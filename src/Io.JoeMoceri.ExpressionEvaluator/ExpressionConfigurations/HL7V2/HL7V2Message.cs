using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Message
    {
        private readonly IList<HL7V2MessageSegment> messageSegments;

        public Exception Error;

        public HL7V2Message()
        {
            messageSegments = new List<HL7V2MessageSegment>();
        }

        /// <summary>
        /// Rebuild the HL7 after making modifications, this updates the Value of each HL7V2FieldBase in this message and the ToString method
        /// </summary>
        public void Rebuild()
        {
            if (messageSegments.Count == 0)
            {
                return;
            }

            for (var i = 0; i < messageSegments.Count; i++)
            {
                messageSegments[i].Rebuild();
            }
        }

        public HL7V2FieldBase Get(string id)
        {
            int GetRepetitionIndex(string input)
            {
                var startIndex = input.IndexOf("(") + 1;
                var endIndex = input.LastIndexOf(")");

                var indexString = input.Substring(startIndex, endIndex - startIndex);

                if (int.TryParse(indexString, out int i))
                {
                    return i;
                }
                else
                {
                    throw new ArgumentException($"Cannot get repetition using index {indexString} for input {input}.");
                }
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            //Get("PID.3.2.1")
            //Get("OBR(2).1") // gets the 2nd OBR repetition's 1st field
	        //Get("GT1.6(2)") // gets the 1st GT1 repetition's 6th field's 2nd repetition

            var split = id.Split('.', StringSplitOptions.RemoveEmptyEntries);

            if (split.Length == 0)
            {
                return null;
            }

            var containsRepetition = split[0].Contains("(");
            var messageSegmentName = containsRepetition ? split[0].Substring(0, split[0].IndexOf("(")) : split[0];
            int? segmentRepetitionIndex = null;

            if (containsRepetition)
            {
                segmentRepetitionIndex = GetRepetitionIndex(split[0]);
            }

            if (split.Length <= 1)
            {
                return null;
            }

            int parsedInt = -1;
            int? fieldIndex = null;
            int? fieldRepetitionIndex = null;
            bool containsFieldRepetition = false;

            containsFieldRepetition = split[1].Contains("(");

            if (containsFieldRepetition)
            {
                fieldRepetitionIndex = GetRepetitionIndex(split[1]);
            }

            if (int.TryParse(containsFieldRepetition ? split[1].Substring(0, split[1].IndexOf("(")) : split[1], out parsedInt))
            {
                fieldIndex = parsedInt;
            }

            int? componentIndex = null;
            if (split.Length > 2)
            {
                if (int.TryParse(split[2], out parsedInt))
                {
                    componentIndex = parsedInt;
                }
            }

            int? subComponentIndex = null;
            if (split.Length > 3)
            {
                if (int.TryParse(split[3], out parsedInt))
                {
                    subComponentIndex = parsedInt;
                }
            }

            var segments = messageSegments.Where(s => s.SegmentName.Equals(messageSegmentName)).ToList();

            if (segments.Count == 0)
            {
                return null;
            }

            var field = segments[segmentRepetitionIndex.HasValue ? segmentRepetitionIndex.Value - 1 : 0].GetField(fieldIndex.Value);

            // optional fields
            if (field == null)
            {
                return null;
            }

            HL7V2FieldBase result = field;

            var repetition = containsFieldRepetition ? fieldRepetitionIndex.Value : 1;

            if (containsFieldRepetition)
            {
                result = field.GetFieldRepetition(fieldRepetitionIndex.Value);
            }

            var components = field.Components(repetition);

            if (components != null && components.Count > 0 && componentIndex.HasValue && componentIndex.Value <= components.Count)
            {
                var component = components[componentIndex.Value - 1];

                if (component.SubComponents != null && component.SubComponents.Count > 0 && subComponentIndex.HasValue && subComponentIndex.Value <= component.SubComponents.Count)
                {
                    return component.SubComponents[subComponentIndex.Value - 1];
                }
                else
                {
                    return component;
                }
            }

            return result;
        }

        public HL7V2MessageSegment this[string segmentName, int index = 0]
        {
            get
            {
                var result = messageSegments.Where(s => s.SegmentName.Equals(segmentName)).ToList()[index];
                return result;
            }
        }

        public IList<HL7V2MessageSegment> Segments(string segmentName)
        {
            return messageSegments.Where(s => s.SegmentName.Equals(segmentName)).ToList();
        }

        public IList<HL7V2MessageSegment> MessageSegments => messageSegments;

        public IList<string> ToHL7V2MessageFile()
        {
            var result = new List<string>();

            for (var i = 0; i < messageSegments.Count; i++)
            {
                result.Add(messageSegments[i].ToString());
            }

            return result;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, ToHL7V2MessageFile()).Trim();
        }

        #region Message Segment Operations
        public HL7V2MessageSegment AddMessageSegment(string segmentName)
        {
            var result = new HL7V2MessageSegment
            {
                SegmentName = segmentName,
            };

            messageSegments.Add(result);

            return result;
        }

        public bool RemoveMessageSegment(string segmentName, int index = 0)
        {
            var fr = messageSegments.Where(f => f.SegmentName.Equals(segmentName)).ToList();

            if (fr.Count == 0 || index < 0 || index > fr.Count)
            {
                return false;
            }

            return messageSegments.Remove(fr[index]);
        }

        public HL7V2MessageSegment InsertMessageSegment(string segmentName, int index = 0)
        {
            if (index > messageSegments.Count || index < 0)
            {
                return null;
            }

            var messageSegment = new HL7V2MessageSegment
            {
                SegmentName = segmentName,
            };

            messageSegments.Insert(index, messageSegment);

            return messageSegment;
        }
        #endregion

        public override bool Equals(object x)
        {
            if (x == null)
            {
                return false;
            }

            if (x.GetType() != this.GetType())
            {
                return false;
            }

            var compareTo = (HL7V2Message)x;
            return AreMessagesTheSame(this, compareTo);

            bool AreMessagesTheSame(HL7V2Message message1, HL7V2Message message2)
            {
                if (message1.ToString() != message2.ToString())
                {
                    return false;
                }

                for (var i = 0; i < message1.MessageSegments.Count; i++)
                {
                    var m1Segment = message1.MessageSegments[i];
                    var m2Segment = message2.MessageSegments[i];

                    if (m1Segment.ToString() != m2Segment.ToString())
                    {
                        return false;
                    }

                    if (m1Segment.SegmentName != m2Segment.SegmentName)
                    {
                        return false;
                    }

                    if (message1.MessageSegments.Count != message2.MessageSegments.Count)
                    {
                        return false;
                    }

                    for (var j = 0; j < m1Segment.Fields.Count; j++)
                    {
                        var m1Field = m1Segment.Fields[j];
                        var m2Field = m2Segment.Fields[j];

                        if (m1Field.Id != m2Field.Id)
                        {
                            return false;
                        }

                        if (m1Field.Value != m2Field.Value)
                        {
                            return false;
                        }

                        if (m1Field.FieldRepetitions.Count != m2Field.FieldRepetitions.Count)
                        {
                            return false;
                        }

                        if (m1Field.FieldRepetitions.Count > 0)
                        {
                            if (m1Field.Components().Count != m2Field.Components().Count)
                            {
                                return false;
                            }
                        }

                        for (var k = 0; k < m1Field.FieldRepetitions.Count; k++)
                        {
                            var m1FieldRepetition = m1Field.FieldRepetitions[k];
                            var m2FieldRepetition = m2Field.FieldRepetitions[k];

                            if (m1FieldRepetition.Id != m2FieldRepetition.Id)
                            {
                                return false;
                            }

                            if (m1FieldRepetition.Value != m2FieldRepetition.Value)
                            {
                                return false;
                            }

                            if (m1FieldRepetition.Components.Count != m2FieldRepetition.Components.Count)
                            {
                                return false;
                            }

                            if (m1FieldRepetition.Delimiter != m2FieldRepetition.Delimiter)
                            {
                                return false;
                            }

                            for (var a = 0; a < m1FieldRepetition.Components.Count; a++)
                            {
                                var m1Component = m1FieldRepetition.Components[a];
                                var m2Component = m2FieldRepetition.Components[a];

                                if (m1Component.Id != m2Component.Id)
                                {
                                    return false;
                                }

                                if (m1Component.Value != m2Component.Value)
                                {
                                    return false;
                                }

                                if (m1Component.SubComponents.Count != m2Component.SubComponents.Count)
                                {
                                    return false;
                                }

                                if (m1Component.Delimiter != m2Component.Delimiter)
                                {
                                    return false;
                                }

                                for (var b = 0; b < m1Component.SubComponents.Count; b++)
                                {
                                    var m1subComponent = m1Component.SubComponents[b];
                                    var m2subComponent = m2Component.SubComponents[b];

                                    if (m1subComponent.Id != m2subComponent.Id)
                                    {
                                        return false;
                                    }

                                    if (m1subComponent.Value != m2subComponent.Value)
                                    {
                                        return false;
                                    }

                                    if (m1subComponent.Delimiter != m2subComponent.Delimiter)
                                    {
                                        return false;
                                    }

                                }
                            }
                        }
                    }
                }

                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ExpressionEvaluatorForDotNet 
{
    /// <summary>
    /// This class refers to HL7V2 Messages defined in V2 specification.
    /// </summary>
    public class HL7V2Message
    {
        /// <summary>
        /// A list of this messages <see cref="HL7V2MessageSegment"/>'s.
        /// </summary>
        private readonly IList<HL7V2MessageSegment> messageSegments;

        /// <summary>
        /// A list of this messages <see cref="HL7V2MessageSegment"/>'s.
        /// </summary>
        public IList<HL7V2MessageSegment> MessageSegments => messageSegments;

        /// <summary>
        /// The error if something failed, otherwise <see cref="null"/>.
        /// </summary>
        public Exception Error;

        /// <summary>
        /// Initializes the <see cref="MessageSegments"/>.
        /// </summary>
        public HL7V2Message()
        {
            messageSegments = new List<HL7V2MessageSegment>();
        }

        /// <summary>
        /// Rebuild the HL7 Message after making modifications, this updates the Value of each <see cref="HL7V2FieldBase"/> in this message and the <see cref="ToString"/> method. Calls each <see cref="MessageSegments"/> <see cref="HL7V2MessageSegment.Rebuild"/> method.
        /// </summary>
        public void Rebuild()
        {
            for (var i = 0; i < messageSegments.Count; i++)
            {
                messageSegments[i].Rebuild();
            }
        }

        /// <summary>
        /// Use this method to Get any kind of 'field' within the message.
        /// Indexes on segments called via Get are 1-based.
        /// Ids on fields are 1-based.
        /// Get("PID.3.2.1") gets the 1st index PID's 3rd field's 2nd component's 1st subcomponent as <see cref="HL7V2FieldBase"/>.
        /// Get("OBR(2).1") // gets the 2nd index OBR's 1st field.
        /// Get("GT1.6(2)") // gets the 1st index GT1's 6th field's 2nd repetition.
        /// </summary>
        /// <param name="id">A string-based id such as MSH.1 to get that field.</param>
        /// <returns><see cref="HL7V2FieldBase"/> if found, otherwise <see cref="null"/>.</returns>
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

        /// <summary>
        /// Get a <see cref="HL7V2MessageSegment"/> by it's <see cref="HL7V2MessageSegment.SegmentName"/> and index, if multiple. Default index is 0.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <param name="index">The index. Default is 0.</param>
        /// <returns><see cref="HL7V2MessageSegment"/>.</returns>
        public HL7V2MessageSegment this[string segmentName, int index = 0]
        {
            get
            {
                var result = messageSegments.Where(s => s.SegmentName.Equals(segmentName)).ToList()[index];
                return result;
            }
        }

        /// <summary>
        /// Gets this messages list of <see cref="HL7V2MessageSegment"/>'s.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <returns><see cref="IList{HL7V2MessageSegment}"/>.</returns>
        public IList<HL7V2MessageSegment> Segments(string segmentName)
        {
            return messageSegments.Where(s => s.SegmentName.Equals(segmentName)).ToList();
        }

        /// <summary>
        /// Converts this message to a <see cref="IList{string}"/> with the segments in order.
        /// </summary>
        /// <returns><see cref="IList{string}"/> as <see cref="HL7V2MessageSegment.ToString"/> using the order of the <see cref="MessageSegments"/>.</returns>
        public IList<string> ToHL7V2MessageFile()
        {
            var result = new List<string>();

            for (var i = 0; i < messageSegments.Count; i++)
            {
                result.Add(messageSegments[i].ToString());
            }

            return result;
        }

        /// <summary>
        /// Converts this message to a string representation, joined by <see cref="Environment.NewLine"/>.
        /// </summary>
        /// <returns><see cref="string"/>.</returns>
        public override string ToString()
        {
            return string.Join(Environment.NewLine, ToHL7V2MessageFile()).Trim();
        }

        /// <summary>
        /// Get's the <see cref="HL7V2MessageSegment"/> in this message.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <returns><see cref="HL7V2MessageSegment"/> if found otherwise <see cref="null"/>.</returns>
        public HL7V2MessageSegment GetMessageSegment(string segmentName)
        {
            return MessageSegments.FirstOrDefault(ms => ms.SegmentName.Equals(segmentName));
        }

        #region Message Segment Operations
        /// <summary>
        /// Adds a <see cref="HL7V2MessageSegment"/> to <see cref="MessageSegments"/>.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <returns><see cref="HL7V2MessageSegment"/> if successful, otherwise <see cref="null"/>.</returns>
        public HL7V2MessageSegment AddMessageSegment(string segmentName)
        {
            var result = new HL7V2MessageSegment
            {
                SegmentName = segmentName,
            };

            messageSegments.Add(result);

            return result;
        }

        /// <summary>
        /// Removes a <see cref="HL7V2MessageSegment"/> from <see cref="MessageSegments"/>.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <param name="index">The index. Default is 0.</param>
        /// <returns><see cref="true"/> if successful, otherwise <see cref="false"/>.</returns>
        public bool RemoveMessageSegment(string segmentName, int index = 0)
        {
            var fr = messageSegments.Where(f => f.SegmentName.Equals(segmentName)).ToList();

            if (fr.Count == 0 || index < 0 || index > fr.Count)
            {
                return false;
            }

            return messageSegments.Remove(fr[index]);
        }

        /// <summary>
        /// Inserts a <see cref="HL7V2MessageSegment"/> into <see cref="MessageSegments"/>.
        /// </summary>
        /// <param name="segmentName">The <see cref="HL7V2MessageSegment.SegmentName"/>.</param>
        /// <param name="index">The index. Default is 0.</param>
        /// <returns><see cref="HL7V2MessageSegment"/> if successful, otherwise <see cref="null"/>.</returns>
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

        /// <summary>
        /// Compare two <see cref="HL7V2Message"/>'s.
        /// </summary>
        /// <param name="otherMessage">The other <see cref="HL7V2Message"/> to compare against.</param>
        /// <returns><see cref="true"/> if equal, otherwise <see cref="false"/>.</returns>
        public override bool Equals(object otherMessage)
        {
            if (otherMessage == null)
            {
                return false;
            }

            if (otherMessage.GetType() != this.GetType())
            {
                return false;
            }

            var compareTo = (HL7V2Message)otherMessage;
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

                        if (m1Field.Delimiter != m2Field.Delimiter)
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

        /// <summary>
        /// Gets the hash code using the string for uniqueness.
        /// </summary>
        /// <returns><see cref="int"/>.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = hash * 16777619 ^ ToString().GetHashCode();
                return hash;
            }
        }
    }
}

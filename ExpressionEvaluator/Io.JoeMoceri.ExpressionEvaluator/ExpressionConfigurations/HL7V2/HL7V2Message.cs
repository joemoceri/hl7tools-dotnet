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

            foreach (var messageSegment in messageSegments)
            {
                messageSegment.Rebuild();
            }
        }

        public HL7V2FieldBase Get(string id)
        {
            // ["PID.3.2.1"]
            // TODO:
	        //Get("PID(2).1") // gets the 2nd PID repetition's 1st field
	        //Get("PID.1(2)") // gets the 1st PID repetition's 1st first field's 2nd repetition

            var split = id.Split('.', StringSplitOptions.RemoveEmptyEntries);

            var messageSegmentName = split[0];
            int? fieldIndex = null;
            int? subFieldIndex = null;
            int? subSubFieldIndex = null;

            if (split.Length <= 1)
            {
                return null;
            }

            int parsedInt = -1;

            if (int.TryParse(split[1], out parsedInt))
            {
                fieldIndex = parsedInt;
            }

            if (split.Length > 2)
            {
                if (int.TryParse(split[2], out parsedInt))
                {
                    subFieldIndex = parsedInt;
                }
            }

            if (split.Length > 3)
            {
                if (int.TryParse(split[3], out parsedInt))
                {
                    subSubFieldIndex = parsedInt;
                }
            }

            var segment = messageSegments.FirstOrDefault(s => s.SegmentName.Equals(messageSegmentName));

            if (segment == null)
            {
                return null;
            }

            var field = segment.GetField(fieldIndex.Value);

            var result = field;

            if (field.Components().Count > 0 && subFieldIndex.HasValue && subFieldIndex.Value <= field.Components().Count)
            {
                var component = field.Components()[subFieldIndex.Value - 1];

                if (component.SubComponents.Count > 0 && subSubFieldIndex.HasValue && subSubFieldIndex.Value <= component.SubComponents.Count)
                {
                    return component.SubComponents[subSubFieldIndex.Value - 1];
                }
                else
                {
                    return component;
                }
            }

            return result;
        }

        public HL7V2MessageSegment this[string segmentName]
        {
            get
            {
                var result = messageSegments.FirstOrDefault(s => s.SegmentName.Equals(segmentName));
                return result;
            }
        }

        public IList<HL7V2MessageSegment> Segments(string segmentName)
        {
            return messageSegments.Where(s => s.SegmentName.Equals(segmentName)).ToList();
        }

        public IList<HL7V2MessageSegment> MessageSegments => messageSegments;

        public IList<string> ToHL7File()
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
            return string.Join(Environment.NewLine, ToHL7File());
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
            var fr = messageSegments.Where(f => f.SegmentName.Equals(segmentName)).ToList()[index];

            if (fr == null)
            {
                return false;
            }

            return messageSegments.Remove(fr);
        }

        public HL7V2MessageSegment InsertMessageSegment(string segmentName, int index = 0)
        {
            if (index >= messageSegments.Count || index <= 0)
            {
                return null;
            }

            var messageSegment = new HL7V2MessageSegment
            {
                SegmentName = segmentName,
            };

            var pFr = messageSegments.Where(fr => fr.SegmentName.Equals(segmentName)).ToList()[index];

            if (pFr == null)
            {
                return null;
            }

            var previousIndex = messageSegments.IndexOf(pFr);

            messageSegments.Insert(previousIndex, messageSegment);

            return messageSegment;
        }

        public HL7V2MessageSegment UpdateMessageSegment(string segmentName, int index = 0)
        {
            if (index >= messageSegments.Count || index <= 0)
            {
                return null;
            }

            var messageSegment = messageSegments.Where(f => f.SegmentName.Equals(segmentName)).ToList()[index];

            if (messageSegment == null)
            {
                return null;
            }

            messageSegment.SegmentName = segmentName;

            return messageSegment;
        }
        #endregion
    }
}

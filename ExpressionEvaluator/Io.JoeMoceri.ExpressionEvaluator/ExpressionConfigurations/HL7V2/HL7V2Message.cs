using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Message
    {
        private readonly IList<HL7V2MessageSegment> messageSegments;

        public HL7V2Message()
        {
            messageSegments = new List<HL7V2MessageSegment>();
        }

        public IHL7V2Field Get(string id)
        {
            // ["PID.3.2.1"]
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

            IHL7V2Field result = field;

            if (field.Components.Count > 0 && subFieldIndex.HasValue && subFieldIndex.Value <= field.Components.Count)
            {
                var component = field.Components[subFieldIndex.Value - 1];
                result = component;

                if (component.SubComponents.Count > 0 && subSubFieldIndex.HasValue && subSubFieldIndex.Value <= component.SubComponents.Count)
                {
                    result = component.SubComponents[subSubFieldIndex.Value - 1];
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

        public IList<HL7V2MessageSegment> MessageSegments => messageSegments;
    }
}

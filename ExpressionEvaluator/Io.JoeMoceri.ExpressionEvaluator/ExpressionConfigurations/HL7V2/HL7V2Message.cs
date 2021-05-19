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

        public HL7V2Field GetField(string id)
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

            var result = segment.GetField(fieldIndex.Value);

            if (result.Fields != null && subFieldIndex.HasValue && subFieldIndex.Value < result.Fields.Count())
            {
                result = result.GetField(subFieldIndex.Value);
            }

            if (result.Fields != null && subSubFieldIndex.HasValue && subSubFieldIndex.Value < result.Fields.Count())
            {
                result = result.GetField(subSubFieldIndex.Value);
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

using System;
using System.Collections.Generic;
using System.Linq;
 
namespace Io.JoeMoceri.ExpressionEvaluator
{
    public class HL7V2Message : List<IHL7V2MessageSegment>, IHL7V2Message
    {
        private readonly IList<IHL7V2MessageSegment> messageSegments;

        public HL7V2Message()
        {
            messageSegments = new List<IHL7V2MessageSegment>();
        }

        public IHL7V2Field GetField(string id)
        {
            // ["PID.3.2.1"]
            var split = id.Split('.', StringSplitOptions.RemoveEmptyEntries);

            var messageSegmentName = split[0];
            int? fieldIndex = null;
            int? subFieldIndex = null;
            int? subSubFieldIndex = null;

            if (split.Length <= 1)
            {
                throw new ArgumentException("Must contain at least one level of depth, such as PID.1", nameof(id));
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

            IHL7V2Field result = this[messageSegmentName][fieldIndex.Value];

            if (subFieldIndex.HasValue && subFieldIndex.Value < result.Fields.Count())
            {
                result = result[subFieldIndex.Value];
            }

            if (subSubFieldIndex.HasValue && subSubFieldIndex.Value < result.Fields.Count())
            {
                result = result[subSubFieldIndex.Value];
            }

            return result;
        }

        public IHL7V2MessageSegment this[string segmentName]
        {
            get
            {
                var result = messageSegments.FirstOrDefault(s => s.SegmentName.Equals(segmentName));
                return result;
            }
        }

        public IList<IHL7V2MessageSegment> MessageSegments => messageSegments;
    }
}

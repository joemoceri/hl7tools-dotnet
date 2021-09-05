using System;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Segment
    {
        public HL7V2Message message { get; init; }

        public IList<HL7V24FieldData> fieldData { get; init; }

        public string Id { get; init; }

        public string SegmentId { get; init; }

        public HL7V24Segment(HL7V2Message message, string id, string segmentId, IList<HL7V24FieldData> fieldData)
        {
            this.message = message;
            this.Id = id;
            this.SegmentId = segmentId;
            this.fieldData = fieldData;
        }

        public HL7V2ValidationResult Validate()
        {
            var issues = new Dictionary<string, string>();
            Exception error = null;

            try
            {

            }
            catch (Exception e)
            {
                error = e;
            }

            return new HL7V2ValidationResult
            {
                Issues = issues,
                Error = error
            };
        }
    }
}

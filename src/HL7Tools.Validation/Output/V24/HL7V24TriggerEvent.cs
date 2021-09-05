using System;
using System.Collections.Generic;

namespace HL7Tools
{
    public class HL7V24TriggerEvent
    {
        public HL7V2Message message { get; init; }

        public IList<HL7V24SegmentData> segmentData { get; init; }

        public string Id { get; init; }

        public string MessageStructureId { get; init; }

        public HL7V24TriggerEvent(HL7V2Message message, string id, string messageStructureId, IList<HL7V24SegmentData> segmentData)
        {
            this.message = message;
            this.Id = id;
            this.MessageStructureId = messageStructureId;
            this.segmentData = segmentData;
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

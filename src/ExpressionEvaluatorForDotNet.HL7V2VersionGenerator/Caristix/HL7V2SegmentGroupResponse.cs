using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class HL7V2SegmentGroupResponse
    {
        public string Name { get; set; }

        public List<SegmentResponse> Segments { get; set; }

        public List<HL7V2SegmentGroupResponse> SegmentGroups { get; set; }
    }
}

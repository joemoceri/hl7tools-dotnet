using System.Collections.Generic;

namespace HL7Tools.Validation
{
    public class HL7V2SegmentGroupResponse
    {
        public string Name { get; set; }

        public List<SegmentResponse> Segments { get; set; }

        public List<HL7V2SegmentGroupResponse> SegmentGroups { get; set; }
    }
}

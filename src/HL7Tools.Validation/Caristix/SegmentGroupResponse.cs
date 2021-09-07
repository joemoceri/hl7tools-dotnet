using Newtonsoft.Json;
using System.Collections.Generic;

namespace HL7Tools.Validation
{
    public class SegmentGroupResponse
    {
        public List<SegmentResponse> Segments { get; set; }

        public List<SegmentGroupResponse> SegmentGroups { get; set; }

        public string Name { get; set; }

        public string Usage { get; set; }

        public string Rpt { get; set; }
    }
}

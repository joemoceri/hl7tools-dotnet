using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator.Caristix
{
    public class SegmentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("segmentId")]
        public string SegmentId { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("chapters")]
        public IList<string> Chapters { get; set; }

        [JsonProperty("fields")]
        public IList<FieldResponse> Fields { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class TriggerEventSegmentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longName")]
        public string LongName { get; set; }

        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("rpt")]
        public string Rpt { get; set; }

        [JsonProperty("isGroup")]
        public bool IsGroup { get; set; }

        [JsonProperty("segments")]
        public IList<TriggerEventSegmentResponse> Segments { get; set; }
    }
}

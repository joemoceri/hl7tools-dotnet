using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HL7Tools.HL7V2VersionGenerator
{
    public class TableResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tableId")]
        public string TableId { get; set; }

        [JsonProperty("tableType")]
        public string TableType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chapters")]
        public IList<string> Chapters { get; set; }

        [JsonProperty("entries")]
        public IList<TableEntryResponse> Entries { get; set; }
    }
}

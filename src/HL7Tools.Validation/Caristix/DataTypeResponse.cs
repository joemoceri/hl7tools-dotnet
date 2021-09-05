using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HL7Tools.HL7V2VersionGenerator
{
    public class DataTypeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("dataTypeName")]
        public string DataTypeName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("rpt")]
        public string Rpt { get; set; }

        [JsonProperty("tableId")]
        public string TableId { get; set; }

        [JsonProperty("tableName")]
        public string TableName { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("fields")]
        public IList<FieldResponse> Fields { get; set; }
    }
}
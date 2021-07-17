using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class CaristixService
    {
        private readonly IRestClient restClient;
        private readonly string baseUrl;

        public CaristixService()
        {
            baseUrl = "https://hl7-definition.caristix.com/v2-api/1/HL7v";
            restClient = new RestClient();
        }

        public IEnumerable<string> GetVersions()
        {
            return new List<string>
            {
                "2.1",
                "2.2",
                "2.3",
                "2.3.1",
                "2.4",
                "2.5",
                "2.5.1",
                "2.6",
                "2.7",
                "2.7.1",
                "2.8",
            };
        }

        public JArray GetTriggerEvents(string version)
        {
            var request = new RestRequest($"{baseUrl}{version}/TriggerEvents", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<JArray>(response.Data.Trim('"'));

            return result;
        }

        public JArray GetSegments(string version)
        {
            var request = new RestRequest($"{baseUrl}{version}/Segments", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<JArray>(response.Data.Trim('"'));

            return result;
        }

        public JArray GetDataTypes(string version)
        {
            var request = new RestRequest($"{baseUrl}{version}/DataTypes", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<JArray>(response.Data.Trim('"'));

            return result;
        }

        public JArray GetTables(string version)
        {
            var request = new RestRequest($"{baseUrl}{version}/Tables", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<JArray>(response.Data.Trim('"'));

            return result;
        }
    }
}

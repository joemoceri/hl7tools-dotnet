using ExpressionEvaluatorForDotNet.HL7V2VersionGenerator.Caristix;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class CaristixService
    {
        private readonly IRestClient restClient;
        private readonly string baseUrl;
        private readonly bool testMode;
        private readonly string basePath;

        public CaristixService(bool testMode = false)
        {
            basePath = Directory.GetParent(Environment.NewLine).Parent.Parent.Parent.FullName;
            this.testMode = testMode;
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

        public IList<TriggerEventResponse> GetTriggerEvents(string version)
        {
            var result = new List<TriggerEventResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "TestData", version, "TriggerEvents");
                foreach (var file in Directory.GetFiles(path))
                {
                    var triggerEvent = JsonConvert.DeserializeObject<TriggerEventResponse>(File.ReadAllText(file));
                    result.Add(triggerEvent);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/TriggerEvents", Method.GET);

            var response = restClient.Execute<string>(request);

            var ids = JsonConvert.DeserializeObject<IList<TriggerEventResponse>>(response.Data.Trim('"')).Select(t => t.Id);

            foreach (var id in ids)
            {
                var triggerEvent = GetTriggerEvent(version, id);
                result.Add(triggerEvent);
            }

            return result;
        }

        public IList<SegmentResponse> GetSegments(string version)
        {
            var result = new List<SegmentResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "TestData", version, "Segments");
                foreach (var file in Directory.GetFiles(path))
                {
                    var segment = JsonConvert.DeserializeObject<SegmentResponse>(File.ReadAllText(file));
                    result.Add(segment);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/Segments", Method.GET);

            var response = restClient.Execute<string>(request);

            var ids = JsonConvert.DeserializeObject<IList<SegmentResponse>>(response.Data.Trim('"')).Select(t => t.Id);

            foreach (var id in ids)
            {
                var segment = GetSegment(version, id);
                result.Add(segment);
            }

            return result;
        }

        public IList<DataTypeResponse> GetDataTypes(string version)
        {
            var result = new List<DataTypeResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "TestData", version, "DataTypes");
                foreach (var file in Directory.GetFiles(path))
                {
                    var dataType = JsonConvert.DeserializeObject<DataTypeResponse>(File.ReadAllText(file));
                    result.Add(dataType);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/DataTypes", Method.GET);

            var response = restClient.Execute<string>(request);

            var ids = JsonConvert.DeserializeObject<IList<DataTypeResponse>>(response.Data.Trim('"')).Select(t => t.Id);

            foreach (var id in ids)
            {
                var dataType = GetDataType(version, id);
                result.Add(dataType);
            }

            return result;
        }

        public IList<TableResponse> GetTables(string version)
        {
            var result = new List<TableResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "TestData", version, "Tables");
                foreach (var file in Directory.GetFiles(path))
                {
                    var table = JsonConvert.DeserializeObject<TableResponse>(File.ReadAllText(file));
                    result.Add(table);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/Tables", Method.GET);

            var response = restClient.Execute<string>(request);

            var ids = JsonConvert.DeserializeObject<IList<TableResponse>>(response.Data.Trim('"')).Select(t => t.Id);

            foreach (var id in ids)
            {
                var table = GetTable(version, id);
                result.Add(table);
            }

            return result;
        }

        public TriggerEventResponse GetTriggerEvent(string version, string triggerEventId)
        {
            var request = new RestRequest($"{baseUrl}{version}/TriggerEvents/{triggerEventId}", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<TriggerEventResponse>(response.Data.Trim('"'));

            return result;
        }

        public SegmentResponse GetSegment(string version, string segmentId)
        {
            var request = new RestRequest($"{baseUrl}{version}/Segments/{segmentId}", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<SegmentResponse>(response.Data.Trim('"'));

            return result;
        }

        public DataTypeResponse GetDataType(string version, string dataTypeId)
        {
            var request = new RestRequest($"{baseUrl}{version}/DataTypes/{dataTypeId}", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<DataTypeResponse>(response.Data.Trim('"'));

            return result;
        }

        public TableResponse GetTable(string version, string tableId)
        {
            var request = new RestRequest($"{baseUrl}{version}/Tables/{tableId}", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<TableResponse>(response.Data.Trim('"'));

            return result;
        }

        public FieldResponse GetField(string version, string fieldId)
        {
            var request = new RestRequest($"{baseUrl}{version}/Fields/{fieldId}", Method.GET);

            var response = restClient.Execute<string>(request);

            var result = JsonConvert.DeserializeObject<FieldResponse>(response.Data.Trim('"'));

            return result;
        }
    }
}

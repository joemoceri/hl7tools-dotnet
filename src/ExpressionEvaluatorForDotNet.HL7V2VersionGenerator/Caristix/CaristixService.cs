using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

        private IRestResponse<T> Retry<T>(RestRequest request)
        {
            IRestResponse<T> result = null;
            var current = 0;
            var max = 5000;

            while (result == null)
            {
                result = restClient.Execute<T>(request);

                if (result.StatusCode == 0)
                {
                    current = Math.Min(current + 1000, max);
                    Thread.Sleep(current);
                    result = null;
                }
                else
                {
                    return result;
                }

            }

            return result;
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

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var ids = JsonConvert.DeserializeObject<IList<TriggerEventResponse>>(response.Data.Trim('"')).Where(te => te.Id != null).Select(t => t.Id).ToList();

            for (var i = 0; i < ids.Count(); i++)
            {
                var triggerEvent = GetTriggerEvent(version, ids[i]);

                var segmentIds = triggerEvent.Segments.Where(s => s.Id != null).Select(s => s.Id).ToList();

                triggerEvent.Segments.Clear();

                for (var j = 0; j < segmentIds.Count(); j++)
                {
                    triggerEvent.Segments.Add(GetSegment(version, segmentIds[j]));
                }

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

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var ids = JsonConvert.DeserializeObject<IList<SegmentResponse>>(response.Data.Trim('"')).Where(s => s.Id != null).Select(t => t.Id).ToList();

            Parallel.ForEach(ids, (id) =>
            {
                var segment = GetSegment(version, id);
                result.Add(segment);
            });

            return result;
        }

        public IList<DataTypeResponse> GetDataTypes(string version)
        {
            var result = new List<DataTypeResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "Caristix", "LocalData", version, "DataTypes");
                foreach (var file in Directory.GetFiles(path))
                {
                    var dataType = JsonConvert.DeserializeObject<DataTypeResponse>(File.ReadAllText(file));
                    result.Add(dataType);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/DataTypes", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var ids = JsonConvert.DeserializeObject<IList<DataTypeResponse>>(response.Data.Trim('"')).Where(dt => dt.Id != null).Select(t => t.Id).ToList();

            for (var i = 0; i < ids.Count(); i++)
            {
                var dataType = GetDataType(version, ids[i]);
                result.Add(dataType);
            }

            return result;
        }

        public IList<TableResponse> GetTables(string version)
        {
            var result = new List<TableResponse>();

            if (testMode)
            {
                var path = Path.Combine(basePath, "Caristix", "LocalData", version, "Tables");
                foreach (var file in Directory.GetFiles(path))
                {
                    var table = JsonConvert.DeserializeObject<TableResponse>(File.ReadAllText(file));
                    result.Add(table);
                }

                return result;
            }

            var request = new RestRequest($"{baseUrl}{version}/Tables", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var ids = JsonConvert.DeserializeObject<IList<TableResponse>>(response.Data.Trim('"')).Where(t => t.Id != null).Select(t => t.Id).ToList();

            for (var i = 0; i < ids.Count(); i++)
            {
                var table = GetTable(version, ids[i]);
                result.Add(table);
            }

            return result;
        }

        public TriggerEventResponse GetTriggerEvent(string version, string triggerEventId)
        {
            Console.WriteLine($"({version})-Getting trigger event {triggerEventId}");

            var request = new RestRequest($"{baseUrl}{version}/TriggerEvents/{triggerEventId}", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var result = JsonConvert.DeserializeObject<TriggerEventResponse>(response.Data.Trim('"'));

            return result;
        }

        public SegmentResponse GetSegment(string version, string segmentId, bool overrideTestMode = false)
        {
            Console.WriteLine($"({version})-Getting segment {segmentId}");
            
            if (overrideTestMode)
            {
                var path = Path.Combine(basePath, "Caristix", "LocalData", version, "Segments", $"V{version.Replace(".", string.Empty)}Segment{segmentId}.json");
                return JsonConvert.DeserializeObject<SegmentResponse>(File.ReadAllText(path));
            }

            var request = new RestRequest($"{baseUrl}{version}/Segments/{segmentId}", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var result = JsonConvert.DeserializeObject<SegmentResponse>(response.Data.Trim('"'));

            var fieldIds = result.Fields.Where(f => f.Id != null).Select(f => f.Id).ToList();

            result.Fields.Clear();

            for (var i = 0; i < fieldIds.Count(); i++)
            {
                result.Fields.Add(GetField(version, fieldIds[i]));
            }

            return result;
        }

        public DataTypeResponse GetDataType(string version, string dataTypeId)
        {
            var request = new RestRequest($"{baseUrl}{version}/DataTypes/{dataTypeId}", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var result = JsonConvert.DeserializeObject<DataTypeResponse>(response.Data.Trim('"'));

            return result;
        }

        public TableResponse GetTable(string version, string tableId)
        {
            var request = new RestRequest($"{baseUrl}{version}/Tables/{tableId}", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var result = JsonConvert.DeserializeObject<TableResponse>(response.Data.Trim('"'));

            return result;
        }

        public FieldResponse GetField(string version, string fieldId)
        {
            var request = new RestRequest($"{baseUrl}{version}/Fields/{fieldId}", Method.GET);

            var response = restClient.Execute<string>(request);

            if (response.StatusCode == 0)
            {
                response = Retry<string>(request);
            }

            var result = JsonConvert.DeserializeObject<FieldResponse>(response.Data.Trim('"'));

            // don't iterate over subcomponents
            if (result.Type.Equals("SubComponent"))
            {
                return result;
            }

            var fieldIds = result.Fields.Where(f => f.Id != null).Select(f => f.Id).ToList();

            result.Fields.Clear();

            for (var i = 0; i < fieldIds.Count(); i++)
            {
                result.Fields.Add(GetField(version, fieldIds[i]));
            }

            return result;
        }
    }
}

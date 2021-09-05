using HL7Tools.Validation.Caristix;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HL7Tools.Validation
{
    public interface ICaristixService
    {
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V21TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V22TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V23TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V231TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V24TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V25TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V251TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V26TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V27TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V271TriggerEvent triggerEvent);
        HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V28TriggerEvent triggerEvent);
    }

    public class CaristixService : ICaristixService
    {
        private readonly IRestClient restClient;
        private readonly string baseUrl;
        private readonly bool useLocalData;
        private readonly string basePath;

        public CaristixService() : this(false)
        {

        }

        public CaristixService(bool useLocalData)
        {
            basePath = Directory.GetParent(Environment.NewLine).Parent.Parent.Parent.FullName;
            this.useLocalData = useLocalData;
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

            if (useLocalData)
            {
                var path = Path.Combine(basePath, "Caristix", "LocalData", version, "TriggerEvents");
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

            // get every trigger event id
            var triggerEvents = JsonConvert.DeserializeObject<IList<TriggerEventResponse>>(response.Data.Trim('"'));
            
            var ids = triggerEvents.Select(te => te.Id).ToList();

            result.AddRange(GetAllTriggerEvents(version, ids));

            return result;
        }

        public IList<TriggerEventResponse> GetAllTriggerEvents(string version, IList<string> ids)
        {
            var result = new List<TriggerEventResponse>();
            for (var i = 0; i < ids.Count(); i++)
            {
                // get the trigger event
                var triggerEvent = GetTriggerEvent(version, ids[i]);

                triggerEvent.Segments = new List<SegmentResponse>();
                triggerEvent.SegmentGroups = new List<HL7V2SegmentGroupResponse>();

                for (var j = 0; j < triggerEvent.TriggerEventSegments.Count(); j++)
                {
                    var tes = triggerEvent.TriggerEventSegments[j];

                    if (tes.IsGroup)
                    {
                        var segmentGroup = new HL7V2SegmentGroupResponse
                        {
                            Name = tes.Name,
                            Segments = new List<SegmentResponse>(),
                            SegmentGroups = new List<HL7V2SegmentGroupResponse>()
                        };

                        segmentGroup.Segments.AddRange(GetSegments(version, triggerEvent, segmentGroup, tes));

                        triggerEvent.SegmentGroups.Add(segmentGroup);
                    }
                    else
                    {
                        triggerEvent.Segments.Add(GetSegment(version, tes.Id, true));
                    }

                }

                result.Add(triggerEvent);
            }

            return result;

            IList<SegmentResponse> GetSegments(string version, TriggerEventResponse triggerEvent, HL7V2SegmentGroupResponse segmentGroup, TriggerEventSegmentResponse tes)
            {
                var result = new List<SegmentResponse>();
                
                // go over each segment of the group
                for (var i = 0; i < tes.Segments.Count; i++)
                {
                    var newTes = tes.Segments[i];
                    if (newTes.IsGroup)
                    {
                        var sg = new HL7V2SegmentGroupResponse
                        {
                            Name = newTes.Name,
                            Segments = new List<SegmentResponse>(),
                            SegmentGroups = new List<HL7V2SegmentGroupResponse>()
                        };

                        sg.Segments.AddRange(GetSegments(version, triggerEvent, sg, newTes));

                        segmentGroup.SegmentGroups.Add(sg);
                    }
                    else
                    {
                        segmentGroup.Segments.Add(GetSegment(version, newTes.Id, true));
                    }
                }

                return result;
            }
        }

        public IList<SegmentResponse> GetSegments(string version)
        {
            var result = new List<SegmentResponse>();

            if (useLocalData)
            {
                var path = Path.Combine(basePath, "Caristix", "LocalData", version, "Segments");
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

            if (useLocalData)
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

            if (useLocalData)
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

        public SegmentResponse GetSegment(string version, string segmentId)
        {
            return GetSegment(version, segmentId, false);
        }

        public SegmentResponse GetSegment(string version, string segmentId, bool overrideTestMode)
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

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V21TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult 
            { 
                Issues = new Dictionary<string, string>() 
            };

            try
            {
                var te = GetTriggerEvent("21", triggerEvent.ToString());

                var tes = te.TriggerEventSegments;

                // TODO: Validate by each property
                for (var i = 0; i < tes.Count; i++)
                {
                    var t = tes[i];

                    var rpt = t.Rpt;

                    var usage = t.Usage;

                    var id = t.Id;

                    var sequence = t.Sequence;

                    var segments = t.Segments;
                }
            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V22TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V23TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V231TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V24TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V25TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V251TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V26TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V27TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V271TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }

        public HL7V2ValidationResult ValidateTriggerEvent(HL7V2Message message, HL7V28TriggerEvent triggerEvent)
        {
            var result = new HL7V2ValidationResult
            {
                Issues = new Dictionary<string, string>()
            };

            try
            {

            }
            catch (Exception ex)
            {
                result.Error = ex;
            }

            return result;
        }
    }
}

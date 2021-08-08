using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class App
    {
        public void Run()
        {
            var caristixService = new CaristixService(true);

            // TODO: Pull data from caristix api, create folders, create .cs files for everything
            var basePath = Directory.GetParent(Environment.NewLine).Parent.Parent.Parent.FullName;
            var versionsBasePath = Path.Combine(basePath, "Output");

            // versions
            var versions = caristixService.GetVersions();

            CreateOutputDirectory(versionsBasePath, versions);

            //return;

            foreach (var version in versions)
            {
                var v = version.Replace(".", string.Empty);

                //CreateTestData(version);

                // tables
                //var tables = caristixService.GetTables(version);

                //foreach (var table in tables)
                //{
                //    var v = version.Replace(".", string.Empty);
                //    var tableTokens = GetTableTokens(v, table);
                //    var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2Table.template.cs.txt"));

                //    foreach (var token in tableTokens)
                //    {
                //        template = template.Replace(token.Key, token.Value);
                //    }

                //    File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", "Tables", $"HL7V{v}Table{table.Id}.cs"), template);
                //}

                //// data types
                //var dataTypes = caristixService.GetDataTypes(version);

                //foreach (var dataType in dataTypes)
                //{
                //    var v = version.Replace(".", string.Empty);
                //    var dataTypeTokens = GetDataTypeTokens(v, dataType);
                //    var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2DataType.template.cs.txt"));

                //    foreach (var token in dataTypeTokens)
                //    {
                //        template = template.Replace(token.Key, token.Value);
                //    }

                //    File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", "DataTypes", $"HL7V{v}DataType{dataType.Id}.cs"), template);
                //}


                //// fields
                //var fieldTemplate = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2Field.template.cs.txt"));

                //fieldTemplate = fieldTemplate.Replace("[{-VERSION-}]", v);

                //File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", $"HL7V{v}Field.cs"), fieldTemplate);

                //// field repetitions
                //var fieldRepetitionTemplate = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2FieldRepetition.template.cs.txt"));

                //fieldRepetitionTemplate = fieldRepetitionTemplate.Replace("[{-VERSION-}]", v);

                //File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", $"HL7V{v}FieldRepetition.cs"), fieldRepetitionTemplate);

                //// components
                //var componentTemplate = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2Component.template.cs.txt"));

                //componentTemplate = componentTemplate.Replace("[{-VERSION-}]", v);

                //File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", $"HL7V{v}Component.cs"), componentTemplate);

                //// sub components
                //var subComponentTemplate = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2SubComponent.template.cs.txt"));

                //subComponentTemplate = subComponentTemplate.Replace("[{-VERSION-}]", v);

                //File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", $"HL7V{v}SubComponent.cs"), subComponentTemplate);

                // segments
                var segments = caristixService.GetSegments(version);

                foreach (var segment in segments)
                {
                    var segmentTokens = GetSegmentTokens(v, segment);
                    var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2Segment.template.cs.txt"));

                    foreach (var token in segmentTokens)
                    {
                        template = template.Replace(token.Key, token.Value);
                    }

                    File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", "Segments", $"HL7V{v}Segment{segment.Id}.cs"), template);
                }

                //// trigger events
                //var triggerEvents = caristixService.GetTriggerEvents(version);

                //foreach (var triggerEvent in triggerEvents)
                //{
                //    var triggerEventTokens = GetTriggerEventTokens(v, triggerEvent);
                //    var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2TriggerEvent.template.cs.txt"));

                //    foreach (var token in triggerEventTokens)
                //    {
                //        template = template.Replace(token.Key, token.Value);
                //    }

                //    File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", "TriggerEvents", $"HL7V{v}TriggerEvent{triggerEvent.Id}.cs"), template);
                //}
            }

            Dictionary<string, string> GetTriggerEventTokens(string version, TriggerEventResponse triggerEvent)
            {
                var result = new Dictionary<string, string>();

                result.Add("[{-VERSION-}]", version);
                result.Add("[{-TRIGGER_EVENT_CLASS_NAME-}]", triggerEvent.Id);
                result.Add("[{-ID-}]", WrapInQuotesOrNull(triggerEvent.Id));
                result.Add("[{-MESSAGE_STRUCTURE_ID-}]", WrapInQuotesOrNull(triggerEvent.MessageStructureId));
                result.Add("[{-EVENT_DESCRIPTION-}]", WrapInQuotesOrNull(triggerEvent.EventDescription));
                result.Add("[{-SAMPLE-}]", WrapInQuotesOrNull(triggerEvent.Sample));
                result.Add("[{-SEGMENT_PROPERTIES-}]", GetSegmentProperties());
                result.Add("[{-SEGMENT_INITIALIZERS-}]", GetSegmentInitializers());

                string chapters = null;

                if (triggerEvent.Chapters != null && triggerEvent.Chapters.Count > 0)
                {
                    var chaptersStrings = string.Empty;
                    for (var i = 0; i < triggerEvent.Chapters.Count; i++)
                    {
                        chaptersStrings += $"\"{triggerEvent.Chapters[i]}\",{Environment.NewLine}";
                    }

                    chaptersStrings = chaptersStrings.Trim();

                    chapters = @$"new[]
                    {{
                        {chaptersStrings}
                    }}";
                }

                result.Add("[{-CHAPTERS-}]", WrapInQuotesOrNull(chapters, true));

                return result;

                string GetSegmentProperties()
                {
                    var result = string.Empty;

                    for (var i = 0; i < triggerEvent.Segments.Count; i++)
                    {
                        var id = triggerEvent.Segments[i].Id;
                        var template = $"public readonly HL7V{version}Segment{id} {id.ToLower()};{Environment.NewLine}";
                        result += template;
                    }

                    return result;
                }

                string GetSegmentInitializers()
                {
                    var result = string.Empty;

                    for (var i = 0; i < triggerEvent.Segments.Count; i++)
                    {
                        var id = triggerEvent.Segments[i].Id;
                        var template = $"this.{id.ToLower()} = new HL7V{version}Segment{id}(this.message);{Environment.NewLine}";
                        result += template;
                    }

                    return result;
                }
            }

            Dictionary<string, string> GetSegmentTokens(string version, SegmentResponse segment)
            {
                var result = new Dictionary<string, string>();

                result.Add("[{-VERSION-}]", version);
                result.Add("[{-SEGMENT_ID_CLASS_NAME-}]", segment.Id);
                result.Add("[{-ID-}]", WrapInQuotesOrNull(segment.Id));
                result.Add("[{-SEGMENT_ID-}]", WrapInQuotesOrNull(segment.SegmentId));
                result.Add("[{-LONG_NAME-}]", WrapInQuotesOrNull(segment.LongName));
                result.Add("[{-DESCRIPTION-}]", WrapInQuotesOrNull(segment.Description));
                result.Add("[{-SAMPLE-}]", WrapInQuotesOrNull(segment.Sample));

                // fieldDatas
                string fieldDatasStrings = null;
                if (segment.Fields != null && segment.Fields.Count > 0)
                {
                    for (var i = 0; i < segment.Fields.Count; i++)
                    {
                        var field = segment.Fields[i];

                        fieldDatasStrings += CreateFieldData(field);
                    }

                    fieldDatasStrings = fieldDatasStrings.Trim();
                }

                if (fieldDatasStrings != null)
                {
                    fieldDatasStrings = @$"new[]
                        {{
                            {fieldDatasStrings}
                        }}";
                }

                result.Add("[{-FIELD_DATAS-}]", WrapInQuotesOrNull(fieldDatasStrings, true));

                // chapters
                string chapters = null;
                if (segment.Chapters != null && segment.Chapters.Count > 0)
                {
                    var chaptersStrings = string.Empty;
                    for (var i = 0; i < segment.Chapters.Count; i++)
                    {
                        chaptersStrings += $"\"{segment.Chapters[i]}\",{Environment.NewLine}";
                    }

                    chaptersStrings = chaptersStrings.Trim();

                    chapters = @$"new[]
                    {{
                        {chaptersStrings}
                    }}";
                }

                result.Add("[{-CHAPTERS-}]", WrapInQuotesOrNull(chapters, true));

                string fields = null;

                if (segment.Fields != null && segment.Fields.Count > 0)
                {
                    for (var i = 0; i < segment.Fields.Count; i++)
                    {
                        var field = segment.Fields[i];

                        fields += CreateSegmentField(version, segment.Id, field);
                    }
                }

                result.Add("[{-FIELDS-}]", WrapInQuotesOrNull(fields, true));

                return result;
            }

            Dictionary<string, string> GetDataTypeTokens(string version, DataTypeResponse dataType)
            {
                var result = new Dictionary<string, string>();

                // tokens
                result.Add("[{-VERSION-}]", version);
                result.Add("[{-DATA_TYPE_ID_CLASS_NAME-}]", dataType.Id);
                result.Add("[{-ID-}]", WrapInQuotesOrNull(dataType.Id));
                result.Add("[{-TYPE-}]", WrapInQuotesOrNull(dataType.Type));
                result.Add("[{-NAME-}]", WrapInQuotesOrNull(dataType.Name));
                result.Add("[{-DESCRIPTION-}]", WrapInQuotesOrNull(dataType.Description));
                result.Add("[{-DATA_TYPE-}]", WrapInQuotesOrNull(dataType.DataType));
                result.Add("[{-DATA_TYPE_NAME-}]", WrapInQuotesOrNull(dataType.DataTypeName));
                result.Add("[{-LENGTH-}]", dataType.Length.ToString());
                result.Add("[{-USAGE-}]", WrapInQuotesOrNull(dataType.Usage));
                result.Add("[{-RPT-}]", WrapInQuotesOrNull(dataType.Rpt));
                result.Add("[{-TABLE_ID-}]", WrapInQuotesOrNull(dataType.TableId));
                result.Add("[{-TABLE_NAME-}]", WrapInQuotesOrNull(dataType.TableName));
                result.Add("[{-SAMPLE-}]", WrapInQuotesOrNull(dataType.Sample));

                // fields
                string fieldsStrings = null;
                if (dataType.Fields != null && dataType.Fields.Count > 0)
                {
                    for (var i = 0; i < dataType.Fields.Count; i++)
                    {
                        var field = dataType.Fields[i];

                        fieldsStrings += CreateFieldData(field);
                    }

                    fieldsStrings = fieldsStrings.Trim();
                }

                if (fieldsStrings != null)
                {
                    fieldsStrings = @$"new[]
                        {{
                            {fieldsStrings}
                        }}";
                }

                result.Add("[{-FIELDS-}]", WrapInQuotesOrNull(fieldsStrings, true));

                return result;
            }

            Dictionary<string, string> GetTableTokens(string version, TableResponse table)
            {
                var result = new Dictionary<string, string>();

                result.Add("[{-VERSION-}]", version);
                result.Add("[{-TABLE_ID-}]", WrapInQuotesOrNull(table.TableId));
                result.Add("[{-TABLE_ID_CLASS_NAME-}]", table.TableId);
                result.Add("[{-ID-}]", WrapInQuotesOrNull(table.Id));
                result.Add("[{-TABLE_TYPE-}]", WrapInQuotesOrNull(table.TableType));
                result.Add("[{-NAME-}]", WrapInQuotesOrNull(table.Name));

                string chapters = null;
                string entries = null;

                if (table.Chapters != null && table.Chapters.Count > 0)
                {
                    var chaptersStrings = string.Empty;
                    for (var i = 0; i < table.Chapters.Count; i++)
                    {
                        chaptersStrings += $"\"{table.Chapters[i]}\",{Environment.NewLine}";
                    }

                    chaptersStrings = chaptersStrings.Trim();

                    chapters = @$"new[]
                    {{
                        {chaptersStrings}
                    }}";
                }

                result.Add("[{-CHAPTERS-}]", WrapInQuotesOrNull(chapters, true));
                
                if (table.Entries != null && table.Entries.Count > 0)
                {
                    var entriesStrings = string.Empty;
                    for (var i = 0; i < table.Entries.Count; i++)
                    {
                        var value = WrapInQuotesOrNull(table.Entries[i].Value);
                        var description = WrapInQuotesOrNull(table.Entries[i].Description);
                        var comment = WrapInQuotesOrNull(table.Entries[i].Comment);

                        entriesStrings += @$"new HL7V2TableEntry
                        {{
                            Value = {value},
                            Description = {description},
                            Comment = {comment}
                        }},{Environment.NewLine}                        ";
                    }

                    entriesStrings = entriesStrings.Trim();

                    entries = @$"new[]
                    {{
                        {entriesStrings}
                    }}";
                }

                result.Add("[{-ENTRIES-}]", WrapInQuotesOrNull(entries, true));

                return result;
            }

            void CreateTestData(string version)
            {
                var localDataPath = Path.Combine(basePath, "Caristix", "LocalData");

                // Tables
                var tables = caristixService.GetTables(version);

                foreach (var table in tables)
                {
                    Directory.CreateDirectory(Path.Combine(localDataPath, version, "Tables"));

                    var path = Path.Combine(localDataPath, version, "Tables", $"V{version.Replace(".", string.Empty)}Table{table.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(table));
                }

                // Data Types
                var dataTypes = caristixService.GetDataTypes(version);

                foreach (var dataType in dataTypes)
                {
                    Directory.CreateDirectory(Path.Combine(localDataPath, version, "DataTypes"));

                    var path = Path.Combine(localDataPath, version, "DataTypes", $"V{version.Replace(".", string.Empty)}DataType{dataType.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(dataType));
                }

                // Segments
                var segments = caristixService.GetSegments(version);

                foreach (var segment in segments)
                {
                    Directory.CreateDirectory(Path.Combine(localDataPath, version, "Segments"));

                    var path = Path.Combine(localDataPath, version, "Segments", $"V{version.Replace(".", string.Empty)}Segment{segment.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(segment));
                }

                // Trigger Events
                var triggerEvents = caristixService.GetTriggerEvents(version);

                foreach (var triggerEvent in triggerEvents)
                {
                    Directory.CreateDirectory(Path.Combine(localDataPath, version, "TriggerEvents"));

                    var path = Path.Combine(localDataPath, version, "TriggerEvents", $"V{version.Replace(".", string.Empty)}TriggerEvent{triggerEvent.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(triggerEvent));
                }
            }

            string WrapInQuotesOrNull(string input, bool notAString = false)
            {
                if (notAString)
                {
                    return input != null ? input : WrapInQuotesOrNull(null);
                }

                return input == null ? "null" : $@"@""{input.Replace("\"", "\"\"")}""";
            }

            string CreateSegmentField(string version, string segmentId, FieldResponse field)
            {
                var v = version.Replace(".", string.Empty);
                var segmentFieldTokens = GetSegmentFieldTokens(v, segmentId, field);
                var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2FieldProperty.template.cs.txt"));

                foreach (var token in segmentFieldTokens)
                {
                    template = template.Replace(token.Key, token.Value);
                }

                return $"{template}{Environment.NewLine}";

                Dictionary<string, string> GetSegmentFieldTokens(string version, string segmentId, FieldResponse field)
                {
                    var result = new Dictionary<string, string>();

                    result.Add("[{-VERSION-}]", version);

                    var lower = char.ToLower(field.Name[0]) + field.Name.Substring(1);

                    result.Add("[{-FIELD_NAME_PROPERTY_NAME_LOWER-}]", ConvertToPropertyString(lower));
                    result.Add("[{-FIELD_NAME_PROPERTY_NAME-}]", ConvertToPropertyString(field.Name));
                    result.Add("[{-SEGMENT_ID-}]", WrapInQuotesOrNull(segmentId));
                    result.Add("[{-FIELD_PROPERTY_ID-}]", WrapInQuotesOrNull(field.Id.Split(".")[1], true));
                    result.Add("[{-ID-}]", WrapInQuotesOrNull(field.Id));
                    result.Add("[{-TYPE-}]", WrapInQuotesOrNull(field.Type));
                    result.Add("[{-POSITION-}]", WrapInQuotesOrNull(field.Position));
                    result.Add("[{-NAME-}]", WrapInQuotesOrNull(field.Name));
                    result.Add("[{-LENGTH-}]", WrapInQuotesOrNull(field.Length.ToString(), true));
                    result.Add("[{-USAGE-}]", WrapInQuotesOrNull(field.Usage));
                    result.Add("[{-RPT-}]", WrapInQuotesOrNull(field.Rpt));
                    result.Add("[{-DATA_TYPE-}]", WrapInQuotesOrNull(field.DataType));
                    result.Add("[{-DATA_TYPE_NAME-}]", WrapInQuotesOrNull(field.DataTypeName));
                    result.Add("[{-TABLE_ID-}]", WrapInQuotesOrNull(field.TableId));
                    result.Add("[{-TABLE_NAME-}]", WrapInQuotesOrNull(field.TableName));
                    result.Add("[{-DESCRIPTION-}]", WrapInQuotesOrNull(field.Description));
                    result.Add("[{-SAMPLE-}]", WrapInQuotesOrNull(field.Sample));

                    return result;
                }
            }

            string CreateFieldData(FieldResponse field)
            {
                string fieldDatas = null;
                if (field.Fields != null && field.Fields.Count > 0)
                {
                    fieldDatas = string.Empty;
                    for (var i = 0; i < field.Fields.Count; i++)
                    {
                        fieldDatas += CreateFieldData(field.Fields[i]);
                    }
                }

                var result = @$"
                        new HL7V2FieldData
                        {{
                            Id = {WrapInQuotesOrNull(field.Id)},
                            Type = {WrapInQuotesOrNull(field.Type)},
                            Position = {WrapInQuotesOrNull(field.Position)},
                            Name = {WrapInQuotesOrNull(field.Name)},
                            Length = {field.Length},
                            Usage = {WrapInQuotesOrNull(field.Usage)},
                            Rpt = {WrapInQuotesOrNull(field.Rpt)},
                            DataType = {WrapInQuotesOrNull(field.DataType)},
                            DataTypeName = {WrapInQuotesOrNull(field.DataTypeName)},
                            TableId = {WrapInQuotesOrNull(field.TableId)},
                            TableName = {WrapInQuotesOrNull(field.TableName)},
                            Description = {WrapInQuotesOrNull(field.Description)},
                            Sample = {WrapInQuotesOrNull(field.Sample)},
                            FieldDatas = {(fieldDatas != null ? $"new []{{" : null)}{WrapInQuotesOrNull(fieldDatas, true)}{(fieldDatas != null ? $"}}" : null)}
                        }},{Environment.NewLine}                        ";

                return result;
            }

            string ConvertToPropertyString(string input)
            {
                var chars = new[] { " ", "-", "/", "&", ".", "'", "(", ")" };

                foreach (var ch in chars)
                {
                    input = input.Replace(ch, ch.Equals("&") ? "And" : string.Empty);
                }

                return input;
            }
        }

        private void CreateOutputDirectory(string versionsBasePath, IEnumerable<string> versions)
        {
            Directory.CreateDirectory(versionsBasePath);

            foreach (var version in versions)
            {
                Directory.CreateDirectory(Path.Combine(versionsBasePath, $"V{version.Replace(".", string.Empty)}", "Tables"));

                Directory.CreateDirectory(Path.Combine(versionsBasePath, $"V{version.Replace(".", string.Empty)}", "DataTypes"));

                Directory.CreateDirectory(Path.Combine(versionsBasePath, $"V{version.Replace(".", string.Empty)}", "Segments"));

                Directory.CreateDirectory(Path.Combine(versionsBasePath, $"V{version.Replace(".", string.Empty)}", "TriggerEvents"));
            }
        }
    }
}

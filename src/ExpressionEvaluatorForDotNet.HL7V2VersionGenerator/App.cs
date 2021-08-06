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
                //CreateTestData(version);

                //var segments = caristixService.GetSegments(version);
                //var triggerEvents = caristixService.GetTriggerEvents(version);

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

                // segments
                var segments = caristixService.GetSegments(version);

                foreach (var segment in segments)
                {
                    var v = version.Replace(".", string.Empty);
                    var segmentTokens = GetSegmentTokens(v, segment);
                    var template = File.ReadAllText(Path.Combine(basePath, "Templates", "HL7V2Segment.template.cs.txt"));

                    foreach (var token in segmentTokens)
                    {
                        template = template.Replace(token.Key, token.Value);
                    }

                    File.WriteAllText(Path.Combine(basePath, "Output", $"V{v}", "Segments", $"HL7V{v}Segment{segment.Id}.cs"), template);
                }
            }

            Dictionary<string, string> GetSegmentTokens(string version, SegmentResponse segment)
            {
                var result = new Dictionary<string, string>();

                result.Add("[{-VERSION-}]", version);
                result.Add("[{-SEGMENT_ID_CLASS_NAME-}]", segment.Id);
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

                // TODO: fields

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

            string CreateFieldData(FieldResponse field)
            {
                string fieldDatas = string.Empty;
                if (field.Fields != null && field.Fields.Count > 0)
                {
                    for (var i = 0; i < field.Fields.Count; i++)
                    {
                        fieldDatas += CreateFieldData(field.Fields[i]);
                    }
                }
                else
                {
                    fieldDatas = null;
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
                            FieldDatas = {WrapInQuotesOrNull(fieldDatas, true)}
                        }},{Environment.NewLine}                        ";

                return result;
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

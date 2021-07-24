using Newtonsoft.Json;
using System;
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
            var versionsBasePath = Path.Combine(basePath, "Versions");

            Directory.CreateDirectory(versionsBasePath);

            // versions
            var versions = caristixService.GetVersions();
            foreach (var version in versions)
            {
                //CreateTestData(version);

                var segments = caristixService.GetSegments(version);
                var dataTypes = caristixService.GetDataTypes(version);
                var tables = caristixService.GetTables(version);
                var triggerEvents = caristixService.GetTriggerEvents(version);

            }

            void CreateTestData(string version)
            {
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version));

                // Tables
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version, "Tables"));
                var tables = caristixService.GetTables(version);

                foreach (var table in tables)
                {
                    Directory.CreateDirectory(Path.Combine(basePath, "TestData", version, "Tables"));

                    var path = Path.Combine(basePath, "TestData", version, "Tables", $"V{version.Replace(".", string.Empty)}Table{table.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(table));
                }

                // Data Types
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version, "DataTypes"));
                var dataTypes = caristixService.GetDataTypes(version);

                foreach (var dataType in dataTypes)
                {
                    Directory.CreateDirectory(Path.Combine(basePath, "TestData", version, "DataTypes"));

                    var path = Path.Combine(basePath, "TestData", version, "DataTypes", $"V{version.Replace(".", string.Empty)}DataType{dataType.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(dataType));
                }

                // Segments
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version, "Segments"));
                var segments = caristixService.GetSegments(version);

                foreach (var segment in segments)
                {
                    Directory.CreateDirectory(Path.Combine(basePath, "TestData", version, "Segments"));

                    var path = Path.Combine(basePath, "TestData", version, "Segments", $"V{version.Replace(".", string.Empty)}Segment{segment.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(segment));
                }

                // Trigger Events
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version, "TriggerEvents"));
                var triggerEvents = caristixService.GetTriggerEvents(version);

                foreach (var triggerEvent in triggerEvents)
                {
                    Directory.CreateDirectory(Path.Combine(basePath, "TestData", version, "TriggerEvents"));

                    var path = Path.Combine(basePath, "TestData", version, "TriggerEvents", $"V{version.Replace(".", string.Empty)}TriggerEvent{triggerEvent.Id}.json");

                    File.WriteAllText(path, JsonConvert.SerializeObject(triggerEvent));
                }
            }
        }
    }
}

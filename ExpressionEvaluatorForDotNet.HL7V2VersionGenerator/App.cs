using System;
using System.IO;

namespace ExpressionEvaluatorForDotNet.HL7V2VersionGenerator
{
    public class App
    {
        public void Run()
        {
            var caristixService = new CaristixService();

            // TODO: Pull data from caristix api, create folders, create .cs files for everything
            var basePath = Directory.GetParent(Environment.NewLine).Parent.Parent.Parent.FullName;
            var versionsBasePath = Path.Combine(basePath, "Versions");

            Directory.CreateDirectory(versionsBasePath);

            // versions
            var versions = caristixService.GetVersions();
            foreach (var version in versions)
            {
                Directory.CreateDirectory(Path.Combine(versionsBasePath, version));
                //var triggerEvents = caristixService.GetTriggerEvents(version);
            }
        }
    }
}

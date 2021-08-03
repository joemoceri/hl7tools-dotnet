using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0367
    {
        public string Id { get { return @"0367"; } }

        public string TableId { get { return @"0367"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Alert level"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Critical",
                            Comment = @"Shut Down, Fix Problem and Re-init"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Normal",
                            Comment = @"No Corrective Action Needed"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Serious",
                            Comment = @"Corrective Action Required"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Warning",
                            Comment = @"Corrective Action Anticipated"
                        },
                    };
            } 
        }
    }
}

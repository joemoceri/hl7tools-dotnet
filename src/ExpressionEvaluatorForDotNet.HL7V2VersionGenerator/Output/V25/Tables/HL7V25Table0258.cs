using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0258
    {
        public string Id { get { return @"0258"; } }

        public string TableId { get { return @"0258"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Relationship modifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"BPU",
                            Description = @"Blood product unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CONTROL",
                            Description = @"Control",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DONOR",
                            Description = @"Donor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PATIENT",
                            Description = @"Patient",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

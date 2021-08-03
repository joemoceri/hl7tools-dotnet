using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0778
    {
        public string Id { get { return @"0778"; } }

        public string TableId { get { return @"0778"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Item Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"EQP",
                            Description = @"Equipment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IMP",
                            Description = @"Implant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MED",
                            Description = @"Medication",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUP",
                            Description = @"Supply",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TDC",
                            Description = @"Tubes, Drains, and Catheters",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

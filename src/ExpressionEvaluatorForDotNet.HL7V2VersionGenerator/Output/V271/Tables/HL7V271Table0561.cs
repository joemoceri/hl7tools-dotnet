using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0561
    {
        public string Id { get { return @"0561"; } }

        public string TableId { get { return @"0561"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Product/Services Clarification Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"CLCTR",
                            Description = @"Claim Center",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DGAPP",
                            Description = @"Diagnostic Approval Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DTCTR",
                            Description = @"Data Center Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENC",
                            Description = @"Encounter Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GFTH",
                            Description = @"Good Faith Indicator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OOP",
                            Description = @"Out of Province Indicator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SEQ",
                            Description = @"Sequence Number",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

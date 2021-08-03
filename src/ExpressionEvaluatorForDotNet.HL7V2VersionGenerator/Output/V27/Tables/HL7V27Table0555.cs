using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0555
    {
        public string Id { get { return @"0555"; } }

        public string TableId { get { return @"0555"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Invoice Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"BK",
                            Description = @"Block",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FN",
                            Description = @"Final",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FS",
                            Description = @"Fee for Service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GP",
                            Description = @"Group",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Information Only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Non Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Partial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"Salary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"By Session",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Supplemental",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

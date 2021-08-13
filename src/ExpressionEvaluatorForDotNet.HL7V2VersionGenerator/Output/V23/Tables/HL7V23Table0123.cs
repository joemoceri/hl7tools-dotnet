using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0123
    {
        public string Id { get { return @"0123"; } }

        public string TableId { get { return @"0123"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Result status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Value = @"A",
                            Description = @"Some, but not all results available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Correction to results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Final results; results stored and verified. Can only be changed with a corrected result.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"No results available; specimen received  procedure incomplete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Order received; specimen not yet received",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preliminary: A verified early result is available  final results not yet obtained",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Results stored; not yet verified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"No results available; procedure scheduled  but not done",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X",
                            Description = @"No results available; Order canceled.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"No order on record for this test. (Used only on queries)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Z",
                            Description = @"No record of this patient. (Used only on queries)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0529
    {
        public string Id { get { return @"0529"; } }

        public string TableId { get { return @"0529"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Precision"; } }

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
                            Value = @"D",
                            Description = @"day",
                            Comment = @"Retained for backward compatibility only"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"hour",
                            Comment = @"Retained for backward compatibility only"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"month",
                            Comment = @"Retained for backward compatibility only"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"minute",
                            Comment = @"Retained for backward compatibility only"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"second",
                            Comment = @"Retained for backward compatibility only"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"year",
                            Comment = @"Retained for backward compatibility only"
                        },
                    };
            } 
        }
    }
}

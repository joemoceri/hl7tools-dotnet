using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0353
    {
        public string Id { get { return @"0353"; } }

        public string TableId { get { return @"0353"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"CWE statuses"; } }

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
                            Value = @"NA",
                            Description = @"Not applicable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NASK",
                            Description = @"Not asked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAV",
                            Description = @"Not available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UASK",
                            Description = @"Asked but Unknown",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

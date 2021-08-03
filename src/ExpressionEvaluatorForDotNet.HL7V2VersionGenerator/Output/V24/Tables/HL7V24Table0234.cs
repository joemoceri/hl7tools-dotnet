using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0234
    {
        public string Id { get { return @"0234"; } }

        public string TableId { get { return @"0234"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Report timing"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"10D",
                            Description = @"10 day report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15D",
                            Description = @"15 day report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30D",
                            Description = @"30 day report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3D",
                            Description = @"3 day report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7D",
                            Description = @"7 day report",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AD",
                            Description = @"Additional information",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CO",
                            Description = @"Correction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Device evaluation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PD",
                            Description = @"Periodic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQ",
                            Description = @"Requested information",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

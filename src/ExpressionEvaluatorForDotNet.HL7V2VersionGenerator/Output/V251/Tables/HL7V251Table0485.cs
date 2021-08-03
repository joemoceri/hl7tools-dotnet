using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0485
    {
        public string Id { get { return @"0485"; } }

        public string TableId { get { return @"0485"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Extended Priority Codes"; } }

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
                            Description = @"ASAP",
                            Comment = @"Fill after S orders"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Callback",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preop",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"As needed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Routine",
                            Comment = @"Default"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat",
                            Comment = @"With highest priority"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Timing critical",
                            Comment = @"A request implying that it is critical to come as close as possible to the requested time, e.g., for a trough anti-microbial level."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TD<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> days."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TH<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> hours."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TL<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> months."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TM<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> minutes."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> seconds."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TW<integer>",
                            Description = null,
                            Comment = @"Timing critical within <integer> weeks."
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0485
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
                            Value = @"A",
                            Description = @"ASAP",
                            Comment = null
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
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Timing critical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TD<integer>",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TH<integer>",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TL<integer>",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TM<integer>",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TS<integer>",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TW<integer>",
                            Description = null,
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

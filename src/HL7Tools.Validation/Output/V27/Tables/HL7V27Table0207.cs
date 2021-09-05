using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0207
    {
        public string Id { get { return @"0207"; } }

        public string TableId { get { return @"0207"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Processing Mode"; } }

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
                            Description = @"Archive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Initial load",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Not present",
                            Description = @"Not present (the default, meaning current  processing)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Restore from archive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Current processing, transmitted at intervals (scheduled or on demand)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

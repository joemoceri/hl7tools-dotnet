using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0207
    {
        public string Id { get { return @"0207"; } }

        public string TableId { get { return @"0207"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Processing mode"; } }

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
                            Value = @"",
                            Description = @"Not present (the default, meaning current  processing)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"a",
                            Description = @"Archive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"i",
                            Description = @"Initial load",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"r",
                            Description = @"Restore from archive",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

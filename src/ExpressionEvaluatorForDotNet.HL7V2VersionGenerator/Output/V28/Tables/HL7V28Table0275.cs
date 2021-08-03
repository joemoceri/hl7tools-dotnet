using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0275
    {
        public string Id { get { return @"0275"; } }

        public string TableId { get { return @"0275"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Document Storage Status"; } }

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
                            Value = @"AA",
                            Description = @"Active and archived",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AC",
                            Description = @"Active",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AR",
                            Description = @"Archived (not active)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PU",
                            Description = @"Purged",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0108
    {
        public string Id { get { return @"0108"; } }

        public string TableId { get { return @"0108"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"QUERY RESULTS LEVEL"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"O",
                            Description = @"Order plus order status",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Status only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Full Results",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

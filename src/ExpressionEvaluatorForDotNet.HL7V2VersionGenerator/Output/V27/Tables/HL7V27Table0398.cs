using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0398
    {
        public string Id { get { return @"0398"; } }

        public string TableId { get { return @"0398"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Continuation Style Code"; } }

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
                            Value = @"F",
                            Description = @"Fragmentation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Interactive Continuation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

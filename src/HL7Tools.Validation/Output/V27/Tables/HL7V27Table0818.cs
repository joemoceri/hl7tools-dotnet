using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0818
    {
        public string Id { get { return @"0818"; } }

        public string TableId { get { return @"0818"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Package"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
                            Value = @"BX",
                            Description = @"Box",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CS",
                            Description = @"Case",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EA",
                            Description = @"Each",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SET",
                            Description = @"Set",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

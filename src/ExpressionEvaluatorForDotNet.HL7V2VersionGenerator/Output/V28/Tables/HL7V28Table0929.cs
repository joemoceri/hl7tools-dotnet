using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0929
    {
        public string Id { get { return @"0929"; } }

        public string TableId { get { return @"0929"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Weight Units"; } }

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
                            Value = @"[lb_av]",
                            Description = @"Pound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"[oz_av]",
                            Description = @"Ounce",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"g",
                            Description = @"Gram",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"kg",
                            Description = @"Kilogram",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

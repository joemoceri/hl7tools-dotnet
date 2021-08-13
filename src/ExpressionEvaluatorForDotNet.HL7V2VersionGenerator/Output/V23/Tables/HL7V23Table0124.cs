using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0124
    {
        public string Id { get { return @"0124"; } }

        public string TableId { get { return @"0124"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Transportation mode"; } }

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
                            Value = @"CART",
                            Description = @"Cart - patient travels on cart or gurney",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PORT",
                            Description = @"The examining device goes to patient’s location",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WALK",
                            Description = @"Patient walks to diagnostic service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WHLC",
                            Description = @"Wheelchair",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

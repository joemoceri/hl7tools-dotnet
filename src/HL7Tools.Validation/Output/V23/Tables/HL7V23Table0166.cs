using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0166
    {
        public string Id { get { return @"0166"; } }

        public string TableId { get { return @"0166"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"RX component type"; } }

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
                            Description = @"Additive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Base",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

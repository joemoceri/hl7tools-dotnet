using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0657
    {
        public string Id { get { return @"0657"; } }

        public string TableId { get { return @"0657"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Device Type"; } }

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
                            Value = @"1",
                            Description = @"EO Gas Sterilizer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Steam Sterilizer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Peracetic Acid",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

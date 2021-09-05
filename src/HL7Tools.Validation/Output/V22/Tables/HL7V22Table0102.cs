using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0102
    {
        public string Id { get { return @"0102"; } }

        public string TableId { get { return @"0102"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DELAYED ACKNOWLEDGMENT TYPE"; } }

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
                            Value = @"D",
                            Description = @"Message Received, stored for later processing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Acknowledgement after processing",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

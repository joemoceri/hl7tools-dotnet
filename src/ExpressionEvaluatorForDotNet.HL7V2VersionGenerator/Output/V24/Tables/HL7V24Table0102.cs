using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0102
    {
        public string Id { get { return @"0102"; } }

        public string TableId { get { return @"0102"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Delayed acknowledgment type"; } }

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
                            Description = @"Message received, stored for later processing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"acknowledgment after processing",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

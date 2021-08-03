using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0682
    {
        public string Id { get { return @"0682"; } }

        public string TableId { get { return @"0682"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Device Status-"; } }

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
                            Value = @"0",
                            Description = @"Ready",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Not Ready",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

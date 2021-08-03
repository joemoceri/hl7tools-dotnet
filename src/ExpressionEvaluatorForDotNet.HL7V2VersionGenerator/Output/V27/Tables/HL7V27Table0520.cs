using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0520
    {
        public string Id { get { return @"0520"; } }

        public string TableId { get { return @"0520"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Message Waiting Priority"; } }

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
                            Value = @"H",
                            Description = @"High",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Low",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Medium",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

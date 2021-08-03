using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0504
    {
        public string Id { get { return @"0504"; } }

        public string TableId { get { return @"0504"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Sequence Condition Code"; } }

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
                            Value = @"EE",
                            Description = @"End related service request(s), end current service request.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ES",
                            Description = @"End related service request(s), start current service request.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SE",
                            Description = @"Start related service request(s), end current service request.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Start related service request(s), start current service request.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

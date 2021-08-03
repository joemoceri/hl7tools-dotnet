using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0445
    {
        public string Id { get { return @"0445"; } }

        public string TableId { get { return @"0445"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Identity Reliability Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"AL",
                            Description = @"Patient/Person Name is an Alias",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UA",
                            Description = @"Unknown/Default Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"Unknown/Default Date of Birth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"US",
                            Description = @"Unknown/Default Social Security Number",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

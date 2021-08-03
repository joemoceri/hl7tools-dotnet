using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0282
    {
        public string Id { get { return @"0282"; } }

        public string TableId { get { return @"0282"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Referral disposition"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
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
                            Value = @"AM",
                            Description = @"Assume Management",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Return Patient After Evaluation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SO",
                            Description = @"Second Opinion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WR",
                            Description = @"Send Written Report",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

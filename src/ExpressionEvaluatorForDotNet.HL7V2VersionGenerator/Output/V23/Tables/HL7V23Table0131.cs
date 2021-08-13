using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0131
    {
        public string Id { get { return @"0131"; } }

        public string TableId { get { return @"0131"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Contact role"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"BP",
                            Description = @"Billing contact person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Contact person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EP",
                            Description = @"Emergency contact person",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Person preparing referral",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

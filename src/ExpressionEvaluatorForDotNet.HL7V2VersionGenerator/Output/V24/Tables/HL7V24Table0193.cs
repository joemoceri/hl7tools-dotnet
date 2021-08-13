using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0193
    {
        public string Id { get { return @"0193"; } }

        public string TableId { get { return @"0193"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Amount class"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"AT",
                            Description = @"Amount",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LM",
                            Description = @"Limit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Percentage",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UL",
                            Description = @"Unlimited",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

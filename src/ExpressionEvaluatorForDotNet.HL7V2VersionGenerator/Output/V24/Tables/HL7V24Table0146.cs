using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0146
    {
        public string Id { get { return @"0146"; } }

        public string TableId { get { return @"0146"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Amount type"; } }

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
                            Value = @"DF",
                            Description = @"Differential",
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
                            Value = @"RT",
                            Description = @"Rate",
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

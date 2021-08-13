using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0271
    {
        public string Id { get { return @"0271"; } }

        public string TableId { get { return @"0271"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Document completion status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Value = @"AU",
                            Description = @"Authenticated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Dictated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DO",
                            Description = @"Documented",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Incomplete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IP",
                            Description = @"In Progress",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LA",
                            Description = @"Legally authenticated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Pre-authenticated",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

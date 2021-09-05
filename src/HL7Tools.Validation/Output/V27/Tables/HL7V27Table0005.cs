using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0005
    {
        public string Id { get { return @"0005"; } }

        public string TableId { get { return @"0005"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Race"; } }

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
                            Value = @"1002-5",
                            Description = @"American Indian or Alaska Native",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2028-9",
                            Description = @"Asian",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2054-5",
                            Description = @"Black or African American",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2076-8",
                            Description = @"Native Hawaiian or Other Pacific Islander",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2106-3",
                            Description = @"White",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2131-1",
                            Description = @"Other Race",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

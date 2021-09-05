using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0267
    {
        public string Id { get { return @"0267"; } }

        public string TableId { get { return @"0267"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Days of the week"; } }

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
                            Value = @"FRI",
                            Description = @"Friday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MON",
                            Description = @"Monday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAT",
                            Description = @"Saturday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUN",
                            Description = @"Sunday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THU",
                            Description = @"Thursday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TUE",
                            Description = @"Tuesday",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WED",
                            Description = @"Wednesday",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0527
    {
        public string Id { get { return @"0527"; } }

        public string TableId { get { return @"0527"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Calendar Alignment"; } }

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
                            Value = @"DM",
                            Description = @"day of the month",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DW",
                            Description = @"day of the week (begins with Monday)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DY",
                            Description = @"day of the year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HD",
                            Description = @"hour of the day",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MY",
                            Description = @"month of the year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NH",
                            Description = @"minute of the hour",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"second of the minute",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WY",
                            Description = @"week of the year",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

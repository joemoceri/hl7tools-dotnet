using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0528
    {
        public string Id { get { return @"0528"; } }

        public string TableId { get { return @"0528"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event related period"; } }

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
                            Value = @"AC",
                            Description = @"before meal (from lat. ante cibus )",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACD",
                            Description = @"before lunch (from lat. ante cibus diurnus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACM",
                            Description = @"before breakfast (from lat. ante cibus matutinus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACV",
                            Description = @"before dinner (from lat. ante cibus vespertinus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HS",
                            Description = @"the hour of sleep (e.g., H18-22)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IC",
                            Description = @"between meals (from lat. inter cibus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD",
                            Description = @"between lunch and dinner",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICM",
                            Description = @"between breakfast and lunch",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICV",
                            Description = @"between dinner and the hour of sleep",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"after meal (from lat. post cibus )",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCD",
                            Description = @"after lunch (from lat. post cibus diurnus )",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCM",
                            Description = @"after breakfast (from lat. post cibus matutinus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCV",
                            Description = @"after dinner (from lat. post cibus vespertinus)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

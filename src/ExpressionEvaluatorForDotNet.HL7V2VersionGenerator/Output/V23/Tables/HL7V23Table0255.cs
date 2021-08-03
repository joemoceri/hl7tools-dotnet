using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0255
    {
        public string Id { get { return @"0255"; } }

        public string TableId { get { return @"0255"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Duration categories"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"*",
                            Description = @"(asterisk) Life of the ""unit.""  Used for blood products.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12H",
                            Description = @"12 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1H",
                            Description = @"1 hour",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1L",
                            Description = @"1 months (30 days)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1W",
                            Description = @"1 week",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2.5H",
                            Description = @"2½ hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24H",
                            Description = @"24 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2D",
                            Description = @"2 days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2H",
                            Description = @"2 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2L",
                            Description = @"2 months",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2W",
                            Description = @"2 weeks",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30M",
                            Description = @"30 minutes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3D",
                            Description = @"3 days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3H",
                            Description = @"3 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3L",
                            Description = @"3 months",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3W",
                            Description = @"3 weeks",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4D",
                            Description = @"4 days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4H",
                            Description = @"4 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4W",
                            Description = @"4 weeks",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5D",
                            Description = @"5 days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5H",
                            Description = @"5 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6D",
                            Description = @"6 days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6H",
                            Description = @"6 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7H",
                            Description = @"7 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8H",
                            Description = @"8 hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"To identify measures at a point in time.  This is a synonym for ""spot"" or ""random"" as applied to urine measurements.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

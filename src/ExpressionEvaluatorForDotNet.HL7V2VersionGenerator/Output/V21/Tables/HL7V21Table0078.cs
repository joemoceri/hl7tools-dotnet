using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0078
    {
        public string Id { get { return @"0078"; } }

        public string TableId { get { return @"0078"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ABNORMAL FLAGS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"<",
                            Description = @"Below absolute low-off instrument scale",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A",
                            Description = @"Abnormal (applies to non-numeric results)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AA",
                            Description = @"Very abnormal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Significant change down",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Above high normal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HH",
                            Description = @"Above upper panic limits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Interval",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LL",
                            Description = @"Below lower panic limits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MS",
                            Description = @"Moderately sensitive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Resists",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Sensitive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Significant change up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VS",
                            Description = @"Very sensitive",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

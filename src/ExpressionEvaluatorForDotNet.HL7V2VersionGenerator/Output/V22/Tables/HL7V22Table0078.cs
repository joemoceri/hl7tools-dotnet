using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0078
    {
        public string Id { get { return @"0078"; } }

        public string TableId { get { return @"0078"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"ABNORMAL FLAGS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"<",
                            Description = @"Below absolute low-off instrument scale",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @">",
                            Description = @"Above absolute high-off instrument scale",
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
                            Description = @"Very abnormal (applies to non-numeric units, analogous to panic limits for numerics limits)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Better (use when direction not relevant)",
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
                            Description = @"Intermediate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Below low normal",
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
                            Value = @"N",
                            Description = @"Normal (applies to non-numeric results)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"null",
                            Description = @"No range defined, or normal ranges don't apply ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Resistant",
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
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Worse (use when direction not relevant)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

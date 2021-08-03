using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0167
    {
        public string Id { get { return @"0167"; } }

        public string TableId { get { return @"0167"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Substitution Status"; } }

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
                            Value = @"0",
                            Description = @"No product selection indicated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Substitution not allowed by prescriber",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Substitution allowed - patient requested product dispensed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Substitution allowed - pharmacist selected product dispensed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Substitution allowed - generic drug not in stock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Substitution allowed - brand drug dispensed as a generic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7",
                            Description = @"Substitution not allowed - brand drug mandated by law",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8",
                            Description = @"Substitution allowed - generic drug not available in marketplace",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"G",
                            Description = @"A generic substitution was dispensed.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No substitute was dispensed.  This is equivalent to the default (null) value.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"A therapeutic substitution was dispensed.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

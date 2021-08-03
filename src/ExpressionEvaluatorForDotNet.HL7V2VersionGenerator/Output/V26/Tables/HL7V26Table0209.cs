using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0209
    {
        public string Id { get { return @"0209"; } }

        public string TableId { get { return @"0209"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Relational operator"; } }

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
                            Value = @"CT",
                            Description = @"Contains",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EQ",
                            Description = @"Equal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GE",
                            Description = @"Greater than or equal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GN",
                            Description = @"Generic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GT",
                            Description = @"Greater than",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LE",
                            Description = @"Less than or equal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LT",
                            Description = @"Less than",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"Not Equal",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

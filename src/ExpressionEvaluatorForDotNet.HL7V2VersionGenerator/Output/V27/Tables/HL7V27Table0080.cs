using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0080
    {
        public string Id { get { return @"0080"; } }

        public string TableId { get { return @"0080"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Nature of Abnormal Testing"; } }

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
                            Value = @"A",
                            Description = @"An age-based population",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Breed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"None - generic normal range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"A race-based population",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"A sex-based population",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SP",
                            Description = @"Species",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ST",
                            Description = @"Strain",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0257
    {
        public string Id { get { return @"0257"; } }

        public string TableId { get { return @"0257"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Nature of challenge"; } }

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
                            Value = @"CFST",
                            Description = @"Fasting (no calorie intake) for the period specified in the time component of the term, e.g., 1H POST CFST",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXCZ",
                            Description = @"Exercise undertaken as challenge (can be quantified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FFST",
                            Description = @"No fluid intake for the period specified in the time component of the term",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

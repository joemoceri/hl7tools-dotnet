using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0452
    {
        public string Id { get { return @"0452"; } }

        public string TableId { get { return @"0452"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Health Care Provider Type Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Value = @"SUGGESTION",
                            Description = @"ANSI ASC X12 Health Care Provider Taxonomy, Level 1 - Type",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

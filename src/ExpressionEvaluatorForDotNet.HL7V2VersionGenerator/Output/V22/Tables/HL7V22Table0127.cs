using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0127
    {
        public string Id { get { return @"0127"; } }

        public string TableId { get { return @"0127"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ALLERGY TYPE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"DA",
                            Description = @"Drug Allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FA",
                            Description = @"Food Allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Miscellaneous Allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Miscellaneous Contraindication",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

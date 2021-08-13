using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0127
    {
        public string Id { get { return @"0127"; } }

        public string TableId { get { return @"0127"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Allergy type"; } }

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
                            Description = @"Drug allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FA",
                            Description = @"Food allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Miscellaneous allergy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Miscellaneous contraindication",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

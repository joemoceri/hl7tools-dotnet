using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0128
    {
        public string Id { get { return @"0128"; } }

        public string TableId { get { return @"0128"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Allergy severity"; } }

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
                            Value = @"MI",
                            Description = @"Mild",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MO",
                            Description = @"Moderate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SV",
                            Description = @"Severe",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

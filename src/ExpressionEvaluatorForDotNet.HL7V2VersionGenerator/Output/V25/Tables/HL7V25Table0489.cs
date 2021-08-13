using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0489
    {
        public string Id { get { return @"0489"; } }

        public string TableId { get { return @"0489"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Risk Codes"; } }

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
                            Value = @"AGG",
                            Description = @"Aggressive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BHZ",
                            Description = @"Biohazard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIO",
                            Description = @"Biological",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COR",
                            Description = @"Corrosive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESC",
                            Description = @"Escape Risk",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Explosive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IFL",
                            Description = @"MaterialDangerInflammable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INF",
                            Description = @"MaterialDangerInfectious",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INJ",
                            Description = @"Injury Hazard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"POI",
                            Description = @"Poison",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAD",
                            Description = @"Radioactive",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0495
    {
        public string Id { get { return @"0495"; } }

        public string TableId { get { return @"0495"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Body Site Modifier"; } }

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
                            Value = @"ANT",
                            Description = @"Anterior",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIL",
                            Description = @"Bilateral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DIS",
                            Description = @"Distal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXT",
                            Description = @"External",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Left",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LAT",
                            Description = @"Lateral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LLQ",
                            Description = @"Quadrant, Left Lower",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LOW",
                            Description = @"Lower",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LUQ",
                            Description = @"Quadrant, Left Upper",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MED",
                            Description = @"Medial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"POS",
                            Description = @"Posterior",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRO",
                            Description = @"Proximal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Right",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLQ",
                            Description = @"Quadrant, Right Lower",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RUQ",
                            Description = @"Quadrant, Right Upper",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPP",
                            Description = @"Upper",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

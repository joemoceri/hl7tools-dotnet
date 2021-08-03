using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0411
    {
        public string Id { get { return @"0411"; } }

        public string TableId { get { return @"0411"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Supplemental service information values"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Value = @"1ST",
                            Description = @"First",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2ND",
                            Description = @"Second",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3RD",
                            Description = @"Third",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4TH",
                            Description = @"Fourth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5TH",
                            Description = @"Fifth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A/P",
                            Description = @"Anterior/Posterior",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANT",
                            Description = @"Anterior",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLT",
                            Description = @"Bilateral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEC",
                            Description = @"Decubitus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DST",
                            Description = @"Distal",
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
                            Value = @"LFT",
                            Description = @"Left",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LLQ",
                            Description = @"Left Lower Quadrant",
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
                            Description = @"Left Upper Quadrant",
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
                            Value = @"OR",
                            Description = @"Operating Room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PED",
                            Description = @"Pediatric",
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
                            Value = @"PRT",
                            Description = @"Portable",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRX",
                            Description = @"Proximal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REC",
                            Description = @"Recumbent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RGH",
                            Description = @"Right",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLQ",
                            Description = @"Right Lower Quadrant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RUQ",
                            Description = @"Right Upper Quadrant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPP",
                            Description = @"Upper",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPR",
                            Description = @"Upright",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WCT",
                            Description = @"With Contrast",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WOC",
                            Description = @"Without Contrast",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WSD",
                            Description = @"With Sedation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

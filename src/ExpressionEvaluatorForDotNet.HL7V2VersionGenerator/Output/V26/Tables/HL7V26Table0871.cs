using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0871
    {
        public string Id { get { return @"0871"; } }

        public string TableId { get { return @"0871"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Supply Risk Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"COR",
                            Description = @"Corrosive",
                            Comment = @"Material is corrosive and may cause severe injury to skin, mucous membranes and eyes. Avoid any unprotected contact."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Explosive",
                            Comment = @"Material is an explosive mixture.  Keep away from fire, sparks, and heat."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FLA",
                            Description = @"Flammable",
                            Comment = @"Material is highly flammable and in certain mixtures (with air) may lead to explosions.  Keep away from fire, sparks and excessive heat."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INJ",
                            Description = @"Injury Hazard",
                            Comment = @"Material is solid and sharp (e.g., cannulas.)  Dispose in hard container."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAD",
                            Description = @"Radioactive",
                            Comment = @"Material is a source for ionizing radiation and must be handled with special care to avoid injury of those who handle it and to avoid environmental hazards."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TOX",
                            Description = @"Toxic",
                            Comment = @"Material is toxic to humans and/or animals.  Special care must be taken to avoid incorporation, even of small amounts."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UNK",
                            Description = @"Unknown",
                            Comment = @"Material hazard level is unknown."
                        },
                    };
            } 
        }
    }
}

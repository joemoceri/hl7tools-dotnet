using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0489
    {
        public string Id { get { return @"0489"; } }

        public string TableId { get { return @"0489"; } }

        public string TableType { get { return @"User"; } }

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
                            Comment = @"A danger that can be associated with certain living subjects, including humans."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BHZ",
                            Description = @"Biohazard",
                            Comment = @"Material contains microorganisms that is an environmental hazard.  Must be handled with special care."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIO",
                            Description = @"Biological",
                            Comment = @"The dangers associated with normal biological materials. I.e. potential risk of unknown infections.  Routine biological materials from living subjects."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COR",
                            Description = @"Corrosive",
                            Comment = @"Material is corrosive and may cause severe injury to skin, mucous membranes and eyes. Avoid any unprotected contact."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESC",
                            Description = @"Escape Risk",
                            Comment = @"The entity is at risk for escaping from containment or control."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Explosive",
                            Comment = @"Material is an explosive mixture.  Keep away from fire, sparks, and heat."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IFL",
                            Description = @"MaterialDangerInflammable",
                            Comment = @"Material is highly inflammable and in certain mixtures (with air) may lead to explosions.  Keep away from fire, sparks and excessive heat."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INF",
                            Description = @"MaterialDangerInfectious",
                            Comment = @"Material known to be infectious with human pathogenic microorganisms.  Those who handle this material must take precautions for their protection."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INJ",
                            Description = @"Injury Hazard",
                            Comment = @"Material is solid and sharp (e.g., cannulas.)  Dispose in hard container."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"POI",
                            Description = @"Poison",
                            Comment = @"Material is poisonous to humans and/or animals.  Special care must be taken to avoid incorporation, even of small amounts."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RAD",
                            Description = @"Radioactive",
                            Comment = @"Material is a source for ionizing radiation and must be handled with special care to avoid injury of those who handle it and to avoid environmental hazards."
                        },
                    };
            } 
        }
    }
}

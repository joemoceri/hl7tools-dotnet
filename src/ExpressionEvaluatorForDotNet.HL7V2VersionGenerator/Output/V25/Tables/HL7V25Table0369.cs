using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0369
    {
        public string Id { get { return @"0369"; } }

        public string TableId { get { return @"0369"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Specimen Role"; } }

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
                            Value = @"B",
                            Description = @"Blind Sample",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Calibrator",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Electronic QC, used with manufactured reference providing signals that simulate QC results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Specimen used for testing proficiency of the organization performing the testing (Filler)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"G",
                            Description = @"Group (where a specimen consists of multiple individual elements that are not individually identified)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Pool (aliquots of individual specimens combined to form a single specimen representing all of the components.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Specimen used for testing Operator Proficiency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Patient (default if blank component value)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q",
                            Description = @"Control specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Replicate (of patient sample as a control)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Verifying Calibrator, used for periodic calibration checks",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

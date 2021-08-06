using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0074
    {
        public string Id { get { return @"0074"; } }

        public string TableId { get { return @"0074"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DIAGNOSTIC SERVICE SECTION ID"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"BG",
                            Description = @"Blood gases",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CH",
                            Description = @"Chemistry",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Cytopathology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CT",
                            Description = @"CAT scan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CUS",
                            Description = @"Cardiac Ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EC",
                            Description = @"Electrocardiac (e.g., EKG, EEC, Holter)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HM",
                            Description = @"Hematology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IMM",
                            Description = @"Immunology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MB",
                            Description = @"Microbiology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCB",
                            Description = @"Mycobacteriology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MYC",
                            Description = @"Mycology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMR",
                            Description = @"Nuclear magnetic resonance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMS",
                            Description = @"Nuclear medicine scan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NRS",
                            Description = @"Nursing service measures",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Occupational Therapy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OUS",
                            Description = @"OB Ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PHR",
                            Description = @"Pharmacy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Physical Therapy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Respiratory Care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RT",
                            Description = @"Radiation Therapy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RUS",
                            Description = @"Radiology ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SP",
                            Description = @"Surgical Pathology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"Serology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Toxicology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VUS",
                            Description = @"Vascular Ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XRC",
                            Description = @"Cineradiography",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
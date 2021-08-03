using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0074
    {
        public string Id { get { return @"0074"; } }

        public string TableId { get { return @"0074"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Diagnostic Service Section ID"; } }

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
                            Value = @"AU",
                            Description = @"Audiology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BG",
                            Description = @"Blood Gases",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLB",
                            Description = @"Blood Bank",
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
                            Description = @"CAT Scan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CTH",
                            Description = @"Cardiac Catheterization",
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
                            Description = @"Electrocardiac (e.g., EKG,  EEC, Holter)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EN",
                            Description = @"Electroneuro (EEG, EMG,EP,PSG)",
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
                            Value = @"ICU",
                            Description = @"Bedside ICU Monitoring",
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
                            Value = @"LAB",
                            Description = @"Laboratory",
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
                            Description = @"Nuclear Magnetic Resonance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NMS",
                            Description = @"Nuclear Medicine Scan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NRS",
                            Description = @"Nursing Service Measures",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OSL",
                            Description = @"Outside Lab",
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
                            Value = @"PF",
                            Description = @"Pulmonary Function",
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
                            Value = @"PHY",
                            Description = @"Physician (Hx. Dx, admission note, etc.)",
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
                            Value = @"RAD",
                            Description = @"Radiology",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Respiratory Care (therapy)",
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
                            Description = @"Radiology Ultrasound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RX",
                            Description = @"Radiograph",
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
                            Value = @"VR",
                            Description = @"Virology",
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
                            Description = @"Cineradiograph",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

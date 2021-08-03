using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0371
    {
        public string Id { get { return @"0371"; } }

        public string TableId { get { return @"0371"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Additive/Preservative"; } }

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
                            Value = @"ACDA",
                            Description = @"ACD Solution A",
                            Comment = @"Yellow top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACDB",
                            Description = @"ACD Solution B",
                            Comment = @"Yellow top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACET",
                            Description = @"Acetic Acid",
                            Comment = @"Urine preservative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMIES",
                            Description = @"Amies transport medium",
                            Comment = @"Protozoa"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BACTM",
                            Description = @"Bacterial Transport medium",
                            Comment = @"Microbiological culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BF10",
                            Description = @"Buffered 10% formalin",
                            Comment = @"Tissue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOR",
                            Description = @"Borate Boric Acid",
                            Comment = @"24HR Urine Additive"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOUIN",
                            Description = @"Bouin's solution",
                            Comment = @"Tissue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BSKM",
                            Description = @"Buffered skim milk",
                            Comment = @"Viral isolation"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C32",
                            Description = @"3.2%  Citrate",
                            Comment = @"Blue top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C38",
                            Description = @"3.8% Citrate",
                            Comment = @"Blue top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CARS",
                            Description = @"Carson's Modified 10% formalin",
                            Comment = @"Tissue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CARY",
                            Description = @"Cary Blair Medium",
                            Comment = @"Stool Cultures"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CHLTM",
                            Description = @"Chlamydia transport medium",
                            Comment = @"Chlamydia culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CTAD",
                            Description = @"CTAD (this should be spelled out if not universally understood)",
                            Comment = @"Blue top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTK",
                            Description = @"Potassium/K EDTA",
                            Comment = @"Deprecated. Replaced by EDTK15 and EDTK75"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTK15",
                            Description = @"Potassium/K EDTA 15%",
                            Comment = @"Purple top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTK75",
                            Description = @"Potassium/K EDTA 7.5%",
                            Comment = @"Purple top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EDTN",
                            Description = @"Sodium/Na EDTA",
                            Comment = @"Dark Blue top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENT",
                            Description = @"Enteric bacteria transport medium",
                            Comment = @"Bacterial culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENT+",
                            Description = @"Enteric plus",
                            Comment = @"Stool Cultures"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F10",
                            Description = @"10% Formalin",
                            Comment = @"Tissue preservative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDP",
                            Description = @"Thrombin NIH; soybean trypsin inhibitor (Fibrin Degradation Products)",
                            Comment = @"Dark Blue top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FL10",
                            Description = @"Sodium Fluoride, 10mg",
                            Comment = @"Urine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FL100",
                            Description = @"Sodium Fluoride, 100mg",
                            Comment = @"Urine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCL6",
                            Description = @"6N HCL",
                            Comment = @"24 HR Urine Additive"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEPA",
                            Description = @"Ammonium heparin",
                            Comment = @"Green top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEPL",
                            Description = @"Lithium/Li  Heparin",
                            Comment = @"Green top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HEPN",
                            Description = @"Sodium/Na  Heparin",
                            Comment = @"Green top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HNO3",
                            Description = @"Nitric Acid",
                            Comment = @"Urine"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JKM",
                            Description = @"Jones Kendrick Medium",
                            Comment = @"Bordetella pertussis"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KARN",
                            Description = @"Karnovsky's fixative",
                            Comment = @"Tissue"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KOX",
                            Description = @"Potassium Oxalate",
                            Comment = @"Gray top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LIA",
                            Description = @"Lithium iodoacetate",
                            Comment = @"Gray top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M4",
                            Description = @"M4",
                            Comment = @"Microbiological culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M4RT",
                            Description = @"M4-RT",
                            Comment = @"Microbiological culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M5",
                            Description = @"M5",
                            Comment = @"Microbiological culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MICHTM",
                            Description = @"Michel's transport medium",
                            Comment = @"IF tests"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MMDTM",
                            Description = @"MMD transport medium",
                            Comment = @"Immunofluorescence"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAF",
                            Description = @"Sodium Fluoride",
                            Comment = @"Gray top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAPS",
                            Description = @"Sodium polyanethol sulfonate 0.35% in 0.85% sodium chloride",
                            Comment = @"Yellow (Blood Culture)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NONE",
                            Description = @"None",
                            Comment = @"Red or Pink top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAGE",
                            Description = @"Pages's Saline",
                            Comment = @"Acanthaoemba"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PHENOL",
                            Description = @"Phenol",
                            Comment = @"24 Hr Urine Additive"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PVA",
                            Description = @"PVA (polyvinylalcohol)",
                            Comment = @"O&P"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RLM",
                            Description = @"Reagan Lowe Medium",
                            Comment = @"Bordetella pertussis cultures"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SILICA",
                            Description = @"Siliceous earth, 12 mg",
                            Comment = @"Gray top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPS",
                            Description = @"SPS(this should be spelled out if not universally understood)",
                            Comment = @"Anticoagulant w/o bacteriocidal properties"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SST",
                            Description = @"Serum Separator Tube (Polymer Gel)",
                            Comment = @"‘Tiger’ Top tube"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STUTM",
                            Description = @"Stuart transport medium",
                            Comment = @"Bacterial culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THROM",
                            Description = @"Thrombin",
                            Comment = @"Orange or Grey/Yellow (STAT Chem)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THYMOL",
                            Description = @"Thymol",
                            Comment = @"24 Hr Urine Additive"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THYO",
                            Description = @"Thyoglycollate broth",
                            Comment = @"Bacterial Isolation"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TOLU",
                            Description = @"Toluene",
                            Comment = @"24 Hr Urine Additive"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URETM",
                            Description = @"Ureaplasma transport medium",
                            Comment = @"Ureaplasma culture"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VIRTM",
                            Description = @"Viral Transport medium",
                            Comment = @"Virus cultures"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WEST",
                            Description = @"Buffered Citrate (Westergren Sedimentation Rate)",
                            Comment = @"Black top tube"
                        },
                    };
            } 
        }
    }
}

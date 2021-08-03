using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0070
    {
        public string Id { get { return @"0070"; } }

        public string TableId { get { return @"0070"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen source codes"; } }

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
                            Value = @"ABS",
                            Description = @"Abscess",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMN",
                            Description = @"Amniotic fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ASP",
                            Description = @"Aspirate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BBL",
                            Description = @"Blood bag",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BDY",
                            Description = @"Whole body",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIFL",
                            Description = @"Bile fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLD",
                            Description = @"Whole blood",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLDA",
                            Description = @"Blood  arterial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLDC",
                            Description = @"Blood  capillary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BLDV",
                            Description = @"Blood  venous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BON",
                            Description = @"Bone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BPH",
                            Description = @"Basophils",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BPU",
                            Description = @"Blood product unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRN",
                            Description = @"Burn",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRO",
                            Description = @"Bronchial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRTH",
                            Description = @"Breath (use EXHLD)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CALC",
                            Description = @"Calculus (=Stone)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CBLD",
                            Description = @"Cord blood",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDM",
                            Description = @"Cardiac muscle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNJT",
                            Description = @"Conjunctiva",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CNL",
                            Description = @"Cannula",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COL",
                            Description = @"Colostrum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSF",
                            Description = @"Cerebral spinal fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CTP",
                            Description = @"Catheter tip",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CUR",
                            Description = @"Curettage",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVM",
                            Description = @"Cervical mucus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVX",
                            Description = @"Cervix",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CYST",
                            Description = @"Cyst",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DIAF",
                            Description = @"Dialysis fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DOSE",
                            Description = @"Dose med or substance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DRN",
                            Description = @"Drain",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DUFL",
                            Description = @"Duodenal fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EAR",
                            Description = @"Ear",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EARW",
                            Description = @"Ear wax (cerumen)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ELT",
                            Description = @"Electrode",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENDC",
                            Description = @"Endocardium",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENDM",
                            Description = @"Endometrium",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EOS",
                            Description = @"Eosinophils",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXHLD",
                            Description = @"Exhaled gas (=breath)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EYE",
                            Description = @"Eye",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FIB",
                            Description = @"Fibroblasts",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FIST",
                            Description = @"Fistula",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FLT",
                            Description = @"Filter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FLU",
                            Description = @"Body fluid, unsp",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GAS",
                            Description = @"Gas",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GAST",
                            Description = @"Gastric fluid/contents",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GEN",
                            Description = @"Genital",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GENC",
                            Description = @"Genital cervix",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GENL",
                            Description = @"Genital lochia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GENV",
                            Description = @"Genital vaginal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HAR",
                            Description = @"Hair",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IHG",
                            Description = @"Inhaled Gas",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISLT",
                            Description = @"Isolate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IT",
                            Description = @"Intubation tube",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LAM",
                            Description = @"Lamella",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LIQ",
                            Description = @"Liquid NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LN",
                            Description = @"Line",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LNA",
                            Description = @"Line arterial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LNV",
                            Description = @"Line venous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LYM",
                            Description = @"Lymphocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MAC",
                            Description = @"Macrophages",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MAR",
                            Description = @"Marrow",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MBLD",
                            Description = @"Menstrual blood",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEC",
                            Description = @"Meconium",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MILK",
                            Description = @"Breast milk",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MLK",
                            Description = @"Milk",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NAIL",
                            Description = @"Nail",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NOS",
                            Description = @"Nose (nasal passage)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORH",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAFL",
                            Description = @"Pancreatic fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAT",
                            Description = @"Patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLAS",
                            Description = @"Plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLB",
                            Description = @"Plasma bag",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLC",
                            Description = @"Placenta",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PLR",
                            Description = @"Pleural fluid (thoracentesis fld)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PMN",
                            Description = @"Polymorphonuclear neutrophils",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPP",
                            Description = @"Platelet poor plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRP",
                            Description = @"Platelet rich plasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRT",
                            Description = @"Peritoneal fluid /ascites",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PUS",
                            Description = @"Pus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RBC",
                            Description = @"Erythrocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RT",
                            Description = @"Route of medicine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAL",
                            Description = @"Saliva",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SEM",
                            Description = @"Seminal fluid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SER",
                            Description = @"Serum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SKM",
                            Description = @"Skeletal muscle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SKN",
                            Description = @"Skin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNV",
                            Description = @"Synovial fluid (Joint fluid)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPRM",
                            Description = @"Spermatozoa",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPT",
                            Description = @"Sputum",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPTC",
                            Description = @"Sputum - coughed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPTT",
                            Description = @"Sputum - tracheal aspirate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STL",
                            Description = @"Stool = Fecal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STON",
                            Description = @"Stone (use CALC)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWT",
                            Description = @"Sweat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TEAR",
                            Description = @"Tears",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THRB",
                            Description = @"Thrombocyte (platelet)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THRT",
                            Description = @"Throat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TISG",
                            Description = @"Tissue gall bladder",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TISPL",
                            Description = @"Tissue placenta",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TISS",
                            Description = @"Tissue",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TISU",
                            Description = @"Tissue ulcer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TLGI",
                            Description = @"Tissue large intestine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TLNG",
                            Description = @"Tissue lung",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TSMI",
                            Description = @"Tissue small intestine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TUB",
                            Description = @"Tube NOS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ULC",
                            Description = @"Ulcer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UMB",
                            Description = @"Umbilical blood",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UMED",
                            Description = @"Unknown medicine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Urine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URC",
                            Description = @"Urine clean catch",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URNS",
                            Description = @"Urine sediment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URT",
                            Description = @"Urine catheter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"URTH",
                            Description = @"Urethra",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USUB",
                            Description = @"Unknown substance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VOM",
                            Description = @"Vomitus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WAT",
                            Description = @"Water",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WBC",
                            Description = @"Leukocytes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WICK",
                            Description = @"Wick",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WND",
                            Description = @"Wound",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WNDA",
                            Description = @"Wound abscess",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WNDD",
                            Description = @"Wound drainage",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WNDE",
                            Description = @"Wound exudate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XXX",
                            Description = @"To be specified in another part of the 422.3.10070message",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

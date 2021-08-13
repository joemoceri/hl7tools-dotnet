using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0488
    {
        public string Id { get { return @"0488"; } }

        public string TableId { get { return @"0488"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen Collection Method"; } }

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
                            Value = @"ANP",
                            Description = @"Plates, Anaerobic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BAP",
                            Description = @"Plates, Blood Agar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BCAE",
                            Description = @"Blood Culture, Aerobic Bottle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BCAN",
                            Description = @"Blood Culture, Anaerobic Bottle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BCPD",
                            Description = @"Blood Culture, Pediatric Bottle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BIO",
                            Description = @"Biopsy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAP",
                            Description = @"Capillary Specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CATH",
                            Description = @"Catheterized",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVP",
                            Description = @"Line, CVP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EPLA",
                            Description = @"Environmental, Plate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESWA",
                            Description = @"Environmental, Swab",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FNA",
                            Description = @"Aspiration, Fine Needle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"KOFFP",
                            Description = @"Plate, Cough",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LNA",
                            Description = @"Line, Arterial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LNV",
                            Description = @"Line, Venous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MARTL",
                            Description = @"Martin-Lewis Agar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ML11",
                            Description = @"Mod. Martin-Lewis Agar",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MLP",
                            Description = @"Plate, Martin-Lewis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NYP",
                            Description = @"Plate, New York City",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PACE",
                            Description = @"Pace, Gen-Probe",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PIN",
                            Description = @"Pinworm Prep",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PNA",
                            Description = @"Aterial puncture",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRIME",
                            Description = @"Pump Prime",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PUMP",
                            Description = @"Pump Specimen",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QC5",
                            Description = @"Quality Control For Micro",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCLP",
                            Description = @"Scalp, Fetal Vein",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCRAPS",
                            Description = @"Scrapings",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SHA",
                            Description = @"Shaving",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWA",
                            Description = @"Swab",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SWD",
                            Description = @"Swab, Dacron tipped",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMAN",
                            Description = @"Transport Media, Anaerobic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMCH",
                            Description = @"Transport Media, Chalamydia",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMM4",
                            Description = @"Transport Media, M4",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMMY",
                            Description = @"Transport Media, Mycoplasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMOT",
                            Description = @"Transport Media,",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMP",
                            Description = @"Plate, Thayer-Martin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMPV",
                            Description = @"Transport Media, PVA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMSC",
                            Description = @"Transport Media, Stool Culture",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMUP",
                            Description = @"Transport Media, Ureaplasma",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TMVI",
                            Description = @"Transport Media, Viral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VENIP",
                            Description = @"Venipuncture",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WOOD",
                            Description = @"Swab, Wooden Shaft",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

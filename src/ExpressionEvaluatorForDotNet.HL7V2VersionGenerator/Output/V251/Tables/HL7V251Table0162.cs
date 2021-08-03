using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0162
    {
        public string Id { get { return @"0162"; } }

        public string TableId { get { return @"0162"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Route of Administration"; } }

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
                            Value = @"AP",
                            Description = @"Apply Externally",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"B",
                            Description = @"Buccal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DT",
                            Description = @"Dental",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EP",
                            Description = @"Epidural",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ET",
                            Description = @"Endotrachial Tube*",
                            Comment = @"used primarily for respiratory therapy and anesthesia delivery"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GTT",
                            Description = @"Gastrostomy Tube",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GU",
                            Description = @"GU Irrigant",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IA",
                            Description = @"Intra-arterial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IB",
                            Description = @"Intrabursal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IC",
                            Description = @"Intracardiac",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICV",
                            Description = @"Intracervical (uterus)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ID",
                            Description = @"Intradermal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IH",
                            Description = @"Inhalation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IHA",
                            Description = @"Intrahepatic Artery",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IM",
                            Description = @"Intramuscular",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IMR",
                            Description = @"Immerse (Soak) Body Part",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Intranasal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IO",
                            Description = @"Intraocular",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IP",
                            Description = @"Intraperitoneal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IS",
                            Description = @"Intrasynovial",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IT",
                            Description = @"Intrathecal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IU",
                            Description = @"Intrauterine",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IV",
                            Description = @"Intravenous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MM",
                            Description = @"Mucous Membrane",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MTH",
                            Description = @"Mouth/Throat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NG",
                            Description = @"Nasogastric",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Nasal Prongs*",
                            Comment = @"used primarily for respiratory therapy and anesthesia delivery"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NS",
                            Description = @"Nasal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NT",
                            Description = @"Nasotrachial Tube",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Ophthalmic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Otic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OTH",
                            Description = @"Other/Miscellaneous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PF",
                            Description = @"Perfusion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PO",
                            Description = @"Oral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PR",
                            Description = @"Rectal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RM",
                            Description = @"Rebreather Mask*",
                            Comment = @"used primarily for respiratory therapy and anesthesia delivery"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SC",
                            Description = @"Subcutaneous",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Soaked Dressing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"Sublingual",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TD",
                            Description = @"Transdermal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TL",
                            Description = @"Translingual",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TP",
                            Description = @"Topical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TRA",
                            Description = @"Tracheostomy*",
                            Comment = @"used primarily for respiratory therapy and anesthesia delivery"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Urethral",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VG",
                            Description = @"Vaginal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VM",
                            Description = @"Ventimask",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WND",
                            Description = @"Wound",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

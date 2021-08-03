using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0496
    {
        public string Id { get { return @"0496"; } }

        public string TableId { get { return @"0496"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Consent Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
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
                            Value = @"001",
                            Description = @"Release of Information/MR / Authorization to Disclosure Protected Health Information",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"002",
                            Description = @"Medical Procedure (invasive)",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"003",
                            Description = @"Acknowledge Receipt of Privacy Notice",
                            Comment = @"Acknowledgement/ Notification"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"004",
                            Description = @"Abortion",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"005",
                            Description = @"Abortion/Laminaria",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"006",
                            Description = @"Accutane - Information",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"007",
                            Description = @"Accutane - Woman",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"008",
                            Description = @"Advanced Beneficiary Notice",
                            Comment = @"Acknowledgement/ Notification"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"009",
                            Description = @"AFP (Alpha Fetoprotein) Screening",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"010",
                            Description = @"Amniocentesis (consent & refusal)",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"011",
                            Description = @"Anatomical Gift (organ donation)",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"012",
                            Description = @"Anesthesia - Complications",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"013",
                            Description = @"Anesthesia - Questionnaire",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"014",
                            Description = @"Angiogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"015",
                            Description = @"Angioplasty",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"016",
                            Description = @"Anticancer Drugs",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"017",
                            Description = @"Antipsychotic Medications",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"018",
                            Description = @"Arthrogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"019",
                            Description = @"Autopsy",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"020",
                            Description = @"AZT Therapy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"021",
                            Description = @"Biliary Drainage",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"022",
                            Description = @"Biliary Stone Extraction",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"023",
                            Description = @"Biopsy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"024",
                            Description = @"Bleeding Time Test",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"025",
                            Description = @"Bronchogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"026",
                            Description = @"Cardiac Catheterization",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"027",
                            Description = @"Coronary Angiography",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"028",
                            Description = @"""""      """" w/o Surgery Capability",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"029",
                            Description = @"Cataract Op/Implant of FDA Aprvd Lens",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"030",
                            Description = @"Cataract Op/Implant of Investigational Lens",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"031",
                            Description = @"Cataract Surgery",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"032",
                            Description = @"Cholera Immunization",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"033",
                            Description = @"Cholesterol Screening",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"034",
                            Description = @"Circumcision - Newborn",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"035",
                            Description = @"Colonoscopy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"036",
                            Description = @"Contact Lenses",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"037",
                            Description = @"CT Scan - Cervical & Lumbar",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"038",
                            Description = @"CT Scan w/ IV Contrast Media into Vein",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"039",
                            Description = @"CVS (Chorionic Villus) Sampling",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"040",
                            Description = @"Cystospy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"041",
                            Description = @"Disclosure of Protected Health Information to Family/Friends",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"042",
                            Description = @"D & C and Conization",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"043",
                            Description = @"Dacryocystogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"044",
                            Description = @"Diagnostic Isotope",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"045",
                            Description = @"Drainage of an Abscess",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"046",
                            Description = @"Drug Screening",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"047",
                            Description = @"Electronic Monitoring of Labor - Refusal",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"048",
                            Description = @"Endometrial Biopsy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"049",
                            Description = @"Endoscopy/Sclerosis of Esophageal Varices",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"050",
                            Description = @"ERCP",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"051",
                            Description = @"Exposure to reportable Communicable Disease",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"052",
                            Description = @"External Version",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"053",
                            Description = @"Fluorescein Angioscopy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"054",
                            Description = @"Hepatitis B - Consent/Declination",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"055",
                            Description = @"Herniogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"056",
                            Description = @"HIV Test - Consent Refusal",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"057",
                            Description = @"HIV Test - Disclosure",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"058",
                            Description = @"HIV Test - Prenatal",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"059",
                            Description = @"Home IV Treatment Program",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"060",
                            Description = @"Home Parenteral Treatment Program",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"061",
                            Description = @"Hysterectomy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"062",
                            Description = @"Hysterosalpingogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"063",
                            Description = @"Injection Slip/ Consent",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"064",
                            Description = @"Intrauterine Device",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"065",
                            Description = @"Intrauterine Device/Sterilization",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"066",
                            Description = @"Intravascular Infusion of Streptokinase/Urokinase",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"067",
                            Description = @"Intravenous Cholangiogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"068",
                            Description = @"Intravenous Digital Angiography",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"069",
                            Description = @"Iodine Administration",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"070",
                            Description = @"ISG",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"071",
                            Description = @"IVP",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"072",
                            Description = @"Laser Photocoagulation",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"073",
                            Description = @"Laser treatment",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"074",
                            Description = @"Lithium Carbonate",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"075",
                            Description = @"Liver Biopsy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"076",
                            Description = @"Lumbar Puncture",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"077",
                            Description = @"Lymphangiogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"078",
                            Description = @"MAO Inhibitors",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"079",
                            Description = @"Med, Psych, and/or Drug/Alcohol",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"080",
                            Description = @"Medical Treatment - Refusal",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"081",
                            Description = @"Morning-after Pill",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"082",
                            Description = @"MRI - Adult",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"083",
                            Description = @"MRI - Pediatric",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"084",
                            Description = @"Myelogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"085",
                            Description = @"Needle Biopsy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"086",
                            Description = @"Needle Biopsy of Lung",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"087",
                            Description = @"Newborn Treatment and Release",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"088",
                            Description = @"Norplant Subdermal Birth Control Implant",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"089",
                            Description = @"Operations, Anesthesia, Transfusions",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"090",
                            Description = @"Oral Contraceptives",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"091",
                            Description = @"Organ Donation",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"092",
                            Description = @"Patient Permits, Consents",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"093",
                            Description = @"Patient Treatment Permit, Release & Admission",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"094",
                            Description = @"Penile Injections",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"095",
                            Description = @"Percutaneous Nephrostomy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"096",
                            Description = @"Percutaneous Transhepatic Cholangiogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"097",
                            Description = @"Photographs",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"098",
                            Description = @"Photographs - Employee",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"099",
                            Description = @"Photographs - Medical Research",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"100",
                            Description = @"Photographs - news Media",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"101",
                            Description = @"Psychiatric Admission - Next of Kin",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"102",
                            Description = @"Psychiatric Information During Hospital Stay",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"103",
                            Description = @"Public Release of Information",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"104",
                            Description = @"Radiologic Procedure",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"105",
                            Description = @"Refusal of Treatment",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"106",
                            Description = @"Release of Body",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"107",
                            Description = @"Release of Limb",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"108",
                            Description = @"Rh Immune Globulin",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"109",
                            Description = @"Rights of Medical Research Participants",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"110",
                            Description = @"Request to Restrict Access/Disclosure to Medical Record/Protected Health Information",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"111",
                            Description = @"Request for Remain Anonymous",
                            Comment = @"Release of Info/ Disclosure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"112",
                            Description = @"Seat Belt Exemption",
                            Comment = @"Administrative"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"113",
                            Description = @"Sialogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1137",
                            Description = @"Voiding Cystogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"114",
                            Description = @"Sigmoidoscopy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"115",
                            Description = @"Sterilization - Anesthesia & Medical Services",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"116",
                            Description = @"Sterilization -Federally Funded",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"117",
                            Description = @"Sterilization - Female",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"118",
                            Description = @"Sterilization - Laparoscopy/Pomeroy",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"119",
                            Description = @"Sterilization - Non-Federally Funded",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"120",
                            Description = @"Sterilization - Secondary",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"121",
                            Description = @"Tranquilizers",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"122",
                            Description = @"Transfer - Acknowledgement",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"123",
                            Description = @"Transfer - Authorization",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"124",
                            Description = @"Transfer Certification - Physician",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"125",
                            Description = @"Transfer/Discharge Request",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"126",
                            Description = @"Transfer for Non-Medical Reasons",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"127",
                            Description = @"Transfer - Interfaculty Neonatal",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"128",
                            Description = @"Transfer Refusal",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"129",
                            Description = @"Transfer Refusal of Further Treatment",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"130",
                            Description = @"Treadmill & EKG",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"131",
                            Description = @"Treadmill, Thallium-201",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"132",
                            Description = @"Typhoid",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"133",
                            Description = @"Use of Investigational Device",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"134",
                            Description = @"Use of Investigational Drug",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"135",
                            Description = @"Venogram",
                            Comment = @"Medical Treatment/ Procedure"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"136",
                            Description = @"Videotape",
                            Comment = @"Release of Info/ Disclosure"
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0396
    {
        public string Id { get { return @"0396"; } }

        public string TableId { get { return @"0396"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Coding system"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"99zzz or L",
                            Description = @"Local general code (where z is an alphanumeric character) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACR",
                            Description = @"American College of Radiology finding codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALPHAID2006",
                            Description = @"German Alpha-ID v2006 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALPHAID2007",
                            Description = @"German Alpha-ID v2007 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALPHAID2008",
                            Description = @"German Alpha-ID v2008 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANS+",
                            Description = @"HL7 set of units of measure ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ART",
                            Description = @"WHO Adverse Reaction Terms ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AS4",
                            Description = @"ASTM E1238/ E1467 Universal ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AS4E",
                            Description = @"AS4 Neurophysiology Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ATC",
                            Description = @"American Type Culture Collection ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C4",
                            Description = @"CPT-4 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C5",
                            Description = @"CPT-5 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAS",
                            Description = @"Chemical abstract codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CCC",
                            Description = @"Clinical Care Classification system ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD2",
                            Description = @"CDT-2 Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDCA",
                            Description = @"CDC Analyte Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDCM",
                            Description = @"CDC Methods/Instruments Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDS",
                            Description = @"CDC Surveillance ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE (obsolete)",
                            Description = @"CEN ECG diagnostic codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLP",
                            Description = @"CLIP ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CPTM",
                            Description = @"CPT Modifier Code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CST",
                            Description = @"COSTART ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVX",
                            Description = @"CDC Vaccine Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DCM",
                            Description = @"DICOM Controlled Terminology ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"EUCLIDES ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E5",
                            Description = @"Euclides  quantity codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E6",
                            Description = @"Euclides Lab method codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E7",
                            Description = @"Euclides Lab equipment codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENZC",
                            Description = @"Enzyme Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDDC",
                            Description = @"First DataBank Drug Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDDX",
                            Description = @"First DataBank Diagnostic Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDK",
                            Description = @"FDA K10 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2004",
                            Description = @"G-DRG German DRG Codes v2004 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2005",
                            Description = @"G-DRG German DRG Codes v2005 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2006",
                            Description = @"G-DRG German DRG Codes v2006 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2007",
                            Description = @"G-DRG German DRG Codes v2007 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GDRG2008",
                            Description = @"G-DRG German DRG Codes v2008 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2004",
                            Description = @"German Major Diagnostic Codes v2004 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2005",
                            Description = @"German Major Diagnostic Codes v2005 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2006",
                            Description = @"German Major Diagnostic Codes v2006 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2007",
                            Description = @"German Major Diagnostic Codes v2007 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GMDC2008",
                            Description = @"German Major Diagnostic Codes v2008 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HB",
                            Description = @"HIBCC ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCPCS",
                            Description = @"CMS (formerly HCFA)  Common Procedure Coding System ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCPT",
                            Description = @"Health Care Provider Taxonomy ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HHC",
                            Description = @"Home Health Care ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HI",
                            Description = @"Health Outcomes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL7nnnn",
                            Description = @"HL7 Defined Codes where nnnn is the HL7 table number ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HOT",
                            Description = @"Japanese Nationwide Medicine Code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HPC",
                            Description = @"CMS (formerly HCFA )Procedure Codes (HCPCS) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10",
                            Description = @"ICD-10 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10G2004",
                            Description = @"ICD 10 Germany v2004 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10G2005",
                            Description = @"ICD 10 Germany v2005 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10G2006",
                            Description = @"ICD 10 Germany v2006 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10P",
                            Description = @"ICD-10  Procedure Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9",
                            Description = @"ICD9 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9C",
                            Description = @"ICD-9CM ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9CDX",
                            Description = @"ICD-9CM Diagnosis codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9CP",
                            Description = @"ICD-9CM Procedure codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IBT",
                            Description = @"ISBT ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IBTnnnn",
                            Description = @"ISBT 128 codes where nnnn  specifies a specific table within ISBT 128. ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10AM",
                            Description = @"ICD-10 Australian modification ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10CA",
                            Description = @"ICD-10 Canada ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10GM2007",
                            Description = @"ICD 10 Germany v2007 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10GM2008",
                            Description = @"ICD 10 Germany v2008 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICDO",
                            Description = @"International Classification of Diseases for Oncology ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICS",
                            Description = @"ICCS ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICSD",
                            Description = @"International Classification of Sleep Disorders ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO+",
                            Description = @"ISO 2955.83 (units of measure) with HL7 extensions ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISOnnnn",
                            Description = @"ISO Defined Codes where nnnn is the ISO table number ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ITIS",
                            Description = @"Integrated Taxonomic Information System ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IUPC",
                            Description = @"IUPAC/IFCC Component Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IUPP",
                            Description = @"IUPAC/IFCC Property Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JC10",
                            Description = @"JLAC/JSLM nationwide laboratory code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JC8",
                            Description = @"Japanese Chemistry ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JJ1017",
                            Description = @"Japanese Image Examination Cache ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LB",
                            Description = @"Local billing code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LN",
                            Description = @"Logical Observation Identifier Names and Codes (LOINCÃ‚Â®) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCD",
                            Description = @"Medicaid ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCR",
                            Description = @"Medicare ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDC",
                            Description = @"Medical Device Communication ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDDX",
                            Description = @"Medispan Diagnostic Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDC",
                            Description = @"Medical Economics Drug Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDR",
                            Description = @"Medical Dictionary for Drug Regulatory Affairs (MEDDRA) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDX",
                            Description = @"Medical Economics Diagnostic Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MGPI",
                            Description = @"Medispan GPI ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MVX",
                            Description = @"CDC Vaccine Manufacturer Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCPDPnnnnsss",
                            Description = @"NCPDP code list for data element nnnn [as used in segment sss] ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NDA",
                            Description = @"NANDA ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NDC",
                            Description = @"National drug codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIC",
                            Description = @"Nursing Interventions Classification ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"National Provider Identifier ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NUBC",
                            Description = @"National Uniform Billing Committee Code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O301",
                            Description = @"German Procedure Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O3012004",
                            Description = @"OPS Germany v2004 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O3012005",
                            Description = @"OPS Germany v2005 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O3012006",
                            Description = @"OPS Germany v2006 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OHA",
                            Description = @"Omaha System ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OPS2007",
                            Description = @"OPS Germany v2007 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OPS2008",
                            Description = @"OPS Germany v2008 ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"POS",
                            Description = @"POS Codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Read Classification ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCT",
                            Description = @"SNOMED Clinical Terms ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCT2",
                            Description = @"SNOMED Clinical Terms alphanumeric codes ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SDM",
                            Description = @"SNOMED- DICOM Microglossary ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNM",
                            Description = @"Systemized Nomenclature of Medicine (SNOMED) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNM3",
                            Description = @"SNOMED International ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNT",
                            Description = @"SNOMED topology codes (anatomic sites) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UB04FL14",
                            Description = @"Priority (Type) of Visit ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UB04FL15",
                            Description = @"Point of Origin ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UB04FL17",
                            Description = @"Patient Discharge Status ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"UCDS ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UCUM",
                            Description = @"UCUM code set for units of measure(from Regenstrief) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UMD",
                            Description = @"MDNS ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UML",
                            Description = @"Unified Medical Language ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPC",
                            Description = @"Universal Product Code ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPIN",
                            Description = @"UPIN ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USPS",
                            Description = @"United States Postal Service ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W1",
                            Description = @"WHO record # drug codes (6 digit) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W2",
                            Description = @"WHO record # drug codes (8 digit) ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W4",
                            Description = @"WHO record # code with ASTM extension ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WC",
                            Description = @"WHO ATC ",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X12DEnnnn",
                            Description = @"ASC X12 Code List nnnn ",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

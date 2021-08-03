using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0396
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
                            Description = @"Local general code (where z is an alphanumeric character)",
                            Comment = @"Locally defined codes for purpose of sender or receiver. Local codes can be identified by L (for backward compatibility) or 99zzz (where z is an alphanumeric character)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ACR",
                            Description = @"American College of Radiology finding codes",
                            Comment = @"Index for Radiological Diagnosis Revised, 3rd Edition 1986, American College of Radiology, Reston, VA."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANS+",
                            Description = @"HL7 set of units of measure",
                            Comment = @"HL7 set of units of measure based upon ANSI X3.50 - 1986, ISO 2988-83, and US customary units / see chapter 7, section 7.4.2.6."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ART",
                            Description = @"WHO Adverse Reaction Terms",
                            Comment = @"WHO Collaborating Centre for International Drug Monitoring, Box 26, S-751 03, Uppsala, Sweden."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AS4",
                            Description = @"ASTM E1238/ E1467 Universal",
                            Comment = @"American Society for Testing & Materials and CPT4 (see Appendix X1 of Specification E1238 and Appendix X2 of Specification E1467)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AS4E",
                            Description = @"AS4 Neurophysiology Codes",
                            Comment = @"ASTM’s diagnostic codes and test result coding/grading systems for clinical neurophysiology. See ASTM Specification E1467, Appendix 2."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ATC",
                            Description = @"American Type Culture Collection",
                            Comment = @"Reference cultures (microorganisms, tissue cultures, etc.), related biological materials and associated data. American Type Culture Collection, 12301 Parklawn Dr, Rockville MD, 20852. (301) 881-2600. http://www.atcc.org"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C4",
                            Description = @"CPT-4",
                            Comment = @"American Medical Association, P.O. Box 10946, Chicago IL  60610."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C5",
                            Description = @"CPT-5",
                            Comment = @"(under development - same contact as above)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CAS",
                            Description = @"Chemical abstract codes",
                            Comment = @"These include unique codes for each unique chemical, including all generic drugs. The codes do not distinguish among different dosing forms. When multiple equivalent CAS numbers exist, use the first one listed in USAN. USAN 1990 and the USP dictionary of drug names, William M. Heller, Ph.D., Executive Editor, United States Pharmacopeial Convention, Inc., 12601 Twinbrook Parkway, Rockville, MD 20852."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CD2",
                            Description = @"CDT-2 Codes",
                            Comment = @"American Dental Association’s Current Dental Terminology (CDT-2) code. American Dental Association, 211 E. Chicago Avenue,. Chicago, Illinois 60611."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDCA",
                            Description = @"CDC Analyte Codes",
                            Comment = @"As above, for CDCM"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDCM",
                            Description = @"CDC Methods/Instruments Codes",
                            Comment = @"Public Health Practice Program Office, Centers for Disease Control and Prevention, 4770 Buford Highway, Atlanta, GA, 30421. Also available via FTP: ftp://ftp.cdc.gov/pub/laboratory_info/CLIA/."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CDS",
                            Description = @"CDC Surveillance",
                            Comment = @"CDC Surveillance Codes. For data unique to specific public health surveillance requirements. Epidemiology Program Office, Centers for Disease Control and Prevention, 1600 Clifton Rd, Atlanta, GA, 30333. (404) 639-3661."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CE",
                            Description = @"CEN ECG diagnostic codes",
                            Comment = @"CEN PT007. A quite comprehensive set of ECG diagnostic codes (abbreviations) and descriptions published as a pre-standard by CEN TC251. Available from CEN TC251 secretariat, c/o Georges DeMoor, State University Hospital Gent, De Pintelaan 185-5K3, 9000 Gent, Belgium or Jos Willems, University of Gathuisberg, 49 Herestraat, 3000 Leuven, Belgium."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLP",
                            Description = @"CLIP",
                            Comment = @"Simon Leeming, Beth Israel Hospital, Boston MA. Codes for radiology reports."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CPTM",
                            Description = @"CPT Modifier Code",
                            Comment = @"Available for the AMA at the address listed for CPT above. These codes are found in Appendix A of CPT 2000 Standard Edition. (CPT 2000 Standard Edition, American Medical Association, Chicago, IL)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CST",
                            Description = @"COSTART",
                            Comment = @"International coding system for adverse drug reactions. In the USA, maintained by the FDA, Rockville, MD."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CVX",
                            Description = @"CDC Vaccine Codes",
                            Comment = @"National Immunization Program, Centers for Disease Control and Prevention, 1660 Clifton Road, Atlanta, GA, 30333"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DCM",
                            Description = @"DICOM Controlled Terminology",
                            Comment = @"Codes defined in DICOM Content Mapping Resource. Digital Imaging and Communications in Medicine (DICOM). NEMA Publication PS-3.16 National Electrical Manufacturers Association (NEMA). Rosslyn, VA, 22209. Available at: http://medical.nema.org"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"EUCLIDES",
                            Comment = @"Available from Euclides Foundation International nv, Excelsiorlaan 4A, B-1930 Zaventem, Belgium; Phone: 32 2 720 90 60."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E5",
                            Description = @"Euclides  quantity codes",
                            Comment = @"Available from Euclides Foundation International nv (see above)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E6",
                            Description = @"Euclides Lab method codes",
                            Comment = @"Available from Euclides Foundation International nv, Excelsiorlaan 4A, B-1930 Zaventem, Belgium; Phone : 32 2 720 90 60."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E7",
                            Description = @"Euclides Lab equipment codes",
                            Comment = @"Available from Euclides Foundation International nv (see above)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ENZC",
                            Description = @"Enzyme Codes",
                            Comment = @"Enzyme Committee of the International Union of Biochemistry and Molecular Biology. Enzyme Nomenclature: Recommendations on the Nomenclature and Classification of Enzyme-Catalysed Reactions. London: Academic Press, 1992."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDDC",
                            Description = @"First DataBank Drug Codes",
                            Comment = @"National Drug Data File. Proprietary product of First DataBank, Inc. (800) 633-3453, or http://www.firstdatabank.com."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDDX",
                            Description = @"First DataBank Diagnostic Codes",
                            Comment = @"Used for drug-diagnosis interaction checking. Proprietary product of First DataBank, Inc. As above for FDDC."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDK",
                            Description = @"FDA K10",
                            Comment = @"Dept. of Health & Human Services, Food & Drug Administration, Rockville, MD 20857. (device & analyte process codes)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HB",
                            Description = @"HIBCC",
                            Comment = @"Health Industry Business Communications Council, 5110 N. 40th St., Ste 120, Phoenix, AZ 85018."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCPCS",
                            Description = @"CMS (formerly HCFA)  Common Procedure Coding System",
                            Comment = @"HCPCS: contains codes for medical equipment, injectable drugs, transportation services, and other services not found in CPT4.[7]"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HCPT",
                            Description = @"Health Care Provider Taxonomy",
                            Comment = @"The Blue Cross and Blue Shield Association will act as the administrator of the Provider Taxonomy so that the code structure is classified as external to X12. Ongoing maintenance is solely the responsibility of Workgroup 15 (Provider Information) within ANSI ASC X12N, or the work group’s successor.  Blue Cross and Blue Shield Association, 225 North Michigan Avenue, Chicago, IL 60601, Attention: ITS Department, ECNS Unit. http://www.wpc-edi.com/taxonomy/ Primary distribution is the responsibility of Washington Publishing Company, through its World Wide Web Site, at the same web site."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HHC",
                            Description = @"Home Health Care",
                            Comment = @"Home Health Care Classification System; Virginia Saba, EdD, RN; Georgetown University School of Nursing; Washington, DC."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HI",
                            Description = @"Health Outcomes",
                            Comment = @"Health Outcomes Institute codes for outcome variables available (with responses) from Stratis Health (formerly Foundation for Health Care Evaluation and Health Outcomes Institute), 2901 Metro Drive, Suite 400, Bloomington, MN, 55425-1525; (612) 854-3306 (voice); (612) 853-8503 (fax); info@stratishealth.org. See examples in the Implementation Guide."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HL7nnnn",
                            Description = @"HL7 Defined Codes where nnnn is the HL7 table number",
                            Comment = @"Health Level Seven where nnnn is the HL7 table number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HOT",
                            Description = @"Japanese Nationwide Medicine Code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HPC",
                            Description = @"CMS (formerly HCFA )Procedure Codes (HCPCS)",
                            Comment = @"Health Care Financing Administration (HCFA) Common Procedure Coding System (HCPCS) including modifiers.[8]http://www.cms.hhs.gov/MedHCPCSGenInfo/"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10",
                            Description = @"ICD-10",
                            Comment = @"World Health Publications, Albany, NY."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I10P",
                            Description = @"ICD-10  Procedure Codes",
                            Comment = @"Procedure Coding System (ICD-10-PCS.)  See http://www.cms.hhs.gov/ICD9ProviderDiagnosticCodes/08_ICD10.aspfor more information."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9",
                            Description = @"ICD9",
                            Comment = @"World Health Publications, Albany, NY."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I9C",
                            Description = @"ICD-9CM",
                            Comment = @"Commission on Professional and Hospital Activities, 1968 Green Road, Ann Arbor, MI 48105 (includes all procedures and diagnostic tests)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IBT",
                            Description = @"ISBT",
                            Comment = @"Retained for backward compatibility only as of v 2.5. This code value has been superceded by IBTnnnn. International Society of Blood Transfusion. Blood Group Terminology 1990. VOX Sanquines 1990 58(2):152-169."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IBTnnnn",
                            Description = @"ISBT 128 codes where nnnn  specifies a specific table within ISBT 128.",
                            Comment = @"International Society of Blood Transfusion. (specific contact information will be supplied to editor.) The variable suffix (nnnn) identifies a specific table within ISBT 128."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IC2",
                            Description = @"ICHPPC-2",
                            Comment = @"International Classification of Health Problems in Primary Care, Classification Committee of World Organization of National Colleges, Academies and Academic Associations of General Practitioners (WONCA), 3rd edition. An adaptation of ICD9 intended for use in General Medicine, Oxford University Press."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10AM",
                            Description = @"ICD-10 Australian modification",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICD10CA",
                            Description = @"ICD-10 Canada",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICDO",
                            Description = @"International Classification of Diseases for Oncology",
                            Comment = @"International Classification of Diseases for Oncology, 2nd Edition. World Health Organization: Geneva, Switzerland, 1990. Order from: College of American Pathologists, 325 Waukegan Road, Northfield, IL, 60093-2750. (847) 446-8800."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICS",
                            Description = @"ICCS",
                            Comment = @"Commission on Professional and Hospital Activities, 1968 Green Road, Ann Arbor, MI 48105."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICSD",
                            Description = @"International Classification of Sleep Disorders",
                            Comment = @"International Classification of Sleep Disorders Diagnostic and Coding Manual, 1990, available from American Sleep Disorders Association, 604 Second Street SW, Rochester, MN  55902"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISO+",
                            Description = @"ISO 2955.83 (units of measure) with HL7 extensions",
                            Comment = @"See chapter 7, section 7.4.2.6"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ISOnnnn",
                            Description = @"ISO Defined Codes where nnnn is the ISO table number",
                            Comment = @"International Standards Organization where nnnn is the ISO table number"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IUPC",
                            Description = @"IUPAC/IFCC Component Codes",
                            Comment = @"Codes used by IUPAC/IFF to identify the component (analyte) measured. Contact Henrik Olesen, as above for IUPP."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IUPP",
                            Description = @"IUPAC/IFCC Property Codes",
                            Comment = @"International Union of Pure and Applied Chemistry/International Federation of Clinical Chemistry. The Silver Book: Compendium of terminology and nomenclature of properties in clinical laboratory sciences. Oxford: Blackwell Scientific Publishers, 1995. Henrik Olesen, M.D., D.M.Sc., Chairperson, Department of Clinical Chemistry, KK76.4.2, Rigshospitalet, University Hospital of Copenhagen, DK-2200, Copenhagen."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JC10",
                            Description = @"JLAC/JSLM, nationwide laboratory code",
                            Comment = @"Source: Classification &Coding for Clinical Laboratory. Japanese Society of Laboratory Medicine(JSLM, Old:Japan Society of Clinical Pathology). Version 10, 1997. A multiaxial code  including a analyte code (e.g., Rubella = 5f395), identification code (e.g., virus ab IGG=1431), a specimen code (e.g., serum =023) and a method code (e.g., ELISA = 022)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JC8",
                            Description = @"Japanese Chemistry",
                            Comment = @"Clinical examination classification code. Japan Association of Clinical Pathology. Version 8, 1990. A multiaxial code  includ ing a subject code (e.g., Rubella = 5f395, identification code (e.g., virus ab IGG), a specimen code (e.g., serum =023) and a method code (e.g., ELISA = 022)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JJ1017",
                            Description = @"Japanese Image Examination Cache",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LB",
                            Description = @"Local billing code",
                            Comment = @"Local billing codes/names (with extensions if needed)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LN",
                            Description = @"Logical Observation Identifier Names and Codes (LOINC®)",
                            Comment = @"Regenstrief Institute, c/o LOINC, 1050 Wishard Blvd., 5th floor, Indianapolis, IN  46202. 317/630-7433. Available from the Regenstrief Institute server at http://www.Regenstrief.org/loinc/loinc.htm."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCD",
                            Description = @"Medicaid",
                            Comment = @"Medicaid billing codes/names."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCR",
                            Description = @"Medicare",
                            Comment = @"Medicare billing codes/names."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDDX",
                            Description = @"Medispan Diagnostic Codes",
                            Comment = @"Codes Used for drug-diagnosis interaction checking. Proprietary product. Hierarchical drug codes for identifying drugs down to manufacturer and pill size. MediSpan, Inc., 8425 Woodfield Crossing Boulevard, Indianapolis, IN 46240. Tel: (800) 428-4495. http://www.medispan.com/Products/index.aspx?cat=1  as above for MGPI."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDC",
                            Description = @"Medical Economics Drug Codes",
                            Comment = @"Proprietary Codes for identifying drugs. Proprietary product of Medical Economics Data, Inc. (800) 223-0581."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDR",
                            Description = @"Medical Dictionary for Drug Regulatory Affairs (MEDDRA)",
                            Comment = @"Dr. Louise Wood, Medicines Control Agency, Market Towers, 1 Nine Elms Lane, London SW85NQ, UK   Tel: (44)0 171-273-0000   http://www.meddramsso.com/MSSOWeb/index.htm"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MEDX",
                            Description = @"Medical Economics Diagnostic Codes",
                            Comment = @"Used for drug-diagnosis interaction checking. Proprietary product of Medical Economics Data, Inc. (800) 223-0581."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MGPI",
                            Description = @"Medispan GPI",
                            Comment = @"Medispan hierarchical drug codes for identifying drugs down to manufacturer and pill size. Proprietary product of MediSpan, Inc., 8425 Woodfield Crossing Boulevard, Indianapolis, IN 46240. Tel: (800) 428-4495."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MVX",
                            Description = @"CDC Vaccine Manufacturer Codes",
                            Comment = @"As above, for CVX"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NDA",
                            Description = @"NANDA",
                            Comment = @"North American Nursing Diagnosis Association, Philadelphia, PA."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NDC",
                            Description = @"National drug codes",
                            Comment = @"These provide unique codes for each distinct drug, dosing form, manufacturer, and packaging. (Available from the National Drug Code Directory, FDA, Rockville, MD, and other sources.)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIC",
                            Description = @"Nursing Interventions Classification",
                            Comment = @"Iowa Intervention Project, College of Nursing, University of Iowa, Iowa City, Iowa"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"National Provider Identifier",
                            Comment = @"Health Care Finance Administration, US Dept. of Health and Human Services, 7500 Security Blvd., Baltimore, MD 21244."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NUBC",
                            Description = @"National Uniform Billing Committee Code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OHA",
                            Description = @"Omaha System",
                            Comment = @"Omaha Visiting Nurse Association, Omaha, NB."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OHA",
                            Description = @"Omaha",
                            Comment = @"Omaha Visiting Nurse Association, Omaha, NB."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"POS",
                            Description = @"POS Codes",
                            Comment = @"HCFA Place of Service Codes for Professional Claims (See http://www.cms.hhs.gov/PlaceofServiceCodes/"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RC",
                            Description = @"Read Classification",
                            Comment = @"The Read Clinical Classification of Medicine, Park View Surgery, 26 Leicester Rd., Loughborough LE11 2AG (includes drug procedure and other codes, as well as diagnostic codes)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SDM",
                            Description = @"SNOMED- DICOM Microglossary",
                            Comment = @"College of American Pathologists, Skokie, IL, 60077-1034. (formerly designated as 99SDM)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNM",
                            Description = @"Systemized Nomenclature of Medicine (SNOMED)",
                            Comment = @"Systemized Nomenclature of Medicine, 2nd Edition 1984 Vols 1, 2, College of American Pathologists, Skokie, IL."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNM3",
                            Description = @"SNOMED International",
                            Comment = @"SNOMED International, 1993 Vols 1-4, College of American Pathologists, Skokie, IL, 60077-1034."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SNT",
                            Description = @"SNOMED topology codes (anatomic sites)",
                            Comment = @"College of American Pathologists, 5202 Old Orchard Road, Skokie, IL 60077-1034."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UC",
                            Description = @"UCDS",
                            Comment = @"Uniform Clinical Data Systems. Ms. Michael McMullan, Office of Peer Review Health Care Finance Administration, The Meadows East Bldg., 6325 Security Blvd., Baltimore, MD 21207; (301) 966 6851."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UMD",
                            Description = @"MDNS",
                            Comment = @"Universal Medical Device Nomenclature System. ECRI, 5200 Butler Pike, Plymouth Meeting, PA  19462 USA. Phone: 215-825-600 0, Fax: 215-834-1275."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UML",
                            Description = @"Unified Medical Language",
                            Comment = @"National Library of Medicine, 8600 Rockville Pike, Bethesda, MD 20894."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPC",
                            Description = @"Universal Product Code",
                            Comment = @"The Uniform Code Council. 8163 Old Yankee Road, Suite J, Dayton, OH  45458; (513) 435 3070"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPIN",
                            Description = @"UPIN",
                            Comment = @"Medicare/CMS 's (formerly HCFA)  universal physician identification numbers, available from Health Care Financing Administration, U.S. Dept. of Health and Human Services, Bureau of Program Operations, 6325 Security Blvd., Meadows East Bldg., Room 300, Baltimore, MD 21207"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USPS",
                            Description = @"United States Postal Service",
                            Comment = @"Two Letter State and Possession Abbreviations are listed in  Publication 28, Postal Addressing Standards which can be obtained from Address Information Products, National Address Information Center, 6060 Primacy Parkway, Suite 101, Memphis, Tennessee  38188-0001 Questions of comments regarding the publication should be addressed to the Office of Address and Customer Information Systems, Customer and Automation Service Department, US Postal Service, 475 Lenfant Plaza SW Rm 7801, Washington, DC  20260-5902"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W1",
                            Description = @"WHO record # drug codes (6 digit)",
                            Comment = @"World Health organization record number code. A unique sequential number is assigned to each unique single component drug and to each multi-component drug. Eight digits are allotted to each such code, six to identify the active agent, and 2 to identify the salt, of single content drugs. Six digits are assigned to each unique combination of drugs in a dispensing unit. The six digit code is identified by W1, the 8 digit code by W2."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W2",
                            Description = @"WHO record # drug codes (8 digit)",
                            Comment = @"World Health organization record number code. A unique sequential number is assigned to each unique single component drug and to each multi-component drug. Eight digits are allotted to each such code, six to identify the active agent, and 2 to identify the salt, of single content drugs. Six digits are assigned to each unique combination of drugs in a dispensing unit. The six digit code is identified by W1, the 8 digit code by W2."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W4",
                            Description = @"WHO record # code with ASTM extension",
                            Comment = @"With ASTM extensions (see Implementation Guide), the WHO codes can be used to report serum (and other) levels, patient compliance with drug usage instructions, average daily doses and more (see Appendix X1 the Implementation Guide)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WC",
                            Description = @"WHO ATC",
                            Comment = @"WHO’s ATC codes provide a hierarchical classification of drugs by therapeutic class. They are linked to the record number codes listed above."
                        },
                    };
            } 
        }
    }
}

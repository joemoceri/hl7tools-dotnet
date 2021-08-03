using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0203
    {
        public string Id { get { return @"0203"; } }

        public string TableId { get { return @"0203"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Identifier Type"; } }

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
                            Value = @"ACSN",
                            Description = @"Accession ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AM",
                            Description = @"American Express",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AMA",
                            Description = @"American Medical Association Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AN",
                            Description = @"Account number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"An Identifier for a provi",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANC",
                            Description = @"Account number Creditor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AND",
                            Description = @"Account number debitor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANON",
                            Description = @"Anonymous identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANT",
                            Description = @"Temporary Account Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APRN",
                            Description = @"Advanced Practice Registered Nurse number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ASID",
                            Description = @"Ancestor Specimen ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BA",
                            Description = @"Bank Account Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BC",
                            Description = @"Bank Card Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BCT",
                            Description = @"Birth Certificate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BR",
                            Description = @"Birth registry number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BRN",
                            Description = @"Breed Registry Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BSNR",
                            Description = @"Primary physician office number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CC",
                            Description = @"Cost Center number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CONM",
                            Description = @"Change of Name Document",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CY",
                            Description = @"County number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CZ",
                            Description = @"Citizenship Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DDS",
                            Description = @"Dentist license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEA",
                            Description = @"Drug Enforcement Administration registration number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFN",
                            Description = @"Drug Furnishing or prescriptive authority Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Diner's Club card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DL",
                            Description = @"Driver's license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DN",
                            Description = @"Doctor number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DO",
                            Description = @"Osteopathic License number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DP",
                            Description = @"Diplomatic Passport",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DPM",
                            Description = @"Podiatrist license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Donor Registration Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DS",
                            Description = @"Discover Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EI",
                            Description = @"Employee number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EN",
                            Description = @"Employer number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ESN",
                            Description = @"Staff Enterprise Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FI",
                            Description = @"Facility ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GI",
                            Description = @"Guarantor internal identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GL",
                            Description = @"General ledger number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GN",
                            Description = @"Guarantor external  identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HC",
                            Description = @"Health Card Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IND",
                            Description = @"Indigenous/Aboriginal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JHN",
                            Description = @"Jurisdictional health number (Canada)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LACSN",
                            Description = @"Laboratory Accession ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LANR",
                            Description = @"Lifelong physician number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Labor and industries number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LN",
                            Description = @"License number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LR",
                            Description = @"Local Registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MA",
                            Description = @"Patient Medicaid number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MB",
                            Description = @"Member Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Patient's Medicare number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCD",
                            Description = @"Practitioner Medicaid number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCN",
                            Description = @"Microchip Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCR",
                            Description = @"Practitioner Medicare number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCT",
                            Description = @"Marriage Certificate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MD",
                            Description = @"Medical License number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MI",
                            Description = @"Military ID number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MR",
                            Description = @"Medical record number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRT",
                            Description = @"Temporary Medical Record Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MS",
                            Description = @"MasterCard",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NBSNR",
                            Description = @"Secondary physician office number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NCT",
                            Description = @"Naturalization Certificate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"National employer identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NH",
                            Description = @"National Health Plan Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NI",
                            Description = @"National unique individual identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NII",
                            Description = @"National Insurance Organization Identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIIP",
                            Description = @"National Insurance Payor Identifier (Payor)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NNxxx",
                            Description = @"National Person Identifier where the xxx is the ISO table 3166 3-character (alphabetic) country code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NP",
                            Description = @"Nurse practitioner number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"National provider identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Optometrist license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Physician Assistant number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PC",
                            Description = @"Parole Card",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCN",
                            Description = @"Penitentiary/correctional institution Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PE",
                            Description = @"Living Subject Enterprise Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEN",
                            Description = @"Pension Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PI",
                            Description = @"Patient internal identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PNT",
                            Description = @"Temporary Living Subject Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPIN",
                            Description = @"Medicare/CMS Performing Provider Identification Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPN",
                            Description = @"Passport number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRC",
                            Description = @"Permanent Resident Card Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"Provider number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Patient external identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QA",
                            Description = @"QA number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RI",
                            Description = @"Resource identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RN",
                            Description = @"Registered Nurse Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPH",
                            Description = @"Pharmacist license number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Railroad Retirement number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRI",
                            Description = @"Regional registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RRP",
                            Description = @"Railroad Retirement Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SID",
                            Description = @"Specimen ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SL",
                            Description = @"State license",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Subscriber Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SP",
                            Description = @"Study Permit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SR",
                            Description = @"State registry ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SS",
                            Description = @"Social Security number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TAX",
                            Description = @"Tax ID number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TN",
                            Description = @"Treaty Number/ (Canada)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TPR",
                            Description = @"Temporary Permanent Resident (Canada)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unspecified identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UPIN",
                            Description = @"Medicare/CMS (formerly HCFA)'s Universal Physician Identification numbers",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"USID",
                            Description = @"Unique Specimen ID",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VN",
                            Description = @"Visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VP",
                            Description = @"Visitor Permit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VS",
                            Description = @"VISA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WC",
                            Description = @"WIC identifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WCN",
                            Description = @"Workers' Comp Number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WP",
                            Description = @"Work Permit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"XX",
                            Description = @"Organization identifier",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

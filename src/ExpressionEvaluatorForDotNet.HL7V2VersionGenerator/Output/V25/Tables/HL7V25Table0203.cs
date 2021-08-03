using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0203
    {
        public string Id { get { return @"0203"; } }

        public string TableId { get { return @"0203"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Identifier type"; } }

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
                            Value = @"AM",
                            Description = @"American Express",
                            Comment = @"Deprecated and replaced by BC in v 2.5."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AN",
                            Description = @"Account number",
                            Comment = @"An identifier that is unique to an account."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANC",
                            Description = @"Account number Creditor",
                            Comment = @"Class: Financial A more precise definition of an account number: sometimes two distinct account numbers must be transmitted in the same message, one as the creditor, the other as the debitor. Kreditorenkontonummer"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AND",
                            Description = @"Account number debitor",
                            Comment = @"Class: Financial A more precise definition of an account number: sometimes two distinct account numbers must be transmitted in the same message, one as the creditor, the other as the debitor. Debitorenkontonummer"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANON",
                            Description = @"Anonymous identifier",
                            Comment = @"An identifier for a living subject whose real identity is protected or suppressed Justification: For public health reporting purposes, anonymous identifiers are occasionally used for protecting patient identity in reporting certain results. For instance, a state health department may choose to use a scheme for generating an anonymous identifier for reporting a patient that has had a positive human immunodeficiency virus antibody test. Anonymous identifiers can be used in PID 3 by replacing the medical record number or other non-anonymous identifier. The assigning authority for an anonymous identifier would be the state/local health department."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ANT",
                            Description = @"Temporary Account Number",
                            Comment = @"Class: FinancialTemporary version of an Account Number. Use Case: An ancillary system that does not normally assign account numbers is the first time to register a patient. This ancillary system will generate a temporary account number that will only be used until an official account number is assigned."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"APRN",
                            Description = @"Advanced Practice Registered Nurse number",
                            Comment = @"An identifier that is unique to an advanced practice registered nurse within the jurisdiction of a certifying board"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BA",
                            Description = @"Bank Account Number",
                            Comment = @"Class: Financial"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BC",
                            Description = @"Bank Card Number",
                            Comment = @"Class: Financial An identifier that is unique to a person’s bank card. Replaces AM, DI, DS, MS, and VS beginning in v 2.5."
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
                            Value = @"CC",
                            Description = @"Cost Center number",
                            Comment = @"Class: Financial Use Case: needed especially for transmitting information about invoices."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CY",
                            Description = @"County number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DDS",
                            Description = @"Dentist license number",
                            Comment = @"An identifier that is unique to a dentist within the jurisdiction of the licensing board"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DEA",
                            Description = @"Drug Enforcement Administration registration number",
                            Comment = @"An identifier for an individual or organization relative to controlled substance regulation and transactions. Use case: This is a registration number that identifies an individual or organization relative to controlled substance regulation and transactions. A DEA number has a very precise and widely accepted meaning within the United States. Surprisingly, the US Drug Enforcement Administration does not solely assign DEA numbers in the United States. Hospitals have the authority to issue DEA numbers to their medical residents. These DEA numbers are based upon the hospital’s DEA number, but the authority rests with the hospital on the assignment to the residents. Thus, DEA as an Identifier Type is necessary in addition to DEA as an Assigning Authority."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DFN",
                            Description = @"Drug Furnishing or prescriptive authority Number",
                            Comment = @"An identifier issued to a health care provider authorizing the person to write drug orders Use Case: A nurse practitioner has authorization to furnish or prescribe pharmaceutical substances; this identifier is in component 1."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DI",
                            Description = @"Diner’s Club card",
                            Comment = @"Deprecated and replaced by BC in v 2.5."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DL",
                            Description = @"Driver’s license number",
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
                            Comment = @"An identifier that is unique to an osteopath within the jurisdiction of a licensing board."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DPM",
                            Description = @"Podiatrist license number",
                            Comment = @"An identifier that is unique to a podiatrist within the jurisdiction of the licensing board."
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
                            Comment = @"Deprecated and replaced by BC in v 2.5."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EI",
                            Description = @"Employee number",
                            Comment = @"A number that uniquely identifies an employee to an employer."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EN",
                            Description = @"Employer number",
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
                            Comment = @"Class: Financial"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GL",
                            Description = @"General ledger number",
                            Comment = @"Class: Financial"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GN",
                            Description = @"Guarantor external  identifier",
                            Comment = @"Class: Financial"
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
                            Comment = @"A number assigned to a member of an indigenous or aboriginal group outside of Canada."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"JHN",
                            Description = @"Jurisdictional health number (Canada)",
                            Comment = @"Class: Insurance 2 uses: a) UK jurisdictional CHI number; b) Canadian provincial health card number:"
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
                            Comment = @"Class: Insurance"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MB",
                            Description = @"Member Number",
                            Comment = @"An identifier for the insured of an insurance policy (this insured always has a subscriber), usually assigned by the insurance carrier. Use Case: Person is covered by an insurance policy. This person may or may not be the subscriber of the policy."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MC",
                            Description = @"Patient's Medicare number",
                            Comment = @"Class: Insurance"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MCD",
                            Description = @"Practitioner Medicaid number",
                            Comment = @"Class: Insurance"
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
                            Comment = @"Class: Insurance"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MD",
                            Description = @"Medical License number",
                            Comment = @"An identifier that is unique to a medical doctor within the jurisdiction of a licensing board. Use Case: These license numbers are sometimes used as identifiers. In some states, the same authority issues all three identifiers, e.g., medical, osteopathic, and physician assistant licenses all issued by one state medical board. For this case, the CX data type requires distinct identifier types to accurately interpret component 1. Additionally, the distinction among these license types is critical in most health care settings (this is not to convey full licensing information, which requires a segment to support all related attributes)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MI",
                            Description = @"Military ID number",
                            Comment = @"A number assigned to an individual who has had military duty, but is not currently on active duty. The number is assigned by the DOD or Veterans’ Affairs (VA)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MR",
                            Description = @"Medical record number",
                            Comment = @"An identifier that is unique to a patient within a set of medical records, not necessarily unique within an application."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MRT",
                            Description = @"Temporary Medical Record Number",
                            Comment = @"Temporary version of a Medical Record Number Use Case: An ancillary system that does not normally assign medical record numbers is the first time to register a patient. This ancillary system will generate a temporary medical record number that will only be used until an official medical record number is assigned."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MS",
                            Description = @"MasterCard",
                            Comment = @"Deprecated and replaced by BC in v 2.5."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"National employer identifier",
                            Comment = @"In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NH",
                            Description = @"National Health Plan Identifier",
                            Comment = @"Class: InsuranceUsed for the UK NHS national identifier. In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NI",
                            Description = @"National unique individual identifier",
                            Comment = @"Class: Insurance In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NII",
                            Description = @"National Insurance Organization Identifier",
                            Comment = @"Class: Insurance In Germany a national identifier for an insurance company. It is printed on the insurance card (health card). It is not to be confused with the health card number itself. Krankenkassen-ID der KV-Karte"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NIIP",
                            Description = @"National Insurance Payor Identifier (Payor)",
                            Comment = @"Class: Insurance In Germany the insurance identifier addressed as the payor. Krankenkassen-ID des Rechnungsempfängers Use case: a subdivision issues the card with their identifier, but the main division is going to pay the invoices."
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
                            Comment = @"An identifier that is unique to a nurse practitioner within the jurisdiction of a certifying board."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NPI",
                            Description = @"National provider identifier",
                            Comment = @"Class: Insurance In the US, the Assigning Authority for this value is typically CMS, but it may be used by all providers and insurance companies in HIPAA related transactions."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OD",
                            Description = @"Optometrist license number",
                            Comment = @"A number that is unique to an individual optometrist within the jurisdiction of the licensing board."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Physician Assistant number",
                            Comment = @"An identifier that is unique to a physician assistant within the jurisdiction of a licensing board"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PCN",
                            Description = @"Penitentiary/correctional institution Number",
                            Comment = @"A number assigned to individual who is incarcerated."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PE",
                            Description = @"Living Subject Enterprise Number",
                            Comment = @"An identifier that is unique to a living subject within an enterprise (as identified by the Assigning Authority)."
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
                            Comment = @"A number that is unique to a patient within an Assigning Authority."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PN",
                            Description = @"Person number",
                            Comment = @"A number that is unique to a living subject within an Assigning Authority."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PNT",
                            Description = @"Temporary Living Subject Number",
                            Comment = @"Temporary version of a Lining Subject Number."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PPN",
                            Description = @"Passport number",
                            Comment = @"A unique number assigned to the document affirming that a person is a citizen of the country. In the US this number is issued only by the State Department."
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
                            Comment = @"A number that is unique to an individual provider, a provider group or an organization within an Assigning Authority. Use case: This allows PRN to represent either an individual (a nurse) or a group/organization (orthopedic surgery team)."
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
                            Comment = @"A generalized resource identifier. Use Case: An identifier type is needed to accommodate what are commonly known as resources. The resources can include human (e.g. a respiratory therapist), non-human (e.g., a companion animal), inanimate object (e.g., an exam room), organization (e.g., diabetic education class) or any other physical or logical entity."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RN",
                            Description = @"Registered Nurse Number",
                            Comment = @"An identifier that is unique to a registered nurse within the jurisdiction of the licensing board."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RPH",
                            Description = @"Pharmacist license number",
                            Comment = @"An identifier that is unique to a pharmacist within the jurisdiction of the licensing board."
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
                            Value = @"SL",
                            Description = @"State license",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SN",
                            Description = @"Subscriber Number",
                            Comment = @"Class: Insurance An identifier for a subscriber of an insurance policy which is unique for, and usually assigned by, the insurance carrier. Use Case: A person is the subscriber of an insurance policy. The person’s family may be plan members, but are not the subscriber."
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
                            Comment = @"A number assigned to a member of an indigenous group in Canada. Use Case: First Nation."
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
                            Description = @"Medicare/CMS (formerly HCFA)’s Universal Physician Identification numbers",
                            Comment = @"Class: Insurance"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VN",
                            Description = @"Visit number",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VS",
                            Description = @"VISA",
                            Comment = @"Deprecated and replaced by BC in v 2.5."
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
                            Description = @"Workers’ Comp Number",
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

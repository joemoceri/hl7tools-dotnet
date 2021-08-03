using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0190
    {
        public string Id { get { return @"0190"; } }

        public string TableId { get { return @"0190"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Address type"; } }

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
                            Value = @"B",
                            Description = @"Firm/Business",
                            Comment = @"Refers to an address specific to an organization, such as an insurance company or employer, versus an individual’s work location or place of employment. It would be specific to a firm or organization that has some sort of business relationship with the subject"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BA",
                            Description = @"Bad address",
                            Comment = @"Retained for backward compatibility only as of v2.6. Refer to XAD.17"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BDL",
                            Description = @"Birth delivery location (address where birth occurred)",
                            Comment = @"Refers to the address where birth occurred."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BI",
                            Description = @"Billing Address",
                            Comment = @"May also be used for the validation/authorization of credit cards"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BR",
                            Description = @"Residence at birth (home address at time of birth)",
                            Comment = @"Refers to the home address at time of birth."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Current Or Temporary",
                            Comment = @"Retained for backward compatibility only as of v2.6. Refer to XAD.16"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Country Of Origin",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"H",
                            Description = @"Home",
                            Comment = @"Refers to a residence or domicile, literally the place where the subject resides the majority of the time. Generally speaking most people will have a home address and it will represent their primary address. Home address is mutually exclusive of permanent address."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Legal Address",
                            Comment = @"Refers to a special case address specific to the status of a subject or legal action involving the subject. For example, prisoners being treated at a healthcare facility may have home addresses, but their status mandates an address specific to their place of incarceration. Statutes may require the health information specific to a ward of the state be sent to a legal guardian, the courts, or a state or municipal agency regardless of the ward’s physical location. In cases involving civil or criminal proceedings, a record may be flagged such that all correspondence is sent to any variety of legal entities."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Mailing",
                            Comment = @"Retained for backward compatibility only as of v2.6. Refer to XAD.18"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Birth (nee) (birth address, not otherwise specified)",
                            Comment = @"Refers to the birth address, not otherwise specified"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Office/Business",
                            Comment = @"Refers to a work address specific to the subject."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Permanent",
                            Comment = @"Refers to a place where the residents know the subject and where correspondence addressed to the subject will eventually reach the subject regardless of their physical location. A permanent address generally reflects a tax jurisdiction.  Members of the military, flight attendants, and executives on rotational assignments are examples of those who typically maintain a permanent address. Although mutually exclusive of home address, in some instances, such as the executives mentioned above, it may be synonymous.  In such cases upon return from assignment this address would revert to the home address."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RH",
                            Description = @"Registry home. Refers to the information system, typically managed by a public health agency, that stores patient information such as immunization histories or cancer data, regardless of where the patient obtains services.",
                            Comment = @"Refers to the information system, typically managed by a public health agency that stores patient information such as immunization histories or cancer data, regardless of where the patient obtains services"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Service Location",
                            Comment = @"Refers to the location in which service is rendered. This would be used if reimbursement is based on the location of the service (to take into account the cost of those services)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SH",
                            Description = @"Shipping Address",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Vacation",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

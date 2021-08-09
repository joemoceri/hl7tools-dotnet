using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentCTD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CTD"; } }

        public string SegmentId { get { return @"CTD"; } }
        
        public string LongName { get { return @"Contact Data"; } }
        
        public string Description { get { return @"The CTD segment may identify any contact personnel associated with a patient referral message and its related transactions. The CTD segment will be paired with a PRD segment. The PRD segment contains data specifically focused on provider information in a referral. While it is important in an inter-enterprise transaction to transmit specific information regarding the providers involved (referring and referred-to), it may also be important to identify the contact personnel associated with the given provider. For example, a provider receiving a referral may need to know the office manager or the billing person at the institution of the provider who sent the referral. This segment allows for multiple contact personnel to be associated with a single provider."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CTD.1",
                            Type = @"Field",
                            Position = @"CTD.1",
                            Name = @"Contact Role",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0131",
                            TableName = @"Contact Role",
                            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred. When a referral is inter-enterprise in nature, there are some important relationships that must be identified. For example, it may be necessary to identify the contact representative at the clinic that sent the referral. User-defined Table 0131 - Contact role is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.1.1",
                            Type = @"Component",
                            Position = @"CTD.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.2",
                            Type = @"Component",
                            Position = @"CTD.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.3",
                            Type = @"Component",
                            Position = @"CTD.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.4",
                            Type = @"Component",
                            Position = @"CTD.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.5",
                            Type = @"Component",
                            Position = @"CTD.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.6",
                            Type = @"Component",
                            Position = @"CTD.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2",
                            Type = @"Field",
                            Position = @"CTD.2",
                            Name = @"Contact Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the contact person identified in this segment. Generally, this field will describe a person or provider associated with the referral. If this contact name is a physician, you may refer to the CTD-7-Contact identifiers for the physician identifier.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.1",
                            Type = @"Component",
                            Position = @"CTD.2.1",
                            Name = @"Family Name",
                            Length = 194,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN - family name"".",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.1",
                            Name = @"Surname",
                            Length = 50,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the ""van"" in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.3",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.3",
                            Name = @"Own Surname",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.4",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in ""Ludwig van Beethoven"". Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.5",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.2",
                            Type = @"Component",
                            Position = @"CTD.2.2",
                            Name = @"Given Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.3",
                            Type = @"Component",
                            Position = @"CTD.2.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.4",
                            Type = @"Component",
                            Position = @"CTD.2.4",
                            Name = @"Suffix (e.g., Jr Or Iii)",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.5",
                            Type = @"Component",
                            Position = @"CTD.2.5",
                            Name = @"Prefix (e.g., Dr)",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.6",
                            Type = @"Component",
                            Position = @"CTD.2.6",
                            Name = @"Degree (e.g., Md)",
                            Length = 6,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.7",
                            Type = @"Component",
                            Position = @"CTD.2.7",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.8",
                            Type = @"Component",
                            Position = @"CTD.2.8",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9",
                            Type = @"Component",
                            Position = @"CTD.2.9",
                            Name = @"Name Context",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.3",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.4",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.5",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.9.6",
                            Type = @"SubComponent",
                            Position = @"CTD.2.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.10",
                            Type = @"Component",
                            Position = @"CTD.2.10",
                            Name = @"Name Validity Range",
                            Length = 53,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to Effective Date and Expiration Date components.

This component contains the start and end date/times, which define the period during which this name was valid. See section 2.A.20, ""DR - date/time range"" for description of subcomponents. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.2",
                            Name = @"Range End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.10.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.10.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.11",
                            Type = @"Component",
                            Position = @"CTD.2.11",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 0444 - Name assembly order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.12",
                            Type = @"Component",
                            Position = @"CTD.2.12",
                            Name = @"Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.12.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.12.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.12.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.12.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.13",
                            Type = @"Component",
                            Position = @"CTD.2.13",
                            Name = @"Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.2.13.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.13.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.13.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.13.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.14",
                            Type = @"Component",
                            Position = @"CTD.2.14",
                            Name = @"Professional Suffix",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the persons profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, Personnel Management.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3",
                            Type = @"Field",
                            Position = @"CTD.3",
                            Name = @"Contact Address",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the mailing address of the contact person identified in this segment. One of the key components for completing the circle of care and provider/institution bonding is the issuance of follow-up correspondence to the referring provider.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.1",
                            Type = @"Component",
                            Position = @"CTD.3.1",
                            Name = @"Street Address",
                            Length = 184,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.1.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 120,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.1.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.1.2",
                            Name = @"Street Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.1.3",
                            Type = @"SubComponent",
                            Position = @"CTD.3.1.3",
                            Name = @"Dwelling Number",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.2",
                            Type = @"Component",
                            Position = @"CTD.3.2",
                            Name = @"Other Designation",
                            Length = 120,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In US usage, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.3",
                            Type = @"Component",
                            Position = @"CTD.3.3",
                            Name = @"City",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.4",
                            Type = @"Component",
                            Position = @"CTD.3.4",
                            Name = @"State Or Province",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.5",
                            Type = @"Component",
                            Position = @"CTD.3.5",
                            Name = @"Zip Or Postal Code",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.6",
                            Type = @"Component",
                            Position = @"CTD.3.6",
                            Name = @"Country",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"This component specifies the country where the addressee is locatedHL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399 - Country code in section 2.15.9.17 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.7",
                            Type = @"Component",
                            Position = @"CTD.3.7",
                            Name = @"Address Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.8",
                            Type = @"Component",
                            Position = @"CTD.3.8",
                            Name = @"Other Geographic Designation",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.9",
                            Type = @"Component",
                            Position = @"CTD.3.9",
                            Name = @"County/Parish Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.10",
                            Type = @"Component",
                            Position = @"CTD.3.10",
                            Name = @"Census Tract",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.11",
                            Type = @"Component",
                            Position = @"CTD.3.11",
                            Name = @"Address Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.12",
                            Type = @"Component",
                            Position = @"CTD.3.12",
                            Name = @"Address Validity Range",
                            Length = 53,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to Effective Date and Expiration Date components.

This component contains the start and end date/times, which define the period in which this address was valid. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.2",
                            Name = @"Range End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.12.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.12.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.13",
                            Type = @"Component",
                            Position = @"CTD.3.13",
                            Name = @"Effective Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the address is valid and active.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.13.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.13.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.13.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.13.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.14",
                            Type = @"Component",
                            Position = @"CTD.3.14",
                            Name = @"Expiration Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the address is valid and active.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.3.14.1",
                            Type = @"SubComponent",
                            Position = @"CTD.3.14.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.14.2",
                            Type = @"SubComponent",
                            Position = @"CTD.3.14.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4",
                            Type = @"Field",
                            Position = @"CTD.4",
                            Name = @"Contact Location",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the location of the contact, which is required when a contact that may be external to a given enterprise must be referenced. For example, if this contact represents the office manager of the referred-to physician, then the contact location should identify the clinic of the physician or provider to whom this referral has been sent. The identification of the contacts location is specified by an application and facility identifier carried in the facility field. The application identifier and the facility identifier would be used in the same manner as their corresponding fields in the MSH segment ( MSH-3-Sending application, MSH-5-Receiving application, MSH-4-Sending facility, MSH-6-Receiving facility ). That is, the facility field will contain an application identifier and facility identifier which describe the location of this contact. However, it should be noted that they may describe a different location because the contact location being referenced in this field may not be the location from which the message originated, which is being described by the MSH.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.4.1",
                            Type = @"Component",
                            Position = @"CTD.4.1",
                            Name = @"Point Of Care",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on PL.6 Person Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of care for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.2",
                            Type = @"Component",
                            Position = @"CTD.4.2",
                            Name = @"Room",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"This component specifies the code for the patient's room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.3",
                            Type = @"Component",
                            Position = @"CTD.4.3",
                            Name = @"Bed",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4",
                            Type = @"Component",
                            Position = @"CTD.4.4",
                            Name = @"Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.1",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.2",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.3",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.5",
                            Type = @"Component",
                            Position = @"CTD.4.5",
                            Name = @"Location Status",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.6",
                            Type = @"Component",
                            Position = @"CTD.4.6",
                            Name = @"Person Location Type",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Person location type is the categorization of the persons location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physicians office. Refer to User-defined Table 0305 - Person location type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.7",
                            Type = @"Component",
                            Position = @"CTD.4.7",
                            Name = @"Building",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.8",
                            Type = @"Component",
                            Position = @"CTD.4.8",
                            Name = @"Floor",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.9",
                            Type = @"Component",
                            Position = @"CTD.4.9",
                            Name = @"Location Description",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the location in free text.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.10",
                            Type = @"Component",
                            Position = @"CTD.4.10",
                            Name = @"Comprehensive Location Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The unique identifier that represents the physical location as a whole without regard for the individual components. This accommodates sites that may have a different method of defining physical units or who may code at a less granular level. For example, point of care, room, and bed may be 1 indivisible code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.4.10.1",
                            Type = @"SubComponent",
                            Position = @"CTD.4.10.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.10.2",
                            Type = @"SubComponent",
                            Position = @"CTD.4.10.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.10.3",
                            Type = @"SubComponent",
                            Position = @"CTD.4.10.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.10.4",
                            Type = @"SubComponent",
                            Position = @"CTD.4.10.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.11",
                            Type = @"Component",
                            Position = @"CTD.4.11",
                            Name = @"Assigning Authority For Location",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The entity that creates the data for the individual physical location components. If populated, it should be the authority for all components populated. Refer to User-defined Table 0363 - Assigning authority for suggested values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.4.11.1",
                            Type = @"SubComponent",
                            Position = @"CTD.4.11.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.11.2",
                            Type = @"SubComponent",
                            Position = @"CTD.4.11.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.11.3",
                            Type = @"SubComponent",
                            Position = @"CTD.4.11.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5",
                            Type = @"Field",
                            Position = @"CTD.5",
                            Name = @"Contact Communication Information",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the information, such as the phone number or electronic mail address, used to communicate with the contact person or organization.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.5.1",
                            Type = @"Component",
                            Position = @"CTD.5.1",
                            Name = @"Telephone Number",
                            Length = 199,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"This component has been retained for backward compatibility only as of version 2.3. 

Specifies the telephone number in a predetermined format that includes an optional extension, beeper number and comment.

Format: [NNN] [(999)]999-9999 [X99999] [B99999] [C any text] ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.2",
                            Type = @"Component",
                            Position = @"CTD.5.2",
                            Name = @"Telecommunication Use Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 Table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.3",
                            Type = @"Component",
                            Position = @"CTD.5.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 Table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.4",
                            Type = @"Component",
                            Position = @"CTD.5.4",
                            Name = @"Email Address",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.5",
                            Type = @"Component",
                            Position = @"CTD.5.5",
                            Name = @"Country Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.6",
                            Type = @"Component",
                            Position = @"CTD.5.6",
                            Name = @"Area/City Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.7",
                            Type = @"Component",
                            Position = @"CTD.5.7",
                            Name = @"Local Number",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.8",
                            Type = @"Component",
                            Position = @"CTD.5.8",
                            Name = @"Extension",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains comments with respect to the telephone number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.9",
                            Type = @"Component",
                            Position = @"CTD.5.9",
                            Name = @"Any Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system network used as a prefix to the Extension component for internal dialing. Note that the use of Extension Prefix requires that the Extension component be valued and that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.10",
                            Type = @"Component",
                            Position = @"CTD.5.10",
                            Name = @"Extension Prefix",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The characters established within a companys internal telephone system used in place of the (external) telephone number to facilitate calling because its length is shorter than that of the telephone number. Note that digits, as well as special characters (e.g., *, #) may be used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.11",
                            Type = @"Component",
                            Position = @"CTD.5.11",
                            Name = @"Speed Dial Code",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An expression of the telephone number as an unparsible string.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.12",
                            Type = @"Component",
                            Position = @"CTD.5.12",
                            Name = @"Unformatted Telephone Number",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" An expression of the telephone number as an unparsible string

Example: |^^^^^^^^^^^1-800-Dentist| ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6",
                            Type = @"Field",
                            Position = @"CTD.6",
                            Name = @"Preferred Method of Contact",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0185",
                            TableName = @"Preferred method of contact",
                            Description = @"This field contains the preferred method to use when communicating with the contact person. Refer to User-defined Table 0185 - Preferred method of contact for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.6.1",
                            Type = @"Component",
                            Position = @"CTD.6.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.2",
                            Type = @"Component",
                            Position = @"CTD.6.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.3",
                            Type = @"Component",
                            Position = @"CTD.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.4",
                            Type = @"Component",
                            Position = @"CTD.6.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.5",
                            Type = @"Component",
                            Position = @"CTD.6.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.6",
                            Type = @"Component",
                            Position = @"CTD.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7",
                            Type = @"Field",
                            Position = @"CTD.7",
                            Name = @"Contact Identifiers",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"PLN",
                            DataTypeName = @"Practitioner License or Other ID Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This repeating field contains the contact’s unique identifiers such as UPIN, Medicare and Medicaid numbers.  Refer to User-defined Table 0338 - Practitioner ID number type for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"CTD.7.1",
                            Type = @"Component",
                            Position = @"CTD.7.1",
                            Name = @"Id Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the license number or other ID number such as UPIN, Medicare and Medicaid number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7.2",
                            Type = @"Component",
                            Position = @"CTD.7.2",
                            Name = @"Type Of Id Number",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0338",
                            TableName = @"Practitioner ID number type",
                            Description = @"Specifies the type of number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7.3",
                            Type = @"Component",
                            Position = @"CTD.7.3",
                            Name = @"State/Other Qualifying Information",
                            Length = 62,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the state or province in which the license or ID is valid, if relevant, or other qualifying information. It is recommended that state qualifications use the abbreviations from the postal service of the country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7.4",
                            Type = @"Component",
                            Position = @"CTD.7.4",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date when the license or ID is no longer valid.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V251SegmentCTD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field contactRole;

public HL7V251Field ContactRole
{
    get
    {
        if (contactRole != null)
        {
            return contactRole;
        }

        contactRole = new HL7V251Field
        {
            field = message[@"CTD"][1],
            Id = @"CTD.1",
            Type = @"Field",
            Position = @"CTD.1",
            Name = @"Contact Role",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0131",
            TableName = @"Contact Role",
            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred. When a referral is inter-enterprise in nature, there are some important relationships that must be identified. For example, it may be necessary to identify the contact representative at the clinic that sent the referral. User-defined Table 0131 - Contact role is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (contactRole.field.FieldRepetitions != null && contactRole.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactRole.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactRole.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactRole.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactRole.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactRole.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactRole.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactRole.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactRole.fieldRepetitions = fieldRepetitions;
        }

        return contactRole;
    } 
}

internal HL7V251Field contactName;

public HL7V251Field ContactName
{
    get
    {
        if (contactName != null)
        {
            return contactName;
        }

        contactName = new HL7V251Field
        {
            field = message[@"CTD"][2],
            Id = @"CTD.2",
            Type = @"Field",
            Position = @"CTD.2",
            Name = @"Contact Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the contact person identified in this segment. Generally, this field will describe a person or provider associated with the referral. If this contact name is a physician, you may refer to the CTD-7-Contact identifiers for the physician identifier.",
            Sample = @"",
        };

        // check for repetitions
        if (contactName.field.FieldRepetitions != null && contactName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactName.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactName.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactName.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactName.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactName.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactName.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactName.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactName.fieldRepetitions = fieldRepetitions;
        }

        return contactName;
    } 
}

internal HL7V251Field contactAddress;

public HL7V251Field ContactAddress
{
    get
    {
        if (contactAddress != null)
        {
            return contactAddress;
        }

        contactAddress = new HL7V251Field
        {
            field = message[@"CTD"][3],
            Id = @"CTD.3",
            Type = @"Field",
            Position = @"CTD.3",
            Name = @"Contact Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the mailing address of the contact person identified in this segment. One of the key components for completing the circle of care and provider/institution bonding is the issuance of follow-up correspondence to the referring provider.",
            Sample = @"",
        };

        // check for repetitions
        if (contactAddress.field.FieldRepetitions != null && contactAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactAddress.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactAddress.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactAddress.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactAddress.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactAddress.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactAddress.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactAddress.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactAddress.fieldRepetitions = fieldRepetitions;
        }

        return contactAddress;
    } 
}

internal HL7V251Field contactLocation;

public HL7V251Field ContactLocation
{
    get
    {
        if (contactLocation != null)
        {
            return contactLocation;
        }

        contactLocation = new HL7V251Field
        {
            field = message[@"CTD"][4],
            Id = @"CTD.4",
            Type = @"Field",
            Position = @"CTD.4",
            Name = @"Contact Location",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the contact, which is required when a contact that may be external to a given enterprise must be referenced. For example, if this contact represents the office manager of the referred-to physician, then the contact location should identify the clinic of the physician or provider to whom this referral has been sent. The identification of the contacts location is specified by an application and facility identifier carried in the facility field. The application identifier and the facility identifier would be used in the same manner as their corresponding fields in the MSH segment ( MSH-3-Sending application, MSH-5-Receiving application, MSH-4-Sending facility, MSH-6-Receiving facility ). That is, the facility field will contain an application identifier and facility identifier which describe the location of this contact. However, it should be noted that they may describe a different location because the contact location being referenced in this field may not be the location from which the message originated, which is being described by the MSH.",
            Sample = @"",
        };

        // check for repetitions
        if (contactLocation.field.FieldRepetitions != null && contactLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactLocation.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactLocation.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactLocation.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactLocation.fieldRepetitions = fieldRepetitions;
        }

        return contactLocation;
    } 
}

internal HL7V251Field contactCommunicationInformation;

public HL7V251Field ContactCommunicationInformation
{
    get
    {
        if (contactCommunicationInformation != null)
        {
            return contactCommunicationInformation;
        }

        contactCommunicationInformation = new HL7V251Field
        {
            field = message[@"CTD"][5],
            Id = @"CTD.5",
            Type = @"Field",
            Position = @"CTD.5",
            Name = @"Contact Communication Information",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the information, such as the phone number or electronic mail address, used to communicate with the contact person or organization.",
            Sample = @"",
        };

        // check for repetitions
        if (contactCommunicationInformation.field.FieldRepetitions != null && contactCommunicationInformation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactCommunicationInformation.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactCommunicationInformation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactCommunicationInformation.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactCommunicationInformation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactCommunicationInformation.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactCommunicationInformation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactCommunicationInformation.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactCommunicationInformation.fieldRepetitions = fieldRepetitions;
        }

        return contactCommunicationInformation;
    } 
}

internal HL7V251Field preferredMethodofContact;

public HL7V251Field PreferredMethodofContact
{
    get
    {
        if (preferredMethodofContact != null)
        {
            return preferredMethodofContact;
        }

        preferredMethodofContact = new HL7V251Field
        {
            field = message[@"CTD"][6],
            Id = @"CTD.6",
            Type = @"Field",
            Position = @"CTD.6",
            Name = @"Preferred Method of Contact",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0185",
            TableName = @"Preferred method of contact",
            Description = @"This field contains the preferred method to use when communicating with the contact person. Refer to User-defined Table 0185 - Preferred method of contact for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (preferredMethodofContact.field.FieldRepetitions != null && preferredMethodofContact.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(preferredMethodofContact.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < preferredMethodofContact.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = preferredMethodofContact.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < preferredMethodofContact.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = preferredMethodofContact.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < preferredMethodofContact.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = preferredMethodofContact.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            preferredMethodofContact.fieldRepetitions = fieldRepetitions;
        }

        return preferredMethodofContact;
    } 
}

internal HL7V251Field contactIdentifiers;

public HL7V251Field ContactIdentifiers
{
    get
    {
        if (contactIdentifiers != null)
        {
            return contactIdentifiers;
        }

        contactIdentifiers = new HL7V251Field
        {
            field = message[@"CTD"][7],
            Id = @"CTD.7",
            Type = @"Field",
            Position = @"CTD.7",
            Name = @"Contact Identifiers",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PLN",
            DataTypeName = @"Practitioner License or Other ID Number",
            TableId = null,
            TableName = null,
            Description = @"This repeating field contains the contact’s unique identifiers such as UPIN, Medicare and Medicaid numbers.  Refer to User-defined Table 0338 - Practitioner ID number type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (contactIdentifiers.field.FieldRepetitions != null && contactIdentifiers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactIdentifiers.Id));
            var fieldRepetitions = new List<HL7V251FieldRepetition>();

            for (var i = 0; i < contactIdentifiers.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V251FieldRepetition
                {
                    fieldRepetition = contactIdentifiers.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V251Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactIdentifiers.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V251Component
                        {
                            component = contactIdentifiers.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V251SubComponent>();

                            for (var k = 0; k < contactIdentifiers.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V251SubComponent
                                {
                                    subComponent = contactIdentifiers.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            contactIdentifiers.fieldRepetitions = fieldRepetitions;
        }

        return contactIdentifiers;
    } 
}
    }
}

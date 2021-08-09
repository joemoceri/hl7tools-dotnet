using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPD1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PD1"; } }

        public string SegmentId { get { return @"PD1"; } }
        
        public string LongName { get { return @"Patient Additional Demographic"; } }
        
        public string Description { get { return @"The patient additional demographic segment contains demographic information that is likely to change about the patient."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"PD1.1",
                            Type = @"Field",
                            Position = @"PD1.1",
                            Name = @"Living Dependency",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0223",
                            TableName = @"Living Dependency",
                            Description = @"This field identifies specific living conditions (e.g., spouse dependent on patient, walk-up) that are relevant to an evaluation of the patient's healthcare needs. This information can be used for discharge planning. This field repeats because, for example, ""spouse dependent"" and ""medical supervision required"" can apply at the same time. Refer to User-defined Table 0223 - Living Dependency for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.2",
                            Type = @"Field",
                            Position = @"PD1.2",
                            Name = @"Living Arrangement",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0220",
                            TableName = @"Living Arrangement",
                            Description = @"This field identifies the situation in which the patient lives at his residential address. Examples might include Alone, Family, Relatives, Institution, etc. Refer to User-defined Table 0220 - Living Arrangement for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3",
                            Type = @"Field",
                            Position = @"PD1.3",
                            Name = @"Patient Primary Facility",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"This field contains the name and identifier that specifies the ""primary care"" healthcare facility selected by the patient at the time of enrolment in an HMO Insurance Plan. Multiple names and identifiers are allowed for the same facility. The legal name of the healthcare facility must be sent in the first sequence. If the legal name of the facility is not sent, then the repeat delimiter must be sent in the first sequence. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.3.1",
                            Type = @"Component",
                            Position = @"PD1.3.1",
                            Name = @"Organization Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.2",
                            Type = @"Component",
                            Position = @"PD1.3.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.3",
                            Type = @"Component",
                            Position = @"PD1.3.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.4",
                            Type = @"Component",
                            Position = @"PD1.3.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.5",
                            Type = @"Component",
                            Position = @"PD1.3.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.6",
                            Type = @"Component",
                            Position = @"PD1.3.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.3",
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
                            Id = @"PD1.3.7",
                            Type = @"Component",
                            Position = @"PD1.3.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.8",
                            Type = @"Component",
                            Position = @"PD1.3.8",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.3.8.1",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.3.8.2",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.3.8.3",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.3",
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
                            Id = @"PD1.3.9",
                            Type = @"Component",
                            Position = @"PD1.3.9",
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
                            Id = @"PD1.3.10",
                            Type = @"Component",
                            Position = @"PD1.3.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4",
                            Type = @"Field",
                            Position = @"PD1.4",
                            Name = @"Patient Primary Care Provider Name and ID No.",
                            Length = 250,
                            Usage = @"B",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number and Name for Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is retained for backward compatibility only; the ROL segment is now used to convey more complete information about the primary care provider. This field contained the provider name and ID of the primary care provider. Multiple names are allowed for the same person. The legal name must be sent in the first sequence. If the legal name is not sent, then the repeat delimiter must be sent in the first sequence.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.1",
                            Type = @"Component",
                            Position = @"PD1.4.1",
                            Name = @"Id Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.2",
                            Type = @"Component",
                            Position = @"PD1.4.2",
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
                            Id = @"PD1.4.2.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.2.1",
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
                            Id = @"PD1.4.2.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.2.2",
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
                            Id = @"PD1.4.2.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.2.3",
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
                            Id = @"PD1.4.2.4",
                            Type = @"SubComponent",
                            Position = @"PD1.4.2.4",
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
                            Id = @"PD1.4.2.5",
                            Type = @"SubComponent",
                            Position = @"PD1.4.2.5",
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
                            Id = @"PD1.4.3",
                            Type = @"Component",
                            Position = @"PD1.4.3",
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
                            Id = @"PD1.4.4",
                            Type = @"Component",
                            Position = @"PD1.4.4",
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
                            Id = @"PD1.4.5",
                            Type = @"Component",
                            Position = @"PD1.4.5",
                            Name = @"Suffix",
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
                            Id = @"PD1.4.6",
                            Type = @"Component",
                            Position = @"PD1.4.6",
                            Name = @"Prefix",
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
                            Id = @"PD1.4.7",
                            Type = @"Component",
                            Position = @"PD1.4.7",
                            Name = @"Degree",
                            Length = 5,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Retained for backward compatibility only as of v 2.5. See Professional Suffix component.

Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 – Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.8",
                            Type = @"Component",
                            Position = @"PD1.4.8",
                            Name = @"Source Table",
                            Length = 4,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined Table 0297 – CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.9",
                            Type = @"Component",
                            Position = @"PD1.4.9",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.9.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.9.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.4.9.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.3",
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
                            Id = @"PD1.4.10",
                            Type = @"Component",
                            Position = @"PD1.4.10",
                            Name = @"Name Type Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name Type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values. See Section 2.A.88.7, "" Name Type Code (ID) "".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.11",
                            Type = @"Component",
                            Position = @"PD1.4.11",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XCN.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.12",
                            Type = @"Component",
                            Position = @"PD1.4.12",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.13",
                            Type = @"Component",
                            Position = @"PD1.4.13",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.14",
                            Type = @"Component",
                            Position = @"PD1.4.14",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.14.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.14.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.4.14.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.3",
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
                            Id = @"PD1.4.15",
                            Type = @"Component",
                            Position = @"PD1.4.15",
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
                            Id = @"PD1.4.16",
                            Type = @"Component",
                            Position = @"PD1.4.16",
                            Name = @"Name Context",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.4",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.5",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.6",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.7",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.8",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.16.9",
                            Type = @"SubComponent",
                            Position = @"PD1.4.16.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.17",
                            Type = @"Component",
                            Position = @"PD1.4.17",
                            Name = @"Name Validity Range",
                            Length = 49,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"Retained for backward compatibility only as of v 2.5. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead. This component cannot be fully expressed and has been identified as v 2.4 erratum.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.17.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.17.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.17.2",
                            Name = @"Range End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.18",
                            Type = @"Component",
                            Position = @"PD1.4.18",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.19",
                            Type = @"Component",
                            Position = @"PD1.4.19",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.20",
                            Type = @"Component",
                            Position = @"PD1.4.20",
                            Name = @"Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.21",
                            Type = @"Component",
                            Position = @"PD1.4.21",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22",
                            Type = @"Component",
                            Position = @"PD1.4.22",
                            Name = @"Assigning Jurisdiction",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.4",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.5",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.6",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.7",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.8",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.22.9",
                            Type = @"SubComponent",
                            Position = @"PD1.4.22.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23",
                            Type = @"Component",
                            Position = @"PD1.4.23",
                            Name = @"Assigning Agency Or Department",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.4",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.5",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.6",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.7",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.8",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.4.23.9",
                            Type = @"SubComponent",
                            Position = @"PD1.4.23.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.5",
                            Type = @"Field",
                            Position = @"PD1.5",
                            Name = @"Student Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0231",
                            TableName = @"Student Status",
                            Description = @"This field indicates if the patient is currently a student or not, and whether the patient is a full-time or a part-time student. This field does not indicate the student's degree level (high school, college, elementary) or the student's field of study (accounting, engineering, etc.). Refer to User-defined Table 0231 - Student Status in Chapter 6 for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.6",
                            Type = @"Field",
                            Position = @"PD1.6",
                            Name = @"Handicap",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0295",
                            TableName = @"Handicap",
                            Description = @"This field indicates the nature of the patient's permanent handicapped condition (e.g., deaf, blind). A handicapped condition is defined as a physical or mental disability that is permanent. Transient handicapped conditions should be sent in the ambulatory status. Refer to User-defined Table 0295 - Handicap for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.7",
                            Type = @"Field",
                            Position = @"PD1.7",
                            Name = @"Living Will Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0315",
                            TableName = @"Living Will Code",
                            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the healthcare facility. If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills. Refer to User-defined Table 0315 - Living Will Code for suggested values. See also PV2-43 - Living Will Code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.8",
                            Type = @"Field",
                            Position = @"PD1.8",
                            Name = @"Organ Donor Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0316",
                            TableName = @"Organ Donor Code",
                            Description = @"This field indicates whether the patient wants to donate his/her organs and whether an organ donor card or similar documentation is on file with the healthcare organization. Refer to User-defined Table 0316 - Organ Donor Code for suggested values. See also PV2-44 - Organ donor Code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.9",
                            Type = @"Field",
                            Position = @"PD1.9",
                            Name = @"Separate Bill",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field specifies that charges for this patient are to be billed separately from other patient bills with the same guarantor. (This bill is now a patient bill rather than a guarantor bill.) Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10",
                            Type = @"Field",
                            Position = @"PD1.10",
                            Name = @"Duplicate Patient",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID with Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates that a patient is the same as, or a duplicate of, another patient found on the sending system. The intent is to be informational only and no action is required by the receiver. Include the patient identifier if the sender knows an identifier for the patient. The assigning authority and identifier type code are strongly recommended for all CX data types.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.10.1",
                            Type = @"Component",
                            Position = @"PD1.10.1",
                            Name = @"Id Number",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value of the identifier itself.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.2",
                            Type = @"Component",
                            Position = @"PD1.10.2",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A digit, or digits, exclusive of the identifier in CX.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.3",
                            Type = @"Component",
                            Position = @"PD1.10.3",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.4",
                            Type = @"Component",
                            Position = @"PD1.10.4",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. . Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.10.4.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.4.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.10.4.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.3",
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
                            Id = @"PD1.10.5",
                            Type = @"Component",
                            Position = @"PD1.10.5",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.6",
                            Type = @"Component",
                            Position = @"PD1.10.6",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.10.6.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.6.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.10.6.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.3",
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
                            Id = @"PD1.10.7",
                            Type = @"Component",
                            Position = @"PD1.10.7",
                            Name = @"Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the identifier is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.8",
                            Type = @"Component",
                            Position = @"PD1.10.8",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the identifier is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9",
                            Type = @"Component",
                            Position = @"PD1.10.9",
                            Name = @"Assigning Jurisdiction",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.4",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.5",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.6",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.7",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.8",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.9.9",
                            Type = @"SubComponent",
                            Position = @"PD1.10.9.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10",
                            Type = @"Component",
                            Position = @"PD1.10.10",
                            Name = @"Assigning Agency Or Department",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.4",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.5",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.6",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.7",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.8",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.10.10.9",
                            Type = @"SubComponent",
                            Position = @"PD1.10.10.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11",
                            Type = @"Field",
                            Position = @"PD1.11",
                            Name = @"Publicity Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0215",
                            TableName = @"Publicity Code",
                            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the patient. Refer to User-defined Table 0215 - Publicity Code for suggested values. Refer to PV2-21 - Visit Publicity Code for visit level code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.11.1",
                            Type = @"Component",
                            Position = @"PD1.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.2",
                            Type = @"Component",
                            Position = @"PD1.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.3",
                            Type = @"Component",
                            Position = @"PD1.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.4",
                            Type = @"Component",
                            Position = @"PD1.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.5",
                            Type = @"Component",
                            Position = @"PD1.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.6",
                            Type = @"Component",
                            Position = @"PD1.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.7",
                            Type = @"Component",
                            Position = @"PD1.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.8",
                            Type = @"Component",
                            Position = @"PD1.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.11.9",
                            Type = @"Component",
                            Position = @"PD1.11.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.12",
                            Type = @"Field",
                            Position = @"PD1.12",
                            Name = @"Protection Indicator",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"From V2.6 onward, this field has been retained for backward compatibility only.  Use the ARV segment instead. This field identifies the patient's protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for the patient. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.13",
                            Type = @"Field",
                            Position = @"PD1.13",
                            Name = @"Protection Indicator Effective Date",
                            Length = 8,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"From V2.6 onward, this field has been retained for backward compatibility only.  Use the ARV segment instead. This field indicates the effective date for PD1-12 - Protection Indicator.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14",
                            Type = @"Field",
                            Position = @"PD1.14",
                            Name = @"Place of Worship",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"The patient's place of worship. For example, the patient attends the First Baptist Church of Atlanta.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.14.1",
                            Type = @"Component",
                            Position = @"PD1.14.1",
                            Name = @"Organization Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.2",
                            Type = @"Component",
                            Position = @"PD1.14.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.3",
                            Type = @"Component",
                            Position = @"PD1.14.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.4",
                            Type = @"Component",
                            Position = @"PD1.14.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.5",
                            Type = @"Component",
                            Position = @"PD1.14.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.6",
                            Type = @"Component",
                            Position = @"PD1.14.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.14.6.1",
                            Type = @"SubComponent",
                            Position = @"PD1.14.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.6.2",
                            Type = @"SubComponent",
                            Position = @"PD1.14.6.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.14.6.3",
                            Type = @"SubComponent",
                            Position = @"PD1.14.6.3",
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
                            Id = @"PD1.14.7",
                            Type = @"Component",
                            Position = @"PD1.14.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.8",
                            Type = @"Component",
                            Position = @"PD1.14.8",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.14.8.1",
                            Type = @"SubComponent",
                            Position = @"PD1.14.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.14.8.2",
                            Type = @"SubComponent",
                            Position = @"PD1.14.8.2",
                            Name = @"Universal Id",
                            Length = 999,
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
                            Id = @"PD1.14.8.3",
                            Type = @"SubComponent",
                            Position = @"PD1.14.8.3",
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
                            Id = @"PD1.14.9",
                            Type = @"Component",
                            Position = @"PD1.14.9",
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
                            Id = @"PD1.14.10",
                            Type = @"Component",
                            Position = @"PD1.14.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15",
                            Type = @"Field",
                            Position = @"PD1.15",
                            Name = @"Advance Directive Code",
                            Length = 705,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0435",
                            TableName = @"Advance Directive Code",
                            Description = @"This field indicates the patient's instructions to the healthcare facility. Refer to User-defined Table 0435 - Advance Directive Code for suggested values. See also PV2-45 - Advance Directive Code. When PD1-22 - Advanced Directive Last Verified Date is valued, this field is required.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PD1.15.1",
                            Type = @"Component",
                            Position = @"PD1.15.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.2",
                            Type = @"Component",
                            Position = @"PD1.15.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.3",
                            Type = @"Component",
                            Position = @"PD1.15.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.4",
                            Type = @"Component",
                            Position = @"PD1.15.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.5",
                            Type = @"Component",
                            Position = @"PD1.15.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.6",
                            Type = @"Component",
                            Position = @"PD1.15.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.7",
                            Type = @"Component",
                            Position = @"PD1.15.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.8",
                            Type = @"Component",
                            Position = @"PD1.15.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.15.9",
                            Type = @"Component",
                            Position = @"PD1.15.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.16",
                            Type = @"Field",
                            Position = @"PD1.16",
                            Name = @"Immunization Registry Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0441",
                            TableName = @"Immunization Registry Status",
                            Description = @"This field identifies the immunization registry status of the patient. Refer to User-defined Table 0441 - Immunization Registry Status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.17",
                            Type = @"Field",
                            Position = @"PD1.17",
                            Name = @"Immunization Registry Status Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the effective date for the immunization registry status reported in PD1-16 - Immunization Registry Status.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.18",
                            Type = @"Field",
                            Position = @"PD1.18",
                            Name = @"Publicity Code Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the effective date for PD1-11 - Publicity Code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.19",
                            Type = @"Field",
                            Position = @"PD1.19",
                            Name = @"Military Branch",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0140",
                            TableName = @"Military Service",
                            Description = @"This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0140 - Military Service for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.20",
                            Type = @"Field",
                            Position = @"PD1.20",
                            Name = @"Military Rank/Grade",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0141",
                            TableName = @"Military Rank/Grade",
                            Description = @"This user-defined field identifies the military rank/grade of the patient. Refer to User-defined Table 0141 - Military Rank/Grade for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.21",
                            Type = @"Field",
                            Position = @"PD1.21",
                            Name = @"Military Status",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0142",
                            TableName = @"Military Status",
                            Description = @"This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0142 - Military Status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PD1.22",
                            Type = @"Field",
                            Position = @"PD1.22",
                            Name = @"Advance Directive Last Verified Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date that all the advance directives held in PD1-15 - Advance Directive Code were last validated. When this field is valued, the field PD1-15 - Advance Directive Code is required.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentPD1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field livingDependency;

public HL7V26Field LivingDependency
{
    get
    {
        if (livingDependency != null)
        {
            return livingDependency;
        }

        livingDependency = new HL7V26Field
        {
            field = message[@"PD1"][1],
            Id = @"PD1.1",
            Type = @"Field",
            Position = @"PD1.1",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living Dependency",
            Description = @"This field identifies specific living conditions (e.g., spouse dependent on patient, walk-up) that are relevant to an evaluation of the patient's healthcare needs. This information can be used for discharge planning. This field repeats because, for example, ""spouse dependent"" and ""medical supervision required"" can apply at the same time. Refer to User-defined Table 0223 - Living Dependency for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (livingDependency.field.FieldRepetitions != null && livingDependency.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(livingDependency.Id));
            livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(livingDependency, fieldData);
        }

        return livingDependency;
    } 
}

internal HL7V26Field livingArrangement;

public HL7V26Field LivingArrangement
{
    get
    {
        if (livingArrangement != null)
        {
            return livingArrangement;
        }

        livingArrangement = new HL7V26Field
        {
            field = message[@"PD1"][2],
            Id = @"PD1.2",
            Type = @"Field",
            Position = @"PD1.2",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living Arrangement",
            Description = @"This field identifies the situation in which the patient lives at his residential address. Examples might include Alone, Family, Relatives, Institution, etc. Refer to User-defined Table 0220 - Living Arrangement for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (livingArrangement.field.FieldRepetitions != null && livingArrangement.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(livingArrangement.Id));
            livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(livingArrangement, fieldData);
        }

        return livingArrangement;
    } 
}

internal HL7V26Field patientPrimaryFacility;

public HL7V26Field PatientPrimaryFacility
{
    get
    {
        if (patientPrimaryFacility != null)
        {
            return patientPrimaryFacility;
        }

        patientPrimaryFacility = new HL7V26Field
        {
            field = message[@"PD1"][3],
            Id = @"PD1.3",
            Type = @"Field",
            Position = @"PD1.3",
            Name = @"Patient Primary Facility",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = @"0204",
            TableName = @"Organizational name type",
            Description = @"This field contains the name and identifier that specifies the ""primary care"" healthcare facility selected by the patient at the time of enrolment in an HMO Insurance Plan. Multiple names and identifiers are allowed for the same facility. The legal name of the healthcare facility must be sent in the first sequence. If the legal name of the facility is not sent, then the repeat delimiter must be sent in the first sequence. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (patientPrimaryFacility.field.FieldRepetitions != null && patientPrimaryFacility.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientPrimaryFacility.Id));
            patientPrimaryFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(patientPrimaryFacility, fieldData);
        }

        return patientPrimaryFacility;
    } 
}

internal HL7V26Field patientPrimaryCareProviderNameandIDNo;

public HL7V26Field PatientPrimaryCareProviderNameandIDNo
{
    get
    {
        if (patientPrimaryCareProviderNameandIDNo != null)
        {
            return patientPrimaryCareProviderNameandIDNo;
        }

        patientPrimaryCareProviderNameandIDNo = new HL7V26Field
        {
            field = message[@"PD1"][4],
            Id = @"PD1.4",
            Type = @"Field",
            Position = @"PD1.4",
            Name = @"Patient Primary Care Provider Name and ID No.",
            Length = 250,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number and Name for Persons",
            TableId = null,
            TableName = null,
            Description = @"This field is retained for backward compatibility only; the ROL segment is now used to convey more complete information about the primary care provider. This field contained the provider name and ID of the primary care provider. Multiple names are allowed for the same person. The legal name must be sent in the first sequence. If the legal name is not sent, then the repeat delimiter must be sent in the first sequence.",
            Sample = @"",
        };

        // check for repetitions
        if (patientPrimaryCareProviderNameandIDNo.field.FieldRepetitions != null && patientPrimaryCareProviderNameandIDNo.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientPrimaryCareProviderNameandIDNo.Id));
            patientPrimaryCareProviderNameandIDNo.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(patientPrimaryCareProviderNameandIDNo, fieldData);
        }

        return patientPrimaryCareProviderNameandIDNo;
    } 
}

internal HL7V26Field studentIndicator;

public HL7V26Field StudentIndicator
{
    get
    {
        if (studentIndicator != null)
        {
            return studentIndicator;
        }

        studentIndicator = new HL7V26Field
        {
            field = message[@"PD1"][5],
            Id = @"PD1.5",
            Type = @"Field",
            Position = @"PD1.5",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student Status",
            Description = @"This field indicates if the patient is currently a student or not, and whether the patient is a full-time or a part-time student. This field does not indicate the student's degree level (high school, college, elementary) or the student's field of study (accounting, engineering, etc.). Refer to User-defined Table 0231 - Student Status in Chapter 6 for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (studentIndicator.field.FieldRepetitions != null && studentIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studentIndicator.Id));
            studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(studentIndicator, fieldData);
        }

        return studentIndicator;
    } 
}

internal HL7V26Field handicap;

public HL7V26Field Handicap
{
    get
    {
        if (handicap != null)
        {
            return handicap;
        }

        handicap = new HL7V26Field
        {
            field = message[@"PD1"][6],
            Id = @"PD1.6",
            Type = @"Field",
            Position = @"PD1.6",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0295",
            TableName = @"Handicap",
            Description = @"This field indicates the nature of the patient's permanent handicapped condition (e.g., deaf, blind). A handicapped condition is defined as a physical or mental disability that is permanent. Transient handicapped conditions should be sent in the ambulatory status. Refer to User-defined Table 0295 - Handicap for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (handicap.field.FieldRepetitions != null && handicap.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(handicap.Id));
            handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(handicap, fieldData);
        }

        return handicap;
    } 
}

internal HL7V26Field livingWillCode;

public HL7V26Field LivingWillCode
{
    get
    {
        if (livingWillCode != null)
        {
            return livingWillCode;
        }

        livingWillCode = new HL7V26Field
        {
            field = message[@"PD1"][7],
            Id = @"PD1.7",
            Type = @"Field",
            Position = @"PD1.7",
            Name = @"Living Will Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0315",
            TableName = @"Living Will Code",
            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the healthcare facility. If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills. Refer to User-defined Table 0315 - Living Will Code for suggested values. See also PV2-43 - Living Will Code.",
            Sample = @"",
        };

        // check for repetitions
        if (livingWillCode.field.FieldRepetitions != null && livingWillCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(livingWillCode.Id));
            livingWillCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(livingWillCode, fieldData);
        }

        return livingWillCode;
    } 
}

internal HL7V26Field organDonorCode;

public HL7V26Field OrganDonorCode
{
    get
    {
        if (organDonorCode != null)
        {
            return organDonorCode;
        }

        organDonorCode = new HL7V26Field
        {
            field = message[@"PD1"][8],
            Id = @"PD1.8",
            Type = @"Field",
            Position = @"PD1.8",
            Name = @"Organ Donor Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0316",
            TableName = @"Organ Donor Code",
            Description = @"This field indicates whether the patient wants to donate his/her organs and whether an organ donor card or similar documentation is on file with the healthcare organization. Refer to User-defined Table 0316 - Organ Donor Code for suggested values. See also PV2-44 - Organ donor Code.",
            Sample = @"",
        };

        // check for repetitions
        if (organDonorCode.field.FieldRepetitions != null && organDonorCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organDonorCode.Id));
            organDonorCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(organDonorCode, fieldData);
        }

        return organDonorCode;
    } 
}

internal HL7V26Field separateBill;

public HL7V26Field SeparateBill
{
    get
    {
        if (separateBill != null)
        {
            return separateBill;
        }

        separateBill = new HL7V26Field
        {
            field = message[@"PD1"][9],
            Id = @"PD1.9",
            Type = @"Field",
            Position = @"PD1.9",
            Name = @"Separate Bill",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field specifies that charges for this patient are to be billed separately from other patient bills with the same guarantor. (This bill is now a patient bill rather than a guarantor bill.) Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (separateBill.field.FieldRepetitions != null && separateBill.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(separateBill.Id));
            separateBill.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(separateBill, fieldData);
        }

        return separateBill;
    } 
}

internal HL7V26Field duplicatePatient;

public HL7V26Field DuplicatePatient
{
    get
    {
        if (duplicatePatient != null)
        {
            return duplicatePatient;
        }

        duplicatePatient = new HL7V26Field
        {
            field = message[@"PD1"][10],
            Id = @"PD1.10",
            Type = @"Field",
            Position = @"PD1.10",
            Name = @"Duplicate Patient",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID with Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field indicates that a patient is the same as, or a duplicate of, another patient found on the sending system. The intent is to be informational only and no action is required by the receiver. Include the patient identifier if the sender knows an identifier for the patient. The assigning authority and identifier type code are strongly recommended for all CX data types.",
            Sample = @"",
        };

        // check for repetitions
        if (duplicatePatient.field.FieldRepetitions != null && duplicatePatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(duplicatePatient.Id));
            duplicatePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(duplicatePatient, fieldData);
        }

        return duplicatePatient;
    } 
}

internal HL7V26Field publicityCode;

public HL7V26Field PublicityCode
{
    get
    {
        if (publicityCode != null)
        {
            return publicityCode;
        }

        publicityCode = new HL7V26Field
        {
            field = message[@"PD1"][11],
            Id = @"PD1.11",
            Type = @"Field",
            Position = @"PD1.11",
            Name = @"Publicity Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0215",
            TableName = @"Publicity Code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the patient. Refer to User-defined Table 0215 - Publicity Code for suggested values. Refer to PV2-21 - Visit Publicity Code for visit level code.",
            Sample = @"",
        };

        // check for repetitions
        if (publicityCode.field.FieldRepetitions != null && publicityCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(publicityCode.Id));
            publicityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(publicityCode, fieldData);
        }

        return publicityCode;
    } 
}

internal HL7V26Field protectionIndicator;

public HL7V26Field ProtectionIndicator
{
    get
    {
        if (protectionIndicator != null)
        {
            return protectionIndicator;
        }

        protectionIndicator = new HL7V26Field
        {
            field = message[@"PD1"][12],
            Id = @"PD1.12",
            Type = @"Field",
            Position = @"PD1.12",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"From V2.6 onward, this field has been retained for backward compatibility only.  Use the ARV segment instead. This field identifies the patient's protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for the patient. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (protectionIndicator.field.FieldRepetitions != null && protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(protectionIndicator.Id));
            protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(protectionIndicator, fieldData);
        }

        return protectionIndicator;
    } 
}

internal HL7V26Field protectionIndicatorEffectiveDate;

public HL7V26Field ProtectionIndicatorEffectiveDate
{
    get
    {
        if (protectionIndicatorEffectiveDate != null)
        {
            return protectionIndicatorEffectiveDate;
        }

        protectionIndicatorEffectiveDate = new HL7V26Field
        {
            field = message[@"PD1"][13],
            Id = @"PD1.13",
            Type = @"Field",
            Position = @"PD1.13",
            Name = @"Protection Indicator Effective Date",
            Length = 8,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"From V2.6 onward, this field has been retained for backward compatibility only.  Use the ARV segment instead. This field indicates the effective date for PD1-12 - Protection Indicator.",
            Sample = @"",
        };

        // check for repetitions
        if (protectionIndicatorEffectiveDate.field.FieldRepetitions != null && protectionIndicatorEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(protectionIndicatorEffectiveDate.Id));
            protectionIndicatorEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(protectionIndicatorEffectiveDate, fieldData);
        }

        return protectionIndicatorEffectiveDate;
    } 
}

internal HL7V26Field placeofWorship;

public HL7V26Field PlaceofWorship
{
    get
    {
        if (placeofWorship != null)
        {
            return placeofWorship;
        }

        placeofWorship = new HL7V26Field
        {
            field = message[@"PD1"][14],
            Id = @"PD1.14",
            Type = @"Field",
            Position = @"PD1.14",
            Name = @"Place of Worship",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"The patient's place of worship. For example, the patient attends the First Baptist Church of Atlanta.",
            Sample = @"",
        };

        // check for repetitions
        if (placeofWorship.field.FieldRepetitions != null && placeofWorship.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(placeofWorship.Id));
            placeofWorship.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(placeofWorship, fieldData);
        }

        return placeofWorship;
    } 
}

internal HL7V26Field advanceDirectiveCode;

public HL7V26Field AdvanceDirectiveCode
{
    get
    {
        if (advanceDirectiveCode != null)
        {
            return advanceDirectiveCode;
        }

        advanceDirectiveCode = new HL7V26Field
        {
            field = message[@"PD1"][15],
            Id = @"PD1.15",
            Type = @"Field",
            Position = @"PD1.15",
            Name = @"Advance Directive Code",
            Length = 705,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0435",
            TableName = @"Advance Directive Code",
            Description = @"This field indicates the patient's instructions to the healthcare facility. Refer to User-defined Table 0435 - Advance Directive Code for suggested values. See also PV2-45 - Advance Directive Code. When PD1-22 - Advanced Directive Last Verified Date is valued, this field is required.",
            Sample = @"",
        };

        // check for repetitions
        if (advanceDirectiveCode.field.FieldRepetitions != null && advanceDirectiveCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(advanceDirectiveCode.Id));
            advanceDirectiveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(advanceDirectiveCode, fieldData);
        }

        return advanceDirectiveCode;
    } 
}

internal HL7V26Field immunizationRegistryStatus;

public HL7V26Field ImmunizationRegistryStatus
{
    get
    {
        if (immunizationRegistryStatus != null)
        {
            return immunizationRegistryStatus;
        }

        immunizationRegistryStatus = new HL7V26Field
        {
            field = message[@"PD1"][16],
            Id = @"PD1.16",
            Type = @"Field",
            Position = @"PD1.16",
            Name = @"Immunization Registry Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0441",
            TableName = @"Immunization Registry Status",
            Description = @"This field identifies the immunization registry status of the patient. Refer to User-defined Table 0441 - Immunization Registry Status for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (immunizationRegistryStatus.field.FieldRepetitions != null && immunizationRegistryStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(immunizationRegistryStatus.Id));
            immunizationRegistryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(immunizationRegistryStatus, fieldData);
        }

        return immunizationRegistryStatus;
    } 
}

internal HL7V26Field immunizationRegistryStatusEffectiveDate;

public HL7V26Field ImmunizationRegistryStatusEffectiveDate
{
    get
    {
        if (immunizationRegistryStatusEffectiveDate != null)
        {
            return immunizationRegistryStatusEffectiveDate;
        }

        immunizationRegistryStatusEffectiveDate = new HL7V26Field
        {
            field = message[@"PD1"][17],
            Id = @"PD1.17",
            Type = @"Field",
            Position = @"PD1.17",
            Name = @"Immunization Registry Status Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the effective date for the immunization registry status reported in PD1-16 - Immunization Registry Status.",
            Sample = @"",
        };

        // check for repetitions
        if (immunizationRegistryStatusEffectiveDate.field.FieldRepetitions != null && immunizationRegistryStatusEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(immunizationRegistryStatusEffectiveDate.Id));
            immunizationRegistryStatusEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(immunizationRegistryStatusEffectiveDate, fieldData);
        }

        return immunizationRegistryStatusEffectiveDate;
    } 
}

internal HL7V26Field publicityCodeEffectiveDate;

public HL7V26Field PublicityCodeEffectiveDate
{
    get
    {
        if (publicityCodeEffectiveDate != null)
        {
            return publicityCodeEffectiveDate;
        }

        publicityCodeEffectiveDate = new HL7V26Field
        {
            field = message[@"PD1"][18],
            Id = @"PD1.18",
            Type = @"Field",
            Position = @"PD1.18",
            Name = @"Publicity Code Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This is the effective date for PD1-11 - Publicity Code.",
            Sample = @"",
        };

        // check for repetitions
        if (publicityCodeEffectiveDate.field.FieldRepetitions != null && publicityCodeEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(publicityCodeEffectiveDate.Id));
            publicityCodeEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(publicityCodeEffectiveDate, fieldData);
        }

        return publicityCodeEffectiveDate;
    } 
}

internal HL7V26Field militaryBranch;

public HL7V26Field MilitaryBranch
{
    get
    {
        if (militaryBranch != null)
        {
            return militaryBranch;
        }

        militaryBranch = new HL7V26Field
        {
            field = message[@"PD1"][19],
            Id = @"PD1.19",
            Type = @"Field",
            Position = @"PD1.19",
            Name = @"Military Branch",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0140",
            TableName = @"Military Service",
            Description = @"This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0140 - Military Service for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (militaryBranch.field.FieldRepetitions != null && militaryBranch.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(militaryBranch.Id));
            militaryBranch.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(militaryBranch, fieldData);
        }

        return militaryBranch;
    } 
}

internal HL7V26Field militaryRankGrade;

public HL7V26Field MilitaryRankGrade
{
    get
    {
        if (militaryRankGrade != null)
        {
            return militaryRankGrade;
        }

        militaryRankGrade = new HL7V26Field
        {
            field = message[@"PD1"][20],
            Id = @"PD1.20",
            Type = @"Field",
            Position = @"PD1.20",
            Name = @"Military Rank/Grade",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0141",
            TableName = @"Military Rank/Grade",
            Description = @"This user-defined field identifies the military rank/grade of the patient. Refer to User-defined Table 0141 - Military Rank/Grade for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (militaryRankGrade.field.FieldRepetitions != null && militaryRankGrade.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(militaryRankGrade.Id));
            militaryRankGrade.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(militaryRankGrade, fieldData);
        }

        return militaryRankGrade;
    } 
}

internal HL7V26Field militaryStatus;

public HL7V26Field MilitaryStatus
{
    get
    {
        if (militaryStatus != null)
        {
            return militaryStatus;
        }

        militaryStatus = new HL7V26Field
        {
            field = message[@"PD1"][21],
            Id = @"PD1.21",
            Type = @"Field",
            Position = @"PD1.21",
            Name = @"Military Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0142",
            TableName = @"Military Status",
            Description = @"This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0142 - Military Status for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (militaryStatus.field.FieldRepetitions != null && militaryStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(militaryStatus.Id));
            militaryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(militaryStatus, fieldData);
        }

        return militaryStatus;
    } 
}

internal HL7V26Field advanceDirectiveLastVerifiedDate;

public HL7V26Field AdvanceDirectiveLastVerifiedDate
{
    get
    {
        if (advanceDirectiveLastVerifiedDate != null)
        {
            return advanceDirectiveLastVerifiedDate;
        }

        advanceDirectiveLastVerifiedDate = new HL7V26Field
        {
            field = message[@"PD1"][22],
            Id = @"PD1.22",
            Type = @"Field",
            Position = @"PD1.22",
            Name = @"Advance Directive Last Verified Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date that all the advance directives held in PD1-15 - Advance Directive Code were last validated. When this field is valued, the field PD1-15 - Advance Directive Code is required.",
            Sample = @"",
        };

        // check for repetitions
        if (advanceDirectiveLastVerifiedDate.field.FieldRepetitions != null && advanceDirectiveLastVerifiedDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(advanceDirectiveLastVerifiedDate.Id));
            advanceDirectiveLastVerifiedDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(advanceDirectiveLastVerifiedDate, fieldData);
        }

        return advanceDirectiveLastVerifiedDate;
    } 
}
    }
}

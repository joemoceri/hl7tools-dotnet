using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentCTD
    {
        public readonly HL7V2Message message;

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
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0131",
                            TableName = @"Contact role",
                            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred. When a referral is inter-enterprise in nature, there are some important relationships that must be identified. For example, it may be necessary to identify the contact representative at the clinic that sent the referral. User defined table 0131 - Contact role is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.1",
                            Type = @"Component",
                            Position = @"CTD.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.2",
                            Type = @"Component",
                            Position = @"CTD.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.3",
                            Type = @"Component",
                            Position = @"CTD.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.4",
                            Type = @"Component",
                            Position = @"CTD.1.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.1.5",
                            Type = @"Component",
                            Position = @"CTD.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"CTD.1.6",
                            Type = @"Component",
                            Position = @"CTD.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2",
                            Type = @"Field",
                            Position = @"CTD.2",
                            Name = @"Contact Name",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the contact person identified in this segment. Generally, this field will describe a person or provider associated with the referral. If this contact name is a physician, you may refer to the CTD-7-contact identifiers (Section 11.5.4.7) for the physician identifier.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1",
                            Type = @"Component",
                            Position = @"CTD.2.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.1",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.1.2",
                            Type = @"SubComponent",
                            Position = @"CTD.2.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.2",
                            Type = @"Component",
                            Position = @"CTD.2.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.3",
                            Type = @"Component",
                            Position = @"CTD.2.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
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
                            Id = @"CTD.2.4",
                            Type = @"Component",
                            Position = @"CTD.2.4",
                            Name = @"Suffix",
                            Length = 0,
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
                            Name = @"Prefix",
                            Length = 0,
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
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.7",
                            Type = @"Component",
                            Position = @"CTD.2.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.2.8",
                            Type = @"Component",
                            Position = @"CTD.2.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3",
                            Type = @"Field",
                            Position = @"CTD.3",
                            Name = @"Contact Address",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the mailing address of the contact person identified in this segment. One of the key components for completing the 'circle of care' and provider/institution bonding is the issuance of follow-up correspondence to the referring provider.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.1",
                            Type = @"Component",
                            Position = @"CTD.3.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.2",
                            Type = @"Component",
                            Position = @"CTD.3.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.3",
                            Type = @"Component",
                            Position = @"CTD.3.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.4",
                            Type = @"Component",
                            Position = @"CTD.3.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.5",
                            Type = @"Component",
                            Position = @"CTD.3.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.6",
                            Type = @"Component",
                            Position = @"CTD.3.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.7",
                            Type = @"Component",
                            Position = @"CTD.3.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.8",
                            Type = @"Component",
                            Position = @"CTD.3.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.9",
                            Type = @"Component",
                            Position = @"CTD.3.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.10",
                            Type = @"Component",
                            Position = @"CTD.3.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.3.11",
                            Type = @"Component",
                            Position = @"CTD.3.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
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
                            Description = @"This field contains the location of the contact, which is required when a contact that may be external to a given enterprise must be referenced. For example, if this contact represents the office manager of the referred-to physician, then the contact location should identify the clinic of the physician or provider to whom this referral has been sent. The identification of the contact's location is specified by an application and facility identifier carried in the facility field. The application identifier and the facility identifier would be used in the same manner as their corresponding fields in the MSH segment ( MSH-3-sending application, MSH-5-receiving application, MSH-4-sending facility, MSH-6-receiving facility ). That is, the facility field will contain an application identifier and facility identifier which describe the location of this contact. However, it should be noted that they may describe a different location because the contact location being referenced in this field may not be the location from which the message originated, which is being described by the MSH.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.1",
                            Type = @"Component",
                            Position = @"CTD.4.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic). After floor, most general patient location designation. User-defined table 0302 - Point of care is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.2",
                            Type = @"Component",
                            Position = @"CTD.4.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room. After nursing unit, most general person location designation. User-defined table 0303 - Room is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.3",
                            Type = @"Component",
                            Position = @"CTD.4.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"Patient bed. After room, most general person location designation. User-defined table 0304 - Bed is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4",
                            Type = @"Component",
                            Position = @"CTD.4.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.20, HD - hierarchic designator).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.1",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.2",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.4.3",
                            Type = @"SubComponent",
                            Position = @"CTD.4.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.5",
                            Type = @"Component",
                            Position = @"CTD.4.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"Location (e.g., Bed) status. User-defined table 0306 - Location status is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.6",
                            Type = @"Component",
                            Position = @"CTD.4.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physicians office. User-defined table 0305 - Person location type is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.7",
                            Type = @"Component",
                            Position = @"CTD.4.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"After facility, most general person location designation. User-defined table 0307 - Building is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.8",
                            Type = @"Component",
                            Position = @"CTD.4.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"After building, most general person location designation. User-defined table 0308 - Floor is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.4.9",
                            Type = @"Component",
                            Position = @"CTD.4.9",
                            Name = @"Location Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5",
                            Type = @"Field",
                            Position = @"CTD.5",
                            Name = @"Contact Communication Information",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the information, such as the phone number or electronic mail address, used to communicate with the contact person or organization.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.1",
                            Type = @"Component",
                            Position = @"CTD.5.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.2",
                            Type = @"Component",
                            Position = @"CTD.5.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.3",
                            Type = @"Component",
                            Position = @"CTD.5.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.5.4",
                            Type = @"Component",
                            Position = @"CTD.5.4",
                            Name = @"Email Address",
                            Length = 0,
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
                            Length = 0,
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
                            Length = 0,
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
                            Name = @"Phone Number",
                            Length = 0,
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
                            Length = 0,
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
                            Id = @"CTD.5.9",
                            Type = @"Component",
                            Position = @"CTD.5.9",
                            Name = @"Any Text",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6",
                            Type = @"Field",
                            Position = @"CTD.6",
                            Name = @"Preferred Method Of Contact",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0185",
                            TableName = @"Preferred method of contact",
                            Description = @"This field contains the preferred method to use when communicating with the contact person. Refer to user-defined table 0185 - Preferred method of contact for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.1",
                            Type = @"Component",
                            Position = @"CTD.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.2",
                            Type = @"Component",
                            Position = @"CTD.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.3",
                            Type = @"Component",
                            Position = @"CTD.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.4",
                            Type = @"Component",
                            Position = @"CTD.6.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.6.5",
                            Type = @"Component",
                            Position = @"CTD.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"CTD.6.6",
                            Type = @"Component",
                            Position = @"CTD.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                            DataType = @"PI",
                            DataTypeName = @"Person Identifier",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7.1",
                            Type = @"Component",
                            Position = @"CTD.7.1",
                            Name = @"ID Number",
                            Length = 0,
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
                            Id = @"CTD.7.2",
                            Type = @"Component",
                            Position = @"CTD.7.2",
                            Name = @"Type Of ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CTD.7.3",
                            Type = @"Component",
                            Position = @"CTD.7.3",
                            Name = @"Other Qualifying Info",
                            Length = 0,
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
                        
                        },
                        };
            }
        }

        public HL7V231SegmentCTD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field contactRole;

public HL7V231Field ContactRole
{
    get
    {
        if (contactRole != null)
        {
            return contactRole;
        }

        contactRole = new HL7V231Field
        {
            field = message[@"CTD"][1],
            Id = @"CTD.1",
            Type = @"Field",
            Position = @"CTD.1",
            Name = @"Contact Role",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0131",
            TableName = @"Contact role",
            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred. When a referral is inter-enterprise in nature, there are some important relationships that must be identified. For example, it may be necessary to identify the contact representative at the clinic that sent the referral. User defined table 0131 - Contact role is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return contactRole;
    } 
}
internal HL7V231Field contactName;

public HL7V231Field ContactName
{
    get
    {
        if (contactName != null)
        {
            return contactName;
        }

        contactName = new HL7V231Field
        {
            field = message[@"CTD"][2],
            Id = @"CTD.2",
            Type = @"Field",
            Position = @"CTD.2",
            Name = @"Contact Name",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the contact person identified in this segment. Generally, this field will describe a person or provider associated with the referral. If this contact name is a physician, you may refer to the CTD-7-contact identifiers (Section 11.5.4.7) for the physician identifier.",
            Sample = @"",
        };

        

        

        

        return contactName;
    } 
}
internal HL7V231Field contactAddress;

public HL7V231Field ContactAddress
{
    get
    {
        if (contactAddress != null)
        {
            return contactAddress;
        }

        contactAddress = new HL7V231Field
        {
            field = message[@"CTD"][3],
            Id = @"CTD.3",
            Type = @"Field",
            Position = @"CTD.3",
            Name = @"Contact Address",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the mailing address of the contact person identified in this segment. One of the key components for completing the 'circle of care' and provider/institution bonding is the issuance of follow-up correspondence to the referring provider.",
            Sample = @"",
        };

        

        

        

        return contactAddress;
    } 
}
internal HL7V231Field contactLocation;

public HL7V231Field ContactLocation
{
    get
    {
        if (contactLocation != null)
        {
            return contactLocation;
        }

        contactLocation = new HL7V231Field
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
            Description = @"This field contains the location of the contact, which is required when a contact that may be external to a given enterprise must be referenced. For example, if this contact represents the office manager of the referred-to physician, then the contact location should identify the clinic of the physician or provider to whom this referral has been sent. The identification of the contact's location is specified by an application and facility identifier carried in the facility field. The application identifier and the facility identifier would be used in the same manner as their corresponding fields in the MSH segment ( MSH-3-sending application, MSH-5-receiving application, MSH-4-sending facility, MSH-6-receiving facility ). That is, the facility field will contain an application identifier and facility identifier which describe the location of this contact. However, it should be noted that they may describe a different location because the contact location being referenced in this field may not be the location from which the message originated, which is being described by the MSH.",
            Sample = @"",
        };

        

        

        

        return contactLocation;
    } 
}
internal HL7V231Field contactCommunicationInformation;

public HL7V231Field ContactCommunicationInformation
{
    get
    {
        if (contactCommunicationInformation != null)
        {
            return contactCommunicationInformation;
        }

        contactCommunicationInformation = new HL7V231Field
        {
            field = message[@"CTD"][5],
            Id = @"CTD.5",
            Type = @"Field",
            Position = @"CTD.5",
            Name = @"Contact Communication Information",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the information, such as the phone number or electronic mail address, used to communicate with the contact person or organization.",
            Sample = @"",
        };

        

        

        

        return contactCommunicationInformation;
    } 
}
internal HL7V231Field preferredMethodOfContact;

public HL7V231Field PreferredMethodOfContact
{
    get
    {
        if (preferredMethodOfContact != null)
        {
            return preferredMethodOfContact;
        }

        preferredMethodOfContact = new HL7V231Field
        {
            field = message[@"CTD"][6],
            Id = @"CTD.6",
            Type = @"Field",
            Position = @"CTD.6",
            Name = @"Preferred Method Of Contact",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0185",
            TableName = @"Preferred method of contact",
            Description = @"This field contains the preferred method to use when communicating with the contact person. Refer to user-defined table 0185 - Preferred method of contact for suggested values.",
            Sample = @"",
        };

        

        

        

        return preferredMethodOfContact;
    } 
}
internal HL7V231Field contactIdentifiers;

public HL7V231Field ContactIdentifiers
{
    get
    {
        if (contactIdentifiers != null)
        {
            return contactIdentifiers;
        }

        contactIdentifiers = new HL7V231Field
        {
            field = message[@"CTD"][7],
            Id = @"CTD.7",
            Type = @"Field",
            Position = @"CTD.7",
            Name = @"Contact Identifiers",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PI",
            DataTypeName = @"Person Identifier",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return contactIdentifiers;
    } 
}

    }
}

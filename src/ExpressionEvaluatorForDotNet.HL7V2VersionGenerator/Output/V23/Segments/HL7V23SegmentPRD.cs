using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPRD
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PRD"; } }

        public string SegmentId { get { return @"PRD"; } }
        
        public string LongName { get { return @"Provider Data"; } }
        
        public string Description { get { return @"This segment will be employed as part of a patient referral message and its related transactions.  The PRD segment contains data specifically focused on a referral, and it is inter-enterprise in nature.  The justification for this new segment comes from the fact that we are dealing with referrals that are external to the facilities that received them.  Therefore, using a segment such as the current PV1 would be inadequate for all the return information that may be required by the receiving facility or application.  In addition, the PV1 does not always provide information sufficient to enable the external facility to make a complete identification of the referring entity.  The information contained in the PRD segment will include the referring provider, the referred-to provider, the referred-to location or service, and the referring provider clinic address."; } }
        
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
                            Id = @"PRD.1",
                            Type = @"Field",
                            Position = @"PRD.1",
                            Name = @"Role",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0286",
                            TableName = @"Provider role",
                            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred.  When a referral is inter-enterprise in nature, there are several important relationships that must be identified.  For example, the proper identification of both the referring and the referred-to provider is critical for proper processing of a referral.  In addition, some enterprises may want information regarding a consulting provider or the identity of the person who actually prepared the referral.  This contact role may also expand to represent affiliated persons to whom information regarding this referral must be forwarded or copied.  Refer to user-defined table 0286 - Provider role for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.1",
                            Type = @"Component",
                            Position = @"PRD.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.2",
                            Type = @"Component",
                            Position = @"PRD.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.3",
                            Type = @"Component",
                            Position = @"PRD.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.4",
                            Type = @"Component",
                            Position = @"PRD.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.5",
                            Type = @"Component",
                            Position = @"PRD.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.1.6",
                            Type = @"Component",
                            Position = @"PRD.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.2",
                            Type = @"Field",
                            Position = @"PRD.2",
                            Name = @"Provider Name",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the provider identified in this segment.  Generally, this field will describe a physician associated with the referral.  However, it is not limited to physicians.  This field may contain the name of any valid healthcare provider associated with this referral.  If this Provider Name is a physician’s name, you may refer to PRD-1-provider identifiers (Section 11.5.3.7) for the physician identifier",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.2.1",
                            Type = @"Component",
                            Position = @"PRD.2.1",
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
                            Id = @"PRD.2.2",
                            Type = @"Component",
                            Position = @"PRD.2.2",
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
                            Id = @"PRD.2.3",
                            Type = @"Component",
                            Position = @"PRD.2.3",
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
                            Id = @"PRD.2.4",
                            Type = @"Component",
                            Position = @"PRD.2.4",
                            Name = @"Suffix",
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
                            Id = @"PRD.2.5",
                            Type = @"Component",
                            Position = @"PRD.2.5",
                            Name = @"Prefix",
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
                            Id = @"PRD.2.6",
                            Type = @"Component",
                            Position = @"PRD.2.6",
                            Name = @"Degree",
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
                            Id = @"PRD.2.7",
                            Type = @"Component",
                            Position = @"PRD.2.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.2.8",
                            Type = @"Component",
                            Position = @"PRD.2.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3",
                            Type = @"Field",
                            Position = @"PRD.3",
                            Name = @"Provider Address",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the mailing address of the provider identified in this segment.  One of the key components to completing the “circle of care” and provider/institution bonding is the issuance of follow-up correspondence to the referring provider",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.1",
                            Type = @"Component",
                            Position = @"PRD.3.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.2",
                            Type = @"Component",
                            Position = @"PRD.3.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.3",
                            Type = @"Component",
                            Position = @"PRD.3.3",
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
                            Id = @"PRD.3.4",
                            Type = @"Component",
                            Position = @"PRD.3.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"tate or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.5",
                            Type = @"Component",
                            Position = @"PRD.3.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.6",
                            Type = @"Component",
                            Position = @"PRD.3.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.7",
                            Type = @"Component",
                            Position = @"PRD.3.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.8",
                            Type = @"Component",
                            Position = @"PRD.3.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.9",
                            Type = @"Component",
                            Position = @"PRD.3.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.3.10",
                            Type = @"Component",
                            Position = @"PRD.3.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4",
                            Type = @"Field",
                            Position = @"PRD.4",
                            Name = @"Provider Location",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the location of the provider as needed when a provider that may be external to a given enterprise must be referenced.  For example, if this provider represented the referred-to physician, the PRD-4-provider location should identify the clinic of the physician or provider to whom this referral has been sent.  The identification of the provider’s location is specified by an application and facility identifier carried in the facility field.  The application ID and facility ID would be used in the same manner as their corresponding fields in the MSH segment (MSH-3-sending application, MSH-5-receiving application MSH-4-sending facility, MSH-6-receiving facility).  That is, the facility field will contain an application identifier and facility identifier which describe the location of this provider.  However, it should be noted that they may describe a different location because the provider location being referenced in this field may not be the location from which the message originated, which is being described by the MSH",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.1",
                            Type = @"Component",
                            Position = @"PRD.4.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic).  After floor, most general patient location designation.  Refer to user-defined table 0302 - Point of care for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.2",
                            Type = @"Component",
                            Position = @"PRD.4.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room.  After nursing unit, most general person location designation.  Refer to user-defined table 0303 - Room for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.3",
                            Type = @"Component",
                            Position = @"PRD.4.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"Patient bed.  After room, most general person location designation.  Refer to user-defined table 0304 - Bed for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.4",
                            Type = @"Component",
                            Position = @"PRD.4.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.4.1",
                            Type = @"SubComponent",
                            Position = @"PRD.4.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.4.2",
                            Type = @"SubComponent",
                            Position = @"PRD.4.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.4.3",
                            Type = @"SubComponent",
                            Position = @"PRD.4.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.5",
                            Type = @"Component",
                            Position = @"PRD.4.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"Location (e.g., Bed) status.  Refer to user-defined table 0306 - Location status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.6",
                            Type = @"Component",
                            Position = @"PRD.4.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physician’s office.  Refer to userdefined table 0305 - Person location type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.7",
                            Type = @"Component",
                            Position = @"PRD.4.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"After facility, most general person location designation.  Refer to user-defined table 0307 - Building for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.8",
                            Type = @"Component",
                            Position = @"PRD.4.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"After building, most general person location designation.  Refer to user-defined table 0308 - Floor for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.4.9",
                            Type = @"Component",
                            Position = @"PRD.4.9",
                            Name = @"Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5",
                            Type = @"Field",
                            Position = @"PRD.5",
                            Name = @"Provider Communication Information",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains information, such as the phone number or electronic mail address, used to communicate with the provider or organization",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5.1",
                            Type = @"Component",
                            Position = @"PRD.5.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5.2",
                            Type = @"Component",
                            Position = @"PRD.5.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5.3",
                            Type = @"Component",
                            Position = @"PRD.5.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5.4",
                            Type = @"Component",
                            Position = @"PRD.5.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.5.5",
                            Type = @"Component",
                            Position = @"PRD.5.5",
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
                            Id = @"PRD.5.6",
                            Type = @"Component",
                            Position = @"PRD.5.6",
                            Name = @"Area/city Code",
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
                            Id = @"PRD.5.7",
                            Type = @"Component",
                            Position = @"PRD.5.7",
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
                            Id = @"PRD.5.8",
                            Type = @"Component",
                            Position = @"PRD.5.8",
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
                            Id = @"PRD.5.9",
                            Type = @"Component",
                            Position = @"PRD.5.9",
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
                            Id = @"PRD.6",
                            Type = @"Field",
                            Position = @"PRD.6",
                            Name = @"Preferred Method of Contact",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0185",
                            TableName = @"Preferred method of contact",
                            Description = @"This field contains the preferred method to use when communicating with the provider.  Refer to user-defined table 0185 - Preferred method of contact for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.1",
                            Type = @"Component",
                            Position = @"PRD.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.2",
                            Type = @"Component",
                            Position = @"PRD.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.3",
                            Type = @"Component",
                            Position = @"PRD.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.4",
                            Type = @"Component",
                            Position = @"PRD.6.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.5",
                            Type = @"Component",
                            Position = @"PRD.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.6.6",
                            Type = @"Component",
                            Position = @"PRD.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.7",
                            Type = @"Field",
                            Position = @"PRD.7",
                            Name = @"Provider Identifiers",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PI",
                            DataTypeName = @"Person Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This repeating field contains the provider’s unique identifiers such as UPIN, Medicare and Medicaid numbers.  Refer to PRA-6-practitioner ID numbers  in Chapter 8 ( Section 8.6.3.6, “Practitioner ID numbers”) for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.7.1",
                            Type = @"Component",
                            Position = @"PRD.7.1",
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
                            Id = @"PRD.7.2",
                            Type = @"Component",
                            Position = @"PRD.7.2",
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
                            Id = @"PRD.7.3",
                            Type = @"Component",
                            Position = @"PRD.7.3",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRD.8",
                            Type = @"Field",
                            Position = @"PRD.8",
                            Name = @"Effective Start Date of Role",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the role of the provider effectively began.  For example, this date may represent the date on which a physician was assigned as a patient’s primary care provider

Note: The PRD-8-effective start date of role and PRD-9-effective end date of role fields should not be used as trigger events.  For example, they should not be used to trigger a change in role.  These two dates are for informational purposes only. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.8.1",
                            Type = @"Component",
                            Position = @"PRD.8.1",
                            Name = @"Time Of An Event",
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
                            Id = @"PRD.9",
                            Type = @"Field",
                            Position = @"PRD.9",
                            Name = @"Effective End Date of Role",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the role of the provider effectively ended.  For example, this date may represent the date that a physician was removed as a patient’s primary care provider.

Note: The PRD-8-effective start date of role and PRD-9-effective end date of role fields should not be used as trigger events.  For example, they should not be used to trigger a change in role.  These two dates are for informational purposes only. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PRD.9.1",
                            Type = @"Component",
                            Position = @"PRD.9.1",
                            Name = @"Time Of An Event",
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

        public HL7V23SegmentPRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field role;

public HL7V23Field Role
{
    get
    {
        if (role != null)
        {
            return role;
        }

        role = new HL7V23Field
        {
            field = message[@"PRD"][1],
            Id = @"PRD.1",
            Type = @"Field",
            Position = @"PRD.1",
            Name = @"Role",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0286",
            TableName = @"Provider role",
            Description = @"This field contains the contact role that defines the relationship of the person described in this segment to the patient being referred.  When a referral is inter-enterprise in nature, there are several important relationships that must be identified.  For example, the proper identification of both the referring and the referred-to provider is critical for proper processing of a referral.  In addition, some enterprises may want information regarding a consulting provider or the identity of the person who actually prepared the referral.  This contact role may also expand to represent affiliated persons to whom information regarding this referral must be forwarded or copied.  Refer to user-defined table 0286 - Provider role for suggested values",
            Sample = @"",
        };

        

        

        

        return role;
    } 
}
internal HL7V23Field providerName;

public HL7V23Field ProviderName
{
    get
    {
        if (providerName != null)
        {
            return providerName;
        }

        providerName = new HL7V23Field
        {
            field = message[@"PRD"][2],
            Id = @"PRD.2",
            Type = @"Field",
            Position = @"PRD.2",
            Name = @"Provider Name",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the provider identified in this segment.  Generally, this field will describe a physician associated with the referral.  However, it is not limited to physicians.  This field may contain the name of any valid healthcare provider associated with this referral.  If this Provider Name is a physician’s name, you may refer to PRD-1-provider identifiers (Section 11.5.3.7) for the physician identifier",
            Sample = @"",
        };

        

        

        

        return providerName;
    } 
}
internal HL7V23Field providerAddress;

public HL7V23Field ProviderAddress
{
    get
    {
        if (providerAddress != null)
        {
            return providerAddress;
        }

        providerAddress = new HL7V23Field
        {
            field = message[@"PRD"][3],
            Id = @"PRD.3",
            Type = @"Field",
            Position = @"PRD.3",
            Name = @"Provider Address",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the mailing address of the provider identified in this segment.  One of the key components to completing the “circle of care” and provider/institution bonding is the issuance of follow-up correspondence to the referring provider",
            Sample = @"",
        };

        

        

        

        return providerAddress;
    } 
}
internal HL7V23Field providerLocation;

public HL7V23Field ProviderLocation
{
    get
    {
        if (providerLocation != null)
        {
            return providerLocation;
        }

        providerLocation = new HL7V23Field
        {
            field = message[@"PRD"][4],
            Id = @"PRD.4",
            Type = @"Field",
            Position = @"PRD.4",
            Name = @"Provider Location",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the provider as needed when a provider that may be external to a given enterprise must be referenced.  For example, if this provider represented the referred-to physician, the PRD-4-provider location should identify the clinic of the physician or provider to whom this referral has been sent.  The identification of the provider’s location is specified by an application and facility identifier carried in the facility field.  The application ID and facility ID would be used in the same manner as their corresponding fields in the MSH segment (MSH-3-sending application, MSH-5-receiving application MSH-4-sending facility, MSH-6-receiving facility).  That is, the facility field will contain an application identifier and facility identifier which describe the location of this provider.  However, it should be noted that they may describe a different location because the provider location being referenced in this field may not be the location from which the message originated, which is being described by the MSH",
            Sample = @"",
        };

        

        

        

        return providerLocation;
    } 
}
internal HL7V23Field providerCommunicationInformation;

public HL7V23Field ProviderCommunicationInformation
{
    get
    {
        if (providerCommunicationInformation != null)
        {
            return providerCommunicationInformation;
        }

        providerCommunicationInformation = new HL7V23Field
        {
            field = message[@"PRD"][5],
            Id = @"PRD.5",
            Type = @"Field",
            Position = @"PRD.5",
            Name = @"Provider Communication Information",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains information, such as the phone number or electronic mail address, used to communicate with the provider or organization",
            Sample = @"",
        };

        

        

        

        return providerCommunicationInformation;
    } 
}
internal HL7V23Field preferredMethodofContact;

public HL7V23Field PreferredMethodofContact
{
    get
    {
        if (preferredMethodofContact != null)
        {
            return preferredMethodofContact;
        }

        preferredMethodofContact = new HL7V23Field
        {
            field = message[@"PRD"][6],
            Id = @"PRD.6",
            Type = @"Field",
            Position = @"PRD.6",
            Name = @"Preferred Method of Contact",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0185",
            TableName = @"Preferred method of contact",
            Description = @"This field contains the preferred method to use when communicating with the provider.  Refer to user-defined table 0185 - Preferred method of contact for suggested values",
            Sample = @"",
        };

        

        

        

        return preferredMethodofContact;
    } 
}
internal HL7V23Field providerIdentifiers;

public HL7V23Field ProviderIdentifiers
{
    get
    {
        if (providerIdentifiers != null)
        {
            return providerIdentifiers;
        }

        providerIdentifiers = new HL7V23Field
        {
            field = message[@"PRD"][7],
            Id = @"PRD.7",
            Type = @"Field",
            Position = @"PRD.7",
            Name = @"Provider Identifiers",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PI",
            DataTypeName = @"Person Identifier",
            TableId = null,
            TableName = null,
            Description = @"This repeating field contains the provider’s unique identifiers such as UPIN, Medicare and Medicaid numbers.  Refer to PRA-6-practitioner ID numbers  in Chapter 8 ( Section 8.6.3.6, “Practitioner ID numbers”) for suggested values",
            Sample = @"",
        };

        

        

        

        return providerIdentifiers;
    } 
}
internal HL7V23Field effectiveStartDateofRole;

public HL7V23Field EffectiveStartDateofRole
{
    get
    {
        if (effectiveStartDateofRole != null)
        {
            return effectiveStartDateofRole;
        }

        effectiveStartDateofRole = new HL7V23Field
        {
            field = message[@"PRD"][8],
            Id = @"PRD.8",
            Type = @"Field",
            Position = @"PRD.8",
            Name = @"Effective Start Date of Role",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the role of the provider effectively began.  For example, this date may represent the date on which a physician was assigned as a patient’s primary care provider

Note: The PRD-8-effective start date of role and PRD-9-effective end date of role fields should not be used as trigger events.  For example, they should not be used to trigger a change in role.  These two dates are for informational purposes only. ",
            Sample = @"",
        };

        

        

        

        return effectiveStartDateofRole;
    } 
}
internal HL7V23Field effectiveEndDateofRole;

public HL7V23Field EffectiveEndDateofRole
{
    get
    {
        if (effectiveEndDateofRole != null)
        {
            return effectiveEndDateofRole;
        }

        effectiveEndDateofRole = new HL7V23Field
        {
            field = message[@"PRD"][9],
            Id = @"PRD.9",
            Type = @"Field",
            Position = @"PRD.9",
            Name = @"Effective End Date of Role",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the role of the provider effectively ended.  For example, this date may represent the date that a physician was removed as a patient’s primary care provider.

Note: The PRD-8-effective start date of role and PRD-9-effective end date of role fields should not be used as trigger events.  For example, they should not be used to trigger a change in role.  These two dates are for informational purposes only. ",
            Sample = @"",
        };

        

        

        

        return effectiveEndDateofRole;
    } 
}

    }
}

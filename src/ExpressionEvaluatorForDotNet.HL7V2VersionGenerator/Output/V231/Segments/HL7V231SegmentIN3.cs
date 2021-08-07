using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentIN3
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IN3"; } }

        public string SegmentId { get { return @"IN3"; } }
        
        public string LongName { get { return @"Insurance additional information, certification segment"; } }
        
        public string Description { get { return @"The IN3 segment contains additional insurance information for certifying the need for patient care. Fields used by this segment are defined by HCFA, or other regulatory agencies."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Id = @"IN3.1",
                            Type = @"Field",
                            Position = @"IN3.1",
                            Name = @"Set ID - IN3",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"IN3-1-set ID-IN3 contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc. The set ID in the IN3 segment is used when there are multiple certifications for the insurance plan identified in IN1-2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2",
                            Type = @"Field",
                            Position = @"IN3.2",
                            Name = @"Certification Number",
                            Length = 59,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number assigned by the certification agency. The assigning authority and identifier type code are strongly recommended for all CX data types.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.1",
                            Type = @"Component",
                            Position = @"IN3.2.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that a ST data type is allowed instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.2",
                            Type = @"Component",
                            Position = @"IN3.2.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.3",
                            Type = @"Component",
                            Position = @"IN3.2.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit). Refer to HL7 table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.4",
                            Type = @"Component",
                            Position = @"IN3.2.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.4.1",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.1",
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
                            Id = @"IN3.2.4.2",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.2",
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
                            Id = @"IN3.2.4.3",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.3",
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
                            Id = @"IN3.2.5",
                            Type = @"Component",
                            Position = @"IN3.2.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.6",
                            Type = @"Component",
                            Position = @"IN3.2.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents: <namespace ID (IS)> & < universal ID (ST)> & <universal ID type (ID)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.6.1",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.1",
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
                            Id = @"IN3.2.6.2",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.2",
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
                            Id = @"IN3.2.6.3",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3",
                            Type = @"Field",
                            Position = @"IN3.3",
                            Name = @"Certified By",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the party that approved the certification. Multiple names and identifiers for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.1",
                            Type = @"Component",
                            Position = @"IN3.3.1",
                            Name = @"Id Number",
                            Length = 0,
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
                            Id = @"IN3.3.2",
                            Type = @"Component",
                            Position = @"IN3.3.2",
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
                            Id = @"IN3.3.2.1",
                            Type = @"SubComponent",
                            Position = @"IN3.3.2.1",
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
                            Id = @"IN3.3.2.2",
                            Type = @"SubComponent",
                            Position = @"IN3.3.2.2",
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
                            Id = @"IN3.3.3",
                            Type = @"Component",
                            Position = @"IN3.3.3",
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
                            Id = @"IN3.3.4",
                            Type = @"Component",
                            Position = @"IN3.3.4",
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
                            Id = @"IN3.3.5",
                            Type = @"Component",
                            Position = @"IN3.3.5",
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
                            Id = @"IN3.3.6",
                            Type = @"Component",
                            Position = @"IN3.3.6",
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
                            Id = @"IN3.3.7",
                            Type = @"Component",
                            Position = @"IN3.3.7",
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
                            Id = @"IN3.3.8",
                            Type = @"Component",
                            Position = @"IN3.3.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.9",
                            Type = @"Component",
                            Position = @"IN3.3.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.1",
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
                            Id = @"IN3.3.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.2",
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
                            Id = @"IN3.3.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.3",
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
                            Id = @"IN3.3.10",
                            Type = @"Component",
                            Position = @"IN3.3.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.11",
                            Type = @"Component",
                            Position = @"IN3.3.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.12",
                            Type = @"Component",
                            Position = @"IN3.3.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.13",
                            Type = @"Component",
                            Position = @"IN3.3.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.14",
                            Type = @"Component",
                            Position = @"IN3.3.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.1",
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
                            Id = @"IN3.3.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.2",
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
                            Id = @"IN3.3.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.3",
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
                            Id = @"IN3.3.15",
                            Type = @"Component",
                            Position = @"IN3.3.15",
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
                            Id = @"IN3.4",
                            Type = @"Field",
                            Position = @"IN3.4",
                            Name = @"Certification Required",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether certification is required. Refer to HL7table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5",
                            Type = @"Field",
                            Position = @"IN3.5",
                            Name = @"Penalty",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_PEN",
                            DataTypeName = @"Penalty",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the penalty, in dollars or a percentage, that will be assessed if the pre-certification is not performed. Refer to user-defined table 0148 - Penalty type for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.1",
                            Type = @"Component",
                            Position = @"IN3.5.1",
                            Name = @"Penalty Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0148",
                            TableName = @"Penalty type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.2",
                            Type = @"Component",
                            Position = @"IN3.5.2",
                            Name = @"Penalty Amount",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.6",
                            Type = @"Field",
                            Position = @"IN3.6",
                            Name = @"Certification Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time stamp that indicates when insurance was certified to exist for the patient.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.6.1",
                            Type = @"Component",
                            Position = @"IN3.6.1",
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
                            Id = @"IN3.7",
                            Type = @"Field",
                            Position = @"IN3.7",
                            Name = @"Certification Modify Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the certification was modified.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.7.1",
                            Type = @"Component",
                            Position = @"IN3.7.1",
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
                            Id = @"IN3.8",
                            Type = @"Field",
                            Position = @"IN3.8",
                            Name = @"Operator",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name party who is responsible for sending this certification information. Multiple names for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.1",
                            Type = @"Component",
                            Position = @"IN3.8.1",
                            Name = @"Id Number",
                            Length = 0,
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
                            Id = @"IN3.8.2",
                            Type = @"Component",
                            Position = @"IN3.8.2",
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
                            Id = @"IN3.8.2.1",
                            Type = @"SubComponent",
                            Position = @"IN3.8.2.1",
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
                            Id = @"IN3.8.2.2",
                            Type = @"SubComponent",
                            Position = @"IN3.8.2.2",
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
                            Id = @"IN3.8.3",
                            Type = @"Component",
                            Position = @"IN3.8.3",
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
                            Id = @"IN3.8.4",
                            Type = @"Component",
                            Position = @"IN3.8.4",
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
                            Id = @"IN3.8.5",
                            Type = @"Component",
                            Position = @"IN3.8.5",
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
                            Id = @"IN3.8.6",
                            Type = @"Component",
                            Position = @"IN3.8.6",
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
                            Id = @"IN3.8.7",
                            Type = @"Component",
                            Position = @"IN3.8.7",
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
                            Id = @"IN3.8.8",
                            Type = @"Component",
                            Position = @"IN3.8.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.9",
                            Type = @"Component",
                            Position = @"IN3.8.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.1",
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
                            Id = @"IN3.8.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.2",
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
                            Id = @"IN3.8.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.3",
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
                            Id = @"IN3.8.10",
                            Type = @"Component",
                            Position = @"IN3.8.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.11",
                            Type = @"Component",
                            Position = @"IN3.8.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.12",
                            Type = @"Component",
                            Position = @"IN3.8.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.13",
                            Type = @"Component",
                            Position = @"IN3.8.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.14",
                            Type = @"Component",
                            Position = @"IN3.8.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.1",
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
                            Id = @"IN3.8.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.2",
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
                            Id = @"IN3.8.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.3",
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
                            Id = @"IN3.8.15",
                            Type = @"Component",
                            Position = @"IN3.8.15",
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
                            Id = @"IN3.9",
                            Type = @"Field",
                            Position = @"IN3.9",
                            Name = @"Certification Begin Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that this certification begins.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.10",
                            Type = @"Field",
                            Position = @"IN3.10",
                            Name = @"Certification End Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains date that this certification ends.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11",
                            Type = @"Field",
                            Position = @"IN3.11",
                            Name = @"Days",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTN",
                            DataTypeName = @"Day Type And Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of days for which this certification is valid. This field applies to denied, pending, or approved days. Refer to user-defined table 0149 - Day type for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.1",
                            Type = @"Component",
                            Position = @"IN3.11.1",
                            Name = @"Day Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0149",
                            TableName = @"Day type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.2",
                            Type = @"Component",
                            Position = @"IN3.11.2",
                            Name = @"Number Of Days",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12",
                            Type = @"Field",
                            Position = @"IN3.12",
                            Name = @"Non-Concur Code/Description",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0233",
                            TableName = @"Non-concur code/description",
                            Description = @"This field contains the non-concur code and description for a denied request. User-defined table 0233 - Non-concur code/description is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.1",
                            Type = @"Component",
                            Position = @"IN3.12.1",
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
                            Id = @"IN3.12.2",
                            Type = @"Component",
                            Position = @"IN3.12.2",
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
                            Id = @"IN3.12.3",
                            Type = @"Component",
                            Position = @"IN3.12.3",
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
                            Id = @"IN3.12.4",
                            Type = @"Component",
                            Position = @"IN3.12.4",
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
                            Id = @"IN3.12.5",
                            Type = @"Component",
                            Position = @"IN3.12.5",
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
                            Id = @"IN3.12.6",
                            Type = @"Component",
                            Position = @"IN3.12.6",
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
                            Id = @"IN3.13",
                            Type = @"Field",
                            Position = @"IN3.13",
                            Name = @"Non-Concur Effective Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the effective date of the non-concurrence classification.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.13.1",
                            Type = @"Component",
                            Position = @"IN3.13.1",
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
                            Id = @"IN3.14",
                            Type = @"Field",
                            Position = @"IN3.14",
                            Name = @"Physician Reviewer",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains the physician who works with and reviews cases that are pending physician review for the certification agency. Multiple names for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2. User-defined table 0010 - Physician ID is used as the HL7 identifier for the user-defined table of value for this field .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.1",
                            Type = @"Component",
                            Position = @"IN3.14.1",
                            Name = @"Id Number",
                            Length = 0,
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
                            Id = @"IN3.14.2",
                            Type = @"Component",
                            Position = @"IN3.14.2",
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
                            Id = @"IN3.14.2.1",
                            Type = @"SubComponent",
                            Position = @"IN3.14.2.1",
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
                            Id = @"IN3.14.2.2",
                            Type = @"SubComponent",
                            Position = @"IN3.14.2.2",
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
                            Id = @"IN3.14.3",
                            Type = @"Component",
                            Position = @"IN3.14.3",
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
                            Id = @"IN3.14.4",
                            Type = @"Component",
                            Position = @"IN3.14.4",
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
                            Id = @"IN3.14.5",
                            Type = @"Component",
                            Position = @"IN3.14.5",
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
                            Id = @"IN3.14.6",
                            Type = @"Component",
                            Position = @"IN3.14.6",
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
                            Id = @"IN3.14.7",
                            Type = @"Component",
                            Position = @"IN3.14.7",
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
                            Id = @"IN3.14.8",
                            Type = @"Component",
                            Position = @"IN3.14.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.9",
                            Type = @"Component",
                            Position = @"IN3.14.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.1",
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
                            Id = @"IN3.14.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.2",
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
                            Id = @"IN3.14.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.3",
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
                            Id = @"IN3.14.10",
                            Type = @"Component",
                            Position = @"IN3.14.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.11",
                            Type = @"Component",
                            Position = @"IN3.14.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.12",
                            Type = @"Component",
                            Position = @"IN3.14.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.13",
                            Type = @"Component",
                            Position = @"IN3.14.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.14",
                            Type = @"Component",
                            Position = @"IN3.14.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.1",
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
                            Id = @"IN3.14.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.2",
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
                            Id = @"IN3.14.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.3",
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
                            Id = @"IN3.14.15",
                            Type = @"Component",
                            Position = @"IN3.14.15",
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
                            Id = @"IN3.15",
                            Type = @"Field",
                            Position = @"IN3.15",
                            Name = @"Certification Contact",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the party contacted at the certification agency who granted the certification and communicated the certification number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16",
                            Type = @"Field",
                            Position = @"IN3.16",
                            Name = @"Certification Contact Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the phone number of the certification contact. Multiple phone numbers for the same certification contact may be sent in this sequence. The primary phone number is assumed to be in the first repetition. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16.1",
                            Type = @"Component",
                            Position = @"IN3.16.1",
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
                            Id = @"IN3.16.2",
                            Type = @"Component",
                            Position = @"IN3.16.2",
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
                            Id = @"IN3.16.3",
                            Type = @"Component",
                            Position = @"IN3.16.3",
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
                            Id = @"IN3.16.4",
                            Type = @"Component",
                            Position = @"IN3.16.4",
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
                            Id = @"IN3.16.5",
                            Type = @"Component",
                            Position = @"IN3.16.5",
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
                            Id = @"IN3.16.6",
                            Type = @"Component",
                            Position = @"IN3.16.6",
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
                            Id = @"IN3.16.7",
                            Type = @"Component",
                            Position = @"IN3.16.7",
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
                            Id = @"IN3.16.8",
                            Type = @"Component",
                            Position = @"IN3.16.8",
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
                            Id = @"IN3.16.9",
                            Type = @"Component",
                            Position = @"IN3.16.9",
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
                            Id = @"IN3.17",
                            Type = @"Field",
                            Position = @"IN3.17",
                            Name = @"Appeal Reason",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0345",
                            TableName = @"Appeal reason",
                            Description = @"This field contains the reason that an appeal was made on a non-concur for certification. Refer to user-defined table 0345 - Appeal reason for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.1",
                            Type = @"Component",
                            Position = @"IN3.17.1",
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
                            Id = @"IN3.17.2",
                            Type = @"Component",
                            Position = @"IN3.17.2",
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
                            Id = @"IN3.17.3",
                            Type = @"Component",
                            Position = @"IN3.17.3",
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
                            Id = @"IN3.17.4",
                            Type = @"Component",
                            Position = @"IN3.17.4",
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
                            Id = @"IN3.17.5",
                            Type = @"Component",
                            Position = @"IN3.17.5",
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
                            Id = @"IN3.17.6",
                            Type = @"Component",
                            Position = @"IN3.17.6",
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
                            Id = @"IN3.18",
                            Type = @"Field",
                            Position = @"IN3.18",
                            Name = @"Certification Agency",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0346",
                            TableName = @"Certification agency",
                            Description = @"This field contains the certification agency. Refer to user-defined table 0346 - Certification agency for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.1",
                            Type = @"Component",
                            Position = @"IN3.18.1",
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
                            Id = @"IN3.18.2",
                            Type = @"Component",
                            Position = @"IN3.18.2",
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
                            Id = @"IN3.18.3",
                            Type = @"Component",
                            Position = @"IN3.18.3",
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
                            Id = @"IN3.18.4",
                            Type = @"Component",
                            Position = @"IN3.18.4",
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
                            Id = @"IN3.18.5",
                            Type = @"Component",
                            Position = @"IN3.18.5",
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
                            Id = @"IN3.18.6",
                            Type = @"Component",
                            Position = @"IN3.18.6",
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
                            Id = @"IN3.19",
                            Type = @"Field",
                            Position = @"IN3.19",
                            Name = @"Certification Agency Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the phone number of the certification agency. The components of this field are described in Chapter 2.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19.1",
                            Type = @"Component",
                            Position = @"IN3.19.1",
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
                            Id = @"IN3.19.2",
                            Type = @"Component",
                            Position = @"IN3.19.2",
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
                            Id = @"IN3.19.3",
                            Type = @"Component",
                            Position = @"IN3.19.3",
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
                            Id = @"IN3.19.4",
                            Type = @"Component",
                            Position = @"IN3.19.4",
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
                            Id = @"IN3.19.5",
                            Type = @"Component",
                            Position = @"IN3.19.5",
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
                            Id = @"IN3.19.6",
                            Type = @"Component",
                            Position = @"IN3.19.6",
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
                            Id = @"IN3.19.7",
                            Type = @"Component",
                            Position = @"IN3.19.7",
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
                            Id = @"IN3.19.8",
                            Type = @"Component",
                            Position = @"IN3.19.8",
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
                            Id = @"IN3.19.9",
                            Type = @"Component",
                            Position = @"IN3.19.9",
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
                            Id = @"IN3.20",
                            Type = @"Field",
                            Position = @"IN3.20",
                            Name = @"Pre-Certification Req/Window",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"PCF",
                            DataTypeName = @"Pre-certification Required",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates whether pre-certification is required for particular patient types, and the time window for obtaining the certification. The following components of this field are defined as follows:",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.1",
                            Type = @"Component",
                            Position = @"IN3.20.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0150",
                            TableName = @"Pre-certification patient type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.2",
                            Type = @"Component",
                            Position = @"IN3.20.2",
                            Name = @"Pre-certification Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3",
                            Type = @"Component",
                            Position = @"IN3.20.3",
                            Name = @"Pre-certification Window",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3.1",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.1",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.21",
                            Type = @"Field",
                            Position = @"IN3.21",
                            Name = @"Case Manager",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the entity who/which is handling this particular patient's case (e.g., UR nurse, or a specific facility location).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.22",
                            Type = @"Field",
                            Position = @"IN3.22",
                            Name = @"Second Opinion Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the second opinion was obtained.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.23",
                            Type = @"Field",
                            Position = @"IN3.23",
                            Name = @"Second Opinion Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0151",
                            TableName = @"Second opinion status",
                            Description = @"This field contains the code that represents the status of the second opinion. User-defined table 0151 - Second opinion status is used as the HL7 identifier for the user-defined table for this field. .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.24",
                            Type = @"Field",
                            Position = @"IN3.24",
                            Name = @"Second Opinion Documentation Received",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0152",
                            TableName = @"Second opinion documentation received",
                            Description = @"Use this field if accompanying documentation has been received by the provider. User-defined table 0152 - Second opinion documentation received is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25",
                            Type = @"Field",
                            Position = @"IN3.25",
                            Name = @"Second Opinion Physician",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains an identifier and name of the physician who provided the second opinion. Multiple names and identifiers for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2. User-defined table 0010 - Physician ID is used as the HL7 identifier for the user-defined table of values for this field .",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.1",
                            Type = @"Component",
                            Position = @"IN3.25.1",
                            Name = @"Id Number",
                            Length = 0,
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
                            Id = @"IN3.25.2",
                            Type = @"Component",
                            Position = @"IN3.25.2",
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
                            Id = @"IN3.25.2.1",
                            Type = @"SubComponent",
                            Position = @"IN3.25.2.1",
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
                            Id = @"IN3.25.2.2",
                            Type = @"SubComponent",
                            Position = @"IN3.25.2.2",
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
                            Id = @"IN3.25.3",
                            Type = @"Component",
                            Position = @"IN3.25.3",
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
                            Id = @"IN3.25.4",
                            Type = @"Component",
                            Position = @"IN3.25.4",
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
                            Id = @"IN3.25.5",
                            Type = @"Component",
                            Position = @"IN3.25.5",
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
                            Id = @"IN3.25.6",
                            Type = @"Component",
                            Position = @"IN3.25.6",
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
                            Id = @"IN3.25.7",
                            Type = @"Component",
                            Position = @"IN3.25.7",
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
                            Id = @"IN3.25.8",
                            Type = @"Component",
                            Position = @"IN3.25.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.9",
                            Type = @"Component",
                            Position = @"IN3.25.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.1",
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
                            Id = @"IN3.25.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.2",
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
                            Id = @"IN3.25.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.3",
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
                            Id = @"IN3.25.10",
                            Type = @"Component",
                            Position = @"IN3.25.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.11",
                            Type = @"Component",
                            Position = @"IN3.25.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.12",
                            Type = @"Component",
                            Position = @"IN3.25.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.13",
                            Type = @"Component",
                            Position = @"IN3.25.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.14",
                            Type = @"Component",
                            Position = @"IN3.25.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.1",
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
                            Id = @"IN3.25.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.2",
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
                            Id = @"IN3.25.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.3",
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
                            Id = @"IN3.25.15",
                            Type = @"Component",
                            Position = @"IN3.25.15",
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
                        };
            }
        }

        public HL7V231SegmentIN3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field setIDIN3;

public HL7V231Field SetIDIN3
{
    get
    {
        if (setIDIN3 != null)
        {
            return setIDIN3;
        }

        setIDIN3 = new HL7V231Field
        {
            field = message[@"IN3"][1],
            Id = @"IN3.1",
            Type = @"Field",
            Position = @"IN3.1",
            Name = @"Set ID - IN3",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"IN3-1-set ID-IN3 contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc. The set ID in the IN3 segment is used when there are multiple certifications for the insurance plan identified in IN1-2.",
            Sample = @"",
        };

        

        

        

        return setIDIN3;
    } 
}
internal HL7V231Field certificationNumber;

public HL7V231Field CertificationNumber
{
    get
    {
        if (certificationNumber != null)
        {
            return certificationNumber;
        }

        certificationNumber = new HL7V231Field
        {
            field = message[@"IN3"][2],
            Id = @"IN3.2",
            Type = @"Field",
            Position = @"IN3.2",
            Name = @"Certification Number",
            Length = 59,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number assigned by the certification agency. The assigning authority and identifier type code are strongly recommended for all CX data types.",
            Sample = @"",
        };

        

        

        

        return certificationNumber;
    } 
}
internal HL7V231Field certifiedBy;

public HL7V231Field CertifiedBy
{
    get
    {
        if (certifiedBy != null)
        {
            return certifiedBy;
        }

        certifiedBy = new HL7V231Field
        {
            field = message[@"IN3"][3],
            Id = @"IN3.3",
            Type = @"Field",
            Position = @"IN3.3",
            Name = @"Certified By",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the party that approved the certification. Multiple names and identifiers for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
            Sample = @"",
        };

        

        

        

        return certifiedBy;
    } 
}
internal HL7V231Field certificationRequired;

public HL7V231Field CertificationRequired
{
    get
    {
        if (certificationRequired != null)
        {
            return certificationRequired;
        }

        certificationRequired = new HL7V231Field
        {
            field = message[@"IN3"][4],
            Id = @"IN3.4",
            Type = @"Field",
            Position = @"IN3.4",
            Name = @"Certification Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether certification is required. Refer to HL7table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return certificationRequired;
    } 
}
internal HL7V231Field penalty;

public HL7V231Field Penalty
{
    get
    {
        if (penalty != null)
        {
            return penalty;
        }

        penalty = new HL7V231Field
        {
            field = message[@"IN3"][5],
            Id = @"IN3.5",
            Type = @"Field",
            Position = @"IN3.5",
            Name = @"Penalty",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PEN",
            DataTypeName = @"Penalty",
            TableId = null,
            TableName = null,
            Description = @"This field contains the penalty, in dollars or a percentage, that will be assessed if the pre-certification is not performed. Refer to user-defined table 0148 - Penalty type for suggested values.",
            Sample = @"",
        };

        

        

        

        return penalty;
    } 
}
internal HL7V231Field certificationDateTime;

public HL7V231Field CertificationDateTime
{
    get
    {
        if (certificationDateTime != null)
        {
            return certificationDateTime;
        }

        certificationDateTime = new HL7V231Field
        {
            field = message[@"IN3"][6],
            Id = @"IN3.6",
            Type = @"Field",
            Position = @"IN3.6",
            Name = @"Certification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time stamp that indicates when insurance was certified to exist for the patient.",
            Sample = @"",
        };

        

        

        

        return certificationDateTime;
    } 
}
internal HL7V231Field certificationModifyDateTime;

public HL7V231Field CertificationModifyDateTime
{
    get
    {
        if (certificationModifyDateTime != null)
        {
            return certificationModifyDateTime;
        }

        certificationModifyDateTime = new HL7V231Field
        {
            field = message[@"IN3"][7],
            Id = @"IN3.7",
            Type = @"Field",
            Position = @"IN3.7",
            Name = @"Certification Modify Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the certification was modified.",
            Sample = @"",
        };

        

        

        

        return certificationModifyDateTime;
    } 
}
internal HL7V231Field operator;

public HL7V231Field Operator
{
    get
    {
        if (operator != null)
        {
            return operator;
        }

        operator = new HL7V231Field
        {
            field = message[@"IN3"][8],
            Id = @"IN3.8",
            Type = @"Field",
            Position = @"IN3.8",
            Name = @"Operator",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name party who is responsible for sending this certification information. Multiple names for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
            Sample = @"",
        };

        

        

        

        return operator;
    } 
}
internal HL7V231Field certificationBeginDate;

public HL7V231Field CertificationBeginDate
{
    get
    {
        if (certificationBeginDate != null)
        {
            return certificationBeginDate;
        }

        certificationBeginDate = new HL7V231Field
        {
            field = message[@"IN3"][9],
            Id = @"IN3.9",
            Type = @"Field",
            Position = @"IN3.9",
            Name = @"Certification Begin Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that this certification begins.",
            Sample = @"",
        };

        

        

        

        return certificationBeginDate;
    } 
}
internal HL7V231Field certificationEndDate;

public HL7V231Field CertificationEndDate
{
    get
    {
        if (certificationEndDate != null)
        {
            return certificationEndDate;
        }

        certificationEndDate = new HL7V231Field
        {
            field = message[@"IN3"][10],
            Id = @"IN3.10",
            Type = @"Field",
            Position = @"IN3.10",
            Name = @"Certification End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains date that this certification ends.",
            Sample = @"",
        };

        

        

        

        return certificationEndDate;
    } 
}
internal HL7V231Field days;

public HL7V231Field Days
{
    get
    {
        if (days != null)
        {
            return days;
        }

        days = new HL7V231Field
        {
            field = message[@"IN3"][11],
            Id = @"IN3.11",
            Type = @"Field",
            Position = @"IN3.11",
            Name = @"Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTN",
            DataTypeName = @"Day Type And Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days for which this certification is valid. This field applies to denied, pending, or approved days. Refer to user-defined table 0149 - Day type for suggested values.",
            Sample = @"",
        };

        

        

        

        return days;
    } 
}
internal HL7V231Field nonConcurCodeDescription;

public HL7V231Field NonConcurCodeDescription
{
    get
    {
        if (nonConcurCodeDescription != null)
        {
            return nonConcurCodeDescription;
        }

        nonConcurCodeDescription = new HL7V231Field
        {
            field = message[@"IN3"][12],
            Id = @"IN3.12",
            Type = @"Field",
            Position = @"IN3.12",
            Name = @"Non-Concur Code/Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0233",
            TableName = @"Non-concur code/description",
            Description = @"This field contains the non-concur code and description for a denied request. User-defined table 0233 - Non-concur code/description is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return nonConcurCodeDescription;
    } 
}
internal HL7V231Field nonConcurEffectiveDateTime;

public HL7V231Field NonConcurEffectiveDateTime
{
    get
    {
        if (nonConcurEffectiveDateTime != null)
        {
            return nonConcurEffectiveDateTime;
        }

        nonConcurEffectiveDateTime = new HL7V231Field
        {
            field = message[@"IN3"][13],
            Id = @"IN3.13",
            Type = @"Field",
            Position = @"IN3.13",
            Name = @"Non-Concur Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date of the non-concurrence classification.",
            Sample = @"",
        };

        

        

        

        return nonConcurEffectiveDateTime;
    } 
}
internal HL7V231Field physicianReviewer;

public HL7V231Field PhysicianReviewer
{
    get
    {
        if (physicianReviewer != null)
        {
            return physicianReviewer;
        }

        physicianReviewer = new HL7V231Field
        {
            field = message[@"IN3"][14],
            Id = @"IN3.14",
            Type = @"Field",
            Position = @"IN3.14",
            Name = @"Physician Reviewer",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains the physician who works with and reviews cases that are pending physician review for the certification agency. Multiple names for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2. User-defined table 0010 - Physician ID is used as the HL7 identifier for the user-defined table of value for this field .",
            Sample = @"",
        };

        

        

        

        return physicianReviewer;
    } 
}
internal HL7V231Field certificationContact;

public HL7V231Field CertificationContact
{
    get
    {
        if (certificationContact != null)
        {
            return certificationContact;
        }

        certificationContact = new HL7V231Field
        {
            field = message[@"IN3"][15],
            Id = @"IN3.15",
            Type = @"Field",
            Position = @"IN3.15",
            Name = @"Certification Contact",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the party contacted at the certification agency who granted the certification and communicated the certification number.",
            Sample = @"",
        };

        

        

        

        return certificationContact;
    } 
}
internal HL7V231Field certificationContactPhoneNumber;

public HL7V231Field CertificationContactPhoneNumber
{
    get
    {
        if (certificationContactPhoneNumber != null)
        {
            return certificationContactPhoneNumber;
        }

        certificationContactPhoneNumber = new HL7V231Field
        {
            field = message[@"IN3"][16],
            Id = @"IN3.16",
            Type = @"Field",
            Position = @"IN3.16",
            Name = @"Certification Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the certification contact. Multiple phone numbers for the same certification contact may be sent in this sequence. The primary phone number is assumed to be in the first repetition. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2.",
            Sample = @"",
        };

        

        

        

        return certificationContactPhoneNumber;
    } 
}
internal HL7V231Field appealReason;

public HL7V231Field AppealReason
{
    get
    {
        if (appealReason != null)
        {
            return appealReason;
        }

        appealReason = new HL7V231Field
        {
            field = message[@"IN3"][17],
            Id = @"IN3.17",
            Type = @"Field",
            Position = @"IN3.17",
            Name = @"Appeal Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0345",
            TableName = @"Appeal reason",
            Description = @"This field contains the reason that an appeal was made on a non-concur for certification. Refer to user-defined table 0345 - Appeal reason for suggested values.",
            Sample = @"",
        };

        

        

        

        return appealReason;
    } 
}
internal HL7V231Field certificationAgency;

public HL7V231Field CertificationAgency
{
    get
    {
        if (certificationAgency != null)
        {
            return certificationAgency;
        }

        certificationAgency = new HL7V231Field
        {
            field = message[@"IN3"][18],
            Id = @"IN3.18",
            Type = @"Field",
            Position = @"IN3.18",
            Name = @"Certification Agency",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0346",
            TableName = @"Certification agency",
            Description = @"This field contains the certification agency. Refer to user-defined table 0346 - Certification agency for suggested values.",
            Sample = @"",
        };

        

        

        

        return certificationAgency;
    } 
}
internal HL7V231Field certificationAgencyPhoneNumber;

public HL7V231Field CertificationAgencyPhoneNumber
{
    get
    {
        if (certificationAgencyPhoneNumber != null)
        {
            return certificationAgencyPhoneNumber;
        }

        certificationAgencyPhoneNumber = new HL7V231Field
        {
            field = message[@"IN3"][19],
            Id = @"IN3.19",
            Type = @"Field",
            Position = @"IN3.19",
            Name = @"Certification Agency Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the certification agency. The components of this field are described in Chapter 2.",
            Sample = @"",
        };

        

        

        

        return certificationAgencyPhoneNumber;
    } 
}
internal HL7V231Field preCertificationReqWindow;

public HL7V231Field PreCertificationReqWindow
{
    get
    {
        if (preCertificationReqWindow != null)
        {
            return preCertificationReqWindow;
        }

        preCertificationReqWindow = new HL7V231Field
        {
            field = message[@"IN3"][20],
            Id = @"IN3.20",
            Type = @"Field",
            Position = @"IN3.20",
            Name = @"Pre-Certification Req/Window",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PCF",
            DataTypeName = @"Pre-certification Required",
            TableId = null,
            TableName = null,
            Description = @"This field indicates whether pre-certification is required for particular patient types, and the time window for obtaining the certification. The following components of this field are defined as follows:",
            Sample = @"",
        };

        

        

        

        return preCertificationReqWindow;
    } 
}
internal HL7V231Field caseManager;

public HL7V231Field CaseManager
{
    get
    {
        if (caseManager != null)
        {
            return caseManager;
        }

        caseManager = new HL7V231Field
        {
            field = message[@"IN3"][21],
            Id = @"IN3.21",
            Type = @"Field",
            Position = @"IN3.21",
            Name = @"Case Manager",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the entity who/which is handling this particular patient's case (e.g., UR nurse, or a specific facility location).",
            Sample = @"",
        };

        

        

        

        return caseManager;
    } 
}
internal HL7V231Field secondOpinionDate;

public HL7V231Field SecondOpinionDate
{
    get
    {
        if (secondOpinionDate != null)
        {
            return secondOpinionDate;
        }

        secondOpinionDate = new HL7V231Field
        {
            field = message[@"IN3"][22],
            Id = @"IN3.22",
            Type = @"Field",
            Position = @"IN3.22",
            Name = @"Second Opinion Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the second opinion was obtained.",
            Sample = @"",
        };

        

        

        

        return secondOpinionDate;
    } 
}
internal HL7V231Field secondOpinionStatus;

public HL7V231Field SecondOpinionStatus
{
    get
    {
        if (secondOpinionStatus != null)
        {
            return secondOpinionStatus;
        }

        secondOpinionStatus = new HL7V231Field
        {
            field = message[@"IN3"][23],
            Id = @"IN3.23",
            Type = @"Field",
            Position = @"IN3.23",
            Name = @"Second Opinion Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0151",
            TableName = @"Second opinion status",
            Description = @"This field contains the code that represents the status of the second opinion. User-defined table 0151 - Second opinion status is used as the HL7 identifier for the user-defined table for this field. .",
            Sample = @"",
        };

        

        

        

        return secondOpinionStatus;
    } 
}
internal HL7V231Field secondOpinionDocumentationReceived;

public HL7V231Field SecondOpinionDocumentationReceived
{
    get
    {
        if (secondOpinionDocumentationReceived != null)
        {
            return secondOpinionDocumentationReceived;
        }

        secondOpinionDocumentationReceived = new HL7V231Field
        {
            field = message[@"IN3"][24],
            Id = @"IN3.24",
            Type = @"Field",
            Position = @"IN3.24",
            Name = @"Second Opinion Documentation Received",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0152",
            TableName = @"Second opinion documentation received",
            Description = @"Use this field if accompanying documentation has been received by the provider. User-defined table 0152 - Second opinion documentation received is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        

        

        

        return secondOpinionDocumentationReceived;
    } 
}
internal HL7V231Field secondOpinionPhysician;

public HL7V231Field SecondOpinionPhysician
{
    get
    {
        if (secondOpinionPhysician != null)
        {
            return secondOpinionPhysician;
        }

        secondOpinionPhysician = new HL7V231Field
        {
            field = message[@"IN3"][25],
            Id = @"IN3.25",
            Type = @"Field",
            Position = @"IN3.25",
            Name = @"Second Opinion Physician",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains an identifier and name of the physician who provided the second opinion. Multiple names and identifiers for the same person may be sent in this sequence. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this field are described in Chapter 2. User-defined table 0010 - Physician ID is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
        };

        

        

        

        return secondOpinionPhysician;
    } 
}

    }
}

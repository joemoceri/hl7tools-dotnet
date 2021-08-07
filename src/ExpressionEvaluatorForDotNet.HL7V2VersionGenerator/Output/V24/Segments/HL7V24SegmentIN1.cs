using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentIN1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IN1"; } }

        public string SegmentId { get { return @"IN1"; } }
        
        public string LongName { get { return @"Insurance"; } }
        
        public string Description { get { return @"The IN1 segment contains insurance policy coverage information necessary to produce properly pro-rated patient and insurance bills."; } }
        
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
                            Id = @"IN1.1",
                            Type = @"Field",
                            Position = @"IN1.1",
                            Name = @"Set ID - IN1",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"IN1-1 - set ID contains the number that identifies this transaction.  For the first occurrence the sequence number shall be 1, for the second occurrence it shall be 2, etc. The Set ID in the IN1 segment is used to aggregate the grouping of insurance segments.  For example, a patient with two insurance plans would have two groupings of insurance segments.  IN1, IN2, and IN3 segments for Insurance Plan A with set ID 1, followed by IN1, IN2, and IN3 segments for Insurance Plan B, with set ID 2.  There is no set ID in the IN2 segment because it is contained in the IN1, IN2, IN3 grouping, and is therefore not needed.  The set ID in the IN3 segment is provided because there can be multiple repetitions of the IN3 segment if there are multiple certifications for the same insurance plan, e.g., IN1 (Set ID 1), IN2, IN3 (Set ID 1), IN3 (Set ID 2), IN3 (Set ID 3)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2",
                            Type = @"Field",
                            Position = @"IN1.2",
                            Name = @"Insurance Plan ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0072",
                            TableName = @"Insurance plan ID",
                            Description = @"This field contains a unique identifier for the insurance plan.  Refer to User-defined Table 0072 - Insurance plan ID for suggested values.  To eliminate a plan, the plan could be sent with null values in each subsequent element.  If the respective systems can support it, a null value can be sent in the plan field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.1",
                            Type = @"Component",
                            Position = @"IN1.2.1",
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
                            Id = @"IN1.2.2",
                            Type = @"Component",
                            Position = @"IN1.2.2",
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
                            Id = @"IN1.2.3",
                            Type = @"Component",
                            Position = @"IN1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.4",
                            Type = @"Component",
                            Position = @"IN1.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.5",
                            Type = @"Component",
                            Position = @"IN1.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.2.6",
                            Type = @"Component",
                            Position = @"IN1.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3",
                            Type = @"Field",
                            Position = @"IN1.3",
                            Name = @"Insurance Company ID",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains unique identifiers for the insurance company.  The assigning authority and identifier type code are strongly recommended for all CX data types",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.1",
                            Type = @"Component",
                            Position = @"IN1.3.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Definition: The value of the identifier itself. It is similar to the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that a ST data type is used instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.2",
                            Type = @"Component",
                            Position = @"IN1.3.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.3",
                            Type = @"Component",
                            Position = @"IN1.3.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit). Refer to HL7 Table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.4",
                            Type = @"Component",
                            Position = @"IN1.3.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type . User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.3.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.3.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.5",
                            Type = @"Component",
                            Position = @"IN1.3.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer toHL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.6",
                            Type = @"Component",
                            Position = @"IN1.3.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.3.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.3.7",
                            Type = @"Component",
                            Position = @"IN1.3.7",
                            Name = @"Effective Date",
                            Length = 0,
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
                            Id = @"IN1.3.8",
                            Type = @"Component",
                            Position = @"IN1.3.8",
                            Name = @"Expiration Date",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4",
                            Type = @"Field",
                            Position = @"IN1.4",
                            Name = @"Insurance Company Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the insurance company.  Multiple names for the same insurance company may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.1",
                            Type = @"Component",
                            Position = @"IN1.4.1",
                            Name = @"Organization Name",
                            Length = 0,
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
                            Id = @"IN1.4.2",
                            Type = @"Component",
                            Position = @"IN1.4.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.3",
                            Type = @"Component",
                            Position = @"IN1.4.3",
                            Name = @"Id Number",
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
                            Id = @"IN1.4.4",
                            Type = @"Component",
                            Position = @"IN1.4.4",
                            Name = @"Check Digit",
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
                            Id = @"IN1.4.5",
                            Type = @"Component",
                            Position = @"IN1.4.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.6",
                            Type = @"Component",
                            Position = @"IN1.4.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.4.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.4.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.7",
                            Type = @"Component",
                            Position = @"IN1.4.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.8",
                            Type = @"Component",
                            Position = @"IN1.4.8",
                            Name = @"Assigning Facility Id",
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
                            Id = @"IN1.4.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.4.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.4.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.4.9",
                            Type = @"Component",
                            Position = @"IN1.4.9",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5",
                            Type = @"Field",
                            Position = @"IN1.5",
                            Name = @"Insurance Company Address",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of the insurance company.  Multiple addresses for the same insurance company may be sent in this field.  The mailing address is assumed to be in the first repetition. When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.1",
                            Type = @"Component",
                            Position = @"IN1.5.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"See section 2.9.38, SAD - street address for description of components.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.5.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.5.1.2",
                            Name = @"Street Name",
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
                            Id = @"IN1.5.1.3",
                            Type = @"SubComponent",
                            Position = @"IN1.5.1.3",
                            Name = @"Dwelling Number",
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
                            Id = @"IN1.5.2",
                            Type = @"Component",
                            Position = @"IN1.5.2",
                            Name = @"Other Designation",
                            Length = 0,
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
                            Id = @"IN1.5.3",
                            Type = @"Component",
                            Position = @"IN1.5.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This may be the name of the city, or district or place depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.4",
                            Type = @"Component",
                            Position = @"IN1.5.4",
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
                            Id = @"IN1.5.5",
                            Type = @"Component",
                            Position = @"IN1.5.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.6",
                            Type = @"Component",
                            Position = @"IN1.5.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code . HL7 Table 0399 - Country code is defined to contain these 3-character codes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.7",
                            Type = @"Component",
                            Position = @"IN1.5.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 Table 0190 - Address type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.8",
                            Type = @"Component",
                            Position = @"IN1.5.8",
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
                            Id = @"IN1.5.9",
                            Type = @"Component",
                            Position = @"IN1.5.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides . User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.10",
                            Type = @"Component",
                            Position = @"IN1.5.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides . User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.11",
                            Type = @"Component",
                            Position = @"IN1.5.11",
                            Name = @"Address Representation Code",
                            Length = 0,
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
                            Id = @"IN1.5.12",
                            Type = @"Component",
                            Position = @"IN1.5.12",
                            Name = @"Address Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period in which this address was valid",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.5.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.5.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6",
                            Type = @"Field",
                            Position = @"IN1.6",
                            Name = @"Insurance Co Contact Person",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the person who should be contacted at the insurance company. Multiple names for the same contact person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.1",
                            Type = @"Component",
                            Position = @"IN1.6.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19, FN - family name.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.6.1.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.6.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.6.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.1.3",
                            Type = @"SubComponent",
                            Position = @"IN1.6.1.3",
                            Name = @"Own Surname",
                            Length = 0,
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
                            Id = @"IN1.6.1.4",
                            Type = @"SubComponent",
                            Position = @"IN1.6.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.1.5",
                            Type = @"SubComponent",
                            Position = @"IN1.6.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.2",
                            Type = @"Component",
                            Position = @"IN1.6.2",
                            Name = @"Given Name",
                            Length = 0,
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
                            Id = @"IN1.6.3",
                            Type = @"Component",
                            Position = @"IN1.6.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
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
                            Id = @"IN1.6.4",
                            Type = @"Component",
                            Position = @"IN1.6.4",
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
                            Id = @"IN1.6.5",
                            Type = @"Component",
                            Position = @"IN1.6.5",
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
                            Id = @"IN1.6.6",
                            Type = @"Component",
                            Position = @"IN1.6.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.7",
                            Type = @"Component",
                            Position = @"IN1.6.7",
                            Name = @"Name Type Code",
                            Length = 0,
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
                            Id = @"IN1.6.8",
                            Type = @"Component",
                            Position = @"IN1.6.8",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                            Id = @"IN1.6.9",
                            Type = @"Component",
                            Position = @"IN1.6.9",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"Subcomponents of name context: <identifier (ID)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ID)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.9.1",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.1",
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
                            Id = @"IN1.6.9.2",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.2",
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
                            Id = @"IN1.6.9.3",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.9.4",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.9.5",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.9.6",
                            Type = @"SubComponent",
                            Position = @"IN1.6.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10",
                            Type = @"Component",
                            Position = @"IN1.6.10",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.6.10.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.6.11",
                            Type = @"Component",
                            Position = @"IN1.6.11",
                            Name = @"Name Assembly Order",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7",
                            Type = @"Field",
                            Position = @"IN1.7",
                            Name = @"Insurance Co Phone Number",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the phone number of the insurance company.  Multiple phone numbers for the same insurance company may be sent in this field.  The primary phone number is assumed to be in the first repetition.  When the primary phone number is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.1",
                            Type = @"Component",
                            Position = @"IN1.7.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.9.45, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.7.2",
                            Type = @"Component",
                            Position = @"IN1.7.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
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
                            Id = @"IN1.7.3",
                            Type = @"Component",
                            Position = @"IN1.7.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
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
                            Id = @"IN1.7.4",
                            Type = @"Component",
                            Position = @"IN1.7.4",
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
                            Id = @"IN1.7.5",
                            Type = @"Component",
                            Position = @"IN1.7.5",
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
                            Id = @"IN1.7.6",
                            Type = @"Component",
                            Position = @"IN1.7.6",
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
                            Id = @"IN1.7.7",
                            Type = @"Component",
                            Position = @"IN1.7.7",
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
                            Id = @"IN1.7.8",
                            Type = @"Component",
                            Position = @"IN1.7.8",
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
                            Id = @"IN1.7.9",
                            Type = @"Component",
                            Position = @"IN1.7.9",
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
                            Id = @"IN1.8",
                            Type = @"Field",
                            Position = @"IN1.8",
                            Name = @"Group Number",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the group number of the insured’s insurance",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9",
                            Type = @"Field",
                            Position = @"IN1.9",
                            Name = @"Group Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the group name of the insured’s insurance",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.1",
                            Type = @"Component",
                            Position = @"IN1.9.1",
                            Name = @"Organization Name",
                            Length = 0,
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
                            Id = @"IN1.9.2",
                            Type = @"Component",
                            Position = @"IN1.9.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.3",
                            Type = @"Component",
                            Position = @"IN1.9.3",
                            Name = @"Id Number",
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
                            Id = @"IN1.9.4",
                            Type = @"Component",
                            Position = @"IN1.9.4",
                            Name = @"Check Digit",
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
                            Id = @"IN1.9.5",
                            Type = @"Component",
                            Position = @"IN1.9.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.6",
                            Type = @"Component",
                            Position = @"IN1.9.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.9.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.9.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.7",
                            Type = @"Component",
                            Position = @"IN1.9.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.8",
                            Type = @"Component",
                            Position = @"IN1.9.8",
                            Name = @"Assigning Facility Id",
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
                            Id = @"IN1.9.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.9.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.9.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.9.9",
                            Type = @"Component",
                            Position = @"IN1.9.9",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10",
                            Type = @"Field",
                            Position = @"IN1.10",
                            Name = @"Insured's Group Emp ID",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field holds the group employer ID for the insured’s insurance.  The assigning authority and identifier type code are strongly recommended for all CX data types",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.1",
                            Type = @"Component",
                            Position = @"IN1.10.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Definition: The value of the identifier itself. It is similar to the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that a ST data type is used instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.2",
                            Type = @"Component",
                            Position = @"IN1.10.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.3",
                            Type = @"Component",
                            Position = @"IN1.10.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit). Refer to HL7 Table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.4",
                            Type = @"Component",
                            Position = @"IN1.10.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type . User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.10.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.10.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.5",
                            Type = @"Component",
                            Position = @"IN1.10.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer toHL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.6",
                            Type = @"Component",
                            Position = @"IN1.10.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.10.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.10.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.10.7",
                            Type = @"Component",
                            Position = @"IN1.10.7",
                            Name = @"Effective Date",
                            Length = 0,
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
                            Id = @"IN1.10.8",
                            Type = @"Component",
                            Position = @"IN1.10.8",
                            Name = @"Expiration Date",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11",
                            Type = @"Field",
                            Position = @"IN1.11",
                            Name = @"Insured's Group Emp Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the employer that provides the employee’s insurance.  Multiple names for the same employer may be sent in this sequence.  The legal name must be sent first.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.1",
                            Type = @"Component",
                            Position = @"IN1.11.1",
                            Name = @"Organization Name",
                            Length = 0,
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
                            Id = @"IN1.11.2",
                            Type = @"Component",
                            Position = @"IN1.11.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.3",
                            Type = @"Component",
                            Position = @"IN1.11.3",
                            Name = @"Id Number",
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
                            Id = @"IN1.11.4",
                            Type = @"Component",
                            Position = @"IN1.11.4",
                            Name = @"Check Digit",
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
                            Id = @"IN1.11.5",
                            Type = @"Component",
                            Position = @"IN1.11.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.6",
                            Type = @"Component",
                            Position = @"IN1.11.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.11.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.11.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.7",
                            Type = @"Component",
                            Position = @"IN1.11.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.8",
                            Type = @"Component",
                            Position = @"IN1.11.8",
                            Name = @"Assigning Facility Id",
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
                            Id = @"IN1.11.8.1",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.8.2",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.11.8.3",
                            Type = @"SubComponent",
                            Position = @"IN1.11.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.11.9",
                            Type = @"Component",
                            Position = @"IN1.11.9",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.12",
                            Type = @"Field",
                            Position = @"IN1.12",
                            Name = @"Plan Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the insurance goes into effect",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.13",
                            Type = @"Field",
                            Position = @"IN1.13",
                            Name = @"Plan Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the last date of service that the insurance will cover or be responsible for",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.14",
                            Type = @"Field",
                            Position = @"IN1.14",
                            Name = @"Authorization Information",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AUI",
                            DataTypeName = @"Authorization Information",
                            TableId = null,
                            TableName = null,
                            Description = @"Based on the type of insurance, some coverage plans require that an authorization number or code be obtained prior to all non-emergency admissions, and within 48 hours of an emergency admission. Insurance billing would not be permitted without this number.  The date and source of authorization are the components of this field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.14.1",
                            Type = @"Component",
                            Position = @"IN1.14.1",
                            Name = @"Authorization Number",
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
                            Id = @"IN1.14.2",
                            Type = @"Component",
                            Position = @"IN1.14.2",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.14.3",
                            Type = @"Component",
                            Position = @"IN1.14.3",
                            Name = @"Source",
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
                            Id = @"IN1.15",
                            Type = @"Field",
                            Position = @"IN1.15",
                            Name = @"Plan Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0086",
                            TableName = @"Plan ID",
                            Description = @"This field contains the coding structure that identifies the various plan types, for example, Medicare, Medicaid, Blue Cross, HMO, etc.  Refer to User-defined Table 0086 - Plan ID for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16",
                            Type = @"Field",
                            Position = @"IN1.16",
                            Name = @"Name Of Insured",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the insured person.  The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by the insurance policy.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.1",
                            Type = @"Component",
                            Position = @"IN1.16.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19, FN - family name.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.16.1.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.16.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.16.1.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.1.3",
                            Type = @"SubComponent",
                            Position = @"IN1.16.1.3",
                            Name = @"Own Surname",
                            Length = 0,
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
                            Id = @"IN1.16.1.4",
                            Type = @"SubComponent",
                            Position = @"IN1.16.1.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.1.5",
                            Type = @"SubComponent",
                            Position = @"IN1.16.1.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.2",
                            Type = @"Component",
                            Position = @"IN1.16.2",
                            Name = @"Given Name",
                            Length = 0,
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
                            Id = @"IN1.16.3",
                            Type = @"Component",
                            Position = @"IN1.16.3",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
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
                            Id = @"IN1.16.4",
                            Type = @"Component",
                            Position = @"IN1.16.4",
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
                            Id = @"IN1.16.5",
                            Type = @"Component",
                            Position = @"IN1.16.5",
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
                            Id = @"IN1.16.6",
                            Type = @"Component",
                            Position = @"IN1.16.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.7",
                            Type = @"Component",
                            Position = @"IN1.16.7",
                            Name = @"Name Type Code",
                            Length = 0,
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
                            Id = @"IN1.16.8",
                            Type = @"Component",
                            Position = @"IN1.16.8",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                            Id = @"IN1.16.9",
                            Type = @"Component",
                            Position = @"IN1.16.9",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"Subcomponents of name context: <identifier (ID)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ID)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.9.1",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.1",
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
                            Id = @"IN1.16.9.2",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.2",
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
                            Id = @"IN1.16.9.3",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.9.4",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.9.5",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.9.6",
                            Type = @"SubComponent",
                            Position = @"IN1.16.9.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10",
                            Type = @"Component",
                            Position = @"IN1.16.10",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.1",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.10.2",
                            Type = @"SubComponent",
                            Position = @"IN1.16.10.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.16.11",
                            Type = @"Component",
                            Position = @"IN1.16.11",
                            Name = @"Name Assembly Order",
                            Length = 0,
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17",
                            Type = @"Field",
                            Position = @"IN1.17",
                            Name = @"Insured's Relationship To Patient",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0063",
                            TableName = @"Relationship",
                            Description = @"This field indicates the insured’s relationship to the patient.  Refer to User-defined Table 0063 Relationship for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17.1",
                            Type = @"Component",
                            Position = @"IN1.17.1",
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
                            Id = @"IN1.17.2",
                            Type = @"Component",
                            Position = @"IN1.17.2",
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
                            Id = @"IN1.17.3",
                            Type = @"Component",
                            Position = @"IN1.17.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17.4",
                            Type = @"Component",
                            Position = @"IN1.17.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17.5",
                            Type = @"Component",
                            Position = @"IN1.17.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.17.6",
                            Type = @"Component",
                            Position = @"IN1.17.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.18",
                            Type = @"Field",
                            Position = @"IN1.18",
                            Name = @"Insured's Date Of Birth",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date of birth of the insured.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.18.1",
                            Type = @"Component",
                            Position = @"IN1.18.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.18.2",
                            Type = @"Component",
                            Position = @"IN1.18.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19",
                            Type = @"Field",
                            Position = @"IN1.19",
                            Name = @"Insured's Address",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of the insured person.  The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by an insurance policy.  Multiple addresses for the same insured person may be in this field.  The mailing address must be sent in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.1",
                            Type = @"Component",
                            Position = @"IN1.19.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"See section 2.9.38, SAD - street address for description of components.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.19.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.19.1.2",
                            Name = @"Street Name",
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
                            Id = @"IN1.19.1.3",
                            Type = @"SubComponent",
                            Position = @"IN1.19.1.3",
                            Name = @"Dwelling Number",
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
                            Id = @"IN1.19.2",
                            Type = @"Component",
                            Position = @"IN1.19.2",
                            Name = @"Other Designation",
                            Length = 0,
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
                            Id = @"IN1.19.3",
                            Type = @"Component",
                            Position = @"IN1.19.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This may be the name of the city, or district or place depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.4",
                            Type = @"Component",
                            Position = @"IN1.19.4",
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
                            Id = @"IN1.19.5",
                            Type = @"Component",
                            Position = @"IN1.19.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.6",
                            Type = @"Component",
                            Position = @"IN1.19.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code . HL7 Table 0399 - Country code is defined to contain these 3-character codes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.7",
                            Type = @"Component",
                            Position = @"IN1.19.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 Table 0190 - Address type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.8",
                            Type = @"Component",
                            Position = @"IN1.19.8",
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
                            Id = @"IN1.19.9",
                            Type = @"Component",
                            Position = @"IN1.19.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides . User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.10",
                            Type = @"Component",
                            Position = @"IN1.19.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides . User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.11",
                            Type = @"Component",
                            Position = @"IN1.19.11",
                            Name = @"Address Representation Code",
                            Length = 0,
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
                            Id = @"IN1.19.12",
                            Type = @"Component",
                            Position = @"IN1.19.12",
                            Name = @"Address Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period in which this address was valid",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.19.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.19.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.20",
                            Type = @"Field",
                            Position = @"IN1.20",
                            Name = @"Assignment Of Benefits",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0135",
                            TableName = @"Assignment of benefits",
                            Description = @"This field indicates whether the insured agreed to assign the insurance benefits to the healthcare provider.  If so, the insurance will pay the provider directly.  Refer to User-defined Table 0135 - Assignment of benefits for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.21",
                            Type = @"Field",
                            Position = @"IN1.21",
                            Name = @"Coordination Of Benefits",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0173",
                            TableName = @"Coordination of benefits",
                            Description = @"This field indicates whether this insurance works in conjunction with other insurance plans, or if it provides independent coverage and payment of benefits regardless of other insurance that might be available to the patient.  Refer to User-defined Table 0173 - Coordination of benefits for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.22",
                            Type = @"Field",
                            Position = @"IN1.22",
                            Name = @"Coord Of Ben. Priority",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"If the insurance works in conjunction with other insurance plans, this field contains priority sequence.  Values are: 1, 2, 3, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.23",
                            Type = @"Field",
                            Position = @"IN1.23",
                            Name = @"Notice Of Admission Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether the insurance company requires a written notice of admission from the healthcare provider.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.24",
                            Type = @"Field",
                            Position = @"IN1.24",
                            Name = @"Notice Of Admission Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"If a notice is required, this field indicates the date that it was sent",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.25",
                            Type = @"Field",
                            Position = @"IN1.25",
                            Name = @"Report Of Eligibility Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether this insurance carrier sends a report that indicates that the patient is eligible for benefits and whether it identifies those benefits.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.26",
                            Type = @"Field",
                            Position = @"IN1.26",
                            Name = @"Report Of Eligibility Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates whether a report of eligibility (ROE) was received, and also indicates the date that it was received",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.27",
                            Type = @"Field",
                            Position = @"IN1.27",
                            Name = @"Release Information Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0093",
                            TableName = @"Release information",
                            Description = @"This field indicates whether the healthcare provider can release information about the patient, and what information can be released.  Refer to User-defined Table 0093 - Release information for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.28",
                            Type = @"Field",
                            Position = @"IN1.28",
                            Name = @"Pre-Admit Cert",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the pre-admission certification code.  If the admission must be certified before the admission, this is the code associated with the admission",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.29",
                            Type = @"Field",
                            Position = @"IN1.29",
                            Name = @"Verification Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the healthcare provider verified that the patient has the indicated benefits",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.29.1",
                            Type = @"Component",
                            Position = @"IN1.29.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.29.2",
                            Type = @"Component",
                            Position = @"IN1.29.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30",
                            Type = @"Field",
                            Position = @"IN1.30",
                            Name = @"Verification By",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"Refers to the person who verified the benefits.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.1",
                            Type = @"Component",
                            Position = @"IN1.30.1",
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
                            Id = @"IN1.30.2",
                            Type = @"Component",
                            Position = @"IN1.30.2",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19,  FN - family name.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.2.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.2.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.30.2.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.2.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.2.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.2.3",
                            Name = @"Own Surname",
                            Length = 0,
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
                            Id = @"IN1.30.2.4",
                            Type = @"SubComponent",
                            Position = @"IN1.30.2.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.2.5",
                            Type = @"SubComponent",
                            Position = @"IN1.30.2.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.3",
                            Type = @"Component",
                            Position = @"IN1.30.3",
                            Name = @"Given Name",
                            Length = 0,
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
                            Id = @"IN1.30.4",
                            Type = @"Component",
                            Position = @"IN1.30.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
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
                            Id = @"IN1.30.5",
                            Type = @"Component",
                            Position = @"IN1.30.5",
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
                            Id = @"IN1.30.6",
                            Type = @"Component",
                            Position = @"IN1.30.6",
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
                            Id = @"IN1.30.7",
                            Type = @"Component",
                            Position = @"IN1.30.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.8",
                            Type = @"Component",
                            Position = @"IN1.30.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined Table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.9",
                            Type = @"Component",
                            Position = @"IN1.30.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.9.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.9.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.30.9.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.10",
                            Type = @"Component",
                            Position = @"IN1.30.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values (see Section 2.9.54.7, Name type code (ID)).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.11",
                            Type = @"Component",
                            Position = @"IN1.30.11",
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
                            Id = @"IN1.30.12",
                            Type = @"Component",
                            Position = @"IN1.30.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 Table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.13",
                            Type = @"Component",
                            Position = @"IN1.30.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.14",
                            Type = @"Component",
                            Position = @"IN1.30.14",
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
                            Id = @"IN1.30.14.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.14.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.30.14.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.15",
                            Type = @"Component",
                            Position = @"IN1.30.15",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                            Id = @"IN1.30.16",
                            Type = @"Component",
                            Position = @"IN1.30.16",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.16.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.1",
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
                            Id = @"IN1.30.16.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.2",
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
                            Id = @"IN1.30.16.3",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.16.4",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.16.5",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.16.6",
                            Type = @"SubComponent",
                            Position = @"IN1.30.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17",
                            Type = @"Component",
                            Position = @"IN1.30.17",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times that define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.1",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.17.2",
                            Type = @"SubComponent",
                            Position = @"IN1.30.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.30.18",
                            Type = @"Component",
                            Position = @"IN1.30.18",
                            Name = @"Name Assembly Order",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name assembly orde r for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.31",
                            Type = @"Field",
                            Position = @"IN1.31",
                            Name = @"Type Of Agreement Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0098",
                            TableName = @"Type of agreement",
                            Description = @"This field is used to further identify an insurance plan.  Refer to User-defined Table 0098 Type of agreement for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.32",
                            Type = @"Field",
                            Position = @"IN1.32",
                            Name = @"Billing Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0022",
                            TableName = @"Billing status",
                            Description = @"This field indicates whether the particular insurance has been billed and, if so, the type of bill. Refer to User-defined Table 0022 - Billing status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.33",
                            Type = @"Field",
                            Position = @"IN1.33",
                            Name = @"Lifetime Reserve Days",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of days left for a certain service to be provided or covered under an insurance policy",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.34",
                            Type = @"Field",
                            Position = @"IN1.34",
                            Name = @"Delay Before L.R. Day",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the delay before lifetime reserve days",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.35",
                            Type = @"Field",
                            Position = @"IN1.35",
                            Name = @"Company Plan Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0042",
                            TableName = @"Company plan code",
                            Description = @"This field contains optional information to further define the data in IN1-3 - insurance company ID. Refer to User-defined Table 0042 - Company plan code for suggested values.  This table contains codes used to identify an insurance company plan uniquely",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.36",
                            Type = @"Field",
                            Position = @"IN1.36",
                            Name = @"Policy Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the individual policy number of the insured to uniquely identify this patient’s plan.  For special types of insurance numbers, there are also special fields in the IN2 segment for Medicaid, Medicare, Champus (i.e., IN2-8 - Medicaid case number, IN2-6 - Medicare health ins card number, IN2-10 - Military ID number).  But we recommend that this field (IN1-36 - policy number) be filled even when the patient’s insurance number is also passed in one of these other fields",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37",
                            Type = @"Field",
                            Position = @"IN1.37",
                            Name = @"Policy Deductible",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount specified by the insurance plan that is the responsibility of the guarantor (i.e. deductible, excess, etc.).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.1",
                            Type = @"Component",
                            Position = @"IN1.37.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.37.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.37.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.2",
                            Type = @"Component",
                            Position = @"IN1.37.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.3",
                            Type = @"Component",
                            Position = @"IN1.37.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.4",
                            Type = @"Component",
                            Position = @"IN1.37.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5",
                            Type = @"Component",
                            Position = @"IN1.37.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.1",
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
                            Id = @"IN1.37.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.2",
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
                            Id = @"IN1.37.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.37.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.37.6",
                            Type = @"Component",
                            Position = @"IN1.37.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38",
                            Type = @"Field",
                            Position = @"IN1.38",
                            Name = @"Policy Limit - Amount",
                            Length = 12,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only.  Use IN2-29 policy type/amount instead of this field.  This field contains the maximum amount that the insurance policy will pay.  In some cases, the limit may be for a single encounter",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.1",
                            Type = @"Component",
                            Position = @"IN1.38.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.38.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.38.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.2",
                            Type = @"Component",
                            Position = @"IN1.38.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.3",
                            Type = @"Component",
                            Position = @"IN1.38.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.4",
                            Type = @"Component",
                            Position = @"IN1.38.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5",
                            Type = @"Component",
                            Position = @"IN1.38.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.1",
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
                            Id = @"IN1.38.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.2",
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
                            Id = @"IN1.38.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.38.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.38.6",
                            Type = @"Component",
                            Position = @"IN1.38.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.39",
                            Type = @"Field",
                            Position = @"IN1.39",
                            Name = @"Policy Limit - Days",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the maximum number of days that the insurance policy will cover",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40",
                            Type = @"Field",
                            Position = @"IN1.40",
                            Name = @"Room Rate - Semi-Private",
                            Length = 12,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only.  Use IN2-28 - room coverage type/amount instead of this field. When used for backward compatibility, IN1-40 - room rate-semi-private contains the average room rate that the policy covers",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.1",
                            Type = @"Component",
                            Position = @"IN1.40.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.40.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.40.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.2",
                            Type = @"Component",
                            Position = @"IN1.40.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.3",
                            Type = @"Component",
                            Position = @"IN1.40.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.4",
                            Type = @"Component",
                            Position = @"IN1.40.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5",
                            Type = @"Component",
                            Position = @"IN1.40.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.1",
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
                            Id = @"IN1.40.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.2",
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
                            Id = @"IN1.40.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.40.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.40.6",
                            Type = @"Component",
                            Position = @"IN1.40.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41",
                            Type = @"Field",
                            Position = @"IN1.41",
                            Name = @"Room Rate - Private",
                            Length = 12,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CP",
                            DataTypeName = @"Composite Price",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility only.  Use IN2-28 - room coverage type/amount instead of this field.  When used for backward compatibility IN1-41 - room rate-private contains the maximum private room rate that the policy covers",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.1",
                            Type = @"Component",
                            Position = @"IN1.41.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.41.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.41.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.2",
                            Type = @"Component",
                            Position = @"IN1.41.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.3",
                            Type = @"Component",
                            Position = @"IN1.41.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.4",
                            Type = @"Component",
                            Position = @"IN1.41.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5",
                            Type = @"Component",
                            Position = @"IN1.41.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.1",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.1",
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
                            Id = @"IN1.41.5.2",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.2",
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
                            Id = @"IN1.41.5.3",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.4",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.5",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.5.6",
                            Type = @"SubComponent",
                            Position = @"IN1.41.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.41.6",
                            Type = @"Component",
                            Position = @"IN1.41.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42",
                            Type = @"Field",
                            Position = @"IN1.42",
                            Name = @"Insured's Employment Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0066",
                            TableName = @"Employment status",
                            Description = @"This field holds the employment status of the insured.  Refer to User-defined Table 0066 - Employment status for suggested values.  This field contains UB92 field 64. For this field element, values from the US HCFA UB92 and others are used",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.1",
                            Type = @"Component",
                            Position = @"IN1.42.1",
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
                            Id = @"IN1.42.2",
                            Type = @"Component",
                            Position = @"IN1.42.2",
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
                            Id = @"IN1.42.3",
                            Type = @"Component",
                            Position = @"IN1.42.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.4",
                            Type = @"Component",
                            Position = @"IN1.42.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.5",
                            Type = @"Component",
                            Position = @"IN1.42.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.42.6",
                            Type = @"Component",
                            Position = @"IN1.42.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.43",
                            Type = @"Field",
                            Position = @"IN1.43",
                            Name = @"Insured's Administrative Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Administrative sex",
                            Description = @"This field contains the gender of the insured.  Refer to User-defined Table 0001 - Administrative sex for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44",
                            Type = @"Field",
                            Position = @"IN1.44",
                            Name = @"Insured's Employer's Address",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of the insured employee’s employer.  Multiple addresses for the same employer may be sent in this field.  The mailing address must be sent first.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.1",
                            Type = @"Component",
                            Position = @"IN1.44.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"See section 2.9.38, SAD - street address for description of components.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.1.1",
                            Type = @"SubComponent",
                            Position = @"IN1.44.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.1.2",
                            Type = @"SubComponent",
                            Position = @"IN1.44.1.2",
                            Name = @"Street Name",
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
                            Id = @"IN1.44.1.3",
                            Type = @"SubComponent",
                            Position = @"IN1.44.1.3",
                            Name = @"Dwelling Number",
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
                            Id = @"IN1.44.2",
                            Type = @"Component",
                            Position = @"IN1.44.2",
                            Name = @"Other Designation",
                            Length = 0,
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
                            Id = @"IN1.44.3",
                            Type = @"Component",
                            Position = @"IN1.44.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This may be the name of the city, or district or place depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.4",
                            Type = @"Component",
                            Position = @"IN1.44.4",
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
                            Id = @"IN1.44.5",
                            Type = @"Component",
                            Position = @"IN1.44.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.6",
                            Type = @"Component",
                            Position = @"IN1.44.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code . HL7 Table 0399 - Country code is defined to contain these 3-character codes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.7",
                            Type = @"Component",
                            Position = @"IN1.44.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 Table 0190 - Address type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.8",
                            Type = @"Component",
                            Position = @"IN1.44.8",
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
                            Id = @"IN1.44.9",
                            Type = @"Component",
                            Position = @"IN1.44.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides . User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.10",
                            Type = @"Component",
                            Position = @"IN1.44.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides . User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.11",
                            Type = @"Component",
                            Position = @"IN1.44.11",
                            Name = @"Address Representation Code",
                            Length = 0,
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
                            Id = @"IN1.44.12",
                            Type = @"Component",
                            Position = @"IN1.44.12",
                            Name = @"Address Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period in which this address was valid",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.1",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.44.12.2",
                            Type = @"SubComponent",
                            Position = @"IN1.44.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.45",
                            Type = @"Field",
                            Position = @"IN1.45",
                            Name = @"Verification Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the status of this patient’s relationship with this insurance carrier",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.46",
                            Type = @"Field",
                            Position = @"IN1.46",
                            Name = @"Prior Insurance Plan ID",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0072",
                            TableName = @"Insurance plan ID",
                            Description = @"This field uniquely identifies the prior insurance plan when the plan ID changes.  Refer to User-defined Table 0072 - Insurance plan ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.47",
                            Type = @"Field",
                            Position = @"IN1.47",
                            Name = @"Coverage Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0309",
                            TableName = @"Coverage type",
                            Description = @"This field contains the coding structure that identifies the type of insurance coverage, or what types of services are covered for the purposes of a billing system.  For example, a physician billing system will only want to receive insurance information for plans that cover physician/professional charges.  Refer to User-defined Table 0309 - Coverage type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.48",
                            Type = @"Field",
                            Position = @"IN1.48",
                            Name = @"Handicap",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0295",
                            TableName = @"Handicap",
                            Description = @"This field contains a code to describe the insured’s disability.  Refer to User-defined Table 0295 - Handicap for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49",
                            Type = @"Field",
                            Position = @"IN1.49",
                            Name = @"Insured's ID Number",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This data element contains a healthcare institution’s identifiers for the insured.  The assigning authority and identifier type code are strongly recommended for all CX data types",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.1",
                            Type = @"Component",
                            Position = @"IN1.49.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Definition: The value of the identifier itself. It is similar to the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that a ST data type is used instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.2",
                            Type = @"Component",
                            Position = @"IN1.49.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.3",
                            Type = @"Component",
                            Position = @"IN1.49.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit). Refer to HL7 Table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.4",
                            Type = @"Component",
                            Position = @"IN1.49.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type . User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.4.1",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.4.2",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.49.4.3",
                            Type = @"SubComponent",
                            Position = @"IN1.49.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.5",
                            Type = @"Component",
                            Position = @"IN1.49.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer toHL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.6",
                            Type = @"Component",
                            Position = @"IN1.49.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.6.1",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.6.2",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"IN1.49.6.3",
                            Type = @"SubComponent",
                            Position = @"IN1.49.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.49.7",
                            Type = @"Component",
                            Position = @"IN1.49.7",
                            Name = @"Effective Date",
                            Length = 0,
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
                            Id = @"IN1.49.8",
                            Type = @"Component",
                            Position = @"IN1.49.8",
                            Name = @"Expiration Date",
                            Length = 0,
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
                        
                        },
                        };
            }
        }

        public HL7V24SegmentIN1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field setIDIN1;

public HL7V24Field SetIDIN1
{
    get
    {
        if (setIDIN1 != null)
        {
            return setIDIN1;
        }

        setIDIN1 = new HL7V24Field
        {
            field = message[@"IN1"][1],
            Id = @"IN1.1",
            Type = @"Field",
            Position = @"IN1.1",
            Name = @"Set ID - IN1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"IN1-1 - set ID contains the number that identifies this transaction.  For the first occurrence the sequence number shall be 1, for the second occurrence it shall be 2, etc. The Set ID in the IN1 segment is used to aggregate the grouping of insurance segments.  For example, a patient with two insurance plans would have two groupings of insurance segments.  IN1, IN2, and IN3 segments for Insurance Plan A with set ID 1, followed by IN1, IN2, and IN3 segments for Insurance Plan B, with set ID 2.  There is no set ID in the IN2 segment because it is contained in the IN1, IN2, IN3 grouping, and is therefore not needed.  The set ID in the IN3 segment is provided because there can be multiple repetitions of the IN3 segment if there are multiple certifications for the same insurance plan, e.g., IN1 (Set ID 1), IN2, IN3 (Set ID 1), IN3 (Set ID 2), IN3 (Set ID 3)",
            Sample = @"",
        };

        

        

        

        return setIDIN1;
    } 
}
internal HL7V24Field insurancePlanID;

public HL7V24Field InsurancePlanID
{
    get
    {
        if (insurancePlanID != null)
        {
            return insurancePlanID;
        }

        insurancePlanID = new HL7V24Field
        {
            field = message[@"IN1"][2],
            Id = @"IN1.2",
            Type = @"Field",
            Position = @"IN1.2",
            Name = @"Insurance Plan ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field contains a unique identifier for the insurance plan.  Refer to User-defined Table 0072 - Insurance plan ID for suggested values.  To eliminate a plan, the plan could be sent with null values in each subsequent element.  If the respective systems can support it, a null value can be sent in the plan field",
            Sample = @"",
        };

        

        

        

        return insurancePlanID;
    } 
}
internal HL7V24Field insuranceCompanyID;

public HL7V24Field InsuranceCompanyID
{
    get
    {
        if (insuranceCompanyID != null)
        {
            return insuranceCompanyID;
        }

        insuranceCompanyID = new HL7V24Field
        {
            field = message[@"IN1"][3],
            Id = @"IN1.3",
            Type = @"Field",
            Position = @"IN1.3",
            Name = @"Insurance Company ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains unique identifiers for the insurance company.  The assigning authority and identifier type code are strongly recommended for all CX data types",
            Sample = @"",
        };

        

        

        

        return insuranceCompanyID;
    } 
}
internal HL7V24Field insuranceCompanyName;

public HL7V24Field InsuranceCompanyName
{
    get
    {
        if (insuranceCompanyName != null)
        {
            return insuranceCompanyName;
        }

        insuranceCompanyName = new HL7V24Field
        {
            field = message[@"IN1"][4],
            Id = @"IN1.4",
            Type = @"Field",
            Position = @"IN1.4",
            Name = @"Insurance Company Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insurance company.  Multiple names for the same insurance company may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return insuranceCompanyName;
    } 
}
internal HL7V24Field insuranceCompanyAddress;

public HL7V24Field InsuranceCompanyAddress
{
    get
    {
        if (insuranceCompanyAddress != null)
        {
            return insuranceCompanyAddress;
        }

        insuranceCompanyAddress = new HL7V24Field
        {
            field = message[@"IN1"][5],
            Id = @"IN1.5",
            Type = @"Field",
            Position = @"IN1.5",
            Name = @"Insurance Company Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insurance company.  Multiple addresses for the same insurance company may be sent in this field.  The mailing address is assumed to be in the first repetition. When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return insuranceCompanyAddress;
    } 
}
internal HL7V24Field insuranceCoContactPerson;

public HL7V24Field InsuranceCoContactPerson
{
    get
    {
        if (insuranceCoContactPerson != null)
        {
            return insuranceCoContactPerson;
        }

        insuranceCoContactPerson = new HL7V24Field
        {
            field = message[@"IN1"][6],
            Id = @"IN1.6",
            Type = @"Field",
            Position = @"IN1.6",
            Name = @"Insurance Co Contact Person",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the person who should be contacted at the insurance company. Multiple names for the same contact person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insuranceCoContactPerson;
    } 
}
internal HL7V24Field insuranceCoPhoneNumber;

public HL7V24Field InsuranceCoPhoneNumber
{
    get
    {
        if (insuranceCoPhoneNumber != null)
        {
            return insuranceCoPhoneNumber;
        }

        insuranceCoPhoneNumber = new HL7V24Field
        {
            field = message[@"IN1"][7],
            Id = @"IN1.7",
            Type = @"Field",
            Position = @"IN1.7",
            Name = @"Insurance Co Phone Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the insurance company.  Multiple phone numbers for the same insurance company may be sent in this field.  The primary phone number is assumed to be in the first repetition.  When the primary phone number is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insuranceCoPhoneNumber;
    } 
}
internal HL7V24Field groupNumber;

public HL7V24Field GroupNumber
{
    get
    {
        if (groupNumber != null)
        {
            return groupNumber;
        }

        groupNumber = new HL7V24Field
        {
            field = message[@"IN1"][8],
            Id = @"IN1.8",
            Type = @"Field",
            Position = @"IN1.8",
            Name = @"Group Number",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the group number of the insured’s insurance",
            Sample = @"",
        };

        

        

        

        return groupNumber;
    } 
}
internal HL7V24Field groupName;

public HL7V24Field GroupName
{
    get
    {
        if (groupName != null)
        {
            return groupName;
        }

        groupName = new HL7V24Field
        {
            field = message[@"IN1"][9],
            Id = @"IN1.9",
            Type = @"Field",
            Position = @"IN1.9",
            Name = @"Group Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the group name of the insured’s insurance",
            Sample = @"",
        };

        

        

        

        return groupName;
    } 
}
internal HL7V24Field insured'sGroupEmpID;

public HL7V24Field Insured'sGroupEmpID
{
    get
    {
        if (insured'sGroupEmpID != null)
        {
            return insured'sGroupEmpID;
        }

        insured'sGroupEmpID = new HL7V24Field
        {
            field = message[@"IN1"][10],
            Id = @"IN1.10",
            Type = @"Field",
            Position = @"IN1.10",
            Name = @"Insured's Group Emp ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field holds the group employer ID for the insured’s insurance.  The assigning authority and identifier type code are strongly recommended for all CX data types",
            Sample = @"",
        };

        

        

        

        return insured'sGroupEmpID;
    } 
}
internal HL7V24Field insured'sGroupEmpName;

public HL7V24Field Insured'sGroupEmpName
{
    get
    {
        if (insured'sGroupEmpName != null)
        {
            return insured'sGroupEmpName;
        }

        insured'sGroupEmpName = new HL7V24Field
        {
            field = message[@"IN1"][11],
            Id = @"IN1.11",
            Type = @"Field",
            Position = @"IN1.11",
            Name = @"Insured's Group Emp Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the employer that provides the employee’s insurance.  Multiple names for the same employer may be sent in this sequence.  The legal name must be sent first.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return insured'sGroupEmpName;
    } 
}
internal HL7V24Field planEffectiveDate;

public HL7V24Field PlanEffectiveDate
{
    get
    {
        if (planEffectiveDate != null)
        {
            return planEffectiveDate;
        }

        planEffectiveDate = new HL7V24Field
        {
            field = message[@"IN1"][12],
            Id = @"IN1.12",
            Type = @"Field",
            Position = @"IN1.12",
            Name = @"Plan Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the insurance goes into effect",
            Sample = @"",
        };

        

        

        

        return planEffectiveDate;
    } 
}
internal HL7V24Field planExpirationDate;

public HL7V24Field PlanExpirationDate
{
    get
    {
        if (planExpirationDate != null)
        {
            return planExpirationDate;
        }

        planExpirationDate = new HL7V24Field
        {
            field = message[@"IN1"][13],
            Id = @"IN1.13",
            Type = @"Field",
            Position = @"IN1.13",
            Name = @"Plan Expiration Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the last date of service that the insurance will cover or be responsible for",
            Sample = @"",
        };

        

        

        

        return planExpirationDate;
    } 
}
internal HL7V24Field authorizationInformation;

public HL7V24Field AuthorizationInformation
{
    get
    {
        if (authorizationInformation != null)
        {
            return authorizationInformation;
        }

        authorizationInformation = new HL7V24Field
        {
            field = message[@"IN1"][14],
            Id = @"IN1.14",
            Type = @"Field",
            Position = @"IN1.14",
            Name = @"Authorization Information",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AUI",
            DataTypeName = @"Authorization Information",
            TableId = null,
            TableName = null,
            Description = @"Based on the type of insurance, some coverage plans require that an authorization number or code be obtained prior to all non-emergency admissions, and within 48 hours of an emergency admission. Insurance billing would not be permitted without this number.  The date and source of authorization are the components of this field",
            Sample = @"",
        };

        

        

        

        return authorizationInformation;
    } 
}
internal HL7V24Field planType;

public HL7V24Field PlanType
{
    get
    {
        if (planType != null)
        {
            return planType;
        }

        planType = new HL7V24Field
        {
            field = message[@"IN1"][15],
            Id = @"IN1.15",
            Type = @"Field",
            Position = @"IN1.15",
            Name = @"Plan Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0086",
            TableName = @"Plan ID",
            Description = @"This field contains the coding structure that identifies the various plan types, for example, Medicare, Medicaid, Blue Cross, HMO, etc.  Refer to User-defined Table 0086 - Plan ID for suggested values.",
            Sample = @"",
        };

        

        

        

        return planType;
    } 
}
internal HL7V24Field nameOfInsured;

public HL7V24Field NameOfInsured
{
    get
    {
        if (nameOfInsured != null)
        {
            return nameOfInsured;
        }

        nameOfInsured = new HL7V24Field
        {
            field = message[@"IN1"][16],
            Id = @"IN1.16",
            Type = @"Field",
            Position = @"IN1.16",
            Name = @"Name Of Insured",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insured person.  The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by the insurance policy.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return nameOfInsured;
    } 
}
internal HL7V24Field insured'sRelationshipToPatient;

public HL7V24Field Insured'sRelationshipToPatient
{
    get
    {
        if (insured'sRelationshipToPatient != null)
        {
            return insured'sRelationshipToPatient;
        }

        insured'sRelationshipToPatient = new HL7V24Field
        {
            field = message[@"IN1"][17],
            Id = @"IN1.17",
            Type = @"Field",
            Position = @"IN1.17",
            Name = @"Insured's Relationship To Patient",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field indicates the insured’s relationship to the patient.  Refer to User-defined Table 0063 Relationship for suggested values",
            Sample = @"",
        };

        

        

        

        return insured'sRelationshipToPatient;
    } 
}
internal HL7V24Field insured'sDateOfBirth;

public HL7V24Field Insured'sDateOfBirth
{
    get
    {
        if (insured'sDateOfBirth != null)
        {
            return insured'sDateOfBirth;
        }

        insured'sDateOfBirth = new HL7V24Field
        {
            field = message[@"IN1"][18],
            Id = @"IN1.18",
            Type = @"Field",
            Position = @"IN1.18",
            Name = @"Insured's Date Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of birth of the insured.",
            Sample = @"",
        };

        

        

        

        return insured'sDateOfBirth;
    } 
}
internal HL7V24Field insured'sAddress;

public HL7V24Field Insured'sAddress
{
    get
    {
        if (insured'sAddress != null)
        {
            return insured'sAddress;
        }

        insured'sAddress = new HL7V24Field
        {
            field = message[@"IN1"][19],
            Id = @"IN1.19",
            Type = @"Field",
            Position = @"IN1.19",
            Name = @"Insured's Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insured person.  The insured is the person who has an agreement with the insurance company to provide healthcare services to persons covered by an insurance policy.  Multiple addresses for the same insured person may be in this field.  The mailing address must be sent in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insured'sAddress;
    } 
}
internal HL7V24Field assignmentOfBenefits;

public HL7V24Field AssignmentOfBenefits
{
    get
    {
        if (assignmentOfBenefits != null)
        {
            return assignmentOfBenefits;
        }

        assignmentOfBenefits = new HL7V24Field
        {
            field = message[@"IN1"][20],
            Id = @"IN1.20",
            Type = @"Field",
            Position = @"IN1.20",
            Name = @"Assignment Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0135",
            TableName = @"Assignment of benefits",
            Description = @"This field indicates whether the insured agreed to assign the insurance benefits to the healthcare provider.  If so, the insurance will pay the provider directly.  Refer to User-defined Table 0135 - Assignment of benefits for suggested values.",
            Sample = @"",
        };

        

        

        

        return assignmentOfBenefits;
    } 
}
internal HL7V24Field coordinationOfBenefits;

public HL7V24Field CoordinationOfBenefits
{
    get
    {
        if (coordinationOfBenefits != null)
        {
            return coordinationOfBenefits;
        }

        coordinationOfBenefits = new HL7V24Field
        {
            field = message[@"IN1"][21],
            Id = @"IN1.21",
            Type = @"Field",
            Position = @"IN1.21",
            Name = @"Coordination Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0173",
            TableName = @"Coordination of benefits",
            Description = @"This field indicates whether this insurance works in conjunction with other insurance plans, or if it provides independent coverage and payment of benefits regardless of other insurance that might be available to the patient.  Refer to User-defined Table 0173 - Coordination of benefits for suggested values.",
            Sample = @"",
        };

        

        

        

        return coordinationOfBenefits;
    } 
}
internal HL7V24Field coordOfBen.Priority;

public HL7V24Field CoordOfBen.Priority
{
    get
    {
        if (coordOfBen.Priority != null)
        {
            return coordOfBen.Priority;
        }

        coordOfBen.Priority = new HL7V24Field
        {
            field = message[@"IN1"][22],
            Id = @"IN1.22",
            Type = @"Field",
            Position = @"IN1.22",
            Name = @"Coord Of Ben. Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"If the insurance works in conjunction with other insurance plans, this field contains priority sequence.  Values are: 1, 2, 3, etc",
            Sample = @"",
        };

        

        

        

        return coordOfBen.Priority;
    } 
}
internal HL7V24Field noticeOfAdmissionFlag;

public HL7V24Field NoticeOfAdmissionFlag
{
    get
    {
        if (noticeOfAdmissionFlag != null)
        {
            return noticeOfAdmissionFlag;
        }

        noticeOfAdmissionFlag = new HL7V24Field
        {
            field = message[@"IN1"][23],
            Id = @"IN1.23",
            Type = @"Field",
            Position = @"IN1.23",
            Name = @"Notice Of Admission Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the insurance company requires a written notice of admission from the healthcare provider.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return noticeOfAdmissionFlag;
    } 
}
internal HL7V24Field noticeOfAdmissionDate;

public HL7V24Field NoticeOfAdmissionDate
{
    get
    {
        if (noticeOfAdmissionDate != null)
        {
            return noticeOfAdmissionDate;
        }

        noticeOfAdmissionDate = new HL7V24Field
        {
            field = message[@"IN1"][24],
            Id = @"IN1.24",
            Type = @"Field",
            Position = @"IN1.24",
            Name = @"Notice Of Admission Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"If a notice is required, this field indicates the date that it was sent",
            Sample = @"",
        };

        

        

        

        return noticeOfAdmissionDate;
    } 
}
internal HL7V24Field reportOfEligibilityFlag;

public HL7V24Field ReportOfEligibilityFlag
{
    get
    {
        if (reportOfEligibilityFlag != null)
        {
            return reportOfEligibilityFlag;
        }

        reportOfEligibilityFlag = new HL7V24Field
        {
            field = message[@"IN1"][25],
            Id = @"IN1.25",
            Type = @"Field",
            Position = @"IN1.25",
            Name = @"Report Of Eligibility Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether this insurance carrier sends a report that indicates that the patient is eligible for benefits and whether it identifies those benefits.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return reportOfEligibilityFlag;
    } 
}
internal HL7V24Field reportOfEligibilityDate;

public HL7V24Field ReportOfEligibilityDate
{
    get
    {
        if (reportOfEligibilityDate != null)
        {
            return reportOfEligibilityDate;
        }

        reportOfEligibilityDate = new HL7V24Field
        {
            field = message[@"IN1"][26],
            Id = @"IN1.26",
            Type = @"Field",
            Position = @"IN1.26",
            Name = @"Report Of Eligibility Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates whether a report of eligibility (ROE) was received, and also indicates the date that it was received",
            Sample = @"",
        };

        

        

        

        return reportOfEligibilityDate;
    } 
}
internal HL7V24Field releaseInformationCode;

public HL7V24Field ReleaseInformationCode
{
    get
    {
        if (releaseInformationCode != null)
        {
            return releaseInformationCode;
        }

        releaseInformationCode = new HL7V24Field
        {
            field = message[@"IN1"][27],
            Id = @"IN1.27",
            Type = @"Field",
            Position = @"IN1.27",
            Name = @"Release Information Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0093",
            TableName = @"Release information",
            Description = @"This field indicates whether the healthcare provider can release information about the patient, and what information can be released.  Refer to User-defined Table 0093 - Release information for suggested values",
            Sample = @"",
        };

        

        

        

        return releaseInformationCode;
    } 
}
internal HL7V24Field preAdmitCert;

public HL7V24Field PreAdmitCert
{
    get
    {
        if (preAdmitCert != null)
        {
            return preAdmitCert;
        }

        preAdmitCert = new HL7V24Field
        {
            field = message[@"IN1"][28],
            Id = @"IN1.28",
            Type = @"Field",
            Position = @"IN1.28",
            Name = @"Pre-Admit Cert",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pre-admission certification code.  If the admission must be certified before the admission, this is the code associated with the admission",
            Sample = @"",
        };

        

        

        

        return preAdmitCert;
    } 
}
internal HL7V24Field verificationDateTime;

public HL7V24Field VerificationDateTime
{
    get
    {
        if (verificationDateTime != null)
        {
            return verificationDateTime;
        }

        verificationDateTime = new HL7V24Field
        {
            field = message[@"IN1"][29],
            Id = @"IN1.29",
            Type = @"Field",
            Position = @"IN1.29",
            Name = @"Verification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the healthcare provider verified that the patient has the indicated benefits",
            Sample = @"",
        };

        

        

        

        return verificationDateTime;
    } 
}
internal HL7V24Field verificationBy;

public HL7V24Field VerificationBy
{
    get
    {
        if (verificationBy != null)
        {
            return verificationBy;
        }

        verificationBy = new HL7V24Field
        {
            field = message[@"IN1"][30],
            Id = @"IN1.30",
            Type = @"Field",
            Position = @"IN1.30",
            Name = @"Verification By",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"Refers to the person who verified the benefits.  Multiple names for the same insured person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return verificationBy;
    } 
}
internal HL7V24Field typeOfAgreementCode;

public HL7V24Field TypeOfAgreementCode
{
    get
    {
        if (typeOfAgreementCode != null)
        {
            return typeOfAgreementCode;
        }

        typeOfAgreementCode = new HL7V24Field
        {
            field = message[@"IN1"][31],
            Id = @"IN1.31",
            Type = @"Field",
            Position = @"IN1.31",
            Name = @"Type Of Agreement Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0098",
            TableName = @"Type of agreement",
            Description = @"This field is used to further identify an insurance plan.  Refer to User-defined Table 0098 Type of agreement for suggested values",
            Sample = @"",
        };

        

        

        

        return typeOfAgreementCode;
    } 
}
internal HL7V24Field billingStatus;

public HL7V24Field BillingStatus
{
    get
    {
        if (billingStatus != null)
        {
            return billingStatus;
        }

        billingStatus = new HL7V24Field
        {
            field = message[@"IN1"][32],
            Id = @"IN1.32",
            Type = @"Field",
            Position = @"IN1.32",
            Name = @"Billing Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0022",
            TableName = @"Billing status",
            Description = @"This field indicates whether the particular insurance has been billed and, if so, the type of bill. Refer to User-defined Table 0022 - Billing status for suggested values",
            Sample = @"",
        };

        

        

        

        return billingStatus;
    } 
}
internal HL7V24Field lifetimeReserveDays;

public HL7V24Field LifetimeReserveDays
{
    get
    {
        if (lifetimeReserveDays != null)
        {
            return lifetimeReserveDays;
        }

        lifetimeReserveDays = new HL7V24Field
        {
            field = message[@"IN1"][33],
            Id = @"IN1.33",
            Type = @"Field",
            Position = @"IN1.33",
            Name = @"Lifetime Reserve Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days left for a certain service to be provided or covered under an insurance policy",
            Sample = @"",
        };

        

        

        

        return lifetimeReserveDays;
    } 
}
internal HL7V24Field delayBeforeL.R.Day;

public HL7V24Field DelayBeforeL.R.Day
{
    get
    {
        if (delayBeforeL.R.Day != null)
        {
            return delayBeforeL.R.Day;
        }

        delayBeforeL.R.Day = new HL7V24Field
        {
            field = message[@"IN1"][34],
            Id = @"IN1.34",
            Type = @"Field",
            Position = @"IN1.34",
            Name = @"Delay Before L.R. Day",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the delay before lifetime reserve days",
            Sample = @"",
        };

        

        

        

        return delayBeforeL.R.Day;
    } 
}
internal HL7V24Field companyPlanCode;

public HL7V24Field CompanyPlanCode
{
    get
    {
        if (companyPlanCode != null)
        {
            return companyPlanCode;
        }

        companyPlanCode = new HL7V24Field
        {
            field = message[@"IN1"][35],
            Id = @"IN1.35",
            Type = @"Field",
            Position = @"IN1.35",
            Name = @"Company Plan Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0042",
            TableName = @"Company plan code",
            Description = @"This field contains optional information to further define the data in IN1-3 - insurance company ID. Refer to User-defined Table 0042 - Company plan code for suggested values.  This table contains codes used to identify an insurance company plan uniquely",
            Sample = @"",
        };

        

        

        

        return companyPlanCode;
    } 
}
internal HL7V24Field policyNumber;

public HL7V24Field PolicyNumber
{
    get
    {
        if (policyNumber != null)
        {
            return policyNumber;
        }

        policyNumber = new HL7V24Field
        {
            field = message[@"IN1"][36],
            Id = @"IN1.36",
            Type = @"Field",
            Position = @"IN1.36",
            Name = @"Policy Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual policy number of the insured to uniquely identify this patient’s plan.  For special types of insurance numbers, there are also special fields in the IN2 segment for Medicaid, Medicare, Champus (i.e., IN2-8 - Medicaid case number, IN2-6 - Medicare health ins card number, IN2-10 - Military ID number).  But we recommend that this field (IN1-36 - policy number) be filled even when the patient’s insurance number is also passed in one of these other fields",
            Sample = @"",
        };

        

        

        

        return policyNumber;
    } 
}
internal HL7V24Field policyDeductible;

public HL7V24Field PolicyDeductible
{
    get
    {
        if (policyDeductible != null)
        {
            return policyDeductible;
        }

        policyDeductible = new HL7V24Field
        {
            field = message[@"IN1"][37],
            Id = @"IN1.37",
            Type = @"Field",
            Position = @"IN1.37",
            Name = @"Policy Deductible",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount specified by the insurance plan that is the responsibility of the guarantor (i.e. deductible, excess, etc.).",
            Sample = @"",
        };

        

        

        

        return policyDeductible;
    } 
}
internal HL7V24Field policyLimitAmount;

public HL7V24Field PolicyLimitAmount
{
    get
    {
        if (policyLimitAmount != null)
        {
            return policyLimitAmount;
        }

        policyLimitAmount = new HL7V24Field
        {
            field = message[@"IN1"][38],
            Id = @"IN1.38",
            Type = @"Field",
            Position = @"IN1.38",
            Name = @"Policy Limit - Amount",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-29 policy type/amount instead of this field.  This field contains the maximum amount that the insurance policy will pay.  In some cases, the limit may be for a single encounter",
            Sample = @"",
        };

        

        

        

        return policyLimitAmount;
    } 
}
internal HL7V24Field policyLimitDays;

public HL7V24Field PolicyLimitDays
{
    get
    {
        if (policyLimitDays != null)
        {
            return policyLimitDays;
        }

        policyLimitDays = new HL7V24Field
        {
            field = message[@"IN1"][39],
            Id = @"IN1.39",
            Type = @"Field",
            Position = @"IN1.39",
            Name = @"Policy Limit - Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum number of days that the insurance policy will cover",
            Sample = @"",
        };

        

        

        

        return policyLimitDays;
    } 
}
internal HL7V24Field roomRateSemiPrivate;

public HL7V24Field RoomRateSemiPrivate
{
    get
    {
        if (roomRateSemiPrivate != null)
        {
            return roomRateSemiPrivate;
        }

        roomRateSemiPrivate = new HL7V24Field
        {
            field = message[@"IN1"][40],
            Id = @"IN1.40",
            Type = @"Field",
            Position = @"IN1.40",
            Name = @"Room Rate - Semi-Private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-28 - room coverage type/amount instead of this field. When used for backward compatibility, IN1-40 - room rate-semi-private contains the average room rate that the policy covers",
            Sample = @"",
        };

        

        

        

        return roomRateSemiPrivate;
    } 
}
internal HL7V24Field roomRatePrivate;

public HL7V24Field RoomRatePrivate
{
    get
    {
        if (roomRatePrivate != null)
        {
            return roomRatePrivate;
        }

        roomRatePrivate = new HL7V24Field
        {
            field = message[@"IN1"][41],
            Id = @"IN1.41",
            Type = @"Field",
            Position = @"IN1.41",
            Name = @"Room Rate - Private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-28 - room coverage type/amount instead of this field.  When used for backward compatibility IN1-41 - room rate-private contains the maximum private room rate that the policy covers",
            Sample = @"",
        };

        

        

        

        return roomRatePrivate;
    } 
}
internal HL7V24Field insured'sEmploymentStatus;

public HL7V24Field Insured'sEmploymentStatus
{
    get
    {
        if (insured'sEmploymentStatus != null)
        {
            return insured'sEmploymentStatus;
        }

        insured'sEmploymentStatus = new HL7V24Field
        {
            field = message[@"IN1"][42],
            Id = @"IN1.42",
            Type = @"Field",
            Position = @"IN1.42",
            Name = @"Insured's Employment Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"This field holds the employment status of the insured.  Refer to User-defined Table 0066 - Employment status for suggested values.  This field contains UB92 field 64. For this field element, values from the US HCFA UB92 and others are used",
            Sample = @"",
        };

        

        

        

        return insured'sEmploymentStatus;
    } 
}
internal HL7V24Field insured'sAdministrativeSex;

public HL7V24Field Insured'sAdministrativeSex
{
    get
    {
        if (insured'sAdministrativeSex != null)
        {
            return insured'sAdministrativeSex;
        }

        insured'sAdministrativeSex = new HL7V24Field
        {
            field = message[@"IN1"][43],
            Id = @"IN1.43",
            Type = @"Field",
            Position = @"IN1.43",
            Name = @"Insured's Administrative Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Administrative sex",
            Description = @"This field contains the gender of the insured.  Refer to User-defined Table 0001 - Administrative sex for suggested values",
            Sample = @"",
        };

        

        

        

        return insured'sAdministrativeSex;
    } 
}
internal HL7V24Field insured'sEmployer'sAddress;

public HL7V24Field Insured'sEmployer'sAddress
{
    get
    {
        if (insured'sEmployer'sAddress != null)
        {
            return insured'sEmployer'sAddress;
        }

        insured'sEmployer'sAddress = new HL7V24Field
        {
            field = message[@"IN1"][44],
            Id = @"IN1.44",
            Type = @"Field",
            Position = @"IN1.44",
            Name = @"Insured's Employer's Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the insured employee’s employer.  Multiple addresses for the same employer may be sent in this field.  The mailing address must be sent first.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return insured'sEmployer'sAddress;
    } 
}
internal HL7V24Field verificationStatus;

public HL7V24Field VerificationStatus
{
    get
    {
        if (verificationStatus != null)
        {
            return verificationStatus;
        }

        verificationStatus = new HL7V24Field
        {
            field = message[@"IN1"][45],
            Id = @"IN1.45",
            Type = @"Field",
            Position = @"IN1.45",
            Name = @"Verification Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the status of this patient’s relationship with this insurance carrier",
            Sample = @"",
        };

        

        

        

        return verificationStatus;
    } 
}
internal HL7V24Field priorInsurancePlanID;

public HL7V24Field PriorInsurancePlanID
{
    get
    {
        if (priorInsurancePlanID != null)
        {
            return priorInsurancePlanID;
        }

        priorInsurancePlanID = new HL7V24Field
        {
            field = message[@"IN1"][46],
            Id = @"IN1.46",
            Type = @"Field",
            Position = @"IN1.46",
            Name = @"Prior Insurance Plan ID",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field uniquely identifies the prior insurance plan when the plan ID changes.  Refer to User-defined Table 0072 - Insurance plan ID for suggested values",
            Sample = @"",
        };

        

        

        

        return priorInsurancePlanID;
    } 
}
internal HL7V24Field coverageType;

public HL7V24Field CoverageType
{
    get
    {
        if (coverageType != null)
        {
            return coverageType;
        }

        coverageType = new HL7V24Field
        {
            field = message[@"IN1"][47],
            Id = @"IN1.47",
            Type = @"Field",
            Position = @"IN1.47",
            Name = @"Coverage Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0309",
            TableName = @"Coverage type",
            Description = @"This field contains the coding structure that identifies the type of insurance coverage, or what types of services are covered for the purposes of a billing system.  For example, a physician billing system will only want to receive insurance information for plans that cover physician/professional charges.  Refer to User-defined Table 0309 - Coverage type for suggested values",
            Sample = @"",
        };

        

        

        

        return coverageType;
    } 
}
internal HL7V24Field handicap;

public HL7V24Field Handicap
{
    get
    {
        if (handicap != null)
        {
            return handicap;
        }

        handicap = new HL7V24Field
        {
            field = message[@"IN1"][48],
            Id = @"IN1.48",
            Type = @"Field",
            Position = @"IN1.48",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0295",
            TableName = @"Handicap",
            Description = @"This field contains a code to describe the insured’s disability.  Refer to User-defined Table 0295 - Handicap for suggested values",
            Sample = @"",
        };

        

        

        

        return handicap;
    } 
}
internal HL7V24Field insured'sIDNumber;

public HL7V24Field Insured'sIDNumber
{
    get
    {
        if (insured'sIDNumber != null)
        {
            return insured'sIDNumber;
        }

        insured'sIDNumber = new HL7V24Field
        {
            field = message[@"IN1"][49],
            Id = @"IN1.49",
            Type = @"Field",
            Position = @"IN1.49",
            Name = @"Insured's ID Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This data element contains a healthcare institution’s identifiers for the insured.  The assigning authority and identifier type code are strongly recommended for all CX data types",
            Sample = @"",
        };

        

        

        

        return insured'sIDNumber;
    } 
}

    }
}

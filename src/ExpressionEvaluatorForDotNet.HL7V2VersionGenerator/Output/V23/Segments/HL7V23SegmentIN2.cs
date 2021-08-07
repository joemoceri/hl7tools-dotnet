using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentIN2
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"IN2"; } }

        public string SegmentId { get { return @"IN2"; } }
        
        public string LongName { get { return @"Insurance additional info"; } }
        
        public string Description { get { return @"The IN2 segment contains additional insurance policy coverage and benefit information necessary for proper billing and reimbursement.  Fields used by this segment are defined by HCFA or other regulatory agencies."; } }
        
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
                            Id = @"IN2.1",
                            Type = @"Field",
                            Position = @"IN2.1",
                            Name = @"Insured's Employee ID",
                            Length = 59,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This fields contains the employee ID of the insured",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.1",
                            Type = @"Component",
                            Position = @"IN2.1.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.2",
                            Type = @"Component",
                            Position = @"IN2.1.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.3",
                            Type = @"Component",
                            Position = @"IN2.1.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.4",
                            Type = @"Component",
                            Position = @"IN2.1.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.1",
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
                            Id = @"IN2.1.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.2",
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
                            Id = @"IN2.1.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.3",
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
                            Id = @"IN2.1.5",
                            Type = @"Component",
                            Position = @"IN2.1.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.6",
                            Type = @"Component",
                            Position = @"IN2.1.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.1",
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
                            Id = @"IN2.1.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.2",
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
                            Id = @"IN2.1.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.2",
                            Type = @"Field",
                            Position = @"IN2.2",
                            Name = @"Insured's Social Security Number",
                            Length = 11,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This fields contains the social security number of the insured",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3",
                            Type = @"Field",
                            Position = @"IN2.3",
                            Name = @"Insured's Employer Name",
                            Length = 130,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of insured’s employer or the person who purchased the insurance for the insured.  Multiple names for the same employer may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.  When the employer is an organization use IN2-70-insured employer organization name and ID.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.1",
                            Type = @"Component",
                            Position = @"IN2.3.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.2",
                            Type = @"Component",
                            Position = @"IN2.3.2",
                            Name = @"Family Name",
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
                            Id = @"IN2.3.3",
                            Type = @"Component",
                            Position = @"IN2.3.3",
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
                            Id = @"IN2.3.4",
                            Type = @"Component",
                            Position = @"IN2.3.4",
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
                            Id = @"IN2.3.5",
                            Type = @"Component",
                            Position = @"IN2.3.5",
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
                            Id = @"IN2.3.6",
                            Type = @"Component",
                            Position = @"IN2.3.6",
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
                            Id = @"IN2.3.7",
                            Type = @"Component",
                            Position = @"IN2.3.7",
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
                            Id = @"IN2.3.8",
                            Type = @"Component",
                            Position = @"IN2.3.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.9",
                            Type = @"Component",
                            Position = @"IN2.3.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.9.1",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.1",
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
                            Id = @"IN2.3.9.2",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.2",
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
                            Id = @"IN2.3.9.3",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.3",
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
                            Id = @"IN2.3.10",
                            Type = @"Component",
                            Position = @"IN2.3.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.11",
                            Type = @"Component",
                            Position = @"IN2.3.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.12",
                            Type = @"Component",
                            Position = @"IN2.3.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.13",
                            Type = @"Component",
                            Position = @"IN2.3.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.14",
                            Type = @"Component",
                            Position = @"IN2.3.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.14.1",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.1",
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
                            Id = @"IN2.3.14.2",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.2",
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
                            Id = @"IN2.3.14.3",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.4",
                            Type = @"Field",
                            Position = @"IN2.4",
                            Name = @"Employer Information Data",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0139",
                            TableName = @"Employer information data",
                            Description = @"This field contains the required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - Employer information data for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.5",
                            Type = @"Field",
                            Position = @"IN2.5",
                            Name = @"Mail Claim Party",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0137",
                            TableName = @"Mail claim party",
                            Description = @"This field contains the party to which the claim should be mailed.  Refer to user-defined table 0137 - Mail claim party for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.6",
                            Type = @"Field",
                            Position = @"IN2.6",
                            Name = @"Medicare Health Ins Card Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the Medicare Health Insurance Number (HIN), defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7",
                            Type = @"Field",
                            Position = @"IN2.7",
                            Name = @"Medicaid Case Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the Medicaid case name, defined by HCFA or other regulatory agencies. Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7.1",
                            Type = @"Component",
                            Position = @"IN2.7.1",
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
                            Id = @"IN2.7.2",
                            Type = @"Component",
                            Position = @"IN2.7.2",
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
                            Id = @"IN2.7.3",
                            Type = @"Component",
                            Position = @"IN2.7.3",
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
                            Id = @"IN2.7.4",
                            Type = @"Component",
                            Position = @"IN2.7.4",
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
                            Id = @"IN2.7.5",
                            Type = @"Component",
                            Position = @"IN2.7.5",
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
                            Id = @"IN2.7.6",
                            Type = @"Component",
                            Position = @"IN2.7.6",
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
                            Id = @"IN2.7.7",
                            Type = @"Component",
                            Position = @"IN2.7.7",
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
                            Id = @"IN2.7.8",
                            Type = @"Component",
                            Position = @"IN2.7.8",
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
                            Id = @"IN2.8",
                            Type = @"Field",
                            Position = @"IN2.8",
                            Name = @"Medicaid Case Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the Medicaid case number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Medicaid policy.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9",
                            Type = @"Field",
                            Position = @"IN2.9",
                            Name = @"Champus Sponsor Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by HCFA or other regulatory agencies.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9.1",
                            Type = @"Component",
                            Position = @"IN2.9.1",
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
                            Id = @"IN2.9.2",
                            Type = @"Component",
                            Position = @"IN2.9.2",
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
                            Id = @"IN2.9.3",
                            Type = @"Component",
                            Position = @"IN2.9.3",
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
                            Id = @"IN2.9.4",
                            Type = @"Component",
                            Position = @"IN2.9.4",
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
                            Id = @"IN2.9.5",
                            Type = @"Component",
                            Position = @"IN2.9.5",
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
                            Id = @"IN2.9.6",
                            Type = @"Component",
                            Position = @"IN2.9.6",
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
                            Id = @"IN2.9.7",
                            Type = @"Component",
                            Position = @"IN2.9.7",
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
                            Id = @"IN2.9.8",
                            Type = @"Component",
                            Position = @"IN2.9.8",
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
                            Id = @"IN2.10",
                            Type = @"Field",
                            Position = @"IN2.10",
                            Name = @"Champus ID Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the Champus ID number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Champus policy",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11",
                            Type = @"Field",
                            Position = @"IN2.11",
                            Name = @"Dependent of Champus Recipient",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.1",
                            Type = @"Component",
                            Position = @"IN2.11.1",
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
                            Id = @"IN2.11.2",
                            Type = @"Component",
                            Position = @"IN2.11.2",
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
                            Id = @"IN2.11.3",
                            Type = @"Component",
                            Position = @"IN2.11.3",
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
                            Id = @"IN2.11.4",
                            Type = @"Component",
                            Position = @"IN2.11.4",
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
                            Id = @"IN2.11.5",
                            Type = @"Component",
                            Position = @"IN2.11.5",
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
                            Id = @"IN2.11.6",
                            Type = @"Component",
                            Position = @"IN2.11.6",
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
                            Id = @"IN2.12",
                            Type = @"Field",
                            Position = @"IN2.12",
                            Name = @"Champus Organization",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.13",
                            Type = @"Field",
                            Position = @"IN2.13",
                            Name = @"Champus Station",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.14",
                            Type = @"Field",
                            Position = @"IN2.14",
                            Name = @"Champus Service",
                            Length = 14,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0140",
                            TableName = @"Champus Service",
                            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0140 - Champus service for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.15",
                            Type = @"Field",
                            Position = @"IN2.15",
                            Name = @"Champus Rank/Grade",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0141",
                            TableName = @"Champus Rank/Grade",
                            Description = @"This user-defined field identifies the Champus military rank/grade of the insured.  Refer to userdefined table 0141 - Champus rank/grade for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.16",
                            Type = @"Field",
                            Position = @"IN2.16",
                            Name = @"Champus Status",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0142",
                            TableName = @"Champus Status",
                            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0142 - Champus status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.17",
                            Type = @"Field",
                            Position = @"IN2.17",
                            Name = @"Champus Retire Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.18",
                            Type = @"Field",
                            Position = @"IN2.18",
                            Name = @"Champus Non-Avail Cert on File",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.19",
                            Type = @"Field",
                            Position = @"IN2.19",
                            Name = @"Baby Coverage",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.20",
                            Type = @"Field",
                            Position = @"IN2.20",
                            Name = @"Combine Baby Bill",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.21",
                            Type = @"Field",
                            Position = @"IN2.21",
                            Name = @"Blood Deductible",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Use this field instead of UB2-2-blood deductible, as the blood deductible can be associated with the specific insurance plan via this field",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22",
                            Type = @"Field",
                            Position = @"IN2.22",
                            Name = @"Special Coverage Approval Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the individual who approves any special coverage.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22.1",
                            Type = @"Component",
                            Position = @"IN2.22.1",
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
                            Id = @"IN2.22.2",
                            Type = @"Component",
                            Position = @"IN2.22.2",
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
                            Id = @"IN2.22.3",
                            Type = @"Component",
                            Position = @"IN2.22.3",
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
                            Id = @"IN2.22.4",
                            Type = @"Component",
                            Position = @"IN2.22.4",
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
                            Id = @"IN2.22.5",
                            Type = @"Component",
                            Position = @"IN2.22.5",
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
                            Id = @"IN2.22.6",
                            Type = @"Component",
                            Position = @"IN2.22.6",
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
                            Id = @"IN2.22.7",
                            Type = @"Component",
                            Position = @"IN2.22.7",
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
                            Id = @"IN2.22.8",
                            Type = @"Component",
                            Position = @"IN2.22.8",
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
                            Id = @"IN2.23",
                            Type = @"Field",
                            Position = @"IN2.23",
                            Name = @"Special Coverage Approval Title",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the title of the person who approves special coverage",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.24",
                            Type = @"Field",
                            Position = @"IN2.24",
                            Name = @"Non-Covered Insurance Code",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0143",
                            TableName = @"Non-covered insurance code",
                            Description = @"This field contains the code that describes why a service is not covered.  Refer to user-defined table 0143 - Non-covered insurance code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25",
                            Type = @"Field",
                            Position = @"IN2.25",
                            Name = @"Payor ID",
                            Length = 59,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is required for NEIC processing, and it identifies the organization from which reimbursement is expected.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.1",
                            Type = @"Component",
                            Position = @"IN2.25.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.2",
                            Type = @"Component",
                            Position = @"IN2.25.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.3",
                            Type = @"Component",
                            Position = @"IN2.25.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.4",
                            Type = @"Component",
                            Position = @"IN2.25.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.1",
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
                            Id = @"IN2.25.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.2",
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
                            Id = @"IN2.25.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.3",
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
                            Id = @"IN2.25.5",
                            Type = @"Component",
                            Position = @"IN2.25.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.6",
                            Type = @"Component",
                            Position = @"IN2.25.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.1",
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
                            Id = @"IN2.25.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.2",
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
                            Id = @"IN2.25.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26",
                            Type = @"Field",
                            Position = @"IN2.26",
                            Name = @"Payor Subscriber ID",
                            Length = 59,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is required for NEIC processing, and it identifies the specific office within the insurance carrier that is designated as responsible for the claim.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.1",
                            Type = @"Component",
                            Position = @"IN2.26.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.2",
                            Type = @"Component",
                            Position = @"IN2.26.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.3",
                            Type = @"Component",
                            Position = @"IN2.26.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.4",
                            Type = @"Component",
                            Position = @"IN2.26.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.1",
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
                            Id = @"IN2.26.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.2",
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
                            Id = @"IN2.26.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.3",
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
                            Id = @"IN2.26.5",
                            Type = @"Component",
                            Position = @"IN2.26.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.6",
                            Type = @"Component",
                            Position = @"IN2.26.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.1",
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
                            Id = @"IN2.26.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.2",
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
                            Id = @"IN2.26.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.27",
                            Type = @"Field",
                            Position = @"IN2.27",
                            Name = @"Eligibility Source",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0144",
                            TableName = @"Eligibility source",
                            Description = @"This field is required for NEIC processing, and it identifies the source of information about the insured’s eligibility for benefits.  Refer to user-defined table 0144 - Eligibility source for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28",
                            Type = @"Field",
                            Position = @"IN2.28",
                            Name = @"Room Coverage Type/Amount",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_RMC",
                            DataTypeName = @"Room Coverage",
                            TableId = null,
                            TableName = null,
                            Description = @" Use this field instead of IN1-40-room rate-semi-private and IN1-41-room rate-private.  This field contains room type (e.g., private, semi-private), amount type (e.g., limit, percentage) and amount covered by the insurance.  Refer to user-defined tables 0145 - Room type and 0146 - Amount type for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.1",
                            Type = @"Component",
                            Position = @"IN2.28.1",
                            Name = @"Room Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0145",
                            TableName = @"Room type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.2",
                            Type = @"Component",
                            Position = @"IN2.28.2",
                            Name = @"Amount Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0146",
                            TableName = @"Amount type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.3",
                            Type = @"Component",
                            Position = @"IN2.28.3",
                            Name = @"Coverage Amount",
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
                            Id = @"IN2.29",
                            Type = @"Field",
                            Position = @"IN2.29",
                            Name = @"Policy Type/Amount",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_PTA",
                            DataTypeName = @"Policy Type",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  Use this field instead of IN1-38-policy limit-amount.  Refer to user-defined tables 0147 - Policy type and 0193 - Amount class for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.1",
                            Type = @"Component",
                            Position = @"IN2.29.1",
                            Name = @"Policy Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0147",
                            TableName = @"Policy type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.2",
                            Type = @"Component",
                            Position = @"IN2.29.2",
                            Name = @"Amount Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0193",
                            TableName = @"Amount class",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.3",
                            Type = @"Component",
                            Position = @"IN2.29.3",
                            Name = @"Amount",
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
                            Id = @"IN2.30",
                            Type = @"Field",
                            Position = @"IN2.30",
                            Name = @"Daily Deductible",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_DDI",
                            DataTypeName = @"Daily Deductible",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of days after which the daily deductible begins, the amount of the deductible, and the number of days to apply the deductible",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.30.1",
                            Type = @"Component",
                            Position = @"IN2.30.1",
                            Name = @"Delay Days",
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
                            Id = @"IN2.30.2",
                            Type = @"Component",
                            Position = @"IN2.30.2",
                            Name = @"Amount",
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
                            Id = @"IN2.30.3",
                            Type = @"Component",
                            Position = @"IN2.30.3",
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
                            Id = @"IN2.31",
                            Type = @"Field",
                            Position = @"IN2.31",
                            Name = @"Living Dependency",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0223",
                            TableName = @"Living dependency",
                            Description = @"This field identifies the specific living conditions for the insured.  Refer to user-defined table 0223- Living dependency for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.32",
                            Type = @"Field",
                            Position = @"IN2.32",
                            Name = @"Ambulatory Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0009",
                            TableName = @"Ambulatory status",
                            Description = @"This field identifies the insured’s state of mobility.  Refer to user-defined table 0009 - Ambulatory status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.33",
                            Type = @"Field",
                            Position = @"IN2.33",
                            Name = @"Citizenship",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0171",
                            TableName = @"Citizenship",
                            Description = @"This field contains the code that identifies the insured’s citizenship.  HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34",
                            Type = @"Field",
                            Position = @"IN2.34",
                            Name = @"Primary Language",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0296",
                            TableName = @"Primary language",
                            Description = @"This field identifies the insured’s primary speaking language.  HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.1",
                            Type = @"Component",
                            Position = @"IN2.34.1",
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
                            Id = @"IN2.34.2",
                            Type = @"Component",
                            Position = @"IN2.34.2",
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
                            Id = @"IN2.34.3",
                            Type = @"Component",
                            Position = @"IN2.34.3",
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
                            Id = @"IN2.34.4",
                            Type = @"Component",
                            Position = @"IN2.34.4",
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
                            Id = @"IN2.34.5",
                            Type = @"Component",
                            Position = @"IN2.34.5",
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
                            Id = @"IN2.34.6",
                            Type = @"Component",
                            Position = @"IN2.34.6",
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
                            Id = @"IN2.35",
                            Type = @"Field",
                            Position = @"IN2.35",
                            Name = @"Living Arrangement",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0220",
                            TableName = @"Living arrangement",
                            Description = @"This field indicates the situation in which the insured person lives at his primary residence.  Refer to user-defined table 0220 - Living arrangement for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36",
                            Type = @"Field",
                            Position = @"IN2.36",
                            Name = @"Publicity Indicator",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0215",
                            TableName = @"Publicity code",
                            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the insured.  Refer to user-defined table 0215 - Publicity code for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.1",
                            Type = @"Component",
                            Position = @"IN2.36.1",
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
                            Id = @"IN2.36.2",
                            Type = @"Component",
                            Position = @"IN2.36.2",
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
                            Id = @"IN2.36.3",
                            Type = @"Component",
                            Position = @"IN2.36.3",
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
                            Id = @"IN2.36.4",
                            Type = @"Component",
                            Position = @"IN2.36.4",
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
                            Id = @"IN2.36.5",
                            Type = @"Component",
                            Position = @"IN2.36.5",
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
                            Id = @"IN2.36.6",
                            Type = @"Component",
                            Position = @"IN2.36.6",
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
                            Id = @"IN2.37",
                            Type = @"Field",
                            Position = @"IN2.37",
                            Name = @"Protection Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field identifies the insured’s protection, which determines whether or not access to information about this enrollee should be restricted from users who do not have adequate authority.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y restrict access
N do not restrict access",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.38",
                            Type = @"Field",
                            Position = @"IN2.38",
                            Name = @"Student Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0231",
                            TableName = @"Student status",
                            Description = @"This field identifies whether the insured is currently a student or not, and whether the patient is a full-time or a part-time student.  This field does not indicate the degree level (high school, college) of student, or his/her field of study (accounting, engineering, etc.).  Refer to user-defined table 0231 - Student status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.39",
                            Type = @"Field",
                            Position = @"IN2.39",
                            Name = @"Religion",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0006",
                            TableName = @"Religion",
                            Description = @"This field indicates the type of religion practiced by the insured.  Refer to user-defined table 0006 - Religion for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.40",
                            Type = @"Field",
                            Position = @"IN2.40",
                            Name = @"Mother s Maiden Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the insured’s mother’s maiden name.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.40.1",
                            Type = @"Component",
                            Position = @"IN2.40.1",
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
                            Id = @"IN2.40.2",
                            Type = @"Component",
                            Position = @"IN2.40.2",
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
                            Id = @"IN2.40.3",
                            Type = @"Component",
                            Position = @"IN2.40.3",
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
                            Id = @"IN2.40.4",
                            Type = @"Component",
                            Position = @"IN2.40.4",
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
                            Id = @"IN2.40.5",
                            Type = @"Component",
                            Position = @"IN2.40.5",
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
                            Id = @"IN2.40.6",
                            Type = @"Component",
                            Position = @"IN2.40.6",
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
                            Id = @"IN2.40.7",
                            Type = @"Component",
                            Position = @"IN2.40.7",
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
                            Id = @"IN2.40.8",
                            Type = @"Component",
                            Position = @"IN2.40.8",
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
                            Id = @"IN2.41",
                            Type = @"Field",
                            Position = @"IN2.41",
                            Name = @"Nationality Code",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0212",
                            TableName = @"Nationality",
                            Description = @"This field contains a code that identifies the nation or national grouping to which the insured person belongs.  This information may be different from a person’s citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.).  HL7 recommends using ISO table 3166 as he suggested values in user-defined table 0212 - Nationality.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.1",
                            Type = @"Component",
                            Position = @"IN2.41.1",
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
                            Id = @"IN2.41.2",
                            Type = @"Component",
                            Position = @"IN2.41.2",
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
                            Id = @"IN2.41.3",
                            Type = @"Component",
                            Position = @"IN2.41.3",
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
                            Id = @"IN2.41.4",
                            Type = @"Component",
                            Position = @"IN2.41.4",
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
                            Id = @"IN2.41.5",
                            Type = @"Component",
                            Position = @"IN2.41.5",
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
                            Id = @"IN2.41.6",
                            Type = @"Component",
                            Position = @"IN2.41.6",
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
                            Id = @"IN2.42",
                            Type = @"Field",
                            Position = @"IN2.42",
                            Name = @"Ethnic Group",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0189",
                            TableName = @"Ethnic group",
                            Description = @"This field indicates the insured’s ethnic group.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0189 - Ethnic group for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.43",
                            Type = @"Field",
                            Position = @"IN2.43",
                            Name = @"Marital Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0002",
                            TableName = @"Marital status",
                            Description = @"This field contains the insured’s marital status.  Refer to user-defined table 0002 - Marital status for suggested values.  Same values as those for PID-16-marital status.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.44",
                            Type = @"Field",
                            Position = @"IN2.44",
                            Name = @"Employment Start Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date on which the insured’s employment with a particular employer began.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.45",
                            Type = @"Field",
                            Position = @"IN2.45",
                            Name = @"Employment Stop Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"his field indicates the date on which the person’s employment with a particular employer ended.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.46",
                            Type = @"Field",
                            Position = @"IN2.46",
                            Name = @"Job Title",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a descriptive name for the insured’s occupation (for example, Sr. Systems Analyst, Sr. Accountant). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.47",
                            Type = @"Field",
                            Position = @"IN2.47",
                            Name = @"Job Code/Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"JCC",
                            DataTypeName = @"Job Code Class",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates a code that identifies the insured’s job code ( for example, programmer, analyst, doctor, etc.).  Refer to user-defined tables 0327 - Job code and 0328 - Job class for suggested values. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.47.1",
                            Type = @"Component",
                            Position = @"IN2.47.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code",
                            Description = @"This component contains the person’s  job code.  Refer to user-defined table 0327 - job code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.47.2",
                            Type = @"Component",
                            Position = @"IN2.47.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the person’s employee classification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.48",
                            Type = @"Field",
                            Position = @"IN2.48",
                            Name = @"Job Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0311",
                            TableName = @"Job status",
                            Description = @"This field indicates a code that identifies the insured’s current job status (for example, part- time/workers comp, full-time/leave of absence, full-time/suspended,   etc.).  Refer to user-defined table 0311 - Job status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.49",
                            Type = @"Field",
                            Position = @"IN2.49",
                            Name = @"Employer Contact Person Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the contact person that should be contacted at the insured’s place of employment.  (Joe Smith is the insured.  He works at GTE.  Contact Sue Jones at GTE regarding Joe Smith’s policy).  Multiple names for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.49.1",
                            Type = @"Component",
                            Position = @"IN2.49.1",
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
                            Id = @"IN2.49.2",
                            Type = @"Component",
                            Position = @"IN2.49.2",
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
                            Id = @"IN2.49.3",
                            Type = @"Component",
                            Position = @"IN2.49.3",
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
                            Id = @"IN2.49.4",
                            Type = @"Component",
                            Position = @"IN2.49.4",
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
                            Id = @"IN2.49.5",
                            Type = @"Component",
                            Position = @"IN2.49.5",
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
                            Id = @"IN2.49.6",
                            Type = @"Component",
                            Position = @"IN2.49.6",
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
                            Id = @"IN2.49.7",
                            Type = @"Component",
                            Position = @"IN2.49.7",
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
                            Id = @"IN2.49.8",
                            Type = @"Component",
                            Position = @"IN2.49.8",
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
                            Id = @"IN2.50",
                            Type = @"Field",
                            Position = @"IN2.50",
                            Name = @"Employer Contact Person Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the telephone number for Sue Jones who is the contact person at GTE (Joe Smith’s place of employment).  Joe Smith is the insured.  Multiple phone numbers for the same contact person may be sent in this sequence, not multiple contacts.  The primary telephone number is assumed to be in the first repetition.  When no primary telephone number is sent, a repeat delimiter must be present for the first repetition. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.50.1",
                            Type = @"Component",
                            Position = @"IN2.50.1",
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
                            Id = @"IN2.50.2",
                            Type = @"Component",
                            Position = @"IN2.50.2",
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
                            Id = @"IN2.50.3",
                            Type = @"Component",
                            Position = @"IN2.50.3",
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
                            Id = @"IN2.50.4",
                            Type = @"Component",
                            Position = @"IN2.50.4",
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
                            Id = @"IN2.50.5",
                            Type = @"Component",
                            Position = @"IN2.50.5",
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
                            Id = @"IN2.50.6",
                            Type = @"Component",
                            Position = @"IN2.50.6",
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
                            Id = @"IN2.50.7",
                            Type = @"Component",
                            Position = @"IN2.50.7",
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
                            Id = @"IN2.50.8",
                            Type = @"Component",
                            Position = @"IN2.50.8",
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
                            Id = @"IN2.50.9",
                            Type = @"Component",
                            Position = @"IN2.50.9",
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
                            Id = @"IN2.51",
                            Type = @"Field",
                            Position = @"IN2.51",
                            Name = @"Employer Contact Reason",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0222",
                            TableName = @"Contact reason",
                            Description = @"This field contains the reason(s) that Sue Jones should be contacted on behalf of Joe Smith, a GTE employer.  Refer to user-defined table 0222 - Contact reason for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.52",
                            Type = @"Field",
                            Position = @"IN2.52",
                            Name = @"Insured's Contact Person Name",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the contact person for the insured",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.52.1",
                            Type = @"Component",
                            Position = @"IN2.52.1",
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
                            Id = @"IN2.52.2",
                            Type = @"Component",
                            Position = @"IN2.52.2",
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
                            Id = @"IN2.52.3",
                            Type = @"Component",
                            Position = @"IN2.52.3",
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
                            Id = @"IN2.52.4",
                            Type = @"Component",
                            Position = @"IN2.52.4",
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
                            Id = @"IN2.52.5",
                            Type = @"Component",
                            Position = @"IN2.52.5",
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
                            Id = @"IN2.52.6",
                            Type = @"Component",
                            Position = @"IN2.52.6",
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
                            Id = @"IN2.52.7",
                            Type = @"Component",
                            Position = @"IN2.52.7",
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
                            Id = @"IN2.52.8",
                            Type = @"Component",
                            Position = @"IN2.52.8",
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
                            Id = @"IN2.53",
                            Type = @"Field",
                            Position = @"IN2.53",
                            Name = @"Insured s Contact Person Telephone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the telephone number for the contact person for the insured.  Multiple names for the same person may be sent in this contact, not multiple contacts.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.53.1",
                            Type = @"Component",
                            Position = @"IN2.53.1",
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
                            Id = @"IN2.53.2",
                            Type = @"Component",
                            Position = @"IN2.53.2",
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
                            Id = @"IN2.53.3",
                            Type = @"Component",
                            Position = @"IN2.53.3",
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
                            Id = @"IN2.53.4",
                            Type = @"Component",
                            Position = @"IN2.53.4",
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
                            Id = @"IN2.53.5",
                            Type = @"Component",
                            Position = @"IN2.53.5",
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
                            Id = @"IN2.53.6",
                            Type = @"Component",
                            Position = @"IN2.53.6",
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
                            Id = @"IN2.53.7",
                            Type = @"Component",
                            Position = @"IN2.53.7",
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
                            Id = @"IN2.53.8",
                            Type = @"Component",
                            Position = @"IN2.53.8",
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
                            Id = @"IN2.53.9",
                            Type = @"Component",
                            Position = @"IN2.53.9",
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
                            Id = @"IN2.54",
                            Type = @"Field",
                            Position = @"IN2.54",
                            Name = @"Insured s Contact Person Reason",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0222",
                            TableName = @"Contact reason",
                            Description = @"This field contains the reason(s) the person should be contacted regarding the insured.  Refer to user-defined table - 0222 - Contact reason for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.55",
                            Type = @"Field",
                            Position = @"IN2.55",
                            Name = @"Relationship To The Patient Start Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date on which the insured’s patient relationship (defined in IN1-17insured’s relationship to patient) became effective (began). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.56",
                            Type = @"Field",
                            Position = @"IN2.56",
                            Name = @"Relationship To The Patient Stop Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the date after which the relationship (defined in IN1-17-insured’s relationship to patient) is no longer effective",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.57",
                            Type = @"Field",
                            Position = @"IN2.57",
                            Name = @"Insurance Company Contact Reason",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0232",
                            TableName = @"Insurance company contact reason",
                            Description = @"This field contains a user-defined code that specifies how the contact should be used.  Refer to user-defined table 0232 - Insurance company contact reason for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58",
                            Type = @"Field",
                            Position = @"IN2.58",
                            Name = @"Insurance Company Contact Phone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the telephone number of the person who should be contacted at the insurance company for questions regarding an insurance policy/claim, etc.  Multiple phone numbers for the insurance company may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.  ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58.1",
                            Type = @"Component",
                            Position = @"IN2.58.1",
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
                            Id = @"IN2.58.2",
                            Type = @"Component",
                            Position = @"IN2.58.2",
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
                            Id = @"IN2.58.3",
                            Type = @"Component",
                            Position = @"IN2.58.3",
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
                            Id = @"IN2.58.4",
                            Type = @"Component",
                            Position = @"IN2.58.4",
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
                            Id = @"IN2.58.5",
                            Type = @"Component",
                            Position = @"IN2.58.5",
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
                            Id = @"IN2.58.6",
                            Type = @"Component",
                            Position = @"IN2.58.6",
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
                            Id = @"IN2.58.7",
                            Type = @"Component",
                            Position = @"IN2.58.7",
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
                            Id = @"IN2.58.8",
                            Type = @"Component",
                            Position = @"IN2.58.8",
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
                            Id = @"IN2.58.9",
                            Type = @"Component",
                            Position = @"IN2.58.9",
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
                            Id = @"IN2.59",
                            Type = @"Field",
                            Position = @"IN2.59",
                            Name = @"Policy Scope",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0312",
                            TableName = @"Policy scope",
                            Description = @"This field contains a user-defined code designating the extent of the coverage for a participating member (e.g., “single,” “family,” etc.  Refer to user-defined table 0312 - Policy scope for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.60",
                            Type = @"Field",
                            Position = @"IN2.60",
                            Name = @"Policy Source",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0313",
                            TableName = @"Policy source",
                            Description = @"This user-defined field identifies how the policy information got established.  Refer to userdefined table 0313 - Policy source for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61",
                            Type = @"Field",
                            Position = @"IN2.61",
                            Name = @"Patient Member Number",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifying number assigned by the payor for each individual covered by the insurance policy issued to the insured.  For example, each individual family member may have a different member number from the insurance policy number issued to the head of household.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.1",
                            Type = @"Component",
                            Position = @"IN2.61.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.2",
                            Type = @"Component",
                            Position = @"IN2.61.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.3",
                            Type = @"Component",
                            Position = @"IN2.61.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.4",
                            Type = @"Component",
                            Position = @"IN2.61.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.1",
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
                            Id = @"IN2.61.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.2",
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
                            Id = @"IN2.61.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.3",
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
                            Id = @"IN2.61.5",
                            Type = @"Component",
                            Position = @"IN2.61.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.6",
                            Type = @"Component",
                            Position = @"IN2.61.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.1",
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
                            Id = @"IN2.61.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.2",
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
                            Id = @"IN2.61.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.62",
                            Type = @"Field",
                            Position = @"IN2.62",
                            Name = @"Guarantor's Relationship To Insured",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0063",
                            TableName = @"Relationship",
                            Description = @"This field specifies the relationship of the guarantor to the insurance subscriber.  Refer to userdefined table 0063-Relationship for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63",
                            Type = @"Field",
                            Position = @"IN2.63",
                            Name = @"Insured's Telephone Number - Home",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"The value of this field represents the insured’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition (PRN - Primary, PH - Telephone).  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63.1",
                            Type = @"Component",
                            Position = @"IN2.63.1",
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
                            Id = @"IN2.63.2",
                            Type = @"Component",
                            Position = @"IN2.63.2",
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
                            Id = @"IN2.63.3",
                            Type = @"Component",
                            Position = @"IN2.63.3",
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
                            Id = @"IN2.63.4",
                            Type = @"Component",
                            Position = @"IN2.63.4",
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
                            Id = @"IN2.63.5",
                            Type = @"Component",
                            Position = @"IN2.63.5",
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
                            Id = @"IN2.63.6",
                            Type = @"Component",
                            Position = @"IN2.63.6",
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
                            Id = @"IN2.63.7",
                            Type = @"Component",
                            Position = @"IN2.63.7",
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
                            Id = @"IN2.63.8",
                            Type = @"Component",
                            Position = @"IN2.63.8",
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
                            Id = @"IN2.63.9",
                            Type = @"Component",
                            Position = @"IN2.63.9",
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
                            Id = @"IN2.64",
                            Type = @"Field",
                            Position = @"IN2.64",
                            Name = @"Insured's Employer Telephone Number",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"The value of this field represents the insured’s employer’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.64.1",
                            Type = @"Component",
                            Position = @"IN2.64.1",
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
                            Id = @"IN2.64.2",
                            Type = @"Component",
                            Position = @"IN2.64.2",
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
                            Id = @"IN2.64.3",
                            Type = @"Component",
                            Position = @"IN2.64.3",
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
                            Id = @"IN2.64.4",
                            Type = @"Component",
                            Position = @"IN2.64.4",
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
                            Id = @"IN2.64.5",
                            Type = @"Component",
                            Position = @"IN2.64.5",
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
                            Id = @"IN2.64.6",
                            Type = @"Component",
                            Position = @"IN2.64.6",
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
                            Id = @"IN2.64.7",
                            Type = @"Component",
                            Position = @"IN2.64.7",
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
                            Id = @"IN2.64.8",
                            Type = @"Component",
                            Position = @"IN2.64.8",
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
                            Id = @"IN2.64.9",
                            Type = @"Component",
                            Position = @"IN2.64.9",
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
                            Id = @"IN2.65",
                            Type = @"Field",
                            Position = @"IN2.65",
                            Name = @"Military Handicapped Program",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the Champus program for the handicapped in which the patient is enrolled",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.1",
                            Type = @"Component",
                            Position = @"IN2.65.1",
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
                            Id = @"IN2.65.2",
                            Type = @"Component",
                            Position = @"IN2.65.2",
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
                            Id = @"IN2.65.3",
                            Type = @"Component",
                            Position = @"IN2.65.3",
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
                            Id = @"IN2.65.4",
                            Type = @"Component",
                            Position = @"IN2.65.4",
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
                            Id = @"IN2.65.5",
                            Type = @"Component",
                            Position = @"IN2.65.5",
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
                            Id = @"IN2.65.6",
                            Type = @"Component",
                            Position = @"IN2.65.6",
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
                            Id = @"IN2.66",
                            Type = @"Field",
                            Position = @"IN2.66",
                            Name = @"Suspend Flag",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether charges should be suspended for a patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y charges should be suspended 
N charges should NOT be suspended ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.67",
                            Type = @"Field",
                            Position = @"IN2.67",
                            Name = @"Co-pay Limit Flag",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates if the patient has reached the co-pay limit so that no more co-pay charges should be calculated for the patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the patient is at or exceeds the co-pay limit 
N the patient is under the co-pay limit ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.68",
                            Type = @"Field",
                            Position = @"IN2.68",
                            Name = @"Stoploss Limit Flag",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates if the patient has reached the stoploss limit established in the Contract Master.  Refer to HL7 table 0136 - Yes/no indicator for valid values

Y the patient has reached the stoploss limit 
N the patient has not reached the stoploss limi",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69",
                            Type = @"Field",
                            Position = @"IN2.69",
                            Name = @"Insured Organization Name And ID",
                            Length = 130,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And ID For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the name of the insured if the insured/subscriber is an organization.  Multiple names for the insured may be sent in this sequence, not multiple insured people.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.1",
                            Type = @"Component",
                            Position = @"IN2.69.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.2",
                            Type = @"Component",
                            Position = @"IN2.69.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.3",
                            Type = @"Component",
                            Position = @"IN2.69.3",
                            Name = @"ID Number",
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
                            Id = @"IN2.69.4",
                            Type = @"Component",
                            Position = @"IN2.69.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.5",
                            Type = @"Component",
                            Position = @"IN2.69.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.6",
                            Type = @"Component",
                            Position = @"IN2.69.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.1",
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
                            Id = @"IN2.69.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.2",
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
                            Id = @"IN2.69.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.3",
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
                            Id = @"IN2.69.7",
                            Type = @"Component",
                            Position = @"IN2.69.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.8",
                            Type = @"Component",
                            Position = @"IN2.69.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.8.1",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.1",
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
                            Id = @"IN2.69.8.2",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.2",
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
                            Id = @"IN2.69.8.3",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70",
                            Type = @"Field",
                            Position = @"IN2.70",
                            Name = @"Insured Employer Organization Name And ID",
                            Length = 130,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And ID For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the name of the insured’s employer, or the organization that purchased the insurance for the insured, if the employer is an organization.  Multiple names and identifiers for the same organization may be sent in this field, not multiple organizations.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.1",
                            Type = @"Component",
                            Position = @"IN2.70.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.2",
                            Type = @"Component",
                            Position = @"IN2.70.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.3",
                            Type = @"Component",
                            Position = @"IN2.70.3",
                            Name = @"ID Number",
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
                            Id = @"IN2.70.4",
                            Type = @"Component",
                            Position = @"IN2.70.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.5",
                            Type = @"Component",
                            Position = @"IN2.70.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.6",
                            Type = @"Component",
                            Position = @"IN2.70.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.1",
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
                            Id = @"IN2.70.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.2",
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
                            Id = @"IN2.70.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.3",
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
                            Id = @"IN2.70.7",
                            Type = @"Component",
                            Position = @"IN2.70.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.8",
                            Type = @"Component",
                            Position = @"IN2.70.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.8.1",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.1",
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
                            Id = @"IN2.70.8.2",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.2",
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
                            Id = @"IN2.70.8.3",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.3",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.71",
                            Type = @"Field",
                            Position = @"IN2.71",
                            Name = @"Race",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0005",
                            TableName = @"Race",
                            Description = @"RISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0005 - Race for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72",
                            Type = @"Field",
                            Position = @"IN2.72",
                            Name = @"Patient Relationship to Insured",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the relationship of the patient to the insured, as defined by HCFA or other regulatory agencies.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.1",
                            Type = @"Component",
                            Position = @"IN2.72.1",
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
                            Id = @"IN2.72.2",
                            Type = @"Component",
                            Position = @"IN2.72.2",
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
                            Id = @"IN2.72.3",
                            Type = @"Component",
                            Position = @"IN2.72.3",
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
                            Id = @"IN2.72.4",
                            Type = @"Component",
                            Position = @"IN2.72.4",
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
                            Id = @"IN2.72.5",
                            Type = @"Component",
                            Position = @"IN2.72.5",
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
                            Id = @"IN2.72.6",
                            Type = @"Component",
                            Position = @"IN2.72.6",
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
                        };
            }
        }

        public HL7V23SegmentIN2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field insured'sEmployeeID;

public HL7V23Field Insured'sEmployeeID
{
    get
    {
        if (insured'sEmployeeID != null)
        {
            return insured'sEmployeeID;
        }

        insured'sEmployeeID = new HL7V23Field
        {
            field = message[@"IN2"][1],
            Id = @"IN2.1",
            Type = @"Field",
            Position = @"IN2.1",
            Name = @"Insured's Employee ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This fields contains the employee ID of the insured",
            Sample = @"",
        };

        

        

        

        return insured'sEmployeeID;
    } 
}
internal HL7V23Field insured'sSocialSecurityNumber;

public HL7V23Field Insured'sSocialSecurityNumber
{
    get
    {
        if (insured'sSocialSecurityNumber != null)
        {
            return insured'sSocialSecurityNumber;
        }

        insured'sSocialSecurityNumber = new HL7V23Field
        {
            field = message[@"IN2"][2],
            Id = @"IN2.2",
            Type = @"Field",
            Position = @"IN2.2",
            Name = @"Insured's Social Security Number",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This fields contains the social security number of the insured",
            Sample = @"",
        };

        

        

        

        return insured'sSocialSecurityNumber;
    } 
}
internal HL7V23Field insured'sEmployerName;

public HL7V23Field Insured'sEmployerName
{
    get
    {
        if (insured'sEmployerName != null)
        {
            return insured'sEmployerName;
        }

        insured'sEmployerName = new HL7V23Field
        {
            field = message[@"IN2"][3],
            Id = @"IN2.3",
            Type = @"Field",
            Position = @"IN2.3",
            Name = @"Insured's Employer Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of insured’s employer or the person who purchased the insurance for the insured.  Multiple names for the same employer may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.  When the employer is an organization use IN2-70-insured employer organization name and ID.",
            Sample = @"",
        };

        

        

        

        return insured'sEmployerName;
    } 
}
internal HL7V23Field employerInformationData;

public HL7V23Field EmployerInformationData
{
    get
    {
        if (employerInformationData != null)
        {
            return employerInformationData;
        }

        employerInformationData = new HL7V23Field
        {
            field = message[@"IN2"][4],
            Id = @"IN2.4",
            Type = @"Field",
            Position = @"IN2.4",
            Name = @"Employer Information Data",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0139",
            TableName = @"Employer information data",
            Description = @"This field contains the required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - Employer information data for suggested values.",
            Sample = @"",
        };

        

        

        

        return employerInformationData;
    } 
}
internal HL7V23Field mailClaimParty;

public HL7V23Field MailClaimParty
{
    get
    {
        if (mailClaimParty != null)
        {
            return mailClaimParty;
        }

        mailClaimParty = new HL7V23Field
        {
            field = message[@"IN2"][5],
            Id = @"IN2.5",
            Type = @"Field",
            Position = @"IN2.5",
            Name = @"Mail Claim Party",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0137",
            TableName = @"Mail claim party",
            Description = @"This field contains the party to which the claim should be mailed.  Refer to user-defined table 0137 - Mail claim party for suggested values.",
            Sample = @"",
        };

        

        

        

        return mailClaimParty;
    } 
}
internal HL7V23Field medicareHealthInsCardNumber;

public HL7V23Field MedicareHealthInsCardNumber
{
    get
    {
        if (medicareHealthInsCardNumber != null)
        {
            return medicareHealthInsCardNumber;
        }

        medicareHealthInsCardNumber = new HL7V23Field
        {
            field = message[@"IN2"][6],
            Id = @"IN2.6",
            Type = @"Field",
            Position = @"IN2.6",
            Name = @"Medicare Health Ins Card Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicare Health Insurance Number (HIN), defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return medicareHealthInsCardNumber;
    } 
}
internal HL7V23Field medicaidCaseName;

public HL7V23Field MedicaidCaseName
{
    get
    {
        if (medicaidCaseName != null)
        {
            return medicaidCaseName;
        }

        medicaidCaseName = new HL7V23Field
        {
            field = message[@"IN2"][7],
            Id = @"IN2.7",
            Type = @"Field",
            Position = @"IN2.7",
            Name = @"Medicaid Case Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicaid case name, defined by HCFA or other regulatory agencies. Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return medicaidCaseName;
    } 
}
internal HL7V23Field medicaidCaseNumber;

public HL7V23Field MedicaidCaseNumber
{
    get
    {
        if (medicaidCaseNumber != null)
        {
            return medicaidCaseNumber;
        }

        medicaidCaseNumber = new HL7V23Field
        {
            field = message[@"IN2"][8],
            Id = @"IN2.8",
            Type = @"Field",
            Position = @"IN2.8",
            Name = @"Medicaid Case Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicaid case number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Medicaid policy.",
            Sample = @"",
        };

        

        

        

        return medicaidCaseNumber;
    } 
}
internal HL7V23Field champusSponsorName;

public HL7V23Field ChampusSponsorName
{
    get
    {
        if (champusSponsorName != null)
        {
            return champusSponsorName;
        }

        champusSponsorName = new HL7V23Field
        {
            field = message[@"IN2"][9],
            Id = @"IN2.9",
            Type = @"Field",
            Position = @"IN2.9",
            Name = @"Champus Sponsor Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return champusSponsorName;
    } 
}
internal HL7V23Field champusIDNumber;

public HL7V23Field ChampusIDNumber
{
    get
    {
        if (champusIDNumber != null)
        {
            return champusIDNumber;
        }

        champusIDNumber = new HL7V23Field
        {
            field = message[@"IN2"][10],
            Id = @"IN2.10",
            Type = @"Field",
            Position = @"IN2.10",
            Name = @"Champus ID Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Champus ID number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Champus policy",
            Sample = @"",
        };

        

        

        

        return champusIDNumber;
    } 
}
internal HL7V23Field dependentofChampusRecipient;

public HL7V23Field DependentofChampusRecipient
{
    get
    {
        if (dependentofChampusRecipient != null)
        {
            return dependentofChampusRecipient;
        }

        dependentofChampusRecipient = new HL7V23Field
        {
            field = message[@"IN2"][11],
            Id = @"IN2.11",
            Type = @"Field",
            Position = @"IN2.11",
            Name = @"Dependent of Champus Recipient",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return dependentofChampusRecipient;
    } 
}
internal HL7V23Field champusOrganization;

public HL7V23Field ChampusOrganization
{
    get
    {
        if (champusOrganization != null)
        {
            return champusOrganization;
        }

        champusOrganization = new HL7V23Field
        {
            field = message[@"IN2"][12],
            Id = @"IN2.12",
            Type = @"Field",
            Position = @"IN2.12",
            Name = @"Champus Organization",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return champusOrganization;
    } 
}
internal HL7V23Field champusStation;

public HL7V23Field ChampusStation
{
    get
    {
        if (champusStation != null)
        {
            return champusStation;
        }

        champusStation = new HL7V23Field
        {
            field = message[@"IN2"][13],
            Id = @"IN2.13",
            Type = @"Field",
            Position = @"IN2.13",
            Name = @"Champus Station",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return champusStation;
    } 
}
internal HL7V23Field champusService;

public HL7V23Field ChampusService
{
    get
    {
        if (champusService != null)
        {
            return champusService;
        }

        champusService = new HL7V23Field
        {
            field = message[@"IN2"][14],
            Id = @"IN2.14",
            Type = @"Field",
            Position = @"IN2.14",
            Name = @"Champus Service",
            Length = 14,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0140",
            TableName = @"Champus Service",
            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0140 - Champus service for suggested values.",
            Sample = @"",
        };

        

        

        

        return champusService;
    } 
}
internal HL7V23Field champusRankGrade;

public HL7V23Field ChampusRankGrade
{
    get
    {
        if (champusRankGrade != null)
        {
            return champusRankGrade;
        }

        champusRankGrade = new HL7V23Field
        {
            field = message[@"IN2"][15],
            Id = @"IN2.15",
            Type = @"Field",
            Position = @"IN2.15",
            Name = @"Champus Rank/Grade",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0141",
            TableName = @"Champus Rank/Grade",
            Description = @"This user-defined field identifies the Champus military rank/grade of the insured.  Refer to userdefined table 0141 - Champus rank/grade for suggested values.",
            Sample = @"",
        };

        

        

        

        return champusRankGrade;
    } 
}
internal HL7V23Field champusStatus;

public HL7V23Field ChampusStatus
{
    get
    {
        if (champusStatus != null)
        {
            return champusStatus;
        }

        champusStatus = new HL7V23Field
        {
            field = message[@"IN2"][16],
            Id = @"IN2.16",
            Type = @"Field",
            Position = @"IN2.16",
            Name = @"Champus Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0142",
            TableName = @"Champus Status",
            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0142 - Champus status for suggested values.",
            Sample = @"",
        };

        

        

        

        return champusStatus;
    } 
}
internal HL7V23Field champusRetireDate;

public HL7V23Field ChampusRetireDate
{
    get
    {
        if (champusRetireDate != null)
        {
            return champusRetireDate;
        }

        champusRetireDate = new HL7V23Field
        {
            field = message[@"IN2"][17],
            Id = @"IN2.17",
            Type = @"Field",
            Position = @"IN2.17",
            Name = @"Champus Retire Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return champusRetireDate;
    } 
}
internal HL7V23Field champusNonAvailCertonFile;

public HL7V23Field ChampusNonAvailCertonFile
{
    get
    {
        if (champusNonAvailCertonFile != null)
        {
            return champusNonAvailCertonFile;
        }

        champusNonAvailCertonFile = new HL7V23Field
        {
            field = message[@"IN2"][18],
            Id = @"IN2.18",
            Type = @"Field",
            Position = @"IN2.18",
            Name = @"Champus Non-Avail Cert on File",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
        };

        

        

        

        return champusNonAvailCertonFile;
    } 
}
internal HL7V23Field babyCoverage;

public HL7V23Field BabyCoverage
{
    get
    {
        if (babyCoverage != null)
        {
            return babyCoverage;
        }

        babyCoverage = new HL7V23Field
        {
            field = message[@"IN2"][19],
            Id = @"IN2.19",
            Type = @"Field",
            Position = @"IN2.19",
            Name = @"Baby Coverage",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
        };

        

        

        

        return babyCoverage;
    } 
}
internal HL7V23Field combineBabyBill;

public HL7V23Field CombineBabyBill
{
    get
    {
        if (combineBabyBill != null)
        {
            return combineBabyBill;
        }

        combineBabyBill = new HL7V23Field
        {
            field = message[@"IN2"][20],
            Id = @"IN2.20",
            Type = @"Field",
            Position = @"IN2.20",
            Name = @"Combine Baby Bill",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
        };

        

        

        

        return combineBabyBill;
    } 
}
internal HL7V23Field bloodDeductible;

public HL7V23Field BloodDeductible
{
    get
    {
        if (bloodDeductible != null)
        {
            return bloodDeductible;
        }

        bloodDeductible = new HL7V23Field
        {
            field = message[@"IN2"][21],
            Id = @"IN2.21",
            Type = @"Field",
            Position = @"IN2.21",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Use this field instead of UB2-2-blood deductible, as the blood deductible can be associated with the specific insurance plan via this field",
            Sample = @"",
        };

        

        

        

        return bloodDeductible;
    } 
}
internal HL7V23Field specialCoverageApprovalName;

public HL7V23Field SpecialCoverageApprovalName
{
    get
    {
        if (specialCoverageApprovalName != null)
        {
            return specialCoverageApprovalName;
        }

        specialCoverageApprovalName = new HL7V23Field
        {
            field = message[@"IN2"][22],
            Id = @"IN2.22",
            Type = @"Field",
            Position = @"IN2.22",
            Name = @"Special Coverage Approval Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the individual who approves any special coverage.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return specialCoverageApprovalName;
    } 
}
internal HL7V23Field specialCoverageApprovalTitle;

public HL7V23Field SpecialCoverageApprovalTitle
{
    get
    {
        if (specialCoverageApprovalTitle != null)
        {
            return specialCoverageApprovalTitle;
        }

        specialCoverageApprovalTitle = new HL7V23Field
        {
            field = message[@"IN2"][23],
            Id = @"IN2.23",
            Type = @"Field",
            Position = @"IN2.23",
            Name = @"Special Coverage Approval Title",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the title of the person who approves special coverage",
            Sample = @"",
        };

        

        

        

        return specialCoverageApprovalTitle;
    } 
}
internal HL7V23Field nonCoveredInsuranceCode;

public HL7V23Field NonCoveredInsuranceCode
{
    get
    {
        if (nonCoveredInsuranceCode != null)
        {
            return nonCoveredInsuranceCode;
        }

        nonCoveredInsuranceCode = new HL7V23Field
        {
            field = message[@"IN2"][24],
            Id = @"IN2.24",
            Type = @"Field",
            Position = @"IN2.24",
            Name = @"Non-Covered Insurance Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0143",
            TableName = @"Non-covered insurance code",
            Description = @"This field contains the code that describes why a service is not covered.  Refer to user-defined table 0143 - Non-covered insurance code for suggested values.",
            Sample = @"",
        };

        

        

        

        return nonCoveredInsuranceCode;
    } 
}
internal HL7V23Field payorID;

public HL7V23Field PayorID
{
    get
    {
        if (payorID != null)
        {
            return payorID;
        }

        payorID = new HL7V23Field
        {
            field = message[@"IN2"][25],
            Id = @"IN2.25",
            Type = @"Field",
            Position = @"IN2.25",
            Name = @"Payor ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field is required for NEIC processing, and it identifies the organization from which reimbursement is expected.",
            Sample = @"",
        };

        

        

        

        return payorID;
    } 
}
internal HL7V23Field payorSubscriberID;

public HL7V23Field PayorSubscriberID
{
    get
    {
        if (payorSubscriberID != null)
        {
            return payorSubscriberID;
        }

        payorSubscriberID = new HL7V23Field
        {
            field = message[@"IN2"][26],
            Id = @"IN2.26",
            Type = @"Field",
            Position = @"IN2.26",
            Name = @"Payor Subscriber ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field is required for NEIC processing, and it identifies the specific office within the insurance carrier that is designated as responsible for the claim.",
            Sample = @"",
        };

        

        

        

        return payorSubscriberID;
    } 
}
internal HL7V23Field eligibilitySource;

public HL7V23Field EligibilitySource
{
    get
    {
        if (eligibilitySource != null)
        {
            return eligibilitySource;
        }

        eligibilitySource = new HL7V23Field
        {
            field = message[@"IN2"][27],
            Id = @"IN2.27",
            Type = @"Field",
            Position = @"IN2.27",
            Name = @"Eligibility Source",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0144",
            TableName = @"Eligibility source",
            Description = @"This field is required for NEIC processing, and it identifies the source of information about the insured’s eligibility for benefits.  Refer to user-defined table 0144 - Eligibility source for suggested values.",
            Sample = @"",
        };

        

        

        

        return eligibilitySource;
    } 
}
internal HL7V23Field roomCoverageTypeAmount;

public HL7V23Field RoomCoverageTypeAmount
{
    get
    {
        if (roomCoverageTypeAmount != null)
        {
            return roomCoverageTypeAmount;
        }

        roomCoverageTypeAmount = new HL7V23Field
        {
            field = message[@"IN2"][28],
            Id = @"IN2.28",
            Type = @"Field",
            Position = @"IN2.28",
            Name = @"Room Coverage Type/Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_RMC",
            DataTypeName = @"Room Coverage",
            TableId = null,
            TableName = null,
            Description = @" Use this field instead of IN1-40-room rate-semi-private and IN1-41-room rate-private.  This field contains room type (e.g., private, semi-private), amount type (e.g., limit, percentage) and amount covered by the insurance.  Refer to user-defined tables 0145 - Room type and 0146 - Amount type for suggested values",
            Sample = @"",
        };

        

        

        

        return roomCoverageTypeAmount;
    } 
}
internal HL7V23Field policyTypeAmount;

public HL7V23Field PolicyTypeAmount
{
    get
    {
        if (policyTypeAmount != null)
        {
            return policyTypeAmount;
        }

        policyTypeAmount = new HL7V23Field
        {
            field = message[@"IN2"][29],
            Id = @"IN2.29",
            Type = @"Field",
            Position = @"IN2.29",
            Name = @"Policy Type/Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PTA",
            DataTypeName = @"Policy Type",
            TableId = null,
            TableName = null,
            Description = @"This field contains the policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  Use this field instead of IN1-38-policy limit-amount.  Refer to user-defined tables 0147 - Policy type and 0193 - Amount class for suggested values",
            Sample = @"",
        };

        

        

        

        return policyTypeAmount;
    } 
}
internal HL7V23Field dailyDeductible;

public HL7V23Field DailyDeductible
{
    get
    {
        if (dailyDeductible != null)
        {
            return dailyDeductible;
        }

        dailyDeductible = new HL7V23Field
        {
            field = message[@"IN2"][30],
            Id = @"IN2.30",
            Type = @"Field",
            Position = @"IN2.30",
            Name = @"Daily Deductible",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DDI",
            DataTypeName = @"Daily Deductible",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days after which the daily deductible begins, the amount of the deductible, and the number of days to apply the deductible",
            Sample = @"",
        };

        

        

        

        return dailyDeductible;
    } 
}
internal HL7V23Field livingDependency;

public HL7V23Field LivingDependency
{
    get
    {
        if (livingDependency != null)
        {
            return livingDependency;
        }

        livingDependency = new HL7V23Field
        {
            field = message[@"IN2"][31],
            Id = @"IN2.31",
            Type = @"Field",
            Position = @"IN2.31",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living dependency",
            Description = @"This field identifies the specific living conditions for the insured.  Refer to user-defined table 0223- Living dependency for suggested values",
            Sample = @"",
        };

        

        

        

        return livingDependency;
    } 
}
internal HL7V23Field ambulatoryStatus;

public HL7V23Field AmbulatoryStatus
{
    get
    {
        if (ambulatoryStatus != null)
        {
            return ambulatoryStatus;
        }

        ambulatoryStatus = new HL7V23Field
        {
            field = message[@"IN2"][32],
            Id = @"IN2.32",
            Type = @"Field",
            Position = @"IN2.32",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"This field identifies the insured’s state of mobility.  Refer to user-defined table 0009 - Ambulatory status for suggested values.",
            Sample = @"",
        };

        

        

        

        return ambulatoryStatus;
    } 
}
internal HL7V23Field citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (citizenship != null)
        {
            return citizenship;
        }

        citizenship = new HL7V23Field
        {
            field = message[@"IN2"][33],
            Id = @"IN2.33",
            Type = @"Field",
            Position = @"IN2.33",
            Name = @"Citizenship",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the code that identifies the insured’s citizenship.  HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship.",
            Sample = @"",
        };

        

        

        

        return citizenship;
    } 
}
internal HL7V23Field primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (primaryLanguage != null)
        {
            return primaryLanguage;
        }

        primaryLanguage = new HL7V23Field
        {
            field = message[@"IN2"][34],
            Id = @"IN2.34",
            Type = @"Field",
            Position = @"IN2.34",
            Name = @"Primary Language",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary language",
            Description = @"This field identifies the insured’s primary speaking language.  HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language.",
            Sample = @"",
        };

        

        

        

        return primaryLanguage;
    } 
}
internal HL7V23Field livingArrangement;

public HL7V23Field LivingArrangement
{
    get
    {
        if (livingArrangement != null)
        {
            return livingArrangement;
        }

        livingArrangement = new HL7V23Field
        {
            field = message[@"IN2"][35],
            Id = @"IN2.35",
            Type = @"Field",
            Position = @"IN2.35",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living arrangement",
            Description = @"This field indicates the situation in which the insured person lives at his primary residence.  Refer to user-defined table 0220 - Living arrangement for suggested values.",
            Sample = @"",
        };

        

        

        

        return livingArrangement;
    } 
}
internal HL7V23Field publicityIndicator;

public HL7V23Field PublicityIndicator
{
    get
    {
        if (publicityIndicator != null)
        {
            return publicityIndicator;
        }

        publicityIndicator = new HL7V23Field
        {
            field = message[@"IN2"][36],
            Id = @"IN2.36",
            Type = @"Field",
            Position = @"IN2.36",
            Name = @"Publicity Indicator",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the insured.  Refer to user-defined table 0215 - Publicity code for suggested values.",
            Sample = @"",
        };

        

        

        

        return publicityIndicator;
    } 
}
internal HL7V23Field protectionIndicator;

public HL7V23Field ProtectionIndicator
{
    get
    {
        if (protectionIndicator != null)
        {
            return protectionIndicator;
        }

        protectionIndicator = new HL7V23Field
        {
            field = message[@"IN2"][37],
            Id = @"IN2.37",
            Type = @"Field",
            Position = @"IN2.37",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the insured’s protection, which determines whether or not access to information about this enrollee should be restricted from users who do not have adequate authority.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y restrict access
N do not restrict access",
            Sample = @"",
        };

        

        

        

        return protectionIndicator;
    } 
}
internal HL7V23Field studentIndicator;

public HL7V23Field StudentIndicator
{
    get
    {
        if (studentIndicator != null)
        {
            return studentIndicator;
        }

        studentIndicator = new HL7V23Field
        {
            field = message[@"IN2"][38],
            Id = @"IN2.38",
            Type = @"Field",
            Position = @"IN2.38",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student status",
            Description = @"This field identifies whether the insured is currently a student or not, and whether the patient is a full-time or a part-time student.  This field does not indicate the degree level (high school, college) of student, or his/her field of study (accounting, engineering, etc.).  Refer to user-defined table 0231 - Student status for suggested values.",
            Sample = @"",
        };

        

        

        

        return studentIndicator;
    } 
}
internal HL7V23Field religion;

public HL7V23Field Religion
{
    get
    {
        if (religion != null)
        {
            return religion;
        }

        religion = new HL7V23Field
        {
            field = message[@"IN2"][39],
            Id = @"IN2.39",
            Type = @"Field",
            Position = @"IN2.39",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field indicates the type of religion practiced by the insured.  Refer to user-defined table 0006 - Religion for suggested values.",
            Sample = @"",
        };

        

        

        

        return religion;
    } 
}
internal HL7V23Field mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (mothersMaidenName != null)
        {
            return mothersMaidenName;
        }

        mothersMaidenName = new HL7V23Field
        {
            field = message[@"IN2"][40],
            Id = @"IN2.40",
            Type = @"Field",
            Position = @"IN2.40",
            Name = @"Mother s Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the insured’s mother’s maiden name.",
            Sample = @"",
        };

        

        

        

        return mothersMaidenName;
    } 
}
internal HL7V23Field nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (nationalityCode != null)
        {
            return nationalityCode;
        }

        nationalityCode = new HL7V23Field
        {
            field = message[@"IN2"][41],
            Id = @"IN2.41",
            Type = @"Field",
            Position = @"IN2.41",
            Name = @"Nationality Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field contains a code that identifies the nation or national grouping to which the insured person belongs.  This information may be different from a person’s citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.).  HL7 recommends using ISO table 3166 as he suggested values in user-defined table 0212 - Nationality.",
            Sample = @"",
        };

        

        

        

        return nationalityCode;
    } 
}
internal HL7V23Field ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (ethnicGroup != null)
        {
            return ethnicGroup;
        }

        ethnicGroup = new HL7V23Field
        {
            field = message[@"IN2"][42],
            Id = @"IN2.42",
            Type = @"Field",
            Position = @"IN2.42",
            Name = @"Ethnic Group",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field indicates the insured’s ethnic group.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0189 - Ethnic group for suggested values.",
            Sample = @"",
        };

        

        

        

        return ethnicGroup;
    } 
}
internal HL7V23Field maritalStatus;

public HL7V23Field MaritalStatus
{
    get
    {
        if (maritalStatus != null)
        {
            return maritalStatus;
        }

        maritalStatus = new HL7V23Field
        {
            field = message[@"IN2"][43],
            Id = @"IN2.43",
            Type = @"Field",
            Position = @"IN2.43",
            Name = @"Marital Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the insured’s marital status.  Refer to user-defined table 0002 - Marital status for suggested values.  Same values as those for PID-16-marital status.",
            Sample = @"",
        };

        

        

        

        return maritalStatus;
    } 
}
internal HL7V23Field employmentStartDate;

public HL7V23Field EmploymentStartDate
{
    get
    {
        if (employmentStartDate != null)
        {
            return employmentStartDate;
        }

        employmentStartDate = new HL7V23Field
        {
            field = message[@"IN2"][44],
            Id = @"IN2.44",
            Type = @"Field",
            Position = @"IN2.44",
            Name = @"Employment Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date on which the insured’s employment with a particular employer began.",
            Sample = @"",
        };

        

        

        

        return employmentStartDate;
    } 
}
internal HL7V23Field employmentStopDate;

public HL7V23Field EmploymentStopDate
{
    get
    {
        if (employmentStopDate != null)
        {
            return employmentStopDate;
        }

        employmentStopDate = new HL7V23Field
        {
            field = message[@"IN2"][45],
            Id = @"IN2.45",
            Type = @"Field",
            Position = @"IN2.45",
            Name = @"Employment Stop Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"his field indicates the date on which the person’s employment with a particular employer ended.",
            Sample = @"",
        };

        

        

        

        return employmentStopDate;
    } 
}
internal HL7V23Field jobTitle;

public HL7V23Field JobTitle
{
    get
    {
        if (jobTitle != null)
        {
            return jobTitle;
        }

        jobTitle = new HL7V23Field
        {
            field = message[@"IN2"][46],
            Id = @"IN2.46",
            Type = @"Field",
            Position = @"IN2.46",
            Name = @"Job Title",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a descriptive name for the insured’s occupation (for example, Sr. Systems Analyst, Sr. Accountant). ",
            Sample = @"",
        };

        

        

        

        return jobTitle;
    } 
}
internal HL7V23Field jobCodeClass;

public HL7V23Field JobCodeClass
{
    get
    {
        if (jobCodeClass != null)
        {
            return jobCodeClass;
        }

        jobCodeClass = new HL7V23Field
        {
            field = message[@"IN2"][47],
            Id = @"IN2.47",
            Type = @"Field",
            Position = @"IN2.47",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code Class",
            TableId = null,
            TableName = null,
            Description = @"This field indicates a code that identifies the insured’s job code ( for example, programmer, analyst, doctor, etc.).  Refer to user-defined tables 0327 - Job code and 0328 - Job class for suggested values. ",
            Sample = @"",
        };

        

        

        

        return jobCodeClass;
    } 
}
internal HL7V23Field jobStatus;

public HL7V23Field JobStatus
{
    get
    {
        if (jobStatus != null)
        {
            return jobStatus;
        }

        jobStatus = new HL7V23Field
        {
            field = message[@"IN2"][48],
            Id = @"IN2.48",
            Type = @"Field",
            Position = @"IN2.48",
            Name = @"Job Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0311",
            TableName = @"Job status",
            Description = @"This field indicates a code that identifies the insured’s current job status (for example, part- time/workers comp, full-time/leave of absence, full-time/suspended,   etc.).  Refer to user-defined table 0311 - Job status for suggested values.",
            Sample = @"",
        };

        

        

        

        return jobStatus;
    } 
}
internal HL7V23Field employerContactPersonName;

public HL7V23Field EmployerContactPersonName
{
    get
    {
        if (employerContactPersonName != null)
        {
            return employerContactPersonName;
        }

        employerContactPersonName = new HL7V23Field
        {
            field = message[@"IN2"][49],
            Id = @"IN2.49",
            Type = @"Field",
            Position = @"IN2.49",
            Name = @"Employer Contact Person Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the contact person that should be contacted at the insured’s place of employment.  (Joe Smith is the insured.  He works at GTE.  Contact Sue Jones at GTE regarding Joe Smith’s policy).  Multiple names for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return employerContactPersonName;
    } 
}
internal HL7V23Field employerContactPersonPhoneNumber;

public HL7V23Field EmployerContactPersonPhoneNumber
{
    get
    {
        if (employerContactPersonPhoneNumber != null)
        {
            return employerContactPersonPhoneNumber;
        }

        employerContactPersonPhoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][50],
            Id = @"IN2.50",
            Type = @"Field",
            Position = @"IN2.50",
            Name = @"Employer Contact Person Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for Sue Jones who is the contact person at GTE (Joe Smith’s place of employment).  Joe Smith is the insured.  Multiple phone numbers for the same contact person may be sent in this sequence, not multiple contacts.  The primary telephone number is assumed to be in the first repetition.  When no primary telephone number is sent, a repeat delimiter must be present for the first repetition. ",
            Sample = @"",
        };

        

        

        

        return employerContactPersonPhoneNumber;
    } 
}
internal HL7V23Field employerContactReason;

public HL7V23Field EmployerContactReason
{
    get
    {
        if (employerContactReason != null)
        {
            return employerContactReason;
        }

        employerContactReason = new HL7V23Field
        {
            field = message[@"IN2"][51],
            Id = @"IN2.51",
            Type = @"Field",
            Position = @"IN2.51",
            Name = @"Employer Contact Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field contains the reason(s) that Sue Jones should be contacted on behalf of Joe Smith, a GTE employer.  Refer to user-defined table 0222 - Contact reason for suggested values.",
            Sample = @"",
        };

        

        

        

        return employerContactReason;
    } 
}
internal HL7V23Field insured'sContactPersonName;

public HL7V23Field Insured'sContactPersonName
{
    get
    {
        if (insured'sContactPersonName != null)
        {
            return insured'sContactPersonName;
        }

        insured'sContactPersonName = new HL7V23Field
        {
            field = message[@"IN2"][52],
            Id = @"IN2.52",
            Type = @"Field",
            Position = @"IN2.52",
            Name = @"Insured's Contact Person Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the contact person for the insured",
            Sample = @"",
        };

        

        

        

        return insured'sContactPersonName;
    } 
}
internal HL7V23Field insuredsContactPersonTelephoneNumber;

public HL7V23Field InsuredsContactPersonTelephoneNumber
{
    get
    {
        if (insuredsContactPersonTelephoneNumber != null)
        {
            return insuredsContactPersonTelephoneNumber;
        }

        insuredsContactPersonTelephoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][53],
            Id = @"IN2.53",
            Type = @"Field",
            Position = @"IN2.53",
            Name = @"Insured s Contact Person Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for the contact person for the insured.  Multiple names for the same person may be sent in this contact, not multiple contacts.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insuredsContactPersonTelephoneNumber;
    } 
}
internal HL7V23Field insuredsContactPersonReason;

public HL7V23Field InsuredsContactPersonReason
{
    get
    {
        if (insuredsContactPersonReason != null)
        {
            return insuredsContactPersonReason;
        }

        insuredsContactPersonReason = new HL7V23Field
        {
            field = message[@"IN2"][54],
            Id = @"IN2.54",
            Type = @"Field",
            Position = @"IN2.54",
            Name = @"Insured s Contact Person Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field contains the reason(s) the person should be contacted regarding the insured.  Refer to user-defined table - 0222 - Contact reason for suggested values",
            Sample = @"",
        };

        

        

        

        return insuredsContactPersonReason;
    } 
}
internal HL7V23Field relationshipToThePatientStartDate;

public HL7V23Field RelationshipToThePatientStartDate
{
    get
    {
        if (relationshipToThePatientStartDate != null)
        {
            return relationshipToThePatientStartDate;
        }

        relationshipToThePatientStartDate = new HL7V23Field
        {
            field = message[@"IN2"][55],
            Id = @"IN2.55",
            Type = @"Field",
            Position = @"IN2.55",
            Name = @"Relationship To The Patient Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date on which the insured’s patient relationship (defined in IN1-17insured’s relationship to patient) became effective (began). ",
            Sample = @"",
        };

        

        

        

        return relationshipToThePatientStartDate;
    } 
}
internal HL7V23Field relationshipToThePatientStopDate;

public HL7V23Field RelationshipToThePatientStopDate
{
    get
    {
        if (relationshipToThePatientStopDate != null)
        {
            return relationshipToThePatientStopDate;
        }

        relationshipToThePatientStopDate = new HL7V23Field
        {
            field = message[@"IN2"][56],
            Id = @"IN2.56",
            Type = @"Field",
            Position = @"IN2.56",
            Name = @"Relationship To The Patient Stop Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date after which the relationship (defined in IN1-17-insured’s relationship to patient) is no longer effective",
            Sample = @"",
        };

        

        

        

        return relationshipToThePatientStopDate;
    } 
}
internal HL7V23Field insuranceCompanyContactReason;

public HL7V23Field InsuranceCompanyContactReason
{
    get
    {
        if (insuranceCompanyContactReason != null)
        {
            return insuranceCompanyContactReason;
        }

        insuranceCompanyContactReason = new HL7V23Field
        {
            field = message[@"IN2"][57],
            Id = @"IN2.57",
            Type = @"Field",
            Position = @"IN2.57",
            Name = @"Insurance Company Contact Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0232",
            TableName = @"Insurance company contact reason",
            Description = @"This field contains a user-defined code that specifies how the contact should be used.  Refer to user-defined table 0232 - Insurance company contact reason for suggested values.",
            Sample = @"",
        };

        

        

        

        return insuranceCompanyContactReason;
    } 
}
internal HL7V23Field insuranceCompanyContactPhoneNumber;

public HL7V23Field InsuranceCompanyContactPhoneNumber
{
    get
    {
        if (insuranceCompanyContactPhoneNumber != null)
        {
            return insuranceCompanyContactPhoneNumber;
        }

        insuranceCompanyContactPhoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][58],
            Id = @"IN2.58",
            Type = @"Field",
            Position = @"IN2.58",
            Name = @"Insurance Company Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the person who should be contacted at the insurance company for questions regarding an insurance policy/claim, etc.  Multiple phone numbers for the insurance company may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.  ",
            Sample = @"",
        };

        

        

        

        return insuranceCompanyContactPhoneNumber;
    } 
}
internal HL7V23Field policyScope;

public HL7V23Field PolicyScope
{
    get
    {
        if (policyScope != null)
        {
            return policyScope;
        }

        policyScope = new HL7V23Field
        {
            field = message[@"IN2"][59],
            Id = @"IN2.59",
            Type = @"Field",
            Position = @"IN2.59",
            Name = @"Policy Scope",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0312",
            TableName = @"Policy scope",
            Description = @"This field contains a user-defined code designating the extent of the coverage for a participating member (e.g., “single,” “family,” etc.  Refer to user-defined table 0312 - Policy scope for suggested values.",
            Sample = @"",
        };

        

        

        

        return policyScope;
    } 
}
internal HL7V23Field policySource;

public HL7V23Field PolicySource
{
    get
    {
        if (policySource != null)
        {
            return policySource;
        }

        policySource = new HL7V23Field
        {
            field = message[@"IN2"][60],
            Id = @"IN2.60",
            Type = @"Field",
            Position = @"IN2.60",
            Name = @"Policy Source",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0313",
            TableName = @"Policy source",
            Description = @"This user-defined field identifies how the policy information got established.  Refer to userdefined table 0313 - Policy source for suggested values.",
            Sample = @"",
        };

        

        

        

        return policySource;
    } 
}
internal HL7V23Field patientMemberNumber;

public HL7V23Field PatientMemberNumber
{
    get
    {
        if (patientMemberNumber != null)
        {
            return patientMemberNumber;
        }

        patientMemberNumber = new HL7V23Field
        {
            field = message[@"IN2"][61],
            Id = @"IN2.61",
            Type = @"Field",
            Position = @"IN2.61",
            Name = @"Patient Member Number",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifying number assigned by the payor for each individual covered by the insurance policy issued to the insured.  For example, each individual family member may have a different member number from the insurance policy number issued to the head of household.",
            Sample = @"",
        };

        

        

        

        return patientMemberNumber;
    } 
}
internal HL7V23Field guarantor'sRelationshipToInsured;

public HL7V23Field Guarantor'sRelationshipToInsured
{
    get
    {
        if (guarantor'sRelationshipToInsured != null)
        {
            return guarantor'sRelationshipToInsured;
        }

        guarantor'sRelationshipToInsured = new HL7V23Field
        {
            field = message[@"IN2"][62],
            Id = @"IN2.62",
            Type = @"Field",
            Position = @"IN2.62",
            Name = @"Guarantor's Relationship To Insured",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field specifies the relationship of the guarantor to the insurance subscriber.  Refer to userdefined table 0063-Relationship for suggested values",
            Sample = @"",
        };

        

        

        

        return guarantor'sRelationshipToInsured;
    } 
}
internal HL7V23Field insured'sTelephoneNumberHome;

public HL7V23Field Insured'sTelephoneNumberHome
{
    get
    {
        if (insured'sTelephoneNumberHome != null)
        {
            return insured'sTelephoneNumberHome;
        }

        insured'sTelephoneNumberHome = new HL7V23Field
        {
            field = message[@"IN2"][63],
            Id = @"IN2.63",
            Type = @"Field",
            Position = @"IN2.63",
            Name = @"Insured's Telephone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"The value of this field represents the insured’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition (PRN - Primary, PH - Telephone).  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. ",
            Sample = @"",
        };

        

        

        

        return insured'sTelephoneNumberHome;
    } 
}
internal HL7V23Field insured'sEmployerTelephoneNumber;

public HL7V23Field Insured'sEmployerTelephoneNumber
{
    get
    {
        if (insured'sEmployerTelephoneNumber != null)
        {
            return insured'sEmployerTelephoneNumber;
        }

        insured'sEmployerTelephoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][64],
            Id = @"IN2.64",
            Type = @"Field",
            Position = @"IN2.64",
            Name = @"Insured's Employer Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"The value of this field represents the insured’s employer’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
        };

        

        

        

        return insured'sEmployerTelephoneNumber;
    } 
}
internal HL7V23Field militaryHandicappedProgram;

public HL7V23Field MilitaryHandicappedProgram
{
    get
    {
        if (militaryHandicappedProgram != null)
        {
            return militaryHandicappedProgram;
        }

        militaryHandicappedProgram = new HL7V23Field
        {
            field = message[@"IN2"][65],
            Id = @"IN2.65",
            Type = @"Field",
            Position = @"IN2.65",
            Name = @"Military Handicapped Program",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the Champus program for the handicapped in which the patient is enrolled",
            Sample = @"",
        };

        

        

        

        return militaryHandicappedProgram;
    } 
}
internal HL7V23Field suspendFlag;

public HL7V23Field SuspendFlag
{
    get
    {
        if (suspendFlag != null)
        {
            return suspendFlag;
        }

        suspendFlag = new HL7V23Field
        {
            field = message[@"IN2"][66],
            Id = @"IN2.66",
            Type = @"Field",
            Position = @"IN2.66",
            Name = @"Suspend Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether charges should be suspended for a patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y charges should be suspended 
N charges should NOT be suspended ",
            Sample = @"",
        };

        

        

        

        return suspendFlag;
    } 
}
internal HL7V23Field copayLimitFlag;

public HL7V23Field CopayLimitFlag
{
    get
    {
        if (copayLimitFlag != null)
        {
            return copayLimitFlag;
        }

        copayLimitFlag = new HL7V23Field
        {
            field = message[@"IN2"][67],
            Id = @"IN2.67",
            Type = @"Field",
            Position = @"IN2.67",
            Name = @"Co-pay Limit Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the patient has reached the co-pay limit so that no more co-pay charges should be calculated for the patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the patient is at or exceeds the co-pay limit 
N the patient is under the co-pay limit ",
            Sample = @"",
        };

        

        

        

        return copayLimitFlag;
    } 
}
internal HL7V23Field stoplossLimitFlag;

public HL7V23Field StoplossLimitFlag
{
    get
    {
        if (stoplossLimitFlag != null)
        {
            return stoplossLimitFlag;
        }

        stoplossLimitFlag = new HL7V23Field
        {
            field = message[@"IN2"][68],
            Id = @"IN2.68",
            Type = @"Field",
            Position = @"IN2.68",
            Name = @"Stoploss Limit Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the patient has reached the stoploss limit established in the Contract Master.  Refer to HL7 table 0136 - Yes/no indicator for valid values

Y the patient has reached the stoploss limit 
N the patient has not reached the stoploss limi",
            Sample = @"",
        };

        

        

        

        return stoplossLimitFlag;
    } 
}
internal HL7V23Field insuredOrganizationNameAndID;

public HL7V23Field InsuredOrganizationNameAndID
{
    get
    {
        if (insuredOrganizationNameAndID != null)
        {
            return insuredOrganizationNameAndID;
        }

        insuredOrganizationNameAndID = new HL7V23Field
        {
            field = message[@"IN2"][69],
            Id = @"IN2.69",
            Type = @"Field",
            Position = @"IN2.69",
            Name = @"Insured Organization Name And ID",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the name of the insured if the insured/subscriber is an organization.  Multiple names for the insured may be sent in this sequence, not multiple insured people.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insuredOrganizationNameAndID;
    } 
}
internal HL7V23Field insuredEmployerOrganizationNameAndID;

public HL7V23Field InsuredEmployerOrganizationNameAndID
{
    get
    {
        if (insuredEmployerOrganizationNameAndID != null)
        {
            return insuredEmployerOrganizationNameAndID;
        }

        insuredEmployerOrganizationNameAndID = new HL7V23Field
        {
            field = message[@"IN2"][70],
            Id = @"IN2.70",
            Type = @"Field",
            Position = @"IN2.70",
            Name = @"Insured Employer Organization Name And ID",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the name of the insured’s employer, or the organization that purchased the insurance for the insured, if the employer is an organization.  Multiple names and identifiers for the same organization may be sent in this field, not multiple organizations.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
        };

        

        

        

        return insuredEmployerOrganizationNameAndID;
    } 
}
internal HL7V23Field race;

public HL7V23Field Race
{
    get
    {
        if (race != null)
        {
            return race;
        }

        race = new HL7V23Field
        {
            field = message[@"IN2"][71],
            Id = @"IN2.71",
            Type = @"Field",
            Position = @"IN2.71",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"RISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0005 - Race for suggested values.",
            Sample = @"",
        };

        

        

        

        return race;
    } 
}
internal HL7V23Field patientRelationshiptoInsured;

public HL7V23Field PatientRelationshiptoInsured
{
    get
    {
        if (patientRelationshiptoInsured != null)
        {
            return patientRelationshiptoInsured;
        }

        patientRelationshiptoInsured = new HL7V23Field
        {
            field = message[@"IN2"][72],
            Id = @"IN2.72",
            Type = @"Field",
            Position = @"IN2.72",
            Name = @"Patient Relationship to Insured",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the relationship of the patient to the insured, as defined by HCFA or other regulatory agencies.",
            Sample = @"",
        };

        

        

        

        return patientRelationshiptoInsured;
    } 
}

    }
}

using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentSTF
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"STF"; } }

        public string SegmentId { get { return @"STF"; } }
        
        public string LongName { get { return @"Staff Identification"; } }
        
        public string Description { get { return @"The STF segment can identify any personnel referenced by information systems.  These can be providers, staff, system users, and referring agents.  In a network environment, this segment can be used to define personnel to other applications; for example, order entry clerks, insurance verification clerks, admission clerks, as well as provider demographics. When using the STF and PRA segments in the Staff/Practitioner Master File message, MFE-4-primary key value is used to link all the segments pertaining to the same master file entry.  Therefore, in the MFE segment, MFE-4-primary key value must be filled in.  Other segments may follow the STF segment to provide data for a particular type of staff member. The PRA segment (practitioner) is one such.  It may optionally follow the STF segment in order to add practitionerspecific data. Other segments may be defined as needed. When using the segments included in this chapter for other then Staff/Practitioner Master File messages, disregard references to MFE-4 - primary key value.

The Technical Steward for the STF segment is PAFM and Personnel Management."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Id = @"STF.1",
                            Type = @"Field",
                            Position = @"STF.1",
                            Name = @"Primary Key Value - STF",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"For MFN Master File Notification, this field is required and must match MFE-4-primary key value to identify which entry is being referenced.  For all other messages, this field should not be used",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.1.1",
                            Type = @"Component",
                            Position = @"STF.1.1",
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
                            Id = @"STF.1.2",
                            Type = @"Component",
                            Position = @"STF.1.2",
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
                            Id = @"STF.1.3",
                            Type = @"Component",
                            Position = @"STF.1.3",
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
                            Id = @"STF.1.4",
                            Type = @"Component",
                            Position = @"STF.1.4",
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
                            Id = @"STF.1.5",
                            Type = @"Component",
                            Position = @"STF.1.5",
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
                            Id = @"STF.1.6",
                            Type = @"Component",
                            Position = @"STF.1.6",
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
                            Id = @"STF.2",
                            Type = @"Field",
                            Position = @"STF.2",
                            Name = @"Staff ID Code",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a personnel identification code or institution user number, used by the institution to identify this person.  Repeating field allows multiple ID codes per person, with the type of ID code indicated in the third component of the coded entry data type.   If a Staff Member has Staff ID codes that are valid only in specific organization units, that Staff ID code should be recorded in the ORGPractitioner Organization Unit segment",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.2.1",
                            Type = @"Component",
                            Position = @"STF.2.1",
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
                            Id = @"STF.2.2",
                            Type = @"Component",
                            Position = @"STF.2.2",
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
                            Id = @"STF.2.3",
                            Type = @"Component",
                            Position = @"STF.2.3",
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
                            Id = @"STF.2.4",
                            Type = @"Component",
                            Position = @"STF.2.4",
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
                            Id = @"STF.2.4.1",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.1",
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
                            Id = @"STF.2.4.2",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.2",
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
                            Id = @"STF.2.4.3",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.3",
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
                            Id = @"STF.2.5",
                            Type = @"Component",
                            Position = @"STF.2.5",
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
                            Id = @"STF.2.6",
                            Type = @"Component",
                            Position = @"STF.2.6",
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
                            Id = @"STF.2.6.1",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.1",
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
                            Id = @"STF.2.6.2",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.2",
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
                            Id = @"STF.2.6.3",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.3",
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
                            Id = @"STF.2.7",
                            Type = @"Component",
                            Position = @"STF.2.7",
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
                            Id = @"STF.2.8",
                            Type = @"Component",
                            Position = @"STF.2.8",
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
                            Id = @"STF.3",
                            Type = @"Field",
                            Position = @"STF.3",
                            Name = @"Staff Name",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XPN",
                            DataTypeName = @"Extended Person Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the staff person’s name.  This field may repeat to transmit multiple names for the same person",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.3.1",
                            Type = @"Component",
                            Position = @"STF.3.1",
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
                            Id = @"STF.3.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.1",
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
                            Id = @"STF.3.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.2",
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
                            Id = @"STF.3.1.3",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.3",
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
                            Id = @"STF.3.1.4",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.4",
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
                            Id = @"STF.3.1.5",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.5",
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
                            Id = @"STF.3.2",
                            Type = @"Component",
                            Position = @"STF.3.2",
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
                            Id = @"STF.3.3",
                            Type = @"Component",
                            Position = @"STF.3.3",
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
                            Id = @"STF.3.4",
                            Type = @"Component",
                            Position = @"STF.3.4",
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
                            Id = @"STF.3.5",
                            Type = @"Component",
                            Position = @"STF.3.5",
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
                            Id = @"STF.3.6",
                            Type = @"Component",
                            Position = @"STF.3.6",
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
                            Id = @"STF.3.7",
                            Type = @"Component",
                            Position = @"STF.3.7",
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
                            Id = @"STF.3.8",
                            Type = @"Component",
                            Position = @"STF.3.8",
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
                            Id = @"STF.3.9",
                            Type = @"Component",
                            Position = @"STF.3.9",
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
                            Id = @"STF.3.9.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.1",
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
                            Id = @"STF.3.9.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.2",
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
                            Id = @"STF.3.9.3",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.3",
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
                            Id = @"STF.3.9.4",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.4",
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
                            Id = @"STF.3.9.5",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.5",
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
                            Id = @"STF.3.9.6",
                            Type = @"SubComponent",
                            Position = @"STF.3.9.6",
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
                            Id = @"STF.3.10",
                            Type = @"Component",
                            Position = @"STF.3.10",
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
                            Id = @"STF.3.10.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.1",
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
                            Id = @"STF.3.10.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.1",
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
                            Id = @"STF.3.10.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.2",
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
                            Id = @"STF.3.10.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.2",
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
                            Id = @"STF.3.10.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.1",
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
                            Id = @"STF.3.10.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.10.2",
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
                            Id = @"STF.3.11",
                            Type = @"Component",
                            Position = @"STF.3.11",
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
                            Id = @"STF.4",
                            Type = @"Field",
                            Position = @"STF.4",
                            Name = @"Staff Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0182",
                            TableName = @"Staff type",
                            Description = @"This field contains a code identifying what type of staff. Refer to User-defined Table 0182 Staff type for suggested values.  Values may include codes for staff, practitioner (physician, nurse, therapist, etc.), referral agent or agency, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.5",
                            Type = @"Field",
                            Position = @"STF.5",
                            Name = @"Administrative Sex",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0001",
                            TableName = @"Administrative sex",
                            Description = @"This field contains the staff person’s sex.  Refer to User-defined Table 0001 – Administrative Sex for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.6",
                            Type = @"Field",
                            Position = @"STF.6",
                            Name = @"Date/Time Of Birth",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a staff member’s date and time of birth",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.6.1",
                            Type = @"Component",
                            Position = @"STF.6.1",
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
                            Id = @"STF.6.2",
                            Type = @"Component",
                            Position = @"STF.6.2",
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
                            Id = @"STF.7",
                            Type = @"Field",
                            Position = @"STF.7",
                            Name = @"Active/Inactive Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0183",
                            TableName = @"Active/inactive",
                            Description = @"This field indicates whether person is currently a valid staff member.  Refer to HL7 Table 0183 - Active/inactive for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.8",
                            Type = @"Field",
                            Position = @"STF.8",
                            Name = @"Department",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0184",
                            TableName = @"Department",
                            Description = @"This field contains the institution department to which this person reports or belongs.  Refer to User-defined Table 0184 - Department for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.8.1",
                            Type = @"Component",
                            Position = @"STF.8.1",
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
                            Id = @"STF.8.2",
                            Type = @"Component",
                            Position = @"STF.8.2",
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
                            Id = @"STF.8.3",
                            Type = @"Component",
                            Position = @"STF.8.3",
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
                            Id = @"STF.8.4",
                            Type = @"Component",
                            Position = @"STF.8.4",
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
                            Id = @"STF.8.5",
                            Type = @"Component",
                            Position = @"STF.8.5",
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
                            Id = @"STF.8.6",
                            Type = @"Component",
                            Position = @"STF.8.6",
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
                            Id = @"STF.9",
                            Type = @"Field",
                            Position = @"STF.9",
                            Name = @"Hospital Service",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0069",
                            TableName = @"Hospital service",
                            Description = @"This field contains the hospital or ancillary service with which this staff person is associated. Refer to User-defined Table 0069 - Hospital service for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.9.1",
                            Type = @"Component",
                            Position = @"STF.9.1",
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
                            Id = @"STF.9.2",
                            Type = @"Component",
                            Position = @"STF.9.2",
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
                            Id = @"STF.9.3",
                            Type = @"Component",
                            Position = @"STF.9.3",
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
                            Id = @"STF.9.4",
                            Type = @"Component",
                            Position = @"STF.9.4",
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
                            Id = @"STF.9.5",
                            Type = @"Component",
                            Position = @"STF.9.5",
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
                            Id = @"STF.9.6",
                            Type = @"Component",
                            Position = @"STF.9.6",
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
                            Id = @"STF.10",
                            Type = @"Field",
                            Position = @"STF.10",
                            Name = @"Phone",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the staff person’s phone number.  This is a repeating field with a component for indicating which phone number is which. It is recommended that the last part of the XTN, [C any text], start with a code from the table associated below with STF-16-preferred method of contact, in order to indicate the type of each phone number in this repeating field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.10.1",
                            Type = @"Component",
                            Position = @"STF.10.1",
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
                            Id = @"STF.10.2",
                            Type = @"Component",
                            Position = @"STF.10.2",
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
                            Id = @"STF.10.3",
                            Type = @"Component",
                            Position = @"STF.10.3",
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
                            Id = @"STF.10.4",
                            Type = @"Component",
                            Position = @"STF.10.4",
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
                            Id = @"STF.10.5",
                            Type = @"Component",
                            Position = @"STF.10.5",
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
                            Id = @"STF.10.6",
                            Type = @"Component",
                            Position = @"STF.10.6",
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
                            Id = @"STF.10.7",
                            Type = @"Component",
                            Position = @"STF.10.7",
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
                            Id = @"STF.10.8",
                            Type = @"Component",
                            Position = @"STF.10.8",
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
                            Id = @"STF.10.9",
                            Type = @"Component",
                            Position = @"STF.10.9",
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
                            Id = @"STF.11",
                            Type = @"Field",
                            Position = @"STF.11",
                            Name = @"Office/Home Address",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the office address and home address of the staff person.  This is a repeating field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.11.1",
                            Type = @"Component",
                            Position = @"STF.11.1",
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
                            Id = @"STF.11.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.11.1.1",
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
                            Id = @"STF.11.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.11.1.2",
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
                            Id = @"STF.11.1.3",
                            Type = @"SubComponent",
                            Position = @"STF.11.1.3",
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
                            Id = @"STF.11.2",
                            Type = @"Component",
                            Position = @"STF.11.2",
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
                            Id = @"STF.11.3",
                            Type = @"Component",
                            Position = @"STF.11.3",
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
                            Id = @"STF.11.4",
                            Type = @"Component",
                            Position = @"STF.11.4",
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
                            Id = @"STF.11.5",
                            Type = @"Component",
                            Position = @"STF.11.5",
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
                            Id = @"STF.11.6",
                            Type = @"Component",
                            Position = @"STF.11.6",
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
                            Id = @"STF.11.7",
                            Type = @"Component",
                            Position = @"STF.11.7",
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
                            Id = @"STF.11.8",
                            Type = @"Component",
                            Position = @"STF.11.8",
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
                            Id = @"STF.11.9",
                            Type = @"Component",
                            Position = @"STF.11.9",
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
                            Id = @"STF.11.10",
                            Type = @"Component",
                            Position = @"STF.11.10",
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
                            Id = @"STF.11.11",
                            Type = @"Component",
                            Position = @"STF.11.11",
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
                            Id = @"STF.11.12",
                            Type = @"Component",
                            Position = @"STF.11.12",
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
                            Id = @"STF.11.12.1",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.1",
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
                            Id = @"STF.11.12.1",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.1",
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
                            Id = @"STF.11.12.2",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.2",
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
                            Id = @"STF.11.12.2",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.2",
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
                            Id = @"STF.11.12.1",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.1",
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
                            Id = @"STF.11.12.2",
                            Type = @"SubComponent",
                            Position = @"STF.11.12.2",
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
                            Id = @"STF.12",
                            Type = @"Field",
                            Position = @"STF.12",
                            Name = @"Institution Activation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DIN",
                            DataTypeName = @"Activation Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date when staff became active for an institution.  This is a repeating field",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.12.1",
                            Type = @"Component",
                            Position = @"STF.12.1",
                            Name = @"Date",
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
                            Id = @"STF.12.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.1.1",
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
                            Id = @"STF.12.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.12.1.2",
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
                            Id = @"STF.12.2",
                            Type = @"Component",
                            Position = @"STF.12.2",
                            Name = @"Institution Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.12.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.1",
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
                            Id = @"STF.12.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.2",
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
                            Id = @"STF.12.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.3",
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
                            Id = @"STF.12.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.4",
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
                            Id = @"STF.12.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.5",
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
                            Id = @"STF.12.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.13",
                            Type = @"Field",
                            Position = @"STF.13",
                            Name = @"Institution Inactivation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DIN",
                            DataTypeName = @"Activation Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date when staff became inactive for an institution.  This is a repeating field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.13.1",
                            Type = @"Component",
                            Position = @"STF.13.1",
                            Name = @"Date",
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
                            Id = @"STF.13.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.1.1",
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
                            Id = @"STF.13.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.13.1.2",
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
                            Id = @"STF.13.2",
                            Type = @"Component",
                            Position = @"STF.13.2",
                            Name = @"Institution Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.13.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.1",
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
                            Id = @"STF.13.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.2",
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
                            Id = @"STF.13.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.3",
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
                            Id = @"STF.13.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.4",
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
                            Id = @"STF.13.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.5",
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
                            Id = @"STF.13.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.14",
                            Type = @"Field",
                            Position = @"STF.14",
                            Name = @"Backup Person ID",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the MFE-4-primary key value of the master file entry that corresponds to the designated backup person for this staff person",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.14.1",
                            Type = @"Component",
                            Position = @"STF.14.1",
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
                            Id = @"STF.14.2",
                            Type = @"Component",
                            Position = @"STF.14.2",
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
                            Id = @"STF.14.3",
                            Type = @"Component",
                            Position = @"STF.14.3",
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
                            Id = @"STF.14.4",
                            Type = @"Component",
                            Position = @"STF.14.4",
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
                            Id = @"STF.14.5",
                            Type = @"Component",
                            Position = @"STF.14.5",
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
                            Id = @"STF.14.6",
                            Type = @"Component",
                            Position = @"STF.14.6",
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
                            Id = @"STF.15",
                            Type = @"Field",
                            Position = @"STF.15",
                            Name = @"E-Mail Address",
                            Length = 40,
                            Usage = @"B",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field has been retained for backward compatibility.  (It is now present in the fourth component of STF-10-phone",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.16",
                            Type = @"Field",
                            Position = @"STF.16",
                            Name = @"Preferred Method of Contact",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0185",
                            TableName = @"Preferred method of contact",
                            Description = @"This field indicates which of a group of multiple phone numbers is the preferred method of contact for this person.  Note that all values of this code refer to this segment’s phone field, except for the value “E,” which refers to the E-mail address field.  If more than one phone number of the preferred type exists in STF-10-phone, this field refers to the first such instance.  Refer to HL7 Table 0185 - Preferred method of contact for valid values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.16.1",
                            Type = @"Component",
                            Position = @"STF.16.1",
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
                            Id = @"STF.16.2",
                            Type = @"Component",
                            Position = @"STF.16.2",
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
                            Id = @"STF.16.3",
                            Type = @"Component",
                            Position = @"STF.16.3",
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
                            Id = @"STF.16.4",
                            Type = @"Component",
                            Position = @"STF.16.4",
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
                            Id = @"STF.16.5",
                            Type = @"Component",
                            Position = @"STF.16.5",
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
                            Id = @"STF.16.6",
                            Type = @"Component",
                            Position = @"STF.16.6",
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
                            Id = @"STF.17",
                            Type = @"Field",
                            Position = @"STF.17",
                            Name = @"Marital Status",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0002",
                            TableName = @"Marital status",
                            Description = @"This field contains the staff member’s marital status.  Refer to User-defined Table 0002 Marital status for suggested values.  Same values as those for PID-16-marital status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.17.1",
                            Type = @"Component",
                            Position = @"STF.17.1",
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
                            Id = @"STF.17.2",
                            Type = @"Component",
                            Position = @"STF.17.2",
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
                            Id = @"STF.17.3",
                            Type = @"Component",
                            Position = @"STF.17.3",
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
                            Id = @"STF.17.4",
                            Type = @"Component",
                            Position = @"STF.17.4",
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
                            Id = @"STF.17.5",
                            Type = @"Component",
                            Position = @"STF.17.5",
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
                            Id = @"STF.17.6",
                            Type = @"Component",
                            Position = @"STF.17.6",
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
                            Id = @"STF.18",
                            Type = @"Field",
                            Position = @"STF.18",
                            Name = @"Job Title",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a descriptive name of the staff member’s occupation (e.g., Sr. Systems Analyst, Sr. Accountant).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.19",
                            Type = @"Field",
                            Position = @"STF.19",
                            Name = @"Job Code/Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"JCC",
                            DataTypeName = @"Job Code/class",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the staff member’s job code and employee classification.  Refer to Userdefined Table 0327 - Job code and User-defined Table 0328 - Employee classification for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.19.1",
                            Type = @"Component",
                            Position = @"STF.19.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code",
                            Description = @"This component contains the persons job code. User-defined Table 0327 - Job code is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.19.2",
                            Type = @"Component",
                            Position = @"STF.19.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the persons employee classification . User-defined Table 0328 - Employee classificationis used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.20",
                            Type = @"Field",
                            Position = @"STF.20",
                            Name = @"Employment Status Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0066",
                            TableName = @"Employment status",
                            Description = @"This field contains the code that indicates the staff member’s employment status, e.g., fulltime, part-time, self-employed, etc. Refer to User-defined Table 0066 - Employment status for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.20.1",
                            Type = @"Component",
                            Position = @"STF.20.1",
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
                            Id = @"STF.20.2",
                            Type = @"Component",
                            Position = @"STF.20.2",
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
                            Id = @"STF.20.3",
                            Type = @"Component",
                            Position = @"STF.20.3",
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
                            Id = @"STF.20.4",
                            Type = @"Component",
                            Position = @"STF.20.4",
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
                            Id = @"STF.20.5",
                            Type = @"Component",
                            Position = @"STF.20.5",
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
                            Id = @"STF.20.6",
                            Type = @"Component",
                            Position = @"STF.20.6",
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
                            Id = @"STF.21",
                            Type = @"Field",
                            Position = @"STF.21",
                            Name = @"Additional Insured on  Auto",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether the present institution is named as an additional insured on the staff member’s auto insurance, especially for use when staff is a driver for the institution.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y indicates that the institution is named as an additional insured
- N indicates that the institution is not named as an additional insured",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.22",
                            Type = @"Field",
                            Position = @"STF.22",
                            Name = @"Driver's License Number - Staff",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DLN",
                            DataTypeName = @"Driver's License Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the driver’s license information of staff, especially for use when staff is a driver for the institution.  For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.22.1",
                            Type = @"Component",
                            Position = @"STF.22.1",
                            Name = @"Drivers License Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the drivers license number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.22.2",
                            Type = @"Component",
                            Position = @"STF.22.2",
                            Name = @"Issuing State, Province, Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0333",
                            TableName = @"Driver’s license issuing authority",
                            Description = @"Issuing authority for drivers license. For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes. (The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code .) User-defined Table 0333 - Drivers license issuing authority is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.22.3",
                            Type = @"Component",
                            Position = @"STF.22.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Expiration date (DT) for drivers license.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.23",
                            Type = @"Field",
                            Position = @"STF.23",
                            Name = @"Copy  Auto Ins",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether the institution has on file a copy of the staff member’s auto insurance, especially for use when staff is a driver for the institution.   Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y indicates that the institution has a copy on file
- N indicates that the institution does not have a copy on file",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.24",
                            Type = @"Field",
                            Position = @"STF.24",
                            Name = @"Auto Ins. Expires",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date on which the staff member’s driver’s license expires, especially for use when staff is a driver for the institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.25",
                            Type = @"Field",
                            Position = @"STF.25",
                            Name = @"Date Last DMV Review",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date of the staff member’s most recent Department of Motor Vehicles review, especially for use when staff is a driver for the institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.26",
                            Type = @"Field",
                            Position = @"STF.26",
                            Name = @"Date Next DMV Review",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date of the staff member’s next Department of Motor Vehicles review, especially for use when staff is a driver for the institution",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.27",
                            Type = @"Field",
                            Position = @"STF.27",
                            Name = @"Race",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0005",
                            TableName = @"Race",
                            Description = @"This field refers to the person's race.  Refer to User-defined Table 0005 - Race for suggested values.  The second triplet of the CE data type for race (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.27.1",
                            Type = @"Component",
                            Position = @"STF.27.1",
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
                            Id = @"STF.27.2",
                            Type = @"Component",
                            Position = @"STF.27.2",
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
                            Id = @"STF.27.3",
                            Type = @"Component",
                            Position = @"STF.27.3",
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
                            Id = @"STF.27.4",
                            Type = @"Component",
                            Position = @"STF.27.4",
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
                            Id = @"STF.27.5",
                            Type = @"Component",
                            Position = @"STF.27.5",
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
                            Id = @"STF.27.6",
                            Type = @"Component",
                            Position = @"STF.27.6",
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
                            Id = @"STF.28",
                            Type = @"Field",
                            Position = @"STF.28",
                            Name = @"Ethnic Group",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0189",
                            TableName = @"Ethnic group",
                            Description = @"This field further defines the person’s ancestry.  Refer to User-defined Table 0189 - Ethnic group for suggested values. The second couplet of the CE data type for ethnic group (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes. In the United States, a current use is to report ethnicity in line with US federal standards for Hispanic origin",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"STF.28.1",
                            Type = @"Component",
                            Position = @"STF.28.1",
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
                            Id = @"STF.28.2",
                            Type = @"Component",
                            Position = @"STF.28.2",
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
                            Id = @"STF.28.3",
                            Type = @"Component",
                            Position = @"STF.28.3",
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
                            Id = @"STF.28.4",
                            Type = @"Component",
                            Position = @"STF.28.4",
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
                            Id = @"STF.28.5",
                            Type = @"Component",
                            Position = @"STF.28.5",
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
                            Id = @"STF.28.6",
                            Type = @"Component",
                            Position = @"STF.28.6",
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
                            Id = @"STF.29",
                            Type = @"Field",
                            Position = @"STF.29",
                            Name = @"Re-activation Approval Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether the re-activation of this record requires special approval.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y the re-activation requires approval
- N this re-activation does not require approval",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentSTF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field primaryKeyValueSTF;

public HL7V24Field PrimaryKeyValueSTF
{
    get
    {
        if (primaryKeyValueSTF != null)
        {
            return primaryKeyValueSTF;
        }

        primaryKeyValueSTF = new HL7V24Field
        {
            field = message[@"STF"][1],
            Id = @"STF.1",
            Type = @"Field",
            Position = @"STF.1",
            Name = @"Primary Key Value - STF",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"For MFN Master File Notification, this field is required and must match MFE-4-primary key value to identify which entry is being referenced.  For all other messages, this field should not be used",
            Sample = @"",
        };

        

        

        

        return primaryKeyValueSTF;
    } 
}
internal HL7V24Field staffIDCode;

public HL7V24Field StaffIDCode
{
    get
    {
        if (staffIDCode != null)
        {
            return staffIDCode;
        }

        staffIDCode = new HL7V24Field
        {
            field = message[@"STF"][2],
            Id = @"STF.2",
            Type = @"Field",
            Position = @"STF.2",
            Name = @"Staff ID Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains a personnel identification code or institution user number, used by the institution to identify this person.  Repeating field allows multiple ID codes per person, with the type of ID code indicated in the third component of the coded entry data type.   If a Staff Member has Staff ID codes that are valid only in specific organization units, that Staff ID code should be recorded in the ORGPractitioner Organization Unit segment",
            Sample = @"",
        };

        

        

        

        return staffIDCode;
    } 
}
internal HL7V24Field staffName;

public HL7V24Field StaffName
{
    get
    {
        if (staffName != null)
        {
            return staffName;
        }

        staffName = new HL7V24Field
        {
            field = message[@"STF"][3],
            Id = @"STF.3",
            Type = @"Field",
            Position = @"STF.3",
            Name = @"Staff Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff person’s name.  This field may repeat to transmit multiple names for the same person",
            Sample = @"",
        };

        

        

        

        return staffName;
    } 
}
internal HL7V24Field staffType;

public HL7V24Field StaffType
{
    get
    {
        if (staffType != null)
        {
            return staffType;
        }

        staffType = new HL7V24Field
        {
            field = message[@"STF"][4],
            Id = @"STF.4",
            Type = @"Field",
            Position = @"STF.4",
            Name = @"Staff Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0182",
            TableName = @"Staff type",
            Description = @"This field contains a code identifying what type of staff. Refer to User-defined Table 0182 Staff type for suggested values.  Values may include codes for staff, practitioner (physician, nurse, therapist, etc.), referral agent or agency, etc",
            Sample = @"",
        };

        

        

        

        return staffType;
    } 
}
internal HL7V24Field administrativeSex;

public HL7V24Field AdministrativeSex
{
    get
    {
        if (administrativeSex != null)
        {
            return administrativeSex;
        }

        administrativeSex = new HL7V24Field
        {
            field = message[@"STF"][5],
            Id = @"STF.5",
            Type = @"Field",
            Position = @"STF.5",
            Name = @"Administrative Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Administrative sex",
            Description = @"This field contains the staff person’s sex.  Refer to User-defined Table 0001 – Administrative Sex for suggested values",
            Sample = @"",
        };

        

        

        

        return administrativeSex;
    } 
}
internal HL7V24Field dateTimeOfBirth;

public HL7V24Field DateTimeOfBirth
{
    get
    {
        if (dateTimeOfBirth != null)
        {
            return dateTimeOfBirth;
        }

        dateTimeOfBirth = new HL7V24Field
        {
            field = message[@"STF"][6],
            Id = @"STF.6",
            Type = @"Field",
            Position = @"STF.6",
            Name = @"Date/Time Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains a staff member’s date and time of birth",
            Sample = @"",
        };

        

        

        

        return dateTimeOfBirth;
    } 
}
internal HL7V24Field activeInactiveFlag;

public HL7V24Field ActiveInactiveFlag
{
    get
    {
        if (activeInactiveFlag != null)
        {
            return activeInactiveFlag;
        }

        activeInactiveFlag = new HL7V24Field
        {
            field = message[@"STF"][7],
            Id = @"STF.7",
            Type = @"Field",
            Position = @"STF.7",
            Name = @"Active/Inactive Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0183",
            TableName = @"Active/inactive",
            Description = @"This field indicates whether person is currently a valid staff member.  Refer to HL7 Table 0183 - Active/inactive for valid values",
            Sample = @"",
        };

        

        

        

        return activeInactiveFlag;
    } 
}
internal HL7V24Field department;

public HL7V24Field Department
{
    get
    {
        if (department != null)
        {
            return department;
        }

        department = new HL7V24Field
        {
            field = message[@"STF"][8],
            Id = @"STF.8",
            Type = @"Field",
            Position = @"STF.8",
            Name = @"Department",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0184",
            TableName = @"Department",
            Description = @"This field contains the institution department to which this person reports or belongs.  Refer to User-defined Table 0184 - Department for suggested values",
            Sample = @"",
        };

        

        

        

        return department;
    } 
}
internal HL7V24Field hospitalService;

public HL7V24Field HospitalService
{
    get
    {
        if (hospitalService != null)
        {
            return hospitalService;
        }

        hospitalService = new HL7V24Field
        {
            field = message[@"STF"][9],
            Id = @"STF.9",
            Type = @"Field",
            Position = @"STF.9",
            Name = @"Hospital Service",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0069",
            TableName = @"Hospital service",
            Description = @"This field contains the hospital or ancillary service with which this staff person is associated. Refer to User-defined Table 0069 - Hospital service for suggested values",
            Sample = @"",
        };

        

        

        

        return hospitalService;
    } 
}
internal HL7V24Field phone;

public HL7V24Field Phone
{
    get
    {
        if (phone != null)
        {
            return phone;
        }

        phone = new HL7V24Field
        {
            field = message[@"STF"][10],
            Id = @"STF.10",
            Type = @"Field",
            Position = @"STF.10",
            Name = @"Phone",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff person’s phone number.  This is a repeating field with a component for indicating which phone number is which. It is recommended that the last part of the XTN, [C any text], start with a code from the table associated below with STF-16-preferred method of contact, in order to indicate the type of each phone number in this repeating field",
            Sample = @"",
        };

        

        

        

        return phone;
    } 
}
internal HL7V24Field officeHomeAddress;

public HL7V24Field OfficeHomeAddress
{
    get
    {
        if (officeHomeAddress != null)
        {
            return officeHomeAddress;
        }

        officeHomeAddress = new HL7V24Field
        {
            field = message[@"STF"][11],
            Id = @"STF.11",
            Type = @"Field",
            Position = @"STF.11",
            Name = @"Office/Home Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the office address and home address of the staff person.  This is a repeating field",
            Sample = @"",
        };

        

        

        

        return officeHomeAddress;
    } 
}
internal HL7V24Field institutionActivationDate;

public HL7V24Field InstitutionActivationDate
{
    get
    {
        if (institutionActivationDate != null)
        {
            return institutionActivationDate;
        }

        institutionActivationDate = new HL7V24Field
        {
            field = message[@"STF"][12],
            Id = @"STF.12",
            Type = @"Field",
            Position = @"STF.12",
            Name = @"Institution Activation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date when staff became active for an institution.  This is a repeating field",
            Sample = @"",
        };

        

        

        

        return institutionActivationDate;
    } 
}
internal HL7V24Field institutionInactivationDate;

public HL7V24Field InstitutionInactivationDate
{
    get
    {
        if (institutionInactivationDate != null)
        {
            return institutionInactivationDate;
        }

        institutionInactivationDate = new HL7V24Field
        {
            field = message[@"STF"][13],
            Id = @"STF.13",
            Type = @"Field",
            Position = @"STF.13",
            Name = @"Institution Inactivation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date when staff became inactive for an institution.  This is a repeating field.",
            Sample = @"",
        };

        

        

        

        return institutionInactivationDate;
    } 
}
internal HL7V24Field backupPersonID;

public HL7V24Field BackupPersonID
{
    get
    {
        if (backupPersonID != null)
        {
            return backupPersonID;
        }

        backupPersonID = new HL7V24Field
        {
            field = message[@"STF"][14],
            Id = @"STF.14",
            Type = @"Field",
            Position = @"STF.14",
            Name = @"Backup Person ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the MFE-4-primary key value of the master file entry that corresponds to the designated backup person for this staff person",
            Sample = @"",
        };

        

        

        

        return backupPersonID;
    } 
}
internal HL7V24Field eMailAddress;

public HL7V24Field EMailAddress
{
    get
    {
        if (eMailAddress != null)
        {
            return eMailAddress;
        }

        eMailAddress = new HL7V24Field
        {
            field = message[@"STF"][15],
            Id = @"STF.15",
            Type = @"Field",
            Position = @"STF.15",
            Name = @"E-Mail Address",
            Length = 40,
            Usage = @"B",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility.  (It is now present in the fourth component of STF-10-phone",
            Sample = @"",
        };

        

        

        

        return eMailAddress;
    } 
}
internal HL7V24Field preferredMethodofContact;

public HL7V24Field PreferredMethodofContact
{
    get
    {
        if (preferredMethodofContact != null)
        {
            return preferredMethodofContact;
        }

        preferredMethodofContact = new HL7V24Field
        {
            field = message[@"STF"][16],
            Id = @"STF.16",
            Type = @"Field",
            Position = @"STF.16",
            Name = @"Preferred Method of Contact",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0185",
            TableName = @"Preferred method of contact",
            Description = @"This field indicates which of a group of multiple phone numbers is the preferred method of contact for this person.  Note that all values of this code refer to this segment’s phone field, except for the value “E,” which refers to the E-mail address field.  If more than one phone number of the preferred type exists in STF-10-phone, this field refers to the first such instance.  Refer to HL7 Table 0185 - Preferred method of contact for valid values",
            Sample = @"",
        };

        

        

        

        return preferredMethodofContact;
    } 
}
internal HL7V24Field maritalStatus;

public HL7V24Field MaritalStatus
{
    get
    {
        if (maritalStatus != null)
        {
            return maritalStatus;
        }

        maritalStatus = new HL7V24Field
        {
            field = message[@"STF"][17],
            Id = @"STF.17",
            Type = @"Field",
            Position = @"STF.17",
            Name = @"Marital Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the staff member’s marital status.  Refer to User-defined Table 0002 Marital status for suggested values.  Same values as those for PID-16-marital status",
            Sample = @"",
        };

        

        

        

        return maritalStatus;
    } 
}
internal HL7V24Field jobTitle;

public HL7V24Field JobTitle
{
    get
    {
        if (jobTitle != null)
        {
            return jobTitle;
        }

        jobTitle = new HL7V24Field
        {
            field = message[@"STF"][18],
            Id = @"STF.18",
            Type = @"Field",
            Position = @"STF.18",
            Name = @"Job Title",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a descriptive name of the staff member’s occupation (e.g., Sr. Systems Analyst, Sr. Accountant).",
            Sample = @"",
        };

        

        

        

        return jobTitle;
    } 
}
internal HL7V24Field jobCodeClass;

public HL7V24Field JobCodeClass
{
    get
    {
        if (jobCodeClass != null)
        {
            return jobCodeClass;
        }

        jobCodeClass = new HL7V24Field
        {
            field = message[@"STF"][19],
            Id = @"STF.19",
            Type = @"Field",
            Position = @"STF.19",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code/class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff member’s job code and employee classification.  Refer to Userdefined Table 0327 - Job code and User-defined Table 0328 - Employee classification for suggested values.",
            Sample = @"",
        };

        

        

        

        return jobCodeClass;
    } 
}
internal HL7V24Field employmentStatusCode;

public HL7V24Field EmploymentStatusCode
{
    get
    {
        if (employmentStatusCode != null)
        {
            return employmentStatusCode;
        }

        employmentStatusCode = new HL7V24Field
        {
            field = message[@"STF"][20],
            Id = @"STF.20",
            Type = @"Field",
            Position = @"STF.20",
            Name = @"Employment Status Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"This field contains the code that indicates the staff member’s employment status, e.g., fulltime, part-time, self-employed, etc. Refer to User-defined Table 0066 - Employment status for suggested values.",
            Sample = @"",
        };

        

        

        

        return employmentStatusCode;
    } 
}
internal HL7V24Field additionalInsuredonAuto;

public HL7V24Field AdditionalInsuredonAuto
{
    get
    {
        if (additionalInsuredonAuto != null)
        {
            return additionalInsuredonAuto;
        }

        additionalInsuredonAuto = new HL7V24Field
        {
            field = message[@"STF"][21],
            Id = @"STF.21",
            Type = @"Field",
            Position = @"STF.21",
            Name = @"Additional Insured on  Auto",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether the present institution is named as an additional insured on the staff member’s auto insurance, especially for use when staff is a driver for the institution.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y indicates that the institution is named as an additional insured
- N indicates that the institution is not named as an additional insured",
            Sample = @"",
        };

        

        

        

        return additionalInsuredonAuto;
    } 
}
internal HL7V24Field driver'sLicenseNumberStaff;

public HL7V24Field Driver'sLicenseNumberStaff
{
    get
    {
        if (driver'sLicenseNumberStaff != null)
        {
            return driver'sLicenseNumberStaff;
        }

        driver'sLicenseNumberStaff = new HL7V24Field
        {
            field = message[@"STF"][22],
            Id = @"STF.22",
            Type = @"Field",
            Position = @"STF.22",
            Name = @"Driver's License Number - Staff",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DLN",
            DataTypeName = @"Driver's License Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the driver’s license information of staff, especially for use when staff is a driver for the institution.  For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes",
            Sample = @"",
        };

        

        

        

        return driver'sLicenseNumberStaff;
    } 
}
internal HL7V24Field copyAutoIns;

public HL7V24Field CopyAutoIns
{
    get
    {
        if (copyAutoIns != null)
        {
            return copyAutoIns;
        }

        copyAutoIns = new HL7V24Field
        {
            field = message[@"STF"][23],
            Id = @"STF.23",
            Type = @"Field",
            Position = @"STF.23",
            Name = @"Copy  Auto Ins",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether the institution has on file a copy of the staff member’s auto insurance, especially for use when staff is a driver for the institution.   Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y indicates that the institution has a copy on file
- N indicates that the institution does not have a copy on file",
            Sample = @"",
        };

        

        

        

        return copyAutoIns;
    } 
}
internal HL7V24Field autoIns.Expires;

public HL7V24Field AutoIns.Expires
{
    get
    {
        if (autoIns.Expires != null)
        {
            return autoIns.Expires;
        }

        autoIns.Expires = new HL7V24Field
        {
            field = message[@"STF"][24],
            Id = @"STF.24",
            Type = @"Field",
            Position = @"STF.24",
            Name = @"Auto Ins. Expires",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the staff member’s driver’s license expires, especially for use when staff is a driver for the institution",
            Sample = @"",
        };

        

        

        

        return autoIns.Expires;
    } 
}
internal HL7V24Field dateLastDMVReview;

public HL7V24Field DateLastDMVReview
{
    get
    {
        if (dateLastDMVReview != null)
        {
            return dateLastDMVReview;
        }

        dateLastDMVReview = new HL7V24Field
        {
            field = message[@"STF"][25],
            Id = @"STF.25",
            Type = @"Field",
            Position = @"STF.25",
            Name = @"Date Last DMV Review",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the staff member’s most recent Department of Motor Vehicles review, especially for use when staff is a driver for the institution",
            Sample = @"",
        };

        

        

        

        return dateLastDMVReview;
    } 
}
internal HL7V24Field dateNextDMVReview;

public HL7V24Field DateNextDMVReview
{
    get
    {
        if (dateNextDMVReview != null)
        {
            return dateNextDMVReview;
        }

        dateNextDMVReview = new HL7V24Field
        {
            field = message[@"STF"][26],
            Id = @"STF.26",
            Type = @"Field",
            Position = @"STF.26",
            Name = @"Date Next DMV Review",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the staff member’s next Department of Motor Vehicles review, especially for use when staff is a driver for the institution",
            Sample = @"",
        };

        

        

        

        return dateNextDMVReview;
    } 
}
internal HL7V24Field race;

public HL7V24Field Race
{
    get
    {
        if (race != null)
        {
            return race;
        }

        race = new HL7V24Field
        {
            field = message[@"STF"][27],
            Id = @"STF.27",
            Type = @"Field",
            Position = @"STF.27",
            Name = @"Race",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"This field refers to the person's race.  Refer to User-defined Table 0005 - Race for suggested values.  The second triplet of the CE data type for race (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes",
            Sample = @"",
        };

        

        

        

        return race;
    } 
}
internal HL7V24Field ethnicGroup;

public HL7V24Field EthnicGroup
{
    get
    {
        if (ethnicGroup != null)
        {
            return ethnicGroup;
        }

        ethnicGroup = new HL7V24Field
        {
            field = message[@"STF"][28],
            Id = @"STF.28",
            Type = @"Field",
            Position = @"STF.28",
            Name = @"Ethnic Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field further defines the person’s ancestry.  Refer to User-defined Table 0189 - Ethnic group for suggested values. The second couplet of the CE data type for ethnic group (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes. In the United States, a current use is to report ethnicity in line with US federal standards for Hispanic origin",
            Sample = @"",
        };

        

        

        

        return ethnicGroup;
    } 
}
internal HL7V24Field reactivationApprovalIndicator;

public HL7V24Field ReactivationApprovalIndicator
{
    get
    {
        if (reactivationApprovalIndicator != null)
        {
            return reactivationApprovalIndicator;
        }

        reactivationApprovalIndicator = new HL7V24Field
        {
            field = message[@"STF"][29],
            Id = @"STF.29",
            Type = @"Field",
            Position = @"STF.29",
            Name = @"Re-activation Approval Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether the re-activation of this record requires special approval.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.

- Y the re-activation requires approval
- N this re-activation does not require approval",
            Sample = @"",
        };

        

        

        

        return reactivationApprovalIndicator;
    } 
}

    }
}

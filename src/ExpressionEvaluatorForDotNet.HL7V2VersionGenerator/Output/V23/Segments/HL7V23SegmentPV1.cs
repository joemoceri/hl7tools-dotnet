using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPV1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PV1"; } }

        public string SegmentId { get { return @"PV1"; } }
        
        public string LongName { get { return @"Patient visit"; } }
        
        public string Description { get { return @"The PV1 segment is used by Registration/Patient Administration applications to communicate information on a visit-specific basis.  This segment can be used to send multiple-visit statistic records to the same patient account or single-visit records to more than one account.  Individual sites must determine the use for this segment.

PV1 usage notes 
The facility (servicing) ID, the optional fourth component of each patient location field, is a string of up to six characters that is uniquely associated with the facility containing the location.  A given institution, or group of intercommunicating institutions, should establish a list of facilities that may be potential assignors of patient locations.  The list will be one of the institution’s master dictionary lists.  Since third parties other than the assignors of patient locations may send or receive HL7 messages containing patient locations, the facility ID in the patient location may not be the same as that implied by the sending and receiving systems identified in the MSH.  The facility ID must be unique across facilities at a given site.  This field is required for HL7 implementations that have more than a single facility with bed locations, since the same <nurse unit> ^ <room> ^ <bed> combination may exist at more than one facility. "; } }
        
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
                            Id = @"PV1.1",
                            Type = @"Field",
                            Position = @"PV1.1",
                            Name = @"Set ID - Patient Visit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.2",
                            Type = @"Field",
                            Position = @"PV1.2",
                            Name = @"Patient Class",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0004",
                            TableName = @"Patient class",
                            Description = @"This field is used by systems to categorize patients by site.  It does not have a consistent industry-wide definition.  It is subject to site-specific variations.  Refer to user-defined table 0004 - Patient class for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.3",
                            Type = @"Field",
                            Position = @"PV1.3",
                            Name = @"Assigned Patient Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the patient’s initial assigned location or the location to which the patient is being moved.  The first component may be the nursing station for inpatient locations, or clinic, department, or home for locations other than inpatient.  For canceling a transaction or discharging a patient, the current location (after the cancellation event or before the discharge event) should be in this field.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.3.1",
                            Type = @"Component",
                            Position = @"PV1.3.1",
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
                            Id = @"PV1.3.2",
                            Type = @"Component",
                            Position = @"PV1.3.2",
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
                            Id = @"PV1.3.3",
                            Type = @"Component",
                            Position = @"PV1.3.3",
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
                            Id = @"PV1.3.4",
                            Type = @"Component",
                            Position = @"PV1.3.4",
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
                            Id = @"PV1.3.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.3.4.1",
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
                            Id = @"PV1.3.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.3.4.2",
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
                            Id = @"PV1.3.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.3.4.3",
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
                            Id = @"PV1.3.5",
                            Type = @"Component",
                            Position = @"PV1.3.5",
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
                            Id = @"PV1.3.6",
                            Type = @"Component",
                            Position = @"PV1.3.6",
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
                            Id = @"PV1.3.7",
                            Type = @"Component",
                            Position = @"PV1.3.7",
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
                            Id = @"PV1.3.8",
                            Type = @"Component",
                            Position = @"PV1.3.8",
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
                            Id = @"PV1.3.9",
                            Type = @"Component",
                            Position = @"PV1.3.9",
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
                            Id = @"PV1.4",
                            Type = @"Field",
                            Position = @"PV1.4",
                            Name = @"Admission Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0007",
                            TableName = @"Admission type",
                            Description = @"This field indicates the circumstances under which the patient was or will be admitted.   Refer to user-defined Table 0007 - Admission type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.5",
                            Type = @"Field",
                            Position = @"PV1.5",
                            Name = @"Preadmit Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field uniquely identifies the patient’s pre-admit account.  Some systems will continue to use the pre-admit number as the billing number after the patient has been admitted.  For backward compatibility, an ST data type can be sent; however HL7 recommends use of the CX data type, like the account number, for new implementations",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.5.1",
                            Type = @"Component",
                            Position = @"PV1.5.1",
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
                            Id = @"PV1.5.2",
                            Type = @"Component",
                            Position = @"PV1.5.2",
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
                            Id = @"PV1.5.3",
                            Type = @"Component",
                            Position = @"PV1.5.3",
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
                            Id = @"PV1.5.4",
                            Type = @"Component",
                            Position = @"PV1.5.4",
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
                            Id = @"PV1.5.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.5.4.1",
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
                            Id = @"PV1.5.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.5.4.2",
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
                            Id = @"PV1.5.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.5.4.3",
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
                            Id = @"PV1.5.5",
                            Type = @"Component",
                            Position = @"PV1.5.5",
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
                            Id = @"PV1.5.6",
                            Type = @"Component",
                            Position = @"PV1.5.6",
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
                            Id = @"PV1.5.6.1",
                            Type = @"SubComponent",
                            Position = @"PV1.5.6.1",
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
                            Id = @"PV1.5.6.2",
                            Type = @"SubComponent",
                            Position = @"PV1.5.6.2",
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
                            Id = @"PV1.5.6.3",
                            Type = @"SubComponent",
                            Position = @"PV1.5.6.3",
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
                            Id = @"PV1.6",
                            Type = @"Field",
                            Position = @"PV1.6",
                            Name = @"Prior Patient Location",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the prior patient location if the patient is being transferred.  The old location is null if the patient is new.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.6.1",
                            Type = @"Component",
                            Position = @"PV1.6.1",
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
                            Id = @"PV1.6.2",
                            Type = @"Component",
                            Position = @"PV1.6.2",
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
                            Id = @"PV1.6.3",
                            Type = @"Component",
                            Position = @"PV1.6.3",
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
                            Id = @"PV1.6.4",
                            Type = @"Component",
                            Position = @"PV1.6.4",
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
                            Id = @"PV1.6.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.6.4.1",
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
                            Id = @"PV1.6.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.6.4.2",
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
                            Id = @"PV1.6.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.6.4.3",
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
                            Id = @"PV1.6.5",
                            Type = @"Component",
                            Position = @"PV1.6.5",
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
                            Id = @"PV1.6.6",
                            Type = @"Component",
                            Position = @"PV1.6.6",
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
                            Id = @"PV1.6.7",
                            Type = @"Component",
                            Position = @"PV1.6.7",
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
                            Id = @"PV1.6.8",
                            Type = @"Component",
                            Position = @"PV1.6.8",
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
                            Id = @"PV1.6.9",
                            Type = @"Component",
                            Position = @"PV1.6.9",
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
                            Id = @"PV1.7",
                            Type = @"Field",
                            Position = @"PV1.7",
                            Name = @"Attending Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains the attending physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple attending doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  Depending on local agreements, either ID or the name may be absent in this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.7.1",
                            Type = @"Component",
                            Position = @"PV1.7.1",
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
                            Id = @"PV1.7.2",
                            Type = @"Component",
                            Position = @"PV1.7.2",
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
                            Id = @"PV1.7.3",
                            Type = @"Component",
                            Position = @"PV1.7.3",
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
                            Id = @"PV1.7.4",
                            Type = @"Component",
                            Position = @"PV1.7.4",
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
                            Id = @"PV1.7.5",
                            Type = @"Component",
                            Position = @"PV1.7.5",
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
                            Id = @"PV1.7.6",
                            Type = @"Component",
                            Position = @"PV1.7.6",
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
                            Id = @"PV1.7.7",
                            Type = @"Component",
                            Position = @"PV1.7.7",
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
                            Id = @"PV1.7.8",
                            Type = @"Component",
                            Position = @"PV1.7.8",
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
                            Id = @"PV1.7.9",
                            Type = @"Component",
                            Position = @"PV1.7.9",
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
                            Id = @"PV1.7.9.1",
                            Type = @"SubComponent",
                            Position = @"PV1.7.9.1",
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
                            Id = @"PV1.7.9.2",
                            Type = @"SubComponent",
                            Position = @"PV1.7.9.2",
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
                            Id = @"PV1.7.9.3",
                            Type = @"SubComponent",
                            Position = @"PV1.7.9.3",
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
                            Id = @"PV1.7.10",
                            Type = @"Component",
                            Position = @"PV1.7.10",
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
                            Id = @"PV1.7.11",
                            Type = @"Component",
                            Position = @"PV1.7.11",
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
                            Id = @"PV1.7.12",
                            Type = @"Component",
                            Position = @"PV1.7.12",
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
                            Id = @"PV1.7.13",
                            Type = @"Component",
                            Position = @"PV1.7.13",
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
                            Id = @"PV1.7.14",
                            Type = @"Component",
                            Position = @"PV1.7.14",
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
                            Id = @"PV1.7.14.1",
                            Type = @"SubComponent",
                            Position = @"PV1.7.14.1",
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
                            Id = @"PV1.7.14.2",
                            Type = @"SubComponent",
                            Position = @"PV1.7.14.2",
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
                            Id = @"PV1.7.14.3",
                            Type = @"SubComponent",
                            Position = @"PV1.7.14.3",
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
                            Id = @"PV1.8",
                            Type = @"Field",
                            Position = @"PV1.8",
                            Name = @"Referring Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains the referring physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple referring doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  Depending on local agreements, either the ID or the name may be absent from this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.8.1",
                            Type = @"Component",
                            Position = @"PV1.8.1",
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
                            Id = @"PV1.8.2",
                            Type = @"Component",
                            Position = @"PV1.8.2",
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
                            Id = @"PV1.8.3",
                            Type = @"Component",
                            Position = @"PV1.8.3",
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
                            Id = @"PV1.8.4",
                            Type = @"Component",
                            Position = @"PV1.8.4",
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
                            Id = @"PV1.8.5",
                            Type = @"Component",
                            Position = @"PV1.8.5",
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
                            Id = @"PV1.8.6",
                            Type = @"Component",
                            Position = @"PV1.8.6",
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
                            Id = @"PV1.8.7",
                            Type = @"Component",
                            Position = @"PV1.8.7",
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
                            Id = @"PV1.8.8",
                            Type = @"Component",
                            Position = @"PV1.8.8",
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
                            Id = @"PV1.8.9",
                            Type = @"Component",
                            Position = @"PV1.8.9",
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
                            Id = @"PV1.8.9.1",
                            Type = @"SubComponent",
                            Position = @"PV1.8.9.1",
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
                            Id = @"PV1.8.9.2",
                            Type = @"SubComponent",
                            Position = @"PV1.8.9.2",
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
                            Id = @"PV1.8.9.3",
                            Type = @"SubComponent",
                            Position = @"PV1.8.9.3",
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
                            Id = @"PV1.8.10",
                            Type = @"Component",
                            Position = @"PV1.8.10",
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
                            Id = @"PV1.8.11",
                            Type = @"Component",
                            Position = @"PV1.8.11",
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
                            Id = @"PV1.8.12",
                            Type = @"Component",
                            Position = @"PV1.8.12",
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
                            Id = @"PV1.8.13",
                            Type = @"Component",
                            Position = @"PV1.8.13",
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
                            Id = @"PV1.8.14",
                            Type = @"Component",
                            Position = @"PV1.8.14",
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
                            Id = @"PV1.8.14.1",
                            Type = @"SubComponent",
                            Position = @"PV1.8.14.1",
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
                            Id = @"PV1.8.14.2",
                            Type = @"SubComponent",
                            Position = @"PV1.8.14.2",
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
                            Id = @"PV1.8.14.3",
                            Type = @"SubComponent",
                            Position = @"PV1.8.14.3",
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
                            Id = @"PV1.9",
                            Type = @"Field",
                            Position = @"PV1.9",
                            Name = @"Consulting Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains the consulting physician information. The field sequences are used to indicate multiple consulting doctors. Depending on local agreements, either the ID or the name may be absent from this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.9.1",
                            Type = @"Component",
                            Position = @"PV1.9.1",
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
                            Id = @"PV1.9.2",
                            Type = @"Component",
                            Position = @"PV1.9.2",
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
                            Id = @"PV1.9.3",
                            Type = @"Component",
                            Position = @"PV1.9.3",
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
                            Id = @"PV1.9.4",
                            Type = @"Component",
                            Position = @"PV1.9.4",
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
                            Id = @"PV1.9.5",
                            Type = @"Component",
                            Position = @"PV1.9.5",
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
                            Id = @"PV1.9.6",
                            Type = @"Component",
                            Position = @"PV1.9.6",
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
                            Id = @"PV1.9.7",
                            Type = @"Component",
                            Position = @"PV1.9.7",
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
                            Id = @"PV1.9.8",
                            Type = @"Component",
                            Position = @"PV1.9.8",
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
                            Id = @"PV1.9.9",
                            Type = @"Component",
                            Position = @"PV1.9.9",
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
                            Id = @"PV1.9.9.1",
                            Type = @"SubComponent",
                            Position = @"PV1.9.9.1",
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
                            Id = @"PV1.9.9.2",
                            Type = @"SubComponent",
                            Position = @"PV1.9.9.2",
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
                            Id = @"PV1.9.9.3",
                            Type = @"SubComponent",
                            Position = @"PV1.9.9.3",
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
                            Id = @"PV1.9.10",
                            Type = @"Component",
                            Position = @"PV1.9.10",
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
                            Id = @"PV1.9.11",
                            Type = @"Component",
                            Position = @"PV1.9.11",
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
                            Id = @"PV1.9.12",
                            Type = @"Component",
                            Position = @"PV1.9.12",
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
                            Id = @"PV1.9.13",
                            Type = @"Component",
                            Position = @"PV1.9.13",
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
                            Id = @"PV1.9.14",
                            Type = @"Component",
                            Position = @"PV1.9.14",
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
                            Id = @"PV1.9.14.1",
                            Type = @"SubComponent",
                            Position = @"PV1.9.14.1",
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
                            Id = @"PV1.9.14.2",
                            Type = @"SubComponent",
                            Position = @"PV1.9.14.2",
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
                            Id = @"PV1.9.14.3",
                            Type = @"SubComponent",
                            Position = @"PV1.9.14.3",
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
                            Id = @"PV1.10",
                            Type = @"Field",
                            Position = @"PV1.10",
                            Name = @"Hospital Service",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0069",
                            TableName = @"Hospital service",
                            Description = @"This field contains the treatment or type of surgery that the patient is scheduled to receive.  It is a required field with trigger events A01 (admit/visit notification), A02 (transfer a patient), A14 (pending admit), A15 (pending transfer).  Refer to user-defined table 0069 - Hospital service for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.11",
                            Type = @"Field",
                            Position = @"PV1.11",
                            Name = @"Temporary Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a location other than the assigned location required for a temporary period of time (e.g., OR).  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.11.1",
                            Type = @"Component",
                            Position = @"PV1.11.1",
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
                            Id = @"PV1.11.2",
                            Type = @"Component",
                            Position = @"PV1.11.2",
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
                            Id = @"PV1.11.3",
                            Type = @"Component",
                            Position = @"PV1.11.3",
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
                            Id = @"PV1.11.4",
                            Type = @"Component",
                            Position = @"PV1.11.4",
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
                            Id = @"PV1.11.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.11.4.1",
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
                            Id = @"PV1.11.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.11.4.2",
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
                            Id = @"PV1.11.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.11.4.3",
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
                            Id = @"PV1.11.5",
                            Type = @"Component",
                            Position = @"PV1.11.5",
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
                            Id = @"PV1.11.6",
                            Type = @"Component",
                            Position = @"PV1.11.6",
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
                            Id = @"PV1.11.7",
                            Type = @"Component",
                            Position = @"PV1.11.7",
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
                            Id = @"PV1.11.8",
                            Type = @"Component",
                            Position = @"PV1.11.8",
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
                            Id = @"PV1.11.9",
                            Type = @"Component",
                            Position = @"PV1.11.9",
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
                            Id = @"PV1.12",
                            Type = @"Field",
                            Position = @"PV1.12",
                            Name = @"Preadmit Test Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0087",
                            TableName = @"Pre-admit test indicator",
                            Description = @"This field indicates whether the patient must have pre-admission testing done in order to be admitted.  Refer to user-defined table 0087 - Pre-admit test indicator for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.13",
                            Type = @"Field",
                            Position = @"PV1.13",
                            Name = @"Readmission Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0092",
                            TableName = @"Re-admission indicator",
                            Description = @"This field indicates that a patient is being re-admitted to the facility and gives the circumstances.  We suggest using “R” for readmission or else null.  Refer to user-defined table 0092 - Re-admission indicator for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.14",
                            Type = @"Field",
                            Position = @"PV1.14",
                            Name = @"Admit Source",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0023",
                            TableName = @"Admit source",
                            Description = @"This field indicates where the patient was admitted.  Refer to user-defined table 0023 - Admit source for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.15",
                            Type = @"Field",
                            Position = @"PV1.15",
                            Name = @"Ambulatory Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0009",
                            TableName = @"Ambulatory status",
                            Description = @"This field indicates any permanent or transient handicapped conditions.  Refer to user-defined table 0009 - Ambulatory status for suggested entries",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.16",
                            Type = @"Field",
                            Position = @"PV1.16",
                            Name = @"VIP Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0099",
                            TableName = @"VIP indicator",
                            Description = @"This field identifies the type of VIP.  Refer to user-defined table 0099 - VIP indicator",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.17",
                            Type = @"Field",
                            Position = @"PV1.17",
                            Name = @"Admitting Doctor",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the admitting physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple admitting doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  By local agreement, the name or ID may be absent in this field.  Refer to userdefined table 0010 - Physician ID for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.17.1",
                            Type = @"Component",
                            Position = @"PV1.17.1",
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
                            Id = @"PV1.17.2",
                            Type = @"Component",
                            Position = @"PV1.17.2",
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
                            Id = @"PV1.17.3",
                            Type = @"Component",
                            Position = @"PV1.17.3",
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
                            Id = @"PV1.17.4",
                            Type = @"Component",
                            Position = @"PV1.17.4",
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
                            Id = @"PV1.17.5",
                            Type = @"Component",
                            Position = @"PV1.17.5",
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
                            Id = @"PV1.17.6",
                            Type = @"Component",
                            Position = @"PV1.17.6",
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
                            Id = @"PV1.17.7",
                            Type = @"Component",
                            Position = @"PV1.17.7",
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
                            Id = @"PV1.17.8",
                            Type = @"Component",
                            Position = @"PV1.17.8",
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
                            Id = @"PV1.17.9",
                            Type = @"Component",
                            Position = @"PV1.17.9",
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
                            Id = @"PV1.17.9.1",
                            Type = @"SubComponent",
                            Position = @"PV1.17.9.1",
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
                            Id = @"PV1.17.9.2",
                            Type = @"SubComponent",
                            Position = @"PV1.17.9.2",
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
                            Id = @"PV1.17.9.3",
                            Type = @"SubComponent",
                            Position = @"PV1.17.9.3",
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
                            Id = @"PV1.17.10",
                            Type = @"Component",
                            Position = @"PV1.17.10",
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
                            Id = @"PV1.17.11",
                            Type = @"Component",
                            Position = @"PV1.17.11",
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
                            Id = @"PV1.17.12",
                            Type = @"Component",
                            Position = @"PV1.17.12",
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
                            Id = @"PV1.17.13",
                            Type = @"Component",
                            Position = @"PV1.17.13",
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
                            Id = @"PV1.17.14",
                            Type = @"Component",
                            Position = @"PV1.17.14",
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
                            Id = @"PV1.17.14.1",
                            Type = @"SubComponent",
                            Position = @"PV1.17.14.1",
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
                            Id = @"PV1.17.14.2",
                            Type = @"SubComponent",
                            Position = @"PV1.17.14.2",
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
                            Id = @"PV1.17.14.3",
                            Type = @"SubComponent",
                            Position = @"PV1.17.14.3",
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
                            Id = @"PV1.18",
                            Type = @"Field",
                            Position = @"PV1.18",
                            Name = @"Patient Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0018",
                            TableName = @"Patient type",
                            Description = @"This field contains site-specific values that identify the patient type.  Refer to user-defined table 0018 - Patient type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.19",
                            Type = @"Field",
                            Position = @"PV1.19",
                            Name = @"Visit Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"For backward compatibility, an NM data type may be sent, but HL7 recommends that new implementations use the CX data type.  This field contains the unique number assigned to each patient visit",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.19.1",
                            Type = @"Component",
                            Position = @"PV1.19.1",
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
                            Id = @"PV1.19.2",
                            Type = @"Component",
                            Position = @"PV1.19.2",
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
                            Id = @"PV1.19.3",
                            Type = @"Component",
                            Position = @"PV1.19.3",
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
                            Id = @"PV1.19.4",
                            Type = @"Component",
                            Position = @"PV1.19.4",
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
                            Id = @"PV1.19.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.19.4.1",
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
                            Id = @"PV1.19.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.19.4.2",
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
                            Id = @"PV1.19.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.19.4.3",
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
                            Id = @"PV1.19.5",
                            Type = @"Component",
                            Position = @"PV1.19.5",
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
                            Id = @"PV1.19.6",
                            Type = @"Component",
                            Position = @"PV1.19.6",
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
                            Id = @"PV1.19.6.1",
                            Type = @"SubComponent",
                            Position = @"PV1.19.6.1",
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
                            Id = @"PV1.19.6.2",
                            Type = @"SubComponent",
                            Position = @"PV1.19.6.2",
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
                            Id = @"PV1.19.6.3",
                            Type = @"SubComponent",
                            Position = @"PV1.19.6.3",
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
                            Id = @"PV1.20",
                            Type = @"Field",
                            Position = @"PV1.20",
                            Name = @"Financial Class",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"FC",
                            DataTypeName = @"Financial Class",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the primary financial class assigned to the patient for the purpose of identifying sources of reimbursement.  Repeats up to four times.  Refer to user-defined table 0064 - Financial class for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.20.1",
                            Type = @"Component",
                            Position = @"PV1.20.1",
                            Name = @"Financial Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0064",
                            TableName = @"Financial class",
                            Description = @"This component contains the financial class assigned to a person. Refer to user-defined table 0064 - Financial class for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.20.2",
                            Type = @"Component",
                            Position = @"PV1.20.2",
                            Name = @"Effective Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the effective date/time of the person’s assignment to the financial class specified in the first component",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.20.2.1",
                            Type = @"SubComponent",
                            Position = @"PV1.20.2.1",
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
                            Id = @"PV1.21",
                            Type = @"Field",
                            Position = @"PV1.21",
                            Name = @"Charge Price Indicator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0032",
                            TableName = @"Charge/price indicator",
                            Description = @"This field contains the code used to determine which price schedule is to be used for room and bed charges.  Refer to user-defined table 0032 - Charge/price indicator for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.22",
                            Type = @"Field",
                            Position = @"PV1.22",
                            Name = @"Courtesy Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0045",
                            TableName = @"Courtesy code",
                            Description = @"This field indicates whether the patient will be extended certain special courtesies.  Refer to userdefined table 0045 - Courtesy code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.23",
                            Type = @"Field",
                            Position = @"PV1.23",
                            Name = @"Credit Rating",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0046",
                            TableName = @"Credit rating",
                            Description = @"This field contains the user-defined code to determine past credit experience.  Refer to userdefined table 0046 - Credit rating for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.24",
                            Type = @"Field",
                            Position = @"PV1.24",
                            Name = @"Contract Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0044",
                            TableName = @"Contract code",
                            Description = @"This field identifies the type of contract entered into by the facility and the guarantor for the purpose of settling outstanding account balances.  Refer to user-defined table 0044 - Contract code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.25",
                            Type = @"Field",
                            Position = @"PV1.25",
                            Name = @"Contract Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the contract is to start or started",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.26",
                            Type = @"Field",
                            Position = @"PV1.26",
                            Name = @"Contract Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount to be paid by the guarantor each period according to the contract",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.27",
                            Type = @"Field",
                            Position = @"PV1.27",
                            Name = @"Contract Period",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the duration of the contract for user-defined periods",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.28",
                            Type = @"Field",
                            Position = @"PV1.28",
                            Name = @"Interest Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0073",
                            TableName = @"Interest rate code",
                            Description = @"This field indicates the amount of interest that will be charged the guarantor on any outstanding amounts.  Refer to user-defined table 0073 - Interest rate code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.29",
                            Type = @"Field",
                            Position = @"PV1.29",
                            Name = @"Transfer to Bad Debt Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0110",
                            TableName = @"Transfer to bad debt code",
                            Description = @"This field indicates that the account was transferred to bad debts and gives the reason.  Refer to user-defined table 0110 - Transfer to bad debt code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.30",
                            Type = @"Field",
                            Position = @"PV1.30",
                            Name = @"Transfer to Bad Debt Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the account was transferred to a bad debt status",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.31",
                            Type = @"Field",
                            Position = @"PV1.31",
                            Name = @"Bad Debt Agency Code",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0021",
                            TableName = @"Bad debt agency code",
                            Description = @"This field can be used as an ST type for backward compatibility.  This field uniquely identifies the bad debt agency to which the account was transferred.  This code is site defined.  One possible implementation would be to edit against a table such as user-defined table 0021 - Bad debt agency code; however, this is not required",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.32",
                            Type = @"Field",
                            Position = @"PV1.32",
                            Name = @"Bad Debt Transfer Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount that was transferred to a bad debt status",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.33",
                            Type = @"Field",
                            Position = @"PV1.33",
                            Name = @"Bad Debt Recovery Amount",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the amount recovered from the guarantor on the account",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.34",
                            Type = @"Field",
                            Position = @"PV1.34",
                            Name = @"Delete Account Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0111",
                            TableName = @"Delete account code",
                            Description = @"This field indicates that the account was deleted from the file and gives the reason.  Refer to user-defined table 0111 - Delete account code for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.35",
                            Type = @"Field",
                            Position = @"PV1.35",
                            Name = @"Delete Account Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date that the account was deleted from the file",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.36",
                            Type = @"Field",
                            Position = @"PV1.36",
                            Name = @"Discharge Disposition",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0112",
                            TableName = @"Discharge disposition",
                            Description = @"This field contains the disposition of the patient at time of discharge (i.e., discharged to home, expired, etc.).  Refer to user-defined table 0112 - Discharged disposition for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.37",
                            Type = @"Field",
                            Position = @"PV1.37",
                            Name = @"Discharged to Location",
                            Length = 25,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_DLD",
                            DataTypeName = @"Discharge Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates a facility to which the patient was discharged.  Refer to user-defined table 0113 - Discharged to location for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.37.1",
                            Type = @"Component",
                            Position = @"PV1.37.1",
                            Name = @"Discharge Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0113",
                            TableName = @"Discharged to location",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.37.2",
                            Type = @"Component",
                            Position = @"PV1.37.2",
                            Name = @"Effective Date",
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
                            Id = @"PV1.37.2.1",
                            Type = @"SubComponent",
                            Position = @"PV1.37.2.1",
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
                            Id = @"PV1.38",
                            Type = @"Field",
                            Position = @"PV1.38",
                            Name = @"Diet Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0114",
                            TableName = @"Diet type",
                            Description = @"This field indicates a special diet type for a patient.  Refer to user-defined table 0114 - Diet type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.39",
                            Type = @"Field",
                            Position = @"PV1.39",
                            Name = @"Servicing Facility",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0115",
                            TableName = @"Servicing facility",
                            Description = @"This field is used in a multiple facility environment to indicate the facility with which this visit is associated.  Refer to user-defined table 0115 - Servicing facility for suggested values. 
An optional fourth component, the facility ID, may be valued in each individual location field in PV1, instead of placing it here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.40",
                            Type = @"Field",
                            Position = @"PV1.40",
                            Name = @"Bed Status",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0116",
                            TableName = @"Bed status",
                            Description = @"This field has been retained for backward compatibility only.  This field contains the status of the bed.  Refer to user-defined table 0116 - Bed status for suggested values.
An optional fifth component, bed status, may be valued in each individual location field in PV1, instead of placing it here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.41",
                            Type = @"Field",
                            Position = @"PV1.41",
                            Name = @"Account Status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0117",
                            TableName = @"Account status",
                            Description = @"This field contains the account status.  Refer to user-defined table 0117 - Account status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.42",
                            Type = @"Field",
                            Position = @"PV1.42",
                            Name = @"Pending Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the point of care, room, bed, facility ID, and bed status to which the patient may be moved.  The first component may be the nursing station for inpatient locations, or the clinic, department, or home for locations other than inpatient.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.42.1",
                            Type = @"Component",
                            Position = @"PV1.42.1",
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
                            Id = @"PV1.42.2",
                            Type = @"Component",
                            Position = @"PV1.42.2",
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
                            Id = @"PV1.42.3",
                            Type = @"Component",
                            Position = @"PV1.42.3",
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
                            Id = @"PV1.42.4",
                            Type = @"Component",
                            Position = @"PV1.42.4",
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
                            Id = @"PV1.42.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.42.4.1",
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
                            Id = @"PV1.42.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.42.4.2",
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
                            Id = @"PV1.42.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.42.4.3",
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
                            Id = @"PV1.42.5",
                            Type = @"Component",
                            Position = @"PV1.42.5",
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
                            Id = @"PV1.42.6",
                            Type = @"Component",
                            Position = @"PV1.42.6",
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
                            Id = @"PV1.42.7",
                            Type = @"Component",
                            Position = @"PV1.42.7",
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
                            Id = @"PV1.42.8",
                            Type = @"Component",
                            Position = @"PV1.42.8",
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
                            Id = @"PV1.42.9",
                            Type = @"Component",
                            Position = @"PV1.42.9",
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
                            Id = @"PV1.43",
                            Type = @"Field",
                            Position = @"PV1.43",
                            Name = @"Prior Temporary Location",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to reflect the patient’s temporary location (such as the OR or X-RAY) prior to a transfer from a temporary location to an actual location, or from a temporary location to another temporary location. The first component may be the nursing station for inpatient locations, or the clinic, department, or home for locations other than inpatient.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.43.1",
                            Type = @"Component",
                            Position = @"PV1.43.1",
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
                            Id = @"PV1.43.2",
                            Type = @"Component",
                            Position = @"PV1.43.2",
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
                            Id = @"PV1.43.3",
                            Type = @"Component",
                            Position = @"PV1.43.3",
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
                            Id = @"PV1.43.4",
                            Type = @"Component",
                            Position = @"PV1.43.4",
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
                            Id = @"PV1.43.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.43.4.1",
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
                            Id = @"PV1.43.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.43.4.2",
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
                            Id = @"PV1.43.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.43.4.3",
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
                            Id = @"PV1.43.5",
                            Type = @"Component",
                            Position = @"PV1.43.5",
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
                            Id = @"PV1.43.6",
                            Type = @"Component",
                            Position = @"PV1.43.6",
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
                            Id = @"PV1.43.7",
                            Type = @"Component",
                            Position = @"PV1.43.7",
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
                            Id = @"PV1.43.8",
                            Type = @"Component",
                            Position = @"PV1.43.8",
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
                            Id = @"PV1.43.9",
                            Type = @"Component",
                            Position = @"PV1.43.9",
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
                            Id = @"PV1.44",
                            Type = @"Field",
                            Position = @"PV1.44",
                            Name = @"Admit Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the admit date/time.  It is to be used if the event date/time is different than the admit date and time, i.e., a retroactive update.  This field is also used to reflect the date/time of an outpatient/emergency patient registration",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.44.1",
                            Type = @"Component",
                            Position = @"PV1.44.1",
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
                            Id = @"PV1.45",
                            Type = @"Field",
                            Position = @"PV1.45",
                            Name = @"Discharge Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the discharge date/time.  It is to be used if the event date/time is different than the discharge date and time, that is, a retroactive update.  This field is also used to reflect the date/time of an outpatient/emergency patient discharge",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.45.1",
                            Type = @"Component",
                            Position = @"PV1.45.1",
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
                            Id = @"PV1.46",
                            Type = @"Field",
                            Position = @"PV1.46",
                            Name = @"Current Patient Balance",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the visit balance due",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.47",
                            Type = @"Field",
                            Position = @"PV1.47",
                            Name = @"Total Charges",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total visit charges",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.48",
                            Type = @"Field",
                            Position = @"PV1.48",
                            Name = @"Total Adjustments",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total adjustments for visit",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.49",
                            Type = @"Field",
                            Position = @"PV1.49",
                            Name = @"Total Payments",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total payments for visit",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.50",
                            Type = @"Field",
                            Position = @"PV1.50",
                            Name = @"Alternate Visit ID",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the alternative, temporary, or pending optional visit ID number to be used if needed.  Refer to HL7 table 0061 - Check digit scheme for valid values.  Refer to user-defined table 0192 - Visit ID type for suggested values",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.50.1",
                            Type = @"Component",
                            Position = @"PV1.50.1",
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
                            Id = @"PV1.50.2",
                            Type = @"Component",
                            Position = @"PV1.50.2",
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
                            Id = @"PV1.50.3",
                            Type = @"Component",
                            Position = @"PV1.50.3",
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
                            Id = @"PV1.50.4",
                            Type = @"Component",
                            Position = @"PV1.50.4",
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
                            Id = @"PV1.50.4.1",
                            Type = @"SubComponent",
                            Position = @"PV1.50.4.1",
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
                            Id = @"PV1.50.4.2",
                            Type = @"SubComponent",
                            Position = @"PV1.50.4.2",
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
                            Id = @"PV1.50.4.3",
                            Type = @"SubComponent",
                            Position = @"PV1.50.4.3",
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
                            Id = @"PV1.50.5",
                            Type = @"Component",
                            Position = @"PV1.50.5",
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
                            Id = @"PV1.50.6",
                            Type = @"Component",
                            Position = @"PV1.50.6",
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
                            Id = @"PV1.50.6.1",
                            Type = @"SubComponent",
                            Position = @"PV1.50.6.1",
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
                            Id = @"PV1.50.6.2",
                            Type = @"SubComponent",
                            Position = @"PV1.50.6.2",
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
                            Id = @"PV1.50.6.3",
                            Type = @"SubComponent",
                            Position = @"PV1.50.6.3",
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
                            Id = @"PV1.51",
                            Type = @"Field",
                            Position = @"PV1.51",
                            Name = @"Visit Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0326",
                            TableName = @"Visit indicator",
                            Description = @"This field specifies the level on which data are being sent.  It is the indicator used to send data at two levels, visit and account.  HL7 recommends sending an ‘A’ or no value when the data in the message are at the account level, or ‘V’ to indicate that  the data sent in the message is at the visit level.  Refer to userdefined table 0326 - Visit indicator for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.52",
                            Type = @"Field",
                            Position = @"PV1.52",
                            Name = @"Other Healthcare Provider",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name",
                            TableId = @"0010",
                            TableName = @"Physician ID",
                            Description = @"This field contains the other healthcare providers (e.g., Nurse care practitioner, midwife, physician assistant).  Multiple healthcare providers can be sent.  Depending on local agreements, either the ID or the name may be absent from this field.  Use values in user-defined table 0010 - Physician ID for first component",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PV1.52.1",
                            Type = @"Component",
                            Position = @"PV1.52.1",
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
                            Id = @"PV1.52.2",
                            Type = @"Component",
                            Position = @"PV1.52.2",
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
                            Id = @"PV1.52.3",
                            Type = @"Component",
                            Position = @"PV1.52.3",
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
                            Id = @"PV1.52.4",
                            Type = @"Component",
                            Position = @"PV1.52.4",
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
                            Id = @"PV1.52.5",
                            Type = @"Component",
                            Position = @"PV1.52.5",
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
                            Id = @"PV1.52.6",
                            Type = @"Component",
                            Position = @"PV1.52.6",
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
                            Id = @"PV1.52.7",
                            Type = @"Component",
                            Position = @"PV1.52.7",
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
                            Id = @"PV1.52.8",
                            Type = @"Component",
                            Position = @"PV1.52.8",
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
                            Id = @"PV1.52.9",
                            Type = @"Component",
                            Position = @"PV1.52.9",
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
                            Id = @"PV1.52.9.1",
                            Type = @"SubComponent",
                            Position = @"PV1.52.9.1",
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
                            Id = @"PV1.52.9.2",
                            Type = @"SubComponent",
                            Position = @"PV1.52.9.2",
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
                            Id = @"PV1.52.9.3",
                            Type = @"SubComponent",
                            Position = @"PV1.52.9.3",
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
                            Id = @"PV1.52.10",
                            Type = @"Component",
                            Position = @"PV1.52.10",
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
                            Id = @"PV1.52.11",
                            Type = @"Component",
                            Position = @"PV1.52.11",
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
                            Id = @"PV1.52.12",
                            Type = @"Component",
                            Position = @"PV1.52.12",
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
                            Id = @"PV1.52.13",
                            Type = @"Component",
                            Position = @"PV1.52.13",
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
                            Id = @"PV1.52.14",
                            Type = @"Component",
                            Position = @"PV1.52.14",
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
                            Id = @"PV1.52.14.1",
                            Type = @"SubComponent",
                            Position = @"PV1.52.14.1",
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
                            Id = @"PV1.52.14.2",
                            Type = @"SubComponent",
                            Position = @"PV1.52.14.2",
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
                            Id = @"PV1.52.14.3",
                            Type = @"SubComponent",
                            Position = @"PV1.52.14.3",
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
                        };
            }
        }

        public HL7V23SegmentPV1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDPatientVisit;

public HL7V23Field SetIDPatientVisit
{
    get
    {
        if (setIDPatientVisit != null)
        {
            return setIDPatientVisit;
        }

        setIDPatientVisit = new HL7V23Field
        {
            field = message[@"PV1"][1],
            Id = @"PV1.1",
            Type = @"Field",
            Position = @"PV1.1",
            Name = @"Set ID - Patient Visit",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc",
            Sample = @"",
        };

        

        

        

        return setIDPatientVisit;
    } 
}
internal HL7V23Field patientClass;

public HL7V23Field PatientClass
{
    get
    {
        if (patientClass != null)
        {
            return patientClass;
        }

        patientClass = new HL7V23Field
        {
            field = message[@"PV1"][2],
            Id = @"PV1.2",
            Type = @"Field",
            Position = @"PV1.2",
            Name = @"Patient Class",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0004",
            TableName = @"Patient class",
            Description = @"This field is used by systems to categorize patients by site.  It does not have a consistent industry-wide definition.  It is subject to site-specific variations.  Refer to user-defined table 0004 - Patient class for suggested values",
            Sample = @"",
        };

        

        

        

        return patientClass;
    } 
}
internal HL7V23Field assignedPatientLocation;

public HL7V23Field AssignedPatientLocation
{
    get
    {
        if (assignedPatientLocation != null)
        {
            return assignedPatientLocation;
        }

        assignedPatientLocation = new HL7V23Field
        {
            field = message[@"PV1"][3],
            Id = @"PV1.3",
            Type = @"Field",
            Position = @"PV1.3",
            Name = @"Assigned Patient Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the patient’s initial assigned location or the location to which the patient is being moved.  The first component may be the nursing station for inpatient locations, or clinic, department, or home for locations other than inpatient.  For canceling a transaction or discharging a patient, the current location (after the cancellation event or before the discharge event) should be in this field.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
            Sample = @"",
        };

        

        

        

        return assignedPatientLocation;
    } 
}
internal HL7V23Field admissionType;

public HL7V23Field AdmissionType
{
    get
    {
        if (admissionType != null)
        {
            return admissionType;
        }

        admissionType = new HL7V23Field
        {
            field = message[@"PV1"][4],
            Id = @"PV1.4",
            Type = @"Field",
            Position = @"PV1.4",
            Name = @"Admission Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0007",
            TableName = @"Admission type",
            Description = @"This field indicates the circumstances under which the patient was or will be admitted.   Refer to user-defined Table 0007 - Admission type for suggested values",
            Sample = @"",
        };

        

        

        

        return admissionType;
    } 
}
internal HL7V23Field preadmitNumber;

public HL7V23Field PreadmitNumber
{
    get
    {
        if (preadmitNumber != null)
        {
            return preadmitNumber;
        }

        preadmitNumber = new HL7V23Field
        {
            field = message[@"PV1"][5],
            Id = @"PV1.5",
            Type = @"Field",
            Position = @"PV1.5",
            Name = @"Preadmit Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the patient’s pre-admit account.  Some systems will continue to use the pre-admit number as the billing number after the patient has been admitted.  For backward compatibility, an ST data type can be sent; however HL7 recommends use of the CX data type, like the account number, for new implementations",
            Sample = @"",
        };

        

        

        

        return preadmitNumber;
    } 
}
internal HL7V23Field priorPatientLocation;

public HL7V23Field PriorPatientLocation
{
    get
    {
        if (priorPatientLocation != null)
        {
            return priorPatientLocation;
        }

        priorPatientLocation = new HL7V23Field
        {
            field = message[@"PV1"][6],
            Id = @"PV1.6",
            Type = @"Field",
            Position = @"PV1.6",
            Name = @"Prior Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the prior patient location if the patient is being transferred.  The old location is null if the patient is new.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
            Sample = @"",
        };

        

        

        

        return priorPatientLocation;
    } 
}
internal HL7V23Field attendingDoctor;

public HL7V23Field AttendingDoctor
{
    get
    {
        if (attendingDoctor != null)
        {
            return attendingDoctor;
        }

        attendingDoctor = new HL7V23Field
        {
            field = message[@"PV1"][7],
            Id = @"PV1.7",
            Type = @"Field",
            Position = @"PV1.7",
            Name = @"Attending Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains the attending physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple attending doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  Depending on local agreements, either ID or the name may be absent in this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
            Sample = @"",
        };

        

        

        

        return attendingDoctor;
    } 
}
internal HL7V23Field referringDoctor;

public HL7V23Field ReferringDoctor
{
    get
    {
        if (referringDoctor != null)
        {
            return referringDoctor;
        }

        referringDoctor = new HL7V23Field
        {
            field = message[@"PV1"][8],
            Id = @"PV1.8",
            Type = @"Field",
            Position = @"PV1.8",
            Name = @"Referring Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains the referring physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple referring doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  Depending on local agreements, either the ID or the name may be absent from this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
            Sample = @"",
        };

        

        

        

        return referringDoctor;
    } 
}
internal HL7V23Field consultingDoctor;

public HL7V23Field ConsultingDoctor
{
    get
    {
        if (consultingDoctor != null)
        {
            return consultingDoctor;
        }

        consultingDoctor = new HL7V23Field
        {
            field = message[@"PV1"][9],
            Id = @"PV1.9",
            Type = @"Field",
            Position = @"PV1.9",
            Name = @"Consulting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains the consulting physician information. The field sequences are used to indicate multiple consulting doctors. Depending on local agreements, either the ID or the name may be absent from this field.  Refer to user-defined table 0010 - Physician ID for suggested values",
            Sample = @"",
        };

        

        

        

        return consultingDoctor;
    } 
}
internal HL7V23Field hospitalService;

public HL7V23Field HospitalService
{
    get
    {
        if (hospitalService != null)
        {
            return hospitalService;
        }

        hospitalService = new HL7V23Field
        {
            field = message[@"PV1"][10],
            Id = @"PV1.10",
            Type = @"Field",
            Position = @"PV1.10",
            Name = @"Hospital Service",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0069",
            TableName = @"Hospital service",
            Description = @"This field contains the treatment or type of surgery that the patient is scheduled to receive.  It is a required field with trigger events A01 (admit/visit notification), A02 (transfer a patient), A14 (pending admit), A15 (pending transfer).  Refer to user-defined table 0069 - Hospital service for suggested values",
            Sample = @"",
        };

        

        

        

        return hospitalService;
    } 
}
internal HL7V23Field temporaryLocation;

public HL7V23Field TemporaryLocation
{
    get
    {
        if (temporaryLocation != null)
        {
            return temporaryLocation;
        }

        temporaryLocation = new HL7V23Field
        {
            field = message[@"PV1"][11],
            Id = @"PV1.11",
            Type = @"Field",
            Position = @"PV1.11",
            Name = @"Temporary Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains a location other than the assigned location required for a temporary period of time (e.g., OR).  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
            Sample = @"",
        };

        

        

        

        return temporaryLocation;
    } 
}
internal HL7V23Field preadmitTestIndicator;

public HL7V23Field PreadmitTestIndicator
{
    get
    {
        if (preadmitTestIndicator != null)
        {
            return preadmitTestIndicator;
        }

        preadmitTestIndicator = new HL7V23Field
        {
            field = message[@"PV1"][12],
            Id = @"PV1.12",
            Type = @"Field",
            Position = @"PV1.12",
            Name = @"Preadmit Test Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0087",
            TableName = @"Pre-admit test indicator",
            Description = @"This field indicates whether the patient must have pre-admission testing done in order to be admitted.  Refer to user-defined table 0087 - Pre-admit test indicator for suggested values",
            Sample = @"",
        };

        

        

        

        return preadmitTestIndicator;
    } 
}
internal HL7V23Field readmissionIndicator;

public HL7V23Field ReadmissionIndicator
{
    get
    {
        if (readmissionIndicator != null)
        {
            return readmissionIndicator;
        }

        readmissionIndicator = new HL7V23Field
        {
            field = message[@"PV1"][13],
            Id = @"PV1.13",
            Type = @"Field",
            Position = @"PV1.13",
            Name = @"Readmission Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0092",
            TableName = @"Re-admission indicator",
            Description = @"This field indicates that a patient is being re-admitted to the facility and gives the circumstances.  We suggest using “R” for readmission or else null.  Refer to user-defined table 0092 - Re-admission indicator for suggested values",
            Sample = @"",
        };

        

        

        

        return readmissionIndicator;
    } 
}
internal HL7V23Field admitSource;

public HL7V23Field AdmitSource
{
    get
    {
        if (admitSource != null)
        {
            return admitSource;
        }

        admitSource = new HL7V23Field
        {
            field = message[@"PV1"][14],
            Id = @"PV1.14",
            Type = @"Field",
            Position = @"PV1.14",
            Name = @"Admit Source",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0023",
            TableName = @"Admit source",
            Description = @"This field indicates where the patient was admitted.  Refer to user-defined table 0023 - Admit source for suggested values",
            Sample = @"",
        };

        

        

        

        return admitSource;
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
            field = message[@"PV1"][15],
            Id = @"PV1.15",
            Type = @"Field",
            Position = @"PV1.15",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"This field indicates any permanent or transient handicapped conditions.  Refer to user-defined table 0009 - Ambulatory status for suggested entries",
            Sample = @"",
        };

        

        

        

        return ambulatoryStatus;
    } 
}
internal HL7V23Field vIPIndicator;

public HL7V23Field VIPIndicator
{
    get
    {
        if (vIPIndicator != null)
        {
            return vIPIndicator;
        }

        vIPIndicator = new HL7V23Field
        {
            field = message[@"PV1"][16],
            Id = @"PV1.16",
            Type = @"Field",
            Position = @"PV1.16",
            Name = @"VIP Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0099",
            TableName = @"VIP indicator",
            Description = @"This field identifies the type of VIP.  Refer to user-defined table 0099 - VIP indicator",
            Sample = @"",
        };

        

        

        

        return vIPIndicator;
    } 
}
internal HL7V23Field admittingDoctor;

public HL7V23Field AdmittingDoctor
{
    get
    {
        if (admittingDoctor != null)
        {
            return admittingDoctor;
        }

        admittingDoctor = new HL7V23Field
        {
            field = message[@"PV1"][17],
            Id = @"PV1.17",
            Type = @"Field",
            Position = @"PV1.17",
            Name = @"Admitting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the admitting physician information.  Multiple names and identifiers for the same physician may be sent.  The field sequences are not used to indicate multiple admitting doctors.  The legal name must be sent in the first sequence.  If the legal name is not sent, then a repeat delimiter must be sent in the first sequence.  By local agreement, the name or ID may be absent in this field.  Refer to userdefined table 0010 - Physician ID for suggested values",
            Sample = @"",
        };

        

        

        

        return admittingDoctor;
    } 
}
internal HL7V23Field patientType;

public HL7V23Field PatientType
{
    get
    {
        if (patientType != null)
        {
            return patientType;
        }

        patientType = new HL7V23Field
        {
            field = message[@"PV1"][18],
            Id = @"PV1.18",
            Type = @"Field",
            Position = @"PV1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0018",
            TableName = @"Patient type",
            Description = @"This field contains site-specific values that identify the patient type.  Refer to user-defined table 0018 - Patient type for suggested values",
            Sample = @"",
        };

        

        

        

        return patientType;
    } 
}
internal HL7V23Field visitNumber;

public HL7V23Field VisitNumber
{
    get
    {
        if (visitNumber != null)
        {
            return visitNumber;
        }

        visitNumber = new HL7V23Field
        {
            field = message[@"PV1"][19],
            Id = @"PV1.19",
            Type = @"Field",
            Position = @"PV1.19",
            Name = @"Visit Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"For backward compatibility, an NM data type may be sent, but HL7 recommends that new implementations use the CX data type.  This field contains the unique number assigned to each patient visit",
            Sample = @"",
        };

        

        

        

        return visitNumber;
    } 
}
internal HL7V23Field financialClass;

public HL7V23Field FinancialClass
{
    get
    {
        if (financialClass != null)
        {
            return financialClass;
        }

        financialClass = new HL7V23Field
        {
            field = message[@"PV1"][20],
            Id = @"PV1.20",
            Type = @"Field",
            Position = @"PV1.20",
            Name = @"Financial Class",
            Length = 50,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FC",
            DataTypeName = @"Financial Class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the primary financial class assigned to the patient for the purpose of identifying sources of reimbursement.  Repeats up to four times.  Refer to user-defined table 0064 - Financial class for suggested values",
            Sample = @"",
        };

        

        

        

        return financialClass;
    } 
}
internal HL7V23Field chargePriceIndicator;

public HL7V23Field ChargePriceIndicator
{
    get
    {
        if (chargePriceIndicator != null)
        {
            return chargePriceIndicator;
        }

        chargePriceIndicator = new HL7V23Field
        {
            field = message[@"PV1"][21],
            Id = @"PV1.21",
            Type = @"Field",
            Position = @"PV1.21",
            Name = @"Charge Price Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0032",
            TableName = @"Charge/price indicator",
            Description = @"This field contains the code used to determine which price schedule is to be used for room and bed charges.  Refer to user-defined table 0032 - Charge/price indicator for suggested values",
            Sample = @"",
        };

        

        

        

        return chargePriceIndicator;
    } 
}
internal HL7V23Field courtesyCode;

public HL7V23Field CourtesyCode
{
    get
    {
        if (courtesyCode != null)
        {
            return courtesyCode;
        }

        courtesyCode = new HL7V23Field
        {
            field = message[@"PV1"][22],
            Id = @"PV1.22",
            Type = @"Field",
            Position = @"PV1.22",
            Name = @"Courtesy Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0045",
            TableName = @"Courtesy code",
            Description = @"This field indicates whether the patient will be extended certain special courtesies.  Refer to userdefined table 0045 - Courtesy code for suggested values",
            Sample = @"",
        };

        

        

        

        return courtesyCode;
    } 
}
internal HL7V23Field creditRating;

public HL7V23Field CreditRating
{
    get
    {
        if (creditRating != null)
        {
            return creditRating;
        }

        creditRating = new HL7V23Field
        {
            field = message[@"PV1"][23],
            Id = @"PV1.23",
            Type = @"Field",
            Position = @"PV1.23",
            Name = @"Credit Rating",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0046",
            TableName = @"Credit rating",
            Description = @"This field contains the user-defined code to determine past credit experience.  Refer to userdefined table 0046 - Credit rating for suggested values",
            Sample = @"",
        };

        

        

        

        return creditRating;
    } 
}
internal HL7V23Field contractCode;

public HL7V23Field ContractCode
{
    get
    {
        if (contractCode != null)
        {
            return contractCode;
        }

        contractCode = new HL7V23Field
        {
            field = message[@"PV1"][24],
            Id = @"PV1.24",
            Type = @"Field",
            Position = @"PV1.24",
            Name = @"Contract Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0044",
            TableName = @"Contract code",
            Description = @"This field identifies the type of contract entered into by the facility and the guarantor for the purpose of settling outstanding account balances.  Refer to user-defined table 0044 - Contract code for suggested values",
            Sample = @"",
        };

        

        

        

        return contractCode;
    } 
}
internal HL7V23Field contractEffectiveDate;

public HL7V23Field ContractEffectiveDate
{
    get
    {
        if (contractEffectiveDate != null)
        {
            return contractEffectiveDate;
        }

        contractEffectiveDate = new HL7V23Field
        {
            field = message[@"PV1"][25],
            Id = @"PV1.25",
            Type = @"Field",
            Position = @"PV1.25",
            Name = @"Contract Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the contract is to start or started",
            Sample = @"",
        };

        

        

        

        return contractEffectiveDate;
    } 
}
internal HL7V23Field contractAmount;

public HL7V23Field ContractAmount
{
    get
    {
        if (contractAmount != null)
        {
            return contractAmount;
        }

        contractAmount = new HL7V23Field
        {
            field = message[@"PV1"][26],
            Id = @"PV1.26",
            Type = @"Field",
            Position = @"PV1.26",
            Name = @"Contract Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount to be paid by the guarantor each period according to the contract",
            Sample = @"",
        };

        

        

        

        return contractAmount;
    } 
}
internal HL7V23Field contractPeriod;

public HL7V23Field ContractPeriod
{
    get
    {
        if (contractPeriod != null)
        {
            return contractPeriod;
        }

        contractPeriod = new HL7V23Field
        {
            field = message[@"PV1"][27],
            Id = @"PV1.27",
            Type = @"Field",
            Position = @"PV1.27",
            Name = @"Contract Period",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the duration of the contract for user-defined periods",
            Sample = @"",
        };

        

        

        

        return contractPeriod;
    } 
}
internal HL7V23Field interestCode;

public HL7V23Field InterestCode
{
    get
    {
        if (interestCode != null)
        {
            return interestCode;
        }

        interestCode = new HL7V23Field
        {
            field = message[@"PV1"][28],
            Id = @"PV1.28",
            Type = @"Field",
            Position = @"PV1.28",
            Name = @"Interest Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0073",
            TableName = @"Interest rate code",
            Description = @"This field indicates the amount of interest that will be charged the guarantor on any outstanding amounts.  Refer to user-defined table 0073 - Interest rate code for suggested values",
            Sample = @"",
        };

        

        

        

        return interestCode;
    } 
}
internal HL7V23Field transfertoBadDebtCode;

public HL7V23Field TransfertoBadDebtCode
{
    get
    {
        if (transfertoBadDebtCode != null)
        {
            return transfertoBadDebtCode;
        }

        transfertoBadDebtCode = new HL7V23Field
        {
            field = message[@"PV1"][29],
            Id = @"PV1.29",
            Type = @"Field",
            Position = @"PV1.29",
            Name = @"Transfer to Bad Debt Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0110",
            TableName = @"Transfer to bad debt code",
            Description = @"This field indicates that the account was transferred to bad debts and gives the reason.  Refer to user-defined table 0110 - Transfer to bad debt code for suggested values",
            Sample = @"",
        };

        

        

        

        return transfertoBadDebtCode;
    } 
}
internal HL7V23Field transfertoBadDebtDate;

public HL7V23Field TransfertoBadDebtDate
{
    get
    {
        if (transfertoBadDebtDate != null)
        {
            return transfertoBadDebtDate;
        }

        transfertoBadDebtDate = new HL7V23Field
        {
            field = message[@"PV1"][30],
            Id = @"PV1.30",
            Type = @"Field",
            Position = @"PV1.30",
            Name = @"Transfer to Bad Debt Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the account was transferred to a bad debt status",
            Sample = @"",
        };

        

        

        

        return transfertoBadDebtDate;
    } 
}
internal HL7V23Field badDebtAgencyCode;

public HL7V23Field BadDebtAgencyCode
{
    get
    {
        if (badDebtAgencyCode != null)
        {
            return badDebtAgencyCode;
        }

        badDebtAgencyCode = new HL7V23Field
        {
            field = message[@"PV1"][31],
            Id = @"PV1.31",
            Type = @"Field",
            Position = @"PV1.31",
            Name = @"Bad Debt Agency Code",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0021",
            TableName = @"Bad debt agency code",
            Description = @"This field can be used as an ST type for backward compatibility.  This field uniquely identifies the bad debt agency to which the account was transferred.  This code is site defined.  One possible implementation would be to edit against a table such as user-defined table 0021 - Bad debt agency code; however, this is not required",
            Sample = @"",
        };

        

        

        

        return badDebtAgencyCode;
    } 
}
internal HL7V23Field badDebtTransferAmount;

public HL7V23Field BadDebtTransferAmount
{
    get
    {
        if (badDebtTransferAmount != null)
        {
            return badDebtTransferAmount;
        }

        badDebtTransferAmount = new HL7V23Field
        {
            field = message[@"PV1"][32],
            Id = @"PV1.32",
            Type = @"Field",
            Position = @"PV1.32",
            Name = @"Bad Debt Transfer Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount that was transferred to a bad debt status",
            Sample = @"",
        };

        

        

        

        return badDebtTransferAmount;
    } 
}
internal HL7V23Field badDebtRecoveryAmount;

public HL7V23Field BadDebtRecoveryAmount
{
    get
    {
        if (badDebtRecoveryAmount != null)
        {
            return badDebtRecoveryAmount;
        }

        badDebtRecoveryAmount = new HL7V23Field
        {
            field = message[@"PV1"][33],
            Id = @"PV1.33",
            Type = @"Field",
            Position = @"PV1.33",
            Name = @"Bad Debt Recovery Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount recovered from the guarantor on the account",
            Sample = @"",
        };

        

        

        

        return badDebtRecoveryAmount;
    } 
}
internal HL7V23Field deleteAccountIndicator;

public HL7V23Field DeleteAccountIndicator
{
    get
    {
        if (deleteAccountIndicator != null)
        {
            return deleteAccountIndicator;
        }

        deleteAccountIndicator = new HL7V23Field
        {
            field = message[@"PV1"][34],
            Id = @"PV1.34",
            Type = @"Field",
            Position = @"PV1.34",
            Name = @"Delete Account Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0111",
            TableName = @"Delete account code",
            Description = @"This field indicates that the account was deleted from the file and gives the reason.  Refer to user-defined table 0111 - Delete account code for suggested values",
            Sample = @"",
        };

        

        

        

        return deleteAccountIndicator;
    } 
}
internal HL7V23Field deleteAccountDate;

public HL7V23Field DeleteAccountDate
{
    get
    {
        if (deleteAccountDate != null)
        {
            return deleteAccountDate;
        }

        deleteAccountDate = new HL7V23Field
        {
            field = message[@"PV1"][35],
            Id = @"PV1.35",
            Type = @"Field",
            Position = @"PV1.35",
            Name = @"Delete Account Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the account was deleted from the file",
            Sample = @"",
        };

        

        

        

        return deleteAccountDate;
    } 
}
internal HL7V23Field dischargeDisposition;

public HL7V23Field DischargeDisposition
{
    get
    {
        if (dischargeDisposition != null)
        {
            return dischargeDisposition;
        }

        dischargeDisposition = new HL7V23Field
        {
            field = message[@"PV1"][36],
            Id = @"PV1.36",
            Type = @"Field",
            Position = @"PV1.36",
            Name = @"Discharge Disposition",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0112",
            TableName = @"Discharge disposition",
            Description = @"This field contains the disposition of the patient at time of discharge (i.e., discharged to home, expired, etc.).  Refer to user-defined table 0112 - Discharged disposition for suggested values",
            Sample = @"",
        };

        

        

        

        return dischargeDisposition;
    } 
}
internal HL7V23Field dischargedtoLocation;

public HL7V23Field DischargedtoLocation
{
    get
    {
        if (dischargedtoLocation != null)
        {
            return dischargedtoLocation;
        }

        dischargedtoLocation = new HL7V23Field
        {
            field = message[@"PV1"][37],
            Id = @"PV1.37",
            Type = @"Field",
            Position = @"PV1.37",
            Name = @"Discharged to Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DLD",
            DataTypeName = @"Discharge Location",
            TableId = null,
            TableName = null,
            Description = @"This field indicates a facility to which the patient was discharged.  Refer to user-defined table 0113 - Discharged to location for suggested values",
            Sample = @"",
        };

        

        

        

        return dischargedtoLocation;
    } 
}
internal HL7V23Field dietType;

public HL7V23Field DietType
{
    get
    {
        if (dietType != null)
        {
            return dietType;
        }

        dietType = new HL7V23Field
        {
            field = message[@"PV1"][38],
            Id = @"PV1.38",
            Type = @"Field",
            Position = @"PV1.38",
            Name = @"Diet Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0114",
            TableName = @"Diet type",
            Description = @"This field indicates a special diet type for a patient.  Refer to user-defined table 0114 - Diet type for suggested values",
            Sample = @"",
        };

        

        

        

        return dietType;
    } 
}
internal HL7V23Field servicingFacility;

public HL7V23Field ServicingFacility
{
    get
    {
        if (servicingFacility != null)
        {
            return servicingFacility;
        }

        servicingFacility = new HL7V23Field
        {
            field = message[@"PV1"][39],
            Id = @"PV1.39",
            Type = @"Field",
            Position = @"PV1.39",
            Name = @"Servicing Facility",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0115",
            TableName = @"Servicing facility",
            Description = @"This field is used in a multiple facility environment to indicate the facility with which this visit is associated.  Refer to user-defined table 0115 - Servicing facility for suggested values. 
An optional fourth component, the facility ID, may be valued in each individual location field in PV1, instead of placing it here",
            Sample = @"",
        };

        

        

        

        return servicingFacility;
    } 
}
internal HL7V23Field bedStatus;

public HL7V23Field BedStatus
{
    get
    {
        if (bedStatus != null)
        {
            return bedStatus;
        }

        bedStatus = new HL7V23Field
        {
            field = message[@"PV1"][40],
            Id = @"PV1.40",
            Type = @"Field",
            Position = @"PV1.40",
            Name = @"Bed Status",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0116",
            TableName = @"Bed status",
            Description = @"This field has been retained for backward compatibility only.  This field contains the status of the bed.  Refer to user-defined table 0116 - Bed status for suggested values.
An optional fifth component, bed status, may be valued in each individual location field in PV1, instead of placing it here",
            Sample = @"",
        };

        

        

        

        return bedStatus;
    } 
}
internal HL7V23Field accountStatus;

public HL7V23Field AccountStatus
{
    get
    {
        if (accountStatus != null)
        {
            return accountStatus;
        }

        accountStatus = new HL7V23Field
        {
            field = message[@"PV1"][41],
            Id = @"PV1.41",
            Type = @"Field",
            Position = @"PV1.41",
            Name = @"Account Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0117",
            TableName = @"Account status",
            Description = @"This field contains the account status.  Refer to user-defined table 0117 - Account status for suggested values",
            Sample = @"",
        };

        

        

        

        return accountStatus;
    } 
}
internal HL7V23Field pendingLocation;

public HL7V23Field PendingLocation
{
    get
    {
        if (pendingLocation != null)
        {
            return pendingLocation;
        }

        pendingLocation = new HL7V23Field
        {
            field = message[@"PV1"][42],
            Id = @"PV1.42",
            Type = @"Field",
            Position = @"PV1.42",
            Name = @"Pending Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the point of care, room, bed, facility ID, and bed status to which the patient may be moved.  The first component may be the nursing station for inpatient locations, or the clinic, department, or home for locations other than inpatient.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
            Sample = @"",
        };

        

        

        

        return pendingLocation;
    } 
}
internal HL7V23Field priorTemporaryLocation;

public HL7V23Field PriorTemporaryLocation
{
    get
    {
        if (priorTemporaryLocation != null)
        {
            return priorTemporaryLocation;
        }

        priorTemporaryLocation = new HL7V23Field
        {
            field = message[@"PV1"][43],
            Id = @"PV1.43",
            Type = @"Field",
            Position = @"PV1.43",
            Name = @"Prior Temporary Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field is used to reflect the patient’s temporary location (such as the OR or X-RAY) prior to a transfer from a temporary location to an actual location, or from a temporary location to another temporary location. The first component may be the nursing station for inpatient locations, or the clinic, department, or home for locations other than inpatient.  If a value exists in the fifth component (bed status), it supersedes the value in PV1-40-bed status",
            Sample = @"",
        };

        

        

        

        return priorTemporaryLocation;
    } 
}
internal HL7V23Field admitDateTime;

public HL7V23Field AdmitDateTime
{
    get
    {
        if (admitDateTime != null)
        {
            return admitDateTime;
        }

        admitDateTime = new HL7V23Field
        {
            field = message[@"PV1"][44],
            Id = @"PV1.44",
            Type = @"Field",
            Position = @"PV1.44",
            Name = @"Admit Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the admit date/time.  It is to be used if the event date/time is different than the admit date and time, i.e., a retroactive update.  This field is also used to reflect the date/time of an outpatient/emergency patient registration",
            Sample = @"",
        };

        

        

        

        return admitDateTime;
    } 
}
internal HL7V23Field dischargeDateTime;

public HL7V23Field DischargeDateTime
{
    get
    {
        if (dischargeDateTime != null)
        {
            return dischargeDateTime;
        }

        dischargeDateTime = new HL7V23Field
        {
            field = message[@"PV1"][45],
            Id = @"PV1.45",
            Type = @"Field",
            Position = @"PV1.45",
            Name = @"Discharge Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the discharge date/time.  It is to be used if the event date/time is different than the discharge date and time, that is, a retroactive update.  This field is also used to reflect the date/time of an outpatient/emergency patient discharge",
            Sample = @"",
        };

        

        

        

        return dischargeDateTime;
    } 
}
internal HL7V23Field currentPatientBalance;

public HL7V23Field CurrentPatientBalance
{
    get
    {
        if (currentPatientBalance != null)
        {
            return currentPatientBalance;
        }

        currentPatientBalance = new HL7V23Field
        {
            field = message[@"PV1"][46],
            Id = @"PV1.46",
            Type = @"Field",
            Position = @"PV1.46",
            Name = @"Current Patient Balance",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the visit balance due",
            Sample = @"",
        };

        

        

        

        return currentPatientBalance;
    } 
}
internal HL7V23Field totalCharges;

public HL7V23Field TotalCharges
{
    get
    {
        if (totalCharges != null)
        {
            return totalCharges;
        }

        totalCharges = new HL7V23Field
        {
            field = message[@"PV1"][47],
            Id = @"PV1.47",
            Type = @"Field",
            Position = @"PV1.47",
            Name = @"Total Charges",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total visit charges",
            Sample = @"",
        };

        

        

        

        return totalCharges;
    } 
}
internal HL7V23Field totalAdjustments;

public HL7V23Field TotalAdjustments
{
    get
    {
        if (totalAdjustments != null)
        {
            return totalAdjustments;
        }

        totalAdjustments = new HL7V23Field
        {
            field = message[@"PV1"][48],
            Id = @"PV1.48",
            Type = @"Field",
            Position = @"PV1.48",
            Name = @"Total Adjustments",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total adjustments for visit",
            Sample = @"",
        };

        

        

        

        return totalAdjustments;
    } 
}
internal HL7V23Field totalPayments;

public HL7V23Field TotalPayments
{
    get
    {
        if (totalPayments != null)
        {
            return totalPayments;
        }

        totalPayments = new HL7V23Field
        {
            field = message[@"PV1"][49],
            Id = @"PV1.49",
            Type = @"Field",
            Position = @"PV1.49",
            Name = @"Total Payments",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total payments for visit",
            Sample = @"",
        };

        

        

        

        return totalPayments;
    } 
}
internal HL7V23Field alternateVisitID;

public HL7V23Field AlternateVisitID
{
    get
    {
        if (alternateVisitID != null)
        {
            return alternateVisitID;
        }

        alternateVisitID = new HL7V23Field
        {
            field = message[@"PV1"][50],
            Id = @"PV1.50",
            Type = @"Field",
            Position = @"PV1.50",
            Name = @"Alternate Visit ID",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the alternative, temporary, or pending optional visit ID number to be used if needed.  Refer to HL7 table 0061 - Check digit scheme for valid values.  Refer to user-defined table 0192 - Visit ID type for suggested values",
            Sample = @"",
        };

        

        

        

        return alternateVisitID;
    } 
}
internal HL7V23Field visitIndicator;

public HL7V23Field VisitIndicator
{
    get
    {
        if (visitIndicator != null)
        {
            return visitIndicator;
        }

        visitIndicator = new HL7V23Field
        {
            field = message[@"PV1"][51],
            Id = @"PV1.51",
            Type = @"Field",
            Position = @"PV1.51",
            Name = @"Visit Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0326",
            TableName = @"Visit indicator",
            Description = @"This field specifies the level on which data are being sent.  It is the indicator used to send data at two levels, visit and account.  HL7 recommends sending an ‘A’ or no value when the data in the message are at the account level, or ‘V’ to indicate that  the data sent in the message is at the visit level.  Refer to userdefined table 0326 - Visit indicator for suggested values",
            Sample = @"",
        };

        

        

        

        return visitIndicator;
    } 
}
internal HL7V23Field otherHealthcareProvider;

public HL7V23Field OtherHealthcareProvider
{
    get
    {
        if (otherHealthcareProvider != null)
        {
            return otherHealthcareProvider;
        }

        otherHealthcareProvider = new HL7V23Field
        {
            field = message[@"PV1"][52],
            Id = @"PV1.52",
            Type = @"Field",
            Position = @"PV1.52",
            Name = @"Other Healthcare Provider",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains the other healthcare providers (e.g., Nurse care practitioner, midwife, physician assistant).  Multiple healthcare providers can be sent.  Depending on local agreements, either the ID or the name may be absent from this field.  Use values in user-defined table 0010 - Physician ID for first component",
            Sample = @"",
        };

        

        

        

        return otherHealthcareProvider;
    } 
}

    }
}

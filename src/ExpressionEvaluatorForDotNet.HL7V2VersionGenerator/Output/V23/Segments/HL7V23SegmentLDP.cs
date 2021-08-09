using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentLDP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"LDP"; } }

        public string SegmentId { get { return @"LDP"; } }
        
        public string LongName { get { return @"Location Department"; } }
        
        public string Description { get { return @"The LDP segment identifies how a patient location room is being used by a certain department.  Multiple departments can use the same patient location, so there can be multiple LDP segments following an LOC segment.  There must be at least one LDP segment for each LOC segment.  This is not intended to include any current occupant information"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

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
                            Id = @"LDP.1",
                            Type = @"Field",
                            Position = @"LDP.1",
                            Name = @"LDP Primary Key Value",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institution’s identification code for the location.  The identifying key value.  This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here).  At least the first component of this field is required.  The contents of this field must exactly match the content of its preceding MFE (MFE-4-primary key value) and its preceding LOC (LOC-1-LOC primary key value).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.1.1",
                            Type = @"Component",
                            Position = @"LDP.1.1",
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
                            Id = @"LDP.1.2",
                            Type = @"Component",
                            Position = @"LDP.1.2",
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
                            Id = @"LDP.1.3",
                            Type = @"Component",
                            Position = @"LDP.1.3",
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
                            Id = @"LDP.1.4",
                            Type = @"Component",
                            Position = @"LDP.1.4",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.1.4.1",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.1",
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
                            Id = @"LDP.1.4.2",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.2",
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
                            Id = @"LDP.1.4.3",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.1.5",
                            Type = @"Component",
                            Position = @"LDP.1.5",
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
                            Id = @"LDP.1.6",
                            Type = @"Component",
                            Position = @"LDP.1.6",
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
                            Id = @"LDP.1.7",
                            Type = @"Component",
                            Position = @"LDP.1.7",
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
                            Id = @"LDP.1.8",
                            Type = @"Component",
                            Position = @"LDP.1.8",
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
                            Id = @"LDP.1.9",
                            Type = @"Component",
                            Position = @"LDP.1.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.2",
                            Type = @"Field",
                            Position = @"LDP.2",
                            Name = @"Location Department",
                            Length = 10,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0264",
                            TableName = @"Location department",
                            Description = @"This field contains the institution’s department to which this location belongs, or its cost center.  Refer to user-defined table 0264 - Location department for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.3",
                            Type = @"Field",
                            Position = @"LDP.3",
                            Name = @"Location Service",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0069",
                            TableName = @"Hospital service",
                            Description = @"This field contains the hospital or ancillary service with which this location is associated.  Depends on institution use.  Repeats for rooms that can be used, for example, by different services on different days.  These values should match the values used for PV1-10-hospital service, which is site defined.  Refer to user-defined table 0069 - Hospital service for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.4",
                            Type = @"Field",
                            Position = @"LDP.4",
                            Name = @"Speciality Type",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0265",
                            TableName = @"Specialty type",
                            Description = @"This field contains the specialty type (if any) of the department or clinic. This may also be considered a bed type.  Specialty type is a physical accommodation type, whereas ‘accommodation type’ (LOC-20-accommodation type) is a financial accommodation type.  Refer to user-defined table 0265 - Specialty type for suggested values.  See also LOC-33-privacy level and LOC-34-level of care.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.4.1",
                            Type = @"Component",
                            Position = @"LDP.4.1",
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
                            Id = @"LDP.4.2",
                            Type = @"Component",
                            Position = @"LDP.4.2",
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
                            Id = @"LDP.4.3",
                            Type = @"Component",
                            Position = @"LDP.4.3",
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
                            Id = @"LDP.4.4",
                            Type = @"Component",
                            Position = @"LDP.4.4",
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
                            Id = @"LDP.4.5",
                            Type = @"Component",
                            Position = @"LDP.4.5",
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
                            Id = @"LDP.4.6",
                            Type = @"Component",
                            Position = @"LDP.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.5",
                            Type = @"Field",
                            Position = @"LDP.5",
                            Name = @"Valid Patient Classes",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0004",
                            TableName = @"Patient class",
                            Description = @"This field contains the patient types that are allowed to be assigned to this bed.  For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc.  These values should be the same set of values as those used for PV1-2-patient class.  Refer to user-defined table 0004 - Patient class for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.6",
                            Type = @"Field",
                            Position = @"LDP.6",
                            Name = @"Active/Inactive Flag",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0183",
                            TableName = @"Active/Inactive",
                            Description = @"This field indicates whether the entry for this location is currently an active, that is, valid, usable entry (disregarding whether it’s waiting to be maintained by housekeeping).  Refer to HL7 table 0183 - Active/inactive for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.7",
                            Type = @"Field",
                            Position = @"LDP.7",
                            Name = @"Activation Date",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time when the location became active or “in service” for a department (disregarding whether it is waiting to be maintained by housekeeping).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.7.1",
                            Type = @"Component",
                            Position = @"LDP.7.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.8",
                            Type = @"Field",
                            Position = @"LDP.8",
                            Name = @"Inactivation Date - LDP",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date when the location became inactive or “out of service” for this department (disregarding whether it is waiting to be maintained by housekeeping). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.8.1",
                            Type = @"Component",
                            Position = @"LDP.8.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.9",
                            Type = @"Field",
                            Position = @"LDP.9",
                            Name = @"Inactivated Reason",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the reason the location was put out of service.  It is used when LDP-8inactivation date-LDP is sent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.10",
                            Type = @"Field",
                            Position = @"LDP.10",
                            Name = @"Visiting Hours",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"VH",
                            DataTypeName = @"Visiting Hours",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the hours when this location is open for visiting.  Refer to HL7 table 0267 - Days of the week for valid values for the first two components. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.10.1",
                            Type = @"Component",
                            Position = @"LDP.10.1",
                            Name = @"Start Day Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0267",
                            TableName = @"Days of the week",
                            Description = @"Starting day of visiting hours range.  See HL7 table 0267 - Days of the week for values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.10.2",
                            Type = @"Component",
                            Position = @"LDP.10.2",
                            Name = @"End Day Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0267",
                            TableName = @"Days of the week",
                            Description = @"Ending day of visiting hours range.  Starting day of visiting hours range.  See HL7 table 0267 - Days of the week for values ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.10.3",
                            Type = @"Component",
                            Position = @"LDP.10.3",
                            Name = @"Start Hour Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TM",
                            DataTypeName = @"Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Starting hour on starting day of visiting hours range (see first component, 2.8.44.1, “Start day range”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.10.4",
                            Type = @"Component",
                            Position = @"LDP.10.4",
                            Name = @"End Hour Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TM",
                            DataTypeName = @"Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Ending hour on ending day of visiting hours range (see second component, 2.8.44.2, “End day range”). ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.11",
                            Type = @"Field",
                            Position = @"LDP.11",
                            Name = @"Contact Phone",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the phone number to use to contact facility personnel about the patient location, in case of inquiries about the location.  This phone is not necessarily within the named patient location.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.11.1",
                            Type = @"Component",
                            Position = @"LDP.11.1",
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
                            Id = @"LDP.11.2",
                            Type = @"Component",
                            Position = @"LDP.11.2",
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
                            Id = @"LDP.11.3",
                            Type = @"Component",
                            Position = @"LDP.11.3",
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
                            Id = @"LDP.11.4",
                            Type = @"Component",
                            Position = @"LDP.11.4",
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
                            Id = @"LDP.11.5",
                            Type = @"Component",
                            Position = @"LDP.11.5",
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
                            Id = @"LDP.11.6",
                            Type = @"Component",
                            Position = @"LDP.11.6",
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
                            Id = @"LDP.11.7",
                            Type = @"Component",
                            Position = @"LDP.11.7",
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
                            Id = @"LDP.11.8",
                            Type = @"Component",
                            Position = @"LDP.11.8",
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
                            Id = @"LDP.11.9",
                            Type = @"Component",
                            Position = @"LDP.11.9",
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
                        },}
                        },
                        };
            }
        }

        public HL7V23SegmentLDP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field lDPPrimaryKeyValue;

public HL7V23Field LDPPrimaryKeyValue
{
    get
    {
        if (lDPPrimaryKeyValue != null)
        {
            return lDPPrimaryKeyValue;
        }

        lDPPrimaryKeyValue = new HL7V23Field
        {
            field = message[@"LDP"][1],
            Id = @"LDP.1",
            Type = @"Field",
            Position = @"LDP.1",
            Name = @"LDP Primary Key Value",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institution’s identification code for the location.  The identifying key value.  This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here).  At least the first component of this field is required.  The contents of this field must exactly match the content of its preceding MFE (MFE-4-primary key value) and its preceding LOC (LOC-1-LOC primary key value).",
            Sample = @"",
        };

        // check for repetitions
        if (lDPPrimaryKeyValue.field.FieldRepetitions != null && lDPPrimaryKeyValue.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(lDPPrimaryKeyValue.Id));
            lDPPrimaryKeyValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(lDPPrimaryKeyValue, fieldData);
        }

        return lDPPrimaryKeyValue;
    } 
}

internal HL7V23Field locationDepartment;

public HL7V23Field LocationDepartment
{
    get
    {
        if (locationDepartment != null)
        {
            return locationDepartment;
        }

        locationDepartment = new HL7V23Field
        {
            field = message[@"LDP"][2],
            Id = @"LDP.2",
            Type = @"Field",
            Position = @"LDP.2",
            Name = @"Location Department",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0264",
            TableName = @"Location department",
            Description = @"This field contains the institution’s department to which this location belongs, or its cost center.  Refer to user-defined table 0264 - Location department for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (locationDepartment.field.FieldRepetitions != null && locationDepartment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationDepartment.Id));
            locationDepartment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationDepartment, fieldData);
        }

        return locationDepartment;
    } 
}

internal HL7V23Field locationService;

public HL7V23Field LocationService
{
    get
    {
        if (locationService != null)
        {
            return locationService;
        }

        locationService = new HL7V23Field
        {
            field = message[@"LDP"][3],
            Id = @"LDP.3",
            Type = @"Field",
            Position = @"LDP.3",
            Name = @"Location Service",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0069",
            TableName = @"Hospital service",
            Description = @"This field contains the hospital or ancillary service with which this location is associated.  Depends on institution use.  Repeats for rooms that can be used, for example, by different services on different days.  These values should match the values used for PV1-10-hospital service, which is site defined.  Refer to user-defined table 0069 - Hospital service for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (locationService.field.FieldRepetitions != null && locationService.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationService.Id));
            locationService.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationService, fieldData);
        }

        return locationService;
    } 
}

internal HL7V23Field specialityType;

public HL7V23Field SpecialityType
{
    get
    {
        if (specialityType != null)
        {
            return specialityType;
        }

        specialityType = new HL7V23Field
        {
            field = message[@"LDP"][4],
            Id = @"LDP.4",
            Type = @"Field",
            Position = @"LDP.4",
            Name = @"Speciality Type",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0265",
            TableName = @"Specialty type",
            Description = @"This field contains the specialty type (if any) of the department or clinic. This may also be considered a bed type.  Specialty type is a physical accommodation type, whereas ‘accommodation type’ (LOC-20-accommodation type) is a financial accommodation type.  Refer to user-defined table 0265 - Specialty type for suggested values.  See also LOC-33-privacy level and LOC-34-level of care.",
            Sample = @"",
        };

        // check for repetitions
        if (specialityType.field.FieldRepetitions != null && specialityType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialityType.Id));
            specialityType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(specialityType, fieldData);
        }

        return specialityType;
    } 
}

internal HL7V23Field validPatientClasses;

public HL7V23Field ValidPatientClasses
{
    get
    {
        if (validPatientClasses != null)
        {
            return validPatientClasses;
        }

        validPatientClasses = new HL7V23Field
        {
            field = message[@"LDP"][5],
            Id = @"LDP.5",
            Type = @"Field",
            Position = @"LDP.5",
            Name = @"Valid Patient Classes",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0004",
            TableName = @"Patient class",
            Description = @"This field contains the patient types that are allowed to be assigned to this bed.  For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc.  These values should be the same set of values as those used for PV1-2-patient class.  Refer to user-defined table 0004 - Patient class for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (validPatientClasses.field.FieldRepetitions != null && validPatientClasses.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(validPatientClasses.Id));
            validPatientClasses.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(validPatientClasses, fieldData);
        }

        return validPatientClasses;
    } 
}

internal HL7V23Field activeInactiveFlag;

public HL7V23Field ActiveInactiveFlag
{
    get
    {
        if (activeInactiveFlag != null)
        {
            return activeInactiveFlag;
        }

        activeInactiveFlag = new HL7V23Field
        {
            field = message[@"LDP"][6],
            Id = @"LDP.6",
            Type = @"Field",
            Position = @"LDP.6",
            Name = @"Active/Inactive Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0183",
            TableName = @"Active/Inactive",
            Description = @"This field indicates whether the entry for this location is currently an active, that is, valid, usable entry (disregarding whether it’s waiting to be maintained by housekeeping).  Refer to HL7 table 0183 - Active/inactive for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (activeInactiveFlag.field.FieldRepetitions != null && activeInactiveFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activeInactiveFlag.Id));
            activeInactiveFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(activeInactiveFlag, fieldData);
        }

        return activeInactiveFlag;
    } 
}

internal HL7V23Field activationDate;

public HL7V23Field ActivationDate
{
    get
    {
        if (activationDate != null)
        {
            return activationDate;
        }

        activationDate = new HL7V23Field
        {
            field = message[@"LDP"][7],
            Id = @"LDP.7",
            Type = @"Field",
            Position = @"LDP.7",
            Name = @"Activation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time when the location became active or “in service” for a department (disregarding whether it is waiting to be maintained by housekeeping).",
            Sample = @"",
        };

        // check for repetitions
        if (activationDate.field.FieldRepetitions != null && activationDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activationDate.Id));
            activationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(activationDate, fieldData);
        }

        return activationDate;
    } 
}

internal HL7V23Field inactivationDateLDP;

public HL7V23Field InactivationDateLDP
{
    get
    {
        if (inactivationDateLDP != null)
        {
            return inactivationDateLDP;
        }

        inactivationDateLDP = new HL7V23Field
        {
            field = message[@"LDP"][8],
            Id = @"LDP.8",
            Type = @"Field",
            Position = @"LDP.8",
            Name = @"Inactivation Date - LDP",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date when the location became inactive or “out of service” for this department (disregarding whether it is waiting to be maintained by housekeeping). ",
            Sample = @"",
        };

        // check for repetitions
        if (inactivationDateLDP.field.FieldRepetitions != null && inactivationDateLDP.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inactivationDateLDP.Id));
            inactivationDateLDP.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(inactivationDateLDP, fieldData);
        }

        return inactivationDateLDP;
    } 
}

internal HL7V23Field inactivatedReason;

public HL7V23Field InactivatedReason
{
    get
    {
        if (inactivatedReason != null)
        {
            return inactivatedReason;
        }

        inactivatedReason = new HL7V23Field
        {
            field = message[@"LDP"][9],
            Id = @"LDP.9",
            Type = @"Field",
            Position = @"LDP.9",
            Name = @"Inactivated Reason",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reason the location was put out of service.  It is used when LDP-8inactivation date-LDP is sent. ",
            Sample = @"",
        };

        // check for repetitions
        if (inactivatedReason.field.FieldRepetitions != null && inactivatedReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inactivatedReason.Id));
            inactivatedReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(inactivatedReason, fieldData);
        }

        return inactivatedReason;
    } 
}

internal HL7V23Field visitingHours;

public HL7V23Field VisitingHours
{
    get
    {
        if (visitingHours != null)
        {
            return visitingHours;
        }

        visitingHours = new HL7V23Field
        {
            field = message[@"LDP"][10],
            Id = @"LDP.10",
            Type = @"Field",
            Position = @"LDP.10",
            Name = @"Visiting Hours",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"VH",
            DataTypeName = @"Visiting Hours",
            TableId = null,
            TableName = null,
            Description = @"This field contains the hours when this location is open for visiting.  Refer to HL7 table 0267 - Days of the week for valid values for the first two components. ",
            Sample = @"",
        };

        // check for repetitions
        if (visitingHours.field.FieldRepetitions != null && visitingHours.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(visitingHours.Id));
            visitingHours.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(visitingHours, fieldData);
        }

        return visitingHours;
    } 
}

internal HL7V23Field contactPhone;

public HL7V23Field ContactPhone
{
    get
    {
        if (contactPhone != null)
        {
            return contactPhone;
        }

        contactPhone = new HL7V23Field
        {
            field = message[@"LDP"][11],
            Id = @"LDP.11",
            Type = @"Field",
            Position = @"LDP.11",
            Name = @"Contact Phone",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number to use to contact facility personnel about the patient location, in case of inquiries about the location.  This phone is not necessarily within the named patient location.",
            Sample = @"",
        };

        // check for repetitions
        if (contactPhone.field.FieldRepetitions != null && contactPhone.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPhone.Id));
            contactPhone.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(contactPhone, fieldData);
        }

        return contactPhone;
    } 
}
    }
}

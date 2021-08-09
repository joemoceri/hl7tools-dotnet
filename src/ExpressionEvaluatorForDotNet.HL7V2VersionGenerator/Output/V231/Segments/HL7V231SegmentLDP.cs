using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentLDP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"LDP"; } }

        public string SegmentId { get { return @"LDP"; } }
        
        public string LongName { get { return @"Location department segment"; } }
        
        public string Description { get { return @"The LDP segment identifies how a patient location room is being used by a certain department. Multiple departments can use the same patient location, so there can be multiple LDP segments following an LOC segment. There must be at least one LDP segment for each LOC segment. This is not intended to include any current occupant information."; } }
        
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
                            Name = @"Primary Key Value - LDP",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institution's identification code for the location. The identifying key value. This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here). At least the first component of this field is required. The contents of this field must exactly match the content of its preceding MFE (MFE-4-primary key value-MFE) and its preceding LOC (LOC-1-primary key value-LOC).",
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
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic). After floor, most general patient location designation. User-defined table 0302 - Point of care is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Patient room. After nursing unit, most general person location designation. User-defined table 0303 - Room is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Patient bed. After room, most general person location designation. User-defined table 0304 - Bed is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Most general person location designation. (See Section 2.8.20, HD - hierarchic designator).",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LDP.1.4.1",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.1",
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
                            Id = @"LDP.1.4.2",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.2",
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
                            Id = @"LDP.1.4.3",
                            Type = @"SubComponent",
                            Position = @"LDP.1.4.3",
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
                            Description = @"Location (e.g., Bed) status. User-defined table 0306 - Location status is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physicians office. User-defined table 0305 - Person location type is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"After facility, most general person location designation. User-defined table 0307 - Building is used as the HL7 identifier for the user-defined table of values for this component.",
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
                            Description = @"After building, most general person location designation. User-defined table 0308 - Floor is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.1.9",
                            Type = @"Component",
                            Position = @"LDP.1.9",
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
                            Description = @"This field contains the institution's department to which this location belongs, or its cost center. User-defined table 0264 - Location department is used as the HL7 identifier for the User-defined table of values for this field.",
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
                            Description = @"This field contains the hospital or ancillary service with which this location is associated. Depends on institution use. Repeats for rooms that can be used, for example, by different services on different days. These values should match the values used for PV1-10-hospital service , which is site defined. User-defined table 0069 - Hospital service is used as the HL7 identifier for the user-defined table of values for this field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.4",
                            Type = @"Field",
                            Position = @"LDP.4",
                            Name = @"Specialty Type",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0265",
                            TableName = @"Specialty type",
                            Description = @"This field contains the specialty type (if any) of the department or clinic. This may also be considered a bed type. Specialty type is a physical accommodation type, whereas accommodation type' ( LCC-3-accommodation type ) is a financial accommodation type. Refer to user-defined table 0265 - Specialty type for suggested values. See also LCH-4-location characteristic ID and LHC-5-Location Characteristic Value.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.4.4",
                            Type = @"Component",
                            Position = @"LDP.4.4",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"This field contains the patient types that are allowed to be assigned to this bed. For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc. These values should be the same set of values as those used for PV1-2-patient class. Refer to user-defined table 0004 - Patient class for suggested values.",
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
                            Description = @"This field indicates whether the entry for this location is currently an active, that is, valid, usable entry (disregarding whether it's waiting to be maintained by housekeeping). Refer to HL7 table 0183 - Active/inactive for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.7",
                            Type = @"Field",
                            Position = @"LDP.7",
                            Name = @"Activation Date  LDP",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time when the location became active or 'in service' for a department (disregarding whether it is waiting to be maintained by housekeeping).",
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
                            Description = @"This field contains the date when the location became inactive or 'out of service' for this department (disregarding whether it is waiting to be maintained by housekeeping).",
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
                            Description = @"This field contains the reason the location was put out of service. It is used when LDP-8-inactivation date-LDP is sent.",
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
                            Description = @"This field contains the hours when this location is open for visiting. Refer to HL7 table 0267 - Days of the week for valid values for the first two components.",
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
                            Description = @"Starting day of visiting hours range. See HL7 table 0267 - Days of the week for valid values.",
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
                            Description = @"Ending day of visiting hours range. Starting day of visiting hours range. See HL7 table 0267 - Days of the week for valid values",
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
                            Description = @"Starting hour on starting day of visiting hours range (see first component, 2.8.46.0, Start day range).",
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
                            Description = @"Ending hour on ending day of visiting hours range (see second component, 2.8.46.2, End day range).",
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
                            Description = @"This field contains the phone number to use to contact facility personnel about the patient location, in case of inquiries about the location. This phone is not necessarily within the named patient location.",
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
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LDP.11.2",
                            Type = @"Component",
                            Position = @"LDP.11.2",
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
                            Id = @"LDP.11.3",
                            Type = @"Component",
                            Position = @"LDP.11.3",
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
                            Description = null,
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

        public HL7V231SegmentLDP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field primaryKeyValueLDP;

public HL7V231Field PrimaryKeyValueLDP
{
    get
    {
        if (primaryKeyValueLDP != null)
        {
            return primaryKeyValueLDP;
        }

        primaryKeyValueLDP = new HL7V231Field
        {
            field = message[@"LDP"][1],
            Id = @"LDP.1",
            Type = @"Field",
            Position = @"LDP.1",
            Name = @"Primary Key Value - LDP",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institution's identification code for the location. The identifying key value. This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here). At least the first component of this field is required. The contents of this field must exactly match the content of its preceding MFE (MFE-4-primary key value-MFE) and its preceding LOC (LOC-1-primary key value-LOC).",
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValueLDP.field.FieldRepetitions != null && primaryKeyValueLDP.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValueLDP.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < primaryKeyValueLDP.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = primaryKeyValueLDP.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryKeyValueLDP.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = primaryKeyValueLDP.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < primaryKeyValueLDP.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = primaryKeyValueLDP.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            primaryKeyValueLDP.fieldRepetitions = fieldRepetitions;
        }

        return primaryKeyValueLDP;
    } 
}

internal HL7V231Field locationDepartment;

public HL7V231Field LocationDepartment
{
    get
    {
        if (locationDepartment != null)
        {
            return locationDepartment;
        }

        locationDepartment = new HL7V231Field
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
            Description = @"This field contains the institution's department to which this location belongs, or its cost center. User-defined table 0264 - Location department is used as the HL7 identifier for the User-defined table of values for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (locationDepartment.field.FieldRepetitions != null && locationDepartment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationDepartment.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < locationDepartment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = locationDepartment.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < locationDepartment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = locationDepartment.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < locationDepartment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = locationDepartment.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            locationDepartment.fieldRepetitions = fieldRepetitions;
        }

        return locationDepartment;
    } 
}

internal HL7V231Field locationService;

public HL7V231Field LocationService
{
    get
    {
        if (locationService != null)
        {
            return locationService;
        }

        locationService = new HL7V231Field
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
            Description = @"This field contains the hospital or ancillary service with which this location is associated. Depends on institution use. Repeats for rooms that can be used, for example, by different services on different days. These values should match the values used for PV1-10-hospital service , which is site defined. User-defined table 0069 - Hospital service is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (locationService.field.FieldRepetitions != null && locationService.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationService.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < locationService.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = locationService.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < locationService.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = locationService.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < locationService.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = locationService.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            locationService.fieldRepetitions = fieldRepetitions;
        }

        return locationService;
    } 
}

internal HL7V231Field specialtyType;

public HL7V231Field SpecialtyType
{
    get
    {
        if (specialtyType != null)
        {
            return specialtyType;
        }

        specialtyType = new HL7V231Field
        {
            field = message[@"LDP"][4],
            Id = @"LDP.4",
            Type = @"Field",
            Position = @"LDP.4",
            Name = @"Specialty Type",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0265",
            TableName = @"Specialty type",
            Description = @"This field contains the specialty type (if any) of the department or clinic. This may also be considered a bed type. Specialty type is a physical accommodation type, whereas accommodation type' ( LCC-3-accommodation type ) is a financial accommodation type. Refer to user-defined table 0265 - Specialty type for suggested values. See also LCH-4-location characteristic ID and LHC-5-Location Characteristic Value.",
            Sample = @"",
        };

        // check for repetitions
        if (specialtyType.field.FieldRepetitions != null && specialtyType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specialtyType.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < specialtyType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = specialtyType.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < specialtyType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = specialtyType.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < specialtyType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = specialtyType.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            specialtyType.fieldRepetitions = fieldRepetitions;
        }

        return specialtyType;
    } 
}

internal HL7V231Field validPatientClasses;

public HL7V231Field ValidPatientClasses
{
    get
    {
        if (validPatientClasses != null)
        {
            return validPatientClasses;
        }

        validPatientClasses = new HL7V231Field
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
            Description = @"This field contains the patient types that are allowed to be assigned to this bed. For example, Inpatient, Outpatient, Series, Clinic, ER, Ambulatory, Observation, etc. These values should be the same set of values as those used for PV1-2-patient class. Refer to user-defined table 0004 - Patient class for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (validPatientClasses.field.FieldRepetitions != null && validPatientClasses.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(validPatientClasses.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < validPatientClasses.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = validPatientClasses.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < validPatientClasses.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = validPatientClasses.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < validPatientClasses.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = validPatientClasses.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            validPatientClasses.fieldRepetitions = fieldRepetitions;
        }

        return validPatientClasses;
    } 
}

internal HL7V231Field activeInactiveFlag;

public HL7V231Field ActiveInactiveFlag
{
    get
    {
        if (activeInactiveFlag != null)
        {
            return activeInactiveFlag;
        }

        activeInactiveFlag = new HL7V231Field
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
            Description = @"This field indicates whether the entry for this location is currently an active, that is, valid, usable entry (disregarding whether it's waiting to be maintained by housekeeping). Refer to HL7 table 0183 - Active/inactive for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (activeInactiveFlag.field.FieldRepetitions != null && activeInactiveFlag.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activeInactiveFlag.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < activeInactiveFlag.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = activeInactiveFlag.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < activeInactiveFlag.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = activeInactiveFlag.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < activeInactiveFlag.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = activeInactiveFlag.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            activeInactiveFlag.fieldRepetitions = fieldRepetitions;
        }

        return activeInactiveFlag;
    } 
}

internal HL7V231Field activationDateLDP;

public HL7V231Field ActivationDateLDP
{
    get
    {
        if (activationDateLDP != null)
        {
            return activationDateLDP;
        }

        activationDateLDP = new HL7V231Field
        {
            field = message[@"LDP"][7],
            Id = @"LDP.7",
            Type = @"Field",
            Position = @"LDP.7",
            Name = @"Activation Date  LDP",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time when the location became active or 'in service' for a department (disregarding whether it is waiting to be maintained by housekeeping).",
            Sample = @"",
        };

        // check for repetitions
        if (activationDateLDP.field.FieldRepetitions != null && activationDateLDP.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(activationDateLDP.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < activationDateLDP.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = activationDateLDP.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < activationDateLDP.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = activationDateLDP.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < activationDateLDP.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = activationDateLDP.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            activationDateLDP.fieldRepetitions = fieldRepetitions;
        }

        return activationDateLDP;
    } 
}

internal HL7V231Field inactivationDateLDP;

public HL7V231Field InactivationDateLDP
{
    get
    {
        if (inactivationDateLDP != null)
        {
            return inactivationDateLDP;
        }

        inactivationDateLDP = new HL7V231Field
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
            Description = @"This field contains the date when the location became inactive or 'out of service' for this department (disregarding whether it is waiting to be maintained by housekeeping).",
            Sample = @"",
        };

        // check for repetitions
        if (inactivationDateLDP.field.FieldRepetitions != null && inactivationDateLDP.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inactivationDateLDP.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < inactivationDateLDP.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = inactivationDateLDP.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inactivationDateLDP.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = inactivationDateLDP.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < inactivationDateLDP.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = inactivationDateLDP.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            inactivationDateLDP.fieldRepetitions = fieldRepetitions;
        }

        return inactivationDateLDP;
    } 
}

internal HL7V231Field inactivatedReason;

public HL7V231Field InactivatedReason
{
    get
    {
        if (inactivatedReason != null)
        {
            return inactivatedReason;
        }

        inactivatedReason = new HL7V231Field
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
            Description = @"This field contains the reason the location was put out of service. It is used when LDP-8-inactivation date-LDP is sent.",
            Sample = @"",
        };

        // check for repetitions
        if (inactivatedReason.field.FieldRepetitions != null && inactivatedReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(inactivatedReason.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < inactivatedReason.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = inactivatedReason.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < inactivatedReason.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = inactivatedReason.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < inactivatedReason.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = inactivatedReason.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            inactivatedReason.fieldRepetitions = fieldRepetitions;
        }

        return inactivatedReason;
    } 
}

internal HL7V231Field visitingHours;

public HL7V231Field VisitingHours
{
    get
    {
        if (visitingHours != null)
        {
            return visitingHours;
        }

        visitingHours = new HL7V231Field
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
            Description = @"This field contains the hours when this location is open for visiting. Refer to HL7 table 0267 - Days of the week for valid values for the first two components.",
            Sample = @"",
        };

        // check for repetitions
        if (visitingHours.field.FieldRepetitions != null && visitingHours.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(visitingHours.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < visitingHours.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = visitingHours.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < visitingHours.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = visitingHours.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < visitingHours.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = visitingHours.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            visitingHours.fieldRepetitions = fieldRepetitions;
        }

        return visitingHours;
    } 
}

internal HL7V231Field contactPhone;

public HL7V231Field ContactPhone
{
    get
    {
        if (contactPhone != null)
        {
            return contactPhone;
        }

        contactPhone = new HL7V231Field
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
            Description = @"This field contains the phone number to use to contact facility personnel about the patient location, in case of inquiries about the location. This phone is not necessarily within the named patient location.",
            Sample = @"",
        };

        // check for repetitions
        if (contactPhone.field.FieldRepetitions != null && contactPhone.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(contactPhone.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < contactPhone.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = contactPhone.field.FieldRepetitions[i],
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
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < contactPhone.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = contactPhone.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < contactPhone.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = contactPhone.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            contactPhone.fieldRepetitions = fieldRepetitions;
        }

        return contactPhone;
    } 
}
    }
}

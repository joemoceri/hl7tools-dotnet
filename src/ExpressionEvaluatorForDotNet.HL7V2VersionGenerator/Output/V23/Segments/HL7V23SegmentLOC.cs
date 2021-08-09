using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentLOC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"LOC"; } }

        public string SegmentId { get { return @"LOC"; } }
        
        public string LongName { get { return @"Location Identification"; } }
        
        public string Description { get { return @"The LOC segment can identify any patient location referenced by information systems.  This segment gives physical set up information about the location.  This is not intended to include any current occupant or current use information.  There should be one LOC segment for each patient location.  If desired, there can also be one LOC segment for each nursing unit and room."; } }
        
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
                            Id = @"LOC.1",
                            Type = @"Field",
                            Position = @"LOC.1",
                            Name = @"Primary Key Value",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the institution’s identification code for the location.  The identifying key value.   Must match MFE-4-primary key value.  This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here).   
At least the first component of this field is required.  The first component can be an identifying code for the nursing station for inpatient locations, or clinic, department or home for patient locations other than inpatient ones. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.1.1",
                            Type = @"Component",
                            Position = @"LOC.1.1",
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
                            Id = @"LOC.1.2",
                            Type = @"Component",
                            Position = @"LOC.1.2",
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
                            Id = @"LOC.1.3",
                            Type = @"Component",
                            Position = @"LOC.1.3",
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
                            Id = @"LOC.1.4",
                            Type = @"Component",
                            Position = @"LOC.1.4",
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
                            Id = @"LOC.1.4.1",
                            Type = @"SubComponent",
                            Position = @"LOC.1.4.1",
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
                            Id = @"LOC.1.4.2",
                            Type = @"SubComponent",
                            Position = @"LOC.1.4.2",
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
                            Id = @"LOC.1.4.3",
                            Type = @"SubComponent",
                            Position = @"LOC.1.4.3",
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
                            Id = @"LOC.1.5",
                            Type = @"Component",
                            Position = @"LOC.1.5",
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
                            Id = @"LOC.1.6",
                            Type = @"Component",
                            Position = @"LOC.1.6",
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
                            Id = @"LOC.1.7",
                            Type = @"Component",
                            Position = @"LOC.1.7",
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
                            Id = @"LOC.1.8",
                            Type = @"Component",
                            Position = @"LOC.1.8",
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
                            Id = @"LOC.1.9",
                            Type = @"Component",
                            Position = @"LOC.1.9",
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
                            Id = @"LOC.2",
                            Type = @"Field",
                            Position = @"LOC.2",
                            Name = @"Location Description",
                            Length = 48,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the optional free text description of the location, to elaborate upon LOC primary key value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LOC.3",
                            Type = @"Field",
                            Position = @"LOC.3",
                            Name = @"Location Type",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0260",
                            TableName = @"Patient location type",
                            Description = @"This field contains the code identifying what type of location this is.  Refer to user-defined table 0260 - Patient location type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LOC.4",
                            Type = @"Field",
                            Position = @"LOC.4",
                            Name = @"Organization Name",
                            Length = 90,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And ID For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the organization of which this location is a part.  For inpatient locations, this can be the hospital or institution name.  For outpatient locations, this can be the clinic or office name",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.4.1",
                            Type = @"Component",
                            Position = @"LOC.4.1",
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
                            Id = @"LOC.4.2",
                            Type = @"Component",
                            Position = @"LOC.4.2",
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
                            Id = @"LOC.4.3",
                            Type = @"Component",
                            Position = @"LOC.4.3",
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
                            Id = @"LOC.4.4",
                            Type = @"Component",
                            Position = @"LOC.4.4",
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
                            Id = @"LOC.4.5",
                            Type = @"Component",
                            Position = @"LOC.4.5",
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
                            Id = @"LOC.4.6",
                            Type = @"Component",
                            Position = @"LOC.4.6",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.4.6.1",
                            Type = @"SubComponent",
                            Position = @"LOC.4.6.1",
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
                            Id = @"LOC.4.6.2",
                            Type = @"SubComponent",
                            Position = @"LOC.4.6.2",
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
                            Id = @"LOC.4.6.3",
                            Type = @"SubComponent",
                            Position = @"LOC.4.6.3",
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
                            Id = @"LOC.4.7",
                            Type = @"Component",
                            Position = @"LOC.4.7",
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
                            Id = @"LOC.4.8",
                            Type = @"Component",
                            Position = @"LOC.4.8",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.4.8.1",
                            Type = @"SubComponent",
                            Position = @"LOC.4.8.1",
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
                            Id = @"LOC.4.8.2",
                            Type = @"SubComponent",
                            Position = @"LOC.4.8.2",
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
                            Id = @"LOC.4.8.3",
                            Type = @"SubComponent",
                            Position = @"LOC.4.8.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LOC.5",
                            Type = @"Field",
                            Position = @"LOC.5",
                            Name = @"Location Address",
                            Length = 106,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"XAD",
                            DataTypeName = @"Extended Address",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the address of the patient location, especially for use for outpatient clinic or office locations",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.5.1",
                            Type = @"Component",
                            Position = @"LOC.5.1",
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
                            Id = @"LOC.5.2",
                            Type = @"Component",
                            Position = @"LOC.5.2",
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
                            Id = @"LOC.5.3",
                            Type = @"Component",
                            Position = @"LOC.5.3",
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
                            Id = @"LOC.5.4",
                            Type = @"Component",
                            Position = @"LOC.5.4",
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
                            Id = @"LOC.5.5",
                            Type = @"Component",
                            Position = @"LOC.5.5",
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
                            Id = @"LOC.5.6",
                            Type = @"Component",
                            Position = @"LOC.5.6",
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
                            Id = @"LOC.5.7",
                            Type = @"Component",
                            Position = @"LOC.5.7",
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
                            Id = @"LOC.5.8",
                            Type = @"Component",
                            Position = @"LOC.5.8",
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
                            Id = @"LOC.5.9",
                            Type = @"Component",
                            Position = @"LOC.5.9",
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
                            Id = @"LOC.5.10",
                            Type = @"Component",
                            Position = @"LOC.5.10",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LOC.6",
                            Type = @"Field",
                            Position = @"LOC.6",
                            Name = @"Location Phone",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"XTN",
                            DataTypeName = @"Extended Telecommunication Number",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the phone number within the patient location, if any.  For example, the room or bed phone for use by the patient",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.6.1",
                            Type = @"Component",
                            Position = @"LOC.6.1",
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
                            Id = @"LOC.6.2",
                            Type = @"Component",
                            Position = @"LOC.6.2",
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
                            Id = @"LOC.6.3",
                            Type = @"Component",
                            Position = @"LOC.6.3",
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
                            Id = @"LOC.6.4",
                            Type = @"Component",
                            Position = @"LOC.6.4",
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
                            Id = @"LOC.6.5",
                            Type = @"Component",
                            Position = @"LOC.6.5",
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
                            Id = @"LOC.6.6",
                            Type = @"Component",
                            Position = @"LOC.6.6",
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
                            Id = @"LOC.6.7",
                            Type = @"Component",
                            Position = @"LOC.6.7",
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
                            Id = @"LOC.6.8",
                            Type = @"Component",
                            Position = @"LOC.6.8",
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
                            Id = @"LOC.6.9",
                            Type = @"Component",
                            Position = @"LOC.6.9",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"LOC.7",
                            Type = @"Field",
                            Position = @"LOC.7",
                            Name = @"License Number",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the multiple license numbers for the facility",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"LOC.7.1",
                            Type = @"Component",
                            Position = @"LOC.7.1",
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
                            Id = @"LOC.7.2",
                            Type = @"Component",
                            Position = @"LOC.7.2",
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
                            Id = @"LOC.7.3",
                            Type = @"Component",
                            Position = @"LOC.7.3",
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
                            Id = @"LOC.7.4",
                            Type = @"Component",
                            Position = @"LOC.7.4",
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
                            Id = @"LOC.7.5",
                            Type = @"Component",
                            Position = @"LOC.7.5",
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
                            Id = @"LOC.7.6",
                            Type = @"Component",
                            Position = @"LOC.7.6",
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
                            Id = @"LOC.8",
                            Type = @"Field",
                            Position = @"LOC.8",
                            Name = @"Location Equipment",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0261",
                            TableName = @"Location equipment",
                            Description = @"This repeating field indicates what types of equipment are built in.  Applies only to room or bed locations.  If LOC-3-location type indicates that this is a room, this will be the equipment in the room which can be used by more than one bed.  If LOC-3-location type indicates this is a bed, this will be the bedside devices available to this bed.  Refer to user-defined table 0261 - Location equipment for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentLOC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field primaryKeyValue;

public HL7V23Field PrimaryKeyValue
{
    get
    {
        if (primaryKeyValue != null)
        {
            return primaryKeyValue;
        }

        primaryKeyValue = new HL7V23Field
        {
            field = message[@"LOC"][1],
            Id = @"LOC.1",
            Type = @"Field",
            Position = @"LOC.1",
            Name = @"Primary Key Value",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the institution’s identification code for the location.  The identifying key value.   Must match MFE-4-primary key value.  This field has the same components as the patient location fields in the PV1 segment (except that bed status is not included here).   
At least the first component of this field is required.  The first component can be an identifying code for the nursing station for inpatient locations, or clinic, department or home for patient locations other than inpatient ones. ",
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValue.field.FieldRepetitions != null && primaryKeyValue.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValue.Id));
            primaryKeyValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(primaryKeyValue, fieldData);
        }

        return primaryKeyValue;
    } 
}

internal HL7V23Field locationDescription;

public HL7V23Field LocationDescription
{
    get
    {
        if (locationDescription != null)
        {
            return locationDescription;
        }

        locationDescription = new HL7V23Field
        {
            field = message[@"LOC"][2],
            Id = @"LOC.2",
            Type = @"Field",
            Position = @"LOC.2",
            Name = @"Location Description",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the optional free text description of the location, to elaborate upon LOC primary key value",
            Sample = @"",
        };

        // check for repetitions
        if (locationDescription.field.FieldRepetitions != null && locationDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationDescription.Id));
            locationDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationDescription, fieldData);
        }

        return locationDescription;
    } 
}

internal HL7V23Field locationType;

public HL7V23Field LocationType
{
    get
    {
        if (locationType != null)
        {
            return locationType;
        }

        locationType = new HL7V23Field
        {
            field = message[@"LOC"][3],
            Id = @"LOC.3",
            Type = @"Field",
            Position = @"LOC.3",
            Name = @"Location Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0260",
            TableName = @"Patient location type",
            Description = @"This field contains the code identifying what type of location this is.  Refer to user-defined table 0260 - Patient location type for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (locationType.field.FieldRepetitions != null && locationType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationType.Id));
            locationType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationType, fieldData);
        }

        return locationType;
    } 
}

internal HL7V23Field organizationName;

public HL7V23Field OrganizationName
{
    get
    {
        if (organizationName != null)
        {
            return organizationName;
        }

        organizationName = new HL7V23Field
        {
            field = message[@"LOC"][4],
            Id = @"LOC.4",
            Type = @"Field",
            Position = @"LOC.4",
            Name = @"Organization Name",
            Length = 90,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the organization of which this location is a part.  For inpatient locations, this can be the hospital or institution name.  For outpatient locations, this can be the clinic or office name",
            Sample = @"",
        };

        // check for repetitions
        if (organizationName.field.FieldRepetitions != null && organizationName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organizationName.Id));
            organizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(organizationName, fieldData);
        }

        return organizationName;
    } 
}

internal HL7V23Field locationAddress;

public HL7V23Field LocationAddress
{
    get
    {
        if (locationAddress != null)
        {
            return locationAddress;
        }

        locationAddress = new HL7V23Field
        {
            field = message[@"LOC"][5],
            Id = @"LOC.5",
            Type = @"Field",
            Position = @"LOC.5",
            Name = @"Location Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of the patient location, especially for use for outpatient clinic or office locations",
            Sample = @"",
        };

        // check for repetitions
        if (locationAddress.field.FieldRepetitions != null && locationAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationAddress.Id));
            locationAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationAddress, fieldData);
        }

        return locationAddress;
    } 
}

internal HL7V23Field locationPhone;

public HL7V23Field LocationPhone
{
    get
    {
        if (locationPhone != null)
        {
            return locationPhone;
        }

        locationPhone = new HL7V23Field
        {
            field = message[@"LOC"][6],
            Id = @"LOC.6",
            Type = @"Field",
            Position = @"LOC.6",
            Name = @"Location Phone",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number within the patient location, if any.  For example, the room or bed phone for use by the patient",
            Sample = @"",
        };

        // check for repetitions
        if (locationPhone.field.FieldRepetitions != null && locationPhone.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationPhone.Id));
            locationPhone.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationPhone, fieldData);
        }

        return locationPhone;
    } 
}

internal HL7V23Field licenseNumber;

public HL7V23Field LicenseNumber
{
    get
    {
        if (licenseNumber != null)
        {
            return licenseNumber;
        }

        licenseNumber = new HL7V23Field
        {
            field = message[@"LOC"][7],
            Id = @"LOC.7",
            Type = @"Field",
            Position = @"LOC.7",
            Name = @"License Number",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the multiple license numbers for the facility",
            Sample = @"",
        };

        // check for repetitions
        if (licenseNumber.field.FieldRepetitions != null && licenseNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(licenseNumber.Id));
            licenseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(licenseNumber, fieldData);
        }

        return licenseNumber;
    } 
}

internal HL7V23Field locationEquipment;

public HL7V23Field LocationEquipment
{
    get
    {
        if (locationEquipment != null)
        {
            return locationEquipment;
        }

        locationEquipment = new HL7V23Field
        {
            field = message[@"LOC"][8],
            Id = @"LOC.8",
            Type = @"Field",
            Position = @"LOC.8",
            Name = @"Location Equipment",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0261",
            TableName = @"Location equipment",
            Description = @"This repeating field indicates what types of equipment are built in.  Applies only to room or bed locations.  If LOC-3-location type indicates that this is a room, this will be the equipment in the room which can be used by more than one bed.  If LOC-3-location type indicates this is a bed, this will be the bedside devices available to this bed.  Refer to user-defined table 0261 - Location equipment for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (locationEquipment.field.FieldRepetitions != null && locationEquipment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationEquipment.Id));
            locationEquipment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(locationEquipment, fieldData);
        }

        return locationEquipment;
    } 
}
    }
}

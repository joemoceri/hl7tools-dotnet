using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentAIS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"AIS"; } }

        public string SegmentId { get { return @"AIS"; } }
        
        public string LongName { get { return @"Appointment Information"; } }
        
        public string Description { get { return @"The AIS segment contains information about various kinds of services that can be scheduled. Services included in a transaction using this segment are assumed to be controlled by a schedule on a schedule filler application. Services not controlled by a schedule are not identified on a schedule request using this segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Id = @"AIS.1",
                            Type = @"Field",
                            Position = @"AIS.1",
                            Name = @"Set ID - AIS",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.2",
                            Type = @"Field",
                            Position = @"AIS.2",
                            Name = @"Segment Action Code",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0206",
                            TableName = @"Segment action code",
                            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3",
                            Type = @"Field",
                            Position = @"AIS.3",
                            Name = @"Universal Service Identifier",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifier code for a service to be scheduled. This field may contain a universal service identifier describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the universal service identifier defined for the OBR segment. This code can be based on local and/or universal codes. The use of universal codes is recommended.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.1",
                            Type = @"Component",
                            Position = @"AIS.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.2",
                            Type = @"Component",
                            Position = @"AIS.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.3",
                            Type = @"Component",
                            Position = @"AIS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.4",
                            Type = @"Component",
                            Position = @"AIS.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.5",
                            Type = @"Component",
                            Position = @"AIS.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.6",
                            Type = @"Component",
                            Position = @"AIS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.4",
                            Type = @"Field",
                            Position = @"AIS.4",
                            Name = @"Start Date/Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.4.1",
                            Type = @"Component",
                            Position = @"AIS.4.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.4.2",
                            Type = @"Component",
                            Position = @"AIS.4.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.5",
                            Type = @"Field",
                            Position = @"AIS.5",
                            Name = @"Start Date/Time Offset",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time. The first component contains the offset amount. An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment.

A positive offset (an unsigned or positive number) indicates that the service is required after the appointment's start date/time.  Specifying a negative offset indicates that the service is required prior to the specified start date/time of the appointment.  Negative offsets are allowed, and sites should clearly define the effect of a negative offset on the appointment's start date/time. 

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6",
                            Type = @"Field",
                            Position = @"AIS.6",
                            Name = @"Start Date/Time Offset Units",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code s) will be assumed.

This field is conditionally required.  If a value for AIS-5-Start date/time offset is provided, then a value is required for this field. ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.1",
                            Type = @"Component",
                            Position = @"AIS.6.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.2",
                            Type = @"Component",
                            Position = @"AIS.6.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.3",
                            Type = @"Component",
                            Position = @"AIS.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.4",
                            Type = @"Component",
                            Position = @"AIS.6.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.5",
                            Type = @"Component",
                            Position = @"AIS.6.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.6",
                            Type = @"Component",
                            Position = @"AIS.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.7",
                            Type = @"Field",
                            Position = @"AIS.7",
                            Name = @"Duration",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if different from the overall duration of the requested/scheduled appointment. This field indicates to the application that a resource is required for a different amount of time than the appointment's overall duration. An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment. If no start date/time offset is specified, then the resource is required for the full duration of the appointment.

This field must be a positive, non-zero number.  A negative number or zero (0) is nonsensical in the context of a duration.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8",
                            Type = @"Field",
                            Position = @"AIS.8",
                            Name = @"Duration Units",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing the duration. If this field is not valued, the ISO base unit of seconds (code s) will be assumed",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.1",
                            Type = @"Component",
                            Position = @"AIS.8.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.2",
                            Type = @"Component",
                            Position = @"AIS.8.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.3",
                            Type = @"Component",
                            Position = @"AIS.8.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.4",
                            Type = @"Component",
                            Position = @"AIS.8.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.5",
                            Type = @"Component",
                            Position = @"AIS.8.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.6",
                            Type = @"Component",
                            Position = @"AIS.8.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.9",
                            Type = @"Field",
                            Position = @"AIS.9",
                            Name = @"Allow Substitution Code",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0279",
                            TableName = @"Allow Substitution Codes",
                            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to User-Defined Table 0279 - Allow Substitution Codes For suggested codes.

This field is conditionally required.  It is required for all request messages.  It is optional for all unsolicited transactions, and for all query messages",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10",
                            Type = @"Field",
                            Position = @"AIS.10",
                            Name = @"Filler Status Code",
                            Length = 250,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0278",
                            TableName = @"Filler status codes",
                            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application. Refer to User-Defined Table 0278 - Filler Status Codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.1",
                            Type = @"Component",
                            Position = @"AIS.10.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.2",
                            Type = @"Component",
                            Position = @"AIS.10.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.3",
                            Type = @"Component",
                            Position = @"AIS.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.4",
                            Type = @"Component",
                            Position = @"AIS.10.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.5",
                            Type = @"Component",
                            Position = @"AIS.10.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.6",
                            Type = @"Component",
                            Position = @"AIS.10.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11",
                            Type = @"Field",
                            Position = @"AIS.11",
                            Name = @"Placer Supplemental Service Information",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0411",
                            TableName = @"Supplemental Service Information Values",
                            Description = @"This field contains supplemental service and/or logistical information sent from the placer system to the filler system for the universal procedure code reported in field AIS-3. This field will be used to provide scheduling information detail that is not available in other, specific fields in the AIS segment. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values for possible values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.1",
                            Type = @"Component",
                            Position = @"AIS.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.2",
                            Type = @"Component",
                            Position = @"AIS.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.3",
                            Type = @"Component",
                            Position = @"AIS.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.4",
                            Type = @"Component",
                            Position = @"AIS.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.5",
                            Type = @"Component",
                            Position = @"AIS.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.6",
                            Type = @"Component",
                            Position = @"AIS.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12",
                            Type = @"Field",
                            Position = @"AIS.12",
                            Name = @"Filler Supplemental Service Information",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0411",
                            TableName = @"Supplemental Service Information Values",
                            Description = @"This field contains supplemental service and/or logistical information sent from the filler system to the placer system for the procedure code reported in field AIS-3. This field will be used to report scheduling information details that is not available in other, specific fields in the AIS segment. Typically it will reflect the same information as was sent to the filler system in AIS-11-Placer supplemental information unless the scheduling was modified in which case the filler system will report what was actually performed using this field. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values for possible values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.1",
                            Type = @"Component",
                            Position = @"AIS.12.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.2",
                            Type = @"Component",
                            Position = @"AIS.12.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.3",
                            Type = @"Component",
                            Position = @"AIS.12.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.4",
                            Type = @"Component",
                            Position = @"AIS.12.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.5",
                            Type = @"Component",
                            Position = @"AIS.12.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.6",
                            Type = @"Component",
                            Position = @"AIS.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V251SegmentAIS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field setIDAIS;

public HL7V251Field SetIDAIS
{
    get
    {
        if (setIDAIS != null)
        {
            return setIDAIS;
        }

        setIDAIS = new HL7V251Field
        {
            field = message[@"AIS"][1],
            Id = @"AIS.1",
            Type = @"Field",
            Position = @"AIS.1",
            Name = @"Set ID - AIS",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
            Sample = @"",
        };

        

        

        

        return setIDAIS;
    } 
}
internal HL7V251Field segmentActionCode;

public HL7V251Field SegmentActionCode
{
    get
    {
        if (segmentActionCode != null)
        {
            return segmentActionCode;
        }

        segmentActionCode = new HL7V251Field
        {
            field = message[@"AIS"][2],
            Id = @"AIS.2",
            Type = @"Field",
            Position = @"AIS.2",
            Name = @"Segment Action Code",
            Length = 3,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
            Sample = @"",
        };

        

        

        

        return segmentActionCode;
    } 
}
internal HL7V251Field universalServiceIdentifier;

public HL7V251Field UniversalServiceIdentifier
{
    get
    {
        if (universalServiceIdentifier != null)
        {
            return universalServiceIdentifier;
        }

        universalServiceIdentifier = new HL7V251Field
        {
            field = message[@"AIS"][3],
            Id = @"AIS.3",
            Type = @"Field",
            Position = @"AIS.3",
            Name = @"Universal Service Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code for a service to be scheduled. This field may contain a universal service identifier describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the universal service identifier defined for the OBR segment. This code can be based on local and/or universal codes. The use of universal codes is recommended.",
            Sample = @"",
        };

        

        

        

        return universalServiceIdentifier;
    } 
}
internal HL7V251Field startDateTime;

public HL7V251Field StartDateTime
{
    get
    {
        if (startDateTime != null)
        {
            return startDateTime;
        }

        startDateTime = new HL7V251Field
        {
            field = message[@"AIS"][4],
            Id = @"AIS.4",
            Type = @"Field",
            Position = @"AIS.4",
            Name = @"Start Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units",
            Sample = @"",
        };

        

        

        

        return startDateTime;
    } 
}
internal HL7V251Field startDateTimeOffset;

public HL7V251Field StartDateTimeOffset
{
    get
    {
        if (startDateTimeOffset != null)
        {
            return startDateTimeOffset;
        }

        startDateTimeOffset = new HL7V251Field
        {
            field = message[@"AIS"][5],
            Id = @"AIS.5",
            Type = @"Field",
            Position = @"AIS.5",
            Name = @"Start Date/Time Offset",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time. The first component contains the offset amount. An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment.

A positive offset (an unsigned or positive number) indicates that the service is required after the appointment's start date/time.  Specifying a negative offset indicates that the service is required prior to the specified start date/time of the appointment.  Negative offsets are allowed, and sites should clearly define the effect of a negative offset on the appointment's start date/time. 

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units",
            Sample = @"",
        };

        

        

        

        return startDateTimeOffset;
    } 
}
internal HL7V251Field startDateTimeOffsetUnits;

public HL7V251Field StartDateTimeOffsetUnits
{
    get
    {
        if (startDateTimeOffsetUnits != null)
        {
            return startDateTimeOffsetUnits;
        }

        startDateTimeOffsetUnits = new HL7V251Field
        {
            field = message[@"AIS"][6],
            Id = @"AIS.6",
            Type = @"Field",
            Position = @"AIS.6",
            Name = @"Start Date/Time Offset Units",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code s) will be assumed.

This field is conditionally required.  If a value for AIS-5-Start date/time offset is provided, then a value is required for this field. ",
            Sample = @"",
        };

        

        

        

        return startDateTimeOffsetUnits;
    } 
}
internal HL7V251Field duration;

public HL7V251Field Duration
{
    get
    {
        if (duration != null)
        {
            return duration;
        }

        duration = new HL7V251Field
        {
            field = message[@"AIS"][7],
            Id = @"AIS.7",
            Type = @"Field",
            Position = @"AIS.7",
            Name = @"Duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if different from the overall duration of the requested/scheduled appointment. This field indicates to the application that a resource is required for a different amount of time than the appointment's overall duration. An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment. If no start date/time offset is specified, then the resource is required for the full duration of the appointment.

This field must be a positive, non-zero number.  A negative number or zero (0) is nonsensical in the context of a duration.",
            Sample = @"",
        };

        

        

        

        return duration;
    } 
}
internal HL7V251Field durationUnits;

public HL7V251Field DurationUnits
{
    get
    {
        if (durationUnits != null)
        {
            return durationUnits;
        }

        durationUnits = new HL7V251Field
        {
            field = message[@"AIS"][8],
            Id = @"AIS.8",
            Type = @"Field",
            Position = @"AIS.8",
            Name = @"Duration Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the duration. If this field is not valued, the ISO base unit of seconds (code s) will be assumed",
            Sample = @"",
        };

        

        

        

        return durationUnits;
    } 
}
internal HL7V251Field allowSubstitutionCode;

public HL7V251Field AllowSubstitutionCode
{
    get
    {
        if (allowSubstitutionCode != null)
        {
            return allowSubstitutionCode;
        }

        allowSubstitutionCode = new HL7V251Field
        {
            field = message[@"AIS"][9],
            Id = @"AIS.9",
            Type = @"Field",
            Position = @"AIS.9",
            Name = @"Allow Substitution Code",
            Length = 10,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0279",
            TableName = @"Allow Substitution Codes",
            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to User-Defined Table 0279 - Allow Substitution Codes For suggested codes.

This field is conditionally required.  It is required for all request messages.  It is optional for all unsolicited transactions, and for all query messages",
            Sample = @"",
        };

        

        

        

        return allowSubstitutionCode;
    } 
}
internal HL7V251Field fillerStatusCode;

public HL7V251Field FillerStatusCode
{
    get
    {
        if (fillerStatusCode != null)
        {
            return fillerStatusCode;
        }

        fillerStatusCode = new HL7V251Field
        {
            field = message[@"AIS"][10],
            Id = @"AIS.10",
            Type = @"Field",
            Position = @"AIS.10",
            Name = @"Filler Status Code",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0278",
            TableName = @"Filler status codes",
            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application. Refer to User-Defined Table 0278 - Filler Status Codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application",
            Sample = @"",
        };

        

        

        

        return fillerStatusCode;
    } 
}
internal HL7V251Field placerSupplementalServiceInformation;

public HL7V251Field PlacerSupplementalServiceInformation
{
    get
    {
        if (placerSupplementalServiceInformation != null)
        {
            return placerSupplementalServiceInformation;
        }

        placerSupplementalServiceInformation = new HL7V251Field
        {
            field = message[@"AIS"][11],
            Id = @"AIS.11",
            Type = @"Field",
            Position = @"AIS.11",
            Name = @"Placer Supplemental Service Information",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0411",
            TableName = @"Supplemental Service Information Values",
            Description = @"This field contains supplemental service and/or logistical information sent from the placer system to the filler system for the universal procedure code reported in field AIS-3. This field will be used to provide scheduling information detail that is not available in other, specific fields in the AIS segment. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values for possible values.",
            Sample = @"",
        };

        

        

        

        return placerSupplementalServiceInformation;
    } 
}
internal HL7V251Field fillerSupplementalServiceInformation;

public HL7V251Field FillerSupplementalServiceInformation
{
    get
    {
        if (fillerSupplementalServiceInformation != null)
        {
            return fillerSupplementalServiceInformation;
        }

        fillerSupplementalServiceInformation = new HL7V251Field
        {
            field = message[@"AIS"][12],
            Id = @"AIS.12",
            Type = @"Field",
            Position = @"AIS.12",
            Name = @"Filler Supplemental Service Information",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0411",
            TableName = @"Supplemental Service Information Values",
            Description = @"This field contains supplemental service and/or logistical information sent from the filler system to the placer system for the procedure code reported in field AIS-3. This field will be used to report scheduling information details that is not available in other, specific fields in the AIS segment. Typically it will reflect the same information as was sent to the filler system in AIS-11-Placer supplemental information unless the scheduling was modified in which case the filler system will report what was actually performed using this field. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values for possible values.",
            Sample = @"",
        };

        

        

        

        return fillerSupplementalServiceInformation;
    } 
}

    }
}

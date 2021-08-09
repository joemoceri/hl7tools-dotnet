using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentAIS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AIS"; } }

        public string SegmentId { get { return @"AIS"; } }
        
        public string LongName { get { return @"Appointment Information - Service"; } }
        
        public string Description { get { return @"The AIS segment contains information about various kinds of services that can be scheduled.  Services included in a transaction using this segment are assumed to be controlled by a schedule on a schedule filler application.  Services not controlled by a schedule are not identified on a schedule request using this segment. "; } }
        
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
                            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion",
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
                            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions.  Refer to HL7 table 0206 - Segment action code in Chapter 2, Section 2.23.4.2, “Action code/unique identifier mode update definition,” for valid values. 

This field is conditionally required.  It is required for all updating or modifying trigger events",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3",
                            Type = @"Field",
                            Position = @"AIS.3",
                            Name = @"Universal Service Identifier",
                            Length = 200,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identifier code for a service to be scheduled.  This field may contain a Universal Service Identifier describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the Universal Service Identifier defined for the OBR segment in the Order Entry chapter (Chapter 4).  This code can be based on local and/or universal codes.  The use of universal codes is recommended",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AIS.3.1",
                            Type = @"Component",
                            Position = @"AIS.3.1",
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
                            Id = @"AIS.3.2",
                            Type = @"Component",
                            Position = @"AIS.3.2",
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
                            Id = @"AIS.3.3",
                            Type = @"Component",
                            Position = @"AIS.3.3",
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
                            Id = @"AIS.3.4",
                            Type = @"Component",
                            Position = @"AIS.3.4",
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
                            Id = @"AIS.3.5",
                            Type = @"Component",
                            Position = @"AIS.3.5",
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
                            Id = @"AIS.3.6",
                            Type = @"Component",
                            Position = @"AIS.3.6",
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
                            Description = @"This field contains the date and time this service needs for the appointment.  This field allows the application to identify that the service is required for the appointment at a different time than the appointment’s start date/time 
This field is conditionally required.  If a value for AIS-4-start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment’s start date/time and the resource’s start date/time either replicate the appointment’s start date/time into this field, or specify an offset of zero (0) in  AIS-4-start date/time offset and any valid time unit code in AIS-5-start date/time offset units. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AIS.4.1",
                            Type = @"Component",
                            Position = @"AIS.4.1",
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
                            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time.  This field allows the application to identify that the service is required for the appointment at a different time than the appointment’s start date/time.  The first component contains the offset amount.  An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment. 

A positive offset (an unsigned or positive number) indicates that the service is required after the appointment’s start date/time.  Specifying a negative offset indicates that the service is required prior to the specified start date/time of the appointment.  Negative offsets are allowed, and sites should clearly define the effect of a negative offset on the appointment’s start date/time. 

This field is conditionally required.  If a value for AIS-4-start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment’s start date/time and the resource’s start date/time either replicate the appointment’s start date/time into this field, or specify an offset of zero (0) in  AIS-4-start date/time offset and any valid time unit code in AIS-5-start date/time offset units",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6",
                            Type = @"Field",
                            Position = @"AIS.6",
                            Name = @"Start Date/Time Offset Units",
                            Length = 200,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset.  This field should be valued according to the recommendations in Chapters 2 and 7.  If this field is not valued, the ISO base unit of seconds (code s) will be assumed.  Refer to Chapter 7, Figures 7-10 through 713, for a list of ISO and ANSI+ unit codes.

This field is conditionally required.  If a value for AIS-4-start date/time offset is provided, then a value is required for this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AIS.6.1",
                            Type = @"Component",
                            Position = @"AIS.6.1",
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
                            Id = @"AIS.6.2",
                            Type = @"Component",
                            Position = @"AIS.6.2",
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
                            Id = @"AIS.6.3",
                            Type = @"Component",
                            Position = @"AIS.6.3",
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
                            Id = @"AIS.6.4",
                            Type = @"Component",
                            Position = @"AIS.6.4",
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
                            Id = @"AIS.6.5",
                            Type = @"Component",
                            Position = @"AIS.6.5",
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
                            Id = @"AIS.6.6",
                            Type = @"Component",
                            Position = @"AIS.6.6",
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
                            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if different from the overall duration of the requested/scheduled appointment.  This field indicates to the application that a resource is required for a different amount of time than the appointment’s overall duration.  An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment.  If no start date/time offset is specified, then the resource is required for the full duration of the appointment.

This field must be a positive, non-zero number.  A negative number or zero (0) is nonsensical in the context of a duration",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8",
                            Type = @"Field",
                            Position = @"AIS.8",
                            Name = @"Duration Units",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a code describing the units of time used for expressing the duration.  This field should be valued according to the recommendations in Chapters 2 and 7.  If this field is not valued, the ISO base unit of seconds (code s) will be assumed.  Refer to Chapter 7, Figures 7-10 through 7-13, for a list of ISO and ANSI+ unit codes. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AIS.8.1",
                            Type = @"Component",
                            Position = @"AIS.8.1",
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
                            Id = @"AIS.8.2",
                            Type = @"Component",
                            Position = @"AIS.8.2",
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
                            Id = @"AIS.8.3",
                            Type = @"Component",
                            Position = @"AIS.8.3",
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
                            Id = @"AIS.8.4",
                            Type = @"Component",
                            Position = @"AIS.8.4",
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
                            Id = @"AIS.8.5",
                            Type = @"Component",
                            Position = @"AIS.8.5",
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
                            Id = @"AIS.8.6",
                            Type = @"Component",
                            Position = @"AIS.8.6",
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
                            TableName = @"Allow substitution codes",
                            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application.  Refer to user-defined table 0279 - Allow substitution codes for suggested codes

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
                            Length = 200,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0278",
                            TableName = @"Filler status codes",
                            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application.  Refer to user-defined table 0278 - Filler status codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AIS.10.1",
                            Type = @"Component",
                            Position = @"AIS.10.1",
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
                            Id = @"AIS.10.2",
                            Type = @"Component",
                            Position = @"AIS.10.2",
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
                            Id = @"AIS.10.3",
                            Type = @"Component",
                            Position = @"AIS.10.3",
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
                            Id = @"AIS.10.4",
                            Type = @"Component",
                            Position = @"AIS.10.4",
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
                            Id = @"AIS.10.5",
                            Type = @"Component",
                            Position = @"AIS.10.5",
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
                            Id = @"AIS.10.6",
                            Type = @"Component",
                            Position = @"AIS.10.6",
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
                        };
            }
        }

        public HL7V23SegmentAIS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDAIS;

public HL7V23Field SetIDAIS
{
    get
    {
        if (setIDAIS != null)
        {
            return setIDAIS;
        }

        setIDAIS = new HL7V23Field
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
            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion",
            Sample = @"",
        };

        // check for repetitions
        if (setIDAIS.field.FieldRepetitions != null && setIDAIS.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDAIS.Id));
            setIDAIS.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(setIDAIS, fieldData);
        }

        return setIDAIS;
    } 
}

internal HL7V23Field segmentActionCode;

public HL7V23Field SegmentActionCode
{
    get
    {
        if (segmentActionCode != null)
        {
            return segmentActionCode;
        }

        segmentActionCode = new HL7V23Field
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
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions.  Refer to HL7 table 0206 - Segment action code in Chapter 2, Section 2.23.4.2, “Action code/unique identifier mode update definition,” for valid values. 

This field is conditionally required.  It is required for all updating or modifying trigger events",
            Sample = @"",
        };

        // check for repetitions
        if (segmentActionCode.field.FieldRepetitions != null && segmentActionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(segmentActionCode.Id));
            segmentActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(segmentActionCode, fieldData);
        }

        return segmentActionCode;
    } 
}

internal HL7V23Field universalServiceIdentifier;

public HL7V23Field UniversalServiceIdentifier
{
    get
    {
        if (universalServiceIdentifier != null)
        {
            return universalServiceIdentifier;
        }

        universalServiceIdentifier = new HL7V23Field
        {
            field = message[@"AIS"][3],
            Id = @"AIS.3",
            Type = @"Field",
            Position = @"AIS.3",
            Name = @"Universal Service Identifier",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code for a service to be scheduled.  This field may contain a Universal Service Identifier describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the Universal Service Identifier defined for the OBR segment in the Order Entry chapter (Chapter 4).  This code can be based on local and/or universal codes.  The use of universal codes is recommended",
            Sample = @"",
        };

        // check for repetitions
        if (universalServiceIdentifier.field.FieldRepetitions != null && universalServiceIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(universalServiceIdentifier.Id));
            universalServiceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(universalServiceIdentifier, fieldData);
        }

        return universalServiceIdentifier;
    } 
}

internal HL7V23Field startDateTime;

public HL7V23Field StartDateTime
{
    get
    {
        if (startDateTime != null)
        {
            return startDateTime;
        }

        startDateTime = new HL7V23Field
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
            Description = @"This field contains the date and time this service needs for the appointment.  This field allows the application to identify that the service is required for the appointment at a different time than the appointment’s start date/time 
This field is conditionally required.  If a value for AIS-4-start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment’s start date/time and the resource’s start date/time either replicate the appointment’s start date/time into this field, or specify an offset of zero (0) in  AIS-4-start date/time offset and any valid time unit code in AIS-5-start date/time offset units. ",
            Sample = @"",
        };

        // check for repetitions
        if (startDateTime.field.FieldRepetitions != null && startDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDateTime.Id));
            startDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(startDateTime, fieldData);
        }

        return startDateTime;
    } 
}

internal HL7V23Field startDateTimeOffset;

public HL7V23Field StartDateTimeOffset
{
    get
    {
        if (startDateTimeOffset != null)
        {
            return startDateTimeOffset;
        }

        startDateTimeOffset = new HL7V23Field
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
            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time.  This field allows the application to identify that the service is required for the appointment at a different time than the appointment’s start date/time.  The first component contains the offset amount.  An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment. 

A positive offset (an unsigned or positive number) indicates that the service is required after the appointment’s start date/time.  Specifying a negative offset indicates that the service is required prior to the specified start date/time of the appointment.  Negative offsets are allowed, and sites should clearly define the effect of a negative offset on the appointment’s start date/time. 

This field is conditionally required.  If a value for AIS-4-start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment’s start date/time and the resource’s start date/time either replicate the appointment’s start date/time into this field, or specify an offset of zero (0) in  AIS-4-start date/time offset and any valid time unit code in AIS-5-start date/time offset units",
            Sample = @"",
        };

        // check for repetitions
        if (startDateTimeOffset.field.FieldRepetitions != null && startDateTimeOffset.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDateTimeOffset.Id));
            startDateTimeOffset.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(startDateTimeOffset, fieldData);
        }

        return startDateTimeOffset;
    } 
}

internal HL7V23Field startDateTimeOffsetUnits;

public HL7V23Field StartDateTimeOffsetUnits
{
    get
    {
        if (startDateTimeOffsetUnits != null)
        {
            return startDateTimeOffsetUnits;
        }

        startDateTimeOffsetUnits = new HL7V23Field
        {
            field = message[@"AIS"][6],
            Id = @"AIS.6",
            Type = @"Field",
            Position = @"AIS.6",
            Name = @"Start Date/Time Offset Units",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset.  This field should be valued according to the recommendations in Chapters 2 and 7.  If this field is not valued, the ISO base unit of seconds (code s) will be assumed.  Refer to Chapter 7, Figures 7-10 through 713, for a list of ISO and ANSI+ unit codes.

This field is conditionally required.  If a value for AIS-4-start date/time offset is provided, then a value is required for this field.",
            Sample = @"",
        };

        // check for repetitions
        if (startDateTimeOffsetUnits.field.FieldRepetitions != null && startDateTimeOffsetUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(startDateTimeOffsetUnits.Id));
            startDateTimeOffsetUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(startDateTimeOffsetUnits, fieldData);
        }

        return startDateTimeOffsetUnits;
    } 
}

internal HL7V23Field duration;

public HL7V23Field Duration
{
    get
    {
        if (duration != null)
        {
            return duration;
        }

        duration = new HL7V23Field
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
            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if different from the overall duration of the requested/scheduled appointment.  This field indicates to the application that a resource is required for a different amount of time than the appointment’s overall duration.  An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment.  If no start date/time offset is specified, then the resource is required for the full duration of the appointment.

This field must be a positive, non-zero number.  A negative number or zero (0) is nonsensical in the context of a duration",
            Sample = @"",
        };

        // check for repetitions
        if (duration.field.FieldRepetitions != null && duration.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(duration.Id));
            duration.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(duration, fieldData);
        }

        return duration;
    } 
}

internal HL7V23Field durationUnits;

public HL7V23Field DurationUnits
{
    get
    {
        if (durationUnits != null)
        {
            return durationUnits;
        }

        durationUnits = new HL7V23Field
        {
            field = message[@"AIS"][8],
            Id = @"AIS.8",
            Type = @"Field",
            Position = @"AIS.8",
            Name = @"Duration Units",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the duration.  This field should be valued according to the recommendations in Chapters 2 and 7.  If this field is not valued, the ISO base unit of seconds (code s) will be assumed.  Refer to Chapter 7, Figures 7-10 through 7-13, for a list of ISO and ANSI+ unit codes. ",
            Sample = @"",
        };

        // check for repetitions
        if (durationUnits.field.FieldRepetitions != null && durationUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(durationUnits.Id));
            durationUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(durationUnits, fieldData);
        }

        return durationUnits;
    } 
}

internal HL7V23Field allowSubstitutionCode;

public HL7V23Field AllowSubstitutionCode
{
    get
    {
        if (allowSubstitutionCode != null)
        {
            return allowSubstitutionCode;
        }

        allowSubstitutionCode = new HL7V23Field
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
            TableName = @"Allow substitution codes",
            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application.  Refer to user-defined table 0279 - Allow substitution codes for suggested codes

This field is conditionally required.  It is required for all request messages.  It is optional for all unsolicited transactions, and for all query messages",
            Sample = @"",
        };

        // check for repetitions
        if (allowSubstitutionCode.field.FieldRepetitions != null && allowSubstitutionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allowSubstitutionCode.Id));
            allowSubstitutionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(allowSubstitutionCode, fieldData);
        }

        return allowSubstitutionCode;
    } 
}

internal HL7V23Field fillerStatusCode;

public HL7V23Field FillerStatusCode
{
    get
    {
        if (fillerStatusCode != null)
        {
            return fillerStatusCode;
        }

        fillerStatusCode = new HL7V23Field
        {
            field = message[@"AIS"][10],
            Id = @"AIS.10",
            Type = @"Field",
            Position = @"AIS.10",
            Name = @"Filler Status Code",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0278",
            TableName = @"Filler status codes",
            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application.  Refer to user-defined table 0278 - Filler status codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application. ",
            Sample = @"",
        };

        // check for repetitions
        if (fillerStatusCode.field.FieldRepetitions != null && fillerStatusCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerStatusCode.Id));
            fillerStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(fillerStatusCode, fieldData);
        }

        return fillerStatusCode;
    } 
}
    }
}

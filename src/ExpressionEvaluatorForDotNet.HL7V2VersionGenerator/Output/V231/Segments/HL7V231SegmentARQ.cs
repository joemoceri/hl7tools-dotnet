using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentARQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ARQ"; } }

        public string SegmentId { get { return @"ARQ"; } }
        
        public string LongName { get { return @"Appointment request segment"; } }
        
        public string Description { get { return @"The ARQ segment defines a request for the booking of an appointment. It is used in transactions sent from an application acting in the role of a placer."; } }
        
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

        public HL7V231SegmentARQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _placerAppointmentID;

public HL7V231Field PlacerAppointmentID
{
    get
    {
        if (_placerAppointmentID != null)
        {
            return _placerAppointmentID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.1",
            Type = @"Field",
            Position = @"ARQ.1",
            Name = @"Placer Appointment ID",
            Length = 75,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains placer application's permanent identifier for the appointment request (and the scheduled appointment itself, when confirmed as booked by the filler application). This is a composite field. Refer to Chapter 2, Section 2.8.15, 'EI - entity identifier,' for a description of the EI data type and its components and subcomponents.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.1.1",
                            Type = @"Component",
                            Position = @"ARQ.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.1.2",
                            Type = @"Component",
                            Position = @"ARQ.1.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.1.3",
                            Type = @"Component",
                            Position = @"ARQ.1.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.1.4",
                            Type = @"Component",
                            Position = @"ARQ.1.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _placerAppointmentID = new HL7V231Field
        {
            field = message[@"ARQ"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerAppointmentID.field.FieldRepetitions != null && _placerAppointmentID.field.FieldRepetitions.Count > 0)
        {
            _placerAppointmentID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerAppointmentID, fieldData);
        }

        return _placerAppointmentID;
    } 
}

internal HL7V231Field _fillerAppointmentID;

public HL7V231Field FillerAppointmentID
{
    get
    {
        if (_fillerAppointmentID != null)
        {
            return _fillerAppointmentID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.2",
            Type = @"Field",
            Position = @"ARQ.2",
            Name = @"Filler Appointment ID",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the filler application's permanent identifier for the appointment request (and the scheduled appointment itself, when confirmed as a booked slot by the filler application). This is a composite field. Refer to Chapter 2, Section 2.8.15, 'EI - entity identifier,' for a description of the EI data type and its components and subcomponents.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.2.1",
                            Type = @"Component",
                            Position = @"ARQ.2.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.2.2",
                            Type = @"Component",
                            Position = @"ARQ.2.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.2.3",
                            Type = @"Component",
                            Position = @"ARQ.2.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.2.4",
                            Type = @"Component",
                            Position = @"ARQ.2.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerAppointmentID = new HL7V231Field
        {
            field = message[@"ARQ"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerAppointmentID.field.FieldRepetitions != null && _fillerAppointmentID.field.FieldRepetitions.Count > 0)
        {
            _fillerAppointmentID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_fillerAppointmentID, fieldData);
        }

        return _fillerAppointmentID;
    } 
}

internal HL7V231Field _occurrenceNumber;

public HL7V231Field OccurrenceNumber
{
    get
    {
        if (_occurrenceNumber != null)
        {
            return _occurrenceNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.3",
            Type = @"Field",
            Position = @"ARQ.3",
            Name = @"Occurrence Number",
            Length = 5,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is used in conjunction with the placer appointment ID and/or the filler appointment ID to uniquely identify an individual occurrence (a child) of a parent repeating schedule appointment.",
            Sample = @"",
            Fields = null
        }

        _occurrenceNumber = new HL7V231Field
        {
            field = message[@"ARQ"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceNumber.field.FieldRepetitions != null && _occurrenceNumber.field.FieldRepetitions.Count > 0)
        {
            _occurrenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_occurrenceNumber, fieldData);
        }

        return _occurrenceNumber;
    } 
}

internal HL7V231Field _placerGroupNumber;

public HL7V231Field PlacerGroupNumber
{
    get
    {
        if (_placerGroupNumber != null)
        {
            return _placerGroupNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.4",
            Type = @"Field",
            Position = @"ARQ.4",
            Name = @"Placer Group Number",
            Length = 22,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field allows a placer application to group sets of appointment requests together, and subsequently to identify the group.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.4.1",
                            Type = @"Component",
                            Position = @"ARQ.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.4.2",
                            Type = @"Component",
                            Position = @"ARQ.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.4.3",
                            Type = @"Component",
                            Position = @"ARQ.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.4.4",
                            Type = @"Component",
                            Position = @"ARQ.4.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _placerGroupNumber = new HL7V231Field
        {
            field = message[@"ARQ"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerGroupNumber.field.FieldRepetitions != null && _placerGroupNumber.field.FieldRepetitions.Count > 0)
        {
            _placerGroupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerGroupNumber, fieldData);
        }

        return _placerGroupNumber;
    } 
}

internal HL7V231Field _scheduleID;

public HL7V231Field ScheduleID
{
    get
    {
        if (_scheduleID != null)
        {
            return _scheduleID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.5",
            Type = @"Field",
            Position = @"ARQ.5",
            Name = @"Schedule ID",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code for the schedule in which this appointment should be (or is) booked. This field is provided for situations in which filler applications maintain multiple schedules, and in which a particular resource or set of resources is controlled by more than one of those schedules.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.5.1",
                            Type = @"Component",
                            Position = @"ARQ.5.1",
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
                            Id = @"ARQ.5.2",
                            Type = @"Component",
                            Position = @"ARQ.5.2",
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
                            Id = @"ARQ.5.3",
                            Type = @"Component",
                            Position = @"ARQ.5.3",
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
                            Id = @"ARQ.5.4",
                            Type = @"Component",
                            Position = @"ARQ.5.4",
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
                            Id = @"ARQ.5.5",
                            Type = @"Component",
                            Position = @"ARQ.5.5",
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
                            Id = @"ARQ.5.6",
                            Type = @"Component",
                            Position = @"ARQ.5.6",
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
                        }
        }

        _scheduleID = new HL7V231Field
        {
            field = message[@"ARQ"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduleID.field.FieldRepetitions != null && _scheduleID.field.FieldRepetitions.Count > 0)
        {
            _scheduleID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_scheduleID, fieldData);
        }

        return _scheduleID;
    } 
}

internal HL7V231Field _requestEventReason;

public HL7V231Field RequestEventReason
{
    get
    {
        if (_requestEventReason != null)
        {
            return _requestEventReason;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.6",
            Type = @"Field",
            Position = @"ARQ.6",
            Name = @"Request Event Reason",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier code for the reason that the request event is being triggered. This field may contain a code describing the cancel reason, the delete reason, the discontinue reason, the add reason, or any other code describing the reason that a specific event is occurring.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.6.1",
                            Type = @"Component",
                            Position = @"ARQ.6.1",
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
                            Id = @"ARQ.6.2",
                            Type = @"Component",
                            Position = @"ARQ.6.2",
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
                            Id = @"ARQ.6.3",
                            Type = @"Component",
                            Position = @"ARQ.6.3",
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
                            Id = @"ARQ.6.4",
                            Type = @"Component",
                            Position = @"ARQ.6.4",
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
                            Id = @"ARQ.6.5",
                            Type = @"Component",
                            Position = @"ARQ.6.5",
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
                            Id = @"ARQ.6.6",
                            Type = @"Component",
                            Position = @"ARQ.6.6",
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
                        }
        }

        _requestEventReason = new HL7V231Field
        {
            field = message[@"ARQ"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestEventReason.field.FieldRepetitions != null && _requestEventReason.field.FieldRepetitions.Count > 0)
        {
            _requestEventReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_requestEventReason, fieldData);
        }

        return _requestEventReason;
    } 
}

internal HL7V231Field _appointmentReason;

public HL7V231Field AppointmentReason
{
    get
    {
        if (_appointmentReason != null)
        {
            return _appointmentReason;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.7",
            Type = @"Field",
            Position = @"ARQ.7",
            Name = @"Appointment Reason",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0276",
            TableName = @"Appointment reason codes",
            Description = @"This field contains the identifier code for the reason that the appointment is to take place. This field may contain a Universal Service ID describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the Universal Service ID defined for the OBR segment in Chapter 4 on Order Entry. It may also contain a site-specific code describing a pre-defined set of reasons that an appointment may be set to occur. This code can be based on local and/or universal codes. The use of universal codes is recommended. Refer to user-defined table 0276 - Appointment reason codes, below, for suggested codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.7.1",
                            Type = @"Component",
                            Position = @"ARQ.7.1",
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
                            Id = @"ARQ.7.2",
                            Type = @"Component",
                            Position = @"ARQ.7.2",
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
                            Id = @"ARQ.7.3",
                            Type = @"Component",
                            Position = @"ARQ.7.3",
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
                            Id = @"ARQ.7.4",
                            Type = @"Component",
                            Position = @"ARQ.7.4",
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
                            Id = @"ARQ.7.5",
                            Type = @"Component",
                            Position = @"ARQ.7.5",
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
                            Id = @"ARQ.7.6",
                            Type = @"Component",
                            Position = @"ARQ.7.6",
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
                        }
        }

        _appointmentReason = new HL7V231Field
        {
            field = message[@"ARQ"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appointmentReason.field.FieldRepetitions != null && _appointmentReason.field.FieldRepetitions.Count > 0)
        {
            _appointmentReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_appointmentReason, fieldData);
        }

        return _appointmentReason;
    } 
}

internal HL7V231Field _appointmentType;

public HL7V231Field AppointmentType
{
    get
    {
        if (_appointmentType != null)
        {
            return _appointmentType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.8",
            Type = @"Field",
            Position = @"ARQ.8",
            Name = @"Appointment Type",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0277",
            TableName = @"Appointment type codes",
            Description = @"This field contains an identifier code for the type of appointment being requested. Refer to user-defined table 0277 - Appointment type codes for suggested codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.8.1",
                            Type = @"Component",
                            Position = @"ARQ.8.1",
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
                            Id = @"ARQ.8.2",
                            Type = @"Component",
                            Position = @"ARQ.8.2",
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
                            Id = @"ARQ.8.3",
                            Type = @"Component",
                            Position = @"ARQ.8.3",
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
                            Id = @"ARQ.8.4",
                            Type = @"Component",
                            Position = @"ARQ.8.4",
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
                            Id = @"ARQ.8.5",
                            Type = @"Component",
                            Position = @"ARQ.8.5",
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
                            Id = @"ARQ.8.6",
                            Type = @"Component",
                            Position = @"ARQ.8.6",
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
                        }
        }

        _appointmentType = new HL7V231Field
        {
            field = message[@"ARQ"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appointmentType.field.FieldRepetitions != null && _appointmentType.field.FieldRepetitions.Count > 0)
        {
            _appointmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_appointmentType, fieldData);
        }

        return _appointmentType;
    } 
}

internal HL7V231Field _appointmentDuration;

public HL7V231Field AppointmentDuration
{
    get
    {
        if (_appointmentDuration != null)
        {
            return _appointmentDuration;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.9",
            Type = @"Field",
            Position = @"ARQ.9",
            Name = @"Appointment Duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount of time being requested for the appointment. In cases of requests for repeating appointments, this field describes the duration of one instance of the appointment. If this field is unvalued, then the institution's standard duration for the type of appointment requested will be assumed.",
            Sample = @"",
            Fields = null
        }

        _appointmentDuration = new HL7V231Field
        {
            field = message[@"ARQ"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appointmentDuration.field.FieldRepetitions != null && _appointmentDuration.field.FieldRepetitions.Count > 0)
        {
            _appointmentDuration.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_appointmentDuration, fieldData);
        }

        return _appointmentDuration;
    } 
}

internal HL7V231Field _appointmentDurationUnits;

public HL7V231Field AppointmentDurationUnits
{
    get
    {
        if (_appointmentDurationUnits != null)
        {
            return _appointmentDurationUnits;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.10",
            Type = @"Field",
            Position = @"ARQ.10",
            Name = @"Appointment Duration Units",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used in expressing the ARQ-9-appointment duration field. This field should be valued according to the recommendations in Chapters 2 and 7. If this component is not valued, the ISO base unit of seconds (code s) will be assumed. Refer to Chapter 7, Figures 7-10 through 7-13, for a list of ISO and ANSI+ unit codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.10.1",
                            Type = @"Component",
                            Position = @"ARQ.10.1",
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
                            Id = @"ARQ.10.2",
                            Type = @"Component",
                            Position = @"ARQ.10.2",
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
                            Id = @"ARQ.10.3",
                            Type = @"Component",
                            Position = @"ARQ.10.3",
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
                            Id = @"ARQ.10.4",
                            Type = @"Component",
                            Position = @"ARQ.10.4",
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
                            Id = @"ARQ.10.5",
                            Type = @"Component",
                            Position = @"ARQ.10.5",
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
                            Id = @"ARQ.10.6",
                            Type = @"Component",
                            Position = @"ARQ.10.6",
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
                        }
        }

        _appointmentDurationUnits = new HL7V231Field
        {
            field = message[@"ARQ"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appointmentDurationUnits.field.FieldRepetitions != null && _appointmentDurationUnits.field.FieldRepetitions.Count > 0)
        {
            _appointmentDurationUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_appointmentDurationUnits, fieldData);
        }

        return _appointmentDurationUnits;
    } 
}

internal HL7V231Field _requestedStartDateTimeRange;

public HL7V231Field RequestedStartDateTimeRange
{
    get
    {
        if (_requestedStartDateTimeRange != null)
        {
            return _requestedStartDateTimeRange;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.11",
            Type = @"Field",
            Position = @"ARQ.11",
            Name = @"Requested Start Date/Time Range",
            Length = 53,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DR",
            DataTypeName = @"Date/time Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time that the appointment is requested to begin, in the form of a date/time range. The first component contains the earliest date and time that the appointment may be scheduled to begin. The second component contains the latest date and time that the appointment may be scheduled to begin.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.11.1",
                            Type = @"Component",
                            Position = @"ARQ.11.1",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.11.1.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.11.1.1",
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
                            Id = @"ARQ.11.2",
                            Type = @"Component",
                            Position = @"ARQ.11.2",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.11.2.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.11.2.1",
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
                        }
        }

        _requestedStartDateTimeRange = new HL7V231Field
        {
            field = message[@"ARQ"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedStartDateTimeRange.field.FieldRepetitions != null && _requestedStartDateTimeRange.field.FieldRepetitions.Count > 0)
        {
            _requestedStartDateTimeRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_requestedStartDateTimeRange, fieldData);
        }

        return _requestedStartDateTimeRange;
    } 
}

internal HL7V231Field _priorityARQ;

public HL7V231Field PriorityARQ
{
    get
    {
        if (_priorityARQ != null)
        {
            return _priorityARQ;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.12",
            Type = @"Field",
            Position = @"ARQ.12",
            Name = @"Priority-ARQ",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the urgency of the request. The definition of this field is equivalent to the definition of the priority component of the Quantity/Timing data type given in the Order Entry chapter (Chapter 4), Section 4.4.6, 'Priority component.'",
            Sample = @"",
            Fields = null
        }

        _priorityARQ = new HL7V231Field
        {
            field = message[@"ARQ"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorityARQ.field.FieldRepetitions != null && _priorityARQ.field.FieldRepetitions.Count > 0)
        {
            _priorityARQ.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_priorityARQ, fieldData);
        }

        return _priorityARQ;
    } 
}

internal HL7V231Field _repeatingInterval;

public HL7V231Field RepeatingInterval
{
    get
    {
        if (_repeatingInterval != null)
        {
            return _repeatingInterval;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.13",
            Type = @"Field",
            Position = @"ARQ.13",
            Name = @"Repeating Interval",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"RI",
            DataTypeName = @"Repeat Interval",
            TableId = null,
            TableName = null,
            Description = @"This field contains the interval between repeating appointments. The default setting indicates that the appointment should occur once, if the component is not valued. The definition of this field is equivalent to the definition of the interval component of the Quantity/Timing data type given in the Order Entry chapter (Chapter 4), Section 4.4.2, 'Interval component.'",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.13.1",
                            Type = @"Component",
                            Position = @"ARQ.13.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered.  It is similar to the frequency and SIG code tables used in order entry systems",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.13.2",
                            Type = @"Component",
                            Position = @"ARQ.13.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution.  If the time of the order spans more than a single day, this new subcomponent is only practical if the same times of administration occur for each day of the order.  If the actual start time of the order (as given by the fourth subcomponent of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time.  In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _repeatingInterval = new HL7V231Field
        {
            field = message[@"ARQ"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_repeatingInterval.field.FieldRepetitions != null && _repeatingInterval.field.FieldRepetitions.Count > 0)
        {
            _repeatingInterval.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_repeatingInterval, fieldData);
        }

        return _repeatingInterval;
    } 
}

internal HL7V231Field _repeatingIntervalDuration;

public HL7V231Field RepeatingIntervalDuration
{
    get
    {
        if (_repeatingIntervalDuration != null)
        {
            return _repeatingIntervalDuration;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.14",
            Type = @"Field",
            Position = @"ARQ.14",
            Name = @"Repeating Interval Duration",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates how long the appointment repetitions should continue, once they have begun. The default setting indicates that the appointment should occur once. If the Interval Duration is defined as indefinitely repeating, the repetition of this appointment can only be stopped by using a discontinue event. The definition of this field is equivalent to the definition of the Interval component of the Quantity/Timing field given in the Order Entry chapter (Chapter 4), Section 4.4.3, 'Duration component,' with the exception of the default value.",
            Sample = @"",
            Fields = null
        }

        _repeatingIntervalDuration = new HL7V231Field
        {
            field = message[@"ARQ"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_repeatingIntervalDuration.field.FieldRepetitions != null && _repeatingIntervalDuration.field.FieldRepetitions.Count > 0)
        {
            _repeatingIntervalDuration.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_repeatingIntervalDuration, fieldData);
        }

        return _repeatingIntervalDuration;
    } 
}

internal HL7V231Field _placerContactPerson;

public HL7V231Field PlacerContactPerson
{
    get
    {
        if (_placerContactPerson != null)
        {
            return _placerContactPerson;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.15",
            Type = @"Field",
            Position = @"ARQ.15",
            Name = @"Placer Contact Person",
            Length = 48,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the person responsible for requesting the scheduling of a requested appointment. This person could be the same person responsible for executing the actual appointment, or it could be the provider requesting that an appointment be made on behalf of the patient, with another provider.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.15.1",
                            Type = @"Component",
                            Position = @"ARQ.15.1",
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
                            Id = @"ARQ.15.2",
                            Type = @"Component",
                            Position = @"ARQ.15.2",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.15.2.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.2.1",
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
                            Id = @"ARQ.15.2.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.2.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.15.3",
                            Type = @"Component",
                            Position = @"ARQ.15.3",
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
                            Id = @"ARQ.15.4",
                            Type = @"Component",
                            Position = @"ARQ.15.4",
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
                            Id = @"ARQ.15.5",
                            Type = @"Component",
                            Position = @"ARQ.15.5",
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
                            Id = @"ARQ.15.6",
                            Type = @"Component",
                            Position = @"ARQ.15.6",
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
                            Id = @"ARQ.15.7",
                            Type = @"Component",
                            Position = @"ARQ.15.7",
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
                            Id = @"ARQ.15.8",
                            Type = @"Component",
                            Position = @"ARQ.15.8",
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
                            Id = @"ARQ.15.9",
                            Type = @"Component",
                            Position = @"ARQ.15.9",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.15.9.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.9.1",
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
                            Id = @"ARQ.15.9.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.9.2",
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
                            Id = @"ARQ.15.9.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.9.3",
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
                            Id = @"ARQ.15.10",
                            Type = @"Component",
                            Position = @"ARQ.15.10",
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
                            Id = @"ARQ.15.11",
                            Type = @"Component",
                            Position = @"ARQ.15.11",
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
                            Id = @"ARQ.15.12",
                            Type = @"Component",
                            Position = @"ARQ.15.12",
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
                            Id = @"ARQ.15.13",
                            Type = @"Component",
                            Position = @"ARQ.15.13",
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
                            Id = @"ARQ.15.14",
                            Type = @"Component",
                            Position = @"ARQ.15.14",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.15.14.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.14.1",
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
                            Id = @"ARQ.15.14.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.14.2",
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
                            Id = @"ARQ.15.14.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.15.14.3",
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
                            Id = @"ARQ.15.15",
                            Type = @"Component",
                            Position = @"ARQ.15.15",
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
                        }
        }

        _placerContactPerson = new HL7V231Field
        {
            field = message[@"ARQ"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerContactPerson.field.FieldRepetitions != null && _placerContactPerson.field.FieldRepetitions.Count > 0)
        {
            _placerContactPerson.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerContactPerson, fieldData);
        }

        return _placerContactPerson;
    } 
}

internal HL7V231Field _placerContactPhoneNumber;

public HL7V231Field PlacerContactPhoneNumber
{
    get
    {
        if (_placerContactPhoneNumber != null)
        {
            return _placerContactPhoneNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.16",
            Type = @"Field",
            Position = @"ARQ.16",
            Name = @"Placer Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number used to contact the placer contact person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.16.1",
                            Type = @"Component",
                            Position = @"ARQ.16.1",
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
                            Id = @"ARQ.16.2",
                            Type = @"Component",
                            Position = @"ARQ.16.2",
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
                            Id = @"ARQ.16.3",
                            Type = @"Component",
                            Position = @"ARQ.16.3",
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
                            Id = @"ARQ.16.4",
                            Type = @"Component",
                            Position = @"ARQ.16.4",
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
                            Id = @"ARQ.16.5",
                            Type = @"Component",
                            Position = @"ARQ.16.5",
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
                            Id = @"ARQ.16.6",
                            Type = @"Component",
                            Position = @"ARQ.16.6",
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
                            Id = @"ARQ.16.7",
                            Type = @"Component",
                            Position = @"ARQ.16.7",
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
                            Id = @"ARQ.16.8",
                            Type = @"Component",
                            Position = @"ARQ.16.8",
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
                            Id = @"ARQ.16.9",
                            Type = @"Component",
                            Position = @"ARQ.16.9",
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
                        }
        }

        _placerContactPhoneNumber = new HL7V231Field
        {
            field = message[@"ARQ"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerContactPhoneNumber.field.FieldRepetitions != null && _placerContactPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _placerContactPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerContactPhoneNumber, fieldData);
        }

        return _placerContactPhoneNumber;
    } 
}

internal HL7V231Field _placerContactAddress;

public HL7V231Field PlacerContactAddress
{
    get
    {
        if (_placerContactAddress != null)
        {
            return _placerContactAddress;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.17",
            Type = @"Field",
            Position = @"ARQ.17",
            Name = @"Placer Contact Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address used to contact the placer contact person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.17.1",
                            Type = @"Component",
                            Position = @"ARQ.17.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.2",
                            Type = @"Component",
                            Position = @"ARQ.17.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.3",
                            Type = @"Component",
                            Position = @"ARQ.17.3",
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
                            Id = @"ARQ.17.4",
                            Type = @"Component",
                            Position = @"ARQ.17.4",
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
                            Id = @"ARQ.17.5",
                            Type = @"Component",
                            Position = @"ARQ.17.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.6",
                            Type = @"Component",
                            Position = @"ARQ.17.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.7",
                            Type = @"Component",
                            Position = @"ARQ.17.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.8",
                            Type = @"Component",
                            Position = @"ARQ.17.8",
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
                            Id = @"ARQ.17.9",
                            Type = @"Component",
                            Position = @"ARQ.17.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.10",
                            Type = @"Component",
                            Position = @"ARQ.17.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.17.11",
                            Type = @"Component",
                            Position = @"ARQ.17.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _placerContactAddress = new HL7V231Field
        {
            field = message[@"ARQ"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerContactAddress.field.FieldRepetitions != null && _placerContactAddress.field.FieldRepetitions.Count > 0)
        {
            _placerContactAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerContactAddress, fieldData);
        }

        return _placerContactAddress;
    } 
}

internal HL7V231Field _placerContactLocation;

public HL7V231Field PlacerContactLocation
{
    get
    {
        if (_placerContactLocation != null)
        {
            return _placerContactLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.18",
            Type = @"Field",
            Position = @"ARQ.18",
            Name = @"Placer Contact Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code that identifies the location of the placer contact person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.18.1",
                            Type = @"Component",
                            Position = @"ARQ.18.1",
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
                            Id = @"ARQ.18.2",
                            Type = @"Component",
                            Position = @"ARQ.18.2",
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
                            Id = @"ARQ.18.3",
                            Type = @"Component",
                            Position = @"ARQ.18.3",
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
                            Id = @"ARQ.18.4",
                            Type = @"Component",
                            Position = @"ARQ.18.4",
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
                            Id = @"ARQ.18.4.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.18.4.1",
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
                            Id = @"ARQ.18.4.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.18.4.2",
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
                            Id = @"ARQ.18.4.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.18.4.3",
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
                            Id = @"ARQ.18.5",
                            Type = @"Component",
                            Position = @"ARQ.18.5",
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
                            Id = @"ARQ.18.6",
                            Type = @"Component",
                            Position = @"ARQ.18.6",
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
                            Id = @"ARQ.18.7",
                            Type = @"Component",
                            Position = @"ARQ.18.7",
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
                            Id = @"ARQ.18.8",
                            Type = @"Component",
                            Position = @"ARQ.18.8",
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
                            Id = @"ARQ.18.9",
                            Type = @"Component",
                            Position = @"ARQ.18.9",
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
                        },
                        }
        }

        _placerContactLocation = new HL7V231Field
        {
            field = message[@"ARQ"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerContactLocation.field.FieldRepetitions != null && _placerContactLocation.field.FieldRepetitions.Count > 0)
        {
            _placerContactLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_placerContactLocation, fieldData);
        }

        return _placerContactLocation;
    } 
}

internal HL7V231Field _enteredbyPerson;

public HL7V231Field EnteredbyPerson
{
    get
    {
        if (_enteredbyPerson != null)
        {
            return _enteredbyPerson;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.19",
            Type = @"Field",
            Position = @"ARQ.19",
            Name = @"Entered by Person",
            Length = 48,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the person responsible for entering the request for the scheduling of an appointment. It is included to provide an audit trail of persons responsible for the request. This person may be someone other than the placer contact person, who is responsible for entering orders and requests.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.19.1",
                            Type = @"Component",
                            Position = @"ARQ.19.1",
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
                            Id = @"ARQ.19.2",
                            Type = @"Component",
                            Position = @"ARQ.19.2",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.19.2.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.2.1",
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
                            Id = @"ARQ.19.2.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.2.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.19.3",
                            Type = @"Component",
                            Position = @"ARQ.19.3",
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
                            Id = @"ARQ.19.4",
                            Type = @"Component",
                            Position = @"ARQ.19.4",
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
                            Id = @"ARQ.19.5",
                            Type = @"Component",
                            Position = @"ARQ.19.5",
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
                            Id = @"ARQ.19.6",
                            Type = @"Component",
                            Position = @"ARQ.19.6",
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
                            Id = @"ARQ.19.7",
                            Type = @"Component",
                            Position = @"ARQ.19.7",
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
                            Id = @"ARQ.19.8",
                            Type = @"Component",
                            Position = @"ARQ.19.8",
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
                            Id = @"ARQ.19.9",
                            Type = @"Component",
                            Position = @"ARQ.19.9",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.19.9.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.9.1",
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
                            Id = @"ARQ.19.9.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.9.2",
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
                            Id = @"ARQ.19.9.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.9.3",
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
                            Id = @"ARQ.19.10",
                            Type = @"Component",
                            Position = @"ARQ.19.10",
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
                            Id = @"ARQ.19.11",
                            Type = @"Component",
                            Position = @"ARQ.19.11",
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
                            Id = @"ARQ.19.12",
                            Type = @"Component",
                            Position = @"ARQ.19.12",
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
                            Id = @"ARQ.19.13",
                            Type = @"Component",
                            Position = @"ARQ.19.13",
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
                            Id = @"ARQ.19.14",
                            Type = @"Component",
                            Position = @"ARQ.19.14",
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
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ARQ.19.14.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.14.1",
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
                            Id = @"ARQ.19.14.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.14.2",
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
                            Id = @"ARQ.19.14.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.19.14.3",
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
                            Id = @"ARQ.19.15",
                            Type = @"Component",
                            Position = @"ARQ.19.15",
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
                        }
        }

        _enteredbyPerson = new HL7V231Field
        {
            field = message[@"ARQ"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enteredbyPerson.field.FieldRepetitions != null && _enteredbyPerson.field.FieldRepetitions.Count > 0)
        {
            _enteredbyPerson.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_enteredbyPerson, fieldData);
        }

        return _enteredbyPerson;
    } 
}

internal HL7V231Field _enteredbyPhoneNumber;

public HL7V231Field EnteredbyPhoneNumber
{
    get
    {
        if (_enteredbyPhoneNumber != null)
        {
            return _enteredbyPhoneNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.20",
            Type = @"Field",
            Position = @"ARQ.20",
            Name = @"Entered by Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number used to contact the ARQ-19-entered by person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.20.1",
                            Type = @"Component",
                            Position = @"ARQ.20.1",
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
                            Id = @"ARQ.20.2",
                            Type = @"Component",
                            Position = @"ARQ.20.2",
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
                            Id = @"ARQ.20.3",
                            Type = @"Component",
                            Position = @"ARQ.20.3",
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
                            Id = @"ARQ.20.4",
                            Type = @"Component",
                            Position = @"ARQ.20.4",
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
                            Id = @"ARQ.20.5",
                            Type = @"Component",
                            Position = @"ARQ.20.5",
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
                            Id = @"ARQ.20.6",
                            Type = @"Component",
                            Position = @"ARQ.20.6",
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
                            Id = @"ARQ.20.7",
                            Type = @"Component",
                            Position = @"ARQ.20.7",
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
                            Id = @"ARQ.20.8",
                            Type = @"Component",
                            Position = @"ARQ.20.8",
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
                            Id = @"ARQ.20.9",
                            Type = @"Component",
                            Position = @"ARQ.20.9",
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
                        }
        }

        _enteredbyPhoneNumber = new HL7V231Field
        {
            field = message[@"ARQ"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enteredbyPhoneNumber.field.FieldRepetitions != null && _enteredbyPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _enteredbyPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_enteredbyPhoneNumber, fieldData);
        }

        return _enteredbyPhoneNumber;
    } 
}

internal HL7V231Field _enteredbyLocation;

public HL7V231Field EnteredbyLocation
{
    get
    {
        if (_enteredbyLocation != null)
        {
            return _enteredbyLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.21",
            Type = @"Field",
            Position = @"ARQ.21",
            Name = @"Entered by Location",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code that identifies the location of the entered by person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.21.1",
                            Type = @"Component",
                            Position = @"ARQ.21.1",
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
                            Id = @"ARQ.21.2",
                            Type = @"Component",
                            Position = @"ARQ.21.2",
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
                            Id = @"ARQ.21.3",
                            Type = @"Component",
                            Position = @"ARQ.21.3",
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
                            Id = @"ARQ.21.4",
                            Type = @"Component",
                            Position = @"ARQ.21.4",
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
                            Id = @"ARQ.21.4.1",
                            Type = @"SubComponent",
                            Position = @"ARQ.21.4.1",
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
                            Id = @"ARQ.21.4.2",
                            Type = @"SubComponent",
                            Position = @"ARQ.21.4.2",
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
                            Id = @"ARQ.21.4.3",
                            Type = @"SubComponent",
                            Position = @"ARQ.21.4.3",
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
                            Id = @"ARQ.21.5",
                            Type = @"Component",
                            Position = @"ARQ.21.5",
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
                            Id = @"ARQ.21.6",
                            Type = @"Component",
                            Position = @"ARQ.21.6",
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
                            Id = @"ARQ.21.7",
                            Type = @"Component",
                            Position = @"ARQ.21.7",
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
                            Id = @"ARQ.21.8",
                            Type = @"Component",
                            Position = @"ARQ.21.8",
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
                            Id = @"ARQ.21.9",
                            Type = @"Component",
                            Position = @"ARQ.21.9",
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
                        },
                        }
        }

        _enteredbyLocation = new HL7V231Field
        {
            field = message[@"ARQ"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_enteredbyLocation.field.FieldRepetitions != null && _enteredbyLocation.field.FieldRepetitions.Count > 0)
        {
            _enteredbyLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_enteredbyLocation, fieldData);
        }

        return _enteredbyLocation;
    } 
}

internal HL7V231Field _parentPlacerAppointmentID;

public HL7V231Field ParentPlacerAppointmentID
{
    get
    {
        if (_parentPlacerAppointmentID != null)
        {
            return _parentPlacerAppointmentID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.22",
            Type = @"Field",
            Position = @"ARQ.22",
            Name = @"Parent Placer Appointment ID",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field relates a child to its parent, when a parent-child relationship exists. It contains the placer application's permanent identifier for the parent of the appointment request. This is a composite field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.22.1",
                            Type = @"Component",
                            Position = @"ARQ.22.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.22.2",
                            Type = @"Component",
                            Position = @"ARQ.22.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.22.3",
                            Type = @"Component",
                            Position = @"ARQ.22.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.22.4",
                            Type = @"Component",
                            Position = @"ARQ.22.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _parentPlacerAppointmentID = new HL7V231Field
        {
            field = message[@"ARQ"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parentPlacerAppointmentID.field.FieldRepetitions != null && _parentPlacerAppointmentID.field.FieldRepetitions.Count > 0)
        {
            _parentPlacerAppointmentID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_parentPlacerAppointmentID, fieldData);
        }

        return _parentPlacerAppointmentID;
    } 
}

internal HL7V231Field _parentFillerAppointmentID;

public HL7V231Field ParentFillerAppointmentID
{
    get
    {
        if (_parentFillerAppointmentID != null)
        {
            return _parentFillerAppointmentID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ARQ.23",
            Type = @"Field",
            Position = @"ARQ.23",
            Name = @"Parent Filler Appointment ID",
            Length = 75,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field relates a child to its parent, when a parent-child relationship exists. It contains the filler application's permanent identifier for the parent of the appointment request. This is a composite field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ARQ.23.1",
                            Type = @"Component",
                            Position = @"ARQ.23.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.23.2",
                            Type = @"Component",
                            Position = @"ARQ.23.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.23.3",
                            Type = @"Component",
                            Position = @"ARQ.23.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ARQ.23.4",
                            Type = @"Component",
                            Position = @"ARQ.23.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _parentFillerAppointmentID = new HL7V231Field
        {
            field = message[@"ARQ"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parentFillerAppointmentID.field.FieldRepetitions != null && _parentFillerAppointmentID.field.FieldRepetitions.Count > 0)
        {
            _parentFillerAppointmentID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_parentFillerAppointmentID, fieldData);
        }

        return _parentFillerAppointmentID;
    } 
}
    }
}

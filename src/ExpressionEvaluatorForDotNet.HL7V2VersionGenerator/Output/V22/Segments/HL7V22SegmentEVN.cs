using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentEVN
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EVN"; } }

        public string SegmentId { get { return @"EVN"; } }
        
        public string LongName { get { return @"Event Type"; } }
        
        public string Description { get { return @"The EVN segment is used to communicate necessary trigger event information to receiving applications.  Valid event types for all chapters are contained in table 0003 - event type code"; } }
        
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

        public HL7V22SegmentEVN(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _eventTypeCode;

public HL7V22Field EventTypeCode
{
    get
    {
        if (_eventTypeCode != null)
        {
            return _eventTypeCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"EVN.1",
            Type = @"Field",
            Position = @"EVN.1",
            Name = @"Event Type Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0003",
            TableName = @"EVENT TYPE CODE",
            Description = @"codes correspond to the trigger events described in this section. e.g., admission, transfer, registration.  This field is left in for backwards compatibility.  It is recommended to use the second component (trigger event) of MSH-9-message type to transmit event type code information",
            Sample = @"",
            Fields = null
        }

        _eventTypeCode = new HL7V22Field
        {
            field = message[@"EVN"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventTypeCode.field.FieldRepetitions != null && _eventTypeCode.field.FieldRepetitions.Count > 0)
        {
            _eventTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_eventTypeCode, fieldData);
        }

        return _eventTypeCode;
    } 
}

internal HL7V22Field _dateTimeOfEvent;

public HL7V22Field DateTimeOfEvent
{
    get
    {
        if (_dateTimeOfEvent != null)
        {
            return _dateTimeOfEvent;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"EVN.2",
            Type = @"Field",
            Position = @"EVN.2",
            Name = @"Date / Time Of Event",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"most systems will default to the system date/time when the transaction was entered, but should also permit an override",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EVN.2.1",
                            Type = @"Component",
                            Position = @"EVN.2.1",
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
                            Id = @"EVN.2.2",
                            Type = @"Component",
                            Position = @"EVN.2.2",
                            Name = @"Degree Of Precision",
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

        _dateTimeOfEvent = new HL7V22Field
        {
            field = message[@"EVN"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfEvent.field.FieldRepetitions != null && _dateTimeOfEvent.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeOfEvent, fieldData);
        }

        return _dateTimeOfEvent;
    } 
}

internal HL7V22Field _dateTimePlannedEvent;

public HL7V22Field DateTimePlannedEvent
{
    get
    {
        if (_dateTimePlannedEvent != null)
        {
            return _dateTimePlannedEvent;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"EVN.3",
            Type = @"Field",
            Position = @"EVN.3",
            Name = @"Date / Time Planned Event",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the event is planned.  Recommend that the PV2 expected admit date and expected discharge date be used whenever possible",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EVN.3.1",
                            Type = @"Component",
                            Position = @"EVN.3.1",
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
                            Id = @"EVN.3.2",
                            Type = @"Component",
                            Position = @"EVN.3.2",
                            Name = @"Degree Of Precision",
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

        _dateTimePlannedEvent = new HL7V22Field
        {
            field = message[@"EVN"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimePlannedEvent.field.FieldRepetitions != null && _dateTimePlannedEvent.field.FieldRepetitions.Count > 0)
        {
            _dateTimePlannedEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimePlannedEvent, fieldData);
        }

        return _dateTimePlannedEvent;
    } 
}

internal HL7V22Field _eventReasonCode;

public HL7V22Field EventReasonCode
{
    get
    {
        if (_eventReasonCode != null)
        {
            return _eventReasonCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"EVN.4",
            Type = @"Field",
            Position = @"EVN.4",
            Name = @"Event Reason Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0062",
            TableName = @"EVENT REASON",
            Description = @"describes the reason for this event (e.g., patient request, physician order, census management, etc.).  Refer to user-defined table 0062 - event reason for valid codes",
            Sample = @"",
            Fields = null
        }

        _eventReasonCode = new HL7V22Field
        {
            field = message[@"EVN"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReasonCode.field.FieldRepetitions != null && _eventReasonCode.field.FieldRepetitions.Count > 0)
        {
            _eventReasonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_eventReasonCode, fieldData);
        }

        return _eventReasonCode;
    } 
}

internal HL7V22Field _operatorId;

public HL7V22Field OperatorId
{
    get
    {
        if (_operatorId != null)
        {
            return _operatorId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"EVN.5",
            Type = @"Field",
            Position = @"EVN.5",
            Name = @"Operator Id",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0188",
            TableName = @"OPERATOR ID",
            Description = @"identifies the individual responsible for triggering the event.  Refer to user-defined table 0188 - operator ID for suggested values",
            Sample = @"",
            Fields = null
        }

        _operatorId = new HL7V22Field
        {
            field = message[@"EVN"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_operatorId.field.FieldRepetitions != null && _operatorId.field.FieldRepetitions.Count > 0)
        {
            _operatorId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_operatorId, fieldData);
        }

        return _operatorId;
    } 
}
    }
}

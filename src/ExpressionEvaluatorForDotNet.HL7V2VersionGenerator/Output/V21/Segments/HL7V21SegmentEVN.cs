using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentEVN
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EVN"; } }

        public string SegmentId { get { return @"EVN"; } }
        
        public string LongName { get { return @"Event Type"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentEVN(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _eventTypeCode;

public HL7V21Field EventTypeCode
{
    get
    {
        if (_eventTypeCode != null)
        {
            return _eventTypeCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _eventTypeCode = new HL7V21Field
        {
            field = message[@"EVN"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventTypeCode.field.FieldRepetitions != null && _eventTypeCode.field.FieldRepetitions.Count > 0)
        {
            _eventTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_eventTypeCode, fieldData);
        }

        return _eventTypeCode;
    } 
}

internal HL7V21Field _dateTimeOfEvent;

public HL7V21Field DateTimeOfEvent
{
    get
    {
        if (_dateTimeOfEvent != null)
        {
            return _dateTimeOfEvent;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"EVN.2",
            Type = @"Field",
            Position = @"EVN.2",
            Name = @"Date/Time Of Event",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dateTimeOfEvent = new HL7V21Field
        {
            field = message[@"EVN"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfEvent.field.FieldRepetitions != null && _dateTimeOfEvent.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateTimeOfEvent, fieldData);
        }

        return _dateTimeOfEvent;
    } 
}

internal HL7V21Field _dateTimePlannedEvent;

public HL7V21Field DateTimePlannedEvent
{
    get
    {
        if (_dateTimePlannedEvent != null)
        {
            return _dateTimePlannedEvent;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"EVN.3",
            Type = @"Field",
            Position = @"EVN.3",
            Name = @"Date/Time Planned Event",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dateTimePlannedEvent = new HL7V21Field
        {
            field = message[@"EVN"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimePlannedEvent.field.FieldRepetitions != null && _dateTimePlannedEvent.field.FieldRepetitions.Count > 0)
        {
            _dateTimePlannedEvent.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateTimePlannedEvent, fieldData);
        }

        return _dateTimePlannedEvent;
    } 
}

internal HL7V21Field _eventReasonCode;

public HL7V21Field EventReasonCode
{
    get
    {
        if (_eventReasonCode != null)
        {
            return _eventReasonCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _eventReasonCode = new HL7V21Field
        {
            field = message[@"EVN"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReasonCode.field.FieldRepetitions != null && _eventReasonCode.field.FieldRepetitions.Count > 0)
        {
            _eventReasonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_eventReasonCode, fieldData);
        }

        return _eventReasonCode;
    } 
}
    }
}

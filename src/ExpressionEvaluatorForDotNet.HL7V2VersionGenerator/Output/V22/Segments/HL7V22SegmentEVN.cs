using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentEVN
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentEVN(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field eventTypeCode;

public HL7V22Field EventTypeCode
{
    get
    {
        if (eventTypeCode != null)
        {
            return eventTypeCode;
        }

        eventTypeCode = new HL7V22Field
        {
            field = message[@"EVN"][1],
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
        };

        

        

        

        return eventTypeCode;
    } 
}
internal HL7V22Field dateTimeOfEvent;

public HL7V22Field DateTimeOfEvent
{
    get
    {
        if (dateTimeOfEvent != null)
        {
            return dateTimeOfEvent;
        }

        dateTimeOfEvent = new HL7V22Field
        {
            field = message[@"EVN"][2],
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
        };

        

        

        

        return dateTimeOfEvent;
    } 
}
internal HL7V22Field dateTimePlannedEvent;

public HL7V22Field DateTimePlannedEvent
{
    get
    {
        if (dateTimePlannedEvent != null)
        {
            return dateTimePlannedEvent;
        }

        dateTimePlannedEvent = new HL7V22Field
        {
            field = message[@"EVN"][3],
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
        };

        

        

        

        return dateTimePlannedEvent;
    } 
}
internal HL7V22Field eventReasonCode;

public HL7V22Field EventReasonCode
{
    get
    {
        if (eventReasonCode != null)
        {
            return eventReasonCode;
        }

        eventReasonCode = new HL7V22Field
        {
            field = message[@"EVN"][4],
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
        };

        

        

        

        return eventReasonCode;
    } 
}
internal HL7V22Field operatorId;

public HL7V22Field OperatorId
{
    get
    {
        if (operatorId != null)
        {
            return operatorId;
        }

        operatorId = new HL7V22Field
        {
            field = message[@"EVN"][5],
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
        };

        

        

        

        return operatorId;
    } 
}

    }
}

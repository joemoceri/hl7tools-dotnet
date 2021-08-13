using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message Acknowledgment"; } }
        
        public string Description { get { return @"The MSA segment contains information sent while acknowledging another message."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V28SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _acknowledgmentCode;

public HL7V28Field AcknowledgmentCode
{
    get
    {
        if (_acknowledgmentCode != null)
        {
            return _acknowledgmentCode;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgment Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0008",
            TableName = @"Acknowledgment Code",
            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment Code for valid values.",
            Sample = @"",
            Fields = null
        }

        _acknowledgmentCode = new HL7V28Field
        {
            field = message[@"MSA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acknowledgmentCode.field.FieldRepetitions != null && _acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            _acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_acknowledgmentCode, fieldData);
        }

        return _acknowledgmentCode;
    } 
}

internal HL7V28Field _messageControlId;

public HL7V28Field MessageControlId
{
    get
    {
        if (_messageControlId != null)
        {
            return _messageControlId;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
            Name = @"Message Control Id",
            Length = 199,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the message control ID of the message sent by the sending system. It allows the sending system to associate this response with the message for which it is intended.",
            Sample = @"",
            Fields = null
        }

        _messageControlId = new HL7V28Field
        {
            field = message[@"MSA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlId.field.FieldRepetitions != null && _messageControlId.field.FieldRepetitions.Count > 0)
        {
            _messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_messageControlId, fieldData);
        }

        return _messageControlId;
    } 
}

internal HL7V28Field _textMessage;

public HL7V28Field TextMessage
{
    get
    {
        if (_textMessage != null)
        {
            return _textMessage;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.3",
            Type = @"Field",
            Position = @"MSA.3",
            Name = @"Text Message",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: The MSA-3 was deprecated as of v 2.4 and the detail was withdrawn and removed from the standard as of v 2.7. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.",
            Sample = @"",
            Fields = null
        }

        _textMessage = new HL7V28Field
        {
            field = message[@"MSA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textMessage.field.FieldRepetitions != null && _textMessage.field.FieldRepetitions.Count > 0)
        {
            _textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_textMessage, fieldData);
        }

        return _textMessage;
    } 
}

internal HL7V28Field _expectedSequenceNumber;

public HL7V28Field ExpectedSequenceNumber
{
    get
    {
        if (_expectedSequenceNumber != null)
        {
            return _expectedSequenceNumber;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.4",
            Type = @"Field",
            Position = @"MSA.4",
            Name = @"Expected Sequence Number",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This optional numeric field is used in the sequence number protocol.",
            Sample = @"",
            Fields = null
        }

        _expectedSequenceNumber = new HL7V28Field
        {
            field = message[@"MSA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSequenceNumber.field.FieldRepetitions != null && _expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_expectedSequenceNumber, fieldData);
        }

        return _expectedSequenceNumber;
    } 
}

internal HL7V28Field _delayedAcknowledgmentType;

public HL7V28Field DelayedAcknowledgmentType
{
    get
    {
        if (_delayedAcknowledgmentType != null)
        {
            return _delayedAcknowledgmentType;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgment Type",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: The MSA-5 was deprecated as of v2.2 and the detail was withdrawn and removed from the standard as of v 2.5.",
            Sample = @"",
            Fields = null
        }

        _delayedAcknowledgmentType = new HL7V28Field
        {
            field = message[@"MSA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayedAcknowledgmentType.field.FieldRepetitions != null && _delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_delayedAcknowledgmentType, fieldData);
        }

        return _delayedAcknowledgmentType;
    } 
}

internal HL7V28Field _errorCondition;

public HL7V28Field ErrorCondition
{
    get
    {
        if (_errorCondition != null)
        {
            return _errorCondition;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.6",
            Type = @"Field",
            Position = @"MSA.6",
            Name = @"Error Condition",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: The MSA-3 was deprecated as of v 2.4 and the detail was withdrawn and removed from the standard as of v 2.7. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.",
            Sample = @"",
            Fields = null
        }

        _errorCondition = new HL7V28Field
        {
            field = message[@"MSA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCondition.field.FieldRepetitions != null && _errorCondition.field.FieldRepetitions.Count > 0)
        {
            _errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_errorCondition, fieldData);
        }

        return _errorCondition;
    } 
}

internal HL7V28Field _messageWaitingNumber;

public HL7V28Field MessageWaitingNumber
{
    get
    {
        if (_messageWaitingNumber != null)
        {
            return _messageWaitingNumber;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.7",
            Type = @"Field",
            Position = @"MSA.7",
            Name = @"Message Waiting Number",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).

For example, if there are 3 low priority messages, 1 medium priority message and 1 high priority message, the message waiting priority would be 'high', because that is the highest priority of any message waiting.

With some applications, there is no guarantee that the sending application will be running. The receiving application is therefore unable to submit unsolicited messages. To mitigate this, a polling approach is used where the receiving application requests any queued messages when it is connected. To avoid the network overhead of continuous polling, the sending application needs a way to indicate that there are queued messages awaiting retrieval. It is also useful to provide an indication of the importance of those messages to indicate how quickly they should be retrieved.

Refer to HL7 Table 0520 - Message Waiting Priority for valid values.

See MSA-7 above for Use Case.",
            Sample = @"",
            Fields = null
        }

        _messageWaitingNumber = new HL7V28Field
        {
            field = message[@"MSA"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageWaitingNumber.field.FieldRepetitions != null && _messageWaitingNumber.field.FieldRepetitions.Count > 0)
        {
            _messageWaitingNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_messageWaitingNumber, fieldData);
        }

        return _messageWaitingNumber;
    } 
}

internal HL7V28Field _messageWaitingPriority;

public HL7V28Field MessageWaitingPriority
{
    get
    {
        if (_messageWaitingPriority != null)
        {
            return _messageWaitingPriority;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"MSA.8",
            Type = @"Field",
            Position = @"MSA.8",
            Name = @"Message Waiting Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0520",
            TableName = @"Message Waiting Priority",
            Description = @"If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).

For example, if there are 3 low priority messages, 1 medium priority message and 1 high priority message, the message waiting priority would be 'high', because that is the highest priority of any message waiting.

With some applications, there is no guarantee that the sending application will be running. The receiving application is therefore unable to submit unsolicited messages. To mitigate this, a polling approach is used where the receiving application requests any queued messages when it is connected. To avoid the network overhead of continuous polling, the sending application needs a way to indicate that there are queued messages awaiting retrieval. It is also useful to provide an indication of the importance of those messages to indicate how quickly they should be retrieved.

Refer to HL7 Table 0520 - Message Waiting Priority for valid values.
See MSA-7 above for Use Case.",
            Sample = @"",
            Fields = null
        }

        _messageWaitingPriority = new HL7V28Field
        {
            field = message[@"MSA"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageWaitingPriority.field.FieldRepetitions != null && _messageWaitingPriority.field.FieldRepetitions.Count > 0)
        {
            _messageWaitingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_messageWaitingPriority, fieldData);
        }

        return _messageWaitingPriority;
    } 
}
    }
}

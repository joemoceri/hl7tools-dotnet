using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentMSA
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V271SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field acknowledgmentCode;

public HL7V271Field AcknowledgmentCode
{
    get
    {
        if (acknowledgmentCode != null)
        {
            return acknowledgmentCode;
        }

        acknowledgmentCode = new HL7V271Field
        {
            field = message[@"MSA"][1],
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
        };

        // check for repetitions
        if (acknowledgmentCode.field.FieldRepetitions != null && acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acknowledgmentCode.Id));
            acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(acknowledgmentCode, fieldData);
        }

        return acknowledgmentCode;
    } 
}

internal HL7V271Field messageControlId;

public HL7V271Field MessageControlId
{
    get
    {
        if (messageControlId != null)
        {
            return messageControlId;
        }

        messageControlId = new HL7V271Field
        {
            field = message[@"MSA"][2],
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
        };

        // check for repetitions
        if (messageControlId.field.FieldRepetitions != null && messageControlId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlId.Id));
            messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(messageControlId, fieldData);
        }

        return messageControlId;
    } 
}

internal HL7V271Field textMessage;

public HL7V271Field TextMessage
{
    get
    {
        if (textMessage != null)
        {
            return textMessage;
        }

        textMessage = new HL7V271Field
        {
            field = message[@"MSA"][3],
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
        };

        // check for repetitions
        if (textMessage.field.FieldRepetitions != null && textMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textMessage.Id));
            textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(textMessage, fieldData);
        }

        return textMessage;
    } 
}

internal HL7V271Field expectedSequenceNumber;

public HL7V271Field ExpectedSequenceNumber
{
    get
    {
        if (expectedSequenceNumber != null)
        {
            return expectedSequenceNumber;
        }

        expectedSequenceNumber = new HL7V271Field
        {
            field = message[@"MSA"][4],
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
        };

        // check for repetitions
        if (expectedSequenceNumber.field.FieldRepetitions != null && expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expectedSequenceNumber.Id));
            expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(expectedSequenceNumber, fieldData);
        }

        return expectedSequenceNumber;
    } 
}

internal HL7V271Field delayedAcknowledgmentType;

public HL7V271Field DelayedAcknowledgmentType
{
    get
    {
        if (delayedAcknowledgmentType != null)
        {
            return delayedAcknowledgmentType;
        }

        delayedAcknowledgmentType = new HL7V271Field
        {
            field = message[@"MSA"][5],
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
        };

        // check for repetitions
        if (delayedAcknowledgmentType.field.FieldRepetitions != null && delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delayedAcknowledgmentType.Id));
            delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(delayedAcknowledgmentType, fieldData);
        }

        return delayedAcknowledgmentType;
    } 
}

internal HL7V271Field errorCondition;

public HL7V271Field ErrorCondition
{
    get
    {
        if (errorCondition != null)
        {
            return errorCondition;
        }

        errorCondition = new HL7V271Field
        {
            field = message[@"MSA"][6],
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
        };

        // check for repetitions
        if (errorCondition.field.FieldRepetitions != null && errorCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(errorCondition.Id));
            errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(errorCondition, fieldData);
        }

        return errorCondition;
    } 
}

internal HL7V271Field messageWaitingNumber;

public HL7V271Field MessageWaitingNumber
{
    get
    {
        if (messageWaitingNumber != null)
        {
            return messageWaitingNumber;
        }

        messageWaitingNumber = new HL7V271Field
        {
            field = message[@"MSA"][7],
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
        };

        // check for repetitions
        if (messageWaitingNumber.field.FieldRepetitions != null && messageWaitingNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageWaitingNumber.Id));
            messageWaitingNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(messageWaitingNumber, fieldData);
        }

        return messageWaitingNumber;
    } 
}

internal HL7V271Field messageWaitingPriority;

public HL7V271Field MessageWaitingPriority
{
    get
    {
        if (messageWaitingPriority != null)
        {
            return messageWaitingPriority;
        }

        messageWaitingPriority = new HL7V271Field
        {
            field = message[@"MSA"][8],
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
        };

        // check for repetitions
        if (messageWaitingPriority.field.FieldRepetitions != null && messageWaitingPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageWaitingPriority.Id));
            messageWaitingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(messageWaitingPriority, fieldData);
        }

        return messageWaitingPriority;
    } 
}
    }
}

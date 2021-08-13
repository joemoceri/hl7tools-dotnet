using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentMSA
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

        public HL7V26SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _acknowledgmentCode;

public HL7V26Field AcknowledgmentCode
{
    get
    {
        if (_acknowledgmentCode != null)
        {
            return _acknowledgmentCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgment Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0008",
            TableName = @"Acknowledgment code",
            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment code for valid values.",
            Sample = @"",
            Fields = null
        }

        _acknowledgmentCode = new HL7V26Field
        {
            field = message[@"MSA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acknowledgmentCode.field.FieldRepetitions != null && _acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            _acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_acknowledgmentCode, fieldData);
        }

        return _acknowledgmentCode;
    } 
}

internal HL7V26Field _messageControlID;

public HL7V26Field MessageControlID
{
    get
    {
        if (_messageControlID != null)
        {
            return _messageControlID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
            Name = @"Message Control ID",
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

        _messageControlID = new HL7V26Field
        {
            field = message[@"MSA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlID.field.FieldRepetitions != null && _messageControlID.field.FieldRepetitions.Count > 0)
        {
            _messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messageControlID, fieldData);
        }

        return _messageControlID;
    } 
}

internal HL7V26Field _textMessage;

public HL7V26Field TextMessage
{
    get
    {
        if (_textMessage != null)
        {
            return _textMessage;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.3",
            Type = @"Field",
            Position = @"MSA.3",
            Name = @"Text Message",
            Length = 80,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This optional field further describes an error condition. This text may be printed in error logs or presented to an end user.

The MSA-3 was deprecated as of v 2.4. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.",
            Sample = @"",
            Fields = null
        }

        _textMessage = new HL7V26Field
        {
            field = message[@"MSA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textMessage.field.FieldRepetitions != null && _textMessage.field.FieldRepetitions.Count > 0)
        {
            _textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_textMessage, fieldData);
        }

        return _textMessage;
    } 
}

internal HL7V26Field _expectedSequenceNumber;

public HL7V26Field ExpectedSequenceNumber
{
    get
    {
        if (_expectedSequenceNumber != null)
        {
            return _expectedSequenceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.4",
            Type = @"Field",
            Position = @"MSA.4",
            Name = @"Expected Sequence Number",
            Length = 15,
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

        _expectedSequenceNumber = new HL7V26Field
        {
            field = message[@"MSA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSequenceNumber.field.FieldRepetitions != null && _expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_expectedSequenceNumber, fieldData);
        }

        return _expectedSequenceNumber;
    } 
}

internal HL7V26Field _delayedAcknowledgmentType;

public HL7V26Field DelayedAcknowledgmentType
{
    get
    {
        if (_delayedAcknowledgmentType != null)
        {
            return _delayedAcknowledgmentType;
        }

        var fieldData = new HL7V26FieldData
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

        _delayedAcknowledgmentType = new HL7V26Field
        {
            field = message[@"MSA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayedAcknowledgmentType.field.FieldRepetitions != null && _delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_delayedAcknowledgmentType, fieldData);
        }

        return _delayedAcknowledgmentType;
    } 
}

internal HL7V26Field _errorCondition;

public HL7V26Field ErrorCondition
{
    get
    {
        if (_errorCondition != null)
        {
            return _errorCondition;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.6",
            Type = @"Field",
            Position = @"MSA.6",
            Name = @"Error Condition",
            Length = 250,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0357",
            TableName = @"Message error condition codes",
            Description = @"This field allows the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgments.

The MSA-6 was deprecated as of v2.4. The reader is referred to the ERR segment. The ERR segment allows for richer descriptions of the erroneous conditions.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSA.6.1",
                            Type = @"Component",
                            Position = @"MSA.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"MSA.6.2",
                            Type = @"Component",
                            Position = @"MSA.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"MSA.6.3",
                            Type = @"Component",
                            Position = @"MSA.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSA.6.4",
                            Type = @"Component",
                            Position = @"MSA.6.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"MSA.6.5",
                            Type = @"Component",
                            Position = @"MSA.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"MSA.6.6",
                            Type = @"Component",
                            Position = @"MSA.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _errorCondition = new HL7V26Field
        {
            field = message[@"MSA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCondition.field.FieldRepetitions != null && _errorCondition.field.FieldRepetitions.Count > 0)
        {
            _errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_errorCondition, fieldData);
        }

        return _errorCondition;
    } 
}

internal HL7V26Field _messageWaitingNumber;

public HL7V26Field MessageWaitingNumber
{
    get
    {
        if (_messageWaitingNumber != null)
        {
            return _messageWaitingNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.7",
            Type = @"Field",
            Position = @"MSA.7",
            Name = @"Message Waiting Number",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"If present, indicates the number of messages the Acknowledging Application has waiting on a queue for the Requesting Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited message (i.e., polling).",
            Sample = @"",
            Fields = null
        }

        _messageWaitingNumber = new HL7V26Field
        {
            field = message[@"MSA"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageWaitingNumber.field.FieldRepetitions != null && _messageWaitingNumber.field.FieldRepetitions.Count > 0)
        {
            _messageWaitingNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messageWaitingNumber, fieldData);
        }

        return _messageWaitingNumber;
    } 
}

internal HL7V26Field _messageWaitingPriority;

public HL7V26Field MessageWaitingPriority
{
    get
    {
        if (_messageWaitingPriority != null)
        {
            return _messageWaitingPriority;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"MSA.8",
            Type = @"Field",
            Position = @"MSA.8",
            Name = @"Message Waiting Priority",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0520",
            TableName = @"Message waiting priority",
            Description = @"If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).",
            Sample = @"",
            Fields = null
        }

        _messageWaitingPriority = new HL7V26Field
        {
            field = message[@"MSA"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageWaitingPriority.field.FieldRepetitions != null && _messageWaitingPriority.field.FieldRepetitions.Count > 0)
        {
            _messageWaitingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messageWaitingPriority, fieldData);
        }

        return _messageWaitingPriority;
    } 
}
    }
}

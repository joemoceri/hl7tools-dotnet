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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0008",
                            TableName = @"Acknowledgment code",
                            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0520",
                            TableName = @"Message waiting priority",
                            Description = @"If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field acknowledgmentCode;

public HL7V26Field AcknowledgmentCode
{
    get
    {
        if (acknowledgmentCode != null)
        {
            return acknowledgmentCode;
        }

        acknowledgmentCode = new HL7V26Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0008",
            TableName = @"Acknowledgment code",
            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 Table 0008 - Acknowledgment code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (acknowledgmentCode.field.FieldRepetitions != null && acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(acknowledgmentCode.Id));
            acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(acknowledgmentCode, fieldData);
        }

        return acknowledgmentCode;
    } 
}

internal HL7V26Field messageControlID;

public HL7V26Field MessageControlID
{
    get
    {
        if (messageControlID != null)
        {
            return messageControlID;
        }

        messageControlID = new HL7V26Field
        {
            field = message[@"MSA"][2],
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
        };

        // check for repetitions
        if (messageControlID.field.FieldRepetitions != null && messageControlID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageControlID.Id));
            messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(messageControlID, fieldData);
        }

        return messageControlID;
    } 
}

internal HL7V26Field textMessage;

public HL7V26Field TextMessage
{
    get
    {
        if (textMessage != null)
        {
            return textMessage;
        }

        textMessage = new HL7V26Field
        {
            field = message[@"MSA"][3],
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
        };

        // check for repetitions
        if (textMessage.field.FieldRepetitions != null && textMessage.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(textMessage.Id));
            textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(textMessage, fieldData);
        }

        return textMessage;
    } 
}

internal HL7V26Field expectedSequenceNumber;

public HL7V26Field ExpectedSequenceNumber
{
    get
    {
        if (expectedSequenceNumber != null)
        {
            return expectedSequenceNumber;
        }

        expectedSequenceNumber = new HL7V26Field
        {
            field = message[@"MSA"][4],
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
        };

        // check for repetitions
        if (expectedSequenceNumber.field.FieldRepetitions != null && expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(expectedSequenceNumber.Id));
            expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(expectedSequenceNumber, fieldData);
        }

        return expectedSequenceNumber;
    } 
}

internal HL7V26Field delayedAcknowledgmentType;

public HL7V26Field DelayedAcknowledgmentType
{
    get
    {
        if (delayedAcknowledgmentType != null)
        {
            return delayedAcknowledgmentType;
        }

        delayedAcknowledgmentType = new HL7V26Field
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
            delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(delayedAcknowledgmentType, fieldData);
        }

        return delayedAcknowledgmentType;
    } 
}

internal HL7V26Field errorCondition;

public HL7V26Field ErrorCondition
{
    get
    {
        if (errorCondition != null)
        {
            return errorCondition;
        }

        errorCondition = new HL7V26Field
        {
            field = message[@"MSA"][6],
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
        };

        // check for repetitions
        if (errorCondition.field.FieldRepetitions != null && errorCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(errorCondition.Id));
            errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(errorCondition, fieldData);
        }

        return errorCondition;
    } 
}

internal HL7V26Field messageWaitingNumber;

public HL7V26Field MessageWaitingNumber
{
    get
    {
        if (messageWaitingNumber != null)
        {
            return messageWaitingNumber;
        }

        messageWaitingNumber = new HL7V26Field
        {
            field = message[@"MSA"][7],
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
        };

        // check for repetitions
        if (messageWaitingNumber.field.FieldRepetitions != null && messageWaitingNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageWaitingNumber.Id));
            messageWaitingNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(messageWaitingNumber, fieldData);
        }

        return messageWaitingNumber;
    } 
}

internal HL7V26Field messageWaitingPriority;

public HL7V26Field MessageWaitingPriority
{
    get
    {
        if (messageWaitingPriority != null)
        {
            return messageWaitingPriority;
        }

        messageWaitingPriority = new HL7V26Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0520",
            TableName = @"Message waiting priority",
            Description = @"If present, indicates that the Sending Application has messages waiting on a queue for the Receiving Application. These messages would then need to be retrieved via a query. This facilitates receiving applications that cannot receive unsolicited messages (i.e., polling). The code specified identifies how important the most important waiting message is (and may govern how soon the receiving application is required to poll for the message).",
            Sample = @"",
        };

        // check for repetitions
        if (messageWaitingPriority.field.FieldRepetitions != null && messageWaitingPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messageWaitingPriority.Id));
            messageWaitingPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(messageWaitingPriority, fieldData);
        }

        return messageWaitingPriority;
    } 
}
    }
}

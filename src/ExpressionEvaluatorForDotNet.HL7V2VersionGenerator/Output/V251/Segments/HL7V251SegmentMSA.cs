using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentMSA
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

        public HL7V251SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _acknowledgmentCode;

public HL7V251Field AcknowledgmentCode
{
    get
    {
        if (_acknowledgmentCode != null)
        {
            return _acknowledgmentCode;
        }

        var fieldData = new HL7V251FieldData
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

        _acknowledgmentCode = new HL7V251Field
        {
            field = message[@"MSA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acknowledgmentCode.field.FieldRepetitions != null && _acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            _acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_acknowledgmentCode, fieldData);
        }

        return _acknowledgmentCode;
    } 
}

internal HL7V251Field _messageControlID;

public HL7V251Field MessageControlID
{
    get
    {
        if (_messageControlID != null)
        {
            return _messageControlID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
            Name = @"Message Control ID",
            Length = 20,
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

        _messageControlID = new HL7V251Field
        {
            field = message[@"MSA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlID.field.FieldRepetitions != null && _messageControlID.field.FieldRepetitions.Count > 0)
        {
            _messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_messageControlID, fieldData);
        }

        return _messageControlID;
    } 
}

internal HL7V251Field _textMessage;

public HL7V251Field TextMessage
{
    get
    {
        if (_textMessage != null)
        {
            return _textMessage;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This optional field further describes an error condition. This text may be printed in error logs or presented to an end user.",
            Sample = @"",
            Fields = null
        }

        _textMessage = new HL7V251Field
        {
            field = message[@"MSA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textMessage.field.FieldRepetitions != null && _textMessage.field.FieldRepetitions.Count > 0)
        {
            _textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_textMessage, fieldData);
        }

        return _textMessage;
    } 
}

internal HL7V251Field _expectedSequenceNumber;

public HL7V251Field ExpectedSequenceNumber
{
    get
    {
        if (_expectedSequenceNumber != null)
        {
            return _expectedSequenceNumber;
        }

        var fieldData = new HL7V251FieldData
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

        _expectedSequenceNumber = new HL7V251Field
        {
            field = message[@"MSA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSequenceNumber.field.FieldRepetitions != null && _expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_expectedSequenceNumber, fieldData);
        }

        return _expectedSequenceNumber;
    } 
}

internal HL7V251Field _delayedAcknowledgmentType;

public HL7V251Field DelayedAcknowledgmentType
{
    get
    {
        if (_delayedAcknowledgmentType != null)
        {
            return _delayedAcknowledgmentType;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"The MSA-5 was deprecated as of v2.2 and the detail was withdrawn and removed from the standard as of v 2.5.",
            Sample = @"",
            Fields = null
        }

        _delayedAcknowledgmentType = new HL7V251Field
        {
            field = message[@"MSA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayedAcknowledgmentType.field.FieldRepetitions != null && _delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_delayedAcknowledgmentType, fieldData);
        }

        return _delayedAcknowledgmentType;
    } 
}

internal HL7V251Field _errorCondition;

public HL7V251Field ErrorCondition
{
    get
    {
        if (_errorCondition != null)
        {
            return _errorCondition;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field allows the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgments.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSA.6.1",
                            Type = @"Component",
                            Position = @"MSA.6.1",
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
                            Id = @"MSA.6.2",
                            Type = @"Component",
                            Position = @"MSA.6.2",
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
                            Id = @"MSA.6.3",
                            Type = @"Component",
                            Position = @"MSA.6.3",
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
                            Id = @"MSA.6.4",
                            Type = @"Component",
                            Position = @"MSA.6.4",
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
                            Id = @"MSA.6.5",
                            Type = @"Component",
                            Position = @"MSA.6.5",
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
                            Id = @"MSA.6.6",
                            Type = @"Component",
                            Position = @"MSA.6.6",
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
                        }
        }

        _errorCondition = new HL7V251Field
        {
            field = message[@"MSA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCondition.field.FieldRepetitions != null && _errorCondition.field.FieldRepetitions.Count > 0)
        {
            _errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_errorCondition, fieldData);
        }

        return _errorCondition;
    } 
}
    }
}

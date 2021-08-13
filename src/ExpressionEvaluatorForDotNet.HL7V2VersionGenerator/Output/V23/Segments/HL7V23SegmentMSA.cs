using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message acknowledgement segment"; } }
        
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

        public HL7V23SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _acknowledgementcode;

public HL7V23Field Acknowledgementcode
{
    get
    {
        if (_acknowledgementcode != null)
        {
            return _acknowledgementcode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgement code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0008",
            TableName = @"Acknowledgment code",
            Description = @"This field contains an acknowledgment code, see message processing rules. Refer to HL7 table 0008 - Acknowledgment code for valid values.",
            Sample = @"",
            Fields = null
        }

        _acknowledgementcode = new HL7V23Field
        {
            field = message[@"MSA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acknowledgementcode.field.FieldRepetitions != null && _acknowledgementcode.field.FieldRepetitions.Count > 0)
        {
            _acknowledgementcode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_acknowledgementcode, fieldData);
        }

        return _acknowledgementcode;
    } 
}

internal HL7V23Field _messageControlID;

public HL7V23Field MessageControlID
{
    get
    {
        if (_messageControlID != null)
        {
            return _messageControlID;
        }

        var fieldData = new HL7V23FieldData
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

        _messageControlID = new HL7V23Field
        {
            field = message[@"MSA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlID.field.FieldRepetitions != null && _messageControlID.field.FieldRepetitions.Count > 0)
        {
            _messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_messageControlID, fieldData);
        }

        return _messageControlID;
    } 
}

internal HL7V23Field _textMessage;

public HL7V23Field TextMessage
{
    get
    {
        if (_textMessage != null)
        {
            return _textMessage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSA.3",
            Type = @"Field",
            Position = @"MSA.3",
            Name = @"Text Message",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This optional field further describes an error condition. This text may be printed in error logs or presented to an end user.",
            Sample = @"",
            Fields = null
        }

        _textMessage = new HL7V23Field
        {
            field = message[@"MSA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textMessage.field.FieldRepetitions != null && _textMessage.field.FieldRepetitions.Count > 0)
        {
            _textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_textMessage, fieldData);
        }

        return _textMessage;
    } 
}

internal HL7V23Field _expectedSequenceNumber;

public HL7V23Field ExpectedSequenceNumber
{
    get
    {
        if (_expectedSequenceNumber != null)
        {
            return _expectedSequenceNumber;
        }

        var fieldData = new HL7V23FieldData
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

        _expectedSequenceNumber = new HL7V23Field
        {
            field = message[@"MSA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSequenceNumber.field.FieldRepetitions != null && _expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_expectedSequenceNumber, fieldData);
        }

        return _expectedSequenceNumber;
    } 
}

internal HL7V23Field _delayedAcknowledgementType;

public HL7V23Field DelayedAcknowledgementType
{
    get
    {
        if (_delayedAcknowledgementType != null)
        {
            return _delayedAcknowledgementType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgement Type",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0102",
            TableName = @"Delayed Acknowledgment Type",
            Description = @"This field has been retained for backward compatibility. This field is used only as described above, in Section 2.12.2, “Application (level 7) processing rules, deferred processing two phase reply (original acknowledgment mode only).” Otherwise this field is not used.",
            Sample = @"",
            Fields = null
        }

        _delayedAcknowledgementType = new HL7V23Field
        {
            field = message[@"MSA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayedAcknowledgementType.field.FieldRepetitions != null && _delayedAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            _delayedAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_delayedAcknowledgementType, fieldData);
        }

        return _delayedAcknowledgementType;
    } 
}

internal HL7V23Field _errorCondition;

public HL7V23Field ErrorCondition
{
    get
    {
        if (_errorCondition != null)
        {
            return _errorCondition;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSA.6",
            Type = @"Field",
            Position = @"MSA.6",
            Name = @"Error Condition",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field allows the acknowledging system to use a user-defined error code to further specify AR or AE type acknowledgments. This field is a generalized replacement for MSA-3-text message.",
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
                            Id = @"MSA.6.2",
                            Type = @"Component",
                            Position = @"MSA.6.2",
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
                            Id = @"MSA.6.3",
                            Type = @"Component",
                            Position = @"MSA.6.3",
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
                            Id = @"MSA.6.4",
                            Type = @"Component",
                            Position = @"MSA.6.4",
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
                            Id = @"MSA.6.5",
                            Type = @"Component",
                            Position = @"MSA.6.5",
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
                            Id = @"MSA.6.6",
                            Type = @"Component",
                            Position = @"MSA.6.6",
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
                        },
                        }
        }

        _errorCondition = new HL7V23Field
        {
            field = message[@"MSA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_errorCondition.field.FieldRepetitions != null && _errorCondition.field.FieldRepetitions.Count > 0)
        {
            _errorCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_errorCondition, fieldData);
        }

        return _errorCondition;
    } 
}
    }
}

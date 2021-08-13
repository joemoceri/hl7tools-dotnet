using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMSA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSA"; } }

        public string SegmentId { get { return @"MSA"; } }
        
        public string LongName { get { return @"Message Acknowledgment"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentMSA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _acknowledgmentCode;

public HL7V21Field AcknowledgmentCode
{
    get
    {
        if (_acknowledgmentCode != null)
        {
            return _acknowledgmentCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSA.1",
            Type = @"Field",
            Position = @"MSA.1",
            Name = @"Acknowledgment Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0008",
            TableName = @"ACKNOWLEDGMENT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _acknowledgmentCode = new HL7V21Field
        {
            field = message[@"MSA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acknowledgmentCode.field.FieldRepetitions != null && _acknowledgmentCode.field.FieldRepetitions.Count > 0)
        {
            _acknowledgmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_acknowledgmentCode, fieldData);
        }

        return _acknowledgmentCode;
    } 
}

internal HL7V21Field _messageControlId;

public HL7V21Field MessageControlId
{
    get
    {
        if (_messageControlId != null)
        {
            return _messageControlId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSA.2",
            Type = @"Field",
            Position = @"MSA.2",
            Name = @"Message Control Id",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _messageControlId = new HL7V21Field
        {
            field = message[@"MSA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlId.field.FieldRepetitions != null && _messageControlId.field.FieldRepetitions.Count > 0)
        {
            _messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_messageControlId, fieldData);
        }

        return _messageControlId;
    } 
}

internal HL7V21Field _textMessage;

public HL7V21Field TextMessage
{
    get
    {
        if (_textMessage != null)
        {
            return _textMessage;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _textMessage = new HL7V21Field
        {
            field = message[@"MSA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textMessage.field.FieldRepetitions != null && _textMessage.field.FieldRepetitions.Count > 0)
        {
            _textMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_textMessage, fieldData);
        }

        return _textMessage;
    } 
}

internal HL7V21Field _expectedSequenceNumber;

public HL7V21Field ExpectedSequenceNumber
{
    get
    {
        if (_expectedSequenceNumber != null)
        {
            return _expectedSequenceNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _expectedSequenceNumber = new HL7V21Field
        {
            field = message[@"MSA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedSequenceNumber.field.FieldRepetitions != null && _expectedSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _expectedSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_expectedSequenceNumber, fieldData);
        }

        return _expectedSequenceNumber;
    } 
}

internal HL7V21Field _delayedAcknowledgmentType;

public HL7V21Field DelayedAcknowledgmentType
{
    get
    {
        if (_delayedAcknowledgmentType != null)
        {
            return _delayedAcknowledgmentType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSA.5",
            Type = @"Field",
            Position = @"MSA.5",
            Name = @"Delayed Acknowledgment Type",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0102",
            TableName = @"DELAYED ACKNOWLEDGMENT TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _delayedAcknowledgmentType = new HL7V21Field
        {
            field = message[@"MSA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayedAcknowledgmentType.field.FieldRepetitions != null && _delayedAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _delayedAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_delayedAcknowledgmentType, fieldData);
        }

        return _delayedAcknowledgmentType;
    } 
}
    }
}

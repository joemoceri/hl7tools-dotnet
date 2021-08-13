using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message Header"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _fieldSeparator;

public HL7V21Field FieldSeparator
{
    get
    {
        if (_fieldSeparator != null)
        {
            return _fieldSeparator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.1",
            Type = @"Field",
            Position = @"MSH.1",
            Name = @"Field Separator",
            Length = 1,
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

        _fieldSeparator = new HL7V21Field
        {
            field = message[@"MSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fieldSeparator.field.FieldRepetitions != null && _fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_fieldSeparator, fieldData);
        }

        return _fieldSeparator;
    } 
}

internal HL7V21Field _encodingCharacters;

public HL7V21Field EncodingCharacters
{
    get
    {
        if (_encodingCharacters != null)
        {
            return _encodingCharacters;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.2",
            Type = @"Field",
            Position = @"MSH.2",
            Name = @"Encoding Characters",
            Length = 4,
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

        _encodingCharacters = new HL7V21Field
        {
            field = message[@"MSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_encodingCharacters.field.FieldRepetitions != null && _encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_encodingCharacters, fieldData);
        }

        return _encodingCharacters;
    } 
}

internal HL7V21Field _sendingApplication;

public HL7V21Field SendingApplication
{
    get
    {
        if (_sendingApplication != null)
        {
            return _sendingApplication;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 15,
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

        _sendingApplication = new HL7V21Field
        {
            field = message[@"MSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingApplication.field.FieldRepetitions != null && _sendingApplication.field.FieldRepetitions.Count > 0)
        {
            _sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_sendingApplication, fieldData);
        }

        return _sendingApplication;
    } 
}

internal HL7V21Field _sendingFacility;

public HL7V21Field SendingFacility
{
    get
    {
        if (_sendingFacility != null)
        {
            return _sendingFacility;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 20,
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

        _sendingFacility = new HL7V21Field
        {
            field = message[@"MSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingFacility.field.FieldRepetitions != null && _sendingFacility.field.FieldRepetitions.Count > 0)
        {
            _sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_sendingFacility, fieldData);
        }

        return _sendingFacility;
    } 
}

internal HL7V21Field _receivingApplication;

public HL7V21Field ReceivingApplication
{
    get
    {
        if (_receivingApplication != null)
        {
            return _receivingApplication;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 15,
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

        _receivingApplication = new HL7V21Field
        {
            field = message[@"MSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingApplication.field.FieldRepetitions != null && _receivingApplication.field.FieldRepetitions.Count > 0)
        {
            _receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_receivingApplication, fieldData);
        }

        return _receivingApplication;
    } 
}

internal HL7V21Field _receivingFacility;

public HL7V21Field ReceivingFacility
{
    get
    {
        if (_receivingFacility != null)
        {
            return _receivingFacility;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 30,
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

        _receivingFacility = new HL7V21Field
        {
            field = message[@"MSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingFacility.field.FieldRepetitions != null && _receivingFacility.field.FieldRepetitions.Count > 0)
        {
            _receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_receivingFacility, fieldData);
        }

        return _receivingFacility;
    } 
}

internal HL7V21Field _dateTimeOfMessage;

public HL7V21Field DateTimeOfMessage
{
    get
    {
        if (_dateTimeOfMessage != null)
        {
            return _dateTimeOfMessage;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
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

        _dateTimeOfMessage = new HL7V21Field
        {
            field = message[@"MSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfMessage.field.FieldRepetitions != null && _dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateTimeOfMessage, fieldData);
        }

        return _dateTimeOfMessage;
    } 
}

internal HL7V21Field _security;

public HL7V21Field Security
{
    get
    {
        if (_security != null)
        {
            return _security;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.8",
            Type = @"Field",
            Position = @"MSH.8",
            Name = @"Security",
            Length = 40,
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

        _security = new HL7V21Field
        {
            field = message[@"MSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_security.field.FieldRepetitions != null && _security.field.FieldRepetitions.Count > 0)
        {
            _security.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_security, fieldData);
        }

        return _security;
    } 
}

internal HL7V21Field _messageType;

public HL7V21Field MessageType
{
    get
    {
        if (_messageType != null)
        {
            return _messageType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 7,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0076",
            TableName = @"MESSAGE TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _messageType = new HL7V21Field
        {
            field = message[@"MSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageType.field.FieldRepetitions != null && _messageType.field.FieldRepetitions.Count > 0)
        {
            _messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_messageType, fieldData);
        }

        return _messageType;
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
            Id = @"MSH.10",
            Type = @"Field",
            Position = @"MSH.10",
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
            field = message[@"MSH"][10],
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

internal HL7V21Field _processingId;

public HL7V21Field ProcessingId
{
    get
    {
        if (_processingId != null)
        {
            return _processingId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.11",
            Type = @"Field",
            Position = @"MSH.11",
            Name = @"Processing Id",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0103",
            TableName = @"PROCESSING ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _processingId = new HL7V21Field
        {
            field = message[@"MSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingId.field.FieldRepetitions != null && _processingId.field.FieldRepetitions.Count > 0)
        {
            _processingId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_processingId, fieldData);
        }

        return _processingId;
    } 
}

internal HL7V21Field _versionId;

public HL7V21Field VersionId
{
    get
    {
        if (_versionId != null)
        {
            return _versionId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version Id",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = @"0104",
            TableName = @"VERSION CONTROL TABLE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _versionId = new HL7V21Field
        {
            field = message[@"MSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_versionId.field.FieldRepetitions != null && _versionId.field.FieldRepetitions.Count > 0)
        {
            _versionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_versionId, fieldData);
        }

        return _versionId;
    } 
}

internal HL7V21Field _sequenceNumber;

public HL7V21Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.13",
            Type = @"Field",
            Position = @"MSH.13",
            Name = @"Sequence Number",
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

        _sequenceNumber = new HL7V21Field
        {
            field = message[@"MSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V21Field _continuationPointer;

public HL7V21Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"MSH.14",
            Type = @"Field",
            Position = @"MSH.14",
            Name = @"Continuation Pointer",
            Length = 180,
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

        _continuationPointer = new HL7V21Field
        {
            field = message[@"MSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}
    }
}

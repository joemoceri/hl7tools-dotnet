using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message Header"; } }
        
        public string Description { get { return @"The MSH segment defines the intent, source, destination, and some specifics of the syntax of a message.

Note: If MSH-15 and MSH-16 are omitted (or are both null), the original Acknowledgement Mode rules are used. "; } }
        
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

        public HL7V22SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _fieldSeparator;

public HL7V22Field FieldSeparator
{
    get
    {
        if (_fieldSeparator != null)
        {
            return _fieldSeparator;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"actually the separator between the segment ID and the first real field, MSH-2-encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |.",
            Sample = @"",
            Fields = null
        }

        _fieldSeparator = new HL7V22Field
        {
            field = message[@"MSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fieldSeparator.field.FieldRepetitions != null && _fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_fieldSeparator, fieldData);
        }

        return _fieldSeparator;
    } 
}

internal HL7V22Field _encodingCharacters;

public HL7V22Field EncodingCharacters
{
    get
    {
        if (_encodingCharacters != null)
        {
            return _encodingCharacters;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator.  Recommended values are ^~\&. ",
            Sample = @"",
            Fields = null
        }

        _encodingCharacters = new HL7V22Field
        {
            field = message[@"MSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_encodingCharacters.field.FieldRepetitions != null && _encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_encodingCharacters, fieldData);
        }

        return _encodingCharacters;
    } 
}

internal HL7V22Field _sendingApplication;

public HL7V22Field SendingApplication
{
    get
    {
        if (_sendingApplication != null)
        {
            return _sendingApplication;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"available for interface with lower level protocols",
            Sample = @"",
            Fields = null
        }

        _sendingApplication = new HL7V22Field
        {
            field = message[@"MSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingApplication.field.FieldRepetitions != null && _sendingApplication.field.FieldRepetitions.Count > 0)
        {
            _sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sendingApplication, fieldData);
        }

        return _sendingApplication;
    } 
}

internal HL7V22Field _sendingFacility;

public HL7V22Field SendingFacility
{
    get
    {
        if (_sendingFacility != null)
        {
            return _sendingFacility;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"addresses one of several occurrences of the same application within the sending system.  Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component.  Entirely site-defined",
            Sample = @"",
            Fields = null
        }

        _sendingFacility = new HL7V22Field
        {
            field = message[@"MSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingFacility.field.FieldRepetitions != null && _sendingFacility.field.FieldRepetitions.Count > 0)
        {
            _sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sendingFacility, fieldData);
        }

        return _sendingFacility;
    } 
}

internal HL7V22Field _receivingApplication;

public HL7V22Field ReceivingApplication
{
    get
    {
        if (_receivingApplication != null)
        {
            return _receivingApplication;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"available for interface with lower level protocols",
            Sample = @"",
            Fields = null
        }

        _receivingApplication = new HL7V22Field
        {
            field = message[@"MSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingApplication.field.FieldRepetitions != null && _receivingApplication.field.FieldRepetitions.Count > 0)
        {
            _receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_receivingApplication, fieldData);
        }

        return _receivingApplication;
    } 
}

internal HL7V22Field _receivingFacility;

public HL7V22Field ReceivingFacility
{
    get
    {
        if (_receivingFacility != null)
        {
            return _receivingFacility;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"identifies the receiving application among multiple identical instances of the application running on behalf of different organizations.  See comments: sending facility",
            Sample = @"",
            Fields = null
        }

        _receivingFacility = new HL7V22Field
        {
            field = message[@"MSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingFacility.field.FieldRepetitions != null && _receivingFacility.field.FieldRepetitions.Count > 0)
        {
            _receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_receivingFacility, fieldData);
        }

        return _receivingFacility;
    } 
}

internal HL7V22Field _dateTimeOfMessage;

public HL7V22Field DateTimeOfMessage
{
    get
    {
        if (_dateTimeOfMessage != null)
        {
            return _dateTimeOfMessage;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date / Time Of Message",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time that the sending system created the message.  If the time zone is specified, it will be used throughout the message as the default time zone",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.7.1",
                            Type = @"Component",
                            Position = @"MSH.7.1",
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
                            Id = @"MSH.7.2",
                            Type = @"Component",
                            Position = @"MSH.7.2",
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
                        }
        }

        _dateTimeOfMessage = new HL7V22Field
        {
            field = message[@"MSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfMessage.field.FieldRepetitions != null && _dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeOfMessage, fieldData);
        }

        return _dateTimeOfMessage;
    } 
}

internal HL7V22Field _security;

public HL7V22Field Security
{
    get
    {
        if (_security != null)
        {
            return _security;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"in some applications of HL7 this field will be used to implement security features.  Its use is not yet further specified",
            Sample = @"",
            Fields = null
        }

        _security = new HL7V22Field
        {
            field = message[@"MSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_security.field.FieldRepetitions != null && _security.field.FieldRepetitions.Count > 0)
        {
            _security.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_security, fieldData);
        }

        return _security;
    } 
}

internal HL7V22Field _messageType;

public HL7V22Field MessageType
{
    get
    {
        if (_messageType != null)
        {
            return _messageType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 7,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CM_MSG",
            DataTypeName = @"Message Type",
            TableId = null,
            TableName = null,
            Description = @"first component is the message type edited by table 0076 - message type; second is the trigger event code edited by table 0003 - event type code.  Receiving system uses this field to know the data segments to recognize, and possibly, the application to which to route this message.  For certain queries, which may have more than a single response event type, the second component may, in the response message, vary to indicate the response event type.  See the discussion of the display query variants in Section 2.8.6.1.1.  The second component is not required on response or acknowledgement messages",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.9.1",
                            Type = @"Component",
                            Position = @"MSH.9.1",
                            Name = @"Message Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0076",
                            TableName = @"MESSAGE TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.2",
                            Type = @"Component",
                            Position = @"MSH.9.2",
                            Name = @"Trigger Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0003",
                            TableName = @"EVENT TYPE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageType = new HL7V22Field
        {
            field = message[@"MSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageType.field.FieldRepetitions != null && _messageType.field.FieldRepetitions.Count > 0)
        {
            _messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_messageType, fieldData);
        }

        return _messageType;
    } 
}

internal HL7V22Field _messageControlId;

public HL7V22Field MessageControlId
{
    get
    {
        if (_messageControlId != null)
        {
            return _messageControlId;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"number or other identifier that uniquely identifies the message.  The receiving system echoes this ID back to the sending system in the Message Acknowledgement segment (MSA).",
            Sample = @"",
            Fields = null
        }

        _messageControlId = new HL7V22Field
        {
            field = message[@"MSH"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlId.field.FieldRepetitions != null && _messageControlId.field.FieldRepetitions.Count > 0)
        {
            _messageControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_messageControlId, fieldData);
        }

        return _messageControlId;
    } 
}

internal HL7V22Field _processingId;

public HL7V22Field ProcessingId
{
    get
    {
        if (_processingId != null)
        {
            return _processingId;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"used to decide whether to process the message as defined in HL7 Application (level 7)  Processing rules.",
            Sample = @"",
            Fields = null
        }

        _processingId = new HL7V22Field
        {
            field = message[@"MSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingId.field.FieldRepetitions != null && _processingId.field.FieldRepetitions.Count > 0)
        {
            _processingId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_processingId, fieldData);
        }

        return _processingId;
    } 
}

internal HL7V22Field _versionId;

public HL7V22Field VersionId
{
    get
    {
        if (_versionId != null)
        {
            return _versionId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version Id",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0104",
            TableName = @"VERSION ID",
            Description = @"matched by the receiving system to its own version to be sure the message will be interpreted correctly",
            Sample = @"",
            Fields = null
        }

        _versionId = new HL7V22Field
        {
            field = message[@"MSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_versionId.field.FieldRepetitions != null && _versionId.field.FieldRepetitions.Count > 0)
        {
            _versionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_versionId, fieldData);
        }

        return _versionId;
    } 
}

internal HL7V22Field _sequenceNumber;

public HL7V22Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"non-null value in this field implies that the sequence number protocol is in use.  This numeric field incremented by one for each subsequent value",
            Sample = @"",
            Fields = null
        }

        _sequenceNumber = new HL7V22Field
        {
            field = message[@"MSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V22Field _continuationPointer;

public HL7V22Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"used to define continuations in application-specific ways",
            Sample = @"",
            Fields = null
        }

        _continuationPointer = new HL7V22Field
        {
            field = message[@"MSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}

internal HL7V22Field _acceptAcknowledgementType;

public HL7V22Field AcceptAcknowledgementType
{
    get
    {
        if (_acceptAcknowledgementType != null)
        {
            return _acceptAcknowledgementType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.15",
            Type = @"Field",
            Position = @"MSH.15",
            Name = @"Accept Acknowledgement Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0155",
            TableName = @"ACCEPT/APPLICATION ACKNOWLEDGEMENT CONDITIONS",
            Description = @"defines the conditions under which accept acknowledgements are required to be returned in response to this message.  Required for enhanced acknowledgement mode.  Refer to table 0155 - acknowledgement conditions for valid values",
            Sample = @"",
            Fields = null
        }

        _acceptAcknowledgementType = new HL7V22Field
        {
            field = message[@"MSH"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acceptAcknowledgementType.field.FieldRepetitions != null && _acceptAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            _acceptAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_acceptAcknowledgementType, fieldData);
        }

        return _acceptAcknowledgementType;
    } 
}

internal HL7V22Field _applicationAcknowledgementType;

public HL7V22Field ApplicationAcknowledgementType
{
    get
    {
        if (_applicationAcknowledgementType != null)
        {
            return _applicationAcknowledgementType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.16",
            Type = @"Field",
            Position = @"MSH.16",
            Name = @"Application Acknowledgement Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0155",
            TableName = @"ACCEPT/APPLICATION ACKNOWLEDGEMENT CONDITIONS",
            Description = @"defines the conditions under which  application  acknowledgements are required to be returned in response to this message.  Required for enhanced acknowledgement mode",
            Sample = @"",
            Fields = null
        }

        _applicationAcknowledgementType = new HL7V22Field
        {
            field = message[@"MSH"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationAcknowledgementType.field.FieldRepetitions != null && _applicationAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            _applicationAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_applicationAcknowledgementType, fieldData);
        }

        return _applicationAcknowledgementType;
    } 
}

internal HL7V22Field _countryCode;

public HL7V22Field CountryCode
{
    get
    {
        if (_countryCode != null)
        {
            return _countryCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"MSH.17",
            Type = @"Field",
            Position = @"MSH.17",
            Name = @"Country Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"ISO3166",
            TableName = @"Country Codes",
            Description = @"defines the country of origin for the message.  It will be used primarily to specify default elements, such as currency denominations.   ISO 3166 provides a list of country codes that may be used.",
            Sample = @"",
            Fields = null
        }

        _countryCode = new HL7V22Field
        {
            field = message[@"MSH"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countryCode.field.FieldRepetitions != null && _countryCode.field.FieldRepetitions.Count > 0)
        {
            _countryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_countryCode, fieldData);
        }

        return _countryCode;
    } 
}
    }
}

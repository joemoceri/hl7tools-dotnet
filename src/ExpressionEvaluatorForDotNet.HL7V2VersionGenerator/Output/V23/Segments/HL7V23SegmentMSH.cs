using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message header segment"; } }
        
        public string Description { get { return @"The MSH segment defines the intent, source, destination, and some specifics of the syntax of a message"; } }
        
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

        public HL7V23SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _fieldSeparator;

public HL7V23Field FieldSeparator
{
    get
    {
        if (_fieldSeparator != null)
        {
            return _fieldSeparator;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2encoding characters.  As such it serves as the separator and defines the character to be used as a separator for the rest of the message.  Recommended value is |, (ASCII 124). ",
            Sample = @"",
            Fields = null
        }

        _fieldSeparator = new HL7V23Field
        {
            field = message[@"MSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fieldSeparator.field.FieldRepetitions != null && _fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fieldSeparator, fieldData);
        }

        return _fieldSeparator;
    } 
}

internal HL7V23Field _encodingCharacters;

public HL7V23Field EncodingCharacters
{
    get
    {
        if (_encodingCharacters != null)
        {
            return _encodingCharacters;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator.  Recommended values are ^~\&, (ASCII 94, 126, 92, and 38, respectively).  See Section 2.7, “MESSAGE DELIMITERS.” ",
            Sample = @"",
            Fields = null
        }

        _encodingCharacters = new HL7V23Field
        {
            field = message[@"MSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_encodingCharacters.field.FieldRepetitions != null && _encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_encodingCharacters, fieldData);
        }

        return _encodingCharacters;
    } 
}

internal HL7V23Field _sendingApplication;

public HL7V23Field SendingApplication
{
    get
    {
        if (_sendingApplication != null)
        {
            return _sendingApplication;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.3.1",
                            Type = @"Component",
                            Position = @"MSH.3.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.2",
                            Type = @"Component",
                            Position = @"MSH.3.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.3",
                            Type = @"Component",
                            Position = @"MSH.3.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingApplication = new HL7V23Field
        {
            field = message[@"MSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingApplication.field.FieldRepetitions != null && _sendingApplication.field.FieldRepetitions.Count > 0)
        {
            _sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sendingApplication, fieldData);
        }

        return _sendingApplication;
    } 
}

internal HL7V23Field _sendingFacility;

public HL7V23Field SendingFacility
{
    get
    {
        if (_sendingFacility != null)
        {
            return _sendingFacility;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field contains the address of one of several occurrences of the same application within the sending system.  Absent other considerations, the Medicare Provider ID might be used with an appropriate sub-identifier in the second component.  Entirely user-defined",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.4.1",
                            Type = @"Component",
                            Position = @"MSH.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.2",
                            Type = @"Component",
                            Position = @"MSH.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.3",
                            Type = @"Component",
                            Position = @"MSH.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingFacility = new HL7V23Field
        {
            field = message[@"MSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingFacility.field.FieldRepetitions != null && _sendingFacility.field.FieldRepetitions.Count > 0)
        {
            _sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sendingFacility, fieldData);
        }

        return _sendingFacility;
    } 
}

internal HL7V23Field _receivingApplication;

public HL7V23Field ReceivingApplication
{
    get
    {
        if (_receivingApplication != null)
        {
            return _receivingApplication;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise.  The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise.  Entirely site-defined. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.5.1",
                            Type = @"Component",
                            Position = @"MSH.5.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.2",
                            Type = @"Component",
                            Position = @"MSH.5.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.3",
                            Type = @"Component",
                            Position = @"MSH.5.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingApplication = new HL7V23Field
        {
            field = message[@"MSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingApplication.field.FieldRepetitions != null && _receivingApplication.field.FieldRepetitions.Count > 0)
        {
            _receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_receivingApplication, fieldData);
        }

        return _receivingApplication;
    } 
}

internal HL7V23Field _receivingFacility;

public HL7V23Field ReceivingFacility
{
    get
    {
        if (_receivingFacility != null)
        {
            return _receivingFacility;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 180,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations.  See comments: MSH-4-sending facility.  Entirely site-defined. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.6.1",
                            Type = @"Component",
                            Position = @"MSH.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.2",
                            Type = @"Component",
                            Position = @"MSH.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.3",
                            Type = @"Component",
                            Position = @"MSH.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingFacility = new HL7V23Field
        {
            field = message[@"MSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingFacility.field.FieldRepetitions != null && _receivingFacility.field.FieldRepetitions.Count > 0)
        {
            _receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_receivingFacility, fieldData);
        }

        return _receivingFacility;
    } 
}

internal HL7V23Field _dateTimeofMessage;

public HL7V23Field DateTimeofMessage
{
    get
    {
        if (_dateTimeofMessage != null)
        {
            return _dateTimeofMessage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date / Time of Message",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message.  If the time zone is specified, it will be used throughout the message as the default time zone",
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
                        }
        }

        _dateTimeofMessage = new HL7V23Field
        {
            field = message[@"MSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeofMessage.field.FieldRepetitions != null && _dateTimeofMessage.field.FieldRepetitions.Count > 0)
        {
            _dateTimeofMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dateTimeofMessage, fieldData);
        }

        return _dateTimeofMessage;
    } 
}

internal HL7V23Field _security;

public HL7V23Field Security
{
    get
    {
        if (_security != null)
        {
            return _security;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"In some applications of HL7, this field is used to implement security features.  Its use is not yet further specified. ",
            Sample = @"",
            Fields = null
        }

        _security = new HL7V23Field
        {
            field = message[@"MSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_security.field.FieldRepetitions != null && _security.field.FieldRepetitions.Count > 0)
        {
            _security.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_security, fieldData);
        }

        return _security;
    } 
}

internal HL7V23Field _messageType;

public HL7V23Field MessageType
{
    get
    {
        if (_messageType != null)
        {
            return _messageType;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @" This field contains the message type and trigger event for the message.  The first component is the message type edited by HL7 table 0076 - Message type; second is the trigger event code edited by HL7 table 0003 - Event type.

The receiving system uses this field to know the data segments to recognize, and possibly, the application to which to route this message.  For certain queries, which may have more than a single response event type, the second component may, in the response message, vary to indicate the response event type.  See the discussion of the display query variants in Section 2.17.1.1, “Original mode display query variants.”  The second component is not required on response or acknowledgment messages",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"The first component is the message type edited by HL7 table 0076 - Message type",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"The second is the trigger event code edited by HL7 table 0003 - Event type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageType = new HL7V23Field
        {
            field = message[@"MSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageType.field.FieldRepetitions != null && _messageType.field.FieldRepetitions.Count > 0)
        {
            _messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_messageType, fieldData);
        }

        return _messageType;
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
            Id = @"MSH.10",
            Type = @"Field",
            Position = @"MSH.10",
            Name = @"Message Control ID",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number or other identifier that uniquely identifies the message.  The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA). ",
            Sample = @"",
            Fields = null
        }

        _messageControlID = new HL7V23Field
        {
            field = message[@"MSH"][10],
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

internal HL7V23Field _processingID;

public HL7V23Field ProcessingID
{
    get
    {
        if (_processingID != null)
        {
            return _processingID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.11",
            Type = @"Field",
            Position = @"MSH.11",
            Name = @"Processing ID",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PT",
            DataTypeName = @"Processing Type",
            TableId = null,
            TableName = null,
            Description = @" This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules, above.  The first component defines whether the message is part of a production, training, or debugging system (refer to HL7 table 0103 - Processing ID for valid values).  The second component defines whether the message is part of an archival process or an initial load (refer to HL7 table 0207 - Processing mode for valid values).  This allows different priorities to be given to different processing modes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.11.1",
                            Type = @"Component",
                            Position = @"MSH.11.1",
                            Name = @"Processing ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0103",
                            TableName = @"Processing ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system.  Refer to HL7 table 0103 - Processing ID for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.11.2",
                            Type = @"Component",
                            Position = @"MSH.11.2",
                            Name = @"Processing Mode",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load.  Refer to HL7 table 0207 - Processing mode for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _processingID = new HL7V23Field
        {
            field = message[@"MSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingID.field.FieldRepetitions != null && _processingID.field.FieldRepetitions.Count > 0)
        {
            _processingID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_processingID, fieldData);
        }

        return _processingID;
    } 
}

internal HL7V23Field _versionID;

public HL7V23Field VersionID
{
    get
    {
        if (_versionID != null)
        {
            return _versionID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version ID",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0104",
            TableName = @"Version ID",
            Description = @" This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly",
            Sample = @"",
            Fields = null
        }

        _versionID = new HL7V23Field
        {
            field = message[@"MSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_versionID.field.FieldRepetitions != null && _versionID.field.FieldRepetitions.Count > 0)
        {
            _versionID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_versionID, fieldData);
        }

        return _versionID;
    } 
}

internal HL7V23Field _sequenceNumber;

public HL7V23Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @" A non-null value in this field implies that the sequence number protocol is in use.  This numeric field is incremented by one for each subsequent value",
            Sample = @"",
            Fields = null
        }

        _sequenceNumber = new HL7V23Field
        {
            field = message[@"MSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V23Field _continuationPointer;

public HL7V23Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field is used to define continuations in application-specific ways",
            Sample = @"",
            Fields = null
        }

        _continuationPointer = new HL7V23Field
        {
            field = message[@"MSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}

internal HL7V23Field _acceptAcknowledgementType;

public HL7V23Field AcceptAcknowledgementType
{
    get
    {
        if (_acceptAcknowledgementType != null)
        {
            return _acceptAcknowledgementType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.15",
            Type = @"Field",
            Position = @"MSH.15",
            Name = @"Accept Acknowledgement Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message.  Required for enhanced acknowledgment mode.  Refer to HL7 table 0155 - Accept/application acknowledgment conditions for valid values",
            Sample = @"",
            Fields = null
        }

        _acceptAcknowledgementType = new HL7V23Field
        {
            field = message[@"MSH"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acceptAcknowledgementType.field.FieldRepetitions != null && _acceptAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            _acceptAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_acceptAcknowledgementType, fieldData);
        }

        return _acceptAcknowledgementType;
    } 
}

internal HL7V23Field _applicationAcknowledgementType;

public HL7V23Field ApplicationAcknowledgementType
{
    get
    {
        if (_applicationAcknowledgementType != null)
        {
            return _applicationAcknowledgementType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.16",
            Type = @"Field",
            Position = @"MSH.16",
            Name = @"Application Acknowledgement Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message.  Required for enhanced acknowledgment mode.  
The following table contains the possible values for MSH-15-accept acknowledgment type and MSH-16application acknowledgment type",
            Sample = @"",
            Fields = null
        }

        _applicationAcknowledgementType = new HL7V23Field
        {
            field = message[@"MSH"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationAcknowledgementType.field.FieldRepetitions != null && _applicationAcknowledgementType.field.FieldRepetitions.Count > 0)
        {
            _applicationAcknowledgementType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_applicationAcknowledgementType, fieldData);
        }

        return _applicationAcknowledgementType;
    } 
}

internal HL7V23Field _countryCode;

public HL7V23Field CountryCode
{
    get
    {
        if (_countryCode != null)
        {
            return _countryCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.17",
            Type = @"Field",
            Position = @"MSH.17",
            Name = @"Country Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"ISO3166",
            TableName = @"Country Codes",
            Description = @"This field contains the country of origin for the message.  It will be used primarily to specify default elements, such as currency denominations.  ISO 3166 provides a list of country codes that may be used",
            Sample = @"",
            Fields = null
        }

        _countryCode = new HL7V23Field
        {
            field = message[@"MSH"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countryCode.field.FieldRepetitions != null && _countryCode.field.FieldRepetitions.Count > 0)
        {
            _countryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_countryCode, fieldData);
        }

        return _countryCode;
    } 
}

internal HL7V23Field _characterSet;

public HL7V23Field CharacterSet
{
    get
    {
        if (_characterSet != null)
        {
            return _characterSet;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.18",
            Type = @"Field",
            Position = @"MSH.18",
            Name = @"Character Set",
            Length = 6,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0211",
            TableName = @"Alternate character sets",
            Description = @"This field contains the character set for the entire message.  Refer to HL7 table 0211 - Alternate character sets for valid values",
            Sample = @"",
            Fields = null
        }

        _characterSet = new HL7V23Field
        {
            field = message[@"MSH"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_characterSet.field.FieldRepetitions != null && _characterSet.field.FieldRepetitions.Count > 0)
        {
            _characterSet.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_characterSet, fieldData);
        }

        return _characterSet;
    } 
}

internal HL7V23Field _principalLanguageofMessage;

public HL7V23Field PrincipalLanguageofMessage
{
    get
    {
        if (_principalLanguageofMessage != null)
        {
            return _principalLanguageofMessage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"MSH.19",
            Type = @"Field",
            Position = @"MSH.19",
            Name = @"Principal Language of Message",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the principal language of the message.  Codes come from ISO 639",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.19.1",
                            Type = @"Component",
                            Position = @"MSH.19.1",
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
                            Id = @"MSH.19.2",
                            Type = @"Component",
                            Position = @"MSH.19.2",
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
                            Id = @"MSH.19.3",
                            Type = @"Component",
                            Position = @"MSH.19.3",
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
                            Id = @"MSH.19.4",
                            Type = @"Component",
                            Position = @"MSH.19.4",
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
                            Id = @"MSH.19.5",
                            Type = @"Component",
                            Position = @"MSH.19.5",
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
                            Id = @"MSH.19.6",
                            Type = @"Component",
                            Position = @"MSH.19.6",
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

        _principalLanguageofMessage = new HL7V23Field
        {
            field = message[@"MSH"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_principalLanguageofMessage.field.FieldRepetitions != null && _principalLanguageofMessage.field.FieldRepetitions.Count > 0)
        {
            _principalLanguageofMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_principalLanguageofMessage, fieldData);
        }

        return _principalLanguageofMessage;
    } 
}
    }
}

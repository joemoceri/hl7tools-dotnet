using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message header segment"; } }
        
        public string Description { get { return @"The MSH segment defines the intent, source, destination, and some specifics of the syntax of a message."; } }
        
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

        public HL7V231SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _fieldSeparator;

public HL7V231Field FieldSeparator
{
    get
    {
        if (_fieldSeparator != null)
        {
            return _fieldSeparator;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters. As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |, (ASCII 124).",
            Sample = @"",
            Fields = null
        }

        _fieldSeparator = new HL7V231Field
        {
            field = message[@"MSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fieldSeparator.field.FieldRepetitions != null && _fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_fieldSeparator, fieldData);
        }

        return _fieldSeparator;
    } 
}

internal HL7V231Field _encodingCharacters;

public HL7V231Field EncodingCharacters
{
    get
    {
        if (_encodingCharacters != null)
        {
            return _encodingCharacters;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.7, 'MESSAGE DELIMITERS.'",
            Sample = @"",
            Fields = null
        }

        _encodingCharacters = new HL7V231Field
        {
            field = message[@"MSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_encodingCharacters.field.FieldRepetitions != null && _encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_encodingCharacters, fieldData);
        }

        return _encodingCharacters;
    } 
}

internal HL7V231Field _sendingApplication;

public HL7V231Field SendingApplication
{
    get
    {
        if (_sendingApplication != null)
        {
            return _sendingApplication;
        }

        var fieldData = new HL7V231FieldData
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
            TableId = @"0361",
            TableName = @"Sending/receiving application",
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined table 0361-Sending/receiving application is used as the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.3.1",
                            Type = @"Component",
                            Position = @"MSH.3.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.2",
                            Type = @"Component",
                            Position = @"MSH.3.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.3",
                            Type = @"Component",
                            Position = @"MSH.3.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingApplication = new HL7V231Field
        {
            field = message[@"MSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingApplication.field.FieldRepetitions != null && _sendingApplication.field.FieldRepetitions.Count > 0)
        {
            _sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sendingApplication, fieldData);
        }

        return _sendingApplication;
    } 
}

internal HL7V231Field _sendingFacility;

public HL7V231Field SendingFacility
{
    get
    {
        if (_sendingFacility != null)
        {
            return _sendingFacility;
        }

        var fieldData = new HL7V231FieldData
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
            TableId = @"0362",
            TableName = @"Sending/receiving facility",
            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendor's identifier, etc. Entirely site-defined. User-defined table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.4.1",
                            Type = @"Component",
                            Position = @"MSH.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.2",
                            Type = @"Component",
                            Position = @"MSH.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.3",
                            Type = @"Component",
                            Position = @"MSH.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingFacility = new HL7V231Field
        {
            field = message[@"MSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingFacility.field.FieldRepetitions != null && _sendingFacility.field.FieldRepetitions.Count > 0)
        {
            _sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sendingFacility, fieldData);
        }

        return _sendingFacility;
    } 
}

internal HL7V231Field _receivingApplication;

public HL7V231Field ReceivingApplication
{
    get
    {
        if (_receivingApplication != null)
        {
            return _receivingApplication;
        }

        var fieldData = new HL7V231FieldData
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
            TableId = @"0361",
            TableName = @"Sending/receiving application",
            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined table 0361-Sending/receiving application is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.5.1",
                            Type = @"Component",
                            Position = @"MSH.5.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.2",
                            Type = @"Component",
                            Position = @"MSH.5.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.3",
                            Type = @"Component",
                            Position = @"MSH.5.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingApplication = new HL7V231Field
        {
            field = message[@"MSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingApplication.field.FieldRepetitions != null && _receivingApplication.field.FieldRepetitions.Count > 0)
        {
            _receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_receivingApplication, fieldData);
        }

        return _receivingApplication;
    } 
}

internal HL7V231Field _receivingFacility;

public HL7V231Field ReceivingFacility
{
    get
    {
        if (_receivingFacility != null)
        {
            return _receivingFacility;
        }

        var fieldData = new HL7V231FieldData
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
            TableId = @"0362",
            TableName = @"Sending/receiving facility",
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined table 0362 - Sending/receiving facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.6.1",
                            Type = @"Component",
                            Position = @"MSH.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.2",
                            Type = @"Component",
                            Position = @"MSH.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.3",
                            Type = @"Component",
                            Position = @"MSH.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingFacility = new HL7V231Field
        {
            field = message[@"MSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingFacility.field.FieldRepetitions != null && _receivingFacility.field.FieldRepetitions.Count > 0)
        {
            _receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_receivingFacility, fieldData);
        }

        return _receivingFacility;
    } 
}

internal HL7V231Field _dateTimeOfMessage;

public HL7V231Field DateTimeOfMessage
{
    get
    {
        if (_dateTimeOfMessage != null)
        {
            return _dateTimeOfMessage;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the sending system created the message. If the time zone is specified, it will be used throughout the message as the default time zone.",
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

        _dateTimeOfMessage = new HL7V231Field
        {
            field = message[@"MSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfMessage.field.FieldRepetitions != null && _dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateTimeOfMessage, fieldData);
        }

        return _dateTimeOfMessage;
    } 
}

internal HL7V231Field _security;

public HL7V231Field Security
{
    get
    {
        if (_security != null)
        {
            return _security;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"In some applications of HL7, this field is used to implement security features. Its use is not yet further specified.",
            Sample = @"",
            Fields = null
        }

        _security = new HL7V231Field
        {
            field = message[@"MSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_security.field.FieldRepetitions != null && _security.field.FieldRepetitions.Count > 0)
        {
            _security.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_security, fieldData);
        }

        return _security;
    } 
}

internal HL7V231Field _messageType;

public HL7V231Field MessageType
{
    get
    {
        if (_messageType != null)
        {
            return _messageType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 7,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"MSG",
            DataTypeName = @"Message Type",
            TableId = null,
            TableName = null,
            Description = @"This field contains the message type, trigger event, and the message structure ID for the message.",
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
                            Description = @"The first component is the message type code defined by HL7 table 0076 - Message type",
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
                            Description = @"The second component is the trigger event code defined by HL7 table 0003 - Event type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.3",
                            Type = @"Component",
                            Position = @"MSH.9.3",
                            Name = @"Message Structure",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = @"The third component is the abstract message structure code defined by HL7 Table 0354 - Message structure.  This table has two columns.  The first column contains the value of this code, which describes a particular HL7 “abstract message structure definition” in terms of segments, as defined in sections 2.11 and 2.11.1.  The second column of table 0354 lists the various HL7 trigger events that use the particular abstract message definition.  For example, the message structure code ADT_A01 describes the single abstract message structure used by the trigger events A01, A04, A05, A08, A13, A14, A28 and A31",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageType = new HL7V231Field
        {
            field = message[@"MSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageType.field.FieldRepetitions != null && _messageType.field.FieldRepetitions.Count > 0)
        {
            _messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_messageType, fieldData);
        }

        return _messageType;
    } 
}

internal HL7V231Field _messageControlID;

public HL7V231Field MessageControlID
{
    get
    {
        if (_messageControlID != null)
        {
            return _messageControlID;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains a number or other identifier that uniquely identifies the message. The receiving system echoes this ID back to the sending system in the Message acknowledgment segment (MSA).",
            Sample = @"",
            Fields = null
        }

        _messageControlID = new HL7V231Field
        {
            field = message[@"MSH"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlID.field.FieldRepetitions != null && _messageControlID.field.FieldRepetitions.Count > 0)
        {
            _messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_messageControlID, fieldData);
        }

        return _messageControlID;
    } 
}

internal HL7V231Field _processingID;

public HL7V231Field ProcessingID
{
    get
    {
        if (_processingID != null)
        {
            return _processingID;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules, above. The first component defines whether the message is part of a production, training, or debugging system (refer to HL7 table 0103 - Processing ID for valid values). The second component defines whether the message is part of an archival process or an initial load (refer to HL7 table 0207 - Processing mode for valid values). This allows different priorities to be given to different processing modes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.11.1",
                            Type = @"Component",
                            Position = @"MSH.11.1",
                            Name = @"Processing Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0103",
                            TableName = @"Processing ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system. Refer to HL7 table 0103 - Processing ID for valid values.",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load. Refer to HL7 table 0207 - Processing mode for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _processingID = new HL7V231Field
        {
            field = message[@"MSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingID.field.FieldRepetitions != null && _processingID.field.FieldRepetitions.Count > 0)
        {
            _processingID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_processingID, fieldData);
        }

        return _processingID;
    } 
}

internal HL7V231Field _versionID;

public HL7V231Field VersionID
{
    get
    {
        if (_versionID != null)
        {
            return _versionID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.12",
            Type = @"Field",
            Position = @"MSH.12",
            Name = @"Version ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"VID",
            DataTypeName = @"Version Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. In version 2.3.1, it has two additional 'internationalization' components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single local' version associated with a single US version. The <internal version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.12.1",
                            Type = @"Component",
                            Position = @"MSH.12.1",
                            Name = @"Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 table 0104 Version ID for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2",
                            Type = @"Component",
                            Position = @"MSH.12.2",
                            Name = @"Internationalization Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to identify the international affiliate country code. Refer to ISO 3166-1:1977 for the country code. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.5",
                            Name = @"Alternate Text",
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
                            Id = @"MSH.12.2.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.6",
                            Name = @"Name Of Alternate Coding System",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3",
                            Type = @"Component",
                            Position = @"MSH.12.3",
                            Name = @"International Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field component identifies international affiliates version; it is especially important when the international affiliate has more than a single local version associated with a single US version.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.5",
                            Name = @"Alternate Text",
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
                            Id = @"MSH.12.3.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.6",
                            Name = @"Name Of Alternate Coding System",
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
                        },}
                        },
                        }
        }

        _versionID = new HL7V231Field
        {
            field = message[@"MSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_versionID.field.FieldRepetitions != null && _versionID.field.FieldRepetitions.Count > 0)
        {
            _versionID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_versionID, fieldData);
        }

        return _versionID;
    } 
}

internal HL7V231Field _sequenceNumber;

public HL7V231Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"A non-null value in this field implies that the sequence number protocol is in use. This numeric field is incremented by one for each subsequent value.",
            Sample = @"",
            Fields = null
        }

        _sequenceNumber = new HL7V231Field
        {
            field = message[@"MSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V231Field _continuationPointer;

public HL7V231Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field is used to define continuations in application-specific ways.",
            Sample = @"",
            Fields = null
        }

        _continuationPointer = new HL7V231Field
        {
            field = message[@"MSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}

internal HL7V231Field _acceptAcknowledgmentType;

public HL7V231Field AcceptAcknowledgmentType
{
    get
    {
        if (_acceptAcknowledgmentType != null)
        {
            return _acceptAcknowledgmentType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.15",
            Type = @"Field",
            Position = @"MSH.15",
            Name = @"Accept Acknowledgment Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 table 0155 - Accept/application acknowledgment conditions for valid values.",
            Sample = @"",
            Fields = null
        }

        _acceptAcknowledgmentType = new HL7V231Field
        {
            field = message[@"MSH"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acceptAcknowledgmentType.field.FieldRepetitions != null && _acceptAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _acceptAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_acceptAcknowledgmentType, fieldData);
        }

        return _acceptAcknowledgmentType;
    } 
}

internal HL7V231Field _applicationAcknowledgmentType;

public HL7V231Field ApplicationAcknowledgmentType
{
    get
    {
        if (_applicationAcknowledgmentType != null)
        {
            return _applicationAcknowledgmentType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.16",
            Type = @"Field",
            Position = @"MSH.16",
            Name = @"Application Acknowledgment Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0155",
            TableName = @"Accept/application acknowledgment conditions",
            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode.",
            Sample = @"",
            Fields = null
        }

        _applicationAcknowledgmentType = new HL7V231Field
        {
            field = message[@"MSH"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationAcknowledgmentType.field.FieldRepetitions != null && _applicationAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _applicationAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_applicationAcknowledgmentType, fieldData);
        }

        return _applicationAcknowledgmentType;
    } 
}

internal HL7V231Field _countryCode;

public HL7V231Field CountryCode
{
    get
    {
        if (_countryCode != null)
        {
            return _countryCode;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. ISO 3166 provides a list of country codes that may be used[3]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
            Sample = @"",
            Fields = null
        }

        _countryCode = new HL7V231Field
        {
            field = message[@"MSH"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countryCode.field.FieldRepetitions != null && _countryCode.field.FieldRepetitions.Count > 0)
        {
            _countryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_countryCode, fieldData);
        }

        return _countryCode;
    } 
}

internal HL7V231Field _characterSet;

public HL7V231Field CharacterSet
{
    get
    {
        if (_characterSet != null)
        {
            return _characterSet;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.18",
            Type = @"Field",
            Position = @"MSH.18",
            Name = @"Character Set",
            Length = 16,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0211",
            TableName = @"Alternate character sets",
            Description = @"This field contains the character set for the entire message. Refer to HL7 table 0211 - Alternate character sets for valid values.",
            Sample = @"",
            Fields = null
        }

        _characterSet = new HL7V231Field
        {
            field = message[@"MSH"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_characterSet.field.FieldRepetitions != null && _characterSet.field.FieldRepetitions.Count > 0)
        {
            _characterSet.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_characterSet, fieldData);
        }

        return _characterSet;
    } 
}

internal HL7V231Field _principalLanguageOfMessage;

public HL7V231Field PrincipalLanguageOfMessage
{
    get
    {
        if (_principalLanguageOfMessage != null)
        {
            return _principalLanguageOfMessage;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.19",
            Type = @"Field",
            Position = @"MSH.19",
            Name = @"Principal Language Of Message",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the principal language of the message. Codes come from ISO 639.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.19.4",
                            Type = @"Component",
                            Position = @"MSH.19.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _principalLanguageOfMessage = new HL7V231Field
        {
            field = message[@"MSH"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_principalLanguageOfMessage.field.FieldRepetitions != null && _principalLanguageOfMessage.field.FieldRepetitions.Count > 0)
        {
            _principalLanguageOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_principalLanguageOfMessage, fieldData);
        }

        return _principalLanguageOfMessage;
    } 
}

internal HL7V231Field _alternateCharacterSetHandlingScheme;

public HL7V231Field AlternateCharacterSetHandlingScheme
{
    get
    {
        if (_alternateCharacterSetHandlingScheme != null)
        {
            return _alternateCharacterSetHandlingScheme;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"MSH.20",
            Type = @"Field",
            Position = @"MSH.20",
            Name = @"Alternate Character Set Handling Scheme",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0356",
            TableName = @"Alternate character set handling scheme",
            Description = @"When any alternative character sets are used (as specified in the second or later components of MSH-18 character sets ), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 table 0356- Alternate character set handling scheme as defined below:",
            Sample = @"",
            Fields = null
        }

        _alternateCharacterSetHandlingScheme = new HL7V231Field
        {
            field = message[@"MSH"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternateCharacterSetHandlingScheme.field.FieldRepetitions != null && _alternateCharacterSetHandlingScheme.field.FieldRepetitions.Count > 0)
        {
            _alternateCharacterSetHandlingScheme.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_alternateCharacterSetHandlingScheme, fieldData);
        }

        return _alternateCharacterSetHandlingScheme;
    } 
}
    }
}

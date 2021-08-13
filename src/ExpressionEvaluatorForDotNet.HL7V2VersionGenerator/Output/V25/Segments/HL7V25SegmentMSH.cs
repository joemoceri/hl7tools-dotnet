using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentMSH
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MSH"; } }

        public string SegmentId { get { return @"MSH"; } }
        
        public string LongName { get { return @"Message Header"; } }
        
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

        public HL7V25SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _fieldSeparator;

public HL7V25Field FieldSeparator
{
    get
    {
        if (_fieldSeparator != null)
        {
            return _fieldSeparator;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field contains the separator between the segment ID and the first real field, MSH-2-encoding characters . As such it serves as the separator and defines the character to be used as a separator for the rest of the message. Recommended value is |, (ASCII 124).",
            Sample = @"",
            Fields = null
        }

        _fieldSeparator = new HL7V25Field
        {
            field = message[@"MSH"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fieldSeparator.field.FieldRepetitions != null && _fieldSeparator.field.FieldRepetitions.Count > 0)
        {
            _fieldSeparator.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_fieldSeparator, fieldData);
        }

        return _fieldSeparator;
    } 
}

internal HL7V25Field _encodingCharacters;

public HL7V25Field EncodingCharacters
{
    get
    {
        if (_encodingCharacters != null)
        {
            return _encodingCharacters;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field contains the four characters in the following order: the component separator, repetition separator, escape character, and subcomponent separator. Recommended values are ^~\& (ASCII 94, 126, 92, and 38, respectively). See Section 2.5.4, ""Message delimiters'.",
            Sample = @"",
            Fields = null
        }

        _encodingCharacters = new HL7V25Field
        {
            field = message[@"MSH"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_encodingCharacters.field.FieldRepetitions != null && _encodingCharacters.field.FieldRepetitions.Count > 0)
        {
            _encodingCharacters.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_encodingCharacters, fieldData);
        }

        return _encodingCharacters;
    } 
}

internal HL7V25Field _sendingApplication;

public HL7V25Field SendingApplication
{
    get
    {
        if (_sendingApplication != null)
        {
            return _sendingApplication;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.3",
            Type = @"Field",
            Position = @"MSH.3",
            Name = @"Sending Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field uniquely identifies the sending application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined. User-defined Table 0361- Application is used as the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.3.1",
                            Type = @"Component",
                            Position = @"MSH.3.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.2",
                            Type = @"Component",
                            Position = @"MSH.3.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.3.3",
                            Type = @"Component",
                            Position = @"MSH.3.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingApplication = new HL7V25Field
        {
            field = message[@"MSH"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingApplication.field.FieldRepetitions != null && _sendingApplication.field.FieldRepetitions.Count > 0)
        {
            _sendingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sendingApplication, fieldData);
        }

        return _sendingApplication;
    } 
}

internal HL7V25Field _sendingFacility;

public HL7V25Field SendingFacility
{
    get
    {
        if (_sendingFacility != null)
        {
            return _sendingFacility;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.4",
            Type = @"Field",
            Position = @"MSH.4",
            Name = @"Sending Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field further describes the sending application, MSH-3-sending application. With the promotion of this field to an HD data type, the usage has been broadened to include not just the sending facility but other organizational entities such as a) the organizational entity responsible for sending application; b) the responsible unit; c) a product or vendors identifier, etc. Entirely site-defined. User-defined Table 0362 - Facility  is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.4.1",
                            Type = @"Component",
                            Position = @"MSH.4.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.2",
                            Type = @"Component",
                            Position = @"MSH.4.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.4.3",
                            Type = @"Component",
                            Position = @"MSH.4.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _sendingFacility = new HL7V25Field
        {
            field = message[@"MSH"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendingFacility.field.FieldRepetitions != null && _sendingFacility.field.FieldRepetitions.Count > 0)
        {
            _sendingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sendingFacility, fieldData);
        }

        return _sendingFacility;
    } 
}

internal HL7V25Field _receivingApplication;

public HL7V25Field ReceivingApplication
{
    get
    {
        if (_receivingApplication != null)
        {
            return _receivingApplication;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.5",
            Type = @"Field",
            Position = @"MSH.5",
            Name = @"Receiving Application",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0361",
            TableName = @"Application",
            Description = @"This field uniquely identifies the receiving application among all other applications within the network enterprise. The network enterprise consists of all those applications that participate in the exchange of HL7 messages within the enterprise. Entirely site-defined User-defined Table 0361- Application is used as the HL7 identifier for the user-defined table of values for the first component.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.5.1",
                            Type = @"Component",
                            Position = @"MSH.5.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.2",
                            Type = @"Component",
                            Position = @"MSH.5.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.5.3",
                            Type = @"Component",
                            Position = @"MSH.5.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingApplication = new HL7V25Field
        {
            field = message[@"MSH"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingApplication.field.FieldRepetitions != null && _receivingApplication.field.FieldRepetitions.Count > 0)
        {
            _receivingApplication.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_receivingApplication, fieldData);
        }

        return _receivingApplication;
    } 
}

internal HL7V25Field _receivingFacility;

public HL7V25Field ReceivingFacility
{
    get
    {
        if (_receivingFacility != null)
        {
            return _receivingFacility;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.6",
            Type = @"Field",
            Position = @"MSH.6",
            Name = @"Receiving Facility",
            Length = 227,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"HD",
            DataTypeName = @"Hierarchic Designator",
            TableId = @"0362",
            TableName = @"Facility",
            Description = @"This field identifies the receiving application among multiple identical instances of the application running on behalf of different organizations. User-defined Table 0362 - Facility is used as the HL7 identifier for the user-defined table of values for the first component. Entirely site-defined.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.6.1",
                            Type = @"Component",
                            Position = @"MSH.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.2",
                            Type = @"Component",
                            Position = @"MSH.6.2",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.6.3",
                            Type = @"Component",
                            Position = @"MSH.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _receivingFacility = new HL7V25Field
        {
            field = message[@"MSH"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receivingFacility.field.FieldRepetitions != null && _receivingFacility.field.FieldRepetitions.Count > 0)
        {
            _receivingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_receivingFacility, fieldData);
        }

        return _receivingFacility;
    } 
}

internal HL7V25Field _dateTimeOfMessage;

public HL7V25Field DateTimeOfMessage
{
    get
    {
        if (_dateTimeOfMessage != null)
        {
            return _dateTimeOfMessage;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.7",
            Type = @"Field",
            Position = @"MSH.7",
            Name = @"Date/Time Of Message",
            Length = 26,
            Usage = @"R",
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
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.7.2",
                            Type = @"Component",
                            Position = @"MSH.7.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision.

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateTimeOfMessage = new HL7V25Field
        {
            field = message[@"MSH"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfMessage.field.FieldRepetitions != null && _dateTimeOfMessage.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_dateTimeOfMessage, fieldData);
        }

        return _dateTimeOfMessage;
    } 
}

internal HL7V25Field _security;

public HL7V25Field Security
{
    get
    {
        if (_security != null)
        {
            return _security;
        }

        var fieldData = new HL7V25FieldData
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

        _security = new HL7V25Field
        {
            field = message[@"MSH"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_security.field.FieldRepetitions != null && _security.field.FieldRepetitions.Count > 0)
        {
            _security.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_security, fieldData);
        }

        return _security;
    } 
}

internal HL7V25Field _messageType;

public HL7V25Field MessageType
{
    get
    {
        if (_messageType != null)
        {
            return _messageType;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.9",
            Type = @"Field",
            Position = @"MSH.9",
            Name = @"Message Type",
            Length = 15,
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
                            Name = @"Message Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"Specifies the message type code. Refer to HL7 Table - Message Type in section 2.17.1 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.2",
                            Type = @"Component",
                            Position = @"MSH.9.2",
                            Name = @"Trigger Event",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"Specifies the trigger event code. Refer to HL7 Table - Event Type in section 2.17.2 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.9.3",
                            Type = @"Component",
                            Position = @"MSH.9.3",
                            Name = @"Message Structure",
                            Length = 7,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = @"Specifies the abstract message structure code. Refer to HL7 Table 0354 - Message Structure in section 2.17.3 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageType = new HL7V25Field
        {
            field = message[@"MSH"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageType.field.FieldRepetitions != null && _messageType.field.FieldRepetitions.Count > 0)
        {
            _messageType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_messageType, fieldData);
        }

        return _messageType;
    } 
}

internal HL7V25Field _messageControlID;

public HL7V25Field MessageControlID
{
    get
    {
        if (_messageControlID != null)
        {
            return _messageControlID;
        }

        var fieldData = new HL7V25FieldData
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

        _messageControlID = new HL7V25Field
        {
            field = message[@"MSH"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageControlID.field.FieldRepetitions != null && _messageControlID.field.FieldRepetitions.Count > 0)
        {
            _messageControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_messageControlID, fieldData);
        }

        return _messageControlID;
    } 
}

internal HL7V25Field _processingID;

public HL7V25Field ProcessingID
{
    get
    {
        if (_processingID != null)
        {
            return _processingID;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is used to decide whether to process the message as defined in HL7 Application (level 7) Processing rules.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.11.1",
                            Type = @"Component",
                            Position = @"MSH.11.1",
                            Name = @"Processing Id",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0103",
                            TableName = @"Processing ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system. Refer to HL7 Table 0103 - Processing ID for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.11.2",
                            Type = @"Component",
                            Position = @"MSH.11.2",
                            Name = @"Processing Mode",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load. Refer to HL7 Table 0207 - Processing mode for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _processingID = new HL7V25Field
        {
            field = message[@"MSH"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingID.field.FieldRepetitions != null && _processingID.field.FieldRepetitions.Count > 0)
        {
            _processingID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_processingID, fieldData);
        }

        return _processingID;
    } 
}

internal HL7V25Field _versionID;

public HL7V25Field VersionID
{
    get
    {
        if (_versionID != null)
        {
            return _versionID;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field is matched by the receiving system to its own version to be sure the message will be interpreted correctly. Beginning with Version 2.3.1, it has two additional internationalization components, for use by HL7 international affiliates. The <internationalization code> is CE data type (using the ISO country codes where appropriate) which represents the HL7 affiliate. The <internal version ID> is used if the HL7 Affiliate has more than a single local version associated with a single US version. The <international version ID> has a CE data type, since the table values vary for each HL7 Affiliate.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.12.1",
                            Type = @"Component",
                            Position = @"MSH.12.1",
                            Name = @"Version Id",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 Table 0104 - Version ID in section 2.15.9.12 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.2",
                            Type = @"Component",
                            Position = @"MSH.12.2",
                            Name = @"Internationalization Code",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Used to identify the international affiliate country code. The values to be used are those of ISO 3166 -1:1977. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MSH.12.2.1",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.1",
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
                            Id = @"MSH.12.2.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.2",
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
                            Id = @"MSH.12.2.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.3",
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
                            Id = @"MSH.12.2.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.4",
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
                            Id = @"MSH.12.2.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.5",
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
                            Id = @"MSH.12.2.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.2.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.12.3",
                            Type = @"Component",
                            Position = @"MSH.12.3",
                            Name = @"International Version Id",
                            Length = 483,
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
                            Id = @"MSH.12.3.2",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.2",
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
                            Id = @"MSH.12.3.3",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.3",
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
                            Id = @"MSH.12.3.4",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.4",
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
                            Id = @"MSH.12.3.5",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.5",
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
                            Id = @"MSH.12.3.6",
                            Type = @"SubComponent",
                            Position = @"MSH.12.3.6",
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
                        },}
                        },
                        }
        }

        _versionID = new HL7V25Field
        {
            field = message[@"MSH"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_versionID.field.FieldRepetitions != null && _versionID.field.FieldRepetitions.Count > 0)
        {
            _versionID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_versionID, fieldData);
        }

        return _versionID;
    } 
}

internal HL7V25Field _sequenceNumber;

public HL7V25Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V25FieldData
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

        _sequenceNumber = new HL7V25Field
        {
            field = message[@"MSH"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V25Field _continuationPointer;

public HL7V25Field ContinuationPointer
{
    get
    {
        if (_continuationPointer != null)
        {
            return _continuationPointer;
        }

        var fieldData = new HL7V25FieldData
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

        _continuationPointer = new HL7V25Field
        {
            field = message[@"MSH"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_continuationPointer.field.FieldRepetitions != null && _continuationPointer.field.FieldRepetitions.Count > 0)
        {
            _continuationPointer.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_continuationPointer, fieldData);
        }

        return _continuationPointer;
    } 
}

internal HL7V25Field _acceptAcknowledgmentType;

public HL7V25Field AcceptAcknowledgmentType
{
    get
    {
        if (_acceptAcknowledgmentType != null)
        {
            return _acceptAcknowledgmentType;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field identifies the conditions under which accept acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode. Refer to HL7 Table 0155 - Accept/application acknowledgment conditions for valid values.",
            Sample = @"",
            Fields = null
        }

        _acceptAcknowledgmentType = new HL7V25Field
        {
            field = message[@"MSH"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_acceptAcknowledgmentType.field.FieldRepetitions != null && _acceptAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _acceptAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_acceptAcknowledgmentType, fieldData);
        }

        return _acceptAcknowledgmentType;
    } 
}

internal HL7V25Field _applicationAcknowledgmentType;

public HL7V25Field ApplicationAcknowledgmentType
{
    get
    {
        if (_applicationAcknowledgmentType != null)
        {
            return _applicationAcknowledgmentType;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field contains the conditions under which application acknowledgments are required to be returned in response to this message. Required for enhanced acknowledgment mode.

Note:  If MSH-15-accept acknowledgment type and MSH-16-application acknowledgment type are omitted (or are both null), the original acknowledgment mode rules are used.",
            Sample = @"",
            Fields = null
        }

        _applicationAcknowledgmentType = new HL7V25Field
        {
            field = message[@"MSH"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationAcknowledgmentType.field.FieldRepetitions != null && _applicationAcknowledgmentType.field.FieldRepetitions.Count > 0)
        {
            _applicationAcknowledgmentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_applicationAcknowledgmentType, fieldData);
        }

        return _applicationAcknowledgmentType;
    } 
}

internal HL7V25Field _countryCode;

public HL7V25Field CountryCode
{
    get
    {
        if (_countryCode != null)
        {
            return _countryCode;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.17",
            Type = @"Field",
            Position = @"MSH.17",
            Name = @"Country Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0399",
            TableName = @"Country code",
            Description = @"This field contains the country of origin for the message. It will be used primarily to specify default elements, such as currency denominations. The values to be used are those of ISO 3166,.[5]. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
            Sample = @"",
            Fields = null
        }

        _countryCode = new HL7V25Field
        {
            field = message[@"MSH"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countryCode.field.FieldRepetitions != null && _countryCode.field.FieldRepetitions.Count > 0)
        {
            _countryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_countryCode, fieldData);
        }

        return _countryCode;
    } 
}

internal HL7V25Field _characterSet;

public HL7V25Field CharacterSet
{
    get
    {
        if (_characterSet != null)
        {
            return _characterSet;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field contains the character set for the entire message. Refer to HL7 Table 0211 - Alternate character sets for valid values.",
            Sample = @"",
            Fields = null
        }

        _characterSet = new HL7V25Field
        {
            field = message[@"MSH"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_characterSet.field.FieldRepetitions != null && _characterSet.field.FieldRepetitions.Count > 0)
        {
            _characterSet.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_characterSet, fieldData);
        }

        return _characterSet;
    } 
}

internal HL7V25Field _principalLanguageOfMessage;

public HL7V25Field PrincipalLanguageOfMessage
{
    get
    {
        if (_principalLanguageOfMessage != null)
        {
            return _principalLanguageOfMessage;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.19",
            Type = @"Field",
            Position = @"MSH.19",
            Name = @"Principal Language Of Message",
            Length = 250,
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
                            Id = @"MSH.19.2",
                            Type = @"Component",
                            Position = @"MSH.19.2",
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
                            Id = @"MSH.19.3",
                            Type = @"Component",
                            Position = @"MSH.19.3",
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
                            Id = @"MSH.19.4",
                            Type = @"Component",
                            Position = @"MSH.19.4",
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
                            Id = @"MSH.19.5",
                            Type = @"Component",
                            Position = @"MSH.19.5",
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
                            Id = @"MSH.19.6",
                            Type = @"Component",
                            Position = @"MSH.19.6",
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

        _principalLanguageOfMessage = new HL7V25Field
        {
            field = message[@"MSH"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_principalLanguageOfMessage.field.FieldRepetitions != null && _principalLanguageOfMessage.field.FieldRepetitions.Count > 0)
        {
            _principalLanguageOfMessage.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_principalLanguageOfMessage, fieldData);
        }

        return _principalLanguageOfMessage;
    } 
}

internal HL7V25Field _alternateCharacterSetHandlingScheme;

public HL7V25Field AlternateCharacterSetHandlingScheme
{
    get
    {
        if (_alternateCharacterSetHandlingScheme != null)
        {
            return _alternateCharacterSetHandlingScheme;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"When any alternative character sets are used (as specified in the second or later iterations of MSH-18 character sets), and if any special handling scheme is needed, this component is to specify the scheme used, according to HL7 Table 0356- Alternate character set handling scheme as defined below:",
            Sample = @"",
            Fields = null
        }

        _alternateCharacterSetHandlingScheme = new HL7V25Field
        {
            field = message[@"MSH"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternateCharacterSetHandlingScheme.field.FieldRepetitions != null && _alternateCharacterSetHandlingScheme.field.FieldRepetitions.Count > 0)
        {
            _alternateCharacterSetHandlingScheme.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_alternateCharacterSetHandlingScheme, fieldData);
        }

        return _alternateCharacterSetHandlingScheme;
    } 
}

internal HL7V25Field _messageProfileIdentifier;

public HL7V25Field MessageProfileIdentifier
{
    get
    {
        if (_messageProfileIdentifier != null)
        {
            return _messageProfileIdentifier;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"MSH.21",
            Type = @"Field",
            Position = @"MSH.21",
            Name = @"Message Profile Identifier",
            Length = 427,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Sites may use this field to assert adherence to, or reference, a message profile. Message profiles contain detailed explanations of grammar, syntax, and usage for a particular message or set of messages. See section 2.12, ""Conformance Using Message Profiles"".",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MSH.21.1",
                            Type = @"Component",
                            Position = @"MSH.21.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21.2",
                            Type = @"Component",
                            Position = @"MSH.21.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSH.21.3",
                            Type = @"Component",
                            Position = @"MSH.21.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"MSH.21.4",
                            Type = @"Component",
                            Position = @"MSH.21.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageProfileIdentifier = new HL7V25Field
        {
            field = message[@"MSH"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageProfileIdentifier.field.FieldRepetitions != null && _messageProfileIdentifier.field.FieldRepetitions.Count > 0)
        {
            _messageProfileIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_messageProfileIdentifier, fieldData);
        }

        return _messageProfileIdentifier;
    } 
}
    }
}

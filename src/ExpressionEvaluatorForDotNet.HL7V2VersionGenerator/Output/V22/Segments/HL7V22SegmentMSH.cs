using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentMSH
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentMSH(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field fieldSeparator;

public HL7V22Field FieldSeparator
{
    get
    {
        if (fieldSeparator != null)
        {
            return fieldSeparator;
        }

        fieldSeparator = new HL7V22Field
        {
            field = message[@"MSH"][1],
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
        };

        

        

        

        return fieldSeparator;
    } 
}
internal HL7V22Field encodingCharacters;

public HL7V22Field EncodingCharacters
{
    get
    {
        if (encodingCharacters != null)
        {
            return encodingCharacters;
        }

        encodingCharacters = new HL7V22Field
        {
            field = message[@"MSH"][2],
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
        };

        

        

        

        return encodingCharacters;
    } 
}
internal HL7V22Field sendingApplication;

public HL7V22Field SendingApplication
{
    get
    {
        if (sendingApplication != null)
        {
            return sendingApplication;
        }

        sendingApplication = new HL7V22Field
        {
            field = message[@"MSH"][3],
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
        };

        

        

        

        return sendingApplication;
    } 
}
internal HL7V22Field sendingFacility;

public HL7V22Field SendingFacility
{
    get
    {
        if (sendingFacility != null)
        {
            return sendingFacility;
        }

        sendingFacility = new HL7V22Field
        {
            field = message[@"MSH"][4],
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
        };

        

        

        

        return sendingFacility;
    } 
}
internal HL7V22Field receivingApplication;

public HL7V22Field ReceivingApplication
{
    get
    {
        if (receivingApplication != null)
        {
            return receivingApplication;
        }

        receivingApplication = new HL7V22Field
        {
            field = message[@"MSH"][5],
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
        };

        

        

        

        return receivingApplication;
    } 
}
internal HL7V22Field receivingFacility;

public HL7V22Field ReceivingFacility
{
    get
    {
        if (receivingFacility != null)
        {
            return receivingFacility;
        }

        receivingFacility = new HL7V22Field
        {
            field = message[@"MSH"][6],
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
        };

        

        

        

        return receivingFacility;
    } 
}
internal HL7V22Field dateTimeOfMessage;

public HL7V22Field DateTimeOfMessage
{
    get
    {
        if (dateTimeOfMessage != null)
        {
            return dateTimeOfMessage;
        }

        dateTimeOfMessage = new HL7V22Field
        {
            field = message[@"MSH"][7],
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
        };

        

        

        

        return dateTimeOfMessage;
    } 
}
internal HL7V22Field security;

public HL7V22Field Security
{
    get
    {
        if (security != null)
        {
            return security;
        }

        security = new HL7V22Field
        {
            field = message[@"MSH"][8],
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
        };

        

        

        

        return security;
    } 
}
internal HL7V22Field messageType;

public HL7V22Field MessageType
{
    get
    {
        if (messageType != null)
        {
            return messageType;
        }

        messageType = new HL7V22Field
        {
            field = message[@"MSH"][9],
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
        };

        

        

        

        return messageType;
    } 
}
internal HL7V22Field messageControlId;

public HL7V22Field MessageControlId
{
    get
    {
        if (messageControlId != null)
        {
            return messageControlId;
        }

        messageControlId = new HL7V22Field
        {
            field = message[@"MSH"][10],
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
        };

        

        

        

        return messageControlId;
    } 
}
internal HL7V22Field processingId;

public HL7V22Field ProcessingId
{
    get
    {
        if (processingId != null)
        {
            return processingId;
        }

        processingId = new HL7V22Field
        {
            field = message[@"MSH"][11],
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
        };

        

        

        

        return processingId;
    } 
}
internal HL7V22Field versionId;

public HL7V22Field VersionId
{
    get
    {
        if (versionId != null)
        {
            return versionId;
        }

        versionId = new HL7V22Field
        {
            field = message[@"MSH"][12],
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
        };

        

        

        

        return versionId;
    } 
}
internal HL7V22Field sequenceNumber;

public HL7V22Field SequenceNumber
{
    get
    {
        if (sequenceNumber != null)
        {
            return sequenceNumber;
        }

        sequenceNumber = new HL7V22Field
        {
            field = message[@"MSH"][13],
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
        };

        

        

        

        return sequenceNumber;
    } 
}
internal HL7V22Field continuationPointer;

public HL7V22Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V22Field
        {
            field = message[@"MSH"][14],
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
        };

        

        

        

        return continuationPointer;
    } 
}
internal HL7V22Field acceptAcknowledgementType;

public HL7V22Field AcceptAcknowledgementType
{
    get
    {
        if (acceptAcknowledgementType != null)
        {
            return acceptAcknowledgementType;
        }

        acceptAcknowledgementType = new HL7V22Field
        {
            field = message[@"MSH"][15],
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
        };

        

        

        

        return acceptAcknowledgementType;
    } 
}
internal HL7V22Field applicationAcknowledgementType;

public HL7V22Field ApplicationAcknowledgementType
{
    get
    {
        if (applicationAcknowledgementType != null)
        {
            return applicationAcknowledgementType;
        }

        applicationAcknowledgementType = new HL7V22Field
        {
            field = message[@"MSH"][16],
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
        };

        

        

        

        return applicationAcknowledgementType;
    } 
}
internal HL7V22Field countryCode;

public HL7V22Field CountryCode
{
    get
    {
        if (countryCode != null)
        {
            return countryCode;
        }

        countryCode = new HL7V22Field
        {
            field = message[@"MSH"][17],
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
        };

        

        

        

        return countryCode;
    } 
}

    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentNST
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NST"; } }

        public string SegmentId { get { return @"NST"; } }
        
        public string LongName { get { return @"Application Control Level Statistics"; } }
        
        public string Description { get { return @"The NST segment allows application control-level statistical information to be passed between the various systems on the network.  Some fields in this segment refer to portions of lower level protocols; they contain information that can be used by application management applications monitoring the state of various network links. 

Usage Notes: Fields 2-15.  These are all marked optional since the statistics kept on a particular link and negotiated between the two systems in question will vary.  Not all values will apply to each system.  Some values are concerned with the type of port, and some values pertain to the lower level protocol."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

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
                            Id = @"NST.1",
                            Type = @"Field",
                            Position = @"NST.1",
                            Name = @"Statistics Available",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0136",
                            TableName = @"Yes/no Indicator",
                            Description = @"This field indicates the availability of statistics. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.  

N - the responding application does not keep any statistics.  If the value ""N"" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).  
Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.2",
                            Type = @"Field",
                            Position = @"NST.2",
                            Name = @"Source Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies a particular lower level link (e.g., a port number). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.3",
                            Type = @"Field",
                            Position = @"NST.3",
                            Name = @"Source Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0332",
                            TableName = @"Source Type",
                            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type.   Refer to HL7 Table 0332 – Source Type in Chapter 2C, Code Tables, for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.4",
                            Type = @"Field",
                            Position = @"NST.4",
                            Name = @"Statistics Start",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.5",
                            Type = @"Field",
                            Position = @"NST.5",
                            Name = @"Statistics End",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.6",
                            Type = @"Field",
                            Position = @"NST.6",
                            Name = @"Receive Character Count",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters received. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.7",
                            Type = @"Field",
                            Position = @"NST.7",
                            Name = @"Send Character Count",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters sent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.8",
                            Type = @"Field",
                            Position = @"NST.8",
                            Name = @"Messages Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.9",
                            Type = @"Field",
                            Position = @"NST.9",
                            Name = @"Messages Sent",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages sent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.10",
                            Type = @"Field",
                            Position = @"NST.10",
                            Name = @"Checksum Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received with checksum errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.11",
                            Type = @"Field",
                            Position = @"NST.11",
                            Name = @"Length Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received with length errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.12",
                            Type = @"Field",
                            Position = @"NST.12",
                            Name = @"Other Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of ""other"" invalid messages received (excluding length and checksum errors). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.13",
                            Type = @"Field",
                            Position = @"NST.13",
                            Name = @"Connect Timeouts",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of connect timeout errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.14",
                            Type = @"Field",
                            Position = @"NST.14",
                            Name = @"Receive Timeouts",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.15",
                            Type = @"Field",
                            Position = @"NST.15",
                            Name = @"Application Control-level Errors",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of application control-level errors in response to an initiated message. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V28SegmentNST(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field statisticsAvailable;

public HL7V28Field StatisticsAvailable
{
    get
    {
        if (statisticsAvailable != null)
        {
            return statisticsAvailable;
        }

        statisticsAvailable = new HL7V28Field
        {
            field = message[@"NST"][1],
            Id = @"NST.1",
            Type = @"Field",
            Position = @"NST.1",
            Name = @"Statistics Available",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0136",
            TableName = @"Yes/no Indicator",
            Description = @"This field indicates the availability of statistics. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.  

N - the responding application does not keep any statistics.  If the value ""N"" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).  
Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsAvailable.field.FieldRepetitions != null && statisticsAvailable.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsAvailable.Id));
            statisticsAvailable.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(statisticsAvailable, fieldData);
        }

        return statisticsAvailable;
    } 
}

internal HL7V28Field sourceIdentifier;

public HL7V28Field SourceIdentifier
{
    get
    {
        if (sourceIdentifier != null)
        {
            return sourceIdentifier;
        }

        sourceIdentifier = new HL7V28Field
        {
            field = message[@"NST"][2],
            Id = @"NST.2",
            Type = @"Field",
            Position = @"NST.2",
            Name = @"Source Identifier",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a particular lower level link (e.g., a port number). ",
            Sample = @"",
        };

        // check for repetitions
        if (sourceIdentifier.field.FieldRepetitions != null && sourceIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceIdentifier.Id));
            sourceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(sourceIdentifier, fieldData);
        }

        return sourceIdentifier;
    } 
}

internal HL7V28Field sourceType;

public HL7V28Field SourceType
{
    get
    {
        if (sourceType != null)
        {
            return sourceType;
        }

        sourceType = new HL7V28Field
        {
            field = message[@"NST"][3],
            Id = @"NST.3",
            Type = @"Field",
            Position = @"NST.3",
            Name = @"Source Type",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0332",
            TableName = @"Source Type",
            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type.   Refer to HL7 Table 0332 – Source Type in Chapter 2C, Code Tables, for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (sourceType.field.FieldRepetitions != null && sourceType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceType.Id));
            sourceType.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(sourceType, fieldData);
        }

        return sourceType;
    } 
}

internal HL7V28Field statisticsStart;

public HL7V28Field StatisticsStart
{
    get
    {
        if (statisticsStart != null)
        {
            return statisticsStart;
        }

        statisticsStart = new HL7V28Field
        {
            field = message[@"NST"][4],
            Id = @"NST.4",
            Type = @"Field",
            Position = @"NST.4",
            Name = @"Statistics Start",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsStart.field.FieldRepetitions != null && statisticsStart.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsStart.Id));
            statisticsStart.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(statisticsStart, fieldData);
        }

        return statisticsStart;
    } 
}

internal HL7V28Field statisticsEnd;

public HL7V28Field StatisticsEnd
{
    get
    {
        if (statisticsEnd != null)
        {
            return statisticsEnd;
        }

        statisticsEnd = new HL7V28Field
        {
            field = message[@"NST"][5],
            Id = @"NST.5",
            Type = @"Field",
            Position = @"NST.5",
            Name = @"Statistics End",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsEnd.field.FieldRepetitions != null && statisticsEnd.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsEnd.Id));
            statisticsEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(statisticsEnd, fieldData);
        }

        return statisticsEnd;
    } 
}

internal HL7V28Field receiveCharacterCount;

public HL7V28Field ReceiveCharacterCount
{
    get
    {
        if (receiveCharacterCount != null)
        {
            return receiveCharacterCount;
        }

        receiveCharacterCount = new HL7V28Field
        {
            field = message[@"NST"][6],
            Id = @"NST.6",
            Type = @"Field",
            Position = @"NST.6",
            Name = @"Receive Character Count",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters received. ",
            Sample = @"",
        };

        // check for repetitions
        if (receiveCharacterCount.field.FieldRepetitions != null && receiveCharacterCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receiveCharacterCount.Id));
            receiveCharacterCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(receiveCharacterCount, fieldData);
        }

        return receiveCharacterCount;
    } 
}

internal HL7V28Field sendCharacterCount;

public HL7V28Field SendCharacterCount
{
    get
    {
        if (sendCharacterCount != null)
        {
            return sendCharacterCount;
        }

        sendCharacterCount = new HL7V28Field
        {
            field = message[@"NST"][7],
            Id = @"NST.7",
            Type = @"Field",
            Position = @"NST.7",
            Name = @"Send Character Count",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters sent. ",
            Sample = @"",
        };

        // check for repetitions
        if (sendCharacterCount.field.FieldRepetitions != null && sendCharacterCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendCharacterCount.Id));
            sendCharacterCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(sendCharacterCount, fieldData);
        }

        return sendCharacterCount;
    } 
}

internal HL7V28Field messagesReceived;

public HL7V28Field MessagesReceived
{
    get
    {
        if (messagesReceived != null)
        {
            return messagesReceived;
        }

        messagesReceived = new HL7V28Field
        {
            field = message[@"NST"][8],
            Id = @"NST.8",
            Type = @"Field",
            Position = @"NST.8",
            Name = @"Messages Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received. ",
            Sample = @"",
        };

        // check for repetitions
        if (messagesReceived.field.FieldRepetitions != null && messagesReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messagesReceived.Id));
            messagesReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(messagesReceived, fieldData);
        }

        return messagesReceived;
    } 
}

internal HL7V28Field messagesSent;

public HL7V28Field MessagesSent
{
    get
    {
        if (messagesSent != null)
        {
            return messagesSent;
        }

        messagesSent = new HL7V28Field
        {
            field = message[@"NST"][9],
            Id = @"NST.9",
            Type = @"Field",
            Position = @"NST.9",
            Name = @"Messages Sent",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages sent. ",
            Sample = @"",
        };

        // check for repetitions
        if (messagesSent.field.FieldRepetitions != null && messagesSent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messagesSent.Id));
            messagesSent.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(messagesSent, fieldData);
        }

        return messagesSent;
    } 
}

internal HL7V28Field checksumErrorsReceived;

public HL7V28Field ChecksumErrorsReceived
{
    get
    {
        if (checksumErrorsReceived != null)
        {
            return checksumErrorsReceived;
        }

        checksumErrorsReceived = new HL7V28Field
        {
            field = message[@"NST"][10],
            Id = @"NST.10",
            Type = @"Field",
            Position = @"NST.10",
            Name = @"Checksum Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with checksum errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (checksumErrorsReceived.field.FieldRepetitions != null && checksumErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(checksumErrorsReceived.Id));
            checksumErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(checksumErrorsReceived, fieldData);
        }

        return checksumErrorsReceived;
    } 
}

internal HL7V28Field lengthErrorsReceived;

public HL7V28Field LengthErrorsReceived
{
    get
    {
        if (lengthErrorsReceived != null)
        {
            return lengthErrorsReceived;
        }

        lengthErrorsReceived = new HL7V28Field
        {
            field = message[@"NST"][11],
            Id = @"NST.11",
            Type = @"Field",
            Position = @"NST.11",
            Name = @"Length Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with length errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (lengthErrorsReceived.field.FieldRepetitions != null && lengthErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(lengthErrorsReceived.Id));
            lengthErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(lengthErrorsReceived, fieldData);
        }

        return lengthErrorsReceived;
    } 
}

internal HL7V28Field otherErrorsReceived;

public HL7V28Field OtherErrorsReceived
{
    get
    {
        if (otherErrorsReceived != null)
        {
            return otherErrorsReceived;
        }

        otherErrorsReceived = new HL7V28Field
        {
            field = message[@"NST"][12],
            Id = @"NST.12",
            Type = @"Field",
            Position = @"NST.12",
            Name = @"Other Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of ""other"" invalid messages received (excluding length and checksum errors). ",
            Sample = @"",
        };

        // check for repetitions
        if (otherErrorsReceived.field.FieldRepetitions != null && otherErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(otherErrorsReceived.Id));
            otherErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(otherErrorsReceived, fieldData);
        }

        return otherErrorsReceived;
    } 
}

internal HL7V28Field connectTimeouts;

public HL7V28Field ConnectTimeouts
{
    get
    {
        if (connectTimeouts != null)
        {
            return connectTimeouts;
        }

        connectTimeouts = new HL7V28Field
        {
            field = message[@"NST"][13],
            Id = @"NST.13",
            Type = @"Field",
            Position = @"NST.13",
            Name = @"Connect Timeouts",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of connect timeout errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (connectTimeouts.field.FieldRepetitions != null && connectTimeouts.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(connectTimeouts.Id));
            connectTimeouts.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(connectTimeouts, fieldData);
        }

        return connectTimeouts;
    } 
}

internal HL7V28Field receiveTimeouts;

public HL7V28Field ReceiveTimeouts
{
    get
    {
        if (receiveTimeouts != null)
        {
            return receiveTimeouts;
        }

        receiveTimeouts = new HL7V28Field
        {
            field = message[@"NST"][14],
            Id = @"NST.14",
            Type = @"Field",
            Position = @"NST.14",
            Name = @"Receive Timeouts",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message. ",
            Sample = @"",
        };

        // check for repetitions
        if (receiveTimeouts.field.FieldRepetitions != null && receiveTimeouts.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receiveTimeouts.Id));
            receiveTimeouts.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(receiveTimeouts, fieldData);
        }

        return receiveTimeouts;
    } 
}

internal HL7V28Field applicationControllevelErrors;

public HL7V28Field ApplicationControllevelErrors
{
    get
    {
        if (applicationControllevelErrors != null)
        {
            return applicationControllevelErrors;
        }

        applicationControllevelErrors = new HL7V28Field
        {
            field = message[@"NST"][15],
            Id = @"NST.15",
            Type = @"Field",
            Position = @"NST.15",
            Name = @"Application Control-level Errors",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of application control-level errors in response to an initiated message. ",
            Sample = @"",
        };

        // check for repetitions
        if (applicationControllevelErrors.field.FieldRepetitions != null && applicationControllevelErrors.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(applicationControllevelErrors.Id));
            applicationControllevelErrors.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(applicationControllevelErrors, fieldData);
        }

        return applicationControllevelErrors;
    } 
}
    }
}

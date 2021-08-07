using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentNST
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NST"; } }

        public string SegmentId { get { return @"NST"; } }
        
        public string LongName { get { return @"Application control level statistics"; } }
        
        public string Description { get { return @"The NST segment allows application control-level statistical information to be passed between the various systems on the network. Some fields in this segment refer to portions of lower level protocols; they contain information that can be used by application management applications monitoring the state of various network links."; } }
        
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates the availability of statistics. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.2",
                            Type = @"Field",
                            Position = @"NST.2",
                            Name = @"Source Identifier",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies a particular lower level link (e.g., a port number).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.3",
                            Type = @"Field",
                            Position = @"NST.3",
                            Name = @"Source Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0332",
                            TableName = @"Source type",
                            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type. Refer to HL7 Table 0332 - Source type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.4",
                            Type = @"Field",
                            Position = @"NST.4",
                            Name = @"Statistics Start",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NST.4.1",
                            Type = @"Component",
                            Position = @"NST.4.1",
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
                            Id = @"NST.4.2",
                            Type = @"Component",
                            Position = @"NST.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.5",
                            Type = @"Field",
                            Position = @"NST.5",
                            Name = @"Statistics End",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NST.5.1",
                            Type = @"Component",
                            Position = @"NST.5.1",
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
                            Id = @"NST.5.2",
                            Type = @"Component",
                            Position = @"NST.5.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.6",
                            Type = @"Field",
                            Position = @"NST.6",
                            Name = @"Receive Character Count",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters received.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.7",
                            Type = @"Field",
                            Position = @"NST.7",
                            Name = @"Send Character Count",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters sent.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.8",
                            Type = @"Field",
                            Position = @"NST.8",
                            Name = @"Messages Received",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.9",
                            Type = @"Field",
                            Position = @"NST.9",
                            Name = @"Messages Sent",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages sent.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.10",
                            Type = @"Field",
                            Position = @"NST.10",
                            Name = @"Checksum Errors Received",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received with checksum errors.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.11",
                            Type = @"Field",
                            Position = @"NST.11",
                            Name = @"Length Errors Received",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received with length errors.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.12",
                            Type = @"Field",
                            Position = @"NST.12",
                            Name = @"Other Errors Received",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of other invalid messages received (excluding length and checksum errors).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.13",
                            Type = @"Field",
                            Position = @"NST.13",
                            Name = @"Connect Timeouts",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of connect timeout errors.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.14",
                            Type = @"Field",
                            Position = @"NST.14",
                            Name = @"Receive Timeouts",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.15",
                            Type = @"Field",
                            Position = @"NST.15",
                            Name = @"Application control-level Errors",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of application control-level errors in response to an initiated message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentNST(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field statisticsAvailable;

public HL7V24Field StatisticsAvailable
{
    get
    {
        if (statisticsAvailable != null)
        {
            return statisticsAvailable;
        }

        statisticsAvailable = new HL7V24Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates the availability of statistics. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        

        

        

        return statisticsAvailable;
    } 
}
internal HL7V24Field sourceIdentifier;

public HL7V24Field SourceIdentifier
{
    get
    {
        if (sourceIdentifier != null)
        {
            return sourceIdentifier;
        }

        sourceIdentifier = new HL7V24Field
        {
            field = message[@"NST"][2],
            Id = @"NST.2",
            Type = @"Field",
            Position = @"NST.2",
            Name = @"Source Identifier",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a particular lower level link (e.g., a port number).",
            Sample = @"",
        };

        

        

        

        return sourceIdentifier;
    } 
}
internal HL7V24Field sourceType;

public HL7V24Field SourceType
{
    get
    {
        if (sourceType != null)
        {
            return sourceType;
        }

        sourceType = new HL7V24Field
        {
            field = message[@"NST"][3],
            Id = @"NST.3",
            Type = @"Field",
            Position = @"NST.3",
            Name = @"Source Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0332",
            TableName = @"Source type",
            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type. Refer to HL7 Table 0332 - Source type for valid values.",
            Sample = @"",
        };

        

        

        

        return sourceType;
    } 
}
internal HL7V24Field statisticsStart;

public HL7V24Field StatisticsStart
{
    get
    {
        if (statisticsStart != null)
        {
            return statisticsStart;
        }

        statisticsStart = new HL7V24Field
        {
            field = message[@"NST"][4],
            Id = @"NST.4",
            Type = @"Field",
            Position = @"NST.4",
            Name = @"Statistics Start",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
            Sample = @"",
        };

        

        

        

        return statisticsStart;
    } 
}
internal HL7V24Field statisticsEnd;

public HL7V24Field StatisticsEnd
{
    get
    {
        if (statisticsEnd != null)
        {
            return statisticsEnd;
        }

        statisticsEnd = new HL7V24Field
        {
            field = message[@"NST"][5],
            Id = @"NST.5",
            Type = @"Field",
            Position = @"NST.5",
            Name = @"Statistics End",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
            Sample = @"",
        };

        

        

        

        return statisticsEnd;
    } 
}
internal HL7V24Field receiveCharacterCount;

public HL7V24Field ReceiveCharacterCount
{
    get
    {
        if (receiveCharacterCount != null)
        {
            return receiveCharacterCount;
        }

        receiveCharacterCount = new HL7V24Field
        {
            field = message[@"NST"][6],
            Id = @"NST.6",
            Type = @"Field",
            Position = @"NST.6",
            Name = @"Receive Character Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters received.",
            Sample = @"",
        };

        

        

        

        return receiveCharacterCount;
    } 
}
internal HL7V24Field sendCharacterCount;

public HL7V24Field SendCharacterCount
{
    get
    {
        if (sendCharacterCount != null)
        {
            return sendCharacterCount;
        }

        sendCharacterCount = new HL7V24Field
        {
            field = message[@"NST"][7],
            Id = @"NST.7",
            Type = @"Field",
            Position = @"NST.7",
            Name = @"Send Character Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters sent.",
            Sample = @"",
        };

        

        

        

        return sendCharacterCount;
    } 
}
internal HL7V24Field messagesReceived;

public HL7V24Field MessagesReceived
{
    get
    {
        if (messagesReceived != null)
        {
            return messagesReceived;
        }

        messagesReceived = new HL7V24Field
        {
            field = message[@"NST"][8],
            Id = @"NST.8",
            Type = @"Field",
            Position = @"NST.8",
            Name = @"Messages Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received.",
            Sample = @"",
        };

        

        

        

        return messagesReceived;
    } 
}
internal HL7V24Field messagesSent;

public HL7V24Field MessagesSent
{
    get
    {
        if (messagesSent != null)
        {
            return messagesSent;
        }

        messagesSent = new HL7V24Field
        {
            field = message[@"NST"][9],
            Id = @"NST.9",
            Type = @"Field",
            Position = @"NST.9",
            Name = @"Messages Sent",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages sent.",
            Sample = @"",
        };

        

        

        

        return messagesSent;
    } 
}
internal HL7V24Field checksumErrorsReceived;

public HL7V24Field ChecksumErrorsReceived
{
    get
    {
        if (checksumErrorsReceived != null)
        {
            return checksumErrorsReceived;
        }

        checksumErrorsReceived = new HL7V24Field
        {
            field = message[@"NST"][10],
            Id = @"NST.10",
            Type = @"Field",
            Position = @"NST.10",
            Name = @"Checksum Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with checksum errors.",
            Sample = @"",
        };

        

        

        

        return checksumErrorsReceived;
    } 
}
internal HL7V24Field lengthErrorsReceived;

public HL7V24Field LengthErrorsReceived
{
    get
    {
        if (lengthErrorsReceived != null)
        {
            return lengthErrorsReceived;
        }

        lengthErrorsReceived = new HL7V24Field
        {
            field = message[@"NST"][11],
            Id = @"NST.11",
            Type = @"Field",
            Position = @"NST.11",
            Name = @"Length Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with length errors.",
            Sample = @"",
        };

        

        

        

        return lengthErrorsReceived;
    } 
}
internal HL7V24Field otherErrorsReceived;

public HL7V24Field OtherErrorsReceived
{
    get
    {
        if (otherErrorsReceived != null)
        {
            return otherErrorsReceived;
        }

        otherErrorsReceived = new HL7V24Field
        {
            field = message[@"NST"][12],
            Id = @"NST.12",
            Type = @"Field",
            Position = @"NST.12",
            Name = @"Other Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of other invalid messages received (excluding length and checksum errors).",
            Sample = @"",
        };

        

        

        

        return otherErrorsReceived;
    } 
}
internal HL7V24Field connectTimeouts;

public HL7V24Field ConnectTimeouts
{
    get
    {
        if (connectTimeouts != null)
        {
            return connectTimeouts;
        }

        connectTimeouts = new HL7V24Field
        {
            field = message[@"NST"][13],
            Id = @"NST.13",
            Type = @"Field",
            Position = @"NST.13",
            Name = @"Connect Timeouts",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of connect timeout errors.",
            Sample = @"",
        };

        

        

        

        return connectTimeouts;
    } 
}
internal HL7V24Field receiveTimeouts;

public HL7V24Field ReceiveTimeouts
{
    get
    {
        if (receiveTimeouts != null)
        {
            return receiveTimeouts;
        }

        receiveTimeouts = new HL7V24Field
        {
            field = message[@"NST"][14],
            Id = @"NST.14",
            Type = @"Field",
            Position = @"NST.14",
            Name = @"Receive Timeouts",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message.",
            Sample = @"",
        };

        

        

        

        return receiveTimeouts;
    } 
}
internal HL7V24Field applicationcontrollevelErrors;

public HL7V24Field ApplicationcontrollevelErrors
{
    get
    {
        if (applicationcontrollevelErrors != null)
        {
            return applicationcontrollevelErrors;
        }

        applicationcontrollevelErrors = new HL7V24Field
        {
            field = message[@"NST"][15],
            Id = @"NST.15",
            Type = @"Field",
            Position = @"NST.15",
            Name = @"Application control-level Errors",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of application control-level errors in response to an initiated message.",
            Sample = @"",
        };

        

        

        

        return applicationcontrollevelErrors;
    } 
}

    }
}

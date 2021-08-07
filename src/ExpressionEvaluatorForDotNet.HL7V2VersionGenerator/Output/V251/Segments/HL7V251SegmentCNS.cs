using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentCNS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"CNS"; } }

        public string SegmentId { get { return @"CNS"; } }
        
        public string LongName { get { return @"Clear Notification"; } }
        
        public string Description { get { return @"The clear equipment notification segment contains the data necessary to allow the receiving equipment to clear any associated notifications."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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
                            Id = @"CNS.1",
                            Type = @"Field",
                            Position = @"CNS.1",
                            Name = @"Starting Notification Reference Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the starting notification reference number that is to be cleared.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.2",
                            Type = @"Field",
                            Position = @"CNS.2",
                            Name = @"Ending Notification Reference Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the ending notification reference number that is to be cleared. If empty, then only notification with Starting Notification Reference Number will be cleared.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.3",
                            Type = @"Field",
                            Position = @"CNS.3",
                            Name = @"Starting Notification Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the starting date/time of the notifications to be cleared. If this field is empty but Ending Notification Date/Time is filled, then all notifications before Ending Notification Date/Time will be cleared.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CNS.3.1",
                            Type = @"Component",
                            Position = @"CNS.3.1",
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
                            Id = @"CNS.3.2",
                            Type = @"Component",
                            Position = @"CNS.3.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.4",
                            Type = @"Field",
                            Position = @"CNS.4",
                            Name = @"Ending Notification Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the ending date/time of the notifications to be cleared. If this field is empty but Starting Notification Date/Time is filled, then all notifications after Starting Notification Date/Time will be cleared.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CNS.4.1",
                            Type = @"Component",
                            Position = @"CNS.4.1",
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
                            Id = @"CNS.4.2",
                            Type = @"Component",
                            Position = @"CNS.4.2",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5",
                            Type = @"Field",
                            Position = @"CNS.5",
                            Name = @"Starting Notification Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the starting notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification Code(CE) 01401).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.1",
                            Type = @"Component",
                            Position = @"CNS.5.1",
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
                            Id = @"CNS.5.2",
                            Type = @"Component",
                            Position = @"CNS.5.2",
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
                            Id = @"CNS.5.3",
                            Type = @"Component",
                            Position = @"CNS.5.3",
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
                            Id = @"CNS.5.4",
                            Type = @"Component",
                            Position = @"CNS.5.4",
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
                            Id = @"CNS.5.5",
                            Type = @"Component",
                            Position = @"CNS.5.5",
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
                            Id = @"CNS.5.6",
                            Type = @"Component",
                            Position = @"CNS.5.6",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6",
                            Type = @"Field",
                            Position = @"CNS.6",
                            Name = @"Ending Notification Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the ending notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification Code(CE) 01401). If empty, then only notification with Starting Notification Code will be cleared.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.1",
                            Type = @"Component",
                            Position = @"CNS.6.1",
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
                            Id = @"CNS.6.2",
                            Type = @"Component",
                            Position = @"CNS.6.2",
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
                            Id = @"CNS.6.3",
                            Type = @"Component",
                            Position = @"CNS.6.3",
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
                            Id = @"CNS.6.4",
                            Type = @"Component",
                            Position = @"CNS.6.4",
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
                            Id = @"CNS.6.5",
                            Type = @"Component",
                            Position = @"CNS.6.5",
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
                            Id = @"CNS.6.6",
                            Type = @"Component",
                            Position = @"CNS.6.6",
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
                        
                        },
                        };
            }
        }

        public HL7V251SegmentCNS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field startingNotificationReferenceNumber;

public HL7V251Field StartingNotificationReferenceNumber
{
    get
    {
        if (startingNotificationReferenceNumber != null)
        {
            return startingNotificationReferenceNumber;
        }

        startingNotificationReferenceNumber = new HL7V251Field
        {
            field = message[@"CNS"][1],
            Id = @"CNS.1",
            Type = @"Field",
            Position = @"CNS.1",
            Name = @"Starting Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification reference number that is to be cleared.",
            Sample = @"",
        };

        

        

        

        return startingNotificationReferenceNumber;
    } 
}
internal HL7V251Field endingNotificationReferenceNumber;

public HL7V251Field EndingNotificationReferenceNumber
{
    get
    {
        if (endingNotificationReferenceNumber != null)
        {
            return endingNotificationReferenceNumber;
        }

        endingNotificationReferenceNumber = new HL7V251Field
        {
            field = message[@"CNS"][2],
            Id = @"CNS.2",
            Type = @"Field",
            Position = @"CNS.2",
            Name = @"Ending Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification reference number that is to be cleared. If empty, then only notification with Starting Notification Reference Number will be cleared.",
            Sample = @"",
        };

        

        

        

        return endingNotificationReferenceNumber;
    } 
}
internal HL7V251Field startingNotificationDateTime;

public HL7V251Field StartingNotificationDateTime
{
    get
    {
        if (startingNotificationDateTime != null)
        {
            return startingNotificationDateTime;
        }

        startingNotificationDateTime = new HL7V251Field
        {
            field = message[@"CNS"][3],
            Id = @"CNS.3",
            Type = @"Field",
            Position = @"CNS.3",
            Name = @"Starting Notification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the starting date/time of the notifications to be cleared. If this field is empty but Ending Notification Date/Time is filled, then all notifications before Ending Notification Date/Time will be cleared.",
            Sample = @"",
        };

        

        

        

        return startingNotificationDateTime;
    } 
}
internal HL7V251Field endingNotificationDateTime;

public HL7V251Field EndingNotificationDateTime
{
    get
    {
        if (endingNotificationDateTime != null)
        {
            return endingNotificationDateTime;
        }

        endingNotificationDateTime = new HL7V251Field
        {
            field = message[@"CNS"][4],
            Id = @"CNS.4",
            Type = @"Field",
            Position = @"CNS.4",
            Name = @"Ending Notification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the ending date/time of the notifications to be cleared. If this field is empty but Starting Notification Date/Time is filled, then all notifications after Starting Notification Date/Time will be cleared.",
            Sample = @"",
        };

        

        

        

        return endingNotificationDateTime;
    } 
}
internal HL7V251Field startingNotificationCode;

public HL7V251Field StartingNotificationCode
{
    get
    {
        if (startingNotificationCode != null)
        {
            return startingNotificationCode;
        }

        startingNotificationCode = new HL7V251Field
        {
            field = message[@"CNS"][5],
            Id = @"CNS.5",
            Type = @"Field",
            Position = @"CNS.5",
            Name = @"Starting Notification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification Code(CE) 01401).",
            Sample = @"",
        };

        

        

        

        return startingNotificationCode;
    } 
}
internal HL7V251Field endingNotificationCode;

public HL7V251Field EndingNotificationCode
{
    get
    {
        if (endingNotificationCode != null)
        {
            return endingNotificationCode;
        }

        endingNotificationCode = new HL7V251Field
        {
            field = message[@"CNS"][6],
            Id = @"CNS.6",
            Type = @"Field",
            Position = @"CNS.6",
            Name = @"Ending Notification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification Code(CE) 01401). If empty, then only notification with Starting Notification Code will be cleared.",
            Sample = @"",
        };

        

        

        

        return endingNotificationCode;
    } 
}

    }
}

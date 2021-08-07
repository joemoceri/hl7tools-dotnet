using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentEQP
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"EQP"; } }

        public string SegmentId { get { return @"EQP"; } }
        
        public string LongName { get { return @"Equipment/log Service"; } }
        
        public string Description { get { return @"The equipment log/service segment is the data necessary to maintain an adequate audit trail of events that have occurred on a particular piece of equipment."; } }
        
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
                            Id = @"EQP.1",
                            Type = @"Field",
                            Position = @"EQP.1",
                            Name = @"Event type",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0450",
                            TableName = @"Event type",
                            Description = @"This field identifies the type of event of the message. Refer to HL7 Table 0450 - Event typ e for valid values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.1",
                            Type = @"Component",
                            Position = @"EQP.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.2",
                            Type = @"Component",
                            Position = @"EQP.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.3",
                            Type = @"Component",
                            Position = @"EQP.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.4",
                            Type = @"Component",
                            Position = @"EQP.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.5",
                            Type = @"Component",
                            Position = @"EQP.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.6",
                            Type = @"Component",
                            Position = @"EQP.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.7",
                            Type = @"Component",
                            Position = @"EQP.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.8",
                            Type = @"Component",
                            Position = @"EQP.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.1.9",
                            Type = @"Component",
                            Position = @"EQP.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.2",
                            Type = @"Field",
                            Position = @"EQP.2",
                            Name = @"File Name",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the physical file name that is being used to store information about the transmitted log and/or service event.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.3",
                            Type = @"Field",
                            Position = @"EQP.3",
                            Name = @"Start Date/Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time that the event started.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.4",
                            Type = @"Field",
                            Position = @"EQP.4",
                            Name = @"End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date/time that the event was completed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQP.5",
                            Type = @"Field",
                            Position = @"EQP.5",
                            Name = @"Transaction Data",
                            Length = 65536,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the data that the log and/or service event was about and is to be logged.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentEQP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field eventtype;

public HL7V26Field Eventtype
{
    get
    {
        if (eventtype != null)
        {
            return eventtype;
        }

        eventtype = new HL7V26Field
        {
            field = message[@"EQP"][1],
            Id = @"EQP.1",
            Type = @"Field",
            Position = @"EQP.1",
            Name = @"Event type",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0450",
            TableName = @"Event type",
            Description = @"This field identifies the type of event of the message. Refer to HL7 Table 0450 - Event typ e for valid values.",
            Sample = @"",
        };

        

        

        

        return eventtype;
    } 
}
internal HL7V26Field fileName;

public HL7V26Field FileName
{
    get
    {
        if (fileName != null)
        {
            return fileName;
        }

        fileName = new HL7V26Field
        {
            field = message[@"EQP"][2],
            Id = @"EQP.2",
            Type = @"Field",
            Position = @"EQP.2",
            Name = @"File Name",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the physical file name that is being used to store information about the transmitted log and/or service event.",
            Sample = @"",
        };

        

        

        

        return fileName;
    } 
}
internal HL7V26Field startDateTime;

public HL7V26Field StartDateTime
{
    get
    {
        if (startDateTime != null)
        {
            return startDateTime;
        }

        startDateTime = new HL7V26Field
        {
            field = message[@"EQP"][3],
            Id = @"EQP.3",
            Type = @"Field",
            Position = @"EQP.3",
            Name = @"Start Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event started.",
            Sample = @"",
        };

        

        

        

        return startDateTime;
    } 
}
internal HL7V26Field endDateTime;

public HL7V26Field EndDateTime
{
    get
    {
        if (endDateTime != null)
        {
            return endDateTime;
        }

        endDateTime = new HL7V26Field
        {
            field = message[@"EQP"][4],
            Id = @"EQP.4",
            Type = @"Field",
            Position = @"EQP.4",
            Name = @"End Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event was completed.",
            Sample = @"",
        };

        

        

        

        return endDateTime;
    } 
}
internal HL7V26Field transactionData;

public HL7V26Field TransactionData
{
    get
    {
        if (transactionData != null)
        {
            return transactionData;
        }

        transactionData = new HL7V26Field
        {
            field = message[@"EQP"][5],
            Id = @"EQP.5",
            Type = @"Field",
            Position = @"EQP.5",
            Name = @"Transaction Data",
            Length = 65536,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the data that the log and/or service event was about and is to be logged.",
            Sample = @"",
        };

        

        

        

        return transactionData;
    } 
}

    }
}

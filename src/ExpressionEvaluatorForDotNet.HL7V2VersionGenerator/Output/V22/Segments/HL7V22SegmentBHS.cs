using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentBHS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"BHS"; } }

        public string SegmentId { get { return @"BHS"; } }
        
        public string LongName { get { return @"Batch Header"; } }
        
        public string Description { get { return @"The BHS segment defines the start of a batch"; } }
        
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
                            Id = @"BHS.1",
                            Type = @"Field",
                            Position = @"BHS.1",
                            Name = @"Batch Field Separator",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.2",
                            Type = @"Field",
                            Position = @"BHS.2",
                            Name = @"Batch Encoding Characters",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.3",
                            Type = @"Field",
                            Position = @"BHS.3",
                            Name = @"Batch Sending Application",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.4",
                            Type = @"Field",
                            Position = @"BHS.4",
                            Name = @"Batch Sending Facility",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.5",
                            Type = @"Field",
                            Position = @"BHS.5",
                            Name = @"Batch Receiving Application",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.6",
                            Type = @"Field",
                            Position = @"BHS.6",
                            Name = @"Batch Receiving Facility",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7",
                            Type = @"Field",
                            Position = @"BHS.7",
                            Name = @"Batch Creation Date / Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BHS.7.1",
                            Type = @"Component",
                            Position = @"BHS.7.1",
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
                            Id = @"BHS.7.2",
                            Type = @"Component",
                            Position = @"BHS.7.2",
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
                            Id = @"BHS.8",
                            Type = @"Field",
                            Position = @"BHS.8",
                            Name = @"Batch Security",
                            Length = 40,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"has the same definition as the corresponding field in the MSH segment",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.9",
                            Type = @"Field",
                            Position = @"BHS.9",
                            Name = @"Batch Name / Id / Type",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"can be used by the application processing the batch.  It can have extra components if needed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.10",
                            Type = @"Field",
                            Position = @"BHS.10",
                            Name = @"Batch Comment",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"comment field that is not further defined in the HL7 protocol",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.11",
                            Type = @"Field",
                            Position = @"BHS.11",
                            Name = @"Batch Control Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"used to uniquely identify a particular batch.  It can be echoed back in BHS-12-reference batch control ID if an answering batch is needed",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BHS.12",
                            Type = @"Field",
                            Position = @"BHS.12",
                            Name = @"Reference Batch Control Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentBHS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field batchFieldSeparator;

public HL7V22Field BatchFieldSeparator
{
    get
    {
        if (batchFieldSeparator != null)
        {
            return batchFieldSeparator;
        }

        batchFieldSeparator = new HL7V22Field
        {
            field = message[@"BHS"][1],
            Id = @"BHS.1",
            Type = @"Field",
            Position = @"BHS.1",
            Name = @"Batch Field Separator",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchFieldSeparator;
    } 
}
internal HL7V22Field batchEncodingCharacters;

public HL7V22Field BatchEncodingCharacters
{
    get
    {
        if (batchEncodingCharacters != null)
        {
            return batchEncodingCharacters;
        }

        batchEncodingCharacters = new HL7V22Field
        {
            field = message[@"BHS"][2],
            Id = @"BHS.2",
            Type = @"Field",
            Position = @"BHS.2",
            Name = @"Batch Encoding Characters",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchEncodingCharacters;
    } 
}
internal HL7V22Field batchSendingApplication;

public HL7V22Field BatchSendingApplication
{
    get
    {
        if (batchSendingApplication != null)
        {
            return batchSendingApplication;
        }

        batchSendingApplication = new HL7V22Field
        {
            field = message[@"BHS"][3],
            Id = @"BHS.3",
            Type = @"Field",
            Position = @"BHS.3",
            Name = @"Batch Sending Application",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchSendingApplication;
    } 
}
internal HL7V22Field batchSendingFacility;

public HL7V22Field BatchSendingFacility
{
    get
    {
        if (batchSendingFacility != null)
        {
            return batchSendingFacility;
        }

        batchSendingFacility = new HL7V22Field
        {
            field = message[@"BHS"][4],
            Id = @"BHS.4",
            Type = @"Field",
            Position = @"BHS.4",
            Name = @"Batch Sending Facility",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchSendingFacility;
    } 
}
internal HL7V22Field batchReceivingApplication;

public HL7V22Field BatchReceivingApplication
{
    get
    {
        if (batchReceivingApplication != null)
        {
            return batchReceivingApplication;
        }

        batchReceivingApplication = new HL7V22Field
        {
            field = message[@"BHS"][5],
            Id = @"BHS.5",
            Type = @"Field",
            Position = @"BHS.5",
            Name = @"Batch Receiving Application",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchReceivingApplication;
    } 
}
internal HL7V22Field batchReceivingFacility;

public HL7V22Field BatchReceivingFacility
{
    get
    {
        if (batchReceivingFacility != null)
        {
            return batchReceivingFacility;
        }

        batchReceivingFacility = new HL7V22Field
        {
            field = message[@"BHS"][6],
            Id = @"BHS.6",
            Type = @"Field",
            Position = @"BHS.6",
            Name = @"Batch Receiving Facility",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchReceivingFacility;
    } 
}
internal HL7V22Field batchCreationDateTime;

public HL7V22Field BatchCreationDateTime
{
    get
    {
        if (batchCreationDateTime != null)
        {
            return batchCreationDateTime;
        }

        batchCreationDateTime = new HL7V22Field
        {
            field = message[@"BHS"][7],
            Id = @"BHS.7",
            Type = @"Field",
            Position = @"BHS.7",
            Name = @"Batch Creation Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchCreationDateTime;
    } 
}
internal HL7V22Field batchSecurity;

public HL7V22Field BatchSecurity
{
    get
    {
        if (batchSecurity != null)
        {
            return batchSecurity;
        }

        batchSecurity = new HL7V22Field
        {
            field = message[@"BHS"][8],
            Id = @"BHS.8",
            Type = @"Field",
            Position = @"BHS.8",
            Name = @"Batch Security",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"has the same definition as the corresponding field in the MSH segment",
            Sample = @"",
        };

        

        

        

        return batchSecurity;
    } 
}
internal HL7V22Field batchNameIdType;

public HL7V22Field BatchNameIdType
{
    get
    {
        if (batchNameIdType != null)
        {
            return batchNameIdType;
        }

        batchNameIdType = new HL7V22Field
        {
            field = message[@"BHS"][9],
            Id = @"BHS.9",
            Type = @"Field",
            Position = @"BHS.9",
            Name = @"Batch Name / Id / Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"can be used by the application processing the batch.  It can have extra components if needed",
            Sample = @"",
        };

        

        

        

        return batchNameIdType;
    } 
}
internal HL7V22Field batchComment;

public HL7V22Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V22Field
        {
            field = message[@"BHS"][10],
            Id = @"BHS.10",
            Type = @"Field",
            Position = @"BHS.10",
            Name = @"Batch Comment",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"comment field that is not further defined in the HL7 protocol",
            Sample = @"",
        };

        

        

        

        return batchComment;
    } 
}
internal HL7V22Field batchControlId;

public HL7V22Field BatchControlId
{
    get
    {
        if (batchControlId != null)
        {
            return batchControlId;
        }

        batchControlId = new HL7V22Field
        {
            field = message[@"BHS"][11],
            Id = @"BHS.11",
            Type = @"Field",
            Position = @"BHS.11",
            Name = @"Batch Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"used to uniquely identify a particular batch.  It can be echoed back in BHS-12-reference batch control ID if an answering batch is needed",
            Sample = @"",
        };

        

        

        

        return batchControlId;
    } 
}
internal HL7V22Field referenceBatchControlId;

public HL7V22Field ReferenceBatchControlId
{
    get
    {
        if (referenceBatchControlId != null)
        {
            return referenceBatchControlId;
        }

        referenceBatchControlId = new HL7V22Field
        {
            field = message[@"BHS"][12],
            Id = @"BHS.12",
            Type = @"Field",
            Position = @"BHS.12",
            Name = @"Reference Batch Control Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"value of BHS-11-batch control ID when this batch was originally transmitted.  Not present if this batch is being sent for the first time.  See definition for BHS-11-batch control ID",
            Sample = @"",
        };

        

        

        

        return referenceBatchControlId;
    } 
}

    }
}

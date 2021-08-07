using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentBTS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"BTS"; } }

        public string SegmentId { get { return @"BTS"; } }
        
        public string LongName { get { return @"Batch Trailer"; } }
        
        public string Description { get { return @"The BTS segment defines the end of a batch. "; } }
        
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
                            Id = @"BTS.1",
                            Type = @"Field",
                            Position = @"BTS.1",
                            Name = @"Batch Message Count",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"count of the individual messages contained within the batch",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.2",
                            Type = @"Field",
                            Position = @"BTS.2",
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
                            Id = @"BTS.3",
                            Type = @"Field",
                            Position = @"BTS.3",
                            Name = @"Batch Totals",
                            Length = 100,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CM_BATCH_TOTAL",
                            DataTypeName = @"Cm For Batch Totals",
                            TableId = null,
                            TableName = null,
                            Description = @"as many types of totals as needed for the batch may be carried by this field as separate  components.  Each component is an NM data type",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3.1",
                            Type = @"Component",
                            Position = @"BTS.3.1",
                            Name = @"Batch Total 1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3.2",
                            Type = @"Component",
                            Position = @"BTS.3.2",
                            Name = @"Batch Total 2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"BTS.3.3",
                            Type = @"Component",
                            Position = @"BTS.3.3",
                            Name = @"...",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V22SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field batchMessageCount;

public HL7V22Field BatchMessageCount
{
    get
    {
        if (batchMessageCount != null)
        {
            return batchMessageCount;
        }

        batchMessageCount = new HL7V22Field
        {
            field = message[@"BTS"][1],
            Id = @"BTS.1",
            Type = @"Field",
            Position = @"BTS.1",
            Name = @"Batch Message Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"count of the individual messages contained within the batch",
            Sample = @"",
        };

        

        

        

        return batchMessageCount;
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
            field = message[@"BTS"][2],
            Id = @"BTS.2",
            Type = @"Field",
            Position = @"BTS.2",
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
internal HL7V22Field batchTotals;

public HL7V22Field BatchTotals
{
    get
    {
        if (batchTotals != null)
        {
            return batchTotals;
        }

        batchTotals = new HL7V22Field
        {
            field = message[@"BTS"][3],
            Id = @"BTS.3",
            Type = @"Field",
            Position = @"BTS.3",
            Name = @"Batch Totals",
            Length = 100,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_BATCH_TOTAL",
            DataTypeName = @"Cm For Batch Totals",
            TableId = null,
            TableName = null,
            Description = @"as many types of totals as needed for the batch may be carried by this field as separate  components.  Each component is an NM data type",
            Sample = @"",
        };

        

        

        

        return batchTotals;
    } 
}

    }
}

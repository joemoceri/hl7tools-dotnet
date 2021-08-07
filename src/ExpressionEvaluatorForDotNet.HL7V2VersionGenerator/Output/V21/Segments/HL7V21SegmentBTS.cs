using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentBTS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"BTS"; } }

        public string SegmentId { get { return @"BTS"; } }
        
        public string LongName { get { return @"Batch Trailer"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Description = null,
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
                            Description = null,
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
                            Rpt = @"1",
                            DataType = @"CM",
                            DataTypeName = @"",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentBTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field batchMessageCount;

public HL7V21Field BatchMessageCount
{
    get
    {
        if (batchMessageCount != null)
        {
            return batchMessageCount;
        }

        batchMessageCount = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return batchMessageCount;
    } 
}
internal HL7V21Field batchComment;

public HL7V21Field BatchComment
{
    get
    {
        if (batchComment != null)
        {
            return batchComment;
        }

        batchComment = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return batchComment;
    } 
}
internal HL7V21Field batchTotals;

public HL7V21Field BatchTotals
{
    get
    {
        if (batchTotals != null)
        {
            return batchTotals;
        }

        batchTotals = new HL7V21Field
        {
            field = message[@"BTS"][3],
            Id = @"BTS.3",
            Type = @"Field",
            Position = @"BTS.3",
            Name = @"Batch Totals",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return batchTotals;
    } 
}

    }
}

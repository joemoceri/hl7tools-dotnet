using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentFTS
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"FTS"; } }

        public string SegmentId { get { return @"FTS"; } }
        
        public string LongName { get { return @"File Trailer"; } }
        
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
                            Id = @"FTS.1",
                            Type = @"Field",
                            Position = @"FTS.1",
                            Name = @"File Batch Count",
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
                            Id = @"FTS.2",
                            Type = @"Field",
                            Position = @"FTS.2",
                            Name = @"File Trailer Comment",
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
                        };
            }
        }

        public HL7V21SegmentFTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field fileBatchCount;

public HL7V21Field FileBatchCount
{
    get
    {
        if (fileBatchCount != null)
        {
            return fileBatchCount;
        }

        fileBatchCount = new HL7V21Field
        {
            field = message[@"FTS"][1],
            Id = @"FTS.1",
            Type = @"Field",
            Position = @"FTS.1",
            Name = @"File Batch Count",
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

        

        

        

        return fileBatchCount;
    } 
}
internal HL7V21Field fileTrailerComment;

public HL7V21Field FileTrailerComment
{
    get
    {
        if (fileTrailerComment != null)
        {
            return fileTrailerComment;
        }

        fileTrailerComment = new HL7V21Field
        {
            field = message[@"FTS"][2],
            Id = @"FTS.2",
            Type = @"Field",
            Position = @"FTS.2",
            Name = @"File Trailer Comment",
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

        

        

        

        return fileTrailerComment;
    } 
}

    }
}

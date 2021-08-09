using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentFTS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FTS"; } }

        public string SegmentId { get { return @"FTS"; } }
        
        public string LongName { get { return @"File Trailer Segment"; } }
        
        public string Description { get { return @"The FTS segment defines the end of a file. "; } }
        
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
                            Id = @"FTS.1",
                            Type = @"Field",
                            Position = @"FTS.1",
                            Name = @"File Batch Count",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of batches contained in this file.",
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
                            Description = @"The use of this free text field is not further specified.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentFTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field fileBatchCount;

public HL7V251Field FileBatchCount
{
    get
    {
        if (fileBatchCount != null)
        {
            return fileBatchCount;
        }

        fileBatchCount = new HL7V251Field
        {
            field = message[@"FTS"][1],
            Id = @"FTS.1",
            Type = @"Field",
            Position = @"FTS.1",
            Name = @"File Batch Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of batches contained in this file.",
            Sample = @"",
        };

        // check for repetitions
        if (fileBatchCount.field.FieldRepetitions != null && fileBatchCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileBatchCount.Id));
            fileBatchCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(fileBatchCount, fieldData);
        }

        return fileBatchCount;
    } 
}

internal HL7V251Field fileTrailerComment;

public HL7V251Field FileTrailerComment
{
    get
    {
        if (fileTrailerComment != null)
        {
            return fileTrailerComment;
        }

        fileTrailerComment = new HL7V251Field
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
            Description = @"The use of this free text field is not further specified.",
            Sample = @"",
        };

        // check for repetitions
        if (fileTrailerComment.field.FieldRepetitions != null && fileTrailerComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileTrailerComment.Id));
            fileTrailerComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(fileTrailerComment, fieldData);
        }

        return fileTrailerComment;
    } 
}
    }
}

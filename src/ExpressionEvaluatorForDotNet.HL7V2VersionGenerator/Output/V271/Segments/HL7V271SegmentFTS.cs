using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentFTS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FTS"; } }

        public string SegmentId { get { return @"FTS"; } }
        
        public string LongName { get { return @"File Trailer"; } }
        
        public string Description { get { return @"The FTS segment defines the end of a file."; } }
        
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

        public HL7V271SegmentFTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _fileBatchCount;

public HL7V271Field FileBatchCount
{
    get
    {
        if (_fileBatchCount != null)
        {
            return _fileBatchCount;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FTS.1",
            Type = @"Field",
            Position = @"FTS.1",
            Name = @"File Batch Count",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of batches contained in this file.",
            Sample = @"",
            Fields = null
        }

        _fileBatchCount = new HL7V271Field
        {
            field = message[@"FTS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileBatchCount.field.FieldRepetitions != null && _fileBatchCount.field.FieldRepetitions.Count > 0)
        {
            _fileBatchCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileBatchCount, fieldData);
        }

        return _fileBatchCount;
    } 
}

internal HL7V271Field _fileTrailerComment;

public HL7V271Field FileTrailerComment
{
    get
    {
        if (_fileTrailerComment != null)
        {
            return _fileTrailerComment;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"FTS.2",
            Type = @"Field",
            Position = @"FTS.2",
            Name = @"File Trailer Comment",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The use of this free text field is not further specified.",
            Sample = @"",
            Fields = null
        }

        _fileTrailerComment = new HL7V271Field
        {
            field = message[@"FTS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fileTrailerComment.field.FieldRepetitions != null && _fileTrailerComment.field.FieldRepetitions.Count > 0)
        {
            _fileTrailerComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_fileTrailerComment, fieldData);
        }

        return _fileTrailerComment;
    } 
}
    }
}

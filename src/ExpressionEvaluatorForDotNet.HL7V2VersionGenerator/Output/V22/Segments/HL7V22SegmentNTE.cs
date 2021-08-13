using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentNTE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NTE"; } }

        public string SegmentId { get { return @"NTE"; } }
        
        public string LongName { get { return @"Notes And Comments"; } }
        
        public string Description { get { return @"The NTE segment is defined here for inclusion in messages defined in other chapters.  It is a common format for sending notes and comments"; } }
        
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

        public HL7V22SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdNotesAndComments;

public HL7V22Field SetIdNotesAndComments
{
    get
    {
        if (_setIdNotesAndComments != null)
        {
            return _setIdNotesAndComments;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NTE.1",
            Type = @"Field",
            Position = @"NTE.1",
            Name = @"Set Id - Notes And Comments",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"may be used where multiple NTE segments are included in a message.  Their numbering must be described in the application message definition",
            Sample = @"",
            Fields = null
        }

        _setIdNotesAndComments = new HL7V22Field
        {
            field = message[@"NTE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdNotesAndComments.field.FieldRepetitions != null && _setIdNotesAndComments.field.FieldRepetitions.Count > 0)
        {
            _setIdNotesAndComments.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdNotesAndComments, fieldData);
        }

        return _setIdNotesAndComments;
    } 
}

internal HL7V22Field _sourceOfComment;

public HL7V22Field SourceOfComment
{
    get
    {
        if (_sourceOfComment != null)
        {
            return _sourceOfComment;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NTE.2",
            Type = @"Field",
            Position = @"NTE.2",
            Name = @"Source Of Comment",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0105",
            TableName = @"SOURCE OF COMMENT",
            Description = @"used when source of comment must be identified.  This table may be extended locally during implementation",
            Sample = @"",
            Fields = null
        }

        _sourceOfComment = new HL7V22Field
        {
            field = message[@"NTE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceOfComment.field.FieldRepetitions != null && _sourceOfComment.field.FieldRepetitions.Count > 0)
        {
            _sourceOfComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sourceOfComment, fieldData);
        }

        return _sourceOfComment;
    } 
}

internal HL7V22Field _comment;

public HL7V22Field Comment
{
    get
    {
        if (_comment != null)
        {
            return _comment;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"NTE.3",
            Type = @"Field",
            Position = @"NTE.3",
            Name = @"Comment",
            Length = 65536,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"comment contained in the segment

Note: In the current HL7 version,  this is an FT rather than a TX data type.  Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version.",
            Sample = @"",
            Fields = null
        }

        _comment = new HL7V22Field
        {
            field = message[@"NTE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_comment.field.FieldRepetitions != null && _comment.field.FieldRepetitions.Count > 0)
        {
            _comment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_comment, fieldData);
        }

        return _comment;
    } 
}
    }
}

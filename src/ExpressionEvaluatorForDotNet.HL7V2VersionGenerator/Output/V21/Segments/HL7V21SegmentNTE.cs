using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNTE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NTE"; } }

        public string SegmentId { get { return @"NTE"; } }
        
        public string LongName { get { return @"Notes And Comments"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdNotesAndComments;

public HL7V21Field SetIdNotesAndComments
{
    get
    {
        if (_setIdNotesAndComments != null)
        {
            return _setIdNotesAndComments;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NTE.1",
            Type = @"Field",
            Position = @"NTE.1",
            Name = @"Set Id - Notes And Comments",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdNotesAndComments = new HL7V21Field
        {
            field = message[@"NTE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdNotesAndComments.field.FieldRepetitions != null && _setIdNotesAndComments.field.FieldRepetitions.Count > 0)
        {
            _setIdNotesAndComments.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdNotesAndComments, fieldData);
        }

        return _setIdNotesAndComments;
    } 
}

internal HL7V21Field _sourceOfComment;

public HL7V21Field SourceOfComment
{
    get
    {
        if (_sourceOfComment != null)
        {
            return _sourceOfComment;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _sourceOfComment = new HL7V21Field
        {
            field = message[@"NTE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceOfComment.field.FieldRepetitions != null && _sourceOfComment.field.FieldRepetitions.Count > 0)
        {
            _sourceOfComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_sourceOfComment, fieldData);
        }

        return _sourceOfComment;
    } 
}

internal HL7V21Field _comment;

public HL7V21Field Comment
{
    get
    {
        if (_comment != null)
        {
            return _comment;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"NTE.3",
            Type = @"Field",
            Position = @"NTE.3",
            Name = @"Comment",
            Length = 120,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _comment = new HL7V21Field
        {
            field = message[@"NTE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_comment.field.FieldRepetitions != null && _comment.field.FieldRepetitions.Count > 0)
        {
            _comment.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_comment, fieldData);
        }

        return _comment;
    } 
}
    }
}

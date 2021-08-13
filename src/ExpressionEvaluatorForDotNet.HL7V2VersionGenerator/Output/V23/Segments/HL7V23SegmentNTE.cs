using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentNTE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NTE"; } }

        public string SegmentId { get { return @"NTE"; } }
        
        public string LongName { get { return @"Notes and comments segment"; } }
        
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

        public HL7V23SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDNotesandComments;

public HL7V23Field SetIDNotesandComments
{
    get
    {
        if (_setIDNotesandComments != null)
        {
            return _setIDNotesandComments;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NTE.1",
            Type = @"Field",
            Position = @"NTE.1",
            Name = @"Set ID - Notes and Comments",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field may be used where multiple NTE segments are included in a message.  Their numbering must be described in the application message definition",
            Sample = @"",
            Fields = null
        }

        _setIDNotesandComments = new HL7V23Field
        {
            field = message[@"NTE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDNotesandComments.field.FieldRepetitions != null && _setIDNotesandComments.field.FieldRepetitions.Count > 0)
        {
            _setIDNotesandComments.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDNotesandComments, fieldData);
        }

        return _setIDNotesandComments;
    } 
}

internal HL7V23Field _sourceofComment;

public HL7V23Field SourceofComment
{
    get
    {
        if (_sourceofComment != null)
        {
            return _sourceofComment;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"NTE.2",
            Type = @"Field",
            Position = @"NTE.2",
            Name = @"Source of Comment",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0105",
            TableName = @"Source of comment",
            Description = @"This field is used when source of comment must be identified.  This table may be extended locally during implementation",
            Sample = @"",
            Fields = null
        }

        _sourceofComment = new HL7V23Field
        {
            field = message[@"NTE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceofComment.field.FieldRepetitions != null && _sourceofComment.field.FieldRepetitions.Count > 0)
        {
            _sourceofComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sourceofComment, fieldData);
        }

        return _sourceofComment;
    } 
}

internal HL7V23Field _comment;

public HL7V23Field Comment
{
    get
    {
        if (_comment != null)
        {
            return _comment;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the comment contained in the segment

Note:  In the current HL7 version,  this is an FT rather than a TX data type.  Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version",
            Sample = @"",
            Fields = null
        }

        _comment = new HL7V23Field
        {
            field = message[@"NTE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_comment.field.FieldRepetitions != null && _comment.field.FieldRepetitions.Count > 0)
        {
            _comment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_comment, fieldData);
        }

        return _comment;
    } 
}
    }
}

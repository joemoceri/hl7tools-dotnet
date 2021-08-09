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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field setIdNotesAndComments;

public HL7V22Field SetIdNotesAndComments
{
    get
    {
        if (setIdNotesAndComments != null)
        {
            return setIdNotesAndComments;
        }

        setIdNotesAndComments = new HL7V22Field
        {
            field = message[@"NTE"][1],
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
        };

        // check for repetitions
        if (setIdNotesAndComments.field.FieldRepetitions != null && setIdNotesAndComments.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdNotesAndComments.Id));
            setIdNotesAndComments.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(setIdNotesAndComments, fieldData);
        }

        return setIdNotesAndComments;
    } 
}

internal HL7V22Field sourceOfComment;

public HL7V22Field SourceOfComment
{
    get
    {
        if (sourceOfComment != null)
        {
            return sourceOfComment;
        }

        sourceOfComment = new HL7V22Field
        {
            field = message[@"NTE"][2],
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
        };

        // check for repetitions
        if (sourceOfComment.field.FieldRepetitions != null && sourceOfComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceOfComment.Id));
            sourceOfComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(sourceOfComment, fieldData);
        }

        return sourceOfComment;
    } 
}

internal HL7V22Field comment;

public HL7V22Field Comment
{
    get
    {
        if (comment != null)
        {
            return comment;
        }

        comment = new HL7V22Field
        {
            field = message[@"NTE"][3],
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
        };

        // check for repetitions
        if (comment.field.FieldRepetitions != null && comment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(comment.Id));
            comment.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(comment, fieldData);
        }

        return comment;
    } 
}
    }
}

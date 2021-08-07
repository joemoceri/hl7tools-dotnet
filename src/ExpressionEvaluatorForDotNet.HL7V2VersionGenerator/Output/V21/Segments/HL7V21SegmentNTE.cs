using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentNTE
    {
        public readonly HL7V2Message message;

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
                            DataTypeName = @"Set Id",
                            TableId = null,
                            TableName = null,
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdNotesAndComments;

public HL7V21Field SetIdNotesAndComments
{
    get
    {
        if (setIdNotesAndComments != null)
        {
            return setIdNotesAndComments;
        }

        setIdNotesAndComments = new HL7V21Field
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
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        

        

        

        return setIdNotesAndComments;
    } 
}
internal HL7V21Field sourceOfComment;

public HL7V21Field SourceOfComment
{
    get
    {
        if (sourceOfComment != null)
        {
            return sourceOfComment;
        }

        sourceOfComment = new HL7V21Field
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
            Description = null,
            Sample = @"",
        };

        

        

        

        return sourceOfComment;
    } 
}
internal HL7V21Field comment;

public HL7V21Field Comment
{
    get
    {
        if (comment != null)
        {
            return comment;
        }

        comment = new HL7V21Field
        {
            field = message[@"NTE"][3],
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
        };

        

        

        

        return comment;
    } 
}

    }
}

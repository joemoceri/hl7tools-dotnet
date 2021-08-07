using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentNTE
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NTE"; } }

        public string SegmentId { get { return @"NTE"; } }
        
        public string LongName { get { return @"Notes and Comments"; } }
        
        public string Description { get { return @"The NTE segment is defined here for inclusion in messages defined in other chapters. It is commonly used for sending notes and comments."; } }
        
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
                            Name = @"Set ID - NTE",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be used where multiple NTE segments are included in a message. Their numbering must be described in the application message definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field is used when source of comment must be identified. This table may be extended locally during implementation. Refer to HL7 Table 0105 - Source of comment for valid values.",
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
                            Description = @"This field contains the comment contained in the segment.

Note: As of v2.2, this field uses the FT rather than a TX data type. Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4",
                            Type = @"Field",
                            Position = @"NTE.4",
                            Name = @"Comment Type",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0364",
                            TableName = @"Comment type",
                            Description = @"This field contains a value to identify the type of comment text being sent in the specific comment record. Refer to User-Defined Table 0364 - Comment Type for suggested values.

Note: A field already exists on the NTE record that identifies the Sources of Comment (e.g., ancillary, placer, other). However some applications need to support other types of comment text (e.g., instructions, reason, remarks, etc.). A separate NTE segment can be used for each type of comment (e.g., instructions are on one NTE and remarks on another NTE)",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.1",
                            Type = @"Component",
                            Position = @"NTE.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.2",
                            Type = @"Component",
                            Position = @"NTE.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.3",
                            Type = @"Component",
                            Position = @"NTE.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.4",
                            Type = @"Component",
                            Position = @"NTE.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.5",
                            Type = @"Component",
                            Position = @"NTE.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.6",
                            Type = @"Component",
                            Position = @"NTE.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        };
            }
        }

        public HL7V25SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field setIDNTE;

public HL7V25Field SetIDNTE
{
    get
    {
        if (setIDNTE != null)
        {
            return setIDNTE;
        }

        setIDNTE = new HL7V25Field
        {
            field = message[@"NTE"][1],
            Id = @"NTE.1",
            Type = @"Field",
            Position = @"NTE.1",
            Name = @"Set ID - NTE",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field may be used where multiple NTE segments are included in a message. Their numbering must be described in the application message definition.",
            Sample = @"",
        };

        

        

        

        return setIDNTE;
    } 
}
internal HL7V25Field sourceofComment;

public HL7V25Field SourceofComment
{
    get
    {
        if (sourceofComment != null)
        {
            return sourceofComment;
        }

        sourceofComment = new HL7V25Field
        {
            field = message[@"NTE"][2],
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
            Description = @"This field is used when source of comment must be identified. This table may be extended locally during implementation. Refer to HL7 Table 0105 - Source of comment for valid values.",
            Sample = @"",
        };

        

        

        

        return sourceofComment;
    } 
}
internal HL7V25Field comment;

public HL7V25Field Comment
{
    get
    {
        if (comment != null)
        {
            return comment;
        }

        comment = new HL7V25Field
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
            Description = @"This field contains the comment contained in the segment.

Note: As of v2.2, this field uses the FT rather than a TX data type. Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version. ",
            Sample = @"",
        };

        

        

        

        return comment;
    } 
}
internal HL7V25Field commentType;

public HL7V25Field CommentType
{
    get
    {
        if (commentType != null)
        {
            return commentType;
        }

        commentType = new HL7V25Field
        {
            field = message[@"NTE"][4],
            Id = @"NTE.4",
            Type = @"Field",
            Position = @"NTE.4",
            Name = @"Comment Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0364",
            TableName = @"Comment type",
            Description = @"This field contains a value to identify the type of comment text being sent in the specific comment record. Refer to User-Defined Table 0364 - Comment Type for suggested values.

Note: A field already exists on the NTE record that identifies the Sources of Comment (e.g., ancillary, placer, other). However some applications need to support other types of comment text (e.g., instructions, reason, remarks, etc.). A separate NTE segment can be used for each type of comment (e.g., instructions are on one NTE and remarks on another NTE)",
            Sample = @"",
        };

        

        

        

        return commentType;
    } 
}

    }
}

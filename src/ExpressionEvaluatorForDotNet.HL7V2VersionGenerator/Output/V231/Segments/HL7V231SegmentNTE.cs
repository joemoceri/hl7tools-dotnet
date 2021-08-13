using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentNTE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NTE"; } }

        public string SegmentId { get { return @"NTE"; } }
        
        public string LongName { get { return @"Notes and comments segment"; } }
        
        public string Description { get { return @"The NTE segment is defined here for inclusion in messages defined in other chapters. It is a common format for sending notes and comments."; } }
        
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

        public HL7V231SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDNTE;

public HL7V231Field SetIDNTE
{
    get
    {
        if (_setIDNTE != null)
        {
            return _setIDNTE;
        }

        var fieldData = new HL7V231FieldData
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
            Fields = null
        }

        _setIDNTE = new HL7V231Field
        {
            field = message[@"NTE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDNTE.field.FieldRepetitions != null && _setIDNTE.field.FieldRepetitions.Count > 0)
        {
            _setIDNTE.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDNTE, fieldData);
        }

        return _setIDNTE;
    } 
}

internal HL7V231Field _sourceofComment;

public HL7V231Field SourceofComment
{
    get
    {
        if (_sourceofComment != null)
        {
            return _sourceofComment;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field is used when source of comment must be identified. This table may be extended locally during implementation.",
            Sample = @"",
            Fields = null
        }

        _sourceofComment = new HL7V231Field
        {
            field = message[@"NTE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceofComment.field.FieldRepetitions != null && _sourceofComment.field.FieldRepetitions.Count > 0)
        {
            _sourceofComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sourceofComment, fieldData);
        }

        return _sourceofComment;
    } 
}

internal HL7V231Field _comment;

public HL7V231Field Comment
{
    get
    {
        if (_comment != null)
        {
            return _comment;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the comment contained in the segment.",
            Sample = @"",
            Fields = null
        }

        _comment = new HL7V231Field
        {
            field = message[@"NTE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_comment.field.FieldRepetitions != null && _comment.field.FieldRepetitions.Count > 0)
        {
            _comment.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_comment, fieldData);
        }

        return _comment;
    } 
}

internal HL7V231Field _commentType;

public HL7V231Field CommentType
{
    get
    {
        if (_commentType != null)
        {
            return _commentType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"NTE.4",
            Type = @"Field",
            Position = @"NTE.4",
            Name = @"Comment Type",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0364",
            TableName = @"Comment type",
            Description = @"This field contains a value to identify the type of comment text being sent in the specific comment record. Refer to user-defined table 0364-Comment type for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NTE.4.1",
                            Type = @"Component",
                            Position = @"NTE.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.2",
                            Type = @"Component",
                            Position = @"NTE.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.3",
                            Type = @"Component",
                            Position = @"NTE.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.4",
                            Type = @"Component",
                            Position = @"NTE.4.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NTE.4.5",
                            Type = @"Component",
                            Position = @"NTE.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
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
                            Id = @"NTE.4.6",
                            Type = @"Component",
                            Position = @"NTE.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
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
                        }
        }

        _commentType = new HL7V231Field
        {
            field = message[@"NTE"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_commentType.field.FieldRepetitions != null && _commentType.field.FieldRepetitions.Count > 0)
        {
            _commentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_commentType, fieldData);
        }

        return _commentType;
    } 
}
    }
}

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
                            Description = @"This field is used when source of comment must be identified.  This table may be extended locally during implementation",
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
                            Description = @"This field contains the comment contained in the segment

Note:  In the current HL7 version,  this is an FT rather than a TX data type.  Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentNTE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field setIDNotesandComments;

public HL7V23Field SetIDNotesandComments
{
    get
    {
        if (setIDNotesandComments != null)
        {
            return setIDNotesandComments;
        }

        setIDNotesandComments = new HL7V23Field
        {
            field = message[@"NTE"][1],
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
        };

        // check for repetitions
        if (setIDNotesandComments.field.FieldRepetitions != null && setIDNotesandComments.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDNotesandComments.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < setIDNotesandComments.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = setIDNotesandComments.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < setIDNotesandComments.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = setIDNotesandComments.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < setIDNotesandComments.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = setIDNotesandComments.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            setIDNotesandComments.fieldRepetitions = fieldRepetitions;
        }

        return setIDNotesandComments;
    } 
}

internal HL7V23Field sourceofComment;

public HL7V23Field SourceofComment
{
    get
    {
        if (sourceofComment != null)
        {
            return sourceofComment;
        }

        sourceofComment = new HL7V23Field
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
            Description = @"This field is used when source of comment must be identified.  This table may be extended locally during implementation",
            Sample = @"",
        };

        // check for repetitions
        if (sourceofComment.field.FieldRepetitions != null && sourceofComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceofComment.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < sourceofComment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = sourceofComment.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < sourceofComment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = sourceofComment.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < sourceofComment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = sourceofComment.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            sourceofComment.fieldRepetitions = fieldRepetitions;
        }

        return sourceofComment;
    } 
}

internal HL7V23Field comment;

public HL7V23Field Comment
{
    get
    {
        if (comment != null)
        {
            return comment;
        }

        comment = new HL7V23Field
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
            Description = @"This field contains the comment contained in the segment

Note:  In the current HL7 version,  this is an FT rather than a TX data type.  Since there is no difference between an FT data type without any embedded formatting commands, and a TX data type, this change is compatible with the previous version",
            Sample = @"",
        };

        // check for repetitions
        if (comment.field.FieldRepetitions != null && comment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(comment.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < comment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = comment.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V23Component>();

                    // there should be components per repetition
                    for (var j = 0; j < comment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = comment.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V23SubComponent>();

                            for (var k = 0; k < comment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = comment.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            comment.fieldRepetitions = fieldRepetitions;
        }

        return comment;
    } 
}
    }
}

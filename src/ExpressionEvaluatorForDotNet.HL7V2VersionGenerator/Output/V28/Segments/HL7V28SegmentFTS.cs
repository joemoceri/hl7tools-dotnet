using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentFTS
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
                            Length = 0,
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
                            Length = 0,
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

        public HL7V28SegmentFTS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field fileBatchCount;

public HL7V28Field FileBatchCount
{
    get
    {
        if (fileBatchCount != null)
        {
            return fileBatchCount;
        }

        fileBatchCount = new HL7V28Field
        {
            field = message[@"FTS"][1],
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
        };

        // check for repetitions
        if (fileBatchCount.field.FieldRepetitions != null && fileBatchCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileBatchCount.Id));
            var fieldRepetitions = new List<HL7V28FieldRepetition>();

            for (var i = 0; i < fileBatchCount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V28FieldRepetition
                {
                    fieldRepetition = fileBatchCount.field.FieldRepetitions[i],
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
                    var components = new List<HL7V28Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileBatchCount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V28Component
                        {
                            component = fileBatchCount.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V28SubComponent>();

                            for (var k = 0; k < fileBatchCount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V28SubComponent
                                {
                                    subComponent = fileBatchCount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileBatchCount.fieldRepetitions = fieldRepetitions;
        }

        return fileBatchCount;
    } 
}

internal HL7V28Field fileTrailerComment;

public HL7V28Field FileTrailerComment
{
    get
    {
        if (fileTrailerComment != null)
        {
            return fileTrailerComment;
        }

        fileTrailerComment = new HL7V28Field
        {
            field = message[@"FTS"][2],
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
        };

        // check for repetitions
        if (fileTrailerComment.field.FieldRepetitions != null && fileTrailerComment.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fileTrailerComment.Id));
            var fieldRepetitions = new List<HL7V28FieldRepetition>();

            for (var i = 0; i < fileTrailerComment.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V28FieldRepetition
                {
                    fieldRepetition = fileTrailerComment.field.FieldRepetitions[i],
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
                    var components = new List<HL7V28Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fileTrailerComment.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V28Component
                        {
                            component = fileTrailerComment.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V28SubComponent>();

                            for (var k = 0; k < fileTrailerComment.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V28SubComponent
                                {
                                    subComponent = fileTrailerComment.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fileTrailerComment.fieldRepetitions = fieldRepetitions;
        }

        return fileTrailerComment;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentRDT
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RDT"; } }

        public string SegmentId { get { return @"RDT"; } }
        
        public string LongName { get { return @"Table Row Data"; } }
        
        public string Description { get { return @"The RDT segment contains the row data of the tabular data response message (TBR)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Id = @"RDT.1",
                            Type = @"Field",
                            Position = @"RDT.1",
                            Name = @"Column Value",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"varies",
                            DataTypeName = @"Varies",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a requested field.  Fields occur in the position order defined for the query or table (unless overridden by an optional RDF segment on a stored procedure request or Virtual Table query message), separated by field delimiters.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentRDT(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V27Field columnValue;

public HL7V27Field ColumnValue
{
    get
    {
        if (columnValue != null)
        {
            return columnValue;
        }

        columnValue = new HL7V27Field
        {
            field = message[@"RDT"][1],
            Id = @"RDT.1",
            Type = @"Field",
            Position = @"RDT.1",
            Name = @"Column Value",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"varies",
            DataTypeName = @"Varies",
            TableId = null,
            TableName = null,
            Description = @"This field is a requested field.  Fields occur in the position order defined for the query or table (unless overridden by an optional RDF segment on a stored procedure request or Virtual Table query message), separated by field delimiters.",
            Sample = @"",
        };

        // check for repetitions
        if (columnValue.field.FieldRepetitions != null && columnValue.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(columnValue.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < columnValue.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = columnValue.field.FieldRepetitions[i],
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
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < columnValue.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = columnValue.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < columnValue.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = columnValue.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            columnValue.fieldRepetitions = fieldRepetitions;
        }

        return columnValue;
    } 
}

    }
}

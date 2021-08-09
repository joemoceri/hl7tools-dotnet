using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentMRG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MRG"; } }

        public string SegmentId { get { return @"MRG"; } }
        
        public string LongName { get { return @"Merge Patient Information"; } }
        
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
                            Id = @"MRG.1",
                            Type = @"Field",
                            Position = @"MRG.1",
                            Name = @"Prior Patient Id - Internal",
                            Length = 16,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.2",
                            Type = @"Field",
                            Position = @"MRG.2",
                            Name = @"Prior Alternate Patient Id",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MRG.3",
                            Type = @"Field",
                            Position = @"MRG.3",
                            Name = @"Prior Patient Account Number",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CK",
                            DataTypeName = @"Composite Id With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentMRG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field priorPatientIdInternal;

public HL7V21Field PriorPatientIdInternal
{
    get
    {
        if (priorPatientIdInternal != null)
        {
            return priorPatientIdInternal;
        }

        priorPatientIdInternal = new HL7V21Field
        {
            field = message[@"MRG"][1],
            Id = @"MRG.1",
            Type = @"Field",
            Position = @"MRG.1",
            Name = @"Prior Patient Id - Internal",
            Length = 16,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorPatientIdInternal.field.FieldRepetitions != null && priorPatientIdInternal.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorPatientIdInternal.Id));
            var fieldRepetitions = new List<HL7V21FieldRepetition>();

            for (var i = 0; i < priorPatientIdInternal.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V21FieldRepetition
                {
                    fieldRepetition = priorPatientIdInternal.field.FieldRepetitions[i],
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
                    var components = new List<HL7V21Component>();

                    // there should be components per repetition
                    for (var j = 0; j < priorPatientIdInternal.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V21Component
                        {
                            component = priorPatientIdInternal.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V21SubComponent>();

                            for (var k = 0; k < priorPatientIdInternal.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V21SubComponent
                                {
                                    subComponent = priorPatientIdInternal.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            priorPatientIdInternal.fieldRepetitions = fieldRepetitions;
        }

        return priorPatientIdInternal;
    } 
}

internal HL7V21Field priorAlternatePatientId;

public HL7V21Field PriorAlternatePatientId
{
    get
    {
        if (priorAlternatePatientId != null)
        {
            return priorAlternatePatientId;
        }

        priorAlternatePatientId = new HL7V21Field
        {
            field = message[@"MRG"][2],
            Id = @"MRG.2",
            Type = @"Field",
            Position = @"MRG.2",
            Name = @"Prior Alternate Patient Id",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorAlternatePatientId.field.FieldRepetitions != null && priorAlternatePatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorAlternatePatientId.Id));
            var fieldRepetitions = new List<HL7V21FieldRepetition>();

            for (var i = 0; i < priorAlternatePatientId.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V21FieldRepetition
                {
                    fieldRepetition = priorAlternatePatientId.field.FieldRepetitions[i],
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
                    var components = new List<HL7V21Component>();

                    // there should be components per repetition
                    for (var j = 0; j < priorAlternatePatientId.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V21Component
                        {
                            component = priorAlternatePatientId.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V21SubComponent>();

                            for (var k = 0; k < priorAlternatePatientId.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V21SubComponent
                                {
                                    subComponent = priorAlternatePatientId.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            priorAlternatePatientId.fieldRepetitions = fieldRepetitions;
        }

        return priorAlternatePatientId;
    } 
}

internal HL7V21Field priorPatientAccountNumber;

public HL7V21Field PriorPatientAccountNumber
{
    get
    {
        if (priorPatientAccountNumber != null)
        {
            return priorPatientAccountNumber;
        }

        priorPatientAccountNumber = new HL7V21Field
        {
            field = message[@"MRG"][3],
            Id = @"MRG.3",
            Type = @"Field",
            Position = @"MRG.3",
            Name = @"Prior Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (priorPatientAccountNumber.field.FieldRepetitions != null && priorPatientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(priorPatientAccountNumber.Id));
            var fieldRepetitions = new List<HL7V21FieldRepetition>();

            for (var i = 0; i < priorPatientAccountNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V21FieldRepetition
                {
                    fieldRepetition = priorPatientAccountNumber.field.FieldRepetitions[i],
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
                    var components = new List<HL7V21Component>();

                    // there should be components per repetition
                    for (var j = 0; j < priorPatientAccountNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V21Component
                        {
                            component = priorPatientAccountNumber.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V21SubComponent>();

                            for (var k = 0; k < priorPatientAccountNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V21SubComponent
                                {
                                    subComponent = priorPatientAccountNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            priorPatientAccountNumber.fieldRepetitions = fieldRepetitions;
        }

        return priorPatientAccountNumber;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentDSC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DSC"; } }

        public string SegmentId { get { return @"DSC"; } }
        
        public string LongName { get { return @"Continuation Pointer"; } }
        
        public string Description { get { return @"The DSC segment is used in the continuation protocol."; } }
        
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
                            Id = @"DSC.1",
                            Type = @"Field",
                            Position = @"DSC.1",
                            Name = @"Continuation Pointer",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. For use with continuations of unsolicited messages, see chapter 5 and section 2.10.2, ""Continuation messages and segments."" Note that continuation protocols work with both display- and record-oriented messages.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DSC.2",
                            Type = @"Field",
                            Position = @"DSC.2",
                            Name = @"Continuation Style",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0398",
                            TableName = @"Continuation Style Code",
                            Description = @"Indicates whether this is a fragmented message (see Section 2.10.2, ""Continuation messages and segments""), or if it is part of an interactive continuation message (see Section 5.6.3, ""Interactive continuation of response messages"").",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V28SegmentDSC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field continuationPointer;

public HL7V28Field ContinuationPointer
{
    get
    {
        if (continuationPointer != null)
        {
            return continuationPointer;
        }

        continuationPointer = new HL7V28Field
        {
            field = message[@"DSC"][1],
            Id = @"DSC.1",
            Type = @"Field",
            Position = @"DSC.1",
            Name = @"Continuation Pointer",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the continuation pointer. In an initial query, this field is not present. If the responder returns a value of null or not present, then there is no more data to fulfill any future continuation requests. For use with continuations of unsolicited messages, see chapter 5 and section 2.10.2, ""Continuation messages and segments."" Note that continuation protocols work with both display- and record-oriented messages.",
            Sample = @"",
        };

        // check for repetitions
        if (continuationPointer.field.FieldRepetitions != null && continuationPointer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationPointer.Id));
            var fieldRepetitions = new List<HL7V28FieldRepetition>();

            for (var i = 0; i < continuationPointer.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V28FieldRepetition
                {
                    fieldRepetition = continuationPointer.field.FieldRepetitions[i],
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
                    for (var j = 0; j < continuationPointer.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V28Component
                        {
                            component = continuationPointer.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < continuationPointer.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V28SubComponent
                                {
                                    subComponent = continuationPointer.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            continuationPointer.fieldRepetitions = fieldRepetitions;
        }

        return continuationPointer;
    } 
}

internal HL7V28Field continuationStyle;

public HL7V28Field ContinuationStyle
{
    get
    {
        if (continuationStyle != null)
        {
            return continuationStyle;
        }

        continuationStyle = new HL7V28Field
        {
            field = message[@"DSC"][2],
            Id = @"DSC.2",
            Type = @"Field",
            Position = @"DSC.2",
            Name = @"Continuation Style",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0398",
            TableName = @"Continuation Style Code",
            Description = @"Indicates whether this is a fragmented message (see Section 2.10.2, ""Continuation messages and segments""), or if it is part of an interactive continuation message (see Section 5.6.3, ""Interactive continuation of response messages"").",
            Sample = @"",
        };

        // check for repetitions
        if (continuationStyle.field.FieldRepetitions != null && continuationStyle.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(continuationStyle.Id));
            var fieldRepetitions = new List<HL7V28FieldRepetition>();

            for (var i = 0; i < continuationStyle.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V28FieldRepetition
                {
                    fieldRepetition = continuationStyle.field.FieldRepetitions[i],
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
                    for (var j = 0; j < continuationStyle.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V28Component
                        {
                            component = continuationStyle.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < continuationStyle.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V28SubComponent
                                {
                                    subComponent = continuationStyle.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            continuationStyle.fieldRepetitions = fieldRepetitions;
        }

        return continuationStyle;
    } 
}
    }
}

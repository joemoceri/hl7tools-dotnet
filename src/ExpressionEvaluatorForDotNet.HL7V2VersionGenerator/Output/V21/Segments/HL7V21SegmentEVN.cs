using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentEVN
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"EVN"; } }

        public string SegmentId { get { return @"EVN"; } }

        public string LongName { get { return @"Event Type"; } }

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
                            Id = @"EVN.1",
                            Type = @"Field",
                            Position = @"EVN.1",
                            Name = @"Event Type Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0003",
                            TableName = @"EVENT TYPE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"EVN.2",
                            Type = @"Field",
                            Position = @"EVN.2",
                            Name = @"Date/Time Of Event",
                            Length = 19,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"EVN.3",
                            Type = @"Field",
                            Position = @"EVN.3",
                            Name = @"Date/Time Planned Event",
                            Length = 19,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"EVN.4",
                            Type = @"Field",
                            Position = @"EVN.4",
                            Name = @"Event Reason Code",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0062",
                            TableName = @"EVENT REASON",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentEVN(HL7V2Message message)
        {
            this.message = message;
        }


        internal HL7V21Field eventTypeCode;

        public HL7V21Field EventTypeCode
        {
            get
            {
                if (eventTypeCode != null)
                {
                    return eventTypeCode;
                }

                eventTypeCode = new HL7V21Field
                {
                    field = message[@"EVN"][1],
                    Id = @"EVN.1",
                    Type = @"Field",
                    Position = @"EVN.1",
                    Name = @"Event Type Code",
                    Length = 3,
                    Usage = @"R",
                    Rpt = @"1",
                    DataType = @"ID",
                    DataTypeName = @"Coded Value",
                    TableId = @"0003",
                    TableName = @"EVENT TYPE CODE",
                    Description = null,
                    Sample = @"",
                };

                // check for repetitions
                if (eventTypeCode.field.FieldRepetitions != null && eventTypeCode.field.FieldRepetitions.Count > 0)
                {
                    // get this fields data
                    var fieldData = Fields.First(fd => fd.Id.Equals(eventTypeCode.Id));
                    var fieldRepetitions = new List<HL7V21FieldRepetition>();

                    for (var i = 0; i < eventTypeCode.field.FieldRepetitions.Count; i++)
                    {
                        var fieldRepetition = new HL7V21FieldRepetition
                        {
                            fieldRepetition = eventTypeCode.field.FieldRepetitions[i],
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
                            for (var j = 0; j < eventTypeCode.field.Components(i + 1).Count; j++)
                            {
                                var componentFieldData = fieldData.FieldDatas[j];
                                var component = new HL7V21Component
                                {
                                    component = eventTypeCode.field.FieldRepetitions[i].Components[j],
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

                                    for (var k = 0; k < eventTypeCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                                    {
                                        var subComponentFieldData = componentFieldData.FieldDatas[k];
                                        var subComponent = new HL7V21SubComponent
                                        {
                                            subComponent = eventTypeCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
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

                    eventTypeCode.fieldRepetitions = fieldRepetitions;
                }

                return eventTypeCode;
            }
        }

        internal HL7V21Field dateTimeOfEvent;

        public HL7V21Field DateTimeOfEvent
        {
            get
            {
                if (dateTimeOfEvent != null)
                {
                    return dateTimeOfEvent;
                }

                dateTimeOfEvent = new HL7V21Field
                {
                    field = message[@"EVN"][2],
                    Id = @"EVN.2",
                    Type = @"Field",
                    Position = @"EVN.2",
                    Name = @"Date/Time Of Event",
                    Length = 19,
                    Usage = @"R",
                    Rpt = @"1",
                    DataType = @"TS",
                    DataTypeName = @"Time Stamp",
                    TableId = null,
                    TableName = null,
                    Description = null,
                    Sample = @"",
                };

                // check for repetitions
                if (dateTimeOfEvent.field.FieldRepetitions != null && dateTimeOfEvent.field.FieldRepetitions.Count > 0)
                {
                    // get this fields data
                    var fieldData = Fields.First(fd => fd.Id.Equals(dateTimeOfEvent.Id));
                    var fieldRepetitions = new List<HL7V21FieldRepetition>();

                    for (var i = 0; i < dateTimeOfEvent.field.FieldRepetitions.Count; i++)
                    {
                        var fieldRepetition = new HL7V21FieldRepetition
                        {
                            fieldRepetition = dateTimeOfEvent.field.FieldRepetitions[i],
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
                            for (var j = 0; j < dateTimeOfEvent.field.Components(i + 1).Count; j++)
                            {
                                var componentFieldData = fieldData.FieldDatas[j];
                                var component = new HL7V21Component
                                {
                                    component = dateTimeOfEvent.field.FieldRepetitions[i].Components[j],
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

                                    for (var k = 0; k < dateTimeOfEvent.field.Components(i + 1)[j].SubComponents.Count; k++)
                                    {
                                        var subComponentFieldData = componentFieldData.FieldDatas[k];
                                        var subComponent = new HL7V21SubComponent
                                        {
                                            subComponent = dateTimeOfEvent.field.FieldRepetitions[i].Components[j].SubComponents[k],
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

                    dateTimeOfEvent.fieldRepetitions = fieldRepetitions;
                }

                return dateTimeOfEvent;
            }
        }

        internal HL7V21Field dateTimePlannedEvent;

        public HL7V21Field DateTimePlannedEvent
        {
            get
            {
                if (dateTimePlannedEvent != null)
                {
                    return dateTimePlannedEvent;
                }

                dateTimePlannedEvent = new HL7V21Field
                {
                    field = message[@"EVN"][3],
                    Id = @"EVN.3",
                    Type = @"Field",
                    Position = @"EVN.3",
                    Name = @"Date/Time Planned Event",
                    Length = 19,
                    Usage = @"O",
                    Rpt = @"1",
                    DataType = @"TS",
                    DataTypeName = @"Time Stamp",
                    TableId = null,
                    TableName = null,
                    Description = null,
                    Sample = @"",
                };

                // check for repetitions
                if (dateTimePlannedEvent.field.FieldRepetitions != null && dateTimePlannedEvent.field.FieldRepetitions.Count > 0)
                {
                    // get this fields data
                    var fieldData = Fields.First(fd => fd.Id.Equals(dateTimePlannedEvent.Id));
                    var fieldRepetitions = new List<HL7V21FieldRepetition>();

                    for (var i = 0; i < dateTimePlannedEvent.field.FieldRepetitions.Count; i++)
                    {
                        var fieldRepetition = new HL7V21FieldRepetition
                        {
                            fieldRepetition = dateTimePlannedEvent.field.FieldRepetitions[i],
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
                            for (var j = 0; j < dateTimePlannedEvent.field.Components(i + 1).Count; j++)
                            {
                                var componentFieldData = fieldData.FieldDatas[j];
                                var component = new HL7V21Component
                                {
                                    component = dateTimePlannedEvent.field.FieldRepetitions[i].Components[j],
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

                                    for (var k = 0; k < dateTimePlannedEvent.field.Components(i + 1)[j].SubComponents.Count; k++)
                                    {
                                        var subComponentFieldData = componentFieldData.FieldDatas[k];
                                        var subComponent = new HL7V21SubComponent
                                        {
                                            subComponent = dateTimePlannedEvent.field.FieldRepetitions[i].Components[j].SubComponents[k],
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

                    dateTimePlannedEvent.fieldRepetitions = fieldRepetitions;
                }

                return dateTimePlannedEvent;
            }
        }

        internal HL7V21Field eventReasonCode;

        public HL7V21Field EventReasonCode
        {
            get
            {
                if (eventReasonCode != null)
                {
                    return eventReasonCode;
                }

                eventReasonCode = new HL7V21Field
                {
                    field = message[@"EVN"][4],
                    Id = @"EVN.4",
                    Type = @"Field",
                    Position = @"EVN.4",
                    Name = @"Event Reason Code",
                    Length = 3,
                    Usage = @"O",
                    Rpt = @"1",
                    DataType = @"ID",
                    DataTypeName = @"Coded Value",
                    TableId = @"0062",
                    TableName = @"EVENT REASON",
                    Description = null,
                    Sample = @"",
                };

                // check for repetitions
                if (eventReasonCode.field.FieldRepetitions != null && eventReasonCode.field.FieldRepetitions.Count > 0)
                {
                    // get this fields data
                    var fieldData = Fields.First(fd => fd.Id.Equals(eventReasonCode.Id));
                    var fieldRepetitions = new List<HL7V21FieldRepetition>();

                    for (var i = 0; i < eventReasonCode.field.FieldRepetitions.Count; i++)
                    {
                        var fieldRepetition = new HL7V21FieldRepetition
                        {
                            fieldRepetition = eventReasonCode.field.FieldRepetitions[i],
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
                            for (var j = 0; j < eventReasonCode.field.Components(i + 1).Count; j++)
                            {
                                var componentFieldData = fieldData.FieldDatas[j];
                                var component = new HL7V21Component
                                {
                                    component = eventReasonCode.field.FieldRepetitions[i].Components[j],
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

                                    for (var k = 0; k < eventReasonCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                                    {
                                        var subComponentFieldData = componentFieldData.FieldDatas[k];
                                        var subComponent = new HL7V21SubComponent
                                        {
                                            subComponent = eventReasonCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
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

                    eventReasonCode.fieldRepetitions = fieldRepetitions;
                }

                return eventReasonCode;
            }
        }

    }
}

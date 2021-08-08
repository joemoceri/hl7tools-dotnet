using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentAPR
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"APR"; } }

        public string SegmentId { get { return @"APR"; } }
        
        public string LongName { get { return @"Appointment Preferences"; } }
        
        public string Description { get { return @"The APR segment contains parameters and preference specifications used for requesting appointments in the SRM message. It allows placer applications to provide coded parameters and preference indicators to the filler application, to help determine when a requested appointment should be scheduled. An APR segment can be provided in conjunction with either the ARQ segment or any of the service and resource segments (AIG, AIS, AIP, and AIL). If an APR segment appears in conjunction with an ARQ segment, its parameters and preference indicators pertain to the schedule request as a whole. If the APR segment appears with any of the service and resource segments, then its parameters and preferences apply only to the immediately preceding service or resource."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Id = @"APR.1",
                            Type = @"Field",
                            Position = @"APR.1",
                            Name = @"Time Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"APR.1.1",
                            Type = @"Component",
                            Position = @"APR.1.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined table 0294Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.1.2",
                            Type = @"Component",
                            Position = @"APR.1.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2",
                            Type = @"Field",
                            Position = @"APR.2",
                            Name = @"Resource Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate resource for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"APR.2.1",
                            Type = @"Component",
                            Position = @"APR.2.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined table 0294Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2.2",
                            Type = @"Component",
                            Position = @"APR.2.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3",
                            Type = @"Field",
                            Position = @"APR.3",
                            Name = @"Location Selection Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate location for the appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"APR.3.1",
                            Type = @"Component",
                            Position = @"APR.3.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined table 0294Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3.2",
                            Type = @"Component",
                            Position = @"APR.3.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.4",
                            Type = @"Field",
                            Position = @"APR.4",
                            Name = @"Slot Spacing Criteria",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used in queries returning lists of possible appointment slots, or other lists of slots. If the filler application allows it, the querying application may indicate the spacing of the slots returned to the querying application, in relation to the requested start date/time in the ARQ segment. The value in this field should be a positive integer, representing the number of minutes between slot starting times that is returned in the query.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5",
                            Type = @"Field",
                            Position = @"APR.5",
                            Name = @"Filler Override Criteria",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"SCV",
                            DataTypeName = @"Scheduling Class Value Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is used to communicate override parameters to the filler application. These override parameters allow placer applications to override specific features of filler applications such as conflict checking. It is assumed that the placer and filler applications will pass enough information to determine whether the requestor is allowed to override such features. This chapter does not provide any security or permission information.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"APR.5.1",
                            Type = @"Component",
                            Position = @"APR.5.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined table 0294Time selection criteria parameter class codes for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5.2",
                            Type = @"Component",
                            Position = @"APR.5.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        };
            }
        }

        public HL7V24SegmentAPR(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V24Field timeSelectionCriteria;

public HL7V24Field TimeSelectionCriteria
{
    get
    {
        if (timeSelectionCriteria != null)
        {
            return timeSelectionCriteria;
        }

        timeSelectionCriteria = new HL7V24Field
        {
            field = message[@"APR"][1],
            Id = @"APR.1",
            Type = @"Field",
            Position = @"APR.1",
            Name = @"Time Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (timeSelectionCriteria.field.FieldRepetitions != null && timeSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(timeSelectionCriteria.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < timeSelectionCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = timeSelectionCriteria.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < timeSelectionCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = timeSelectionCriteria.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < timeSelectionCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = timeSelectionCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            timeSelectionCriteria.fieldRepetitions = fieldRepetitions;
        }

        return timeSelectionCriteria;
    } 
}

internal HL7V24Field resourceSelectionCriteria;

public HL7V24Field ResourceSelectionCriteria
{
    get
    {
        if (resourceSelectionCriteria != null)
        {
            return resourceSelectionCriteria;
        }

        resourceSelectionCriteria = new HL7V24Field
        {
            field = message[@"APR"][2],
            Id = @"APR.2",
            Type = @"Field",
            Position = @"APR.2",
            Name = @"Resource Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate resource for an appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (resourceSelectionCriteria.field.FieldRepetitions != null && resourceSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(resourceSelectionCriteria.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < resourceSelectionCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = resourceSelectionCriteria.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < resourceSelectionCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = resourceSelectionCriteria.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < resourceSelectionCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = resourceSelectionCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            resourceSelectionCriteria.fieldRepetitions = fieldRepetitions;
        }

        return resourceSelectionCriteria;
    } 
}

internal HL7V24Field locationSelectionCriteria;

public HL7V24Field LocationSelectionCriteria
{
    get
    {
        if (locationSelectionCriteria != null)
        {
            return locationSelectionCriteria;
        }

        locationSelectionCriteria = new HL7V24Field
        {
            field = message[@"APR"][3],
            Id = @"APR.3",
            Type = @"Field",
            Position = @"APR.3",
            Name = @"Location Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate location for the appointment. The first component of this field is a code identifying the parameter or preference being passed to the filler application. The second component is the actual data value for that parameter.",
            Sample = @"",
        };

        // check for repetitions
        if (locationSelectionCriteria.field.FieldRepetitions != null && locationSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(locationSelectionCriteria.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < locationSelectionCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = locationSelectionCriteria.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < locationSelectionCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = locationSelectionCriteria.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < locationSelectionCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = locationSelectionCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            locationSelectionCriteria.fieldRepetitions = fieldRepetitions;
        }

        return locationSelectionCriteria;
    } 
}

internal HL7V24Field slotSpacingCriteria;

public HL7V24Field SlotSpacingCriteria
{
    get
    {
        if (slotSpacingCriteria != null)
        {
            return slotSpacingCriteria;
        }

        slotSpacingCriteria = new HL7V24Field
        {
            field = message[@"APR"][4],
            Id = @"APR.4",
            Type = @"Field",
            Position = @"APR.4",
            Name = @"Slot Spacing Criteria",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is used in queries returning lists of possible appointment slots, or other lists of slots. If the filler application allows it, the querying application may indicate the spacing of the slots returned to the querying application, in relation to the requested start date/time in the ARQ segment. The value in this field should be a positive integer, representing the number of minutes between slot starting times that is returned in the query.",
            Sample = @"",
        };

        // check for repetitions
        if (slotSpacingCriteria.field.FieldRepetitions != null && slotSpacingCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(slotSpacingCriteria.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < slotSpacingCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = slotSpacingCriteria.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < slotSpacingCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = slotSpacingCriteria.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < slotSpacingCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = slotSpacingCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            slotSpacingCriteria.fieldRepetitions = fieldRepetitions;
        }

        return slotSpacingCriteria;
    } 
}

internal HL7V24Field fillerOverrideCriteria;

public HL7V24Field FillerOverrideCriteria
{
    get
    {
        if (fillerOverrideCriteria != null)
        {
            return fillerOverrideCriteria;
        }

        fillerOverrideCriteria = new HL7V24Field
        {
            field = message[@"APR"][5],
            Id = @"APR.5",
            Type = @"Field",
            Position = @"APR.5",
            Name = @"Filler Override Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate override parameters to the filler application. These override parameters allow placer applications to override specific features of filler applications such as conflict checking. It is assumed that the placer and filler applications will pass enough information to determine whether the requestor is allowed to override such features. This chapter does not provide any security or permission information.",
            Sample = @"",
        };

        // check for repetitions
        if (fillerOverrideCriteria.field.FieldRepetitions != null && fillerOverrideCriteria.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(fillerOverrideCriteria.Id));
            var fieldRepetitions = new List<HL7V24FieldRepetition>();

            for (var i = 0; i < fillerOverrideCriteria.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V24FieldRepetition
                {
                    fieldRepetition = fillerOverrideCriteria.field.FieldRepetitions[i],
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
                    var components = new List<HL7V24Component>();

                    // there should be components per repetition
                    for (var j = 0; j < fillerOverrideCriteria.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V24Component
                        {
                            component = fillerOverrideCriteria.field.FieldRepetitions[i].Components[j],
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
                            var subComponents = new List<HL7V24SubComponent>();

                            for (var k = 0; k < fillerOverrideCriteria.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V24SubComponent
                                {
                                    subComponent = fillerOverrideCriteria.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            fillerOverrideCriteria.fieldRepetitions = fieldRepetitions;
        }

        return fillerOverrideCriteria;
    } 
}

    }
}

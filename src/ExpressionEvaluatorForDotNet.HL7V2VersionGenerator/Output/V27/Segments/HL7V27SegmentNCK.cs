using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentNCK
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"NCK"; } }

        public string SegmentId { get { return @"NCK"; } }
        
        public string LongName { get { return @"System Clock"; } }
        
        public string Description { get { return @"The NCK segment is used to allow the various applications on the network to synchronize their system clocks (system date and time).

Usage Notes: If this message is to be used to automatically reset/correct system clocks, it is recommended that the system or administrative personnel initiating the NMQ with the NCK segment have the authority to correct the clock (system date and time) for the other systems on the network.  This is important in order to avoid the obvious confusion of multiple systems attempting to resynchronize each other's clocks.

If this message is used only to gather information on the various systems' clocks, it is still important for an administrative procedure to be worked out to avoid conflicts when resetting clocks."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",
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
                            Id = @"NCK.1",
                            Type = @"Field",
                            Position = @"NCK.1",
                            Name = @"System Date/Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an HL7 time stamp.  It is strongly recommended that seconds be included.  If the message contains an NST or NSC segment, the NCK segment is optional.  If the NCK segment is present, this field is required.  If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system.  If present in the NMR response message, it contains the responding system's date/time. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentNCK(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V27Field systemDateTime;

public HL7V27Field SystemDateTime
{
    get
    {
        if (systemDateTime != null)
        {
            return systemDateTime;
        }

        systemDateTime = new HL7V27Field
        {
            field = message[@"NCK"][1],
            Id = @"NCK.1",
            Type = @"Field",
            Position = @"NCK.1",
            Name = @"System Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains an HL7 time stamp.  It is strongly recommended that seconds be included.  If the message contains an NST or NSC segment, the NCK segment is optional.  If the NCK segment is present, this field is required.  If present in the NMQ message, or the unsolicited NMD message, it contains the system date/time of the sending system.  If present in the NMR response message, it contains the responding system's date/time. ",
            Sample = @"",
        };

        // check for repetitions
        if (systemDateTime.field.FieldRepetitions != null && systemDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(systemDateTime.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < systemDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = systemDateTime.field.FieldRepetitions[i],
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
                    for (var j = 0; j < systemDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = systemDateTime.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < systemDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = systemDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            systemDateTime.fieldRepetitions = fieldRepetitions;
        }

        return systemDateTime;
    } 
}

    }
}

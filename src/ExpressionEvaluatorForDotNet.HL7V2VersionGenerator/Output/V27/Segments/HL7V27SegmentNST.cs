using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentNST
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NST"; } }

        public string SegmentId { get { return @"NST"; } }
        
        public string LongName { get { return @"Application Control Level Statistics"; } }
        
        public string Description { get { return @"The NST segment allows application control-level statistical information to be passed between the various systems on the network.  Some fields in this segment refer to portions of lower level protocols; they contain information that can be used by application management applications monitoring the state of various network links. 

Usage Notes: Fields 2-15.  These are all marked optional since the statistics kept on a particular link and negotiated between the two systems in question will vary.  Not all values will apply to each system.  Some values are concerned with the type of port, and some values pertain to the lower level protocol."; } }
        
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
                            Id = @"NST.1",
                            Type = @"Field",
                            Position = @"NST.1",
                            Name = @"Statistics Available",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0136",
                            TableName = @"Yes/no Indicator",
                            Description = @"This field indicates the availability of statistics. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.  
N - the responding application does not keep any statistics.  If the value ""N"" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).  
Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.2",
                            Type = @"Field",
                            Position = @"NST.2",
                            Name = @"Source Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies a particular lower level link (e.g., a port number). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.3",
                            Type = @"Field",
                            Position = @"NST.3",
                            Name = @"Source Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0332",
                            TableName = @"Source Type",
                            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type.   Refer to HL7 Table 0332 – Source Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.4",
                            Type = @"Field",
                            Position = @"NST.4",
                            Name = @"Statistics Start",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.5",
                            Type = @"Field",
                            Position = @"NST.5",
                            Name = @"Statistics End",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.6",
                            Type = @"Field",
                            Position = @"NST.6",
                            Name = @"Receive Character Count",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters received. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.7",
                            Type = @"Field",
                            Position = @"NST.7",
                            Name = @"Send Character Count",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of characters sent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.8",
                            Type = @"Field",
                            Position = @"NST.8",
                            Name = @"Messages Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.9",
                            Type = @"Field",
                            Position = @"NST.9",
                            Name = @"Messages Sent",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages sent. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.10",
                            Type = @"Field",
                            Position = @"NST.10",
                            Name = @"Checksum Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of messages received with checksum errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.11",
                            Type = @"Field",
                            Position = @"NST.11",
                            Name = @"Length Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"field contains the number of messages received with length errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.12",
                            Type = @"Field",
                            Position = @"NST.12",
                            Name = @"Other Errors Received",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of connect timeout errors. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.13",
                            Type = @"Field",
                            Position = @"NST.13",
                            Name = @"Connect Timeouts",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.14",
                            Type = @"Field",
                            Position = @"NST.14",
                            Name = @"Receive Timeouts",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NST.15",
                            Type = @"Field",
                            Position = @"NST.15",
                            Name = @"Application Control-level Errors",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number of application control-level errors in response to an initiated message. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V27SegmentNST(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field statisticsAvailable;

public HL7V27Field StatisticsAvailable
{
    get
    {
        if (statisticsAvailable != null)
        {
            return statisticsAvailable;
        }

        statisticsAvailable = new HL7V27Field
        {
            field = message[@"NST"][1],
            Id = @"NST.1",
            Type = @"Field",
            Position = @"NST.1",
            Name = @"Statistics Available",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0136",
            TableName = @"Yes/no Indicator",
            Description = @"This field indicates the availability of statistics. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.  
N - the responding application does not keep any statistics.  If the value ""N"" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).  
Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsAvailable.field.FieldRepetitions != null && statisticsAvailable.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsAvailable.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < statisticsAvailable.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = statisticsAvailable.field.FieldRepetitions[i],
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
                    for (var j = 0; j < statisticsAvailable.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = statisticsAvailable.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < statisticsAvailable.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = statisticsAvailable.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            statisticsAvailable.fieldRepetitions = fieldRepetitions;
        }

        return statisticsAvailable;
    } 
}

internal HL7V27Field sourceIdentifier;

public HL7V27Field SourceIdentifier
{
    get
    {
        if (sourceIdentifier != null)
        {
            return sourceIdentifier;
        }

        sourceIdentifier = new HL7V27Field
        {
            field = message[@"NST"][2],
            Id = @"NST.2",
            Type = @"Field",
            Position = @"NST.2",
            Name = @"Source Identifier",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a particular lower level link (e.g., a port number). ",
            Sample = @"",
        };

        // check for repetitions
        if (sourceIdentifier.field.FieldRepetitions != null && sourceIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceIdentifier.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < sourceIdentifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = sourceIdentifier.field.FieldRepetitions[i],
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
                    for (var j = 0; j < sourceIdentifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = sourceIdentifier.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < sourceIdentifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = sourceIdentifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sourceIdentifier.fieldRepetitions = fieldRepetitions;
        }

        return sourceIdentifier;
    } 
}

internal HL7V27Field sourceType;

public HL7V27Field SourceType
{
    get
    {
        if (sourceType != null)
        {
            return sourceType;
        }

        sourceType = new HL7V27Field
        {
            field = message[@"NST"][3],
            Id = @"NST.3",
            Type = @"Field",
            Position = @"NST.3",
            Name = @"Source Type",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0332",
            TableName = @"Source Type",
            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type.   Refer to HL7 Table 0332 – Source Type for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (sourceType.field.FieldRepetitions != null && sourceType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sourceType.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < sourceType.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = sourceType.field.FieldRepetitions[i],
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
                    for (var j = 0; j < sourceType.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = sourceType.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < sourceType.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = sourceType.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sourceType.fieldRepetitions = fieldRepetitions;
        }

        return sourceType;
    } 
}

internal HL7V27Field statisticsStart;

public HL7V27Field StatisticsStart
{
    get
    {
        if (statisticsStart != null)
        {
            return statisticsStart;
        }

        statisticsStart = new HL7V27Field
        {
            field = message[@"NST"][4],
            Id = @"NST.4",
            Type = @"Field",
            Position = @"NST.4",
            Name = @"Statistics Start",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsStart.field.FieldRepetitions != null && statisticsStart.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsStart.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < statisticsStart.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = statisticsStart.field.FieldRepetitions[i],
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
                    for (var j = 0; j < statisticsStart.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = statisticsStart.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < statisticsStart.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = statisticsStart.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            statisticsStart.fieldRepetitions = fieldRepetitions;
        }

        return statisticsStart;
    } 
}

internal HL7V27Field statisticsEnd;

public HL7V27Field StatisticsEnd
{
    get
    {
        if (statisticsEnd != null)
        {
            return statisticsEnd;
        }

        statisticsEnd = new HL7V27Field
        {
            field = message[@"NST"][5],
            Id = @"NST.5",
            Type = @"Field",
            Position = @"NST.5",
            Name = @"Statistics End",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6 15 of this segment.  It is strongly recommended that this value include seconds. ",
            Sample = @"",
        };

        // check for repetitions
        if (statisticsEnd.field.FieldRepetitions != null && statisticsEnd.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(statisticsEnd.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < statisticsEnd.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = statisticsEnd.field.FieldRepetitions[i],
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
                    for (var j = 0; j < statisticsEnd.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = statisticsEnd.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < statisticsEnd.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = statisticsEnd.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            statisticsEnd.fieldRepetitions = fieldRepetitions;
        }

        return statisticsEnd;
    } 
}

internal HL7V27Field receiveCharacterCount;

public HL7V27Field ReceiveCharacterCount
{
    get
    {
        if (receiveCharacterCount != null)
        {
            return receiveCharacterCount;
        }

        receiveCharacterCount = new HL7V27Field
        {
            field = message[@"NST"][6],
            Id = @"NST.6",
            Type = @"Field",
            Position = @"NST.6",
            Name = @"Receive Character Count",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters received. ",
            Sample = @"",
        };

        // check for repetitions
        if (receiveCharacterCount.field.FieldRepetitions != null && receiveCharacterCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receiveCharacterCount.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < receiveCharacterCount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = receiveCharacterCount.field.FieldRepetitions[i],
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
                    for (var j = 0; j < receiveCharacterCount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = receiveCharacterCount.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < receiveCharacterCount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = receiveCharacterCount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receiveCharacterCount.fieldRepetitions = fieldRepetitions;
        }

        return receiveCharacterCount;
    } 
}

internal HL7V27Field sendCharacterCount;

public HL7V27Field SendCharacterCount
{
    get
    {
        if (sendCharacterCount != null)
        {
            return sendCharacterCount;
        }

        sendCharacterCount = new HL7V27Field
        {
            field = message[@"NST"][7],
            Id = @"NST.7",
            Type = @"Field",
            Position = @"NST.7",
            Name = @"Send Character Count",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters sent. ",
            Sample = @"",
        };

        // check for repetitions
        if (sendCharacterCount.field.FieldRepetitions != null && sendCharacterCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sendCharacterCount.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < sendCharacterCount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = sendCharacterCount.field.FieldRepetitions[i],
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
                    for (var j = 0; j < sendCharacterCount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = sendCharacterCount.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < sendCharacterCount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = sendCharacterCount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            sendCharacterCount.fieldRepetitions = fieldRepetitions;
        }

        return sendCharacterCount;
    } 
}

internal HL7V27Field messagesReceived;

public HL7V27Field MessagesReceived
{
    get
    {
        if (messagesReceived != null)
        {
            return messagesReceived;
        }

        messagesReceived = new HL7V27Field
        {
            field = message[@"NST"][8],
            Id = @"NST.8",
            Type = @"Field",
            Position = @"NST.8",
            Name = @"Messages Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received. ",
            Sample = @"",
        };

        // check for repetitions
        if (messagesReceived.field.FieldRepetitions != null && messagesReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messagesReceived.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < messagesReceived.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = messagesReceived.field.FieldRepetitions[i],
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
                    for (var j = 0; j < messagesReceived.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = messagesReceived.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < messagesReceived.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = messagesReceived.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            messagesReceived.fieldRepetitions = fieldRepetitions;
        }

        return messagesReceived;
    } 
}

internal HL7V27Field messagesSent;

public HL7V27Field MessagesSent
{
    get
    {
        if (messagesSent != null)
        {
            return messagesSent;
        }

        messagesSent = new HL7V27Field
        {
            field = message[@"NST"][9],
            Id = @"NST.9",
            Type = @"Field",
            Position = @"NST.9",
            Name = @"Messages Sent",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages sent. ",
            Sample = @"",
        };

        // check for repetitions
        if (messagesSent.field.FieldRepetitions != null && messagesSent.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(messagesSent.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < messagesSent.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = messagesSent.field.FieldRepetitions[i],
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
                    for (var j = 0; j < messagesSent.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = messagesSent.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < messagesSent.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = messagesSent.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            messagesSent.fieldRepetitions = fieldRepetitions;
        }

        return messagesSent;
    } 
}

internal HL7V27Field checksumErrorsReceived;

public HL7V27Field ChecksumErrorsReceived
{
    get
    {
        if (checksumErrorsReceived != null)
        {
            return checksumErrorsReceived;
        }

        checksumErrorsReceived = new HL7V27Field
        {
            field = message[@"NST"][10],
            Id = @"NST.10",
            Type = @"Field",
            Position = @"NST.10",
            Name = @"Checksum Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with checksum errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (checksumErrorsReceived.field.FieldRepetitions != null && checksumErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(checksumErrorsReceived.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < checksumErrorsReceived.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = checksumErrorsReceived.field.FieldRepetitions[i],
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
                    for (var j = 0; j < checksumErrorsReceived.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = checksumErrorsReceived.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < checksumErrorsReceived.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = checksumErrorsReceived.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            checksumErrorsReceived.fieldRepetitions = fieldRepetitions;
        }

        return checksumErrorsReceived;
    } 
}

internal HL7V27Field lengthErrorsReceived;

public HL7V27Field LengthErrorsReceived
{
    get
    {
        if (lengthErrorsReceived != null)
        {
            return lengthErrorsReceived;
        }

        lengthErrorsReceived = new HL7V27Field
        {
            field = message[@"NST"][11],
            Id = @"NST.11",
            Type = @"Field",
            Position = @"NST.11",
            Name = @"Length Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"field contains the number of messages received with length errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (lengthErrorsReceived.field.FieldRepetitions != null && lengthErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(lengthErrorsReceived.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < lengthErrorsReceived.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = lengthErrorsReceived.field.FieldRepetitions[i],
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
                    for (var j = 0; j < lengthErrorsReceived.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = lengthErrorsReceived.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < lengthErrorsReceived.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = lengthErrorsReceived.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            lengthErrorsReceived.fieldRepetitions = fieldRepetitions;
        }

        return lengthErrorsReceived;
    } 
}

internal HL7V27Field otherErrorsReceived;

public HL7V27Field OtherErrorsReceived
{
    get
    {
        if (otherErrorsReceived != null)
        {
            return otherErrorsReceived;
        }

        otherErrorsReceived = new HL7V27Field
        {
            field = message[@"NST"][12],
            Id = @"NST.12",
            Type = @"Field",
            Position = @"NST.12",
            Name = @"Other Errors Received",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of connect timeout errors. ",
            Sample = @"",
        };

        // check for repetitions
        if (otherErrorsReceived.field.FieldRepetitions != null && otherErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(otherErrorsReceived.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < otherErrorsReceived.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = otherErrorsReceived.field.FieldRepetitions[i],
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
                    for (var j = 0; j < otherErrorsReceived.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = otherErrorsReceived.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < otherErrorsReceived.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = otherErrorsReceived.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            otherErrorsReceived.fieldRepetitions = fieldRepetitions;
        }

        return otherErrorsReceived;
    } 
}

internal HL7V27Field connectTimeouts;

public HL7V27Field ConnectTimeouts
{
    get
    {
        if (connectTimeouts != null)
        {
            return connectTimeouts;
        }

        connectTimeouts = new HL7V27Field
        {
            field = message[@"NST"][13],
            Id = @"NST.13",
            Type = @"Field",
            Position = @"NST.13",
            Name = @"Connect Timeouts",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message.",
            Sample = @"",
        };

        // check for repetitions
        if (connectTimeouts.field.FieldRepetitions != null && connectTimeouts.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(connectTimeouts.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < connectTimeouts.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = connectTimeouts.field.FieldRepetitions[i],
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
                    for (var j = 0; j < connectTimeouts.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = connectTimeouts.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < connectTimeouts.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = connectTimeouts.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            connectTimeouts.fieldRepetitions = fieldRepetitions;
        }

        return connectTimeouts;
    } 
}

internal HL7V27Field receiveTimeouts;

public HL7V27Field ReceiveTimeouts
{
    get
    {
        if (receiveTimeouts != null)
        {
            return receiveTimeouts;
        }

        receiveTimeouts = new HL7V27Field
        {
            field = message[@"NST"][14],
            Id = @"NST.14",
            Type = @"Field",
            Position = @"NST.14",
            Name = @"Receive Timeouts",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message. ",
            Sample = @"",
        };

        // check for repetitions
        if (receiveTimeouts.field.FieldRepetitions != null && receiveTimeouts.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(receiveTimeouts.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < receiveTimeouts.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = receiveTimeouts.field.FieldRepetitions[i],
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
                    for (var j = 0; j < receiveTimeouts.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = receiveTimeouts.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < receiveTimeouts.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = receiveTimeouts.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            receiveTimeouts.fieldRepetitions = fieldRepetitions;
        }

        return receiveTimeouts;
    } 
}

internal HL7V27Field applicationControllevelErrors;

public HL7V27Field ApplicationControllevelErrors
{
    get
    {
        if (applicationControllevelErrors != null)
        {
            return applicationControllevelErrors;
        }

        applicationControllevelErrors = new HL7V27Field
        {
            field = message[@"NST"][15],
            Id = @"NST.15",
            Type = @"Field",
            Position = @"NST.15",
            Name = @"Application Control-level Errors",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of application control-level errors in response to an initiated message. ",
            Sample = @"",
        };

        // check for repetitions
        if (applicationControllevelErrors.field.FieldRepetitions != null && applicationControllevelErrors.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(applicationControllevelErrors.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < applicationControllevelErrors.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = applicationControllevelErrors.field.FieldRepetitions[i],
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
                    for (var j = 0; j < applicationControllevelErrors.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = applicationControllevelErrors.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < applicationControllevelErrors.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = applicationControllevelErrors.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            applicationControllevelErrors.fieldRepetitions = fieldRepetitions;
        }

        return applicationControllevelErrors;
    } 
}
    }
}

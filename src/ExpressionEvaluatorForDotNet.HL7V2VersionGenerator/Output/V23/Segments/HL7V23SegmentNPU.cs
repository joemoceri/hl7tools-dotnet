using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentNPU
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NPU"; } }

        public string SegmentId { get { return @"NPU"; } }
        
        public string LongName { get { return @"Bed status update"; } }
        
        public string Description { get { return @"The NPU segment allows the updating of census (bed status) data without sending patient-specific data.  An example might include changing the status of a bed from “housekeeping” to “unoccupied.” "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

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
                            Id = @"NPU.1",
                            Type = @"Field",
                            Position = @"NPU.1",
                            Name = @"Bed Location",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"PL",
                            DataTypeName = @"Person Location",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the bed location that is a valid bed location",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NPU.1.1",
                            Type = @"Component",
                            Position = @"NPU.1.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = @"Conditional on person location type (e.g., nursing unit or department or clinic).  After floor, most general patient location designation.  Refer to user-defined table 0302 - Point of care for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.2",
                            Type = @"Component",
                            Position = @"NPU.1.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"Patient room.  After nursing unit, most general person location designation.  Refer to user-defined table 0303 - Room for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.3",
                            Type = @"Component",
                            Position = @"NPU.1.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"Patient bed.  After room, most general person location designation.  Refer to user-defined table 0304 - Bed for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.4",
                            Type = @"Component",
                            Position = @"NPU.1.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Most general person location designation. (See Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"NPU.1.4.1",
                            Type = @"SubComponent",
                            Position = @"NPU.1.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.4.2",
                            Type = @"SubComponent",
                            Position = @"NPU.1.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.4.3",
                            Type = @"SubComponent",
                            Position = @"NPU.1.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.5",
                            Type = @"Component",
                            Position = @"NPU.1.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = @"Location (e.g., Bed) status.  Refer to user-defined table 0306 - Location status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.6",
                            Type = @"Component",
                            Position = @"NPU.1.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = @"Usually includes values such as nursing unit, department, clinic, SNF, physician’s office.  Refer to userdefined table 0305 - Person location type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.7",
                            Type = @"Component",
                            Position = @"NPU.1.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"After facility, most general person location designation.  Refer to user-defined table 0307 - Building for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.8",
                            Type = @"Component",
                            Position = @"NPU.1.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"After building, most general person location designation.  Refer to user-defined table 0308 - Floor for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.1.9",
                            Type = @"Component",
                            Position = @"NPU.1.9",
                            Name = @"Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A free text description of the location",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NPU.2",
                            Type = @"Field",
                            Position = @"NPU.2",
                            Name = @"Bed Status",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0116",
                            TableName = @"Bed status",
                            Description = @"This field contains the bed status.   Refer to user-defined table 0116 - Bed status for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentNPU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field bedLocation;

public HL7V23Field BedLocation
{
    get
    {
        if (bedLocation != null)
        {
            return bedLocation;
        }

        bedLocation = new HL7V23Field
        {
            field = message[@"NPU"][1],
            Id = @"NPU.1",
            Type = @"Field",
            Position = @"NPU.1",
            Name = @"Bed Location",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PL",
            DataTypeName = @"Person Location",
            TableId = null,
            TableName = null,
            Description = @"This field contains the bed location that is a valid bed location",
            Sample = @"",
        };

        // check for repetitions
        if (bedLocation.field.FieldRepetitions != null && bedLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedLocation.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < bedLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = bedLocation.field.FieldRepetitions[i],
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
                    for (var j = 0; j < bedLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = bedLocation.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < bedLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = bedLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            bedLocation.fieldRepetitions = fieldRepetitions;
        }

        return bedLocation;
    } 
}

internal HL7V23Field bedStatus;

public HL7V23Field BedStatus
{
    get
    {
        if (bedStatus != null)
        {
            return bedStatus;
        }

        bedStatus = new HL7V23Field
        {
            field = message[@"NPU"][2],
            Id = @"NPU.2",
            Type = @"Field",
            Position = @"NPU.2",
            Name = @"Bed Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0116",
            TableName = @"Bed status",
            Description = @"This field contains the bed status.   Refer to user-defined table 0116 - Bed status for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (bedStatus.field.FieldRepetitions != null && bedStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(bedStatus.Id));
            var fieldRepetitions = new List<HL7V23FieldRepetition>();

            for (var i = 0; i < bedStatus.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V23FieldRepetition
                {
                    fieldRepetition = bedStatus.field.FieldRepetitions[i],
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
                    for (var j = 0; j < bedStatus.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V23Component
                        {
                            component = bedStatus.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < bedStatus.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V23SubComponent
                                {
                                    subComponent = bedStatus.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            bedStatus.fieldRepetitions = fieldRepetitions;
        }

        return bedStatus;
    } 
}
    }
}

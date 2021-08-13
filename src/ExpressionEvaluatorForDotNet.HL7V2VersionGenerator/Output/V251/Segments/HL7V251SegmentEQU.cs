using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentEQU
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EQU"; } }

        public string SegmentId { get { return @"EQU"; } }
        
        public string LongName { get { return @"Equipment Detail"; } }
        
        public string Description { get { return @"The equipment detail segment contains the data necessary to identify and maintain the equipment that is being used throughout the Laboratory Automation System."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V251SegmentEQU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _equipmentInstanceIdentifier;

public HL7V251Field EquipmentInstanceIdentifier
{
    get
    {
        if (_equipmentInstanceIdentifier != null)
        {
            return _equipmentInstanceIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"EQU.1",
            Type = @"Field",
            Position = @"EQU.1",
            Name = @"Equipment Instance Identifier",
            Length = 22,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the equipment. This is the identifier from an institution's master list of equipment. The <namespace ID> identifies the institution.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQU.1.1",
                            Type = @"Component",
                            Position = @"EQU.1.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.1.2",
                            Type = @"Component",
                            Position = @"EQU.1.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.1.3",
                            Type = @"Component",
                            Position = @"EQU.1.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.1.4",
                            Type = @"Component",
                            Position = @"EQU.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _equipmentInstanceIdentifier = new HL7V251Field
        {
            field = message[@"EQU"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentInstanceIdentifier.field.FieldRepetitions != null && _equipmentInstanceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _equipmentInstanceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_equipmentInstanceIdentifier, fieldData);
        }

        return _equipmentInstanceIdentifier;
    } 
}

internal HL7V251Field _eventDateTime;

public HL7V251Field EventDateTime
{
    get
    {
        if (_eventDateTime != null)
        {
            return _eventDateTime;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"EQU.2",
            Type = @"Field",
            Position = @"EQU.2",
            Name = @"Event Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event (e.g., state transition, issuing of command, finishing of command execution) occurred.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQU.2.1",
                            Type = @"Component",
                            Position = @"EQU.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.2.2",
                            Type = @"Component",
                            Position = @"EQU.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eventDateTime = new HL7V251Field
        {
            field = message[@"EQU"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDateTime.field.FieldRepetitions != null && _eventDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_eventDateTime, fieldData);
        }

        return _eventDateTime;
    } 
}

internal HL7V251Field _equipmentState;

public HL7V251Field EquipmentState
{
    get
    {
        if (_equipmentState != null)
        {
            return _equipmentState;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"EQU.3",
            Type = @"Field",
            Position = @"EQU.3",
            Name = @"Equipment State",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0365",
            TableName = @"Equipment state",
            Description = @"This field identifies the status that the equipment was in at the time that the transaction was initiated. Refer to HL7 Table 0365 - Equipment state for valid values. The Equipment State is required in the ESU message and is optional otherwise.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQU.3.1",
                            Type = @"Component",
                            Position = @"EQU.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.2",
                            Type = @"Component",
                            Position = @"EQU.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.3",
                            Type = @"Component",
                            Position = @"EQU.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.4",
                            Type = @"Component",
                            Position = @"EQU.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.5",
                            Type = @"Component",
                            Position = @"EQU.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.6",
                            Type = @"Component",
                            Position = @"EQU.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _equipmentState = new HL7V251Field
        {
            field = message[@"EQU"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentState.field.FieldRepetitions != null && _equipmentState.field.FieldRepetitions.Count > 0)
        {
            _equipmentState.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_equipmentState, fieldData);
        }

        return _equipmentState;
    } 
}

internal HL7V251Field _localRemoteControlState;

public HL7V251Field LocalRemoteControlState
{
    get
    {
        if (_localRemoteControlState != null)
        {
            return _localRemoteControlState;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"EQU.4",
            Type = @"Field",
            Position = @"EQU.4",
            Name = @"Local/Remote Control State",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0366",
            TableName = @"Local/remote control state",
            Description = @"This field identifies the current state of control associated with the equipment. An equipment can either work autonomously ('Local' control state) or it can be controlled by another system, e.g., LAS computer ('Remote' control state). Refer to HL7 Table 0366 - Local/remote control state for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQU.4.1",
                            Type = @"Component",
                            Position = @"EQU.4.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.2",
                            Type = @"Component",
                            Position = @"EQU.4.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.3",
                            Type = @"Component",
                            Position = @"EQU.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.4",
                            Type = @"Component",
                            Position = @"EQU.4.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.5",
                            Type = @"Component",
                            Position = @"EQU.4.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.6",
                            Type = @"Component",
                            Position = @"EQU.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _localRemoteControlState = new HL7V251Field
        {
            field = message[@"EQU"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_localRemoteControlState.field.FieldRepetitions != null && _localRemoteControlState.field.FieldRepetitions.Count > 0)
        {
            _localRemoteControlState.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_localRemoteControlState, fieldData);
        }

        return _localRemoteControlState;
    } 
}

internal HL7V251Field _alertLevel;

public HL7V251Field AlertLevel
{
    get
    {
        if (_alertLevel != null)
        {
            return _alertLevel;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"EQU.5",
            Type = @"Field",
            Position = @"EQU.5",
            Name = @"Alert Level",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0367",
            TableName = @"Alert level",
            Description = @"This field identifies the highest level of the alert state (e.g., highest alert severity) that is associated with the indicated equipment (e.g. processing event, inventory event, QC event). Refer to HL7 Table 0367 - Alert level for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQU.5.1",
                            Type = @"Component",
                            Position = @"EQU.5.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.2",
                            Type = @"Component",
                            Position = @"EQU.5.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.3",
                            Type = @"Component",
                            Position = @"EQU.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.4",
                            Type = @"Component",
                            Position = @"EQU.5.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.5",
                            Type = @"Component",
                            Position = @"EQU.5.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.6",
                            Type = @"Component",
                            Position = @"EQU.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _alertLevel = new HL7V251Field
        {
            field = message[@"EQU"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alertLevel.field.FieldRepetitions != null && _alertLevel.field.FieldRepetitions.Count > 0)
        {
            _alertLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_alertLevel, fieldData);
        }

        return _alertLevel;
    } 
}
    }
}

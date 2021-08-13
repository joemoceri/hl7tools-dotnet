using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentEQU
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

        public HL7V26SegmentEQU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _equipmentInstanceIdentifier;

public HL7V26Field EquipmentInstanceIdentifier
{
    get
    {
        if (_equipmentInstanceIdentifier != null)
        {
            return _equipmentInstanceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQU.1",
            Type = @"Field",
            Position = @"EQU.1",
            Name = @"Equipment Instance Identifier",
            Length = 427,
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

        _equipmentInstanceIdentifier = new HL7V26Field
        {
            field = message[@"EQU"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentInstanceIdentifier.field.FieldRepetitions != null && _equipmentInstanceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _equipmentInstanceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_equipmentInstanceIdentifier, fieldData);
        }

        return _equipmentInstanceIdentifier;
    } 
}

internal HL7V26Field _eventDateTime;

public HL7V26Field EventDateTime
{
    get
    {
        if (_eventDateTime != null)
        {
            return _eventDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQU.2",
            Type = @"Field",
            Position = @"EQU.2",
            Name = @"Event Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time that the event (e.g., state transition, issuing of command, finishing of command execution) occurred.",
            Sample = @"",
            Fields = null
        }

        _eventDateTime = new HL7V26Field
        {
            field = message[@"EQU"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventDateTime.field.FieldRepetitions != null && _eventDateTime.field.FieldRepetitions.Count > 0)
        {
            _eventDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_eventDateTime, fieldData);
        }

        return _eventDateTime;
    } 
}

internal HL7V26Field _equipmentState;

public HL7V26Field EquipmentState
{
    get
    {
        if (_equipmentState != null)
        {
            return _equipmentState;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQU.3",
            Type = @"Field",
            Position = @"EQU.3",
            Name = @"Equipment State",
            Length = 705,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.7",
                            Type = @"Component",
                            Position = @"EQU.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.8",
                            Type = @"Component",
                            Position = @"EQU.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.3.9",
                            Type = @"Component",
                            Position = @"EQU.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _equipmentState = new HL7V26Field
        {
            field = message[@"EQU"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentState.field.FieldRepetitions != null && _equipmentState.field.FieldRepetitions.Count > 0)
        {
            _equipmentState.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_equipmentState, fieldData);
        }

        return _equipmentState;
    } 
}

internal HL7V26Field _localRemoteControlState;

public HL7V26Field LocalRemoteControlState
{
    get
    {
        if (_localRemoteControlState != null)
        {
            return _localRemoteControlState;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQU.4",
            Type = @"Field",
            Position = @"EQU.4",
            Name = @"Local/Remote Control State",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.7",
                            Type = @"Component",
                            Position = @"EQU.4.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.8",
                            Type = @"Component",
                            Position = @"EQU.4.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.4.9",
                            Type = @"Component",
                            Position = @"EQU.4.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _localRemoteControlState = new HL7V26Field
        {
            field = message[@"EQU"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_localRemoteControlState.field.FieldRepetitions != null && _localRemoteControlState.field.FieldRepetitions.Count > 0)
        {
            _localRemoteControlState.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_localRemoteControlState, fieldData);
        }

        return _localRemoteControlState;
    } 
}

internal HL7V26Field _alertLevel;

public HL7V26Field AlertLevel
{
    get
    {
        if (_alertLevel != null)
        {
            return _alertLevel;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQU.5",
            Type = @"Field",
            Position = @"EQU.5",
            Name = @"Alert Level",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0367",
            TableName = @"Alert level",
            Description = @"This field identifies the highest level of the alert state (e.g., highest alert severity) that is associated with the indicated equipment (e.g., processing event, inventory event, QC event). Refer to HL7 Table 0367 - Alert level for valid values.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.7",
                            Type = @"Component",
                            Position = @"EQU.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.8",
                            Type = @"Component",
                            Position = @"EQU.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQU.5.9",
                            Type = @"Component",
                            Position = @"EQU.5.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _alertLevel = new HL7V26Field
        {
            field = message[@"EQU"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alertLevel.field.FieldRepetitions != null && _alertLevel.field.FieldRepetitions.Count > 0)
        {
            _alertLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_alertLevel, fieldData);
        }

        return _alertLevel;
    } 
}
    }
}

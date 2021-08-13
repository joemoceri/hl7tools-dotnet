using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentSDD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SDD"; } }

        public string SegmentId { get { return @"SDD"; } }
        
        public string LongName { get { return @"Sterilization Device Data"; } }
        
        public string Description { get { return @"The SDD segment contains the attributes of an instance of a cycle that provides sterilization or decontamination of medical supplies."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public HL7V26SegmentSDD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _lotNumber;

public HL7V26Field LotNumber
{
    get
    {
        if (_lotNumber != null)
        {
            return _lotNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.1",
            Type = @"Field",
            Position = @"SDD.1",
            Name = @"Lot Number",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"A unique number associated with an instance of a sterilization/decontamination cycle assigned by the instrument-tracking system.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SDD.1.1",
                            Type = @"Component",
                            Position = @"SDD.1.1",
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
                            Id = @"SDD.1.2",
                            Type = @"Component",
                            Position = @"SDD.1.2",
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
                            Id = @"SDD.1.3",
                            Type = @"Component",
                            Position = @"SDD.1.3",
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
                            Id = @"SDD.1.4",
                            Type = @"Component",
                            Position = @"SDD.1.4",
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

        _lotNumber = new HL7V26Field
        {
            field = message[@"SDD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lotNumber.field.FieldRepetitions != null && _lotNumber.field.FieldRepetitions.Count > 0)
        {
            _lotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_lotNumber, fieldData);
        }

        return _lotNumber;
    } 
}

internal HL7V26Field _deviceNumber;

public HL7V26Field DeviceNumber
{
    get
    {
        if (_deviceNumber != null)
        {
            return _deviceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.2",
            Type = @"Field",
            Position = @"SDD.2",
            Name = @"Device Number",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The number of the device (e.g., 01 VAC).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SDD.2.1",
                            Type = @"Component",
                            Position = @"SDD.2.1",
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
                            Id = @"SDD.2.2",
                            Type = @"Component",
                            Position = @"SDD.2.2",
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
                            Id = @"SDD.2.3",
                            Type = @"Component",
                            Position = @"SDD.2.3",
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
                            Id = @"SDD.2.4",
                            Type = @"Component",
                            Position = @"SDD.2.4",
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

        _deviceNumber = new HL7V26Field
        {
            field = message[@"SDD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceNumber.field.FieldRepetitions != null && _deviceNumber.field.FieldRepetitions.Count > 0)
        {
            _deviceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_deviceNumber, fieldData);
        }

        return _deviceNumber;
    } 
}

internal HL7V26Field _deviceName;

public HL7V26Field DeviceName
{
    get
    {
        if (_deviceName != null)
        {
            return _deviceName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.3",
            Type = @"Field",
            Position = @"SDD.3",
            Name = @"Device Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the device associated with the device number in SDD-2 (e.g., 01 VAC).",
            Sample = @"",
            Fields = null
        }

        _deviceName = new HL7V26Field
        {
            field = message[@"SDD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceName.field.FieldRepetitions != null && _deviceName.field.FieldRepetitions.Count > 0)
        {
            _deviceName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_deviceName, fieldData);
        }

        return _deviceName;
    } 
}

internal HL7V26Field _deviceDataState;

public HL7V26Field DeviceDataState
{
    get
    {
        if (_deviceDataState != null)
        {
            return _deviceDataState;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.4",
            Type = @"Field",
            Position = @"SDD.4",
            Name = @"Device Data State",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0667",
            TableName = @"Device Data State",
            Description = @"The state of data being sent, i.e., historic data of the cycle or a real-time snapshot of the current value of the cycle data. During a sterilization process, data is consistently being output to record the value of the data at each point in time within the instance of a cycle. For example, the temperature is recorded at every point in time during the cycle.",
            Sample = @"",
            Fields = null
        }

        _deviceDataState = new HL7V26Field
        {
            field = message[@"SDD"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceDataState.field.FieldRepetitions != null && _deviceDataState.field.FieldRepetitions.Count > 0)
        {
            _deviceDataState.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_deviceDataState, fieldData);
        }

        return _deviceDataState;
    } 
}

internal HL7V26Field _loadStatus;

public HL7V26Field LoadStatus
{
    get
    {
        if (_loadStatus != null)
        {
            return _loadStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.5",
            Type = @"Field",
            Position = @"SDD.5",
            Name = @"Load Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0669",
            TableName = @"Load Status",
            Description = @"The status of the load.",
            Sample = @"",
            Fields = null
        }

        _loadStatus = new HL7V26Field
        {
            field = message[@"SDD"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_loadStatus.field.FieldRepetitions != null && _loadStatus.field.FieldRepetitions.Count > 0)
        {
            _loadStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_loadStatus, fieldData);
        }

        return _loadStatus;
    } 
}

internal HL7V26Field _controlCode;

public HL7V26Field ControlCode
{
    get
    {
        if (_controlCode != null)
        {
            return _controlCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.6",
            Type = @"Field",
            Position = @"SDD.6",
            Name = @"Control Code",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"A code to command the device to send cycle data from the previous load to the instrument-tracking system.",
            Sample = @"",
            Fields = null
        }

        _controlCode = new HL7V26Field
        {
            field = message[@"SDD"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_controlCode.field.FieldRepetitions != null && _controlCode.field.FieldRepetitions.Count > 0)
        {
            _controlCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_controlCode, fieldData);
        }

        return _controlCode;
    } 
}

internal HL7V26Field _operatorName;

public HL7V26Field OperatorName
{
    get
    {
        if (_operatorName != null)
        {
            return _operatorName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SDD.7",
            Type = @"Field",
            Position = @"SDD.7",
            Name = @"Operator Name",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The person who started the device load for the decontamination/sterilization process.",
            Sample = @"",
            Fields = null
        }

        _operatorName = new HL7V26Field
        {
            field = message[@"SDD"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_operatorName.field.FieldRepetitions != null && _operatorName.field.FieldRepetitions.Count > 0)
        {
            _operatorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_operatorName, fieldData);
        }

        return _operatorName;
    } 
}
    }
}

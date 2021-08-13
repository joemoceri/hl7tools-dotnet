using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentSCP
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SCP"; } }

        public string SegmentId { get { return @"SCP"; } }
        
        public string LongName { get { return @"Sterilizer Configuration"; } }
        
        public string Description { get { return @"The sterilization configuration segment contains information specific to configuration of a sterilizer or washer for processing sterilization or decontamination loads."; } }
        
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

        public HL7V26SegmentSCP(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _numberOfDecontaminationSterilizationDevices;

public HL7V26Field NumberOfDecontaminationSterilizationDevices
{
    get
    {
        if (_numberOfDecontaminationSterilizationDevices != null)
        {
            return _numberOfDecontaminationSterilizationDevices;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.1",
            Type = @"Field",
            Position = @"SCP.1",
            Name = @"Number Of Decontamination/Sterilization Devices",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"The number of decontamination/sterilization devices recognized by the instrument-tracking system. The decontamination/sterilization device(s) would configure itself based on the data in this message.",
            Sample = @"",
            Fields = null
        }

        _numberOfDecontaminationSterilizationDevices = new HL7V26Field
        {
            field = message[@"SCP"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfDecontaminationSterilizationDevices.field.FieldRepetitions != null && _numberOfDecontaminationSterilizationDevices.field.FieldRepetitions.Count > 0)
        {
            _numberOfDecontaminationSterilizationDevices.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_numberOfDecontaminationSterilizationDevices, fieldData);
        }

        return _numberOfDecontaminationSterilizationDevices;
    } 
}

internal HL7V26Field _laborCalculationType;

public HL7V26Field LaborCalculationType
{
    get
    {
        if (_laborCalculationType != null)
        {
            return _laborCalculationType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.2",
            Type = @"Field",
            Position = @"SCP.2",
            Name = @"Labor Calculation Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0651",
            TableName = @"Labor Calculation Type",
            Description = @"The method at which labor is calculated for use in tracking employee productivity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SCP.2.1",
                            Type = @"Component",
                            Position = @"SCP.2.1",
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
                            Id = @"SCP.2.2",
                            Type = @"Component",
                            Position = @"SCP.2.2",
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
                            Id = @"SCP.2.3",
                            Type = @"Component",
                            Position = @"SCP.2.3",
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
                            Id = @"SCP.2.4",
                            Type = @"Component",
                            Position = @"SCP.2.4",
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
                            Id = @"SCP.2.5",
                            Type = @"Component",
                            Position = @"SCP.2.5",
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
                            Id = @"SCP.2.6",
                            Type = @"Component",
                            Position = @"SCP.2.6",
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
                            Id = @"SCP.2.7",
                            Type = @"Component",
                            Position = @"SCP.2.7",
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
                            Id = @"SCP.2.8",
                            Type = @"Component",
                            Position = @"SCP.2.8",
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
                            Id = @"SCP.2.9",
                            Type = @"Component",
                            Position = @"SCP.2.9",
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

        _laborCalculationType = new HL7V26Field
        {
            field = message[@"SCP"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_laborCalculationType.field.FieldRepetitions != null && _laborCalculationType.field.FieldRepetitions.Count > 0)
        {
            _laborCalculationType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_laborCalculationType, fieldData);
        }

        return _laborCalculationType;
    } 
}

internal HL7V26Field _dateFormat;

public HL7V26Field DateFormat
{
    get
    {
        if (_dateFormat != null)
        {
            return _dateFormat;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.3",
            Type = @"Field",
            Position = @"SCP.3",
            Name = @"Date Format",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0653",
            TableName = @"Date Format",
            Description = @"The format of the date that is used to record date parameters of a decontamination/sterilization instance.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SCP.3.1",
                            Type = @"Component",
                            Position = @"SCP.3.1",
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
                            Id = @"SCP.3.2",
                            Type = @"Component",
                            Position = @"SCP.3.2",
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
                            Id = @"SCP.3.3",
                            Type = @"Component",
                            Position = @"SCP.3.3",
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
                            Id = @"SCP.3.4",
                            Type = @"Component",
                            Position = @"SCP.3.4",
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
                            Id = @"SCP.3.5",
                            Type = @"Component",
                            Position = @"SCP.3.5",
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
                            Id = @"SCP.3.6",
                            Type = @"Component",
                            Position = @"SCP.3.6",
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
                            Id = @"SCP.3.7",
                            Type = @"Component",
                            Position = @"SCP.3.7",
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
                            Id = @"SCP.3.8",
                            Type = @"Component",
                            Position = @"SCP.3.8",
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
                            Id = @"SCP.3.9",
                            Type = @"Component",
                            Position = @"SCP.3.9",
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

        _dateFormat = new HL7V26Field
        {
            field = message[@"SCP"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateFormat.field.FieldRepetitions != null && _dateFormat.field.FieldRepetitions.Count > 0)
        {
            _dateFormat.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_dateFormat, fieldData);
        }

        return _dateFormat;
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
            Id = @"SCP.4",
            Type = @"Field",
            Position = @"SCP.4",
            Name = @"Device Number",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The number of the device (e.g., 01).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SCP.4.1",
                            Type = @"Component",
                            Position = @"SCP.4.1",
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
                            Id = @"SCP.4.2",
                            Type = @"Component",
                            Position = @"SCP.4.2",
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
                            Id = @"SCP.4.3",
                            Type = @"Component",
                            Position = @"SCP.4.3",
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
                            Id = @"SCP.4.4",
                            Type = @"Component",
                            Position = @"SCP.4.4",
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
            field = message[@"SCP"][4],
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
            Id = @"SCP.5",
            Type = @"Field",
            Position = @"SCP.5",
            Name = @"Device Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the device associated with the device number in SCP-4 (e.g., VAC)",
            Sample = @"",
            Fields = null
        }

        _deviceName = new HL7V26Field
        {
            field = message[@"SCP"][5],
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

internal HL7V26Field _deviceModelName;

public HL7V26Field DeviceModelName
{
    get
    {
        if (_deviceModelName != null)
        {
            return _deviceModelName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.6",
            Type = @"Field",
            Position = @"SCP.6",
            Name = @"Device Model Name",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The manufacturer's designated model name.",
            Sample = @"",
            Fields = null
        }

        _deviceModelName = new HL7V26Field
        {
            field = message[@"SCP"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceModelName.field.FieldRepetitions != null && _deviceModelName.field.FieldRepetitions.Count > 0)
        {
            _deviceModelName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_deviceModelName, fieldData);
        }

        return _deviceModelName;
    } 
}

internal HL7V26Field _deviceType;

public HL7V26Field DeviceType
{
    get
    {
        if (_deviceType != null)
        {
            return _deviceType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.7",
            Type = @"Field",
            Position = @"SCP.7",
            Name = @"Device Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0657",
            TableName = @"Device Type",
            Description = @"The type of device, such as a steam sterilizer or gas sterilizer.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SCP.7.1",
                            Type = @"Component",
                            Position = @"SCP.7.1",
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
                            Id = @"SCP.7.2",
                            Type = @"Component",
                            Position = @"SCP.7.2",
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
                            Id = @"SCP.7.3",
                            Type = @"Component",
                            Position = @"SCP.7.3",
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
                            Id = @"SCP.7.4",
                            Type = @"Component",
                            Position = @"SCP.7.4",
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
                            Id = @"SCP.7.5",
                            Type = @"Component",
                            Position = @"SCP.7.5",
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
                            Id = @"SCP.7.6",
                            Type = @"Component",
                            Position = @"SCP.7.6",
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
                            Id = @"SCP.7.7",
                            Type = @"Component",
                            Position = @"SCP.7.7",
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
                            Id = @"SCP.7.8",
                            Type = @"Component",
                            Position = @"SCP.7.8",
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
                            Id = @"SCP.7.9",
                            Type = @"Component",
                            Position = @"SCP.7.9",
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

        _deviceType = new HL7V26Field
        {
            field = message[@"SCP"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deviceType.field.FieldRepetitions != null && _deviceType.field.FieldRepetitions.Count > 0)
        {
            _deviceType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_deviceType, fieldData);
        }

        return _deviceType;
    } 
}

internal HL7V26Field _lotControl;

public HL7V26Field LotControl
{
    get
    {
        if (_lotControl != null)
        {
            return _lotControl;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SCP.8",
            Type = @"Field",
            Position = @"SCP.8",
            Name = @"Lot Control",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0659",
            TableName = @"Lot Control",
            Description = @"A code assigned to a device to indicate if the sterilization load is built in the sub-sterile area adjacent to an Operating Room or the Central Processing Department (Central Supply).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SCP.8.1",
                            Type = @"Component",
                            Position = @"SCP.8.1",
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
                            Id = @"SCP.8.2",
                            Type = @"Component",
                            Position = @"SCP.8.2",
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
                            Id = @"SCP.8.3",
                            Type = @"Component",
                            Position = @"SCP.8.3",
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
                            Id = @"SCP.8.4",
                            Type = @"Component",
                            Position = @"SCP.8.4",
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
                            Id = @"SCP.8.5",
                            Type = @"Component",
                            Position = @"SCP.8.5",
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
                            Id = @"SCP.8.6",
                            Type = @"Component",
                            Position = @"SCP.8.6",
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
                            Id = @"SCP.8.7",
                            Type = @"Component",
                            Position = @"SCP.8.7",
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
                            Id = @"SCP.8.8",
                            Type = @"Component",
                            Position = @"SCP.8.8",
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
                            Id = @"SCP.8.9",
                            Type = @"Component",
                            Position = @"SCP.8.9",
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

        _lotControl = new HL7V26Field
        {
            field = message[@"SCP"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lotControl.field.FieldRepetitions != null && _lotControl.field.FieldRepetitions.Count > 0)
        {
            _lotControl.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_lotControl, fieldData);
        }

        return _lotControl;
    } 
}
    }
}

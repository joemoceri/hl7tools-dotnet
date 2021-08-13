using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentSLT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SLT"; } }

        public string SegmentId { get { return @"SLT"; } }
        
        public string LongName { get { return @"Sterilization Lot Segment"; } }
        
        public string Description { get { return @"The SLT segment defines requests, responses, and notifications of sterilization lots and supply item descriptions. This message may be used for CPD (Central Supply) and OR (Sub-sterile area outside of an Operating Room) mode."; } }
        
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

        public HL7V26SegmentSLT(HL7V2Message message)
        {
            this.message = message;
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
            Id = @"SLT.1",
            Type = @"Field",
            Position = @"SLT.1",
            Name = @"Device Number",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The unique identifier of the device (assigned by user, not assigned by the software application; e.g.: 01).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SLT.1.1",
                            Type = @"Component",
                            Position = @"SLT.1.1",
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
                            Id = @"SLT.1.2",
                            Type = @"Component",
                            Position = @"SLT.1.2",
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
                            Id = @"SLT.1.3",
                            Type = @"Component",
                            Position = @"SLT.1.3",
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
                            Id = @"SLT.1.4",
                            Type = @"Component",
                            Position = @"SLT.1.4",
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
            field = message[@"SLT"][1],
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
            Id = @"SLT.2",
            Type = @"Field",
            Position = @"SLT.2",
            Name = @"Device Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the device associated with the device number in SLT-1 (e.g., VAC).",
            Sample = @"",
            Fields = null
        }

        _deviceName = new HL7V26Field
        {
            field = message[@"SLT"][2],
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
            Id = @"SLT.3",
            Type = @"Field",
            Position = @"SLT.3",
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
                            Id = @"SLT.3.1",
                            Type = @"Component",
                            Position = @"SLT.3.1",
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
                            Id = @"SLT.3.2",
                            Type = @"Component",
                            Position = @"SLT.3.2",
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
                            Id = @"SLT.3.3",
                            Type = @"Component",
                            Position = @"SLT.3.3",
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
                            Id = @"SLT.3.4",
                            Type = @"Component",
                            Position = @"SLT.3.4",
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
            field = message[@"SLT"][3],
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

internal HL7V26Field _itemIdentifier;

public HL7V26Field ItemIdentifier
{
    get
    {
        if (_itemIdentifier != null)
        {
            return _itemIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SLT.4",
            Type = @"Field",
            Position = @"SLT.4",
            Name = @"Item Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The Item Identifier is a unique code assigned to the material item by the Instrument-tracking software application to identify the item being sterilized or decontaminated.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SLT.4.1",
                            Type = @"Component",
                            Position = @"SLT.4.1",
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
                            Id = @"SLT.4.2",
                            Type = @"Component",
                            Position = @"SLT.4.2",
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
                            Id = @"SLT.4.3",
                            Type = @"Component",
                            Position = @"SLT.4.3",
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
                            Id = @"SLT.4.4",
                            Type = @"Component",
                            Position = @"SLT.4.4",
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

        _itemIdentifier = new HL7V26Field
        {
            field = message[@"SLT"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemIdentifier.field.FieldRepetitions != null && _itemIdentifier.field.FieldRepetitions.Count > 0)
        {
            _itemIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_itemIdentifier, fieldData);
        }

        return _itemIdentifier;
    } 
}

internal HL7V26Field _barCode;

public HL7V26Field BarCode
{
    get
    {
        if (_barCode != null)
        {
            return _barCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"SLT.5",
            Type = @"Field",
            Position = @"SLT.5",
            Name = @"Bar Code",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The special identification code, printed as a set of vertical bars of differing widths, used on instruments to identify them and provide for rapid, error-free input by a barcode scanning device. The coding can include numbers, letters or a combination of both.",
            Sample = @"",
            Fields = null
        }

        _barCode = new HL7V26Field
        {
            field = message[@"SLT"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_barCode.field.FieldRepetitions != null && _barCode.field.FieldRepetitions.Count > 0)
        {
            _barCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_barCode, fieldData);
        }

        return _barCode;
    } 
}
    }
}

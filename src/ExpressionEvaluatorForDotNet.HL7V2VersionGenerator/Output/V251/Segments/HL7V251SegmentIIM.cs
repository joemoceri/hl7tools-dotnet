using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentIIM
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IIM"; } }

        public string SegmentId { get { return @"IIM"; } }
        
        public string LongName { get { return @"Inventory Item Master"; } }
        
        public string Description { get { return @"The Inventory Item Master segment (IIM) contains information about the stock of product that can be used to fulfill an ordered test/service. All of the fields in this segment describe the test/service and other basic attributes pertaining to Service Item defined within an Other Observation/Service Item master file. This segment is related to centrally stocked or supply management concerns.

Note:  We recognize that the M15 Inventory Item Master File trigger event and the IIM inventory item master segment is a limited implementation.  There is a comprehensive Materials Management message in development for inclusion in the next release.  For further information contact the Scheduling and Logistics TC.  This will be coordinated with the Control/Query TC and the Orders and Observations TC. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V251SegmentIIM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _primaryKeyValueIIM;

public HL7V251Field PrimaryKeyValueIIM
{
    get
    {
        if (_primaryKeyValueIIM != null)
        {
            return _primaryKeyValueIIM;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.1",
            Type = @"Field",
            Position = @"IIM.1",
            Name = @"Primary Key Value - IIM",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the code assigned by the institution for the purpose of uniquely identifying an inventoried item. It is the identifying key value, and must match MFE-4 - Primary Key Value - MFE .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.1.1",
                            Type = @"Component",
                            Position = @"IIM.1.1",
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
                            Id = @"IIM.1.2",
                            Type = @"Component",
                            Position = @"IIM.1.2",
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
                            Id = @"IIM.1.3",
                            Type = @"Component",
                            Position = @"IIM.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.1.4",
                            Type = @"Component",
                            Position = @"IIM.1.4",
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
                            Id = @"IIM.1.5",
                            Type = @"Component",
                            Position = @"IIM.1.5",
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
                            Id = @"IIM.1.6",
                            Type = @"Component",
                            Position = @"IIM.1.6",
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
                            Id = @"IIM.1.7",
                            Type = @"Component",
                            Position = @"IIM.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.1.8",
                            Type = @"Component",
                            Position = @"IIM.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.1.9",
                            Type = @"Component",
                            Position = @"IIM.1.9",
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

        _primaryKeyValueIIM = new HL7V251Field
        {
            field = message[@"IIM"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueIIM.field.FieldRepetitions != null && _primaryKeyValueIIM.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueIIM.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_primaryKeyValueIIM, fieldData);
        }

        return _primaryKeyValueIIM;
    } 
}

internal HL7V251Field _serviceItemCode;

public HL7V251Field ServiceItemCode
{
    get
    {
        if (_serviceItemCode != null)
        {
            return _serviceItemCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.2",
            Type = @"Field",
            Position = @"IIM.2",
            Name = @"Service Item Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the service item. It relates the inventory item of this message to an entry in an Other Observation/Service Item master file.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.2.1",
                            Type = @"Component",
                            Position = @"IIM.2.1",
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
                            Id = @"IIM.2.2",
                            Type = @"Component",
                            Position = @"IIM.2.2",
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
                            Id = @"IIM.2.3",
                            Type = @"Component",
                            Position = @"IIM.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.2.4",
                            Type = @"Component",
                            Position = @"IIM.2.4",
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
                            Id = @"IIM.2.5",
                            Type = @"Component",
                            Position = @"IIM.2.5",
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
                            Id = @"IIM.2.6",
                            Type = @"Component",
                            Position = @"IIM.2.6",
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
                            Id = @"IIM.2.7",
                            Type = @"Component",
                            Position = @"IIM.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.2.8",
                            Type = @"Component",
                            Position = @"IIM.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.2.9",
                            Type = @"Component",
                            Position = @"IIM.2.9",
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

        _serviceItemCode = new HL7V251Field
        {
            field = message[@"IIM"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_serviceItemCode.field.FieldRepetitions != null && _serviceItemCode.field.FieldRepetitions.Count > 0)
        {
            _serviceItemCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_serviceItemCode, fieldData);
        }

        return _serviceItemCode;
    } 
}

internal HL7V251Field _inventoryLotNumber;

public HL7V251Field InventoryLotNumber
{
    get
    {
        if (_inventoryLotNumber != null)
        {
            return _inventoryLotNumber;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.3",
            Type = @"Field",
            Position = @"IIM.3",
            Name = @"Inventory Lot Number",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the service item in inventory.

Note:  The lot number is the number printed on the label attached to the item or container holding the substance.  If the substance is a vaccine, for example, and a diluent is required, a lot number may appear on the vial containing the diluent; however, any such identifier associated with a diluent is not the identifier of interest. The substance lot number should be reported, not that of the diluent. ",
            Sample = @"",
            Fields = null
        }

        _inventoryLotNumber = new HL7V251Field
        {
            field = message[@"IIM"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryLotNumber.field.FieldRepetitions != null && _inventoryLotNumber.field.FieldRepetitions.Count > 0)
        {
            _inventoryLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryLotNumber, fieldData);
        }

        return _inventoryLotNumber;
    } 
}

internal HL7V251Field _inventoryExpirationDate;

public HL7V251Field InventoryExpirationDate
{
    get
    {
        if (_inventoryExpirationDate != null)
        {
            return _inventoryExpirationDate;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.4",
            Type = @"Field",
            Position = @"IIM.4",
            Name = @"Inventory Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the service item in inventory.

Note:  Expiration date does not always have a “day” component; therefore, such a date may be transmitted as YYYYMM. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.4.1",
                            Type = @"Component",
                            Position = @"IIM.4.1",
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
                            Id = @"IIM.4.2",
                            Type = @"Component",
                            Position = @"IIM.4.2",
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

        _inventoryExpirationDate = new HL7V251Field
        {
            field = message[@"IIM"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryExpirationDate.field.FieldRepetitions != null && _inventoryExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _inventoryExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryExpirationDate, fieldData);
        }

        return _inventoryExpirationDate;
    } 
}

internal HL7V251Field _inventoryManufacturerName;

public HL7V251Field InventoryManufacturerName
{
    get
    {
        if (_inventoryManufacturerName != null)
        {
            return _inventoryManufacturerName;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.5",
            Type = @"Field",
            Position = @"IIM.5",
            Name = @"Inventory Manufacturer Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturer of the service item in inventory.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.5.1",
                            Type = @"Component",
                            Position = @"IIM.5.1",
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
                            Id = @"IIM.5.2",
                            Type = @"Component",
                            Position = @"IIM.5.2",
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
                            Id = @"IIM.5.3",
                            Type = @"Component",
                            Position = @"IIM.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.5.4",
                            Type = @"Component",
                            Position = @"IIM.5.4",
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
                            Id = @"IIM.5.5",
                            Type = @"Component",
                            Position = @"IIM.5.5",
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
                            Id = @"IIM.5.6",
                            Type = @"Component",
                            Position = @"IIM.5.6",
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
                            Id = @"IIM.5.7",
                            Type = @"Component",
                            Position = @"IIM.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.5.8",
                            Type = @"Component",
                            Position = @"IIM.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.5.9",
                            Type = @"Component",
                            Position = @"IIM.5.9",
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

        _inventoryManufacturerName = new HL7V251Field
        {
            field = message[@"IIM"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryManufacturerName.field.FieldRepetitions != null && _inventoryManufacturerName.field.FieldRepetitions.Count > 0)
        {
            _inventoryManufacturerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryManufacturerName, fieldData);
        }

        return _inventoryManufacturerName;
    } 
}

internal HL7V251Field _inventoryLocation;

public HL7V251Field InventoryLocation
{
    get
    {
        if (_inventoryLocation != null)
        {
            return _inventoryLocation;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.6",
            Type = @"Field",
            Position = @"IIM.6",
            Name = @"Inventory Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the inventory. As an implementation consideration, this location can have a range of specificity. The location can be very general, e.g., a facility where the inventory is warehoused, or very specific, e.g., a shelf location.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.6.1",
                            Type = @"Component",
                            Position = @"IIM.6.1",
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
                            Id = @"IIM.6.2",
                            Type = @"Component",
                            Position = @"IIM.6.2",
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
                            Id = @"IIM.6.3",
                            Type = @"Component",
                            Position = @"IIM.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.6.4",
                            Type = @"Component",
                            Position = @"IIM.6.4",
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
                            Id = @"IIM.6.5",
                            Type = @"Component",
                            Position = @"IIM.6.5",
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
                            Id = @"IIM.6.6",
                            Type = @"Component",
                            Position = @"IIM.6.6",
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
                            Id = @"IIM.6.7",
                            Type = @"Component",
                            Position = @"IIM.6.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.6.8",
                            Type = @"Component",
                            Position = @"IIM.6.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.6.9",
                            Type = @"Component",
                            Position = @"IIM.6.9",
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

        _inventoryLocation = new HL7V251Field
        {
            field = message[@"IIM"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryLocation.field.FieldRepetitions != null && _inventoryLocation.field.FieldRepetitions.Count > 0)
        {
            _inventoryLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryLocation, fieldData);
        }

        return _inventoryLocation;
    } 
}

internal HL7V251Field _inventoryReceivedDate;

public HL7V251Field InventoryReceivedDate
{
    get
    {
        if (_inventoryReceivedDate != null)
        {
            return _inventoryReceivedDate;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.7",
            Type = @"Field",
            Position = @"IIM.7",
            Name = @"Inventory Received Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the most recent date that the product in question was received into inventory.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.7.1",
                            Type = @"Component",
                            Position = @"IIM.7.1",
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
                            Id = @"IIM.7.2",
                            Type = @"Component",
                            Position = @"IIM.7.2",
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

        _inventoryReceivedDate = new HL7V251Field
        {
            field = message[@"IIM"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryReceivedDate.field.FieldRepetitions != null && _inventoryReceivedDate.field.FieldRepetitions.Count > 0)
        {
            _inventoryReceivedDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryReceivedDate, fieldData);
        }

        return _inventoryReceivedDate;
    } 
}

internal HL7V251Field _inventoryReceivedQuantity;

public HL7V251Field InventoryReceivedQuantity
{
    get
    {
        if (_inventoryReceivedQuantity != null)
        {
            return _inventoryReceivedQuantity;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.8",
            Type = @"Field",
            Position = @"IIM.8",
            Name = @"Inventory Received Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was received on the date specific in IIM-7 Inventory Received Date.",
            Sample = @"",
            Fields = null
        }

        _inventoryReceivedQuantity = new HL7V251Field
        {
            field = message[@"IIM"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryReceivedQuantity.field.FieldRepetitions != null && _inventoryReceivedQuantity.field.FieldRepetitions.Count > 0)
        {
            _inventoryReceivedQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryReceivedQuantity, fieldData);
        }

        return _inventoryReceivedQuantity;
    } 
}

internal HL7V251Field _inventoryReceivedQuantityUnit;

public HL7V251Field InventoryReceivedQuantityUnit
{
    get
    {
        if (_inventoryReceivedQuantityUnit != null)
        {
            return _inventoryReceivedQuantityUnit;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.9",
            Type = @"Field",
            Position = @"IIM.9",
            Name = @"Inventory Received Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the unit for IIM-8 Inventory Received Quantity and IIM-10 Inventory Received Item Cost.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.9.1",
                            Type = @"Component",
                            Position = @"IIM.9.1",
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
                            Id = @"IIM.9.2",
                            Type = @"Component",
                            Position = @"IIM.9.2",
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
                            Id = @"IIM.9.3",
                            Type = @"Component",
                            Position = @"IIM.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.9.4",
                            Type = @"Component",
                            Position = @"IIM.9.4",
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
                            Id = @"IIM.9.5",
                            Type = @"Component",
                            Position = @"IIM.9.5",
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
                            Id = @"IIM.9.6",
                            Type = @"Component",
                            Position = @"IIM.9.6",
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
                            Id = @"IIM.9.7",
                            Type = @"Component",
                            Position = @"IIM.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.9.8",
                            Type = @"Component",
                            Position = @"IIM.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.9.9",
                            Type = @"Component",
                            Position = @"IIM.9.9",
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

        _inventoryReceivedQuantityUnit = new HL7V251Field
        {
            field = message[@"IIM"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryReceivedQuantityUnit.field.FieldRepetitions != null && _inventoryReceivedQuantityUnit.field.FieldRepetitions.Count > 0)
        {
            _inventoryReceivedQuantityUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryReceivedQuantityUnit, fieldData);
        }

        return _inventoryReceivedQuantityUnit;
    } 
}

internal HL7V251Field _inventoryReceivedItemCost;

public HL7V251Field InventoryReceivedItemCost
{
    get
    {
        if (_inventoryReceivedItemCost != null)
        {
            return _inventoryReceivedItemCost;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.10",
            Type = @"Field",
            Position = @"IIM.10",
            Name = @"Inventory Received Item Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the per-unit cost of the inventory item at the time of receipt. IIM-9 Inventory Received Quantity Unit specifies the per-unit basis of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.10.1",
                            Type = @"Component",
                            Position = @"IIM.10.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.10.2",
                            Type = @"Component",
                            Position = @"IIM.10.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _inventoryReceivedItemCost = new HL7V251Field
        {
            field = message[@"IIM"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryReceivedItemCost.field.FieldRepetitions != null && _inventoryReceivedItemCost.field.FieldRepetitions.Count > 0)
        {
            _inventoryReceivedItemCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryReceivedItemCost, fieldData);
        }

        return _inventoryReceivedItemCost;
    } 
}

internal HL7V251Field _inventoryOnHandDate;

public HL7V251Field InventoryOnHandDate
{
    get
    {
        if (_inventoryOnHandDate != null)
        {
            return _inventoryOnHandDate;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.11",
            Type = @"Field",
            Position = @"IIM.11",
            Name = @"Inventory On Hand Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the most recent date that an inventory count for the inventory item was performed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.11.1",
                            Type = @"Component",
                            Position = @"IIM.11.1",
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
                            Id = @"IIM.11.2",
                            Type = @"Component",
                            Position = @"IIM.11.2",
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

        _inventoryOnHandDate = new HL7V251Field
        {
            field = message[@"IIM"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryOnHandDate.field.FieldRepetitions != null && _inventoryOnHandDate.field.FieldRepetitions.Count > 0)
        {
            _inventoryOnHandDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryOnHandDate, fieldData);
        }

        return _inventoryOnHandDate;
    } 
}

internal HL7V251Field _inventoryOnHandQuantity;

public HL7V251Field InventoryOnHandQuantity
{
    get
    {
        if (_inventoryOnHandQuantity != null)
        {
            return _inventoryOnHandQuantity;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.12",
            Type = @"Field",
            Position = @"IIM.12",
            Name = @"Inventory On Hand Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in IIM-11 Inventory on Hand Date. No adjustment has been made for subsequent use.",
            Sample = @"",
            Fields = null
        }

        _inventoryOnHandQuantity = new HL7V251Field
        {
            field = message[@"IIM"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryOnHandQuantity.field.FieldRepetitions != null && _inventoryOnHandQuantity.field.FieldRepetitions.Count > 0)
        {
            _inventoryOnHandQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryOnHandQuantity, fieldData);
        }

        return _inventoryOnHandQuantity;
    } 
}

internal HL7V251Field _inventoryOnHandQuantityUnit;

public HL7V251Field InventoryOnHandQuantityUnit
{
    get
    {
        if (_inventoryOnHandQuantityUnit != null)
        {
            return _inventoryOnHandQuantityUnit;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.13",
            Type = @"Field",
            Position = @"IIM.13",
            Name = @"Inventory On Hand Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the unit for IIM-12 - Inventory on Hand Quantity.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.13.1",
                            Type = @"Component",
                            Position = @"IIM.13.1",
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
                            Id = @"IIM.13.2",
                            Type = @"Component",
                            Position = @"IIM.13.2",
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
                            Id = @"IIM.13.3",
                            Type = @"Component",
                            Position = @"IIM.13.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.13.4",
                            Type = @"Component",
                            Position = @"IIM.13.4",
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
                            Id = @"IIM.13.5",
                            Type = @"Component",
                            Position = @"IIM.13.5",
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
                            Id = @"IIM.13.6",
                            Type = @"Component",
                            Position = @"IIM.13.6",
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
                            Id = @"IIM.13.7",
                            Type = @"Component",
                            Position = @"IIM.13.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.13.8",
                            Type = @"Component",
                            Position = @"IIM.13.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IIM.13.9",
                            Type = @"Component",
                            Position = @"IIM.13.9",
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

        _inventoryOnHandQuantityUnit = new HL7V251Field
        {
            field = message[@"IIM"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryOnHandQuantityUnit.field.FieldRepetitions != null && _inventoryOnHandQuantityUnit.field.FieldRepetitions.Count > 0)
        {
            _inventoryOnHandQuantityUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_inventoryOnHandQuantityUnit, fieldData);
        }

        return _inventoryOnHandQuantityUnit;
    } 
}

internal HL7V251Field _procedureCode;

public HL7V251Field ProcedureCode
{
    get
    {
        if (_procedureCode != null)
        {
            return _procedureCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.14",
            Type = @"Field",
            Position = @"IIM.14",
            Name = @"Procedure Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0088",
            TableName = @"Procedure Code",
            Description = @"This field contains a unique identifier assigned to the service item, if any, associated with the charge. In the United States this is often the HCPCS code. Refer to User-defined Table 0088 - Procedure code for suggested values. This field is a CE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.14.1",
                            Type = @"Component",
                            Position = @"IIM.14.1",
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
                            Id = @"IIM.14.2",
                            Type = @"Component",
                            Position = @"IIM.14.2",
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
                            Id = @"IIM.14.3",
                            Type = @"Component",
                            Position = @"IIM.14.3",
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
                            Id = @"IIM.14.4",
                            Type = @"Component",
                            Position = @"IIM.14.4",
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
                            Id = @"IIM.14.5",
                            Type = @"Component",
                            Position = @"IIM.14.5",
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
                            Id = @"IIM.14.6",
                            Type = @"Component",
                            Position = @"IIM.14.6",
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

        _procedureCode = new HL7V251Field
        {
            field = message[@"IIM"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCode.field.FieldRepetitions != null && _procedureCode.field.FieldRepetitions.Count > 0)
        {
            _procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_procedureCode, fieldData);
        }

        return _procedureCode;
    } 
}

internal HL7V251Field _procedureCodeModifier;

public HL7V251Field ProcedureCodeModifier
{
    get
    {
        if (_procedureCodeModifier != null)
        {
            return _procedureCodeModifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IIM.15",
            Type = @"Field",
            Position = @"IIM.15",
            Name = @"Procedure Code Modifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0340",
            TableName = @"Procedure code modifier",
            Description = @"This field contains the procedure code modifier to the procedure code reported in IIM-14 Procedure Code , when applicable. Procedure code modifiers are defined by USA regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to User-defined Table 0340 - Procedure code modifier for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IIM.15.1",
                            Type = @"Component",
                            Position = @"IIM.15.1",
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
                            Id = @"IIM.15.2",
                            Type = @"Component",
                            Position = @"IIM.15.2",
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
                            Id = @"IIM.15.3",
                            Type = @"Component",
                            Position = @"IIM.15.3",
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
                            Id = @"IIM.15.4",
                            Type = @"Component",
                            Position = @"IIM.15.4",
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
                            Id = @"IIM.15.5",
                            Type = @"Component",
                            Position = @"IIM.15.5",
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
                            Id = @"IIM.15.6",
                            Type = @"Component",
                            Position = @"IIM.15.6",
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

        _procedureCodeModifier = new HL7V251Field
        {
            field = message[@"IIM"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_procedureCodeModifier.field.FieldRepetitions != null && _procedureCodeModifier.field.FieldRepetitions.Count > 0)
        {
            _procedureCodeModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_procedureCodeModifier, fieldData);
        }

        return _procedureCodeModifier;
    } 
}
    }
}

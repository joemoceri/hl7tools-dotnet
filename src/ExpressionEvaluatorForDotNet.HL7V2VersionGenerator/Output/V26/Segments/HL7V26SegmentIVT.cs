using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentIVT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IVT"; } }

        public string SegmentId { get { return @"IVT"; } }
        
        public string LongName { get { return @"Material Location"; } }
        
        public string Description { get { return @"The Material Location segment (IVT) contains information specific to an inventory location for the inventory supply item in the Material Item (ITM) segment."; } }
        
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

        public HL7V26SegmentIVT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIdIVT;

public HL7V26Field SetIdIVT
{
    get
    {
        if (_setIdIVT != null)
        {
            return _setIdIVT;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.1",
            Type = @"Field",
            Position = @"IVT.1",
            Name = @"Set Id – IVT",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a sequential number that identifies this segment within a given Material Location segment group. For the first occurrence of the segment, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
            Sample = @"",
            Fields = null
        }

        _setIdIVT = new HL7V26Field
        {
            field = message[@"IVT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdIVT.field.FieldRepetitions != null && _setIdIVT.field.FieldRepetitions.Count > 0)
        {
            _setIdIVT.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIdIVT, fieldData);
        }

        return _setIdIVT;
    } 
}

internal HL7V26Field _inventoryLocationIdentifier;

public HL7V26Field InventoryLocationIdentifier
{
    get
    {
        if (_inventoryLocationIdentifier != null)
        {
            return _inventoryLocationIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.2",
            Type = @"Field",
            Position = @"IVT.2",
            Name = @"Inventory Location Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the code identifying an inventory supply location that stocks or purchases this item.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.2.1",
                            Type = @"Component",
                            Position = @"IVT.2.1",
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
                            Id = @"IVT.2.2",
                            Type = @"Component",
                            Position = @"IVT.2.2",
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
                            Id = @"IVT.2.3",
                            Type = @"Component",
                            Position = @"IVT.2.3",
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
                            Id = @"IVT.2.4",
                            Type = @"Component",
                            Position = @"IVT.2.4",
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

        _inventoryLocationIdentifier = new HL7V26Field
        {
            field = message[@"IVT"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryLocationIdentifier.field.FieldRepetitions != null && _inventoryLocationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _inventoryLocationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_inventoryLocationIdentifier, fieldData);
        }

        return _inventoryLocationIdentifier;
    } 
}

internal HL7V26Field _inventoryLocationName;

public HL7V26Field InventoryLocationName
{
    get
    {
        if (_inventoryLocationName != null)
        {
            return _inventoryLocationName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.3",
            Type = @"Field",
            Position = @"IVT.3",
            Name = @"Inventory Location Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the inventory supply location identified in IVT-2.",
            Sample = @"",
            Fields = null
        }

        _inventoryLocationName = new HL7V26Field
        {
            field = message[@"IVT"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryLocationName.field.FieldRepetitions != null && _inventoryLocationName.field.FieldRepetitions.Count > 0)
        {
            _inventoryLocationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_inventoryLocationName, fieldData);
        }

        return _inventoryLocationName;
    } 
}

internal HL7V26Field _sourceLocationIdentifier;

public HL7V26Field SourceLocationIdentifier
{
    get
    {
        if (_sourceLocationIdentifier != null)
        {
            return _sourceLocationIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.4",
            Type = @"Field",
            Position = @"IVT.4",
            Name = @"Source Location Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the code identifying the source location that purchases and stocks items in addition to filling supply requests for the location specified in IVT-2. For example, IVT-2 may be considered Central Supply, an inventory location that issues to departments. IVT-3 may be considered General Stores, a supply location that most items are received into when delivered to the healthcare facility. General Stores would then replenish the Central Supply inventory. Central Supply would then issue supplies to departments based on requests for supplies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.4.1",
                            Type = @"Component",
                            Position = @"IVT.4.1",
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
                            Id = @"IVT.4.2",
                            Type = @"Component",
                            Position = @"IVT.4.2",
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
                            Id = @"IVT.4.3",
                            Type = @"Component",
                            Position = @"IVT.4.3",
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
                            Id = @"IVT.4.4",
                            Type = @"Component",
                            Position = @"IVT.4.4",
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

        _sourceLocationIdentifier = new HL7V26Field
        {
            field = message[@"IVT"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceLocationIdentifier.field.FieldRepetitions != null && _sourceLocationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _sourceLocationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sourceLocationIdentifier, fieldData);
        }

        return _sourceLocationIdentifier;
    } 
}

internal HL7V26Field _sourceLocationName;

public HL7V26Field SourceLocationName
{
    get
    {
        if (_sourceLocationName != null)
        {
            return _sourceLocationName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.5",
            Type = @"Field",
            Position = @"IVT.5",
            Name = @"Source Location Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the source supply location identified in IVT-4.",
            Sample = @"",
            Fields = null
        }

        _sourceLocationName = new HL7V26Field
        {
            field = message[@"IVT"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceLocationName.field.FieldRepetitions != null && _sourceLocationName.field.FieldRepetitions.Count > 0)
        {
            _sourceLocationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sourceLocationName, fieldData);
        }

        return _sourceLocationName;
    } 
}

internal HL7V26Field _itemStatus;

public HL7V26Field ItemStatus
{
    get
    {
        if (_itemStatus != null)
        {
            return _itemStatus;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.6",
            Type = @"Field",
            Position = @"IVT.6",
            Name = @"Item Status",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0625",
            TableName = @"Item Status Codes",
            Description = @"This field contains the status that applies to the inventory supply item for the inventory location specified in IVT-2. Refer to User-defined Table 0625 - Item Status Codes for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.6.1",
                            Type = @"Component",
                            Position = @"IVT.6.1",
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
                            Id = @"IVT.6.2",
                            Type = @"Component",
                            Position = @"IVT.6.2",
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
                            Id = @"IVT.6.3",
                            Type = @"Component",
                            Position = @"IVT.6.3",
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
                            Id = @"IVT.6.4",
                            Type = @"Component",
                            Position = @"IVT.6.4",
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
                            Id = @"IVT.6.5",
                            Type = @"Component",
                            Position = @"IVT.6.5",
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
                            Id = @"IVT.6.6",
                            Type = @"Component",
                            Position = @"IVT.6.6",
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
                            Id = @"IVT.6.7",
                            Type = @"Component",
                            Position = @"IVT.6.7",
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
                            Id = @"IVT.6.8",
                            Type = @"Component",
                            Position = @"IVT.6.8",
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
                            Id = @"IVT.6.9",
                            Type = @"Component",
                            Position = @"IVT.6.9",
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

        _itemStatus = new HL7V26Field
        {
            field = message[@"IVT"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemStatus.field.FieldRepetitions != null && _itemStatus.field.FieldRepetitions.Count > 0)
        {
            _itemStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_itemStatus, fieldData);
        }

        return _itemStatus;
    } 
}

internal HL7V26Field _binLocationIdentifier;

public HL7V26Field BinLocationIdentifier
{
    get
    {
        if (_binLocationIdentifier != null)
        {
            return _binLocationIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.7",
            Type = @"Field",
            Position = @"IVT.7",
            Name = @"Bin Location Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"A unique code assigned to a bin location located within the inventory location in IVT-2, where the inventory supply item may be stored.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.7.1",
                            Type = @"Component",
                            Position = @"IVT.7.1",
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
                            Id = @"IVT.7.2",
                            Type = @"Component",
                            Position = @"IVT.7.2",
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
                            Id = @"IVT.7.3",
                            Type = @"Component",
                            Position = @"IVT.7.3",
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
                            Id = @"IVT.7.4",
                            Type = @"Component",
                            Position = @"IVT.7.4",
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

        _binLocationIdentifier = new HL7V26Field
        {
            field = message[@"IVT"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_binLocationIdentifier.field.FieldRepetitions != null && _binLocationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _binLocationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_binLocationIdentifier, fieldData);
        }

        return _binLocationIdentifier;
    } 
}

internal HL7V26Field _orderPackaging;

public HL7V26Field OrderPackaging
{
    get
    {
        if (_orderPackaging != null)
        {
            return _orderPackaging;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.8",
            Type = @"Field",
            Position = @"IVT.8",
            Name = @"Order Packaging",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the primary packaging unit by which the item can be requisitioned or ordered to replenish the inventory supply item for the corresponding inventory location specified in IVT-2. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.8.1",
                            Type = @"Component",
                            Position = @"IVT.8.1",
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
                            Id = @"IVT.8.2",
                            Type = @"Component",
                            Position = @"IVT.8.2",
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
                            Id = @"IVT.8.3",
                            Type = @"Component",
                            Position = @"IVT.8.3",
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
                            Id = @"IVT.8.4",
                            Type = @"Component",
                            Position = @"IVT.8.4",
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
                            Id = @"IVT.8.5",
                            Type = @"Component",
                            Position = @"IVT.8.5",
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
                            Id = @"IVT.8.6",
                            Type = @"Component",
                            Position = @"IVT.8.6",
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
                            Id = @"IVT.8.7",
                            Type = @"Component",
                            Position = @"IVT.8.7",
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
                            Id = @"IVT.8.8",
                            Type = @"Component",
                            Position = @"IVT.8.8",
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
                            Id = @"IVT.8.9",
                            Type = @"Component",
                            Position = @"IVT.8.9",
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

        _orderPackaging = new HL7V26Field
        {
            field = message[@"IVT"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderPackaging.field.FieldRepetitions != null && _orderPackaging.field.FieldRepetitions.Count > 0)
        {
            _orderPackaging.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_orderPackaging, fieldData);
        }

        return _orderPackaging;
    } 
}

internal HL7V26Field _issuePackaging;

public HL7V26Field IssuePackaging
{
    get
    {
        if (_issuePackaging != null)
        {
            return _issuePackaging;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.9",
            Type = @"Field",
            Position = @"IVT.9",
            Name = @"Issue Packaging",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the primary issue packaging unit by which the inventory supply item can be issued to departments or other locations by the corresponding inventory location specified in IVT-2. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.9.1",
                            Type = @"Component",
                            Position = @"IVT.9.1",
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
                            Id = @"IVT.9.2",
                            Type = @"Component",
                            Position = @"IVT.9.2",
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
                            Id = @"IVT.9.3",
                            Type = @"Component",
                            Position = @"IVT.9.3",
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
                            Id = @"IVT.9.4",
                            Type = @"Component",
                            Position = @"IVT.9.4",
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
                            Id = @"IVT.9.5",
                            Type = @"Component",
                            Position = @"IVT.9.5",
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
                            Id = @"IVT.9.6",
                            Type = @"Component",
                            Position = @"IVT.9.6",
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
                            Id = @"IVT.9.7",
                            Type = @"Component",
                            Position = @"IVT.9.7",
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
                            Id = @"IVT.9.8",
                            Type = @"Component",
                            Position = @"IVT.9.8",
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
                            Id = @"IVT.9.9",
                            Type = @"Component",
                            Position = @"IVT.9.9",
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

        _issuePackaging = new HL7V26Field
        {
            field = message[@"IVT"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_issuePackaging.field.FieldRepetitions != null && _issuePackaging.field.FieldRepetitions.Count > 0)
        {
            _issuePackaging.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_issuePackaging, fieldData);
        }

        return _issuePackaging;
    } 
}

internal HL7V26Field _defaultInventoryAssetAccount;

public HL7V26Field DefaultInventoryAssetAccount
{
    get
    {
        if (_defaultInventoryAssetAccount != null)
        {
            return _defaultInventoryAssetAccount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.10",
            Type = @"Field",
            Position = @"IVT.10",
            Name = @"Default Inventory Asset Account",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the general ledger number for the default inventory asset account used in journal transactions associated with items stored in this inventory location. The account includes all elements of a general ledger account (a fully qualified general ledger account number). All elements may include a corporation, department/cost center account, and expense account.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.10.1",
                            Type = @"Component",
                            Position = @"IVT.10.1",
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
                            Id = @"IVT.10.2",
                            Type = @"Component",
                            Position = @"IVT.10.2",
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
                            Id = @"IVT.10.3",
                            Type = @"Component",
                            Position = @"IVT.10.3",
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
                            Id = @"IVT.10.4",
                            Type = @"Component",
                            Position = @"IVT.10.4",
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

        _defaultInventoryAssetAccount = new HL7V26Field
        {
            field = message[@"IVT"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_defaultInventoryAssetAccount.field.FieldRepetitions != null && _defaultInventoryAssetAccount.field.FieldRepetitions.Count > 0)
        {
            _defaultInventoryAssetAccount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_defaultInventoryAssetAccount, fieldData);
        }

        return _defaultInventoryAssetAccount;
    } 
}

internal HL7V26Field _patientChargeableIndicator;

public HL7V26Field PatientChargeableIndicator
{
    get
    {
        if (_patientChargeableIndicator != null)
        {
            return _patientChargeableIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.11",
            Type = @"Field",
            Position = @"IVT.11",
            Name = @"Patient Chargeable Indicator",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field indicates whether the item is patient chargeable at this inventory location. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.11.1",
                            Type = @"Component",
                            Position = @"IVT.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.2",
                            Type = @"Component",
                            Position = @"IVT.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.3",
                            Type = @"Component",
                            Position = @"IVT.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.4",
                            Type = @"Component",
                            Position = @"IVT.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.5",
                            Type = @"Component",
                            Position = @"IVT.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.6",
                            Type = @"Component",
                            Position = @"IVT.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.7",
                            Type = @"Component",
                            Position = @"IVT.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.8",
                            Type = @"Component",
                            Position = @"IVT.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.11.9",
                            Type = @"Component",
                            Position = @"IVT.11.9",
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

        _patientChargeableIndicator = new HL7V26Field
        {
            field = message[@"IVT"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientChargeableIndicator.field.FieldRepetitions != null && _patientChargeableIndicator.field.FieldRepetitions.Count > 0)
        {
            _patientChargeableIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_patientChargeableIndicator, fieldData);
        }

        return _patientChargeableIndicator;
    } 
}

internal HL7V26Field _transactionCode;

public HL7V26Field TransactionCode
{
    get
    {
        if (_transactionCode != null)
        {
            return _transactionCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.12",
            Type = @"Field",
            Position = @"IVT.12",
            Name = @"Transaction Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0132",
            TableName = @"Transaction Code",
            Description = @"This field contains a code that is used by a billing system to charge for the inventory supply item, the descriptive name of the patient charge for that system (as it may appear on a patient's bill or charge labels) and the name of the coding system that assigned the charge code. Refer to User-defined Table 0132 - Transaction Codes in Chapter 6for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.12.1",
                            Type = @"Component",
                            Position = @"IVT.12.1",
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
                            Id = @"IVT.12.2",
                            Type = @"Component",
                            Position = @"IVT.12.2",
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
                            Id = @"IVT.12.3",
                            Type = @"Component",
                            Position = @"IVT.12.3",
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
                            Id = @"IVT.12.4",
                            Type = @"Component",
                            Position = @"IVT.12.4",
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
                            Id = @"IVT.12.5",
                            Type = @"Component",
                            Position = @"IVT.12.5",
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
                            Id = @"IVT.12.6",
                            Type = @"Component",
                            Position = @"IVT.12.6",
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
                            Id = @"IVT.12.7",
                            Type = @"Component",
                            Position = @"IVT.12.7",
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
                            Id = @"IVT.12.8",
                            Type = @"Component",
                            Position = @"IVT.12.8",
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
                            Id = @"IVT.12.9",
                            Type = @"Component",
                            Position = @"IVT.12.9",
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

        _transactionCode = new HL7V26Field
        {
            field = message[@"IVT"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionCode.field.FieldRepetitions != null && _transactionCode.field.FieldRepetitions.Count > 0)
        {
            _transactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_transactionCode, fieldData);
        }

        return _transactionCode;
    } 
}

internal HL7V26Field _transactionamountunit;

public HL7V26Field Transactionamountunit
{
    get
    {
        if (_transactionamountunit != null)
        {
            return _transactionamountunit;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.13",
            Type = @"Field",
            Position = @"IVT.13",
            Name = @"Transaction amount - unit",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the dollar amount charged to patients for this single inventory supply item.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.13.1",
                            Type = @"Component",
                            Position = @"IVT.13.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IVT.13.1.1",
                            Type = @"SubComponent",
                            Position = @"IVT.13.1.1",
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
                            Id = @"IVT.13.1.2",
                            Type = @"SubComponent",
                            Position = @"IVT.13.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.13.2",
                            Type = @"Component",
                            Position = @"IVT.13.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.13.3",
                            Type = @"Component",
                            Position = @"IVT.13.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.13.4",
                            Type = @"Component",
                            Position = @"IVT.13.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.13.5",
                            Type = @"Component",
                            Position = @"IVT.13.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IVT.13.5.1",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.1",
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
                            Id = @"IVT.13.5.2",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.2",
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
                            Id = @"IVT.13.5.3",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.3",
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
                            Id = @"IVT.13.5.4",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.4",
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
                            Id = @"IVT.13.5.5",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.5",
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
                            Id = @"IVT.13.5.6",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.6",
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
                            Id = @"IVT.13.5.7",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.7",
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
                            Id = @"IVT.13.5.8",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.8",
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
                            Id = @"IVT.13.5.9",
                            Type = @"SubComponent",
                            Position = @"IVT.13.5.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.13.6",
                            Type = @"Component",
                            Position = @"IVT.13.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _transactionamountunit = new HL7V26Field
        {
            field = message[@"IVT"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionamountunit.field.FieldRepetitions != null && _transactionamountunit.field.FieldRepetitions.Count > 0)
        {
            _transactionamountunit.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_transactionamountunit, fieldData);
        }

        return _transactionamountunit;
    } 
}

internal HL7V26Field _itemImportanceCode;

public HL7V26Field ItemImportanceCode
{
    get
    {
        if (_itemImportanceCode != null)
        {
            return _itemImportanceCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.14",
            Type = @"Field",
            Position = @"IVT.14",
            Name = @"Item Importance Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0634",
            TableName = @"Item Importance Codes",
            Description = @"This field contains an indicator of the level of importance of an item considered for this inventory location, such as an indicator signifying whether the item is considered critical for this inventory location. Refer to User-defined Table 0634 - Item Importance Codes for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.14.1",
                            Type = @"Component",
                            Position = @"IVT.14.1",
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
                            Id = @"IVT.14.2",
                            Type = @"Component",
                            Position = @"IVT.14.2",
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
                            Id = @"IVT.14.3",
                            Type = @"Component",
                            Position = @"IVT.14.3",
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
                            Id = @"IVT.14.4",
                            Type = @"Component",
                            Position = @"IVT.14.4",
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
                            Id = @"IVT.14.5",
                            Type = @"Component",
                            Position = @"IVT.14.5",
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
                            Id = @"IVT.14.6",
                            Type = @"Component",
                            Position = @"IVT.14.6",
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
                            Id = @"IVT.14.7",
                            Type = @"Component",
                            Position = @"IVT.14.7",
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
                            Id = @"IVT.14.8",
                            Type = @"Component",
                            Position = @"IVT.14.8",
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
                            Id = @"IVT.14.9",
                            Type = @"Component",
                            Position = @"IVT.14.9",
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

        _itemImportanceCode = new HL7V26Field
        {
            field = message[@"IVT"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_itemImportanceCode.field.FieldRepetitions != null && _itemImportanceCode.field.FieldRepetitions.Count > 0)
        {
            _itemImportanceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_itemImportanceCode, fieldData);
        }

        return _itemImportanceCode;
    } 
}

internal HL7V26Field _stockedItemIndicator;

public HL7V26Field StockedItemIndicator
{
    get
    {
        if (_stockedItemIndicator != null)
        {
            return _stockedItemIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.15",
            Type = @"Field",
            Position = @"IVT.15",
            Name = @"Stocked Item Indicator",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field contains an indicator that identifies whether the item is regularly stocked in this inventory location. Stock items are ordered regularly as part of the healthcare organization's inventory replenishment cycle. If the item is not regularly stocked in this inventory location (non-stock item), the item is available to be ordered from this inventory location if requested by a department. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.15.1",
                            Type = @"Component",
                            Position = @"IVT.15.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.2",
                            Type = @"Component",
                            Position = @"IVT.15.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.3",
                            Type = @"Component",
                            Position = @"IVT.15.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.4",
                            Type = @"Component",
                            Position = @"IVT.15.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.5",
                            Type = @"Component",
                            Position = @"IVT.15.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.6",
                            Type = @"Component",
                            Position = @"IVT.15.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.7",
                            Type = @"Component",
                            Position = @"IVT.15.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.8",
                            Type = @"Component",
                            Position = @"IVT.15.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.15.9",
                            Type = @"Component",
                            Position = @"IVT.15.9",
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

        _stockedItemIndicator = new HL7V26Field
        {
            field = message[@"IVT"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_stockedItemIndicator.field.FieldRepetitions != null && _stockedItemIndicator.field.FieldRepetitions.Count > 0)
        {
            _stockedItemIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_stockedItemIndicator, fieldData);
        }

        return _stockedItemIndicator;
    } 
}

internal HL7V26Field _consignmentItemIndicator;

public HL7V26Field ConsignmentItemIndicator
{
    get
    {
        if (_consignmentItemIndicator != null)
        {
            return _consignmentItemIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.16",
            Type = @"Field",
            Position = @"IVT.16",
            Name = @"Consignment Item Indicator",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field contains an indicator signifying whether the inventory supply item is purchased on consignment. If the item is purchased on consignment, the healthcare organization does not pay for the inventory supply item until it is used. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.16.1",
                            Type = @"Component",
                            Position = @"IVT.16.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.2",
                            Type = @"Component",
                            Position = @"IVT.16.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.3",
                            Type = @"Component",
                            Position = @"IVT.16.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.4",
                            Type = @"Component",
                            Position = @"IVT.16.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.5",
                            Type = @"Component",
                            Position = @"IVT.16.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.6",
                            Type = @"Component",
                            Position = @"IVT.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.7",
                            Type = @"Component",
                            Position = @"IVT.16.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.8",
                            Type = @"Component",
                            Position = @"IVT.16.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.16.9",
                            Type = @"Component",
                            Position = @"IVT.16.9",
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

        _consignmentItemIndicator = new HL7V26Field
        {
            field = message[@"IVT"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consignmentItemIndicator.field.FieldRepetitions != null && _consignmentItemIndicator.field.FieldRepetitions.Count > 0)
        {
            _consignmentItemIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_consignmentItemIndicator, fieldData);
        }

        return _consignmentItemIndicator;
    } 
}

internal HL7V26Field _reusableItemIndicator;

public HL7V26Field ReusableItemIndicator
{
    get
    {
        if (_reusableItemIndicator != null)
        {
            return _reusableItemIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.17",
            Type = @"Field",
            Position = @"IVT.17",
            Name = @"Reusable Item Indicator",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field contains an indicator signifying that the inventory supply item is reusable, for example, after sterilization. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.17.1",
                            Type = @"Component",
                            Position = @"IVT.17.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.2",
                            Type = @"Component",
                            Position = @"IVT.17.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.3",
                            Type = @"Component",
                            Position = @"IVT.17.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.4",
                            Type = @"Component",
                            Position = @"IVT.17.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.5",
                            Type = @"Component",
                            Position = @"IVT.17.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.6",
                            Type = @"Component",
                            Position = @"IVT.17.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.7",
                            Type = @"Component",
                            Position = @"IVT.17.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.8",
                            Type = @"Component",
                            Position = @"IVT.17.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.17.9",
                            Type = @"Component",
                            Position = @"IVT.17.9",
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

        _reusableItemIndicator = new HL7V26Field
        {
            field = message[@"IVT"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reusableItemIndicator.field.FieldRepetitions != null && _reusableItemIndicator.field.FieldRepetitions.Count > 0)
        {
            _reusableItemIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reusableItemIndicator, fieldData);
        }

        return _reusableItemIndicator;
    } 
}

internal HL7V26Field _reusableCost;

public HL7V26Field ReusableCost
{
    get
    {
        if (_reusableCost != null)
        {
            return _reusableCost;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.18",
            Type = @"Field",
            Position = @"IVT.18",
            Name = @"Reusable Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the issue cost charged to a department or patient for a reusable item. This cost is calculated based on the cost of reprocessing the item. Examples of reusable items are linens, restraints, and procedure packs (custom for specific procedures).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.18.1",
                            Type = @"Component",
                            Position = @"IVT.18.1",
                            Name = @"Price",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IVT.18.1.1",
                            Type = @"SubComponent",
                            Position = @"IVT.18.1.1",
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
                            Id = @"IVT.18.1.2",
                            Type = @"SubComponent",
                            Position = @"IVT.18.1.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.18.2",
                            Type = @"Component",
                            Position = @"IVT.18.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.18.3",
                            Type = @"Component",
                            Position = @"IVT.18.3",
                            Name = @"From Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the ""range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.18.4",
                            Type = @"Component",
                            Position = @"IVT.18.4",
                            Name = @"To Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value>.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.18.5",
                            Type = @"Component",
                            Position = @"IVT.18.5",
                            Name = @"Range Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CWE, defined by the standard table of units for either time or quantity (see for example, the tables in Section 7.1.4, ""Coding schemes""). This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and <to value> are present.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IVT.18.5.1",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.1",
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
                            Id = @"IVT.18.5.2",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.2",
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
                            Id = @"IVT.18.5.3",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.3",
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
                            Id = @"IVT.18.5.4",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.4",
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
                            Id = @"IVT.18.5.5",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.5",
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
                            Id = @"IVT.18.5.6",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.6",
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
                            Id = @"IVT.18.5.7",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.7",
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
                            Id = @"IVT.18.5.8",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.8",
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
                            Id = @"IVT.18.5.9",
                            Type = @"SubComponent",
                            Position = @"IVT.18.5.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.18.6",
                            Type = @"Component",
                            Position = @"IVT.18.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _reusableCost = new HL7V26Field
        {
            field = message[@"IVT"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reusableCost.field.FieldRepetitions != null && _reusableCost.field.FieldRepetitions.Count > 0)
        {
            _reusableCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_reusableCost, fieldData);
        }

        return _reusableCost;
    } 
}

internal HL7V26Field _substituteItemIdentifier;

public HL7V26Field SubstituteItemIdentifier
{
    get
    {
        if (_substituteItemIdentifier != null)
        {
            return _substituteItemIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.19",
            Type = @"Field",
            Position = @"IVT.19",
            Name = @"Substitute Item Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The substitute item is an item that is recommended as a substitute for the corresponding item in ITM-1.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.19.1",
                            Type = @"Component",
                            Position = @"IVT.19.1",
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
                            Id = @"IVT.19.2",
                            Type = @"Component",
                            Position = @"IVT.19.2",
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
                            Id = @"IVT.19.3",
                            Type = @"Component",
                            Position = @"IVT.19.3",
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
                            Id = @"IVT.19.4",
                            Type = @"Component",
                            Position = @"IVT.19.4",
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

        _substituteItemIdentifier = new HL7V26Field
        {
            field = message[@"IVT"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substituteItemIdentifier.field.FieldRepetitions != null && _substituteItemIdentifier.field.FieldRepetitions.Count > 0)
        {
            _substituteItemIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_substituteItemIdentifier, fieldData);
        }

        return _substituteItemIdentifier;
    } 
}

internal HL7V26Field _latexFreeSubstituteItemIdentifier;

public HL7V26Field LatexFreeSubstituteItemIdentifier
{
    get
    {
        if (_latexFreeSubstituteItemIdentifier != null)
        {
            return _latexFreeSubstituteItemIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.20",
            Type = @"Field",
            Position = @"IVT.20",
            Name = @"Latex-Free Substitute Item Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The latex-free substitute item is an item that is latex-free, recommended as a substitute for the corresponding item in the ITM-1 segment when a latex-free item is needed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.20.1",
                            Type = @"Component",
                            Position = @"IVT.20.1",
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
                            Id = @"IVT.20.2",
                            Type = @"Component",
                            Position = @"IVT.20.2",
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
                            Id = @"IVT.20.3",
                            Type = @"Component",
                            Position = @"IVT.20.3",
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
                            Id = @"IVT.20.4",
                            Type = @"Component",
                            Position = @"IVT.20.4",
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

        _latexFreeSubstituteItemIdentifier = new HL7V26Field
        {
            field = message[@"IVT"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_latexFreeSubstituteItemIdentifier.field.FieldRepetitions != null && _latexFreeSubstituteItemIdentifier.field.FieldRepetitions.Count > 0)
        {
            _latexFreeSubstituteItemIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_latexFreeSubstituteItemIdentifier, fieldData);
        }

        return _latexFreeSubstituteItemIdentifier;
    } 
}

internal HL7V26Field _recommendedReorderTheory;

public HL7V26Field RecommendedReorderTheory
{
    get
    {
        if (_recommendedReorderTheory != null)
        {
            return _recommendedReorderTheory;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.21",
            Type = @"Field",
            Position = @"IVT.21",
            Name = @"Recommended Reorder Theory",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0642",
            TableName = @"Reorder Theory Codes",
            Description = @"This field contains the method used to calculate a recommendation for when and how much of an inventory supply item to reorder. Refer to User-defined Table 0642 - Reorder Theory Codes for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.21.1",
                            Type = @"Component",
                            Position = @"IVT.21.1",
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
                            Id = @"IVT.21.2",
                            Type = @"Component",
                            Position = @"IVT.21.2",
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
                            Id = @"IVT.21.3",
                            Type = @"Component",
                            Position = @"IVT.21.3",
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
                            Id = @"IVT.21.4",
                            Type = @"Component",
                            Position = @"IVT.21.4",
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
                            Id = @"IVT.21.5",
                            Type = @"Component",
                            Position = @"IVT.21.5",
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
                            Id = @"IVT.21.6",
                            Type = @"Component",
                            Position = @"IVT.21.6",
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
                            Id = @"IVT.21.7",
                            Type = @"Component",
                            Position = @"IVT.21.7",
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
                            Id = @"IVT.21.8",
                            Type = @"Component",
                            Position = @"IVT.21.8",
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
                            Id = @"IVT.21.9",
                            Type = @"Component",
                            Position = @"IVT.21.9",
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

        _recommendedReorderTheory = new HL7V26Field
        {
            field = message[@"IVT"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recommendedReorderTheory.field.FieldRepetitions != null && _recommendedReorderTheory.field.FieldRepetitions.Count > 0)
        {
            _recommendedReorderTheory.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recommendedReorderTheory, fieldData);
        }

        return _recommendedReorderTheory;
    } 
}

internal HL7V26Field _recommendedSafetyStockDays;

public HL7V26Field RecommendedSafetyStockDays
{
    get
    {
        if (_recommendedSafetyStockDays != null)
        {
            return _recommendedSafetyStockDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.22",
            Type = @"Field",
            Position = @"IVT.22",
            Name = @"Recommended Safety Stock Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days for stock to be kept on-hand to cushion against a stock-out for this item.",
            Sample = @"",
            Fields = null
        }

        _recommendedSafetyStockDays = new HL7V26Field
        {
            field = message[@"IVT"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recommendedSafetyStockDays.field.FieldRepetitions != null && _recommendedSafetyStockDays.field.FieldRepetitions.Count > 0)
        {
            _recommendedSafetyStockDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recommendedSafetyStockDays, fieldData);
        }

        return _recommendedSafetyStockDays;
    } 
}

internal HL7V26Field _recommendedMaximumDaysInventory;

public HL7V26Field RecommendedMaximumDaysInventory
{
    get
    {
        if (_recommendedMaximumDaysInventory != null)
        {
            return _recommendedMaximumDaysInventory;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.23",
            Type = @"Field",
            Position = @"IVT.23",
            Name = @"Recommended Maximum Days Inventory",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the maximum number of days of inventory to have on-hand at any one point in time. This value is used in calculations of recommended order quantities",
            Sample = @"",
            Fields = null
        }

        _recommendedMaximumDaysInventory = new HL7V26Field
        {
            field = message[@"IVT"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recommendedMaximumDaysInventory.field.FieldRepetitions != null && _recommendedMaximumDaysInventory.field.FieldRepetitions.Count > 0)
        {
            _recommendedMaximumDaysInventory.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recommendedMaximumDaysInventory, fieldData);
        }

        return _recommendedMaximumDaysInventory;
    } 
}

internal HL7V26Field _recommendedOrderPoint;

public HL7V26Field RecommendedOrderPoint
{
    get
    {
        if (_recommendedOrderPoint != null)
        {
            return _recommendedOrderPoint;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.24",
            Type = @"Field",
            Position = @"IVT.24",
            Name = @"Recommended Order Point",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the on-hand quantity referencing the recommended level of inventory at which the item should be re-ordered.",
            Sample = @"",
            Fields = null
        }

        _recommendedOrderPoint = new HL7V26Field
        {
            field = message[@"IVT"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recommendedOrderPoint.field.FieldRepetitions != null && _recommendedOrderPoint.field.FieldRepetitions.Count > 0)
        {
            _recommendedOrderPoint.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recommendedOrderPoint, fieldData);
        }

        return _recommendedOrderPoint;
    } 
}

internal HL7V26Field _recommendedOrderAmount;

public HL7V26Field RecommendedOrderAmount
{
    get
    {
        if (_recommendedOrderAmount != null)
        {
            return _recommendedOrderAmount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.25",
            Type = @"Field",
            Position = @"IVT.25",
            Name = @"Recommended Order Amount",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity that the system should recommend to order when the on-hand quantity is equal to or less than the reorder point. The quantity should be set at the Order Unit of Measure.",
            Sample = @"",
            Fields = null
        }

        _recommendedOrderAmount = new HL7V26Field
        {
            field = message[@"IVT"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recommendedOrderAmount.field.FieldRepetitions != null && _recommendedOrderAmount.field.FieldRepetitions.Count > 0)
        {
            _recommendedOrderAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_recommendedOrderAmount, fieldData);
        }

        return _recommendedOrderAmount;
    } 
}

internal HL7V26Field _operatingRoomParLevelIndicator;

public HL7V26Field OperatingRoomParLevelIndicator
{
    get
    {
        if (_operatingRoomParLevelIndicator != null)
        {
            return _operatingRoomParLevelIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"IVT.26",
            Type = @"Field",
            Position = @"IVT.26",
            Name = @"Operating Room Par Level Indicator",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field contains an indicator that determines whether on-hands inventory will be decremented when performing Preference List Issues. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.

If valued with a 'Y', this indicates to the system that the item to be issued is contained in an OR Par Level area (in an actual Operating Room) and not an Operating Room inventory area; therefore, on-hands of the Operation Room inventory area will not be decremented. If valued with a 'N', the item is contained in an Operating Room inventory location and on-hands will be decremented when performing Preference List Issues.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IVT.26.1",
                            Type = @"Component",
                            Position = @"IVT.26.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.2",
                            Type = @"Component",
                            Position = @"IVT.26.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.3",
                            Type = @"Component",
                            Position = @"IVT.26.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.4",
                            Type = @"Component",
                            Position = @"IVT.26.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.5",
                            Type = @"Component",
                            Position = @"IVT.26.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.6",
                            Type = @"Component",
                            Position = @"IVT.26.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.7",
                            Type = @"Component",
                            Position = @"IVT.26.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.8",
                            Type = @"Component",
                            Position = @"IVT.26.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IVT.26.9",
                            Type = @"Component",
                            Position = @"IVT.26.9",
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

        _operatingRoomParLevelIndicator = new HL7V26Field
        {
            field = message[@"IVT"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_operatingRoomParLevelIndicator.field.FieldRepetitions != null && _operatingRoomParLevelIndicator.field.FieldRepetitions.Count > 0)
        {
            _operatingRoomParLevelIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_operatingRoomParLevelIndicator, fieldData);
        }

        return _operatingRoomParLevelIndicator;
    } 
}
    }
}

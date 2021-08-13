using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentVND
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"VND"; } }

        public string SegmentId { get { return @"VND"; } }
        
        public string LongName { get { return @"Purchasing Vendor"; } }
        
        public string Description { get { return @"This segment contains purchasing vendors that supply the inventory supply item specified in the ITM segment."; } }
        
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

        public HL7V26SegmentVND(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIdVND;

public HL7V26Field SetIdVND
{
    get
    {
        if (_setIdVND != null)
        {
            return _setIdVND;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"VND.1",
            Type = @"Field",
            Position = @"VND.1",
            Name = @"Set Id – VND",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a sequential number that identifies this segment within a given PURCHASING_VENDOR segment group. For the first occurrence of the segment in a given group, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
            Sample = @"",
            Fields = null
        }

        _setIdVND = new HL7V26Field
        {
            field = message[@"VND"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdVND.field.FieldRepetitions != null && _setIdVND.field.FieldRepetitions.Count > 0)
        {
            _setIdVND.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIdVND, fieldData);
        }

        return _setIdVND;
    } 
}

internal HL7V26Field _vendorIdentifier;

public HL7V26Field VendorIdentifier
{
    get
    {
        if (_vendorIdentifier != null)
        {
            return _vendorIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"VND.2",
            Type = @"Field",
            Position = @"VND.2",
            Name = @"Vendor Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the vendor in the system.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VND.2.1",
                            Type = @"Component",
                            Position = @"VND.2.1",
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
                            Id = @"VND.2.2",
                            Type = @"Component",
                            Position = @"VND.2.2",
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
                            Id = @"VND.2.3",
                            Type = @"Component",
                            Position = @"VND.2.3",
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
                            Id = @"VND.2.4",
                            Type = @"Component",
                            Position = @"VND.2.4",
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

        _vendorIdentifier = new HL7V26Field
        {
            field = message[@"VND"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorIdentifier.field.FieldRepetitions != null && _vendorIdentifier.field.FieldRepetitions.Count > 0)
        {
            _vendorIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_vendorIdentifier, fieldData);
        }

        return _vendorIdentifier;
    } 
}

internal HL7V26Field _vendorName;

public HL7V26Field VendorName
{
    get
    {
        if (_vendorName != null)
        {
            return _vendorName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"VND.3",
            Type = @"Field",
            Position = @"VND.3",
            Name = @"Vendor Name",
            Length = 999,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the vendor identified in VND-2.",
            Sample = @"",
            Fields = null
        }

        _vendorName = new HL7V26Field
        {
            field = message[@"VND"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorName.field.FieldRepetitions != null && _vendorName.field.FieldRepetitions.Count > 0)
        {
            _vendorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_vendorName, fieldData);
        }

        return _vendorName;
    } 
}

internal HL7V26Field _vendorCatalogNumber;

public HL7V26Field VendorCatalogNumber
{
    get
    {
        if (_vendorCatalogNumber != null)
        {
            return _vendorCatalogNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"VND.4",
            Type = @"Field",
            Position = @"VND.4",
            Name = @"Vendor Catalog Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the catalog number assigned to the item by a purchasing vendor.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VND.4.1",
                            Type = @"Component",
                            Position = @"VND.4.1",
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
                            Id = @"VND.4.2",
                            Type = @"Component",
                            Position = @"VND.4.2",
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
                            Id = @"VND.4.3",
                            Type = @"Component",
                            Position = @"VND.4.3",
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
                            Id = @"VND.4.4",
                            Type = @"Component",
                            Position = @"VND.4.4",
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

        _vendorCatalogNumber = new HL7V26Field
        {
            field = message[@"VND"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorCatalogNumber.field.FieldRepetitions != null && _vendorCatalogNumber.field.FieldRepetitions.Count > 0)
        {
            _vendorCatalogNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_vendorCatalogNumber, fieldData);
        }

        return _vendorCatalogNumber;
    } 
}

internal HL7V26Field _primaryVendorIndicator;

public HL7V26Field PrimaryVendorIndicator
{
    get
    {
        if (_primaryVendorIndicator != null)
        {
            return _primaryVendorIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"VND.5",
            Type = @"Field",
            Position = @"VND.5",
            Name = @"Primary Vendor Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded yes/no indicator",
            Description = @"This field contains an indicator to communicate whether this purchasing vendor is the primary vendor used to place orders for inventory supply item. Refer to HL7 Table 0532 - Expanded yes/no indicator table in Chapter 2 for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VND.5.1",
                            Type = @"Component",
                            Position = @"VND.5.1",
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
                            Id = @"VND.5.2",
                            Type = @"Component",
                            Position = @"VND.5.2",
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
                            Id = @"VND.5.3",
                            Type = @"Component",
                            Position = @"VND.5.3",
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
                            Id = @"VND.5.4",
                            Type = @"Component",
                            Position = @"VND.5.4",
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
                            Id = @"VND.5.5",
                            Type = @"Component",
                            Position = @"VND.5.5",
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
                            Id = @"VND.5.6",
                            Type = @"Component",
                            Position = @"VND.5.6",
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
                            Id = @"VND.5.7",
                            Type = @"Component",
                            Position = @"VND.5.7",
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
                            Id = @"VND.5.8",
                            Type = @"Component",
                            Position = @"VND.5.8",
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
                            Id = @"VND.5.9",
                            Type = @"Component",
                            Position = @"VND.5.9",
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

        _primaryVendorIndicator = new HL7V26Field
        {
            field = message[@"VND"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryVendorIndicator.field.FieldRepetitions != null && _primaryVendorIndicator.field.FieldRepetitions.Count > 0)
        {
            _primaryVendorIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_primaryVendorIndicator, fieldData);
        }

        return _primaryVendorIndicator;
    } 
}
    }
}

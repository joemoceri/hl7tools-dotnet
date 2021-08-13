using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRQ1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RQ1"; } }

        public string SegmentId { get { return @"RQ1"; } }
        
        public string LongName { get { return @"Requisition Detail-1"; } }
        
        public string Description { get { return @"RQ1 contains additional detail for each non-stock requisitioned item. This segment definition is paired with a preceding RQD segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V26SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _anticipatedPrice;

public HL7V26Field AnticipatedPrice
{
    get
    {
        if (_anticipatedPrice != null)
        {
            return _anticipatedPrice;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.1",
            Type = @"Field",
            Position = @"RQ1.1",
            Name = @"Anticipated Price",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reference price for the requisition unit of measure that is known to the requisition application. It may or may not be the actual cost of acquiring the item from a supplier. It is also not the price charged to the patient.",
            Sample = @"",
            Fields = null
        }

        _anticipatedPrice = new HL7V26Field
        {
            field = message[@"RQ1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anticipatedPrice.field.FieldRepetitions != null && _anticipatedPrice.field.FieldRepetitions.Count > 0)
        {
            _anticipatedPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_anticipatedPrice, fieldData);
        }

        return _anticipatedPrice;
    } 
}

internal HL7V26Field _manufacturerIdentifier;

public HL7V26Field ManufacturerIdentifier
{
    get
    {
        if (_manufacturerIdentifier != null)
        {
            return _manufacturerIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.2",
            Type = @"Field",
            Position = @"RQ1.2",
            Name = @"Manufacturer Identifier",
            Length = 705,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.

Refer to User-defined Table 0385 – Manufacturer identifier for suggested values, or relevant external code sets may be used (e.g., HIBCC Manufacturers Labeler ID Code (LIC), UPC, NDC).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQ1.2.1",
                            Type = @"Component",
                            Position = @"RQ1.2.1",
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
                            Id = @"RQ1.2.2",
                            Type = @"Component",
                            Position = @"RQ1.2.2",
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
                            Id = @"RQ1.2.3",
                            Type = @"Component",
                            Position = @"RQ1.2.3",
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
                            Id = @"RQ1.2.4",
                            Type = @"Component",
                            Position = @"RQ1.2.4",
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
                            Id = @"RQ1.2.5",
                            Type = @"Component",
                            Position = @"RQ1.2.5",
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
                            Id = @"RQ1.2.6",
                            Type = @"Component",
                            Position = @"RQ1.2.6",
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
                            Id = @"RQ1.2.7",
                            Type = @"Component",
                            Position = @"RQ1.2.7",
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
                            Id = @"RQ1.2.8",
                            Type = @"Component",
                            Position = @"RQ1.2.8",
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
                            Id = @"RQ1.2.9",
                            Type = @"Component",
                            Position = @"RQ1.2.9",
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

        _manufacturerIdentifier = new HL7V26Field
        {
            field = message[@"RQ1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturerIdentifier.field.FieldRepetitions != null && _manufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _manufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_manufacturerIdentifier, fieldData);
        }

        return _manufacturerIdentifier;
    } 
}

internal HL7V26Field _manufacturersCatalog;

public HL7V26Field ManufacturersCatalog
{
    get
    {
        if (_manufacturersCatalog != null)
        {
            return _manufacturersCatalog;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.3",
            Type = @"Field",
            Position = @"RQ1.3",
            Name = @"Manufacturer's Catalog",
            Length = 16,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the manufacturer's catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = null
        }

        _manufacturersCatalog = new HL7V26Field
        {
            field = message[@"RQ1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturersCatalog.field.FieldRepetitions != null && _manufacturersCatalog.field.FieldRepetitions.Count > 0)
        {
            _manufacturersCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_manufacturersCatalog, fieldData);
        }

        return _manufacturersCatalog;
    } 
}

internal HL7V26Field _vendorID;

public HL7V26Field VendorID
{
    get
    {
        if (_vendorID != null)
        {
            return _vendorID;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.4",
            Type = @"Field",
            Position = @"RQ1.4",
            Name = @"Vendor ID",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQ1.4.1",
                            Type = @"Component",
                            Position = @"RQ1.4.1",
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
                            Id = @"RQ1.4.2",
                            Type = @"Component",
                            Position = @"RQ1.4.2",
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
                            Id = @"RQ1.4.3",
                            Type = @"Component",
                            Position = @"RQ1.4.3",
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
                            Id = @"RQ1.4.4",
                            Type = @"Component",
                            Position = @"RQ1.4.4",
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
                            Id = @"RQ1.4.5",
                            Type = @"Component",
                            Position = @"RQ1.4.5",
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
                            Id = @"RQ1.4.6",
                            Type = @"Component",
                            Position = @"RQ1.4.6",
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
                            Id = @"RQ1.4.7",
                            Type = @"Component",
                            Position = @"RQ1.4.7",
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
                            Id = @"RQ1.4.8",
                            Type = @"Component",
                            Position = @"RQ1.4.8",
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
                            Id = @"RQ1.4.9",
                            Type = @"Component",
                            Position = @"RQ1.4.9",
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

        _vendorID = new HL7V26Field
        {
            field = message[@"RQ1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorID.field.FieldRepetitions != null && _vendorID.field.FieldRepetitions.Count > 0)
        {
            _vendorID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_vendorID, fieldData);
        }

        return _vendorID;
    } 
}

internal HL7V26Field _vendorCatalog;

public HL7V26Field VendorCatalog
{
    get
    {
        if (_vendorCatalog != null)
        {
            return _vendorCatalog;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.5",
            Type = @"Field",
            Position = @"RQ1.5",
            Name = @"Vendor Catalog",
            Length = 16,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the vendor's catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = null
        }

        _vendorCatalog = new HL7V26Field
        {
            field = message[@"RQ1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorCatalog.field.FieldRepetitions != null && _vendorCatalog.field.FieldRepetitions.Count > 0)
        {
            _vendorCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_vendorCatalog, fieldData);
        }

        return _vendorCatalog;
    } 
}

internal HL7V26Field _taxable;

public HL7V26Field Taxable
{
    get
    {
        if (_taxable != null)
        {
            return _taxable;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.6",
            Type = @"Field",
            Position = @"RQ1.6",
            Name = @"Taxable",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether this item is subject to tax.",
            Sample = @"",
            Fields = null
        }

        _taxable = new HL7V26Field
        {
            field = message[@"RQ1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_taxable.field.FieldRepetitions != null && _taxable.field.FieldRepetitions.Count > 0)
        {
            _taxable.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_taxable, fieldData);
        }

        return _taxable;
    } 
}

internal HL7V26Field _substituteAllowed;

public HL7V26Field SubstituteAllowed
{
    get
    {
        if (_substituteAllowed != null)
        {
            return _substituteAllowed;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RQ1.7",
            Type = @"Field",
            Position = @"RQ1.7",
            Name = @"Substitute Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7 Table 0136 - Yes/No Indicator as defined in Chapter 2.",
            Sample = @"",
            Fields = null
        }

        _substituteAllowed = new HL7V26Field
        {
            field = message[@"RQ1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substituteAllowed.field.FieldRepetitions != null && _substituteAllowed.field.FieldRepetitions.Count > 0)
        {
            _substituteAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_substituteAllowed, fieldData);
        }

        return _substituteAllowed;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRQ1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RQ1"; } }

        public string SegmentId { get { return @"RQ1"; } }
        
        public string LongName { get { return @"Requisition Detail-1"; } }
        
        public string Description { get { return @"RQ1 contains additional detail for each nonstock requisitioned item. This segment definition is paired with a preceding RQD segment."; } }
        
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

        public HL7V24SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _anticipatedPrice;

public HL7V24Field AnticipatedPrice
{
    get
    {
        if (_anticipatedPrice != null)
        {
            return _anticipatedPrice;
        }

        var fieldData = new HL7V24FieldData
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

        _anticipatedPrice = new HL7V24Field
        {
            field = message[@"RQ1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anticipatedPrice.field.FieldRepetitions != null && _anticipatedPrice.field.FieldRepetitions.Count > 0)
        {
            _anticipatedPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_anticipatedPrice, fieldData);
        }

        return _anticipatedPrice;
    } 
}

internal HL7V24Field _manufacturerIdentifier;

public HL7V24Field ManufacturerIdentifier
{
    get
    {
        if (_manufacturerIdentifier != null)
        {
            return _manufacturerIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RQ1.2",
            Type = @"Field",
            Position = @"RQ1.2",
            Name = @"Manufacturer Identifier",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQ1.2.1",
                            Type = @"Component",
                            Position = @"RQ1.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2.2",
                            Type = @"Component",
                            Position = @"RQ1.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2.3",
                            Type = @"Component",
                            Position = @"RQ1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2.4",
                            Type = @"Component",
                            Position = @"RQ1.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2.5",
                            Type = @"Component",
                            Position = @"RQ1.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2.6",
                            Type = @"Component",
                            Position = @"RQ1.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _manufacturerIdentifier = new HL7V24Field
        {
            field = message[@"RQ1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturerIdentifier.field.FieldRepetitions != null && _manufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _manufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_manufacturerIdentifier, fieldData);
        }

        return _manufacturerIdentifier;
    } 
}

internal HL7V24Field _manufacturersCatalog;

public HL7V24Field ManufacturersCatalog
{
    get
    {
        if (_manufacturersCatalog != null)
        {
            return _manufacturersCatalog;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field is the manufacturers catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = null
        }

        _manufacturersCatalog = new HL7V24Field
        {
            field = message[@"RQ1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturersCatalog.field.FieldRepetitions != null && _manufacturersCatalog.field.FieldRepetitions.Count > 0)
        {
            _manufacturersCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_manufacturersCatalog, fieldData);
        }

        return _manufacturersCatalog;
    } 
}

internal HL7V24Field _vendorID;

public HL7V24Field VendorID
{
    get
    {
        if (_vendorID != null)
        {
            return _vendorID;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RQ1.4",
            Type = @"Field",
            Position = @"RQ1.4",
            Name = @"Vendor ID",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RQ1.4.1",
                            Type = @"Component",
                            Position = @"RQ1.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4.2",
                            Type = @"Component",
                            Position = @"RQ1.4.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4.3",
                            Type = @"Component",
                            Position = @"RQ1.4.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4.4",
                            Type = @"Component",
                            Position = @"RQ1.4.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4.5",
                            Type = @"Component",
                            Position = @"RQ1.4.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4.6",
                            Type = @"Component",
                            Position = @"RQ1.4.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _vendorID = new HL7V24Field
        {
            field = message[@"RQ1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorID.field.FieldRepetitions != null && _vendorID.field.FieldRepetitions.Count > 0)
        {
            _vendorID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_vendorID, fieldData);
        }

        return _vendorID;
    } 
}

internal HL7V24Field _vendorCatalog;

public HL7V24Field VendorCatalog
{
    get
    {
        if (_vendorCatalog != null)
        {
            return _vendorCatalog;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field is the vendors catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
            Fields = null
        }

        _vendorCatalog = new HL7V24Field
        {
            field = message[@"RQ1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorCatalog.field.FieldRepetitions != null && _vendorCatalog.field.FieldRepetitions.Count > 0)
        {
            _vendorCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_vendorCatalog, fieldData);
        }

        return _vendorCatalog;
    } 
}

internal HL7V24Field _taxable;

public HL7V24Field Taxable
{
    get
    {
        if (_taxable != null)
        {
            return _taxable;
        }

        var fieldData = new HL7V24FieldData
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

        _taxable = new HL7V24Field
        {
            field = message[@"RQ1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_taxable.field.FieldRepetitions != null && _taxable.field.FieldRepetitions.Count > 0)
        {
            _taxable.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_taxable, fieldData);
        }

        return _taxable;
    } 
}

internal HL7V24Field _substituteAllowed;

public HL7V24Field SubstituteAllowed
{
    get
    {
        if (_substituteAllowed != null)
        {
            return _substituteAllowed;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7table 0136 - Yes/no indicator as defined in Chapter 2.",
            Sample = @"",
            Fields = null
        }

        _substituteAllowed = new HL7V24Field
        {
            field = message[@"RQ1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substituteAllowed.field.FieldRepetitions != null && _substituteAllowed.field.FieldRepetitions.Count > 0)
        {
            _substituteAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substituteAllowed, fieldData);
        }

        return _substituteAllowed;
    } 
}
    }
}

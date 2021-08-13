using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRQ1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RQ1"; } }

        public string SegmentId { get { return @"RQ1"; } }
        
        public string LongName { get { return @"Requisition Detail 1"; } }
        
        public string Description { get { return @"RQ1 contains additional detail for each nonstock requisitioned item. This segment definition is paired with a preceeding RQD segment."; } }
        
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

        public HL7V22SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _anticipatedPrice;

public HL7V22Field AnticipatedPrice
{
    get
    {
        if (_anticipatedPrice != null)
        {
            return _anticipatedPrice;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.1",
            Type = @"Field",
            Position = @"RQ1.1",
            Name = @"Anticipated Price",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"reference price for the requisition unit of measure that is known to the Requisition application.  It may or may not be the actual cost of acquiring the item from a supplier.  It is also not the price charged to the patient",
            Sample = @"",
            Fields = null
        }

        _anticipatedPrice = new HL7V22Field
        {
            field = message[@"RQ1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anticipatedPrice.field.FieldRepetitions != null && _anticipatedPrice.field.FieldRepetitions.Count > 0)
        {
            _anticipatedPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_anticipatedPrice, fieldData);
        }

        return _anticipatedPrice;
    } 
}

internal HL7V22Field _manufacturerId;

public HL7V22Field ManufacturerId
{
    get
    {
        if (_manufacturerId != null)
        {
            return _manufacturerId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.2",
            Type = @"Field",
            Position = @"RQ1.2",
            Name = @"Manufacturer Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"unique code that identifies the manufacturer on the application receiving the requisition.   Codes may be selected from HIBCC Manufacturer's Labeler ID Code (LIC), the UPC or the NDC. ",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _manufacturerId = new HL7V22Field
        {
            field = message[@"RQ1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturerId.field.FieldRepetitions != null && _manufacturerId.field.FieldRepetitions.Count > 0)
        {
            _manufacturerId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_manufacturerId, fieldData);
        }

        return _manufacturerId;
    } 
}

internal HL7V22Field _manufacturersCatalog;

public HL7V22Field ManufacturersCatalog
{
    get
    {
        if (_manufacturersCatalog != null)
        {
            return _manufacturersCatalog;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.3",
            Type = @"Field",
            Position = @"RQ1.3",
            Name = @"Manufacturer's Catalog",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" manufacturer's catalog number or code for this item",
            Sample = @"",
            Fields = null
        }

        _manufacturersCatalog = new HL7V22Field
        {
            field = message[@"RQ1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_manufacturersCatalog.field.FieldRepetitions != null && _manufacturersCatalog.field.FieldRepetitions.Count > 0)
        {
            _manufacturersCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_manufacturersCatalog, fieldData);
        }

        return _manufacturersCatalog;
    } 
}

internal HL7V22Field _vendorId;

public HL7V22Field VendorId
{
    get
    {
        if (_vendorId != null)
        {
            return _vendorId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.4",
            Type = @"Field",
            Position = @"RQ1.4",
            Name = @"Vendor Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"unique code that identifies the vendor on the application receiving the requisition",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _vendorId = new HL7V22Field
        {
            field = message[@"RQ1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorId.field.FieldRepetitions != null && _vendorId.field.FieldRepetitions.Count > 0)
        {
            _vendorId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_vendorId, fieldData);
        }

        return _vendorId;
    } 
}

internal HL7V22Field _vendorCatalog;

public HL7V22Field VendorCatalog
{
    get
    {
        if (_vendorCatalog != null)
        {
            return _vendorCatalog;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.5",
            Type = @"Field",
            Position = @"RQ1.5",
            Name = @"Vendor Catalog",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"vendor's catalog number, name, or code for this item",
            Sample = @"",
            Fields = null
        }

        _vendorCatalog = new HL7V22Field
        {
            field = message[@"RQ1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vendorCatalog.field.FieldRepetitions != null && _vendorCatalog.field.FieldRepetitions.Count > 0)
        {
            _vendorCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_vendorCatalog, fieldData);
        }

        return _vendorCatalog;
    } 
}

internal HL7V22Field _taxable;

public HL7V22Field Taxable
{
    get
    {
        if (_taxable != null)
        {
            return _taxable;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.6",
            Type = @"Field",
            Position = @"RQ1.6",
            Name = @"Taxable",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"is this item subject to tax? ",
            Sample = @"",
            Fields = null
        }

        _taxable = new HL7V22Field
        {
            field = message[@"RQ1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_taxable.field.FieldRepetitions != null && _taxable.field.FieldRepetitions.Count > 0)
        {
            _taxable.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_taxable, fieldData);
        }

        return _taxable;
    } 
}

internal HL7V22Field _substituteAllowed;

public HL7V22Field SubstituteAllowed
{
    get
    {
        if (_substituteAllowed != null)
        {
            return _substituteAllowed;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RQ1.7",
            Type = @"Field",
            Position = @"RQ1.7",
            Name = @"Substitute Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered.  Refer to table 0136 - Y/N indicator",
            Sample = @"",
            Fields = null
        }

        _substituteAllowed = new HL7V22Field
        {
            field = message[@"RQ1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substituteAllowed.field.FieldRepetitions != null && _substituteAllowed.field.FieldRepetitions.Count > 0)
        {
            _substituteAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_substituteAllowed, fieldData);
        }

        return _substituteAllowed;
    } 
}
    }
}

using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRQ1
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
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
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V22SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field anticipatedPrice;

public HL7V22Field AnticipatedPrice
{
    get
    {
        if (anticipatedPrice != null)
        {
            return anticipatedPrice;
        }

        anticipatedPrice = new HL7V22Field
        {
            field = message[@"RQ1"][1],
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
        };

        

        

        

        return anticipatedPrice;
    } 
}
internal HL7V22Field manufacturerId;

public HL7V22Field ManufacturerId
{
    get
    {
        if (manufacturerId != null)
        {
            return manufacturerId;
        }

        manufacturerId = new HL7V22Field
        {
            field = message[@"RQ1"][2],
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
        };

        

        

        

        return manufacturerId;
    } 
}
internal HL7V22Field manufacturer'sCatalog;

public HL7V22Field Manufacturer'sCatalog
{
    get
    {
        if (manufacturer'sCatalog != null)
        {
            return manufacturer'sCatalog;
        }

        manufacturer'sCatalog = new HL7V22Field
        {
            field = message[@"RQ1"][3],
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
        };

        

        

        

        return manufacturer'sCatalog;
    } 
}
internal HL7V22Field vendorId;

public HL7V22Field VendorId
{
    get
    {
        if (vendorId != null)
        {
            return vendorId;
        }

        vendorId = new HL7V22Field
        {
            field = message[@"RQ1"][4],
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
        };

        

        

        

        return vendorId;
    } 
}
internal HL7V22Field vendorCatalog;

public HL7V22Field VendorCatalog
{
    get
    {
        if (vendorCatalog != null)
        {
            return vendorCatalog;
        }

        vendorCatalog = new HL7V22Field
        {
            field = message[@"RQ1"][5],
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
        };

        

        

        

        return vendorCatalog;
    } 
}
internal HL7V22Field taxable;

public HL7V22Field Taxable
{
    get
    {
        if (taxable != null)
        {
            return taxable;
        }

        taxable = new HL7V22Field
        {
            field = message[@"RQ1"][6],
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
        };

        

        

        

        return taxable;
    } 
}
internal HL7V22Field substituteAllowed;

public HL7V22Field SubstituteAllowed
{
    get
    {
        if (substituteAllowed != null)
        {
            return substituteAllowed;
        }

        substituteAllowed = new HL7V22Field
        {
            field = message[@"RQ1"][7],
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
        };

        

        

        

        return substituteAllowed;
    } 
}

    }
}

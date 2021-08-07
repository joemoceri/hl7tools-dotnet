using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentRQ1
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RQ1"; } }

        public string SegmentId { get { return @"RQ1"; } }
        
        public string LongName { get { return @"Requisition detail-1 segment"; } }
        
        public string Description { get { return @"RQ1 contains additional detail for each nonstock requisitioned item.  This segment definition is paired with a preceding RQD segment."; } }
        
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the reference price for the requisition unit of measure that is known to the requisition application.  It may or may not be the actual cost of acquiring the item from a supplier.  It is also not the price charged to the patient",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.2",
                            Type = @"Field",
                            Position = @"RQ1.2",
                            Name = @"Manufactured ID",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.

Codes may be selected from HIBCC Manufacturers Labeler ID Code (LIC), the UPC or the NDC.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the manufacturer’s catalog number or code for this item.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5vendor catalog must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RQ1.4",
                            Type = @"Field",
                            Position = @"RQ1.4",
                            Name = @"Vendor ID",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.

Because of this, it is recommended that each nonstock item have RQ1-2-manufacturers ID and RQ1-3manufacturer’s catalog, or RQ1-4-vendor ID and RQ1-5-vendor catalog.  It is also possible that the requisitioning application will not know the identifier, as listed in the Manufacturer’s or Vendor’s catalog.  In this case, it is important to include the name portion of this coded element field.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the vendor’s catalog number, name, or code for this item.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5vendor catalog must be valued.",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether this item is subject to tax.

In general, nonstock requisitioned items will be printed by the receiving application and then processed by a human.  In other words, the human will use the information to call the vendor or manufacturer to get pricing and other related purchasing information before placing the order with an outside vendor.",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered.  Refer to HL7 table 0136 - Yes/no indicator ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field anticipatedPrice;

public HL7V23Field AnticipatedPrice
{
    get
    {
        if (anticipatedPrice != null)
        {
            return anticipatedPrice;
        }

        anticipatedPrice = new HL7V23Field
        {
            field = message[@"RQ1"][1],
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
            Description = @"This field contains the reference price for the requisition unit of measure that is known to the requisition application.  It may or may not be the actual cost of acquiring the item from a supplier.  It is also not the price charged to the patient",
            Sample = @"",
        };

        

        

        

        return anticipatedPrice;
    } 
}
internal HL7V23Field manufacturedID;

public HL7V23Field ManufacturedID
{
    get
    {
        if (manufacturedID != null)
        {
            return manufacturedID;
        }

        manufacturedID = new HL7V23Field
        {
            field = message[@"RQ1"][2],
            Id = @"RQ1.2",
            Type = @"Field",
            Position = @"RQ1.2",
            Name = @"Manufactured ID",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.

Codes may be selected from HIBCC Manufacturers Labeler ID Code (LIC), the UPC or the NDC.",
            Sample = @"",
        };

        

        

        

        return manufacturedID;
    } 
}
internal HL7V23Field manufacturer'sCatalog;

public HL7V23Field Manufacturer'sCatalog
{
    get
    {
        if (manufacturer'sCatalog != null)
        {
            return manufacturer'sCatalog;
        }

        manufacturer'sCatalog = new HL7V23Field
        {
            field = message[@"RQ1"][3],
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
            Description = @"This field is the manufacturer’s catalog number or code for this item.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5vendor catalog must be valued.",
            Sample = @"",
        };

        

        

        

        return manufacturer'sCatalog;
    } 
}
internal HL7V23Field vendorID;

public HL7V23Field VendorID
{
    get
    {
        if (vendorID != null)
        {
            return vendorID;
        }

        vendorID = new HL7V23Field
        {
            field = message[@"RQ1"][4],
            Id = @"RQ1.4",
            Type = @"Field",
            Position = @"RQ1.4",
            Name = @"Vendor ID",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.

Because of this, it is recommended that each nonstock item have RQ1-2-manufacturers ID and RQ1-3manufacturer’s catalog, or RQ1-4-vendor ID and RQ1-5-vendor catalog.  It is also possible that the requisitioning application will not know the identifier, as listed in the Manufacturer’s or Vendor’s catalog.  In this case, it is important to include the name portion of this coded element field.",
            Sample = @"",
        };

        

        

        

        return vendorID;
    } 
}
internal HL7V23Field vendorCatalog;

public HL7V23Field VendorCatalog
{
    get
    {
        if (vendorCatalog != null)
        {
            return vendorCatalog;
        }

        vendorCatalog = new HL7V23Field
        {
            field = message[@"RQ1"][5],
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
            Description = @"This field is the vendor’s catalog number, name, or code for this item.  This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer’s catalog or RQ1-4-vendor ID and RQ1-5vendor catalog must be valued.",
            Sample = @"",
        };

        

        

        

        return vendorCatalog;
    } 
}
internal HL7V23Field taxable;

public HL7V23Field Taxable
{
    get
    {
        if (taxable != null)
        {
            return taxable;
        }

        taxable = new HL7V23Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether this item is subject to tax.

In general, nonstock requisitioned items will be printed by the receiving application and then processed by a human.  In other words, the human will use the information to call the vendor or manufacturer to get pricing and other related purchasing information before placing the order with an outside vendor.",
            Sample = @"",
        };

        

        

        

        return taxable;
    } 
}
internal HL7V23Field substituteAllowed;

public HL7V23Field SubstituteAllowed
{
    get
    {
        if (substituteAllowed != null)
        {
            return substituteAllowed;
        }

        substituteAllowed = new HL7V23Field
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
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered.  Refer to HL7 table 0136 - Yes/no indicator ",
            Sample = @"",
        };

        

        

        

        return substituteAllowed;
    } 
}

    }
}

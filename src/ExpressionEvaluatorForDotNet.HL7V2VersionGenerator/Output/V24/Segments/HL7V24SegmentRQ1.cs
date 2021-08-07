using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRQ1
    {
        public readonly HL7V2Message message;

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
                            Description = @"This field contains the reference price for the requisition unit of measure that is known to the requisition application. It may or may not be the actual cost of acquiring the item from a supplier. It is also not the price charged to the patient.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field is the manufacturers catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field is the vendors catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
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
                            Description = @"This field indicates whether this item is subject to tax.",
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
                            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7table 0136 - Yes/no indicator as defined in Chapter 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field anticipatedPrice;

public HL7V24Field AnticipatedPrice
{
    get
    {
        if (anticipatedPrice != null)
        {
            return anticipatedPrice;
        }

        anticipatedPrice = new HL7V24Field
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
            Description = @"This field contains the reference price for the requisition unit of measure that is known to the requisition application. It may or may not be the actual cost of acquiring the item from a supplier. It is also not the price charged to the patient.",
            Sample = @"",
        };

        

        

        

        return anticipatedPrice;
    } 
}
internal HL7V24Field manufacturerIdentifier;

public HL7V24Field ManufacturerIdentifier
{
    get
    {
        if (manufacturerIdentifier != null)
        {
            return manufacturerIdentifier;
        }

        manufacturerIdentifier = new HL7V24Field
        {
            field = message[@"RQ1"][2],
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
        };

        

        

        

        return manufacturerIdentifier;
    } 
}
internal HL7V24Field manufacturer'sCatalog;

public HL7V24Field Manufacturer'sCatalog
{
    get
    {
        if (manufacturer'sCatalog != null)
        {
            return manufacturer'sCatalog;
        }

        manufacturer'sCatalog = new HL7V24Field
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
            Description = @"This field is the manufacturers catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        

        

        

        return manufacturer'sCatalog;
    } 
}
internal HL7V24Field vendorID;

public HL7V24Field VendorID
{
    get
    {
        if (vendorID != null)
        {
            return vendorID;
        }

        vendorID = new HL7V24Field
        {
            field = message[@"RQ1"][4],
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
        };

        

        

        

        return vendorID;
    } 
}
internal HL7V24Field vendorCatalog;

public HL7V24Field VendorCatalog
{
    get
    {
        if (vendorCatalog != null)
        {
            return vendorCatalog;
        }

        vendorCatalog = new HL7V24Field
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
            Description = @"This field is the vendors catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturers catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        

        

        

        return vendorCatalog;
    } 
}
internal HL7V24Field taxable;

public HL7V24Field Taxable
{
    get
    {
        if (taxable != null)
        {
            return taxable;
        }

        taxable = new HL7V24Field
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
            Description = @"This field indicates whether this item is subject to tax.",
            Sample = @"",
        };

        

        

        

        return taxable;
    } 
}
internal HL7V24Field substituteAllowed;

public HL7V24Field SubstituteAllowed
{
    get
    {
        if (substituteAllowed != null)
        {
            return substituteAllowed;
        }

        substituteAllowed = new HL7V24Field
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
            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7table 0136 - Yes/no indicator as defined in Chapter 2.",
            Sample = @"",
        };

        

        

        

        return substituteAllowed;
    } 
}

    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentRQ1
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
                            TableId = @"0385",
                            TableName = @"Manufacturer identifier",
                            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Description = @"This field is the manufacturer's catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
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
                            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
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
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            Description = @"This field is the vendor's catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
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
                            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7Table 0136 - Yes/No Indicator.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentRQ1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field anticipatedPrice;

public HL7V251Field AnticipatedPrice
{
    get
    {
        if (anticipatedPrice != null)
        {
            return anticipatedPrice;
        }

        anticipatedPrice = new HL7V251Field
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

        // check for repetitions
        if (anticipatedPrice.field.FieldRepetitions != null && anticipatedPrice.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(anticipatedPrice.Id));
            anticipatedPrice.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(anticipatedPrice, fieldData);
        }

        return anticipatedPrice;
    } 
}

internal HL7V251Field manufacturerIdentifier;

public HL7V251Field ManufacturerIdentifier
{
    get
    {
        if (manufacturerIdentifier != null)
        {
            return manufacturerIdentifier;
        }

        manufacturerIdentifier = new HL7V251Field
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
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field contains the unique code that identifies the manufacturer on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (manufacturerIdentifier.field.FieldRepetitions != null && manufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(manufacturerIdentifier.Id));
            manufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(manufacturerIdentifier, fieldData);
        }

        return manufacturerIdentifier;
    } 
}

internal HL7V251Field manufacturersCatalog;

public HL7V251Field ManufacturersCatalog
{
    get
    {
        if (manufacturersCatalog != null)
        {
            return manufacturersCatalog;
        }

        manufacturersCatalog = new HL7V251Field
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
            Description = @"This field is the manufacturer's catalog number or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (manufacturersCatalog.field.FieldRepetitions != null && manufacturersCatalog.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(manufacturersCatalog.Id));
            manufacturersCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(manufacturersCatalog, fieldData);
        }

        return manufacturersCatalog;
    } 
}

internal HL7V251Field vendorID;

public HL7V251Field VendorID
{
    get
    {
        if (vendorID != null)
        {
            return vendorID;
        }

        vendorID = new HL7V251Field
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
            Description = @"This field is the unique code that identifies the vendor on the application receiving the requisition. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (vendorID.field.FieldRepetitions != null && vendorID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vendorID.Id));
            vendorID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(vendorID, fieldData);
        }

        return vendorID;
    } 
}

internal HL7V251Field vendorCatalog;

public HL7V251Field VendorCatalog
{
    get
    {
        if (vendorCatalog != null)
        {
            return vendorCatalog;
        }

        vendorCatalog = new HL7V251Field
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
            Description = @"This field is the vendor's catalog number, name, or code for this item. This field is conditional because either RQ1-2-manufacturer ID and RQ1-3-manufacturer's catalog or RQ1-4-vendor ID and RQ1-5-vendor catalog must be valued.",
            Sample = @"",
        };

        // check for repetitions
        if (vendorCatalog.field.FieldRepetitions != null && vendorCatalog.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vendorCatalog.Id));
            vendorCatalog.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(vendorCatalog, fieldData);
        }

        return vendorCatalog;
    } 
}

internal HL7V251Field taxable;

public HL7V251Field Taxable
{
    get
    {
        if (taxable != null)
        {
            return taxable;
        }

        taxable = new HL7V251Field
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

        // check for repetitions
        if (taxable.field.FieldRepetitions != null && taxable.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(taxable.Id));
            taxable.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(taxable, fieldData);
        }

        return taxable;
    } 
}

internal HL7V251Field substituteAllowed;

public HL7V251Field SubstituteAllowed
{
    get
    {
        if (substituteAllowed != null)
        {
            return substituteAllowed;
        }

        substituteAllowed = new HL7V251Field
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
            Description = @"This field indicates whether the ancillary department may substitute an equivalent version of the item(s) ordered. Refer to HL7Table 0136 - Yes/No Indicator.",
            Sample = @"",
        };

        // check for repetitions
        if (substituteAllowed.field.FieldRepetitions != null && substituteAllowed.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(substituteAllowed.Id));
            substituteAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(substituteAllowed, fieldData);
        }

        return substituteAllowed;
    } 
}
    }
}

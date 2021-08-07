using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentILT
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"ILT"; } }

        public string SegmentId { get { return @"ILT"; } }
        
        public string LongName { get { return @"Material Lot Segment"; } }
        
        public string Description { get { return @"The Material Lot segment (ILT) contains material information specific to a lot within an inventory location associated with the item in the IVT segment. This segment is similar to the IIM segment used with the limited inventory item master message."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ILT.1",
                            Type = @"Field",
                            Position = @"ILT.1",
                            Name = @"Set Id - ILT",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.2",
                            Type = @"Field",
                            Position = @"ILT.2",
                            Name = @"Inventory Lot Number",
                            Length = 250,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the lot number of the service item in inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.3",
                            Type = @"Field",
                            Position = @"ILT.3",
                            Name = @"Inventory Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the expiration date of the service item in inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.4",
                            Type = @"Field",
                            Position = @"ILT.4",
                            Name = @"Inventory Received Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the most recent date that the product in question was received into inventory.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.5",
                            Type = @"Field",
                            Position = @"ILT.5",
                            Name = @"Inventory Received Quantity",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of this inventory item that was received on the date specific in ILT-4 - Inventory Received Date field.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.6",
                            Type = @"Field",
                            Position = @"ILT.6",
                            Name = @"Inventory Received Quantity Unit",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the unit for the Inventory Received Quantity. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ILT.6.1",
                            Type = @"Component",
                            Position = @"ILT.6.1",
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
                            Id = @"ILT.6.2",
                            Type = @"Component",
                            Position = @"ILT.6.2",
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
                            Id = @"ILT.6.3",
                            Type = @"Component",
                            Position = @"ILT.6.3",
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
                            Id = @"ILT.6.4",
                            Type = @"Component",
                            Position = @"ILT.6.4",
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
                            Id = @"ILT.6.5",
                            Type = @"Component",
                            Position = @"ILT.6.5",
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
                            Id = @"ILT.6.6",
                            Type = @"Component",
                            Position = @"ILT.6.6",
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
                            Id = @"ILT.6.7",
                            Type = @"Component",
                            Position = @"ILT.6.7",
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
                            Id = @"ILT.6.8",
                            Type = @"Component",
                            Position = @"ILT.6.8",
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
                            Id = @"ILT.6.9",
                            Type = @"Component",
                            Position = @"ILT.6.9",
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
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.7",
                            Type = @"Field",
                            Position = @"ILT.7",
                            Name = @"Inventory Received Item Cost",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the per-unit cost of the inventory item at the time of receipt. ILT-6 - Inventory Received Quantity Unit field specifies the per-unit basis of this field.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ILT.7.1",
                            Type = @"Component",
                            Position = @"ILT.7.1",
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
                            Id = @"ILT.7.2",
                            Type = @"Component",
                            Position = @"ILT.7.2",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.8",
                            Type = @"Field",
                            Position = @"ILT.8",
                            Name = @"Inventory On Hand Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the most recent date that an inventory count was performed for the inventory item.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.9",
                            Type = @"Field",
                            Position = @"ILT.9",
                            Name = @"Inventory On Hand Quantity",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in ILT-8 - Inventory on Hand Date field. No adjustment has been made for subsequent use.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ILT.10",
                            Type = @"Field",
                            Position = @"ILT.10",
                            Name = @"Inventory On Hand Quantity Unit",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in ILT-8 - Inventory on Hand Date field. No adjustment has been made for subsequent use. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"ILT.10.1",
                            Type = @"Component",
                            Position = @"ILT.10.1",
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
                            Id = @"ILT.10.2",
                            Type = @"Component",
                            Position = @"ILT.10.2",
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
                            Id = @"ILT.10.3",
                            Type = @"Component",
                            Position = @"ILT.10.3",
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
                            Id = @"ILT.10.4",
                            Type = @"Component",
                            Position = @"ILT.10.4",
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
                            Id = @"ILT.10.5",
                            Type = @"Component",
                            Position = @"ILT.10.5",
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
                            Id = @"ILT.10.6",
                            Type = @"Component",
                            Position = @"ILT.10.6",
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
                            Id = @"ILT.10.7",
                            Type = @"Component",
                            Position = @"ILT.10.7",
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
                            Id = @"ILT.10.8",
                            Type = @"Component",
                            Position = @"ILT.10.8",
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
                            Id = @"ILT.10.9",
                            Type = @"Component",
                            Position = @"ILT.10.9",
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
                        
                        },
                        };
            }
        }

        public HL7V26SegmentILT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIdILT;

public HL7V26Field SetIdILT
{
    get
    {
        if (setIdILT != null)
        {
            return setIdILT;
        }

        setIdILT = new HL7V26Field
        {
            field = message[@"ILT"][1],
            Id = @"ILT.1",
            Type = @"Field",
            Position = @"ILT.1",
            Name = @"Set Id - ILT",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc.",
            Sample = @"",
        };

        

        

        

        return setIdILT;
    } 
}
internal HL7V26Field inventoryLotNumber;

public HL7V26Field InventoryLotNumber
{
    get
    {
        if (inventoryLotNumber != null)
        {
            return inventoryLotNumber;
        }

        inventoryLotNumber = new HL7V26Field
        {
            field = message[@"ILT"][2],
            Id = @"ILT.2",
            Type = @"Field",
            Position = @"ILT.2",
            Name = @"Inventory Lot Number",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the service item in inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryLotNumber;
    } 
}
internal HL7V26Field inventoryExpirationDate;

public HL7V26Field InventoryExpirationDate
{
    get
    {
        if (inventoryExpirationDate != null)
        {
            return inventoryExpirationDate;
        }

        inventoryExpirationDate = new HL7V26Field
        {
            field = message[@"ILT"][3],
            Id = @"ILT.3",
            Type = @"Field",
            Position = @"ILT.3",
            Name = @"Inventory Expiration Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the service item in inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryExpirationDate;
    } 
}
internal HL7V26Field inventoryReceivedDate;

public HL7V26Field InventoryReceivedDate
{
    get
    {
        if (inventoryReceivedDate != null)
        {
            return inventoryReceivedDate;
        }

        inventoryReceivedDate = new HL7V26Field
        {
            field = message[@"ILT"][4],
            Id = @"ILT.4",
            Type = @"Field",
            Position = @"ILT.4",
            Name = @"Inventory Received Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the most recent date that the product in question was received into inventory.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedDate;
    } 
}
internal HL7V26Field inventoryReceivedQuantity;

public HL7V26Field InventoryReceivedQuantity
{
    get
    {
        if (inventoryReceivedQuantity != null)
        {
            return inventoryReceivedQuantity;
        }

        inventoryReceivedQuantity = new HL7V26Field
        {
            field = message[@"ILT"][5],
            Id = @"ILT.5",
            Type = @"Field",
            Position = @"ILT.5",
            Name = @"Inventory Received Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was received on the date specific in ILT-4 - Inventory Received Date field.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedQuantity;
    } 
}
internal HL7V26Field inventoryReceivedQuantityUnit;

public HL7V26Field InventoryReceivedQuantityUnit
{
    get
    {
        if (inventoryReceivedQuantityUnit != null)
        {
            return inventoryReceivedQuantityUnit;
        }

        inventoryReceivedQuantityUnit = new HL7V26Field
        {
            field = message[@"ILT"][6],
            Id = @"ILT.6",
            Type = @"Field",
            Position = @"ILT.6",
            Name = @"Inventory Received Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the unit for the Inventory Received Quantity. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedQuantityUnit;
    } 
}
internal HL7V26Field inventoryReceivedItemCost;

public HL7V26Field InventoryReceivedItemCost
{
    get
    {
        if (inventoryReceivedItemCost != null)
        {
            return inventoryReceivedItemCost;
        }

        inventoryReceivedItemCost = new HL7V26Field
        {
            field = message[@"ILT"][7],
            Id = @"ILT.7",
            Type = @"Field",
            Position = @"ILT.7",
            Name = @"Inventory Received Item Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"MO",
            DataTypeName = @"Money",
            TableId = null,
            TableName = null,
            Description = @"This field contains the per-unit cost of the inventory item at the time of receipt. ILT-6 - Inventory Received Quantity Unit field specifies the per-unit basis of this field.",
            Sample = @"",
        };

        

        

        

        return inventoryReceivedItemCost;
    } 
}
internal HL7V26Field inventoryOnHandDate;

public HL7V26Field InventoryOnHandDate
{
    get
    {
        if (inventoryOnHandDate != null)
        {
            return inventoryOnHandDate;
        }

        inventoryOnHandDate = new HL7V26Field
        {
            field = message[@"ILT"][8],
            Id = @"ILT.8",
            Type = @"Field",
            Position = @"ILT.8",
            Name = @"Inventory On Hand Date",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the most recent date that an inventory count was performed for the inventory item.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandDate;
    } 
}
internal HL7V26Field inventoryOnHandQuantity;

public HL7V26Field InventoryOnHandQuantity
{
    get
    {
        if (inventoryOnHandQuantity != null)
        {
            return inventoryOnHandQuantity;
        }

        inventoryOnHandQuantity = new HL7V26Field
        {
            field = message[@"ILT"][9],
            Id = @"ILT.9",
            Type = @"Field",
            Position = @"ILT.9",
            Name = @"Inventory On Hand Quantity",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in ILT-8 - Inventory on Hand Date field. No adjustment has been made for subsequent use.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandQuantity;
    } 
}
internal HL7V26Field inventoryOnHandQuantityUnit;

public HL7V26Field InventoryOnHandQuantityUnit
{
    get
    {
        if (inventoryOnHandQuantityUnit != null)
        {
            return inventoryOnHandQuantityUnit;
        }

        inventoryOnHandQuantityUnit = new HL7V26Field
        {
            field = message[@"ILT"][10],
            Id = @"ILT.10",
            Type = @"Field",
            Position = @"ILT.10",
            Name = @"Inventory On Hand Quantity Unit",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the quantity of this inventory item that was available for issue/use as of the date specified in ILT-8 - Inventory on Hand Date field. No adjustment has been made for subsequent use. See User-defined Table 0818 - Package in PKG-2 - Packaging Units for suggested values.",
            Sample = @"",
        };

        

        

        

        return inventoryOnHandQuantityUnit;
    } 
}

    }
}

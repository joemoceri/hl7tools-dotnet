using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentSLT
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"SLT"; } }

        public string SegmentId { get { return @"SLT"; } }
        
        public string LongName { get { return @"Sterilization Lot"; } }
        
        public string Description { get { return @"The SLT segment defines requests, responses, and notifications of sterilization lots and supply item descriptions.  This message may be used for CPD (Central Supply) and OR (Sub-sterile area outside of an Operating Room) mode."; } }
        
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
                            Id = @"SLT.1",
                            Type = @"Field",
                            Position = @"SLT.1",
                            Name = @"Device Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The unique identifier of the device (assigned by user, not assigned by the software application; e.g.: 01).",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SLT.1.1",
                            Type = @"Component",
                            Position = @"SLT.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"SLT.1.2",
                            Type = @"Component",
                            Position = @"SLT.1.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"See Section 2.A.33.1, ""Namespace ID (IS)"" for definition. The component intentionally remains associated with the IS data type in v 2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.1.3",
                            Type = @"Component",
                            Position = @"SLT.1.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.A.33.2, ""Universal ID (ST)"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.1.4",
                            Type = @"Component",
                            Position = @"SLT.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, ""Universal ID Type (ID),"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.2",
                            Type = @"Field",
                            Position = @"SLT.2",
                            Name = @"Device Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the device associated with the device number in SLT-1 (e.g., VAC).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.3",
                            Type = @"Field",
                            Position = @"SLT.3",
                            Name = @"Lot Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique number associated with an instance of a sterilization/decontamination cycle assigned by the instrument-tracking system.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SLT.3.1",
                            Type = @"Component",
                            Position = @"SLT.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"SLT.3.2",
                            Type = @"Component",
                            Position = @"SLT.3.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"See Section 2.A.33.1, ""Namespace ID (IS)"" for definition. The component intentionally remains associated with the IS data type in v 2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.3.3",
                            Type = @"Component",
                            Position = @"SLT.3.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.A.33.2, ""Universal ID (ST)"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.3.4",
                            Type = @"Component",
                            Position = @"SLT.3.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, ""Universal ID Type (ID),"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.4",
                            Type = @"Field",
                            Position = @"SLT.4",
                            Name = @"Item Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"The Item Identifier is a unique code assigned to the material item by the Instrument-tracking software application to identify the item being sterilized or decontaminated.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"SLT.4.1",
                            Type = @"Component",
                            Position = @"SLT.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
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
                            Id = @"SLT.4.2",
                            Type = @"Component",
                            Position = @"SLT.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"See Section 2.A.33.1, ""Namespace ID (IS)"" for definition. The component intentionally remains associated with the IS data type in v 2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.4.3",
                            Type = @"Component",
                            Position = @"SLT.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.A.33.2, ""Universal ID (ST)"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.4.4",
                            Type = @"Component",
                            Position = @"SLT.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"Refer to HL7 Table 0301 - Universal ID Type for valid values. See Section 2.A.33.3, ""Universal ID Type (ID),"" for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SLT.5",
                            Type = @"Field",
                            Position = @"SLT.5",
                            Name = @"Bar Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The special identification code, printed as a set of vertical bars of differing widths, used on instruments to identify them and provide for rapid, error-free input by a barcode scanning device.  The coding can include numbers, letters or a combination of both.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V28SegmentSLT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field deviceNumber;

public HL7V28Field DeviceNumber
{
    get
    {
        if (deviceNumber != null)
        {
            return deviceNumber;
        }

        deviceNumber = new HL7V28Field
        {
            field = message[@"SLT"][1],
            Id = @"SLT.1",
            Type = @"Field",
            Position = @"SLT.1",
            Name = @"Device Number",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The unique identifier of the device (assigned by user, not assigned by the software application; e.g.: 01).",
            Sample = @"",
        };

        

        

        

        return deviceNumber;
    } 
}
internal HL7V28Field deviceName;

public HL7V28Field DeviceName
{
    get
    {
        if (deviceName != null)
        {
            return deviceName;
        }

        deviceName = new HL7V28Field
        {
            field = message[@"SLT"][2],
            Id = @"SLT.2",
            Type = @"Field",
            Position = @"SLT.2",
            Name = @"Device Name",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the device associated with the device number in SLT-1 (e.g., VAC).",
            Sample = @"",
        };

        

        

        

        return deviceName;
    } 
}
internal HL7V28Field lotNumber;

public HL7V28Field LotNumber
{
    get
    {
        if (lotNumber != null)
        {
            return lotNumber;
        }

        lotNumber = new HL7V28Field
        {
            field = message[@"SLT"][3],
            Id = @"SLT.3",
            Type = @"Field",
            Position = @"SLT.3",
            Name = @"Lot Number",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"A unique number associated with an instance of a sterilization/decontamination cycle assigned by the instrument-tracking system.",
            Sample = @"",
        };

        

        

        

        return lotNumber;
    } 
}
internal HL7V28Field itemIdentifier;

public HL7V28Field ItemIdentifier
{
    get
    {
        if (itemIdentifier != null)
        {
            return itemIdentifier;
        }

        itemIdentifier = new HL7V28Field
        {
            field = message[@"SLT"][4],
            Id = @"SLT.4",
            Type = @"Field",
            Position = @"SLT.4",
            Name = @"Item Identifier",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The Item Identifier is a unique code assigned to the material item by the Instrument-tracking software application to identify the item being sterilized or decontaminated.",
            Sample = @"",
        };

        

        

        

        return itemIdentifier;
    } 
}
internal HL7V28Field barCode;

public HL7V28Field BarCode
{
    get
    {
        if (barCode != null)
        {
            return barCode;
        }

        barCode = new HL7V28Field
        {
            field = message[@"SLT"][5],
            Id = @"SLT.5",
            Type = @"Field",
            Position = @"SLT.5",
            Name = @"Bar Code",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The special identification code, printed as a set of vertical bars of differing widths, used on instruments to identify them and provide for rapid, error-free input by a barcode scanning device.  The coding can include numbers, letters or a combination of both.",
            Sample = @"",
        };

        

        

        

        return barCode;
    } 
}

    }
}

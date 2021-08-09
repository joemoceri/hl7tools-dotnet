using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentSLT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SLT"; } }

        public string SegmentId { get { return @"SLT"; } }
        
        public string LongName { get { return @"Sterilization Lot"; } }
        
        public string Description { get { return @"The SLT segment defines requests, responses, and notifications of sterilization lots and supply item descriptions.  This message may be used for CPD (Central Supply) and OR (Sub-sterile area outside of an Operating Room) mode.  "; } }
        
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

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
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

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
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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
                            FieldDatas = new []{new HL7V2FieldData
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
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

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
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
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
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
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

        public HL7V271SegmentSLT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field deviceNumber;

public HL7V271Field DeviceNumber
{
    get
    {
        if (deviceNumber != null)
        {
            return deviceNumber;
        }

        deviceNumber = new HL7V271Field
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

        // check for repetitions
        if (deviceNumber.field.FieldRepetitions != null && deviceNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deviceNumber.Id));
            deviceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(deviceNumber, fieldData);
        }

        return deviceNumber;
    } 
}

internal HL7V271Field deviceName;

public HL7V271Field DeviceName
{
    get
    {
        if (deviceName != null)
        {
            return deviceName;
        }

        deviceName = new HL7V271Field
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

        // check for repetitions
        if (deviceName.field.FieldRepetitions != null && deviceName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deviceName.Id));
            deviceName.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(deviceName, fieldData);
        }

        return deviceName;
    } 
}

internal HL7V271Field lotNumber;

public HL7V271Field LotNumber
{
    get
    {
        if (lotNumber != null)
        {
            return lotNumber;
        }

        lotNumber = new HL7V271Field
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

        // check for repetitions
        if (lotNumber.field.FieldRepetitions != null && lotNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(lotNumber.Id));
            lotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(lotNumber, fieldData);
        }

        return lotNumber;
    } 
}

internal HL7V271Field itemIdentifier;

public HL7V271Field ItemIdentifier
{
    get
    {
        if (itemIdentifier != null)
        {
            return itemIdentifier;
        }

        itemIdentifier = new HL7V271Field
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

        // check for repetitions
        if (itemIdentifier.field.FieldRepetitions != null && itemIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(itemIdentifier.Id));
            itemIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(itemIdentifier, fieldData);
        }

        return itemIdentifier;
    } 
}

internal HL7V271Field barCode;

public HL7V271Field BarCode
{
    get
    {
        if (barCode != null)
        {
            return barCode;
        }

        barCode = new HL7V271Field
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

        // check for repetitions
        if (barCode.field.FieldRepetitions != null && barCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(barCode.Id));
            barCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(barCode, fieldData);
        }

        return barCode;
    } 
}
    }
}

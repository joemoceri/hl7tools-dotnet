using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentSID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SID"; } }

        public string SegmentId { get { return @"SID"; } }
        
        public string LongName { get { return @"Substance Identifier"; } }
        
        public string Description { get { return @"The Substance Identifier segment contains data necessary to identify the substance (e.g., reagents) used in the production of analytical test results. The combination of these fields must uniquely identify the substance, i.e., depending on the manufacturer all or some fields are required (this is the reason the optionality is C (conditional)). If the analysis requires multiple substances, this segment is repeated for each substance. The segment(s) should be attached to the TCD segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V24SegmentSID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _applicationMethodIdentifier;

public HL7V24Field ApplicationMethodIdentifier
{
    get
    {
        if (_applicationMethodIdentifier != null)
        {
            return _applicationMethodIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"SID.1",
            Type = @"Field",
            Position = @"SID.1",
            Name = @"Application / Method Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the application / method used for the analysis",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SID.1.1",
                            Type = @"Component",
                            Position = @"SID.1.1",
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
                            Id = @"SID.1.2",
                            Type = @"Component",
                            Position = @"SID.1.2",
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
                            Id = @"SID.1.3",
                            Type = @"Component",
                            Position = @"SID.1.3",
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
                            Id = @"SID.1.4",
                            Type = @"Component",
                            Position = @"SID.1.4",
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
                            Id = @"SID.1.5",
                            Type = @"Component",
                            Position = @"SID.1.5",
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
                            Id = @"SID.1.6",
                            Type = @"Component",
                            Position = @"SID.1.6",
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

        _applicationMethodIdentifier = new HL7V24Field
        {
            field = message[@"SID"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationMethodIdentifier.field.FieldRepetitions != null && _applicationMethodIdentifier.field.FieldRepetitions.Count > 0)
        {
            _applicationMethodIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_applicationMethodIdentifier, fieldData);
        }

        return _applicationMethodIdentifier;
    } 
}

internal HL7V24Field _substanceLotNumber;

public HL7V24Field SubstanceLotNumber
{
    get
    {
        if (_substanceLotNumber != null)
        {
            return _substanceLotNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"SID.2",
            Type = @"Field",
            Position = @"SID.2",
            Name = @"Substance Lot Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the lot number assigned by the manufacturer during production of the substance",
            Sample = @"",
            Fields = null
        }

        _substanceLotNumber = new HL7V24Field
        {
            field = message[@"SID"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceLotNumber.field.FieldRepetitions != null && _substanceLotNumber.field.FieldRepetitions.Count > 0)
        {
            _substanceLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceLotNumber, fieldData);
        }

        return _substanceLotNumber;
    } 
}

internal HL7V24Field _substanceContainerIdentifier;

public HL7V24Field SubstanceContainerIdentifier
{
    get
    {
        if (_substanceContainerIdentifier != null)
        {
            return _substanceContainerIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"SID.3",
            Type = @"Field",
            Position = @"SID.3",
            Name = @"Substance Container Identifier",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the container assigned by the manufacturer during production of the substance.  This identifier should be unique within specific lot of specific application / method",
            Sample = @"",
            Fields = null
        }

        _substanceContainerIdentifier = new HL7V24Field
        {
            field = message[@"SID"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceContainerIdentifier.field.FieldRepetitions != null && _substanceContainerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _substanceContainerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceContainerIdentifier, fieldData);
        }

        return _substanceContainerIdentifier;
    } 
}

internal HL7V24Field _substanceManufacturerIdentifier;

public HL7V24Field SubstanceManufacturerIdentifier
{
    get
    {
        if (_substanceManufacturerIdentifier != null)
        {
            return _substanceManufacturerIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"SID.4",
            Type = @"Field",
            Position = @"SID.4",
            Name = @"Substance Manufacturer Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0385",
            TableName = @"Manufacturer identifier",
            Description = @"This field identifies the manufacturer of this substance. Refer to User-defined Table 0451 Manufacturer identifier for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SID.4.1",
                            Type = @"Component",
                            Position = @"SID.4.1",
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
                            Id = @"SID.4.2",
                            Type = @"Component",
                            Position = @"SID.4.2",
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
                            Id = @"SID.4.3",
                            Type = @"Component",
                            Position = @"SID.4.3",
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
                            Id = @"SID.4.4",
                            Type = @"Component",
                            Position = @"SID.4.4",
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
                            Id = @"SID.4.5",
                            Type = @"Component",
                            Position = @"SID.4.5",
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
                            Id = @"SID.4.6",
                            Type = @"Component",
                            Position = @"SID.4.6",
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

        _substanceManufacturerIdentifier = new HL7V24Field
        {
            field = message[@"SID"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceManufacturerIdentifier.field.FieldRepetitions != null && _substanceManufacturerIdentifier.field.FieldRepetitions.Count > 0)
        {
            _substanceManufacturerIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceManufacturerIdentifier, fieldData);
        }

        return _substanceManufacturerIdentifier;
    } 
}
    }
}

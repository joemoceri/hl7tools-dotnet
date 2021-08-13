using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRXC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXC"; } }

        public string SegmentId { get { return @"RXC"; } }
        
        public string LongName { get { return @"Pharmacy/Treatment Component Order"; } }
        
        public string Description { get { return @"If the drug or treatment ordered with the RXO segment is a compound drug OR an IV solution, AND there is not a coded value for OBR-4-universal service ID , which specifies the components (base and all additives), then the components (the base and additives) are specified by two or more RXC segments. The policy of the pharmacy or treatment application on substitutions at the RXC level is identical to that for the RXO level."; } }
        
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

        public HL7V24SegmentRXC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _rXComponentType;

public HL7V24Field RXComponentType
{
    get
    {
        if (_rXComponentType != null)
        {
            return _rXComponentType;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.1",
            Type = @"Field",
            Position = @"RXC.1",
            Name = @"RX Component Type",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0166",
            TableName = @"RX component type",
            Description = @"Following are the values for this field : HL7 Table 0166 - RX component type",
            Sample = @"",
            Fields = null
        }

        _rXComponentType = new HL7V24Field
        {
            field = message[@"RXC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rXComponentType.field.FieldRepetitions != null && _rXComponentType.field.FieldRepetitions.Count > 0)
        {
            _rXComponentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_rXComponentType, fieldData);
        }

        return _rXComponentType;
    } 
}

internal HL7V24Field _componentCode;

public HL7V24Field ComponentCode
{
    get
    {
        if (_componentCode != null)
        {
            return _componentCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.2",
            Type = @"Field",
            Position = @"RXC.2",
            Name = @"Component Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is equivalent to OBR-4-universal service ID.  It defines the base or component in the same manner as the give and dispense codes.  As with the give and dispense codes, it may contain text only, code only, text + code, or text + code + units (implied or explicit).  As with the give and dispense codes, if RXC-4-component units is present, this overrides the units implied by the code.  If only text is present, the pharmacy or treatment application must include a manual review or reentering of the component drug or treatment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.2.1",
                            Type = @"Component",
                            Position = @"RXC.2.1",
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
                            Id = @"RXC.2.2",
                            Type = @"Component",
                            Position = @"RXC.2.2",
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
                            Id = @"RXC.2.3",
                            Type = @"Component",
                            Position = @"RXC.2.3",
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
                            Id = @"RXC.2.4",
                            Type = @"Component",
                            Position = @"RXC.2.4",
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
                            Id = @"RXC.2.5",
                            Type = @"Component",
                            Position = @"RXC.2.5",
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
                            Id = @"RXC.2.6",
                            Type = @"Component",
                            Position = @"RXC.2.6",
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

        _componentCode = new HL7V24Field
        {
            field = message[@"RXC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentCode.field.FieldRepetitions != null && _componentCode.field.FieldRepetitions.Count > 0)
        {
            _componentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_componentCode, fieldData);
        }

        return _componentCode;
    } 
}

internal HL7V24Field _componentAmount;

public HL7V24Field ComponentAmount
{
    get
    {
        if (_componentAmount != null)
        {
            return _componentAmount;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.3",
            Type = @"Field",
            Position = @"RXC.3",
            Name = @"Component Amount",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the amount of this component to be added to the specified amount of the base.",
            Sample = @"",
            Fields = null
        }

        _componentAmount = new HL7V24Field
        {
            field = message[@"RXC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentAmount.field.FieldRepetitions != null && _componentAmount.field.FieldRepetitions.Count > 0)
        {
            _componentAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_componentAmount, fieldData);
        }

        return _componentAmount;
    } 
}

internal HL7V24Field _componentUnits;

public HL7V24Field ComponentUnits
{
    get
    {
        if (_componentUnits != null)
        {
            return _componentUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.4",
            Type = @"Field",
            Position = @"RXC.4",
            Name = @"Component Units",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the units for the component amount.  If present, this overrides the units implied by RXC-2-component code.  This must be in simple units that reflect the actual quantity of the component being added.  It does not include compound units",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.4.1",
                            Type = @"Component",
                            Position = @"RXC.4.1",
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
                            Id = @"RXC.4.2",
                            Type = @"Component",
                            Position = @"RXC.4.2",
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
                            Id = @"RXC.4.3",
                            Type = @"Component",
                            Position = @"RXC.4.3",
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
                            Id = @"RXC.4.4",
                            Type = @"Component",
                            Position = @"RXC.4.4",
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
                            Id = @"RXC.4.5",
                            Type = @"Component",
                            Position = @"RXC.4.5",
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
                            Id = @"RXC.4.6",
                            Type = @"Component",
                            Position = @"RXC.4.6",
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

        _componentUnits = new HL7V24Field
        {
            field = message[@"RXC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentUnits.field.FieldRepetitions != null && _componentUnits.field.FieldRepetitions.Count > 0)
        {
            _componentUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_componentUnits, fieldData);
        }

        return _componentUnits;
    } 
}

internal HL7V24Field _componentStrength;

public HL7V24Field ComponentStrength
{
    get
    {
        if (_componentStrength != null)
        {
            return _componentStrength;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.5",
            Type = @"Field",
            Position = @"RXC.5",
            Name = @"Component Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use when RXC-2-component code does not specify the strength.  This is the numeric part of the strength, used in combination with RXC-6-component strength units",
            Sample = @"",
            Fields = null
        }

        _componentStrength = new HL7V24Field
        {
            field = message[@"RXC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentStrength.field.FieldRepetitions != null && _componentStrength.field.FieldRepetitions.Count > 0)
        {
            _componentStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_componentStrength, fieldData);
        }

        return _componentStrength;
    } 
}

internal HL7V24Field _componentStrengthUnits;

public HL7V24Field ComponentStrengthUnits
{
    get
    {
        if (_componentStrengthUnits != null)
        {
            return _componentStrengthUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.6",
            Type = @"Field",
            Position = @"RXC.6",
            Name = @"Component Strength Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when RXC-2-component code does not specify the strength.  This is the unit of the strength, used in combination with RXC-5-component strength",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.6.1",
                            Type = @"Component",
                            Position = @"RXC.6.1",
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
                            Id = @"RXC.6.2",
                            Type = @"Component",
                            Position = @"RXC.6.2",
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
                            Id = @"RXC.6.3",
                            Type = @"Component",
                            Position = @"RXC.6.3",
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
                            Id = @"RXC.6.4",
                            Type = @"Component",
                            Position = @"RXC.6.4",
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
                            Id = @"RXC.6.5",
                            Type = @"Component",
                            Position = @"RXC.6.5",
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
                            Id = @"RXC.6.6",
                            Type = @"Component",
                            Position = @"RXC.6.6",
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

        _componentStrengthUnits = new HL7V24Field
        {
            field = message[@"RXC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentStrengthUnits.field.FieldRepetitions != null && _componentStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _componentStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_componentStrengthUnits, fieldData);
        }

        return _componentStrengthUnits;
    } 
}

internal HL7V24Field _supplementaryCode;

public HL7V24Field SupplementaryCode
{
    get
    {
        if (_supplementaryCode != null)
        {
            return _supplementaryCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXC.7",
            Type = @"Field",
            Position = @"RXC.7",
            Name = @"Supplementary Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field accommodates the identification of any codes that might be associated with the pharmaceutical or other treatment substance. Common codes include: the Generic Product Identifier (GPI), Generic Code Number_Sequence Number (GCN_SEQNO), National Drug Code (NDC).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.7.1",
                            Type = @"Component",
                            Position = @"RXC.7.1",
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
                            Id = @"RXC.7.2",
                            Type = @"Component",
                            Position = @"RXC.7.2",
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
                            Id = @"RXC.7.3",
                            Type = @"Component",
                            Position = @"RXC.7.3",
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
                            Id = @"RXC.7.4",
                            Type = @"Component",
                            Position = @"RXC.7.4",
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
                            Id = @"RXC.7.5",
                            Type = @"Component",
                            Position = @"RXC.7.5",
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
                            Id = @"RXC.7.6",
                            Type = @"Component",
                            Position = @"RXC.7.6",
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

        _supplementaryCode = new HL7V24Field
        {
            field = message[@"RXC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_supplementaryCode.field.FieldRepetitions != null && _supplementaryCode.field.FieldRepetitions.Count > 0)
        {
            _supplementaryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_supplementaryCode, fieldData);
        }

        return _supplementaryCode;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentRXC
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

        public HL7V251SegmentRXC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _rXComponentType;

public HL7V251Field RXComponentType
{
    get
    {
        if (_rXComponentType != null)
        {
            return _rXComponentType;
        }

        var fieldData = new HL7V251FieldData
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
            TableName = @"RX Component Type",
            Description = @" Refer To UHL7 Table 0166 - RX Component Type for valid values. 

For the non-IV case, the ""B"" value may still apply.  For example, if a custom dermatologic salve is being prepared, the ""B"" item might be a standard base ointment into which other components are mixed. 

The amount of the ""base"" specified in the ""B"" segment(s) is defined to be the quantity into which amounts specified in the ""A"" components are mixed.  Thus the RXC segments as a group define the ""recipe"" for a particular amount (defined by the base segment(s)).  The give amount, as defined in the RXO, does not need to correspond to this base amount.  For example, the RXC segments may specify a recipe for a liter of a standard type of saline with 1 gram of a particular antimicrobial, while the give amount (from the RXO) may specify the administration of 2 liters of this IV-solution every 24 hours. 

The amount specified in each ""A"" segment is defined to be the quantity to be added to the amount of the base as specified in its RXC segment. 

If any ""base"" components are present then these should be transmitted first.  The first ""base"" component in the transmission should be considered the ""primary base"" if such a distinction is necessary.  Similarly, the first ""additive"" in the transmission should be considered the ""primary additive"" if such a distinction is necessary. ",
            Sample = @"",
            Fields = null
        }

        _rXComponentType = new HL7V251Field
        {
            field = message[@"RXC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rXComponentType.field.FieldRepetitions != null && _rXComponentType.field.FieldRepetitions.Count > 0)
        {
            _rXComponentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_rXComponentType, fieldData);
        }

        return _rXComponentType;
    } 
}

internal HL7V251Field _componentCode;

public HL7V251Field ComponentCode
{
    get
    {
        if (_componentCode != null)
        {
            return _componentCode;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field is equivalent to OBR-4-universal service ID . It defines the base or component in the same manner as the give and dispense codes. As with the give and dispense codes, it may contain text only, code only, text + code, or text + code + units (implied or explicit). As with the give and dispense codes, if RXC-4-component units is present, this overrides the units implied by the code. If only text is present, the pharmacy or treatment application must include a manual review or reentering of the component drug or treatment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.2.1",
                            Type = @"Component",
                            Position = @"RXC.2.1",
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
                            Id = @"RXC.2.2",
                            Type = @"Component",
                            Position = @"RXC.2.2",
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
                            Id = @"RXC.2.3",
                            Type = @"Component",
                            Position = @"RXC.2.3",
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
                            Id = @"RXC.2.4",
                            Type = @"Component",
                            Position = @"RXC.2.4",
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
                            Id = @"RXC.2.5",
                            Type = @"Component",
                            Position = @"RXC.2.5",
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
                            Id = @"RXC.2.6",
                            Type = @"Component",
                            Position = @"RXC.2.6",
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
                        },
                        }
        }

        _componentCode = new HL7V251Field
        {
            field = message[@"RXC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentCode.field.FieldRepetitions != null && _componentCode.field.FieldRepetitions.Count > 0)
        {
            _componentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentCode, fieldData);
        }

        return _componentCode;
    } 
}

internal HL7V251Field _componentAmount;

public HL7V251Field ComponentAmount
{
    get
    {
        if (_componentAmount != null)
        {
            return _componentAmount;
        }

        var fieldData = new HL7V251FieldData
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

        _componentAmount = new HL7V251Field
        {
            field = message[@"RXC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentAmount.field.FieldRepetitions != null && _componentAmount.field.FieldRepetitions.Count > 0)
        {
            _componentAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentAmount, fieldData);
        }

        return _componentAmount;
    } 
}

internal HL7V251Field _componentUnits;

public HL7V251Field ComponentUnits
{
    get
    {
        if (_componentUnits != null)
        {
            return _componentUnits;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field identifies the units for the component amount. If present, this overrides the units implied by RXC-2-component code . This must be in simple units that reflect the actual quantity of the component being added. It does not include compound units.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.4.1",
                            Type = @"Component",
                            Position = @"RXC.4.1",
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
                            Id = @"RXC.4.2",
                            Type = @"Component",
                            Position = @"RXC.4.2",
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
                            Id = @"RXC.4.3",
                            Type = @"Component",
                            Position = @"RXC.4.3",
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
                            Id = @"RXC.4.4",
                            Type = @"Component",
                            Position = @"RXC.4.4",
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
                            Id = @"RXC.4.5",
                            Type = @"Component",
                            Position = @"RXC.4.5",
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
                            Id = @"RXC.4.6",
                            Type = @"Component",
                            Position = @"RXC.4.6",
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
                        },
                        }
        }

        _componentUnits = new HL7V251Field
        {
            field = message[@"RXC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentUnits.field.FieldRepetitions != null && _componentUnits.field.FieldRepetitions.Count > 0)
        {
            _componentUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentUnits, fieldData);
        }

        return _componentUnits;
    } 
}

internal HL7V251Field _componentStrength;

public HL7V251Field ComponentStrength
{
    get
    {
        if (_componentStrength != null)
        {
            return _componentStrength;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"Use when RXC-2-component code does not specify the strength. This is the numeric part of the strength, used in combination with RXC-6-component strength units.",
            Sample = @"",
            Fields = null
        }

        _componentStrength = new HL7V251Field
        {
            field = message[@"RXC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentStrength.field.FieldRepetitions != null && _componentStrength.field.FieldRepetitions.Count > 0)
        {
            _componentStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentStrength, fieldData);
        }

        return _componentStrength;
    } 
}

internal HL7V251Field _componentStrengthUnits;

public HL7V251Field ComponentStrengthUnits
{
    get
    {
        if (_componentStrengthUnits != null)
        {
            return _componentStrengthUnits;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"Use when RXC-2-component code does not specify the strength. This is the unit of the strength, used in combination with RXC-5-component strength.

Note:  These units can be a ""compound quantity;"" i.e., the units may express a quantity per unit of time.  For example, micrograms per hour (micg/h) is an acceptable value.  These compound units are contained in the ISO+ table.  See Chapter 7 for full definition of ISO+ units. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.6.1",
                            Type = @"Component",
                            Position = @"RXC.6.1",
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
                            Id = @"RXC.6.2",
                            Type = @"Component",
                            Position = @"RXC.6.2",
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
                            Id = @"RXC.6.3",
                            Type = @"Component",
                            Position = @"RXC.6.3",
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
                            Id = @"RXC.6.4",
                            Type = @"Component",
                            Position = @"RXC.6.4",
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
                            Id = @"RXC.6.5",
                            Type = @"Component",
                            Position = @"RXC.6.5",
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
                            Id = @"RXC.6.6",
                            Type = @"Component",
                            Position = @"RXC.6.6",
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
                        },
                        }
        }

        _componentStrengthUnits = new HL7V251Field
        {
            field = message[@"RXC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentStrengthUnits.field.FieldRepetitions != null && _componentStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _componentStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentStrengthUnits, fieldData);
        }

        return _componentStrengthUnits;
    } 
}

internal HL7V251Field _supplementaryCode;

public HL7V251Field SupplementaryCode
{
    get
    {
        if (_supplementaryCode != null)
        {
            return _supplementaryCode;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field accommodates the identification of any codes that might be associated with the pharmaceutical or other treatment substance. Common codes include: the Generic Product Identifier (GPI), Generic Code Number_Sequence Number (GCN_SEQNO), National Drug Code (NDC). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.7.1",
                            Type = @"Component",
                            Position = @"RXC.7.1",
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
                            Id = @"RXC.7.2",
                            Type = @"Component",
                            Position = @"RXC.7.2",
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
                            Id = @"RXC.7.3",
                            Type = @"Component",
                            Position = @"RXC.7.3",
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
                            Id = @"RXC.7.4",
                            Type = @"Component",
                            Position = @"RXC.7.4",
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
                            Id = @"RXC.7.5",
                            Type = @"Component",
                            Position = @"RXC.7.5",
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
                            Id = @"RXC.7.6",
                            Type = @"Component",
                            Position = @"RXC.7.6",
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
                        },
                        }
        }

        _supplementaryCode = new HL7V251Field
        {
            field = message[@"RXC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_supplementaryCode.field.FieldRepetitions != null && _supplementaryCode.field.FieldRepetitions.Count > 0)
        {
            _supplementaryCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_supplementaryCode, fieldData);
        }

        return _supplementaryCode;
    } 
}

internal HL7V251Field _componentDrugStrengthVolume;

public HL7V251Field ComponentDrugStrengthVolume
{
    get
    {
        if (_componentDrugStrengthVolume != null)
        {
            return _componentDrugStrengthVolume;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"RXC.8",
            Type = @"Field",
            Position = @"RXC.8",
            Name = @"Component Drug Strength Volume",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This numeric field defines the volume measurement in which the drug strength concentration is contained.",
            Sample = @"",
            Fields = null
        }

        _componentDrugStrengthVolume = new HL7V251Field
        {
            field = message[@"RXC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentDrugStrengthVolume.field.FieldRepetitions != null && _componentDrugStrengthVolume.field.FieldRepetitions.Count > 0)
        {
            _componentDrugStrengthVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentDrugStrengthVolume, fieldData);
        }

        return _componentDrugStrengthVolume;
    } 
}

internal HL7V251Field _componentDrugStrengthVolumeUnits;

public HL7V251Field ComponentDrugStrengthVolumeUnits
{
    get
    {
        if (_componentDrugStrengthVolumeUnits != null)
        {
            return _componentDrugStrengthVolumeUnits;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"RXC.9",
            Type = @"Field",
            Position = @"RXC.9",
            Name = @"Component Drug Strength Volume Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the volumetric unit associated with RXC-8 Component Drug Strength Volume.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXC.9.1",
                            Type = @"Component",
                            Position = @"RXC.9.1",
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
                            Id = @"RXC.9.2",
                            Type = @"Component",
                            Position = @"RXC.9.2",
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
                            Id = @"RXC.9.3",
                            Type = @"Component",
                            Position = @"RXC.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXC.9.4",
                            Type = @"Component",
                            Position = @"RXC.9.4",
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
                            Id = @"RXC.9.5",
                            Type = @"Component",
                            Position = @"RXC.9.5",
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
                            Id = @"RXC.9.6",
                            Type = @"Component",
                            Position = @"RXC.9.6",
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
                            Id = @"RXC.9.7",
                            Type = @"Component",
                            Position = @"RXC.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXC.9.8",
                            Type = @"Component",
                            Position = @"RXC.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXC.9.9",
                            Type = @"Component",
                            Position = @"RXC.9.9",
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
                        }
        }

        _componentDrugStrengthVolumeUnits = new HL7V251Field
        {
            field = message[@"RXC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentDrugStrengthVolumeUnits.field.FieldRepetitions != null && _componentDrugStrengthVolumeUnits.field.FieldRepetitions.Count > 0)
        {
            _componentDrugStrengthVolumeUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_componentDrugStrengthVolumeUnits, fieldData);
        }

        return _componentDrugStrengthVolumeUnits;
    } 
}
    }
}

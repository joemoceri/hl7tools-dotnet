using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXC"; } }

        public string SegmentId { get { return @"RXC"; } }
        
        public string LongName { get { return @"Pharmacy Component Order"; } }
        
        public string Description { get { return @"If the drug ordered with the RXO segment is a compound drug OR an IV solution, AND there is not a coded value for the Universal Service ID which specifies the components (base and all additives), then the components (the base and additives) are specified by two or more RXC segments.  The policy of the Pharmacy application on substitutions at the RXC level is identical to that for the RXO level. "; } }
        
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

        public HL7V22SegmentRXC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _rxComponentType;

public HL7V22Field RxComponentType
{
    get
    {
        if (_rxComponentType != null)
        {
            return _rxComponentType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXC.1",
            Type = @"Field",
            Position = @"RXC.1",
            Name = @"Rx Component Type",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0166",
            TableName = @"RX COMPONENT TYPE",
            Description = @"For the non-IV case, the ""B"" value may still apply.  For example, if a custom dermatologic salve is being prepared, the ""B"" item might be a standard base ointment into which other components are mixed. 
 
The amount of the ""base"" specified in the ""B"" segment(s) is defined to be the quantity into which amounts specified in the ""A"" components are mixed.  Thus the RXC segments as a group define the ""recipe"" for a particular amount (defined by the base segment(s)).  The give amount, as defined in the RXO, does not need to correspond to this base amount.  For example, the RXC segments may specify a recipe for a liter of a standard type of saline with 1 gram of a particular antibiotic, while the give amount (from the RXO) may specify the administration of 2 liters of this IV-solution every 24 hours. 
 
The amount specified in each ""A"" segment is defined to be the quantity to be added to the amount of the base as specified in its RXC segment. 
 
If any ""base"" components are present then these should be transmitted first.  The first ""base"" component in the transmission should be considered the ""primary base"" if such a distinction is necessary.  Similarly, the first ""additive"" in the transmission should be considered the ""primary additive"" if such a distinction is necessary.",
            Sample = @"",
            Fields = null
        }

        _rxComponentType = new HL7V22Field
        {
            field = message[@"RXC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rxComponentType.field.FieldRepetitions != null && _rxComponentType.field.FieldRepetitions.Count > 0)
        {
            _rxComponentType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rxComponentType, fieldData);
        }

        return _rxComponentType;
    } 
}

internal HL7V22Field _componentCode;

public HL7V22Field ComponentCode
{
    get
    {
        if (_componentCode != null)
        {
            return _componentCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXC.2",
            Type = @"Field",
            Position = @"RXC.2",
            Name = @"Component Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"equivalent to OBR-4-universal service ID.  It defines the base or component in the same manner as the give and dispense codes.  As with the give and dispense codes, it may contain text only, code only, text + code, or text + code + units (implied or explicit).  As with the give and dispense codes, if RXC-4component units is present, this overrides the units implied by the code.  If only text is present, the Pharmacy application must include a manual review or reentering of the component drug",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _componentCode = new HL7V22Field
        {
            field = message[@"RXC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentCode.field.FieldRepetitions != null && _componentCode.field.FieldRepetitions.Count > 0)
        {
            _componentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_componentCode, fieldData);
        }

        return _componentCode;
    } 
}

internal HL7V22Field _componentAmount;

public HL7V22Field ComponentAmount
{
    get
    {
        if (_componentAmount != null)
        {
            return _componentAmount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"amount of this component to be added to the specified amount of the base.",
            Sample = @"",
            Fields = null
        }

        _componentAmount = new HL7V22Field
        {
            field = message[@"RXC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentAmount.field.FieldRepetitions != null && _componentAmount.field.FieldRepetitions.Count > 0)
        {
            _componentAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_componentAmount, fieldData);
        }

        return _componentAmount;
    } 
}

internal HL7V22Field _componentUnits;

public HL7V22Field ComponentUnits
{
    get
    {
        if (_componentUnits != null)
        {
            return _componentUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXC.4",
            Type = @"Field",
            Position = @"RXC.4",
            Name = @"Component Units",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"units for the component amount.  If present, this overrides the units implied by RXC-2-component code.  This must be in simple units that reflect the actual quantity of the component being added.  It does not include compound units.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _componentUnits = new HL7V22Field
        {
            field = message[@"RXC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_componentUnits.field.FieldRepetitions != null && _componentUnits.field.FieldRepetitions.Count > 0)
        {
            _componentUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_componentUnits, fieldData);
        }

        return _componentUnits;
    } 
}
    }
}

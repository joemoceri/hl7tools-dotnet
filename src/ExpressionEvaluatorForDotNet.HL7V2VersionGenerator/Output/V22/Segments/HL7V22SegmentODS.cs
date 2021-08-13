using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentODS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ODS"; } }

        public string SegmentId { get { return @"ODS"; } }
        
        public string LongName { get { return @"Dietary Orders, Supplements, And Preferences"; } }
        
        public string Description { get { return @"The ORC sequence items of interest to ODS are ORC-1-order control,ORC-2-placer order number, ORC-3-filler order number, ORC-7-quantity/timing, ORC-9-date/time of transaction, ORC-10-entered by, and ORC-11verified by.  For ORC-1-order control, the values may be New (NW), Cancel (CA), Discontinue Order Request (DC), Change (XO), Hold Order Request (HD), and Release Previous Hold (RL).  The HD and RL codes could stop service for a specified length of time.  ORC-4-quantity/timing should be used to specify whether an order is continuous or for one service period only.  It is also useful for supplements which are part of a diet but only delivered, say, every day at night"; } }
        
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

        public HL7V22SegmentODS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _type;

public HL7V22Field Type
{
    get
    {
        if (_type != null)
        {
            return _type;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ODS.1",
            Type = @"Field",
            Position = @"ODS.1",
            Name = @"Type",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0159",
            TableName = @"DIET TYPE",
            Description = @"specifies type of diet.  Refer to table 0159-diet type for valid entries",
            Sample = @"",
            Fields = null
        }

        _type = new HL7V22Field
        {
            field = message[@"ODS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_type.field.FieldRepetitions != null && _type.field.FieldRepetitions.Count > 0)
        {
            _type.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_type, fieldData);
        }

        return _type;
    } 
}

internal HL7V22Field _servicePeriod;

public HL7V22Field ServicePeriod
{
    get
    {
        if (_servicePeriod != null)
        {
            return _servicePeriod;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ODS.2",
            Type = @"Field",
            Position = @"ODS.2",
            Name = @"Service Period",
            Length = 60,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"when blank, the modifier applies to all service periods.  Diet orders, for example, typically apply to all service periods.  This field usually specifies supplements.  This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed.  The service periods will be local CEs, normally numbers",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODS.2.1",
                            Type = @"Component",
                            Position = @"ODS.2.1",
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
                            Id = @"ODS.2.2",
                            Type = @"Component",
                            Position = @"ODS.2.2",
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
                            Id = @"ODS.2.3",
                            Type = @"Component",
                            Position = @"ODS.2.3",
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
                            Id = @"ODS.2.4",
                            Type = @"Component",
                            Position = @"ODS.2.4",
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
                            Id = @"ODS.2.5",
                            Type = @"Component",
                            Position = @"ODS.2.5",
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
                            Id = @"ODS.2.6",
                            Type = @"Component",
                            Position = @"ODS.2.6",
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

        _servicePeriod = new HL7V22Field
        {
            field = message[@"ODS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicePeriod.field.FieldRepetitions != null && _servicePeriod.field.FieldRepetitions.Count > 0)
        {
            _servicePeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_servicePeriod, fieldData);
        }

        return _servicePeriod;
    } 
}

internal HL7V22Field _dietSupplementOrPreferenceCode;

public HL7V22Field DietSupplementOrPreferenceCode
{
    get
    {
        if (_dietSupplementOrPreferenceCode != null)
        {
            return _dietSupplementOrPreferenceCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ODS.3",
            Type = @"Field",
            Position = @"ODS.3",
            Name = @"Diet, Supplement, Or Preference Code",
            Length = 60,
            Usage = @"R",
            Rpt = @"20",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function.  Since ODS is a repeating segment, multiple entities get multiple segments",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODS.3.1",
                            Type = @"Component",
                            Position = @"ODS.3.1",
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
                            Id = @"ODS.3.2",
                            Type = @"Component",
                            Position = @"ODS.3.2",
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
                            Id = @"ODS.3.3",
                            Type = @"Component",
                            Position = @"ODS.3.3",
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
                            Id = @"ODS.3.4",
                            Type = @"Component",
                            Position = @"ODS.3.4",
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
                            Id = @"ODS.3.5",
                            Type = @"Component",
                            Position = @"ODS.3.5",
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
                            Id = @"ODS.3.6",
                            Type = @"Component",
                            Position = @"ODS.3.6",
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

        _dietSupplementOrPreferenceCode = new HL7V22Field
        {
            field = message[@"ODS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dietSupplementOrPreferenceCode.field.FieldRepetitions != null && _dietSupplementOrPreferenceCode.field.FieldRepetitions.Count > 0)
        {
            _dietSupplementOrPreferenceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dietSupplementOrPreferenceCode, fieldData);
        }

        return _dietSupplementOrPreferenceCode;
    } 
}

internal HL7V22Field _textInstruction;

public HL7V22Field TextInstruction
{
    get
    {
        if (_textInstruction != null)
        {
            return _textInstruction;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"ODS.4",
            Type = @"Field",
            Position = @"ODS.4",
            Name = @"Text Instruction",
            Length = 80,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"specific instructions for dietary.  These instructions may address specific patient needs, such as isolation.  This field provides the ordering provider's dietary instructions as free text.  It can represent the full dietary instruction or indicate supplemental information",
            Sample = @"",
            Fields = null
        }

        _textInstruction = new HL7V22Field
        {
            field = message[@"ODS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textInstruction.field.FieldRepetitions != null && _textInstruction.field.FieldRepetitions.Count > 0)
        {
            _textInstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_textInstruction, fieldData);
        }

        return _textInstruction;
    } 
}
    }
}

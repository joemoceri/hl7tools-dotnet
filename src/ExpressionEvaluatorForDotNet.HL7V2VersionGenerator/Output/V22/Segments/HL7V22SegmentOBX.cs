using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOBX
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBX"; } }

        public string SegmentId { get { return @"OBX"; } }
        
        public string LongName { get { return @"Observation Result"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V22SegmentOBX(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdObservationalSimple;

public HL7V22Field SetIdObservationalSimple
{
    get
    {
        if (_setIdObservationalSimple != null)
        {
            return _setIdObservationalSimple;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.1",
            Type = @"Field",
            Position = @"OBX.1",
            Name = @"Set Id - Observational Simple",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdObservationalSimple = new HL7V22Field
        {
            field = message[@"OBX"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdObservationalSimple.field.FieldRepetitions != null && _setIdObservationalSimple.field.FieldRepetitions.Count > 0)
        {
            _setIdObservationalSimple.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdObservationalSimple, fieldData);
        }

        return _setIdObservationalSimple;
    } 
}

internal HL7V22Field _valueType;

public HL7V22Field ValueType
{
    get
    {
        if (_valueType != null)
        {
            return _valueType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.2",
            Type = @"Field",
            Position = @"OBX.2",
            Name = @"Value Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0125",
            TableName = @"VALUE TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _valueType = new HL7V22Field
        {
            field = message[@"OBX"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueType.field.FieldRepetitions != null && _valueType.field.FieldRepetitions.Count > 0)
        {
            _valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_valueType, fieldData);
        }

        return _valueType;
    } 
}

internal HL7V22Field _observationIdentifier;

public HL7V22Field ObservationIdentifier
{
    get
    {
        if (_observationIdentifier != null)
        {
            return _observationIdentifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.3",
            Type = @"Field",
            Position = @"OBX.3",
            Name = @"Observation Identifier",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.3.1",
                            Type = @"Component",
                            Position = @"OBX.3.1",
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
                            Id = @"OBX.3.2",
                            Type = @"Component",
                            Position = @"OBX.3.2",
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
                            Id = @"OBX.3.3",
                            Type = @"Component",
                            Position = @"OBX.3.3",
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
                            Id = @"OBX.3.4",
                            Type = @"Component",
                            Position = @"OBX.3.4",
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
                            Id = @"OBX.3.5",
                            Type = @"Component",
                            Position = @"OBX.3.5",
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
                            Id = @"OBX.3.6",
                            Type = @"Component",
                            Position = @"OBX.3.6",
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

        _observationIdentifier = new HL7V22Field
        {
            field = message[@"OBX"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationIdentifier.field.FieldRepetitions != null && _observationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _observationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_observationIdentifier, fieldData);
        }

        return _observationIdentifier;
    } 
}

internal HL7V22Field _observationSubid;

public HL7V22Field ObservationSubid
{
    get
    {
        if (_observationSubid != null)
        {
            return _observationSubid;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.4",
            Type = @"Field",
            Position = @"OBX.4",
            Name = @"Observation Sub-id",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationSubid = new HL7V22Field
        {
            field = message[@"OBX"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationSubid.field.FieldRepetitions != null && _observationSubid.field.FieldRepetitions.Count > 0)
        {
            _observationSubid.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_observationSubid, fieldData);
        }

        return _observationSubid;
    } 
}

internal HL7V22Field _observationValue;

public HL7V22Field ObservationValue
{
    get
    {
        if (_observationValue != null)
        {
            return _observationValue;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.5",
            Type = @"Field",
            Position = @"OBX.5",
            Name = @"Observation Value",
            Length = 65536,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationValue = new HL7V22Field
        {
            field = message[@"OBX"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationValue.field.FieldRepetitions != null && _observationValue.field.FieldRepetitions.Count > 0)
        {
            _observationValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_observationValue, fieldData);
        }

        return _observationValue;
    } 
}

internal HL7V22Field _units;

public HL7V22Field Units
{
    get
    {
        if (_units != null)
        {
            return _units;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.6",
            Type = @"Field",
            Position = @"OBX.6",
            Name = @"Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.6.1",
                            Type = @"Component",
                            Position = @"OBX.6.1",
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
                            Id = @"OBX.6.2",
                            Type = @"Component",
                            Position = @"OBX.6.2",
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
                            Id = @"OBX.6.3",
                            Type = @"Component",
                            Position = @"OBX.6.3",
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
                            Id = @"OBX.6.4",
                            Type = @"Component",
                            Position = @"OBX.6.4",
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
                            Id = @"OBX.6.5",
                            Type = @"Component",
                            Position = @"OBX.6.5",
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
                            Id = @"OBX.6.6",
                            Type = @"Component",
                            Position = @"OBX.6.6",
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

        _units = new HL7V22Field
        {
            field = message[@"OBX"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_units.field.FieldRepetitions != null && _units.field.FieldRepetitions.Count > 0)
        {
            _units.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_units, fieldData);
        }

        return _units;
    } 
}

internal HL7V22Field _referencesRange;

public HL7V22Field ReferencesRange
{
    get
    {
        if (_referencesRange != null)
        {
            return _referencesRange;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.7",
            Type = @"Field",
            Position = @"OBX.7",
            Name = @"References Range",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _referencesRange = new HL7V22Field
        {
            field = message[@"OBX"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referencesRange.field.FieldRepetitions != null && _referencesRange.field.FieldRepetitions.Count > 0)
        {
            _referencesRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_referencesRange, fieldData);
        }

        return _referencesRange;
    } 
}

internal HL7V22Field _abnormalFlags;

public HL7V22Field AbnormalFlags
{
    get
    {
        if (_abnormalFlags != null)
        {
            return _abnormalFlags;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.8",
            Type = @"Field",
            Position = @"OBX.8",
            Name = @"Abnormal Flags",
            Length = 10,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0078",
            TableName = @"ABNORMAL FLAGS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _abnormalFlags = new HL7V22Field
        {
            field = message[@"OBX"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_abnormalFlags.field.FieldRepetitions != null && _abnormalFlags.field.FieldRepetitions.Count > 0)
        {
            _abnormalFlags.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_abnormalFlags, fieldData);
        }

        return _abnormalFlags;
    } 
}

internal HL7V22Field _probability;

public HL7V22Field Probability
{
    get
    {
        if (_probability != null)
        {
            return _probability;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.9",
            Type = @"Field",
            Position = @"OBX.9",
            Name = @"Probability",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _probability = new HL7V22Field
        {
            field = message[@"OBX"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_probability.field.FieldRepetitions != null && _probability.field.FieldRepetitions.Count > 0)
        {
            _probability.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_probability, fieldData);
        }

        return _probability;
    } 
}

internal HL7V22Field _natureOfAbnormalTest;

public HL7V22Field NatureOfAbnormalTest
{
    get
    {
        if (_natureOfAbnormalTest != null)
        {
            return _natureOfAbnormalTest;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.10",
            Type = @"Field",
            Position = @"OBX.10",
            Name = @"Nature Of Abnormal Test",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0080",
            TableName = @"NATURE OF ABNORMAL TESTING",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _natureOfAbnormalTest = new HL7V22Field
        {
            field = message[@"OBX"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_natureOfAbnormalTest.field.FieldRepetitions != null && _natureOfAbnormalTest.field.FieldRepetitions.Count > 0)
        {
            _natureOfAbnormalTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_natureOfAbnormalTest, fieldData);
        }

        return _natureOfAbnormalTest;
    } 
}

internal HL7V22Field _observationResultStatus;

public HL7V22Field ObservationResultStatus
{
    get
    {
        if (_observationResultStatus != null)
        {
            return _observationResultStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.11",
            Type = @"Field",
            Position = @"OBX.11",
            Name = @"Observation Result Status",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0085",
            TableName = @"OBSERVATION RESULT STATUS CODES INTERPRETATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationResultStatus = new HL7V22Field
        {
            field = message[@"OBX"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationResultStatus.field.FieldRepetitions != null && _observationResultStatus.field.FieldRepetitions.Count > 0)
        {
            _observationResultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_observationResultStatus, fieldData);
        }

        return _observationResultStatus;
    } 
}

internal HL7V22Field _effectiveDateLastObservationNormalValues;

public HL7V22Field EffectiveDateLastObservationNormalValues
{
    get
    {
        if (_effectiveDateLastObservationNormalValues != null)
        {
            return _effectiveDateLastObservationNormalValues;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.12",
            Type = @"Field",
            Position = @"OBX.12",
            Name = @"Effective Date Last Observation Normal Values",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.12.1",
                            Type = @"Component",
                            Position = @"OBX.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.12.2",
                            Type = @"Component",
                            Position = @"OBX.12.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _effectiveDateLastObservationNormalValues = new HL7V22Field
        {
            field = message[@"OBX"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_effectiveDateLastObservationNormalValues.field.FieldRepetitions != null && _effectiveDateLastObservationNormalValues.field.FieldRepetitions.Count > 0)
        {
            _effectiveDateLastObservationNormalValues.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_effectiveDateLastObservationNormalValues, fieldData);
        }

        return _effectiveDateLastObservationNormalValues;
    } 
}

internal HL7V22Field _userDefinedAccessChecks;

public HL7V22Field UserDefinedAccessChecks
{
    get
    {
        if (_userDefinedAccessChecks != null)
        {
            return _userDefinedAccessChecks;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.13",
            Type = @"Field",
            Position = @"OBX.13",
            Name = @"User Defined Access Checks",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _userDefinedAccessChecks = new HL7V22Field
        {
            field = message[@"OBX"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userDefinedAccessChecks.field.FieldRepetitions != null && _userDefinedAccessChecks.field.FieldRepetitions.Count > 0)
        {
            _userDefinedAccessChecks.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_userDefinedAccessChecks, fieldData);
        }

        return _userDefinedAccessChecks;
    } 
}

internal HL7V22Field _dateTimeOfTheObservation;

public HL7V22Field DateTimeOfTheObservation
{
    get
    {
        if (_dateTimeOfTheObservation != null)
        {
            return _dateTimeOfTheObservation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.14",
            Type = @"Field",
            Position = @"OBX.14",
            Name = @"Date / Time Of The Observation",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.14.1",
                            Type = @"Component",
                            Position = @"OBX.14.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.14.2",
                            Type = @"Component",
                            Position = @"OBX.14.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateTimeOfTheObservation = new HL7V22Field
        {
            field = message[@"OBX"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfTheObservation.field.FieldRepetitions != null && _dateTimeOfTheObservation.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfTheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeOfTheObservation, fieldData);
        }

        return _dateTimeOfTheObservation;
    } 
}

internal HL7V22Field _producersId;

public HL7V22Field ProducersId
{
    get
    {
        if (_producersId != null)
        {
            return _producersId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.15",
            Type = @"Field",
            Position = @"OBX.15",
            Name = @"Producer's Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.15.1",
                            Type = @"Component",
                            Position = @"OBX.15.1",
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
                            Id = @"OBX.15.2",
                            Type = @"Component",
                            Position = @"OBX.15.2",
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
                            Id = @"OBX.15.3",
                            Type = @"Component",
                            Position = @"OBX.15.3",
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
                            Id = @"OBX.15.4",
                            Type = @"Component",
                            Position = @"OBX.15.4",
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
                            Id = @"OBX.15.5",
                            Type = @"Component",
                            Position = @"OBX.15.5",
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
                            Id = @"OBX.15.6",
                            Type = @"Component",
                            Position = @"OBX.15.6",
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

        _producersId = new HL7V22Field
        {
            field = message[@"OBX"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_producersId.field.FieldRepetitions != null && _producersId.field.FieldRepetitions.Count > 0)
        {
            _producersId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_producersId, fieldData);
        }

        return _producersId;
    } 
}

internal HL7V22Field _responsibleObserver;

public HL7V22Field ResponsibleObserver
{
    get
    {
        if (_responsibleObserver != null)
        {
            return _responsibleObserver;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OBX.16",
            Type = @"Field",
            Position = @"OBX.16",
            Name = @"Responsible Observer",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.16.1",
                            Type = @"Component",
                            Position = @"OBX.16.1",
                            Name = @"Physician Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.2",
                            Type = @"Component",
                            Position = @"OBX.16.2",
                            Name = @"Familiy Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.3",
                            Type = @"Component",
                            Position = @"OBX.16.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.4",
                            Type = @"Component",
                            Position = @"OBX.16.4",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.5",
                            Type = @"Component",
                            Position = @"OBX.16.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.6",
                            Type = @"Component",
                            Position = @"OBX.16.6",
                            Name = @"Prefix (e.g. Dr)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.7",
                            Type = @"Component",
                            Position = @"OBX.16.7",
                            Name = @"Degree (e.g. Md)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.8",
                            Type = @"Component",
                            Position = @"OBX.16.8",
                            Name = @"Source Table Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _responsibleObserver = new HL7V22Field
        {
            field = message[@"OBX"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responsibleObserver.field.FieldRepetitions != null && _responsibleObserver.field.FieldRepetitions.Count > 0)
        {
            _responsibleObserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_responsibleObserver, fieldData);
        }

        return _responsibleObserver;
    } 
}
    }
}

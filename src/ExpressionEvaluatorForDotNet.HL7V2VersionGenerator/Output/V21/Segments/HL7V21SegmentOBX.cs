using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentOBX
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBX"; } }

        public string SegmentId { get { return @"OBX"; } }
        
        public string LongName { get { return @"Result"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentOBX(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdObservationSimple;

public HL7V21Field SetIdObservationSimple
{
    get
    {
        if (_setIdObservationSimple != null)
        {
            return _setIdObservationSimple;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.1",
            Type = @"Field",
            Position = @"OBX.1",
            Name = @"Set Id - Observation Simple",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdObservationSimple = new HL7V21Field
        {
            field = message[@"OBX"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdObservationSimple.field.FieldRepetitions != null && _setIdObservationSimple.field.FieldRepetitions.Count > 0)
        {
            _setIdObservationSimple.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdObservationSimple, fieldData);
        }

        return _setIdObservationSimple;
    } 
}

internal HL7V21Field _valueType;

public HL7V21Field ValueType
{
    get
    {
        if (_valueType != null)
        {
            return _valueType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.2",
            Type = @"Field",
            Position = @"OBX.2",
            Name = @"Value Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0125",
            TableName = @"VALUE TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _valueType = new HL7V21Field
        {
            field = message[@"OBX"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueType.field.FieldRepetitions != null && _valueType.field.FieldRepetitions.Count > 0)
        {
            _valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_valueType, fieldData);
        }

        return _valueType;
    } 
}

internal HL7V21Field _observationIdentifier;

public HL7V21Field ObservationIdentifier
{
    get
    {
        if (_observationIdentifier != null)
        {
            return _observationIdentifier;
        }

        var fieldData = new HL7V21FieldData
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _observationIdentifier = new HL7V21Field
        {
            field = message[@"OBX"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationIdentifier.field.FieldRepetitions != null && _observationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _observationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observationIdentifier, fieldData);
        }

        return _observationIdentifier;
    } 
}

internal HL7V21Field _observationSubid;

public HL7V21Field ObservationSubid
{
    get
    {
        if (_observationSubid != null)
        {
            return _observationSubid;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.4",
            Type = @"Field",
            Position = @"OBX.4",
            Name = @"Observation Sub-id",
            Length = 20,
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

        _observationSubid = new HL7V21Field
        {
            field = message[@"OBX"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationSubid.field.FieldRepetitions != null && _observationSubid.field.FieldRepetitions.Count > 0)
        {
            _observationSubid.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observationSubid, fieldData);
        }

        return _observationSubid;
    } 
}

internal HL7V21Field _observationResults;

public HL7V21Field ObservationResults
{
    get
    {
        if (_observationResults != null)
        {
            return _observationResults;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.5",
            Type = @"Field",
            Position = @"OBX.5",
            Name = @"Observation Results",
            Length = 65,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observationResults = new HL7V21Field
        {
            field = message[@"OBX"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationResults.field.FieldRepetitions != null && _observationResults.field.FieldRepetitions.Count > 0)
        {
            _observationResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observationResults, fieldData);
        }

        return _observationResults;
    } 
}

internal HL7V21Field _units;

public HL7V21Field Units
{
    get
    {
        if (_units != null)
        {
            return _units;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.6",
            Type = @"Field",
            Position = @"OBX.6",
            Name = @"Units",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _units = new HL7V21Field
        {
            field = message[@"OBX"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_units.field.FieldRepetitions != null && _units.field.FieldRepetitions.Count > 0)
        {
            _units.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_units, fieldData);
        }

        return _units;
    } 
}

internal HL7V21Field _referencesRange;

public HL7V21Field ReferencesRange
{
    get
    {
        if (_referencesRange != null)
        {
            return _referencesRange;
        }

        var fieldData = new HL7V21FieldData
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

        _referencesRange = new HL7V21Field
        {
            field = message[@"OBX"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referencesRange.field.FieldRepetitions != null && _referencesRange.field.FieldRepetitions.Count > 0)
        {
            _referencesRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_referencesRange, fieldData);
        }

        return _referencesRange;
    } 
}

internal HL7V21Field _abnormalFlags;

public HL7V21Field AbnormalFlags
{
    get
    {
        if (_abnormalFlags != null)
        {
            return _abnormalFlags;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.8",
            Type = @"Field",
            Position = @"OBX.8",
            Name = @"Abnormal Flags",
            Length = 10,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0078",
            TableName = @"ABNORMAL FLAGS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _abnormalFlags = new HL7V21Field
        {
            field = message[@"OBX"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_abnormalFlags.field.FieldRepetitions != null && _abnormalFlags.field.FieldRepetitions.Count > 0)
        {
            _abnormalFlags.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_abnormalFlags, fieldData);
        }

        return _abnormalFlags;
    } 
}

internal HL7V21Field _probability;

public HL7V21Field Probability
{
    get
    {
        if (_probability != null)
        {
            return _probability;
        }

        var fieldData = new HL7V21FieldData
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

        _probability = new HL7V21Field
        {
            field = message[@"OBX"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_probability.field.FieldRepetitions != null && _probability.field.FieldRepetitions.Count > 0)
        {
            _probability.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_probability, fieldData);
        }

        return _probability;
    } 
}

internal HL7V21Field _natureOfAbnormalTest;

public HL7V21Field NatureOfAbnormalTest
{
    get
    {
        if (_natureOfAbnormalTest != null)
        {
            return _natureOfAbnormalTest;
        }

        var fieldData = new HL7V21FieldData
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

        _natureOfAbnormalTest = new HL7V21Field
        {
            field = message[@"OBX"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_natureOfAbnormalTest.field.FieldRepetitions != null && _natureOfAbnormalTest.field.FieldRepetitions.Count > 0)
        {
            _natureOfAbnormalTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_natureOfAbnormalTest, fieldData);
        }

        return _natureOfAbnormalTest;
    } 
}

internal HL7V21Field _observResultStatus;

public HL7V21Field ObservResultStatus
{
    get
    {
        if (_observResultStatus != null)
        {
            return _observResultStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.11",
            Type = @"Field",
            Position = @"OBX.11",
            Name = @"Observ Result Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0085",
            TableName = @"OBSERVATION RESULT STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _observResultStatus = new HL7V21Field
        {
            field = message[@"OBX"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observResultStatus.field.FieldRepetitions != null && _observResultStatus.field.FieldRepetitions.Count > 0)
        {
            _observResultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_observResultStatus, fieldData);
        }

        return _observResultStatus;
    } 
}

internal HL7V21Field _dateLastObsNormalValues;

public HL7V21Field DateLastObsNormalValues
{
    get
    {
        if (_dateLastObsNormalValues != null)
        {
            return _dateLastObsNormalValues;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"OBX.12",
            Type = @"Field",
            Position = @"OBX.12",
            Name = @"Date Last Obs Normal Values",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dateLastObsNormalValues = new HL7V21Field
        {
            field = message[@"OBX"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateLastObsNormalValues.field.FieldRepetitions != null && _dateLastObsNormalValues.field.FieldRepetitions.Count > 0)
        {
            _dateLastObsNormalValues.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateLastObsNormalValues, fieldData);
        }

        return _dateLastObsNormalValues;
    } 
}
    }
}

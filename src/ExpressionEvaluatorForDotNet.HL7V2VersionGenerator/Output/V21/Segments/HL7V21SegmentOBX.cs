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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = new []{new HL7V2FieldData
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
                        },}
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentOBX(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdObservationSimple;

public HL7V21Field SetIdObservationSimple
{
    get
    {
        if (setIdObservationSimple != null)
        {
            return setIdObservationSimple;
        }

        setIdObservationSimple = new HL7V21Field
        {
            field = message[@"OBX"][1],
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
        };

        // check for repetitions
        if (setIdObservationSimple.field.FieldRepetitions != null && setIdObservationSimple.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdObservationSimple.Id));
            setIdObservationSimple.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(setIdObservationSimple, fieldData);
        }

        return setIdObservationSimple;
    } 
}

internal HL7V21Field valueType;

public HL7V21Field ValueType
{
    get
    {
        if (valueType != null)
        {
            return valueType;
        }

        valueType = new HL7V21Field
        {
            field = message[@"OBX"][2],
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
        };

        // check for repetitions
        if (valueType.field.FieldRepetitions != null && valueType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(valueType.Id));
            valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(valueType, fieldData);
        }

        return valueType;
    } 
}

internal HL7V21Field observationIdentifier;

public HL7V21Field ObservationIdentifier
{
    get
    {
        if (observationIdentifier != null)
        {
            return observationIdentifier;
        }

        observationIdentifier = new HL7V21Field
        {
            field = message[@"OBX"][3],
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
        };

        // check for repetitions
        if (observationIdentifier.field.FieldRepetitions != null && observationIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationIdentifier.Id));
            observationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(observationIdentifier, fieldData);
        }

        return observationIdentifier;
    } 
}

internal HL7V21Field observationSubid;

public HL7V21Field ObservationSubid
{
    get
    {
        if (observationSubid != null)
        {
            return observationSubid;
        }

        observationSubid = new HL7V21Field
        {
            field = message[@"OBX"][4],
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
        };

        // check for repetitions
        if (observationSubid.field.FieldRepetitions != null && observationSubid.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationSubid.Id));
            observationSubid.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(observationSubid, fieldData);
        }

        return observationSubid;
    } 
}

internal HL7V21Field observationResults;

public HL7V21Field ObservationResults
{
    get
    {
        if (observationResults != null)
        {
            return observationResults;
        }

        observationResults = new HL7V21Field
        {
            field = message[@"OBX"][5],
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
        };

        // check for repetitions
        if (observationResults.field.FieldRepetitions != null && observationResults.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observationResults.Id));
            observationResults.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(observationResults, fieldData);
        }

        return observationResults;
    } 
}

internal HL7V21Field units;

public HL7V21Field Units
{
    get
    {
        if (units != null)
        {
            return units;
        }

        units = new HL7V21Field
        {
            field = message[@"OBX"][6],
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
        };

        // check for repetitions
        if (units.field.FieldRepetitions != null && units.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(units.Id));
            units.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(units, fieldData);
        }

        return units;
    } 
}

internal HL7V21Field referencesRange;

public HL7V21Field ReferencesRange
{
    get
    {
        if (referencesRange != null)
        {
            return referencesRange;
        }

        referencesRange = new HL7V21Field
        {
            field = message[@"OBX"][7],
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
        };

        // check for repetitions
        if (referencesRange.field.FieldRepetitions != null && referencesRange.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(referencesRange.Id));
            referencesRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(referencesRange, fieldData);
        }

        return referencesRange;
    } 
}

internal HL7V21Field abnormalFlags;

public HL7V21Field AbnormalFlags
{
    get
    {
        if (abnormalFlags != null)
        {
            return abnormalFlags;
        }

        abnormalFlags = new HL7V21Field
        {
            field = message[@"OBX"][8],
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
        };

        // check for repetitions
        if (abnormalFlags.field.FieldRepetitions != null && abnormalFlags.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(abnormalFlags.Id));
            abnormalFlags.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(abnormalFlags, fieldData);
        }

        return abnormalFlags;
    } 
}

internal HL7V21Field probability;

public HL7V21Field Probability
{
    get
    {
        if (probability != null)
        {
            return probability;
        }

        probability = new HL7V21Field
        {
            field = message[@"OBX"][9],
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
        };

        // check for repetitions
        if (probability.field.FieldRepetitions != null && probability.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(probability.Id));
            probability.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(probability, fieldData);
        }

        return probability;
    } 
}

internal HL7V21Field natureOfAbnormalTest;

public HL7V21Field NatureOfAbnormalTest
{
    get
    {
        if (natureOfAbnormalTest != null)
        {
            return natureOfAbnormalTest;
        }

        natureOfAbnormalTest = new HL7V21Field
        {
            field = message[@"OBX"][10],
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
        };

        // check for repetitions
        if (natureOfAbnormalTest.field.FieldRepetitions != null && natureOfAbnormalTest.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(natureOfAbnormalTest.Id));
            natureOfAbnormalTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(natureOfAbnormalTest, fieldData);
        }

        return natureOfAbnormalTest;
    } 
}

internal HL7V21Field observResultStatus;

public HL7V21Field ObservResultStatus
{
    get
    {
        if (observResultStatus != null)
        {
            return observResultStatus;
        }

        observResultStatus = new HL7V21Field
        {
            field = message[@"OBX"][11],
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
        };

        // check for repetitions
        if (observResultStatus.field.FieldRepetitions != null && observResultStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(observResultStatus.Id));
            observResultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(observResultStatus, fieldData);
        }

        return observResultStatus;
    } 
}

internal HL7V21Field dateLastObsNormalValues;

public HL7V21Field DateLastObsNormalValues
{
    get
    {
        if (dateLastObsNormalValues != null)
        {
            return dateLastObsNormalValues;
        }

        dateLastObsNormalValues = new HL7V21Field
        {
            field = message[@"OBX"][12],
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
        };

        // check for repetitions
        if (dateLastObsNormalValues.field.FieldRepetitions != null && dateLastObsNormalValues.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateLastObsNormalValues.Id));
            dateLastObsNormalValues.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(dateLastObsNormalValues, fieldData);
        }

        return dateLastObsNormalValues;
    } 
}
    }
}

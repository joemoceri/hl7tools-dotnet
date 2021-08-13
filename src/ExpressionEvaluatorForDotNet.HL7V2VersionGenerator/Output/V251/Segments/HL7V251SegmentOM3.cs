using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentOM3
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM3"; } }

        public string SegmentId { get { return @"OM3"; } }
        
        public string LongName { get { return @"Categorical Service/Test/Observation"; } }
        
        public string Description { get { return @"This segment applies to free text and other non-numeric data types."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V251SegmentOM3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _sequenceNumberTestObservationMasterFile;

public HL7V251Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.1",
            Type = @"Field",
            Position = @"OM3.1",
            Name = @"Sequence Number - Test/Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment.",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V251Field
        {
            field = message[@"OM3"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V251Field _preferredCodingSystem;

public HL7V251Field PreferredCodingSystem
{
    get
    {
        if (_preferredCodingSystem != null)
        {
            return _preferredCodingSystem;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.2",
            Type = @"Field",
            Position = @"OM3.2",
            Name = @"Preferred Coding System",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the observations whose categorical responses are taken from a specified table of codes (e.g., CE data types). Record the preferred coding system for this observation (e.g., ICD9, SNOMED III). Take the codes from ASTM Table 3 or 5, or specify a local code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.2.1",
                            Type = @"Component",
                            Position = @"OM3.2.1",
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
                            Id = @"OM3.2.2",
                            Type = @"Component",
                            Position = @"OM3.2.2",
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
                            Id = @"OM3.2.3",
                            Type = @"Component",
                            Position = @"OM3.2.3",
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
                            Id = @"OM3.2.4",
                            Type = @"Component",
                            Position = @"OM3.2.4",
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
                            Id = @"OM3.2.5",
                            Type = @"Component",
                            Position = @"OM3.2.5",
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
                            Id = @"OM3.2.6",
                            Type = @"Component",
                            Position = @"OM3.2.6",
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

        _preferredCodingSystem = new HL7V251Field
        {
            field = message[@"OM3"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredCodingSystem.field.FieldRepetitions != null && _preferredCodingSystem.field.FieldRepetitions.Count > 0)
        {
            _preferredCodingSystem.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_preferredCodingSystem, fieldData);
        }

        return _preferredCodingSystem;
    } 
}

internal HL7V251Field _validCodedAnswers;

public HL7V251Field ValidCodedAnswers
{
    get
    {
        if (_validCodedAnswers != null)
        {
            return _validCodedAnswers;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.3",
            Type = @"Field",
            Position = @"OM3.3",
            Name = @"Valid Coded 'Answers'",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a list of valid coded answers. In the case that the list of coded answers is easily enumerated, list the valid coded answers for this observation here using the preferred coding system given in OM3-2 - Preferred Coding System. If, for example, the given observation was VDRL, the valid answers might be non-reactive, 86^ intermediate, and 87^ reactive.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.3.1",
                            Type = @"Component",
                            Position = @"OM3.3.1",
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
                            Id = @"OM3.3.2",
                            Type = @"Component",
                            Position = @"OM3.3.2",
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
                            Id = @"OM3.3.3",
                            Type = @"Component",
                            Position = @"OM3.3.3",
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
                            Id = @"OM3.3.4",
                            Type = @"Component",
                            Position = @"OM3.3.4",
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
                            Id = @"OM3.3.5",
                            Type = @"Component",
                            Position = @"OM3.3.5",
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
                            Id = @"OM3.3.6",
                            Type = @"Component",
                            Position = @"OM3.3.6",
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

        _validCodedAnswers = new HL7V251Field
        {
            field = message[@"OM3"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_validCodedAnswers.field.FieldRepetitions != null && _validCodedAnswers.field.FieldRepetitions.Count > 0)
        {
            _validCodedAnswers.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_validCodedAnswers, fieldData);
        }

        return _validCodedAnswers;
    } 
}

internal HL7V251Field _normalTextCodesforCategoricalObservations;

public HL7V251Field NormalTextCodesforCategoricalObservations
{
    get
    {
        if (_normalTextCodesforCategoricalObservations != null)
        {
            return _normalTextCodesforCategoricalObservations;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.4",
            Type = @"Field",
            Position = @"OM3.4",
            Name = @"Normal Text/Codes for Categorical Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Certain observations/tests with a nature code of A or C (see OM1-18 - Nature of Service/Test/Observation) have text (alpha) results (e.g., reactive, nonreactive). Alpha normals for those tests should be entered in this field (e.g., ""nonreactive"").",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.4.1",
                            Type = @"Component",
                            Position = @"OM3.4.1",
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
                            Id = @"OM3.4.2",
                            Type = @"Component",
                            Position = @"OM3.4.2",
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
                            Id = @"OM3.4.3",
                            Type = @"Component",
                            Position = @"OM3.4.3",
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
                            Id = @"OM3.4.4",
                            Type = @"Component",
                            Position = @"OM3.4.4",
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
                            Id = @"OM3.4.5",
                            Type = @"Component",
                            Position = @"OM3.4.5",
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
                            Id = @"OM3.4.6",
                            Type = @"Component",
                            Position = @"OM3.4.6",
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

        _normalTextCodesforCategoricalObservations = new HL7V251Field
        {
            field = message[@"OM3"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_normalTextCodesforCategoricalObservations.field.FieldRepetitions != null && _normalTextCodesforCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            _normalTextCodesforCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_normalTextCodesforCategoricalObservations, fieldData);
        }

        return _normalTextCodesforCategoricalObservations;
    } 
}

internal HL7V251Field _abnormalTextCodesforCategoricalObservations;

public HL7V251Field AbnormalTextCodesforCategoricalObservations
{
    get
    {
        if (_abnormalTextCodesforCategoricalObservations != null)
        {
            return _abnormalTextCodesforCategoricalObservations;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.5",
            Type = @"Field",
            Position = @"OM3.5",
            Name = @"Abnormal Text/Codes for Categorical Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of the text answers that are abnormal for the test.

Note:  Backward compatibility note - As of v2.5 this field is allowed to repeat.  When used for versions prior to v2.5, extra repetitions sent will be lost.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.5.1",
                            Type = @"Component",
                            Position = @"OM3.5.1",
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
                            Id = @"OM3.5.2",
                            Type = @"Component",
                            Position = @"OM3.5.2",
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
                            Id = @"OM3.5.3",
                            Type = @"Component",
                            Position = @"OM3.5.3",
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
                            Id = @"OM3.5.4",
                            Type = @"Component",
                            Position = @"OM3.5.4",
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
                            Id = @"OM3.5.5",
                            Type = @"Component",
                            Position = @"OM3.5.5",
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
                            Id = @"OM3.5.6",
                            Type = @"Component",
                            Position = @"OM3.5.6",
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

        _abnormalTextCodesforCategoricalObservations = new HL7V251Field
        {
            field = message[@"OM3"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_abnormalTextCodesforCategoricalObservations.field.FieldRepetitions != null && _abnormalTextCodesforCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            _abnormalTextCodesforCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_abnormalTextCodesforCategoricalObservations, fieldData);
        }

        return _abnormalTextCodesforCategoricalObservations;
    } 
}

internal HL7V251Field _criticalTextCodesforCategoricalObservations;

public HL7V251Field CriticalTextCodesforCategoricalObservations
{
    get
    {
        if (_criticalTextCodesforCategoricalObservations != null)
        {
            return _criticalTextCodesforCategoricalObservations;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.6",
            Type = @"Field",
            Position = @"OM3.6",
            Name = @"Critical Text/Codes for Categorical Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of coded results that are critically abnormal for this observation.

Note:  Backward compatibility note - As of v2.5 this field is allowed to repeat.  When used for versions prior to v2.5, extra repetitions sent will be lost.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM3.6.1",
                            Type = @"Component",
                            Position = @"OM3.6.1",
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
                            Id = @"OM3.6.2",
                            Type = @"Component",
                            Position = @"OM3.6.2",
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
                            Id = @"OM3.6.3",
                            Type = @"Component",
                            Position = @"OM3.6.3",
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
                            Id = @"OM3.6.4",
                            Type = @"Component",
                            Position = @"OM3.6.4",
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
                            Id = @"OM3.6.5",
                            Type = @"Component",
                            Position = @"OM3.6.5",
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
                            Id = @"OM3.6.6",
                            Type = @"Component",
                            Position = @"OM3.6.6",
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

        _criticalTextCodesforCategoricalObservations = new HL7V251Field
        {
            field = message[@"OM3"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_criticalTextCodesforCategoricalObservations.field.FieldRepetitions != null && _criticalTextCodesforCategoricalObservations.field.FieldRepetitions.Count > 0)
        {
            _criticalTextCodesforCategoricalObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_criticalTextCodesforCategoricalObservations, fieldData);
        }

        return _criticalTextCodesforCategoricalObservations;
    } 
}

internal HL7V251Field _valueType;

public HL7V251Field ValueType
{
    get
    {
        if (_valueType != null)
        {
            return _valueType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"OM3.7",
            Type = @"Field",
            Position = @"OM3.7",
            Name = @"Value Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0125",
            TableName = @"Value type",
            Description = @"This field contains the allowed data type for a single categorical observation (code A or C in OM1-18 - Nature of Observation). Refer to HL7 table 0125 - Value type for valid values.",
            Sample = @"",
            Fields = null
        }

        _valueType = new HL7V251Field
        {
            field = message[@"OM3"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueType.field.FieldRepetitions != null && _valueType.field.FieldRepetitions.Count > 0)
        {
            _valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_valueType, fieldData);
        }

        return _valueType;
    } 
}
    }
}

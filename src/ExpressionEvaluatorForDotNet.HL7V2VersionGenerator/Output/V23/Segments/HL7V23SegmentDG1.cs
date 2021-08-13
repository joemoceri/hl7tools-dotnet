using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentDG1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DG1"; } }

        public string SegmentId { get { return @"DG1"; } }
        
        public string LongName { get { return @"Diagnosis"; } }
        
        public string Description { get { return @"The DG1 segment contains patient diagnosis information of various types, for example, admitting,  primary, etc.  The DG1 segment is used to send multiple diagnoses (for example, for medical records encoding).  It is also used when the FT1-19-diagnosis does not provide sufficient information for a billing system.  This diagnosis coding should be distinguished from the clinical problem segment used by caregivers to manage the patient (see Chapter 12, Patient Care).  Coding methodologies are also defined. "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V23SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDDiagnosis;

public HL7V23Field SetIDDiagnosis
{
    get
    {
        if (_setIDDiagnosis != null)
        {
            return _setIDDiagnosis;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.1",
            Type = @"Field",
            Position = @"DG1.1",
            Name = @"Set ID - Diagnosis",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc. ",
            Sample = @"",
            Fields = null
        }

        _setIDDiagnosis = new HL7V23Field
        {
            field = message[@"DG1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDDiagnosis.field.FieldRepetitions != null && _setIDDiagnosis.field.FieldRepetitions.Count > 0)
        {
            _setIDDiagnosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDDiagnosis, fieldData);
        }

        return _setIDDiagnosis;
    } 
}

internal HL7V23Field _diagnosisCodingMethod;

public HL7V23Field DiagnosisCodingMethod
{
    get
    {
        if (_diagnosisCodingMethod != null)
        {
            return _diagnosisCodingMethod;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.2",
            Type = @"Field",
            Position = @"DG1.2",
            Name = @"Diagnosis Coding Method",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0053",
            TableName = @"Diagnosis Coding Method",
            Description = @"This field has been retained for backward compatibility only.   Use the components of DG1-3diagnosis code instead of this field.  When used for backward compatibility, ICD9 is the recommended coding methodology.  Refer to HL7 table 0053 - Diagnosis coding method for valid values. ",
            Sample = @"",
            Fields = null
        }

        _diagnosisCodingMethod = new HL7V23Field
        {
            field = message[@"DG1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCodingMethod.field.FieldRepetitions != null && _diagnosisCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisCodingMethod, fieldData);
        }

        return _diagnosisCodingMethod;
    } 
}

internal HL7V23Field _diagnosisCode;

public HL7V23Field DiagnosisCode
{
    get
    {
        if (_diagnosisCode != null)
        {
            return _diagnosisCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.3",
            Type = @"Field",
            Position = @"DG1.3",
            Name = @"Diagnosis Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0051",
            TableName = @"Diagnosis code",
            Description = @"Use this field instead of DG1-2-coding method and DG1-4-diagnosis description.  (Those two fields have been retained for backward compatibility only.)  DG1-3-diagnosis code contains the diagnosis code assigned to this diagnosis.  Refer to user-defined table 0051- Diagnosis code for suggested values. This field is a CE data type for compatibility with clinical and ancillary systems. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.3.1",
                            Type = @"Component",
                            Position = @"DG1.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3.2",
                            Type = @"Component",
                            Position = @"DG1.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3.3",
                            Type = @"Component",
                            Position = @"DG1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3.4",
                            Type = @"Component",
                            Position = @"DG1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3.5",
                            Type = @"Component",
                            Position = @"DG1.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.3.6",
                            Type = @"Component",
                            Position = @"DG1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _diagnosisCode = new HL7V23Field
        {
            field = message[@"DG1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCode.field.FieldRepetitions != null && _diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisCode, fieldData);
        }

        return _diagnosisCode;
    } 
}

internal HL7V23Field _diagnosisDescription;

public HL7V23Field DiagnosisDescription
{
    get
    {
        if (_diagnosisDescription != null)
        {
            return _diagnosisDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.4",
            Type = @"Field",
            Position = @"DG1.4",
            Name = @"Diagnosis Description",
            Length = 40,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use the components of DG1-3diagnosis code field instead of this field.  When used for backward compatibility, DG1-4-diagnosis description contains a description that best describes the diagnosis",
            Sample = @"",
            Fields = null
        }

        _diagnosisDescription = new HL7V23Field
        {
            field = message[@"DG1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDescription.field.FieldRepetitions != null && _diagnosisDescription.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisDescription, fieldData);
        }

        return _diagnosisDescription;
    } 
}

internal HL7V23Field _diagnosisDateTime;

public HL7V23Field DiagnosisDateTime
{
    get
    {
        if (_diagnosisDateTime != null)
        {
            return _diagnosisDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.5",
            Type = @"Field",
            Position = @"DG1.5",
            Name = @"Diagnosis Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the diagnosis was determined",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.5.1",
                            Type = @"Component",
                            Position = @"DG1.5.1",
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
                        }
        }

        _diagnosisDateTime = new HL7V23Field
        {
            field = message[@"DG1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDateTime.field.FieldRepetitions != null && _diagnosisDateTime.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisDateTime, fieldData);
        }

        return _diagnosisDateTime;
    } 
}

internal HL7V23Field _diagnosisType;

public HL7V23Field DiagnosisType
{
    get
    {
        if (_diagnosisType != null)
        {
            return _diagnosisType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.6",
            Type = @"Field",
            Position = @"DG1.6",
            Name = @"Diagnosis Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0052",
            TableName = @"Diagnosis type",
            Description = @"This field contains a code that identifies the type of diagnosis being sent.  Refer to user-defined table 0052 - Diagnosis type.  This field should no longer be used to indicate “DRG” because the DRG fields have moved to the new DRG segment. ",
            Sample = @"",
            Fields = null
        }

        _diagnosisType = new HL7V23Field
        {
            field = message[@"DG1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisType.field.FieldRepetitions != null && _diagnosisType.field.FieldRepetitions.Count > 0)
        {
            _diagnosisType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisType, fieldData);
        }

        return _diagnosisType;
    } 
}

internal HL7V23Field _majorDiagnosticCategory;

public HL7V23Field MajorDiagnosticCategory
{
    get
    {
        if (_majorDiagnosticCategory != null)
        {
            return _majorDiagnosticCategory;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.7",
            Type = @"Field",
            Position = @"DG1.7",
            Name = @"Major Diagnostic Category",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0118",
            TableName = @"Major diagnostic category",
            Description = @"This field has been retained for backward compatibility only.  This field should only be used in a master file transaction.  Refer to user-defined table 0118 - Major diagnostic category for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.7.1",
                            Type = @"Component",
                            Position = @"DG1.7.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.2",
                            Type = @"Component",
                            Position = @"DG1.7.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.3",
                            Type = @"Component",
                            Position = @"DG1.7.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.4",
                            Type = @"Component",
                            Position = @"DG1.7.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.5",
                            Type = @"Component",
                            Position = @"DG1.7.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.7.6",
                            Type = @"Component",
                            Position = @"DG1.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _majorDiagnosticCategory = new HL7V23Field
        {
            field = message[@"DG1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_majorDiagnosticCategory.field.FieldRepetitions != null && _majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            _majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_majorDiagnosticCategory, fieldData);
        }

        return _majorDiagnosticCategory;
    } 
}

internal HL7V23Field _diagnosticRelatedGroup;

public HL7V23Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.8",
            Type = @"Field",
            Position = @"DG1.8",
            Name = @"Diagnostic Related Group",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0055",
            TableName = @"Diagnosis related group",
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  It contains the DRG for the transaction.  Interim DRG’s could be determined for an encounter.  Refer to user-defined table 0055 - DRG code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.8.1",
                            Type = @"Component",
                            Position = @"DG1.8.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.8.2",
                            Type = @"Component",
                            Position = @"DG1.8.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.8.3",
                            Type = @"Component",
                            Position = @"DG1.8.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.8.4",
                            Type = @"Component",
                            Position = @"DG1.8.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.8.5",
                            Type = @"Component",
                            Position = @"DG1.8.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.8.6",
                            Type = @"Component",
                            Position = @"DG1.8.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _diagnosticRelatedGroup = new HL7V23Field
        {
            field = message[@"DG1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V23Field _dRGApprovalIndicator;

public HL7V23Field DRGApprovalIndicator
{
    get
    {
        if (_dRGApprovalIndicator != null)
        {
            return _dRGApprovalIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.9",
            Type = @"Field",
            Position = @"DG1.9",
            Name = @"DRG Approval Indicator",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  This field indicates if the DRG has been approved by a reviewing entity.  Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _dRGApprovalIndicator = new HL7V23Field
        {
            field = message[@"DG1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGApprovalIndicator.field.FieldRepetitions != null && _dRGApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _dRGApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dRGApprovalIndicator, fieldData);
        }

        return _dRGApprovalIndicator;
    } 
}

internal HL7V23Field _dRGGrouperReviewCode;

public HL7V23Field DRGGrouperReviewCode
{
    get
    {
        if (_dRGGrouperReviewCode != null)
        {
            return _dRGGrouperReviewCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.10",
            Type = @"Field",
            Position = @"DG1.10",
            Name = @"DRG Grouper Review Code",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0056",
            TableName = @"DRG grouper review code",
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  Refer to user-defined table 0056 - DRG grouper review code for suggested values.  This code indicates that the grouper results have been reviewed and approved.",
            Sample = @"",
            Fields = null
        }

        _dRGGrouperReviewCode = new HL7V23Field
        {
            field = message[@"DG1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dRGGrouperReviewCode.field.FieldRepetitions != null && _dRGGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            _dRGGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dRGGrouperReviewCode, fieldData);
        }

        return _dRGGrouperReviewCode;
    } 
}

internal HL7V23Field _outlierType;

public HL7V23Field OutlierType
{
    get
    {
        if (_outlierType != null)
        {
            return _outlierType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.11",
            Type = @"Field",
            Position = @"DG1.11",
            Name = @"Outlier Type",
            Length = 60,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0083",
            TableName = @"Outlier type",
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  When used for backward compatibility, this field contains the type of outlier that has been paid.  Refer to user-defined table 0083 - Outlier type for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.11.1",
                            Type = @"Component",
                            Position = @"DG1.11.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11.2",
                            Type = @"Component",
                            Position = @"DG1.11.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11.3",
                            Type = @"Component",
                            Position = @"DG1.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11.4",
                            Type = @"Component",
                            Position = @"DG1.11.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11.5",
                            Type = @"Component",
                            Position = @"DG1.11.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.11.6",
                            Type = @"Component",
                            Position = @"DG1.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierType = new HL7V23Field
        {
            field = message[@"DG1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierType.field.FieldRepetitions != null && _outlierType.field.FieldRepetitions.Count > 0)
        {
            _outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_outlierType, fieldData);
        }

        return _outlierType;
    } 
}

internal HL7V23Field _outlierDays;

public HL7V23Field OutlierDays
{
    get
    {
        if (_outlierDays != null)
        {
            return _outlierDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.12",
            Type = @"Field",
            Position = @"DG1.12",
            Name = @"Outlier Days",
            Length = 3,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  When used for backward compatibility, this field contains the number of days that have been approved for an outlier payment.",
            Sample = @"",
            Fields = null
        }

        _outlierDays = new HL7V23Field
        {
            field = message[@"DG1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierDays.field.FieldRepetitions != null && _outlierDays.field.FieldRepetitions.Count > 0)
        {
            _outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_outlierDays, fieldData);
        }

        return _outlierDays;
    } 
}

internal HL7V23Field _outlierCost;

public HL7V23Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.13",
            Type = @"Field",
            Position = @"DG1.13",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field  has been retained for backward compatibility only.  This field has moved to the new DRG segment.  When used for backward compatibility, this field contains the amount of money that has been approved for an outlier payment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.13.1",
                            Type = @"Component",
                            Position = @"DG1.13.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.13.1.1",
                            Type = @"SubComponent",
                            Position = @"DG1.13.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.1.2",
                            Type = @"SubComponent",
                            Position = @"DG1.13.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.2",
                            Type = @"Component",
                            Position = @"DG1.13.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.3",
                            Type = @"Component",
                            Position = @"DG1.13.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.4",
                            Type = @"Component",
                            Position = @"DG1.13.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5",
                            Type = @"Component",
                            Position = @"DG1.13.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.1",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.2",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.3",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.4",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.5",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.5.6",
                            Type = @"SubComponent",
                            Position = @"DG1.13.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.13.6",
                            Type = @"Component",
                            Position = @"DG1.13.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _outlierCost = new HL7V23Field
        {
            field = message[@"DG1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}

internal HL7V23Field _grouperVersionandType;

public HL7V23Field GrouperVersionandType
{
    get
    {
        if (_grouperVersionandType != null)
        {
            return _grouperVersionandType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.14",
            Type = @"Field",
            Position = @"DG1.14",
            Name = @"Grouper Version and Type",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  This field has moved to the new DRG segment.  When used for backward compatibility, this field contains the grouper version and type.",
            Sample = @"",
            Fields = null
        }

        _grouperVersionandType = new HL7V23Field
        {
            field = message[@"DG1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperVersionandType.field.FieldRepetitions != null && _grouperVersionandType.field.FieldRepetitions.Count > 0)
        {
            _grouperVersionandType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_grouperVersionandType, fieldData);
        }

        return _grouperVersionandType;
    } 
}

internal HL7V23Field _diagnosisPriority;

public HL7V23Field DiagnosisPriority
{
    get
    {
        if (_diagnosisPriority != null)
        {
            return _diagnosisPriority;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.15",
            Type = @"Field",
            Position = @"DG1.15",
            Name = @"Diagnosis Priority",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  This field should no longer be used for DRG priority, because the DRG fields have moved to the new DRG segment.

When used for backward compatibility, DG1-15-diagnosis priority contains the number that identifies the significance or priority of the diagnosis or DRG code.  The numbers have the following meanings:

0 the admitting diagnosis
1 the primary diagnosis
2 and higher for ranked secondary diagnoses",
            Sample = @"",
            Fields = null
        }

        _diagnosisPriority = new HL7V23Field
        {
            field = message[@"DG1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisPriority.field.FieldRepetitions != null && _diagnosisPriority.field.FieldRepetitions.Count > 0)
        {
            _diagnosisPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisPriority, fieldData);
        }

        return _diagnosisPriority;
    } 
}

internal HL7V23Field _diagnosingClinician;

public HL7V23Field DiagnosingClinician
{
    get
    {
        if (_diagnosingClinician != null)
        {
            return _diagnosingClinician;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.16",
            Type = @"Field",
            Position = @"DG1.16",
            Name = @"Diagnosing Clinician",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual responsible for generating the diagnosis information. Multiple names and identifiers for the same person may be sent in this field, not multiple diagnosing clinicians.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.16.1",
                            Type = @"Component",
                            Position = @"DG1.16.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.2",
                            Type = @"Component",
                            Position = @"DG1.16.2",
                            Name = @"Family Name",
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
                            Id = @"DG1.16.3",
                            Type = @"Component",
                            Position = @"DG1.16.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.4",
                            Type = @"Component",
                            Position = @"DG1.16.4",
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
                            Id = @"DG1.16.5",
                            Type = @"Component",
                            Position = @"DG1.16.5",
                            Name = @"Suffix",
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
                            Id = @"DG1.16.6",
                            Type = @"Component",
                            Position = @"DG1.16.6",
                            Name = @"Prefix",
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
                            Id = @"DG1.16.7",
                            Type = @"Component",
                            Position = @"DG1.16.7",
                            Name = @"Degree",
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
                            Id = @"DG1.16.8",
                            Type = @"Component",
                            Position = @"DG1.16.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.9",
                            Type = @"Component",
                            Position = @"DG1.16.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.9.1",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.9.2",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.9.3",
                            Type = @"SubComponent",
                            Position = @"DG1.16.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.10",
                            Type = @"Component",
                            Position = @"DG1.16.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.11",
                            Type = @"Component",
                            Position = @"DG1.16.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.12",
                            Type = @"Component",
                            Position = @"DG1.16.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.13",
                            Type = @"Component",
                            Position = @"DG1.16.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.14",
                            Type = @"Component",
                            Position = @"DG1.16.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DG1.16.14.1",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.14.2",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.16.14.3",
                            Type = @"SubComponent",
                            Position = @"DG1.16.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _diagnosingClinician = new HL7V23Field
        {
            field = message[@"DG1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosingClinician.field.FieldRepetitions != null && _diagnosingClinician.field.FieldRepetitions.Count > 0)
        {
            _diagnosingClinician.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosingClinician, fieldData);
        }

        return _diagnosingClinician;
    } 
}

internal HL7V23Field _diagnosisClassification;

public HL7V23Field DiagnosisClassification
{
    get
    {
        if (_diagnosisClassification != null)
        {
            return _diagnosisClassification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.17",
            Type = @"Field",
            Position = @"DG1.17",
            Name = @"Diagnosis Classification",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0228",
            TableName = @"Diagnosis classification",
            Description = @"This field indicates if the patient information is for a diagnosis or a non-diagnosis code.  Refer to user-defined table 0228 - Diagnosis classification for suggested values",
            Sample = @"",
            Fields = null
        }

        _diagnosisClassification = new HL7V23Field
        {
            field = message[@"DG1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisClassification.field.FieldRepetitions != null && _diagnosisClassification.field.FieldRepetitions.Count > 0)
        {
            _diagnosisClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosisClassification, fieldData);
        }

        return _diagnosisClassification;
    } 
}

internal HL7V23Field _confidentialIndicator;

public HL7V23Field ConfidentialIndicator
{
    get
    {
        if (_confidentialIndicator != null)
        {
            return _confidentialIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.18",
            Type = @"Field",
            Position = @"DG1.18",
            Name = @"Confidential Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether the diagnosis is confidential. ",
            Sample = @"",
            Fields = null
        }

        _confidentialIndicator = new HL7V23Field
        {
            field = message[@"DG1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_confidentialIndicator.field.FieldRepetitions != null && _confidentialIndicator.field.FieldRepetitions.Count > 0)
        {
            _confidentialIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_confidentialIndicator, fieldData);
        }

        return _confidentialIndicator;
    } 
}

internal HL7V23Field _attestationDateTime;

public HL7V23Field AttestationDateTime
{
    get
    {
        if (_attestationDateTime != null)
        {
            return _attestationDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"DG1.19",
            Type = @"Field",
            Position = @"DG1.19",
            Name = @"Attestation Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the time stamp that indicates the date and time that the attestation was signed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.19.1",
                            Type = @"Component",
                            Position = @"DG1.19.1",
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
                        }
        }

        _attestationDateTime = new HL7V23Field
        {
            field = message[@"DG1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_attestationDateTime.field.FieldRepetitions != null && _attestationDateTime.field.FieldRepetitions.Count > 0)
        {
            _attestationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_attestationDateTime, fieldData);
        }

        return _attestationDateTime;
    } 
}
    }
}

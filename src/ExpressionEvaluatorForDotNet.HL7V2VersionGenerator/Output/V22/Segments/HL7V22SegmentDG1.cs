using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentDG1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DG1"; } }

        public string SegmentId { get { return @"DG1"; } }
        
        public string LongName { get { return @"Diagnosis"; } }
        
        public string Description { get { return @"The DG1 segment contains patient diagnosis information of various types.  For example: Admitting, Current, Primary, Final, etc.  Coding methodologies are also defined"; } }
        
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

        public HL7V22SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdDiagnosis;

public HL7V22Field SetIdDiagnosis
{
    get
    {
        if (_setIdDiagnosis != null)
        {
            return _setIdDiagnosis;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.1",
            Type = @"Field",
            Position = @"DG1.1",
            Name = @"Set Id - Diagnosis",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"sequence number that uniquely identifies the individual transaction for adding, deleting, and updating the diagnosis in the patient's record",
            Sample = @"",
            Fields = null
        }

        _setIdDiagnosis = new HL7V22Field
        {
            field = message[@"DG1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdDiagnosis.field.FieldRepetitions != null && _setIdDiagnosis.field.FieldRepetitions.Count > 0)
        {
            _setIdDiagnosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdDiagnosis, fieldData);
        }

        return _setIdDiagnosis;
    } 
}

internal HL7V22Field _diagnosisCodingMethod;

public HL7V22Field DiagnosisCodingMethod
{
    get
    {
        if (_diagnosisCodingMethod != null)
        {
            return _diagnosisCodingMethod;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.2",
            Type = @"Field",
            Position = @"DG1.2",
            Name = @"Diagnosis Coding Method",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0053",
            TableName = @"DIAGNOSIS CODING METHOD",
            Description = @"ICD9 is the recommended coding methodology.  Refer to user-defined table 0053- diagnosis coding method",
            Sample = @"",
            Fields = null
        }

        _diagnosisCodingMethod = new HL7V22Field
        {
            field = message[@"DG1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCodingMethod.field.FieldRepetitions != null && _diagnosisCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisCodingMethod, fieldData);
        }

        return _diagnosisCodingMethod;
    } 
}

internal HL7V22Field _diagnosisCode;

public HL7V22Field DiagnosisCode
{
    get
    {
        if (_diagnosisCode != null)
        {
            return _diagnosisCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.3",
            Type = @"Field",
            Position = @"DG1.3",
            Name = @"Diagnosis Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0051",
            TableName = @"DIAGNOSIS CODE",
            Description = @"diagnosis code assigned to this diagnosis.  Refer to user-defined table 0051- diagnosis code",
            Sample = @"",
            Fields = null
        }

        _diagnosisCode = new HL7V22Field
        {
            field = message[@"DG1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCode.field.FieldRepetitions != null && _diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisCode, fieldData);
        }

        return _diagnosisCode;
    } 
}

internal HL7V22Field _diagnosisDescription;

public HL7V22Field DiagnosisDescription
{
    get
    {
        if (_diagnosisDescription != null)
        {
            return _diagnosisDescription;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.4",
            Type = @"Field",
            Position = @"DG1.4",
            Name = @"Diagnosis Description",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"description that best describes the diagnosis",
            Sample = @"",
            Fields = null
        }

        _diagnosisDescription = new HL7V22Field
        {
            field = message[@"DG1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDescription.field.FieldRepetitions != null && _diagnosisDescription.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisDescription, fieldData);
        }

        return _diagnosisDescription;
    } 
}

internal HL7V22Field _diagnosisDateTime;

public HL7V22Field DiagnosisDateTime
{
    get
    {
        if (_diagnosisDateTime != null)
        {
            return _diagnosisDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.5",
            Type = @"Field",
            Position = @"DG1.5",
            Name = @"Diagnosis Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time the diagnosis was determined",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"DG1.5.2",
                            Type = @"Component",
                            Position = @"DG1.5.2",
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

        _diagnosisDateTime = new HL7V22Field
        {
            field = message[@"DG1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDateTime.field.FieldRepetitions != null && _diagnosisDateTime.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisDateTime, fieldData);
        }

        return _diagnosisDateTime;
    } 
}

internal HL7V22Field _diagnosisDrgType;

public HL7V22Field DiagnosisDrgType
{
    get
    {
        if (_diagnosisDrgType != null)
        {
            return _diagnosisDrgType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.6",
            Type = @"Field",
            Position = @"DG1.6",
            Name = @"Diagnosis / Drg Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0052",
            TableName = @"DIAGNOSIS TYPE",
            Description = @"code identifies the type of diagnosis being sent.  Valid types could include: Admitting, Final, etc.  Refer to user-defined table 0052- diagnosis type",
            Sample = @"",
            Fields = null
        }

        _diagnosisDrgType = new HL7V22Field
        {
            field = message[@"DG1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDrgType.field.FieldRepetitions != null && _diagnosisDrgType.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDrgType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisDrgType, fieldData);
        }

        return _diagnosisDrgType;
    } 
}

internal HL7V22Field _majorDiagnosticCategory;

public HL7V22Field MajorDiagnosticCategory
{
    get
    {
        if (_majorDiagnosticCategory != null)
        {
            return _majorDiagnosticCategory;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.7",
            Type = @"Field",
            Position = @"DG1.7",
            Name = @"Major Diagnostic Category",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0118",
            TableName = @"MAJOR DIAGNOSTIC CATEGORY",
            Description = @"refer to user-defined table 0118 - major diagnostic category",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _majorDiagnosticCategory = new HL7V22Field
        {
            field = message[@"DG1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_majorDiagnosticCategory.field.FieldRepetitions != null && _majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            _majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_majorDiagnosticCategory, fieldData);
        }

        return _majorDiagnosticCategory;
    } 
}

internal HL7V22Field _diagnosticRelatedGroup;

public HL7V22Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.8",
            Type = @"Field",
            Position = @"DG1.8",
            Name = @"Diagnostic Related Group",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0055",
            TableName = @"DRG CODE",
            Description = @"DRG for the transaction.  Interim DRG's could be determined for an encounter.  Refer to user-defined table 0055- DRG code",
            Sample = @"",
            Fields = null
        }

        _diagnosticRelatedGroup = new HL7V22Field
        {
            field = message[@"DG1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V22Field _drgApprovalIndicator;

public HL7V22Field DrgApprovalIndicator
{
    get
    {
        if (_drgApprovalIndicator != null)
        {
            return _drgApprovalIndicator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.9",
            Type = @"Field",
            Position = @"DG1.9",
            Name = @"Drg Approval Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"indicates if the DRG has been approved by a reviewing entity ",
            Sample = @"",
            Fields = null
        }

        _drgApprovalIndicator = new HL7V22Field
        {
            field = message[@"DG1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drgApprovalIndicator.field.FieldRepetitions != null && _drgApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _drgApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_drgApprovalIndicator, fieldData);
        }

        return _drgApprovalIndicator;
    } 
}

internal HL7V22Field _drgGrouperReviewCode;

public HL7V22Field DrgGrouperReviewCode
{
    get
    {
        if (_drgGrouperReviewCode != null)
        {
            return _drgGrouperReviewCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.10",
            Type = @"Field",
            Position = @"DG1.10",
            Name = @"Drg Grouper Review Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0056",
            TableName = @"DRG GROUPER REVIEW CODE",
            Description = @"refer to user-defined table 0056 - DRG grouper review code.  This code indicates that the grouper results have been reviewed and approved",
            Sample = @"",
            Fields = null
        }

        _drgGrouperReviewCode = new HL7V22Field
        {
            field = message[@"DG1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drgGrouperReviewCode.field.FieldRepetitions != null && _drgGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            _drgGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_drgGrouperReviewCode, fieldData);
        }

        return _drgGrouperReviewCode;
    } 
}

internal HL7V22Field _outlierType;

public HL7V22Field OutlierType
{
    get
    {
        if (_outlierType != null)
        {
            return _outlierType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.11",
            Type = @"Field",
            Position = @"DG1.11",
            Name = @"Outlier Type",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0083",
            TableName = @"OUTLIER TYPE",
            Description = @"Refer to user-defined table 0083 - outlier type.  The type of outlier that has been paid",
            Sample = @"",
            Fields = null
        }

        _outlierType = new HL7V22Field
        {
            field = message[@"DG1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierType.field.FieldRepetitions != null && _outlierType.field.FieldRepetitions.Count > 0)
        {
            _outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_outlierType, fieldData);
        }

        return _outlierType;
    } 
}

internal HL7V22Field _outlierDays;

public HL7V22Field OutlierDays
{
    get
    {
        if (_outlierDays != null)
        {
            return _outlierDays;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.12",
            Type = @"Field",
            Position = @"DG1.12",
            Name = @"Outlier Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number of days that have been approved as an outlier payment",
            Sample = @"",
            Fields = null
        }

        _outlierDays = new HL7V22Field
        {
            field = message[@"DG1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierDays.field.FieldRepetitions != null && _outlierDays.field.FieldRepetitions.Count > 0)
        {
            _outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_outlierDays, fieldData);
        }

        return _outlierDays;
    } 
}

internal HL7V22Field _outlierCost;

public HL7V22Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.13",
            Type = @"Field",
            Position = @"DG1.13",
            Name = @"Outlier Cost",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of money that has been approved as a payment",
            Sample = @"",
            Fields = null
        }

        _outlierCost = new HL7V22Field
        {
            field = message[@"DG1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}

internal HL7V22Field _grouperVersionAndType;

public HL7V22Field GrouperVersionAndType
{
    get
    {
        if (_grouperVersionAndType != null)
        {
            return _grouperVersionAndType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.14",
            Type = @"Field",
            Position = @"DG1.14",
            Name = @"Grouper Version And Type",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"grouper version and type",
            Sample = @"",
            Fields = null
        }

        _grouperVersionAndType = new HL7V22Field
        {
            field = message[@"DG1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperVersionAndType.field.FieldRepetitions != null && _grouperVersionAndType.field.FieldRepetitions.Count > 0)
        {
            _grouperVersionAndType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_grouperVersionAndType, fieldData);
        }

        return _grouperVersionAndType;
    } 
}

internal HL7V22Field _diagnosisDrgPriority;

public HL7V22Field DiagnosisDrgPriority
{
    get
    {
        if (_diagnosisDrgPriority != null)
        {
            return _diagnosisDrgPriority;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.15",
            Type = @"Field",
            Position = @"DG1.15",
            Name = @"Diagnosis / Drg Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number which identifies the significance or priority of the diagnosis or DRG code",
            Sample = @"",
            Fields = null
        }

        _diagnosisDrgPriority = new HL7V22Field
        {
            field = message[@"DG1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDrgPriority.field.FieldRepetitions != null && _diagnosisDrgPriority.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDrgPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosisDrgPriority, fieldData);
        }

        return _diagnosisDrgPriority;
    } 
}

internal HL7V22Field _diagnosingClinician;

public HL7V22Field DiagnosingClinician
{
    get
    {
        if (_diagnosingClinician != null)
        {
            return _diagnosingClinician;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"DG1.16",
            Type = @"Field",
            Position = @"DG1.16",
            Name = @"Diagnosing Clinician",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"individual responsible for generating the diagnosis information",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DG1.16.1",
                            Type = @"Component",
                            Position = @"DG1.16.1",
                            Name = @"Id Number",
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
                            Id = @"DG1.16.2",
                            Type = @"Component",
                            Position = @"DG1.16.2",
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
                            Id = @"DG1.16.3",
                            Type = @"Component",
                            Position = @"DG1.16.3",
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
                            Id = @"DG1.16.6",
                            Type = @"Component",
                            Position = @"DG1.16.6",
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
                            Id = @"DG1.16.7",
                            Type = @"Component",
                            Position = @"DG1.16.7",
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
                            Id = @"DG1.16.8",
                            Type = @"Component",
                            Position = @"DG1.16.8",
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

        _diagnosingClinician = new HL7V22Field
        {
            field = message[@"DG1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosingClinician.field.FieldRepetitions != null && _diagnosingClinician.field.FieldRepetitions.Count > 0)
        {
            _diagnosingClinician.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_diagnosingClinician, fieldData);
        }

        return _diagnosingClinician;
    } 
}
    }
}

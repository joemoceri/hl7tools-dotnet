using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentDG1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DG1"; } }

        public string SegmentId { get { return @"DG1"; } }
        
        public string LongName { get { return @"Diagnosis"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdDiagnosis;

public HL7V21Field SetIdDiagnosis
{
    get
    {
        if (_setIdDiagnosis != null)
        {
            return _setIdDiagnosis;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DG1.1",
            Type = @"Field",
            Position = @"DG1.1",
            Name = @"Set Id - Diagnosis",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdDiagnosis = new HL7V21Field
        {
            field = message[@"DG1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdDiagnosis.field.FieldRepetitions != null && _setIdDiagnosis.field.FieldRepetitions.Count > 0)
        {
            _setIdDiagnosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdDiagnosis, fieldData);
        }

        return _setIdDiagnosis;
    } 
}

internal HL7V21Field _diagnosisCodingMethod;

public HL7V21Field DiagnosisCodingMethod
{
    get
    {
        if (_diagnosisCodingMethod != null)
        {
            return _diagnosisCodingMethod;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosisCodingMethod = new HL7V21Field
        {
            field = message[@"DG1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCodingMethod.field.FieldRepetitions != null && _diagnosisCodingMethod.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosisCodingMethod, fieldData);
        }

        return _diagnosisCodingMethod;
    } 
}

internal HL7V21Field _diagnosisCode;

public HL7V21Field DiagnosisCode
{
    get
    {
        if (_diagnosisCode != null)
        {
            return _diagnosisCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosisCode = new HL7V21Field
        {
            field = message[@"DG1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisCode.field.FieldRepetitions != null && _diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            _diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosisCode, fieldData);
        }

        return _diagnosisCode;
    } 
}

internal HL7V21Field _diagnosisDescription;

public HL7V21Field DiagnosisDescription
{
    get
    {
        if (_diagnosisDescription != null)
        {
            return _diagnosisDescription;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosisDescription = new HL7V21Field
        {
            field = message[@"DG1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDescription.field.FieldRepetitions != null && _diagnosisDescription.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosisDescription, fieldData);
        }

        return _diagnosisDescription;
    } 
}

internal HL7V21Field _diagnosisDateTime;

public HL7V21Field DiagnosisDateTime
{
    get
    {
        if (_diagnosisDateTime != null)
        {
            return _diagnosisDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DG1.5",
            Type = @"Field",
            Position = @"DG1.5",
            Name = @"Diagnosis Date/Time",
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

        _diagnosisDateTime = new HL7V21Field
        {
            field = message[@"DG1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDateTime.field.FieldRepetitions != null && _diagnosisDateTime.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosisDateTime, fieldData);
        }

        return _diagnosisDateTime;
    } 
}

internal HL7V21Field _diagnosisDrgType;

public HL7V21Field DiagnosisDrgType
{
    get
    {
        if (_diagnosisDrgType != null)
        {
            return _diagnosisDrgType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DG1.6",
            Type = @"Field",
            Position = @"DG1.6",
            Name = @"Diagnosis/Drg Type",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0052",
            TableName = @"DIAGNOSIS TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosisDrgType = new HL7V21Field
        {
            field = message[@"DG1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosisDrgType.field.FieldRepetitions != null && _diagnosisDrgType.field.FieldRepetitions.Count > 0)
        {
            _diagnosisDrgType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosisDrgType, fieldData);
        }

        return _diagnosisDrgType;
    } 
}

internal HL7V21Field _majorDiagnosticCategory;

public HL7V21Field MajorDiagnosticCategory
{
    get
    {
        if (_majorDiagnosticCategory != null)
        {
            return _majorDiagnosticCategory;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DG1.7",
            Type = @"Field",
            Position = @"DG1.7",
            Name = @"Major Diagnostic Category",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0118",
            TableName = @"MAJOR DIAGNOSTIC CATEGORY",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _majorDiagnosticCategory = new HL7V21Field
        {
            field = message[@"DG1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_majorDiagnosticCategory.field.FieldRepetitions != null && _majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            _majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_majorDiagnosticCategory, fieldData);
        }

        return _majorDiagnosticCategory;
    } 
}

internal HL7V21Field _diagnosticRelatedGroup;

public HL7V21Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _diagnosticRelatedGroup = new HL7V21Field
        {
            field = message[@"DG1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V21Field _drgApprovalIndicator;

public HL7V21Field DrgApprovalIndicator
{
    get
    {
        if (_drgApprovalIndicator != null)
        {
            return _drgApprovalIndicator;
        }

        var fieldData = new HL7V21FieldData
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
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _drgApprovalIndicator = new HL7V21Field
        {
            field = message[@"DG1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drgApprovalIndicator.field.FieldRepetitions != null && _drgApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _drgApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drgApprovalIndicator, fieldData);
        }

        return _drgApprovalIndicator;
    } 
}

internal HL7V21Field _drgGrouperReviewCode;

public HL7V21Field DrgGrouperReviewCode
{
    get
    {
        if (_drgGrouperReviewCode != null)
        {
            return _drgGrouperReviewCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _drgGrouperReviewCode = new HL7V21Field
        {
            field = message[@"DG1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_drgGrouperReviewCode.field.FieldRepetitions != null && _drgGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            _drgGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_drgGrouperReviewCode, fieldData);
        }

        return _drgGrouperReviewCode;
    } 
}

internal HL7V21Field _outlierType;

public HL7V21Field OutlierType
{
    get
    {
        if (_outlierType != null)
        {
            return _outlierType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"DG1.11",
            Type = @"Field",
            Position = @"DG1.11",
            Name = @"Outlier Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0083",
            TableName = @"OUTLIER TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _outlierType = new HL7V21Field
        {
            field = message[@"DG1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierType.field.FieldRepetitions != null && _outlierType.field.FieldRepetitions.Count > 0)
        {
            _outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_outlierType, fieldData);
        }

        return _outlierType;
    } 
}

internal HL7V21Field _outlierDays;

public HL7V21Field OutlierDays
{
    get
    {
        if (_outlierDays != null)
        {
            return _outlierDays;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _outlierDays = new HL7V21Field
        {
            field = message[@"DG1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierDays.field.FieldRepetitions != null && _outlierDays.field.FieldRepetitions.Count > 0)
        {
            _outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_outlierDays, fieldData);
        }

        return _outlierDays;
    } 
}

internal HL7V21Field _outlierCost;

public HL7V21Field OutlierCost
{
    get
    {
        if (_outlierCost != null)
        {
            return _outlierCost;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _outlierCost = new HL7V21Field
        {
            field = message[@"DG1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_outlierCost.field.FieldRepetitions != null && _outlierCost.field.FieldRepetitions.Count > 0)
        {
            _outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_outlierCost, fieldData);
        }

        return _outlierCost;
    } 
}

internal HL7V21Field _grouperVersionAndType;

public HL7V21Field GrouperVersionAndType
{
    get
    {
        if (_grouperVersionAndType != null)
        {
            return _grouperVersionAndType;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _grouperVersionAndType = new HL7V21Field
        {
            field = message[@"DG1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_grouperVersionAndType.field.FieldRepetitions != null && _grouperVersionAndType.field.FieldRepetitions.Count > 0)
        {
            _grouperVersionAndType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_grouperVersionAndType, fieldData);
        }

        return _grouperVersionAndType;
    } 
}
    }
}

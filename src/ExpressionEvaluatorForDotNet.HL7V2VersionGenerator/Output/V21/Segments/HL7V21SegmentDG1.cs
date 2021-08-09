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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentDG1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdDiagnosis;

public HL7V21Field SetIdDiagnosis
{
    get
    {
        if (setIdDiagnosis != null)
        {
            return setIdDiagnosis;
        }

        setIdDiagnosis = new HL7V21Field
        {
            field = message[@"DG1"][1],
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
        };

        // check for repetitions
        if (setIdDiagnosis.field.FieldRepetitions != null && setIdDiagnosis.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdDiagnosis.Id));
            setIdDiagnosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(setIdDiagnosis, fieldData);
        }

        return setIdDiagnosis;
    } 
}

internal HL7V21Field diagnosisCodingMethod;

public HL7V21Field DiagnosisCodingMethod
{
    get
    {
        if (diagnosisCodingMethod != null)
        {
            return diagnosisCodingMethod;
        }

        diagnosisCodingMethod = new HL7V21Field
        {
            field = message[@"DG1"][2],
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
        };

        // check for repetitions
        if (diagnosisCodingMethod.field.FieldRepetitions != null && diagnosisCodingMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisCodingMethod.Id));
            diagnosisCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosisCodingMethod, fieldData);
        }

        return diagnosisCodingMethod;
    } 
}

internal HL7V21Field diagnosisCode;

public HL7V21Field DiagnosisCode
{
    get
    {
        if (diagnosisCode != null)
        {
            return diagnosisCode;
        }

        diagnosisCode = new HL7V21Field
        {
            field = message[@"DG1"][3],
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
        };

        // check for repetitions
        if (diagnosisCode.field.FieldRepetitions != null && diagnosisCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisCode.Id));
            diagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosisCode, fieldData);
        }

        return diagnosisCode;
    } 
}

internal HL7V21Field diagnosisDescription;

public HL7V21Field DiagnosisDescription
{
    get
    {
        if (diagnosisDescription != null)
        {
            return diagnosisDescription;
        }

        diagnosisDescription = new HL7V21Field
        {
            field = message[@"DG1"][4],
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
        };

        // check for repetitions
        if (diagnosisDescription.field.FieldRepetitions != null && diagnosisDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisDescription.Id));
            diagnosisDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosisDescription, fieldData);
        }

        return diagnosisDescription;
    } 
}

internal HL7V21Field diagnosisDateTime;

public HL7V21Field DiagnosisDateTime
{
    get
    {
        if (diagnosisDateTime != null)
        {
            return diagnosisDateTime;
        }

        diagnosisDateTime = new HL7V21Field
        {
            field = message[@"DG1"][5],
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
        };

        // check for repetitions
        if (diagnosisDateTime.field.FieldRepetitions != null && diagnosisDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisDateTime.Id));
            diagnosisDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosisDateTime, fieldData);
        }

        return diagnosisDateTime;
    } 
}

internal HL7V21Field diagnosisDrgType;

public HL7V21Field DiagnosisDrgType
{
    get
    {
        if (diagnosisDrgType != null)
        {
            return diagnosisDrgType;
        }

        diagnosisDrgType = new HL7V21Field
        {
            field = message[@"DG1"][6],
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
        };

        // check for repetitions
        if (diagnosisDrgType.field.FieldRepetitions != null && diagnosisDrgType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosisDrgType.Id));
            diagnosisDrgType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosisDrgType, fieldData);
        }

        return diagnosisDrgType;
    } 
}

internal HL7V21Field majorDiagnosticCategory;

public HL7V21Field MajorDiagnosticCategory
{
    get
    {
        if (majorDiagnosticCategory != null)
        {
            return majorDiagnosticCategory;
        }

        majorDiagnosticCategory = new HL7V21Field
        {
            field = message[@"DG1"][7],
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
        };

        // check for repetitions
        if (majorDiagnosticCategory.field.FieldRepetitions != null && majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(majorDiagnosticCategory.Id));
            majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(majorDiagnosticCategory, fieldData);
        }

        return majorDiagnosticCategory;
    } 
}

internal HL7V21Field diagnosticRelatedGroup;

public HL7V21Field DiagnosticRelatedGroup
{
    get
    {
        if (diagnosticRelatedGroup != null)
        {
            return diagnosticRelatedGroup;
        }

        diagnosticRelatedGroup = new HL7V21Field
        {
            field = message[@"DG1"][8],
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
        };

        // check for repetitions
        if (diagnosticRelatedGroup.field.FieldRepetitions != null && diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(diagnosticRelatedGroup.Id));
            diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(diagnosticRelatedGroup, fieldData);
        }

        return diagnosticRelatedGroup;
    } 
}

internal HL7V21Field drgApprovalIndicator;

public HL7V21Field DrgApprovalIndicator
{
    get
    {
        if (drgApprovalIndicator != null)
        {
            return drgApprovalIndicator;
        }

        drgApprovalIndicator = new HL7V21Field
        {
            field = message[@"DG1"][9],
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
        };

        // check for repetitions
        if (drgApprovalIndicator.field.FieldRepetitions != null && drgApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(drgApprovalIndicator.Id));
            drgApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(drgApprovalIndicator, fieldData);
        }

        return drgApprovalIndicator;
    } 
}

internal HL7V21Field drgGrouperReviewCode;

public HL7V21Field DrgGrouperReviewCode
{
    get
    {
        if (drgGrouperReviewCode != null)
        {
            return drgGrouperReviewCode;
        }

        drgGrouperReviewCode = new HL7V21Field
        {
            field = message[@"DG1"][10],
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
        };

        // check for repetitions
        if (drgGrouperReviewCode.field.FieldRepetitions != null && drgGrouperReviewCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(drgGrouperReviewCode.Id));
            drgGrouperReviewCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(drgGrouperReviewCode, fieldData);
        }

        return drgGrouperReviewCode;
    } 
}

internal HL7V21Field outlierType;

public HL7V21Field OutlierType
{
    get
    {
        if (outlierType != null)
        {
            return outlierType;
        }

        outlierType = new HL7V21Field
        {
            field = message[@"DG1"][11],
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
        };

        // check for repetitions
        if (outlierType.field.FieldRepetitions != null && outlierType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierType.Id));
            outlierType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(outlierType, fieldData);
        }

        return outlierType;
    } 
}

internal HL7V21Field outlierDays;

public HL7V21Field OutlierDays
{
    get
    {
        if (outlierDays != null)
        {
            return outlierDays;
        }

        outlierDays = new HL7V21Field
        {
            field = message[@"DG1"][12],
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
        };

        // check for repetitions
        if (outlierDays.field.FieldRepetitions != null && outlierDays.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierDays.Id));
            outlierDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(outlierDays, fieldData);
        }

        return outlierDays;
    } 
}

internal HL7V21Field outlierCost;

public HL7V21Field OutlierCost
{
    get
    {
        if (outlierCost != null)
        {
            return outlierCost;
        }

        outlierCost = new HL7V21Field
        {
            field = message[@"DG1"][13],
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
        };

        // check for repetitions
        if (outlierCost.field.FieldRepetitions != null && outlierCost.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(outlierCost.Id));
            outlierCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(outlierCost, fieldData);
        }

        return outlierCost;
    } 
}

internal HL7V21Field grouperVersionAndType;

public HL7V21Field GrouperVersionAndType
{
    get
    {
        if (grouperVersionAndType != null)
        {
            return grouperVersionAndType;
        }

        grouperVersionAndType = new HL7V21Field
        {
            field = message[@"DG1"][14],
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
        };

        // check for repetitions
        if (grouperVersionAndType.field.FieldRepetitions != null && grouperVersionAndType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(grouperVersionAndType.Id));
            grouperVersionAndType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(grouperVersionAndType, fieldData);
        }

        return grouperVersionAndType;
    } 
}
    }
}

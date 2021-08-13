using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentFT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"FT1"; } }

        public string SegmentId { get { return @"FT1"; } }
        
        public string LongName { get { return @"Financial Transaction"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentFT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdFinancialTransaction;

public HL7V21Field SetIdFinancialTransaction
{
    get
    {
        if (_setIdFinancialTransaction != null)
        {
            return _setIdFinancialTransaction;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.1",
            Type = @"Field",
            Position = @"FT1.1",
            Name = @"Set Id - Financial Transaction",
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

        _setIdFinancialTransaction = new HL7V21Field
        {
            field = message[@"FT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdFinancialTransaction.field.FieldRepetitions != null && _setIdFinancialTransaction.field.FieldRepetitions.Count > 0)
        {
            _setIdFinancialTransaction.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdFinancialTransaction, fieldData);
        }

        return _setIdFinancialTransaction;
    } 
}

internal HL7V21Field _transactionId;

public HL7V21Field TransactionId
{
    get
    {
        if (_transactionId != null)
        {
            return _transactionId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.2",
            Type = @"Field",
            Position = @"FT1.2",
            Name = @"Transaction Id",
            Length = 12,
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

        _transactionId = new HL7V21Field
        {
            field = message[@"FT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionId.field.FieldRepetitions != null && _transactionId.field.FieldRepetitions.Count > 0)
        {
            _transactionId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionId, fieldData);
        }

        return _transactionId;
    } 
}

internal HL7V21Field _transactionBatchId;

public HL7V21Field TransactionBatchId
{
    get
    {
        if (_transactionBatchId != null)
        {
            return _transactionBatchId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.3",
            Type = @"Field",
            Position = @"FT1.3",
            Name = @"Transaction Batch Id",
            Length = 5,
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

        _transactionBatchId = new HL7V21Field
        {
            field = message[@"FT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionBatchId.field.FieldRepetitions != null && _transactionBatchId.field.FieldRepetitions.Count > 0)
        {
            _transactionBatchId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionBatchId, fieldData);
        }

        return _transactionBatchId;
    } 
}

internal HL7V21Field _transactionDate;

public HL7V21Field TransactionDate
{
    get
    {
        if (_transactionDate != null)
        {
            return _transactionDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.4",
            Type = @"Field",
            Position = @"FT1.4",
            Name = @"Transaction Date",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transactionDate = new HL7V21Field
        {
            field = message[@"FT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDate.field.FieldRepetitions != null && _transactionDate.field.FieldRepetitions.Count > 0)
        {
            _transactionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionDate, fieldData);
        }

        return _transactionDate;
    } 
}

internal HL7V21Field _transactionPostingDate;

public HL7V21Field TransactionPostingDate
{
    get
    {
        if (_transactionPostingDate != null)
        {
            return _transactionPostingDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.5",
            Type = @"Field",
            Position = @"FT1.5",
            Name = @"Transaction Posting Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transactionPostingDate = new HL7V21Field
        {
            field = message[@"FT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionPostingDate.field.FieldRepetitions != null && _transactionPostingDate.field.FieldRepetitions.Count > 0)
        {
            _transactionPostingDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionPostingDate, fieldData);
        }

        return _transactionPostingDate;
    } 
}

internal HL7V21Field _transactionType;

public HL7V21Field TransactionType
{
    get
    {
        if (_transactionType != null)
        {
            return _transactionType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.6",
            Type = @"Field",
            Position = @"FT1.6",
            Name = @"Transaction Type",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0017",
            TableName = @"TRANSACTION TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transactionType = new HL7V21Field
        {
            field = message[@"FT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionType.field.FieldRepetitions != null && _transactionType.field.FieldRepetitions.Count > 0)
        {
            _transactionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionType, fieldData);
        }

        return _transactionType;
    } 
}

internal HL7V21Field _transactionCode;

public HL7V21Field TransactionCode
{
    get
    {
        if (_transactionCode != null)
        {
            return _transactionCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.7",
            Type = @"Field",
            Position = @"FT1.7",
            Name = @"Transaction Code",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0096",
            TableName = @"FINANCIAL TRANSACTION CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transactionCode = new HL7V21Field
        {
            field = message[@"FT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionCode.field.FieldRepetitions != null && _transactionCode.field.FieldRepetitions.Count > 0)
        {
            _transactionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionCode, fieldData);
        }

        return _transactionCode;
    } 
}

internal HL7V21Field _transactionDescription;

public HL7V21Field TransactionDescription
{
    get
    {
        if (_transactionDescription != null)
        {
            return _transactionDescription;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.8",
            Type = @"Field",
            Position = @"FT1.8",
            Name = @"Transaction Description",
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

        _transactionDescription = new HL7V21Field
        {
            field = message[@"FT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescription.field.FieldRepetitions != null && _transactionDescription.field.FieldRepetitions.Count > 0)
        {
            _transactionDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionDescription, fieldData);
        }

        return _transactionDescription;
    } 
}

internal HL7V21Field _transactionDescriptionAlt;

public HL7V21Field TransactionDescriptionAlt
{
    get
    {
        if (_transactionDescriptionAlt != null)
        {
            return _transactionDescriptionAlt;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.9",
            Type = @"Field",
            Position = @"FT1.9",
            Name = @"Transaction Description - Alt",
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

        _transactionDescriptionAlt = new HL7V21Field
        {
            field = message[@"FT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionDescriptionAlt.field.FieldRepetitions != null && _transactionDescriptionAlt.field.FieldRepetitions.Count > 0)
        {
            _transactionDescriptionAlt.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionDescriptionAlt, fieldData);
        }

        return _transactionDescriptionAlt;
    } 
}

internal HL7V21Field _transactionAmountExtended;

public HL7V21Field TransactionAmountExtended
{
    get
    {
        if (_transactionAmountExtended != null)
        {
            return _transactionAmountExtended;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.10",
            Type = @"Field",
            Position = @"FT1.10",
            Name = @"Transaction Amount - Extended",
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

        _transactionAmountExtended = new HL7V21Field
        {
            field = message[@"FT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountExtended.field.FieldRepetitions != null && _transactionAmountExtended.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountExtended.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionAmountExtended, fieldData);
        }

        return _transactionAmountExtended;
    } 
}

internal HL7V21Field _transactionQuantity;

public HL7V21Field TransactionQuantity
{
    get
    {
        if (_transactionQuantity != null)
        {
            return _transactionQuantity;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.11",
            Type = @"Field",
            Position = @"FT1.11",
            Name = @"Transaction Quantity",
            Length = 4,
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

        _transactionQuantity = new HL7V21Field
        {
            field = message[@"FT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionQuantity.field.FieldRepetitions != null && _transactionQuantity.field.FieldRepetitions.Count > 0)
        {
            _transactionQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionQuantity, fieldData);
        }

        return _transactionQuantity;
    } 
}

internal HL7V21Field _transactionAmountUnit;

public HL7V21Field TransactionAmountUnit
{
    get
    {
        if (_transactionAmountUnit != null)
        {
            return _transactionAmountUnit;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.12",
            Type = @"Field",
            Position = @"FT1.12",
            Name = @"Transaction Amount - Unit",
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

        _transactionAmountUnit = new HL7V21Field
        {
            field = message[@"FT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transactionAmountUnit.field.FieldRepetitions != null && _transactionAmountUnit.field.FieldRepetitions.Count > 0)
        {
            _transactionAmountUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transactionAmountUnit, fieldData);
        }

        return _transactionAmountUnit;
    } 
}

internal HL7V21Field _departmentCode;

public HL7V21Field DepartmentCode
{
    get
    {
        if (_departmentCode != null)
        {
            return _departmentCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.13",
            Type = @"Field",
            Position = @"FT1.13",
            Name = @"Department Code",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0049",
            TableName = @"DEPARTMENT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _departmentCode = new HL7V21Field
        {
            field = message[@"FT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_departmentCode.field.FieldRepetitions != null && _departmentCode.field.FieldRepetitions.Count > 0)
        {
            _departmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_departmentCode, fieldData);
        }

        return _departmentCode;
    } 
}

internal HL7V21Field _insurancePlanId;

public HL7V21Field InsurancePlanId
{
    get
    {
        if (_insurancePlanId != null)
        {
            return _insurancePlanId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.14",
            Type = @"Field",
            Position = @"FT1.14",
            Name = @"Insurance Plan Id",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insurancePlanId = new HL7V21Field
        {
            field = message[@"FT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanId.field.FieldRepetitions != null && _insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insurancePlanId, fieldData);
        }

        return _insurancePlanId;
    } 
}

internal HL7V21Field _insuranceAmount;

public HL7V21Field InsuranceAmount
{
    get
    {
        if (_insuranceAmount != null)
        {
            return _insuranceAmount;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.15",
            Type = @"Field",
            Position = @"FT1.15",
            Name = @"Insurance Amount",
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

        _insuranceAmount = new HL7V21Field
        {
            field = message[@"FT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceAmount.field.FieldRepetitions != null && _insuranceAmount.field.FieldRepetitions.Count > 0)
        {
            _insuranceAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceAmount, fieldData);
        }

        return _insuranceAmount;
    } 
}

internal HL7V21Field _patientLocation;

public HL7V21Field PatientLocation
{
    get
    {
        if (_patientLocation != null)
        {
            return _patientLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.16",
            Type = @"Field",
            Position = @"FT1.16",
            Name = @"Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientLocation = new HL7V21Field
        {
            field = message[@"FT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientLocation.field.FieldRepetitions != null && _patientLocation.field.FieldRepetitions.Count > 0)
        {
            _patientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientLocation, fieldData);
        }

        return _patientLocation;
    } 
}

internal HL7V21Field _feeSchedule;

public HL7V21Field FeeSchedule
{
    get
    {
        if (_feeSchedule != null)
        {
            return _feeSchedule;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.17",
            Type = @"Field",
            Position = @"FT1.17",
            Name = @"Fee Schedule",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0024",
            TableName = @"FEE SCHEDULE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _feeSchedule = new HL7V21Field
        {
            field = message[@"FT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_feeSchedule.field.FieldRepetitions != null && _feeSchedule.field.FieldRepetitions.Count > 0)
        {
            _feeSchedule.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_feeSchedule, fieldData);
        }

        return _feeSchedule;
    } 
}

internal HL7V21Field _patientType;

public HL7V21Field PatientType
{
    get
    {
        if (_patientType != null)
        {
            return _patientType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.18",
            Type = @"Field",
            Position = @"FT1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0018",
            TableName = @"PATIENT TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientType = new HL7V21Field
        {
            field = message[@"FT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientType.field.FieldRepetitions != null && _patientType.field.FieldRepetitions.Count > 0)
        {
            _patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientType, fieldData);
        }

        return _patientType;
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
            Id = @"FT1.19",
            Type = @"Field",
            Position = @"FT1.19",
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
            field = message[@"FT1"][19],
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

internal HL7V21Field _performedByCode;

public HL7V21Field PerformedByCode
{
    get
    {
        if (_performedByCode != null)
        {
            return _performedByCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.20",
            Type = @"Field",
            Position = @"FT1.20",
            Name = @"Performed By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0084",
            TableName = @"PERFORMED BY CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _performedByCode = new HL7V21Field
        {
            field = message[@"FT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_performedByCode.field.FieldRepetitions != null && _performedByCode.field.FieldRepetitions.Count > 0)
        {
            _performedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_performedByCode, fieldData);
        }

        return _performedByCode;
    } 
}

internal HL7V21Field _orderedByCode;

public HL7V21Field OrderedByCode
{
    get
    {
        if (_orderedByCode != null)
        {
            return _orderedByCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.21",
            Type = @"Field",
            Position = @"FT1.21",
            Name = @"Ordered By Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _orderedByCode = new HL7V21Field
        {
            field = message[@"FT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderedByCode.field.FieldRepetitions != null && _orderedByCode.field.FieldRepetitions.Count > 0)
        {
            _orderedByCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_orderedByCode, fieldData);
        }

        return _orderedByCode;
    } 
}

internal HL7V21Field _unitCost;

public HL7V21Field UnitCost
{
    get
    {
        if (_unitCost != null)
        {
            return _unitCost;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"FT1.22",
            Type = @"Field",
            Position = @"FT1.22",
            Name = @"Unit Cost",
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

        _unitCost = new HL7V21Field
        {
            field = message[@"FT1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unitCost.field.FieldRepetitions != null && _unitCost.field.FieldRepetitions.Count > 0)
        {
            _unitCost.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_unitCost, fieldData);
        }

        return _unitCost;
    } 
}
    }
}

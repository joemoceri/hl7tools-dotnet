using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Ub82 Data"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdUb82;

public HL7V21Field SetIdUb82
{
    get
    {
        if (_setIdUb82 != null)
        {
            return _setIdUb82;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set Id - Ub82",
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

        _setIdUb82 = new HL7V21Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdUb82.field.FieldRepetitions != null && _setIdUb82.field.FieldRepetitions.Count > 0)
        {
            _setIdUb82.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdUb82, fieldData);
        }

        return _setIdUb82;
    } 
}

internal HL7V21Field _bloodDeductible;

public HL7V21Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible",
            Length = 1,
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

        _bloodDeductible = new HL7V21Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V21Field _bloodFurnpintsOf40;

public HL7V21Field BloodFurnpintsOf40
{
    get
    {
        if (_bloodFurnpintsOf40 != null)
        {
            return _bloodFurnpintsOf40;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furn.-pints Of (40)",
            Length = 2,
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

        _bloodFurnpintsOf40 = new HL7V21Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnpintsOf40.field.FieldRepetitions != null && _bloodFurnpintsOf40.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnpintsOf40.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bloodFurnpintsOf40, fieldData);
        }

        return _bloodFurnpintsOf40;
    } 
}

internal HL7V21Field _bloodReplacedpints41;

public HL7V21Field BloodReplacedpints41
{
    get
    {
        if (_bloodReplacedpints41 != null)
        {
            return _bloodReplacedpints41;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-pints (41)",
            Length = 2,
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

        _bloodReplacedpints41 = new HL7V21Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedpints41.field.FieldRepetitions != null && _bloodReplacedpints41.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedpints41.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bloodReplacedpints41, fieldData);
        }

        return _bloodReplacedpints41;
    } 
}

internal HL7V21Field _bloodNotRplcdpints42;

public HL7V21Field BloodNotRplcdpints42
{
    get
    {
        if (_bloodNotRplcdpints42 != null)
        {
            return _bloodNotRplcdpints42;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Rplcd-pints(42)",
            Length = 2,
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

        _bloodNotRplcdpints42 = new HL7V21Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotRplcdpints42.field.FieldRepetitions != null && _bloodNotRplcdpints42.field.FieldRepetitions.Count > 0)
        {
            _bloodNotRplcdpints42.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bloodNotRplcdpints42, fieldData);
        }

        return _bloodNotRplcdpints42;
    } 
}

internal HL7V21Field _coinsuranceDays25;

public HL7V21Field CoinsuranceDays25
{
    get
    {
        if (_coinsuranceDays25 != null)
        {
            return _coinsuranceDays25;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-insurance Days (25)",
            Length = 2,
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

        _coinsuranceDays25 = new HL7V21Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coinsuranceDays25.field.FieldRepetitions != null && _coinsuranceDays25.field.FieldRepetitions.Count > 0)
        {
            _coinsuranceDays25.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_coinsuranceDays25, fieldData);
        }

        return _coinsuranceDays25;
    } 
}

internal HL7V21Field _conditionCode;

public HL7V21Field ConditionCode
{
    get
    {
        if (_conditionCode != null)
        {
            return _conditionCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0043",
            TableName = @"CONDITION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V21Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode.field.FieldRepetitions != null && _conditionCode.field.FieldRepetitions.Count > 0)
        {
            _conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_conditionCode, fieldData);
        }

        return _conditionCode;
    } 
}

internal HL7V21Field _coveredDays23;

public HL7V21Field CoveredDays23
{
    get
    {
        if (_coveredDays23 != null)
        {
            return _coveredDays23;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days - (23)",
            Length = 3,
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

        _coveredDays23 = new HL7V21Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays23.field.FieldRepetitions != null && _coveredDays23.field.FieldRepetitions.Count > 0)
        {
            _coveredDays23.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_coveredDays23, fieldData);
        }

        return _coveredDays23;
    } 
}

internal HL7V21Field _nonCoveredDays24;

public HL7V21Field NonCoveredDays24
{
    get
    {
        if (_nonCoveredDays24 != null)
        {
            return _nonCoveredDays24;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days - (24)",
            Length = 3,
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

        _nonCoveredDays24 = new HL7V21Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays24.field.FieldRepetitions != null && _nonCoveredDays24.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays24.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nonCoveredDays24, fieldData);
        }

        return _nonCoveredDays24;
    } 
}

internal HL7V21Field _valueAmountAndCode;

public HL7V21Field ValueAmountAndCode
{
    get
    {
        if (_valueAmountAndCode != null)
        {
            return _valueAmountAndCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 12,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _valueAmountAndCode = new HL7V21Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode.field.FieldRepetitions != null && _valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_valueAmountAndCode, fieldData);
        }

        return _valueAmountAndCode;
    } 
}

internal HL7V21Field _numberOfGraceDays90;

public HL7V21Field NumberOfGraceDays90
{
    get
    {
        if (_numberOfGraceDays90 != null)
        {
            return _numberOfGraceDays90;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days (90)",
            Length = 2,
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

        _numberOfGraceDays90 = new HL7V21Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays90.field.FieldRepetitions != null && _numberOfGraceDays90.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays90.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_numberOfGraceDays90, fieldData);
        }

        return _numberOfGraceDays90;
    } 
}

internal HL7V21Field _specProgIndicator44;

public HL7V21Field SpecProgIndicator44
{
    get
    {
        if (_specProgIndicator44 != null)
        {
            return _specProgIndicator44;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Spec. Prog. Indicator(44)",
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

        _specProgIndicator44 = new HL7V21Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specProgIndicator44.field.FieldRepetitions != null && _specProgIndicator44.field.FieldRepetitions.Count > 0)
        {
            _specProgIndicator44.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_specProgIndicator44, fieldData);
        }

        return _specProgIndicator44;
    } 
}

internal HL7V21Field _psroUrApprovalInd87;

public HL7V21Field PsroUrApprovalInd87
{
    get
    {
        if (_psroUrApprovalInd87 != null)
        {
            return _psroUrApprovalInd87;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"Psro/Ur Approval Ind. (87)",
            Length = 1,
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

        _psroUrApprovalInd87 = new HL7V21Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovalInd87.field.FieldRepetitions != null && _psroUrApprovalInd87.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovalInd87.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_psroUrApprovalInd87, fieldData);
        }

        return _psroUrApprovalInd87;
    } 
}

internal HL7V21Field _psroUrAprvdStayfm88;

public HL7V21Field PsroUrAprvdStayfm88
{
    get
    {
        if (_psroUrAprvdStayfm88 != null)
        {
            return _psroUrAprvdStayfm88;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"Psro/Ur Aprvd Stay-fm(88)",
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

        _psroUrAprvdStayfm88 = new HL7V21Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrAprvdStayfm88.field.FieldRepetitions != null && _psroUrAprvdStayfm88.field.FieldRepetitions.Count > 0)
        {
            _psroUrAprvdStayfm88.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_psroUrAprvdStayfm88, fieldData);
        }

        return _psroUrAprvdStayfm88;
    } 
}

internal HL7V21Field _psroUrAprvdStayto89;

public HL7V21Field PsroUrAprvdStayto89
{
    get
    {
        if (_psroUrAprvdStayto89 != null)
        {
            return _psroUrAprvdStayto89;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"Psro/Ur Aprvd Stay-to(89)",
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

        _psroUrAprvdStayto89 = new HL7V21Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrAprvdStayto89.field.FieldRepetitions != null && _psroUrAprvdStayto89.field.FieldRepetitions.Count > 0)
        {
            _psroUrAprvdStayto89.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_psroUrAprvdStayto89, fieldData);
        }

        return _psroUrAprvdStayto89;
    } 
}

internal HL7V21Field _occurrence2832;

public HL7V21Field Occurrence2832
{
    get
    {
        if (_occurrence2832 != null)
        {
            return _occurrence2832;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence (28-32)",
            Length = 20,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _occurrence2832 = new HL7V21Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence2832.field.FieldRepetitions != null && _occurrence2832.field.FieldRepetitions.Count > 0)
        {
            _occurrence2832.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_occurrence2832, fieldData);
        }

        return _occurrence2832;
    } 
}

internal HL7V21Field _occurrenceSpan33;

public HL7V21Field OccurrenceSpan33
{
    get
    {
        if (_occurrenceSpan33 != null)
        {
            return _occurrenceSpan33;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span (33)",
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

        _occurrenceSpan33 = new HL7V21Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan33.field.FieldRepetitions != null && _occurrenceSpan33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan33.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_occurrenceSpan33, fieldData);
        }

        return _occurrenceSpan33;
    } 
}

internal HL7V21Field _occurrenceSpanStartDate33;

public HL7V21Field OccurrenceSpanStartDate33
{
    get
    {
        if (_occurrenceSpanStartDate33 != null)
        {
            return _occurrenceSpanStartDate33;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occurrence Span Start Date(33)",
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

        _occurrenceSpanStartDate33 = new HL7V21Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanStartDate33.field.FieldRepetitions != null && _occurrenceSpanStartDate33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanStartDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_occurrenceSpanStartDate33, fieldData);
        }

        return _occurrenceSpanStartDate33;
    } 
}

internal HL7V21Field _occurSpanEndDate33;

public HL7V21Field OccurSpanEndDate33
{
    get
    {
        if (_occurSpanEndDate33 != null)
        {
            return _occurSpanEndDate33;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur. Span End Date (33)",
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

        _occurSpanEndDate33 = new HL7V21Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanEndDate33.field.FieldRepetitions != null && _occurSpanEndDate33.field.FieldRepetitions.Count > 0)
        {
            _occurSpanEndDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_occurSpanEndDate33, fieldData);
        }

        return _occurSpanEndDate33;
    } 
}

internal HL7V21Field _ub82Locator2;

public HL7V21Field Ub82Locator2
{
    get
    {
        if (_ub82Locator2 != null)
        {
            return _ub82Locator2;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"Ub-82 Locator 2",
            Length = 30,
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

        _ub82Locator2 = new HL7V21Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator2.field.FieldRepetitions != null && _ub82Locator2.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ub82Locator2, fieldData);
        }

        return _ub82Locator2;
    } 
}

internal HL7V21Field _ub82Locator9;

public HL7V21Field Ub82Locator9
{
    get
    {
        if (_ub82Locator9 != null)
        {
            return _ub82Locator9;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"Ub-82 Locator 9",
            Length = 7,
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

        _ub82Locator9 = new HL7V21Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator9.field.FieldRepetitions != null && _ub82Locator9.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ub82Locator9, fieldData);
        }

        return _ub82Locator9;
    } 
}

internal HL7V21Field _ub82Locator27;

public HL7V21Field Ub82Locator27
{
    get
    {
        if (_ub82Locator27 != null)
        {
            return _ub82Locator27;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"Ub-82 Locator 27",
            Length = 8,
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

        _ub82Locator27 = new HL7V21Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator27.field.FieldRepetitions != null && _ub82Locator27.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ub82Locator27, fieldData);
        }

        return _ub82Locator27;
    } 
}

internal HL7V21Field _ub82Locator45;

public HL7V21Field Ub82Locator45
{
    get
    {
        if (_ub82Locator45 != null)
        {
            return _ub82Locator45;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"Ub-82 Locator 45",
            Length = 17,
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

        _ub82Locator45 = new HL7V21Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator45.field.FieldRepetitions != null && _ub82Locator45.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ub82Locator45, fieldData);
        }

        return _ub82Locator45;
    } 
}
    }
}

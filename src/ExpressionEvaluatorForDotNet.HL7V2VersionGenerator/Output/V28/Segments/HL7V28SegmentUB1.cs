using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Ub82"; } }
        
        public string Description { get { return @"The UB1 segment contains data specific to the United States. Only billing/claims fields that do not exist in other HL7 defined segments appear in this segment. The codes listed as examples are not an exhaustive or current list.

Attention: UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6."; } }
        
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

        public HL7V28SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field _setIdUb1;

public HL7V28Field SetIdUb1
{
    get
    {
        if (_setIdUb1 != null)
        {
            return _setIdUb1;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set Id - Ub1",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-1 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _setIdUb1 = new HL7V28Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdUb1.field.FieldRepetitions != null && _setIdUb1.field.FieldRepetitions.Count > 0)
        {
            _setIdUb1.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_setIdUb1, fieldData);
        }

        return _setIdUb1;
    } 
}

internal HL7V28Field _bloodDeductible;

public HL7V28Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible = new HL7V28Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V28Field _bloodFurnishedpints;

public HL7V28Field BloodFurnishedpints
{
    get
    {
        if (_bloodFurnishedpints != null)
        {
            return _bloodFurnishedpints;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-3 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _bloodFurnishedpints = new HL7V28Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnishedpints.field.FieldRepetitions != null && _bloodFurnishedpints.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnishedpints.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_bloodFurnishedpints, fieldData);
        }

        return _bloodFurnishedpints;
    } 
}

internal HL7V28Field _bloodReplacedpints;

public HL7V28Field BloodReplacedpints
{
    get
    {
        if (_bloodReplacedpints != null)
        {
            return _bloodReplacedpints;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _bloodReplacedpints = new HL7V28Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedpints.field.FieldRepetitions != null && _bloodReplacedpints.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedpints.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_bloodReplacedpints, fieldData);
        }

        return _bloodReplacedpints;
    } 
}

internal HL7V28Field _bloodNotReplacedpints;

public HL7V28Field BloodNotReplacedpints
{
    get
    {
        if (_bloodNotReplacedpints != null)
        {
            return _bloodNotReplacedpints;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced-pints",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-5 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _bloodNotReplacedpints = new HL7V28Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotReplacedpints.field.FieldRepetitions != null && _bloodNotReplacedpints.field.FieldRepetitions.Count > 0)
        {
            _bloodNotReplacedpints.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_bloodNotReplacedpints, fieldData);
        }

        return _bloodNotReplacedpints;
    } 
}

internal HL7V28Field _coinsuranceDays;

public HL7V28Field CoinsuranceDays
{
    get
    {
        if (_coinsuranceDays != null)
        {
            return _coinsuranceDays;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-insurance Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-6 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _coinsuranceDays = new HL7V28Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coinsuranceDays.field.FieldRepetitions != null && _coinsuranceDays.field.FieldRepetitions.Count > 0)
        {
            _coinsuranceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_coinsuranceDays, fieldData);
        }

        return _coinsuranceDays;
    } 
}

internal HL7V28Field _conditionCode;

public HL7V28Field ConditionCode
{
    get
    {
        if (_conditionCode != null)
        {
            return _conditionCode;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 0,
            Usage = @"W",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-7 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V28Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode.field.FieldRepetitions != null && _conditionCode.field.FieldRepetitions.Count > 0)
        {
            _conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_conditionCode, fieldData);
        }

        return _conditionCode;
    } 
}

internal HL7V28Field _coveredDays;

public HL7V28Field CoveredDays
{
    get
    {
        if (_coveredDays != null)
        {
            return _coveredDays;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _coveredDays = new HL7V28Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays.field.FieldRepetitions != null && _coveredDays.field.FieldRepetitions.Count > 0)
        {
            _coveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_coveredDays, fieldData);
        }

        return _coveredDays;
    } 
}

internal HL7V28Field _nonCoveredDays;

public HL7V28Field NonCoveredDays
{
    get
    {
        if (_nonCoveredDays != null)
        {
            return _nonCoveredDays;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-9 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays = new HL7V28Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays.field.FieldRepetitions != null && _nonCoveredDays.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_nonCoveredDays, fieldData);
        }

        return _nonCoveredDays;
    } 
}

internal HL7V28Field _valueAmountAndCode;

public HL7V28Field ValueAmountAndCode
{
    get
    {
        if (_valueAmountAndCode != null)
        {
            return _valueAmountAndCode;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 0,
            Usage = @"W",
            Rpt = @"8",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-10 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _valueAmountAndCode = new HL7V28Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode.field.FieldRepetitions != null && _valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_valueAmountAndCode, fieldData);
        }

        return _valueAmountAndCode;
    } 
}

internal HL7V28Field _numberOfGraceDays;

public HL7V28Field NumberOfGraceDays
{
    get
    {
        if (_numberOfGraceDays != null)
        {
            return _numberOfGraceDays;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _numberOfGraceDays = new HL7V28Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays.field.FieldRepetitions != null && _numberOfGraceDays.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_numberOfGraceDays, fieldData);
        }

        return _numberOfGraceDays;
    } 
}

internal HL7V28Field _specialProgramIndicator;

public HL7V28Field SpecialProgramIndicator
{
    get
    {
        if (_specialProgramIndicator != null)
        {
            return _specialProgramIndicator;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _specialProgramIndicator = new HL7V28Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramIndicator.field.FieldRepetitions != null && _specialProgramIndicator.field.FieldRepetitions.Count > 0)
        {
            _specialProgramIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_specialProgramIndicator, fieldData);
        }

        return _specialProgramIndicator;
    } 
}

internal HL7V28Field _psroUrApprovalIndicator;

public HL7V28Field PsroUrApprovalIndicator
{
    get
    {
        if (_psroUrApprovalIndicator != null)
        {
            return _psroUrApprovalIndicator;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"Psro/Ur Approval Indicator",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-13 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovalIndicator = new HL7V28Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovalIndicator.field.FieldRepetitions != null && _psroUrApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_psroUrApprovalIndicator, fieldData);
        }

        return _psroUrApprovalIndicator;
    } 
}

internal HL7V28Field _psroUrApprovedStayfm;

public HL7V28Field PsroUrApprovedStayfm
{
    get
    {
        if (_psroUrApprovedStayfm != null)
        {
            return _psroUrApprovedStayfm;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"Psro/Ur Approved Stay-fm",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-14 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovedStayfm = new HL7V28Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovedStayfm.field.FieldRepetitions != null && _psroUrApprovedStayfm.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovedStayfm.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_psroUrApprovedStayfm, fieldData);
        }

        return _psroUrApprovedStayfm;
    } 
}

internal HL7V28Field _psroUrApprovedStayto;

public HL7V28Field PsroUrApprovedStayto
{
    get
    {
        if (_psroUrApprovedStayto != null)
        {
            return _psroUrApprovedStayto;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"Psro/Ur Approved Stay-to",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-15 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovedStayto = new HL7V28Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovedStayto.field.FieldRepetitions != null && _psroUrApprovedStayto.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovedStayto.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_psroUrApprovedStayto, fieldData);
        }

        return _psroUrApprovedStayto;
    } 
}

internal HL7V28Field _occurrence;

public HL7V28Field Occurrence
{
    get
    {
        if (_occurrence != null)
        {
            return _occurrence;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence",
            Length = 0,
            Usage = @"W",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-16 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _occurrence = new HL7V28Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence.field.FieldRepetitions != null && _occurrence.field.FieldRepetitions.Count > 0)
        {
            _occurrence.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_occurrence, fieldData);
        }

        return _occurrence;
    } 
}

internal HL7V28Field _occurrenceSpan;

public HL7V28Field OccurrenceSpan
{
    get
    {
        if (_occurrenceSpan != null)
        {
            return _occurrenceSpan;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-17 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _occurrenceSpan = new HL7V28Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan.field.FieldRepetitions != null && _occurrenceSpan.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_occurrenceSpan, fieldData);
        }

        return _occurrenceSpan;
    } 
}

internal HL7V28Field _occurSpanStartDate;

public HL7V28Field OccurSpanStartDate
{
    get
    {
        if (_occurSpanStartDate != null)
        {
            return _occurSpanStartDate;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-18 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _occurSpanStartDate = new HL7V28Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanStartDate.field.FieldRepetitions != null && _occurSpanStartDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_occurSpanStartDate, fieldData);
        }

        return _occurSpanStartDate;
    } 
}

internal HL7V28Field _occurSpanEndDate;

public HL7V28Field OccurSpanEndDate
{
    get
    {
        if (_occurSpanEndDate != null)
        {
            return _occurSpanEndDate;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-19 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _occurSpanEndDate = new HL7V28Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanEndDate.field.FieldRepetitions != null && _occurSpanEndDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_occurSpanEndDate, fieldData);
        }

        return _occurSpanEndDate;
    } 
}

internal HL7V28Field _ub82Locator2;

public HL7V28Field Ub82Locator2
{
    get
    {
        if (_ub82Locator2 != null)
        {
            return _ub82Locator2;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"Ub-82 Locator 2",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-20 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _ub82Locator2 = new HL7V28Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator2.field.FieldRepetitions != null && _ub82Locator2.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_ub82Locator2, fieldData);
        }

        return _ub82Locator2;
    } 
}

internal HL7V28Field _ub82Locator9;

public HL7V28Field Ub82Locator9
{
    get
    {
        if (_ub82Locator9 != null)
        {
            return _ub82Locator9;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"Ub-82 Locator 9",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-21 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _ub82Locator9 = new HL7V28Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator9.field.FieldRepetitions != null && _ub82Locator9.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_ub82Locator9, fieldData);
        }

        return _ub82Locator9;
    } 
}

internal HL7V28Field _ub82Locator27;

public HL7V28Field Ub82Locator27
{
    get
    {
        if (_ub82Locator27 != null)
        {
            return _ub82Locator27;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"Ub-82 Locator 27",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-22 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _ub82Locator27 = new HL7V28Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator27.field.FieldRepetitions != null && _ub82Locator27.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_ub82Locator27, fieldData);
        }

        return _ub82Locator27;
    } 
}

internal HL7V28Field _ub82Locator45;

public HL7V28Field Ub82Locator45
{
    get
    {
        if (_ub82Locator45 != null)
        {
            return _ub82Locator45;
        }

        var fieldData = new HL7V28FieldData
        {
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"Ub-82 Locator 45",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: UB1-23 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6.",
            Sample = @"",
            Fields = null
        }

        _ub82Locator45 = new HL7V28Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator45.field.FieldRepetitions != null && _ub82Locator45.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(_ub82Locator45, fieldData);
        }

        return _ub82Locator45;
    } 
}
    }
}

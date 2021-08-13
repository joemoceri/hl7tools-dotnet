using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Ub82 Data"; } }
        
        public string Description { get { return @"The UB1 segment contains data necessary to complete UB82 bills.  Only UB82 data elements that do not exist in other HL7 defined segments will appear in this segment.  Patient name and Date of Birth are required for UB82 billing, however, they are included in the PID segment and therefore do not appear here"; } }
        
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

        public HL7V22SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdUb82;

public HL7V22Field SetIdUb82
{
    get
    {
        if (_setIdUb82 != null)
        {
            return _setIdUb82;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set Id - Ub82",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number used to uniquely identify the transaction for the purpose of adding, changing, or deleting the entry",
            Sample = @"",
            Fields = null
        }

        _setIdUb82 = new HL7V22Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdUb82.field.FieldRepetitions != null && _setIdUb82.field.FieldRepetitions.Count > 0)
        {
            _setIdUb82.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdUb82, fieldData);
        }

        return _setIdUb82;
    } 
}

internal HL7V22Field _bloodDeductible43;

public HL7V22Field BloodDeductible43
{
    get
    {
        if (_bloodDeductible43 != null)
        {
            return _bloodDeductible43;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible (43)",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"It is recommended that IN2-21-blood deductible be used instead of this field as the blood deductible can be associated with the specific insurance plan via that segment",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible43 = new HL7V22Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible43.field.FieldRepetitions != null && _bloodDeductible43.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible43.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bloodDeductible43, fieldData);
        }

        return _bloodDeductible43;
    } 
}

internal HL7V22Field _bloodFurnishedPintsOf40;

public HL7V22Field BloodFurnishedPintsOf40
{
    get
    {
        if (_bloodFurnishedPintsOf40 != null)
        {
            return _bloodFurnishedPintsOf40;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished Pints Of (40)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount of blood furnished the patient for this visit.  The (40) indicates the corresponding UB82 Data Element number",
            Sample = @"",
            Fields = null
        }

        _bloodFurnishedPintsOf40 = new HL7V22Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnishedPintsOf40.field.FieldRepetitions != null && _bloodFurnishedPintsOf40.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnishedPintsOf40.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bloodFurnishedPintsOf40, fieldData);
        }

        return _bloodFurnishedPintsOf40;
    } 
}

internal HL7V22Field _bloodReplacedPints41;

public HL7V22Field BloodReplacedPints41
{
    get
    {
        if (_bloodReplacedPints41 != null)
        {
            return _bloodReplacedPints41;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced Pints (41)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 41.",
            Sample = @"",
            Fields = null
        }

        _bloodReplacedPints41 = new HL7V22Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedPints41.field.FieldRepetitions != null && _bloodReplacedPints41.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedPints41.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bloodReplacedPints41, fieldData);
        }

        return _bloodReplacedPints41;
    } 
}

internal HL7V22Field _bloodNotReplacedPints42;

public HL7V22Field BloodNotReplacedPints42
{
    get
    {
        if (_bloodNotReplacedPints42 != null)
        {
            return _bloodNotReplacedPints42;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced Pints (42)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Blood not replaced.  Measured in pints.  UB82 Data Element 42 ",
            Sample = @"",
            Fields = null
        }

        _bloodNotReplacedPints42 = new HL7V22Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotReplacedPints42.field.FieldRepetitions != null && _bloodNotReplacedPints42.field.FieldRepetitions.Count > 0)
        {
            _bloodNotReplacedPints42.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bloodNotReplacedPints42, fieldData);
        }

        return _bloodNotReplacedPints42;
    } 
}

internal HL7V22Field _coinsuranceDays25;

public HL7V22Field CoinsuranceDays25
{
    get
    {
        if (_coinsuranceDays25 != null)
        {
            return _coinsuranceDays25;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-insurance Days (25)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 25.",
            Sample = @"",
            Fields = null
        }

        _coinsuranceDays25 = new HL7V22Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coinsuranceDays25.field.FieldRepetitions != null && _coinsuranceDays25.field.FieldRepetitions.Count > 0)
        {
            _coinsuranceDays25.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coinsuranceDays25, fieldData);
        }

        return _coinsuranceDays25;
    } 
}

internal HL7V22Field _conditionCode3539;

public HL7V22Field ConditionCode3539
{
    get
    {
        if (_conditionCode3539 != null)
        {
            return _conditionCode3539;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code (35-39)",
            Length = 2,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0043",
            TableName = @"CONDITION CODE",
            Description = @"repeats 5 times.  UB82 Data Elements (35), (36), (37), (38),and (39).   Refer to user-defined table 0043 - condition code for suggested values",
            Sample = @"",
            Fields = null
        }

        _conditionCode3539 = new HL7V22Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode3539.field.FieldRepetitions != null && _conditionCode3539.field.FieldRepetitions.Count > 0)
        {
            _conditionCode3539.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_conditionCode3539, fieldData);
        }

        return _conditionCode3539;
    } 
}

internal HL7V22Field _coveredDays23;

public HL7V22Field CoveredDays23
{
    get
    {
        if (_coveredDays23 != null)
        {
            return _coveredDays23;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days (23)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 23",
            Sample = @"",
            Fields = null
        }

        _coveredDays23 = new HL7V22Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays23.field.FieldRepetitions != null && _coveredDays23.field.FieldRepetitions.Count > 0)
        {
            _coveredDays23.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coveredDays23, fieldData);
        }

        return _coveredDays23;
    } 
}

internal HL7V22Field _noncoveredDays24;

public HL7V22Field NoncoveredDays24
{
    get
    {
        if (_noncoveredDays24 != null)
        {
            return _noncoveredDays24;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non-covered Days (24)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 24",
            Sample = @"",
            Fields = null
        }

        _noncoveredDays24 = new HL7V22Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noncoveredDays24.field.FieldRepetitions != null && _noncoveredDays24.field.FieldRepetitions.Count > 0)
        {
            _noncoveredDays24.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_noncoveredDays24, fieldData);
        }

        return _noncoveredDays24;
    } 
}

internal HL7V22Field _valueAmountAndCode4649;

public HL7V22Field ValueAmountAndCode4649
{
    get
    {
        if (_valueAmountAndCode4649 != null)
        {
            return _valueAmountAndCode4649;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount And Code (46-49)",
            Length = 12,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM_UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"pair can repeat up to eight times.  (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B).  Refer to userdefined table 0153 - value code for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.10.1",
                            Type = @"Component",
                            Position = @"UB1.10.1",
                            Name = @"Value Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0153",
                            TableName = @"VALUE CODE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.2",
                            Type = @"Component",
                            Position = @"UB1.10.2",
                            Name = @"Value Amount",
                            Length = 0,
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
                        }
        }

        _valueAmountAndCode4649 = new HL7V22Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode4649.field.FieldRepetitions != null && _valueAmountAndCode4649.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode4649.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_valueAmountAndCode4649, fieldData);
        }

        return _valueAmountAndCode4649;
    } 
}

internal HL7V22Field _numberOfGraceDays90;

public HL7V22Field NumberOfGraceDays90
{
    get
    {
        if (_numberOfGraceDays90 != null)
        {
            return _numberOfGraceDays90;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days (90)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"UB82 Data Element 90",
            Sample = @"",
            Fields = null
        }

        _numberOfGraceDays90 = new HL7V22Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays90.field.FieldRepetitions != null && _numberOfGraceDays90.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays90.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_numberOfGraceDays90, fieldData);
        }

        return _numberOfGraceDays90;
    } 
}

internal HL7V22Field _specialProgramIndicator44;

public HL7V22Field SpecialProgramIndicator44
{
    get
    {
        if (_specialProgramIndicator44 != null)
        {
            return _specialProgramIndicator44;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator (44)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"special program indicator.  UB82 Data Element 44.",
            Sample = @"",
            Fields = null
        }

        _specialProgramIndicator44 = new HL7V22Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramIndicator44.field.FieldRepetitions != null && _specialProgramIndicator44.field.FieldRepetitions.Count > 0)
        {
            _specialProgramIndicator44.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_specialProgramIndicator44, fieldData);
        }

        return _specialProgramIndicator44;
    } 
}

internal HL7V22Field _psroUrApprovalIndicator87;

public HL7V22Field PsroUrApprovalIndicator87
{
    get
    {
        if (_psroUrApprovalIndicator87 != null)
        {
            return _psroUrApprovalIndicator87;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"Psro / Ur Approval Indicator (87)",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approval indicator.  UB82 data element 87",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovalIndicator87 = new HL7V22Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovalIndicator87.field.FieldRepetitions != null && _psroUrApprovalIndicator87.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovalIndicator87.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_psroUrApprovalIndicator87, fieldData);
        }

        return _psroUrApprovalIndicator87;
    } 
}

internal HL7V22Field _psroUrApprovedStayFrom88;

public HL7V22Field PsroUrApprovedStayFrom88
{
    get
    {
        if (_psroUrApprovedStayFrom88 != null)
        {
            return _psroUrApprovedStayFrom88;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"Psro / Ur Approved Stay - From (88)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approved stay date (from).  UB82 Data Element 88.",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovedStayFrom88 = new HL7V22Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovedStayFrom88.field.FieldRepetitions != null && _psroUrApprovedStayFrom88.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovedStayFrom88.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_psroUrApprovedStayFrom88, fieldData);
        }

        return _psroUrApprovedStayFrom88;
    } 
}

internal HL7V22Field _psroUrApprovedStayTo89;

public HL7V22Field PsroUrApprovedStayTo89
{
    get
    {
        if (_psroUrApprovedStayTo89 != null)
        {
            return _psroUrApprovedStayTo89;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"Psro / Ur Approved Stay - To (89)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"PSRO/UR approved stay date (to).  UB82 Data Element 89",
            Sample = @"",
            Fields = null
        }

        _psroUrApprovedStayTo89 = new HL7V22Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_psroUrApprovedStayTo89.field.FieldRepetitions != null && _psroUrApprovedStayTo89.field.FieldRepetitions.Count > 0)
        {
            _psroUrApprovedStayTo89.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_psroUrApprovedStayTo89, fieldData);
        }

        return _psroUrApprovedStayTo89;
    } 
}

internal HL7V22Field _occurrence2832;

public HL7V22Field Occurrence2832
{
    get
    {
        if (_occurrence2832 != null)
        {
            return _occurrence2832;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence (28-32)",
            Length = 20,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CM_OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"set of values can repeat up to five times.  UB82 Data Elements 28-32",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.16.1",
                            Type = @"Component",
                            Position = @"UB1.16.1",
                            Name = @"Occurrence Code",
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
                            Id = @"UB1.16.2",
                            Type = @"Component",
                            Position = @"UB1.16.2",
                            Name = @"Occurrence Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrence2832 = new HL7V22Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence2832.field.FieldRepetitions != null && _occurrence2832.field.FieldRepetitions.Count > 0)
        {
            _occurrence2832.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrence2832, fieldData);
        }

        return _occurrence2832;
    } 
}

internal HL7V22Field _occurrenceSpan33;

public HL7V22Field OccurrenceSpan33
{
    get
    {
        if (_occurrenceSpan33 != null)
        {
            return _occurrenceSpan33;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"UB82 Data Element 33.",
            Sample = @"",
            Fields = null
        }

        _occurrenceSpan33 = new HL7V22Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan33.field.FieldRepetitions != null && _occurrenceSpan33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan33.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrenceSpan33, fieldData);
        }

        return _occurrenceSpan33;
    } 
}

internal HL7V22Field _occurrenceSpanStartDate33;

public HL7V22Field OccurrenceSpanStartDate33
{
    get
    {
        if (_occurrenceSpanStartDate33 != null)
        {
            return _occurrenceSpanStartDate33;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occurrence Span Start Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"occurrence span start date.  UB82 Data Element 33",
            Sample = @"",
            Fields = null
        }

        _occurrenceSpanStartDate33 = new HL7V22Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanStartDate33.field.FieldRepetitions != null && _occurrenceSpanStartDate33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanStartDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrenceSpanStartDate33, fieldData);
        }

        return _occurrenceSpanStartDate33;
    } 
}

internal HL7V22Field _occurrenceSpanEndDate33;

public HL7V22Field OccurrenceSpanEndDate33
{
    get
    {
        if (_occurrenceSpanEndDate33 != null)
        {
            return _occurrenceSpanEndDate33;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occurrence Span End Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"occurrence span end date.  UB82 Data Element 33.",
            Sample = @"",
            Fields = null
        }

        _occurrenceSpanEndDate33 = new HL7V22Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanEndDate33.field.FieldRepetitions != null && _occurrenceSpanEndDate33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanEndDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrenceSpanEndDate33, fieldData);
        }

        return _occurrenceSpanEndDate33;
    } 
}

internal HL7V22Field _ub82Locator2;

public HL7V22Field Ub82Locator2
{
    get
    {
        if (_ub82Locator2 != null)
        {
            return _ub82Locator2;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
            Fields = null
        }

        _ub82Locator2 = new HL7V22Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator2.field.FieldRepetitions != null && _ub82Locator2.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub82Locator2, fieldData);
        }

        return _ub82Locator2;
    } 
}

internal HL7V22Field _ub82Locator9;

public HL7V22Field Ub82Locator9
{
    get
    {
        if (_ub82Locator9 != null)
        {
            return _ub82Locator9;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
            Fields = null
        }

        _ub82Locator9 = new HL7V22Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator9.field.FieldRepetitions != null && _ub82Locator9.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub82Locator9, fieldData);
        }

        return _ub82Locator9;
    } 
}

internal HL7V22Field _ub82Locator27;

public HL7V22Field Ub82Locator27
{
    get
    {
        if (_ub82Locator27 != null)
        {
            return _ub82Locator27;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
            Fields = null
        }

        _ub82Locator27 = new HL7V22Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator27.field.FieldRepetitions != null && _ub82Locator27.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub82Locator27, fieldData);
        }

        return _ub82Locator27;
    } 
}

internal HL7V22Field _ub82Locator45;

public HL7V22Field Ub82Locator45
{
    get
    {
        if (_ub82Locator45 != null)
        {
            return _ub82Locator45;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"defined by UB-82 HICFA specification",
            Sample = @"",
            Fields = null
        }

        _ub82Locator45 = new HL7V22Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub82Locator45.field.FieldRepetitions != null && _ub82Locator45.field.FieldRepetitions.Count > 0)
        {
            _ub82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub82Locator45, fieldData);
        }

        return _ub82Locator45;
    } 
}
    }
}

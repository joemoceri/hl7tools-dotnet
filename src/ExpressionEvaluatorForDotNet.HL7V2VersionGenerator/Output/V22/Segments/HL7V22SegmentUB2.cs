using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"Ub92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills.  Only UB92 data elements that do not exist in other HL7 defined segments will appear in this segment.  Just as with the UB82 billing, Patient Name and Date of Birth are required, they are included in the PID segment and therefore do not appear here.  Where the field locators are different on the UB92, when compared to the UB82, the element is listed with its new location in parentheses ()."; } }
        
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

        public HL7V22SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdUb92;

public HL7V22Field SetIdUb92
{
    get
    {
        if (_setIdUb92 != null)
        {
            return _setIdUb92;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.1",
            Type = @"Field",
            Position = @"UB2.1",
            Name = @"Set Id - Ub92",
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

        _setIdUb92 = new HL7V22Field
        {
            field = message[@"UB2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdUb92.field.FieldRepetitions != null && _setIdUb92.field.FieldRepetitions.Count > 0)
        {
            _setIdUb92.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdUb92, fieldData);
        }

        return _setIdUb92;
    } 
}

internal HL7V22Field _coinsuranceDays9;

public HL7V22Field CoinsuranceDays9
{
    get
    {
        if (_coinsuranceDays9 != null)
        {
            return _coinsuranceDays9;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-insurance Days (9)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" UB92 data element 9. ",
            Sample = @"",
            Fields = null
        }

        _coinsuranceDays9 = new HL7V22Field
        {
            field = message[@"UB2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coinsuranceDays9.field.FieldRepetitions != null && _coinsuranceDays9.field.FieldRepetitions.Count > 0)
        {
            _coinsuranceDays9.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coinsuranceDays9, fieldData);
        }

        return _coinsuranceDays9;
    } 
}

internal HL7V22Field _conditionCode2430;

public HL7V22Field ConditionCode2430
{
    get
    {
        if (_conditionCode2430 != null)
        {
            return _conditionCode2430;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code (24-30)",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0043",
            TableName = @"CONDITION CODE",
            Description = @"repeats up to seven times.  UB92 data elements 24-30.  Refer to user-defined table 0043 - condition code. ",
            Sample = @"",
            Fields = null
        }

        _conditionCode2430 = new HL7V22Field
        {
            field = message[@"UB2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode2430.field.FieldRepetitions != null && _conditionCode2430.field.FieldRepetitions.Count > 0)
        {
            _conditionCode2430.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_conditionCode2430, fieldData);
        }

        return _conditionCode2430;
    } 
}

internal HL7V22Field _coveredDays7;

public HL7V22Field CoveredDays7
{
    get
    {
        if (_coveredDays7 != null)
        {
            return _coveredDays7;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.4",
            Type = @"Field",
            Position = @"UB2.4",
            Name = @"Covered Days (7)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"UB92 data element 7.",
            Sample = @"",
            Fields = null
        }

        _coveredDays7 = new HL7V22Field
        {
            field = message[@"UB2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays7.field.FieldRepetitions != null && _coveredDays7.field.FieldRepetitions.Count > 0)
        {
            _coveredDays7.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coveredDays7, fieldData);
        }

        return _coveredDays7;
    } 
}

internal HL7V22Field _noncoveredDays8;

public HL7V22Field NoncoveredDays8
{
    get
    {
        if (_noncoveredDays8 != null)
        {
            return _noncoveredDays8;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-covered Days (8)",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"UB92 data element 8. ",
            Sample = @"",
            Fields = null
        }

        _noncoveredDays8 = new HL7V22Field
        {
            field = message[@"UB2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noncoveredDays8.field.FieldRepetitions != null && _noncoveredDays8.field.FieldRepetitions.Count > 0)
        {
            _noncoveredDays8.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_noncoveredDays8, fieldData);
        }

        return _noncoveredDays8;
    } 
}

internal HL7V22Field _valueAmountAndCode3941;

public HL7V22Field ValueAmountAndCode3941
{
    get
    {
        if (_valueAmountAndCode3941 != null)
        {
            return _valueAmountAndCode3941;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount And Code (39-41)",
            Length = 11,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"CM_UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"pair can repeat up to 12 times.  UB92 data elements 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, 41d. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.6.1",
                            Type = @"Component",
                            Position = @"UB2.6.1",
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
                            Id = @"UB2.6.2",
                            Type = @"Component",
                            Position = @"UB2.6.2",
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

        _valueAmountAndCode3941 = new HL7V22Field
        {
            field = message[@"UB2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode3941.field.FieldRepetitions != null && _valueAmountAndCode3941.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode3941.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_valueAmountAndCode3941, fieldData);
        }

        return _valueAmountAndCode3941;
    } 
}

internal HL7V22Field _occurrenceCodeAndDate3235;

public HL7V22Field OccurrenceCodeAndDate3235
{
    get
    {
        if (_occurrenceCodeAndDate3235 != null)
        {
            return _occurrenceCodeAndDate3235;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code And Date (32-35)",
            Length = 11,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM_OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"set of values can repeat up to eight times.  UB92 data elements 32a, 32b, 33a, 33b, 34a, 34b, 35a, 35b",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.7.1",
                            Type = @"Component",
                            Position = @"UB2.7.1",
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
                            Id = @"UB2.7.2",
                            Type = @"Component",
                            Position = @"UB2.7.2",
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

        _occurrenceCodeAndDate3235 = new HL7V22Field
        {
            field = message[@"UB2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceCodeAndDate3235.field.FieldRepetitions != null && _occurrenceCodeAndDate3235.field.FieldRepetitions.Count > 0)
        {
            _occurrenceCodeAndDate3235.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrenceCodeAndDate3235, fieldData);
        }

        return _occurrenceCodeAndDate3235;
    } 
}

internal HL7V22Field _occurrenceSpanCodeDates36;

public HL7V22Field OccurrenceSpanCodeDates36
{
    get
    {
        if (_occurrenceSpanCodeDates36 != null)
        {
            return _occurrenceSpanCodeDates36;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code / Dates (36)",
            Length = 28,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"CM_OSP",
            DataTypeName = @"Occurence Span",
            TableId = null,
            TableName = null,
            Description = @"can repeat up to two times.  UB92 data element 36a, 36b. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.8.1",
                            Type = @"Component",
                            Position = @"UB2.8.1",
                            Name = @"Occurrence Span Code",
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
                            Id = @"UB2.8.2",
                            Type = @"Component",
                            Position = @"UB2.8.2",
                            Name = @"Occurrence Span Start Date",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.3",
                            Type = @"Component",
                            Position = @"UB2.8.3",
                            Name = @"Occurrence Span Stop Date",
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

        _occurrenceSpanCodeDates36 = new HL7V22Field
        {
            field = message[@"UB2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanCodeDates36.field.FieldRepetitions != null && _occurrenceSpanCodeDates36.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanCodeDates36.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_occurrenceSpanCodeDates36, fieldData);
        }

        return _occurrenceSpanCodeDates36;
    } 
}

internal HL7V22Field _ub92Locator2state;

public HL7V22Field Ub92Locator2state
{
    get
    {
        if (_ub92Locator2state != null)
        {
            return _ub92Locator2state;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"Ub92 Locator 2 (state)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _ub92Locator2state = new HL7V22Field
        {
            field = message[@"UB2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator2state.field.FieldRepetitions != null && _ub92Locator2state.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator2state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator2state, fieldData);
        }

        return _ub92Locator2state;
    } 
}

internal HL7V22Field _ub92Locator11state;

public HL7V22Field Ub92Locator11state
{
    get
    {
        if (_ub92Locator11state != null)
        {
            return _ub92Locator11state;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"Ub92 Locator 11 (state)",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _ub92Locator11state = new HL7V22Field
        {
            field = message[@"UB2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator11state.field.FieldRepetitions != null && _ub92Locator11state.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator11state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator11state, fieldData);
        }

        return _ub92Locator11state;
    } 
}

internal HL7V22Field _ub92Locator31national;

public HL7V22Field Ub92Locator31national
{
    get
    {
        if (_ub92Locator31national != null)
        {
            return _ub92Locator31national;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"Ub92 Locator 31 (national)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HICFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _ub92Locator31national = new HL7V22Field
        {
            field = message[@"UB2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator31national.field.FieldRepetitions != null && _ub92Locator31national.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator31national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator31national, fieldData);
        }

        return _ub92Locator31national;
    } 
}

internal HL7V22Field _documentControlNumber37;

public HL7V22Field DocumentControlNumber37
{
    get
    {
        if (_documentControlNumber37 != null)
        {
            return _documentControlNumber37;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.12",
            Type = @"Field",
            Position = @"UB2.12",
            Name = @"Document Control Number (37)",
            Length = 23,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"number assigned by payor.  Used for rebilling/adjustment purposes.  May repeat up to 3 times.  UB92 data element 37",
            Sample = @"",
            Fields = null
        }

        _documentControlNumber37 = new HL7V22Field
        {
            field = message[@"UB2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentControlNumber37.field.FieldRepetitions != null && _documentControlNumber37.field.FieldRepetitions.Count > 0)
        {
            _documentControlNumber37.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_documentControlNumber37, fieldData);
        }

        return _documentControlNumber37;
    } 
}

internal HL7V22Field _ub92Locator49national;

public HL7V22Field Ub92Locator49national
{
    get
    {
        if (_ub92Locator49national != null)
        {
            return _ub92Locator49national;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"Ub92 Locator 49 (national)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to 23 times",
            Sample = @"",
            Fields = null
        }

        _ub92Locator49national = new HL7V22Field
        {
            field = message[@"UB2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator49national.field.FieldRepetitions != null && _ub92Locator49national.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator49national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator49national, fieldData);
        }

        return _ub92Locator49national;
    } 
}

internal HL7V22Field _ub92Locator56state;

public HL7V22Field Ub92Locator56state
{
    get
    {
        if (_ub92Locator56state != null)
        {
            return _ub92Locator56state;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"Ub92 Locator 56 (state)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to five times",
            Sample = @"",
            Fields = null
        }

        _ub92Locator56state = new HL7V22Field
        {
            field = message[@"UB2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator56state.field.FieldRepetitions != null && _ub92Locator56state.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator56state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator56state, fieldData);
        }

        return _ub92Locator56state;
    } 
}

internal HL7V22Field _ub92Locator57national;

public HL7V22Field Ub92Locator57national
{
    get
    {
        if (_ub92Locator57national != null)
        {
            return _ub92Locator57national;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"Ub92 Locator 57 (national)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by UB-92 HICFA specification",
            Sample = @"",
            Fields = null
        }

        _ub92Locator57national = new HL7V22Field
        {
            field = message[@"UB2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator57national.field.FieldRepetitions != null && _ub92Locator57national.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator57national.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator57national, fieldData);
        }

        return _ub92Locator57national;
    } 
}

internal HL7V22Field _ub92Locator78state;

public HL7V22Field Ub92Locator78state
{
    get
    {
        if (_ub92Locator78state != null)
        {
            return _ub92Locator78state;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"Ub92 Locator 78 (state)",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _ub92Locator78state = new HL7V22Field
        {
            field = message[@"UB2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ub92Locator78state.field.FieldRepetitions != null && _ub92Locator78state.field.FieldRepetitions.Count > 0)
        {
            _ub92Locator78state.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ub92Locator78state, fieldData);
        }

        return _ub92Locator78state;
    } 
}
    }
}

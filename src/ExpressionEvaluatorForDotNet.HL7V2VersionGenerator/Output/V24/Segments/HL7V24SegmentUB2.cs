using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"UB92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills. Only UB82 and UB92 fields that do not exist in other HL7 defined segments appear in this segment.  Just as with the UB82 billing, Patient Name and Date of Birth are required; they are included in the PID segment and therefore do not appear here. When the field locators are different on the UB92, as compared to the UB82, the element is listed with its new location in parentheses ( ). The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.

The Uniform Billing segments are specific to the US and may not be implemented in non-US systems."; } }
        
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

        public HL7V24SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _setIDUB2;

public HL7V24Field SetIDUB2
{
    get
    {
        if (_setIDUB2 != null)
        {
            return _setIDUB2;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.1",
            Type = @"Field",
            Position = @"UB2.1",
            Name = @"Set ID - UB2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @" This field contains the number that identifies this transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc",
            Sample = @"",
            Fields = null
        }

        _setIDUB2 = new HL7V24Field
        {
            field = message[@"UB2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB2.field.FieldRepetitions != null && _setIDUB2.field.FieldRepetitions.Count > 0)
        {
            _setIDUB2.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_setIDUB2, fieldData);
        }

        return _setIDUB2;
    } 
}

internal HL7V24Field _coInsuranceDays9;

public HL7V24Field CoInsuranceDays9
{
    get
    {
        if (_coInsuranceDays9 != null)
        {
            return _coInsuranceDays9;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-Insurance Days (9)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 9.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays9 = new HL7V24Field
        {
            field = message[@"UB2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays9.field.FieldRepetitions != null && _coInsuranceDays9.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays9.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_coInsuranceDays9, fieldData);
        }

        return _coInsuranceDays9;
    } 
}

internal HL7V24Field _conditionCode2430;

public HL7V24Field ConditionCode2430
{
    get
    {
        if (_conditionCode2430 != null)
        {
            return _conditionCode2430;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code (24-30)",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition code",
            Description = @"The code in this field can repeat up to seven times.  UB92 fields 24-30.  Refer to User-defined Table 0043 - Condition code for suggested values.  The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _conditionCode2430 = new HL7V24Field
        {
            field = message[@"UB2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode2430.field.FieldRepetitions != null && _conditionCode2430.field.FieldRepetitions.Count > 0)
        {
            _conditionCode2430.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_conditionCode2430, fieldData);
        }

        return _conditionCode2430;
    } 
}

internal HL7V24Field _coveredDays7;

public HL7V24Field CoveredDays7
{
    get
    {
        if (_coveredDays7 != null)
        {
            return _coveredDays7;
        }

        var fieldData = new HL7V24FieldData
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
            Description = @"This field contains UB92 field 7.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coveredDays7 = new HL7V24Field
        {
            field = message[@"UB2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays7.field.FieldRepetitions != null && _coveredDays7.field.FieldRepetitions.Count > 0)
        {
            _coveredDays7.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_coveredDays7, fieldData);
        }

        return _coveredDays7;
    } 
}

internal HL7V24Field _nonCoveredDays8;

public HL7V24Field NonCoveredDays8
{
    get
    {
        if (_nonCoveredDays8 != null)
        {
            return _nonCoveredDays8;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-Covered Days (8)",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 8. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays8 = new HL7V24Field
        {
            field = message[@"UB2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays8.field.FieldRepetitions != null && _nonCoveredDays8.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays8.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_nonCoveredDays8, fieldData);
        }

        return _nonCoveredDays8;
    } 
}

internal HL7V24Field _valueAmountAndCode3941;

public HL7V24Field ValueAmountAndCode3941
{
    get
    {
        if (_valueAmountAndCode3941 != null)
        {
            return _valueAmountAndCode3941;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount & Code (39-41)",
            Length = 11,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"The pair in this field can repeat up to twelve times.  UB92 fields 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d.  Refer to User-defined Table 0153 - Value code for suggested values.  The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.  This field is defined by HCFA or other regulatory agencies",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0153",
                            TableName = @"Value code",
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

        _valueAmountAndCode3941 = new HL7V24Field
        {
            field = message[@"UB2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode3941.field.FieldRepetitions != null && _valueAmountAndCode3941.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode3941.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_valueAmountAndCode3941, fieldData);
        }

        return _valueAmountAndCode3941;
    } 
}

internal HL7V24Field _occurrenceCodeAndDate3235;

public HL7V24Field OccurrenceCodeAndDate3235
{
    get
    {
        if (_occurrenceCodeAndDate3235 != null)
        {
            return _occurrenceCodeAndDate3235;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code & Date (32-35)",
            Length = 11,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to eight times.  UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b.  This field is defined by HCFA or other regulatory agencies.  Refer to User-defined Table 0350 - Occurrence code for suggested values.  The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
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

        _occurrenceCodeAndDate3235 = new HL7V24Field
        {
            field = message[@"UB2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceCodeAndDate3235.field.FieldRepetitions != null && _occurrenceCodeAndDate3235.field.FieldRepetitions.Count > 0)
        {
            _occurrenceCodeAndDate3235.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_occurrenceCodeAndDate3235, fieldData);
        }

        return _occurrenceCodeAndDate3235;
    } 
}

internal HL7V24Field _occurrenceSpanCodeDates36;

public HL7V24Field OccurrenceSpanCodeDates36
{
    get
    {
        if (_occurrenceSpanCodeDates36 != null)
        {
            return _occurrenceSpanCodeDates36;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code/Dates (36)",
            Length = 28,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"OSP",
            DataTypeName = @"Occurence Span",
            TableId = null,
            TableName = null,
            Description = @"This field can repeat up to two times.  UB92 field 36a, 36b.  This field is defined by HCFA or other regulatory agencies.  Refer to User-defined Table 0351 - Occurrence span for suggested values.  The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
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
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
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

        _occurrenceSpanCodeDates36 = new HL7V24Field
        {
            field = message[@"UB2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanCodeDates36.field.FieldRepetitions != null && _occurrenceSpanCodeDates36.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanCodeDates36.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_occurrenceSpanCodeDates36, fieldData);
        }

        return _occurrenceSpanCodeDates36;
    } 
}

internal HL7V24Field _uB92Locator2state;

public HL7V24Field UB92Locator2state
{
    get
    {
        if (_uB92Locator2state != null)
        {
            return _uB92Locator2state;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"UB92 Locator 2 (state)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _uB92Locator2state = new HL7V24Field
        {
            field = message[@"UB2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator2state.field.FieldRepetitions != null && _uB92Locator2state.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator2state.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator2state, fieldData);
        }

        return _uB92Locator2state;
    } 
}

internal HL7V24Field _uB92Locator11state;

public HL7V24Field UB92Locator11state
{
    get
    {
        if (_uB92Locator11state != null)
        {
            return _uB92Locator11state;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"UB92 Locator 11 (state)",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _uB92Locator11state = new HL7V24Field
        {
            field = message[@"UB2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator11state.field.FieldRepetitions != null && _uB92Locator11state.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator11state.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator11state, fieldData);
        }

        return _uB92Locator11state;
    } 
}

internal HL7V24Field _uB92Locator31national;

public HL7V24Field UB92Locator31national
{
    get
    {
        if (_uB92Locator31national != null)
        {
            return _uB92Locator31national;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"UB92 Locator 31 (national)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _uB92Locator31national = new HL7V24Field
        {
            field = message[@"UB2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator31national.field.FieldRepetitions != null && _uB92Locator31national.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator31national.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator31national, fieldData);
        }

        return _uB92Locator31national;
    } 
}

internal HL7V24Field _documentControlNumber;

public HL7V24Field DocumentControlNumber
{
    get
    {
        if (_documentControlNumber != null)
        {
            return _documentControlNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.12",
            Type = @"Field",
            Position = @"UB2.12",
            Name = @"Document Control Number",
            Length = 23,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times.  Refer UB92 field 37",
            Sample = @"",
            Fields = null
        }

        _documentControlNumber = new HL7V24Field
        {
            field = message[@"UB2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentControlNumber.field.FieldRepetitions != null && _documentControlNumber.field.FieldRepetitions.Count > 0)
        {
            _documentControlNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_documentControlNumber, fieldData);
        }

        return _documentControlNumber;
    } 
}

internal HL7V24Field _uB92Locator49national;

public HL7V24Field UB92Locator49national
{
    get
    {
        if (_uB92Locator49national != null)
        {
            return _uB92Locator49national;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"UB92 Locator 49 (national)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies. This field may repeat up to twentythree times",
            Sample = @"",
            Fields = null
        }

        _uB92Locator49national = new HL7V24Field
        {
            field = message[@"UB2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator49national.field.FieldRepetitions != null && _uB92Locator49national.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator49national.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator49national, fieldData);
        }

        return _uB92Locator49national;
    } 
}

internal HL7V24Field _uB92Locator56state;

public HL7V24Field UB92Locator56state
{
    get
    {
        if (_uB92Locator56state != null)
        {
            return _uB92Locator56state;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"UB92 Locator 56 (state)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to five times",
            Sample = @"",
            Fields = null
        }

        _uB92Locator56state = new HL7V24Field
        {
            field = message[@"UB2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator56state.field.FieldRepetitions != null && _uB92Locator56state.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator56state.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator56state, fieldData);
        }

        return _uB92Locator56state;
    } 
}

internal HL7V24Field _uB92Locator57national;

public HL7V24Field UB92Locator57national
{
    get
    {
        if (_uB92Locator57national != null)
        {
            return _uB92Locator57national;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"UB92 Locator 57 (national)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-92 HCFA specification.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator57national = new HL7V24Field
        {
            field = message[@"UB2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator57national.field.FieldRepetitions != null && _uB92Locator57national.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator57national.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator57national, fieldData);
        }

        return _uB92Locator57national;
    } 
}

internal HL7V24Field _uB92Locator78state;

public HL7V24Field UB92Locator78state
{
    get
    {
        if (_uB92Locator78state != null)
        {
            return _uB92Locator78state;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"UB92 Locator 78 (state)",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to two times",
            Sample = @"",
            Fields = null
        }

        _uB92Locator78state = new HL7V24Field
        {
            field = message[@"UB2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator78state.field.FieldRepetitions != null && _uB92Locator78state.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator78state.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_uB92Locator78state, fieldData);
        }

        return _uB92Locator78state;
    } 
}

internal HL7V24Field _specialVisitCount;

public HL7V24Field SpecialVisitCount
{
    get
    {
        if (_specialVisitCount != null)
        {
            return _specialVisitCount;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"UB2.17",
            Type = @"Field",
            Position = @"UB2.17",
            Name = @"Special Visit Count",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total number of special therapy visits",
            Sample = @"",
            Fields = null
        }

        _specialVisitCount = new HL7V24Field
        {
            field = message[@"UB2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialVisitCount.field.FieldRepetitions != null && _specialVisitCount.field.FieldRepetitions.Count > 0)
        {
            _specialVisitCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_specialVisitCount, fieldData);
        }

        return _specialVisitCount;
    } 
}
    }
}

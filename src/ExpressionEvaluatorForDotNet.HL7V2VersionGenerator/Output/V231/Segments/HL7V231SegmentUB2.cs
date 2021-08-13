using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"UB92 data segment"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills. Only UB92 fields that do not exist in other HL7 defined segments appear in this segment. Just as with the UB82 billing, Patient Name and Date of Birth are required; they are included in the PID segment and therefore do not appear here. When the field locators are different on the UB92, as compared to the UB82, the element is listed with its new location in parentheses ( ). The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information."; } }
        
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

        public HL7V231SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDUB2;

public HL7V231Field SetIDUB2
{
    get
    {
        if (_setIDUB2 != null)
        {
            return _setIDUB2;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDUB2 = new HL7V231Field
        {
            field = message[@"UB2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB2.field.FieldRepetitions != null && _setIDUB2.field.FieldRepetitions.Count > 0)
        {
            _setIDUB2.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDUB2, fieldData);
        }

        return _setIDUB2;
    } 
}

internal HL7V231Field _coInsuranceDays;

public HL7V231Field CoInsuranceDays
{
    get
    {
        if (_coInsuranceDays != null)
        {
            return _coInsuranceDays;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-Insurance Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 9. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays = new HL7V231Field
        {
            field = message[@"UB2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays.field.FieldRepetitions != null && _coInsuranceDays.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_coInsuranceDays, fieldData);
        }

        return _coInsuranceDays;
    } 
}

internal HL7V231Field _conditionCode;

public HL7V231Field ConditionCode
{
    get
    {
        if (_conditionCode != null)
        {
            return _conditionCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition code",
            Description = @"The code in this field can repeat up to seven times. UB92 fields 24-30. Refer to user-defined table 0043 - Condition code for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V231Field
        {
            field = message[@"UB2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode.field.FieldRepetitions != null && _conditionCode.field.FieldRepetitions.Count > 0)
        {
            _conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_conditionCode, fieldData);
        }

        return _conditionCode;
    } 
}

internal HL7V231Field _coveredDays;

public HL7V231Field CoveredDays
{
    get
    {
        if (_coveredDays != null)
        {
            return _coveredDays;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.4",
            Type = @"Field",
            Position = @"UB2.4",
            Name = @"Covered Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 7. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coveredDays = new HL7V231Field
        {
            field = message[@"UB2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays.field.FieldRepetitions != null && _coveredDays.field.FieldRepetitions.Count > 0)
        {
            _coveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_coveredDays, fieldData);
        }

        return _coveredDays;
    } 
}

internal HL7V231Field _nonCoveredDays;

public HL7V231Field NonCoveredDays
{
    get
    {
        if (_nonCoveredDays != null)
        {
            return _nonCoveredDays;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-Covered Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 8. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays = new HL7V231Field
        {
            field = message[@"UB2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays.field.FieldRepetitions != null && _nonCoveredDays.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_nonCoveredDays, fieldData);
        }

        return _nonCoveredDays;
    } 
}

internal HL7V231Field _valueAmountAndCode;

public HL7V231Field ValueAmountAndCode
{
    get
    {
        if (_valueAmountAndCode != null)
        {
            return _valueAmountAndCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount & Code",
            Length = 11,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"The pair in this field can repeat up to twelve times. UB92 fields 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. Refer to user-defined table 0153 - Value code for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information. This field is defined by HCFA or other regulatory agencies.",
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

        _valueAmountAndCode = new HL7V231Field
        {
            field = message[@"UB2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode.field.FieldRepetitions != null && _valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_valueAmountAndCode, fieldData);
        }

        return _valueAmountAndCode;
    } 
}

internal HL7V231Field _occurrenceCodeAndDate;

public HL7V231Field OccurrenceCodeAndDate
{
    get
    {
        if (_occurrenceCodeAndDate != null)
        {
            return _occurrenceCodeAndDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code & Date",
            Length = 11,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to eight times. UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0350 - Occurrence code for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
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
                            DataTypeName = @"Coded values for HL7 tables",
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

        _occurrenceCodeAndDate = new HL7V231Field
        {
            field = message[@"UB2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceCodeAndDate.field.FieldRepetitions != null && _occurrenceCodeAndDate.field.FieldRepetitions.Count > 0)
        {
            _occurrenceCodeAndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_occurrenceCodeAndDate, fieldData);
        }

        return _occurrenceCodeAndDate;
    } 
}

internal HL7V231Field _occurrenceSpanCodeDates;

public HL7V231Field OccurrenceSpanCodeDates
{
    get
    {
        if (_occurrenceSpanCodeDates != null)
        {
            return _occurrenceSpanCodeDates;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code/Dates",
            Length = 28,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"OSP",
            DataTypeName = @"Occurence Span",
            TableId = null,
            TableName = null,
            Description = @"This field can repeat up to two times. UB92 field 36a, 36b. This field is defined by HCFA or other regulatory agencies. Refer to user-defined table 0351 - Occurrence span for suggested values. The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
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
                            Description = null,
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
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

        _occurrenceSpanCodeDates = new HL7V231Field
        {
            field = message[@"UB2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanCodeDates.field.FieldRepetitions != null && _occurrenceSpanCodeDates.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanCodeDates.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_occurrenceSpanCodeDates, fieldData);
        }

        return _occurrenceSpanCodeDates;
    } 
}

internal HL7V231Field _uB92Locator2;

public HL7V231Field UB92Locator2
{
    get
    {
        if (_uB92Locator2 != null)
        {
            return _uB92Locator2;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"UB92 Locator 2",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator2 = new HL7V231Field
        {
            field = message[@"UB2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator2.field.FieldRepetitions != null && _uB92Locator2.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator2, fieldData);
        }

        return _uB92Locator2;
    } 
}

internal HL7V231Field _uB92Locator11;

public HL7V231Field UB92Locator11
{
    get
    {
        if (_uB92Locator11 != null)
        {
            return _uB92Locator11;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"UB92 Locator 11",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator11 = new HL7V231Field
        {
            field = message[@"UB2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator11.field.FieldRepetitions != null && _uB92Locator11.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator11.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator11, fieldData);
        }

        return _uB92Locator11;
    } 
}

internal HL7V231Field _uB92Locator31;

public HL7V231Field UB92Locator31
{
    get
    {
        if (_uB92Locator31 != null)
        {
            return _uB92Locator31;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"UB92 Locator 31",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator31 = new HL7V231Field
        {
            field = message[@"UB2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator31.field.FieldRepetitions != null && _uB92Locator31.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator31.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator31, fieldData);
        }

        return _uB92Locator31;
    } 
}

internal HL7V231Field _documentControlNumber;

public HL7V231Field DocumentControlNumber
{
    get
    {
        if (_documentControlNumber != null)
        {
            return _documentControlNumber;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times. UB92 field 37",
            Sample = @"",
            Fields = null
        }

        _documentControlNumber = new HL7V231Field
        {
            field = message[@"UB2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentControlNumber.field.FieldRepetitions != null && _documentControlNumber.field.FieldRepetitions.Count > 0)
        {
            _documentControlNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_documentControlNumber, fieldData);
        }

        return _documentControlNumber;
    } 
}

internal HL7V231Field _uB92Locator49;

public HL7V231Field UB92Locator49
{
    get
    {
        if (_uB92Locator49 != null)
        {
            return _uB92Locator49;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"UB92 Locator 49",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to twenty-three times. This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator49 = new HL7V231Field
        {
            field = message[@"UB2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator49.field.FieldRepetitions != null && _uB92Locator49.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator49.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator49, fieldData);
        }

        return _uB92Locator49;
    } 
}

internal HL7V231Field _uB92Locator56;

public HL7V231Field UB92Locator56
{
    get
    {
        if (_uB92Locator56 != null)
        {
            return _uB92Locator56;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"UB92 Locator 56",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to five times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator56 = new HL7V231Field
        {
            field = message[@"UB2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator56.field.FieldRepetitions != null && _uB92Locator56.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator56.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator56, fieldData);
        }

        return _uB92Locator56;
    } 
}

internal HL7V231Field _uB92Locator57;

public HL7V231Field UB92Locator57
{
    get
    {
        if (_uB92Locator57 != null)
        {
            return _uB92Locator57;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"UB92 Locator 57",
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

        _uB92Locator57 = new HL7V231Field
        {
            field = message[@"UB2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator57.field.FieldRepetitions != null && _uB92Locator57.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator57.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator57, fieldData);
        }

        return _uB92Locator57;
    } 
}

internal HL7V231Field _uB92Locator78;

public HL7V231Field UB92Locator78
{
    get
    {
        if (_uB92Locator78 != null)
        {
            return _uB92Locator78;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"UB92 Locator 78",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to two times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator78 = new HL7V231Field
        {
            field = message[@"UB2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator78.field.FieldRepetitions != null && _uB92Locator78.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator78.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_uB92Locator78, fieldData);
        }

        return _uB92Locator78;
    } 
}

internal HL7V231Field _specialVisitCount;

public HL7V231Field SpecialVisitCount
{
    get
    {
        if (_specialVisitCount != null)
        {
            return _specialVisitCount;
        }

        var fieldData = new HL7V231FieldData
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
            Description = @"This field contains the total number of special therapy visits.",
            Sample = @"",
            Fields = null
        }

        _specialVisitCount = new HL7V231Field
        {
            field = message[@"UB2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialVisitCount.field.FieldRepetitions != null && _specialVisitCount.field.FieldRepetitions.Count > 0)
        {
            _specialVisitCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_specialVisitCount, fieldData);
        }

        return _specialVisitCount;
    } 
}
    }
}

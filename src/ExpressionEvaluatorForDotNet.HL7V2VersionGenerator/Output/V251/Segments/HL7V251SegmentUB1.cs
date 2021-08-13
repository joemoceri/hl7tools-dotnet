using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"UB82 Data"; } }
        
        public string Description { get { return @"The UB1 segment contains the data necessary to complete UB82 bills specific to the United States; other realms may choose to implement using regional code sets. Only UB82 fields that do not exist in other HL7 defined segments appear in this segment. Patient Name and Date of Birth are required for UB82 billing; however, they are included in the PID segment and therefore do not appear here. The UB codes listed as examples are not an exhaustive or current list. Refer to a UB specification for additional information.

The Uniform Billing segments are specific to the US and may not be implemented in non-US systems. "; } }
        
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

        public HL7V251SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _setIDUB1;

public HL7V251Field SetIDUB1
{
    get
    {
        if (_setIDUB1 != null)
        {
            return _setIDUB1;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.1",
            Type = @"Field",
            Position = @"UB1.1",
            Name = @"Set ID - UB1",
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

        _setIDUB1 = new HL7V251Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB1.field.FieldRepetitions != null && _setIDUB1.field.FieldRepetitions.Count > 0)
        {
            _setIDUB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_setIDUB1, fieldData);
        }

        return _setIDUB1;
    } 
}

internal HL7V251Field _bloodDeductible43;

public HL7V251Field BloodDeductible43
{
    get
    {
        if (_bloodDeductible43 != null)
        {
            return _bloodDeductible43;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible (43)",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.3, t his field has been retained for backward compatibility only.  Use IN2-21 - Blood Deductible instead of this field, as the blood deductible can be associated with the specific insurance plan via that segment. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible43 = new HL7V251Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible43.field.FieldRepetitions != null && _bloodDeductible43.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible43.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_bloodDeductible43, fieldData);
        }

        return _bloodDeductible43;
    } 
}

internal HL7V251Field _bloodFurnishedPintsOf40;

public HL7V251Field BloodFurnishedPintsOf40
{
    get
    {
        if (_bloodFurnishedPintsOf40 != null)
        {
            return _bloodFurnishedPintsOf40;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished-Pints Of (40)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the amount of blood furnished to the patient for this visit.  The (40) indicates the corresponding UB82 field number. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodFurnishedPintsOf40 = new HL7V251Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnishedPintsOf40.field.FieldRepetitions != null && _bloodFurnishedPintsOf40.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnishedPintsOf40.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_bloodFurnishedPintsOf40, fieldData);
        }

        return _bloodFurnishedPintsOf40;
    } 
}

internal HL7V251Field _bloodReplacedPints41;

public HL7V251Field BloodReplacedPints41
{
    get
    {
        if (_bloodReplacedPints41 != null)
        {
            return _bloodReplacedPints41;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-Pints (41)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 41. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodReplacedPints41 = new HL7V251Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedPints41.field.FieldRepetitions != null && _bloodReplacedPints41.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedPints41.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_bloodReplacedPints41, fieldData);
        }

        return _bloodReplacedPints41;
    } 
}

internal HL7V251Field _bloodNotReplacedPints42;

public HL7V251Field BloodNotReplacedPints42
{
    get
    {
        if (_bloodNotReplacedPints42 != null)
        {
            return _bloodNotReplacedPints42;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced-Pints (42)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the blood not replaced, as measured in pints.  UB82 Field 42. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodNotReplacedPints42 = new HL7V251Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotReplacedPints42.field.FieldRepetitions != null && _bloodNotReplacedPints42.field.FieldRepetitions.Count > 0)
        {
            _bloodNotReplacedPints42.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_bloodNotReplacedPints42, fieldData);
        }

        return _bloodNotReplacedPints42;
    } 
}

internal HL7V251Field _coInsuranceDays25;

public HL7V251Field CoInsuranceDays25
{
    get
    {
        if (_coInsuranceDays25 != null)
        {
            return _coInsuranceDays25;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-Insurance Days (25)",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 25. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays25 = new HL7V251Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays25.field.FieldRepetitions != null && _coInsuranceDays25.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays25.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_coInsuranceDays25, fieldData);
        }

        return _coInsuranceDays25;
    } 
}

internal HL7V251Field _conditionCode3539;

public HL7V251Field ConditionCode3539
{
    get
    {
        if (_conditionCode3539 != null)
        {
            return _conditionCode3539;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code (35-39)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition Code",
            Description = @"The code in this field repeats five times.  UB82 Fields (35), (36), (37), (38), and (39).  Refer to User-defined Table 0043 - Condition Code for suggested values. Refer to a UB specification for additional information.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _conditionCode3539 = new HL7V251Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode3539.field.FieldRepetitions != null && _conditionCode3539.field.FieldRepetitions.Count > 0)
        {
            _conditionCode3539.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_conditionCode3539, fieldData);
        }

        return _conditionCode3539;
    } 
}

internal HL7V251Field _coveredDays23;

public HL7V251Field CoveredDays23
{
    get
    {
        if (_coveredDays23 != null)
        {
            return _coveredDays23;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains UB82 Field 23. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coveredDays23 = new HL7V251Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays23.field.FieldRepetitions != null && _coveredDays23.field.FieldRepetitions.Count > 0)
        {
            _coveredDays23.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_coveredDays23, fieldData);
        }

        return _coveredDays23;
    } 
}

internal HL7V251Field _nonCoveredDays24;

public HL7V251Field NonCoveredDays24
{
    get
    {
        if (_nonCoveredDays24 != null)
        {
            return _nonCoveredDays24;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days (24)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 24. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays24 = new HL7V251Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays24.field.FieldRepetitions != null && _nonCoveredDays24.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays24.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_nonCoveredDays24, fieldData);
        }

        return _nonCoveredDays24;
    } 
}

internal HL7V251Field _valueAmountandCode4649;

public HL7V251Field ValueAmountandCode4649
{
    get
    {
        if (_valueAmountandCode4649 != null)
        {
            return _valueAmountandCode4649;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount and Code (46-49)",
            Length = 41,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"UVC",
            DataTypeName = @"UB Value Code and Amount",
            TableId = null,
            TableName = null,
            Description = @"This field contains a monetary amount and an associated billing code.  The pair in this field can repeat up to eight times to represent/contain UB82 form locators 46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.10.1",
                            Type = @"Component",
                            Position = @"UB1.10.1",
                            Name = @"Value Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0153",
                            TableName = @"Value code",
                            Description = @"Specifies the National Uniform Billing Committee (NUBC) code itself.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.1",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.2",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.3",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.4",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.5",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.6",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.7",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.8",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.1.9",
                            Type = @"SubComponent",
                            Position = @"UB1.10.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.2",
                            Type = @"Component",
                            Position = @"UB1.10.2",
                            Name = @"Value Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.10.2.1",
                            Type = @"SubComponent",
                            Position = @"UB1.10.2.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.10.2.2",
                            Type = @"SubComponent",
                            Position = @"UB1.10.2.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _valueAmountandCode4649 = new HL7V251Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountandCode4649.field.FieldRepetitions != null && _valueAmountandCode4649.field.FieldRepetitions.Count > 0)
        {
            _valueAmountandCode4649.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_valueAmountandCode4649, fieldData);
        }

        return _valueAmountandCode4649;
    } 
}

internal HL7V251Field _numberOfGraceDays90;

public HL7V251Field NumberOfGraceDays90
{
    get
    {
        if (_numberOfGraceDays90 != null)
        {
            return _numberOfGraceDays90;
        }

        var fieldData = new HL7V251FieldData
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
            Description = @"This field contains UB82 Field 90.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _numberOfGraceDays90 = new HL7V251Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays90.field.FieldRepetitions != null && _numberOfGraceDays90.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays90.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_numberOfGraceDays90, fieldData);
        }

        return _numberOfGraceDays90;
    } 
}

internal HL7V251Field _specialProgramIndicator44;

public HL7V251Field SpecialProgramIndicator44
{
    get
    {
        if (_specialProgramIndicator44 != null)
        {
            return _specialProgramIndicator44;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator (44)",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0348",
            TableName = @"Special Program Indicator",
            Description = @"This field contains the special program indicator.  UB82 Field 44.  This field is defined by CMS or other regulatory agencies.  Refer to User-defined Table 0348 - Special Program Indicator for suggested values. Refer to a UB specification for additional information ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.12.1",
                            Type = @"Component",
                            Position = @"UB1.12.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.2",
                            Type = @"Component",
                            Position = @"UB1.12.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.3",
                            Type = @"Component",
                            Position = @"UB1.12.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.4",
                            Type = @"Component",
                            Position = @"UB1.12.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.5",
                            Type = @"Component",
                            Position = @"UB1.12.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.6",
                            Type = @"Component",
                            Position = @"UB1.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _specialProgramIndicator44 = new HL7V251Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramIndicator44.field.FieldRepetitions != null && _specialProgramIndicator44.field.FieldRepetitions.Count > 0)
        {
            _specialProgramIndicator44.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_specialProgramIndicator44, fieldData);
        }

        return _specialProgramIndicator44;
    } 
}

internal HL7V251Field _pSROURApprovalIndicator87;

public HL7V251Field PSROURApprovalIndicator87
{
    get
    {
        if (_pSROURApprovalIndicator87 != null)
        {
            return _pSROURApprovalIndicator87;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"PSRO/UR Approval Indicator (87)",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0349",
            TableName = @"PSRO/UR Approval Indicator",
            Description = @"This field contains the PSRO/UR approval indicator.  UB82 field 87.  This field is defined by CMS or other regulatory agencies.  Refer to User-defined Table 0349 - PSRO/UR Approval Indicator for suggested values. Refer to a UB specification for additional information.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.13.1",
                            Type = @"Component",
                            Position = @"UB1.13.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.2",
                            Type = @"Component",
                            Position = @"UB1.13.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.3",
                            Type = @"Component",
                            Position = @"UB1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.4",
                            Type = @"Component",
                            Position = @"UB1.13.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.5",
                            Type = @"Component",
                            Position = @"UB1.13.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.6",
                            Type = @"Component",
                            Position = @"UB1.13.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pSROURApprovalIndicator87 = new HL7V251Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovalIndicator87.field.FieldRepetitions != null && _pSROURApprovalIndicator87.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovalIndicator87.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_pSROURApprovalIndicator87, fieldData);
        }

        return _pSROURApprovalIndicator87;
    } 
}

internal HL7V251Field _pSROURApprovedStayFm88;

public HL7V251Field PSROURApprovedStayFm88
{
    get
    {
        if (_pSROURApprovedStayFm88 != null)
        {
            return _pSROURApprovedStayFm88;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"PSRO/UR Approved Stay-Fm (88)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (from).  UB82 Field 88.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayFm88 = new HL7V251Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayFm88.field.FieldRepetitions != null && _pSROURApprovedStayFm88.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayFm88.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_pSROURApprovedStayFm88, fieldData);
        }

        return _pSROURApprovedStayFm88;
    } 
}

internal HL7V251Field _pSROURApprovedStayTo89;

public HL7V251Field PSROURApprovedStayTo89
{
    get
    {
        if (_pSROURApprovedStayTo89 != null)
        {
            return _pSROURApprovedStayTo89;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"PSRO/UR Approved Stay-To (89)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (to).  UB82 Field 89.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayTo89 = new HL7V251Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayTo89.field.FieldRepetitions != null && _pSROURApprovedStayTo89.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayTo89.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_pSROURApprovedStayTo89, fieldData);
        }

        return _pSROURApprovedStayTo89;
    } 
}

internal HL7V251Field _occurrence2832;

public HL7V251Field Occurrence2832
{
    get
    {
        if (_occurrence2832 != null)
        {
            return _occurrence2832;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence (28-32)",
            Length = 259,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"OCD",
            DataTypeName = @"Occurrence Code and Date",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to five times.  UB82 Fields 28-32.  This field is defined by CMS or other regulatory agencies. Refer to a UB specification for additional information.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.16.1",
                            Type = @"Component",
                            Position = @"UB1.16.1",
                            Name = @"Occurrence Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
                            Description = @"The NUBC code for the event or occurrence relating to a bill that may affect payer processing.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.1",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.2",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.3",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.4",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.5",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.6",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.7",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.8",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.9",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.2",
                            Type = @"Component",
                            Position = @"UB1.16.2",
                            Name = @"Occurrence Date",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date the event, relating to a bill that may affect payer processing, occurred.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrence2832 = new HL7V251Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence2832.field.FieldRepetitions != null && _occurrence2832.field.FieldRepetitions.Count > 0)
        {
            _occurrence2832.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurrence2832, fieldData);
        }

        return _occurrence2832;
    } 
}

internal HL7V251Field _occurrenceSpan33;

public HL7V251Field OccurrenceSpan33
{
    get
    {
        if (_occurrenceSpan33 != null)
        {
            return _occurrenceSpan33;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span (33)",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0351",
            TableName = @"Occurrence span",
            Description = @"UB82 Field 33.  This field is defined by CMS or other regulatory agencies.  Refer to Userdefined Table 0351 - Occurrence Span in Chapter 2 for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.17.1",
                            Type = @"Component",
                            Position = @"UB1.17.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.2",
                            Type = @"Component",
                            Position = @"UB1.17.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.3",
                            Type = @"Component",
                            Position = @"UB1.17.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.4",
                            Type = @"Component",
                            Position = @"UB1.17.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.5",
                            Type = @"Component",
                            Position = @"UB1.17.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.6",
                            Type = @"Component",
                            Position = @"UB1.17.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrenceSpan33 = new HL7V251Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan33.field.FieldRepetitions != null && _occurrenceSpan33.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan33.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurrenceSpan33, fieldData);
        }

        return _occurrenceSpan33;
    } 
}

internal HL7V251Field _occurSpanStartDate33;

public HL7V251Field OccurSpanStartDate33
{
    get
    {
        if (_occurSpanStartDate33 != null)
        {
            return _occurSpanStartDate33;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span start date.  UB82 Field 33.  This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _occurSpanStartDate33 = new HL7V251Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanStartDate33.field.FieldRepetitions != null && _occurSpanStartDate33.field.FieldRepetitions.Count > 0)
        {
            _occurSpanStartDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurSpanStartDate33, fieldData);
        }

        return _occurSpanStartDate33;
    } 
}

internal HL7V251Field _occurSpanEndDate33;

public HL7V251Field OccurSpanEndDate33
{
    get
    {
        if (_occurSpanEndDate33 != null)
        {
            return _occurSpanEndDate33;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date (33)",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span end date. UB82 Field 33. This field is defined by CMS or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _occurSpanEndDate33 = new HL7V251Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanEndDate33.field.FieldRepetitions != null && _occurSpanEndDate33.field.FieldRepetitions.Count > 0)
        {
            _occurSpanEndDate33.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurSpanEndDate33, fieldData);
        }

        return _occurSpanEndDate33;
    } 
}

internal HL7V251Field _uB82Locator2;

public HL7V251Field UB82Locator2
{
    get
    {
        if (_uB82Locator2 != null)
        {
            return _uB82Locator2;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"UB-82 Locator 2",
            Length = 30,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 CMS specification and maintained for backward compatibility",
            Sample = @"",
            Fields = null
        }

        _uB82Locator2 = new HL7V251Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator2.field.FieldRepetitions != null && _uB82Locator2.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB82Locator2, fieldData);
        }

        return _uB82Locator2;
    } 
}

internal HL7V251Field _uB82Locator9;

public HL7V251Field UB82Locator9
{
    get
    {
        if (_uB82Locator9 != null)
        {
            return _uB82Locator9;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"UB-82 Locator 9",
            Length = 7,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 CMS specification and maintained for backward compatibility.",
            Sample = @"",
            Fields = null
        }

        _uB82Locator9 = new HL7V251Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator9.field.FieldRepetitions != null && _uB82Locator9.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB82Locator9, fieldData);
        }

        return _uB82Locator9;
    } 
}

internal HL7V251Field _uB82Locator27;

public HL7V251Field UB82Locator27
{
    get
    {
        if (_uB82Locator27 != null)
        {
            return _uB82Locator27;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"UB-82 Locator 27",
            Length = 8,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 CMS specification and maintained for backward compatibility.",
            Sample = @"",
            Fields = null
        }

        _uB82Locator27 = new HL7V251Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator27.field.FieldRepetitions != null && _uB82Locator27.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB82Locator27, fieldData);
        }

        return _uB82Locator27;
    } 
}

internal HL7V251Field _uB82Locator45;

public HL7V251Field UB82Locator45
{
    get
    {
        if (_uB82Locator45 != null)
        {
            return _uB82Locator45;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"UB-82 Locator 45",
            Length = 17,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-82 CMS specification and maintained for backward compatibility.",
            Sample = @"",
            Fields = null
        }

        _uB82Locator45 = new HL7V251Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator45.field.FieldRepetitions != null && _uB82Locator45.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB82Locator45, fieldData);
        }

        return _uB82Locator45;
    } 
}
    }
}

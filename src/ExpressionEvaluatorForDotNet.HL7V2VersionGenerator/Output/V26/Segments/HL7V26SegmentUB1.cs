using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"Uniform Billing 1"; } }
        
        public string Description { get { return @"The UB1 segment contains data specific to the United States; other realms may choose to implement using regional code sets. Only billing/claims fields that do not exist in other HL7 defined segments appear in this segment. The codes listed as examples are not an exhaustive or current list.

Prior to V2.6, this segment was published as a UB-82 specific segment, but has been widely implemented for usage with UB-82 and/or UB-92 data.  With the publication of the UB-92 (in 1992) and the HIPAA requirements in the US (2004), this segment is technically no longer applicable for the UB-82 which is no longer in use.  However, the segment is often used internally to message data from a patient registration to a patient accounting system.  It has been 'generalized' in V2.6 for wider applicability."; } }
        
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

        public HL7V26SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDUB1;

public HL7V26Field SetIDUB1
{
    get
    {
        if (_setIDUB1 != null)
        {
            return _setIDUB1;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be 1; for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDUB1 = new HL7V26Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB1.field.FieldRepetitions != null && _setIDUB1.field.FieldRepetitions.Count > 0)
        {
            _setIDUB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDUB1, fieldData);
        }

        return _setIDUB1;
    } 
}

internal HL7V26Field _bloodDeductible;

public HL7V26Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"UB1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v2.6.",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible = new HL7V26Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V26Field _bloodFurnishedPints;

public HL7V26Field BloodFurnishedPints
{
    get
    {
        if (_bloodFurnishedPints != null)
        {
            return _bloodFurnishedPints;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished-Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the amount of blood furnished to the patient for this visit. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _bloodFurnishedPints = new HL7V26Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnishedPints.field.FieldRepetitions != null && _bloodFurnishedPints.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnishedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_bloodFurnishedPints, fieldData);
        }

        return _bloodFurnishedPints;
    } 
}

internal HL7V26Field _bloodReplacedPints;

public HL7V26Field BloodReplacedPints
{
    get
    {
        if (_bloodReplacedPints != null)
        {
            return _bloodReplacedPints;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced-Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total number of pints of whole blood or units of packed red cells furnished to the patient that were replaced. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _bloodReplacedPints = new HL7V26Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedPints.field.FieldRepetitions != null && _bloodReplacedPints.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_bloodReplacedPints, fieldData);
        }

        return _bloodReplacedPints;
    } 
}

internal HL7V26Field _bloodNotReplacedPints;

public HL7V26Field BloodNotReplacedPints
{
    get
    {
        if (_bloodNotReplacedPints != null)
        {
            return _bloodNotReplacedPints;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced-Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the blood not replaced, as measured in pints. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _bloodNotReplacedPints = new HL7V26Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotReplacedPints.field.FieldRepetitions != null && _bloodNotReplacedPints.field.FieldRepetitions.Count > 0)
        {
            _bloodNotReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_bloodNotReplacedPints, fieldData);
        }

        return _bloodNotReplacedPints;
    } 
}

internal HL7V26Field _coInsuranceDays;

public HL7V26Field CoInsuranceDays
{
    get
    {
        if (_coInsuranceDays != null)
        {
            return _coInsuranceDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co-Insurance Days",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-2 Co-Insurance Days instead of this field. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays = new HL7V26Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays.field.FieldRepetitions != null && _coInsuranceDays.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_coInsuranceDays, fieldData);
        }

        return _coInsuranceDays;
    } 
}

internal HL7V26Field _conditionCode;

public HL7V26Field ConditionCode
{
    get
    {
        if (_conditionCode != null)
        {
            return _conditionCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 14,
            Usage = @"B",
            Rpt = @"5",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition Code",
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-3 Condition Code instead of this field. Refer to User-defined Table 0043 - Condition Code for suggested values. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V26Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode.field.FieldRepetitions != null && _conditionCode.field.FieldRepetitions.Count > 0)
        {
            _conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_conditionCode, fieldData);
        }

        return _conditionCode;
    } 
}

internal HL7V26Field _coveredDays;

public HL7V26Field CoveredDays
{
    get
    {
        if (_coveredDays != null)
        {
            return _coveredDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days",
            Length = 3,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-4 Covered Days instead of this field. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coveredDays = new HL7V26Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays.field.FieldRepetitions != null && _coveredDays.field.FieldRepetitions.Count > 0)
        {
            _coveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_coveredDays, fieldData);
        }

        return _coveredDays;
    } 
}

internal HL7V26Field _nonCoveredDays;

public HL7V26Field NonCoveredDays
{
    get
    {
        if (_nonCoveredDays != null)
        {
            return _nonCoveredDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days",
            Length = 3,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only. Use UB2-5 Non-Covered Days instead of this field. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays = new HL7V26Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays.field.FieldRepetitions != null && _nonCoveredDays.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_nonCoveredDays, fieldData);
        }

        return _nonCoveredDays;
    } 
}

internal HL7V26Field _valueAmountAndCode;

public HL7V26Field ValueAmountAndCode
{
    get
    {
        if (_valueAmountAndCode != null)
        {
            return _valueAmountAndCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 41,
            Usage = @"B",
            Rpt = @"8",
            DataType = @"UVC",
            DataTypeName = @"UB Value Code and Amount",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-6 Value Amount & Code instead of this field. This field contains a monetary amount and an associated billing code. This field is defined by CMS or other regulatory agencies.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
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
                            Description = @"Analogous to “Identifier” in component 1.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
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
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
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
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, ""MSH-17-country code"", in section 2.14.9.17, is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _valueAmountAndCode = new HL7V26Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode.field.FieldRepetitions != null && _valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_valueAmountAndCode, fieldData);
        }

        return _valueAmountAndCode;
    } 
}

internal HL7V26Field _numberOfGraceDays;

public HL7V26Field NumberOfGraceDays
{
    get
    {
        if (_numberOfGraceDays != null)
        {
            return _numberOfGraceDays;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.11",
            Type = @"Field",
            Position = @"UB1.11",
            Name = @"Number Of Grace Days",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days necessary to arrange for the patients post-discharge care following provider review organization/utilization review (PRO/UR) determination.. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _numberOfGraceDays = new HL7V26Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays.field.FieldRepetitions != null && _numberOfGraceDays.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_numberOfGraceDays, fieldData);
        }

        return _numberOfGraceDays;
    } 
}

internal HL7V26Field _specialProgramIndicator;

public HL7V26Field SpecialProgramIndicator
{
    get
    {
        if (_specialProgramIndicator != null)
        {
            return _specialProgramIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Special Program Indicator",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0348",
            TableName = @"Special Program Indicator",
            Description = @"This field contains an indicator for special funding programs, such as physically handicapped childrens program, family planning, and disability. This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0348 - Special Program Indicator for suggested values. Refer to a UB specification for additional information",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.7",
                            Type = @"Component",
                            Position = @"UB1.12.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.8",
                            Type = @"Component",
                            Position = @"UB1.12.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.9",
                            Type = @"Component",
                            Position = @"UB1.12.9",
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
                        },
                        }
        }

        _specialProgramIndicator = new HL7V26Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialProgramIndicator.field.FieldRepetitions != null && _specialProgramIndicator.field.FieldRepetitions.Count > 0)
        {
            _specialProgramIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_specialProgramIndicator, fieldData);
        }

        return _specialProgramIndicator;
    } 
}

internal HL7V26Field _pSROURApprovalIndicator;

public HL7V26Field PSROURApprovalIndicator
{
    get
    {
        if (_pSROURApprovalIndicator != null)
        {
            return _pSROURApprovalIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"PSRO/UR Approval Indicator",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0349",
            TableName = @"PSRO/UR Approval Indicator",
            Description = @"This field contains a code for the provider service review organization/utilization review (PSRO/UR) approval indicator. This field is defined by CMS or other regulatory agencies. Refer toUser-defined Table 0349 - PSRO/UR Approval Indicator for suggested values.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.7",
                            Type = @"Component",
                            Position = @"UB1.13.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.8",
                            Type = @"Component",
                            Position = @"UB1.13.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.9",
                            Type = @"Component",
                            Position = @"UB1.13.9",
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
                        },
                        }
        }

        _pSROURApprovalIndicator = new HL7V26Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovalIndicator.field.FieldRepetitions != null && _pSROURApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pSROURApprovalIndicator, fieldData);
        }

        return _pSROURApprovalIndicator;
    } 
}

internal HL7V26Field _pSROURApprovedStayFm;

public HL7V26Field PSROURApprovedStayFm
{
    get
    {
        if (_pSROURApprovedStayFm != null)
        {
            return _pSROURApprovedStayFm;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"PSRO/UR Approved Stay-Fm",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (from). This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayFm = new HL7V26Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayFm.field.FieldRepetitions != null && _pSROURApprovedStayFm.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayFm.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pSROURApprovedStayFm, fieldData);
        }

        return _pSROURApprovedStayFm;
    } 
}

internal HL7V26Field _pSROURApprovedStayTo;

public HL7V26Field PSROURApprovedStayTo
{
    get
    {
        if (_pSROURApprovedStayTo != null)
        {
            return _pSROURApprovedStayTo;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"PSRO/UR Approved Stay-To",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (to). This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayTo = new HL7V26Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayTo.field.FieldRepetitions != null && _pSROURApprovedStayTo.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_pSROURApprovedStayTo, fieldData);
        }

        return _pSROURApprovedStayTo;
    } 
}

internal HL7V26Field _occurrence;

public HL7V26Field Occurrence
{
    get
    {
        if (_occurrence != null)
        {
            return _occurrence;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence",
            Length = 259,
            Usage = @"B",
            Rpt = @"5",
            DataType = @"OCD",
            DataTypeName = @"Occurrence Code and Date",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-7 Occurrence Code & Date instead of this field. This field is defined by CMS or other regulatory agencies.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
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
                            Description = @"Analogous to “Identifier” in component 1.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
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
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
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
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
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

        _occurrence = new HL7V26Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence.field.FieldRepetitions != null && _occurrence.field.FieldRepetitions.Count > 0)
        {
            _occurrence.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurrence, fieldData);
        }

        return _occurrence;
    } 
}

internal HL7V26Field _occurrenceSpan;

public HL7V26Field OccurrenceSpan
{
    get
    {
        if (_occurrenceSpan != null)
        {
            return _occurrenceSpan;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span",
            Length = 250,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0351",
            TableName = @"Occurrence span",
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-8 Occurrence Span Code/Date instead of this field. This field is defined by CMS or other regulatory agencies. Refer to User-defined Table 0351 - Occurrence Span in Chapter 2 for suggested values.",
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
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
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
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
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
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
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
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
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
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
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
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.7",
                            Type = @"Component",
                            Position = @"UB1.17.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.8",
                            Type = @"Component",
                            Position = @"UB1.17.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.9",
                            Type = @"Component",
                            Position = @"UB1.17.9",
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
                        },
                        }
        }

        _occurrenceSpan = new HL7V26Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan.field.FieldRepetitions != null && _occurrenceSpan.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurrenceSpan, fieldData);
        }

        return _occurrenceSpan;
    } 
}

internal HL7V26Field _occurSpanStartDate;

public HL7V26Field OccurSpanStartDate
{
    get
    {
        if (_occurSpanStartDate != null)
        {
            return _occurSpanStartDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date",
            Length = 8,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-8 Occurrence Span Code/Date instead of this field. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _occurSpanStartDate = new HL7V26Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanStartDate.field.FieldRepetitions != null && _occurSpanStartDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurSpanStartDate, fieldData);
        }

        return _occurSpanStartDate;
    } 
}

internal HL7V26Field _occurSpanEndDate;

public HL7V26Field OccurSpanEndDate
{
    get
    {
        if (_occurSpanEndDate != null)
        {
            return _occurSpanEndDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date",
            Length = 8,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"As of Version 2.6, t his field has been retained for backward compatibility only.  Use UB2-8 Occurrence Span Code/Date instead of this field. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _occurSpanEndDate = new HL7V26Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanEndDate.field.FieldRepetitions != null && _occurSpanEndDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurSpanEndDate, fieldData);
        }

        return _occurSpanEndDate;
    } 
}

internal HL7V26Field _uB82Locator2;

public HL7V26Field UB82Locator2
{
    get
    {
        if (_uB82Locator2 != null)
        {
            return _uB82Locator2;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"Defined by UB-82 CMS specification and maintained for backward compatibility.",
            Sample = @"",
            Fields = null
        }

        _uB82Locator2 = new HL7V26Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator2.field.FieldRepetitions != null && _uB82Locator2.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB82Locator2, fieldData);
        }

        return _uB82Locator2;
    } 
}

internal HL7V26Field _uB82Locator9;

public HL7V26Field UB82Locator9
{
    get
    {
        if (_uB82Locator9 != null)
        {
            return _uB82Locator9;
        }

        var fieldData = new HL7V26FieldData
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

        _uB82Locator9 = new HL7V26Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator9.field.FieldRepetitions != null && _uB82Locator9.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB82Locator9, fieldData);
        }

        return _uB82Locator9;
    } 
}

internal HL7V26Field _uB82Locator27;

public HL7V26Field UB82Locator27
{
    get
    {
        if (_uB82Locator27 != null)
        {
            return _uB82Locator27;
        }

        var fieldData = new HL7V26FieldData
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

        _uB82Locator27 = new HL7V26Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator27.field.FieldRepetitions != null && _uB82Locator27.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB82Locator27, fieldData);
        }

        return _uB82Locator27;
    } 
}

internal HL7V26Field _uB82Locator45;

public HL7V26Field UB82Locator45
{
    get
    {
        if (_uB82Locator45 != null)
        {
            return _uB82Locator45;
        }

        var fieldData = new HL7V26FieldData
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

        _uB82Locator45 = new HL7V26Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator45.field.FieldRepetitions != null && _uB82Locator45.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB82Locator45, fieldData);
        }

        return _uB82Locator45;
    } 
}
    }
}

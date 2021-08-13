using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"UB92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills specific to the United States; other realms may choose to implement using regional code sets. Only UB92 fields that do not exist in other HL7 defined segments appear in this segment.  For example, Patient Name and Date of Birth are required; they are included in the PID segment and therefore do not appear here. UB92 field locators are provided in parentheses ( ). The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information."; } }
        
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

        public HL7V26SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDUB2;

public HL7V26Field SetIDUB2
{
    get
    {
        if (_setIDUB2 != null)
        {
            return _setIDUB2;
        }

        var fieldData = new HL7V26FieldData
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

        _setIDUB2 = new HL7V26Field
        {
            field = message[@"UB2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB2.field.FieldRepetitions != null && _setIDUB2.field.FieldRepetitions.Count > 0)
        {
            _setIDUB2.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDUB2, fieldData);
        }

        return _setIDUB2;
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
            Description = @"This field contains the number of inpatient days exceeding defined benefit coverage. In the US, this corresponds to UB92 form locator 9. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays = new HL7V26Field
        {
            field = message[@"UB2"][2],
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
            TableName = @"Condition Code",
            Description = @"This field contains a code reporting conditions that may affect payer processing; for example, the condition is related to employment (Patient covered by insurance not reflected here, treatment of non-terminal condition for hospice patient). The code in this field can repeat up to seven times to correspond to UB92 form locators 24-30. Refer to User-defined Table 0043 - Condition Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V26Field
        {
            field = message[@"UB2"][3],
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
            Description = @"This field contains UB92 field 7. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coveredDays = new HL7V26Field
        {
            field = message[@"UB2"][4],
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
            Description = @"This field contains UB92 field 8. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays = new HL7V26Field
        {
            field = message[@"UB2"][5],
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

internal HL7V26Field _valueAmountandCode;

public HL7V26Field ValueAmountandCode
{
    get
    {
        if (_valueAmountandCode != null)
        {
            return _valueAmountandCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount and Code",
            Length = 41,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"UVC",
            DataTypeName = @"UB Value Code and Amount",
            TableId = null,
            TableName = null,
            Description = @"This field contains a monetary amount and an associated billing code. The pair in this field can repeat up to twelve times to represent/contain UB92 form locators 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.6.1",
                            Type = @"Component",
                            Position = @"UB2.6.1",
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
                            Id = @"UB2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.1",
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
                            Id = @"UB2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.2",
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
                            Id = @"UB2.6.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.3",
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
                            Id = @"UB2.6.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.4",
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
                            Id = @"UB2.6.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.5",
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
                            Id = @"UB2.6.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.6",
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
                            Id = @"UB2.6.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.7",
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
                            Id = @"UB2.6.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.8",
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
                            Id = @"UB2.6.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.9",
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
                            Id = @"UB2.6.2",
                            Type = @"Component",
                            Position = @"UB2.6.2",
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
                            Id = @"UB2.6.2.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.1",
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
                            Id = @"UB2.6.2.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.2",
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

        _valueAmountandCode = new HL7V26Field
        {
            field = message[@"UB2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountandCode.field.FieldRepetitions != null && _valueAmountandCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountandCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_valueAmountandCode, fieldData);
        }

        return _valueAmountandCode;
    } 
}

internal HL7V26Field _occurrenceCodeandDate;

public HL7V26Field OccurrenceCodeandDate
{
    get
    {
        if (_occurrenceCodeandDate != null)
        {
            return _occurrenceCodeandDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code and Date",
            Length = 259,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"OCD",
            DataTypeName = @"Occurrence Code and Date",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to eight times. UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.7.1",
                            Type = @"Component",
                            Position = @"UB2.7.1",
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
                            Id = @"UB2.7.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.1",
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
                            Id = @"UB2.7.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.2",
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
                            Id = @"UB2.7.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.3",
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
                            Id = @"UB2.7.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.4",
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
                            Id = @"UB2.7.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.5",
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
                            Id = @"UB2.7.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.6",
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
                            Id = @"UB2.7.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.7",
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
                            Id = @"UB2.7.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.8",
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
                            Id = @"UB2.7.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.9",
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
                            Id = @"UB2.7.2",
                            Type = @"Component",
                            Position = @"UB2.7.2",
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

        _occurrenceCodeandDate = new HL7V26Field
        {
            field = message[@"UB2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceCodeandDate.field.FieldRepetitions != null && _occurrenceCodeandDate.field.FieldRepetitions.Count > 0)
        {
            _occurrenceCodeandDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurrenceCodeandDate, fieldData);
        }

        return _occurrenceCodeandDate;
    } 
}

internal HL7V26Field _occurrenceSpanCodeDates;

public HL7V26Field OccurrenceSpanCodeDates
{
    get
    {
        if (_occurrenceSpanCodeDates != null)
        {
            return _occurrenceSpanCodeDates;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code/Dates",
            Length = 268,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"OSP",
            DataTypeName = @"Occurrence Span Code and Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.8.1",
                            Type = @"Component",
                            Position = @"UB2.8.1",
                            Name = @"Occurrence Span Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = @"The NUBC code itself that identifies an event that relates to the payment of a claim.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.1",
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
                            Id = @"UB2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.2",
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
                            Id = @"UB2.8.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.3",
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
                            Id = @"UB2.8.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.4",
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
                            Id = @"UB2.8.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.5",
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
                            Id = @"UB2.8.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.6",
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
                            Id = @"UB2.8.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.7",
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
                            Id = @"UB2.8.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.8",
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
                            Id = @"UB2.8.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.9",
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
                            Id = @"UB2.8.2",
                            Type = @"Component",
                            Position = @"UB2.8.2",
                            Name = @"Occurrence Span Start Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event started that relates to the payment of a claim.

Either start or stop date or both must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.3",
                            Type = @"Component",
                            Position = @"UB2.8.3",
                            Name = @"Occurrence Span Stop Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event ended that relates to the payment of a claim.

Either start or stop date or both must be present.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrenceSpanCodeDates = new HL7V26Field
        {
            field = message[@"UB2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanCodeDates.field.FieldRepetitions != null && _occurrenceSpanCodeDates.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanCodeDates.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_occurrenceSpanCodeDates, fieldData);
        }

        return _occurrenceSpanCodeDates;
    } 
}

internal HL7V26Field _uB92Locator2State;

public HL7V26Field UB92Locator2State
{
    get
    {
        if (_uB92Locator2State != null)
        {
            return _uB92Locator2State;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"UB92 Locator 2 (State)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an occurrence span code and an associated date. This field can repeat up to two times to represent/contain UB92 form locators 36a and 36b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator2State = new HL7V26Field
        {
            field = message[@"UB2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator2State.field.FieldRepetitions != null && _uB92Locator2State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator2State.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator2State, fieldData);
        }

        return _uB92Locator2State;
    } 
}

internal HL7V26Field _uB92Locator11State;

public HL7V26Field UB92Locator11State
{
    get
    {
        if (_uB92Locator11State != null)
        {
            return _uB92Locator11State;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"UB92 Locator 11 (State)",
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

        _uB92Locator11State = new HL7V26Field
        {
            field = message[@"UB2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator11State.field.FieldRepetitions != null && _uB92Locator11State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator11State.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator11State, fieldData);
        }

        return _uB92Locator11State;
    } 
}

internal HL7V26Field _uB92Locator31National;

public HL7V26Field UB92Locator31National
{
    get
    {
        if (_uB92Locator31National != null)
        {
            return _uB92Locator31National;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"UB92 Locator 31 (National)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator31National = new HL7V26Field
        {
            field = message[@"UB2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator31National.field.FieldRepetitions != null && _uB92Locator31National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator31National.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator31National, fieldData);
        }

        return _uB92Locator31National;
    } 
}

internal HL7V26Field _documentControlNumber;

public HL7V26Field DocumentControlNumber
{
    get
    {
        if (_documentControlNumber != null)
        {
            return _documentControlNumber;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times. Refer UB92 field 37",
            Sample = @"",
            Fields = null
        }

        _documentControlNumber = new HL7V26Field
        {
            field = message[@"UB2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentControlNumber.field.FieldRepetitions != null && _documentControlNumber.field.FieldRepetitions.Count > 0)
        {
            _documentControlNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_documentControlNumber, fieldData);
        }

        return _documentControlNumber;
    } 
}

internal HL7V26Field _uB92Locator49National;

public HL7V26Field UB92Locator49National
{
    get
    {
        if (_uB92Locator49National != null)
        {
            return _uB92Locator49National;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"UB92 Locator 49 (National)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by CMS or other regulatory agencies. This field may repeat up to twenty-three times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator49National = new HL7V26Field
        {
            field = message[@"UB2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator49National.field.FieldRepetitions != null && _uB92Locator49National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator49National.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator49National, fieldData);
        }

        return _uB92Locator49National;
    } 
}

internal HL7V26Field _uB92Locator56State;

public HL7V26Field UB92Locator56State
{
    get
    {
        if (_uB92Locator56State != null)
        {
            return _uB92Locator56State;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"UB92 Locator 56 (State)",
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

        _uB92Locator56State = new HL7V26Field
        {
            field = message[@"UB2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator56State.field.FieldRepetitions != null && _uB92Locator56State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator56State.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator56State, fieldData);
        }

        return _uB92Locator56State;
    } 
}

internal HL7V26Field _uB92Locator57National;

public HL7V26Field UB92Locator57National
{
    get
    {
        if (_uB92Locator57National != null)
        {
            return _uB92Locator57National;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"UB92 Locator 57 (National)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-92 CMS specification.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator57National = new HL7V26Field
        {
            field = message[@"UB2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator57National.field.FieldRepetitions != null && _uB92Locator57National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator57National.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator57National, fieldData);
        }

        return _uB92Locator57National;
    } 
}

internal HL7V26Field _uB92Locator78State;

public HL7V26Field UB92Locator78State
{
    get
    {
        if (_uB92Locator78State != null)
        {
            return _uB92Locator78State;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"UB92 Locator 78 (State)",
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

        _uB92Locator78State = new HL7V26Field
        {
            field = message[@"UB2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator78State.field.FieldRepetitions != null && _uB92Locator78State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator78State.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_uB92Locator78State, fieldData);
        }

        return _uB92Locator78State;
    } 
}

internal HL7V26Field _specialVisitCount;

public HL7V26Field SpecialVisitCount
{
    get
    {
        if (_specialVisitCount != null)
        {
            return _specialVisitCount;
        }

        var fieldData = new HL7V26FieldData
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

        _specialVisitCount = new HL7V26Field
        {
            field = message[@"UB2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialVisitCount.field.FieldRepetitions != null && _specialVisitCount.field.FieldRepetitions.Count > 0)
        {
            _specialVisitCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_specialVisitCount, fieldData);
        }

        return _specialVisitCount;
    } 
}
    }
}

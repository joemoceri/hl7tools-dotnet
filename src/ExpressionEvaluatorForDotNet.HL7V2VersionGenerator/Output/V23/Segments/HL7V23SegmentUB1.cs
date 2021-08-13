using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentUB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB1"; } }

        public string SegmentId { get { return @"UB1"; } }
        
        public string LongName { get { return @"UB82  data"; } }
        
        public string Description { get { return @"The UB1 segment contains the data necessary to complete UB82 bills.  Only UB82 fields that do not exist in other HL7 defined segments appear in this segment.  Patient Name and Date of Birth are required for UB82 billing; however, they are included in the PID segment and therefore do not appear here."; } }
        
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

        public HL7V23SegmentUB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDUB1;

public HL7V23Field SetIDUB1
{
    get
    {
        if (_setIDUB1 != null)
        {
            return _setIDUB1;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc. ",
            Sample = @"",
            Fields = null
        }

        _setIDUB1 = new HL7V23Field
        {
            field = message[@"UB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB1.field.FieldRepetitions != null && _setIDUB1.field.FieldRepetitions.Count > 0)
        {
            _setIDUB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDUB1, fieldData);
        }

        return _setIDUB1;
    } 
}

internal HL7V23Field _bloodDeductible;

public HL7V23Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.2",
            Type = @"Field",
            Position = @"UB1.2",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  Use IN2-21-blood deductible instead of this field, as the blood deductible can be associated with the specific insurance plan via that segment.  This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible = new HL7V23Field
        {
            field = message[@"UB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V23Field _bloodFurnishedPintsOf;

public HL7V23Field BloodFurnishedPintsOf
{
    get
    {
        if (_bloodFurnishedPintsOf != null)
        {
            return _bloodFurnishedPintsOf;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.3",
            Type = @"Field",
            Position = @"UB1.3",
            Name = @"Blood Furnished Pints Of",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the amount of blood furnished to the patient for this visit.  The (40) indicates the corresponding UB82 field number. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodFurnishedPintsOf = new HL7V23Field
        {
            field = message[@"UB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodFurnishedPintsOf.field.FieldRepetitions != null && _bloodFurnishedPintsOf.field.FieldRepetitions.Count > 0)
        {
            _bloodFurnishedPintsOf.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_bloodFurnishedPintsOf, fieldData);
        }

        return _bloodFurnishedPintsOf;
    } 
}

internal HL7V23Field _bloodReplacedPints;

public HL7V23Field BloodReplacedPints
{
    get
    {
        if (_bloodReplacedPints != null)
        {
            return _bloodReplacedPints;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.4",
            Type = @"Field",
            Position = @"UB1.4",
            Name = @"Blood Replaced Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 41. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodReplacedPints = new HL7V23Field
        {
            field = message[@"UB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodReplacedPints.field.FieldRepetitions != null && _bloodReplacedPints.field.FieldRepetitions.Count > 0)
        {
            _bloodReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_bloodReplacedPints, fieldData);
        }

        return _bloodReplacedPints;
    } 
}

internal HL7V23Field _bloodNotReplacedPints;

public HL7V23Field BloodNotReplacedPints
{
    get
    {
        if (_bloodNotReplacedPints != null)
        {
            return _bloodNotReplacedPints;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.5",
            Type = @"Field",
            Position = @"UB1.5",
            Name = @"Blood Not Replaced Pints",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the blood not replaced, as measured in pints.  UB82 Field 42. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _bloodNotReplacedPints = new HL7V23Field
        {
            field = message[@"UB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodNotReplacedPints.field.FieldRepetitions != null && _bloodNotReplacedPints.field.FieldRepetitions.Count > 0)
        {
            _bloodNotReplacedPints.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_bloodNotReplacedPints, fieldData);
        }

        return _bloodNotReplacedPints;
    } 
}

internal HL7V23Field _coInsuranceDays;

public HL7V23Field CoInsuranceDays
{
    get
    {
        if (_coInsuranceDays != null)
        {
            return _coInsuranceDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.6",
            Type = @"Field",
            Position = @"UB1.6",
            Name = @"Co Insurance Days",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 25. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays = new HL7V23Field
        {
            field = message[@"UB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays.field.FieldRepetitions != null && _coInsuranceDays.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_coInsuranceDays, fieldData);
        }

        return _coInsuranceDays;
    } 
}

internal HL7V23Field _conditionCode;

public HL7V23Field ConditionCode
{
    get
    {
        if (_conditionCode != null)
        {
            return _conditionCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.7",
            Type = @"Field",
            Position = @"UB1.7",
            Name = @"Condition Code",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition code",
            Description = @"The code in this field repeats five times.  UB82 Fields (35), (36), (37), (38), and (39).   Refer to user-defined table 0043 - Condition code for suggested values. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _conditionCode = new HL7V23Field
        {
            field = message[@"UB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode.field.FieldRepetitions != null && _conditionCode.field.FieldRepetitions.Count > 0)
        {
            _conditionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_conditionCode, fieldData);
        }

        return _conditionCode;
    } 
}

internal HL7V23Field _coveredDays;

public HL7V23Field CoveredDays
{
    get
    {
        if (_coveredDays != null)
        {
            return _coveredDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.8",
            Type = @"Field",
            Position = @"UB1.8",
            Name = @"Covered Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 23. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _coveredDays = new HL7V23Field
        {
            field = message[@"UB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays.field.FieldRepetitions != null && _coveredDays.field.FieldRepetitions.Count > 0)
        {
            _coveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_coveredDays, fieldData);
        }

        return _coveredDays;
    } 
}

internal HL7V23Field _nonCoveredDays;

public HL7V23Field NonCoveredDays
{
    get
    {
        if (_nonCoveredDays != null)
        {
            return _nonCoveredDays;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.9",
            Type = @"Field",
            Position = @"UB1.9",
            Name = @"Non Covered Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB82 Field 24. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays = new HL7V23Field
        {
            field = message[@"UB1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays.field.FieldRepetitions != null && _nonCoveredDays.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nonCoveredDays, fieldData);
        }

        return _nonCoveredDays;
    } 
}

internal HL7V23Field _valueAmountAndCode;

public HL7V23Field ValueAmountAndCode
{
    get
    {
        if (_valueAmountAndCode != null)
        {
            return _valueAmountAndCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.10",
            Type = @"Field",
            Position = @"UB1.10",
            Name = @"Value Amount & Code",
            Length = 12,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"CM_UVC",
            DataTypeName = @"Value Code And Amount",
            TableId = null,
            TableName = null,
            Description = @"The pair in this field can repeat up to eight times (46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B).  Refer to user-defined table 0153 - Value code for suggested values. This field is defined by HCFA or other regulatory agencies.",
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

        _valueAmountAndCode = new HL7V23Field
        {
            field = message[@"UB1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountAndCode.field.FieldRepetitions != null && _valueAmountAndCode.field.FieldRepetitions.Count > 0)
        {
            _valueAmountAndCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_valueAmountAndCode, fieldData);
        }

        return _valueAmountAndCode;
    } 
}

internal HL7V23Field _numberOfGraceDays;

public HL7V23Field NumberOfGraceDays
{
    get
    {
        if (_numberOfGraceDays != null)
        {
            return _numberOfGraceDays;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains UB82 Field 90.  This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _numberOfGraceDays = new HL7V23Field
        {
            field = message[@"UB1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfGraceDays.field.FieldRepetitions != null && _numberOfGraceDays.field.FieldRepetitions.Count > 0)
        {
            _numberOfGraceDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_numberOfGraceDays, fieldData);
        }

        return _numberOfGraceDays;
    } 
}

internal HL7V23Field _specProgramIndicator;

public HL7V23Field SpecProgramIndicator
{
    get
    {
        if (_specProgramIndicator != null)
        {
            return _specProgramIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.12",
            Type = @"Field",
            Position = @"UB1.12",
            Name = @"Spec Program Indicator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the special program indicator.  UB82 Field 44.  This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.12.1",
                            Type = @"Component",
                            Position = @"UB1.12.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.2",
                            Type = @"Component",
                            Position = @"UB1.12.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.3",
                            Type = @"Component",
                            Position = @"UB1.12.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.4",
                            Type = @"Component",
                            Position = @"UB1.12.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.5",
                            Type = @"Component",
                            Position = @"UB1.12.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.12.6",
                            Type = @"Component",
                            Position = @"UB1.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _specProgramIndicator = new HL7V23Field
        {
            field = message[@"UB1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specProgramIndicator.field.FieldRepetitions != null && _specProgramIndicator.field.FieldRepetitions.Count > 0)
        {
            _specProgramIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specProgramIndicator, fieldData);
        }

        return _specProgramIndicator;
    } 
}

internal HL7V23Field _pSROURApprovalIndicator;

public HL7V23Field PSROURApprovalIndicator
{
    get
    {
        if (_pSROURApprovalIndicator != null)
        {
            return _pSROURApprovalIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.13",
            Type = @"Field",
            Position = @"UB1.13",
            Name = @"PSRO/UR Approval Indicator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approval indicator.  UB82 field 87. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.13.1",
                            Type = @"Component",
                            Position = @"UB1.13.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.2",
                            Type = @"Component",
                            Position = @"UB1.13.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.3",
                            Type = @"Component",
                            Position = @"UB1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.4",
                            Type = @"Component",
                            Position = @"UB1.13.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.5",
                            Type = @"Component",
                            Position = @"UB1.13.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.13.6",
                            Type = @"Component",
                            Position = @"UB1.13.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _pSROURApprovalIndicator = new HL7V23Field
        {
            field = message[@"UB1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovalIndicator.field.FieldRepetitions != null && _pSROURApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_pSROURApprovalIndicator, fieldData);
        }

        return _pSROURApprovalIndicator;
    } 
}

internal HL7V23Field _pSROURApprovedStayFm;

public HL7V23Field PSROURApprovedStayFm
{
    get
    {
        if (_pSROURApprovedStayFm != null)
        {
            return _pSROURApprovedStayFm;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.14",
            Type = @"Field",
            Position = @"UB1.14",
            Name = @"PSRO/UR Approved Stay Fm",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (from).  UB82 Field 88. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayFm = new HL7V23Field
        {
            field = message[@"UB1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayFm.field.FieldRepetitions != null && _pSROURApprovedStayFm.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayFm.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_pSROURApprovedStayFm, fieldData);
        }

        return _pSROURApprovedStayFm;
    } 
}

internal HL7V23Field _pSROURApprovedStayTo;

public HL7V23Field PSROURApprovedStayTo
{
    get
    {
        if (_pSROURApprovedStayTo != null)
        {
            return _pSROURApprovedStayTo;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.15",
            Type = @"Field",
            Position = @"UB1.15",
            Name = @"PSRO/UR Approved Stay To",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the PSRO/UR approved stay date (to).  UB82 Field 89. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _pSROURApprovedStayTo = new HL7V23Field
        {
            field = message[@"UB1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pSROURApprovedStayTo.field.FieldRepetitions != null && _pSROURApprovedStayTo.field.FieldRepetitions.Count > 0)
        {
            _pSROURApprovedStayTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_pSROURApprovedStayTo, fieldData);
        }

        return _pSROURApprovedStayTo;
    } 
}

internal HL7V23Field _occurrence;

public HL7V23Field Occurrence
{
    get
    {
        if (_occurrence != null)
        {
            return _occurrence;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.16",
            Type = @"Field",
            Position = @"UB1.16",
            Name = @"Occurrence",
            Length = 20,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"CM_OCD",
            DataTypeName = @"Occurence",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to five times.  UB82 Fields 28-32. This field is defined by HCFA or other regulatory agencies",
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
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.1",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.2",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.3",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.4",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.5",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.16.1.6",
                            Type = @"SubComponent",
                            Position = @"UB1.16.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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

        _occurrence = new HL7V23Field
        {
            field = message[@"UB1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrence.field.FieldRepetitions != null && _occurrence.field.FieldRepetitions.Count > 0)
        {
            _occurrence.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_occurrence, fieldData);
        }

        return _occurrence;
    } 
}

internal HL7V23Field _occurrenceSpan;

public HL7V23Field OccurrenceSpan
{
    get
    {
        if (_occurrenceSpan != null)
        {
            return _occurrenceSpan;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.17",
            Type = @"Field",
            Position = @"UB1.17",
            Name = @"Occurrence Span",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"UB82 Field 33. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB1.17.1",
                            Type = @"Component",
                            Position = @"UB1.17.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.2",
                            Type = @"Component",
                            Position = @"UB1.17.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.3",
                            Type = @"Component",
                            Position = @"UB1.17.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.4",
                            Type = @"Component",
                            Position = @"UB1.17.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.5",
                            Type = @"Component",
                            Position = @"UB1.17.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB1.17.6",
                            Type = @"Component",
                            Position = @"UB1.17.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrenceSpan = new HL7V23Field
        {
            field = message[@"UB1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpan.field.FieldRepetitions != null && _occurrenceSpan.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpan.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_occurrenceSpan, fieldData);
        }

        return _occurrenceSpan;
    } 
}

internal HL7V23Field _occurSpanStartDate;

public HL7V23Field OccurSpanStartDate
{
    get
    {
        if (_occurSpanStartDate != null)
        {
            return _occurSpanStartDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.18",
            Type = @"Field",
            Position = @"UB1.18",
            Name = @"Occur Span Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span start date.  UB82 Field 33. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _occurSpanStartDate = new HL7V23Field
        {
            field = message[@"UB1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanStartDate.field.FieldRepetitions != null && _occurSpanStartDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_occurSpanStartDate, fieldData);
        }

        return _occurSpanStartDate;
    } 
}

internal HL7V23Field _occurSpanEndDate;

public HL7V23Field OccurSpanEndDate
{
    get
    {
        if (_occurSpanEndDate != null)
        {
            return _occurSpanEndDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.19",
            Type = @"Field",
            Position = @"UB1.19",
            Name = @"Occur Span End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the occurrence span end date.  UB82 Field 33. This field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _occurSpanEndDate = new HL7V23Field
        {
            field = message[@"UB1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurSpanEndDate.field.FieldRepetitions != null && _occurSpanEndDate.field.FieldRepetitions.Count > 0)
        {
            _occurSpanEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_occurSpanEndDate, fieldData);
        }

        return _occurSpanEndDate;
    } 
}

internal HL7V23Field _uB82Locator2;

public HL7V23Field UB82Locator2
{
    get
    {
        if (_uB82Locator2 != null)
        {
            return _uB82Locator2;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.20",
            Type = @"Field",
            Position = @"UB1.20",
            Name = @"UB 82 Locator 2",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" Defined by UB-82 HCFA specification",
            Sample = @"",
            Fields = null
        }

        _uB82Locator2 = new HL7V23Field
        {
            field = message[@"UB1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator2.field.FieldRepetitions != null && _uB82Locator2.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator2.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_uB82Locator2, fieldData);
        }

        return _uB82Locator2;
    } 
}

internal HL7V23Field _uB82Locator9;

public HL7V23Field UB82Locator9
{
    get
    {
        if (_uB82Locator9 != null)
        {
            return _uB82Locator9;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.21",
            Type = @"Field",
            Position = @"UB1.21",
            Name = @"UB 82 Locator 9",
            Length = 7,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" Defined by UB-82 HCFA specification",
            Sample = @"",
            Fields = null
        }

        _uB82Locator9 = new HL7V23Field
        {
            field = message[@"UB1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator9.field.FieldRepetitions != null && _uB82Locator9.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator9.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_uB82Locator9, fieldData);
        }

        return _uB82Locator9;
    } 
}

internal HL7V23Field _uB82Locator27;

public HL7V23Field UB82Locator27
{
    get
    {
        if (_uB82Locator27 != null)
        {
            return _uB82Locator27;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.22",
            Type = @"Field",
            Position = @"UB1.22",
            Name = @"UB 82 Locator 27",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" Defined by UB-82 HCFA specification",
            Sample = @"",
            Fields = null
        }

        _uB82Locator27 = new HL7V23Field
        {
            field = message[@"UB1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator27.field.FieldRepetitions != null && _uB82Locator27.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator27.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_uB82Locator27, fieldData);
        }

        return _uB82Locator27;
    } 
}

internal HL7V23Field _uB82Locator45;

public HL7V23Field UB82Locator45
{
    get
    {
        if (_uB82Locator45 != null)
        {
            return _uB82Locator45;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"UB1.23",
            Type = @"Field",
            Position = @"UB1.23",
            Name = @"UB 82 Locator 45",
            Length = 17,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @" Defined by UB-82 HCFA specification",
            Sample = @"",
            Fields = null
        }

        _uB82Locator45 = new HL7V23Field
        {
            field = message[@"UB1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB82Locator45.field.FieldRepetitions != null && _uB82Locator45.field.FieldRepetitions.Count > 0)
        {
            _uB82Locator45.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_uB82Locator45, fieldData);
        }

        return _uB82Locator45;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentRXA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXA"; } }

        public string SegmentId { get { return @"RXA"; } }
        
        public string LongName { get { return @"Pharmacy/Treatment Administration"; } }
        
        public string Description { get { return @"The ORC must have the filler order number and the order control code RE. As a site-specific variant, the RXO and associated RXCs and/or the RXE (and associated RXCs) may be present if the receiving application needs any of their data. The RXA carries the administration data."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V24SegmentRXA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _giveSubIDCounter;

public HL7V24Field GiveSubIDCounter
{
    get
    {
        if (_giveSubIDCounter != null)
        {
            return _giveSubIDCounter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.1",
            Type = @"Field",
            Position = @"RXA.1",
            Name = @"Give Sub-ID Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use this field if matching this RXA segment to its corresponding RXG segment. If the two applications are not matching RXG and RXA segments, this fields value is zero (0).",
            Sample = @"",
            Fields = null
        }

        _giveSubIDCounter = new HL7V24Field
        {
            field = message[@"RXA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveSubIDCounter.field.FieldRepetitions != null && _giveSubIDCounter.field.FieldRepetitions.Count > 0)
        {
            _giveSubIDCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_giveSubIDCounter, fieldData);
        }

        return _giveSubIDCounter;
    } 
}

internal HL7V24Field _administrationSubIDCounter;

public HL7V24Field AdministrationSubIDCounter
{
    get
    {
        if (_administrationSubIDCounter != null)
        {
            return _administrationSubIDCounter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.2",
            Type = @"Field",
            Position = @"RXA.2",
            Name = @"Administration Sub-ID Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field starts with 1 the first time that medication/treatment is administered for this order. Increments by one with each additional administration the medication/treatment.",
            Sample = @"",
            Fields = null
        }

        _administrationSubIDCounter = new HL7V24Field
        {
            field = message[@"RXA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administrationSubIDCounter.field.FieldRepetitions != null && _administrationSubIDCounter.field.FieldRepetitions.Count > 0)
        {
            _administrationSubIDCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administrationSubIDCounter, fieldData);
        }

        return _administrationSubIDCounter;
    } 
}

internal HL7V24Field _dateTimeStartofAdministration;

public HL7V24Field DateTimeStartofAdministration
{
    get
    {
        if (_dateTimeStartofAdministration != null)
        {
            return _dateTimeStartofAdministration;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.3",
            Type = @"Field",
            Position = @"RXA.3",
            Name = @"Date/Time Start of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If the order is for a continuous administration (such as an IV), and the rate is changed at a certain time after the start, an RAS message can be issued to record the change. For such an RAS message, this field records the time the rate was changed to the new value recorded in the RXA-12-administered per (time unit) of the same message.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.3.1",
                            Type = @"Component",
                            Position = @"RXA.3.1",
                            Name = @"Time Of An Event",
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
                            Id = @"RXA.3.2",
                            Type = @"Component",
                            Position = @"RXA.3.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateTimeStartofAdministration = new HL7V24Field
        {
            field = message[@"RXA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeStartofAdministration.field.FieldRepetitions != null && _dateTimeStartofAdministration.field.FieldRepetitions.Count > 0)
        {
            _dateTimeStartofAdministration.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dateTimeStartofAdministration, fieldData);
        }

        return _dateTimeStartofAdministration;
    } 
}

internal HL7V24Field _dateTimeEndofAdministration;

public HL7V24Field DateTimeEndofAdministration
{
    get
    {
        if (_dateTimeEndofAdministration != null)
        {
            return _dateTimeEndofAdministration;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.4",
            Type = @"Field",
            Position = @"RXA.4",
            Name = @"Date/Time End of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If null, the date/time of RXA-3-date/time start of administration is assumed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.4.1",
                            Type = @"Component",
                            Position = @"RXA.4.1",
                            Name = @"Time Of An Event",
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
                            Id = @"RXA.4.2",
                            Type = @"Component",
                            Position = @"RXA.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateTimeEndofAdministration = new HL7V24Field
        {
            field = message[@"RXA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeEndofAdministration.field.FieldRepetitions != null && _dateTimeEndofAdministration.field.FieldRepetitions.Count > 0)
        {
            _dateTimeEndofAdministration.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dateTimeEndofAdministration, fieldData);
        }

        return _dateTimeEndofAdministration;
    } 
}

internal HL7V24Field _administeredCode;

public HL7V24Field AdministeredCode
{
    get
    {
        if (_administeredCode != null)
        {
            return _administeredCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.5",
            Type = @"Field",
            Position = @"RXA.5",
            Name = @"Administered Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0292",
            TableName = @"Vaccines administered",
            Description = @"This field contains the identifier of the medical substance/treatment administered. It is equivalent to OBR-4-universal service ID in function. If the substance administered is a vaccine, CVX codes may be used to code this field (see HL7 Table 0292 - Vaccines administered ).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.5.1",
                            Type = @"Component",
                            Position = @"RXA.5.1",
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
                            Id = @"RXA.5.2",
                            Type = @"Component",
                            Position = @"RXA.5.2",
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
                            Id = @"RXA.5.3",
                            Type = @"Component",
                            Position = @"RXA.5.3",
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
                            Id = @"RXA.5.4",
                            Type = @"Component",
                            Position = @"RXA.5.4",
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
                            Id = @"RXA.5.5",
                            Type = @"Component",
                            Position = @"RXA.5.5",
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
                            Id = @"RXA.5.6",
                            Type = @"Component",
                            Position = @"RXA.5.6",
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
                        },
                        }
        }

        _administeredCode = new HL7V24Field
        {
            field = message[@"RXA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredCode.field.FieldRepetitions != null && _administeredCode.field.FieldRepetitions.Count > 0)
        {
            _administeredCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredCode, fieldData);
        }

        return _administeredCode;
    } 
}

internal HL7V24Field _administeredAmount;

public HL7V24Field AdministeredAmount
{
    get
    {
        if (_administeredAmount != null)
        {
            return _administeredAmount;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.6",
            Type = @"Field",
            Position = @"RXA.6",
            Name = @"Administered Amount",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the amount administered.",
            Sample = @"",
            Fields = null
        }

        _administeredAmount = new HL7V24Field
        {
            field = message[@"RXA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredAmount.field.FieldRepetitions != null && _administeredAmount.field.FieldRepetitions.Count > 0)
        {
            _administeredAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredAmount, fieldData);
        }

        return _administeredAmount;
    } 
}

internal HL7V24Field _administeredUnits;

public HL7V24Field AdministeredUnits
{
    get
    {
        if (_administeredUnits != null)
        {
            return _administeredUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.7",
            Type = @"Field",
            Position = @"RXA.7",
            Name = @"Administered Units",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is conditional because it is required if the administered amount code does not imply units. This field must be in simple units that reflect the actual quantity of the substance administered. It does not include compound units.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.7.1",
                            Type = @"Component",
                            Position = @"RXA.7.1",
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
                            Id = @"RXA.7.2",
                            Type = @"Component",
                            Position = @"RXA.7.2",
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
                            Id = @"RXA.7.3",
                            Type = @"Component",
                            Position = @"RXA.7.3",
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
                            Id = @"RXA.7.4",
                            Type = @"Component",
                            Position = @"RXA.7.4",
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
                            Id = @"RXA.7.5",
                            Type = @"Component",
                            Position = @"RXA.7.5",
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
                            Id = @"RXA.7.6",
                            Type = @"Component",
                            Position = @"RXA.7.6",
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
                        },
                        }
        }

        _administeredUnits = new HL7V24Field
        {
            field = message[@"RXA"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredUnits.field.FieldRepetitions != null && _administeredUnits.field.FieldRepetitions.Count > 0)
        {
            _administeredUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredUnits, fieldData);
        }

        return _administeredUnits;
    } 
}

internal HL7V24Field _administeredDosageForm;

public HL7V24Field AdministeredDosageForm
{
    get
    {
        if (_administeredDosageForm != null)
        {
            return _administeredDosageForm;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.8",
            Type = @"Field",
            Position = @"RXA.8",
            Name = @"Administered Dosage Form",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"The dosage form indicates the manner in which the medication/treatment is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the dispense/give code in RXA-5-Administered code. Use this field when the administered code does not specify the dosage form.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.8.1",
                            Type = @"Component",
                            Position = @"RXA.8.1",
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
                            Id = @"RXA.8.2",
                            Type = @"Component",
                            Position = @"RXA.8.2",
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
                            Id = @"RXA.8.3",
                            Type = @"Component",
                            Position = @"RXA.8.3",
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
                            Id = @"RXA.8.4",
                            Type = @"Component",
                            Position = @"RXA.8.4",
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
                            Id = @"RXA.8.5",
                            Type = @"Component",
                            Position = @"RXA.8.5",
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
                            Id = @"RXA.8.6",
                            Type = @"Component",
                            Position = @"RXA.8.6",
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
                        },
                        }
        }

        _administeredDosageForm = new HL7V24Field
        {
            field = message[@"RXA"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredDosageForm.field.FieldRepetitions != null && _administeredDosageForm.field.FieldRepetitions.Count > 0)
        {
            _administeredDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredDosageForm, fieldData);
        }

        return _administeredDosageForm;
    } 
}

internal HL7V24Field _administrationNotes;

public HL7V24Field AdministrationNotes
{
    get
    {
        if (_administrationNotes != null)
        {
            return _administrationNotes;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.9",
            Type = @"Field",
            Position = @"RXA.9",
            Name = @"Administration Notes",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains notes from the provider administering the medication/treatment. If coded, requires a user-defined table. If free text (describing a custom IV, mixture, or salve, for example) place a null in the first component and the text in the second, e.g., |^this is a free text administration note| .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.9.1",
                            Type = @"Component",
                            Position = @"RXA.9.1",
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
                            Id = @"RXA.9.2",
                            Type = @"Component",
                            Position = @"RXA.9.2",
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
                            Id = @"RXA.9.3",
                            Type = @"Component",
                            Position = @"RXA.9.3",
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
                            Id = @"RXA.9.4",
                            Type = @"Component",
                            Position = @"RXA.9.4",
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
                            Id = @"RXA.9.5",
                            Type = @"Component",
                            Position = @"RXA.9.5",
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
                            Id = @"RXA.9.6",
                            Type = @"Component",
                            Position = @"RXA.9.6",
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
                        },
                        }
        }

        _administrationNotes = new HL7V24Field
        {
            field = message[@"RXA"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administrationNotes.field.FieldRepetitions != null && _administrationNotes.field.FieldRepetitions.Count > 0)
        {
            _administrationNotes.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administrationNotes, fieldData);
        }

        return _administrationNotes;
    } 
}

internal HL7V24Field _administeringProvider;

public HL7V24Field AdministeringProvider
{
    get
    {
        if (_administeringProvider != null)
        {
            return _administeringProvider;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.10",
            Type = @"Field",
            Position = @"RXA.10",
            Name = @"Administering Provider",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field contains the provider ID of the person administering the pharmaceutical/treatment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.10.1",
                            Type = @"Component",
                            Position = @"RXA.10.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2",
                            Type = @"Component",
                            Position = @"RXA.10.2",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19,  FN - family name.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.1",
                            Name = @"Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = @"The atomic element of the person's family name. In most Western usage, this is the person's last name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.2",
                            Name = @"Own Surname Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.3",
                            Name = @"Own Surname",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the surname (in most Western usage, the last name) that is derived from the person's own surname, as distinguished from any portion that is derived from the surname of the person's partner or spouse. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.4",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.4",
                            Name = @"Surname Prefix From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Internationalization usage for Germanic languages. This component is optional. An example of a <surname prefix> is the van in Ludwig van Beethoven. Since the <surname prefix> doesn't sort completely alphabetically, it is reasonable to specify it as a separate sub-component of the PN and extended PN data types (XPN and XCN).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.2.5",
                            Type = @"SubComponent",
                            Position = @"RXA.10.2.5",
                            Name = @"Surname From Partner/Spouse",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The portion of the person's surname (in most Western usage, the last name) that is derived from the surname of the person's partner or spouse, as distinguished from the part derived from the person's own surname. This component is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.3",
                            Type = @"Component",
                            Position = @"RXA.10.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"First name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.4",
                            Type = @"Component",
                            Position = @"RXA.10.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.5",
                            Type = @"Component",
                            Position = @"RXA.10.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.6",
                            Type = @"Component",
                            Position = @"RXA.10.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.7",
                            Type = @"Component",
                            Position = @"RXA.10.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.8",
                            Type = @"Component",
                            Position = @"RXA.10.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined Table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9",
                            Type = @"Component",
                            Position = @"RXA.10.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.9.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.10",
                            Type = @"Component",
                            Position = @"RXA.10.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values (see Section 2.9.54.7, Name type code (ID)).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.11",
                            Type = @"Component",
                            Position = @"RXA.10.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.12",
                            Type = @"Component",
                            Position = @"RXA.10.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 Table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.13",
                            Type = @"Component",
                            Position = @"RXA.10.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14",
                            Type = @"Component",
                            Position = @"RXA.10.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.14.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.14.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.15",
                            Type = @"Component",
                            Position = @"RXA.10.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.16",
                            Type = @"Component",
                            Position = @"RXA.10.16",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.16.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.1",
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
                            Id = @"RXA.10.16.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.2",
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
                            Id = @"RXA.10.16.3",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.3",
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
                            Id = @"RXA.10.16.4",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.4",
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
                            Id = @"RXA.10.16.5",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.5",
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
                            Id = @"RXA.10.16.6",
                            Type = @"SubComponent",
                            Position = @"RXA.10.16.6",
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
                            Id = @"RXA.10.17",
                            Type = @"Component",
                            Position = @"RXA.10.17",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times that define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.1",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.17.2",
                            Type = @"SubComponent",
                            Position = @"RXA.10.17.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.10.18",
                            Type = @"Component",
                            Position = @"RXA.10.18",
                            Name = @"Name Assembly Order",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name assembly orde r for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _administeringProvider = new HL7V24Field
        {
            field = message[@"RXA"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeringProvider.field.FieldRepetitions != null && _administeringProvider.field.FieldRepetitions.Count > 0)
        {
            _administeringProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeringProvider, fieldData);
        }

        return _administeringProvider;
    } 
}

internal HL7V24Field _administeredatLocation;

public HL7V24Field AdministeredatLocation
{
    get
    {
        if (_administeredatLocation != null)
        {
            return _administeredatLocation;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.11",
            Type = @"Field",
            Position = @"RXA.11",
            Name = @"Administered-at Location",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"LA2",
            DataTypeName = @"Location With Address Information (variant 2",
            TableId = null,
            TableName = null,
            Description = @"The first component contains the inpatient or outpatient location at which the drug or treatment was administered (if applicable). The default (null) value is the current census location for the patient. Site-specific table. The first eight components have the same form as the first eight components of PV1-3-assigned patient location. The final eight components replace the ninth component of PV1-3-assigned patient location and represent the full address specification.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.11.1",
                            Type = @"Component",
                            Position = @"RXA.11.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.2",
                            Type = @"Component",
                            Position = @"RXA.11.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.3",
                            Type = @"Component",
                            Position = @"RXA.11.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4",
                            Type = @"Component",
                            Position = @"RXA.11.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.1",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.2",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.4.3",
                            Type = @"SubComponent",
                            Position = @"RXA.11.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.5",
                            Type = @"Component",
                            Position = @"RXA.11.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.6",
                            Type = @"Component",
                            Position = @"RXA.11.6",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.7",
                            Type = @"Component",
                            Position = @"RXA.11.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.8",
                            Type = @"Component",
                            Position = @"RXA.11.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.9",
                            Type = @"Component",
                            Position = @"RXA.11.9",
                            Name = @"Street Address",
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
                            Id = @"RXA.11.10",
                            Type = @"Component",
                            Position = @"RXA.11.10",
                            Name = @"Other Designation",
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
                            Id = @"RXA.11.11",
                            Type = @"Component",
                            Position = @"RXA.11.11",
                            Name = @"City",
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
                            Id = @"RXA.11.12",
                            Type = @"Component",
                            Position = @"RXA.11.12",
                            Name = @"State Or Province",
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
                            Id = @"RXA.11.13",
                            Type = @"Component",
                            Position = @"RXA.11.13",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXA.11.14",
                            Type = @"Component",
                            Position = @"RXA.11.14",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.15",
                            Type = @"Component",
                            Position = @"RXA.11.15",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.16",
                            Type = @"Component",
                            Position = @"RXA.11.16",
                            Name = @"Other Geographic Designation",
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
                        }
        }

        _administeredatLocation = new HL7V24Field
        {
            field = message[@"RXA"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredatLocation.field.FieldRepetitions != null && _administeredatLocation.field.FieldRepetitions.Count > 0)
        {
            _administeredatLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredatLocation, fieldData);
        }

        return _administeredatLocation;
    } 
}

internal HL7V24Field _administeredPer;

public HL7V24Field AdministeredPer
{
    get
    {
        if (_administeredPer != null)
        {
            return _administeredPer;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.12",
            Type = @"Field",
            Position = @"RXA.12",
            Name = @"Administered Per",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rate at which this medication/treatment was administered as calculated by using RXA-6-administered amount and RXA-7-administered units. This field is conditional because it is required when a treatment is administered continuously at a prescribed rate, e.g., certain IV solutions.",
            Sample = @"",
            Fields = null
        }

        _administeredPer = new HL7V24Field
        {
            field = message[@"RXA"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredPer.field.FieldRepetitions != null && _administeredPer.field.FieldRepetitions.Count > 0)
        {
            _administeredPer.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredPer, fieldData);
        }

        return _administeredPer;
    } 
}

internal HL7V24Field _administeredStrength;

public HL7V24Field AdministeredStrength
{
    get
    {
        if (_administeredStrength != null)
        {
            return _administeredStrength;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.13",
            Type = @"Field",
            Position = @"RXA.13",
            Name = @"Administered Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use when RXA-5-Administered code does not specify the strength. This is the numeric part of the strength, used in combination with RXA-14-Administered strength units.",
            Sample = @"",
            Fields = null
        }

        _administeredStrength = new HL7V24Field
        {
            field = message[@"RXA"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredStrength.field.FieldRepetitions != null && _administeredStrength.field.FieldRepetitions.Count > 0)
        {
            _administeredStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredStrength, fieldData);
        }

        return _administeredStrength;
    } 
}

internal HL7V24Field _administeredStrengthUnits;

public HL7V24Field AdministeredStrengthUnits
{
    get
    {
        if (_administeredStrengthUnits != null)
        {
            return _administeredStrengthUnits;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.14",
            Type = @"Field",
            Position = @"RXA.14",
            Name = @"Administered Strength Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when RXA-5-Administered code does not specify the strength. This is the unit of the strength, used in combination with RXA-13-Administered strength.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.14.1",
                            Type = @"Component",
                            Position = @"RXA.14.1",
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
                            Id = @"RXA.14.2",
                            Type = @"Component",
                            Position = @"RXA.14.2",
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
                            Id = @"RXA.14.3",
                            Type = @"Component",
                            Position = @"RXA.14.3",
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
                            Id = @"RXA.14.4",
                            Type = @"Component",
                            Position = @"RXA.14.4",
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
                            Id = @"RXA.14.5",
                            Type = @"Component",
                            Position = @"RXA.14.5",
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
                            Id = @"RXA.14.6",
                            Type = @"Component",
                            Position = @"RXA.14.6",
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
                        },
                        }
        }

        _administeredStrengthUnits = new HL7V24Field
        {
            field = message[@"RXA"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredStrengthUnits.field.FieldRepetitions != null && _administeredStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _administeredStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_administeredStrengthUnits, fieldData);
        }

        return _administeredStrengthUnits;
    } 
}

internal HL7V24Field _substanceLotNumber;

public HL7V24Field SubstanceLotNumber
{
    get
    {
        if (_substanceLotNumber != null)
        {
            return _substanceLotNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.15",
            Type = @"Field",
            Position = @"RXA.15",
            Name = @"Substance Lot Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lot number of the medical substance administered.",
            Sample = @"",
            Fields = null
        }

        _substanceLotNumber = new HL7V24Field
        {
            field = message[@"RXA"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceLotNumber.field.FieldRepetitions != null && _substanceLotNumber.field.FieldRepetitions.Count > 0)
        {
            _substanceLotNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceLotNumber, fieldData);
        }

        return _substanceLotNumber;
    } 
}

internal HL7V24Field _substanceExpirationDate;

public HL7V24Field SubstanceExpirationDate
{
    get
    {
        if (_substanceExpirationDate != null)
        {
            return _substanceExpirationDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.16",
            Type = @"Field",
            Position = @"RXA.16",
            Name = @"Substance Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date of the medical substance administered.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.16.1",
                            Type = @"Component",
                            Position = @"RXA.16.1",
                            Name = @"Time Of An Event",
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
                            Id = @"RXA.16.2",
                            Type = @"Component",
                            Position = @"RXA.16.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _substanceExpirationDate = new HL7V24Field
        {
            field = message[@"RXA"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceExpirationDate.field.FieldRepetitions != null && _substanceExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _substanceExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceExpirationDate, fieldData);
        }

        return _substanceExpirationDate;
    } 
}

internal HL7V24Field _substanceManufacturerName;

public HL7V24Field SubstanceManufacturerName
{
    get
    {
        if (_substanceManufacturerName != null)
        {
            return _substanceManufacturerName;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.17",
            Type = @"Field",
            Position = @"RXA.17",
            Name = @"Substance Manufacturer Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0227",
            TableName = @"Manufacturers of vaccines",
            Description = @"This field contains the manufacturer of the medical substance administered.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.17.1",
                            Type = @"Component",
                            Position = @"RXA.17.1",
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
                            Id = @"RXA.17.2",
                            Type = @"Component",
                            Position = @"RXA.17.2",
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
                            Id = @"RXA.17.3",
                            Type = @"Component",
                            Position = @"RXA.17.3",
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
                            Id = @"RXA.17.4",
                            Type = @"Component",
                            Position = @"RXA.17.4",
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
                            Id = @"RXA.17.5",
                            Type = @"Component",
                            Position = @"RXA.17.5",
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
                            Id = @"RXA.17.6",
                            Type = @"Component",
                            Position = @"RXA.17.6",
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
                        },
                        }
        }

        _substanceManufacturerName = new HL7V24Field
        {
            field = message[@"RXA"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceManufacturerName.field.FieldRepetitions != null && _substanceManufacturerName.field.FieldRepetitions.Count > 0)
        {
            _substanceManufacturerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceManufacturerName, fieldData);
        }

        return _substanceManufacturerName;
    } 
}

internal HL7V24Field _substanceTreatmentRefusalReason;

public HL7V24Field SubstanceTreatmentRefusalReason
{
    get
    {
        if (_substanceTreatmentRefusalReason != null)
        {
            return _substanceTreatmentRefusalReason;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.18",
            Type = @"Field",
            Position = @"RXA.18",
            Name = @"Substance/Treatment Refusal Reason",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reason the patient refused the medical substance/treatment. Any entry in the field indicates that the patient did not take the substance.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.18.1",
                            Type = @"Component",
                            Position = @"RXA.18.1",
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
                            Id = @"RXA.18.2",
                            Type = @"Component",
                            Position = @"RXA.18.2",
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
                            Id = @"RXA.18.3",
                            Type = @"Component",
                            Position = @"RXA.18.3",
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
                            Id = @"RXA.18.4",
                            Type = @"Component",
                            Position = @"RXA.18.4",
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
                            Id = @"RXA.18.5",
                            Type = @"Component",
                            Position = @"RXA.18.5",
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
                            Id = @"RXA.18.6",
                            Type = @"Component",
                            Position = @"RXA.18.6",
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
                        },
                        }
        }

        _substanceTreatmentRefusalReason = new HL7V24Field
        {
            field = message[@"RXA"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_substanceTreatmentRefusalReason.field.FieldRepetitions != null && _substanceTreatmentRefusalReason.field.FieldRepetitions.Count > 0)
        {
            _substanceTreatmentRefusalReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_substanceTreatmentRefusalReason, fieldData);
        }

        return _substanceTreatmentRefusalReason;
    } 
}

internal HL7V24Field _indication;

public HL7V24Field Indication
{
    get
    {
        if (_indication != null)
        {
            return _indication;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.19",
            Type = @"Field",
            Position = @"RXA.19",
            Name = @"Indication",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.19.1",
                            Type = @"Component",
                            Position = @"RXA.19.1",
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
                            Id = @"RXA.19.2",
                            Type = @"Component",
                            Position = @"RXA.19.2",
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
                            Id = @"RXA.19.3",
                            Type = @"Component",
                            Position = @"RXA.19.3",
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
                            Id = @"RXA.19.4",
                            Type = @"Component",
                            Position = @"RXA.19.4",
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
                            Id = @"RXA.19.5",
                            Type = @"Component",
                            Position = @"RXA.19.5",
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
                            Id = @"RXA.19.6",
                            Type = @"Component",
                            Position = @"RXA.19.6",
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
                        },
                        }
        }

        _indication = new HL7V24Field
        {
            field = message[@"RXA"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_indication.field.FieldRepetitions != null && _indication.field.FieldRepetitions.Count > 0)
        {
            _indication.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_indication, fieldData);
        }

        return _indication;
    } 
}

internal HL7V24Field _completionStatus;

public HL7V24Field CompletionStatus
{
    get
    {
        if (_completionStatus != null)
        {
            return _completionStatus;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.20",
            Type = @"Field",
            Position = @"RXA.20",
            Name = @"Completion Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0322",
            TableName = @"Completion status",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _completionStatus = new HL7V24Field
        {
            field = message[@"RXA"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_completionStatus.field.FieldRepetitions != null && _completionStatus.field.FieldRepetitions.Count > 0)
        {
            _completionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_completionStatus, fieldData);
        }

        return _completionStatus;
    } 
}

internal HL7V24Field _actionCodeRXA;

public HL7V24Field ActionCodeRXA
{
    get
    {
        if (_actionCodeRXA != null)
        {
            return _actionCodeRXA;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.21",
            Type = @"Field",
            Position = @"RXA.21",
            Name = @"Action Code-RXA",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0323",
            TableName = @"Action code",
            Description = @"Status of record. The information in this field enables the use of the RXA in the vaccine messages (see Section 4.18, Vaccine Segments), where a method of correcting vaccination information transmitted with incorrect patient identifying information is needed. Refer to HL7 Table 0323 - Action code for valid values.",
            Sample = @"",
            Fields = null
        }

        _actionCodeRXA = new HL7V24Field
        {
            field = message[@"RXA"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionCodeRXA.field.FieldRepetitions != null && _actionCodeRXA.field.FieldRepetitions.Count > 0)
        {
            _actionCodeRXA.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_actionCodeRXA, fieldData);
        }

        return _actionCodeRXA;
    } 
}

internal HL7V24Field _systemEntryDateTime;

public HL7V24Field SystemEntryDateTime
{
    get
    {
        if (_systemEntryDateTime != null)
        {
            return _systemEntryDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"RXA.22",
            Type = @"Field",
            Position = @"RXA.22",
            Name = @"System Entry Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"Date/time the administration information was entered into the source system. This field is used to detect instances where treatment administration information is inadvertently entered multiple times by providing a unique identification field. Under usual circumstances, this field would be provided automatically by the computer system rather than being entered by a person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.22.1",
                            Type = @"Component",
                            Position = @"RXA.22.1",
                            Name = @"Time Of An Event",
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
                            Id = @"RXA.22.2",
                            Type = @"Component",
                            Position = @"RXA.22.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _systemEntryDateTime = new HL7V24Field
        {
            field = message[@"RXA"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_systemEntryDateTime.field.FieldRepetitions != null && _systemEntryDateTime.field.FieldRepetitions.Count > 0)
        {
            _systemEntryDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_systemEntryDateTime, fieldData);
        }

        return _systemEntryDateTime;
    } 
}
    }
}

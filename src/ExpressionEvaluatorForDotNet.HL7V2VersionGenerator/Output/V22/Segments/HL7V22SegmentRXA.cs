using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentRXA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXA"; } }

        public string SegmentId { get { return @"RXA"; } }
        
        public string LongName { get { return @"Pharmacy Aadministration"; } }
        
        public string Description { get { return @"The ORC must have the filler order number and the order control code RE.  As a site-specific variant, the RXO and associated RXCs and/or the RXE (and associated RXCs) may be present if the receiving application needs any of their data.  The RXA carries the administration data."; } }
        
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

        public HL7V22SegmentRXA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _giveSubidCounter;

public HL7V22Field GiveSubidCounter
{
    get
    {
        if (_giveSubidCounter != null)
        {
            return _giveSubidCounter;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.1",
            Type = @"Field",
            Position = @"RXA.1",
            Name = @"Give Sub-id Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"use if matching this RXA segment to its corresponding RXG segment.  If the two applications are not matching RXG and RXA segments, this field's value is zero. ",
            Sample = @"",
            Fields = null
        }

        _giveSubidCounter = new HL7V22Field
        {
            field = message[@"RXA"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_giveSubidCounter.field.FieldRepetitions != null && _giveSubidCounter.field.FieldRepetitions.Count > 0)
        {
            _giveSubidCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_giveSubidCounter, fieldData);
        }

        return _giveSubidCounter;
    } 
}

internal HL7V22Field _administrationSubidCounter;

public HL7V22Field AdministrationSubidCounter
{
    get
    {
        if (_administrationSubidCounter != null)
        {
            return _administrationSubidCounter;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.2",
            Type = @"Field",
            Position = @"RXA.2",
            Name = @"Administration Sub-id Counter",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"starts with 1 the first time that medication is administered for this order.  Increments by one with each additional administration of medication.   
 
Note:More than one RXA segment can be ""matched"" to a single RXG segment, as is the case when recording a change of the rate of adminstration of an IV solution",
            Sample = @"",
            Fields = null
        }

        _administrationSubidCounter = new HL7V22Field
        {
            field = message[@"RXA"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administrationSubidCounter.field.FieldRepetitions != null && _administrationSubidCounter.field.FieldRepetitions.Count > 0)
        {
            _administrationSubidCounter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administrationSubidCounter, fieldData);
        }

        return _administrationSubidCounter;
    } 
}

internal HL7V22Field _dateTimeStartOfAdministration;

public HL7V22Field DateTimeStartOfAdministration
{
    get
    {
        if (_dateTimeStartOfAdministration != null)
        {
            return _dateTimeStartOfAdministration;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.3",
            Type = @"Field",
            Position = @"RXA.3",
            Name = @"Date / Time Start Of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"if the order is for a continuous administration (such as an IV), and the rate is changed at a certain time after the start, an RAS message can be issued to record the change.  For such an RAS message, this field records the time the rate was changed to the new value recorded in the  Administered Per (Time Unit) field of the same message",
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
                            Name = @"Degree Of Precision",
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

        _dateTimeStartOfAdministration = new HL7V22Field
        {
            field = message[@"RXA"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeStartOfAdministration.field.FieldRepetitions != null && _dateTimeStartOfAdministration.field.FieldRepetitions.Count > 0)
        {
            _dateTimeStartOfAdministration.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeStartOfAdministration, fieldData);
        }

        return _dateTimeStartOfAdministration;
    } 
}

internal HL7V22Field _dateTimeEndOfAdministration;

public HL7V22Field DateTimeEndOfAdministration
{
    get
    {
        if (_dateTimeEndOfAdministration != null)
        {
            return _dateTimeEndOfAdministration;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.4",
            Type = @"Field",
            Position = @"RXA.4",
            Name = @"Date / Time End Of Administration",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"If null, the date/time of RXA-3-date/time start of administration is assumed",
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
                            Name = @"Degree Of Precision",
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

        _dateTimeEndOfAdministration = new HL7V22Field
        {
            field = message[@"RXA"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeEndOfAdministration.field.FieldRepetitions != null && _dateTimeEndOfAdministration.field.FieldRepetitions.Count > 0)
        {
            _dateTimeEndOfAdministration.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeEndOfAdministration, fieldData);
        }

        return _dateTimeEndOfAdministration;
    } 
}

internal HL7V22Field _administeredCode;

public HL7V22Field AdministeredCode
{
    get
    {
        if (_administeredCode != null)
        {
            return _administeredCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.5",
            Type = @"Field",
            Position = @"RXA.5",
            Name = @"Administered Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"identifier of the medical substance administered.  It is equivalent to OBR-4-universal service ID code in function",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _administeredCode = new HL7V22Field
        {
            field = message[@"RXA"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredCode.field.FieldRepetitions != null && _administeredCode.field.FieldRepetitions.Count > 0)
        {
            _administeredCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredCode, fieldData);
        }

        return _administeredCode;
    } 
}

internal HL7V22Field _administeredAmount;

public HL7V22Field AdministeredAmount
{
    get
    {
        if (_administeredAmount != null)
        {
            return _administeredAmount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"amount administered",
            Sample = @"",
            Fields = null
        }

        _administeredAmount = new HL7V22Field
        {
            field = message[@"RXA"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredAmount.field.FieldRepetitions != null && _administeredAmount.field.FieldRepetitions.Count > 0)
        {
            _administeredAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredAmount, fieldData);
        }

        return _administeredAmount;
    } 
}

internal HL7V22Field _administeredUnits;

public HL7V22Field AdministeredUnits
{
    get
    {
        if (_administeredUnits != null)
        {
            return _administeredUnits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.7",
            Type = @"Field",
            Position = @"RXA.7",
            Name = @"Administered Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"must be in simple units that reflect the actual quantity of the substance administered.  It does not include compound units",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _administeredUnits = new HL7V22Field
        {
            field = message[@"RXA"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredUnits.field.FieldRepetitions != null && _administeredUnits.field.FieldRepetitions.Count > 0)
        {
            _administeredUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredUnits, fieldData);
        }

        return _administeredUnits;
    } 
}

internal HL7V22Field _administeredDosageForm;

public HL7V22Field AdministeredDosageForm
{
    get
    {
        if (_administeredDosageForm != null)
        {
            return _administeredDosageForm;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.8",
            Type = @"Field",
            Position = @"RXA.8",
            Name = @"Administered Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"use this field when the administered code does not specify the dosage form",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _administeredDosageForm = new HL7V22Field
        {
            field = message[@"RXA"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredDosageForm.field.FieldRepetitions != null && _administeredDosageForm.field.FieldRepetitions.Count > 0)
        {
            _administeredDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredDosageForm, fieldData);
        }

        return _administeredDosageForm;
    } 
}

internal HL7V22Field _administrationNotes;

public HL7V22Field AdministrationNotes
{
    get
    {
        if (_administrationNotes != null)
        {
            return _administrationNotes;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.9",
            Type = @"Field",
            Position = @"RXA.9",
            Name = @"Administration Notes",
            Length = 200,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"free text notes from the provider administering the medication.  This may contain free text describing a custom IV, mixture, or salve",
            Sample = @"",
            Fields = null
        }

        _administrationNotes = new HL7V22Field
        {
            field = message[@"RXA"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administrationNotes.field.FieldRepetitions != null && _administrationNotes.field.FieldRepetitions.Count > 0)
        {
            _administrationNotes.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administrationNotes, fieldData);
        }

        return _administrationNotes;
    } 
}

internal HL7V22Field _administeringProvider;

public HL7V22Field AdministeringProvider
{
    get
    {
        if (_administeringProvider != null)
        {
            return _administeringProvider;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.10",
            Type = @"Field",
            Position = @"RXA.10",
            Name = @"Administering Provider",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"provider ID of the person administering the pharmaceutical",
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
                            Id = @"RXA.10.2",
                            Type = @"Component",
                            Position = @"RXA.10.2",
                            Name = @"Familiy Name",
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
                            Id = @"RXA.10.3",
                            Type = @"Component",
                            Position = @"RXA.10.3",
                            Name = @"Given Name",
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
                            Id = @"RXA.10.4",
                            Type = @"Component",
                            Position = @"RXA.10.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"RXA.10.5",
                            Type = @"Component",
                            Position = @"RXA.10.5",
                            Name = @"Suffix (e.g. Jr Or Iii)",
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
                            Id = @"RXA.10.6",
                            Type = @"Component",
                            Position = @"RXA.10.6",
                            Name = @"Prefix (e.g. Dr)",
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
                            Id = @"RXA.10.7",
                            Type = @"Component",
                            Position = @"RXA.10.7",
                            Name = @"Degree (e.g. Md)",
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
                            Id = @"RXA.10.8",
                            Type = @"Component",
                            Position = @"RXA.10.8",
                            Name = @"Source Table Id",
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
                        }
        }

        _administeringProvider = new HL7V22Field
        {
            field = message[@"RXA"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeringProvider.field.FieldRepetitions != null && _administeringProvider.field.FieldRepetitions.Count > 0)
        {
            _administeringProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeringProvider, fieldData);
        }

        return _administeringProvider;
    } 
}

internal HL7V22Field _administeredatLocation;

public HL7V22Field AdministeredatLocation
{
    get
    {
        if (_administeredatLocation != null)
        {
            return _administeredatLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.11",
            Type = @"Field",
            Position = @"RXA.11",
            Name = @"Administered-at Location",
            Length = 12,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CM_LA1",
            DataTypeName = @"Location With Address Information",
            TableId = null,
            TableName = null,
            Description = @"he first component contains the inpatient or outpatient location at which the drug was administered (if applicable).  The default (null) value is the current census location for the patient.  Site specific table.  This component has the same form as PV1-3-assigned patient location. 
 ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXA.11.1",
                            Type = @"Component",
                            Position = @"RXA.11.1",
                            Name = @"Dispense / Deliver To Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_INTERNAL_LOCATION",
                            DataTypeName = @"Cm For Location Information In Hospital",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.11.1.1",
                            Type = @"SubComponent",
                            Position = @"RXA.11.1.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"RXA.11.1.2",
                            Type = @"SubComponent",
                            Position = @"RXA.11.1.2",
                            Name = @"Room",
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
                            Id = @"RXA.11.1.3",
                            Type = @"SubComponent",
                            Position = @"RXA.11.1.3",
                            Name = @"Bed",
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
                            Id = @"RXA.11.1.4",
                            Type = @"SubComponent",
                            Position = @"RXA.11.1.4",
                            Name = @"Facility Id",
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
                            Id = @"RXA.11.1.5",
                            Type = @"SubComponent",
                            Position = @"RXA.11.1.5",
                            Name = @"Bed Status",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.2",
                            Type = @"Component",
                            Position = @"RXA.11.2",
                            Name = @"Location",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component can be used to specify an address.  This could be used to fill mail orders to a patient or provider, or to account for home health care. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXA.11.2.1",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.1",
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
                            Id = @"RXA.11.2.2",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.2",
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
                            Id = @"RXA.11.2.3",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.3",
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
                            Id = @"RXA.11.2.4",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.4",
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
                            Id = @"RXA.11.2.5",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.5",
                            Name = @"Zip Or Postal Code",
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
                            Id = @"RXA.11.2.6",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.2.7",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.7",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0190",
                            TableName = @"ADDRESS TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXA.11.2.8",
                            Type = @"SubComponent",
                            Position = @"RXA.11.2.8",
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
                        },}
                        },
                        }
        }

        _administeredatLocation = new HL7V22Field
        {
            field = message[@"RXA"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredatLocation.field.FieldRepetitions != null && _administeredatLocation.field.FieldRepetitions.Count > 0)
        {
            _administeredatLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredatLocation, fieldData);
        }

        return _administeredatLocation;
    } 
}

internal HL7V22Field _administeredPertimeUnit;

public HL7V22Field AdministeredPertimeUnit
{
    get
    {
        if (_administeredPertimeUnit != null)
        {
            return _administeredPertimeUnit;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"RXA.12",
            Type = @"Field",
            Position = @"RXA.12",
            Name = @"Administered Per (time Unit)",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _administeredPertimeUnit = new HL7V22Field
        {
            field = message[@"RXA"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_administeredPertimeUnit.field.FieldRepetitions != null && _administeredPertimeUnit.field.FieldRepetitions.Count > 0)
        {
            _administeredPertimeUnit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_administeredPertimeUnit, fieldData);
        }

        return _administeredPertimeUnit;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentSTF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"STF"; } }

        public string SegmentId { get { return @"STF"; } }
        
        public string LongName { get { return @"Staff Identification Segment"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V22SegmentSTF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _stfPrimaryKeyValue;

public HL7V22Field StfPrimaryKeyValue
{
    get
    {
        if (_stfPrimaryKeyValue != null)
        {
            return _stfPrimaryKeyValue;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.1",
            Type = @"Field",
            Position = @"STF.1",
            Name = @"Stf - Primary Key Value",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.1.1",
                            Type = @"Component",
                            Position = @"STF.1.1",
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
                            Id = @"STF.1.2",
                            Type = @"Component",
                            Position = @"STF.1.2",
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
                            Id = @"STF.1.3",
                            Type = @"Component",
                            Position = @"STF.1.3",
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
                            Id = @"STF.1.4",
                            Type = @"Component",
                            Position = @"STF.1.4",
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
                            Id = @"STF.1.5",
                            Type = @"Component",
                            Position = @"STF.1.5",
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
                            Id = @"STF.1.6",
                            Type = @"Component",
                            Position = @"STF.1.6",
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

        _stfPrimaryKeyValue = new HL7V22Field
        {
            field = message[@"STF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_stfPrimaryKeyValue.field.FieldRepetitions != null && _stfPrimaryKeyValue.field.FieldRepetitions.Count > 0)
        {
            _stfPrimaryKeyValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_stfPrimaryKeyValue, fieldData);
        }

        return _stfPrimaryKeyValue;
    } 
}

internal HL7V22Field _staffIdCode;

public HL7V22Field StaffIdCode
{
    get
    {
        if (_staffIdCode != null)
        {
            return _staffIdCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.2",
            Type = @"Field",
            Position = @"STF.2",
            Name = @"Staff Id Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.2.1",
                            Type = @"Component",
                            Position = @"STF.2.1",
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
                            Id = @"STF.2.2",
                            Type = @"Component",
                            Position = @"STF.2.2",
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
                            Id = @"STF.2.3",
                            Type = @"Component",
                            Position = @"STF.2.3",
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
                            Id = @"STF.2.4",
                            Type = @"Component",
                            Position = @"STF.2.4",
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
                            Id = @"STF.2.5",
                            Type = @"Component",
                            Position = @"STF.2.5",
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
                            Id = @"STF.2.6",
                            Type = @"Component",
                            Position = @"STF.2.6",
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

        _staffIdCode = new HL7V22Field
        {
            field = message[@"STF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffIdCode.field.FieldRepetitions != null && _staffIdCode.field.FieldRepetitions.Count > 0)
        {
            _staffIdCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_staffIdCode, fieldData);
        }

        return _staffIdCode;
    } 
}

internal HL7V22Field _staffName;

public HL7V22Field StaffName
{
    get
    {
        if (_staffName != null)
        {
            return _staffName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.3",
            Type = @"Field",
            Position = @"STF.3",
            Name = @"Staff Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.3.1",
                            Type = @"Component",
                            Position = @"STF.3.1",
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
                            Id = @"STF.3.2",
                            Type = @"Component",
                            Position = @"STF.3.2",
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
                            Id = @"STF.3.3",
                            Type = @"Component",
                            Position = @"STF.3.3",
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
                            Id = @"STF.3.4",
                            Type = @"Component",
                            Position = @"STF.3.4",
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
                            Id = @"STF.3.5",
                            Type = @"Component",
                            Position = @"STF.3.5",
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
                            Id = @"STF.3.6",
                            Type = @"Component",
                            Position = @"STF.3.6",
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
                        }
        }

        _staffName = new HL7V22Field
        {
            field = message[@"STF"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffName.field.FieldRepetitions != null && _staffName.field.FieldRepetitions.Count > 0)
        {
            _staffName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_staffName, fieldData);
        }

        return _staffName;
    } 
}

internal HL7V22Field _staffType;

public HL7V22Field StaffType
{
    get
    {
        if (_staffType != null)
        {
            return _staffType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.4",
            Type = @"Field",
            Position = @"STF.4",
            Name = @"Staff Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0182",
            TableName = @"STAFF TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _staffType = new HL7V22Field
        {
            field = message[@"STF"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffType.field.FieldRepetitions != null && _staffType.field.FieldRepetitions.Count > 0)
        {
            _staffType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_staffType, fieldData);
        }

        return _staffType;
    } 
}

internal HL7V22Field _sex;

public HL7V22Field Sex
{
    get
    {
        if (_sex != null)
        {
            return _sex;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.5",
            Type = @"Field",
            Position = @"STF.5",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V22Field
        {
            field = message[@"STF"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sex.field.FieldRepetitions != null && _sex.field.FieldRepetitions.Count > 0)
        {
            _sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sex, fieldData);
        }

        return _sex;
    } 
}

internal HL7V22Field _dateOfBirth;

public HL7V22Field DateOfBirth
{
    get
    {
        if (_dateOfBirth != null)
        {
            return _dateOfBirth;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.6",
            Type = @"Field",
            Position = @"STF.6",
            Name = @"Date Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.6.1",
                            Type = @"Component",
                            Position = @"STF.6.1",
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
                            Id = @"STF.6.2",
                            Type = @"Component",
                            Position = @"STF.6.2",
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

        _dateOfBirth = new HL7V22Field
        {
            field = message[@"STF"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateOfBirth.field.FieldRepetitions != null && _dateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _dateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateOfBirth, fieldData);
        }

        return _dateOfBirth;
    } 
}

internal HL7V22Field _activeInactive;

public HL7V22Field ActiveInactive
{
    get
    {
        if (_activeInactive != null)
        {
            return _activeInactive;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.7",
            Type = @"Field",
            Position = @"STF.7",
            Name = @"Active / Inactive",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0183",
            TableName = @"ACTIVE/INACTIVE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _activeInactive = new HL7V22Field
        {
            field = message[@"STF"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_activeInactive.field.FieldRepetitions != null && _activeInactive.field.FieldRepetitions.Count > 0)
        {
            _activeInactive.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_activeInactive, fieldData);
        }

        return _activeInactive;
    } 
}

internal HL7V22Field _department;

public HL7V22Field Department
{
    get
    {
        if (_department != null)
        {
            return _department;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.8",
            Type = @"Field",
            Position = @"STF.8",
            Name = @"Department",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0184",
            TableName = @"DEPARTMENT",
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.8.1",
                            Type = @"Component",
                            Position = @"STF.8.1",
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
                            Id = @"STF.8.2",
                            Type = @"Component",
                            Position = @"STF.8.2",
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
                            Id = @"STF.8.3",
                            Type = @"Component",
                            Position = @"STF.8.3",
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
                            Id = @"STF.8.4",
                            Type = @"Component",
                            Position = @"STF.8.4",
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
                            Id = @"STF.8.5",
                            Type = @"Component",
                            Position = @"STF.8.5",
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
                            Id = @"STF.8.6",
                            Type = @"Component",
                            Position = @"STF.8.6",
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

        _department = new HL7V22Field
        {
            field = message[@"STF"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_department.field.FieldRepetitions != null && _department.field.FieldRepetitions.Count > 0)
        {
            _department.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_department, fieldData);
        }

        return _department;
    } 
}

internal HL7V22Field _service;

public HL7V22Field Service
{
    get
    {
        if (_service != null)
        {
            return _service;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.9",
            Type = @"Field",
            Position = @"STF.9",
            Name = @"Service",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.9.1",
                            Type = @"Component",
                            Position = @"STF.9.1",
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
                            Id = @"STF.9.2",
                            Type = @"Component",
                            Position = @"STF.9.2",
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
                            Id = @"STF.9.3",
                            Type = @"Component",
                            Position = @"STF.9.3",
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
                            Id = @"STF.9.4",
                            Type = @"Component",
                            Position = @"STF.9.4",
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
                            Id = @"STF.9.5",
                            Type = @"Component",
                            Position = @"STF.9.5",
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
                            Id = @"STF.9.6",
                            Type = @"Component",
                            Position = @"STF.9.6",
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

        _service = new HL7V22Field
        {
            field = message[@"STF"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_service.field.FieldRepetitions != null && _service.field.FieldRepetitions.Count > 0)
        {
            _service.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_service, fieldData);
        }

        return _service;
    } 
}

internal HL7V22Field _phone;

public HL7V22Field Phone
{
    get
    {
        if (_phone != null)
        {
            return _phone;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.10",
            Type = @"Field",
            Position = @"STF.10",
            Name = @"Phone",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _phone = new HL7V22Field
        {
            field = message[@"STF"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phone.field.FieldRepetitions != null && _phone.field.FieldRepetitions.Count > 0)
        {
            _phone.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_phone, fieldData);
        }

        return _phone;
    } 
}

internal HL7V22Field _officeHomeAddress;

public HL7V22Field OfficeHomeAddress
{
    get
    {
        if (_officeHomeAddress != null)
        {
            return _officeHomeAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.11",
            Type = @"Field",
            Position = @"STF.11",
            Name = @"Office / Home Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.11.1",
                            Type = @"Component",
                            Position = @"STF.11.1",
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
                            Id = @"STF.11.2",
                            Type = @"Component",
                            Position = @"STF.11.2",
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
                            Id = @"STF.11.3",
                            Type = @"Component",
                            Position = @"STF.11.3",
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
                            Id = @"STF.11.4",
                            Type = @"Component",
                            Position = @"STF.11.4",
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
                            Id = @"STF.11.5",
                            Type = @"Component",
                            Position = @"STF.11.5",
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
                            Id = @"STF.11.6",
                            Type = @"Component",
                            Position = @"STF.11.6",
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
                            Id = @"STF.11.7",
                            Type = @"Component",
                            Position = @"STF.11.7",
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
                            Id = @"STF.11.8",
                            Type = @"Component",
                            Position = @"STF.11.8",
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

        _officeHomeAddress = new HL7V22Field
        {
            field = message[@"STF"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_officeHomeAddress.field.FieldRepetitions != null && _officeHomeAddress.field.FieldRepetitions.Count > 0)
        {
            _officeHomeAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_officeHomeAddress, fieldData);
        }

        return _officeHomeAddress;
    } 
}

internal HL7V22Field _activationDate;

public HL7V22Field ActivationDate
{
    get
    {
        if (_activationDate != null)
        {
            return _activationDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.12",
            Type = @"Field",
            Position = @"STF.12",
            Name = @"Activation Date",
            Length = 19,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.12.1",
                            Type = @"Component",
                            Position = @"STF.12.1",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.12.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.1.1",
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
                            Id = @"STF.12.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.12.1.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.12.2",
                            Type = @"Component",
                            Position = @"STF.12.2",
                            Name = @"Institution Name",
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
                            Id = @"STF.12.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.1",
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
                            Id = @"STF.12.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.2",
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
                            Id = @"STF.12.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.3",
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
                            Id = @"STF.12.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.4",
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
                            Id = @"STF.12.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.5",
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
                            Id = @"STF.12.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.6",
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
                        },}
                        },
                        }
        }

        _activationDate = new HL7V22Field
        {
            field = message[@"STF"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_activationDate.field.FieldRepetitions != null && _activationDate.field.FieldRepetitions.Count > 0)
        {
            _activationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_activationDate, fieldData);
        }

        return _activationDate;
    } 
}

internal HL7V22Field _inactivationDate;

public HL7V22Field InactivationDate
{
    get
    {
        if (_inactivationDate != null)
        {
            return _inactivationDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.13",
            Type = @"Field",
            Position = @"STF.13",
            Name = @"Inactivation Date",
            Length = 19,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.13.1",
                            Type = @"Component",
                            Position = @"STF.13.1",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.13.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.1.1",
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
                            Id = @"STF.13.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.13.1.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.13.2",
                            Type = @"Component",
                            Position = @"STF.13.2",
                            Name = @"Institution Name",
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
                            Id = @"STF.13.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.1",
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
                            Id = @"STF.13.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.2",
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
                            Id = @"STF.13.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.3",
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
                            Id = @"STF.13.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.4",
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
                            Id = @"STF.13.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.5",
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
                            Id = @"STF.13.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.6",
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
                        },}
                        },
                        }
        }

        _inactivationDate = new HL7V22Field
        {
            field = message[@"STF"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inactivationDate.field.FieldRepetitions != null && _inactivationDate.field.FieldRepetitions.Count > 0)
        {
            _inactivationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_inactivationDate, fieldData);
        }

        return _inactivationDate;
    } 
}

internal HL7V22Field _backupPersonId;

public HL7V22Field BackupPersonId
{
    get
    {
        if (_backupPersonId != null)
        {
            return _backupPersonId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.14",
            Type = @"Field",
            Position = @"STF.14",
            Name = @"Backup Person Id",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.14.1",
                            Type = @"Component",
                            Position = @"STF.14.1",
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
                            Id = @"STF.14.2",
                            Type = @"Component",
                            Position = @"STF.14.2",
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
                            Id = @"STF.14.3",
                            Type = @"Component",
                            Position = @"STF.14.3",
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
                            Id = @"STF.14.4",
                            Type = @"Component",
                            Position = @"STF.14.4",
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
                            Id = @"STF.14.5",
                            Type = @"Component",
                            Position = @"STF.14.5",
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
                            Id = @"STF.14.6",
                            Type = @"Component",
                            Position = @"STF.14.6",
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

        _backupPersonId = new HL7V22Field
        {
            field = message[@"STF"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_backupPersonId.field.FieldRepetitions != null && _backupPersonId.field.FieldRepetitions.Count > 0)
        {
            _backupPersonId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_backupPersonId, fieldData);
        }

        return _backupPersonId;
    } 
}

internal HL7V22Field _emailAddress;

public HL7V22Field EmailAddress
{
    get
    {
        if (_emailAddress != null)
        {
            return _emailAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.15",
            Type = @"Field",
            Position = @"STF.15",
            Name = @"E-mail Address",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _emailAddress = new HL7V22Field
        {
            field = message[@"STF"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_emailAddress.field.FieldRepetitions != null && _emailAddress.field.FieldRepetitions.Count > 0)
        {
            _emailAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_emailAddress, fieldData);
        }

        return _emailAddress;
    } 
}

internal HL7V22Field _preferredMethodOfContact;

public HL7V22Field PreferredMethodOfContact
{
    get
    {
        if (_preferredMethodOfContact != null)
        {
            return _preferredMethodOfContact;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"STF.16",
            Type = @"Field",
            Position = @"STF.16",
            Name = @"Preferred Method Of Contact",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0185",
            TableName = @"PREFERRED METHOD OF CONTACT",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _preferredMethodOfContact = new HL7V22Field
        {
            field = message[@"STF"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredMethodOfContact.field.FieldRepetitions != null && _preferredMethodOfContact.field.FieldRepetitions.Count > 0)
        {
            _preferredMethodOfContact.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_preferredMethodOfContact, fieldData);
        }

        return _preferredMethodOfContact;
    } 
}
    }
}

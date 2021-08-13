using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentPID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PID"; } }

        public string SegmentId { get { return @"PID"; } }
        
        public string LongName { get { return @"Patient Identification"; } }
        
        public string Description { get { return @"The PID segment is used by all applications as the primary means of communicating patient identification information.  This segment contains permanent patient identifying, and demographic information that, for the most part, is not likely to change frequently"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V22SegmentPID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdPatientId;

public HL7V22Field SetIdPatientId
{
    get
    {
        if (_setIdPatientId != null)
        {
            return _setIdPatientId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.1",
            Type = @"Field",
            Position = @"PID.1",
            Name = @"Set Id - Patient Id",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"for those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc",
            Sample = @"",
            Fields = null
        }

        _setIdPatientId = new HL7V22Field
        {
            field = message[@"PID"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdPatientId.field.FieldRepetitions != null && _setIdPatientId.field.FieldRepetitions.Count > 0)
        {
            _setIdPatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdPatientId, fieldData);
        }

        return _setIdPatientId;
    } 
}

internal HL7V22Field _patientIdexternalId;

public HL7V22Field PatientIdexternalId
{
    get
    {
        if (_patientIdexternalId != null)
        {
            return _patientIdexternalId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.2",
            Type = @"Field",
            Position = @"PID.2",
            Name = @"Patient Id (external Id)",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"if the patient is from another institution, outside office, etc., the identifier used by that institution can be shown here.  This may be a number which multiple disparate corporations or facilities share.  Refer to table 0061 - check digit scheme in Chapter 2",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.2.1",
                            Type = @"Component",
                            Position = @"PID.2.1",
                            Name = @"ID Number",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.2.2",
                            Type = @"Component",
                            Position = @"PID.2.2",
                            Name = @"Check Digit",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.2.3",
                            Type = @"Component",
                            Position = @"PID.2.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.2.4",
                            Type = @"Component",
                            Position = @"PID.2.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _patientIdexternalId = new HL7V22Field
        {
            field = message[@"PID"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIdexternalId.field.FieldRepetitions != null && _patientIdexternalId.field.FieldRepetitions.Count > 0)
        {
            _patientIdexternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientIdexternalId, fieldData);
        }

        return _patientIdexternalId;
    } 
}

internal HL7V22Field _patientIdinternalId;

public HL7V22Field PatientIdinternalId
{
    get
    {
        if (_patientIdinternalId != null)
        {
            return _patientIdinternalId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.3",
            Type = @"Field",
            Position = @"PID.3",
            Name = @"Patient Id (internal Id)",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"CM_PAT_ID",
            DataTypeName = @"Patient Id",
            TableId = null,
            TableName = null,
            Description = @" primary ID used by the facility to uniquely identify a patient at the time of admit, (e.g., medical record number, billing number, etc).  Refer to table 0061-check digit scheme",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.3.1",
                            Type = @"Component",
                            Position = @"PID.3.1",
                            Name = @"Patient Id",
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
                            Id = @"PID.3.2",
                            Type = @"Component",
                            Position = @"PID.3.2",
                            Name = @"Check Digit",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.3.3",
                            Type = @"Component",
                            Position = @"PID.3.3",
                            Name = @"Check Digit Scheme",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.3.4",
                            Type = @"Component",
                            Position = @"PID.3.4",
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
                            Id = @"PID.3.5",
                            Type = @"Component",
                            Position = @"PID.3.5",
                            Name = @"Type",
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

        _patientIdinternalId = new HL7V22Field
        {
            field = message[@"PID"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIdinternalId.field.FieldRepetitions != null && _patientIdinternalId.field.FieldRepetitions.Count > 0)
        {
            _patientIdinternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientIdinternalId, fieldData);
        }

        return _patientIdinternalId;
    } 
}

internal HL7V22Field _alternatePatientId;

public HL7V22Field AlternatePatientId
{
    get
    {
        if (_alternatePatientId != null)
        {
            return _alternatePatientId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.4",
            Type = @"Field",
            Position = @"PID.4",
            Name = @"Alternate Patient Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"third number may be required to identify a patient.  Possible contents include a visit number, a visit date, or Social Security Number",
            Sample = @"",
            Fields = null
        }

        _alternatePatientId = new HL7V22Field
        {
            field = message[@"PID"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternatePatientId.field.FieldRepetitions != null && _alternatePatientId.field.FieldRepetitions.Count > 0)
        {
            _alternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_alternatePatientId, fieldData);
        }

        return _alternatePatientId;
    } 
}

internal HL7V22Field _patientName;

public HL7V22Field PatientName
{
    get
    {
        if (_patientName != null)
        {
            return _patientName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.5",
            Type = @"Field",
            Position = @"PID.5",
            Name = @"Patient Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name is standard format described in Chapter 2. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.5.1",
                            Type = @"Component",
                            Position = @"PID.5.1",
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
                            Id = @"PID.5.2",
                            Type = @"Component",
                            Position = @"PID.5.2",
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
                            Id = @"PID.5.3",
                            Type = @"Component",
                            Position = @"PID.5.3",
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
                            Id = @"PID.5.4",
                            Type = @"Component",
                            Position = @"PID.5.4",
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
                            Id = @"PID.5.5",
                            Type = @"Component",
                            Position = @"PID.5.5",
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
                            Id = @"PID.5.6",
                            Type = @"Component",
                            Position = @"PID.5.6",
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

        _patientName = new HL7V22Field
        {
            field = message[@"PID"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientName.field.FieldRepetitions != null && _patientName.field.FieldRepetitions.Count > 0)
        {
            _patientName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientName, fieldData);
        }

        return _patientName;
    } 
}

internal HL7V22Field _mothersMaidenName;

public HL7V22Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.6",
            Type = @"Field",
            Position = @"PID.6",
            Name = @"Mother's Maiden Name",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"family name under which the mother was born (i.e., before marriage.)  Used to disambiguate patients with the same last name",
            Sample = @"",
            Fields = null
        }

        _mothersMaidenName = new HL7V22Field
        {
            field = message[@"PID"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
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
            Id = @"PID.7",
            Type = @"Field",
            Position = @"PID.7",
            Name = @"Date Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"patient's date of birth",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.7.1",
                            Type = @"Component",
                            Position = @"PID.7.1",
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
                            Id = @"PID.7.2",
                            Type = @"Component",
                            Position = @"PID.7.2",
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
            field = message[@"PID"][7],
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
            Id = @"PID.8",
            Type = @"Field",
            Position = @"PID.8",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = @"patient's sex.  Refer to table 0001 - sex for valid codes.",
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V22Field
        {
            field = message[@"PID"][8],
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

internal HL7V22Field _patientAlias;

public HL7V22Field PatientAlias
{
    get
    {
        if (_patientAlias != null)
        {
            return _patientAlias;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.9",
            Type = @"Field",
            Position = @"PID.9",
            Name = @"Patient Alias",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name(s) by which the patient has been known at some time",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.9.1",
                            Type = @"Component",
                            Position = @"PID.9.1",
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
                            Id = @"PID.9.2",
                            Type = @"Component",
                            Position = @"PID.9.2",
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
                            Id = @"PID.9.3",
                            Type = @"Component",
                            Position = @"PID.9.3",
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
                            Id = @"PID.9.4",
                            Type = @"Component",
                            Position = @"PID.9.4",
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
                            Id = @"PID.9.5",
                            Type = @"Component",
                            Position = @"PID.9.5",
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
                            Id = @"PID.9.6",
                            Type = @"Component",
                            Position = @"PID.9.6",
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

        _patientAlias = new HL7V22Field
        {
            field = message[@"PID"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAlias.field.FieldRepetitions != null && _patientAlias.field.FieldRepetitions.Count > 0)
        {
            _patientAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientAlias, fieldData);
        }

        return _patientAlias;
    } 
}

internal HL7V22Field _race;

public HL7V22Field Race
{
    get
    {
        if (_race != null)
        {
            return _race;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.10",
            Type = @"Field",
            Position = @"PID.10",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0005",
            TableName = @"RACE",
            Description = @"ERISA also has a published list of ethnic classifications which may be used by local agreement at a site.  Refer to user-defined table 0005 - race",
            Sample = @"",
            Fields = null
        }

        _race = new HL7V22Field
        {
            field = message[@"PID"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_race.field.FieldRepetitions != null && _race.field.FieldRepetitions.Count > 0)
        {
            _race.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_race, fieldData);
        }

        return _race;
    } 
}

internal HL7V22Field _patientAddress;

public HL7V22Field PatientAddress
{
    get
    {
        if (_patientAddress != null)
        {
            return _patientAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.11",
            Type = @"Field",
            Position = @"PID.11",
            Name = @"Patient Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"mailing address of the patient",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.11.1",
                            Type = @"Component",
                            Position = @"PID.11.1",
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
                            Id = @"PID.11.2",
                            Type = @"Component",
                            Position = @"PID.11.2",
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
                            Id = @"PID.11.3",
                            Type = @"Component",
                            Position = @"PID.11.3",
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
                            Id = @"PID.11.4",
                            Type = @"Component",
                            Position = @"PID.11.4",
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
                            Id = @"PID.11.5",
                            Type = @"Component",
                            Position = @"PID.11.5",
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
                            Id = @"PID.11.6",
                            Type = @"Component",
                            Position = @"PID.11.6",
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
                            Id = @"PID.11.7",
                            Type = @"Component",
                            Position = @"PID.11.7",
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
                            Id = @"PID.11.8",
                            Type = @"Component",
                            Position = @"PID.11.8",
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

        _patientAddress = new HL7V22Field
        {
            field = message[@"PID"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAddress.field.FieldRepetitions != null && _patientAddress.field.FieldRepetitions.Count > 0)
        {
            _patientAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientAddress, fieldData);
        }

        return _patientAddress;
    } 
}

internal HL7V22Field _countyCode;

public HL7V22Field CountyCode
{
    get
    {
        if (_countyCode != null)
        {
            return _countyCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.12",
            Type = @"Field",
            Position = @"PID.12",
            Name = @"County Code",
            Length = 4,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"patient's county code.  This field was left in for backwards compatibility.  County can now be supported in the other geographic designation component of the AD data type",
            Sample = @"",
            Fields = null
        }

        _countyCode = new HL7V22Field
        {
            field = message[@"PID"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countyCode.field.FieldRepetitions != null && _countyCode.field.FieldRepetitions.Count > 0)
        {
            _countyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_countyCode, fieldData);
        }

        return _countyCode;
    } 
}

internal HL7V22Field _phoneNumberHome;

public HL7V22Field PhoneNumberHome
{
    get
    {
        if (_phoneNumberHome != null)
        {
            return _phoneNumberHome;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.13",
            Type = @"Field",
            Position = @"PID.13",
            Name = @"Phone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"up to three repetitions are permitted.  The first is considered the primary number",
            Sample = @"",
            Fields = null
        }

        _phoneNumberHome = new HL7V22Field
        {
            field = message[@"PID"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberHome.field.FieldRepetitions != null && _phoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_phoneNumberHome, fieldData);
        }

        return _phoneNumberHome;
    } 
}

internal HL7V22Field _phoneNumberBusiness;

public HL7V22Field PhoneNumberBusiness
{
    get
    {
        if (_phoneNumberBusiness != null)
        {
            return _phoneNumberBusiness;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.14",
            Type = @"Field",
            Position = @"PID.14",
            Name = @"Phone Number - Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"up to three repetitions are permitted.  The first is considered the primary one",
            Sample = @"",
            Fields = null
        }

        _phoneNumberBusiness = new HL7V22Field
        {
            field = message[@"PID"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberBusiness.field.FieldRepetitions != null && _phoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_phoneNumberBusiness, fieldData);
        }

        return _phoneNumberBusiness;
    } 
}

internal HL7V22Field _languagePatient;

public HL7V22Field LanguagePatient
{
    get
    {
        if (_languagePatient != null)
        {
            return _languagePatient;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.15",
            Type = @"Field",
            Position = @"PID.15",
            Name = @"Language - Patient",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the patient's primary language",
            Sample = @"",
            Fields = null
        }

        _languagePatient = new HL7V22Field
        {
            field = message[@"PID"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_languagePatient.field.FieldRepetitions != null && _languagePatient.field.FieldRepetitions.Count > 0)
        {
            _languagePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_languagePatient, fieldData);
        }

        return _languagePatient;
    } 
}

internal HL7V22Field _maritalStatus;

public HL7V22Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.16",
            Type = @"Field",
            Position = @"PID.16",
            Name = @"Marital Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0002",
            TableName = @"MARITAL STATUS",
            Description = @"patient's marital status.  Refer to user-defined table 0002 - marital status for suggested entries",
            Sample = @"",
            Fields = null
        }

        _maritalStatus = new HL7V22Field
        {
            field = message[@"PID"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
    } 
}

internal HL7V22Field _religion;

public HL7V22Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.17",
            Type = @"Field",
            Position = @"PID.17",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0006",
            TableName = @"RELIGION",
            Description = @"patient's religion.  Refer to user-defined table 0006 - religion",
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V22Field
        {
            field = message[@"PID"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V22Field _patientAccountNumber;

public HL7V22Field PatientAccountNumber
{
    get
    {
        if (_patientAccountNumber != null)
        {
            return _patientAccountNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.18",
            Type = @"Field",
            Position = @"PID.18",
            Name = @"Patient Account Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"number assigned by accounting to which all charges, payments, etc. are recorded.  It is used to identify the patient's account.  Refer to table 0061 - check digit scheme in Chapter 2. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.18.1",
                            Type = @"Component",
                            Position = @"PID.18.1",
                            Name = @"ID Number",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.18.2",
                            Type = @"Component",
                            Position = @"PID.18.2",
                            Name = @"Check Digit",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.18.3",
                            Type = @"Component",
                            Position = @"PID.18.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.18.4",
                            Type = @"Component",
                            Position = @"PID.18.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _patientAccountNumber = new HL7V22Field
        {
            field = message[@"PID"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAccountNumber.field.FieldRepetitions != null && _patientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            _patientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientAccountNumber, fieldData);
        }

        return _patientAccountNumber;
    } 
}

internal HL7V22Field _socialSecurityNumberPatient;

public HL7V22Field SocialSecurityNumberPatient
{
    get
    {
        if (_socialSecurityNumberPatient != null)
        {
            return _socialSecurityNumberPatient;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.19",
            Type = @"Field",
            Position = @"PID.19",
            Name = @"Social Security Number - Patient",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"patient's social security number.  This number may also be an RR retirement number",
            Sample = @"",
            Fields = null
        }

        _socialSecurityNumberPatient = new HL7V22Field
        {
            field = message[@"PID"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_socialSecurityNumberPatient.field.FieldRepetitions != null && _socialSecurityNumberPatient.field.FieldRepetitions.Count > 0)
        {
            _socialSecurityNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_socialSecurityNumberPatient, fieldData);
        }

        return _socialSecurityNumberPatient;
    } 
}

internal HL7V22Field _driversLicenseNumberPatient;

public HL7V22Field DriversLicenseNumberPatient
{
    get
    {
        if (_driversLicenseNumberPatient != null)
        {
            return _driversLicenseNumberPatient;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.20",
            Type = @"Field",
            Position = @"PID.20",
            Name = @"Driver's License Number - Patient",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_LICENSE_NO",
            DataTypeName = @"Cm For Driving License",
            TableId = null,
            TableName = null,
            Description = @"patient's drivers license number.  Some sites may use this as a unique number that identifies the patient.  Default of the second component is the state in which the patient is being registered",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.20.1",
                            Type = @"Component",
                            Position = @"PID.20.1",
                            Name = @"License Number",
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
                            Id = @"PID.20.2",
                            Type = @"Component",
                            Position = @"PID.20.2",
                            Name = @"Issuing State,province,country",
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

        _driversLicenseNumberPatient = new HL7V22Field
        {
            field = message[@"PID"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_driversLicenseNumberPatient.field.FieldRepetitions != null && _driversLicenseNumberPatient.field.FieldRepetitions.Count > 0)
        {
            _driversLicenseNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_driversLicenseNumberPatient, fieldData);
        }

        return _driversLicenseNumberPatient;
    } 
}

internal HL7V22Field _mothersIdentifier;

public HL7V22Field MothersIdentifier
{
    get
    {
        if (_mothersIdentifier != null)
        {
            return _mothersIdentifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.21",
            Type = @"Field",
            Position = @"PID.21",
            Name = @"Mother's Identifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = @" used as a link field for newborns, for example.  Typically a patient ID or account number may be used.  Refer to HL7 table 0061 - check digit scheme as defined in Chapter 2. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.21.1",
                            Type = @"Component",
                            Position = @"PID.21.1",
                            Name = @"ID Number",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.21.2",
                            Type = @"Component",
                            Position = @"PID.21.2",
                            Name = @"Check Digit",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.21.3",
                            Type = @"Component",
                            Position = @"PID.21.3",
                            Name = @"Code Identifying the Check Digit Scheme Employed ",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0061",
                            TableName = @"CHECK DIGIT SCHEME",
                            Description = @"The check digit scheme codes are defined in table 0061 - check digit scheme. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PID.21.4",
                            Type = @"Component",
                            Position = @"PID.21.4",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility ID is a unique name (up to six characters in length) of the system that stores the data.  It is an ST data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning facility ID's are unique across a given HL7 implementation.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _mothersIdentifier = new HL7V22Field
        {
            field = message[@"PID"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersIdentifier.field.FieldRepetitions != null && _mothersIdentifier.field.FieldRepetitions.Count > 0)
        {
            _mothersIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_mothersIdentifier, fieldData);
        }

        return _mothersIdentifier;
    } 
}

internal HL7V22Field _ethnicGroup;

public HL7V22Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.22",
            Type = @"Field",
            Position = @"PID.22",
            Name = @"Ethnic Group",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0189",
            TableName = @"ETHNIC GROUP",
            Description = @"further defines patient ancestry.  Refer to user-defined table 0189 - ethnic group for suggested values",
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V22Field
        {
            field = message[@"PID"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V22Field _birthPlace;

public HL7V22Field BirthPlace
{
    get
    {
        if (_birthPlace != null)
        {
            return _birthPlace;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.23",
            Type = @"Field",
            Position = @"PID.23",
            Name = @"Birth Place",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"indicates the location of the patient's birth",
            Sample = @"",
            Fields = null
        }

        _birthPlace = new HL7V22Field
        {
            field = message[@"PID"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_birthPlace.field.FieldRepetitions != null && _birthPlace.field.FieldRepetitions.Count > 0)
        {
            _birthPlace.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_birthPlace, fieldData);
        }

        return _birthPlace;
    } 
}

internal HL7V22Field _multipleBirthIndicator;

public HL7V22Field MultipleBirthIndicator
{
    get
    {
        if (_multipleBirthIndicator != null)
        {
            return _multipleBirthIndicator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.24",
            Type = @"Field",
            Position = @"PID.24",
            Name = @"Multiple Birth Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"indicates if the patient was part of a multiple birth.  Refer to HL7 table 0136 - Y/N indicator as described in Chapter 2. ",
            Sample = @"",
            Fields = null
        }

        _multipleBirthIndicator = new HL7V22Field
        {
            field = message[@"PID"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_multipleBirthIndicator.field.FieldRepetitions != null && _multipleBirthIndicator.field.FieldRepetitions.Count > 0)
        {
            _multipleBirthIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_multipleBirthIndicator, fieldData);
        }

        return _multipleBirthIndicator;
    } 
}

internal HL7V22Field _birthOrder;

public HL7V22Field BirthOrder
{
    get
    {
        if (_birthOrder != null)
        {
            return _birthOrder;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.25",
            Type = @"Field",
            Position = @"PID.25",
            Name = @"Birth Order",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"if a patient was part of a multiple birth, a value (number) indicating the patient's birth order",
            Sample = @"",
            Fields = null
        }

        _birthOrder = new HL7V22Field
        {
            field = message[@"PID"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_birthOrder.field.FieldRepetitions != null && _birthOrder.field.FieldRepetitions.Count > 0)
        {
            _birthOrder.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_birthOrder, fieldData);
        }

        return _birthOrder;
    } 
}

internal HL7V22Field _citizenship;

public HL7V22Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.26",
            Type = @"Field",
            Position = @"PID.26",
            Name = @"Citizenship",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0171",
            TableName = @"COUNTRY CODE",
            Description = @"indicates the patient's country of citizenship.  Refer to user-defined table 0171 - country code for suggested values or to ISO 3166",
            Sample = @"",
            Fields = null
        }

        _citizenship = new HL7V22Field
        {
            field = message[@"PID"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V22Field _veteransMilitaryStatus;

public HL7V22Field VeteransMilitaryStatus
{
    get
    {
        if (_veteransMilitaryStatus != null)
        {
            return _veteransMilitaryStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PID.27",
            Type = @"Field",
            Position = @"PID.27",
            Name = @"Veterans Military Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0172",
            TableName = @"VETERANS MILITARY STATUS",
            Description = @"indicates the military status assigned to a veteran.  Refer to user-defined table 0172 - veterans military status for suggested codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PID.27.1",
                            Type = @"Component",
                            Position = @"PID.27.1",
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
                            Id = @"PID.27.2",
                            Type = @"Component",
                            Position = @"PID.27.2",
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
                            Id = @"PID.27.3",
                            Type = @"Component",
                            Position = @"PID.27.3",
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
                            Id = @"PID.27.4",
                            Type = @"Component",
                            Position = @"PID.27.4",
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
                            Id = @"PID.27.5",
                            Type = @"Component",
                            Position = @"PID.27.5",
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
                            Id = @"PID.27.6",
                            Type = @"Component",
                            Position = @"PID.27.6",
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

        _veteransMilitaryStatus = new HL7V22Field
        {
            field = message[@"PID"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_veteransMilitaryStatus.field.FieldRepetitions != null && _veteransMilitaryStatus.field.FieldRepetitions.Count > 0)
        {
            _veteransMilitaryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_veteransMilitaryStatus, fieldData);
        }

        return _veteransMilitaryStatus;
    } 
}
    }
}

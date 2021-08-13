using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPID
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PID"; } }

        public string SegmentId { get { return @"PID"; } }
        
        public string LongName { get { return @"Patient Identification"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentPID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdPatientId;

public HL7V21Field SetIdPatientId
{
    get
    {
        if (_setIdPatientId != null)
        {
            return _setIdPatientId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.1",
            Type = @"Field",
            Position = @"PID.1",
            Name = @"Set Id - Patient Id",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdPatientId = new HL7V21Field
        {
            field = message[@"PID"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdPatientId.field.FieldRepetitions != null && _setIdPatientId.field.FieldRepetitions.Count > 0)
        {
            _setIdPatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdPatientId, fieldData);
        }

        return _setIdPatientId;
    } 
}

internal HL7V21Field _patientIdExternalexternalId;

public HL7V21Field PatientIdExternalexternalId
{
    get
    {
        if (_patientIdExternalexternalId != null)
        {
            return _patientIdExternalexternalId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.2",
            Type = @"Field",
            Position = @"PID.2",
            Name = @"Patient Id External (external Id)",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientIdExternalexternalId = new HL7V21Field
        {
            field = message[@"PID"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIdExternalexternalId.field.FieldRepetitions != null && _patientIdExternalexternalId.field.FieldRepetitions.Count > 0)
        {
            _patientIdExternalexternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientIdExternalexternalId, fieldData);
        }

        return _patientIdExternalexternalId;
    } 
}

internal HL7V21Field _patientIdInternalinternalId;

public HL7V21Field PatientIdInternalinternalId
{
    get
    {
        if (_patientIdInternalinternalId != null)
        {
            return _patientIdInternalinternalId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.3",
            Type = @"Field",
            Position = @"PID.3",
            Name = @"Patient Id Internal (internal Id)",
            Length = 16,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CK",
            DataTypeName = @"Composite Id With Check Digit",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientIdInternalinternalId = new HL7V21Field
        {
            field = message[@"PID"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientIdInternalinternalId.field.FieldRepetitions != null && _patientIdInternalinternalId.field.FieldRepetitions.Count > 0)
        {
            _patientIdInternalinternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientIdInternalinternalId, fieldData);
        }

        return _patientIdInternalinternalId;
    } 
}

internal HL7V21Field _alternatePatientId;

public HL7V21Field AlternatePatientId
{
    get
    {
        if (_alternatePatientId != null)
        {
            return _alternatePatientId;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _alternatePatientId = new HL7V21Field
        {
            field = message[@"PID"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternatePatientId.field.FieldRepetitions != null && _alternatePatientId.field.FieldRepetitions.Count > 0)
        {
            _alternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_alternatePatientId, fieldData);
        }

        return _alternatePatientId;
    } 
}

internal HL7V21Field _patientName;

public HL7V21Field PatientName
{
    get
    {
        if (_patientName != null)
        {
            return _patientName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientName = new HL7V21Field
        {
            field = message[@"PID"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientName.field.FieldRepetitions != null && _patientName.field.FieldRepetitions.Count > 0)
        {
            _patientName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientName, fieldData);
        }

        return _patientName;
    } 
}

internal HL7V21Field _mothersMaidenName;

public HL7V21Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _mothersMaidenName = new HL7V21Field
        {
            field = message[@"PID"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V21Field _dateOfBirth;

public HL7V21Field DateOfBirth
{
    get
    {
        if (_dateOfBirth != null)
        {
            return _dateOfBirth;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.7",
            Type = @"Field",
            Position = @"PID.7",
            Name = @"Date Of Birth",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dateOfBirth = new HL7V21Field
        {
            field = message[@"PID"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateOfBirth.field.FieldRepetitions != null && _dateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _dateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dateOfBirth, fieldData);
        }

        return _dateOfBirth;
    } 
}

internal HL7V21Field _sex;

public HL7V21Field Sex
{
    get
    {
        if (_sex != null)
        {
            return _sex;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V21Field
        {
            field = message[@"PID"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sex.field.FieldRepetitions != null && _sex.field.FieldRepetitions.Count > 0)
        {
            _sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_sex, fieldData);
        }

        return _sex;
    } 
}

internal HL7V21Field _patientAlias;

public HL7V21Field PatientAlias
{
    get
    {
        if (_patientAlias != null)
        {
            return _patientAlias;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientAlias = new HL7V21Field
        {
            field = message[@"PID"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAlias.field.FieldRepetitions != null && _patientAlias.field.FieldRepetitions.Count > 0)
        {
            _patientAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientAlias, fieldData);
        }

        return _patientAlias;
    } 
}

internal HL7V21Field _ethnicGroup;

public HL7V21Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.10",
            Type = @"Field",
            Position = @"PID.10",
            Name = @"Ethnic Group",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0005",
            TableName = @"ETHNIC GROUP",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V21Field
        {
            field = message[@"PID"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V21Field _patientAddress;

public HL7V21Field PatientAddress
{
    get
    {
        if (_patientAddress != null)
        {
            return _patientAddress;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.11",
            Type = @"Field",
            Position = @"PID.11",
            Name = @"Patient Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientAddress = new HL7V21Field
        {
            field = message[@"PID"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAddress.field.FieldRepetitions != null && _patientAddress.field.FieldRepetitions.Count > 0)
        {
            _patientAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientAddress, fieldData);
        }

        return _patientAddress;
    } 
}

internal HL7V21Field _countyCode;

public HL7V21Field CountyCode
{
    get
    {
        if (_countyCode != null)
        {
            return _countyCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.12",
            Type = @"Field",
            Position = @"PID.12",
            Name = @"County Code",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _countyCode = new HL7V21Field
        {
            field = message[@"PID"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_countyCode.field.FieldRepetitions != null && _countyCode.field.FieldRepetitions.Count > 0)
        {
            _countyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_countyCode, fieldData);
        }

        return _countyCode;
    } 
}

internal HL7V21Field _phoneNumberHome;

public HL7V21Field PhoneNumberHome
{
    get
    {
        if (_phoneNumberHome != null)
        {
            return _phoneNumberHome;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _phoneNumberHome = new HL7V21Field
        {
            field = message[@"PID"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberHome.field.FieldRepetitions != null && _phoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_phoneNumberHome, fieldData);
        }

        return _phoneNumberHome;
    } 
}

internal HL7V21Field _phoneNumberBusiness;

public HL7V21Field PhoneNumberBusiness
{
    get
    {
        if (_phoneNumberBusiness != null)
        {
            return _phoneNumberBusiness;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _phoneNumberBusiness = new HL7V21Field
        {
            field = message[@"PID"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phoneNumberBusiness.field.FieldRepetitions != null && _phoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            _phoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_phoneNumberBusiness, fieldData);
        }

        return _phoneNumberBusiness;
    } 
}

internal HL7V21Field _languagePatient;

public HL7V21Field LanguagePatient
{
    get
    {
        if (_languagePatient != null)
        {
            return _languagePatient;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _languagePatient = new HL7V21Field
        {
            field = message[@"PID"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_languagePatient.field.FieldRepetitions != null && _languagePatient.field.FieldRepetitions.Count > 0)
        {
            _languagePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_languagePatient, fieldData);
        }

        return _languagePatient;
    } 
}

internal HL7V21Field _maritalStatus;

public HL7V21Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _maritalStatus = new HL7V21Field
        {
            field = message[@"PID"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
    } 
}

internal HL7V21Field _religion;

public HL7V21Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V21Field
        {
            field = message[@"PID"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V21Field _patientAccountNumber;

public HL7V21Field PatientAccountNumber
{
    get
    {
        if (_patientAccountNumber != null)
        {
            return _patientAccountNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientAccountNumber = new HL7V21Field
        {
            field = message[@"PID"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientAccountNumber.field.FieldRepetitions != null && _patientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            _patientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientAccountNumber, fieldData);
        }

        return _patientAccountNumber;
    } 
}

internal HL7V21Field _ssnNumberPatient;

public HL7V21Field SsnNumberPatient
{
    get
    {
        if (_ssnNumberPatient != null)
        {
            return _ssnNumberPatient;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.19",
            Type = @"Field",
            Position = @"PID.19",
            Name = @"Ssn Number - Patient",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _ssnNumberPatient = new HL7V21Field
        {
            field = message[@"PID"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ssnNumberPatient.field.FieldRepetitions != null && _ssnNumberPatient.field.FieldRepetitions.Count > 0)
        {
            _ssnNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ssnNumberPatient, fieldData);
        }

        return _ssnNumberPatient;
    } 
}

internal HL7V21Field _driversLicNumPatient;

public HL7V21Field DriversLicNumPatient
{
    get
    {
        if (_driversLicNumPatient != null)
        {
            return _driversLicNumPatient;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PID.20",
            Type = @"Field",
            Position = @"PID.20",
            Name = @"Driver's Lic Num - Patient",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM",
            DataTypeName = @"",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _driversLicNumPatient = new HL7V21Field
        {
            field = message[@"PID"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_driversLicNumPatient.field.FieldRepetitions != null && _driversLicNumPatient.field.FieldRepetitions.Count > 0)
        {
            _driversLicNumPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_driversLicNumPatient, fieldData);
        }

        return _driversLicNumPatient;
    } 
}
    }
}

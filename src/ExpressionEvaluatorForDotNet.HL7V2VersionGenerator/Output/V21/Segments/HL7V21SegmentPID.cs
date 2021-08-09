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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentPID(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field setIdPatientId;

public HL7V21Field SetIdPatientId
{
    get
    {
        if (setIdPatientId != null)
        {
            return setIdPatientId;
        }

        setIdPatientId = new HL7V21Field
        {
            field = message[@"PID"][1],
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
        };

        // check for repetitions
        if (setIdPatientId.field.FieldRepetitions != null && setIdPatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdPatientId.Id));
            setIdPatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(setIdPatientId, fieldData);
        }

        return setIdPatientId;
    } 
}

internal HL7V21Field patientIdExternalexternalId;

public HL7V21Field PatientIdExternalexternalId
{
    get
    {
        if (patientIdExternalexternalId != null)
        {
            return patientIdExternalexternalId;
        }

        patientIdExternalexternalId = new HL7V21Field
        {
            field = message[@"PID"][2],
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
        };

        // check for repetitions
        if (patientIdExternalexternalId.field.FieldRepetitions != null && patientIdExternalexternalId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientIdExternalexternalId.Id));
            patientIdExternalexternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientIdExternalexternalId, fieldData);
        }

        return patientIdExternalexternalId;
    } 
}

internal HL7V21Field patientIdInternalinternalId;

public HL7V21Field PatientIdInternalinternalId
{
    get
    {
        if (patientIdInternalinternalId != null)
        {
            return patientIdInternalinternalId;
        }

        patientIdInternalinternalId = new HL7V21Field
        {
            field = message[@"PID"][3],
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
        };

        // check for repetitions
        if (patientIdInternalinternalId.field.FieldRepetitions != null && patientIdInternalinternalId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientIdInternalinternalId.Id));
            patientIdInternalinternalId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientIdInternalinternalId, fieldData);
        }

        return patientIdInternalinternalId;
    } 
}

internal HL7V21Field alternatePatientId;

public HL7V21Field AlternatePatientId
{
    get
    {
        if (alternatePatientId != null)
        {
            return alternatePatientId;
        }

        alternatePatientId = new HL7V21Field
        {
            field = message[@"PID"][4],
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
        };

        // check for repetitions
        if (alternatePatientId.field.FieldRepetitions != null && alternatePatientId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(alternatePatientId.Id));
            alternatePatientId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(alternatePatientId, fieldData);
        }

        return alternatePatientId;
    } 
}

internal HL7V21Field patientName;

public HL7V21Field PatientName
{
    get
    {
        if (patientName != null)
        {
            return patientName;
        }

        patientName = new HL7V21Field
        {
            field = message[@"PID"][5],
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
        };

        // check for repetitions
        if (patientName.field.FieldRepetitions != null && patientName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientName.Id));
            patientName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientName, fieldData);
        }

        return patientName;
    } 
}

internal HL7V21Field mothersMaidenName;

public HL7V21Field MothersMaidenName
{
    get
    {
        if (mothersMaidenName != null)
        {
            return mothersMaidenName;
        }

        mothersMaidenName = new HL7V21Field
        {
            field = message[@"PID"][6],
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
        };

        // check for repetitions
        if (mothersMaidenName.field.FieldRepetitions != null && mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mothersMaidenName.Id));
            mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(mothersMaidenName, fieldData);
        }

        return mothersMaidenName;
    } 
}

internal HL7V21Field dateOfBirth;

public HL7V21Field DateOfBirth
{
    get
    {
        if (dateOfBirth != null)
        {
            return dateOfBirth;
        }

        dateOfBirth = new HL7V21Field
        {
            field = message[@"PID"][7],
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
        };

        // check for repetitions
        if (dateOfBirth.field.FieldRepetitions != null && dateOfBirth.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dateOfBirth.Id));
            dateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(dateOfBirth, fieldData);
        }

        return dateOfBirth;
    } 
}

internal HL7V21Field sex;

public HL7V21Field Sex
{
    get
    {
        if (sex != null)
        {
            return sex;
        }

        sex = new HL7V21Field
        {
            field = message[@"PID"][8],
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
        };

        // check for repetitions
        if (sex.field.FieldRepetitions != null && sex.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(sex.Id));
            sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(sex, fieldData);
        }

        return sex;
    } 
}

internal HL7V21Field patientAlias;

public HL7V21Field PatientAlias
{
    get
    {
        if (patientAlias != null)
        {
            return patientAlias;
        }

        patientAlias = new HL7V21Field
        {
            field = message[@"PID"][9],
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
        };

        // check for repetitions
        if (patientAlias.field.FieldRepetitions != null && patientAlias.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAlias.Id));
            patientAlias.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientAlias, fieldData);
        }

        return patientAlias;
    } 
}

internal HL7V21Field ethnicGroup;

public HL7V21Field EthnicGroup
{
    get
    {
        if (ethnicGroup != null)
        {
            return ethnicGroup;
        }

        ethnicGroup = new HL7V21Field
        {
            field = message[@"PID"][10],
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
        };

        // check for repetitions
        if (ethnicGroup.field.FieldRepetitions != null && ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ethnicGroup.Id));
            ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(ethnicGroup, fieldData);
        }

        return ethnicGroup;
    } 
}

internal HL7V21Field patientAddress;

public HL7V21Field PatientAddress
{
    get
    {
        if (patientAddress != null)
        {
            return patientAddress;
        }

        patientAddress = new HL7V21Field
        {
            field = message[@"PID"][11],
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
        };

        // check for repetitions
        if (patientAddress.field.FieldRepetitions != null && patientAddress.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAddress.Id));
            patientAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientAddress, fieldData);
        }

        return patientAddress;
    } 
}

internal HL7V21Field countyCode;

public HL7V21Field CountyCode
{
    get
    {
        if (countyCode != null)
        {
            return countyCode;
        }

        countyCode = new HL7V21Field
        {
            field = message[@"PID"][12],
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
        };

        // check for repetitions
        if (countyCode.field.FieldRepetitions != null && countyCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(countyCode.Id));
            countyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(countyCode, fieldData);
        }

        return countyCode;
    } 
}

internal HL7V21Field phoneNumberHome;

public HL7V21Field PhoneNumberHome
{
    get
    {
        if (phoneNumberHome != null)
        {
            return phoneNumberHome;
        }

        phoneNumberHome = new HL7V21Field
        {
            field = message[@"PID"][13],
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
        };

        // check for repetitions
        if (phoneNumberHome.field.FieldRepetitions != null && phoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumberHome.Id));
            phoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(phoneNumberHome, fieldData);
        }

        return phoneNumberHome;
    } 
}

internal HL7V21Field phoneNumberBusiness;

public HL7V21Field PhoneNumberBusiness
{
    get
    {
        if (phoneNumberBusiness != null)
        {
            return phoneNumberBusiness;
        }

        phoneNumberBusiness = new HL7V21Field
        {
            field = message[@"PID"][14],
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
        };

        // check for repetitions
        if (phoneNumberBusiness.field.FieldRepetitions != null && phoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(phoneNumberBusiness.Id));
            phoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(phoneNumberBusiness, fieldData);
        }

        return phoneNumberBusiness;
    } 
}

internal HL7V21Field languagePatient;

public HL7V21Field LanguagePatient
{
    get
    {
        if (languagePatient != null)
        {
            return languagePatient;
        }

        languagePatient = new HL7V21Field
        {
            field = message[@"PID"][15],
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
        };

        // check for repetitions
        if (languagePatient.field.FieldRepetitions != null && languagePatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(languagePatient.Id));
            languagePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(languagePatient, fieldData);
        }

        return languagePatient;
    } 
}

internal HL7V21Field maritalStatus;

public HL7V21Field MaritalStatus
{
    get
    {
        if (maritalStatus != null)
        {
            return maritalStatus;
        }

        maritalStatus = new HL7V21Field
        {
            field = message[@"PID"][16],
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
        };

        // check for repetitions
        if (maritalStatus.field.FieldRepetitions != null && maritalStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(maritalStatus.Id));
            maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(maritalStatus, fieldData);
        }

        return maritalStatus;
    } 
}

internal HL7V21Field religion;

public HL7V21Field Religion
{
    get
    {
        if (religion != null)
        {
            return religion;
        }

        religion = new HL7V21Field
        {
            field = message[@"PID"][17],
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
        };

        // check for repetitions
        if (religion.field.FieldRepetitions != null && religion.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(religion.Id));
            religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(religion, fieldData);
        }

        return religion;
    } 
}

internal HL7V21Field patientAccountNumber;

public HL7V21Field PatientAccountNumber
{
    get
    {
        if (patientAccountNumber != null)
        {
            return patientAccountNumber;
        }

        patientAccountNumber = new HL7V21Field
        {
            field = message[@"PID"][18],
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
        };

        // check for repetitions
        if (patientAccountNumber.field.FieldRepetitions != null && patientAccountNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(patientAccountNumber.Id));
            patientAccountNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(patientAccountNumber, fieldData);
        }

        return patientAccountNumber;
    } 
}

internal HL7V21Field ssnNumberPatient;

public HL7V21Field SsnNumberPatient
{
    get
    {
        if (ssnNumberPatient != null)
        {
            return ssnNumberPatient;
        }

        ssnNumberPatient = new HL7V21Field
        {
            field = message[@"PID"][19],
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
        };

        // check for repetitions
        if (ssnNumberPatient.field.FieldRepetitions != null && ssnNumberPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(ssnNumberPatient.Id));
            ssnNumberPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(ssnNumberPatient, fieldData);
        }

        return ssnNumberPatient;
    } 
}

internal HL7V21Field driversLicNumPatient;

public HL7V21Field DriversLicNumPatient
{
    get
    {
        if (driversLicNumPatient != null)
        {
            return driversLicNumPatient;
        }

        driversLicNumPatient = new HL7V21Field
        {
            field = message[@"PID"][20],
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
        };

        // check for repetitions
        if (driversLicNumPatient.field.FieldRepetitions != null && driversLicNumPatient.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(driversLicNumPatient.Id));
            driversLicNumPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(driversLicNumPatient, fieldData);
        }

        return driversLicNumPatient;
    } 
}
    }
}

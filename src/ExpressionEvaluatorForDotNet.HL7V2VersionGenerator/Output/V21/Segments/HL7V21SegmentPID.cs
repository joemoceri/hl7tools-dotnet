using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPID
    {
        public readonly HL7V2Message message;

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

        

        

        

        return setIdPatientId;
    } 
}
internal HL7V21Field patientIdExternal(externalId);

public HL7V21Field PatientIdExternal(externalId)
{
    get
    {
        if (patientIdExternal(externalId) != null)
        {
            return patientIdExternal(externalId);
        }

        patientIdExternal(externalId) = new HL7V21Field
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

        

        

        

        return patientIdExternal(externalId);
    } 
}
internal HL7V21Field patientIdInternal(internalId);

public HL7V21Field PatientIdInternal(internalId)
{
    get
    {
        if (patientIdInternal(internalId) != null)
        {
            return patientIdInternal(internalId);
        }

        patientIdInternal(internalId) = new HL7V21Field
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

        

        

        

        return patientIdInternal(internalId);
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

        

        

        

        return patientName;
    } 
}
internal HL7V21Field mother'sMaidenName;

public HL7V21Field Mother'sMaidenName
{
    get
    {
        if (mother'sMaidenName != null)
        {
            return mother'sMaidenName;
        }

        mother'sMaidenName = new HL7V21Field
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

        

        

        

        return mother'sMaidenName;
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

        

        

        

        return ssnNumberPatient;
    } 
}
internal HL7V21Field driver'sLicNumPatient;

public HL7V21Field Driver'sLicNumPatient
{
    get
    {
        if (driver'sLicNumPatient != null)
        {
            return driver'sLicNumPatient;
        }

        driver'sLicNumPatient = new HL7V21Field
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

        

        

        

        return driver'sLicNumPatient;
    } 
}

    }
}

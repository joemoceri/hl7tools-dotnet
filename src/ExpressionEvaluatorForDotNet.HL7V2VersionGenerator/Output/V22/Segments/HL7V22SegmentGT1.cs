using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor"; } }
        
        public string Description { get { return @"The GT1 segment contains guarantor (e.g., person with financial responsibility for payment of a patient account) data for patient and insurance billing applications"; } }
        
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

        public HL7V22SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdGuarantor;

public HL7V22Field SetIdGuarantor
{
    get
    {
        if (_setIdGuarantor != null)
        {
            return _setIdGuarantor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set Id - Guarantor",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies the transaction for the purpose of adding, changing, or deleting a transaction",
            Sample = @"",
            Fields = null
        }

        _setIdGuarantor = new HL7V22Field
        {
            field = message[@"GT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdGuarantor.field.FieldRepetitions != null && _setIdGuarantor.field.FieldRepetitions.Count > 0)
        {
            _setIdGuarantor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdGuarantor, fieldData);
        }

        return _setIdGuarantor;
    } 
}

internal HL7V22Field _guarantorNumber;

public HL7V22Field GuarantorNumber
{
    get
    {
        if (_guarantorNumber != null)
        {
            return _guarantorNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.2",
            Type = @"Field",
            Position = @"GT1.2",
            Name = @"Guarantor Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"COMP_ID_DIGIT",
            DataTypeName = @"Composite Id W/chk Digit",
            TableId = null,
            TableName = null,
            Description = @"unique number assigned to the guarantor",
            Sample = @"",
            Fields = null
        }

        _guarantorNumber = new HL7V22Field
        {
            field = message[@"GT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorNumber.field.FieldRepetitions != null && _guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorNumber, fieldData);
        }

        return _guarantorNumber;
    } 
}

internal HL7V22Field _guarantorName;

public HL7V22Field GuarantorName
{
    get
    {
        if (_guarantorName != null)
        {
            return _guarantorName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.3",
            Type = @"Field",
            Position = @"GT1.3",
            Name = @"Guarantor Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.3.1",
                            Type = @"Component",
                            Position = @"GT1.3.1",
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
                            Id = @"GT1.3.2",
                            Type = @"Component",
                            Position = @"GT1.3.2",
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
                            Id = @"GT1.3.3",
                            Type = @"Component",
                            Position = @"GT1.3.3",
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
                            Id = @"GT1.3.4",
                            Type = @"Component",
                            Position = @"GT1.3.4",
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
                            Id = @"GT1.3.5",
                            Type = @"Component",
                            Position = @"GT1.3.5",
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
                            Id = @"GT1.3.6",
                            Type = @"Component",
                            Position = @"GT1.3.6",
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

        _guarantorName = new HL7V22Field
        {
            field = message[@"GT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorName.field.FieldRepetitions != null && _guarantorName.field.FieldRepetitions.Count > 0)
        {
            _guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorName, fieldData);
        }

        return _guarantorName;
    } 
}

internal HL7V22Field _guarantorSpouseName;

public HL7V22Field GuarantorSpouseName
{
    get
    {
        if (_guarantorSpouseName != null)
        {
            return _guarantorSpouseName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.4",
            Type = @"Field",
            Position = @"GT1.4",
            Name = @"Guarantor Spouse Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor's spouse",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.4.1",
                            Type = @"Component",
                            Position = @"GT1.4.1",
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
                            Id = @"GT1.4.2",
                            Type = @"Component",
                            Position = @"GT1.4.2",
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
                            Id = @"GT1.4.3",
                            Type = @"Component",
                            Position = @"GT1.4.3",
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
                            Id = @"GT1.4.4",
                            Type = @"Component",
                            Position = @"GT1.4.4",
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
                            Id = @"GT1.4.5",
                            Type = @"Component",
                            Position = @"GT1.4.5",
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
                            Id = @"GT1.4.6",
                            Type = @"Component",
                            Position = @"GT1.4.6",
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

        _guarantorSpouseName = new HL7V22Field
        {
            field = message[@"GT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSpouseName.field.FieldRepetitions != null && _guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            _guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorSpouseName, fieldData);
        }

        return _guarantorSpouseName;
    } 
}

internal HL7V22Field _guarantorAddress;

public HL7V22Field GuarantorAddress
{
    get
    {
        if (_guarantorAddress != null)
        {
            return _guarantorAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.5",
            Type = @"Field",
            Position = @"GT1.5",
            Name = @"Guarantor Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"guarantor's address",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.5.1",
                            Type = @"Component",
                            Position = @"GT1.5.1",
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
                            Id = @"GT1.5.2",
                            Type = @"Component",
                            Position = @"GT1.5.2",
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
                            Id = @"GT1.5.3",
                            Type = @"Component",
                            Position = @"GT1.5.3",
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
                            Id = @"GT1.5.4",
                            Type = @"Component",
                            Position = @"GT1.5.4",
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
                            Id = @"GT1.5.5",
                            Type = @"Component",
                            Position = @"GT1.5.5",
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
                            Id = @"GT1.5.6",
                            Type = @"Component",
                            Position = @"GT1.5.6",
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
                            Id = @"GT1.5.7",
                            Type = @"Component",
                            Position = @"GT1.5.7",
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
                            Id = @"GT1.5.8",
                            Type = @"Component",
                            Position = @"GT1.5.8",
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

        _guarantorAddress = new HL7V22Field
        {
            field = message[@"GT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorAddress.field.FieldRepetitions != null && _guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorAddress, fieldData);
        }

        return _guarantorAddress;
    } 
}

internal HL7V22Field _guarantorPhoneNumberHome;

public HL7V22Field GuarantorPhoneNumberHome
{
    get
    {
        if (_guarantorPhoneNumberHome != null)
        {
            return _guarantorPhoneNumberHome;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Phone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's home phone number",
            Sample = @"",
            Fields = null
        }

        _guarantorPhoneNumberHome = new HL7V22Field
        {
            field = message[@"GT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhoneNumberHome.field.FieldRepetitions != null && _guarantorPhoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorPhoneNumberHome, fieldData);
        }

        return _guarantorPhoneNumberHome;
    } 
}

internal HL7V22Field _guarantorPhoneNumberBusiness;

public HL7V22Field GuarantorPhoneNumberBusiness
{
    get
    {
        if (_guarantorPhoneNumberBusiness != null)
        {
            return _guarantorPhoneNumberBusiness;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.7",
            Type = @"Field",
            Position = @"GT1.7",
            Name = @"Guarantor Phone Number - Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's business phone number",
            Sample = @"",
            Fields = null
        }

        _guarantorPhoneNumberBusiness = new HL7V22Field
        {
            field = message[@"GT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhoneNumberBusiness.field.FieldRepetitions != null && _guarantorPhoneNumberBusiness.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhoneNumberBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorPhoneNumberBusiness, fieldData);
        }

        return _guarantorPhoneNumberBusiness;
    } 
}

internal HL7V22Field _guarantorDateOfBirth;

public HL7V22Field GuarantorDateOfBirth
{
    get
    {
        if (_guarantorDateOfBirth != null)
        {
            return _guarantorDateOfBirth;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.8",
            Type = @"Field",
            Position = @"GT1.8",
            Name = @"Guarantor Date Of Birth",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"guarantor's date of birth",
            Sample = @"",
            Fields = null
        }

        _guarantorDateOfBirth = new HL7V22Field
        {
            field = message[@"GT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateOfBirth.field.FieldRepetitions != null && _guarantorDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorDateOfBirth, fieldData);
        }

        return _guarantorDateOfBirth;
    } 
}

internal HL7V22Field _guarantorSex;

public HL7V22Field GuarantorSex
{
    get
    {
        if (_guarantorSex != null)
        {
            return _guarantorSex;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.9",
            Type = @"Field",
            Position = @"GT1.9",
            Name = @"Guarantor Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = @"refer to table 0001 - sex for valid entries",
            Sample = @"",
            Fields = null
        }

        _guarantorSex = new HL7V22Field
        {
            field = message[@"GT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSex.field.FieldRepetitions != null && _guarantorSex.field.FieldRepetitions.Count > 0)
        {
            _guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorSex, fieldData);
        }

        return _guarantorSex;
    } 
}

internal HL7V22Field _guarantorType;

public HL7V22Field GuarantorType
{
    get
    {
        if (_guarantorType != null)
        {
            return _guarantorType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.10",
            Type = @"Field",
            Position = @"GT1.10",
            Name = @"Guarantor Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0068",
            TableName = @"GUARANTOR TYPE",
            Description = @"type of guarantor, e.g., individual, institution, etc.  Refer to user-defined table 0068 - guarantor type",
            Sample = @"",
            Fields = null
        }

        _guarantorType = new HL7V22Field
        {
            field = message[@"GT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorType.field.FieldRepetitions != null && _guarantorType.field.FieldRepetitions.Count > 0)
        {
            _guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorType, fieldData);
        }

        return _guarantorType;
    } 
}

internal HL7V22Field _guarantorRelationship;

public HL7V22Field GuarantorRelationship
{
    get
    {
        if (_guarantorRelationship != null)
        {
            return _guarantorRelationship;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.11",
            Type = @"Field",
            Position = @"GT1.11",
            Name = @"Guarantor Relationship",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = @"relationship of the guarantor with the patient, e.g., parent, child, etc.  Refer to user-defined table 0063 - guarantor relationship",
            Sample = @"",
            Fields = null
        }

        _guarantorRelationship = new HL7V22Field
        {
            field = message[@"GT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRelationship.field.FieldRepetitions != null && _guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            _guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorRelationship, fieldData);
        }

        return _guarantorRelationship;
    } 
}

internal HL7V22Field _guarantorSocialSecurityNumber;

public HL7V22Field GuarantorSocialSecurityNumber
{
    get
    {
        if (_guarantorSocialSecurityNumber != null)
        {
            return _guarantorSocialSecurityNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.12",
            Type = @"Field",
            Position = @"GT1.12",
            Name = @"Guarantor Social Security Number",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"guarantor's social security number",
            Sample = @"",
            Fields = null
        }

        _guarantorSocialSecurityNumber = new HL7V22Field
        {
            field = message[@"GT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSocialSecurityNumber.field.FieldRepetitions != null && _guarantorSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorSocialSecurityNumber, fieldData);
        }

        return _guarantorSocialSecurityNumber;
    } 
}

internal HL7V22Field _guarantorDateBegin;

public HL7V22Field GuarantorDateBegin
{
    get
    {
        if (_guarantorDateBegin != null)
        {
            return _guarantorDateBegin;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.13",
            Type = @"Field",
            Position = @"GT1.13",
            Name = @"Guarantor Date - Begin",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the guarantor becomes responsible for the patient's account",
            Sample = @"",
            Fields = null
        }

        _guarantorDateBegin = new HL7V22Field
        {
            field = message[@"GT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateBegin.field.FieldRepetitions != null && _guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorDateBegin, fieldData);
        }

        return _guarantorDateBegin;
    } 
}

internal HL7V22Field _guarantorDateEnd;

public HL7V22Field GuarantorDateEnd
{
    get
    {
        if (_guarantorDateEnd != null)
        {
            return _guarantorDateEnd;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.14",
            Type = @"Field",
            Position = @"GT1.14",
            Name = @"Guarantor Date - End",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date the guarantor stops being responsible for the patient's account",
            Sample = @"",
            Fields = null
        }

        _guarantorDateEnd = new HL7V22Field
        {
            field = message[@"GT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateEnd.field.FieldRepetitions != null && _guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorDateEnd, fieldData);
        }

        return _guarantorDateEnd;
    } 
}

internal HL7V22Field _guarantorPriority;

public HL7V22Field GuarantorPriority
{
    get
    {
        if (_guarantorPriority != null)
        {
            return _guarantorPriority;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.15",
            Type = @"Field",
            Position = @"GT1.15",
            Name = @"Guarantor Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"used to determine the order in which the guarantors will be responsible for the patient's account",
            Sample = @"",
            Fields = null
        }

        _guarantorPriority = new HL7V22Field
        {
            field = message[@"GT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPriority.field.FieldRepetitions != null && _guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            _guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorPriority, fieldData);
        }

        return _guarantorPriority;
    } 
}

internal HL7V22Field _guarantorEmployerName;

public HL7V22Field GuarantorEmployerName
{
    get
    {
        if (_guarantorEmployerName != null)
        {
            return _guarantorEmployerName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.16",
            Type = @"Field",
            Position = @"GT1.16",
            Name = @"Guarantor Employer Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the guarantor's employer",
            Sample = @"",
            Fields = null
        }

        _guarantorEmployerName = new HL7V22Field
        {
            field = message[@"GT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerName.field.FieldRepetitions != null && _guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorEmployerName, fieldData);
        }

        return _guarantorEmployerName;
    } 
}

internal HL7V22Field _guarantorEmployerAddress;

public HL7V22Field GuarantorEmployerAddress
{
    get
    {
        if (_guarantorEmployerAddress != null)
        {
            return _guarantorEmployerAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.17",
            Type = @"Field",
            Position = @"GT1.17",
            Name = @"Guarantor Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @" guarantor's employer's address",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.17.1",
                            Type = @"Component",
                            Position = @"GT1.17.1",
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
                            Id = @"GT1.17.2",
                            Type = @"Component",
                            Position = @"GT1.17.2",
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
                            Id = @"GT1.17.3",
                            Type = @"Component",
                            Position = @"GT1.17.3",
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
                            Id = @"GT1.17.4",
                            Type = @"Component",
                            Position = @"GT1.17.4",
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
                            Id = @"GT1.17.5",
                            Type = @"Component",
                            Position = @"GT1.17.5",
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
                            Id = @"GT1.17.6",
                            Type = @"Component",
                            Position = @"GT1.17.6",
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
                            Id = @"GT1.17.7",
                            Type = @"Component",
                            Position = @"GT1.17.7",
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
                            Id = @"GT1.17.8",
                            Type = @"Component",
                            Position = @"GT1.17.8",
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

        _guarantorEmployerAddress = new HL7V22Field
        {
            field = message[@"GT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerAddress.field.FieldRepetitions != null && _guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorEmployerAddress, fieldData);
        }

        return _guarantorEmployerAddress;
    } 
}

internal HL7V22Field _guarantorEmployPhoneNumber;

public HL7V22Field GuarantorEmployPhoneNumber
{
    get
    {
        if (_guarantorEmployPhoneNumber != null)
        {
            return _guarantorEmployPhoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employ Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"guarantor's employer phone number",
            Sample = @"",
            Fields = null
        }

        _guarantorEmployPhoneNumber = new HL7V22Field
        {
            field = message[@"GT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployPhoneNumber.field.FieldRepetitions != null && _guarantorEmployPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorEmployPhoneNumber, fieldData);
        }

        return _guarantorEmployPhoneNumber;
    } 
}

internal HL7V22Field _guarantorEmployeeIdNumber;

public HL7V22Field GuarantorEmployeeIdNumber
{
    get
    {
        if (_guarantorEmployeeIdNumber != null)
        {
            return _guarantorEmployeeIdNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.19",
            Type = @"Field",
            Position = @"GT1.19",
            Name = @"Guarantor Employee Id Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"guarantor's employee number",
            Sample = @"",
            Fields = null
        }

        _guarantorEmployeeIdNumber = new HL7V22Field
        {
            field = message[@"GT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployeeIdNumber.field.FieldRepetitions != null && _guarantorEmployeeIdNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployeeIdNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorEmployeeIdNumber, fieldData);
        }

        return _guarantorEmployeeIdNumber;
    } 
}

internal HL7V22Field _guarantorEmploymentStatus;

public HL7V22Field GuarantorEmploymentStatus
{
    get
    {
        if (_guarantorEmploymentStatus != null)
        {
            return _guarantorEmploymentStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.20",
            Type = @"Field",
            Position = @"GT1.20",
            Name = @"Guarantor Employment Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = @"code that indicates the guarantor's employment status. e.g., Full Time, Part Time, Self Employed, etc.  Refer to user-defined table 0066 - employment status",
            Sample = @"",
            Fields = null
        }

        _guarantorEmploymentStatus = new HL7V22Field
        {
            field = message[@"GT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmploymentStatus.field.FieldRepetitions != null && _guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorEmploymentStatus, fieldData);
        }

        return _guarantorEmploymentStatus;
    } 
}

internal HL7V22Field _guarantorOrganization;

public HL7V22Field GuarantorOrganization
{
    get
    {
        if (_guarantorOrganization != null)
        {
            return _guarantorOrganization;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"GT1.21",
            Type = @"Field",
            Position = @"GT1.21",
            Name = @"Guarantor Organization",
            Length = 60,
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

        _guarantorOrganization = new HL7V22Field
        {
            field = message[@"GT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorOrganization.field.FieldRepetitions != null && _guarantorOrganization.field.FieldRepetitions.Count > 0)
        {
            _guarantorOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_guarantorOrganization, fieldData);
        }

        return _guarantorOrganization;
    } 
}
    }
}

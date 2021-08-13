using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentIN2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN2"; } }

        public string SegmentId { get { return @"IN2"; } }
        
        public string LongName { get { return @"Insurance Additional Info"; } }
        
        public string Description { get { return @"The IN2 segment contains additional insurance policy coverage and benefit information necessary for proper billing and reimbursement.  Fields used by this segment are defined by HICFA or other regulatory agencies."; } }
        
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

        public HL7V22SegmentIN2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _insuredsEmployeeId;

public HL7V22Field InsuredsEmployeeId
{
    get
    {
        if (_insuredsEmployeeId != null)
        {
            return _insuredsEmployeeId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.1",
            Type = @"Field",
            Position = @"IN2.1",
            Name = @"Insured's Employee Id",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"employee ID of insured",
            Sample = @"",
            Fields = null
        }

        _insuredsEmployeeId = new HL7V22Field
        {
            field = message[@"IN2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployeeId.field.FieldRepetitions != null && _insuredsEmployeeId.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployeeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsEmployeeId, fieldData);
        }

        return _insuredsEmployeeId;
    } 
}

internal HL7V22Field _insuredsSocialSecurityNumber;

public HL7V22Field InsuredsSocialSecurityNumber
{
    get
    {
        if (_insuredsSocialSecurityNumber != null)
        {
            return _insuredsSocialSecurityNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.2",
            Type = @"Field",
            Position = @"IN2.2",
            Name = @"Insured's Social Security Number",
            Length = 9,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"social security number of insured",
            Sample = @"",
            Fields = null
        }

        _insuredsSocialSecurityNumber = new HL7V22Field
        {
            field = message[@"IN2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsSocialSecurityNumber.field.FieldRepetitions != null && _insuredsSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            _insuredsSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsSocialSecurityNumber, fieldData);
        }

        return _insuredsSocialSecurityNumber;
    } 
}

internal HL7V22Field _insuredsEmployerName;

public HL7V22Field InsuredsEmployerName
{
    get
    {
        if (_insuredsEmployerName != null)
        {
            return _insuredsEmployerName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.3",
            Type = @"Field",
            Position = @"IN2.3",
            Name = @"Insured's Employer Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"name of insured's employer",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.3.1",
                            Type = @"Component",
                            Position = @"IN2.3.1",
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
                            Id = @"IN2.3.2",
                            Type = @"Component",
                            Position = @"IN2.3.2",
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
                            Id = @"IN2.3.3",
                            Type = @"Component",
                            Position = @"IN2.3.3",
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
                            Id = @"IN2.3.4",
                            Type = @"Component",
                            Position = @"IN2.3.4",
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
                            Id = @"IN2.3.5",
                            Type = @"Component",
                            Position = @"IN2.3.5",
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
                            Id = @"IN2.3.6",
                            Type = @"Component",
                            Position = @"IN2.3.6",
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
                            Id = @"IN2.3.7",
                            Type = @"Component",
                            Position = @"IN2.3.7",
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
                            Id = @"IN2.3.8",
                            Type = @"Component",
                            Position = @"IN2.3.8",
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

        _insuredsEmployerName = new HL7V22Field
        {
            field = message[@"IN2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerName.field.FieldRepetitions != null && _insuredsEmployerName.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsEmployerName, fieldData);
        }

        return _insuredsEmployerName;
    } 
}

internal HL7V22Field _employerInformationData;

public HL7V22Field EmployerInformationData
{
    get
    {
        if (_employerInformationData != null)
        {
            return _employerInformationData;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.4",
            Type = @"Field",
            Position = @"IN2.4",
            Name = @"Employer Information Data",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0139",
            TableName = @"EMPLOYER INFORMATION DATA",
            Description = @"required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - employer information data for suggested values",
            Sample = @"",
            Fields = null
        }

        _employerInformationData = new HL7V22Field
        {
            field = message[@"IN2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employerInformationData.field.FieldRepetitions != null && _employerInformationData.field.FieldRepetitions.Count > 0)
        {
            _employerInformationData.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_employerInformationData, fieldData);
        }

        return _employerInformationData;
    } 
}

internal HL7V22Field _mailClaimParty;

public HL7V22Field MailClaimParty
{
    get
    {
        if (_mailClaimParty != null)
        {
            return _mailClaimParty;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.5",
            Type = @"Field",
            Position = @"IN2.5",
            Name = @"Mail Claim Party",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0137",
            TableName = @"MAIL CLAIM PARTY",
            Description = @"party to which the claim should be mailed",
            Sample = @"",
            Fields = null
        }

        _mailClaimParty = new HL7V22Field
        {
            field = message[@"IN2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mailClaimParty.field.FieldRepetitions != null && _mailClaimParty.field.FieldRepetitions.Count > 0)
        {
            _mailClaimParty.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_mailClaimParty, fieldData);
        }

        return _mailClaimParty;
    } 
}

internal HL7V22Field _medicareHealthInsuranceCardNumber;

public HL7V22Field MedicareHealthInsuranceCardNumber
{
    get
    {
        if (_medicareHealthInsuranceCardNumber != null)
        {
            return _medicareHealthInsuranceCardNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.6",
            Type = @"Field",
            Position = @"IN2.6",
            Name = @"Medicare Health Insurance Card Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _medicareHealthInsuranceCardNumber = new HL7V22Field
        {
            field = message[@"IN2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicareHealthInsuranceCardNumber.field.FieldRepetitions != null && _medicareHealthInsuranceCardNumber.field.FieldRepetitions.Count > 0)
        {
            _medicareHealthInsuranceCardNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_medicareHealthInsuranceCardNumber, fieldData);
        }

        return _medicareHealthInsuranceCardNumber;
    } 
}

internal HL7V22Field _medicaidCaseName;

public HL7V22Field MedicaidCaseName
{
    get
    {
        if (_medicaidCaseName != null)
        {
            return _medicaidCaseName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.7",
            Type = @"Field",
            Position = @"IN2.7",
            Name = @"Medicaid Case Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.7.1",
                            Type = @"Component",
                            Position = @"IN2.7.1",
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
                            Id = @"IN2.7.2",
                            Type = @"Component",
                            Position = @"IN2.7.2",
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
                            Id = @"IN2.7.3",
                            Type = @"Component",
                            Position = @"IN2.7.3",
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
                            Id = @"IN2.7.4",
                            Type = @"Component",
                            Position = @"IN2.7.4",
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
                            Id = @"IN2.7.5",
                            Type = @"Component",
                            Position = @"IN2.7.5",
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
                            Id = @"IN2.7.6",
                            Type = @"Component",
                            Position = @"IN2.7.6",
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

        _medicaidCaseName = new HL7V22Field
        {
            field = message[@"IN2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicaidCaseName.field.FieldRepetitions != null && _medicaidCaseName.field.FieldRepetitions.Count > 0)
        {
            _medicaidCaseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_medicaidCaseName, fieldData);
        }

        return _medicaidCaseName;
    } 
}

internal HL7V22Field _medicaidCaseNumber;

public HL7V22Field MedicaidCaseNumber
{
    get
    {
        if (_medicaidCaseNumber != null)
        {
            return _medicaidCaseNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.8",
            Type = @"Field",
            Position = @"IN2.8",
            Name = @"Medicaid Case Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _medicaidCaseNumber = new HL7V22Field
        {
            field = message[@"IN2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicaidCaseNumber.field.FieldRepetitions != null && _medicaidCaseNumber.field.FieldRepetitions.Count > 0)
        {
            _medicaidCaseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_medicaidCaseNumber, fieldData);
        }

        return _medicaidCaseNumber;
    } 
}

internal HL7V22Field _champusSponsorName;

public HL7V22Field ChampusSponsorName
{
    get
    {
        if (_champusSponsorName != null)
        {
            return _champusSponsorName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.9",
            Type = @"Field",
            Position = @"IN2.9",
            Name = @"Champus Sponsor Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.9.1",
                            Type = @"Component",
                            Position = @"IN2.9.1",
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
                            Id = @"IN2.9.2",
                            Type = @"Component",
                            Position = @"IN2.9.2",
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
                            Id = @"IN2.9.3",
                            Type = @"Component",
                            Position = @"IN2.9.3",
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
                            Id = @"IN2.9.4",
                            Type = @"Component",
                            Position = @"IN2.9.4",
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
                            Id = @"IN2.9.5",
                            Type = @"Component",
                            Position = @"IN2.9.5",
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
                            Id = @"IN2.9.6",
                            Type = @"Component",
                            Position = @"IN2.9.6",
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

        _champusSponsorName = new HL7V22Field
        {
            field = message[@"IN2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusSponsorName.field.FieldRepetitions != null && _champusSponsorName.field.FieldRepetitions.Count > 0)
        {
            _champusSponsorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusSponsorName, fieldData);
        }

        return _champusSponsorName;
    } 
}

internal HL7V22Field _champusIdNumber;

public HL7V22Field ChampusIdNumber
{
    get
    {
        if (_champusIdNumber != null)
        {
            return _champusIdNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.10",
            Type = @"Field",
            Position = @"IN2.10",
            Name = @"Champus Id Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"this field is defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _champusIdNumber = new HL7V22Field
        {
            field = message[@"IN2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusIdNumber.field.FieldRepetitions != null && _champusIdNumber.field.FieldRepetitions.Count > 0)
        {
            _champusIdNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusIdNumber, fieldData);
        }

        return _champusIdNumber;
    } 
}

internal HL7V22Field _dependentOfChampusRecipient;

public HL7V22Field DependentOfChampusRecipient
{
    get
    {
        if (_dependentOfChampusRecipient != null)
        {
            return _dependentOfChampusRecipient;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.11",
            Type = @"Field",
            Position = @"IN2.11",
            Name = @"Dependent Of Champus Recipient",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _dependentOfChampusRecipient = new HL7V22Field
        {
            field = message[@"IN2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dependentOfChampusRecipient.field.FieldRepetitions != null && _dependentOfChampusRecipient.field.FieldRepetitions.Count > 0)
        {
            _dependentOfChampusRecipient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dependentOfChampusRecipient, fieldData);
        }

        return _dependentOfChampusRecipient;
    } 
}

internal HL7V22Field _champusOrganization;

public HL7V22Field ChampusOrganization
{
    get
    {
        if (_champusOrganization != null)
        {
            return _champusOrganization;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.12",
            Type = @"Field",
            Position = @"IN2.12",
            Name = @"Champus Organization",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _champusOrganization = new HL7V22Field
        {
            field = message[@"IN2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusOrganization.field.FieldRepetitions != null && _champusOrganization.field.FieldRepetitions.Count > 0)
        {
            _champusOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusOrganization, fieldData);
        }

        return _champusOrganization;
    } 
}

internal HL7V22Field _champusStation;

public HL7V22Field ChampusStation
{
    get
    {
        if (_champusStation != null)
        {
            return _champusStation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.13",
            Type = @"Field",
            Position = @"IN2.13",
            Name = @"Champus Station",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _champusStation = new HL7V22Field
        {
            field = message[@"IN2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusStation.field.FieldRepetitions != null && _champusStation.field.FieldRepetitions.Count > 0)
        {
            _champusStation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusStation, fieldData);
        }

        return _champusStation;
    } 
}

internal HL7V22Field _champusService;

public HL7V22Field ChampusService
{
    get
    {
        if (_champusService != null)
        {
            return _champusService;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.14",
            Type = @"Field",
            Position = @"IN2.14",
            Name = @"Champus Service",
            Length = 14,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0140",
            TableName = @"CHAMPUS SERVICE",
            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0140 - Champus service for suggested values",
            Sample = @"",
            Fields = null
        }

        _champusService = new HL7V22Field
        {
            field = message[@"IN2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusService.field.FieldRepetitions != null && _champusService.field.FieldRepetitions.Count > 0)
        {
            _champusService.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusService, fieldData);
        }

        return _champusService;
    } 
}

internal HL7V22Field _champusRankGrade;

public HL7V22Field ChampusRankGrade
{
    get
    {
        if (_champusRankGrade != null)
        {
            return _champusRankGrade;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.15",
            Type = @"Field",
            Position = @"IN2.15",
            Name = @"Champus Rank / Grade",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0141",
            TableName = @"CHAMPUS RANK/GRADE",
            Description = @"This user-defined field identifies the CHAMPUS military rank/grade of the insured.  Refer to table 0141 - Champus rank/grade for suggested values",
            Sample = @"",
            Fields = null
        }

        _champusRankGrade = new HL7V22Field
        {
            field = message[@"IN2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusRankGrade.field.FieldRepetitions != null && _champusRankGrade.field.FieldRepetitions.Count > 0)
        {
            _champusRankGrade.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusRankGrade, fieldData);
        }

        return _champusRankGrade;
    } 
}

internal HL7V22Field _champusStatus;

public HL7V22Field ChampusStatus
{
    get
    {
        if (_champusStatus != null)
        {
            return _champusStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.16",
            Type = @"Field",
            Position = @"IN2.16",
            Name = @"Champus Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0142",
            TableName = @"CHAMPUS STATE",
            Description = @"defined by HCFA or other regulatory agencies.  Refer to table 0142 - Champus status for suggested values",
            Sample = @"",
            Fields = null
        }

        _champusStatus = new HL7V22Field
        {
            field = message[@"IN2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusStatus.field.FieldRepetitions != null && _champusStatus.field.FieldRepetitions.Count > 0)
        {
            _champusStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusStatus, fieldData);
        }

        return _champusStatus;
    } 
}

internal HL7V22Field _champusRetireDate;

public HL7V22Field ChampusRetireDate
{
    get
    {
        if (_champusRetireDate != null)
        {
            return _champusRetireDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.17",
            Type = @"Field",
            Position = @"IN2.17",
            Name = @"Champus Retire Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"defined by HCFA or other regulatory agencies",
            Sample = @"",
            Fields = null
        }

        _champusRetireDate = new HL7V22Field
        {
            field = message[@"IN2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusRetireDate.field.FieldRepetitions != null && _champusRetireDate.field.FieldRepetitions.Count > 0)
        {
            _champusRetireDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusRetireDate, fieldData);
        }

        return _champusRetireDate;
    } 
}

internal HL7V22Field _champusNonavailabilityCertificationOnFile;

public HL7V22Field ChampusNonavailabilityCertificationOnFile
{
    get
    {
        if (_champusNonavailabilityCertificationOnFile != null)
        {
            return _champusNonavailabilityCertificationOnFile;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.18",
            Type = @"Field",
            Position = @"IN2.18",
            Name = @"Champus Non-availability Certification On File",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
            Fields = null
        }

        _champusNonavailabilityCertificationOnFile = new HL7V22Field
        {
            field = message[@"IN2"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusNonavailabilityCertificationOnFile.field.FieldRepetitions != null && _champusNonavailabilityCertificationOnFile.field.FieldRepetitions.Count > 0)
        {
            _champusNonavailabilityCertificationOnFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_champusNonavailabilityCertificationOnFile, fieldData);
        }

        return _champusNonavailabilityCertificationOnFile;
    } 
}

internal HL7V22Field _babyCoverage;

public HL7V22Field BabyCoverage
{
    get
    {
        if (_babyCoverage != null)
        {
            return _babyCoverage;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.19",
            Type = @"Field",
            Position = @"IN2.19",
            Name = @"Baby Coverage",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
            Fields = null
        }

        _babyCoverage = new HL7V22Field
        {
            field = message[@"IN2"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_babyCoverage.field.FieldRepetitions != null && _babyCoverage.field.FieldRepetitions.Count > 0)
        {
            _babyCoverage.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_babyCoverage, fieldData);
        }

        return _babyCoverage;
    } 
}

internal HL7V22Field _combineBabyBill;

public HL7V22Field CombineBabyBill
{
    get
    {
        if (_combineBabyBill != null)
        {
            return _combineBabyBill;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.20",
            Type = @"Field",
            Position = @"IN2.20",
            Name = @"Combine Baby Bill",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"refer to table 0136 - Y/N indicator",
            Sample = @"",
            Fields = null
        }

        _combineBabyBill = new HL7V22Field
        {
            field = message[@"IN2"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_combineBabyBill.field.FieldRepetitions != null && _combineBabyBill.field.FieldRepetitions.Count > 0)
        {
            _combineBabyBill.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_combineBabyBill, fieldData);
        }

        return _combineBabyBill;
    } 
}

internal HL7V22Field _bloodDeductible;

public HL7V22Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.21",
            Type = @"Field",
            Position = @"IN2.21",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"it is recommended that this field be used instead of UB2-2-blood deductible as the blood deductible can be associated with the specific insurance plan via this field",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible = new HL7V22Field
        {
            field = message[@"IN2"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V22Field _specialCoverageApprovalName;

public HL7V22Field SpecialCoverageApprovalName
{
    get
    {
        if (_specialCoverageApprovalName != null)
        {
            return _specialCoverageApprovalName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.22",
            Type = @"Field",
            Position = @"IN2.22",
            Name = @"Special Coverage Approval Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the individual that approves any special coverage",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.22.1",
                            Type = @"Component",
                            Position = @"IN2.22.1",
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
                            Id = @"IN2.22.2",
                            Type = @"Component",
                            Position = @"IN2.22.2",
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
                            Id = @"IN2.22.3",
                            Type = @"Component",
                            Position = @"IN2.22.3",
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
                            Id = @"IN2.22.4",
                            Type = @"Component",
                            Position = @"IN2.22.4",
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
                            Id = @"IN2.22.5",
                            Type = @"Component",
                            Position = @"IN2.22.5",
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
                            Id = @"IN2.22.6",
                            Type = @"Component",
                            Position = @"IN2.22.6",
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

        _specialCoverageApprovalName = new HL7V22Field
        {
            field = message[@"IN2"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialCoverageApprovalName.field.FieldRepetitions != null && _specialCoverageApprovalName.field.FieldRepetitions.Count > 0)
        {
            _specialCoverageApprovalName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_specialCoverageApprovalName, fieldData);
        }

        return _specialCoverageApprovalName;
    } 
}

internal HL7V22Field _specialCoverageApprovalTitle;

public HL7V22Field SpecialCoverageApprovalTitle
{
    get
    {
        if (_specialCoverageApprovalTitle != null)
        {
            return _specialCoverageApprovalTitle;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.23",
            Type = @"Field",
            Position = @"IN2.23",
            Name = @"Special Coverage Approval Title",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"title of the person that approves special coverage",
            Sample = @"",
            Fields = null
        }

        _specialCoverageApprovalTitle = new HL7V22Field
        {
            field = message[@"IN2"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialCoverageApprovalTitle.field.FieldRepetitions != null && _specialCoverageApprovalTitle.field.FieldRepetitions.Count > 0)
        {
            _specialCoverageApprovalTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_specialCoverageApprovalTitle, fieldData);
        }

        return _specialCoverageApprovalTitle;
    } 
}

internal HL7V22Field _noncoveredInsuranceCode;

public HL7V22Field NoncoveredInsuranceCode
{
    get
    {
        if (_noncoveredInsuranceCode != null)
        {
            return _noncoveredInsuranceCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.24",
            Type = @"Field",
            Position = @"IN2.24",
            Name = @"Non-covered Insurance Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0143",
            TableName = @"NON-COVEREDINSURANCE CODE",
            Description = @"code which describes why a service is not covered.  Refer to user-defined table 0143 - non-covered insurance code for suggested values",
            Sample = @"",
            Fields = null
        }

        _noncoveredInsuranceCode = new HL7V22Field
        {
            field = message[@"IN2"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noncoveredInsuranceCode.field.FieldRepetitions != null && _noncoveredInsuranceCode.field.FieldRepetitions.Count > 0)
        {
            _noncoveredInsuranceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_noncoveredInsuranceCode, fieldData);
        }

        return _noncoveredInsuranceCode;
    } 
}

internal HL7V22Field _payorId;

public HL7V22Field PayorId
{
    get
    {
        if (_payorId != null)
        {
            return _payorId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.25",
            Type = @"Field",
            Position = @"IN2.25",
            Name = @"Payor Id",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"required for NEIC processing, identifies the organization from which reimbursement is expected",
            Sample = @"",
            Fields = null
        }

        _payorId = new HL7V22Field
        {
            field = message[@"IN2"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payorId.field.FieldRepetitions != null && _payorId.field.FieldRepetitions.Count > 0)
        {
            _payorId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_payorId, fieldData);
        }

        return _payorId;
    } 
}

internal HL7V22Field _payorSubscriberId;

public HL7V22Field PayorSubscriberId
{
    get
    {
        if (_payorSubscriberId != null)
        {
            return _payorSubscriberId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.26",
            Type = @"Field",
            Position = @"IN2.26",
            Name = @"Payor Subscriber Id",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"required for NEIC processing, identifies the specific office within the insurance carrier designated as responsible for the claim",
            Sample = @"",
            Fields = null
        }

        _payorSubscriberId = new HL7V22Field
        {
            field = message[@"IN2"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payorSubscriberId.field.FieldRepetitions != null && _payorSubscriberId.field.FieldRepetitions.Count > 0)
        {
            _payorSubscriberId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_payorSubscriberId, fieldData);
        }

        return _payorSubscriberId;
    } 
}

internal HL7V22Field _eligibilitySource;

public HL7V22Field EligibilitySource
{
    get
    {
        if (_eligibilitySource != null)
        {
            return _eligibilitySource;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.27",
            Type = @"Field",
            Position = @"IN2.27",
            Name = @"Eligibility Source",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0144",
            TableName = @"ELIGIBILITY SOURCE",
            Description = @"required for NEIC processing, identifies the source of information about the insured's eligibility for benefits.  Refer to user-defined table 0144 - eligibility source for suggested entries",
            Sample = @"",
            Fields = null
        }

        _eligibilitySource = new HL7V22Field
        {
            field = message[@"IN2"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eligibilitySource.field.FieldRepetitions != null && _eligibilitySource.field.FieldRepetitions.Count > 0)
        {
            _eligibilitySource.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_eligibilitySource, fieldData);
        }

        return _eligibilitySource;
    } 
}

internal HL7V22Field _roomCoverageTypeAmount;

public HL7V22Field RoomCoverageTypeAmount
{
    get
    {
        if (_roomCoverageTypeAmount != null)
        {
            return _roomCoverageTypeAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.28",
            Type = @"Field",
            Position = @"IN2.28",
            Name = @"Room Coverage Type / Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_RMC",
            DataTypeName = @"Room Coverage",
            TableId = null,
            TableName = null,
            Description = @"room type (e.g., private, semi-private) and amount (e.g., rate, percentage, differential) covered by the insurance.  It is recommended that this field be used instead of IN1-40-room rate - semi-private and IN141-room rate - private.  Refer to user-defined tables 0145 - room type and 0146 - amount type for suggested entries",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.28.1",
                            Type = @"Component",
                            Position = @"IN2.28.1",
                            Name = @"Room Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0145",
                            TableName = @"ROOM TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.2",
                            Type = @"Component",
                            Position = @"IN2.28.2",
                            Name = @"Amount Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0146",
                            TableName = @"AMOUNT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.3",
                            Type = @"Component",
                            Position = @"IN2.28.3",
                            Name = @"Coverage Amount",
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

        _roomCoverageTypeAmount = new HL7V22Field
        {
            field = message[@"IN2"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomCoverageTypeAmount.field.FieldRepetitions != null && _roomCoverageTypeAmount.field.FieldRepetitions.Count > 0)
        {
            _roomCoverageTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_roomCoverageTypeAmount, fieldData);
        }

        return _roomCoverageTypeAmount;
    } 
}

internal HL7V22Field _policyTypeAmount;

public HL7V22Field PolicyTypeAmount
{
    get
    {
        if (_policyTypeAmount != null)
        {
            return _policyTypeAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.29",
            Type = @"Field",
            Position = @"IN2.29",
            Name = @"Policy Type / Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PTA",
            DataTypeName = @"Policy Type",
            TableId = null,
            TableName = null,
            Description = @"policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  It is recommended that this field is used instead of IN1-38-policy limit - amount.  Refer to userdefined tables 0147 - policy type and 0193 - amount class for suggested entries",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.29.1",
                            Type = @"Component",
                            Position = @"IN2.29.1",
                            Name = @"Policy Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0147",
                            TableName = @"POLICY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.2",
                            Type = @"Component",
                            Position = @"IN2.29.2",
                            Name = @"Amount Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0193",
                            TableName = @"AMOUNT CLASS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.3",
                            Type = @"Component",
                            Position = @"IN2.29.3",
                            Name = @"Amount",
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

        _policyTypeAmount = new HL7V22Field
        {
            field = message[@"IN2"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyTypeAmount.field.FieldRepetitions != null && _policyTypeAmount.field.FieldRepetitions.Count > 0)
        {
            _policyTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_policyTypeAmount, fieldData);
        }

        return _policyTypeAmount;
    } 
}

internal HL7V22Field _dailyDeductible;

public HL7V22Field DailyDeductible
{
    get
    {
        if (_dailyDeductible != null)
        {
            return _dailyDeductible;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN2.30",
            Type = @"Field",
            Position = @"IN2.30",
            Name = @"Daily Deductible",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DDI",
            DataTypeName = @"Daily Deductible",
            TableId = null,
            TableName = null,
            Description = @"number of days after which to begin the daily deductible, the amount of the deductible, and the number of days to apply the deductible",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.30.1",
                            Type = @"Component",
                            Position = @"IN2.30.1",
                            Name = @"Delay Days",
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
                            Id = @"IN2.30.2",
                            Type = @"Component",
                            Position = @"IN2.30.2",
                            Name = @"Amount",
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
                            Id = @"IN2.30.3",
                            Type = @"Component",
                            Position = @"IN2.30.3",
                            Name = @"Number Of Days",
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

        _dailyDeductible = new HL7V22Field
        {
            field = message[@"IN2"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dailyDeductible.field.FieldRepetitions != null && _dailyDeductible.field.FieldRepetitions.Count > 0)
        {
            _dailyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dailyDeductible, fieldData);
        }

        return _dailyDeductible;
    } 
}
    }
}

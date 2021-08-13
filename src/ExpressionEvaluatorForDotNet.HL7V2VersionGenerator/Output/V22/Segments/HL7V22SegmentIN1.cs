using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentIN1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN1"; } }

        public string SegmentId { get { return @"IN1"; } }
        
        public string LongName { get { return @"Insurance"; } }
        
        public string Description { get { return @"The IN1 segment contains insurance policy coverage information necessary to produce properly pro-rated and patient and insurance bills."; } }
        
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

        public HL7V22SegmentIN1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdInsurance;

public HL7V22Field SetIdInsurance
{
    get
    {
        if (_setIdInsurance != null)
        {
            return _setIdInsurance;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.1",
            Type = @"Field",
            Position = @"IN1.1",
            Name = @"Set Id - Insurance",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"sequence number which uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction",
            Sample = @"",
            Fields = null
        }

        _setIdInsurance = new HL7V22Field
        {
            field = message[@"IN1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdInsurance.field.FieldRepetitions != null && _setIdInsurance.field.FieldRepetitions.Count > 0)
        {
            _setIdInsurance.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdInsurance, fieldData);
        }

        return _setIdInsurance;
    } 
}

internal HL7V22Field _insurancePlanId;

public HL7V22Field InsurancePlanId
{
    get
    {
        if (_insurancePlanId != null)
        {
            return _insurancePlanId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.2",
            Type = @"Field",
            Position = @"IN1.2",
            Name = @"Insurance Plan Id",
            Length = 8,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = @"uniquely identifies the insurance plan.  Refer to user-defined table 0072 - insurance plan ID.  To eliminate a plan, the plan could be sent with null values in each subsequent element.  If the respective systems can support it, a null value can be sent in the plan field",
            Sample = @"",
            Fields = null
        }

        _insurancePlanId = new HL7V22Field
        {
            field = message[@"IN1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanId.field.FieldRepetitions != null && _insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insurancePlanId, fieldData);
        }

        return _insurancePlanId;
    } 
}

internal HL7V22Field _insuranceCompanyId;

public HL7V22Field InsuranceCompanyId
{
    get
    {
        if (_insuranceCompanyId != null)
        {
            return _insuranceCompanyId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.3",
            Type = @"Field",
            Position = @"IN1.3",
            Name = @"Insurance Company Id",
            Length = 9,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the insurance company",
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyId = new HL7V22Field
        {
            field = message[@"IN1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyId.field.FieldRepetitions != null && _insuranceCompanyId.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceCompanyId, fieldData);
        }

        return _insuranceCompanyId;
    } 
}

internal HL7V22Field _insuranceCompanyName;

public HL7V22Field InsuranceCompanyName
{
    get
    {
        if (_insuranceCompanyName != null)
        {
            return _insuranceCompanyName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.4",
            Type = @"Field",
            Position = @"IN1.4",
            Name = @"Insurance Company Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the insurance company",
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyName = new HL7V22Field
        {
            field = message[@"IN1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyName.field.FieldRepetitions != null && _insuranceCompanyName.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceCompanyName, fieldData);
        }

        return _insuranceCompanyName;
    } 
}

internal HL7V22Field _insuranceCompanyAddress;

public HL7V22Field InsuranceCompanyAddress
{
    get
    {
        if (_insuranceCompanyAddress != null)
        {
            return _insuranceCompanyAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.5",
            Type = @"Field",
            Position = @"IN1.5",
            Name = @"Insurance Company Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"address of the insurance company",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.5.1",
                            Type = @"Component",
                            Position = @"IN1.5.1",
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
                            Id = @"IN1.5.2",
                            Type = @"Component",
                            Position = @"IN1.5.2",
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
                            Id = @"IN1.5.3",
                            Type = @"Component",
                            Position = @"IN1.5.3",
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
                            Id = @"IN1.5.4",
                            Type = @"Component",
                            Position = @"IN1.5.4",
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
                            Id = @"IN1.5.5",
                            Type = @"Component",
                            Position = @"IN1.5.5",
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
                            Id = @"IN1.5.6",
                            Type = @"Component",
                            Position = @"IN1.5.6",
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
                            Id = @"IN1.5.7",
                            Type = @"Component",
                            Position = @"IN1.5.7",
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
                            Id = @"IN1.5.8",
                            Type = @"Component",
                            Position = @"IN1.5.8",
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

        _insuranceCompanyAddress = new HL7V22Field
        {
            field = message[@"IN1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyAddress.field.FieldRepetitions != null && _insuranceCompanyAddress.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceCompanyAddress, fieldData);
        }

        return _insuranceCompanyAddress;
    } 
}

internal HL7V22Field _insuranceCompanyContactPers;

public HL7V22Field InsuranceCompanyContactPers
{
    get
    {
        if (_insuranceCompanyContactPers != null)
        {
            return _insuranceCompanyContactPers;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.6",
            Type = @"Field",
            Position = @"IN1.6",
            Name = @"Insurance Company Contact Pers",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the person who should be contacted at the insurance company",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.6.1",
                            Type = @"Component",
                            Position = @"IN1.6.1",
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
                            Id = @"IN1.6.2",
                            Type = @"Component",
                            Position = @"IN1.6.2",
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
                            Id = @"IN1.6.3",
                            Type = @"Component",
                            Position = @"IN1.6.3",
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
                            Id = @"IN1.6.4",
                            Type = @"Component",
                            Position = @"IN1.6.4",
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
                            Id = @"IN1.6.5",
                            Type = @"Component",
                            Position = @"IN1.6.5",
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
                            Id = @"IN1.6.6",
                            Type = @"Component",
                            Position = @"IN1.6.6",
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

        _insuranceCompanyContactPers = new HL7V22Field
        {
            field = message[@"IN1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyContactPers.field.FieldRepetitions != null && _insuranceCompanyContactPers.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyContactPers.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceCompanyContactPers, fieldData);
        }

        return _insuranceCompanyContactPers;
    } 
}

internal HL7V22Field _insuranceCompanyPhoneNumber;

public HL7V22Field InsuranceCompanyPhoneNumber
{
    get
    {
        if (_insuranceCompanyPhoneNumber != null)
        {
            return _insuranceCompanyPhoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.7",
            Type = @"Field",
            Position = @"IN1.7",
            Name = @"Insurance Company Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"phone number of the insurance company",
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyPhoneNumber = new HL7V22Field
        {
            field = message[@"IN1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyPhoneNumber.field.FieldRepetitions != null && _insuranceCompanyPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuranceCompanyPhoneNumber, fieldData);
        }

        return _insuranceCompanyPhoneNumber;
    } 
}

internal HL7V22Field _groupNumber;

public HL7V22Field GroupNumber
{
    get
    {
        if (_groupNumber != null)
        {
            return _groupNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.8",
            Type = @"Field",
            Position = @"IN1.8",
            Name = @"Group Number",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"group number of the insured's insurance",
            Sample = @"",
            Fields = null
        }

        _groupNumber = new HL7V22Field
        {
            field = message[@"IN1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupNumber.field.FieldRepetitions != null && _groupNumber.field.FieldRepetitions.Count > 0)
        {
            _groupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_groupNumber, fieldData);
        }

        return _groupNumber;
    } 
}

internal HL7V22Field _groupName;

public HL7V22Field GroupName
{
    get
    {
        if (_groupName != null)
        {
            return _groupName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.9",
            Type = @"Field",
            Position = @"IN1.9",
            Name = @"Group Name",
            Length = 35,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"group name of the insured's insurance",
            Sample = @"",
            Fields = null
        }

        _groupName = new HL7V22Field
        {
            field = message[@"IN1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupName.field.FieldRepetitions != null && _groupName.field.FieldRepetitions.Count > 0)
        {
            _groupName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_groupName, fieldData);
        }

        return _groupName;
    } 
}

internal HL7V22Field _insuredsGroupEmployerId;

public HL7V22Field InsuredsGroupEmployerId
{
    get
    {
        if (_insuredsGroupEmployerId != null)
        {
            return _insuredsGroupEmployerId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.10",
            Type = @"Field",
            Position = @"IN1.10",
            Name = @"Insured's Group Employer Id",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"group employer ID of the insured's insurance",
            Sample = @"",
            Fields = null
        }

        _insuredsGroupEmployerId = new HL7V22Field
        {
            field = message[@"IN1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsGroupEmployerId.field.FieldRepetitions != null && _insuredsGroupEmployerId.field.FieldRepetitions.Count > 0)
        {
            _insuredsGroupEmployerId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsGroupEmployerId, fieldData);
        }

        return _insuredsGroupEmployerId;
    } 
}

internal HL7V22Field _insuredsGroupEmployerName;

public HL7V22Field InsuredsGroupEmployerName
{
    get
    {
        if (_insuredsGroupEmployerName != null)
        {
            return _insuredsGroupEmployerName;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.11",
            Type = @"Field",
            Position = @"IN1.11",
            Name = @"Insured's Group Employer Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the employer which provides the employee's insurance",
            Sample = @"",
            Fields = null
        }

        _insuredsGroupEmployerName = new HL7V22Field
        {
            field = message[@"IN1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsGroupEmployerName.field.FieldRepetitions != null && _insuredsGroupEmployerName.field.FieldRepetitions.Count > 0)
        {
            _insuredsGroupEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsGroupEmployerName, fieldData);
        }

        return _insuredsGroupEmployerName;
    } 
}

internal HL7V22Field _planEffectiveDate;

public HL7V22Field PlanEffectiveDate
{
    get
    {
        if (_planEffectiveDate != null)
        {
            return _planEffectiveDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.12",
            Type = @"Field",
            Position = @"IN1.12",
            Name = @"Plan Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that the insurance goes into effect",
            Sample = @"",
            Fields = null
        }

        _planEffectiveDate = new HL7V22Field
        {
            field = message[@"IN1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planEffectiveDate.field.FieldRepetitions != null && _planEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _planEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_planEffectiveDate, fieldData);
        }

        return _planEffectiveDate;
    } 
}

internal HL7V22Field _planExpirationDate;

public HL7V22Field PlanExpirationDate
{
    get
    {
        if (_planExpirationDate != null)
        {
            return _planExpirationDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.13",
            Type = @"Field",
            Position = @"IN1.13",
            Name = @"Plan Expiration Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"last date of service that the insurance will cover or be responsible for",
            Sample = @"",
            Fields = null
        }

        _planExpirationDate = new HL7V22Field
        {
            field = message[@"IN1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planExpirationDate.field.FieldRepetitions != null && _planExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _planExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_planExpirationDate, fieldData);
        }

        return _planExpirationDate;
    } 
}

internal HL7V22Field _authorizationInformation;

public HL7V22Field AuthorizationInformation
{
    get
    {
        if (_authorizationInformation != null)
        {
            return _authorizationInformation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.14",
            Type = @"Field",
            Position = @"IN1.14",
            Name = @"Authorization Information",
            Length = 55,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_AUI",
            DataTypeName = @"Authorization Information",
            TableId = null,
            TableName = null,
            Description = @"based on the type of insurance, some coverages require that an authorization number or code be obtained prior to all non emergency admissions and within  48 hours of an emergency  admission.  Insurance billing would not be permitted without this number.  Date and source of authorization are sub-fields",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.14.1",
                            Type = @"Component",
                            Position = @"IN1.14.1",
                            Name = @"Authorization Number",
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
                            Id = @"IN1.14.2",
                            Type = @"Component",
                            Position = @"IN1.14.2",
                            Name = @"Date",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN1.14.3",
                            Type = @"Component",
                            Position = @"IN1.14.3",
                            Name = @"Source",
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

        _authorizationInformation = new HL7V22Field
        {
            field = message[@"IN1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationInformation.field.FieldRepetitions != null && _authorizationInformation.field.FieldRepetitions.Count > 0)
        {
            _authorizationInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_authorizationInformation, fieldData);
        }

        return _authorizationInformation;
    } 
}

internal HL7V22Field _planType;

public HL7V22Field PlanType
{
    get
    {
        if (_planType != null)
        {
            return _planType;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.15",
            Type = @"Field",
            Position = @"IN1.15",
            Name = @"Plan Type",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0086",
            TableName = @"INS. PLAN TYPE",
            Description = @"coding structure that identifies the various plan types.  Refer to user-defined table 0086 - plan ID",
            Sample = @"",
            Fields = null
        }

        _planType = new HL7V22Field
        {
            field = message[@"IN1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planType.field.FieldRepetitions != null && _planType.field.FieldRepetitions.Count > 0)
        {
            _planType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_planType, fieldData);
        }

        return _planType;
    } 
}

internal HL7V22Field _nameOfInsured;

public HL7V22Field NameOfInsured
{
    get
    {
        if (_nameOfInsured != null)
        {
            return _nameOfInsured;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.16",
            Type = @"Field",
            Position = @"IN1.16",
            Name = @"Name Of Insured",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = @"name of the insured person",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.16.1",
                            Type = @"Component",
                            Position = @"IN1.16.1",
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
                            Id = @"IN1.16.2",
                            Type = @"Component",
                            Position = @"IN1.16.2",
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
                            Id = @"IN1.16.3",
                            Type = @"Component",
                            Position = @"IN1.16.3",
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
                            Id = @"IN1.16.4",
                            Type = @"Component",
                            Position = @"IN1.16.4",
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
                            Id = @"IN1.16.5",
                            Type = @"Component",
                            Position = @"IN1.16.5",
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
                            Id = @"IN1.16.6",
                            Type = @"Component",
                            Position = @"IN1.16.6",
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

        _nameOfInsured = new HL7V22Field
        {
            field = message[@"IN1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nameOfInsured.field.FieldRepetitions != null && _nameOfInsured.field.FieldRepetitions.Count > 0)
        {
            _nameOfInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nameOfInsured, fieldData);
        }

        return _nameOfInsured;
    } 
}

internal HL7V22Field _insuredsRelationshipToPatient;

public HL7V22Field InsuredsRelationshipToPatient
{
    get
    {
        if (_insuredsRelationshipToPatient != null)
        {
            return _insuredsRelationshipToPatient;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.17",
            Type = @"Field",
            Position = @"IN1.17",
            Name = @"Insured's Relationship To Patient",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0063",
            TableName = @"RELATIONSHIP",
            Description = @"insured's relationship to the patient. Refer to user-defined table 0063 - relationship",
            Sample = @"",
            Fields = null
        }

        _insuredsRelationshipToPatient = new HL7V22Field
        {
            field = message[@"IN1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsRelationshipToPatient.field.FieldRepetitions != null && _insuredsRelationshipToPatient.field.FieldRepetitions.Count > 0)
        {
            _insuredsRelationshipToPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsRelationshipToPatient, fieldData);
        }

        return _insuredsRelationshipToPatient;
    } 
}

internal HL7V22Field _insuredsDateOfBirth;

public HL7V22Field InsuredsDateOfBirth
{
    get
    {
        if (_insuredsDateOfBirth != null)
        {
            return _insuredsDateOfBirth;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.18",
            Type = @"Field",
            Position = @"IN1.18",
            Name = @"Insured's Date Of Birth",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date of birth of insured",
            Sample = @"",
            Fields = null
        }

        _insuredsDateOfBirth = new HL7V22Field
        {
            field = message[@"IN1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsDateOfBirth.field.FieldRepetitions != null && _insuredsDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _insuredsDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsDateOfBirth, fieldData);
        }

        return _insuredsDateOfBirth;
    } 
}

internal HL7V22Field _insuredsAddress;

public HL7V22Field InsuredsAddress
{
    get
    {
        if (_insuredsAddress != null)
        {
            return _insuredsAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.19",
            Type = @"Field",
            Position = @"IN1.19",
            Name = @"Insured's Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"address of insured person",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.19.1",
                            Type = @"Component",
                            Position = @"IN1.19.1",
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
                            Id = @"IN1.19.2",
                            Type = @"Component",
                            Position = @"IN1.19.2",
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
                            Id = @"IN1.19.3",
                            Type = @"Component",
                            Position = @"IN1.19.3",
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
                            Id = @"IN1.19.4",
                            Type = @"Component",
                            Position = @"IN1.19.4",
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
                            Id = @"IN1.19.5",
                            Type = @"Component",
                            Position = @"IN1.19.5",
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
                            Id = @"IN1.19.6",
                            Type = @"Component",
                            Position = @"IN1.19.6",
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
                            Id = @"IN1.19.7",
                            Type = @"Component",
                            Position = @"IN1.19.7",
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
                            Id = @"IN1.19.8",
                            Type = @"Component",
                            Position = @"IN1.19.8",
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

        _insuredsAddress = new HL7V22Field
        {
            field = message[@"IN1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsAddress.field.FieldRepetitions != null && _insuredsAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsAddress, fieldData);
        }

        return _insuredsAddress;
    } 
}

internal HL7V22Field _assignmentOfBenefits;

public HL7V22Field AssignmentOfBenefits
{
    get
    {
        if (_assignmentOfBenefits != null)
        {
            return _assignmentOfBenefits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.20",
            Type = @"Field",
            Position = @"IN1.20",
            Name = @"Assignment Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0135",
            TableName = @"ASSIGNMENT OF BENEFITS",
            Description = @"has the insured agreed to assign the insurance benefits to the healthcare provider? If so, the insurance will pay the provider directly.  Refer to user-defined table 0135 - assignment of benefits for suggested values",
            Sample = @"",
            Fields = null
        }

        _assignmentOfBenefits = new HL7V22Field
        {
            field = message[@"IN1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignmentOfBenefits.field.FieldRepetitions != null && _assignmentOfBenefits.field.FieldRepetitions.Count > 0)
        {
            _assignmentOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_assignmentOfBenefits, fieldData);
        }

        return _assignmentOfBenefits;
    } 
}

internal HL7V22Field _coordinationOfBenefits;

public HL7V22Field CoordinationOfBenefits
{
    get
    {
        if (_coordinationOfBenefits != null)
        {
            return _coordinationOfBenefits;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.21",
            Type = @"Field",
            Position = @"IN1.21",
            Name = @"Coordination Of Benefits",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0173",
            TableName = @"COORDINATION OF BENEFITS",
            Description = @"does this insurance work in conjunction with other insurance plans, or does it provide independent coverage and payment of benefits regardless of other insurance that might be available to the patient?  Refer to user-defined table 0173 - coordination of benefits for suggested values",
            Sample = @"",
            Fields = null
        }

        _coordinationOfBenefits = new HL7V22Field
        {
            field = message[@"IN1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordinationOfBenefits.field.FieldRepetitions != null && _coordinationOfBenefits.field.FieldRepetitions.Count > 0)
        {
            _coordinationOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coordinationOfBenefits, fieldData);
        }

        return _coordinationOfBenefits;
    } 
}

internal HL7V22Field _coordinationOfBenefitsPriority;

public HL7V22Field CoordinationOfBenefitsPriority
{
    get
    {
        if (_coordinationOfBenefitsPriority != null)
        {
            return _coordinationOfBenefitsPriority;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.22",
            Type = @"Field",
            Position = @"IN1.22",
            Name = @"Coordination Of Benefits - Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"if the insurance works in conjunction with other insurance plans, what is priority sequence?  Values are: 1, 2, 3, etc",
            Sample = @"",
            Fields = null
        }

        _coordinationOfBenefitsPriority = new HL7V22Field
        {
            field = message[@"IN1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordinationOfBenefitsPriority.field.FieldRepetitions != null && _coordinationOfBenefitsPriority.field.FieldRepetitions.Count > 0)
        {
            _coordinationOfBenefitsPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_coordinationOfBenefitsPriority, fieldData);
        }

        return _coordinationOfBenefitsPriority;
    } 
}

internal HL7V22Field _noticeOfAdmissionCode;

public HL7V22Field NoticeOfAdmissionCode
{
    get
    {
        if (_noticeOfAdmissionCode != null)
        {
            return _noticeOfAdmissionCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.23",
            Type = @"Field",
            Position = @"IN1.23",
            Name = @"Notice Of Admission Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"does the insurance require a written notice of admission from the healthcare provider?  Refer to table 0136 - Y/N indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _noticeOfAdmissionCode = new HL7V22Field
        {
            field = message[@"IN1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeOfAdmissionCode.field.FieldRepetitions != null && _noticeOfAdmissionCode.field.FieldRepetitions.Count > 0)
        {
            _noticeOfAdmissionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_noticeOfAdmissionCode, fieldData);
        }

        return _noticeOfAdmissionCode;
    } 
}

internal HL7V22Field _noticeOfAdmissionDate;

public HL7V22Field NoticeOfAdmissionDate
{
    get
    {
        if (_noticeOfAdmissionDate != null)
        {
            return _noticeOfAdmissionDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.24",
            Type = @"Field",
            Position = @"IN1.24",
            Name = @"Notice Of Admission Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"if a notice is required, this is the date that it was sent",
            Sample = @"",
            Fields = null
        }

        _noticeOfAdmissionDate = new HL7V22Field
        {
            field = message[@"IN1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeOfAdmissionDate.field.FieldRepetitions != null && _noticeOfAdmissionDate.field.FieldRepetitions.Count > 0)
        {
            _noticeOfAdmissionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_noticeOfAdmissionDate, fieldData);
        }

        return _noticeOfAdmissionDate;
    } 
}

internal HL7V22Field _reportOfEligibilityCode;

public HL7V22Field ReportOfEligibilityCode
{
    get
    {
        if (_reportOfEligibilityCode != null)
        {
            return _reportOfEligibilityCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.25",
            Type = @"Field",
            Position = @"IN1.25",
            Name = @"Report Of Eligibility Code",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"does this insurance carrier send a report which indicates that the patient is eligible for benefits and identifies those benefits?  Refer to table 0136 - Y/N indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _reportOfEligibilityCode = new HL7V22Field
        {
            field = message[@"IN1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportOfEligibilityCode.field.FieldRepetitions != null && _reportOfEligibilityCode.field.FieldRepetitions.Count > 0)
        {
            _reportOfEligibilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_reportOfEligibilityCode, fieldData);
        }

        return _reportOfEligibilityCode;
    } 
}

internal HL7V22Field _reportOfEligibilityDate;

public HL7V22Field ReportOfEligibilityDate
{
    get
    {
        if (_reportOfEligibilityDate != null)
        {
            return _reportOfEligibilityDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.26",
            Type = @"Field",
            Position = @"IN1.26",
            Name = @"Report Of Eligibility Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"if a report of eligibility (ROE) was received, this indicates the date it was received",
            Sample = @"",
            Fields = null
        }

        _reportOfEligibilityDate = new HL7V22Field
        {
            field = message[@"IN1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reportOfEligibilityDate.field.FieldRepetitions != null && _reportOfEligibilityDate.field.FieldRepetitions.Count > 0)
        {
            _reportOfEligibilityDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_reportOfEligibilityDate, fieldData);
        }

        return _reportOfEligibilityDate;
    } 
}

internal HL7V22Field _releaseInformationCode;

public HL7V22Field ReleaseInformationCode
{
    get
    {
        if (_releaseInformationCode != null)
        {
            return _releaseInformationCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.27",
            Type = @"Field",
            Position = @"IN1.27",
            Name = @"Release Information Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0093",
            TableName = @"RELEASE OF INFORMATION",
            Description = @" can the healthcare provider release information about the patient, and what information can be released.  Refer to user-defined table 0093 - release information code for suggested values",
            Sample = @"",
            Fields = null
        }

        _releaseInformationCode = new HL7V22Field
        {
            field = message[@"IN1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_releaseInformationCode.field.FieldRepetitions != null && _releaseInformationCode.field.FieldRepetitions.Count > 0)
        {
            _releaseInformationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_releaseInformationCode, fieldData);
        }

        return _releaseInformationCode;
    } 
}

internal HL7V22Field _preadmitCertificationpac;

public HL7V22Field PreadmitCertificationpac
{
    get
    {
        if (_preadmitCertificationpac != null)
        {
            return _preadmitCertificationpac;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.28",
            Type = @"Field",
            Position = @"IN1.28",
            Name = @"Pre-admit Certification (pac)",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"pre-admission certification code.  If the admission must be certified before the admission, this is the code associated with the admission. ",
            Sample = @"",
            Fields = null
        }

        _preadmitCertificationpac = new HL7V22Field
        {
            field = message[@"IN1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitCertificationpac.field.FieldRepetitions != null && _preadmitCertificationpac.field.FieldRepetitions.Count > 0)
        {
            _preadmitCertificationpac.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_preadmitCertificationpac, fieldData);
        }

        return _preadmitCertificationpac;
    } 
}

internal HL7V22Field _verificationDateTime;

public HL7V22Field VerificationDateTime
{
    get
    {
        if (_verificationDateTime != null)
        {
            return _verificationDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.29",
            Type = @"Field",
            Position = @"IN1.29",
            Name = @"Verification Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time that the healthcare provider verified that the patient has the indicated benefits",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.29.1",
                            Type = @"Component",
                            Position = @"IN1.29.1",
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
                            Id = @"IN1.29.2",
                            Type = @"Component",
                            Position = @"IN1.29.2",
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

        _verificationDateTime = new HL7V22Field
        {
            field = message[@"IN1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationDateTime.field.FieldRepetitions != null && _verificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _verificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_verificationDateTime, fieldData);
        }

        return _verificationDateTime;
    } 
}

internal HL7V22Field _verificationBy;

public HL7V22Field VerificationBy
{
    get
    {
        if (_verificationBy != null)
        {
            return _verificationBy;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.30",
            Type = @"Field",
            Position = @"IN1.30",
            Name = @"Verification By",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"person that verified the benefits",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.30.1",
                            Type = @"Component",
                            Position = @"IN1.30.1",
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
                            Id = @"IN1.30.2",
                            Type = @"Component",
                            Position = @"IN1.30.2",
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
                            Id = @"IN1.30.3",
                            Type = @"Component",
                            Position = @"IN1.30.3",
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
                            Id = @"IN1.30.4",
                            Type = @"Component",
                            Position = @"IN1.30.4",
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
                            Id = @"IN1.30.5",
                            Type = @"Component",
                            Position = @"IN1.30.5",
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
                            Id = @"IN1.30.6",
                            Type = @"Component",
                            Position = @"IN1.30.6",
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
                            Id = @"IN1.30.7",
                            Type = @"Component",
                            Position = @"IN1.30.7",
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
                            Id = @"IN1.30.8",
                            Type = @"Component",
                            Position = @"IN1.30.8",
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

        _verificationBy = new HL7V22Field
        {
            field = message[@"IN1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationBy.field.FieldRepetitions != null && _verificationBy.field.FieldRepetitions.Count > 0)
        {
            _verificationBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_verificationBy, fieldData);
        }

        return _verificationBy;
    } 
}

internal HL7V22Field _typeOfAgreementCode;

public HL7V22Field TypeOfAgreementCode
{
    get
    {
        if (_typeOfAgreementCode != null)
        {
            return _typeOfAgreementCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.31",
            Type = @"Field",
            Position = @"IN1.31",
            Name = @"Type Of Agreement Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0098",
            TableName = @"TYPE OF AGREEMENT CODE",
            Description = @"used to further identify an insurance plan.  Refer to user-defined table 0098 - type of agreement code for suggested values.  Suggested values are standard, unified, or maternity",
            Sample = @"",
            Fields = null
        }

        _typeOfAgreementCode = new HL7V22Field
        {
            field = message[@"IN1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_typeOfAgreementCode.field.FieldRepetitions != null && _typeOfAgreementCode.field.FieldRepetitions.Count > 0)
        {
            _typeOfAgreementCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_typeOfAgreementCode, fieldData);
        }

        return _typeOfAgreementCode;
    } 
}

internal HL7V22Field _billingStatus;

public HL7V22Field BillingStatus
{
    get
    {
        if (_billingStatus != null)
        {
            return _billingStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.32",
            Type = @"Field",
            Position = @"IN1.32",
            Name = @"Billing Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0022",
            TableName = @"BILLING STATUS",
            Description = @"has the particular insurance been billed and if so, what type of bill.  Refer to user-defined table 0022 - billing status for suggested values",
            Sample = @"",
            Fields = null
        }

        _billingStatus = new HL7V22Field
        {
            field = message[@"IN1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_billingStatus.field.FieldRepetitions != null && _billingStatus.field.FieldRepetitions.Count > 0)
        {
            _billingStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_billingStatus, fieldData);
        }

        return _billingStatus;
    } 
}

internal HL7V22Field _lifetimeReserveDays;

public HL7V22Field LifetimeReserveDays
{
    get
    {
        if (_lifetimeReserveDays != null)
        {
            return _lifetimeReserveDays;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.33",
            Type = @"Field",
            Position = @"IN1.33",
            Name = @"Lifetime Reserve Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"number of days left where a certain service may be provided or covered under an insurance policy",
            Sample = @"",
            Fields = null
        }

        _lifetimeReserveDays = new HL7V22Field
        {
            field = message[@"IN1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lifetimeReserveDays.field.FieldRepetitions != null && _lifetimeReserveDays.field.FieldRepetitions.Count > 0)
        {
            _lifetimeReserveDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_lifetimeReserveDays, fieldData);
        }

        return _lifetimeReserveDays;
    } 
}

internal HL7V22Field _delayBeforeLifetimeReserveDays;

public HL7V22Field DelayBeforeLifetimeReserveDays
{
    get
    {
        if (_delayBeforeLifetimeReserveDays != null)
        {
            return _delayBeforeLifetimeReserveDays;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.34",
            Type = @"Field",
            Position = @"IN1.34",
            Name = @"Delay Before Lifetime Reserve Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"delay before lifetime reserve days",
            Sample = @"",
            Fields = null
        }

        _delayBeforeLifetimeReserveDays = new HL7V22Field
        {
            field = message[@"IN1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayBeforeLifetimeReserveDays.field.FieldRepetitions != null && _delayBeforeLifetimeReserveDays.field.FieldRepetitions.Count > 0)
        {
            _delayBeforeLifetimeReserveDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_delayBeforeLifetimeReserveDays, fieldData);
        }

        return _delayBeforeLifetimeReserveDays;
    } 
}

internal HL7V22Field _companyPlanCode;

public HL7V22Field CompanyPlanCode
{
    get
    {
        if (_companyPlanCode != null)
        {
            return _companyPlanCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.35",
            Type = @"Field",
            Position = @"IN1.35",
            Name = @"Company Plan Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0042",
            TableName = @"INS. COMPANY PLAN CODE",
            Description = @"Refer to user-defined table 0042 - company plan code.  This table contains codes used to uniquely identify an insurance plan.  Optional information to further define data in IN1-3-insurance company ID",
            Sample = @"",
            Fields = null
        }

        _companyPlanCode = new HL7V22Field
        {
            field = message[@"IN1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_companyPlanCode.field.FieldRepetitions != null && _companyPlanCode.field.FieldRepetitions.Count > 0)
        {
            _companyPlanCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_companyPlanCode, fieldData);
        }

        return _companyPlanCode;
    } 
}

internal HL7V22Field _policyNumber;

public HL7V22Field PolicyNumber
{
    get
    {
        if (_policyNumber != null)
        {
            return _policyNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.36",
            Type = @"Field",
            Position = @"IN1.36",
            Name = @"Policy Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"individual policy number of the insured",
            Sample = @"",
            Fields = null
        }

        _policyNumber = new HL7V22Field
        {
            field = message[@"IN1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyNumber.field.FieldRepetitions != null && _policyNumber.field.FieldRepetitions.Count > 0)
        {
            _policyNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_policyNumber, fieldData);
        }

        return _policyNumber;
    } 
}

internal HL7V22Field _policyDeductible;

public HL7V22Field PolicyDeductible
{
    get
    {
        if (_policyDeductible != null)
        {
            return _policyDeductible;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.37",
            Type = @"Field",
            Position = @"IN1.37",
            Name = @"Policy Deductible",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"amount specified by the insurance plan that is the responsibility of the guarantor",
            Sample = @"",
            Fields = null
        }

        _policyDeductible = new HL7V22Field
        {
            field = message[@"IN1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyDeductible.field.FieldRepetitions != null && _policyDeductible.field.FieldRepetitions.Count > 0)
        {
            _policyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_policyDeductible, fieldData);
        }

        return _policyDeductible;
    } 
}

internal HL7V22Field _policyLimitAmount;

public HL7V22Field PolicyLimitAmount
{
    get
    {
        if (_policyLimitAmount != null)
        {
            return _policyLimitAmount;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.38",
            Type = @"Field",
            Position = @"IN1.38",
            Name = @"Policy Limit - Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"maximum amount that the insurance policy will pay.  In some cases, the limit may be for a single encounter",
            Sample = @"",
            Fields = null
        }

        _policyLimitAmount = new HL7V22Field
        {
            field = message[@"IN1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitAmount.field.FieldRepetitions != null && _policyLimitAmount.field.FieldRepetitions.Count > 0)
        {
            _policyLimitAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_policyLimitAmount, fieldData);
        }

        return _policyLimitAmount;
    } 
}

internal HL7V22Field _policyLimitDays;

public HL7V22Field PolicyLimitDays
{
    get
    {
        if (_policyLimitDays != null)
        {
            return _policyLimitDays;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.39",
            Type = @"Field",
            Position = @"IN1.39",
            Name = @"Policy Limit - Days",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"maximum number of days that the insurance policy will cover",
            Sample = @"",
            Fields = null
        }

        _policyLimitDays = new HL7V22Field
        {
            field = message[@"IN1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitDays.field.FieldRepetitions != null && _policyLimitDays.field.FieldRepetitions.Count > 0)
        {
            _policyLimitDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_policyLimitDays, fieldData);
        }

        return _policyLimitDays;
    } 
}

internal HL7V22Field _roomRateSemiprivate;

public HL7V22Field RoomRateSemiprivate
{
    get
    {
        if (_roomRateSemiprivate != null)
        {
            return _roomRateSemiprivate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.40",
            Type = @"Field",
            Position = @"IN1.40",
            Name = @"Room Rate - Semi-private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"average room rate that the policy will cover.  It is recommended that IN2-28-room coverage type/amount be used instead of this field.  This field remains only for backward compatibility",
            Sample = @"",
            Fields = null
        }

        _roomRateSemiprivate = new HL7V22Field
        {
            field = message[@"IN1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRateSemiprivate.field.FieldRepetitions != null && _roomRateSemiprivate.field.FieldRepetitions.Count > 0)
        {
            _roomRateSemiprivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_roomRateSemiprivate, fieldData);
        }

        return _roomRateSemiprivate;
    } 
}

internal HL7V22Field _roomRatePrivate;

public HL7V22Field RoomRatePrivate
{
    get
    {
        if (_roomRatePrivate != null)
        {
            return _roomRatePrivate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.41",
            Type = @"Field",
            Position = @"IN1.41",
            Name = @"Room Rate - Private",
            Length = 12,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @" maximum private room rate the policy will cover.  It is recommended that IN2-28-room coverage type/amount be used instead of this field.  This field remains only for backward compatibility",
            Sample = @"",
            Fields = null
        }

        _roomRatePrivate = new HL7V22Field
        {
            field = message[@"IN1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRatePrivate.field.FieldRepetitions != null && _roomRatePrivate.field.FieldRepetitions.Count > 0)
        {
            _roomRatePrivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_roomRatePrivate, fieldData);
        }

        return _roomRatePrivate;
    } 
}

internal HL7V22Field _insuredsEmploymentStatus;

public HL7V22Field InsuredsEmploymentStatus
{
    get
    {
        if (_insuredsEmploymentStatus != null)
        {
            return _insuredsEmploymentStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.42",
            Type = @"Field",
            Position = @"IN1.42",
            Name = @"Insured's Employment Status",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = @"refer to user-defined table 0066 - employment status for valid codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.42.1",
                            Type = @"Component",
                            Position = @"IN1.42.1",
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
                            Id = @"IN1.42.2",
                            Type = @"Component",
                            Position = @"IN1.42.2",
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
                            Id = @"IN1.42.3",
                            Type = @"Component",
                            Position = @"IN1.42.3",
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
                            Id = @"IN1.42.4",
                            Type = @"Component",
                            Position = @"IN1.42.4",
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
                            Id = @"IN1.42.5",
                            Type = @"Component",
                            Position = @"IN1.42.5",
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
                            Id = @"IN1.42.6",
                            Type = @"Component",
                            Position = @"IN1.42.6",
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

        _insuredsEmploymentStatus = new HL7V22Field
        {
            field = message[@"IN1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmploymentStatus.field.FieldRepetitions != null && _insuredsEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsEmploymentStatus, fieldData);
        }

        return _insuredsEmploymentStatus;
    } 
}

internal HL7V22Field _insuredsSex;

public HL7V22Field InsuredsSex
{
    get
    {
        if (_insuredsSex != null)
        {
            return _insuredsSex;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.43",
            Type = @"Field",
            Position = @"IN1.43",
            Name = @"Insured's Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0001",
            TableName = @"SEX",
            Description = @"refer to table 0001 - sex for valid codes.",
            Sample = @"",
            Fields = null
        }

        _insuredsSex = new HL7V22Field
        {
            field = message[@"IN1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsSex.field.FieldRepetitions != null && _insuredsSex.field.FieldRepetitions.Count > 0)
        {
            _insuredsSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsSex, fieldData);
        }

        return _insuredsSex;
    } 
}

internal HL7V22Field _insuredsEmployerAddress;

public HL7V22Field InsuredsEmployerAddress
{
    get
    {
        if (_insuredsEmployerAddress != null)
        {
            return _insuredsEmployerAddress;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.44",
            Type = @"Field",
            Position = @"IN1.44",
            Name = @"Insured's Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"AD",
            DataTypeName = @"Address",
            TableId = null,
            TableName = null,
            Description = @"address of the insured employee",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN1.44.1",
                            Type = @"Component",
                            Position = @"IN1.44.1",
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
                            Id = @"IN1.44.2",
                            Type = @"Component",
                            Position = @"IN1.44.2",
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
                            Id = @"IN1.44.3",
                            Type = @"Component",
                            Position = @"IN1.44.3",
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
                            Id = @"IN1.44.4",
                            Type = @"Component",
                            Position = @"IN1.44.4",
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
                            Id = @"IN1.44.5",
                            Type = @"Component",
                            Position = @"IN1.44.5",
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
                            Id = @"IN1.44.6",
                            Type = @"Component",
                            Position = @"IN1.44.6",
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
                            Id = @"IN1.44.7",
                            Type = @"Component",
                            Position = @"IN1.44.7",
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
                            Id = @"IN1.44.8",
                            Type = @"Component",
                            Position = @"IN1.44.8",
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

        _insuredsEmployerAddress = new HL7V22Field
        {
            field = message[@"IN1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerAddress.field.FieldRepetitions != null && _insuredsEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_insuredsEmployerAddress, fieldData);
        }

        return _insuredsEmployerAddress;
    } 
}

internal HL7V22Field _verificationStatus;

public HL7V22Field VerificationStatus
{
    get
    {
        if (_verificationStatus != null)
        {
            return _verificationStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.45",
            Type = @"Field",
            Position = @"IN1.45",
            Name = @"Verification Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"status of this patient's relationship with this insurance carrier",
            Sample = @"",
            Fields = null
        }

        _verificationStatus = new HL7V22Field
        {
            field = message[@"IN1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationStatus.field.FieldRepetitions != null && _verificationStatus.field.FieldRepetitions.Count > 0)
        {
            _verificationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_verificationStatus, fieldData);
        }

        return _verificationStatus;
    } 
}

internal HL7V22Field _priorInsurancePlanId;

public HL7V22Field PriorInsurancePlanId
{
    get
    {
        if (_priorInsurancePlanId != null)
        {
            return _priorInsurancePlanId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN1.46",
            Type = @"Field",
            Position = @"IN1.46",
            Name = @"Prior Insurance Plan Id",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0072",
            TableName = @"INS. PLAN ID",
            Description = @"uniquely identifies the prior insurance plan when the plan ID changes.  Refer to user-defined table 0072 - insurance plan ID",
            Sample = @"",
            Fields = null
        }

        _priorInsurancePlanId = new HL7V22Field
        {
            field = message[@"IN1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorInsurancePlanId.field.FieldRepetitions != null && _priorInsurancePlanId.field.FieldRepetitions.Count > 0)
        {
            _priorInsurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_priorInsurancePlanId, fieldData);
        }

        return _priorInsurancePlanId;
    } 
}
    }
}

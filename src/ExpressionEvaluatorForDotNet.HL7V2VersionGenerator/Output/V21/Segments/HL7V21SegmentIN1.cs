using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentIN1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN1"; } }

        public string SegmentId { get { return @"IN1"; } }
        
        public string LongName { get { return @"Insurance"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentIN1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdInsurance;

public HL7V21Field SetIdInsurance
{
    get
    {
        if (_setIdInsurance != null)
        {
            return _setIdInsurance;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.1",
            Type = @"Field",
            Position = @"IN1.1",
            Name = @"Set Id - Insurance",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Set Id",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _setIdInsurance = new HL7V21Field
        {
            field = message[@"IN1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdInsurance.field.FieldRepetitions != null && _setIdInsurance.field.FieldRepetitions.Count > 0)
        {
            _setIdInsurance.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdInsurance, fieldData);
        }

        return _setIdInsurance;
    } 
}

internal HL7V21Field _insurancePlanId;

public HL7V21Field InsurancePlanId
{
    get
    {
        if (_insurancePlanId != null)
        {
            return _insurancePlanId;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insurancePlanId = new HL7V21Field
        {
            field = message[@"IN1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insurancePlanId.field.FieldRepetitions != null && _insurancePlanId.field.FieldRepetitions.Count > 0)
        {
            _insurancePlanId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insurancePlanId, fieldData);
        }

        return _insurancePlanId;
    } 
}

internal HL7V21Field _insuranceCompanyId;

public HL7V21Field InsuranceCompanyId
{
    get
    {
        if (_insuranceCompanyId != null)
        {
            return _insuranceCompanyId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.3",
            Type = @"Field",
            Position = @"IN1.3",
            Name = @"Insurance Company Id",
            Length = 6,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyId = new HL7V21Field
        {
            field = message[@"IN1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyId.field.FieldRepetitions != null && _insuranceCompanyId.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceCompanyId, fieldData);
        }

        return _insuranceCompanyId;
    } 
}

internal HL7V21Field _insuranceCompanyName;

public HL7V21Field InsuranceCompanyName
{
    get
    {
        if (_insuranceCompanyName != null)
        {
            return _insuranceCompanyName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyName = new HL7V21Field
        {
            field = message[@"IN1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyName.field.FieldRepetitions != null && _insuranceCompanyName.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceCompanyName, fieldData);
        }

        return _insuranceCompanyName;
    } 
}

internal HL7V21Field _insuranceCompanyAddress;

public HL7V21Field InsuranceCompanyAddress
{
    get
    {
        if (_insuranceCompanyAddress != null)
        {
            return _insuranceCompanyAddress;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyAddress = new HL7V21Field
        {
            field = message[@"IN1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyAddress.field.FieldRepetitions != null && _insuranceCompanyAddress.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceCompanyAddress, fieldData);
        }

        return _insuranceCompanyAddress;
    } 
}

internal HL7V21Field _insuranceCoContactPers;

public HL7V21Field InsuranceCoContactPers
{
    get
    {
        if (_insuranceCoContactPers != null)
        {
            return _insuranceCoContactPers;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.6",
            Type = @"Field",
            Position = @"IN1.6",
            Name = @"Insurance Co. Contact Pers",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"PN",
            DataTypeName = @"Person Name",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuranceCoContactPers = new HL7V21Field
        {
            field = message[@"IN1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCoContactPers.field.FieldRepetitions != null && _insuranceCoContactPers.field.FieldRepetitions.Count > 0)
        {
            _insuranceCoContactPers.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceCoContactPers, fieldData);
        }

        return _insuranceCoContactPers;
    } 
}

internal HL7V21Field _insuranceCoPhoneNumber;

public HL7V21Field InsuranceCoPhoneNumber
{
    get
    {
        if (_insuranceCoPhoneNumber != null)
        {
            return _insuranceCoPhoneNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.7",
            Type = @"Field",
            Position = @"IN1.7",
            Name = @"Insurance Co Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuranceCoPhoneNumber = new HL7V21Field
        {
            field = message[@"IN1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCoPhoneNumber.field.FieldRepetitions != null && _insuranceCoPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuranceCoPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuranceCoPhoneNumber, fieldData);
        }

        return _insuranceCoPhoneNumber;
    } 
}

internal HL7V21Field _groupNumber;

public HL7V21Field GroupNumber
{
    get
    {
        if (_groupNumber != null)
        {
            return _groupNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _groupNumber = new HL7V21Field
        {
            field = message[@"IN1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupNumber.field.FieldRepetitions != null && _groupNumber.field.FieldRepetitions.Count > 0)
        {
            _groupNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_groupNumber, fieldData);
        }

        return _groupNumber;
    } 
}

internal HL7V21Field _groupName;

public HL7V21Field GroupName
{
    get
    {
        if (_groupName != null)
        {
            return _groupName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _groupName = new HL7V21Field
        {
            field = message[@"IN1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupName.field.FieldRepetitions != null && _groupName.field.FieldRepetitions.Count > 0)
        {
            _groupName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_groupName, fieldData);
        }

        return _groupName;
    } 
}

internal HL7V21Field _insuredsGroupEmpId;

public HL7V21Field InsuredsGroupEmpId
{
    get
    {
        if (_insuredsGroupEmpId != null)
        {
            return _insuredsGroupEmpId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.10",
            Type = @"Field",
            Position = @"IN1.10",
            Name = @"Insured's Group Emp. Id",
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

        _insuredsGroupEmpId = new HL7V21Field
        {
            field = message[@"IN1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsGroupEmpId.field.FieldRepetitions != null && _insuredsGroupEmpId.field.FieldRepetitions.Count > 0)
        {
            _insuredsGroupEmpId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsGroupEmpId, fieldData);
        }

        return _insuredsGroupEmpId;
    } 
}

internal HL7V21Field _insuredsGroupEmpName;

public HL7V21Field InsuredsGroupEmpName
{
    get
    {
        if (_insuredsGroupEmpName != null)
        {
            return _insuredsGroupEmpName;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.11",
            Type = @"Field",
            Position = @"IN1.11",
            Name = @"Insured's Group Emp. Name",
            Length = 45,
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

        _insuredsGroupEmpName = new HL7V21Field
        {
            field = message[@"IN1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsGroupEmpName.field.FieldRepetitions != null && _insuredsGroupEmpName.field.FieldRepetitions.Count > 0)
        {
            _insuredsGroupEmpName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsGroupEmpName, fieldData);
        }

        return _insuredsGroupEmpName;
    } 
}

internal HL7V21Field _planEffectiveDate;

public HL7V21Field PlanEffectiveDate
{
    get
    {
        if (_planEffectiveDate != null)
        {
            return _planEffectiveDate;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _planEffectiveDate = new HL7V21Field
        {
            field = message[@"IN1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planEffectiveDate.field.FieldRepetitions != null && _planEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _planEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_planEffectiveDate, fieldData);
        }

        return _planEffectiveDate;
    } 
}

internal HL7V21Field _planExpirationDate;

public HL7V21Field PlanExpirationDate
{
    get
    {
        if (_planExpirationDate != null)
        {
            return _planExpirationDate;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _planExpirationDate = new HL7V21Field
        {
            field = message[@"IN1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planExpirationDate.field.FieldRepetitions != null && _planExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _planExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_planExpirationDate, fieldData);
        }

        return _planExpirationDate;
    } 
}

internal HL7V21Field _authorizationInformation;

public HL7V21Field AuthorizationInformation
{
    get
    {
        if (_authorizationInformation != null)
        {
            return _authorizationInformation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.14",
            Type = @"Field",
            Position = @"IN1.14",
            Name = @"Authorization Information",
            Length = 55,
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

        _authorizationInformation = new HL7V21Field
        {
            field = message[@"IN1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationInformation.field.FieldRepetitions != null && _authorizationInformation.field.FieldRepetitions.Count > 0)
        {
            _authorizationInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_authorizationInformation, fieldData);
        }

        return _authorizationInformation;
    } 
}

internal HL7V21Field _planType;

public HL7V21Field PlanType
{
    get
    {
        if (_planType != null)
        {
            return _planType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.15",
            Type = @"Field",
            Position = @"IN1.15",
            Name = @"Plan Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0086",
            TableName = @"INS. PLAN TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _planType = new HL7V21Field
        {
            field = message[@"IN1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_planType.field.FieldRepetitions != null && _planType.field.FieldRepetitions.Count > 0)
        {
            _planType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_planType, fieldData);
        }

        return _planType;
    } 
}

internal HL7V21Field _nameOfInsured;

public HL7V21Field NameOfInsured
{
    get
    {
        if (_nameOfInsured != null)
        {
            return _nameOfInsured;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _nameOfInsured = new HL7V21Field
        {
            field = message[@"IN1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nameOfInsured.field.FieldRepetitions != null && _nameOfInsured.field.FieldRepetitions.Count > 0)
        {
            _nameOfInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_nameOfInsured, fieldData);
        }

        return _nameOfInsured;
    } 
}

internal HL7V21Field _insuredsRelationshipToPatient;

public HL7V21Field InsuredsRelationshipToPatient
{
    get
    {
        if (_insuredsRelationshipToPatient != null)
        {
            return _insuredsRelationshipToPatient;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsRelationshipToPatient = new HL7V21Field
        {
            field = message[@"IN1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsRelationshipToPatient.field.FieldRepetitions != null && _insuredsRelationshipToPatient.field.FieldRepetitions.Count > 0)
        {
            _insuredsRelationshipToPatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsRelationshipToPatient, fieldData);
        }

        return _insuredsRelationshipToPatient;
    } 
}

internal HL7V21Field _insuredsDateOfBirth;

public HL7V21Field InsuredsDateOfBirth
{
    get
    {
        if (_insuredsDateOfBirth != null)
        {
            return _insuredsDateOfBirth;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsDateOfBirth = new HL7V21Field
        {
            field = message[@"IN1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsDateOfBirth.field.FieldRepetitions != null && _insuredsDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _insuredsDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsDateOfBirth, fieldData);
        }

        return _insuredsDateOfBirth;
    } 
}

internal HL7V21Field _insuredsAddress;

public HL7V21Field InsuredsAddress
{
    get
    {
        if (_insuredsAddress != null)
        {
            return _insuredsAddress;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsAddress = new HL7V21Field
        {
            field = message[@"IN1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsAddress.field.FieldRepetitions != null && _insuredsAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsAddress, fieldData);
        }

        return _insuredsAddress;
    } 
}

internal HL7V21Field _assignmentOfBenefits;

public HL7V21Field AssignmentOfBenefits
{
    get
    {
        if (_assignmentOfBenefits != null)
        {
            return _assignmentOfBenefits;
        }

        var fieldData = new HL7V21FieldData
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
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _assignmentOfBenefits = new HL7V21Field
        {
            field = message[@"IN1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignmentOfBenefits.field.FieldRepetitions != null && _assignmentOfBenefits.field.FieldRepetitions.Count > 0)
        {
            _assignmentOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_assignmentOfBenefits, fieldData);
        }

        return _assignmentOfBenefits;
    } 
}

internal HL7V21Field _coordinationOfBenefits;

public HL7V21Field CoordinationOfBenefits
{
    get
    {
        if (_coordinationOfBenefits != null)
        {
            return _coordinationOfBenefits;
        }

        var fieldData = new HL7V21FieldData
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
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _coordinationOfBenefits = new HL7V21Field
        {
            field = message[@"IN1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordinationOfBenefits.field.FieldRepetitions != null && _coordinationOfBenefits.field.FieldRepetitions.Count > 0)
        {
            _coordinationOfBenefits.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_coordinationOfBenefits, fieldData);
        }

        return _coordinationOfBenefits;
    } 
}

internal HL7V21Field _coordOfBenPriority;

public HL7V21Field CoordOfBenPriority
{
    get
    {
        if (_coordOfBenPriority != null)
        {
            return _coordOfBenPriority;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.22",
            Type = @"Field",
            Position = @"IN1.22",
            Name = @"Coord Of Ben. Priority",
            Length = 2,
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

        _coordOfBenPriority = new HL7V21Field
        {
            field = message[@"IN1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coordOfBenPriority.field.FieldRepetitions != null && _coordOfBenPriority.field.FieldRepetitions.Count > 0)
        {
            _coordOfBenPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_coordOfBenPriority, fieldData);
        }

        return _coordOfBenPriority;
    } 
}

internal HL7V21Field _noticeOfAdmissionCode;

public HL7V21Field NoticeOfAdmissionCode
{
    get
    {
        if (_noticeOfAdmissionCode != null)
        {
            return _noticeOfAdmissionCode;
        }

        var fieldData = new HL7V21FieldData
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
            TableId = @"0081",
            TableName = @"NOTICE OF ADMISSION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _noticeOfAdmissionCode = new HL7V21Field
        {
            field = message[@"IN1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeOfAdmissionCode.field.FieldRepetitions != null && _noticeOfAdmissionCode.field.FieldRepetitions.Count > 0)
        {
            _noticeOfAdmissionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_noticeOfAdmissionCode, fieldData);
        }

        return _noticeOfAdmissionCode;
    } 
}

internal HL7V21Field _noticeOfAdmissionDate;

public HL7V21Field NoticeOfAdmissionDate
{
    get
    {
        if (_noticeOfAdmissionDate != null)
        {
            return _noticeOfAdmissionDate;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _noticeOfAdmissionDate = new HL7V21Field
        {
            field = message[@"IN1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_noticeOfAdmissionDate.field.FieldRepetitions != null && _noticeOfAdmissionDate.field.FieldRepetitions.Count > 0)
        {
            _noticeOfAdmissionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_noticeOfAdmissionDate, fieldData);
        }

        return _noticeOfAdmissionDate;
    } 
}

internal HL7V21Field _rptOfEligibilityCode;

public HL7V21Field RptOfEligibilityCode
{
    get
    {
        if (_rptOfEligibilityCode != null)
        {
            return _rptOfEligibilityCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.25",
            Type = @"Field",
            Position = @"IN1.25",
            Name = @"Rpt Of Eligibility Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0094",
            TableName = @"REPORT OF ELIGIBILITY",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _rptOfEligibilityCode = new HL7V21Field
        {
            field = message[@"IN1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rptOfEligibilityCode.field.FieldRepetitions != null && _rptOfEligibilityCode.field.FieldRepetitions.Count > 0)
        {
            _rptOfEligibilityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rptOfEligibilityCode, fieldData);
        }

        return _rptOfEligibilityCode;
    } 
}

internal HL7V21Field _rptOfEligibilityDate;

public HL7V21Field RptOfEligibilityDate
{
    get
    {
        if (_rptOfEligibilityDate != null)
        {
            return _rptOfEligibilityDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.26",
            Type = @"Field",
            Position = @"IN1.26",
            Name = @"Rpt Of Eligibility Date",
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

        _rptOfEligibilityDate = new HL7V21Field
        {
            field = message[@"IN1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rptOfEligibilityDate.field.FieldRepetitions != null && _rptOfEligibilityDate.field.FieldRepetitions.Count > 0)
        {
            _rptOfEligibilityDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_rptOfEligibilityDate, fieldData);
        }

        return _rptOfEligibilityDate;
    } 
}

internal HL7V21Field _releaseInformationCode;

public HL7V21Field ReleaseInformationCode
{
    get
    {
        if (_releaseInformationCode != null)
        {
            return _releaseInformationCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _releaseInformationCode = new HL7V21Field
        {
            field = message[@"IN1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_releaseInformationCode.field.FieldRepetitions != null && _releaseInformationCode.field.FieldRepetitions.Count > 0)
        {
            _releaseInformationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_releaseInformationCode, fieldData);
        }

        return _releaseInformationCode;
    } 
}

internal HL7V21Field _preadmitCertpac;

public HL7V21Field PreadmitCertpac
{
    get
    {
        if (_preadmitCertpac != null)
        {
            return _preadmitCertpac;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.28",
            Type = @"Field",
            Position = @"IN1.28",
            Name = @"Pre-admit Cert. (pac)",
            Length = 15,
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

        _preadmitCertpac = new HL7V21Field
        {
            field = message[@"IN1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitCertpac.field.FieldRepetitions != null && _preadmitCertpac.field.FieldRepetitions.Count > 0)
        {
            _preadmitCertpac.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_preadmitCertpac, fieldData);
        }

        return _preadmitCertpac;
    } 
}

internal HL7V21Field _verificationDate;

public HL7V21Field VerificationDate
{
    get
    {
        if (_verificationDate != null)
        {
            return _verificationDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.29",
            Type = @"Field",
            Position = @"IN1.29",
            Name = @"Verification Date",
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

        _verificationDate = new HL7V21Field
        {
            field = message[@"IN1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationDate.field.FieldRepetitions != null && _verificationDate.field.FieldRepetitions.Count > 0)
        {
            _verificationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_verificationDate, fieldData);
        }

        return _verificationDate;
    } 
}

internal HL7V21Field _verificationBy;

public HL7V21Field VerificationBy
{
    get
    {
        if (_verificationBy != null)
        {
            return _verificationBy;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.30",
            Type = @"Field",
            Position = @"IN1.30",
            Name = @"Verification By",
            Length = 60,
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

        _verificationBy = new HL7V21Field
        {
            field = message[@"IN1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_verificationBy.field.FieldRepetitions != null && _verificationBy.field.FieldRepetitions.Count > 0)
        {
            _verificationBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_verificationBy, fieldData);
        }

        return _verificationBy;
    } 
}

internal HL7V21Field _typeOfAgreementCode;

public HL7V21Field TypeOfAgreementCode
{
    get
    {
        if (_typeOfAgreementCode != null)
        {
            return _typeOfAgreementCode;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _typeOfAgreementCode = new HL7V21Field
        {
            field = message[@"IN1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_typeOfAgreementCode.field.FieldRepetitions != null && _typeOfAgreementCode.field.FieldRepetitions.Count > 0)
        {
            _typeOfAgreementCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_typeOfAgreementCode, fieldData);
        }

        return _typeOfAgreementCode;
    } 
}

internal HL7V21Field _billingStatus;

public HL7V21Field BillingStatus
{
    get
    {
        if (_billingStatus != null)
        {
            return _billingStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _billingStatus = new HL7V21Field
        {
            field = message[@"IN1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_billingStatus.field.FieldRepetitions != null && _billingStatus.field.FieldRepetitions.Count > 0)
        {
            _billingStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_billingStatus, fieldData);
        }

        return _billingStatus;
    } 
}

internal HL7V21Field _lifetimeReserveDays;

public HL7V21Field LifetimeReserveDays
{
    get
    {
        if (_lifetimeReserveDays != null)
        {
            return _lifetimeReserveDays;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _lifetimeReserveDays = new HL7V21Field
        {
            field = message[@"IN1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lifetimeReserveDays.field.FieldRepetitions != null && _lifetimeReserveDays.field.FieldRepetitions.Count > 0)
        {
            _lifetimeReserveDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_lifetimeReserveDays, fieldData);
        }

        return _lifetimeReserveDays;
    } 
}

internal HL7V21Field _delayBeforeLRDay;

public HL7V21Field DelayBeforeLRDay
{
    get
    {
        if (_delayBeforeLRDay != null)
        {
            return _delayBeforeLRDay;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.34",
            Type = @"Field",
            Position = @"IN1.34",
            Name = @"Delay Before L. R. Day",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _delayBeforeLRDay = new HL7V21Field
        {
            field = message[@"IN1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_delayBeforeLRDay.field.FieldRepetitions != null && _delayBeforeLRDay.field.FieldRepetitions.Count > 0)
        {
            _delayBeforeLRDay.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_delayBeforeLRDay, fieldData);
        }

        return _delayBeforeLRDay;
    } 
}

internal HL7V21Field _companyPlanCode;

public HL7V21Field CompanyPlanCode
{
    get
    {
        if (_companyPlanCode != null)
        {
            return _companyPlanCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.35",
            Type = @"Field",
            Position = @"IN1.35",
            Name = @"Company Plan Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0042",
            TableName = @"INS. COMPANY PLAN CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _companyPlanCode = new HL7V21Field
        {
            field = message[@"IN1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_companyPlanCode.field.FieldRepetitions != null && _companyPlanCode.field.FieldRepetitions.Count > 0)
        {
            _companyPlanCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_companyPlanCode, fieldData);
        }

        return _companyPlanCode;
    } 
}

internal HL7V21Field _policyNumber;

public HL7V21Field PolicyNumber
{
    get
    {
        if (_policyNumber != null)
        {
            return _policyNumber;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _policyNumber = new HL7V21Field
        {
            field = message[@"IN1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyNumber.field.FieldRepetitions != null && _policyNumber.field.FieldRepetitions.Count > 0)
        {
            _policyNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_policyNumber, fieldData);
        }

        return _policyNumber;
    } 
}

internal HL7V21Field _policyDeductible;

public HL7V21Field PolicyDeductible
{
    get
    {
        if (_policyDeductible != null)
        {
            return _policyDeductible;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _policyDeductible = new HL7V21Field
        {
            field = message[@"IN1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyDeductible.field.FieldRepetitions != null && _policyDeductible.field.FieldRepetitions.Count > 0)
        {
            _policyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_policyDeductible, fieldData);
        }

        return _policyDeductible;
    } 
}

internal HL7V21Field _policyLimitAmount;

public HL7V21Field PolicyLimitAmount
{
    get
    {
        if (_policyLimitAmount != null)
        {
            return _policyLimitAmount;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _policyLimitAmount = new HL7V21Field
        {
            field = message[@"IN1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitAmount.field.FieldRepetitions != null && _policyLimitAmount.field.FieldRepetitions.Count > 0)
        {
            _policyLimitAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_policyLimitAmount, fieldData);
        }

        return _policyLimitAmount;
    } 
}

internal HL7V21Field _policyLimitDays;

public HL7V21Field PolicyLimitDays
{
    get
    {
        if (_policyLimitDays != null)
        {
            return _policyLimitDays;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _policyLimitDays = new HL7V21Field
        {
            field = message[@"IN1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyLimitDays.field.FieldRepetitions != null && _policyLimitDays.field.FieldRepetitions.Count > 0)
        {
            _policyLimitDays.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_policyLimitDays, fieldData);
        }

        return _policyLimitDays;
    } 
}

internal HL7V21Field _roomRateSemiprivate;

public HL7V21Field RoomRateSemiprivate
{
    get
    {
        if (_roomRateSemiprivate != null)
        {
            return _roomRateSemiprivate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.40",
            Type = @"Field",
            Position = @"IN1.40",
            Name = @"Room Rate - Semi-private",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _roomRateSemiprivate = new HL7V21Field
        {
            field = message[@"IN1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRateSemiprivate.field.FieldRepetitions != null && _roomRateSemiprivate.field.FieldRepetitions.Count > 0)
        {
            _roomRateSemiprivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_roomRateSemiprivate, fieldData);
        }

        return _roomRateSemiprivate;
    } 
}

internal HL7V21Field _roomRatePrivate;

public HL7V21Field RoomRatePrivate
{
    get
    {
        if (_roomRatePrivate != null)
        {
            return _roomRatePrivate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.41",
            Type = @"Field",
            Position = @"IN1.41",
            Name = @"Room Rate - Private",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _roomRatePrivate = new HL7V21Field
        {
            field = message[@"IN1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomRatePrivate.field.FieldRepetitions != null && _roomRatePrivate.field.FieldRepetitions.Count > 0)
        {
            _roomRatePrivate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_roomRatePrivate, fieldData);
        }

        return _roomRatePrivate;
    } 
}

internal HL7V21Field _insuredsEmploymentStatus;

public HL7V21Field InsuredsEmploymentStatus
{
    get
    {
        if (_insuredsEmploymentStatus != null)
        {
            return _insuredsEmploymentStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"IN1.42",
            Type = @"Field",
            Position = @"IN1.42",
            Name = @"Insured's Employment Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0066",
            TableName = @"EMPLOYMENT STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsEmploymentStatus = new HL7V21Field
        {
            field = message[@"IN1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmploymentStatus.field.FieldRepetitions != null && _insuredsEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsEmploymentStatus, fieldData);
        }

        return _insuredsEmploymentStatus;
    } 
}

internal HL7V21Field _insuredsSex;

public HL7V21Field InsuredsSex
{
    get
    {
        if (_insuredsSex != null)
        {
            return _insuredsSex;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsSex = new HL7V21Field
        {
            field = message[@"IN1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsSex.field.FieldRepetitions != null && _insuredsSex.field.FieldRepetitions.Count > 0)
        {
            _insuredsSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsSex, fieldData);
        }

        return _insuredsSex;
    } 
}

internal HL7V21Field _insuredsEmployerAddress;

public HL7V21Field InsuredsEmployerAddress
{
    get
    {
        if (_insuredsEmployerAddress != null)
        {
            return _insuredsEmployerAddress;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _insuredsEmployerAddress = new HL7V21Field
        {
            field = message[@"IN1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerAddress.field.FieldRepetitions != null && _insuredsEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_insuredsEmployerAddress, fieldData);
        }

        return _insuredsEmployerAddress;
    } 
}
    }
}

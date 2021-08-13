using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdGuarantor;

public HL7V21Field SetIdGuarantor
{
    get
    {
        if (_setIdGuarantor != null)
        {
            return _setIdGuarantor;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set Id - Guarantor",
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

        _setIdGuarantor = new HL7V21Field
        {
            field = message[@"GT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdGuarantor.field.FieldRepetitions != null && _setIdGuarantor.field.FieldRepetitions.Count > 0)
        {
            _setIdGuarantor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdGuarantor, fieldData);
        }

        return _setIdGuarantor;
    } 
}

internal HL7V21Field _guarantorNumber;

public HL7V21Field GuarantorNumber
{
    get
    {
        if (_guarantorNumber != null)
        {
            return _guarantorNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.2",
            Type = @"Field",
            Position = @"GT1.2",
            Name = @"Guarantor Number",
            Length = 20,
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

        _guarantorNumber = new HL7V21Field
        {
            field = message[@"GT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorNumber.field.FieldRepetitions != null && _guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorNumber, fieldData);
        }

        return _guarantorNumber;
    } 
}

internal HL7V21Field _guarantorName;

public HL7V21Field GuarantorName
{
    get
    {
        if (_guarantorName != null)
        {
            return _guarantorName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorName = new HL7V21Field
        {
            field = message[@"GT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorName.field.FieldRepetitions != null && _guarantorName.field.FieldRepetitions.Count > 0)
        {
            _guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorName, fieldData);
        }

        return _guarantorName;
    } 
}

internal HL7V21Field _guarantorSpouseName;

public HL7V21Field GuarantorSpouseName
{
    get
    {
        if (_guarantorSpouseName != null)
        {
            return _guarantorSpouseName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorSpouseName = new HL7V21Field
        {
            field = message[@"GT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSpouseName.field.FieldRepetitions != null && _guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            _guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorSpouseName, fieldData);
        }

        return _guarantorSpouseName;
    } 
}

internal HL7V21Field _guarantorAddress;

public HL7V21Field GuarantorAddress
{
    get
    {
        if (_guarantorAddress != null)
        {
            return _guarantorAddress;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorAddress = new HL7V21Field
        {
            field = message[@"GT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorAddress.field.FieldRepetitions != null && _guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorAddress, fieldData);
        }

        return _guarantorAddress;
    } 
}

internal HL7V21Field _guarantorPhNumHome;

public HL7V21Field GuarantorPhNumHome
{
    get
    {
        if (_guarantorPhNumHome != null)
        {
            return _guarantorPhNumHome;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Ph. Num.- Home",
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

        _guarantorPhNumHome = new HL7V21Field
        {
            field = message[@"GT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumHome.field.FieldRepetitions != null && _guarantorPhNumHome.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorPhNumHome, fieldData);
        }

        return _guarantorPhNumHome;
    } 
}

internal HL7V21Field _guarantorPhNumbusiness;

public HL7V21Field GuarantorPhNumbusiness
{
    get
    {
        if (_guarantorPhNumbusiness != null)
        {
            return _guarantorPhNumbusiness;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.7",
            Type = @"Field",
            Position = @"GT1.7",
            Name = @"Guarantor Ph. Num-business",
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

        _guarantorPhNumbusiness = new HL7V21Field
        {
            field = message[@"GT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumbusiness.field.FieldRepetitions != null && _guarantorPhNumbusiness.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumbusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorPhNumbusiness, fieldData);
        }

        return _guarantorPhNumbusiness;
    } 
}

internal HL7V21Field _guarantorDateOfBirth;

public HL7V21Field GuarantorDateOfBirth
{
    get
    {
        if (_guarantorDateOfBirth != null)
        {
            return _guarantorDateOfBirth;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorDateOfBirth = new HL7V21Field
        {
            field = message[@"GT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateOfBirth.field.FieldRepetitions != null && _guarantorDateOfBirth.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorDateOfBirth, fieldData);
        }

        return _guarantorDateOfBirth;
    } 
}

internal HL7V21Field _guarantorSex;

public HL7V21Field GuarantorSex
{
    get
    {
        if (_guarantorSex != null)
        {
            return _guarantorSex;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorSex = new HL7V21Field
        {
            field = message[@"GT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSex.field.FieldRepetitions != null && _guarantorSex.field.FieldRepetitions.Count > 0)
        {
            _guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorSex, fieldData);
        }

        return _guarantorSex;
    } 
}

internal HL7V21Field _guarantorType;

public HL7V21Field GuarantorType
{
    get
    {
        if (_guarantorType != null)
        {
            return _guarantorType;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorType = new HL7V21Field
        {
            field = message[@"GT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorType.field.FieldRepetitions != null && _guarantorType.field.FieldRepetitions.Count > 0)
        {
            _guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorType, fieldData);
        }

        return _guarantorType;
    } 
}

internal HL7V21Field _guarantorRelationship;

public HL7V21Field GuarantorRelationship
{
    get
    {
        if (_guarantorRelationship != null)
        {
            return _guarantorRelationship;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorRelationship = new HL7V21Field
        {
            field = message[@"GT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRelationship.field.FieldRepetitions != null && _guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            _guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorRelationship, fieldData);
        }

        return _guarantorRelationship;
    } 
}

internal HL7V21Field _guarantorSsn;

public HL7V21Field GuarantorSsn
{
    get
    {
        if (_guarantorSsn != null)
        {
            return _guarantorSsn;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.12",
            Type = @"Field",
            Position = @"GT1.12",
            Name = @"Guarantor Ssn",
            Length = 11,
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

        _guarantorSsn = new HL7V21Field
        {
            field = message[@"GT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSsn.field.FieldRepetitions != null && _guarantorSsn.field.FieldRepetitions.Count > 0)
        {
            _guarantorSsn.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorSsn, fieldData);
        }

        return _guarantorSsn;
    } 
}

internal HL7V21Field _guarantorDateBegin;

public HL7V21Field GuarantorDateBegin
{
    get
    {
        if (_guarantorDateBegin != null)
        {
            return _guarantorDateBegin;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorDateBegin = new HL7V21Field
        {
            field = message[@"GT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateBegin.field.FieldRepetitions != null && _guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorDateBegin, fieldData);
        }

        return _guarantorDateBegin;
    } 
}

internal HL7V21Field _guarantorDateEnd;

public HL7V21Field GuarantorDateEnd
{
    get
    {
        if (_guarantorDateEnd != null)
        {
            return _guarantorDateEnd;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorDateEnd = new HL7V21Field
        {
            field = message[@"GT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateEnd.field.FieldRepetitions != null && _guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorDateEnd, fieldData);
        }

        return _guarantorDateEnd;
    } 
}

internal HL7V21Field _guarantorPriority;

public HL7V21Field GuarantorPriority
{
    get
    {
        if (_guarantorPriority != null)
        {
            return _guarantorPriority;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorPriority = new HL7V21Field
        {
            field = message[@"GT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPriority.field.FieldRepetitions != null && _guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            _guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorPriority, fieldData);
        }

        return _guarantorPriority;
    } 
}

internal HL7V21Field _guarantorEmployerName;

public HL7V21Field GuarantorEmployerName
{
    get
    {
        if (_guarantorEmployerName != null)
        {
            return _guarantorEmployerName;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorEmployerName = new HL7V21Field
        {
            field = message[@"GT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerName.field.FieldRepetitions != null && _guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorEmployerName, fieldData);
        }

        return _guarantorEmployerName;
    } 
}

internal HL7V21Field _guarantorEmployerAddress;

public HL7V21Field GuarantorEmployerAddress
{
    get
    {
        if (_guarantorEmployerAddress != null)
        {
            return _guarantorEmployerAddress;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorEmployerAddress = new HL7V21Field
        {
            field = message[@"GT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerAddress.field.FieldRepetitions != null && _guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorEmployerAddress, fieldData);
        }

        return _guarantorEmployerAddress;
    } 
}

internal HL7V21Field _guarantorEmployPhone#;

public HL7V21Field GuarantorEmployPhone#
{
    get
    {
        if (_guarantorEmployPhone# != null)
        {
            return _guarantorEmployPhone#;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employ Phone #",
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

        _guarantorEmployPhone# = new HL7V21Field
        {
            field = message[@"GT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployPhone#.field.FieldRepetitions != null && _guarantorEmployPhone#.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployPhone#.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorEmployPhone#, fieldData);
        }

        return _guarantorEmployPhone#;
    } 
}

internal HL7V21Field _guarantorEmployeeIdNum;

public HL7V21Field GuarantorEmployeeIdNum
{
    get
    {
        if (_guarantorEmployeeIdNum != null)
        {
            return _guarantorEmployeeIdNum;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"GT1.19",
            Type = @"Field",
            Position = @"GT1.19",
            Name = @"Guarantor Employee Id Num",
            Length = 20,
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

        _guarantorEmployeeIdNum = new HL7V21Field
        {
            field = message[@"GT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployeeIdNum.field.FieldRepetitions != null && _guarantorEmployeeIdNum.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployeeIdNum.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorEmployeeIdNum, fieldData);
        }

        return _guarantorEmployeeIdNum;
    } 
}

internal HL7V21Field _guarantorEmploymentStatus;

public HL7V21Field GuarantorEmploymentStatus
{
    get
    {
        if (_guarantorEmploymentStatus != null)
        {
            return _guarantorEmploymentStatus;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _guarantorEmploymentStatus = new HL7V21Field
        {
            field = message[@"GT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmploymentStatus.field.FieldRepetitions != null && _guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_guarantorEmploymentStatus, fieldData);
        }

        return _guarantorEmploymentStatus;
    } 
}
    }
}

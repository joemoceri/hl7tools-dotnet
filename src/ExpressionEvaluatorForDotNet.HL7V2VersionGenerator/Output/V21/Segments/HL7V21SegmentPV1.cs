using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentPV1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PV1"; } }

        public string SegmentId { get { return @"PV1"; } }
        
        public string LongName { get { return @"Patient Visit"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentPV1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _setIdPatientVisit;

public HL7V21Field SetIdPatientVisit
{
    get
    {
        if (_setIdPatientVisit != null)
        {
            return _setIdPatientVisit;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.1",
            Type = @"Field",
            Position = @"PV1.1",
            Name = @"Set Id - Patient Visit",
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

        _setIdPatientVisit = new HL7V21Field
        {
            field = message[@"PV1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdPatientVisit.field.FieldRepetitions != null && _setIdPatientVisit.field.FieldRepetitions.Count > 0)
        {
            _setIdPatientVisit.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_setIdPatientVisit, fieldData);
        }

        return _setIdPatientVisit;
    } 
}

internal HL7V21Field _patientClass;

public HL7V21Field PatientClass
{
    get
    {
        if (_patientClass != null)
        {
            return _patientClass;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.2",
            Type = @"Field",
            Position = @"PV1.2",
            Name = @"Patient Class",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0004",
            TableName = @"PATIENT CLASS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientClass = new HL7V21Field
        {
            field = message[@"PV1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientClass.field.FieldRepetitions != null && _patientClass.field.FieldRepetitions.Count > 0)
        {
            _patientClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientClass, fieldData);
        }

        return _patientClass;
    } 
}

internal HL7V21Field _assignedPatientLocation;

public HL7V21Field AssignedPatientLocation
{
    get
    {
        if (_assignedPatientLocation != null)
        {
            return _assignedPatientLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.3",
            Type = @"Field",
            Position = @"PV1.3",
            Name = @"Assigned Patient Location",
            Length = 12,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _assignedPatientLocation = new HL7V21Field
        {
            field = message[@"PV1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignedPatientLocation.field.FieldRepetitions != null && _assignedPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _assignedPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_assignedPatientLocation, fieldData);
        }

        return _assignedPatientLocation;
    } 
}

internal HL7V21Field _admissionType;

public HL7V21Field AdmissionType
{
    get
    {
        if (_admissionType != null)
        {
            return _admissionType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.4",
            Type = @"Field",
            Position = @"PV1.4",
            Name = @"Admission Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0007",
            TableName = @"ADMISSION TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _admissionType = new HL7V21Field
        {
            field = message[@"PV1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admissionType.field.FieldRepetitions != null && _admissionType.field.FieldRepetitions.Count > 0)
        {
            _admissionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_admissionType, fieldData);
        }

        return _admissionType;
    } 
}

internal HL7V21Field _preadmitNumber;

public HL7V21Field PreadmitNumber
{
    get
    {
        if (_preadmitNumber != null)
        {
            return _preadmitNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.5",
            Type = @"Field",
            Position = @"PV1.5",
            Name = @"Pre-admit Number",
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

        _preadmitNumber = new HL7V21Field
        {
            field = message[@"PV1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitNumber.field.FieldRepetitions != null && _preadmitNumber.field.FieldRepetitions.Count > 0)
        {
            _preadmitNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_preadmitNumber, fieldData);
        }

        return _preadmitNumber;
    } 
}

internal HL7V21Field _priorPatientLocation;

public HL7V21Field PriorPatientLocation
{
    get
    {
        if (_priorPatientLocation != null)
        {
            return _priorPatientLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.6",
            Type = @"Field",
            Position = @"PV1.6",
            Name = @"Prior Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priorPatientLocation = new HL7V21Field
        {
            field = message[@"PV1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPatientLocation.field.FieldRepetitions != null && _priorPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _priorPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priorPatientLocation, fieldData);
        }

        return _priorPatientLocation;
    } 
}

internal HL7V21Field _attendingDoctor;

public HL7V21Field AttendingDoctor
{
    get
    {
        if (_attendingDoctor != null)
        {
            return _attendingDoctor;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.7",
            Type = @"Field",
            Position = @"PV1.7",
            Name = @"Attending Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _attendingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_attendingDoctor.field.FieldRepetitions != null && _attendingDoctor.field.FieldRepetitions.Count > 0)
        {
            _attendingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_attendingDoctor, fieldData);
        }

        return _attendingDoctor;
    } 
}

internal HL7V21Field _referringDoctor;

public HL7V21Field ReferringDoctor
{
    get
    {
        if (_referringDoctor != null)
        {
            return _referringDoctor;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.8",
            Type = @"Field",
            Position = @"PV1.8",
            Name = @"Referring Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _referringDoctor = new HL7V21Field
        {
            field = message[@"PV1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referringDoctor.field.FieldRepetitions != null && _referringDoctor.field.FieldRepetitions.Count > 0)
        {
            _referringDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_referringDoctor, fieldData);
        }

        return _referringDoctor;
    } 
}

internal HL7V21Field _consultingDoctor;

public HL7V21Field ConsultingDoctor
{
    get
    {
        if (_consultingDoctor != null)
        {
            return _consultingDoctor;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.9",
            Type = @"Field",
            Position = @"PV1.9",
            Name = @"Consulting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _consultingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consultingDoctor.field.FieldRepetitions != null && _consultingDoctor.field.FieldRepetitions.Count > 0)
        {
            _consultingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_consultingDoctor, fieldData);
        }

        return _consultingDoctor;
    } 
}

internal HL7V21Field _hospitalService;

public HL7V21Field HospitalService
{
    get
    {
        if (_hospitalService != null)
        {
            return _hospitalService;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.10",
            Type = @"Field",
            Position = @"PV1.10",
            Name = @"Hospital Service",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0069",
            TableName = @"HOSPITAL SERVICE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _hospitalService = new HL7V21Field
        {
            field = message[@"PV1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hospitalService.field.FieldRepetitions != null && _hospitalService.field.FieldRepetitions.Count > 0)
        {
            _hospitalService.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_hospitalService, fieldData);
        }

        return _hospitalService;
    } 
}

internal HL7V21Field _temporaryLocation;

public HL7V21Field TemporaryLocation
{
    get
    {
        if (_temporaryLocation != null)
        {
            return _temporaryLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.11",
            Type = @"Field",
            Position = @"PV1.11",
            Name = @"Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _temporaryLocation = new HL7V21Field
        {
            field = message[@"PV1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_temporaryLocation.field.FieldRepetitions != null && _temporaryLocation.field.FieldRepetitions.Count > 0)
        {
            _temporaryLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_temporaryLocation, fieldData);
        }

        return _temporaryLocation;
    } 
}

internal HL7V21Field _preadmitTestIndicator;

public HL7V21Field PreadmitTestIndicator
{
    get
    {
        if (_preadmitTestIndicator != null)
        {
            return _preadmitTestIndicator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.12",
            Type = @"Field",
            Position = @"PV1.12",
            Name = @"Pre-admit Test Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0087",
            TableName = @"PRE-ADMIT TESTING",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _preadmitTestIndicator = new HL7V21Field
        {
            field = message[@"PV1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitTestIndicator.field.FieldRepetitions != null && _preadmitTestIndicator.field.FieldRepetitions.Count > 0)
        {
            _preadmitTestIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_preadmitTestIndicator, fieldData);
        }

        return _preadmitTestIndicator;
    } 
}

internal HL7V21Field _readmissionIndicator;

public HL7V21Field ReadmissionIndicator
{
    get
    {
        if (_readmissionIndicator != null)
        {
            return _readmissionIndicator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.13",
            Type = @"Field",
            Position = @"PV1.13",
            Name = @"Re-admission Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0092",
            TableName = @"RE-ADMISSION INDICATOR",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _readmissionIndicator = new HL7V21Field
        {
            field = message[@"PV1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_readmissionIndicator.field.FieldRepetitions != null && _readmissionIndicator.field.FieldRepetitions.Count > 0)
        {
            _readmissionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_readmissionIndicator, fieldData);
        }

        return _readmissionIndicator;
    } 
}

internal HL7V21Field _admitSource;

public HL7V21Field AdmitSource
{
    get
    {
        if (_admitSource != null)
        {
            return _admitSource;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.14",
            Type = @"Field",
            Position = @"PV1.14",
            Name = @"Admit Source",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0023",
            TableName = @"ADMIT SOURCE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _admitSource = new HL7V21Field
        {
            field = message[@"PV1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitSource.field.FieldRepetitions != null && _admitSource.field.FieldRepetitions.Count > 0)
        {
            _admitSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_admitSource, fieldData);
        }

        return _admitSource;
    } 
}

internal HL7V21Field _ambulatoryStatus;

public HL7V21Field AmbulatoryStatus
{
    get
    {
        if (_ambulatoryStatus != null)
        {
            return _ambulatoryStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.15",
            Type = @"Field",
            Position = @"PV1.15",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0009",
            TableName = @"AMBULATORY STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatus = new HL7V21Field
        {
            field = message[@"PV1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatus.field.FieldRepetitions != null && _ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_ambulatoryStatus, fieldData);
        }

        return _ambulatoryStatus;
    } 
}

internal HL7V21Field _vipIndicator;

public HL7V21Field VipIndicator
{
    get
    {
        if (_vipIndicator != null)
        {
            return _vipIndicator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.16",
            Type = @"Field",
            Position = @"PV1.16",
            Name = @"Vip Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0099",
            TableName = @"VIP INDICATOR",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _vipIndicator = new HL7V21Field
        {
            field = message[@"PV1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vipIndicator.field.FieldRepetitions != null && _vipIndicator.field.FieldRepetitions.Count > 0)
        {
            _vipIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_vipIndicator, fieldData);
        }

        return _vipIndicator;
    } 
}

internal HL7V21Field _admittingDoctor;

public HL7V21Field AdmittingDoctor
{
    get
    {
        if (_admittingDoctor != null)
        {
            return _admittingDoctor;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.17",
            Type = @"Field",
            Position = @"PV1.17",
            Name = @"Admitting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN",
            DataTypeName = @"Composite Id Number And Name",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _admittingDoctor = new HL7V21Field
        {
            field = message[@"PV1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admittingDoctor.field.FieldRepetitions != null && _admittingDoctor.field.FieldRepetitions.Count > 0)
        {
            _admittingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_admittingDoctor, fieldData);
        }

        return _admittingDoctor;
    } 
}

internal HL7V21Field _patientType;

public HL7V21Field PatientType
{
    get
    {
        if (_patientType != null)
        {
            return _patientType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.18",
            Type = @"Field",
            Position = @"PV1.18",
            Name = @"Patient Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0018",
            TableName = @"PATIENT TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _patientType = new HL7V21Field
        {
            field = message[@"PV1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientType.field.FieldRepetitions != null && _patientType.field.FieldRepetitions.Count > 0)
        {
            _patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_patientType, fieldData);
        }

        return _patientType;
    } 
}

internal HL7V21Field _visitNumber;

public HL7V21Field VisitNumber
{
    get
    {
        if (_visitNumber != null)
        {
            return _visitNumber;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.19",
            Type = @"Field",
            Position = @"PV1.19",
            Name = @"Visit Number",
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

        _visitNumber = new HL7V21Field
        {
            field = message[@"PV1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitNumber.field.FieldRepetitions != null && _visitNumber.field.FieldRepetitions.Count > 0)
        {
            _visitNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_visitNumber, fieldData);
        }

        return _visitNumber;
    } 
}

internal HL7V21Field _financialClass;

public HL7V21Field FinancialClass
{
    get
    {
        if (_financialClass != null)
        {
            return _financialClass;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.20",
            Type = @"Field",
            Position = @"PV1.20",
            Name = @"Financial Class",
            Length = 11,
            Usage = @"O",
            Rpt = @"4",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0064",
            TableName = @"FINANCIAL CLASS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _financialClass = new HL7V21Field
        {
            field = message[@"PV1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_financialClass.field.FieldRepetitions != null && _financialClass.field.FieldRepetitions.Count > 0)
        {
            _financialClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_financialClass, fieldData);
        }

        return _financialClass;
    } 
}

internal HL7V21Field _chargePriceIndicator;

public HL7V21Field ChargePriceIndicator
{
    get
    {
        if (_chargePriceIndicator != null)
        {
            return _chargePriceIndicator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.21",
            Type = @"Field",
            Position = @"PV1.21",
            Name = @"Charge Price Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0032",
            TableName = @"CHARGE/PRICE INDICATOR",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _chargePriceIndicator = new HL7V21Field
        {
            field = message[@"PV1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargePriceIndicator.field.FieldRepetitions != null && _chargePriceIndicator.field.FieldRepetitions.Count > 0)
        {
            _chargePriceIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_chargePriceIndicator, fieldData);
        }

        return _chargePriceIndicator;
    } 
}

internal HL7V21Field _courtesyCode;

public HL7V21Field CourtesyCode
{
    get
    {
        if (_courtesyCode != null)
        {
            return _courtesyCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.22",
            Type = @"Field",
            Position = @"PV1.22",
            Name = @"Courtesy Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0045",
            TableName = @"COURTESY CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _courtesyCode = new HL7V21Field
        {
            field = message[@"PV1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_courtesyCode.field.FieldRepetitions != null && _courtesyCode.field.FieldRepetitions.Count > 0)
        {
            _courtesyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_courtesyCode, fieldData);
        }

        return _courtesyCode;
    } 
}

internal HL7V21Field _creditRating;

public HL7V21Field CreditRating
{
    get
    {
        if (_creditRating != null)
        {
            return _creditRating;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.23",
            Type = @"Field",
            Position = @"PV1.23",
            Name = @"Credit Rating",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0046",
            TableName = @"CREDIT RATING",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _creditRating = new HL7V21Field
        {
            field = message[@"PV1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_creditRating.field.FieldRepetitions != null && _creditRating.field.FieldRepetitions.Count > 0)
        {
            _creditRating.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_creditRating, fieldData);
        }

        return _creditRating;
    } 
}

internal HL7V21Field _contractCode;

public HL7V21Field ContractCode
{
    get
    {
        if (_contractCode != null)
        {
            return _contractCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.24",
            Type = @"Field",
            Position = @"PV1.24",
            Name = @"Contract Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0044",
            TableName = @"CONTRACT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _contractCode = new HL7V21Field
        {
            field = message[@"PV1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractCode.field.FieldRepetitions != null && _contractCode.field.FieldRepetitions.Count > 0)
        {
            _contractCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_contractCode, fieldData);
        }

        return _contractCode;
    } 
}

internal HL7V21Field _contractEffectiveDate;

public HL7V21Field ContractEffectiveDate
{
    get
    {
        if (_contractEffectiveDate != null)
        {
            return _contractEffectiveDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.25",
            Type = @"Field",
            Position = @"PV1.25",
            Name = @"Contract Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _contractEffectiveDate = new HL7V21Field
        {
            field = message[@"PV1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractEffectiveDate.field.FieldRepetitions != null && _contractEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _contractEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_contractEffectiveDate, fieldData);
        }

        return _contractEffectiveDate;
    } 
}

internal HL7V21Field _contractAmount;

public HL7V21Field ContractAmount
{
    get
    {
        if (_contractAmount != null)
        {
            return _contractAmount;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.26",
            Type = @"Field",
            Position = @"PV1.26",
            Name = @"Contract Amount",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _contractAmount = new HL7V21Field
        {
            field = message[@"PV1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractAmount.field.FieldRepetitions != null && _contractAmount.field.FieldRepetitions.Count > 0)
        {
            _contractAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_contractAmount, fieldData);
        }

        return _contractAmount;
    } 
}

internal HL7V21Field _contractPeriod;

public HL7V21Field ContractPeriod
{
    get
    {
        if (_contractPeriod != null)
        {
            return _contractPeriod;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.27",
            Type = @"Field",
            Position = @"PV1.27",
            Name = @"Contract Period",
            Length = 3,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _contractPeriod = new HL7V21Field
        {
            field = message[@"PV1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractPeriod.field.FieldRepetitions != null && _contractPeriod.field.FieldRepetitions.Count > 0)
        {
            _contractPeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_contractPeriod, fieldData);
        }

        return _contractPeriod;
    } 
}

internal HL7V21Field _interestCode;

public HL7V21Field InterestCode
{
    get
    {
        if (_interestCode != null)
        {
            return _interestCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.28",
            Type = @"Field",
            Position = @"PV1.28",
            Name = @"Interest Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0073",
            TableName = @"INTEREST RATE CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _interestCode = new HL7V21Field
        {
            field = message[@"PV1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_interestCode.field.FieldRepetitions != null && _interestCode.field.FieldRepetitions.Count > 0)
        {
            _interestCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_interestCode, fieldData);
        }

        return _interestCode;
    } 
}

internal HL7V21Field _transferToBadDebtCode;

public HL7V21Field TransferToBadDebtCode
{
    get
    {
        if (_transferToBadDebtCode != null)
        {
            return _transferToBadDebtCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.29",
            Type = @"Field",
            Position = @"PV1.29",
            Name = @"Transfer To Bad Debt Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0110",
            TableName = @"TRANSFER TO BAD DEBT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _transferToBadDebtCode = new HL7V21Field
        {
            field = message[@"PV1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferToBadDebtCode.field.FieldRepetitions != null && _transferToBadDebtCode.field.FieldRepetitions.Count > 0)
        {
            _transferToBadDebtCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transferToBadDebtCode, fieldData);
        }

        return _transferToBadDebtCode;
    } 
}

internal HL7V21Field _transferToBadDebtDate;

public HL7V21Field TransferToBadDebtDate
{
    get
    {
        if (_transferToBadDebtDate != null)
        {
            return _transferToBadDebtDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.30",
            Type = @"Field",
            Position = @"PV1.30",
            Name = @"Transfer To Bad Debt Date",
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

        _transferToBadDebtDate = new HL7V21Field
        {
            field = message[@"PV1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferToBadDebtDate.field.FieldRepetitions != null && _transferToBadDebtDate.field.FieldRepetitions.Count > 0)
        {
            _transferToBadDebtDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_transferToBadDebtDate, fieldData);
        }

        return _transferToBadDebtDate;
    } 
}

internal HL7V21Field _badDebtAgencyCode;

public HL7V21Field BadDebtAgencyCode
{
    get
    {
        if (_badDebtAgencyCode != null)
        {
            return _badDebtAgencyCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.31",
            Type = @"Field",
            Position = @"PV1.31",
            Name = @"Bad Debt Agency Code",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = @"0021",
            TableName = @"BAD DEBT AGENCY CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _badDebtAgencyCode = new HL7V21Field
        {
            field = message[@"PV1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtAgencyCode.field.FieldRepetitions != null && _badDebtAgencyCode.field.FieldRepetitions.Count > 0)
        {
            _badDebtAgencyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_badDebtAgencyCode, fieldData);
        }

        return _badDebtAgencyCode;
    } 
}

internal HL7V21Field _badDebtTransferAmount;

public HL7V21Field BadDebtTransferAmount
{
    get
    {
        if (_badDebtTransferAmount != null)
        {
            return _badDebtTransferAmount;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.32",
            Type = @"Field",
            Position = @"PV1.32",
            Name = @"Bad Debt Transfer Amount",
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

        _badDebtTransferAmount = new HL7V21Field
        {
            field = message[@"PV1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtTransferAmount.field.FieldRepetitions != null && _badDebtTransferAmount.field.FieldRepetitions.Count > 0)
        {
            _badDebtTransferAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_badDebtTransferAmount, fieldData);
        }

        return _badDebtTransferAmount;
    } 
}

internal HL7V21Field _badDebtRecoveryAmount;

public HL7V21Field BadDebtRecoveryAmount
{
    get
    {
        if (_badDebtRecoveryAmount != null)
        {
            return _badDebtRecoveryAmount;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.33",
            Type = @"Field",
            Position = @"PV1.33",
            Name = @"Bad Debt Recovery Amount",
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

        _badDebtRecoveryAmount = new HL7V21Field
        {
            field = message[@"PV1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtRecoveryAmount.field.FieldRepetitions != null && _badDebtRecoveryAmount.field.FieldRepetitions.Count > 0)
        {
            _badDebtRecoveryAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_badDebtRecoveryAmount, fieldData);
        }

        return _badDebtRecoveryAmount;
    } 
}

internal HL7V21Field _deleteAccountIndicator;

public HL7V21Field DeleteAccountIndicator
{
    get
    {
        if (_deleteAccountIndicator != null)
        {
            return _deleteAccountIndicator;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.34",
            Type = @"Field",
            Position = @"PV1.34",
            Name = @"Delete Account Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0111",
            TableName = @"DELETE ACCOUNT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _deleteAccountIndicator = new HL7V21Field
        {
            field = message[@"PV1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deleteAccountIndicator.field.FieldRepetitions != null && _deleteAccountIndicator.field.FieldRepetitions.Count > 0)
        {
            _deleteAccountIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_deleteAccountIndicator, fieldData);
        }

        return _deleteAccountIndicator;
    } 
}

internal HL7V21Field _deleteAccountDate;

public HL7V21Field DeleteAccountDate
{
    get
    {
        if (_deleteAccountDate != null)
        {
            return _deleteAccountDate;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.35",
            Type = @"Field",
            Position = @"PV1.35",
            Name = @"Delete Account Date",
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

        _deleteAccountDate = new HL7V21Field
        {
            field = message[@"PV1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deleteAccountDate.field.FieldRepetitions != null && _deleteAccountDate.field.FieldRepetitions.Count > 0)
        {
            _deleteAccountDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_deleteAccountDate, fieldData);
        }

        return _deleteAccountDate;
    } 
}

internal HL7V21Field _dischargeDisposition;

public HL7V21Field DischargeDisposition
{
    get
    {
        if (_dischargeDisposition != null)
        {
            return _dischargeDisposition;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.36",
            Type = @"Field",
            Position = @"PV1.36",
            Name = @"Discharge Disposition",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0112",
            TableName = @"DISCHARGED DISPOSITION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dischargeDisposition = new HL7V21Field
        {
            field = message[@"PV1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargeDisposition.field.FieldRepetitions != null && _dischargeDisposition.field.FieldRepetitions.Count > 0)
        {
            _dischargeDisposition.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dischargeDisposition, fieldData);
        }

        return _dischargeDisposition;
    } 
}

internal HL7V21Field _dischargedToLocation;

public HL7V21Field DischargedToLocation
{
    get
    {
        if (_dischargedToLocation != null)
        {
            return _dischargedToLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.37",
            Type = @"Field",
            Position = @"PV1.37",
            Name = @"Discharged To Location",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0113",
            TableName = @"DISCHARGED TO LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dischargedToLocation = new HL7V21Field
        {
            field = message[@"PV1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargedToLocation.field.FieldRepetitions != null && _dischargedToLocation.field.FieldRepetitions.Count > 0)
        {
            _dischargedToLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dischargedToLocation, fieldData);
        }

        return _dischargedToLocation;
    } 
}

internal HL7V21Field _dietType;

public HL7V21Field DietType
{
    get
    {
        if (_dietType != null)
        {
            return _dietType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.38",
            Type = @"Field",
            Position = @"PV1.38",
            Name = @"Diet Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0114",
            TableName = @"DIET TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dietType = new HL7V21Field
        {
            field = message[@"PV1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dietType.field.FieldRepetitions != null && _dietType.field.FieldRepetitions.Count > 0)
        {
            _dietType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dietType, fieldData);
        }

        return _dietType;
    } 
}

internal HL7V21Field _servicingFacility;

public HL7V21Field ServicingFacility
{
    get
    {
        if (_servicingFacility != null)
        {
            return _servicingFacility;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.39",
            Type = @"Field",
            Position = @"PV1.39",
            Name = @"Servicing Facility",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0115",
            TableName = @"SERVICING FACILITY",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _servicingFacility = new HL7V21Field
        {
            field = message[@"PV1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicingFacility.field.FieldRepetitions != null && _servicingFacility.field.FieldRepetitions.Count > 0)
        {
            _servicingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_servicingFacility, fieldData);
        }

        return _servicingFacility;
    } 
}

internal HL7V21Field _bedStatus;

public HL7V21Field BedStatus
{
    get
    {
        if (_bedStatus != null)
        {
            return _bedStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.40",
            Type = @"Field",
            Position = @"PV1.40",
            Name = @"Bed Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0116",
            TableName = @"BED STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _bedStatus = new HL7V21Field
        {
            field = message[@"PV1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bedStatus.field.FieldRepetitions != null && _bedStatus.field.FieldRepetitions.Count > 0)
        {
            _bedStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_bedStatus, fieldData);
        }

        return _bedStatus;
    } 
}

internal HL7V21Field _accountStatus;

public HL7V21Field AccountStatus
{
    get
    {
        if (_accountStatus != null)
        {
            return _accountStatus;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.41",
            Type = @"Field",
            Position = @"PV1.41",
            Name = @"Account Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0117",
            TableName = @"ACCOUNT STATUS",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _accountStatus = new HL7V21Field
        {
            field = message[@"PV1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accountStatus.field.FieldRepetitions != null && _accountStatus.field.FieldRepetitions.Count > 0)
        {
            _accountStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_accountStatus, fieldData);
        }

        return _accountStatus;
    } 
}

internal HL7V21Field _pendingLocation;

public HL7V21Field PendingLocation
{
    get
    {
        if (_pendingLocation != null)
        {
            return _pendingLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.42",
            Type = @"Field",
            Position = @"PV1.42",
            Name = @"Pending Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _pendingLocation = new HL7V21Field
        {
            field = message[@"PV1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pendingLocation.field.FieldRepetitions != null && _pendingLocation.field.FieldRepetitions.Count > 0)
        {
            _pendingLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_pendingLocation, fieldData);
        }

        return _pendingLocation;
    } 
}

internal HL7V21Field _priorTemporaryLocation;

public HL7V21Field PriorTemporaryLocation
{
    get
    {
        if (_priorTemporaryLocation != null)
        {
            return _priorTemporaryLocation;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.43",
            Type = @"Field",
            Position = @"PV1.43",
            Name = @"Prior Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _priorTemporaryLocation = new HL7V21Field
        {
            field = message[@"PV1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorTemporaryLocation.field.FieldRepetitions != null && _priorTemporaryLocation.field.FieldRepetitions.Count > 0)
        {
            _priorTemporaryLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_priorTemporaryLocation, fieldData);
        }

        return _priorTemporaryLocation;
    } 
}

internal HL7V21Field _admitDateTime;

public HL7V21Field AdmitDateTime
{
    get
    {
        if (_admitDateTime != null)
        {
            return _admitDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.44",
            Type = @"Field",
            Position = @"PV1.44",
            Name = @"Admit Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _admitDateTime = new HL7V21Field
        {
            field = message[@"PV1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitDateTime.field.FieldRepetitions != null && _admitDateTime.field.FieldRepetitions.Count > 0)
        {
            _admitDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_admitDateTime, fieldData);
        }

        return _admitDateTime;
    } 
}

internal HL7V21Field _dischargeDateTime;

public HL7V21Field DischargeDateTime
{
    get
    {
        if (_dischargeDateTime != null)
        {
            return _dischargeDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.45",
            Type = @"Field",
            Position = @"PV1.45",
            Name = @"Discharge Date/Time",
            Length = 19,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _dischargeDateTime = new HL7V21Field
        {
            field = message[@"PV1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargeDateTime.field.FieldRepetitions != null && _dischargeDateTime.field.FieldRepetitions.Count > 0)
        {
            _dischargeDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_dischargeDateTime, fieldData);
        }

        return _dischargeDateTime;
    } 
}

internal HL7V21Field _currentPatientBalance;

public HL7V21Field CurrentPatientBalance
{
    get
    {
        if (_currentPatientBalance != null)
        {
            return _currentPatientBalance;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.46",
            Type = @"Field",
            Position = @"PV1.46",
            Name = @"Current Patient Balance",
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

        _currentPatientBalance = new HL7V21Field
        {
            field = message[@"PV1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentPatientBalance.field.FieldRepetitions != null && _currentPatientBalance.field.FieldRepetitions.Count > 0)
        {
            _currentPatientBalance.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_currentPatientBalance, fieldData);
        }

        return _currentPatientBalance;
    } 
}

internal HL7V21Field _totalCharges;

public HL7V21Field TotalCharges
{
    get
    {
        if (_totalCharges != null)
        {
            return _totalCharges;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.47",
            Type = @"Field",
            Position = @"PV1.47",
            Name = @"Total Charges",
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

        _totalCharges = new HL7V21Field
        {
            field = message[@"PV1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalCharges.field.FieldRepetitions != null && _totalCharges.field.FieldRepetitions.Count > 0)
        {
            _totalCharges.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_totalCharges, fieldData);
        }

        return _totalCharges;
    } 
}

internal HL7V21Field _totalAdjustments;

public HL7V21Field TotalAdjustments
{
    get
    {
        if (_totalAdjustments != null)
        {
            return _totalAdjustments;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.48",
            Type = @"Field",
            Position = @"PV1.48",
            Name = @"Total Adjustments",
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

        _totalAdjustments = new HL7V21Field
        {
            field = message[@"PV1"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalAdjustments.field.FieldRepetitions != null && _totalAdjustments.field.FieldRepetitions.Count > 0)
        {
            _totalAdjustments.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_totalAdjustments, fieldData);
        }

        return _totalAdjustments;
    } 
}

internal HL7V21Field _totalPayments;

public HL7V21Field TotalPayments
{
    get
    {
        if (_totalPayments != null)
        {
            return _totalPayments;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"PV1.49",
            Type = @"Field",
            Position = @"PV1.49",
            Name = @"Total Payments",
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

        _totalPayments = new HL7V21Field
        {
            field = message[@"PV1"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalPayments.field.FieldRepetitions != null && _totalPayments.field.FieldRepetitions.Count > 0)
        {
            _totalPayments.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_totalPayments, fieldData);
        }

        return _totalPayments;
    } 
}
    }
}

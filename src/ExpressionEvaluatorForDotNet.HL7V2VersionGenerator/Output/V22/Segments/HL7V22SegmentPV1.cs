using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentPV1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PV1"; } }

        public string SegmentId { get { return @"PV1"; } }
        
        public string LongName { get { return @"Patient Visit"; } }
        
        public string Description { get { return @"The PV1 segment is used by Registration/ADT applications to communicate information on a visit specific basis.  This segment can be used to send multiple visit statistic records to the same patient account, or single visit records to more than one account.  Individual sites must determine this segment's use"; } }
        
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

        public HL7V22SegmentPV1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdPatientVisit;

public HL7V22Field SetIdPatientVisit
{
    get
    {
        if (_setIdPatientVisit != null)
        {
            return _setIdPatientVisit;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.1",
            Type = @"Field",
            Position = @"PV1.1",
            Name = @"Set Id - Patient Visit",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"number that uniquely identifies this transaction for the purpose of adding, changing, or deleting the transaction.  For those messages that permit segments to repeat, the Set ID field is used to identify the repetitions.  For example, the swap and query transactions allow for multiple PID segments would have Set ID values of 1, 2, then 3, etc.",
            Sample = @"",
            Fields = null
        }

        _setIdPatientVisit = new HL7V22Field
        {
            field = message[@"PV1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdPatientVisit.field.FieldRepetitions != null && _setIdPatientVisit.field.FieldRepetitions.Count > 0)
        {
            _setIdPatientVisit.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdPatientVisit, fieldData);
        }

        return _setIdPatientVisit;
    } 
}

internal HL7V22Field _patientClass;

public HL7V22Field PatientClass
{
    get
    {
        if (_patientClass != null)
        {
            return _patientClass;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"a common field used by systems to categorize patients by site.  It does not have a consistent industrywide definition.  Subject to site-specific variations.  Refer to user-defined table 0004 - patient class for suggested codes",
            Sample = @"",
            Fields = null
        }

        _patientClass = new HL7V22Field
        {
            field = message[@"PV1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientClass.field.FieldRepetitions != null && _patientClass.field.FieldRepetitions.Count > 0)
        {
            _patientClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientClass, fieldData);
        }

        return _patientClass;
    } 
}

internal HL7V22Field _assignedPatientLocation;

public HL7V22Field AssignedPatientLocation
{
    get
    {
        if (_assignedPatientLocation != null)
        {
            return _assignedPatientLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.3",
            Type = @"Field",
            Position = @"PV1.3",
            Name = @"Assigned Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = @"New location is the patient's initial assigned location, or the location to which he is being moved.  For canceling a transaction or discharging a patient, the current room number should be in this field.  If a value exists in the fifth component (bed status) it supercedes the value in 3.3.3.40",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.3.1",
                            Type = @"Component",
                            Position = @"PV1.3.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"PV1.3.2",
                            Type = @"Component",
                            Position = @"PV1.3.2",
                            Name = @"Room",
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
                            Id = @"PV1.3.3",
                            Type = @"Component",
                            Position = @"PV1.3.3",
                            Name = @"Bed",
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
                            Id = @"PV1.3.4",
                            Type = @"Component",
                            Position = @"PV1.3.4",
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
                            Id = @"PV1.3.5",
                            Type = @"Component",
                            Position = @"PV1.3.5",
                            Name = @"Bed Status",
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

        _assignedPatientLocation = new HL7V22Field
        {
            field = message[@"PV1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assignedPatientLocation.field.FieldRepetitions != null && _assignedPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _assignedPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_assignedPatientLocation, fieldData);
        }

        return _assignedPatientLocation;
    } 
}

internal HL7V22Field _admissionType;

public HL7V22Field AdmissionType
{
    get
    {
        if (_admissionType != null)
        {
            return _admissionType;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"indicates the circumstance under which the patient was or will be admitted",
            Sample = @"",
            Fields = null
        }

        _admissionType = new HL7V22Field
        {
            field = message[@"PV1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admissionType.field.FieldRepetitions != null && _admissionType.field.FieldRepetitions.Count > 0)
        {
            _admissionType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_admissionType, fieldData);
        }

        return _admissionType;
    } 
}

internal HL7V22Field _preadmitNumber;

public HL7V22Field PreadmitNumber
{
    get
    {
        if (_preadmitNumber != null)
        {
            return _preadmitNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.5",
            Type = @"Field",
            Position = @"PV1.5",
            Name = @"Preadmit Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"uniquely identifies the patient's pre-admit account.  Some systems will continue to use the pre-admit number as the billing number after the patient has been admitted.  In the future, this field should be a CK data type -- like the account number",
            Sample = @"",
            Fields = null
        }

        _preadmitNumber = new HL7V22Field
        {
            field = message[@"PV1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitNumber.field.FieldRepetitions != null && _preadmitNumber.field.FieldRepetitions.Count > 0)
        {
            _preadmitNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_preadmitNumber, fieldData);
        }

        return _preadmitNumber;
    } 
}

internal HL7V22Field _priorPatientLocation;

public HL7V22Field PriorPatientLocation
{
    get
    {
        if (_priorPatientLocation != null)
        {
            return _priorPatientLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.6",
            Type = @"Field",
            Position = @"PV1.6",
            Name = @"Prior Patient Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = null,
            TableName = null,
            Description = @"old location is null if the patient is new.  It contains the prior patient location if the patient is being transferred.  If a value exists in the fifth component (bed status) it supercedes the value in 3.3.3.40",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.6.1",
                            Type = @"Component",
                            Position = @"PV1.6.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"PV1.6.2",
                            Type = @"Component",
                            Position = @"PV1.6.2",
                            Name = @"Room",
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
                            Id = @"PV1.6.3",
                            Type = @"Component",
                            Position = @"PV1.6.3",
                            Name = @"Bed",
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
                            Id = @"PV1.6.4",
                            Type = @"Component",
                            Position = @"PV1.6.4",
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
                            Id = @"PV1.6.5",
                            Type = @"Component",
                            Position = @"PV1.6.5",
                            Name = @"Bed Status",
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

        _priorPatientLocation = new HL7V22Field
        {
            field = message[@"PV1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPatientLocation.field.FieldRepetitions != null && _priorPatientLocation.field.FieldRepetitions.Count > 0)
        {
            _priorPatientLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_priorPatientLocation, fieldData);
        }

        return _priorPatientLocation;
    } 
}

internal HL7V22Field _attendingDoctor;

public HL7V22Field AttendingDoctor
{
    get
    {
        if (_attendingDoctor != null)
        {
            return _attendingDoctor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.7",
            Type = @"Field",
            Position = @"PV1.7",
            Name = @"Attending Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"Depending on local agreements, either ID or the name may be absent.  Refer to user-defined table 0010 - physician ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.7.1",
                            Type = @"Component",
                            Position = @"PV1.7.1",
                            Name = @"Physician Id",
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
                            Id = @"PV1.7.2",
                            Type = @"Component",
                            Position = @"PV1.7.2",
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
                            Id = @"PV1.7.3",
                            Type = @"Component",
                            Position = @"PV1.7.3",
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
                            Id = @"PV1.7.4",
                            Type = @"Component",
                            Position = @"PV1.7.4",
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
                            Id = @"PV1.7.5",
                            Type = @"Component",
                            Position = @"PV1.7.5",
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
                            Id = @"PV1.7.6",
                            Type = @"Component",
                            Position = @"PV1.7.6",
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
                            Id = @"PV1.7.7",
                            Type = @"Component",
                            Position = @"PV1.7.7",
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
                            Id = @"PV1.7.8",
                            Type = @"Component",
                            Position = @"PV1.7.8",
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

        _attendingDoctor = new HL7V22Field
        {
            field = message[@"PV1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_attendingDoctor.field.FieldRepetitions != null && _attendingDoctor.field.FieldRepetitions.Count > 0)
        {
            _attendingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_attendingDoctor, fieldData);
        }

        return _attendingDoctor;
    } 
}

internal HL7V22Field _referringDoctor;

public HL7V22Field ReferringDoctor
{
    get
    {
        if (_referringDoctor != null)
        {
            return _referringDoctor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.8",
            Type = @"Field",
            Position = @"PV1.8",
            Name = @"Referring Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"depending on local agreements, either ID or the name may be absent.  Refer to user-defined table 0010 - physician ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.8.1",
                            Type = @"Component",
                            Position = @"PV1.8.1",
                            Name = @"Physician Id",
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
                            Id = @"PV1.8.2",
                            Type = @"Component",
                            Position = @"PV1.8.2",
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
                            Id = @"PV1.8.3",
                            Type = @"Component",
                            Position = @"PV1.8.3",
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
                            Id = @"PV1.8.4",
                            Type = @"Component",
                            Position = @"PV1.8.4",
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
                            Id = @"PV1.8.5",
                            Type = @"Component",
                            Position = @"PV1.8.5",
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
                            Id = @"PV1.8.6",
                            Type = @"Component",
                            Position = @"PV1.8.6",
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
                            Id = @"PV1.8.7",
                            Type = @"Component",
                            Position = @"PV1.8.7",
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
                            Id = @"PV1.8.8",
                            Type = @"Component",
                            Position = @"PV1.8.8",
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

        _referringDoctor = new HL7V22Field
        {
            field = message[@"PV1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referringDoctor.field.FieldRepetitions != null && _referringDoctor.field.FieldRepetitions.Count > 0)
        {
            _referringDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_referringDoctor, fieldData);
        }

        return _referringDoctor;
    } 
}

internal HL7V22Field _consultingDoctor;

public HL7V22Field ConsultingDoctor
{
    get
    {
        if (_consultingDoctor != null)
        {
            return _consultingDoctor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.9",
            Type = @"Field",
            Position = @"PV1.9",
            Name = @"Consulting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"depending on local agreements, either ID or the name may be absent.  Refer to user-defined table 0010 - physician ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.9.1",
                            Type = @"Component",
                            Position = @"PV1.9.1",
                            Name = @"Physician Id",
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
                            Id = @"PV1.9.2",
                            Type = @"Component",
                            Position = @"PV1.9.2",
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
                            Id = @"PV1.9.3",
                            Type = @"Component",
                            Position = @"PV1.9.3",
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
                            Id = @"PV1.9.4",
                            Type = @"Component",
                            Position = @"PV1.9.4",
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
                            Id = @"PV1.9.5",
                            Type = @"Component",
                            Position = @"PV1.9.5",
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
                            Id = @"PV1.9.6",
                            Type = @"Component",
                            Position = @"PV1.9.6",
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
                            Id = @"PV1.9.7",
                            Type = @"Component",
                            Position = @"PV1.9.7",
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
                            Id = @"PV1.9.8",
                            Type = @"Component",
                            Position = @"PV1.9.8",
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

        _consultingDoctor = new HL7V22Field
        {
            field = message[@"PV1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_consultingDoctor.field.FieldRepetitions != null && _consultingDoctor.field.FieldRepetitions.Count > 0)
        {
            _consultingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_consultingDoctor, fieldData);
        }

        return _consultingDoctor;
    } 
}

internal HL7V22Field _hospitalService;

public HL7V22Field HospitalService
{
    get
    {
        if (_hospitalService != null)
        {
            return _hospitalService;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"The treatment or type of surgery the patient is scheduled to receive.  Required field with trigger events A01, A02, A14, A15.  Refer to user-defined table 0069 - hospital service",
            Sample = @"",
            Fields = null
        }

        _hospitalService = new HL7V22Field
        {
            field = message[@"PV1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hospitalService.field.FieldRepetitions != null && _hospitalService.field.FieldRepetitions.Count > 0)
        {
            _hospitalService.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_hospitalService, fieldData);
        }

        return _hospitalService;
    } 
}

internal HL7V22Field _temporaryLocation;

public HL7V22Field TemporaryLocation
{
    get
    {
        if (_temporaryLocation != null)
        {
            return _temporaryLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.11",
            Type = @"Field",
            Position = @"PV1.11",
            Name = @"Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = @"0079",
            TableName = @"LOCATION",
            Description = @"location other than the assigned location required for a temporary period of time (e.g., OR).  If a value exists in the fifth component (bed status) it supercedes the value in 3.3.3.40",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.11.1",
                            Type = @"Component",
                            Position = @"PV1.11.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"PV1.11.2",
                            Type = @"Component",
                            Position = @"PV1.11.2",
                            Name = @"Room",
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
                            Id = @"PV1.11.3",
                            Type = @"Component",
                            Position = @"PV1.11.3",
                            Name = @"Bed",
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
                            Id = @"PV1.11.4",
                            Type = @"Component",
                            Position = @"PV1.11.4",
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
                            Id = @"PV1.11.5",
                            Type = @"Component",
                            Position = @"PV1.11.5",
                            Name = @"Bed Status",
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

        _temporaryLocation = new HL7V22Field
        {
            field = message[@"PV1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_temporaryLocation.field.FieldRepetitions != null && _temporaryLocation.field.FieldRepetitions.Count > 0)
        {
            _temporaryLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_temporaryLocation, fieldData);
        }

        return _temporaryLocation;
    } 
}

internal HL7V22Field _preadmitTestIndicator;

public HL7V22Field PreadmitTestIndicator
{
    get
    {
        if (_preadmitTestIndicator != null)
        {
            return _preadmitTestIndicator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.12",
            Type = @"Field",
            Position = @"PV1.12",
            Name = @"Preadmit Test Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0087",
            TableName = @"PRE-ADMIT TESTING",
            Description = @"indicates that the patient must have pre-admission testing done in order to be admitted.  Refer to userdefined table 0087 - pre-admit test indicator for suggested codes",
            Sample = @"",
            Fields = null
        }

        _preadmitTestIndicator = new HL7V22Field
        {
            field = message[@"PV1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preadmitTestIndicator.field.FieldRepetitions != null && _preadmitTestIndicator.field.FieldRepetitions.Count > 0)
        {
            _preadmitTestIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_preadmitTestIndicator, fieldData);
        }

        return _preadmitTestIndicator;
    } 
}

internal HL7V22Field _readmissionIndicator;

public HL7V22Field ReadmissionIndicator
{
    get
    {
        if (_readmissionIndicator != null)
        {
            return _readmissionIndicator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.13",
            Type = @"Field",
            Position = @"PV1.13",
            Name = @"Readmission Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0092",
            TableName = @"RE-ADMISSION INDICATOR",
            Description = @"indicates that a patient is being re-admitted to the facility and the circumstances.  R for readmission or else null.  Also recurring patient visits can be indicated.  Refer to user-defined table 0092 - re-admission indicator",
            Sample = @"",
            Fields = null
        }

        _readmissionIndicator = new HL7V22Field
        {
            field = message[@"PV1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_readmissionIndicator.field.FieldRepetitions != null && _readmissionIndicator.field.FieldRepetitions.Count > 0)
        {
            _readmissionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_readmissionIndicator, fieldData);
        }

        return _readmissionIndicator;
    } 
}

internal HL7V22Field _admitSource;

public HL7V22Field AdmitSource
{
    get
    {
        if (_admitSource != null)
        {
            return _admitSource;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"indicates where the patient was admitted.  Refer to user-defined table 0023 - admit source for suggested codes",
            Sample = @"",
            Fields = null
        }

        _admitSource = new HL7V22Field
        {
            field = message[@"PV1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitSource.field.FieldRepetitions != null && _admitSource.field.FieldRepetitions.Count > 0)
        {
            _admitSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_admitSource, fieldData);
        }

        return _admitSource;
    } 
}

internal HL7V22Field _ambulatoryStatus;

public HL7V22Field AmbulatoryStatus
{
    get
    {
        if (_ambulatoryStatus != null)
        {
            return _ambulatoryStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.15",
            Type = @"Field",
            Position = @"PV1.15",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0009",
            TableName = @"AMBULATORY STATUS",
            Description = @"refer to user-defined table 0009 - ambulatory status for suggested entries",
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatus = new HL7V22Field
        {
            field = message[@"PV1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatus.field.FieldRepetitions != null && _ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_ambulatoryStatus, fieldData);
        }

        return _ambulatoryStatus;
    } 
}

internal HL7V22Field _vipIndicator;

public HL7V22Field VipIndicator
{
    get
    {
        if (_vipIndicator != null)
        {
            return _vipIndicator;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"user-defined code to identify the type of VIP.  Refer to user-defined table 0099 - VIP indicator",
            Sample = @"",
            Fields = null
        }

        _vipIndicator = new HL7V22Field
        {
            field = message[@"PV1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_vipIndicator.field.FieldRepetitions != null && _vipIndicator.field.FieldRepetitions.Count > 0)
        {
            _vipIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_vipIndicator, fieldData);
        }

        return _vipIndicator;
    } 
}

internal HL7V22Field _admittingDoctor;

public HL7V22Field AdmittingDoctor
{
    get
    {
        if (_admittingDoctor != null)
        {
            return _admittingDoctor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.17",
            Type = @"Field",
            Position = @"PV1.17",
            Name = @"Admitting Doctor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PHYSICIAN",
            DataTypeName = @"Cn For Physicians",
            TableId = @"0010",
            TableName = @"PHYSICIAN ID",
            Description = @"by local agreement name or ID may not be present.  Refer to user-defined table 0010 - physician ID",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.17.1",
                            Type = @"Component",
                            Position = @"PV1.17.1",
                            Name = @"Physician Id",
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
                            Id = @"PV1.17.2",
                            Type = @"Component",
                            Position = @"PV1.17.2",
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
                            Id = @"PV1.17.3",
                            Type = @"Component",
                            Position = @"PV1.17.3",
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
                            Id = @"PV1.17.4",
                            Type = @"Component",
                            Position = @"PV1.17.4",
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
                            Id = @"PV1.17.5",
                            Type = @"Component",
                            Position = @"PV1.17.5",
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
                            Id = @"PV1.17.6",
                            Type = @"Component",
                            Position = @"PV1.17.6",
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
                            Id = @"PV1.17.7",
                            Type = @"Component",
                            Position = @"PV1.17.7",
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
                            Id = @"PV1.17.8",
                            Type = @"Component",
                            Position = @"PV1.17.8",
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

        _admittingDoctor = new HL7V22Field
        {
            field = message[@"PV1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admittingDoctor.field.FieldRepetitions != null && _admittingDoctor.field.FieldRepetitions.Count > 0)
        {
            _admittingDoctor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_admittingDoctor, fieldData);
        }

        return _admittingDoctor;
    } 
}

internal HL7V22Field _patientType;

public HL7V22Field PatientType
{
    get
    {
        if (_patientType != null)
        {
            return _patientType;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"site-specific values.  Refer user-defined table 0018 - patient type",
            Sample = @"",
            Fields = null
        }

        _patientType = new HL7V22Field
        {
            field = message[@"PV1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientType.field.FieldRepetitions != null && _patientType.field.FieldRepetitions.Count > 0)
        {
            _patientType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientType, fieldData);
        }

        return _patientType;
    } 
}

internal HL7V22Field _visitNumber;

public HL7V22Field VisitNumber
{
    get
    {
        if (_visitNumber != null)
        {
            return _visitNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.19",
            Type = @"Field",
            Position = @"PV1.19",
            Name = @"Visit Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PAT_ID",
            DataTypeName = @"Patient Id",
            TableId = null,
            TableName = null,
            Description = @"unique number assigned to each patient visit.  This is left as NM data type for backwards compatibility but HL7 recommends new implementations use CK data type",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.19.1",
                            Type = @"Component",
                            Position = @"PV1.19.1",
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
                            Id = @"PV1.19.2",
                            Type = @"Component",
                            Position = @"PV1.19.2",
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
                            Id = @"PV1.19.3",
                            Type = @"Component",
                            Position = @"PV1.19.3",
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
                            Id = @"PV1.19.4",
                            Type = @"Component",
                            Position = @"PV1.19.4",
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
                            Id = @"PV1.19.5",
                            Type = @"Component",
                            Position = @"PV1.19.5",
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

        _visitNumber = new HL7V22Field
        {
            field = message[@"PV1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitNumber.field.FieldRepetitions != null && _visitNumber.field.FieldRepetitions.Count > 0)
        {
            _visitNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_visitNumber, fieldData);
        }

        return _visitNumber;
    } 
}

internal HL7V22Field _financialClass;

public HL7V22Field FinancialClass
{
    get
    {
        if (_financialClass != null)
        {
            return _financialClass;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.20",
            Type = @"Field",
            Position = @"PV1.20",
            Name = @"Financial Class",
            Length = 50,
            Usage = @"O",
            Rpt = @"4",
            DataType = @"CM_FINANCE",
            DataTypeName = @"Cm Of Finance",
            TableId = null,
            TableName = null,
            Description = @"primary financial class assigned to the patient for the purpose of identifying sources of reimbursement.  Repeats up to 4 times.  Refer to user-defined table 0064 - financial class for suggested codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.20.1",
                            Type = @"Component",
                            Position = @"PV1.20.1",
                            Name = @"Financial Class Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0064",
                            TableName = @"FINANCIAL CLASS",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.20.2",
                            Type = @"Component",
                            Position = @"PV1.20.2",
                            Name = @"Effective Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PV1.20.2.1",
                            Type = @"SubComponent",
                            Position = @"PV1.20.2.1",
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
                            Id = @"PV1.20.2.2",
                            Type = @"SubComponent",
                            Position = @"PV1.20.2.2",
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
                        },}
                        },
                        }
        }

        _financialClass = new HL7V22Field
        {
            field = message[@"PV1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_financialClass.field.FieldRepetitions != null && _financialClass.field.FieldRepetitions.Count > 0)
        {
            _financialClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_financialClass, fieldData);
        }

        return _financialClass;
    } 
}

internal HL7V22Field _chargePriceIndicator;

public HL7V22Field ChargePriceIndicator
{
    get
    {
        if (_chargePriceIndicator != null)
        {
            return _chargePriceIndicator;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"code used to determine which price schedule is to be used for room and bed charges.  Refer to userdefined table 0032 - charge/price indicator",
            Sample = @"",
            Fields = null
        }

        _chargePriceIndicator = new HL7V22Field
        {
            field = message[@"PV1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargePriceIndicator.field.FieldRepetitions != null && _chargePriceIndicator.field.FieldRepetitions.Count > 0)
        {
            _chargePriceIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_chargePriceIndicator, fieldData);
        }

        return _chargePriceIndicator;
    } 
}

internal HL7V22Field _courtesyCode;

public HL7V22Field CourtesyCode
{
    get
    {
        if (_courtesyCode != null)
        {
            return _courtesyCode;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"code that indicates whether the patient will be extended certain special courtesies.  Refer to user-defined table 0045 - courtesy code",
            Sample = @"",
            Fields = null
        }

        _courtesyCode = new HL7V22Field
        {
            field = message[@"PV1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_courtesyCode.field.FieldRepetitions != null && _courtesyCode.field.FieldRepetitions.Count > 0)
        {
            _courtesyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_courtesyCode, fieldData);
        }

        return _courtesyCode;
    } 
}

internal HL7V22Field _creditRating;

public HL7V22Field CreditRating
{
    get
    {
        if (_creditRating != null)
        {
            return _creditRating;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"user-defined code to determine past credit experience.  Refer user-defined table 0046 - credit rating",
            Sample = @"",
            Fields = null
        }

        _creditRating = new HL7V22Field
        {
            field = message[@"PV1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_creditRating.field.FieldRepetitions != null && _creditRating.field.FieldRepetitions.Count > 0)
        {
            _creditRating.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_creditRating, fieldData);
        }

        return _creditRating;
    } 
}

internal HL7V22Field _contractCode;

public HL7V22Field ContractCode
{
    get
    {
        if (_contractCode != null)
        {
            return _contractCode;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"identifies the type of contract entered into by the facility and the guarantor for the purpose of settling outstanding account balances.  Refer to user-defined table 0044 - contract code",
            Sample = @"",
            Fields = null
        }

        _contractCode = new HL7V22Field
        {
            field = message[@"PV1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractCode.field.FieldRepetitions != null && _contractCode.field.FieldRepetitions.Count > 0)
        {
            _contractCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_contractCode, fieldData);
        }

        return _contractCode;
    } 
}

internal HL7V22Field _contractEffectiveDate;

public HL7V22Field ContractEffectiveDate
{
    get
    {
        if (_contractEffectiveDate != null)
        {
            return _contractEffectiveDate;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"date the contract is to start.",
            Sample = @"",
            Fields = null
        }

        _contractEffectiveDate = new HL7V22Field
        {
            field = message[@"PV1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractEffectiveDate.field.FieldRepetitions != null && _contractEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _contractEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_contractEffectiveDate, fieldData);
        }

        return _contractEffectiveDate;
    } 
}

internal HL7V22Field _contractAmount;

public HL7V22Field ContractAmount
{
    get
    {
        if (_contractAmount != null)
        {
            return _contractAmount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"amount to be paid by the guarantor each period as per the contract",
            Sample = @"",
            Fields = null
        }

        _contractAmount = new HL7V22Field
        {
            field = message[@"PV1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractAmount.field.FieldRepetitions != null && _contractAmount.field.FieldRepetitions.Count > 0)
        {
            _contractAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_contractAmount, fieldData);
        }

        return _contractAmount;
    } 
}

internal HL7V22Field _contractPeriod;

public HL7V22Field ContractPeriod
{
    get
    {
        if (_contractPeriod != null)
        {
            return _contractPeriod;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"specifies the duration of the contract for user-defined periods",
            Sample = @"",
            Fields = null
        }

        _contractPeriod = new HL7V22Field
        {
            field = message[@"PV1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contractPeriod.field.FieldRepetitions != null && _contractPeriod.field.FieldRepetitions.Count > 0)
        {
            _contractPeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_contractPeriod, fieldData);
        }

        return _contractPeriod;
    } 
}

internal HL7V22Field _interestCode;

public HL7V22Field InterestCode
{
    get
    {
        if (_interestCode != null)
        {
            return _interestCode;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"indicates the amount of interest that will be charged the guarantor on any outstanding amounts.  Refer to user-defined table 0073 - interest rate code",
            Sample = @"",
            Fields = null
        }

        _interestCode = new HL7V22Field
        {
            field = message[@"PV1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_interestCode.field.FieldRepetitions != null && _interestCode.field.FieldRepetitions.Count > 0)
        {
            _interestCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_interestCode, fieldData);
        }

        return _interestCode;
    } 
}

internal HL7V22Field _transferToBadDebtCode;

public HL7V22Field TransferToBadDebtCode
{
    get
    {
        if (_transferToBadDebtCode != null)
        {
            return _transferToBadDebtCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.29",
            Type = @"Field",
            Position = @"PV1.29",
            Name = @"Transfer To Bad Debt - Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0110",
            TableName = @"TRANSFER TO BAD DEBT CODE",
            Description = @"indicates the account was transferred to bad debts and the reason.  Refer to user-defined table 0110 - transfer to bad debt code",
            Sample = @"",
            Fields = null
        }

        _transferToBadDebtCode = new HL7V22Field
        {
            field = message[@"PV1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferToBadDebtCode.field.FieldRepetitions != null && _transferToBadDebtCode.field.FieldRepetitions.Count > 0)
        {
            _transferToBadDebtCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transferToBadDebtCode, fieldData);
        }

        return _transferToBadDebtCode;
    } 
}

internal HL7V22Field _transferToBadDebtDate;

public HL7V22Field TransferToBadDebtDate
{
    get
    {
        if (_transferToBadDebtDate != null)
        {
            return _transferToBadDebtDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.30",
            Type = @"Field",
            Position = @"PV1.30",
            Name = @"Transfer To Bad Debt - Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that the account was transferred to a bad debt status",
            Sample = @"",
            Fields = null
        }

        _transferToBadDebtDate = new HL7V22Field
        {
            field = message[@"PV1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferToBadDebtDate.field.FieldRepetitions != null && _transferToBadDebtDate.field.FieldRepetitions.Count > 0)
        {
            _transferToBadDebtDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transferToBadDebtDate, fieldData);
        }

        return _transferToBadDebtDate;
    } 
}

internal HL7V22Field _badDebtAgencyCode;

public HL7V22Field BadDebtAgencyCode
{
    get
    {
        if (_badDebtAgencyCode != null)
        {
            return _badDebtAgencyCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.31",
            Type = @"Field",
            Position = @"PV1.31",
            Name = @"Bad Debt Agency Code",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0021",
            TableName = @"BAD DEBT AGENCY CODE",
            Description = @"uniquely identifies the bad debt agency that the account was transferred to.  This code is site-defined.  This field was kept as an ST type for backwards compatibility.  One possible implementation is to edit against a table such as, user-defined table 0021 - bad debt agency code, however this is not required",
            Sample = @"",
            Fields = null
        }

        _badDebtAgencyCode = new HL7V22Field
        {
            field = message[@"PV1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtAgencyCode.field.FieldRepetitions != null && _badDebtAgencyCode.field.FieldRepetitions.Count > 0)
        {
            _badDebtAgencyCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_badDebtAgencyCode, fieldData);
        }

        return _badDebtAgencyCode;
    } 
}

internal HL7V22Field _badDebtTransferAmount;

public HL7V22Field BadDebtTransferAmount
{
    get
    {
        if (_badDebtTransferAmount != null)
        {
            return _badDebtTransferAmount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"amount that was transferred to a bad debt status",
            Sample = @"",
            Fields = null
        }

        _badDebtTransferAmount = new HL7V22Field
        {
            field = message[@"PV1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtTransferAmount.field.FieldRepetitions != null && _badDebtTransferAmount.field.FieldRepetitions.Count > 0)
        {
            _badDebtTransferAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_badDebtTransferAmount, fieldData);
        }

        return _badDebtTransferAmount;
    } 
}

internal HL7V22Field _badDebtRecoveryAmount;

public HL7V22Field BadDebtRecoveryAmount
{
    get
    {
        if (_badDebtRecoveryAmount != null)
        {
            return _badDebtRecoveryAmount;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"amount recovered from the guarantor on the account",
            Sample = @"",
            Fields = null
        }

        _badDebtRecoveryAmount = new HL7V22Field
        {
            field = message[@"PV1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_badDebtRecoveryAmount.field.FieldRepetitions != null && _badDebtRecoveryAmount.field.FieldRepetitions.Count > 0)
        {
            _badDebtRecoveryAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_badDebtRecoveryAmount, fieldData);
        }

        return _badDebtRecoveryAmount;
    } 
}

internal HL7V22Field _deleteAccountIndicator;

public HL7V22Field DeleteAccountIndicator
{
    get
    {
        if (_deleteAccountIndicator != null)
        {
            return _deleteAccountIndicator;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"indicates that the account was deleted from the file and the reason.  Refer to user-defined table 0111 - delete account code",
            Sample = @"",
            Fields = null
        }

        _deleteAccountIndicator = new HL7V22Field
        {
            field = message[@"PV1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deleteAccountIndicator.field.FieldRepetitions != null && _deleteAccountIndicator.field.FieldRepetitions.Count > 0)
        {
            _deleteAccountIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_deleteAccountIndicator, fieldData);
        }

        return _deleteAccountIndicator;
    } 
}

internal HL7V22Field _deleteAccountDate;

public HL7V22Field DeleteAccountDate
{
    get
    {
        if (_deleteAccountDate != null)
        {
            return _deleteAccountDate;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"date that the account was deleted from the file",
            Sample = @"",
            Fields = null
        }

        _deleteAccountDate = new HL7V22Field
        {
            field = message[@"PV1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deleteAccountDate.field.FieldRepetitions != null && _deleteAccountDate.field.FieldRepetitions.Count > 0)
        {
            _deleteAccountDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_deleteAccountDate, fieldData);
        }

        return _deleteAccountDate;
    } 
}

internal HL7V22Field _dischargeDisposition;

public HL7V22Field DischargeDisposition
{
    get
    {
        if (_dischargeDisposition != null)
        {
            return _dischargeDisposition;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.36",
            Type = @"Field",
            Position = @"PV1.36",
            Name = @"Discharge Disposition",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0112",
            TableName = @"DISCHARGE DISPOSITION",
            Description = @"disposition of the patient at time of discharge (i.e., discharged to home; expired; etc.).  Refer to userdefined table 0112 - discharged disposition",
            Sample = @"",
            Fields = null
        }

        _dischargeDisposition = new HL7V22Field
        {
            field = message[@"PV1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargeDisposition.field.FieldRepetitions != null && _dischargeDisposition.field.FieldRepetitions.Count > 0)
        {
            _dischargeDisposition.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dischargeDisposition, fieldData);
        }

        return _dischargeDisposition;
    } 
}

internal HL7V22Field _dischargedToLocation;

public HL7V22Field DischargedToLocation
{
    get
    {
        if (_dischargedToLocation != null)
        {
            return _dischargedToLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.37",
            Type = @"Field",
            Position = @"PV1.37",
            Name = @"Discharged To Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DLD",
            DataTypeName = @"Discharge Location",
            TableId = null,
            TableName = null,
            Description = @"indicates a facility to which the patient was discharged.  Refer to user-defined table 0113  - discharged to location",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.37.1",
                            Type = @"Component",
                            Position = @"PV1.37.1",
                            Name = @"Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0113",
                            TableName = @"DISCHARGED TO LOCATION",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PV1.37.2",
                            Type = @"Component",
                            Position = @"PV1.37.2",
                            Name = @"Description",
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

        _dischargedToLocation = new HL7V22Field
        {
            field = message[@"PV1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargedToLocation.field.FieldRepetitions != null && _dischargedToLocation.field.FieldRepetitions.Count > 0)
        {
            _dischargedToLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dischargedToLocation, fieldData);
        }

        return _dischargedToLocation;
    } 
}

internal HL7V22Field _dietType;

public HL7V22Field DietType
{
    get
    {
        if (_dietType != null)
        {
            return _dietType;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"indicates a special diet type for a patient.  Refer to user-defined table 0114 - diet type",
            Sample = @"",
            Fields = null
        }

        _dietType = new HL7V22Field
        {
            field = message[@"PV1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dietType.field.FieldRepetitions != null && _dietType.field.FieldRepetitions.Count > 0)
        {
            _dietType.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dietType, fieldData);
        }

        return _dietType;
    } 
}

internal HL7V22Field _servicingFacility;

public HL7V22Field ServicingFacility
{
    get
    {
        if (_servicingFacility != null)
        {
            return _servicingFacility;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.39",
            Type = @"Field",
            Position = @"PV1.39",
            Name = @"Servicing Facility",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0115",
            TableName = @"SERVICING FACILITY",
            Description = @"used in a multiple facility environment to indicate the facility with which this visit is associated.  Refer to user-defined table 0115 - servicing facility",
            Sample = @"",
            Fields = null
        }

        _servicingFacility = new HL7V22Field
        {
            field = message[@"PV1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicingFacility.field.FieldRepetitions != null && _servicingFacility.field.FieldRepetitions.Count > 0)
        {
            _servicingFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_servicingFacility, fieldData);
        }

        return _servicingFacility;
    } 
}

internal HL7V22Field _bedStatus;

public HL7V22Field BedStatus
{
    get
    {
        if (_bedStatus != null)
        {
            return _bedStatus;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"efer to user-defined table 0116 - bed status",
            Sample = @"",
            Fields = null
        }

        _bedStatus = new HL7V22Field
        {
            field = message[@"PV1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bedStatus.field.FieldRepetitions != null && _bedStatus.field.FieldRepetitions.Count > 0)
        {
            _bedStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_bedStatus, fieldData);
        }

        return _bedStatus;
    } 
}

internal HL7V22Field _accountStatus;

public HL7V22Field AccountStatus
{
    get
    {
        if (_accountStatus != null)
        {
            return _accountStatus;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"refer to user-defined table 0117 - account status",
            Sample = @"",
            Fields = null
        }

        _accountStatus = new HL7V22Field
        {
            field = message[@"PV1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accountStatus.field.FieldRepetitions != null && _accountStatus.field.FieldRepetitions.Count > 0)
        {
            _accountStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_accountStatus, fieldData);
        }

        return _accountStatus;
    } 
}

internal HL7V22Field _pendingLocation;

public HL7V22Field PendingLocation
{
    get
    {
        if (_pendingLocation != null)
        {
            return _pendingLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.42",
            Type = @"Field",
            Position = @"PV1.42",
            Name = @"Pending Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = null,
            TableName = null,
            Description = @"indicates the nursing station, room, bed, facility ID and bed status to which the patient may be moved.  If a value exists in the fifth component (bed status) it supercedes the value in 3.3.3.40",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.42.1",
                            Type = @"Component",
                            Position = @"PV1.42.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"PV1.42.2",
                            Type = @"Component",
                            Position = @"PV1.42.2",
                            Name = @"Room",
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
                            Id = @"PV1.42.3",
                            Type = @"Component",
                            Position = @"PV1.42.3",
                            Name = @"Bed",
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
                            Id = @"PV1.42.4",
                            Type = @"Component",
                            Position = @"PV1.42.4",
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
                            Id = @"PV1.42.5",
                            Type = @"Component",
                            Position = @"PV1.42.5",
                            Name = @"Bed Status",
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

        _pendingLocation = new HL7V22Field
        {
            field = message[@"PV1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pendingLocation.field.FieldRepetitions != null && _pendingLocation.field.FieldRepetitions.Count > 0)
        {
            _pendingLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_pendingLocation, fieldData);
        }

        return _pendingLocation;
    } 
}

internal HL7V22Field _priorTemporaryLocation;

public HL7V22Field PriorTemporaryLocation
{
    get
    {
        if (_priorTemporaryLocation != null)
        {
            return _priorTemporaryLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.43",
            Type = @"Field",
            Position = @"PV1.43",
            Name = @"Prior Temporary Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = null,
            TableName = null,
            Description = @"can be used when a patient is arriving or departing or for general update events.   If a value exists in the fifth component (bed status) it supercedes the value in 3.3.3.40",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.43.1",
                            Type = @"Component",
                            Position = @"PV1.43.1",
                            Name = @"Nurse Unit (station)",
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
                            Id = @"PV1.43.2",
                            Type = @"Component",
                            Position = @"PV1.43.2",
                            Name = @"Room",
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
                            Id = @"PV1.43.3",
                            Type = @"Component",
                            Position = @"PV1.43.3",
                            Name = @"Bed",
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
                            Id = @"PV1.43.4",
                            Type = @"Component",
                            Position = @"PV1.43.4",
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
                            Id = @"PV1.43.5",
                            Type = @"Component",
                            Position = @"PV1.43.5",
                            Name = @"Bed Status",
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

        _priorTemporaryLocation = new HL7V22Field
        {
            field = message[@"PV1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorTemporaryLocation.field.FieldRepetitions != null && _priorTemporaryLocation.field.FieldRepetitions.Count > 0)
        {
            _priorTemporaryLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_priorTemporaryLocation, fieldData);
        }

        return _priorTemporaryLocation;
    } 
}

internal HL7V22Field _admitDateTime;

public HL7V22Field AdmitDateTime
{
    get
    {
        if (_admitDateTime != null)
        {
            return _admitDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.44",
            Type = @"Field",
            Position = @"PV1.44",
            Name = @"Admit Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"admit date/time.  To be used if the event date/time is different than the admit date and time, i.e., a retroactive update",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.44.1",
                            Type = @"Component",
                            Position = @"PV1.44.1",
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
                            Id = @"PV1.44.2",
                            Type = @"Component",
                            Position = @"PV1.44.2",
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

        _admitDateTime = new HL7V22Field
        {
            field = message[@"PV1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitDateTime.field.FieldRepetitions != null && _admitDateTime.field.FieldRepetitions.Count > 0)
        {
            _admitDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_admitDateTime, fieldData);
        }

        return _admitDateTime;
    } 
}

internal HL7V22Field _dischargeDateTime;

public HL7V22Field DischargeDateTime
{
    get
    {
        if (_dischargeDateTime != null)
        {
            return _dischargeDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.45",
            Type = @"Field",
            Position = @"PV1.45",
            Name = @"Discharge Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"discharge date/time.  To be used if the event date/time is different than the admit date and time, i.e., a retroactive update",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.45.1",
                            Type = @"Component",
                            Position = @"PV1.45.1",
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
                            Id = @"PV1.45.2",
                            Type = @"Component",
                            Position = @"PV1.45.2",
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

        _dischargeDateTime = new HL7V22Field
        {
            field = message[@"PV1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dischargeDateTime.field.FieldRepetitions != null && _dischargeDateTime.field.FieldRepetitions.Count > 0)
        {
            _dischargeDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dischargeDateTime, fieldData);
        }

        return _dischargeDateTime;
    } 
}

internal HL7V22Field _currentPatientBalance;

public HL7V22Field CurrentPatientBalance
{
    get
    {
        if (_currentPatientBalance != null)
        {
            return _currentPatientBalance;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"visit balance due",
            Sample = @"",
            Fields = null
        }

        _currentPatientBalance = new HL7V22Field
        {
            field = message[@"PV1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_currentPatientBalance.field.FieldRepetitions != null && _currentPatientBalance.field.FieldRepetitions.Count > 0)
        {
            _currentPatientBalance.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_currentPatientBalance, fieldData);
        }

        return _currentPatientBalance;
    } 
}

internal HL7V22Field _totalCharges;

public HL7V22Field TotalCharges
{
    get
    {
        if (_totalCharges != null)
        {
            return _totalCharges;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"total visit charges",
            Sample = @"",
            Fields = null
        }

        _totalCharges = new HL7V22Field
        {
            field = message[@"PV1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalCharges.field.FieldRepetitions != null && _totalCharges.field.FieldRepetitions.Count > 0)
        {
            _totalCharges.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_totalCharges, fieldData);
        }

        return _totalCharges;
    } 
}

internal HL7V22Field _totalAdjustments;

public HL7V22Field TotalAdjustments
{
    get
    {
        if (_totalAdjustments != null)
        {
            return _totalAdjustments;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"total adjustments for visit",
            Sample = @"",
            Fields = null
        }

        _totalAdjustments = new HL7V22Field
        {
            field = message[@"PV1"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalAdjustments.field.FieldRepetitions != null && _totalAdjustments.field.FieldRepetitions.Count > 0)
        {
            _totalAdjustments.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_totalAdjustments, fieldData);
        }

        return _totalAdjustments;
    } 
}

internal HL7V22Field _totalPayments;

public HL7V22Field TotalPayments
{
    get
    {
        if (_totalPayments != null)
        {
            return _totalPayments;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"total payments for visit",
            Sample = @"",
            Fields = null
        }

        _totalPayments = new HL7V22Field
        {
            field = message[@"PV1"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_totalPayments.field.FieldRepetitions != null && _totalPayments.field.FieldRepetitions.Count > 0)
        {
            _totalPayments.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_totalPayments, fieldData);
        }

        return _totalPayments;
    } 
}

internal HL7V22Field _alternateVisitId;

public HL7V22Field AlternateVisitId
{
    get
    {
        if (_alternateVisitId != null)
        {
            return _alternateVisitId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV1.50",
            Type = @"Field",
            Position = @"PV1.50",
            Name = @"Alternate Visit Id",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PAT_ID_0192",
            DataTypeName = @"Patient Id With Table 0192",
            TableId = null,
            TableName = null,
            Description = @"optional visit ID number to be used if needed.   -  ID used by the facility to uniquely identify a patient at the time of admit.  Refer to HL7 table 0061 - check digit scheme as defined in Chapter 2.  Refer to userdefined table 0192 - visit ID type",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV1.50.1",
                            Type = @"Component",
                            Position = @"PV1.50.1",
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
                            Id = @"PV1.50.2",
                            Type = @"Component",
                            Position = @"PV1.50.2",
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
                            Id = @"PV1.50.3",
                            Type = @"Component",
                            Position = @"PV1.50.3",
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
                            Id = @"PV1.50.4",
                            Type = @"Component",
                            Position = @"PV1.50.4",
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
                            Id = @"PV1.50.5",
                            Type = @"Component",
                            Position = @"PV1.50.5",
                            Name = @"Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0192",
                            TableName = @"VISIT ID TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _alternateVisitId = new HL7V22Field
        {
            field = message[@"PV1"][50],
            fieldData = fieldData
        };

        // check for repetitions
        if (_alternateVisitId.field.FieldRepetitions != null && _alternateVisitId.field.FieldRepetitions.Count > 0)
        {
            _alternateVisitId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_alternateVisitId, fieldData);
        }

        return _alternateVisitId;
    } 
}
    }
}

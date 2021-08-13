using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentPV2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PV2"; } }

        public string SegmentId { get { return @"PV2"; } }
        
        public string LongName { get { return @"Patient Visit - Additional Information"; } }
        
        public string Description { get { return @"The PV2 segment is a continuation of visit specific information contained on the PV1 segment. "; } }
        
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

        public HL7V22SegmentPV2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _priorPendingLocation;

public HL7V22Field PriorPendingLocation
{
    get
    {
        if (_priorPendingLocation != null)
        {
            return _priorPendingLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.1",
            Type = @"Field",
            Position = @"PV2.1",
            Name = @"Prior Pending Location",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_INTERNAL_LOCATION",
            DataTypeName = @"Cm For Location Information In Hospital",
            TableId = null,
            TableName = null,
            Description = @"required only for Cancel Pending Transfer (A27) messages",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.1.1",
                            Type = @"Component",
                            Position = @"PV2.1.1",
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
                            Id = @"PV2.1.2",
                            Type = @"Component",
                            Position = @"PV2.1.2",
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
                            Id = @"PV2.1.3",
                            Type = @"Component",
                            Position = @"PV2.1.3",
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
                            Id = @"PV2.1.4",
                            Type = @"Component",
                            Position = @"PV2.1.4",
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
                            Id = @"PV2.1.5",
                            Type = @"Component",
                            Position = @"PV2.1.5",
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

        _priorPendingLocation = new HL7V22Field
        {
            field = message[@"PV2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priorPendingLocation.field.FieldRepetitions != null && _priorPendingLocation.field.FieldRepetitions.Count > 0)
        {
            _priorPendingLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_priorPendingLocation, fieldData);
        }

        return _priorPendingLocation;
    } 
}

internal HL7V22Field _accommodationCode;

public HL7V22Field AccommodationCode
{
    get
    {
        if (_accommodationCode != null)
        {
            return _accommodationCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.2",
            Type = @"Field",
            Position = @"PV2.2",
            Name = @"Accommodation Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0129",
            TableName = @"ACCOMODATION CODE",
            Description = @"indicates the specific patient accommodations for this visit.  Refer to user-defined table 0129 - accommodation code",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.2.1",
                            Type = @"Component",
                            Position = @"PV2.2.1",
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
                            Id = @"PV2.2.2",
                            Type = @"Component",
                            Position = @"PV2.2.2",
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
                            Id = @"PV2.2.3",
                            Type = @"Component",
                            Position = @"PV2.2.3",
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
                            Id = @"PV2.2.4",
                            Type = @"Component",
                            Position = @"PV2.2.4",
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
                            Id = @"PV2.2.5",
                            Type = @"Component",
                            Position = @"PV2.2.5",
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
                            Id = @"PV2.2.6",
                            Type = @"Component",
                            Position = @"PV2.2.6",
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

        _accommodationCode = new HL7V22Field
        {
            field = message[@"PV2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accommodationCode.field.FieldRepetitions != null && _accommodationCode.field.FieldRepetitions.Count > 0)
        {
            _accommodationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_accommodationCode, fieldData);
        }

        return _accommodationCode;
    } 
}

internal HL7V22Field _admitReason;

public HL7V22Field AdmitReason
{
    get
    {
        if (_admitReason != null)
        {
            return _admitReason;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.3",
            Type = @"Field",
            Position = @"PV2.3",
            Name = @"Admit Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"short description the patient admission reason",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.3.1",
                            Type = @"Component",
                            Position = @"PV2.3.1",
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
                            Id = @"PV2.3.2",
                            Type = @"Component",
                            Position = @"PV2.3.2",
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
                            Id = @"PV2.3.3",
                            Type = @"Component",
                            Position = @"PV2.3.3",
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
                            Id = @"PV2.3.4",
                            Type = @"Component",
                            Position = @"PV2.3.4",
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
                            Id = @"PV2.3.5",
                            Type = @"Component",
                            Position = @"PV2.3.5",
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
                            Id = @"PV2.3.6",
                            Type = @"Component",
                            Position = @"PV2.3.6",
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

        _admitReason = new HL7V22Field
        {
            field = message[@"PV2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_admitReason.field.FieldRepetitions != null && _admitReason.field.FieldRepetitions.Count > 0)
        {
            _admitReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_admitReason, fieldData);
        }

        return _admitReason;
    } 
}

internal HL7V22Field _transferReason;

public HL7V22Field TransferReason
{
    get
    {
        if (_transferReason != null)
        {
            return _transferReason;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.4",
            Type = @"Field",
            Position = @"PV2.4",
            Name = @"Transfer Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"short description of the patient location change reason",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PV2.4.1",
                            Type = @"Component",
                            Position = @"PV2.4.1",
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
                            Id = @"PV2.4.2",
                            Type = @"Component",
                            Position = @"PV2.4.2",
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
                            Id = @"PV2.4.3",
                            Type = @"Component",
                            Position = @"PV2.4.3",
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
                            Id = @"PV2.4.4",
                            Type = @"Component",
                            Position = @"PV2.4.4",
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
                            Id = @"PV2.4.5",
                            Type = @"Component",
                            Position = @"PV2.4.5",
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
                            Id = @"PV2.4.6",
                            Type = @"Component",
                            Position = @"PV2.4.6",
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

        _transferReason = new HL7V22Field
        {
            field = message[@"PV2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transferReason.field.FieldRepetitions != null && _transferReason.field.FieldRepetitions.Count > 0)
        {
            _transferReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_transferReason, fieldData);
        }

        return _transferReason;
    } 
}

internal HL7V22Field _patientValuables;

public HL7V22Field PatientValuables
{
    get
    {
        if (_patientValuables != null)
        {
            return _patientValuables;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.5",
            Type = @"Field",
            Position = @"PV2.5",
            Name = @"Patient Valuables",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"short description of patient valuables checked in during admission",
            Sample = @"",
            Fields = null
        }

        _patientValuables = new HL7V22Field
        {
            field = message[@"PV2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuables.field.FieldRepetitions != null && _patientValuables.field.FieldRepetitions.Count > 0)
        {
            _patientValuables.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientValuables, fieldData);
        }

        return _patientValuables;
    } 
}

internal HL7V22Field _patientValuablesLocation;

public HL7V22Field PatientValuablesLocation
{
    get
    {
        if (_patientValuablesLocation != null)
        {
            return _patientValuablesLocation;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.6",
            Type = @"Field",
            Position = @"PV2.6",
            Name = @"Patient Valuables Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"indicates the location of the patient's valuables",
            Sample = @"",
            Fields = null
        }

        _patientValuablesLocation = new HL7V22Field
        {
            field = message[@"PV2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientValuablesLocation.field.FieldRepetitions != null && _patientValuablesLocation.field.FieldRepetitions.Count > 0)
        {
            _patientValuablesLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_patientValuablesLocation, fieldData);
        }

        return _patientValuablesLocation;
    } 
}

internal HL7V22Field _visitUserCode;

public HL7V22Field VisitUserCode
{
    get
    {
        if (_visitUserCode != null)
        {
            return _visitUserCode;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.7",
            Type = @"Field",
            Position = @"PV2.7",
            Name = @"Visit User Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0130",
            TableName = @"VISIT USER CODE",
            Description = @"further categorizes a patient's visit with respect to an individual institution's needs (e.g., teaching flag = TE, indicating the patient is a teaching case).  Refer to user-defined table 0130 - visit user code",
            Sample = @"",
            Fields = null
        }

        _visitUserCode = new HL7V22Field
        {
            field = message[@"PV2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_visitUserCode.field.FieldRepetitions != null && _visitUserCode.field.FieldRepetitions.Count > 0)
        {
            _visitUserCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_visitUserCode, fieldData);
        }

        return _visitUserCode;
    } 
}

internal HL7V22Field _expectedAdmitDate;

public HL7V22Field ExpectedAdmitDate
{
    get
    {
        if (_expectedAdmitDate != null)
        {
            return _expectedAdmitDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.8",
            Type = @"Field",
            Position = @"PV2.8",
            Name = @"Expected Admit Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date patient expected to be admitted",
            Sample = @"",
            Fields = null
        }

        _expectedAdmitDate = new HL7V22Field
        {
            field = message[@"PV2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedAdmitDate.field.FieldRepetitions != null && _expectedAdmitDate.field.FieldRepetitions.Count > 0)
        {
            _expectedAdmitDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_expectedAdmitDate, fieldData);
        }

        return _expectedAdmitDate;
    } 
}

internal HL7V22Field _expectedDischargeDate;

public HL7V22Field ExpectedDischargeDate
{
    get
    {
        if (_expectedDischargeDate != null)
        {
            return _expectedDischargeDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"PV2.9",
            Type = @"Field",
            Position = @"PV2.9",
            Name = @"Expected Discharge Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"non-event related date used by ancillaries to more accurately determine projected workloads",
            Sample = @"",
            Fields = null
        }

        _expectedDischargeDate = new HL7V22Field
        {
            field = message[@"PV2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_expectedDischargeDate.field.FieldRepetitions != null && _expectedDischargeDate.field.FieldRepetitions.Count > 0)
        {
            _expectedDischargeDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_expectedDischargeDate, fieldData);
        }

        return _expectedDischargeDate;
    } 
}
    }
}

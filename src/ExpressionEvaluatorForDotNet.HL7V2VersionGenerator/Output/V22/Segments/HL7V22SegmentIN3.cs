using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentIN3
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN3"; } }

        public string SegmentId { get { return @"IN3"; } }
        
        public string LongName { get { return @"Insurance Additional Info-certification"; } }
        
        public string Description { get { return @"The IN3 segment contains additional insurance information for certifying the need for patient care.  Fields used by this segment are defined by HICFA or other regulatory agencies"; } }
        
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

        public HL7V22SegmentIN3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _setIdInsuranceCertification;

public HL7V22Field SetIdInsuranceCertification
{
    get
    {
        if (_setIdInsuranceCertification != null)
        {
            return _setIdInsuranceCertification;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.1",
            Type = @"Field",
            Position = @"IN3.1",
            Name = @"Set Id - Insurance Certification",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"sequence number which uniquely identifies this segment for the purpose of adding, changing, or deleting a certification segment",
            Sample = @"",
            Fields = null
        }

        _setIdInsuranceCertification = new HL7V22Field
        {
            field = message[@"IN3"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIdInsuranceCertification.field.FieldRepetitions != null && _setIdInsuranceCertification.field.FieldRepetitions.Count > 0)
        {
            _setIdInsuranceCertification.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_setIdInsuranceCertification, fieldData);
        }

        return _setIdInsuranceCertification;
    } 
}

internal HL7V22Field _certificationNumber;

public HL7V22Field CertificationNumber
{
    get
    {
        if (_certificationNumber != null)
        {
            return _certificationNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.2",
            Type = @"Field",
            Position = @"IN3.2",
            Name = @"Certification Number",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"assigned by the certification agency",
            Sample = @"",
            Fields = null
        }

        _certificationNumber = new HL7V22Field
        {
            field = message[@"IN3"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationNumber.field.FieldRepetitions != null && _certificationNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationNumber, fieldData);
        }

        return _certificationNumber;
    } 
}

internal HL7V22Field _certifiedBy;

public HL7V22Field CertifiedBy
{
    get
    {
        if (_certifiedBy != null)
        {
            return _certifiedBy;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.3",
            Type = @"Field",
            Position = @"IN3.3",
            Name = @"Certified By",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"party that approved the certification",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.3.1",
                            Type = @"Component",
                            Position = @"IN3.3.1",
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
                            Id = @"IN3.3.2",
                            Type = @"Component",
                            Position = @"IN3.3.2",
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
                            Id = @"IN3.3.3",
                            Type = @"Component",
                            Position = @"IN3.3.3",
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
                            Id = @"IN3.3.4",
                            Type = @"Component",
                            Position = @"IN3.3.4",
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
                            Id = @"IN3.3.5",
                            Type = @"Component",
                            Position = @"IN3.3.5",
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
                            Id = @"IN3.3.6",
                            Type = @"Component",
                            Position = @"IN3.3.6",
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
                            Id = @"IN3.3.7",
                            Type = @"Component",
                            Position = @"IN3.3.7",
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
                            Id = @"IN3.3.8",
                            Type = @"Component",
                            Position = @"IN3.3.8",
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

        _certifiedBy = new HL7V22Field
        {
            field = message[@"IN3"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certifiedBy.field.FieldRepetitions != null && _certifiedBy.field.FieldRepetitions.Count > 0)
        {
            _certifiedBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certifiedBy, fieldData);
        }

        return _certifiedBy;
    } 
}

internal HL7V22Field _certificationRequired;

public HL7V22Field CertificationRequired
{
    get
    {
        if (_certificationRequired != null)
        {
            return _certificationRequired;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.4",
            Type = @"Field",
            Position = @"IN3.4",
            Name = @"Certification Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0136",
            TableName = @"Y/N INDICATOR",
            Description = @"identifies whether certification is required.  Refer to table 0136 - Y/N indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _certificationRequired = new HL7V22Field
        {
            field = message[@"IN3"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationRequired.field.FieldRepetitions != null && _certificationRequired.field.FieldRepetitions.Count > 0)
        {
            _certificationRequired.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationRequired, fieldData);
        }

        return _certificationRequired;
    } 
}

internal HL7V22Field _penalty;

public HL7V22Field Penalty
{
    get
    {
        if (_penalty != null)
        {
            return _penalty;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.5",
            Type = @"Field",
            Position = @"IN3.5",
            Name = @"Penalty",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PEN",
            DataTypeName = @"Penalty",
            TableId = null,
            TableName = null,
            Description = @"the penalty, in dollars or a percentage, that will be assessed if the pre-certification is not performed.  Refer to user-defined table 0148 - penalty type for suggested entries",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.5.1",
                            Type = @"Component",
                            Position = @"IN3.5.1",
                            Name = @"Penalty Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0148",
                            TableName = @"PENALTY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.2",
                            Type = @"Component",
                            Position = @"IN3.5.2",
                            Name = @"Penalty Amount",
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

        _penalty = new HL7V22Field
        {
            field = message[@"IN3"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_penalty.field.FieldRepetitions != null && _penalty.field.FieldRepetitions.Count > 0)
        {
            _penalty.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_penalty, fieldData);
        }

        return _penalty;
    } 
}

internal HL7V22Field _certificationDateTime;

public HL7V22Field CertificationDateTime
{
    get
    {
        if (_certificationDateTime != null)
        {
            return _certificationDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.6",
            Type = @"Field",
            Position = @"IN3.6",
            Name = @"Certification Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date and time stamp when insurance was certified to exist for the patient",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.6.1",
                            Type = @"Component",
                            Position = @"IN3.6.1",
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
                            Id = @"IN3.6.2",
                            Type = @"Component",
                            Position = @"IN3.6.2",
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

        _certificationDateTime = new HL7V22Field
        {
            field = message[@"IN3"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationDateTime.field.FieldRepetitions != null && _certificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _certificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationDateTime, fieldData);
        }

        return _certificationDateTime;
    } 
}

internal HL7V22Field _certificationModifyDateTime;

public HL7V22Field CertificationModifyDateTime
{
    get
    {
        if (_certificationModifyDateTime != null)
        {
            return _certificationModifyDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.7",
            Type = @"Field",
            Position = @"IN3.7",
            Name = @"Certification Modify Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"date/time that the certification was modified",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.7.1",
                            Type = @"Component",
                            Position = @"IN3.7.1",
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
                            Id = @"IN3.7.2",
                            Type = @"Component",
                            Position = @"IN3.7.2",
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

        _certificationModifyDateTime = new HL7V22Field
        {
            field = message[@"IN3"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationModifyDateTime.field.FieldRepetitions != null && _certificationModifyDateTime.field.FieldRepetitions.Count > 0)
        {
            _certificationModifyDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationModifyDateTime, fieldData);
        }

        return _certificationModifyDateTime;
    } 
}

internal HL7V22Field _operator;

public HL7V22Field Operator
{
    get
    {
        if (_operator != null)
        {
            return _operator;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.8",
            Type = @"Field",
            Position = @"IN3.8",
            Name = @"Operator",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"party that is responsible for sending this certification information",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.8.1",
                            Type = @"Component",
                            Position = @"IN3.8.1",
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
                            Id = @"IN3.8.2",
                            Type = @"Component",
                            Position = @"IN3.8.2",
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
                            Id = @"IN3.8.3",
                            Type = @"Component",
                            Position = @"IN3.8.3",
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
                            Id = @"IN3.8.4",
                            Type = @"Component",
                            Position = @"IN3.8.4",
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
                            Id = @"IN3.8.5",
                            Type = @"Component",
                            Position = @"IN3.8.5",
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
                            Id = @"IN3.8.6",
                            Type = @"Component",
                            Position = @"IN3.8.6",
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
                            Id = @"IN3.8.7",
                            Type = @"Component",
                            Position = @"IN3.8.7",
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
                            Id = @"IN3.8.8",
                            Type = @"Component",
                            Position = @"IN3.8.8",
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

        _operator = new HL7V22Field
        {
            field = message[@"IN3"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_operator.field.FieldRepetitions != null && _operator.field.FieldRepetitions.Count > 0)
        {
            _operator.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_operator, fieldData);
        }

        return _operator;
    } 
}

internal HL7V22Field _certificationBeginDate;

public HL7V22Field CertificationBeginDate
{
    get
    {
        if (_certificationBeginDate != null)
        {
            return _certificationBeginDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.9",
            Type = @"Field",
            Position = @"IN3.9",
            Name = @"Certification Begin Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that this certification begins",
            Sample = @"",
            Fields = null
        }

        _certificationBeginDate = new HL7V22Field
        {
            field = message[@"IN3"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationBeginDate.field.FieldRepetitions != null && _certificationBeginDate.field.FieldRepetitions.Count > 0)
        {
            _certificationBeginDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationBeginDate, fieldData);
        }

        return _certificationBeginDate;
    } 
}

internal HL7V22Field _certificationEndDate;

public HL7V22Field CertificationEndDate
{
    get
    {
        if (_certificationEndDate != null)
        {
            return _certificationEndDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.10",
            Type = @"Field",
            Position = @"IN3.10",
            Name = @"Certification End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that this certification ends",
            Sample = @"",
            Fields = null
        }

        _certificationEndDate = new HL7V22Field
        {
            field = message[@"IN3"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationEndDate.field.FieldRepetitions != null && _certificationEndDate.field.FieldRepetitions.Count > 0)
        {
            _certificationEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationEndDate, fieldData);
        }

        return _certificationEndDate;
    } 
}

internal HL7V22Field _days;

public HL7V22Field Days
{
    get
    {
        if (_days != null)
        {
            return _days;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.11",
            Type = @"Field",
            Position = @"IN3.11",
            Name = @"Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DTN",
            DataTypeName = @"Day Type And Number",
            TableId = null,
            TableName = null,
            Description = @"number of days for which this certification is valid.  This field will apply to denied, pending, or approved days.  Refer to user-defined table 0149 - day type for suggested entries",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.11.1",
                            Type = @"Component",
                            Position = @"IN3.11.1",
                            Name = @"Day Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0149",
                            TableName = @"DAY TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.2",
                            Type = @"Component",
                            Position = @"IN3.11.2",
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

        _days = new HL7V22Field
        {
            field = message[@"IN3"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_days.field.FieldRepetitions != null && _days.field.FieldRepetitions.Count > 0)
        {
            _days.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_days, fieldData);
        }

        return _days;
    } 
}

internal HL7V22Field _nonconcurCodeDescription;

public HL7V22Field NonconcurCodeDescription
{
    get
    {
        if (_nonconcurCodeDescription != null)
        {
            return _nonconcurCodeDescription;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.12",
            Type = @"Field",
            Position = @"IN3.12",
            Name = @"Non-concur Code / Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"non-concur code and description for a denied request",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.12.1",
                            Type = @"Component",
                            Position = @"IN3.12.1",
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
                            Id = @"IN3.12.2",
                            Type = @"Component",
                            Position = @"IN3.12.2",
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
                            Id = @"IN3.12.3",
                            Type = @"Component",
                            Position = @"IN3.12.3",
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
                            Id = @"IN3.12.4",
                            Type = @"Component",
                            Position = @"IN3.12.4",
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
                            Id = @"IN3.12.5",
                            Type = @"Component",
                            Position = @"IN3.12.5",
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
                            Id = @"IN3.12.6",
                            Type = @"Component",
                            Position = @"IN3.12.6",
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

        _nonconcurCodeDescription = new HL7V22Field
        {
            field = message[@"IN3"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonconcurCodeDescription.field.FieldRepetitions != null && _nonconcurCodeDescription.field.FieldRepetitions.Count > 0)
        {
            _nonconcurCodeDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nonconcurCodeDescription, fieldData);
        }

        return _nonconcurCodeDescription;
    } 
}

internal HL7V22Field _nonconcurEffectiveDateTime;

public HL7V22Field NonconcurEffectiveDateTime
{
    get
    {
        if (_nonconcurEffectiveDateTime != null)
        {
            return _nonconcurEffectiveDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.13",
            Type = @"Field",
            Position = @"IN3.13",
            Name = @"Non-concur Effective Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"effective date of the non-concurrence classification",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.13.1",
                            Type = @"Component",
                            Position = @"IN3.13.1",
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
                            Id = @"IN3.13.2",
                            Type = @"Component",
                            Position = @"IN3.13.2",
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

        _nonconcurEffectiveDateTime = new HL7V22Field
        {
            field = message[@"IN3"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonconcurEffectiveDateTime.field.FieldRepetitions != null && _nonconcurEffectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            _nonconcurEffectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_nonconcurEffectiveDateTime, fieldData);
        }

        return _nonconcurEffectiveDateTime;
    } 
}

internal HL7V22Field _physicianReviewer;

public HL7V22Field PhysicianReviewer
{
    get
    {
        if (_physicianReviewer != null)
        {
            return _physicianReviewer;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.14",
            Type = @"Field",
            Position = @"IN3.14",
            Name = @"Physician Reviewer",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"physician who works with and reviews cases that are pending physician review for the certification agency",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.14.1",
                            Type = @"Component",
                            Position = @"IN3.14.1",
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
                            Id = @"IN3.14.2",
                            Type = @"Component",
                            Position = @"IN3.14.2",
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
                            Id = @"IN3.14.3",
                            Type = @"Component",
                            Position = @"IN3.14.3",
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
                            Id = @"IN3.14.4",
                            Type = @"Component",
                            Position = @"IN3.14.4",
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
                            Id = @"IN3.14.5",
                            Type = @"Component",
                            Position = @"IN3.14.5",
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
                            Id = @"IN3.14.6",
                            Type = @"Component",
                            Position = @"IN3.14.6",
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
                            Id = @"IN3.14.7",
                            Type = @"Component",
                            Position = @"IN3.14.7",
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
                            Id = @"IN3.14.8",
                            Type = @"Component",
                            Position = @"IN3.14.8",
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

        _physicianReviewer = new HL7V22Field
        {
            field = message[@"IN3"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_physicianReviewer.field.FieldRepetitions != null && _physicianReviewer.field.FieldRepetitions.Count > 0)
        {
            _physicianReviewer.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_physicianReviewer, fieldData);
        }

        return _physicianReviewer;
    } 
}

internal HL7V22Field _certificationContact;

public HL7V22Field CertificationContact
{
    get
    {
        if (_certificationContact != null)
        {
            return _certificationContact;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.15",
            Type = @"Field",
            Position = @"IN3.15",
            Name = @"Certification Contact",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"name of the party contacted at the certification agency who granted the certification and communicated the certification number",
            Sample = @"",
            Fields = null
        }

        _certificationContact = new HL7V22Field
        {
            field = message[@"IN3"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationContact.field.FieldRepetitions != null && _certificationContact.field.FieldRepetitions.Count > 0)
        {
            _certificationContact.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationContact, fieldData);
        }

        return _certificationContact;
    } 
}

internal HL7V22Field _certificationContactPhoneNumber;

public HL7V22Field CertificationContactPhoneNumber
{
    get
    {
        if (_certificationContactPhoneNumber != null)
        {
            return _certificationContactPhoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.16",
            Type = @"Field",
            Position = @"IN3.16",
            Name = @"Certification Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"phone number of the certification contact",
            Sample = @"",
            Fields = null
        }

        _certificationContactPhoneNumber = new HL7V22Field
        {
            field = message[@"IN3"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationContactPhoneNumber.field.FieldRepetitions != null && _certificationContactPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationContactPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationContactPhoneNumber, fieldData);
        }

        return _certificationContactPhoneNumber;
    } 
}

internal HL7V22Field _appealReason;

public HL7V22Field AppealReason
{
    get
    {
        if (_appealReason != null)
        {
            return _appealReason;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.17",
            Type = @"Field",
            Position = @"IN3.17",
            Name = @"Appeal Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"reason an appeal was made on a non-concur for certification",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.17.1",
                            Type = @"Component",
                            Position = @"IN3.17.1",
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
                            Id = @"IN3.17.2",
                            Type = @"Component",
                            Position = @"IN3.17.2",
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
                            Id = @"IN3.17.3",
                            Type = @"Component",
                            Position = @"IN3.17.3",
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
                            Id = @"IN3.17.4",
                            Type = @"Component",
                            Position = @"IN3.17.4",
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
                            Id = @"IN3.17.5",
                            Type = @"Component",
                            Position = @"IN3.17.5",
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
                            Id = @"IN3.17.6",
                            Type = @"Component",
                            Position = @"IN3.17.6",
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

        _appealReason = new HL7V22Field
        {
            field = message[@"IN3"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appealReason.field.FieldRepetitions != null && _appealReason.field.FieldRepetitions.Count > 0)
        {
            _appealReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_appealReason, fieldData);
        }

        return _appealReason;
    } 
}

internal HL7V22Field _certificationAgency;

public HL7V22Field CertificationAgency
{
    get
    {
        if (_certificationAgency != null)
        {
            return _certificationAgency;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.18",
            Type = @"Field",
            Position = @"IN3.18",
            Name = @"Certification Agency",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"certification agency",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.18.1",
                            Type = @"Component",
                            Position = @"IN3.18.1",
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
                            Id = @"IN3.18.2",
                            Type = @"Component",
                            Position = @"IN3.18.2",
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
                            Id = @"IN3.18.3",
                            Type = @"Component",
                            Position = @"IN3.18.3",
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
                            Id = @"IN3.18.4",
                            Type = @"Component",
                            Position = @"IN3.18.4",
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
                            Id = @"IN3.18.5",
                            Type = @"Component",
                            Position = @"IN3.18.5",
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
                            Id = @"IN3.18.6",
                            Type = @"Component",
                            Position = @"IN3.18.6",
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

        _certificationAgency = new HL7V22Field
        {
            field = message[@"IN3"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationAgency.field.FieldRepetitions != null && _certificationAgency.field.FieldRepetitions.Count > 0)
        {
            _certificationAgency.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationAgency, fieldData);
        }

        return _certificationAgency;
    } 
}

internal HL7V22Field _certificationAgencyPhoneNumber;

public HL7V22Field CertificationAgencyPhoneNumber
{
    get
    {
        if (_certificationAgencyPhoneNumber != null)
        {
            return _certificationAgencyPhoneNumber;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.19",
            Type = @"Field",
            Position = @"IN3.19",
            Name = @"Certification Agency Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"3",
            DataType = @"TN",
            DataTypeName = @"Telephone Number",
            TableId = null,
            TableName = null,
            Description = @"phone number of the Certification agency",
            Sample = @"",
            Fields = null
        }

        _certificationAgencyPhoneNumber = new HL7V22Field
        {
            field = message[@"IN3"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationAgencyPhoneNumber.field.FieldRepetitions != null && _certificationAgencyPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationAgencyPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_certificationAgencyPhoneNumber, fieldData);
        }

        return _certificationAgencyPhoneNumber;
    } 
}

internal HL7V22Field _precertificationRequiredWindow;

public HL7V22Field PrecertificationRequiredWindow
{
    get
    {
        if (_precertificationRequiredWindow != null)
        {
            return _precertificationRequiredWindow;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.20",
            Type = @"Field",
            Position = @"IN3.20",
            Name = @"Pre-certification Required / Window",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PCF",
            DataTypeName = @"Pre-certification Required",
            TableId = null,
            TableName = null,
            Description = @"identifies whether pre-certification is required for particular patient types and the time window for obtaining the certification.  Refer to user-defined table 0150 - pre-certification patient type for suggested values.  Valid values for the pre-certification required component are found in table 0136 - Y/N indicator.  The pre-certification window is the amount of time needed to be certified from arrival at the institution.  Its format follows the time stamp (TS) data type rules",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.20.1",
                            Type = @"Component",
                            Position = @"IN3.20.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0150",
                            TableName = @"PRECERTIFICATION PATIENT TYPE",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.2",
                            Type = @"Component",
                            Position = @"IN3.20.2",
                            Name = @"Pre-certication Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3",
                            Type = @"Component",
                            Position = @"IN3.20.3",
                            Name = @"Pre-certification Window",
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
                            Id = @"IN3.20.3.1",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.1",
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
                            Id = @"IN3.20.3.2",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.2",
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

        _precertificationRequiredWindow = new HL7V22Field
        {
            field = message[@"IN3"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_precertificationRequiredWindow.field.FieldRepetitions != null && _precertificationRequiredWindow.field.FieldRepetitions.Count > 0)
        {
            _precertificationRequiredWindow.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_precertificationRequiredWindow, fieldData);
        }

        return _precertificationRequiredWindow;
    } 
}

internal HL7V22Field _caseManager;

public HL7V22Field CaseManager
{
    get
    {
        if (_caseManager != null)
        {
            return _caseManager;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.21",
            Type = @"Field",
            Position = @"IN3.21",
            Name = @"Case Manager",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"entity who/which is handling this particular patient's case (e.g., UR nurse, or a specific facility location).",
            Sample = @"",
            Fields = null
        }

        _caseManager = new HL7V22Field
        {
            field = message[@"IN3"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_caseManager.field.FieldRepetitions != null && _caseManager.field.FieldRepetitions.Count > 0)
        {
            _caseManager.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_caseManager, fieldData);
        }

        return _caseManager;
    } 
}

internal HL7V22Field _secondOpinionDate;

public HL7V22Field SecondOpinionDate
{
    get
    {
        if (_secondOpinionDate != null)
        {
            return _secondOpinionDate;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.22",
            Type = @"Field",
            Position = @"IN3.22",
            Name = @"Second Opinion Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"date that the second opinion was obtained",
            Sample = @"",
            Fields = null
        }

        _secondOpinionDate = new HL7V22Field
        {
            field = message[@"IN3"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionDate.field.FieldRepetitions != null && _secondOpinionDate.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_secondOpinionDate, fieldData);
        }

        return _secondOpinionDate;
    } 
}

internal HL7V22Field _secondOpinionStatus;

public HL7V22Field SecondOpinionStatus
{
    get
    {
        if (_secondOpinionStatus != null)
        {
            return _secondOpinionStatus;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.23",
            Type = @"Field",
            Position = @"IN3.23",
            Name = @"Second Opinion Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0151",
            TableName = @"SECOND OPINION STATUS",
            Description = @"Code that represents the status of the second opinion.  Refer to user-defined table 0151 - second opinion status for suggested values",
            Sample = @"",
            Fields = null
        }

        _secondOpinionStatus = new HL7V22Field
        {
            field = message[@"IN3"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionStatus.field.FieldRepetitions != null && _secondOpinionStatus.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_secondOpinionStatus, fieldData);
        }

        return _secondOpinionStatus;
    } 
}

internal HL7V22Field _secondOpinionDocumentationReceived;

public HL7V22Field SecondOpinionDocumentationReceived
{
    get
    {
        if (_secondOpinionDocumentationReceived != null)
        {
            return _secondOpinionDocumentationReceived;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.24",
            Type = @"Field",
            Position = @"IN3.24",
            Name = @"Second Opinion Documentation Received",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0152",
            TableName = @"SECOND OPINION DOCUMENTATION RECEIVED",
            Description = @"if accompanying documentation has been received by the provider.  Refer to table 0152 - second opinion documentation received",
            Sample = @"",
            Fields = null
        }

        _secondOpinionDocumentationReceived = new HL7V22Field
        {
            field = message[@"IN3"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionDocumentationReceived.field.FieldRepetitions != null && _secondOpinionDocumentationReceived.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionDocumentationReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_secondOpinionDocumentationReceived, fieldData);
        }

        return _secondOpinionDocumentationReceived;
    } 
}

internal HL7V22Field _secondOpinionPractitioner;

public HL7V22Field SecondOpinionPractitioner
{
    get
    {
        if (_secondOpinionPractitioner != null)
        {
            return _secondOpinionPractitioner;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"IN3.25",
            Type = @"Field",
            Position = @"IN3.25",
            Name = @"Second Opinion Practitioner",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CN_PERSON",
            DataTypeName = @"Cn For Person",
            TableId = null,
            TableName = null,
            Description = @"ID and name of the physician who provided the second opinion",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.25.1",
                            Type = @"Component",
                            Position = @"IN3.25.1",
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
                            Id = @"IN3.25.2",
                            Type = @"Component",
                            Position = @"IN3.25.2",
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
                            Id = @"IN3.25.3",
                            Type = @"Component",
                            Position = @"IN3.25.3",
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
                            Id = @"IN3.25.4",
                            Type = @"Component",
                            Position = @"IN3.25.4",
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
                            Id = @"IN3.25.5",
                            Type = @"Component",
                            Position = @"IN3.25.5",
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
                            Id = @"IN3.25.6",
                            Type = @"Component",
                            Position = @"IN3.25.6",
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
                            Id = @"IN3.25.7",
                            Type = @"Component",
                            Position = @"IN3.25.7",
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
                            Id = @"IN3.25.8",
                            Type = @"Component",
                            Position = @"IN3.25.8",
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

        _secondOpinionPractitioner = new HL7V22Field
        {
            field = message[@"IN3"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionPractitioner.field.FieldRepetitions != null && _secondOpinionPractitioner.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionPractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_secondOpinionPractitioner, fieldData);
        }

        return _secondOpinionPractitioner;
    } 
}
    }
}

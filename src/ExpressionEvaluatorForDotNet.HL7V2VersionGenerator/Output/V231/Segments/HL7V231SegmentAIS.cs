using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentAIS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AIS"; } }

        public string SegmentId { get { return @"AIS"; } }
        
        public string LongName { get { return @"Appointment information - service segment"; } }
        
        public string Description { get { return @"The AIS segment contains information about various kinds of services that can be scheduled. Services included in a transaction using this segment are assumed to be controlled by a schedule on a schedule filler application. Services not controlled by a schedule are not identified on a schedule request using this segment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V231SegmentAIS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDAIS;

public HL7V231Field SetIDAIS
{
    get
    {
        if (_setIDAIS != null)
        {
            return _setIDAIS;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.1",
            Type = @"Field",
            Position = @"AIS.1",
            Name = @"Set ID - AIS",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains a number that uniquely identifies the information represented by this segment in this transaction for the purposes of addition, change or deletion.",
            Sample = @"",
            Fields = null
        }

        _setIDAIS = new HL7V231Field
        {
            field = message[@"AIS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDAIS.field.FieldRepetitions != null && _setIDAIS.field.FieldRepetitions.Count > 0)
        {
            _setIDAIS.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDAIS, fieldData);
        }

        return _setIDAIS;
    } 
}

internal HL7V231Field _segmentActionCode;

public HL7V231Field SegmentActionCode
{
    get
    {
        if (_segmentActionCode != null)
        {
            return _segmentActionCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.2",
            Type = @"Field",
            Position = @"AIS.2",
            Name = @"Segment Action Code",
            Length = 3,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 table 0206 - Segment action code in Chapter 2, Section 2.23.4.2, 'Action code/unique identifier mode update definition,' for valid values.",
            Sample = @"",
            Fields = null
        }

        _segmentActionCode = new HL7V231Field
        {
            field = message[@"AIS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentActionCode.field.FieldRepetitions != null && _segmentActionCode.field.FieldRepetitions.Count > 0)
        {
            _segmentActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_segmentActionCode, fieldData);
        }

        return _segmentActionCode;
    } 
}

internal HL7V231Field _universalServiceID;

public HL7V231Field UniversalServiceID
{
    get
    {
        if (_universalServiceID != null)
        {
            return _universalServiceID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.3",
            Type = @"Field",
            Position = @"AIS.3",
            Name = @"Universal Service ID",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code for a service to be scheduled. This field may contain a Universal Service ID describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the Universal Service ID defined for the OBR segment in the Order Entry chapter (Chapter 4). This code can be based on local and/or universal codes. The use of universal codes is recommended.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.3.1",
                            Type = @"Component",
                            Position = @"AIS.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.2",
                            Type = @"Component",
                            Position = @"AIS.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.3",
                            Type = @"Component",
                            Position = @"AIS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.4",
                            Type = @"Component",
                            Position = @"AIS.3.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.5",
                            Type = @"Component",
                            Position = @"AIS.3.5",
                            Name = @"Alternate Text",
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
                            Id = @"AIS.3.6",
                            Type = @"Component",
                            Position = @"AIS.3.6",
                            Name = @"Name Of Alternate Coding System",
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

        _universalServiceID = new HL7V231Field
        {
            field = message[@"AIS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_universalServiceID.field.FieldRepetitions != null && _universalServiceID.field.FieldRepetitions.Count > 0)
        {
            _universalServiceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_universalServiceID, fieldData);
        }

        return _universalServiceID;
    } 
}

internal HL7V231Field _startDateTime;

public HL7V231Field StartDateTime
{
    get
    {
        if (_startDateTime != null)
        {
            return _startDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.4",
            Type = @"Field",
            Position = @"AIS.4",
            Name = @"Start Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.4.1",
                            Type = @"Component",
                            Position = @"AIS.4.1",
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
                        }
        }

        _startDateTime = new HL7V231Field
        {
            field = message[@"AIS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTime.field.FieldRepetitions != null && _startDateTime.field.FieldRepetitions.Count > 0)
        {
            _startDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_startDateTime, fieldData);
        }

        return _startDateTime;
    } 
}

internal HL7V231Field _startDateTimeOffset;

public HL7V231Field StartDateTimeOffset
{
    get
    {
        if (_startDateTimeOffset != null)
        {
            return _startDateTimeOffset;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.5",
            Type = @"Field",
            Position = @"AIS.5",
            Name = @"Start Date/Time Offset",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time. The first component contains the offset amount. An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment.",
            Sample = @"",
            Fields = null
        }

        _startDateTimeOffset = new HL7V231Field
        {
            field = message[@"AIS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTimeOffset.field.FieldRepetitions != null && _startDateTimeOffset.field.FieldRepetitions.Count > 0)
        {
            _startDateTimeOffset.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_startDateTimeOffset, fieldData);
        }

        return _startDateTimeOffset;
    } 
}

internal HL7V231Field _startDateTimeOffsetUnits;

public HL7V231Field StartDateTimeOffsetUnits
{
    get
    {
        if (_startDateTimeOffsetUnits != null)
        {
            return _startDateTimeOffsetUnits;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.6",
            Type = @"Field",
            Position = @"AIS.6",
            Name = @"Start Date/Time Offset Units",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code s) will be assumed. Refer to Chapter 7, Figures 7-10 through 7-13, for a list of ISO and ANSI+ unit codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.6.1",
                            Type = @"Component",
                            Position = @"AIS.6.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.2",
                            Type = @"Component",
                            Position = @"AIS.6.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.3",
                            Type = @"Component",
                            Position = @"AIS.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.4",
                            Type = @"Component",
                            Position = @"AIS.6.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.5",
                            Type = @"Component",
                            Position = @"AIS.6.5",
                            Name = @"Alternate Text",
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
                            Id = @"AIS.6.6",
                            Type = @"Component",
                            Position = @"AIS.6.6",
                            Name = @"Name Of Alternate Coding System",
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

        _startDateTimeOffsetUnits = new HL7V231Field
        {
            field = message[@"AIS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTimeOffsetUnits.field.FieldRepetitions != null && _startDateTimeOffsetUnits.field.FieldRepetitions.Count > 0)
        {
            _startDateTimeOffsetUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_startDateTimeOffsetUnits, fieldData);
        }

        return _startDateTimeOffsetUnits;
    } 
}

internal HL7V231Field _duration;

public HL7V231Field Duration
{
    get
    {
        if (_duration != null)
        {
            return _duration;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.7",
            Type = @"Field",
            Position = @"AIS.7",
            Name = @"Duration",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the duration for which the resource is requested/scheduled for this appointment, if different from the overall duration of the requested/scheduled appointment. This field indicates to the application that a resource is required for a different amount of time than the appointment's overall duration. An unvalued duration indicates that the resource is required from its start date/time offset (specified in the previous two fields) until the end of the appointment. If no start date/time offset is specified, then the resource is required for the full duration of the appointment.",
            Sample = @"",
            Fields = null
        }

        _duration = new HL7V231Field
        {
            field = message[@"AIS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_duration.field.FieldRepetitions != null && _duration.field.FieldRepetitions.Count > 0)
        {
            _duration.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_duration, fieldData);
        }

        return _duration;
    } 
}

internal HL7V231Field _durationUnits;

public HL7V231Field DurationUnits
{
    get
    {
        if (_durationUnits != null)
        {
            return _durationUnits;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.8",
            Type = @"Field",
            Position = @"AIS.8",
            Name = @"Duration Units",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the duration. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code s) will be assumed. Refer to Chapter 7, Figures 7-10 through 7-13, for a list of ISO and ANSI+ unit codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.8.1",
                            Type = @"Component",
                            Position = @"AIS.8.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.2",
                            Type = @"Component",
                            Position = @"AIS.8.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.3",
                            Type = @"Component",
                            Position = @"AIS.8.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.4",
                            Type = @"Component",
                            Position = @"AIS.8.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.5",
                            Type = @"Component",
                            Position = @"AIS.8.5",
                            Name = @"Alternate Text",
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
                            Id = @"AIS.8.6",
                            Type = @"Component",
                            Position = @"AIS.8.6",
                            Name = @"Name Of Alternate Coding System",
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

        _durationUnits = new HL7V231Field
        {
            field = message[@"AIS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_durationUnits.field.FieldRepetitions != null && _durationUnits.field.FieldRepetitions.Count > 0)
        {
            _durationUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_durationUnits, fieldData);
        }

        return _durationUnits;
    } 
}

internal HL7V231Field _allowSubstitutionCode;

public HL7V231Field AllowSubstitutionCode
{
    get
    {
        if (_allowSubstitutionCode != null)
        {
            return _allowSubstitutionCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.9",
            Type = @"Field",
            Position = @"AIS.9",
            Name = @"Allow Substitution Code",
            Length = 10,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0279",
            TableName = @"Allow substitution codes",
            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to user-defined table 0279 - Allow substitution codes for suggested codes.",
            Sample = @"",
            Fields = null
        }

        _allowSubstitutionCode = new HL7V231Field
        {
            field = message[@"AIS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_allowSubstitutionCode.field.FieldRepetitions != null && _allowSubstitutionCode.field.FieldRepetitions.Count > 0)
        {
            _allowSubstitutionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_allowSubstitutionCode, fieldData);
        }

        return _allowSubstitutionCode;
    } 
}

internal HL7V231Field _fillerStatusCode;

public HL7V231Field FillerStatusCode
{
    get
    {
        if (_fillerStatusCode != null)
        {
            return _fillerStatusCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"AIS.10",
            Type = @"Field",
            Position = @"AIS.10",
            Name = @"Filler Status Code",
            Length = 200,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0278",
            TableName = @"Filler status codes",
            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application. Refer to user-defined table 0278 - Filler status codes for suggested codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.10.1",
                            Type = @"Component",
                            Position = @"AIS.10.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.2",
                            Type = @"Component",
                            Position = @"AIS.10.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.3",
                            Type = @"Component",
                            Position = @"AIS.10.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.4",
                            Type = @"Component",
                            Position = @"AIS.10.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.5",
                            Type = @"Component",
                            Position = @"AIS.10.5",
                            Name = @"Alternate Text",
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
                            Id = @"AIS.10.6",
                            Type = @"Component",
                            Position = @"AIS.10.6",
                            Name = @"Name Of Alternate Coding System",
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

        _fillerStatusCode = new HL7V231Field
        {
            field = message[@"AIS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerStatusCode.field.FieldRepetitions != null && _fillerStatusCode.field.FieldRepetitions.Count > 0)
        {
            _fillerStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_fillerStatusCode, fieldData);
        }

        return _fillerStatusCode;
    } 
}
    }
}

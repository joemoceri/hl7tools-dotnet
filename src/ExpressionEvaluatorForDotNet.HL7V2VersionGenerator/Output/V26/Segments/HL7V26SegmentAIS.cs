using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentAIS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AIS"; } }

        public string SegmentId { get { return @"AIS"; } }
        
        public string LongName { get { return @"Appointment Information"; } }
        
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

        public HL7V26SegmentAIS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDAIS;

public HL7V26Field SetIDAIS
{
    get
    {
        if (_setIDAIS != null)
        {
            return _setIDAIS;
        }

        var fieldData = new HL7V26FieldData
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

        _setIDAIS = new HL7V26Field
        {
            field = message[@"AIS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDAIS.field.FieldRepetitions != null && _setIDAIS.field.FieldRepetitions.Count > 0)
        {
            _setIDAIS.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDAIS, fieldData);
        }

        return _setIDAIS;
    } 
}

internal HL7V26Field _segmentActionCode;

public HL7V26Field SegmentActionCode
{
    get
    {
        if (_segmentActionCode != null)
        {
            return _segmentActionCode;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the action to be taken when updating or modifying information in this segment from previously sent interface transactions. Refer to HL7 Table 0206 - Segment action code in Chapter 2, Section 2.10.4.2, ""Action code/unique identifier mode update definition,"" for valid values.

This field is conditionally required.  It is required for all updating or modifying trigger events.",
            Sample = @"",
            Fields = null
        }

        _segmentActionCode = new HL7V26Field
        {
            field = message[@"AIS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentActionCode.field.FieldRepetitions != null && _segmentActionCode.field.FieldRepetitions.Count > 0)
        {
            _segmentActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_segmentActionCode, fieldData);
        }

        return _segmentActionCode;
    } 
}

internal HL7V26Field _universalServiceIdentifier;

public HL7V26Field UniversalServiceIdentifier
{
    get
    {
        if (_universalServiceIdentifier != null)
        {
            return _universalServiceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.3",
            Type = @"Field",
            Position = @"AIS.3",
            Name = @"Universal Service Identifier",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier code for a service to be scheduled. This field may contain a universal service identifier describing the observation/test/battery/procedure or other activity that is to be performed during the requested appointment, similar to the universal service identifier defined for the OBR segment in the Order Entry chapter (Chapter 4). This code can be based on local and/or universal codes. The use of universal codes is recommended.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.3.1",
                            Type = @"Component",
                            Position = @"AIS.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.2",
                            Type = @"Component",
                            Position = @"AIS.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.3",
                            Type = @"Component",
                            Position = @"AIS.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.4",
                            Type = @"Component",
                            Position = @"AIS.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.5",
                            Type = @"Component",
                            Position = @"AIS.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.6",
                            Type = @"Component",
                            Position = @"AIS.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.7",
                            Type = @"Component",
                            Position = @"AIS.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.8",
                            Type = @"Component",
                            Position = @"AIS.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.3.9",
                            Type = @"Component",
                            Position = @"AIS.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _universalServiceIdentifier = new HL7V26Field
        {
            field = message[@"AIS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_universalServiceIdentifier.field.FieldRepetitions != null && _universalServiceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _universalServiceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_universalServiceIdentifier, fieldData);
        }

        return _universalServiceIdentifier;
    } 
}

internal HL7V26Field _startDateTime;

public HL7V26Field StartDateTime
{
    get
    {
        if (_startDateTime != null)
        {
            return _startDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.4",
            Type = @"Field",
            Position = @"AIS.4",
            Name = @"Start Date/Time",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time this service needs for the appointment. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time.

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units.",
            Sample = @"",
            Fields = null
        }

        _startDateTime = new HL7V26Field
        {
            field = message[@"AIS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTime.field.FieldRepetitions != null && _startDateTime.field.FieldRepetitions.Count > 0)
        {
            _startDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startDateTime, fieldData);
        }

        return _startDateTime;
    } 
}

internal HL7V26Field _startDateTimeOffset;

public HL7V26Field StartDateTimeOffset
{
    get
    {
        if (_startDateTimeOffset != null)
        {
            return _startDateTimeOffset;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field contains the offset this service needs for the appointment, expressed in units of time relative to the scheduled start date/time. This field allows the application to identify that the service is required for the appointment at a different time than the appointment's start date/time. The first component contains the offset amount. An offset of zero (0), or an unvalued field indicates that the service is required at the start date/time of the appointment.

This field is conditionally required.  If a value for AIS-5-Start date/time offset is not provided, then a value is required for this field.  To specify that there is no difference between the appointment's start date/time and the resource's start date/time either replicate the appointment's start date/time into this field, or specify an offset of zero (0) in AIS-5-Start date/time offset and any valid time unit code in AIS-6-Start date/time offset units.",
            Sample = @"",
            Fields = null
        }

        _startDateTimeOffset = new HL7V26Field
        {
            field = message[@"AIS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTimeOffset.field.FieldRepetitions != null && _startDateTimeOffset.field.FieldRepetitions.Count > 0)
        {
            _startDateTimeOffset.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startDateTimeOffset, fieldData);
        }

        return _startDateTimeOffset;
    } 
}

internal HL7V26Field _startDateTimeOffsetUnits;

public HL7V26Field StartDateTimeOffsetUnits
{
    get
    {
        if (_startDateTimeOffsetUnits != null)
        {
            return _startDateTimeOffsetUnits;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.6",
            Type = @"Field",
            Position = @"AIS.6",
            Name = @"Start Date/Time Offset Units",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the start date/time offset. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO and ANSI+ unit codes.

This field is conditionally required.  If a value for AIS-5-Start date/time offset is provided, then a value is required for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.6.1",
                            Type = @"Component",
                            Position = @"AIS.6.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.2",
                            Type = @"Component",
                            Position = @"AIS.6.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.3",
                            Type = @"Component",
                            Position = @"AIS.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.4",
                            Type = @"Component",
                            Position = @"AIS.6.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.5",
                            Type = @"Component",
                            Position = @"AIS.6.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.6",
                            Type = @"Component",
                            Position = @"AIS.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.7",
                            Type = @"Component",
                            Position = @"AIS.6.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.8",
                            Type = @"Component",
                            Position = @"AIS.6.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.6.9",
                            Type = @"Component",
                            Position = @"AIS.6.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _startDateTimeOffsetUnits = new HL7V26Field
        {
            field = message[@"AIS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startDateTimeOffsetUnits.field.FieldRepetitions != null && _startDateTimeOffsetUnits.field.FieldRepetitions.Count > 0)
        {
            _startDateTimeOffsetUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_startDateTimeOffsetUnits, fieldData);
        }

        return _startDateTimeOffsetUnits;
    } 
}

internal HL7V26Field _duration;

public HL7V26Field Duration
{
    get
    {
        if (_duration != null)
        {
            return _duration;
        }

        var fieldData = new HL7V26FieldData
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

        _duration = new HL7V26Field
        {
            field = message[@"AIS"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_duration.field.FieldRepetitions != null && _duration.field.FieldRepetitions.Count > 0)
        {
            _duration.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_duration, fieldData);
        }

        return _duration;
    } 
}

internal HL7V26Field _durationUnits;

public HL7V26Field DurationUnits
{
    get
    {
        if (_durationUnits != null)
        {
            return _durationUnits;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.8",
            Type = @"Field",
            Position = @"AIS.8",
            Name = @"Duration Units",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains a code describing the units of time used for expressing the duration. This field should be valued according to the recommendations in Chapters 2 and 7. If this field is not valued, the ISO base unit of seconds (code ""s"") will be assumed. Refer to Chapter 7, Figures 7-6 through 7-9, for a list of ISO and ANSI+ unit codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.8.1",
                            Type = @"Component",
                            Position = @"AIS.8.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.2",
                            Type = @"Component",
                            Position = @"AIS.8.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.3",
                            Type = @"Component",
                            Position = @"AIS.8.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.4",
                            Type = @"Component",
                            Position = @"AIS.8.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.5",
                            Type = @"Component",
                            Position = @"AIS.8.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.6",
                            Type = @"Component",
                            Position = @"AIS.8.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.7",
                            Type = @"Component",
                            Position = @"AIS.8.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.8",
                            Type = @"Component",
                            Position = @"AIS.8.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.8.9",
                            Type = @"Component",
                            Position = @"AIS.8.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _durationUnits = new HL7V26Field
        {
            field = message[@"AIS"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_durationUnits.field.FieldRepetitions != null && _durationUnits.field.FieldRepetitions.Count > 0)
        {
            _durationUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_durationUnits, fieldData);
        }

        return _durationUnits;
    } 
}

internal HL7V26Field _allowSubstitutionCode;

public HL7V26Field AllowSubstitutionCode
{
    get
    {
        if (_allowSubstitutionCode != null)
        {
            return _allowSubstitutionCode;
        }

        var fieldData = new HL7V26FieldData
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
            TableName = @"Allow Substitution Codes",
            Description = @"This field contains a code indicating whether the identified resource can be substituted with an equivalent resource by the filler application. Refer to User-Defined Table 0279 - Allow Substitution Codes for suggested codes.",
            Sample = @"",
            Fields = null
        }

        _allowSubstitutionCode = new HL7V26Field
        {
            field = message[@"AIS"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_allowSubstitutionCode.field.FieldRepetitions != null && _allowSubstitutionCode.field.FieldRepetitions.Count > 0)
        {
            _allowSubstitutionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_allowSubstitutionCode, fieldData);
        }

        return _allowSubstitutionCode;
    } 
}

internal HL7V26Field _fillerStatusCode;

public HL7V26Field FillerStatusCode
{
    get
    {
        if (_fillerStatusCode != null)
        {
            return _fillerStatusCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.10",
            Type = @"Field",
            Position = @"AIS.10",
            Name = @"Filler Status Code",
            Length = 250,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0278",
            TableName = @"Filler status codes",
            Description = @"This field contains a code that describes the requested/scheduled status of the resource or activity, from the point of view of the filler application. Refer to User-Defined Table 0278 - Filler Status Codes for suggested codes.

This is a conditionally required field.  Because the information contained in this field is only appropriate in transactions originating from a filler application, it is required for those messages.  This includes all unsolicited transactions originating from a filler application, as well as all response messages originating from a filler application.  This field is optional for all transactions originating from placer, querying and auxiliary applications.  It is recommended that this field be left unvalued in transactions originating from applications other than the filler application.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.10.1",
                            Type = @"Component",
                            Position = @"AIS.10.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.2",
                            Type = @"Component",
                            Position = @"AIS.10.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.3",
                            Type = @"Component",
                            Position = @"AIS.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.4",
                            Type = @"Component",
                            Position = @"AIS.10.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.5",
                            Type = @"Component",
                            Position = @"AIS.10.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.6",
                            Type = @"Component",
                            Position = @"AIS.10.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.7",
                            Type = @"Component",
                            Position = @"AIS.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.8",
                            Type = @"Component",
                            Position = @"AIS.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.10.9",
                            Type = @"Component",
                            Position = @"AIS.10.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerStatusCode = new HL7V26Field
        {
            field = message[@"AIS"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerStatusCode.field.FieldRepetitions != null && _fillerStatusCode.field.FieldRepetitions.Count > 0)
        {
            _fillerStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_fillerStatusCode, fieldData);
        }

        return _fillerStatusCode;
    } 
}

internal HL7V26Field _placerSupplementalServiceInformation;

public HL7V26Field PlacerSupplementalServiceInformation
{
    get
    {
        if (_placerSupplementalServiceInformation != null)
        {
            return _placerSupplementalServiceInformation;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.11",
            Type = @"Field",
            Position = @"AIS.11",
            Name = @"Placer Supplemental Service Information",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0411",
            TableName = @"Supplemental Service Information Values",
            Description = @"This field contains supplemental service and/or logistical information sent from the placer system to the filler system for the universal procedure code reported in field AIS-3. This field will be used to provide scheduling information detail that is not available in other, specific fields in the AIS segment. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values , which can be found in chapter 4, for possible values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.11.1",
                            Type = @"Component",
                            Position = @"AIS.11.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.2",
                            Type = @"Component",
                            Position = @"AIS.11.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.3",
                            Type = @"Component",
                            Position = @"AIS.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.4",
                            Type = @"Component",
                            Position = @"AIS.11.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.5",
                            Type = @"Component",
                            Position = @"AIS.11.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.6",
                            Type = @"Component",
                            Position = @"AIS.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.7",
                            Type = @"Component",
                            Position = @"AIS.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.8",
                            Type = @"Component",
                            Position = @"AIS.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.11.9",
                            Type = @"Component",
                            Position = @"AIS.11.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _placerSupplementalServiceInformation = new HL7V26Field
        {
            field = message[@"AIS"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerSupplementalServiceInformation.field.FieldRepetitions != null && _placerSupplementalServiceInformation.field.FieldRepetitions.Count > 0)
        {
            _placerSupplementalServiceInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_placerSupplementalServiceInformation, fieldData);
        }

        return _placerSupplementalServiceInformation;
    } 
}

internal HL7V26Field _fillerSupplementalServiceInformation;

public HL7V26Field FillerSupplementalServiceInformation
{
    get
    {
        if (_fillerSupplementalServiceInformation != null)
        {
            return _fillerSupplementalServiceInformation;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"AIS.12",
            Type = @"Field",
            Position = @"AIS.12",
            Name = @"Filler Supplemental Service Information",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0411",
            TableName = @"Supplemental Service Information Values",
            Description = @"This field contains supplemental service and/or logistical information sent from the filler system to the placer system for the procedure code reported in field AIS-3. This field will be used to report scheduling information details that is not available in other, specific fields in the AIS segment. Typically it will reflect the same information as was sent to the filler system in AIS-11-Placer supplemental information unless the scheduling was modified in which case the filler system will report what was actually performed using this field. Multiple supplemental service information elements may be reported. Refer to User-defined Table 0411 - Supplemental service information values , which can be found in chapter 4, for possible values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AIS.12.1",
                            Type = @"Component",
                            Position = @"AIS.12.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.2",
                            Type = @"Component",
                            Position = @"AIS.12.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.3",
                            Type = @"Component",
                            Position = @"AIS.12.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.4",
                            Type = @"Component",
                            Position = @"AIS.12.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.5",
                            Type = @"Component",
                            Position = @"AIS.12.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.6",
                            Type = @"Component",
                            Position = @"AIS.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.7",
                            Type = @"Component",
                            Position = @"AIS.12.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.8",
                            Type = @"Component",
                            Position = @"AIS.12.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AIS.12.9",
                            Type = @"Component",
                            Position = @"AIS.12.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerSupplementalServiceInformation = new HL7V26Field
        {
            field = message[@"AIS"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerSupplementalServiceInformation.field.FieldRepetitions != null && _fillerSupplementalServiceInformation.field.FieldRepetitions.Count > 0)
        {
            _fillerSupplementalServiceInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_fillerSupplementalServiceInformation, fieldData);
        }

        return _fillerSupplementalServiceInformation;
    } 
}
    }
}

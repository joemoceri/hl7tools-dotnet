using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Original Style Query Filter"; } }
        
        public string Description { get { return @"The QRF segment is used with the QRD segment to further refine the content of an original style query."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V24SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _whereSubjectFilter;

public HL7V24Field WhereSubjectFilter
{
    get
    {
        if (_whereSubjectFilter != null)
        {
            return _whereSubjectFilter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.1",
            Type = @"Field",
            Position = @"QRF.1",
            Name = @"Where Subject Filter",
            Length = 20,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc",
            Sample = @"",
            Fields = null
        }

        _whereSubjectFilter = new HL7V24Field
        {
            field = message[@"QRF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whereSubjectFilter.field.FieldRepetitions != null && _whereSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _whereSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whereSubjectFilter, fieldData);
        }

        return _whereSubjectFilter;
    } 
}

internal HL7V24Field _whenDataStartDateTime;

public HL7V24Field WhenDataStartDateTime
{
    get
    {
        if (_whenDataStartDateTime != null)
        {
            return _whenDataStartDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date/Time",
            Length = 26,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or after which this value should be included",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QRF.2.1",
                            Type = @"Component",
                            Position = @"QRF.2.1",
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
                            Id = @"QRF.2.2",
                            Type = @"Component",
                            Position = @"QRF.2.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _whenDataStartDateTime = new HL7V24Field
        {
            field = message[@"QRF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataStartDateTime.field.FieldRepetitions != null && _whenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whenDataStartDateTime, fieldData);
        }

        return _whenDataStartDateTime;
    } 
}

internal HL7V24Field _whenDataEndDateTime;

public HL7V24Field WhenDataEndDateTime
{
    get
    {
        if (_whenDataEndDateTime != null)
        {
            return _whenDataEndDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date/Time",
            Length = 26,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only. It is recommended to use QRF-9 – When quantity/timing qualifier.  When used for backward compatibility, this field contains the dates and times equal to or before which this date should be included. This field contains the dates and times equal to or before which this date should be included",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QRF.3.1",
                            Type = @"Component",
                            Position = @"QRF.3.1",
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
                            Id = @"QRF.3.2",
                            Type = @"Component",
                            Position = @"QRF.3.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _whenDataEndDateTime = new HL7V24Field
        {
            field = message[@"QRF"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataEndDateTime.field.FieldRepetitions != null && _whenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whenDataEndDateTime, fieldData);
        }

        return _whenDataEndDateTime;
    } 
}

internal HL7V24Field _whatUserQualifier;

public HL7V24Field WhatUserQualifier
{
    get
    {
        if (_whatUserQualifier != null)
        {
            return _whatUserQualifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.4",
            Type = @"Field",
            Position = @"QRF.4",
            Name = @"What User Qualifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifier to further define characteristics of the data of interest",
            Sample = @"",
            Fields = null
        }

        _whatUserQualifier = new HL7V24Field
        {
            field = message[@"QRF"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatUserQualifier.field.FieldRepetitions != null && _whatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            _whatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whatUserQualifier, fieldData);
        }

        return _whatUserQualifier;
    } 
}

internal HL7V24Field _otherQRYSubjectFilter;

public HL7V24Field OtherQRYSubjectFilter
{
    get
    {
        if (_otherQRYSubjectFilter != null)
        {
            return _otherQRYSubjectFilter;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.5",
            Type = @"Field",
            Position = @"QRF.5",
            Name = @"Other QRY Subject Filter",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a filter defined locally for use between two systems.  This filter uses codes and field definitions that have specific meaning only to the applications and/or site involved",
            Sample = @"",
            Fields = null
        }

        _otherQRYSubjectFilter = new HL7V24Field
        {
            field = message[@"QRF"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherQRYSubjectFilter.field.FieldRepetitions != null && _otherQRYSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _otherQRYSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_otherQRYSubjectFilter, fieldData);
        }

        return _otherQRYSubjectFilter;
    } 
}

internal HL7V24Field _whichDateTimeQualifier;

public HL7V24Field WhichDateTimeQualifier
{
    get
    {
        if (_whichDateTimeQualifier != null)
        {
            return _whichDateTimeQualifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.6",
            Type = @"Field",
            Position = @"QRF.6",
            Name = @"Which Date/Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0156",
            TableName = @"Which date/time qualifier",
            Description = @"This field specifies the type of date referred to in QRF-2-When data start date/time and QRF3-When data end date/time",
            Sample = @"",
            Fields = null
        }

        _whichDateTimeQualifier = new HL7V24Field
        {
            field = message[@"QRF"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whichDateTimeQualifier.field.FieldRepetitions != null && _whichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            _whichDateTimeQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whichDateTimeQualifier, fieldData);
        }

        return _whichDateTimeQualifier;
    } 
}

internal HL7V24Field _whichDateTimeStatusQualifier;

public HL7V24Field WhichDateTimeStatusQualifier
{
    get
    {
        if (_whichDateTimeStatusQualifier != null)
        {
            return _whichDateTimeStatusQualifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.7",
            Type = @"Field",
            Position = @"QRF.7",
            Name = @"Which Date/Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0157",
            TableName = @"Which date/time status qualifier",
            Description = @"This field specifies the status type of objects selected in date range defined by QRF-2-When data start date/time and QRF-3-When data end date/time",
            Sample = @"",
            Fields = null
        }

        _whichDateTimeStatusQualifier = new HL7V24Field
        {
            field = message[@"QRF"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whichDateTimeStatusQualifier.field.FieldRepetitions != null && _whichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            _whichDateTimeStatusQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whichDateTimeStatusQualifier, fieldData);
        }

        return _whichDateTimeStatusQualifier;
    } 
}

internal HL7V24Field _dateTimeSelectionQualifier;

public HL7V24Field DateTimeSelectionQualifier
{
    get
    {
        if (_dateTimeSelectionQualifier != null)
        {
            return _dateTimeSelectionQualifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.8",
            Type = @"Field",
            Position = @"QRF.8",
            Name = @"Date/Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0158",
            TableName = @"Date/time selection qualifier",
            Description = @"This field allows the specification of certain types of values within the date/time range",
            Sample = @"",
            Fields = null
        }

        _dateTimeSelectionQualifier = new HL7V24Field
        {
            field = message[@"QRF"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeSelectionQualifier.field.FieldRepetitions != null && _dateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            _dateTimeSelectionQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_dateTimeSelectionQualifier, fieldData);
        }

        return _dateTimeSelectionQualifier;
    } 
}

internal HL7V24Field _whenQuantityTimingQualifier;

public HL7V24Field WhenQuantityTimingQualifier
{
    get
    {
        if (_whenQuantityTimingQualifier != null)
        {
            return _whenQuantityTimingQualifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.9",
            Type = @"Field",
            Position = @"QRF.9",
            Name = @"When Quantity/Timing Qualifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field allows an interval definition to be used for specifying multiple responses to a query. With the addition of this filter, new query specifications should no longer use QRF-2-When data start date/time and QRF-3-When data end date/time in future implementations",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QRF.9.1",
                            Type = @"Component",
                            Position = @"QRF.9.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the quantity of the service that should be provided at each service interval. For example, if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.1.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.1",
                            Name = @"Quantity",
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
                            Id = @"QRF.9.1.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.1.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.2",
                            Type = @"Component",
                            Position = @"QRF.9.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.2.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered.  It is similar to the frequency and SIG code tables used in order entry systems. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.2.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution.  If the time of the order spans more than a single day, this new subcomponent is only practical if the same times of administration occur for each day of the order.  If the actual start time of the order (as given by the fourth subcomponent of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time.  In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.3",
                            Type = @"Component",
                            Position = @"QRF.9.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.4",
                            Type = @"Component",
                            Position = @"QRF.9.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.4.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.4.1",
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
                            Id = @"QRF.9.4.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.5",
                            Type = @"Component",
                            Position = @"QRF.9.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should contain the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.5.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.5.1",
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
                            Id = @"QRF.9.5.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.5.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.6",
                            Type = @"Component",
                            Position = @"QRF.9.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @" This field describes the urgency of the request.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.7",
                            Type = @"Component",
                            Position = @"QRF.9.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.8",
                            Type = @"Component",
                            Position = @"QRF.9.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.9",
                            Type = @"Component",
                            Position = @"QRF.9.9",
                            Name = @"Conjunction Component",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0472",
                            TableName = @"TQ Conjunction ID",
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values as shown in HL7 table 0472 - TQ Conjunction ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10",
                            Type = @"Component",
                            Position = @"QRF.9.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencing ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.2",
                            Name = @"Placer Order Number: Entity Identifier",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"QRF.9.10.3",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.3",
                            Name = @"Placer Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.4",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.4",
                            Name = @"Filler Order Number: Entity Identifier",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"QRF.9.10.5",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.5",
                            Name = @"Filler Order Number: Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.6",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"QRF.9.10.7",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.8",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.8",
                            Name = @"Placer Order Number: Universal ID",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"QRF.9.10.9",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.9",
                            Name = @"Placer Order Number; Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.10.10",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.10",
                            Name = @"Filler Order Number: Universal ID",
                            Length = 0,
                            Usage = @"R",
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
                            Id = @"QRF.9.10.11",
                            Type = @"SubComponent",
                            Position = @"QRF.9.10.11",
                            Name = @"Filler Order Number: Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11",
                            Type = @"Component",
                            Position = @"QRF.9.11",
                            Name = @"Occurrence Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the duration for a single performance of a service, e.g., whirlpool twenty minutes three times per day for three days. It is optional within TQ and does not repeat.

Note: The component delimiter in this CQ is demoted to a subcomponent delimiter.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.1",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.1",
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
                            Id = @"QRF.9.11.2",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.2",
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
                            Id = @"QRF.9.11.3",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.4",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.5",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.11.6",
                            Type = @"SubComponent",
                            Position = @"QRF.9.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QRF.9.12",
                            Type = @"Component",
                            Position = @"QRF.9.12",
                            Name = @"Total Occurences",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total number of occurrences of a service that should result from this order.  It is optional within TQ and does not repeat.  If both the end date/time and the total occurrences are valued and the occurrences would extend beyond the end date/time, then the end date/time takes precedence.  Otherwise the number of occurrences takes precedence.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _whenQuantityTimingQualifier = new HL7V24Field
        {
            field = message[@"QRF"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenQuantityTimingQualifier.field.FieldRepetitions != null && _whenQuantityTimingQualifier.field.FieldRepetitions.Count > 0)
        {
            _whenQuantityTimingQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_whenQuantityTimingQualifier, fieldData);
        }

        return _whenQuantityTimingQualifier;
    } 
}

internal HL7V24Field _searchConfidenceThreshold;

public HL7V24Field SearchConfidenceThreshold
{
    get
    {
        if (_searchConfidenceThreshold != null)
        {
            return _searchConfidenceThreshold;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"QRF.10",
            Type = @"Field",
            Position = @"QRF.10",
            Name = @"Search Confidence Threshold",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a numeric value used to establish the minimum threshold match. The value instructs the responding system to return no records for patients whose “match weight” on the lookup was lower than this user-defined value",
            Sample = @"",
            Fields = null
        }

        _searchConfidenceThreshold = new HL7V24Field
        {
            field = message[@"QRF"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_searchConfidenceThreshold.field.FieldRepetitions != null && _searchConfidenceThreshold.field.FieldRepetitions.Count > 0)
        {
            _searchConfidenceThreshold.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_searchConfidenceThreshold, fieldData);
        }

        return _searchConfidenceThreshold;
    } 
}
    }
}

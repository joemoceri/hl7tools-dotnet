using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Query Filter"; } }
        
        public string Description { get { return @"The QRF segment is used with the QRD segment to refine the content of a query further"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

                    };
            }
        }

        public HL7V22SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _whereSubjectFilter;

public HL7V22Field WhereSubjectFilter
{
    get
    {
        if (_whereSubjectFilter != null)
        {
            return _whereSubjectFilter;
        }

        var fieldData = new HL7V22FieldData
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
            Description = @"identifies the department, system, or subsystem to which the query pertains.  This field may repeat as in LAB~HEMO, etc",
            Sample = @"",
            Fields = null
        }

        _whereSubjectFilter = new HL7V22Field
        {
            field = message[@"QRF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whereSubjectFilter.field.FieldRepetitions != null && _whereSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _whereSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whereSubjectFilter, fieldData);
        }

        return _whereSubjectFilter;
    } 
}

internal HL7V22Field _whenDataStartDateTime;

public HL7V22Field WhenDataStartDateTime
{
    get
    {
        if (_whenDataStartDateTime != null)
        {
            return _whenDataStartDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"data representing dates and times equal or after this value should be included",
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

        _whenDataStartDateTime = new HL7V22Field
        {
            field = message[@"QRF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataStartDateTime.field.FieldRepetitions != null && _whenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whenDataStartDateTime, fieldData);
        }

        return _whenDataStartDateTime;
    } 
}

internal HL7V22Field _whenDataEndDateTime;

public HL7V22Field WhenDataEndDateTime
{
    get
    {
        if (_whenDataEndDateTime != null)
        {
            return _whenDataEndDateTime;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date / Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"data representing dates and times the same as or before this date should be included",
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

        _whenDataEndDateTime = new HL7V22Field
        {
            field = message[@"QRF"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataEndDateTime.field.FieldRepetitions != null && _whenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whenDataEndDateTime, fieldData);
        }

        return _whenDataEndDateTime;
    } 
}

internal HL7V22Field _whatUserQualifier;

public HL7V22Field WhatUserQualifier
{
    get
    {
        if (_whatUserQualifier != null)
        {
            return _whatUserQualifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.4",
            Type = @"Field",
            Position = @"QRF.4",
            Name = @"What User Qualifier",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"an identifier to further define characteristics of the data of interest",
            Sample = @"",
            Fields = null
        }

        _whatUserQualifier = new HL7V22Field
        {
            field = message[@"QRF"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatUserQualifier.field.FieldRepetitions != null && _whatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            _whatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whatUserQualifier, fieldData);
        }

        return _whatUserQualifier;
    } 
}

internal HL7V22Field _otherQrySubjectFilter;

public HL7V22Field OtherQrySubjectFilter
{
    get
    {
        if (_otherQrySubjectFilter != null)
        {
            return _otherQrySubjectFilter;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.5",
            Type = @"Field",
            Position = @"QRF.5",
            Name = @"Other Qry Subject Filter",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"a filter defined locally for use between two systems.  This filter uses codes and field definitions which have specific meaning only to the applications and/or site involved",
            Sample = @"",
            Fields = null
        }

        _otherQrySubjectFilter = new HL7V22Field
        {
            field = message[@"QRF"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherQrySubjectFilter.field.FieldRepetitions != null && _otherQrySubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _otherQrySubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_otherQrySubjectFilter, fieldData);
        }

        return _otherQrySubjectFilter;
    } 
}

internal HL7V22Field _whichDateTimeQualifier;

public HL7V22Field WhichDateTimeQualifier
{
    get
    {
        if (_whichDateTimeQualifier != null)
        {
            return _whichDateTimeQualifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.6",
            Type = @"Field",
            Position = @"QRF.6",
            Name = @"Which Date / Time Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0156",
            TableName = @"DATE/TIME QUALIFIER",
            Description = @"specifies type of date referred to in QRF-2-when data start date/time and QRF-3-when data end date/time",
            Sample = @"",
            Fields = null
        }

        _whichDateTimeQualifier = new HL7V22Field
        {
            field = message[@"QRF"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whichDateTimeQualifier.field.FieldRepetitions != null && _whichDateTimeQualifier.field.FieldRepetitions.Count > 0)
        {
            _whichDateTimeQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whichDateTimeQualifier, fieldData);
        }

        return _whichDateTimeQualifier;
    } 
}

internal HL7V22Field _whichDateTimeStatusQualifier;

public HL7V22Field WhichDateTimeStatusQualifier
{
    get
    {
        if (_whichDateTimeStatusQualifier != null)
        {
            return _whichDateTimeStatusQualifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.7",
            Type = @"Field",
            Position = @"QRF.7",
            Name = @"Which Date / Time Status Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0157",
            TableName = @"WHICH DATE/TIME STATUS QUALIFIER",
            Description = @"specifies status type of objects selected in date range defined by QRF-2-when data start date/time and QRF-3-when data end date/time).",
            Sample = @"",
            Fields = null
        }

        _whichDateTimeStatusQualifier = new HL7V22Field
        {
            field = message[@"QRF"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whichDateTimeStatusQualifier.field.FieldRepetitions != null && _whichDateTimeStatusQualifier.field.FieldRepetitions.Count > 0)
        {
            _whichDateTimeStatusQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_whichDateTimeStatusQualifier, fieldData);
        }

        return _whichDateTimeStatusQualifier;
    } 
}

internal HL7V22Field _dateTimeSelectionQualifier;

public HL7V22Field DateTimeSelectionQualifier
{
    get
    {
        if (_dateTimeSelectionQualifier != null)
        {
            return _dateTimeSelectionQualifier;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"QRF.8",
            Type = @"Field",
            Position = @"QRF.8",
            Name = @"Date / Time Selection Qualifier",
            Length = 12,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0158",
            TableName = @"DATE/TIME SELECTION QUALIFIER",
            Description = @"allows specification of certain types of values within the date/time range.",
            Sample = @"",
            Fields = null
        }

        _dateTimeSelectionQualifier = new HL7V22Field
        {
            field = message[@"QRF"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeSelectionQualifier.field.FieldRepetitions != null && _dateTimeSelectionQualifier.field.FieldRepetitions.Count > 0)
        {
            _dateTimeSelectionQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_dateTimeSelectionQualifier, fieldData);
        }

        return _dateTimeSelectionQualifier;
    } 
}
    }
}

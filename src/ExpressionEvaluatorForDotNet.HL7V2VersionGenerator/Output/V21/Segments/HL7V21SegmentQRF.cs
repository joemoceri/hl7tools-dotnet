using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentQRF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRF"; } }

        public string SegmentId { get { return @"QRF"; } }
        
        public string LongName { get { return @"Query Filter"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentQRF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _whereSubjectFilter;

public HL7V21Field WhereSubjectFilter
{
    get
    {
        if (_whereSubjectFilter != null)
        {
            return _whereSubjectFilter;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _whereSubjectFilter = new HL7V21Field
        {
            field = message[@"QRF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whereSubjectFilter.field.FieldRepetitions != null && _whereSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _whereSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whereSubjectFilter, fieldData);
        }

        return _whereSubjectFilter;
    } 
}

internal HL7V21Field _whenDataStartDateTime;

public HL7V21Field WhenDataStartDateTime
{
    get
    {
        if (_whenDataStartDateTime != null)
        {
            return _whenDataStartDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRF.2",
            Type = @"Field",
            Position = @"QRF.2",
            Name = @"When Data Start Date/Time",
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

        _whenDataStartDateTime = new HL7V21Field
        {
            field = message[@"QRF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataStartDateTime.field.FieldRepetitions != null && _whenDataStartDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataStartDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whenDataStartDateTime, fieldData);
        }

        return _whenDataStartDateTime;
    } 
}

internal HL7V21Field _whenDataEndDateTime;

public HL7V21Field WhenDataEndDateTime
{
    get
    {
        if (_whenDataEndDateTime != null)
        {
            return _whenDataEndDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRF.3",
            Type = @"Field",
            Position = @"QRF.3",
            Name = @"When Data End Date/Time",
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

        _whenDataEndDateTime = new HL7V21Field
        {
            field = message[@"QRF"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whenDataEndDateTime.field.FieldRepetitions != null && _whenDataEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _whenDataEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whenDataEndDateTime, fieldData);
        }

        return _whenDataEndDateTime;
    } 
}

internal HL7V21Field _whatUserQualifier;

public HL7V21Field WhatUserQualifier
{
    get
    {
        if (_whatUserQualifier != null)
        {
            return _whatUserQualifier;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _whatUserQualifier = new HL7V21Field
        {
            field = message[@"QRF"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatUserQualifier.field.FieldRepetitions != null && _whatUserQualifier.field.FieldRepetitions.Count > 0)
        {
            _whatUserQualifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whatUserQualifier, fieldData);
        }

        return _whatUserQualifier;
    } 
}

internal HL7V21Field _otherQrySubjectFilter;

public HL7V21Field OtherQrySubjectFilter
{
    get
    {
        if (_otherQrySubjectFilter != null)
        {
            return _otherQrySubjectFilter;
        }

        var fieldData = new HL7V21FieldData
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
            Description = null,
            Sample = @"",
            Fields = null
        }

        _otherQrySubjectFilter = new HL7V21Field
        {
            field = message[@"QRF"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherQrySubjectFilter.field.FieldRepetitions != null && _otherQrySubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _otherQrySubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_otherQrySubjectFilter, fieldData);
        }

        return _otherQrySubjectFilter;
    } 
}
    }
}

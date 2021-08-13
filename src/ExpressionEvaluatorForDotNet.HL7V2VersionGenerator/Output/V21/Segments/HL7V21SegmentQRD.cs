using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21SegmentQRD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QRD"; } }

        public string SegmentId { get { return @"QRD"; } }
        
        public string LongName { get { return @"Query Definition"; } }
        
        public string Description { get { return @""; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            }
        }

        public HL7V21SegmentQRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field _queryDateTime;

public HL7V21Field QueryDateTime
{
    get
    {
        if (_queryDateTime != null)
        {
            return _queryDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.1",
            Type = @"Field",
            Position = @"QRD.1",
            Name = @"Query Date/Time",
            Length = 19,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryDateTime = new HL7V21Field
        {
            field = message[@"QRD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryDateTime.field.FieldRepetitions != null && _queryDateTime.field.FieldRepetitions.Count > 0)
        {
            _queryDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_queryDateTime, fieldData);
        }

        return _queryDateTime;
    } 
}

internal HL7V21Field _queryFormatCode;

public HL7V21Field QueryFormatCode
{
    get
    {
        if (_queryFormatCode != null)
        {
            return _queryFormatCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.2",
            Type = @"Field",
            Position = @"QRD.2",
            Name = @"Query Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0106",
            TableName = @"QUERY FORMAT CODE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryFormatCode = new HL7V21Field
        {
            field = message[@"QRD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryFormatCode.field.FieldRepetitions != null && _queryFormatCode.field.FieldRepetitions.Count > 0)
        {
            _queryFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_queryFormatCode, fieldData);
        }

        return _queryFormatCode;
    } 
}

internal HL7V21Field _queryPriority;

public HL7V21Field QueryPriority
{
    get
    {
        if (_queryPriority != null)
        {
            return _queryPriority;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.3",
            Type = @"Field",
            Position = @"QRD.3",
            Name = @"Query Priority",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0091",
            TableName = @"QUERY PRIORITY",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryPriority = new HL7V21Field
        {
            field = message[@"QRD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryPriority.field.FieldRepetitions != null && _queryPriority.field.FieldRepetitions.Count > 0)
        {
            _queryPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_queryPriority, fieldData);
        }

        return _queryPriority;
    } 
}

internal HL7V21Field _queryId;

public HL7V21Field QueryId
{
    get
    {
        if (_queryId != null)
        {
            return _queryId;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.4",
            Type = @"Field",
            Position = @"QRD.4",
            Name = @"Query Id",
            Length = 10,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryId = new HL7V21Field
        {
            field = message[@"QRD"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryId.field.FieldRepetitions != null && _queryId.field.FieldRepetitions.Count > 0)
        {
            _queryId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_queryId, fieldData);
        }

        return _queryId;
    } 
}

internal HL7V21Field _deferredResponseType;

public HL7V21Field DeferredResponseType
{
    get
    {
        if (_deferredResponseType != null)
        {
            return _deferredResponseType;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.5",
            Type = @"Field",
            Position = @"QRD.5",
            Name = @"Deferred Response Type",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0107",
            TableName = @"DEFERRED RESPONSE TYPE",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _deferredResponseType = new HL7V21Field
        {
            field = message[@"QRD"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deferredResponseType.field.FieldRepetitions != null && _deferredResponseType.field.FieldRepetitions.Count > 0)
        {
            _deferredResponseType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_deferredResponseType, fieldData);
        }

        return _deferredResponseType;
    } 
}

internal HL7V21Field _deferredResponseDateTime;

public HL7V21Field DeferredResponseDateTime
{
    get
    {
        if (_deferredResponseDateTime != null)
        {
            return _deferredResponseDateTime;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.6",
            Type = @"Field",
            Position = @"QRD.6",
            Name = @"Deferred Response Date/Time",
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

        _deferredResponseDateTime = new HL7V21Field
        {
            field = message[@"QRD"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deferredResponseDateTime.field.FieldRepetitions != null && _deferredResponseDateTime.field.FieldRepetitions.Count > 0)
        {
            _deferredResponseDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_deferredResponseDateTime, fieldData);
        }

        return _deferredResponseDateTime;
    } 
}

internal HL7V21Field _quantityLimitedRequest;

public HL7V21Field QuantityLimitedRequest
{
    get
    {
        if (_quantityLimitedRequest != null)
        {
            return _quantityLimitedRequest;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.7",
            Type = @"Field",
            Position = @"QRD.7",
            Name = @"Quantity Limited Request",
            Length = 5,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = @"0126",
            TableName = @"QUANTITY LIMITED REQUEST",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _quantityLimitedRequest = new HL7V21Field
        {
            field = message[@"QRD"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityLimitedRequest.field.FieldRepetitions != null && _quantityLimitedRequest.field.FieldRepetitions.Count > 0)
        {
            _quantityLimitedRequest.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_quantityLimitedRequest, fieldData);
        }

        return _quantityLimitedRequest;
    } 
}

internal HL7V21Field _whoSubjectFilter;

public HL7V21Field WhoSubjectFilter
{
    get
    {
        if (_whoSubjectFilter != null)
        {
            return _whoSubjectFilter;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.8",
            Type = @"Field",
            Position = @"QRD.8",
            Name = @"Who Subject Filter",
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

        _whoSubjectFilter = new HL7V21Field
        {
            field = message[@"QRD"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whoSubjectFilter.field.FieldRepetitions != null && _whoSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _whoSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whoSubjectFilter, fieldData);
        }

        return _whoSubjectFilter;
    } 
}

internal HL7V21Field _whatSubjectFilter;

public HL7V21Field WhatSubjectFilter
{
    get
    {
        if (_whatSubjectFilter != null)
        {
            return _whatSubjectFilter;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.9",
            Type = @"Field",
            Position = @"QRD.9",
            Name = @"What Subject Filter",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0048",
            TableName = @"WHAT SUBJECT FILTER",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _whatSubjectFilter = new HL7V21Field
        {
            field = message[@"QRD"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatSubjectFilter.field.FieldRepetitions != null && _whatSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            _whatSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whatSubjectFilter, fieldData);
        }

        return _whatSubjectFilter;
    } 
}

internal HL7V21Field _whatDepartmentDataCode;

public HL7V21Field WhatDepartmentDataCode
{
    get
    {
        if (_whatDepartmentDataCode != null)
        {
            return _whatDepartmentDataCode;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.10",
            Type = @"Field",
            Position = @"QRD.10",
            Name = @"What Department Data Code",
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

        _whatDepartmentDataCode = new HL7V21Field
        {
            field = message[@"QRD"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatDepartmentDataCode.field.FieldRepetitions != null && _whatDepartmentDataCode.field.FieldRepetitions.Count > 0)
        {
            _whatDepartmentDataCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whatDepartmentDataCode, fieldData);
        }

        return _whatDepartmentDataCode;
    } 
}

internal HL7V21Field _whatDataCodeValueQual;

public HL7V21Field WhatDataCodeValueQual
{
    get
    {
        if (_whatDataCodeValueQual != null)
        {
            return _whatDataCodeValueQual;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.11",
            Type = @"Field",
            Position = @"QRD.11",
            Name = @"What Data Code Value Qual.",
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

        _whatDataCodeValueQual = new HL7V21Field
        {
            field = message[@"QRD"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_whatDataCodeValueQual.field.FieldRepetitions != null && _whatDataCodeValueQual.field.FieldRepetitions.Count > 0)
        {
            _whatDataCodeValueQual.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_whatDataCodeValueQual, fieldData);
        }

        return _whatDataCodeValueQual;
    } 
}

internal HL7V21Field _queryResultsLevel;

public HL7V21Field QueryResultsLevel
{
    get
    {
        if (_queryResultsLevel != null)
        {
            return _queryResultsLevel;
        }

        var fieldData = new HL7V21FieldData
        {
            Id = @"QRD.12",
            Type = @"Field",
            Position = @"QRD.12",
            Name = @"Query Results Level",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value",
            TableId = @"0108",
            TableName = @"QUERY RESULTS LEVEL",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _queryResultsLevel = new HL7V21Field
        {
            field = message[@"QRD"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResultsLevel.field.FieldRepetitions != null && _queryResultsLevel.field.FieldRepetitions.Count > 0)
        {
            _queryResultsLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(_queryResultsLevel, fieldData);
        }

        return _queryResultsLevel;
    } 
}
    }
}

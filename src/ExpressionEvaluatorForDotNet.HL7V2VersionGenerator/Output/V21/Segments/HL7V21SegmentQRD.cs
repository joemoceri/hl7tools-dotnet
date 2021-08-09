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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V21SegmentQRD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V21Field queryDateTime;

public HL7V21Field QueryDateTime
{
    get
    {
        if (queryDateTime != null)
        {
            return queryDateTime;
        }

        queryDateTime = new HL7V21Field
        {
            field = message[@"QRD"][1],
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
        };

        // check for repetitions
        if (queryDateTime.field.FieldRepetitions != null && queryDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryDateTime.Id));
            queryDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(queryDateTime, fieldData);
        }

        return queryDateTime;
    } 
}

internal HL7V21Field queryFormatCode;

public HL7V21Field QueryFormatCode
{
    get
    {
        if (queryFormatCode != null)
        {
            return queryFormatCode;
        }

        queryFormatCode = new HL7V21Field
        {
            field = message[@"QRD"][2],
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
        };

        // check for repetitions
        if (queryFormatCode.field.FieldRepetitions != null && queryFormatCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryFormatCode.Id));
            queryFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(queryFormatCode, fieldData);
        }

        return queryFormatCode;
    } 
}

internal HL7V21Field queryPriority;

public HL7V21Field QueryPriority
{
    get
    {
        if (queryPriority != null)
        {
            return queryPriority;
        }

        queryPriority = new HL7V21Field
        {
            field = message[@"QRD"][3],
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
        };

        // check for repetitions
        if (queryPriority.field.FieldRepetitions != null && queryPriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryPriority.Id));
            queryPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(queryPriority, fieldData);
        }

        return queryPriority;
    } 
}

internal HL7V21Field queryId;

public HL7V21Field QueryId
{
    get
    {
        if (queryId != null)
        {
            return queryId;
        }

        queryId = new HL7V21Field
        {
            field = message[@"QRD"][4],
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
        };

        // check for repetitions
        if (queryId.field.FieldRepetitions != null && queryId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryId.Id));
            queryId.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(queryId, fieldData);
        }

        return queryId;
    } 
}

internal HL7V21Field deferredResponseType;

public HL7V21Field DeferredResponseType
{
    get
    {
        if (deferredResponseType != null)
        {
            return deferredResponseType;
        }

        deferredResponseType = new HL7V21Field
        {
            field = message[@"QRD"][5],
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
        };

        // check for repetitions
        if (deferredResponseType.field.FieldRepetitions != null && deferredResponseType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deferredResponseType.Id));
            deferredResponseType.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(deferredResponseType, fieldData);
        }

        return deferredResponseType;
    } 
}

internal HL7V21Field deferredResponseDateTime;

public HL7V21Field DeferredResponseDateTime
{
    get
    {
        if (deferredResponseDateTime != null)
        {
            return deferredResponseDateTime;
        }

        deferredResponseDateTime = new HL7V21Field
        {
            field = message[@"QRD"][6],
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
        };

        // check for repetitions
        if (deferredResponseDateTime.field.FieldRepetitions != null && deferredResponseDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(deferredResponseDateTime.Id));
            deferredResponseDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(deferredResponseDateTime, fieldData);
        }

        return deferredResponseDateTime;
    } 
}

internal HL7V21Field quantityLimitedRequest;

public HL7V21Field QuantityLimitedRequest
{
    get
    {
        if (quantityLimitedRequest != null)
        {
            return quantityLimitedRequest;
        }

        quantityLimitedRequest = new HL7V21Field
        {
            field = message[@"QRD"][7],
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
        };

        // check for repetitions
        if (quantityLimitedRequest.field.FieldRepetitions != null && quantityLimitedRequest.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(quantityLimitedRequest.Id));
            quantityLimitedRequest.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(quantityLimitedRequest, fieldData);
        }

        return quantityLimitedRequest;
    } 
}

internal HL7V21Field whoSubjectFilter;

public HL7V21Field WhoSubjectFilter
{
    get
    {
        if (whoSubjectFilter != null)
        {
            return whoSubjectFilter;
        }

        whoSubjectFilter = new HL7V21Field
        {
            field = message[@"QRD"][8],
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
        };

        // check for repetitions
        if (whoSubjectFilter.field.FieldRepetitions != null && whoSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whoSubjectFilter.Id));
            whoSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(whoSubjectFilter, fieldData);
        }

        return whoSubjectFilter;
    } 
}

internal HL7V21Field whatSubjectFilter;

public HL7V21Field WhatSubjectFilter
{
    get
    {
        if (whatSubjectFilter != null)
        {
            return whatSubjectFilter;
        }

        whatSubjectFilter = new HL7V21Field
        {
            field = message[@"QRD"][9],
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
        };

        // check for repetitions
        if (whatSubjectFilter.field.FieldRepetitions != null && whatSubjectFilter.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whatSubjectFilter.Id));
            whatSubjectFilter.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(whatSubjectFilter, fieldData);
        }

        return whatSubjectFilter;
    } 
}

internal HL7V21Field whatDepartmentDataCode;

public HL7V21Field WhatDepartmentDataCode
{
    get
    {
        if (whatDepartmentDataCode != null)
        {
            return whatDepartmentDataCode;
        }

        whatDepartmentDataCode = new HL7V21Field
        {
            field = message[@"QRD"][10],
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
        };

        // check for repetitions
        if (whatDepartmentDataCode.field.FieldRepetitions != null && whatDepartmentDataCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whatDepartmentDataCode.Id));
            whatDepartmentDataCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(whatDepartmentDataCode, fieldData);
        }

        return whatDepartmentDataCode;
    } 
}

internal HL7V21Field whatDataCodeValueQual;

public HL7V21Field WhatDataCodeValueQual
{
    get
    {
        if (whatDataCodeValueQual != null)
        {
            return whatDataCodeValueQual;
        }

        whatDataCodeValueQual = new HL7V21Field
        {
            field = message[@"QRD"][11],
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
        };

        // check for repetitions
        if (whatDataCodeValueQual.field.FieldRepetitions != null && whatDataCodeValueQual.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(whatDataCodeValueQual.Id));
            whatDataCodeValueQual.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(whatDataCodeValueQual, fieldData);
        }

        return whatDataCodeValueQual;
    } 
}

internal HL7V21Field queryResultsLevel;

public HL7V21Field QueryResultsLevel
{
    get
    {
        if (queryResultsLevel != null)
        {
            return queryResultsLevel;
        }

        queryResultsLevel = new HL7V21Field
        {
            field = message[@"QRD"][12],
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
        };

        // check for repetitions
        if (queryResultsLevel.field.FieldRepetitions != null && queryResultsLevel.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(queryResultsLevel.Id));
            queryResultsLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV21FieldRepetitions(queryResultsLevel, fieldData);
        }

        return queryResultsLevel;
    } 
}
    }
}

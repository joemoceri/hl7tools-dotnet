using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentEQL
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EQL"; } }

        public string SegmentId { get { return @"EQL"; } }
        
        public string LongName { get { return @"Embedded Query Language"; } }
        
        public string Description { get { return @"The EQL segment is used to define queries using select statements based on the query language of choice (e.g., SQL).  Refer to the functional chapters for the lists of HL7-defined EQL select statements. "; } }
        
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

        public HL7V26SegmentEQL(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _queryTag;

public HL7V26Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQL.1",
            Type = @"Field",
            Position = @"EQL.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. ",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V26Field
        {
            field = message[@"EQL"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V26Field _queryResponseFormatCode;

public HL7V26Field QueryResponseFormatCode
{
    get
    {
        if (_queryResponseFormatCode != null)
        {
            return _queryResponseFormatCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQL.2",
            Type = @"Field",
            Position = @"EQL.2",
            Name = @"Query/Response Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0106",
            TableName = @"Query/response format code",
            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values.",
            Sample = @"",
            Fields = null
        }

        _queryResponseFormatCode = new HL7V26Field
        {
            field = message[@"EQL"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseFormatCode.field.FieldRepetitions != null && _queryResponseFormatCode.field.FieldRepetitions.Count > 0)
        {
            _queryResponseFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryResponseFormatCode, fieldData);
        }

        return _queryResponseFormatCode;
    } 
}

internal HL7V26Field _eQLQueryName;

public HL7V26Field EQLQueryName
{
    get
    {
        if (_eQLQueryName != null)
        {
            return _eQLQueryName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQL.3",
            Type = @"Field",
            Position = @"EQL.3",
            Name = @"EQL Query Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the query.  Where the default HL7 coding system is used, these names are assigned by the function-specific chapters of this specification.  The values for this field are equivalent to those of SPR-3-Stored procedure name.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQL.3.1",
                            Type = @"Component",
                            Position = @"EQL.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"EQL.3.2",
                            Type = @"Component",
                            Position = @"EQL.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"EQL.3.3",
                            Type = @"Component",
                            Position = @"EQL.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.4",
                            Type = @"Component",
                            Position = @"EQL.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"EQL.3.5",
                            Type = @"Component",
                            Position = @"EQL.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"W",
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
                            Id = @"EQL.3.6",
                            Type = @"Component",
                            Position = @"EQL.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eQLQueryName = new HL7V26Field
        {
            field = message[@"EQL"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eQLQueryName.field.FieldRepetitions != null && _eQLQueryName.field.FieldRepetitions.Count > 0)
        {
            _eQLQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_eQLQueryName, fieldData);
        }

        return _eQLQueryName;
    } 
}

internal HL7V26Field _eQLQueryStatement;

public HL7V26Field EQLQueryStatement
{
    get
    {
        if (_eQLQueryStatement != null)
        {
            return _eQLQueryStatement;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"EQL.4",
            Type = @"Field",
            Position = @"EQL.4",
            Name = @"EQL Query Statement",
            Length = 4096,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the EQL select statement that is the basis of the query. ",
            Sample = @"",
            Fields = null
        }

        _eQLQueryStatement = new HL7V26Field
        {
            field = message[@"EQL"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eQLQueryStatement.field.FieldRepetitions != null && _eQLQueryStatement.field.FieldRepetitions.Count > 0)
        {
            _eQLQueryStatement.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_eQLQueryStatement, fieldData);
        }

        return _eQLQueryStatement;
    } 
}
    }
}

using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentEQL
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"EQL"; } }

        public string SegmentId { get { return @"EQL"; } }
        
        public string LongName { get { return @"Embedded Query Language"; } }
        
        public string Description { get { return @"The EQL segment is used to define queries using select statements based on the query language of choice (e.g., SQL).  Refer to the functional chapters for the lists of HL7-defined EQL select statements. 

This segment is not carried forward to the recommended queries for v 2.4."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. 
5",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values.  ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.1",
                            Type = @"Component",
                            Position = @"EQL.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.2",
                            Type = @"Component",
                            Position = @"EQL.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.3",
                            Type = @"Component",
                            Position = @"EQL.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.4",
                            Type = @"Component",
                            Position = @"EQL.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.5",
                            Type = @"Component",
                            Position = @"EQL.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.6",
                            Type = @"Component",
                            Position = @"EQL.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V25SegmentEQL(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field queryTag;

public HL7V25Field QueryTag
{
    get
    {
        if (queryTag != null)
        {
            return queryTag;
        }

        queryTag = new HL7V25Field
        {
            field = message[@"EQL"][1],
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
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. 
5",
            Sample = @"",
        };

        

        

        

        return queryTag;
    } 
}
internal HL7V25Field queryResponseFormatCode;

public HL7V25Field QueryResponseFormatCode
{
    get
    {
        if (queryResponseFormatCode != null)
        {
            return queryResponseFormatCode;
        }

        queryResponseFormatCode = new HL7V25Field
        {
            field = message[@"EQL"][2],
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
            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values.  ",
            Sample = @"",
        };

        

        

        

        return queryResponseFormatCode;
    } 
}
internal HL7V25Field eQLQueryName;

public HL7V25Field EQLQueryName
{
    get
    {
        if (eQLQueryName != null)
        {
            return eQLQueryName;
        }

        eQLQueryName = new HL7V25Field
        {
            field = message[@"EQL"][3],
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
        };

        

        

        

        return eQLQueryName;
    } 
}
internal HL7V25Field eQLQueryStatement;

public HL7V25Field EQLQueryStatement
{
    get
    {
        if (eQLQueryStatement != null)
        {
            return eQLQueryStatement;
        }

        eQLQueryStatement = new HL7V25Field
        {
            field = message[@"EQL"][4],
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
        };

        

        

        

        return eQLQueryStatement;
    } 
}

    }
}

using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentQAK
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"QAK"; } }

        public string SegmentId { get { return @"QAK"; } }
        
        public string LongName { get { return @"Query Acknowledgement"; } }
        
        public string Description { get { return @"The QAK segment contains information sent with responses to a query. "; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QAK.1",
                            Type = @"Field",
                            Position = @"QAK.1",
                            Name = @"Query tag",
                            Length = 32,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.2",
                            Type = @"Field",
                            Position = @"QAK.2",
                            Name = @"Query response status",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0208",
                            TableName = @"Query response status",
                            Description = @"This field allows the responding system to return a precise response status.  It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error.  It is defined with HL7 table 0208 - Query response status",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentQAK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field querytag;

public HL7V23Field Querytag
{
    get
    {
        if (querytag != null)
        {
            return querytag;
        }

        querytag = new HL7V23Field
        {
            field = message[@"QAK"][1],
            Id = @"QAK.1",
            Type = @"Field",
            Position = @"QAK.1",
            Name = @"Query tag",
            Length = 32,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole",
            Sample = @"",
        };

        

        

        

        return querytag;
    } 
}
internal HL7V23Field queryresponsestatus;

public HL7V23Field Queryresponsestatus
{
    get
    {
        if (queryresponsestatus != null)
        {
            return queryresponsestatus;
        }

        queryresponsestatus = new HL7V23Field
        {
            field = message[@"QAK"][2],
            Id = @"QAK.2",
            Type = @"Field",
            Position = @"QAK.2",
            Name = @"Query response status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0208",
            TableName = @"Query response status",
            Description = @"This field allows the responding system to return a precise response status.  It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error.  It is defined with HL7 table 0208 - Query response status",
            Sample = @"",
        };

        

        

        

        return queryresponsestatus;
    } 
}

    }
}

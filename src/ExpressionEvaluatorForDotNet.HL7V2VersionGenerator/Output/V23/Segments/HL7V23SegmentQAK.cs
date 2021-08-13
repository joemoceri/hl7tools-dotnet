using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentQAK
    {
        public HL7V2Message message { get; init; }

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

        public HL7V23SegmentQAK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _querytag;

public HL7V23Field Querytag
{
    get
    {
        if (_querytag != null)
        {
            return _querytag;
        }

        var fieldData = new HL7V23FieldData
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
            Fields = null
        }

        _querytag = new HL7V23Field
        {
            field = message[@"QAK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_querytag.field.FieldRepetitions != null && _querytag.field.FieldRepetitions.Count > 0)
        {
            _querytag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_querytag, fieldData);
        }

        return _querytag;
    } 
}

internal HL7V23Field _queryresponsestatus;

public HL7V23Field Queryresponsestatus
{
    get
    {
        if (_queryresponsestatus != null)
        {
            return _queryresponsestatus;
        }

        var fieldData = new HL7V23FieldData
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
            Fields = null
        }

        _queryresponsestatus = new HL7V23Field
        {
            field = message[@"QAK"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryresponsestatus.field.FieldRepetitions != null && _queryresponsestatus.field.FieldRepetitions.Count > 0)
        {
            _queryresponsestatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_queryresponsestatus, fieldData);
        }

        return _queryresponsestatus;
    } 
}
    }
}

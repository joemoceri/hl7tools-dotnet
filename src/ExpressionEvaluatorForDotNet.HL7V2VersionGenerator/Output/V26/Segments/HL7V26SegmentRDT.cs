using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentRDT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RDT"; } }

        public string SegmentId { get { return @"RDT"; } }
        
        public string LongName { get { return @"Table Row Data"; } }
        
        public string Description { get { return @"The RDT segment contains the row data of the tabular data response message (TBR)."; } }
        
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

        public HL7V26SegmentRDT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _columnValue;

public HL7V26Field ColumnValue
{
    get
    {
        if (_columnValue != null)
        {
            return _columnValue;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"RDT.1",
            Type = @"Field",
            Position = @"RDT.1",
            Name = @"Column Value",
            Length = 99999,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field is a requested field. Fields occur in the position order defined for the query or table (unless overridden by an optional RDF segment on a stored procedure request or Virtual Table query message), separated by field delimiters.",
            Sample = @"",
            Fields = null
        }

        _columnValue = new HL7V26Field
        {
            field = message[@"RDT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_columnValue.field.FieldRepetitions != null && _columnValue.field.FieldRepetitions.Count > 0)
        {
            _columnValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_columnValue, fieldData);
        }

        return _columnValue;
    } 
}
    }
}

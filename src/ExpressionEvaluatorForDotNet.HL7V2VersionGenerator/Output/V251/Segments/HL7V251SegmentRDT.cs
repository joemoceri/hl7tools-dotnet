using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentRDT
    {
        public readonly HL7V2Message message;

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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
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
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V251SegmentRDT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field columnValue;

public HL7V251Field ColumnValue
{
    get
    {
        if (columnValue != null)
        {
            return columnValue;
        }

        columnValue = new HL7V251Field
        {
            field = message[@"RDT"][1],
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
        };

        

        

        

        return columnValue;
    } 
}

    }
}

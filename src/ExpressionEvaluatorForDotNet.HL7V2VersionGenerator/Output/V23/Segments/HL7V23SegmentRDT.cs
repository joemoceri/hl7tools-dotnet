using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentRDT
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RDT"; } }

        public string SegmentId { get { return @"RDT"; } }
        
        public string LongName { get { return @"Table Row Data"; } }
        
        public string Description { get { return @"The RDT segment contains the row data of the tabular data response message (TBR"; } }
        
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
                            Id = @"RDT.1",
                            Type = @"Field",
                            Position = @"RDT.1",
                            Name = @"Column value",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"VARIES",
                            DataTypeName = @"Variable Datatype",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a requested field.  Fields occur in the position order defined for the query or table, (unless overridden by an optional RDF segment on a stored procedure request or virtual table query message), separated by field delimiters",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V23SegmentRDT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field columnvalue;

public HL7V23Field Columnvalue
{
    get
    {
        if (columnvalue != null)
        {
            return columnvalue;
        }

        columnvalue = new HL7V23Field
        {
            field = message[@"RDT"][1],
            Id = @"RDT.1",
            Type = @"Field",
            Position = @"RDT.1",
            Name = @"Column value",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field is a requested field.  Fields occur in the position order defined for the query or table, (unless overridden by an optional RDF segment on a stored procedure request or virtual table query message), separated by field delimiters",
            Sample = @"",
        };

        

        

        

        return columnvalue;
    } 
}

    }
}

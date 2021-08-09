using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRDT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RDT"; } }

        public string SegmentId { get { return @"RDT"; } }
        
        public string LongName { get { return @"Table row data segment"; } }
        
        public string Description { get { return @"The RDT segment contains the row data of the tabular data response message (TBR)."; } }
        
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
                            Name = @"Column Value",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"VARIES",
                            DataTypeName = @"Variable Datatype",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a requested field. Fields occur in the position order defined for the query or table, (unless overridden by an optional RDF segment on a stored procedure request or virtual table query message), separated by field delimiters.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V231SegmentRDT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field columnValue;

public HL7V231Field ColumnValue
{
    get
    {
        if (columnValue != null)
        {
            return columnValue;
        }

        columnValue = new HL7V231Field
        {
            field = message[@"RDT"][1],
            Id = @"RDT.1",
            Type = @"Field",
            Position = @"RDT.1",
            Name = @"Column Value",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field is a requested field. Fields occur in the position order defined for the query or table, (unless overridden by an optional RDF segment on a stored procedure request or virtual table query message), separated by field delimiters.",
            Sample = @"",
        };

        // check for repetitions
        if (columnValue.field.FieldRepetitions != null && columnValue.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(columnValue.Id));
            columnValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(columnValue, fieldData);
        }

        return columnValue;
    } 
}
    }
}

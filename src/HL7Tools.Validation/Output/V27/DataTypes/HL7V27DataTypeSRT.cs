using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeSRT
    {
        public string Id { get { return @"SRT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Sort Order"; } }

        public string Description { get { return @"Specifies those parameters by which the response will be sorted and by what method. 

Example: In a tabular response query, where the return data is known by column name, the SRT might look like:
|LastName^A~FirstName^A|

Example: In a segment response query, where the return data is known by segment and offset, the SRT field would use segment field name notation:
|PID.3.1^A~PID.3.2|"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SRT.1",
                            Type = @"DataTypeComponent",
                            Position = @"SRT.1",
                            Name = @"Sort-by Field",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the field by which the response will be sorted. In a tabular response, this will be the column name to sort by. In the Segment Pattern and the Display Response, this will be the segment field name to sort by. See QIP in Section 2.A.59.1, ""Segment Field Name (ST)"" for segment field name definition.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SRT.2",
                            Type = @"DataTypeComponent",
                            Position = @"SRT.2",
                            Name = @"Sequencing",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0397",
                            TableName = @"Sequencing",
                            Description = @"Identifies how the field or parameter will be sorted; and, if sorted, whether the sort will be case sensitive (the default) or not. Refer to HL7 Table 0397 – Sequencing  for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

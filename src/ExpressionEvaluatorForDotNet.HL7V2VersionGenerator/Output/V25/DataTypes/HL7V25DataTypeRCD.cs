using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"RCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Row Column Definition"; } }

        public string Description { get { return @"This specifies the format of a column in terms of a segment field name, a data type, and a maximum length."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 19; } }

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
                            Id = @"RCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HL7 segment field name, which identifies the field occupying the column. Refer to Section 2.A.59.1, ""Segment Field Name (ST),"" for segment field name definition conventions.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCD.2",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.2",
                            Name = @"Hl7 Data Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0440",
                            TableName = @"Data types",
                            Description = @"The two or three character HL7 data type. Refer to HL7 Table 0440 - Data Types in section 2.16 for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCD.3",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.3",
                            Name = @"Maximum Column Width",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum width of the column, as dictated by the responding system. This may vary from the HL7-defined maximum field length.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

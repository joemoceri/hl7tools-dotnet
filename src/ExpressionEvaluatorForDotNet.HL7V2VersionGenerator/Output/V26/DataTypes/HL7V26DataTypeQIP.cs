using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"QIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Input Parameter List"; } }

        public string Description { get { return @"This data type contains a segment field name and the list of values to be passed to the query processor."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 212; } }

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
                            Id = @"QIP.1",
                            Type = @"DataTypeComponent",
                            Position = @"QIP.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the segment field name.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"QIP.2",
                            Name = @"Values",
                            Length = 199,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form ""value1& value2 & value3...""",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

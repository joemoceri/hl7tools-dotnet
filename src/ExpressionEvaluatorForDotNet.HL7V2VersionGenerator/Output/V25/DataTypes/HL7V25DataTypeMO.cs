using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"MO"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Money"; } }

        public string Description { get { return @"This data type specifies an amount of money and the denomination in which it is expressed."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 20; } }

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
                            Id = @"MO.1",
                            Type = @"DataTypeComponent",
                            Position = @"MO.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MO.2",
                            Type = @"DataTypeComponent",
                            Position = @"MO.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

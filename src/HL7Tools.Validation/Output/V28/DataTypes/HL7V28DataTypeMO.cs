using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeMO
    {
        public string Id { get { return @"MO"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Money"; } }

        public string Description { get { return @"This data type specifies an amount of money and the denomination in which it is expressed."; } }

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
                            Id = @"MO.1",
                            Type = @"DataTypeComponent",
                            Position = @"MO.1",
                            Name = @"Quantity",
                            Length = 0,
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
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0913",
                            TableName = @"Monetary Denomination Code",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913 – Monetary Denomination Code.

If the denomination is not specified, ""MSH-17-country code"", in Chapter 2, section 2.14.9.17, is used to determine the default. 

Example, where USD is the ISO 4217 code for the U.S. American dollar. 
|99.50^USD|",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

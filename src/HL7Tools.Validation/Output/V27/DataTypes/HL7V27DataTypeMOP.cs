using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeMOP
    {
        public string Id { get { return @"MOP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Money Or Percentage"; } }

        public string Description { get { return @"This data type specifies an amount that may be either currency or a percentage. It is a variation on the MO data type that is limited to currency.

Note: Replaces the CM data type used in section 6.5.8.5 IN3-5, as of v 2.5. This data type is restricted to this field.

Example: USD is the ISO 4217 code for the U.S. American dollar.
|AT^99.50^USD|"; } }

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
                            Id = @"MOP.1",
                            Type = @"DataTypeComponent",
                            Position = @"MOP.1",
                            Name = @"Money Or Percentage Indicator",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0148",
                            TableName = @"Money or Percentage Indicator",
                            Description = @"Specifies whether the amount is currency or a percentage.

Refer to HL7 Table 0148 – Money or Percentage Indicator for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MOP.2",
                            Type = @"DataTypeComponent",
                            Position = @"MOP.2",
                            Name = @"Money Or Percentage Quantity",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the currency or percentage quantity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MOP.3",
                            Type = @"DataTypeComponent",
                            Position = @"MOP.3",
                            Name = @"Monetary  Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0913",
                            TableName = @"Monetary Denomination Code",
                            Description = @"the denomination in which the quantity is expressed where the amount is currency. The values for the denomination component are the three-character codes specified in ISO-4217. See Externally-defined Table 0913 – Monetary Denomination Code.

If the denomination is not specified, the context of the message or MSH-17 Country Code, in Chapter 2, section 2.14.9.17, is used to determine the default.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

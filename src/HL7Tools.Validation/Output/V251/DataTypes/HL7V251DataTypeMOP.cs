using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeMOP
    {
        public string Id { get { return @"MOP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Money or Percentage"; } }

        public string Description { get { return @"This data type specifies an amount that may be either currency or a percentage. It is a variation on the MO data type that is limited to currency.

Example: USD is the ISO 4217 code for the U.S. American dollar. |AT^99.50^USD| "; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 23; } }

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
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0148",
                            TableName = @"Money or percentage indicator",
                            Description = @"Specifies whether the amount is currency or a percentage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MOP.2",
                            Type = @"DataTypeComponent",
                            Position = @"MOP.2",
                            Name = @"Money Or Percentage Quantity",
                            Length = 16,
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
                            Name = @"Currency Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"the denomination in which the quantity is expressed where the amount is currency. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, the context of the message or MSH-17-country code is used to determine the default.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

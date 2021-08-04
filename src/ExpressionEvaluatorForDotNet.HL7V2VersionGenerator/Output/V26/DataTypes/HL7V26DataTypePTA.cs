using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"PTA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Policy Type and Amount"; } }

        public string Description { get { return @"This data type specifies the policy type and amount covered by the insurance."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 56; } }

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
                            Id = @"PTA.1",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.1",
                            Name = @"Policy Type",
                            Length = 5,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0147",
                            TableName = @"Policy type",
                            Description = @"Specifies the policy type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTA.2",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.2",
                            Name = @"Amount Class",
                            Length = 9,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0193",
                            TableName = @"Amount class",
                            Description = @"Specifies the amount quantity class.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTA.3",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.3",
                            Name = @"Money Or Percentage Quantity",
                            Length = 16,
                            Usage = @"B",
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
                            Id = @"PTA.4",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.4",
                            Name = @"Money Or Percentage",
                            Length = 23,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MOP",
                            DataTypeName = @"Money or Percentage",
                            TableId = null,
                            TableName = null,
                            Description = @"specifies an amount that may be either currency or a percentage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypePTA
    {
        public string Id { get { return @"PTA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Policy Type And Amount"; } }

        public string Description { get { return @"This data type specifies the policy type and amount covered by the insurance.

Note: Replaces the CM data type used in section 6.5.7.29 IN2-29, as of v 2.5."; } }

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
                            Id = @"PTA.1",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.1",
                            Name = @"Policy Type",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0147",
                            TableName = @"Policy Type",
                            Description = @"Specifies the policy type.

Refer to User-defined Table 0147 - Policy Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTA.2",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.2",
                            Name = @"Amount Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0193",
                            TableName = @"Amount Class",
                            Description = @"Specifies the amount quantity class.

Refer to User-defined Table 0193 - Amount Class for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTA.3",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.3",
                            Name = @"Money Or Percentage Quantity",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The PTA.3 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to PTA.4 instead.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTA.4",
                            Type = @"DataTypeComponent",
                            Position = @"PTA.4",
                            Name = @"Money Or Percentage",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MOP",
                            DataTypeName = @"Money Or Percentage",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an amount that may be either currency or a percentage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

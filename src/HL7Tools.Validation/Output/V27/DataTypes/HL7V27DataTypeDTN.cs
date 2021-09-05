using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeDTN
    {
        public string Id { get { return @"DTN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Day Type And Number"; } }

        public string Description { get { return @"This data type specifies the type and number of days for which a certification is valid.

Note: Replaces the CM data type used in section 6.5.8.11 IN3-11, as of v2.5."; } }

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
                            Id = @"DTN.1",
                            Type = @"DataTypeComponent",
                            Position = @"DTN.1",
                            Name = @"Day Type",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0149",
                            TableName = @"Day Type",
                            Description = @"Specifies whether the days are denied, pending, or approved.

Refer to User-defined Table 0149 - Day Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DTN.2",
                            Type = @"DataTypeComponent",
                            Position = @"DTN.2",
                            Name = @"Number Of Days",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the number of days for which the certification is valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

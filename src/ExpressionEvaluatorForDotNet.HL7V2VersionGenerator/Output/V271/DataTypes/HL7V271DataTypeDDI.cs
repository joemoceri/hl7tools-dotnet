using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"DDI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Daily Deductible Information"; } }

        public string Description { get { return @"This data type specifies the detail information for the daily deductible.

Note: Replaces the CM data type used in section 6.5.7.30 IN2-30, as of v 2.5."; } }

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
                            Id = @"DDI.1",
                            Type = @"DataTypeComponent",
                            Position = @"DDI.1",
                            Name = @"Delay Days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number of days after which the daily deductible begins.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DDI.2",
                            Type = @"DataTypeComponent",
                            Position = @"DDI.2",
                            Name = @"Monetary Amount",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The monetary amount of the deductible.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DDI.3",
                            Type = @"DataTypeComponent",
                            Position = @"DDI.3",
                            Name = @"Number Of Days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number of days to apply the deductible. If this component is not populated, it means that the number of days is indefinite.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

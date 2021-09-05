using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataTypeNR
    {
        public string Id { get { return @"NR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Numeric Range"; } }

        public string Description { get { return @"Specifies the interval between the lowest and the highest values in a series of data. In the case where a numeric range is unbounded on one side, the component of the unbounded side is null. Whether the end points are included in the range is defined in the usage note for the field."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 33; } }

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
                            Id = @"NR.1",
                            Type = @"DataTypeComponent",
                            Position = @"NR.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NR.2",
                            Type = @"DataTypeComponent",
                            Position = @"NR.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

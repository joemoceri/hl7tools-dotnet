using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"CQ"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Quantity with Units"; } }

        public string Description { get { return null; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 722; } }

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
                            Id = @"CQ.1",
                            Type = @"DataTypeComponent",
                            Position = @"CQ.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CQ.2",
                            Type = @"DataTypeComponent",
                            Position = @"CQ.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

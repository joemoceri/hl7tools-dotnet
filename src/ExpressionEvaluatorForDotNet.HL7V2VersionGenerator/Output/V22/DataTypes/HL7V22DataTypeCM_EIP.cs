using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_EIP
    {
        public string Id { get { return @"CM_EIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Parent Order"; } }

        public string Description { get { return null; } }

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
                            Id = @"CM_EIP.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_EIP.1",
                            Name = @"Parent's Placer Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the placer order number of the parent order.  It is required when the order is a child",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_EIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_EIP.2",
                            Name = @"Parent's Filler Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler order number of the parent order.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

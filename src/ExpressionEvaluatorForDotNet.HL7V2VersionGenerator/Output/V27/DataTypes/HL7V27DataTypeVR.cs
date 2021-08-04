using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"VR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Value Range"; } }

        public string Description { get { return @"This data type contains the lower bound value and upper bound values that constitute a range. Either or both components may be populated.
Note: Replaces the CM data type used in 5.10.5.3.11 QRD-11 as of v 2.5.

The VR differs from the Numeric Range (NR) data type only in that the values are not restricted to numbers. If the range is not numeric, the set must be orderable in some intuitive way such as alpha or the order must be defined in the field where the data type is used.

Example 1:
 |+^+++|

Example 2: Colors of the rainbow
|violet^red|"; } }

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
                            Id = @"VR.1",
                            Type = @"DataTypeComponent",
                            Position = @"VR.1",
                            Name = @"First Data Code Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the lower bound value.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VR.2",
                            Type = @"DataTypeComponent",
                            Position = @"VR.2",
                            Name = @"Last Data Code Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the upper bound value.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

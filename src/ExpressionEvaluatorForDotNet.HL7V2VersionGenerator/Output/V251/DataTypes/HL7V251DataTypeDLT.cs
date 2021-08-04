using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeDLT
    {
        public string Id { get { return @"DLT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Delta"; } }

        public string Description { get { return @"Describes the information that controls delta check warnings."; } }

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
                            Id = @"DLT.1",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.1",
                            Name = @"Normal Range",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the normal interval of the reference data",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.2",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.2",
                            Name = @"Numeric Threshold",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.3",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.3",
                            Name = @"Change Computation",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0523",
                            TableName = @"Computation type",
                            Description = @"Specifies if the change is computed as a percent change or as an absolute change. Refer to HL7 Table 0523 - Computation type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.4",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.4",
                            Name = @"Days Retained",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The length of time in days that the value is retained for computing delta checks.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

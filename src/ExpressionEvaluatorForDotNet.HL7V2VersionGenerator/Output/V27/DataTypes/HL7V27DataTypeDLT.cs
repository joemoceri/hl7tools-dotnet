using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeDLT
    {
        public string Id { get { return @"DLT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Delta"; } }

        public string Description { get { return @"Describes the information that controls delta check warnings.

Note: Replaces the CM data type used in section 8.8.4.9 – OM2-9, as of v 2.5."; } }

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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the normal interval of the reference data.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.2",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.2",
                            Name = @"Numeric Threshold",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected. 

For example the threshold may be set to 10. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.3",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.3",
                            Name = @"Change Computation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0523",
                            TableName = @"Computation Type",
                            Description = @"Specifies if the change is computed as a percent change or as an absolute change. Refer to HL7 Table 0523 - Computation Type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLT.4",
                            Type = @"DataTypeComponent",
                            Position = @"DLT.4",
                            Name = @"Days Retained",
                            Length = 0,
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

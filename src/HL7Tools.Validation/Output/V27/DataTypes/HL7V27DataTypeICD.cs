using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeICD
    {
        public string Id { get { return @"ICD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Insurance Certification Definition"; } }

        public string Description { get { return @"This data type specifies whether insurance certification is required for particular patient types, and the time window for obtaining the certification. 

Note: Replaces the CM data type used in section 6.5.8.20 IN3-20, as of v2.5."; } }

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
                            Id = @"ICD.1",
                            Type = @"DataTypeComponent",
                            Position = @"ICD.1",
                            Name = @"Certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0150",
                            TableName = @"Certification Patient Type",
                            Description = @"Specifies the category or type of patient for which this certification is requested. Refer to User-defined Table 0150 - Certification patient type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ICD.2",
                            Type = @"DataTypeComponent",
                            Position = @"ICD.2",
                            Name = @"Certification Required",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0136",
                            TableName = @"Yes/no Indicator",
                            Description = @"Specifies whether or not a certification is required. Refer to HL7 Table 0136 - Yes/no Indicator for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ICD.3",
                            Type = @"DataTypeComponent",
                            Position = @"ICD.3",
                            Name = @"Date/Time Certification Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The date/time by which the certification must be obtained. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

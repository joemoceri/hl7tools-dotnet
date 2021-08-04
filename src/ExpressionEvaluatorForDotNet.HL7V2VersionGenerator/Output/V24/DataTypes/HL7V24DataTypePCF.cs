using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypePCF
    {
        public string Id { get { return @"PCF"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Pre-certification Required"; } }

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
                            Id = @"PCF.1",
                            Type = @"DataTypeComponent",
                            Position = @"PCF.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0150",
                            TableName = @"Pre-certification patient type",
                            Description = @"pre-certification patient type refers to User-defined Table 0150 - Pre-certification patient type for suggested values ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCF.2",
                            Type = @"DataTypeComponent",
                            Position = @"PCF.2",
                            Name = @"Pre-certification Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"pre-certification required refers to HL7 table 0136 - Yes/no indicator for valid values ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PCF.3",
                            Type = @"DataTypeComponent",
                            Position = @"PCF.3",
                            Name = @"Pre-certification Window",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"pre-certification window is the amount of time required to attain certification from arrival at the institution. Its format follows the time stamp (TS) data type rules.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

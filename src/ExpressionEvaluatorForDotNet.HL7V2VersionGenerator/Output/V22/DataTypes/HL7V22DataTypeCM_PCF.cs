using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CM_PCF"; } }

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
                            Id = @"CM_PCF.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PCF.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0150",
                            TableName = @"PRECERTIFICATION PATIENT TYPE",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_PCF.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PCF.2",
                            Name = @"Pre-certication Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = @"0136",
                            TableName = @"Y/N INDICATOR",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_PCF.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PCF.3",
                            Name = @"Pre-certification Window",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

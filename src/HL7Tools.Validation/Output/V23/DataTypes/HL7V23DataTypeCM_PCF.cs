using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeCM_PCF
    {
        public string Id { get { return @"CM_PCF"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Pre-certification Required"; } }

        public string Description { get { return @"This field indicates whether pre-certification is required for particular patient types, and the time window for obtaining the certification."; } }

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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0150",
                            TableName = @"Pre-certification patient type",
                            Description = @"pre-certification patient type refers to user-defined table 0150 - Pre-certification patient type for suggested values ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_PCF.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PCF.2",
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
                            Id = @"CM_PCF.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PCF.3",
                            Name = @"Pre-certification Windwow",
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

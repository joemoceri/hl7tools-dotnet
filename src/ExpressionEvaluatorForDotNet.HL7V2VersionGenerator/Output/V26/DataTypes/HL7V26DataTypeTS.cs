using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeTS
    {
        public string Id { get { return @"TS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time Stamp"; } }

        public string Description { get { return @"Attention: The TS data type has been replaced by the DTM data type and the detail was withdrawn and removed from the standard as of v 2.6."; } }

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
                            Id = @"TS.1",
                            Type = @"DataTypeComponent",
                            Position = @"TS.1",
                            Name = @"Time",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TS.2",
                            Type = @"DataTypeComponent",
                            Position = @"TS.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
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

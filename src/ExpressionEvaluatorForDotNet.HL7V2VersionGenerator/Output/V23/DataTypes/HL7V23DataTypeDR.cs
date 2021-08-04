using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"DR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date Time Range"; } }

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
                            Id = @"DR.1",
                            Type = @"DataTypeComponent",
                            Position = @"DR.1",
                            Name = @"Range Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DR.2",
                            Type = @"DataTypeComponent",
                            Position = @"DR.2",
                            Name = @"Range End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

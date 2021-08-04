using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"CCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Charge Code and Date"; } }

        public string Description { get { return @"Specifies whether a charge action is based on an invocation event or is time-based."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 28; } }

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
                            Id = @"CCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"CCD.1",
                            Name = @"Invocation Event",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0100",
                            TableName = @"Invocation event",
                            Description = @"Specifies the code for the event precipitating/triggering the charge activity. Refer to HL7 Table 0100 - Invocation event for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CCD.2",
                            Type = @"DataTypeComponent",
                            Position = @"CCD.2",
                            Name = @"Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is used to express the exact time to charge for the ordered service; it is used only when the CCD.1 value is T. When used, it is expressed as a TS data type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

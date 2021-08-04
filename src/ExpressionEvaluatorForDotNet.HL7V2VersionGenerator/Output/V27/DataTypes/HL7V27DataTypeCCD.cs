using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeCCD
    {
        public string Id { get { return @"CCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Charge Code And Date"; } }

        public string Description { get { return @"Specifies whether a charge action is based on an invocation event or is time-based.

Note: Replaces the CM data type used in section 4.5.2.1 BLG-1, as of v2.5."; } }

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
                            Id = @"CCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"CCD.1",
                            Name = @"Invocation Event",
                            Length = 1,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
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
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is used to express the exact time to charge for the ordered service; it is used only when the CCD.1 value is T. When used, it is expressed as a DTM data type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

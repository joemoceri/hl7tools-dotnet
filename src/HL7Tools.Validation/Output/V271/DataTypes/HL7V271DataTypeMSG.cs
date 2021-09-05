using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeMSG
    {
        public string Id { get { return @"MSG"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Message Type"; } }

        public string Description { get { return @"This field contains the message type, trigger event, and the message structure ID for the message.

Note: Replaces the CM data type used in 2.16.9.9 MSH-9 as of v 2.5."; } }

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
                            Id = @"MSG.1",
                            Type = @"DataTypeComponent",
                            Position = @"MSG.1",
                            Name = @"Message Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0076",
                            TableName = @"Message Type",
                            Description = @"Specifies the message type code. Refer to HL7 Table 0076– Message Type for valid values.

This table contains values such as ACK, ADT, ORM, ORU etc. 

See Chapter 2, ""Control"", section 2.5.1, ""Messages"" for further discussion.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSG.2",
                            Type = @"DataTypeComponent",
                            Position = @"MSG.2",
                            Name = @"Trigger Event",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0003",
                            TableName = @"Event Type",
                            Description = @"Specifies the trigger event code. Refer to HL7 Table 0003– Event Type for valid values. 

This table contains values like A01, O01, R01 etc.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSG.3",
                            Type = @"DataTypeComponent",
                            Position = @"MSG.3",
                            Name = @"Message Structure",
                            Length = 7,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0354",
                            TableName = @"Message Structure",
                            Description = @"Specifies the abstract message structure code. Refer to HL7 Table 0354 – Message Structure for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

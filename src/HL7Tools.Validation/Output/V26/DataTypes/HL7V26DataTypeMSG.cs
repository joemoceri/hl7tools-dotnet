using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeMSG
    {
        public string Id { get { return @"MSG"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Message Type"; } }

        public string Description { get { return @"This field contains the message type, trigger event, and the message structure ID for the message."; } }

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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"Specifies the message type code. Refer to HL7 Table 0076- Message Type in section 2.16.1 for valid values.",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"Specifies the trigger event code. Refer to HL7 Table 0003- Event Type in section 2.16.2 for valid values.",
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
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = @"Specifies the abstract message structure code. Refer to HL7 Table 0354 - Message Structure in section 2.17.3 for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

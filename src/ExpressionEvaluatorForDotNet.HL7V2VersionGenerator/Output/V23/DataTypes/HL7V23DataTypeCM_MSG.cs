using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeCM_MSG
    {
        public string Id { get { return @"CM_MSG"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Message Type"; } }

        public string Description { get { return @"This field contains the message type and trigger event for the message. "; } }

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
                            Id = @"CM_MSG.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_MSG.1",
                            Name = @"Message Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"The first component is the message type edited by HL7 table 0076 - Message type",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_MSG.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_MSG.2",
                            Name = @"Trigger Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"The second is the trigger event code edited by HL7 table 0003 - Event type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

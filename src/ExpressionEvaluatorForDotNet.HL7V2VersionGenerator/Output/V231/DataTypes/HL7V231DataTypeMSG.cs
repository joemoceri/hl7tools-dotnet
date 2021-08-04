using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
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
                            Name = @"Message Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0076",
                            TableName = @"Message type",
                            Description = @"The first component is the message type code defined by HL7 table 0076 - Message type",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSG.2",
                            Type = @"DataTypeComponent",
                            Position = @"MSG.2",
                            Name = @"Trigger Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0003",
                            TableName = @"Event type",
                            Description = @"The second component is the trigger event code defined by HL7 table 0003 - Event type",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MSG.3",
                            Type = @"DataTypeComponent",
                            Position = @"MSG.3",
                            Name = @"Message Structure",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0354",
                            TableName = @"Message structure",
                            Description = @"The third component is the abstract message structure code defined by HL7 Table 0354 - Message structure.  This table has two columns.  The first column contains the value of this code, which describes a particular HL7 “abstract message structure definition” in terms of segments, as defined in sections 2.11 and 2.11.1.  The second column of table 0354 lists the various HL7 trigger events that use the particular abstract message definition.  For example, the message structure code ADT_A01 describes the single abstract message structure used by the trigger events A01, A04, A05, A08, A13, A14, A28 and A31",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

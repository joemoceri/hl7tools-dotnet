using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"PT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Processing Type"; } }

        public string Description { get { return @"This data type indicates whether to process a message as defined in HL7 Application (level 7) Processing rules."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 3; } }

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
                            Id = @"PT.1",
                            Type = @"DataTypeComponent",
                            Position = @"PT.1",
                            Name = @"Processing Id",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0103",
                            TableName = @"Processing ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system. Refer to HL7 Table 0103 - Processing ID for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PT.2",
                            Type = @"DataTypeComponent",
                            Position = @"PT.2",
                            Name = @"Processing Mode",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0207",
                            TableName = @"Processing mode",
                            Description = @"A value that defines whether the message is part of an archival process or an initial load. Refer to HL7 Table 0207 - Processing mode for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

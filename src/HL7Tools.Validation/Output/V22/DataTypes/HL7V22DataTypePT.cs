using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypePT
    {
        public string Id { get { return @"PT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Processing Type"; } }

        public string Description { get { return @"This data type indicates whether to process a message as defined in HL7 Application (level 7) Processing rules"; } }

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
                            Id = @"PT.1",
                            Type = @"DataTypeComponent",
                            Position = @"PT.1",
                            Name = @"Processing ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"0103",
                            TableName = @"PROCESSING ID",
                            Description = @"A value that defines whether the message is part of a production, training, or debugging system.  Refer to HL7 table 0103 - Processing ID for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PT.2",
                            Type = @"DataTypeComponent",
                            Position = @"PT.2",
                            Name = @"Processing Mode",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A value that defines whether the message is part of an archival process or an initial load.  Refer to HL7 table 0207 - Processing mode for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

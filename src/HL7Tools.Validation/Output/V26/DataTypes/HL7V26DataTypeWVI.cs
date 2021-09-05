using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeWVI
    {
        public string Id { get { return @"WVI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Identifier"; } }

        public string Description { get { return @"This data type specifies the number and name of the recording channel where waveform data is transmitted."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 22; } }

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
                            Id = @"WVI.1",
                            Type = @"DataTypeComponent",
                            Position = @"WVI.1",
                            Name = @"Channel Number",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the number of the recording channel.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"WVI.2",
                            Type = @"DataTypeComponent",
                            Position = @"WVI.2",
                            Name = @"Channel Name",
                            Length = 17,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the name of the recording channel.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

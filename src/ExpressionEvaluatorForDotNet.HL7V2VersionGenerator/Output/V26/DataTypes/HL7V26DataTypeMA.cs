using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"MA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Multiplexed Array"; } }

        public string Description { get { return @"This data type is used to represent channel-multiplexed waveform data. Assuming that fields that utilize this data type repeat and that Y represents the specific repetition, the components of the repetition will reflect sample Y from each channel."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 65536; } }

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
                            Id = @"MA.1",
                            Type = @"DataTypeComponent",
                            Position = @"MA.1",
                            Name = @"Sample Y From Channel 1",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MA.2",
                            Type = @"DataTypeComponent",
                            Position = @"MA.2",
                            Name = @"Sample Y From Channel 2",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MA.3",
                            Type = @"DataTypeComponent",
                            Position = @"MA.3",
                            Name = @"Sample Y From Channel 3",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MA.4",
                            Type = @"DataTypeComponent",
                            Position = @"MA.4",
                            Name = @"Sample Y From Channel 4",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataTypeMA
    {
        public string Id { get { return @"MA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Multiplexed Array"; } }

        public string Description { get { return @"This data type is used to represent channel-multiplexed waveform data, (e.g., the digitized values from an analog-to-digital converter or other digital data source). Each value is of type NM, and represents a time sample from a channel. This segment may contain data from one or more channels. The waveform data is in channel-multiplexed format (that is, the values for all channels for the first time sample are transmitted, then the values for the next time sample, and so on until the requisite number of time samples have been transmitted). Time samples are separated by repeat delimiters (~), and channels within a sample are separated by component delimiters (^). The time between samples (the sampling interval) is the reciprocal of the digitization frequency as specified using the CD data type."; } }

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
                            Name = @"Sample 1 From Channel 1",
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
                            Name = @"Sample 1 From Channel 2",
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
                            Name = @"Sample 1 From Channel N",
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
                            Name = @"Sample 2 From Channel 1",
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
                            Id = @"MA.5",
                            Type = @"DataTypeComponent",
                            Position = @"MA.5",
                            Name = @"Sample 2 From Channel N",
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
                            Id = @"MA.6",
                            Type = @"DataTypeComponent",
                            Position = @"MA.6",
                            Name = @"Sample N From Channel N",
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

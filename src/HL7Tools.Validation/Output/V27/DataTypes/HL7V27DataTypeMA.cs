using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeMA
    {
        public string Id { get { return @"MA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Multiplexed Array"; } }

        public string Description { get { return @"This data type is used to represent channel-multiplexed waveform data. Assuming that fields that utilize this data type repeat and that Y represents the specific repetition, the components of the repetition will reflect sample Y from each channel.

Usage Note: The MA data type is preferred when the signal recording device outputs the waveform data by time (all signal amplitudes at time sample 1, followed by all signal amplitudes at time sample 2, followed by all signal amplitudes at time sample 3, etc.). The typical count is 32, 64, or 128 channels. At the time of this writing, the MA data type is the one used by most commercial EEG instruments, while other electrophysiological instruments (such as evoked potential instruments) may use the NA data type. The MA data type is the ""natural"" one for multi-channel EEG instruments since the signal acquisition process involves digitizing each channel in succession as rapidly as possible, then after a fixed interval (like 0.004 seconds) digitizing all the channels again in succession, and repeating this every 0.004 seconds as long as the recording continues.

Use Case: Commercial EEG instruments

Example 1: 3 channels (identical), 6 time-samples
|0^0^0~1^1^1~2^2^2~3^3^3~4^4^4~5^5^5|

Example 2: 1 channel, 11 time-samples
|0~1~2~3~4~5~6~7~8~9~10|"; } }

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
                            Id = @"MA.1",
                            Type = @"DataTypeComponent",
                            Position = @"MA.1",
                            Name = @"Sample Y From Channel 1",
                            Length = 0,
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
                            Length = 0,
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
                            Length = 0,
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
                            Length = 0,
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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"CCP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Calibration Parameters"; } }

        public string Description { get { return @"This data type identifies the corrections to channel sensitivity, the baseline, and the channel time skew when transmitting waveform results.

Note: Replaces the CM data type used in 7.14.1.5 OBX-5.3 where OBX-5 Observation value (*) is data type CD as of v 2.5.

Attention: Retained for backward compatibility only in version 2.7.  This is used only in the CD Channel Definition data type, which has been retained for backward compatibility only in v2.7. "; } }

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
                            Id = @"CCP.1",
                            Type = @"DataTypeComponent",
                            Position = @"CCP.1",
                            Name = @"Channel Calibration Sensitivity Correction Factor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines a correction factor for channel sensitivity, which may be derived from the last calibration procedure performed. The actual channel sensitivity is the nominal channel sensitivity given in the previous component multiplied by the unitless correction factor.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CCP.2",
                            Type = @"DataTypeComponent",
                            Position = @"CCP.2",
                            Name = @"Channel Calibration Baseline",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines the actual channel baseline (the data value which corresponds to a nominal input signal of zero). The actual baseline may differ from the ideal because of a dc offset in the amplifier connected to the ADC. The actual baseline values for all channels (which need not be integers) may be determined at the time of calibration as the average digitized values obtained when a zero input signal is connected to each channel.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CCP.3",
                            Type = @"DataTypeComponent",
                            Position = @"CCP.3",
                            Name = @"Channel Calibration Time Skew",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines the time difference between the nominal sampling (digitization) time (which would be the same for all channels) and the actual sampling time of the channel, in seconds (or fractions thereof). This value will differ from zero when all channels in the montage are not sampled simultaneously, as occurs in systems, which sample successive channels at regular time intervals. This value may be determined from a calibration procedure in which an identical time-varying signal is applied to all channels and interchannel time differences are estimated, or more commonly it may be taken from the manufacturer’s specifications for the digitizing system used. For example, for a system which samples successive channels at regular time intervals t, the time skew of channel number n would be (n 1)t. The actual time of sampling (digitization) of sample number m of channel number n in such a system would be R + (m-1)/f + (n-1)t, where R is the reference time at the start of the epoch and f is the channel sampling frequency (t < 1/f).",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

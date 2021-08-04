using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataTypeCD
    {
        public string Id { get { return @"CD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Definition"; } }

        public string Description { get { return @"This data type is used for labeling of digital waveform data. It defines a recording channel, which is associated with one of the values in each time sample of waveform data. Each channel has a number (which generally defines its position in a multichannel display) and an optional name or label (also used in displays). One or two named waveform sources may also be associated with a channel (providing for the use of differential amplifiers with two inputs). The other components of the channel definition data type are optional. The individual components are defined as follows:"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 581; } }

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
                            Id = @"CD.1",
                            Type = @"DataTypeComponent",
                            Position = @"CD.1",
                            Name = @"Channel Identifier",
                            Length = 22,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"WVI",
                            DataTypeName = @"Channel Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the number and name of the recording channel where waveform data is transmitted. Waveform Source (WVS)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.2",
                            Type = @"DataTypeComponent",
                            Position = @"CD.2",
                            Name = @"Waveform Source",
                            Length = 17,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"WVS",
                            DataTypeName = @"Waveform Source",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines the channel sensitivity (gain) and the units in which it is measured.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.3",
                            Type = @"DataTypeComponent",
                            Position = @"CD.3",
                            Name = @"Channel Sensitivity/Units",
                            Length = 478,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CSU",
                            DataTypeName = @"Channel Sensitivity",
                            TableId = null,
                            TableName = null,
                            Description = @"This component identifies the corrections to channel sensitivity, the baseline, and the channel time skew.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.4",
                            Type = @"DataTypeComponent",
                            Position = @"CD.4",
                            Name = @"Channel Calibration Parameters",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CCP",
                            DataTypeName = @"Channel Calibration Parameters",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines the sampling frequency in hertz of the channel, that is, the reciprocal of the time in seconds between successive samples. Note that this is the frequency of transmitted data, which may or may not be the actual frequency at which the data was acquired by an analog-to-digital converter or other digital data source (i.e. the data transmitted may be subsampled, or interpolated, from the originally acquired data.)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.5",
                            Type = @"DataTypeComponent",
                            Position = @"CD.5",
                            Name = @"Channel Sampling Frequency",
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component defines the minimum and maximum data values which can occur in this channel in the digital waveform data, that is, the range of the ADC, and also specifies whether or not non-integral data values may occur in this channel in the waveform data. If the minimum and maximum values are both integers (or not present), only integral data values may be used in this channel. If either the minimum or the maximum value contains a decimal point, then non-integral as well as integral data values may be used in this channel. For an n-bit signed ADC, the nominal baseline B = 0, and the minimum (L) and maximum (H) values may be calculated as follows:",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.6",
                            Type = @"DataTypeComponent",
                            Position = @"CD.6",
                            Name = @"Minimum/Maximum Data Values",
                            Length = 33,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"CD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Definition"; } }

        public string Description { get { return @"This data type is used for labeling of digital waveform data.  It defines a recording channel which is associated with one of the values in each time sample of waveform data.  Each channel has a number (which generally defines its position in a multichannel display) and an optional name or label (also used in displays). One or two named waveform sources may also be associated with a channel (providing for the use of differential amplifiers with two inputs).  The other components of the channel definition data type are optional."; } }

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
                            Id = @"CD.1",
                            Type = @"DataTypeComponent",
                            Position = @"CD.1",
                            Name = @"Channel Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"WVI",
                            DataTypeName = @"Channel Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Two subcomponents separated by subcomponent delimiters (&) which identify the channel, consisting of a channel number (required, maximum 4 characters, data type NM)and a channel name (optional, maximum 17 characters, data type ST).  The channel name is a text string used as a label in waveform data displays. If this name is not present, the channel label displayed is <source1>-<source2>, where <source1> and <source2> are the names of the two waveform sources connected to this channel, or, if only one waveform sources <source1> is specified, the channel label displayed when the channel name is not given is <source1>.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.2",
                            Type = @"DataTypeComponent",
                            Position = @"CD.2",
                            Name = @"Waveform source",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"WVS",
                            DataTypeName = @"Wavefrom Source",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the source of the waveform connected to the channel.  Two names (each maximum of 8 characters, data type ST) separated by a subcomponent delimiter (&) may be specified if it is necessary to individually identify the two inputs for a waveform.  Only one name need be specified if the channel is connected to a single input. For example, in EKG recordings typically only one name is used (such as I or II); in electroencephalography, two names are typically used, one for each input of the differential amplifier (such as F3 and C3)..(NOTE:  Although the committee voted in Denver to make waveform source a coded entry, this is not syntactically possible.  We do not have a sub-sub-component delimiter available to separate the sub-fields of the proposed coded entry.  Therefore, waveform source remains a string data type.).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.3",
                            Type = @"DataTypeComponent",
                            Position = @"CD.3",
                            Name = @"Channel Sensitivity/units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CSU",
                            DataTypeName = @"Channel Sensitivity/units",
                            TableId = null,
                            TableName = null,
                            Description = @"This CM data type defines the channel sensitivity (gain) and the units in which it is measured.  This component consists of up to seven subcomponents, separated from each other by subcomponent delimiters (&). The first subcomponent specifies the sensitivity, while the remaining six subcomponents are used to specify the units of the sensitivity, using a format similar to the components of the coded entry (CE) data type. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.4",
                            Type = @"DataTypeComponent",
                            Position = @"CD.4",
                            Name = @"Calibration Parameters",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CCP",
                            DataTypeName = @"Channel Calibration Parameters",
                            TableId = null,
                            TableName = null,
                            Description = @"This component consists of three optional subcomponents (each a maximum of 20 characters, data type NM), separated from each other by subcomponent delimiters (&), which define corrections to channel sensitivity, baseline, and channel time skew which may be derived from a calibration procedure",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.5",
                            Type = @"DataTypeComponent",
                            Position = @"CD.5",
                            Name = @"Sampling Frequency",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the sampling frequency in hertz of the channel, that is, the reciprocal of the time in seconds between successive samples (maximum 20 characters, data type NM).  Note that this is the frequency of transmitted data, which may or may not be the actual frequency at which the data was acquired by an analog-to-digital converter or other digital data source (i.e. the data transmitted may be subsampled, or interpolated, from the originally acquired data.)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CD.6",
                            Type = @"DataTypeComponent",
                            Position = @"CD.6",
                            Name = @"Minimum/maximum Data Values",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = @"Defines the minimum and maximum data values which can occur in this channel in the digital waveform data, that is, the range of the ADC (each maximum of 20 characters, data type NM), and also specifies whether or not nonintegral data values may occur in this channel in the waveform data.  If the minimum and maximum values are both integers (or not present), only integral data values may be used in this channel.  If either the minimum or the maximum value contains a decimal point, then nonintegral as well as integral data values may be used in this channel.  The minimum and maximum data values are separated by a component delimiter (&). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

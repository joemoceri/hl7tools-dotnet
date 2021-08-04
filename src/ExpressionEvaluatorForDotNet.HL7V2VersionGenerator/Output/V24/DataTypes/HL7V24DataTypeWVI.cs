using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypeWVI
    {
        public string Id { get { return @"WVI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Identifier"; } }

        public string Description { get { return null; } }

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
                            Id = @"WVI.1",
                            Type = @"DataTypeComponent",
                            Position = @"WVI.1",
                            Name = @"Channel Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The channel number identifies the recording channel associated with a specified value in a time sample of data. It generally defines its position in a multichannel display",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"WVI.2",
                            Type = @"DataTypeComponent",
                            Position = @"WVI.2",
                            Name = @"Channel Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The channel name is a text string used as a label in waveform data displays.  If this name is not present, the channel label displayed is <source1>-<source2>, where <source1> and <source2> are the names of the two waveform sources connected to this channel, or, if only one waveform sources <source1> is specified, the channel label displayed when the channel name is not given is <source1>.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

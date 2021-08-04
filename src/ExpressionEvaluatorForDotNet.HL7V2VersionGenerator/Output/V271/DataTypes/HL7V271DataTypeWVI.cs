using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"WVI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Identifier"; } }

        public string Description { get { return @"This data type specifies the number and name of the recording channel where waveform data is transmitted.

Note: Replaces the CM data type used in 7.14.1.3.1 OBX-5.1 where OBX-5 Observation value (*) is data type CD as of v 2.5.

Attention: Retained for backward compatibility only in v 2.7.  This is used only in the CD Channel Definition data type, which has been retained for backward compatibility only in v2.7."; } }

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
                            Length = 0,
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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"WVS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Waveform Source"; } }

        public string Description { get { return @"This data type identifies the source of the waveform connected to a channel.

Note: Replaces the CM data type used in 7.14.1.4 OBX-5.2 where OBX-5 Observation value (*) is data type CD as of v 2.5.

Attention: Retained for backward compatibility only in v2.7.  It is used only in the CD Channel Definition data type, which has been retained for backward compatibility only in v2.7."; } }

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
                            Id = @"WVS.1",
                            Type = @"DataTypeComponent",
                            Position = @"WVS.1",
                            Name = @"Source One Name",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component identifies the first input for the waveform source.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"WVS.2",
                            Type = @"DataTypeComponent",
                            Position = @"WVS.2",
                            Name = @"Source Two Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component identifies the second input for the waveform source if a differential input is used.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"WVS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Waveform Source"; } }

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
                            Id = @"WVS.1",
                            Type = @"DataTypeComponent",
                            Position = @"WVS.1",
                            Name = @"Source Name 1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the first input for the waveform source",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"WVS.2",
                            Type = @"DataTypeComponent",
                            Position = @"WVS.2",
                            Name = @"Source Name 2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the second input for the waveform source",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

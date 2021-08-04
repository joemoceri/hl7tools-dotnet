using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"TS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time Stamp"; } }

        public string Description { get { return @"Contains the exact time of an event, including the date and time. The date portion of a time stamp follows the rules of a date field and the time portion follows the rules of a time field. The time zone (+/-ZZZZ) is represented as +/-HHMM offset from UCT (formerly Greenwich Mean Time (GMT)), where +0000 or -0000 both represent UCT (without offset). The specific data representations used in the HL7 encoding rules are compatible with ISO 8824-1987(E)."; } }

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
                            Id = @"TS.1",
                            Type = @"DataTypeComponent",
                            Position = @"TS.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
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

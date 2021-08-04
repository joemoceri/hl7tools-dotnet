using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"ELD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Error Location and Description"; } }

        public string Description { get { return @"Specifies the segment that contains an error and describes the nature of the error."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 493; } }

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
                            Id = @"ELD.1",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.1",
                            Name = @"Segment Id",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The segment containing the error in another message",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ELD.2",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.2",
                            Name = @"Segment Sequence",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the specific occurrence if the segment specified in component 1 occurs more than once in the message.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ELD.3",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.3",
                            Name = @"Field Position",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Ordinal position of the data field within the segment. For systems that do not use the HL7 Encoding Rules, the data item number may be used for the third component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ELD.4",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.4",
                            Name = @"Code Identifying Error",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0357",
                            TableName = @"Message error condition codes",
                            Description = @"A code that describes the nature of the error. Refer to HL7 Table 0357 - Message error condition codes for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

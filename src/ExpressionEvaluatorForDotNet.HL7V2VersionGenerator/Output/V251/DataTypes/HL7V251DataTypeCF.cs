using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"CF"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded Element with Formatted Values"; } }

        public string Description { get { return @"This data type transmits codes and the formatted text associated with the code. This data type can be used to transmit for the first time the formatted text for the canned text portion of a report, for example, a standard radiological description for a normal chest X-ray. The receiving system can store this information and in subsequent messages only the identifier need be sent. Another potential use of this data type is transmitting master file records that contain formatted text.

Example:  OBX||CF|71020^CXR^99CPMC||79989^\H\Description:\N\\.sp\\ti+4\Heart is not enlarged. There is no evidence of pneumonia, effusion, pneumothorax or any masses. \.sp+3\\H\Impression:\N\\.sp\\.ti+4\Negative chest.^99CPMC "; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 65536; } }

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
                            Id = @"CF.1",
                            Type = @"DataTypeComponent",
                            Position = @"CF.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.2",
                            Type = @"DataTypeComponent",
                            Position = @"CF.2",
                            Name = @"Formatted Text",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question with the addition of embedded formatting instructions.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.3",
                            Type = @"DataTypeComponent",
                            Position = @"CF.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Contains the name of the coding system employed.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.4",
                            Type = @"DataTypeComponent",
                            Position = @"CF.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Alternate sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. This identifier is the equivalent of component one.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.5",
                            Type = @"DataTypeComponent",
                            Position = @"CF.5",
                            Name = @"Alternate Formatted Text",
                            Length = 65536,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the alternate identifier in question with the addition of embedded formatting instructions.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.6",
                            Type = @"DataTypeComponent",
                            Position = @"CF.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Contains the name of the coding system employed for the alternate identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"VID"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Version Identifier"; } }

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
                            Id = @"VID.1",
                            Type = @"DataTypeComponent",
                            Position = @"VID.1",
                            Name = @"Version Id",
                            Length = 5,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 Table 0104 - Version ID in Chapter 2C for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VID.2",
                            Type = @"DataTypeComponent",
                            Position = @"VID.2",
                            Name = @"Internationalization Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0399",
                            TableName = @"Country Code",
                            Description = @"Used to identify the international affiliate country code. The values to be used are those of ISO 3166 -1:1977. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.
Refer to HL7 Table 0399 - Country Code in Chapter 2C for the 3-character codes as defined by ISO 3166 table.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VID.3",
                            Type = @"DataTypeComponent",
                            Position = @"VID.3",
                            Name = @"International Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field component identifies international affiliate’s version; it is especially important when the international affiliate has more than a single local version associated with a single US version.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"VID"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Version Identifier"; } }

        public string Description { get { return null; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 973; } }

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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0104",
                            TableName = @"Version ID",
                            Description = @"Used to identify the HL7 version. Refer to HL7 Table 0104 - Version ID in section 2.15.9.12 for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VID.2",
                            Type = @"DataTypeComponent",
                            Position = @"VID.2",
                            Name = @"Internationalization Code",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Used to identify the international affiliate country code. The values to be used are those of ISO 3166 -1:1977. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VID.3",
                            Type = @"DataTypeComponent",
                            Position = @"VID.3",
                            Name = @"International Version Id",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field component identifies international affiliates version; it is especially important when the international affiliate has more than a single local version associated with a single US version.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

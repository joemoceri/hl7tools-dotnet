using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeDLN
    {
        public string Id { get { return @"DLN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Driver License Number"; } }

        public string Description { get { return @"This field contains the drivers license information. For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 66; } }

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
                            Id = @"DLN.1",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.1",
                            Name = @"License Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the drivers license number.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLN.2",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.2",
                            Name = @"Issuing State, Province, Country",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0333",
                            TableName = @"Driver’s license issuing authority",
                            Description = @"Issuing authority for drivers license. For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code. User-defined Table 0333 - Drivers license issuing authority is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLN.3",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.3",
                            Name = @"Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Expiration date (DT) for drivers license.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

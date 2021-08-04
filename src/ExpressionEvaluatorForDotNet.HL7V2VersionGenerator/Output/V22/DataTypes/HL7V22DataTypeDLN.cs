using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeDLN
    {
        public string Id { get { return @"DLN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Driver's License Number"; } }

        public string Description { get { return @"This field contains the driver’s license information.  For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes"; } }

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
                            Id = @"DLN.1",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.1",
                            Name = @"Driver s License Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the driver’s license number",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLN.2",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.2",
                            Name = @"Issuing State, Province, Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Issuing authority for driver’s license.  For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes.  Refer to user-defined table 0333 - Driver’s license issuing authority",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLN.3",
                            Type = @"DataTypeComponent",
                            Position = @"DLN.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Expiration date (DT) for driver’s license",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypePLN
    {
        public string Id { get { return @"PLN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Practitioner License or Other ID Number"; } }

        public string Description { get { return @"This data type specifies a practitioners license number, or other ID number such as UPIN, Medicare and Medicaid number, and associated detail."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 101; } }

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
                            Id = @"PLN.1",
                            Type = @"DataTypeComponent",
                            Position = @"PLN.1",
                            Name = @"Id Number",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the license number or other ID number such as UPIN, Medicare and Medicaid number.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PLN.2",
                            Type = @"DataTypeComponent",
                            Position = @"PLN.2",
                            Name = @"Type Of Id Number",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0338",
                            TableName = @"Practitioner ID number type",
                            Description = @"Specifies the type of number.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PLN.3",
                            Type = @"DataTypeComponent",
                            Position = @"PLN.3",
                            Name = @"State/Other Qualifying Information",
                            Length = 62,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the state or province in which the license or ID is valid, if relevant, or other qualifying information. It is recommended that state qualifications use the abbreviations from the postal service of the country.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PLN.4",
                            Type = @"DataTypeComponent",
                            Position = @"PLN.4",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date when the license or ID is no longer valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

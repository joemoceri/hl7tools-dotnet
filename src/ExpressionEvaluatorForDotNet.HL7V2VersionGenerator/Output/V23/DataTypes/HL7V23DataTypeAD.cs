using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeAD
    {
        public string Id { get { return @"AD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Address"; } }

        public string Description { get { return @"Example: 
|10 ASH LN^#3^LIMA^OH^48132| "; } }

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
                            Id = @"AD.1",
                            Type = @"DataTypeComponent",
                            Position = @"AD.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Street address ",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.2",
                            Type = @"DataTypeComponent",
                            Position = @"AD.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.3",
                            Type = @"DataTypeComponent",
                            Position = @"AD.3",
                            Name = @"City",
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

                        new HL7V2FieldData
                        {
                            Id = @"AD.4",
                            Type = @"DataTypeComponent",
                            Position = @"AD.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"State or province should be represented by the official postal service codes for that country",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.5",
                            Type = @"DataTypeComponent",
                            Position = @"AD.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.6",
                            Type = @"DataTypeComponent",
                            Position = @"AD.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines  the country of the address.   ISO 3166 provides a list of country codes that may be used",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.7",
                            Type = @"DataTypeComponent",
                            Position = @"AD.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Type is optional and defined by HL7 table 0190 - Address type",
                            Sample = null,
                            FieldDatas = null
                        },

                        new HL7V2FieldData
                        {
                            Id = @"AD.8",
                            Type = @"DataTypeComponent",
                            Position = @"AD.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

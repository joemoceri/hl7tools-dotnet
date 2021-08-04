using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"XAD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Address"; } }

        public string Description { get { return @"Note: Replaces the AD data type as of v 2.3.

Example of usage for US:
|1234 Easy St.^Ste. 123^San Francisco^CA^95123^USA^B^^SF^| 

This would be formatted for postal purposes as : 1234 Easy St. Ste. 123 San Francisco CA 95123"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 250; } }

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
                            Id = @"XAD.1",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"See section 2.9.38, SAD - street address for description of components.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.2",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In US usage, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.3",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This may be the name of the city, or district or place depending upon the national convention for formatting addresses for postal usage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.4",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.5",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.6",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code . HL7 Table 0399 - Country code is defined to contain these 3-character codes.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.7",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 Table 0190 - Address type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.8",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.9",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides . User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.10",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides . User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.11",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.12",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.12",
                            Name = @"Address Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period in which this address was valid",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

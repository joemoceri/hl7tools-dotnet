using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"XAD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Address"; } }

        public string Description { get { return @"This data type specifies the address of a person, place or organization plus associated information."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 2915; } }

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
                            Length = 184,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"This component contains the house number, apartment number, street name, street direction, P.O. Box number, and similar address information.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.2",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.2",
                            Name = @"Other Designation",
                            Length = 120,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the second line of address. In US usage, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.3",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.3",
                            Name = @"City",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This component specifies the city, or district or place where the addressee is located depending upon the national convention for formatting addresses for postal usage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.4",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.4",
                            Name = @"State Or Province",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"This component specifies the state or province where the addressee is located. State or province should be represented by the official postal service codes for that country.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.5",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.5",
                            Name = @"Zip Or Postal Code",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"This component specifies the zip or postal code where the addressee is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.6",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.6",
                            Name = @"Country",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country Code",
                            Description = @"This component specifies the country where the addressee is located. HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399 - Country code in section 2.15.9.17, ""MSH-17 - Country code"" for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.7",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.7",
                            Name = @"Address Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.8",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.8",
                            Name = @"Other Geographic Designation",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any other geographic designation. It includes county, bioregion, SMSA, etc.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.9",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.9",
                            Name = @"County/Parish Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.10",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.10",
                            Name = @"Census Tract",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.11",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.11",
                            Name = @"Address Representation Code",
                            Length = 1,
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
                            Length = 49,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component cannot be fully expressed. Identified as v 2.4 erratum. Retained for backward compatibility only as of v 2.5. Refer to 2.A.85.13, Effective Date and 2.A.85.14, Expiration Date components.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.13",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.13",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the address is valid and active for the ‘owning’ entity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.14",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.14",
                            Name = @"Expiration Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the address is valid and active for the ‘owning’ entity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.15",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.15",
                            Name = @"Expiration Reason",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0616",
                            TableName = @"Address Expiration Reason",
                            Description = @"This identifies why this address was marked as ""ended"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.16",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.16",
                            Name = @"Temporary Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"If ""Y"" this indicates that the address is considered temporary. Refer to HL7 Table 0136 - Yes/No Indicator .",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.17",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.17",
                            Name = @"Bad Address Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"If ""Y"", this indicates that it is not possible to contact the ""owning"" entity at this address. Refer to HL7 Table 0136 - Yes/No Indicator.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.18",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.18",
                            Name = @"Address Usage",
                            Length = 44,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0617",
                            TableName = @"Address Usage",
                            Description = @"This indicates how the address is intended to be used.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.19",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.19",
                            Name = @"Addressee",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the name of the person or organization that should appear as part of the address. This is also known as the ""Care of"" or ""C/O"" line.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.20",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.20",
                            Name = @"Comment",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Descriptive information about the use of the address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.21",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.21",
                            Name = @"Preference Order",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"For an entity having multiple addresses, indicates which is the 'most preferred' (lowest number) to 'least preferred' (highest number).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.22",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.22",
                            Name = @"Protection Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0618",
                            TableName = @"Protection Code",
                            Description = @"Identifies that an address needs to be treated with special care or sensitivity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XAD.23",
                            Type = @"DataTypeComponent",
                            Position = @"XAD.23",
                            Name = @"Address Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"A unique identifier for the address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeLA2
    {
        public string Id { get { return @"LA2"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Location With Address Variation 2"; } }

        public string Description { get { return @"Specifies a location and its address. 

Note: Replaces the CM data type used in 4.14.5.13 RXD-13, 4.14.6.11 RXG-11 and 4.14.7.11 RXA-11 as of v 2.5. Retained for backward compatibility only as of v 2.5,

Attention: Retained for backward compatibility only in v2.6. Fields associated with this data type have been replaced by 2 new fields in the RXD, RXG and RXA segments."; } }

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
                            Id = @"LA2.1",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.1",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0302",
                            TableName = @"Point of Care",
                            Description = @"This component specifies the code for the point where patient care is administered. It is conditional on Patient Location Type (e.g., nursing unit or department or clinic). After floor, it is the most general patient location designation. Refer to User-defined Table 0302 - Point of Care for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.2",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.2",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = @"This component specifies the code for the patient room. After point of care, it is the most general person location designation. Refer to User-defined Table 0303 - Room for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.3",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.3",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = @"This component specifies the code for the patient's bed. After room, it is the most general person location designation. Refer to User-defined Table 0304 - Bed for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.4",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.4",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is subject to site interpretation but generally describes the highest level physical designation of an institution, medical center or enterprise. It is the most general person location designation.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.5",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.5",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0306",
                            TableName = @"Location Status",
                            Description = @"This component specifies the code for the status or availability of the location. For example, it may convey bed status. Refer to User-defined Table 0306 - Location Status for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.6",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.6",
                            Name = @"Patient Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0305",
                            TableName = @"Person Location Type",
                            Description = @"Patient location type is the categorization of the patient’s location defined by facility, building, floor, point of care, room or bed. Although not a required field, when used, it may be the only populated field. It usually includes values such as nursing unit, department, clinic, SNF, physician’s office. Refer to User-defined Table 0305 – Person Location Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.7",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.7",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = @"This component specifies the code for the building where the person is located. After facility, it is the most general person location designation. Refer to User-defined Table 0307 - Building for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.8",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = @"This component specifies the code for the floor where the person is located. After building, it is the most general person location designation. Refer to User-defined Table 0308 - Floor for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.9",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.9",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the street or mailing address of a person or institution. When referencing an institution, it is used to specify the institution name. When used in connection with a person, it specifies the first line of the address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.10",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.10",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the second line of an address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.11",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.11",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the city, or district or place where the person or institution is located depending upon the national convention for formatting addresses for postal usage. City should be represented by the official postal service codes for that state.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.12",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.12",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the state or province where the person or institution is located. State or province should be represented by the official postal service codes for that country.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.13",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.13",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the zip or postal code where the person or institution is located. Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9 and the Australian Postcode takes the form 9999.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.14",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.14",
                            Name = @"Country",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0399",
                            TableName = @"Country Code",
                            Description = @"This component specifies the country where the person or institution is located. ISO 3166 provides a list of country codes that may be used.   HL7 specifies that the 3-character (alphabetic) form of ISO 3166 be used for the country code. Refer to HL7 Table 0399 – Country Code in section 2.C.2.313 ISO-3166.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.15",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.15",
                            Name = @"Address Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0190",
                            TableName = @"Address Type",
                            Description = @"This component specifies the kind or type of address. Refer to HL7 Table 0190 - Address Type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"LA2.16",
                            Type = @"DataTypeComponent",
                            Position = @"LA2.16",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies any other geographic designation that may be necessary. It includes county, bioregion, SMSA, etc.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

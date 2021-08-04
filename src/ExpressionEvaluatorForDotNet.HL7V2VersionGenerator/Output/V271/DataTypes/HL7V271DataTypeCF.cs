using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"CF"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded Element With Formatted Values"; } }

        public string Description { get { return @"This data type transmits codes and the formatted text associated with the code. This data type can be used to transmit for the first time the formatted text for the canned text portion of a report, for example, a standard radiological description for a normal chest X ray. The receiving system can store this information and in subsequent messages only the identifier need be sent. Another potential use of this data type is transmitting master file records that contain formatted text. This data type has six components as follows:
The components, primary and alternate, are defined exactly as in the CE data type with the exception of the second and fifth components, which are of the formatted text data type.

Example: 
OBX||CF|71020^CXR^99CPMC||79989^\H\Description:\N\\.sp\\ti+4\Heart is not enlarged. There is no evidence of pneumonia, effusion, pneumothorax or any masses. \.sp+3\\H\Impression:\N\\.sp\\.ti+4\Negative chest.^99CPMC

As of v2.7 a third tuple, formerly known as triplet, has been added  to the CF data type. Additionally, 3 new components were added to each tuple such that each tuple now has a total of 7 components. The Original Text component applies to the CF as a whole."; } }

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
                            Id = @"CF.1",
                            Type = @"DataTypeComponent",
                            Position = @"CF.1",
                            Name = @"Identifier",
                            Length = 0,
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
                            Length = 0,
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
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Contains the name of the coding system employed. 

Refer to HL7 Table 0396 - Coding System in Chapter 2, ""Control"", section 2.16.4, ""Coding System Table"" for valid values.

As of v2.7 this component is required when CF.1 is populated and CF.14 is not populated. Both CF.3 and CF.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding system as specified in CF.3 and/or CF.14, the Coding System component or the Coding System OID, for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.4",
                            Type = @"DataTypeComponent",
                            Position = @"CF.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CF-1 Identifier.

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.5",
                            Type = @"DataTypeComponent",
                            Position = @"CF.5",
                            Name = @"Alternate Formatted Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the alternate identifier in question with the addition of embedded formatting instructions. Analogous to CF.2 Formatted Text.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.6",
                            Type = @"DataTypeComponent",
                            Position = @"CF.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Contains the name of the coding system employed for the alternate identifier. Analogous to CF.3 Name of Coding System.

Refer to HL7 Table 0396 - Coding System in Chapter 2C, ""Code Tables"", for valid values.

As of v2.7 this component is required when CF.4 is populated and CF.17 is not populated. Both CF.6 and CF.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding ystem as specified in CF.6 and/or CF.17, the Coding System component or the Coding System OID, for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.7",
                            Type = @"DataTypeComponent",
                            Position = @"CF.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CF.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CF.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent.  If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.8",
                            Type = @"DataTypeComponent",
                            Position = @"CF.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6. Analogous To CF.7 Coding System Version ID. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.9",
                            Type = @"DataTypeComponent",
                            Position = @"CF.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.10",
                            Type = @"DataTypeComponent",
                            Position = @"CF.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CF.1 Identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.11",
                            Type = @"DataTypeComponent",
                            Position = @"CF.11",
                            Name = @"Second Alternate Formatted Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FT",
                            DataTypeName = @"Formatted Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the Second Alternate Identifier. Analogous to CF.2 Formatted Text.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.12",
                            Type = @"DataTypeComponent",
                            Position = @"CF.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CF. Name of Coding System.

This component is required when CF.10 is populated and CF.20 is not populated. Both CF.10 and CF.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding ystem as specified in CF.12 and/or CF.20 the Coding System component or the Coding System OID for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.13",
                            Type = @"DataTypeComponent",
                            Position = @"CF.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous To CF.7 Coding System Version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.14",
                            Type = @"DataTypeComponent",
                            Position = @"CF.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CF.1 is populated and CF.3 is not populated. Both CF.3 and CF.14 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.15",
                            Type = @"DataTypeComponent",
                            Position = @"CF.15",
                            Name = @"Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.16",
                            Type = @"DataTypeComponent",
                            Position = @"CF.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CF.15. The version is a date. The date is the date/time that the value set being used was published.
Value set version ID is required if CF.15 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.17",
                            Type = @"DataTypeComponent",
                            Position = @"CF.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CF.6. Analogous To CF.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CF.4 is populated and CF.6 is not populated. Both CF.6 and CF.17 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.18",
                            Type = @"DataTypeComponent",
                            Position = @"CF.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CF.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.19",
                            Type = @"DataTypeComponent",
                            Position = @"CF.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CF.18. The version is a date. The date is the date/time that the value set being used was published.
Value set version ID is required if CF.18 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.20",
                            Type = @"DataTypeComponent",
                            Position = @"CF.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CF.12. Analogous To CF.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CF.10 is populated and CF.12 is not populated. Both CF.12 and CF.20 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.21",
                            Type = @"DataTypeComponent",
                            Position = @"CF.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CF.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CF.22",
                            Type = @"DataTypeComponent",
                            Position = @"CF.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CF.21. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CF.21 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

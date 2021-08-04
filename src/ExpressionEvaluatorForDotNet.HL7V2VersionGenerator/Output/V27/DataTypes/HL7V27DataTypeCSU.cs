using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"CSU"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Channel Sensitivity And Units"; } }

        public string Description { get { return @"This data type defines the channel sensitivity (gain) and the units in which it is measured in a waveform result.

Note: Replaces the CM data type used in 7.14.1.5 OBX-5.3 where OBX-5 Observation value (*) is data type CD as of v 2.5.

Attention: Retained for backward compatibility only in version 2.7.  This is used only in the CD Channel Definition data type, which has been retained for backward compatibility only in version 2.7.

As of v2.7 a third tuple, formerly known as triplet, has been added  to the CSU data type. Additionally, 3 new components were added to each tuple such that each tuple now has a total of 7 components. The Original Text component applies to the CSU as a whole."; } }

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
                            Id = @"CSU.1",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.1",
                            Name = @"Channel Sensitivity",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component transmits the nominal value that corresponds to one unit in the waveform data, that is, the effective resolution of the least significant bit of the ADC, and the polarity of the channel.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.2",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.2",
                            Name = @"Unit Of Measure Identifier",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The unit designation for the channel sensitivity. This field is required if the unit of measure description is not present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.3",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.3",
                            Name = @"Unit Of Measure Description",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The full text name of the unit of measure identifier. This field is required if the unit of measure identifier is not present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.4",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.4",
                            Name = @"Unit Of Measure Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Specifies the designated system of units. Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. This component is required if the CSU.2 Unit of Measure Identifier is present.

Both CSU.4 and CSU.15 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CSU.4 and/or CSU.15, the ""Coding System"" component or the ""Coding System OID"" for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.5",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.5",
                            Name = @"Alternate Unit Of Measure Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate units designation for the channel sensitivity. Analogous to CSU.2 Unit of Measure Identifier.

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.6",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.6",
                            Name = @"Alternate Unit Of Measure Description",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The full text name of the alternate unit of measure identifier. Analogous to CSU.3 Unit of Measure Description. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.7",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.7",
                            Name = @"Alternate Unit Of Measure Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Specifies the coding system for the alternate unit of measure. Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. Analogous to CSU.4 Unit of Measure Coding System. 

This field is required if the CSU.5 Alternate Unit of Measure Identifier is present. Both CSU.7 and CSU.18 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CSU.7 and/or CSU.18, the ""Coding System"" component or the ""Coding System OID"" for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.8",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.8",
                            Name = @"Unit Of Measure Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 2-4. If CSU.4 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CSU.4 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.9",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.9",
                            Name = @"Alternate Unit Of Measure Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 5-7. Analogous to CSU.8 Unit of Measure Coding System Version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.10",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.10",
                            Name = @"Original Text",
                            Length = 199,
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
                            Id = @"CSU.11",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.11",
                            Name = @"Second Alternate Unit Of Measure Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a  second alternate units designation for the channel sensitivity.  Analogous to CSU.2 Unit of Measure Identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.12",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.12",
                            Name = @"Second Alternate Unit Of Measure Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the second alternate identifier. Analogous to CSU.3 Unit of Measure Description.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.13",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.13",
                            Name = @"Name Of Second Alternate Unit Of Measure Coding Sy",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Specifies the coding system for the second alternate unit of measure.  Analogous to CSU.4 Unit of Measure Coding System.  Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values.

This component is required when CSU.11 is populated. Both CSU.13 and CSU.21 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CSU.13 and/or CSU.21 the Coding System component or the Coding System OID for the tuple.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.14",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.14",
                            Name = @"Second Alternate Unit Of Measure Coding System Ver",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 11-13. Analogous to CSU.8 Unit of Measure Coding System Version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.15",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.15",
                            Name = @"Unit Of Measure Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CSU.4. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CSU.2 is populated and CSU.4 is not populated. Both CSU.4 and CSU.15 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.16",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.16",
                            Name = @"Unit Of Measure Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CSU.2 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.17",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.17",
                            Name = @"Unit Of Measure Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CSU.16.  The version is a date. The date is the date/time that the value set being used was published.
Value set version ID is required if CSU.16 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.18",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.18",
                            Name = @"Alternate Unit Of Measure Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CSU.7. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CSU.5 is populated and CSU.7 is not populated. Both CSU.7 and CSU.18 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.19",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.19",
                            Name = @"Alternate Unit Of Measure Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CSU.5 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.20",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.20",
                            Name = @"Alternate Unit Of Measure Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CSU.19.  The version is a date. The date is the date/time that the value set being used was published.
Value set version ID is required if CSU.19 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.21",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.21",
                            Name = @"Alternate Unit Of Measure Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CSU.13. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CSU.11 is populated and CSU.13 is not populated. Both CSU.13 and CSU.21 may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.22",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.22",
                            Name = @"Alternate Unit Of Measure Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CSU.11 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CSU.23",
                            Type = @"DataTypeComponent",
                            Position = @"CSU.23",
                            Name = @"Alternate Unit Of Measure Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CSU.22. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CSU.22 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

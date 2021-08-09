using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27SegmentVND
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"VND"; } }

        public string SegmentId { get { return @"VND"; } }
        
        public string LongName { get { return @"Purchasing Vendor"; } }
        
        public string Description { get { return @"This segment contains purchasing vendors that supply the inventory supply item specified in the ITM segment.   "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

                    };
            }
        }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"VND.1",
                            Type = @"Field",
                            Position = @"VND.1",
                            Name = @"Set Id - Vnd",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence Id",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a sequential number that identifies this segment within a given PURCHASING_VENDOR segment group. For the first occurrence of the segment in a given group, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.2",
                            Type = @"Field",
                            Position = @"VND.2",
                            Name = @"Vendor Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifier of the vendor in the system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VND.2.1",
                            Type = @"Component",
                            Position = @"VND.2.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.2.2",
                            Type = @"Component",
                            Position = @"VND.2.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.2.3",
                            Type = @"Component",
                            Position = @"VND.2.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.2.4",
                            Type = @"Component",
                            Position = @"VND.2.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.3",
                            Type = @"Field",
                            Position = @"VND.3",
                            Name = @"Vendor Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name of the vendor identified in VND-2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.4",
                            Type = @"Field",
                            Position = @"VND.4",
                            Name = @"Vendor Catalog Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"field contains the catalog number assigned to the item by a purchasing vendor.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VND.4.1",
                            Type = @"Component",
                            Position = @"VND.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.4.2",
                            Type = @"Component",
                            Position = @"VND.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The component intentionally remains associated with the IS data type in v2.7.

The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 – Assigning Authority for suggested values.

Note: When the HD is used as a part of another data type, in this case as part of the EI data type, this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment. 

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.4.3",
                            Type = @"Component",
                            Position = @"VND.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.4.4",
                            Type = @"Component",
                            Position = @"VND.4.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.

Refer to HL7 Table 0301 - Universal ID Type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5",
                            Type = @"Field",
                            Position = @"VND.5",
                            Name = @"Primary Vendor Indicator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded With No Exceptions",
                            TableId = @"0532",
                            TableName = @"Expanded Yes/no Indicator",
                            Description = @"This field contains an indicator to communicate whether this purchasing vendor is the primary vendor used to place orders for inventory supply item.  Refer to HL7 Table 0532 - Expanded Yes/no Indicator in Chapter 2C, Code Tables, for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"VND.5.1",
                            Type = @"Component",
                            Position = @"VND.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.

Usage Note: The identifier is required and must be a valid code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.2",
                            Type = @"Component",
                            Position = @"VND.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.

Usage Note: Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.3",
                            Type = @"Component",
                            Position = @"VND.5.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, section ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.

 As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.

Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.

Usage Note: The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states ""Refer to HL7 Table nnnn for valid values”, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.4",
                            Type = @"Component",
                            Position = @"VND.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CNE.1 Identifier. 

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.5",
                            Type = @"Component",
                            Position = @"VND.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CNE.2 Text. 

Usage Notes: If present, CNE.5 obeys the same rules of use and interpretation as described for CNE.2. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.6",
                            Type = @"Component",
                            Position = @"VND.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, section ""Coding System Table"", for valid values.

As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.

Usage Notes: If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.7",
                            Type = @"Component",
                            Position = @"VND.5.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.8",
                            Type = @"Component",
                            Position = @"VND.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.

Usage Notes: If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.9",
                            Type = @"Component",
                            Position = @"VND.5.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.10",
                            Type = @"Component",
                            Position = @"VND.5.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a second alternate code. Analogous to CN-1 Identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.11",
                            Type = @"Component",
                            Position = @"VND.5.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the Second Alternate Identifier. Analogous to CNE.2 Text.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.12",
                            Type = @"Component",
                            Position = @"VND.5.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, section ""Coding System Table"", for valid values.

As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.13",
                            Type = @"Component",
                            Position = @"VND.5.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous to CNE.7 Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.14",
                            Type = @"Component",
                            Position = @"VND.5.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used.

This component is required when CNE.1 is populated and CNE.3 is not populated. Both CNE.3 and CNE.14 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.15",
                            Type = @"Component",
                            Position = @"VND.5.15",
                            Name = @"Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.16",
                            Type = @"Component",
                            Position = @"VND.5.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CNE.15. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CNE.15 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.17",
                            Type = @"Component",
                            Position = @"VND.5.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CNE.6. Analogous to CNE.14 OID for Coding System. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CNE.4 is populated and CNE.6 is not populated. Both CNE.6 and CNE.17 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.18",
                            Type = @"Component",
                            Position = @"VND.5.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.19",
                            Type = @"Component",
                            Position = @"VND.5.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CNE.18. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CNE.18 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.20",
                            Type = @"Component",
                            Position = @"VND.5.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) from which the value in CNE.12 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined numbers, the OID registered in the HL7 OID registry should be used. 

This component is required when CNE.4 is populated and neither CNE.6 nor CNE.18 is populated. In short either the CNE.6 or the CNE.14 or CNE.17 must be populated when CNE.4 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.21",
                            Type = @"Component",
                            Position = @"VND.5.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CNE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VND.5.22",
                            Type = @"Component",
                            Position = @"VND.5.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CNE.21. The version is a date. The date is the date/time that the value set being used was published.
Value set version ID is required if CNE.21 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        };
            }
        }

        public HL7V27SegmentVND(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V27Field setIdVnd;

public HL7V27Field SetIdVnd
{
    get
    {
        if (setIdVnd != null)
        {
            return setIdVnd;
        }

        setIdVnd = new HL7V27Field
        {
            field = message[@"VND"][1],
            Id = @"VND.1",
            Type = @"Field",
            Position = @"VND.1",
            Name = @"Set Id - Vnd",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence Id",
            TableId = null,
            TableName = null,
            Description = @"This field contains a sequential number that identifies this segment within a given PURCHASING_VENDOR segment group. For the first occurrence of the segment in a given group, the sequence number shall be one; for the second occurrence, the sequence number shall be two; etc. ",
            Sample = @"",
        };

        // check for repetitions
        if (setIdVnd.field.FieldRepetitions != null && setIdVnd.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIdVnd.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < setIdVnd.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = setIdVnd.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < setIdVnd.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = setIdVnd.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < setIdVnd.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = setIdVnd.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            setIdVnd.fieldRepetitions = fieldRepetitions;
        }

        return setIdVnd;
    } 
}

internal HL7V27Field vendorIdentifier;

public HL7V27Field VendorIdentifier
{
    get
    {
        if (vendorIdentifier != null)
        {
            return vendorIdentifier;
        }

        vendorIdentifier = new HL7V27Field
        {
            field = message[@"VND"][2],
            Id = @"VND.2",
            Type = @"Field",
            Position = @"VND.2",
            Name = @"Vendor Identifier",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier of the vendor in the system.",
            Sample = @"",
        };

        // check for repetitions
        if (vendorIdentifier.field.FieldRepetitions != null && vendorIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vendorIdentifier.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < vendorIdentifier.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = vendorIdentifier.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < vendorIdentifier.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = vendorIdentifier.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < vendorIdentifier.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = vendorIdentifier.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            vendorIdentifier.fieldRepetitions = fieldRepetitions;
        }

        return vendorIdentifier;
    } 
}

internal HL7V27Field vendorName;

public HL7V27Field VendorName
{
    get
    {
        if (vendorName != null)
        {
            return vendorName;
        }

        vendorName = new HL7V27Field
        {
            field = message[@"VND"][3],
            Id = @"VND.3",
            Type = @"Field",
            Position = @"VND.3",
            Name = @"Vendor Name",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the vendor identified in VND-2.",
            Sample = @"",
        };

        // check for repetitions
        if (vendorName.field.FieldRepetitions != null && vendorName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vendorName.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < vendorName.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = vendorName.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < vendorName.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = vendorName.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < vendorName.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = vendorName.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            vendorName.fieldRepetitions = fieldRepetitions;
        }

        return vendorName;
    } 
}

internal HL7V27Field vendorCatalogNumber;

public HL7V27Field VendorCatalogNumber
{
    get
    {
        if (vendorCatalogNumber != null)
        {
            return vendorCatalogNumber;
        }

        vendorCatalogNumber = new HL7V27Field
        {
            field = message[@"VND"][4],
            Id = @"VND.4",
            Type = @"Field",
            Position = @"VND.4",
            Name = @"Vendor Catalog Number",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"field contains the catalog number assigned to the item by a purchasing vendor.",
            Sample = @"",
        };

        // check for repetitions
        if (vendorCatalogNumber.field.FieldRepetitions != null && vendorCatalogNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(vendorCatalogNumber.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < vendorCatalogNumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = vendorCatalogNumber.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < vendorCatalogNumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = vendorCatalogNumber.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < vendorCatalogNumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = vendorCatalogNumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            vendorCatalogNumber.fieldRepetitions = fieldRepetitions;
        }

        return vendorCatalogNumber;
    } 
}

internal HL7V27Field primaryVendorIndicator;

public HL7V27Field PrimaryVendorIndicator
{
    get
    {
        if (primaryVendorIndicator != null)
        {
            return primaryVendorIndicator;
        }

        primaryVendorIndicator = new HL7V27Field
        {
            field = message[@"VND"][5],
            Id = @"VND.5",
            Type = @"Field",
            Position = @"VND.5",
            Name = @"Primary Vendor Indicator",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded With No Exceptions",
            TableId = @"0532",
            TableName = @"Expanded Yes/no Indicator",
            Description = @"This field contains an indicator to communicate whether this purchasing vendor is the primary vendor used to place orders for inventory supply item.  Refer to HL7 Table 0532 - Expanded Yes/no Indicator in Chapter 2C, Code Tables, for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryVendorIndicator.field.FieldRepetitions != null && primaryVendorIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryVendorIndicator.Id));
            var fieldRepetitions = new List<HL7V27FieldRepetition>();

            for (var i = 0; i < primaryVendorIndicator.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V27FieldRepetition
                {
                    fieldRepetition = primaryVendorIndicator.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V27Component>();

                    // there should be components per repetition
                    for (var j = 0; j < primaryVendorIndicator.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V27Component
                        {
                            component = primaryVendorIndicator.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V27SubComponent>();

                            for (var k = 0; k < primaryVendorIndicator.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V27SubComponent
                                {
                                    subComponent = primaryVendorIndicator.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            primaryVendorIndicator.fieldRepetitions = fieldRepetitions;
        }

        return primaryVendorIndicator;
    } 
}
    }
}

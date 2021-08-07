using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentDMI
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"DMI"; } }

        public string SegmentId { get { return @"DMI"; } }
        
        public string LongName { get { return @"Drg Master File Information"; } }
        
        public string Description { get { return @"The DMI segment contains the DRG related basic information, for example, relative weight, etc.  The DMI segment is used to send the fixed information assigned to a specific DRG."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Id = @"DMI.1",
                            Type = @"Field",
                            Position = @"DMI.1",
                            Name = @"Diagnostic Related Group",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded With No Exceptions",
                            TableId = @"0055",
                            TableName = @"Diagnosis Related Group",
                            Description = @"This field contains the DRG for the transaction.  Interim DRG's could be determined for an encounter.  Refer to External Table 0055 – Diagnosis Related Group in Chapter 2C, Code Tables, for suggested values.  ",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.1",
                            Type = @"Component",
                            Position = @"DMI.1.1",
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
                            Id = @"DMI.1.2",
                            Type = @"Component",
                            Position = @"DMI.1.2",
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
                            Id = @"DMI.1.3",
                            Type = @"Component",
                            Position = @"DMI.1.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.

As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.

Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.

Usage Note: The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states ""Refer to HL7 Table nnnn for valid values”, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.4",
                            Type = @"Component",
                            Position = @"DMI.1.4",
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
                            Id = @"DMI.1.5",
                            Type = @"Component",
                            Position = @"DMI.1.5",
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
                            Id = @"DMI.1.6",
                            Type = @"Component",
                            Position = @"DMI.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.

As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.

Usage Notes: If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.7",
                            Type = @"Component",
                            Position = @"DMI.1.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.8",
                            Type = @"Component",
                            Position = @"DMI.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.

Usage Notes: If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.9",
                            Type = @"Component",
                            Position = @"DMI.1.9",
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
                            Id = @"DMI.1.10",
                            Type = @"Component",
                            Position = @"DMI.1.10",
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
                            Id = @"DMI.1.11",
                            Type = @"Component",
                            Position = @"DMI.1.11",
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
                            Id = @"DMI.1.12",
                            Type = @"Component",
                            Position = @"DMI.1.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.

As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.13",
                            Type = @"Component",
                            Position = @"DMI.1.13",
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
                            Id = @"DMI.1.14",
                            Type = @"Component",
                            Position = @"DMI.1.14",
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
                            Id = @"DMI.1.15",
                            Type = @"Component",
                            Position = @"DMI.1.15",
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
                            Id = @"DMI.1.16",
                            Type = @"Component",
                            Position = @"DMI.1.16",
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
                            Id = @"DMI.1.17",
                            Type = @"Component",
                            Position = @"DMI.1.17",
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
                            Id = @"DMI.1.18",
                            Type = @"Component",
                            Position = @"DMI.1.18",
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
                            Id = @"DMI.1.19",
                            Type = @"Component",
                            Position = @"DMI.1.19",
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
                            Id = @"DMI.1.20",
                            Type = @"Component",
                            Position = @"DMI.1.20",
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
                            Id = @"DMI.1.21",
                            Type = @"Component",
                            Position = @"DMI.1.21",
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
                            Id = @"DMI.1.22",
                            Type = @"Component",
                            Position = @"DMI.1.22",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2",
                            Type = @"Field",
                            Position = @"DMI.2",
                            Name = @"Major Diagnostic Category",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded With No Exceptions",
                            TableId = @"0118",
                            TableName = @"Major Diagnostic Category",
                            Description = @"This field indicates the determined Major Diagnostic Category (MDC) value. Refer to External Table 0118 – Major Diagnostic Category in Chapter 2C, Code Tables, for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.1",
                            Type = @"Component",
                            Position = @"DMI.2.1",
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
                            Id = @"DMI.2.2",
                            Type = @"Component",
                            Position = @"DMI.2.2",
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
                            Id = @"DMI.2.3",
                            Type = @"Component",
                            Position = @"DMI.2.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained. Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values. Each coding system is assigned a unique identifier.

As of v2.7 this component is required when CNE.1 is populated and CNE.14 is not populated. Both CNE.3 and CNE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.3 and/or CNE.14 the Coding System component or the Coding System OID for the tuple.The combination of the identifier and name of coding system represent a unique concept for a data item.

Some organizations that publish code sets author more than one. The coding system, then, to be unique, is a concatenation of the name of the coding authority organization and the name of its code set or table. When an HL7 table is used for a CNE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. Similarly, ISO tables will be named ISOnnnn, where nnnn is the ISO table number.

Usage Note: The following statement is retained for backward compatibility as of v2.7. Best practice would recommend that this component always be populated. However, if the field narrative explicitly states ""Refer to HL7 Table nnnn for valid values”, and, if the sending and receiving systems are HL7 compliant, the coding system would be known from the standard.  This would be similar to a field with an ID data type, except that there is a second triplet in which to express an alternate code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.4",
                            Type = @"Component",
                            Position = @"DMI.2.4",
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
                            Id = @"DMI.2.5",
                            Type = @"Component",
                            Position = @"DMI.2.5",
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
                            Id = @"DMI.2.6",
                            Type = @"Component",
                            Position = @"DMI.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.  Analogous to  CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.

As of v2.7 this component is required when CNE.4 is populated and CNE.17 is not populated. Both CNE.6 and CNE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.6 and/or CNE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.

Usage Notes: If present, CNE.6 obeys the same rules of use and interpretation as described for CNE.3.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.7",
                            Type = @"Component",
                            Position = @"DMI.2.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The version ID for the coding system identified by CNE.3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.8",
                            Type = @"Component",
                            Position = @"DMI.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The version ID for the coding system identified by CNE.6.  It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility. Analogous to CNE.7 Coding System Version ID.

Usage Notes: If present, CNE.8 obeys the same rules of use and interpretation as described for CNE.7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.9",
                            Type = @"Component",
                            Position = @"DMI.2.9",
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
                            Id = @"DMI.2.10",
                            Type = @"Component",
                            Position = @"DMI.2.10",
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
                            Id = @"DMI.2.11",
                            Type = @"Component",
                            Position = @"DMI.2.11",
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
                            Id = @"DMI.2.12",
                            Type = @"Component",
                            Position = @"DMI.2.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the Second Alternate Identifier component. Analogous to CNE.3 Name of Coding System.  Refer to HL7 Table 0396 - Coding Systems in Chapter 2C, Code Tables, for valid values.

As of v2.7 this component is required when CNE.10 is populated and CNE.20 is not populated. Both CNE.12 and CNE.20 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CNE.12 and/or CNE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.13",
                            Type = @"Component",
                            Position = @"DMI.2.13",
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
                            Id = @"DMI.2.14",
                            Type = @"Component",
                            Position = @"DMI.2.14",
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
                            Id = @"DMI.2.15",
                            Type = @"Component",
                            Position = @"DMI.2.15",
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
                            Id = @"DMI.2.16",
                            Type = @"Component",
                            Position = @"DMI.2.16",
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
                            Id = @"DMI.2.17",
                            Type = @"Component",
                            Position = @"DMI.2.17",
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
                            Id = @"DMI.2.18",
                            Type = @"Component",
                            Position = @"DMI.2.18",
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
                            Id = @"DMI.2.19",
                            Type = @"Component",
                            Position = @"DMI.2.19",
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
                            Id = @"DMI.2.20",
                            Type = @"Component",
                            Position = @"DMI.2.20",
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
                            Id = @"DMI.2.21",
                            Type = @"Component",
                            Position = @"DMI.2.21",
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
                            Id = @"DMI.2.22",
                            Type = @"Component",
                            Position = @"DMI.2.22",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.3",
                            Type = @"Field",
                            Position = @"DMI.3",
                            Name = @"Lower And Upper Trim Points",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Numeric Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the lower and upper trim points as calculated for this DRG.. 
Example as used in Germany: The ""lower trim point"" is equivalent to 1/3 of the average length of stay for patients having this DRG.  The ""upper trim point"" is equivalent to 3 times the average length of stay.  It is marked as the right dotted line within the graphics below.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"DMI.3.1",
                            Type = @"Component",
                            Position = @"DMI.3.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.3.2",
                            Type = @"Component",
                            Position = @"DMI.3.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.4",
                            Type = @"Field",
                            Position = @"DMI.4",
                            Name = @"Average Length Of Stay",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the average length of stay in days, calculated as the geometric mean value, allocated to the determined DRG.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.5",
                            Type = @"Field",
                            Position = @"DMI.5",
                            Name = @"Relative Weight",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each DRG has its own relative weight (cost weight) which is calculated (defined) by official institutions. This value is the basis for calculating other values, e.g., the effective weight.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V28SegmentDMI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field diagnosticRelatedGroup;

public HL7V28Field DiagnosticRelatedGroup
{
    get
    {
        if (diagnosticRelatedGroup != null)
        {
            return diagnosticRelatedGroup;
        }

        diagnosticRelatedGroup = new HL7V28Field
        {
            field = message[@"DMI"][1],
            Id = @"DMI.1",
            Type = @"Field",
            Position = @"DMI.1",
            Name = @"Diagnostic Related Group",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded With No Exceptions",
            TableId = @"0055",
            TableName = @"Diagnosis Related Group",
            Description = @"This field contains the DRG for the transaction.  Interim DRG's could be determined for an encounter.  Refer to External Table 0055 – Diagnosis Related Group in Chapter 2C, Code Tables, for suggested values.  ",
            Sample = @"",
        };

        

        

        

        return diagnosticRelatedGroup;
    } 
}
internal HL7V28Field majorDiagnosticCategory;

public HL7V28Field MajorDiagnosticCategory
{
    get
    {
        if (majorDiagnosticCategory != null)
        {
            return majorDiagnosticCategory;
        }

        majorDiagnosticCategory = new HL7V28Field
        {
            field = message[@"DMI"][2],
            Id = @"DMI.2",
            Type = @"Field",
            Position = @"DMI.2",
            Name = @"Major Diagnostic Category",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded With No Exceptions",
            TableId = @"0118",
            TableName = @"Major Diagnostic Category",
            Description = @"This field indicates the determined Major Diagnostic Category (MDC) value. Refer to External Table 0118 – Major Diagnostic Category in Chapter 2C, Code Tables, for suggested values.",
            Sample = @"",
        };

        

        

        

        return majorDiagnosticCategory;
    } 
}
internal HL7V28Field lowerAndUpperTrimPoints;

public HL7V28Field LowerAndUpperTrimPoints
{
    get
    {
        if (lowerAndUpperTrimPoints != null)
        {
            return lowerAndUpperTrimPoints;
        }

        lowerAndUpperTrimPoints = new HL7V28Field
        {
            field = message[@"DMI"][3],
            Id = @"DMI.3",
            Type = @"Field",
            Position = @"DMI.3",
            Name = @"Lower And Upper Trim Points",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NR",
            DataTypeName = @"Numeric Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lower and upper trim points as calculated for this DRG.. 
Example as used in Germany: The ""lower trim point"" is equivalent to 1/3 of the average length of stay for patients having this DRG.  The ""upper trim point"" is equivalent to 3 times the average length of stay.  It is marked as the right dotted line within the graphics below.",
            Sample = @"",
        };

        

        

        

        return lowerAndUpperTrimPoints;
    } 
}
internal HL7V28Field averageLengthOfStay;

public HL7V28Field AverageLengthOfStay
{
    get
    {
        if (averageLengthOfStay != null)
        {
            return averageLengthOfStay;
        }

        averageLengthOfStay = new HL7V28Field
        {
            field = message[@"DMI"][4],
            Id = @"DMI.4",
            Type = @"Field",
            Position = @"DMI.4",
            Name = @"Average Length Of Stay",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the average length of stay in days, calculated as the geometric mean value, allocated to the determined DRG.",
            Sample = @"",
        };

        

        

        

        return averageLengthOfStay;
    } 
}
internal HL7V28Field relativeWeight;

public HL7V28Field RelativeWeight
{
    get
    {
        if (relativeWeight != null)
        {
            return relativeWeight;
        }

        relativeWeight = new HL7V28Field
        {
            field = message[@"DMI"][5],
            Id = @"DMI.5",
            Type = @"Field",
            Position = @"DMI.5",
            Name = @"Relative Weight",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Each DRG has its own relative weight (cost weight) which is calculated (defined) by official institutions. This value is the basis for calculating other values, e.g., the effective weight.",
            Sample = @"",
        };

        

        

        

        return relativeWeight;
    } 
}

    }
}

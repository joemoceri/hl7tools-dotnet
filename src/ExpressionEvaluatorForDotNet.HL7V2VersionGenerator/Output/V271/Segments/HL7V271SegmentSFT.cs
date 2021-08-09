using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentSFT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SFT"; } }

        public string SegmentId { get { return @"SFT"; } }
        
        public string LongName { get { return @"Software Segment"; } }
        
        public string Description { get { return @"This segment provides additional information about the software product(s) used as a Sending Application. The primary purpose of this segment is for diagnostic use. There may be additional uses per site-specific agreements.

Implementers are encouraged to use message profile identifiers (as found in 2.14.9.21, ""MSH-21 Message Profile Identifier (EI) 01598"") to control the behavior of the receiving application rather than relying on application or version information in the SFT segment.

For example, if software product A has versions 9 and 10 deployed in different Enterprise locations, the fact that they use different message types, segments, or fields should be reflected via their message profiles (see section 2B, ""Conformance Using Message Profiles""). If there is an upgrade from version 10 to 10.1, this would be reflected in the SFT segment, but changes to the message contents should be reflected via a new/different conformance profile.

Use Case: An external application has been customized to communicate with a centralized patient drug history system. However, due to certain, known characteristics of the external software package, the centralized system must modify its behavior in order to process transactions correctly. In one example, the external application may have multiple versions in production. As such, the centralized application will need to know the name of the Software Vendor Organization, the Software Release Number, the Software Product Name, and the Software Binary ID so that it can correctly identify the software submitting the transaction and modify its behavior appropriately.

While preparing a transaction for submission to a centralized system the sending application specifies its Software Install Date and its configuration settings (Software Product Information). 
While processing the transaction, the centralized system encounters an error. Upon examination of the error, install date and configuration of the software that sent the message, helpdesk staff are able to determine the sending application has not been updated to reflect recent application changes.

Use Case: In circumstances where a message is manipulated or modified by multiple systems, a repetition of this segment may be appended by each system."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Id = @"SFT.1",
                            Type = @"Field",
                            Position = @"SFT.1",
                            Name = @"Software Vendor Organization",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"Organization identification information for the software vendor that created this transaction. The purpose of this field, along with the remaining fields in this segment, is to provide a more complete picture of applications that are sending HL7 messages. The Software Vendor Organization field would allow the identification of the vendor who is responsible for maintaining the application.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SFT.1.1",
                            Type = @"Component",
                            Position = @"SFT.1.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2",
                            Type = @"Component",
                            Position = @"SFT.1.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0204",
                            TableName = @"Organizational Name Type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.1",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.2",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., ""myocardial infarction"" or ""X-ray impression"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.3",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the ""Coding System"" component or the ""Coding System OID"" for the tuple.

Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. 

Refer to section 2.A.8.3, ""Name of Coding System (ID)"" for a discussion of coding system conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.4",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. 

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.5",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.6",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.7",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.8",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.9",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.9",
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
                            Id = @"SFT.1.2.10",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.11",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.12",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.13",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.14",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.15",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.15",
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
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.16",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.15 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.17",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.18",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.19",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.18 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.20",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.21",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.2.22",
                            Type = @"SubComponent",
                            Position = @"SFT.1.2.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.21 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.3",
                            Type = @"Component",
                            Position = @"SFT.1.3",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The XON.3 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XON.10 Organization Identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.4",
                            Type = @"Component",
                            Position = @"SFT.1.4",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.

This component may also be used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.5",
                            Type = @"Component",
                            Position = @"SFT.1.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0061",
                            TableName = @"Check Digit Scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.

The check digit scheme codes are defined in HL7 Table 0061 - Check Digit Scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.6",
                            Type = @"Component",
                            Position = @"SFT.1.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values. 

Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.

By site agreement, implementers may continue to use User-defined Table 0300 – Namespace ID for the first sub-component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SFT.1.6.1",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.6.2",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.6.3",
                            Type = @"SubComponent",
                            Position = @"SFT.1.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.7",
                            Type = @"Component",
                            Position = @"SFT.1.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0203",
                            TableName = @"Identifier Type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.8",
                            Type = @"Component",
                            Position = @"SFT.1.8",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.

Note:When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SFT.1.8.1",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"The local coded item for the entity. The component intentionally remains associated with the IS data type in v2.7.

User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component. 

Note: When the HD is used in a given segment (either as a field or as a component of another data type) this table may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.8.2",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.8.3",
                            Type = @"SubComponent",
                            Position = @"SFT.1.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.9",
                            Type = @"Component",
                            Position = @"SFT.1.9",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0465",
                            TableName = @"Name/Address Representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.

Note: This new component remains in “alphabetic” representation with each repetition of the field using these data types, i.e. even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.
Refer to HL7 Table 0465 – Name/address Representation Code for valid values.

In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.1.10",
                            Type = @"Component",
                            Position = @"SFT.1.10",
                            Name = @"Organization Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.

Note: The check digit and code identifying check digit scheme are null if Organization identifier is alphanumeric.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.2",
                            Type = @"Field",
                            Position = @"SFT.2",
                            Name = @"Software Certified Version Or Release Number",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Latest software version number of the sending system that has been compliance tested and accepted. Software Certified Version or Release Number helps to provide a complete picture of the application that is sending/receiving HL7 messages. Versions are important in identifying a specific 'release' of an application. In some situations, the receiving application validates the Software Certified Version or Release Number against a list of ""certified"" versions/releases of the particular software to determine if the sending application adheres to specific business rules required by the receiving application.

Alternatively, the software may perform different processing depending on the version of the sending software",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.3",
                            Type = @"Field",
                            Position = @"SFT.3",
                            Name = @"Software Product Name",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the software product that submitted the transaction. A key component in the identification of an application is its Software Product Name. This is a key piece of information in identifying an application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.4",
                            Type = @"Field",
                            Position = @"SFT.4",
                            Name = @"Software Binary Id",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Issued by a vendor for each unique software version instance to distinguish between like versions of the same software e.g., a checksum.

Software Binary Ids are issued for each unique software version instance. As such, this information helps to differentiate between differing versions of the same software. Identical Primary IDs indicate that the software is identical at the binary level (configuration settings may differ).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.5",
                            Type = @"Field",
                            Position = @"SFT.5",
                            Name = @"Software Product Information",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Software identification information that can be supplied by a software vendor with their transaction. Might include configuration settings, etc.

This field would contain any additional information an application provides with the transaction it has submitted. This information could be used for diagnostic purposes and provides greater flexibility in identifying a piece of software. Possibilities include setup or configuration parameter information.

This field should not be sent unless performing diagnostics.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SFT.6",
                            Type = @"Field",
                            Position = @"SFT.6",
                            Name = @"Software Install Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"Date the submitting software was installed at the sending site.

A Software Install Date on its own can often provide key information about the behavior of the application, and is necessary to provide a complete picture of the sending application.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V271SegmentSFT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field softwareVendorOrganization;

public HL7V271Field SoftwareVendorOrganization
{
    get
    {
        if (softwareVendorOrganization != null)
        {
            return softwareVendorOrganization;
        }

        softwareVendorOrganization = new HL7V271Field
        {
            field = message[@"SFT"][1],
            Id = @"SFT.1",
            Type = @"Field",
            Position = @"SFT.1",
            Name = @"Software Vendor Organization",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"Organization identification information for the software vendor that created this transaction. The purpose of this field, along with the remaining fields in this segment, is to provide a more complete picture of applications that are sending HL7 messages. The Software Vendor Organization field would allow the identification of the vendor who is responsible for maintaining the application.",
            Sample = @"",
        };

        // check for repetitions
        if (softwareVendorOrganization.field.FieldRepetitions != null && softwareVendorOrganization.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareVendorOrganization.Id));
            softwareVendorOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareVendorOrganization, fieldData);
        }

        return softwareVendorOrganization;
    } 
}

internal HL7V271Field softwareCertifiedVersionOrReleaseNumber;

public HL7V271Field SoftwareCertifiedVersionOrReleaseNumber
{
    get
    {
        if (softwareCertifiedVersionOrReleaseNumber != null)
        {
            return softwareCertifiedVersionOrReleaseNumber;
        }

        softwareCertifiedVersionOrReleaseNumber = new HL7V271Field
        {
            field = message[@"SFT"][2],
            Id = @"SFT.2",
            Type = @"Field",
            Position = @"SFT.2",
            Name = @"Software Certified Version Or Release Number",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Latest software version number of the sending system that has been compliance tested and accepted. Software Certified Version or Release Number helps to provide a complete picture of the application that is sending/receiving HL7 messages. Versions are important in identifying a specific 'release' of an application. In some situations, the receiving application validates the Software Certified Version or Release Number against a list of ""certified"" versions/releases of the particular software to determine if the sending application adheres to specific business rules required by the receiving application.

Alternatively, the software may perform different processing depending on the version of the sending software",
            Sample = @"",
        };

        // check for repetitions
        if (softwareCertifiedVersionOrReleaseNumber.field.FieldRepetitions != null && softwareCertifiedVersionOrReleaseNumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareCertifiedVersionOrReleaseNumber.Id));
            softwareCertifiedVersionOrReleaseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareCertifiedVersionOrReleaseNumber, fieldData);
        }

        return softwareCertifiedVersionOrReleaseNumber;
    } 
}

internal HL7V271Field softwareProductName;

public HL7V271Field SoftwareProductName
{
    get
    {
        if (softwareProductName != null)
        {
            return softwareProductName;
        }

        softwareProductName = new HL7V271Field
        {
            field = message[@"SFT"][3],
            Id = @"SFT.3",
            Type = @"Field",
            Position = @"SFT.3",
            Name = @"Software Product Name",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The name of the software product that submitted the transaction. A key component in the identification of an application is its Software Product Name. This is a key piece of information in identifying an application.",
            Sample = @"",
        };

        // check for repetitions
        if (softwareProductName.field.FieldRepetitions != null && softwareProductName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareProductName.Id));
            softwareProductName.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareProductName, fieldData);
        }

        return softwareProductName;
    } 
}

internal HL7V271Field softwareBinaryId;

public HL7V271Field SoftwareBinaryId
{
    get
    {
        if (softwareBinaryId != null)
        {
            return softwareBinaryId;
        }

        softwareBinaryId = new HL7V271Field
        {
            field = message[@"SFT"][4],
            Id = @"SFT.4",
            Type = @"Field",
            Position = @"SFT.4",
            Name = @"Software Binary Id",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Issued by a vendor for each unique software version instance to distinguish between like versions of the same software e.g., a checksum.

Software Binary Ids are issued for each unique software version instance. As such, this information helps to differentiate between differing versions of the same software. Identical Primary IDs indicate that the software is identical at the binary level (configuration settings may differ).",
            Sample = @"",
        };

        // check for repetitions
        if (softwareBinaryId.field.FieldRepetitions != null && softwareBinaryId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareBinaryId.Id));
            softwareBinaryId.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareBinaryId, fieldData);
        }

        return softwareBinaryId;
    } 
}

internal HL7V271Field softwareProductInformation;

public HL7V271Field SoftwareProductInformation
{
    get
    {
        if (softwareProductInformation != null)
        {
            return softwareProductInformation;
        }

        softwareProductInformation = new HL7V271Field
        {
            field = message[@"SFT"][5],
            Id = @"SFT.5",
            Type = @"Field",
            Position = @"SFT.5",
            Name = @"Software Product Information",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"Software identification information that can be supplied by a software vendor with their transaction. Might include configuration settings, etc.

This field would contain any additional information an application provides with the transaction it has submitted. This information could be used for diagnostic purposes and provides greater flexibility in identifying a piece of software. Possibilities include setup or configuration parameter information.

This field should not be sent unless performing diagnostics.",
            Sample = @"",
        };

        // check for repetitions
        if (softwareProductInformation.field.FieldRepetitions != null && softwareProductInformation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareProductInformation.Id));
            softwareProductInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareProductInformation, fieldData);
        }

        return softwareProductInformation;
    } 
}

internal HL7V271Field softwareInstallDate;

public HL7V271Field SoftwareInstallDate
{
    get
    {
        if (softwareInstallDate != null)
        {
            return softwareInstallDate;
        }

        softwareInstallDate = new HL7V271Field
        {
            field = message[@"SFT"][6],
            Id = @"SFT.6",
            Type = @"Field",
            Position = @"SFT.6",
            Name = @"Software Install Date",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"Date the submitting software was installed at the sending site.

A Software Install Date on its own can often provide key information about the behavior of the application, and is necessary to provide a complete picture of the sending application.",
            Sample = @"",
        };

        // check for repetitions
        if (softwareInstallDate.field.FieldRepetitions != null && softwareInstallDate.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(softwareInstallDate.Id));
            softwareInstallDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(softwareInstallDate, fieldData);
        }

        return softwareInstallDate;
    } 
}
    }
}

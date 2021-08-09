using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28SegmentMFA
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFA"; } }

        public string SegmentId { get { return @"MFA"; } }
        
        public string LongName { get { return @"Master File Acknowledgment"; } }
        
        public string Description { get { return @""; } }
        
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
                            Id = @"MFA.1",
                            Type = @"Field",
                            Position = @"MFA.1",
                            Name = @"Record-level Event Code",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0180",
                            TableName = @"Record-level Event Code",
                            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system.  When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged.  It is only required if the MFI response level code requires responses at the record level (any value other than NE).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.2",
                            Type = @"Field",
                            Position = @"MFA.2",
                            Name = @"Mfn Control Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An optional effective date/time can be included for the record-level action specified.  It is the date/time the originating system expects that the event is to have been completed on the receiving system.  If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.3",
                            Type = @"Field",
                            Position = @"MFA.3",
                            Name = @"Event Completion Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"Refer to User-defined Table 0181 - MFN Record-level Error Return for suggested values.  All such tables will have at least the following two return code values: ""S"" for successful and ""U"" for unsuccessful.

  This field contains the status of the requested update.  Site-defined table, specific to each master file being updated via this transaction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4",
                            Type = @"Field",
                            Position = @"MFA.4",
                            Name = @"Mfn Record Level Error Return",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0181",
                            TableName = @"MFN Record-level Error Return",
                            Description = @"The repetition of the primary key permits the identification of an individual component of a complex record as the object of the record-level event code.  This feature allows the Master Files protocol to be used for modifications of single components of complex records.  If this field repeats, the field MFA-6 - Primary Key Value Type - MFA must also repeat (with the same number of repetitions), and the data type of each repetition of MFA-5 - Primary Key Value - MFA is specified by the corresponding repetition of MFA-6 - Value Type - MFA.

  This field uniquely identifies the record of the master file (identified in the MFI segment) for which the update status is being acknowledged (as defined by the field MFN-4 - Record Level Error Return).  The data type of this field is defined by the value of MFA-6 - Value Type - MFA, and may take on the format of any of the HL7 data types defined in HL7 Table 0355 - Primary Key Value Type.  The PL data type is used only on location master transactions.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"MFA.4.1",
                            Type = @"Component",
                            Position = @"MFA.4.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.

In the context of “Data Missing”, described above in the Usage Note, refer to HL7 Table 0353 – CWE Statuses for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.2",
                            Type = @"Component",
                            Position = @"MFA.4.2",
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
                            Id = @"MFA.4.3",
                            Type = @"Component",
                            Position = @"MFA.4.3",
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
                            Id = @"MFA.4.4",
                            Type = @"Component",
                            Position = @"MFA.4.4",
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
                            Id = @"MFA.4.5",
                            Type = @"Component",
                            Position = @"MFA.4.5",
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
                            Id = @"MFA.4.6",
                            Type = @"Component",
                            Position = @"MFA.4.6",
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
                            Id = @"MFA.4.7",
                            Type = @"Component",
                            Position = @"MFA.4.7",
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
                            Id = @"MFA.4.8",
                            Type = @"Component",
                            Position = @"MFA.4.8",
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
                            Id = @"MFA.4.9",
                            Type = @"Component",
                            Position = @"MFA.4.9",
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
                            Id = @"MFA.4.10",
                            Type = @"Component",
                            Position = @"MFA.4.10",
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
                            Id = @"MFA.4.11",
                            Type = @"Component",
                            Position = @"MFA.4.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.4.12",
                            Type = @"Component",
                            Position = @"MFA.4.12",
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
                            Id = @"MFA.4.13",
                            Type = @"Component",
                            Position = @"MFA.4.13",
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
                            Id = @"MFA.4.14",
                            Type = @"Component",
                            Position = @"MFA.4.14",
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
                            Id = @"MFA.4.15",
                            Type = @"Component",
                            Position = @"MFA.4.15",
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
                            Id = @"MFA.4.16",
                            Type = @"Component",
                            Position = @"MFA.4.16",
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
                            Id = @"MFA.4.17",
                            Type = @"Component",
                            Position = @"MFA.4.17",
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
                            Id = @"MFA.4.18",
                            Type = @"Component",
                            Position = @"MFA.4.18",
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
                            Id = @"MFA.4.19",
                            Type = @"Component",
                            Position = @"MFA.4.19",
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
                            Id = @"MFA.4.20",
                            Type = @"Component",
                            Position = @"MFA.4.20",
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
                            Id = @"MFA.4.21",
                            Type = @"Component",
                            Position = @"MFA.4.21",
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
                            Id = @"MFA.4.22",
                            Type = @"Component",
                            Position = @"MFA.4.22",
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
                            Id = @"MFA.5",
                            Type = @"Field",
                            Position = @"MFA.5",
                            Name = @"Primary Key Value - Mfa",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"varies",
                            DataTypeName = @"Varies",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the HL7 data type of MFA-5 - Primary Key Value - MFA.  The valid HL7 data types are listed in HL7 Table 0355 - Primary Key Value Type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MFA.6",
                            Type = @"Field",
                            Position = @"MFA.6",
                            Name = @"Primary Key Value Type - Mfa",
                            Length = 3,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0355",
                            TableName = @"Primary Key Value Type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V28SegmentMFA(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V28Field recordlevelEventCode;

public HL7V28Field RecordlevelEventCode
{
    get
    {
        if (recordlevelEventCode != null)
        {
            return recordlevelEventCode;
        }

        recordlevelEventCode = new HL7V28Field
        {
            field = message[@"MFA"][1],
            Id = @"MFA.1",
            Type = @"Field",
            Position = @"MFA.1",
            Name = @"Record-level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0180",
            TableName = @"Record-level Event Code",
            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system.  When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged.  It is only required if the MFI response level code requires responses at the record level (any value other than NE).",
            Sample = @"",
        };

        // check for repetitions
        if (recordlevelEventCode.field.FieldRepetitions != null && recordlevelEventCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(recordlevelEventCode.Id));
            recordlevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(recordlevelEventCode, fieldData);
        }

        return recordlevelEventCode;
    } 
}

internal HL7V28Field mfnControlId;

public HL7V28Field MfnControlId
{
    get
    {
        if (mfnControlId != null)
        {
            return mfnControlId;
        }

        mfnControlId = new HL7V28Field
        {
            field = message[@"MFA"][2],
            Id = @"MFA.2",
            Type = @"Field",
            Position = @"MFA.2",
            Name = @"Mfn Control Id",
            Length = 0,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"An optional effective date/time can be included for the record-level action specified.  It is the date/time the originating system expects that the event is to have been completed on the receiving system.  If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
            Sample = @"",
        };

        // check for repetitions
        if (mfnControlId.field.FieldRepetitions != null && mfnControlId.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mfnControlId.Id));
            mfnControlId.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(mfnControlId, fieldData);
        }

        return mfnControlId;
    } 
}

internal HL7V28Field eventCompletionDateTime;

public HL7V28Field EventCompletionDateTime
{
    get
    {
        if (eventCompletionDateTime != null)
        {
            return eventCompletionDateTime;
        }

        eventCompletionDateTime = new HL7V28Field
        {
            field = message[@"MFA"][3],
            Id = @"MFA.3",
            Type = @"Field",
            Position = @"MFA.3",
            Name = @"Event Completion Date/Time",
            Length = 0,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/time",
            TableId = null,
            TableName = null,
            Description = @"Refer to User-defined Table 0181 - MFN Record-level Error Return for suggested values.  All such tables will have at least the following two return code values: ""S"" for successful and ""U"" for unsuccessful.

  This field contains the status of the requested update.  Site-defined table, specific to each master file being updated via this transaction.",
            Sample = @"",
        };

        // check for repetitions
        if (eventCompletionDateTime.field.FieldRepetitions != null && eventCompletionDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(eventCompletionDateTime.Id));
            eventCompletionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(eventCompletionDateTime, fieldData);
        }

        return eventCompletionDateTime;
    } 
}

internal HL7V28Field mfnRecordLevelErrorReturn;

public HL7V28Field MfnRecordLevelErrorReturn
{
    get
    {
        if (mfnRecordLevelErrorReturn != null)
        {
            return mfnRecordLevelErrorReturn;
        }

        mfnRecordLevelErrorReturn = new HL7V28Field
        {
            field = message[@"MFA"][4],
            Id = @"MFA.4",
            Type = @"Field",
            Position = @"MFA.4",
            Name = @"Mfn Record Level Error Return",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded With Exceptions",
            TableId = @"0181",
            TableName = @"MFN Record-level Error Return",
            Description = @"The repetition of the primary key permits the identification of an individual component of a complex record as the object of the record-level event code.  This feature allows the Master Files protocol to be used for modifications of single components of complex records.  If this field repeats, the field MFA-6 - Primary Key Value Type - MFA must also repeat (with the same number of repetitions), and the data type of each repetition of MFA-5 - Primary Key Value - MFA is specified by the corresponding repetition of MFA-6 - Value Type - MFA.

  This field uniquely identifies the record of the master file (identified in the MFI segment) for which the update status is being acknowledged (as defined by the field MFN-4 - Record Level Error Return).  The data type of this field is defined by the value of MFA-6 - Value Type - MFA, and may take on the format of any of the HL7 data types defined in HL7 Table 0355 - Primary Key Value Type.  The PL data type is used only on location master transactions.",
            Sample = @"",
        };

        // check for repetitions
        if (mfnRecordLevelErrorReturn.field.FieldRepetitions != null && mfnRecordLevelErrorReturn.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(mfnRecordLevelErrorReturn.Id));
            mfnRecordLevelErrorReturn.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(mfnRecordLevelErrorReturn, fieldData);
        }

        return mfnRecordLevelErrorReturn;
    } 
}

internal HL7V28Field primaryKeyValueMfa;

public HL7V28Field PrimaryKeyValueMfa
{
    get
    {
        if (primaryKeyValueMfa != null)
        {
            return primaryKeyValueMfa;
        }

        primaryKeyValueMfa = new HL7V28Field
        {
            field = message[@"MFA"][5],
            Id = @"MFA.5",
            Type = @"Field",
            Position = @"MFA.5",
            Name = @"Primary Key Value - Mfa",
            Length = 0,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"varies",
            DataTypeName = @"Varies",
            TableId = null,
            TableName = null,
            Description = @"This field contains the HL7 data type of MFA-5 - Primary Key Value - MFA.  The valid HL7 data types are listed in HL7 Table 0355 - Primary Key Value Type.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValueMfa.field.FieldRepetitions != null && primaryKeyValueMfa.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValueMfa.Id));
            primaryKeyValueMfa.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(primaryKeyValueMfa, fieldData);
        }

        return primaryKeyValueMfa;
    } 
}

internal HL7V28Field primaryKeyValueTypeMfa;

public HL7V28Field PrimaryKeyValueTypeMfa
{
    get
    {
        if (primaryKeyValueTypeMfa != null)
        {
            return primaryKeyValueTypeMfa;
        }

        primaryKeyValueTypeMfa = new HL7V28Field
        {
            field = message[@"MFA"][6],
            Id = @"MFA.6",
            Type = @"Field",
            Position = @"MFA.6",
            Name = @"Primary Key Value Type - Mfa",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0355",
            TableName = @"Primary Key Value Type",
            Description = null,
            Sample = @"",
        };

        // check for repetitions
        if (primaryKeyValueTypeMfa.field.FieldRepetitions != null && primaryKeyValueTypeMfa.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryKeyValueTypeMfa.Id));
            primaryKeyValueTypeMfa.fieldRepetitions = HL7V2FieldGenerator.GenerateV28FieldRepetitions(primaryKeyValueTypeMfa, fieldData);
        }

        return primaryKeyValueTypeMfa;
    } 
}
    }
}

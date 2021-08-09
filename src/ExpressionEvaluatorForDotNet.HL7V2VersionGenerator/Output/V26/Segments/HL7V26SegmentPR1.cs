using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPR1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PR1"; } }

        public string SegmentId { get { return @"PR1"; } }
        
        public string LongName { get { return @"Procedures"; } }
        
        public string Description { get { return @"The PR1 segment contains information relative to various types of procedures that can be performed on a patient. The PR1 segment can be used to send procedure information, for example: Surgical, Nuclear Medicine, X-ray with contrast, etc. The PR1 segment is used to send multiple procedures, for example, for medical records encoding or for billing systems."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Id = @"PR1.1",
                            Type = @"Field",
                            Position = @"PR1.1",
                            Name = @"Set ID - PR1",
                            Length = 4,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.2",
                            Type = @"Field",
                            Position = @"PR1.2",
                            Name = @"Procedure Coding Method",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"PR1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3",
                            Type = @"Field",
                            Position = @"PR1.3",
                            Name = @"Procedure Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0088",
                            TableName = @"Procedure Code",
                            Description = @"This field contains a unique identifier assigned to the procedure. Refer to Externally-defined Table 0088 - Procedure Code for suggested values. This field is a CNE data type for compatibility with clinical and ancillary systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.3.1",
                            Type = @"Component",
                            Position = @"PR1.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.2",
                            Type = @"Component",
                            Position = @"PR1.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.3",
                            Type = @"Component",
                            Position = @"PR1.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.4",
                            Type = @"Component",
                            Position = @"PR1.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.5",
                            Type = @"Component",
                            Position = @"PR1.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.6",
                            Type = @"Component",
                            Position = @"PR1.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.7",
                            Type = @"Component",
                            Position = @"PR1.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.8",
                            Type = @"Component",
                            Position = @"PR1.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.3.9",
                            Type = @"Component",
                            Position = @"PR1.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.4",
                            Type = @"Field",
                            Position = @"PR1.4",
                            Name = @"Procedure Description",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"PR1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.5",
                            Type = @"Field",
                            Position = @"PR1.5",
                            Name = @"Procedure Date/Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time that the procedure was performed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.6",
                            Type = @"Field",
                            Position = @"PR1.6",
                            Name = @"Procedure Functional Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0230",
                            TableName = @"Procedure Functional Type",
                            Description = @"This field contains the optional code that further defines the type of procedure. Refer to User-defined Table 0230 - Procedure Functional Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.7",
                            Type = @"Field",
                            Position = @"PR1.7",
                            Name = @"Procedure Minutes",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the length of time in whole minutes that the procedure took to complete.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.8",
                            Type = @"Field",
                            Position = @"PR1.8",
                            Name = @"Anesthesiologist",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"PR1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.9",
                            Type = @"Field",
                            Position = @"PR1.9",
                            Name = @"Anesthesia Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0019",
                            TableName = @"Anesthesia Code",
                            Description = @"This field contains a unique identifier of the anesthesia used during the procedure. Refer to User-defined Table 0019 - Anesthesia Code for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.10",
                            Type = @"Field",
                            Position = @"PR1.10",
                            Name = @"Anesthesia Minutes",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the length of time in minutes that the anesthesia was administered.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.11",
                            Type = @"Field",
                            Position = @"PR1.11",
                            Name = @"Surgeon",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"PR1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.12",
                            Type = @"Field",
                            Position = @"PR1.12",
                            Name = @"Procedure Practitioner",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"PR1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13",
                            Type = @"Field",
                            Position = @"PR1.13",
                            Name = @"Consent Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0059",
                            TableName = @"Consent Code",
                            Description = @"This field contains the type of consent that was obtained for permission to treat the patient. Refer to User-defined Table 0059 - Consent Code for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.13.1",
                            Type = @"Component",
                            Position = @"PR1.13.1",
                            Name = @"Identifier",
                            Length = 20,
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
                            Id = @"PR1.13.2",
                            Type = @"Component",
                            Position = @"PR1.13.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.3",
                            Type = @"Component",
                            Position = @"PR1.13.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.4",
                            Type = @"Component",
                            Position = @"PR1.13.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.5",
                            Type = @"Component",
                            Position = @"PR1.13.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.6",
                            Type = @"Component",
                            Position = @"PR1.13.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.7",
                            Type = @"Component",
                            Position = @"PR1.13.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.8",
                            Type = @"Component",
                            Position = @"PR1.13.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.13.9",
                            Type = @"Component",
                            Position = @"PR1.13.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.14",
                            Type = @"Field",
                            Position = @"PR1.14",
                            Name = @"Procedure Priority",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0418",
                            TableName = @"Procedure Priority",
                            Description = @"This field contains a number that identifies the significance or priority of the procedure code. Refer to HL7 Table 0418 - Procedure Priority for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15",
                            Type = @"Field",
                            Position = @"PR1.15",
                            Name = @"Associated Diagnosis Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0051",
                            TableName = @"Diagnosis Code",
                            Description = @"This field contains the diagnosis that is the primary reason this procedure was performed, e.g., in the US, Medicare wants to know for which diagnosis this procedure is submitted for inclusion on CMS 1500 form. Refer to User-defined Table 0051 - Diagnosis Code for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.15.1",
                            Type = @"Component",
                            Position = @"PR1.15.1",
                            Name = @"Identifier",
                            Length = 20,
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
                            Id = @"PR1.15.2",
                            Type = @"Component",
                            Position = @"PR1.15.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.3",
                            Type = @"Component",
                            Position = @"PR1.15.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.4",
                            Type = @"Component",
                            Position = @"PR1.15.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.5",
                            Type = @"Component",
                            Position = @"PR1.15.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.6",
                            Type = @"Component",
                            Position = @"PR1.15.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.7",
                            Type = @"Component",
                            Position = @"PR1.15.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.8",
                            Type = @"Component",
                            Position = @"PR1.15.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.15.9",
                            Type = @"Component",
                            Position = @"PR1.15.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16",
                            Type = @"Field",
                            Position = @"PR1.16",
                            Name = @"Procedure Code Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0340",
                            TableName = @"Procedure Code Modifier",
                            Description = @"This field contains the procedure code modifier to the procedure code reported in field 3, when applicable. Procedure code modifiers are defined by regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to Externally-defined Table 0340 - Procedure Code Modifier for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.16.1",
                            Type = @"Component",
                            Position = @"PR1.16.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.2",
                            Type = @"Component",
                            Position = @"PR1.16.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.3",
                            Type = @"Component",
                            Position = @"PR1.16.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.4",
                            Type = @"Component",
                            Position = @"PR1.16.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.5",
                            Type = @"Component",
                            Position = @"PR1.16.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.6",
                            Type = @"Component",
                            Position = @"PR1.16.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.7",
                            Type = @"Component",
                            Position = @"PR1.16.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.8",
                            Type = @"Component",
                            Position = @"PR1.16.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.16.9",
                            Type = @"Component",
                            Position = @"PR1.16.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.17",
                            Type = @"Field",
                            Position = @"PR1.17",
                            Name = @"Procedure DRG Type",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0416",
                            TableName = @"Procedure DRG Type",
                            Description = @"This field indicates a procedures priority ranking relative to its DRG. Refer to User-defined Table 0416 - Procedure DRG Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18",
                            Type = @"Field",
                            Position = @"PR1.18",
                            Name = @"Tissue Type Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0417",
                            TableName = @"Tissue Type Code",
                            Description = @"Code representing type of tissue removed from a patient during this procedure. Refer to User-defined Table 0417 - Tissue Type Code for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.18.1",
                            Type = @"Component",
                            Position = @"PR1.18.1",
                            Name = @"Identifier",
                            Length = 20,
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
                            Id = @"PR1.18.2",
                            Type = @"Component",
                            Position = @"PR1.18.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.3",
                            Type = @"Component",
                            Position = @"PR1.18.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.4",
                            Type = @"Component",
                            Position = @"PR1.18.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.5",
                            Type = @"Component",
                            Position = @"PR1.18.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.6",
                            Type = @"Component",
                            Position = @"PR1.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.7",
                            Type = @"Component",
                            Position = @"PR1.18.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.8",
                            Type = @"Component",
                            Position = @"PR1.18.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.18.9",
                            Type = @"Component",
                            Position = @"PR1.18.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.19",
                            Type = @"Field",
                            Position = @"PR1.19",
                            Name = @"Procedure Identifier",
                            Length = 427,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a value that uniquely identifies a single procedure for an encounter. It is unique across all segments and messages for an encounter.  This field is required in all implementations employing Update Diagnosis/Procedures (P12) messages.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"PR1.19.1",
                            Type = @"Component",
                            Position = @"PR1.19.1",
                            Name = @"Entity Identifier",
                            Length = 199,
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
                            Id = @"PR1.19.2",
                            Type = @"Component",
                            Position = @"PR1.19.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.19.3",
                            Type = @"Component",
                            Position = @"PR1.19.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.19.4",
                            Type = @"Component",
                            Position = @"PR1.19.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.20",
                            Type = @"Field",
                            Position = @"PR1.20",
                            Name = @"Procedure Action Code",
                            Length = 1,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0206",
                            TableName = @"Segment action code",
                            Description = @"This field defines the action to be taken for this procedure. Refer to HL7 Table 0206 - Segment Action Code in Chapter 2 for valid values.  This field is required for the Update Diagnosis/Procedures (P12) message.  In all other events it is optional.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.21",
                            Type = @"Field",
                            Position = @"PR1.21",
                            Name = @"DRG Procedure Determination Status",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0761",
                            TableName = @"DRG Procedure Determination Status",
                            Description = @"This field contains the status of the use of this particular procedure for the DRG determination. Refer to User-defined Table 0761 - DRG Procedure Determination Status for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PR1.22",
                            Type = @"Field",
                            Position = @"PR1.22",
                            Name = @"DRG Procedure Relevance",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0763",
                            TableName = @"DRG Procedure Relevance",
                            Description = @"This field contains the relevance of this particular procedure for the DRG determination. Refer toUser-defined Table 0763 - DRG Procedure Relevance for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentPR1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDPR1;

public HL7V26Field SetIDPR1
{
    get
    {
        if (setIDPR1 != null)
        {
            return setIDPR1;
        }

        setIDPR1 = new HL7V26Field
        {
            field = message[@"PR1"][1],
            Id = @"PR1.1",
            Type = @"Field",
            Position = @"PR1.1",
            Name = @"Set ID - PR1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDPR1.field.FieldRepetitions != null && setIDPR1.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDPR1.Id));
            setIDPR1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(setIDPR1, fieldData);
        }

        return setIDPR1;
    } 
}

internal HL7V26Field procedureCodingMethod;

public HL7V26Field ProcedureCodingMethod
{
    get
    {
        if (procedureCodingMethod != null)
        {
            return procedureCodingMethod;
        }

        procedureCodingMethod = new HL7V26Field
        {
            field = message[@"PR1"][2],
            Id = @"PR1.2",
            Type = @"Field",
            Position = @"PR1.2",
            Name = @"Procedure Coding Method",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-2 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
        };

        // check for repetitions
        if (procedureCodingMethod.field.FieldRepetitions != null && procedureCodingMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureCodingMethod.Id));
            procedureCodingMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureCodingMethod, fieldData);
        }

        return procedureCodingMethod;
    } 
}

internal HL7V26Field procedureCode;

public HL7V26Field ProcedureCode
{
    get
    {
        if (procedureCode != null)
        {
            return procedureCode;
        }

        procedureCode = new HL7V26Field
        {
            field = message[@"PR1"][3],
            Id = @"PR1.3",
            Type = @"Field",
            Position = @"PR1.3",
            Name = @"Procedure Code",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0088",
            TableName = @"Procedure Code",
            Description = @"This field contains a unique identifier assigned to the procedure. Refer to Externally-defined Table 0088 - Procedure Code for suggested values. This field is a CNE data type for compatibility with clinical and ancillary systems.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureCode.field.FieldRepetitions != null && procedureCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureCode.Id));
            procedureCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureCode, fieldData);
        }

        return procedureCode;
    } 
}

internal HL7V26Field procedureDescription;

public HL7V26Field ProcedureDescription
{
    get
    {
        if (procedureDescription != null)
        {
            return procedureDescription;
        }

        procedureDescription = new HL7V26Field
        {
            field = message[@"PR1"][4],
            Id = @"PR1.4",
            Type = @"Field",
            Position = @"PR1.4",
            Name = @"Procedure Description",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-4 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
        };

        // check for repetitions
        if (procedureDescription.field.FieldRepetitions != null && procedureDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureDescription.Id));
            procedureDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureDescription, fieldData);
        }

        return procedureDescription;
    } 
}

internal HL7V26Field procedureDateTime;

public HL7V26Field ProcedureDateTime
{
    get
    {
        if (procedureDateTime != null)
        {
            return procedureDateTime;
        }

        procedureDateTime = new HL7V26Field
        {
            field = message[@"PR1"][5],
            Id = @"PR1.5",
            Type = @"Field",
            Position = @"PR1.5",
            Name = @"Procedure Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the procedure was performed.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureDateTime.field.FieldRepetitions != null && procedureDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureDateTime.Id));
            procedureDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureDateTime, fieldData);
        }

        return procedureDateTime;
    } 
}

internal HL7V26Field procedureFunctionalType;

public HL7V26Field ProcedureFunctionalType
{
    get
    {
        if (procedureFunctionalType != null)
        {
            return procedureFunctionalType;
        }

        procedureFunctionalType = new HL7V26Field
        {
            field = message[@"PR1"][6],
            Id = @"PR1.6",
            Type = @"Field",
            Position = @"PR1.6",
            Name = @"Procedure Functional Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0230",
            TableName = @"Procedure Functional Type",
            Description = @"This field contains the optional code that further defines the type of procedure. Refer to User-defined Table 0230 - Procedure Functional Type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureFunctionalType.field.FieldRepetitions != null && procedureFunctionalType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureFunctionalType.Id));
            procedureFunctionalType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureFunctionalType, fieldData);
        }

        return procedureFunctionalType;
    } 
}

internal HL7V26Field procedureMinutes;

public HL7V26Field ProcedureMinutes
{
    get
    {
        if (procedureMinutes != null)
        {
            return procedureMinutes;
        }

        procedureMinutes = new HL7V26Field
        {
            field = message[@"PR1"][7],
            Id = @"PR1.7",
            Type = @"Field",
            Position = @"PR1.7",
            Name = @"Procedure Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the length of time in whole minutes that the procedure took to complete.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureMinutes.field.FieldRepetitions != null && procedureMinutes.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureMinutes.Id));
            procedureMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureMinutes, fieldData);
        }

        return procedureMinutes;
    } 
}

internal HL7V26Field anesthesiologist;

public HL7V26Field Anesthesiologist
{
    get
    {
        if (anesthesiologist != null)
        {
            return anesthesiologist;
        }

        anesthesiologist = new HL7V26Field
        {
            field = message[@"PR1"][8],
            Id = @"PR1.8",
            Type = @"Field",
            Position = @"PR1.8",
            Name = @"Anesthesiologist",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-8 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
        };

        // check for repetitions
        if (anesthesiologist.field.FieldRepetitions != null && anesthesiologist.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(anesthesiologist.Id));
            anesthesiologist.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(anesthesiologist, fieldData);
        }

        return anesthesiologist;
    } 
}

internal HL7V26Field anesthesiaCode;

public HL7V26Field AnesthesiaCode
{
    get
    {
        if (anesthesiaCode != null)
        {
            return anesthesiaCode;
        }

        anesthesiaCode = new HL7V26Field
        {
            field = message[@"PR1"][9],
            Id = @"PR1.9",
            Type = @"Field",
            Position = @"PR1.9",
            Name = @"Anesthesia Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0019",
            TableName = @"Anesthesia Code",
            Description = @"This field contains a unique identifier of the anesthesia used during the procedure. Refer to User-defined Table 0019 - Anesthesia Code for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (anesthesiaCode.field.FieldRepetitions != null && anesthesiaCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(anesthesiaCode.Id));
            anesthesiaCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(anesthesiaCode, fieldData);
        }

        return anesthesiaCode;
    } 
}

internal HL7V26Field anesthesiaMinutes;

public HL7V26Field AnesthesiaMinutes
{
    get
    {
        if (anesthesiaMinutes != null)
        {
            return anesthesiaMinutes;
        }

        anesthesiaMinutes = new HL7V26Field
        {
            field = message[@"PR1"][10],
            Id = @"PR1.10",
            Type = @"Field",
            Position = @"PR1.10",
            Name = @"Anesthesia Minutes",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the length of time in minutes that the anesthesia was administered.",
            Sample = @"",
        };

        // check for repetitions
        if (anesthesiaMinutes.field.FieldRepetitions != null && anesthesiaMinutes.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(anesthesiaMinutes.Id));
            anesthesiaMinutes.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(anesthesiaMinutes, fieldData);
        }

        return anesthesiaMinutes;
    } 
}

internal HL7V26Field surgeon;

public HL7V26Field Surgeon
{
    get
    {
        if (surgeon != null)
        {
            return surgeon;
        }

        surgeon = new HL7V26Field
        {
            field = message[@"PR1"][11],
            Id = @"PR1.11",
            Type = @"Field",
            Position = @"PR1.11",
            Name = @"Surgeon",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-11 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
        };

        // check for repetitions
        if (surgeon.field.FieldRepetitions != null && surgeon.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(surgeon.Id));
            surgeon.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(surgeon, fieldData);
        }

        return surgeon;
    } 
}

internal HL7V26Field procedurePractitioner;

public HL7V26Field ProcedurePractitioner
{
    get
    {
        if (procedurePractitioner != null)
        {
            return procedurePractitioner;
        }

        procedurePractitioner = new HL7V26Field
        {
            field = message[@"PR1"][12],
            Id = @"PR1.12",
            Type = @"Field",
            Position = @"PR1.12",
            Name = @"Procedure Practitioner",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"PR1-12 was deprecated as of v2.3 and the detail was withdrawn and removed from the standard as of v 2.6",
            Sample = @"",
        };

        // check for repetitions
        if (procedurePractitioner.field.FieldRepetitions != null && procedurePractitioner.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedurePractitioner.Id));
            procedurePractitioner.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedurePractitioner, fieldData);
        }

        return procedurePractitioner;
    } 
}

internal HL7V26Field consentCode;

public HL7V26Field ConsentCode
{
    get
    {
        if (consentCode != null)
        {
            return consentCode;
        }

        consentCode = new HL7V26Field
        {
            field = message[@"PR1"][13],
            Id = @"PR1.13",
            Type = @"Field",
            Position = @"PR1.13",
            Name = @"Consent Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0059",
            TableName = @"Consent Code",
            Description = @"This field contains the type of consent that was obtained for permission to treat the patient. Refer to User-defined Table 0059 - Consent Code for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (consentCode.field.FieldRepetitions != null && consentCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(consentCode.Id));
            consentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(consentCode, fieldData);
        }

        return consentCode;
    } 
}

internal HL7V26Field procedurePriority;

public HL7V26Field ProcedurePriority
{
    get
    {
        if (procedurePriority != null)
        {
            return procedurePriority;
        }

        procedurePriority = new HL7V26Field
        {
            field = message[@"PR1"][14],
            Id = @"PR1.14",
            Type = @"Field",
            Position = @"PR1.14",
            Name = @"Procedure Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0418",
            TableName = @"Procedure Priority",
            Description = @"This field contains a number that identifies the significance or priority of the procedure code. Refer to HL7 Table 0418 - Procedure Priority for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (procedurePriority.field.FieldRepetitions != null && procedurePriority.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedurePriority.Id));
            procedurePriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedurePriority, fieldData);
        }

        return procedurePriority;
    } 
}

internal HL7V26Field associatedDiagnosisCode;

public HL7V26Field AssociatedDiagnosisCode
{
    get
    {
        if (associatedDiagnosisCode != null)
        {
            return associatedDiagnosisCode;
        }

        associatedDiagnosisCode = new HL7V26Field
        {
            field = message[@"PR1"][15],
            Id = @"PR1.15",
            Type = @"Field",
            Position = @"PR1.15",
            Name = @"Associated Diagnosis Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0051",
            TableName = @"Diagnosis Code",
            Description = @"This field contains the diagnosis that is the primary reason this procedure was performed, e.g., in the US, Medicare wants to know for which diagnosis this procedure is submitted for inclusion on CMS 1500 form. Refer to User-defined Table 0051 - Diagnosis Code for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (associatedDiagnosisCode.field.FieldRepetitions != null && associatedDiagnosisCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(associatedDiagnosisCode.Id));
            associatedDiagnosisCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(associatedDiagnosisCode, fieldData);
        }

        return associatedDiagnosisCode;
    } 
}

internal HL7V26Field procedureCodeModifier;

public HL7V26Field ProcedureCodeModifier
{
    get
    {
        if (procedureCodeModifier != null)
        {
            return procedureCodeModifier;
        }

        procedureCodeModifier = new HL7V26Field
        {
            field = message[@"PR1"][16],
            Id = @"PR1.16",
            Type = @"Field",
            Position = @"PR1.16",
            Name = @"Procedure Code Modifier",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0340",
            TableName = @"Procedure Code Modifier",
            Description = @"This field contains the procedure code modifier to the procedure code reported in field 3, when applicable. Procedure code modifiers are defined by regulatory agencies such as CMS and the AMA. Multiple modifiers may be reported. Refer to Externally-defined Table 0340 - Procedure Code Modifier for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureCodeModifier.field.FieldRepetitions != null && procedureCodeModifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureCodeModifier.Id));
            procedureCodeModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureCodeModifier, fieldData);
        }

        return procedureCodeModifier;
    } 
}

internal HL7V26Field procedureDRGType;

public HL7V26Field ProcedureDRGType
{
    get
    {
        if (procedureDRGType != null)
        {
            return procedureDRGType;
        }

        procedureDRGType = new HL7V26Field
        {
            field = message[@"PR1"][17],
            Id = @"PR1.17",
            Type = @"Field",
            Position = @"PR1.17",
            Name = @"Procedure DRG Type",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0416",
            TableName = @"Procedure DRG Type",
            Description = @"This field indicates a procedures priority ranking relative to its DRG. Refer to User-defined Table 0416 - Procedure DRG Type for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureDRGType.field.FieldRepetitions != null && procedureDRGType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureDRGType.Id));
            procedureDRGType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureDRGType, fieldData);
        }

        return procedureDRGType;
    } 
}

internal HL7V26Field tissueTypeCode;

public HL7V26Field TissueTypeCode
{
    get
    {
        if (tissueTypeCode != null)
        {
            return tissueTypeCode;
        }

        tissueTypeCode = new HL7V26Field
        {
            field = message[@"PR1"][18],
            Id = @"PR1.18",
            Type = @"Field",
            Position = @"PR1.18",
            Name = @"Tissue Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0417",
            TableName = @"Tissue Type Code",
            Description = @"Code representing type of tissue removed from a patient during this procedure. Refer to User-defined Table 0417 - Tissue Type Code for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (tissueTypeCode.field.FieldRepetitions != null && tissueTypeCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(tissueTypeCode.Id));
            tissueTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(tissueTypeCode, fieldData);
        }

        return tissueTypeCode;
    } 
}

internal HL7V26Field procedureIdentifier;

public HL7V26Field ProcedureIdentifier
{
    get
    {
        if (procedureIdentifier != null)
        {
            return procedureIdentifier;
        }

        procedureIdentifier = new HL7V26Field
        {
            field = message[@"PR1"][19],
            Id = @"PR1.19",
            Type = @"Field",
            Position = @"PR1.19",
            Name = @"Procedure Identifier",
            Length = 427,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a value that uniquely identifies a single procedure for an encounter. It is unique across all segments and messages for an encounter.  This field is required in all implementations employing Update Diagnosis/Procedures (P12) messages.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureIdentifier.field.FieldRepetitions != null && procedureIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureIdentifier.Id));
            procedureIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureIdentifier, fieldData);
        }

        return procedureIdentifier;
    } 
}

internal HL7V26Field procedureActionCode;

public HL7V26Field ProcedureActionCode
{
    get
    {
        if (procedureActionCode != null)
        {
            return procedureActionCode;
        }

        procedureActionCode = new HL7V26Field
        {
            field = message[@"PR1"][20],
            Id = @"PR1.20",
            Type = @"Field",
            Position = @"PR1.20",
            Name = @"Procedure Action Code",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0206",
            TableName = @"Segment action code",
            Description = @"This field defines the action to be taken for this procedure. Refer to HL7 Table 0206 - Segment Action Code in Chapter 2 for valid values.  This field is required for the Update Diagnosis/Procedures (P12) message.  In all other events it is optional.",
            Sample = @"",
        };

        // check for repetitions
        if (procedureActionCode.field.FieldRepetitions != null && procedureActionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(procedureActionCode.Id));
            procedureActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(procedureActionCode, fieldData);
        }

        return procedureActionCode;
    } 
}

internal HL7V26Field dRGProcedureDeterminationStatus;

public HL7V26Field DRGProcedureDeterminationStatus
{
    get
    {
        if (dRGProcedureDeterminationStatus != null)
        {
            return dRGProcedureDeterminationStatus;
        }

        dRGProcedureDeterminationStatus = new HL7V26Field
        {
            field = message[@"PR1"][21],
            Id = @"PR1.21",
            Type = @"Field",
            Position = @"PR1.21",
            Name = @"DRG Procedure Determination Status",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0761",
            TableName = @"DRG Procedure Determination Status",
            Description = @"This field contains the status of the use of this particular procedure for the DRG determination. Refer to User-defined Table 0761 - DRG Procedure Determination Status for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (dRGProcedureDeterminationStatus.field.FieldRepetitions != null && dRGProcedureDeterminationStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dRGProcedureDeterminationStatus.Id));
            dRGProcedureDeterminationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(dRGProcedureDeterminationStatus, fieldData);
        }

        return dRGProcedureDeterminationStatus;
    } 
}

internal HL7V26Field dRGProcedureRelevance;

public HL7V26Field DRGProcedureRelevance
{
    get
    {
        if (dRGProcedureRelevance != null)
        {
            return dRGProcedureRelevance;
        }

        dRGProcedureRelevance = new HL7V26Field
        {
            field = message[@"PR1"][22],
            Id = @"PR1.22",
            Type = @"Field",
            Position = @"PR1.22",
            Name = @"DRG Procedure Relevance",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0763",
            TableName = @"DRG Procedure Relevance",
            Description = @"This field contains the relevance of this particular procedure for the DRG determination. Refer toUser-defined Table 0763 - DRG Procedure Relevance for suggested values.",
            Sample = @"",
        };

        // check for repetitions
        if (dRGProcedureRelevance.field.FieldRepetitions != null && dRGProcedureRelevance.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(dRGProcedureRelevance.Id));
            dRGProcedureRelevance.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(dRGProcedureRelevance, fieldData);
        }

        return dRGProcedureRelevance;
    } 
}
    }
}

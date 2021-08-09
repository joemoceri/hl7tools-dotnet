using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentSPM
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SPM"; } }

        public string SegmentId { get { return @"SPM"; } }
        
        public string LongName { get { return @"Specimen"; } }
        
        public string Description { get { return @"The intent of this segment is to describe the characteristics of a specimen. It differs from the intent of the OBR in that the OBR addresses order-specific information. It differs from the SAC segment in that the SAC addresses specimen container attributes. An advantage afforded by a separate specimen segment is that it generalizes the multiple relationships among order(s), results, specimen(s) and specimen container(s)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Id = @"SPM.1",
                            Type = @"Field",
                            Position = @"SPM.1",
                            Name = @"Set ID - SPM",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the sequence number. This field is used to identify SPM segment instances in message structures where the SPM segment repeats.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2",
                            Type = @"Field",
                            Position = @"SPM.2",
                            Name = @"Specimen ID",
                            Length = 855,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EIP",
                            DataTypeName = @"Entity Identifier Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a unique identifier for the specimen as referenced by the Placer application, the Filler application, or both.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.2.1",
                            Type = @"Component",
                            Position = @"SPM.2.1",
                            Name = @"Placer Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the placer system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.2.1.1",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.1",
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
                            Id = @"SPM.2.1.2",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.2",
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
                            Id = @"SPM.2.1.3",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.3",
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
                            Id = @"SPM.2.1.4",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.4",
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
                            Id = @"SPM.2.2",
                            Type = @"Component",
                            Position = @"SPM.2.2",
                            Name = @"Filler Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the filler system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.2.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.1",
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
                            Id = @"SPM.2.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.2",
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
                            Id = @"SPM.2.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.3",
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
                            Id = @"SPM.2.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.4",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3",
                            Type = @"Field",
                            Position = @"SPM.3",
                            Name = @"Specimen Parent IDs",
                            Length = 855,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"EIP",
                            DataTypeName = @"Entity Identifier Pair",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identifiers for the specimen or specimens that contributed to the specimen that is described by the segment instance.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.3.1",
                            Type = @"Component",
                            Position = @"SPM.3.1",
                            Name = @"Placer Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the placer system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.3.1.1",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.1",
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
                            Id = @"SPM.3.1.2",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.2",
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
                            Id = @"SPM.3.1.3",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.3",
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
                            Id = @"SPM.3.1.4",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.4",
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
                            Id = @"SPM.3.2",
                            Type = @"Component",
                            Position = @"SPM.3.2",
                            Name = @"Filler Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the filler system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.3.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.1",
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
                            Id = @"SPM.3.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.2",
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
                            Id = @"SPM.3.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.3",
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
                            Id = @"SPM.3.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.4",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.4",
                            Type = @"Field",
                            Position = @"SPM.4",
                            Name = @"Specimen Type",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0487",
                            TableName = @"Specimen Type",
                            Description = @"This field describes the precise nature of the entity that will be the source material for the observation.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.4.1",
                            Type = @"Component",
                            Position = @"SPM.4.1",
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
                            Id = @"SPM.4.2",
                            Type = @"Component",
                            Position = @"SPM.4.2",
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
                            Id = @"SPM.4.3",
                            Type = @"Component",
                            Position = @"SPM.4.3",
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
                            Id = @"SPM.4.4",
                            Type = @"Component",
                            Position = @"SPM.4.4",
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
                            Id = @"SPM.4.5",
                            Type = @"Component",
                            Position = @"SPM.4.5",
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
                            Id = @"SPM.4.6",
                            Type = @"Component",
                            Position = @"SPM.4.6",
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
                            Id = @"SPM.4.7",
                            Type = @"Component",
                            Position = @"SPM.4.7",
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
                            Id = @"SPM.4.8",
                            Type = @"Component",
                            Position = @"SPM.4.8",
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
                            Id = @"SPM.4.9",
                            Type = @"Component",
                            Position = @"SPM.4.9",
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
                            Id = @"SPM.5",
                            Type = @"Field",
                            Position = @"SPM.5",
                            Name = @"Specimen Type Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0541",
                            TableName = @"Specimen Type Modifier",
                            Description = @"This field contains modifying or qualifying description(s) about the specimen type",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.5.1",
                            Type = @"Component",
                            Position = @"SPM.5.1",
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
                            Id = @"SPM.5.2",
                            Type = @"Component",
                            Position = @"SPM.5.2",
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
                            Id = @"SPM.5.3",
                            Type = @"Component",
                            Position = @"SPM.5.3",
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
                            Id = @"SPM.5.4",
                            Type = @"Component",
                            Position = @"SPM.5.4",
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
                            Id = @"SPM.5.5",
                            Type = @"Component",
                            Position = @"SPM.5.5",
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
                            Id = @"SPM.5.6",
                            Type = @"Component",
                            Position = @"SPM.5.6",
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
                            Id = @"SPM.5.7",
                            Type = @"Component",
                            Position = @"SPM.5.7",
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
                            Id = @"SPM.5.8",
                            Type = @"Component",
                            Position = @"SPM.5.8",
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
                            Id = @"SPM.5.9",
                            Type = @"Component",
                            Position = @"SPM.5.9",
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
                            Id = @"SPM.6",
                            Type = @"Field",
                            Position = @"SPM.6",
                            Name = @"Specimen Additives",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0371",
                            TableName = @"Additive/Preservative",
                            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. These additives may be introduced in order to preserve, maintain or enhance the particular nature or component of the specimen. Refer to HL7 Table 0371 - Additivefor valid values. When multiple additives are introduced and valid individual additive codes exist but a valid value for the combination does not exist, repeating the field with individual values is most appropriate.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.6.1",
                            Type = @"Component",
                            Position = @"SPM.6.1",
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
                            Id = @"SPM.6.2",
                            Type = @"Component",
                            Position = @"SPM.6.2",
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
                            Id = @"SPM.6.3",
                            Type = @"Component",
                            Position = @"SPM.6.3",
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
                            Id = @"SPM.6.4",
                            Type = @"Component",
                            Position = @"SPM.6.4",
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
                            Id = @"SPM.6.5",
                            Type = @"Component",
                            Position = @"SPM.6.5",
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
                            Id = @"SPM.6.6",
                            Type = @"Component",
                            Position = @"SPM.6.6",
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
                            Id = @"SPM.6.7",
                            Type = @"Component",
                            Position = @"SPM.6.7",
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
                            Id = @"SPM.6.8",
                            Type = @"Component",
                            Position = @"SPM.6.8",
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
                            Id = @"SPM.6.9",
                            Type = @"Component",
                            Position = @"SPM.6.9",
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
                            Id = @"SPM.7",
                            Type = @"Field",
                            Position = @"SPM.7",
                            Name = @"Specimen Collection Method",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0488",
                            TableName = @"Specimen Collection Method",
                            Description = @"Describes the procedure or process by which the specimen was collected.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.7.1",
                            Type = @"Component",
                            Position = @"SPM.7.1",
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
                            Id = @"SPM.7.2",
                            Type = @"Component",
                            Position = @"SPM.7.2",
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
                            Id = @"SPM.7.3",
                            Type = @"Component",
                            Position = @"SPM.7.3",
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
                            Id = @"SPM.7.4",
                            Type = @"Component",
                            Position = @"SPM.7.4",
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
                            Id = @"SPM.7.5",
                            Type = @"Component",
                            Position = @"SPM.7.5",
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
                            Id = @"SPM.7.6",
                            Type = @"Component",
                            Position = @"SPM.7.6",
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
                            Id = @"SPM.7.7",
                            Type = @"Component",
                            Position = @"SPM.7.7",
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
                            Id = @"SPM.7.8",
                            Type = @"Component",
                            Position = @"SPM.7.8",
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
                            Id = @"SPM.7.9",
                            Type = @"Component",
                            Position = @"SPM.7.9",
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
                            Id = @"SPM.8",
                            Type = @"Field",
                            Position = @"SPM.8",
                            Name = @"Specimen Source Site",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"specifies the source from which the specimen was obtained. For example, in the case where a liver biopsy is obtained via a percutaneous needle, the source would be liver.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.8.1",
                            Type = @"Component",
                            Position = @"SPM.8.1",
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
                            Id = @"SPM.8.2",
                            Type = @"Component",
                            Position = @"SPM.8.2",
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
                            Id = @"SPM.8.3",
                            Type = @"Component",
                            Position = @"SPM.8.3",
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
                            Id = @"SPM.8.4",
                            Type = @"Component",
                            Position = @"SPM.8.4",
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
                            Id = @"SPM.8.5",
                            Type = @"Component",
                            Position = @"SPM.8.5",
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
                            Id = @"SPM.8.6",
                            Type = @"Component",
                            Position = @"SPM.8.6",
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
                            Id = @"SPM.8.7",
                            Type = @"Component",
                            Position = @"SPM.8.7",
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
                            Id = @"SPM.8.8",
                            Type = @"Component",
                            Position = @"SPM.8.8",
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
                            Id = @"SPM.8.9",
                            Type = @"Component",
                            Position = @"SPM.8.9",
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
                            Id = @"SPM.9",
                            Type = @"Field",
                            Position = @"SPM.9",
                            Name = @"Specimen Source Site Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0542",
                            TableName = @"Specimen Source Type Modifier",
                            Description = @"This field contains modifying or qualifying description(s) about the specimen source site",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.9.1",
                            Type = @"Component",
                            Position = @"SPM.9.1",
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
                            Id = @"SPM.9.2",
                            Type = @"Component",
                            Position = @"SPM.9.2",
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
                            Id = @"SPM.9.3",
                            Type = @"Component",
                            Position = @"SPM.9.3",
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
                            Id = @"SPM.9.4",
                            Type = @"Component",
                            Position = @"SPM.9.4",
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
                            Id = @"SPM.9.5",
                            Type = @"Component",
                            Position = @"SPM.9.5",
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
                            Id = @"SPM.9.6",
                            Type = @"Component",
                            Position = @"SPM.9.6",
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
                            Id = @"SPM.9.7",
                            Type = @"Component",
                            Position = @"SPM.9.7",
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
                            Id = @"SPM.9.8",
                            Type = @"Component",
                            Position = @"SPM.9.8",
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
                            Id = @"SPM.9.9",
                            Type = @"Component",
                            Position = @"SPM.9.9",
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
                            Id = @"SPM.10",
                            Type = @"Field",
                            Position = @"SPM.10",
                            Name = @"Specimen Collection Site",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0543",
                            TableName = @"Specimen Collection Site",
                            Description = @"This field differs from SPM-8-Specimen Source Site in those cases where the source site must be approached via a particular site (e.g., anatomic location). For example, in the case where a liver biopsy is obtained via a percutaneous needle, the collection site would be the point of entry of the needle. For venous blood collected from the left radial vein, the collection site could be ""antecubital fossa"".",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.10.1",
                            Type = @"Component",
                            Position = @"SPM.10.1",
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
                            Id = @"SPM.10.2",
                            Type = @"Component",
                            Position = @"SPM.10.2",
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
                            Id = @"SPM.10.3",
                            Type = @"Component",
                            Position = @"SPM.10.3",
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
                            Id = @"SPM.10.4",
                            Type = @"Component",
                            Position = @"SPM.10.4",
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
                            Id = @"SPM.10.5",
                            Type = @"Component",
                            Position = @"SPM.10.5",
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
                            Id = @"SPM.10.6",
                            Type = @"Component",
                            Position = @"SPM.10.6",
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
                            Id = @"SPM.10.7",
                            Type = @"Component",
                            Position = @"SPM.10.7",
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
                            Id = @"SPM.10.8",
                            Type = @"Component",
                            Position = @"SPM.10.8",
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
                            Id = @"SPM.10.9",
                            Type = @"Component",
                            Position = @"SPM.10.9",
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
                            Id = @"SPM.11",
                            Type = @"Field",
                            Position = @"SPM.11",
                            Name = @"Specimen Role",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0369",
                            TableName = @"Specimen Role",
                            Description = @"This field indicates the role of the sample. Refer to User-defined Table 0369 – Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.

If this field is not populated, then the specimen described has no special, or specific, role other than serving as the focus of the observation.  Such specimens include patient, environmental and other specimens that are intended for analysis.

A grouped specimen consists of identical specimen types from multiple individuals that do not have individual identifiers and upon which the same services will be performed.  If the specimen role value is ""G"" then the Grouped Specimen Count (SPM-13) must be valued with the total number of specimens contained in the group.  

If the specimen role is ""L"", the repetitions of Parent Specimen ID (SPM-4) represent the individual parent specimens that contribute to the pooled specimen.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.11.1",
                            Type = @"Component",
                            Position = @"SPM.11.1",
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
                            Id = @"SPM.11.2",
                            Type = @"Component",
                            Position = @"SPM.11.2",
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
                            Id = @"SPM.11.3",
                            Type = @"Component",
                            Position = @"SPM.11.3",
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
                            Id = @"SPM.11.4",
                            Type = @"Component",
                            Position = @"SPM.11.4",
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
                            Id = @"SPM.11.5",
                            Type = @"Component",
                            Position = @"SPM.11.5",
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
                            Id = @"SPM.11.6",
                            Type = @"Component",
                            Position = @"SPM.11.6",
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
                            Id = @"SPM.11.7",
                            Type = @"Component",
                            Position = @"SPM.11.7",
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
                            Id = @"SPM.11.8",
                            Type = @"Component",
                            Position = @"SPM.11.8",
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
                            Id = @"SPM.11.9",
                            Type = @"Component",
                            Position = @"SPM.11.9",
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
                            Id = @"SPM.12",
                            Type = @"Field",
                            Position = @"SPM.12",
                            Name = @"Specimen Collection Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies the volume or mass of the collected specimen. For laboratory tests, the collection volume is the volume of a specimen. Specifically, units should be expressed in the ISO Standard unit abbreviations (ISO-2955, 1977). This is a results-only field except when the placer or a party has already drawn the specimen. (See Chapter 7 for full details about units.)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.12.1",
                            Type = @"Component",
                            Position = @"SPM.12.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.12.2",
                            Type = @"Component",
                            Position = @"SPM.12.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.12.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.1",
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
                            Id = @"SPM.12.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.2",
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
                            Id = @"SPM.12.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.3",
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
                            Id = @"SPM.12.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.4",
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
                            Id = @"SPM.12.2.5",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.5",
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
                            Id = @"SPM.12.2.6",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.6",
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
                            Id = @"SPM.12.2.7",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.7",
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
                            Id = @"SPM.12.2.8",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.8",
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
                            Id = @"SPM.12.2.9",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.13",
                            Type = @"Field",
                            Position = @"SPM.13",
                            Name = @"Grouped Specimen Count",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field refers to the number of individual specimens of a particular type represented by this instance of a specimen. The use of this field is restricted to specimens upon which all specimen related attributes are identical. This field would only be valued if the specimen role attribute has the value ""G"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.14",
                            Type = @"Field",
                            Position = @"SPM.14",
                            Name = @"Specimen Description",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a text field that allows additional information specifically about the specimen to be sent in the message",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.15",
                            Type = @"Field",
                            Position = @"SPM.15",
                            Name = @"Specimen Handling Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0376",
                            TableName = @"Special Handling Code",
                            Description = @"This describes how the specimen and/or container need to be handled from the time of collection through the initiation of testing. As this field is not required, no assumptions can be made as to meaning when this field is not populated.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.15.1",
                            Type = @"Component",
                            Position = @"SPM.15.1",
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
                            Id = @"SPM.15.2",
                            Type = @"Component",
                            Position = @"SPM.15.2",
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
                            Id = @"SPM.15.3",
                            Type = @"Component",
                            Position = @"SPM.15.3",
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
                            Id = @"SPM.15.4",
                            Type = @"Component",
                            Position = @"SPM.15.4",
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
                            Id = @"SPM.15.5",
                            Type = @"Component",
                            Position = @"SPM.15.5",
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
                            Id = @"SPM.15.6",
                            Type = @"Component",
                            Position = @"SPM.15.6",
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
                            Id = @"SPM.15.7",
                            Type = @"Component",
                            Position = @"SPM.15.7",
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
                            Id = @"SPM.15.8",
                            Type = @"Component",
                            Position = @"SPM.15.8",
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
                            Id = @"SPM.15.9",
                            Type = @"Component",
                            Position = @"SPM.15.9",
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
                            Id = @"SPM.16",
                            Type = @"Field",
                            Position = @"SPM.16",
                            Name = @"Specimen Risk Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0489",
                            TableName = @"Risk Codes",
                            Description = @"This field contains any known or suspected specimen hazards, e.g., exceptionally infectious agent or blood from a hepatitis patient. Either code and/or text may be absent. However, the code is always placed in the first component position and any free text in the second component. Thus, a component delimiter must precede free text without a code. Refer to User-defined Table 0489 - Risk Codes for suggested entries",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.16.1",
                            Type = @"Component",
                            Position = @"SPM.16.1",
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
                            Id = @"SPM.16.2",
                            Type = @"Component",
                            Position = @"SPM.16.2",
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
                            Id = @"SPM.16.3",
                            Type = @"Component",
                            Position = @"SPM.16.3",
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
                            Id = @"SPM.16.4",
                            Type = @"Component",
                            Position = @"SPM.16.4",
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
                            Id = @"SPM.16.5",
                            Type = @"Component",
                            Position = @"SPM.16.5",
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
                            Id = @"SPM.16.6",
                            Type = @"Component",
                            Position = @"SPM.16.6",
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
                            Id = @"SPM.16.7",
                            Type = @"Component",
                            Position = @"SPM.16.7",
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
                            Id = @"SPM.16.8",
                            Type = @"Component",
                            Position = @"SPM.16.8",
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
                            Id = @"SPM.16.9",
                            Type = @"Component",
                            Position = @"SPM.16.9",
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
                            Id = @"SPM.17",
                            Type = @"Field",
                            Position = @"SPM.17",
                            Name = @"Specimen Collection Date/Time",
                            Length = 49,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/Time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"The date and time when the specimen was acquired from the source. The use of the Date Range data type allows for description of specimens collected over a period of time, for example, 24-hour urine collection. For specimens collected at a point in time, only the first component (start date/time) will be populated.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.17.1",
                            Type = @"Component",
                            Position = @"SPM.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.17.2",
                            Type = @"Component",
                            Position = @"SPM.17.2",
                            Name = @"Range End Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the DTM (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.18",
                            Type = @"Field",
                            Position = @"SPM.18",
                            Name = @"Specimen Received Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The specimen received date/time is the time that the specimen is received at the diagnostic service. The actual time that is recorded is based on how specimen receipt is managed and may correspond to the time the sample is logged in. This is fundamentally different from SPM-17 Specimen Collection date/time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.19",
                            Type = @"Field",
                            Position = @"SPM.19",
                            Name = @"Specimen Expiration Date/Time",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the date and time the specimen can no longer be used for the purpose implied by the order. For example, in the Blood Banking environment the specimen can no longer be used for pre-transfusion compatibility testing. The specimen segment will include an SPM-21-Specimen Reject Reason of 'EX' indicating 'Expired' for message instances created after this date and time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.20",
                            Type = @"Field",
                            Position = @"SPM.20",
                            Name = @"Specimen Availability",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This describes whether the specimen, as it exists, is currently available to use in an analysis. Refer to HL7 Table 0136 Yes/No Indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.21",
                            Type = @"Field",
                            Position = @"SPM.21",
                            Name = @"Specimen Reject Reason",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0490",
                            TableName = @"Specimen Reject Reason",
                            Description = @"This describes one or more reasons the specimen is rejected for the specified observation/result/analysis. Refer to HL7 Table 0490 - Specimen Reject Reason for valid values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.21.1",
                            Type = @"Component",
                            Position = @"SPM.21.1",
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
                            Id = @"SPM.21.2",
                            Type = @"Component",
                            Position = @"SPM.21.2",
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
                            Id = @"SPM.21.3",
                            Type = @"Component",
                            Position = @"SPM.21.3",
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
                            Id = @"SPM.21.4",
                            Type = @"Component",
                            Position = @"SPM.21.4",
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
                            Id = @"SPM.21.5",
                            Type = @"Component",
                            Position = @"SPM.21.5",
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
                            Id = @"SPM.21.6",
                            Type = @"Component",
                            Position = @"SPM.21.6",
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
                            Id = @"SPM.21.7",
                            Type = @"Component",
                            Position = @"SPM.21.7",
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
                            Id = @"SPM.21.8",
                            Type = @"Component",
                            Position = @"SPM.21.8",
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
                            Id = @"SPM.21.9",
                            Type = @"Component",
                            Position = @"SPM.21.9",
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
                            Id = @"SPM.22",
                            Type = @"Field",
                            Position = @"SPM.22",
                            Name = @"Specimen Quality",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0491",
                            TableName = @"Specimen Quality",
                            Description = @"The degree or grade of excellence of the specimen at receipt. The filler populates this attribute. Refer to User-defined Table 0491 - Specimen Quality for suggested entries.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.22.1",
                            Type = @"Component",
                            Position = @"SPM.22.1",
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
                            Id = @"SPM.22.2",
                            Type = @"Component",
                            Position = @"SPM.22.2",
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
                            Id = @"SPM.22.3",
                            Type = @"Component",
                            Position = @"SPM.22.3",
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
                            Id = @"SPM.22.4",
                            Type = @"Component",
                            Position = @"SPM.22.4",
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
                            Id = @"SPM.22.5",
                            Type = @"Component",
                            Position = @"SPM.22.5",
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
                            Id = @"SPM.22.6",
                            Type = @"Component",
                            Position = @"SPM.22.6",
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
                            Id = @"SPM.22.7",
                            Type = @"Component",
                            Position = @"SPM.22.7",
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
                            Id = @"SPM.22.8",
                            Type = @"Component",
                            Position = @"SPM.22.8",
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
                            Id = @"SPM.22.9",
                            Type = @"Component",
                            Position = @"SPM.22.9",
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
                            Id = @"SPM.23",
                            Type = @"Field",
                            Position = @"SPM.23",
                            Name = @"Specimen Appropriateness",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0492",
                            TableName = @"Specimen Appropriateness",
                            Description = @"The suitability of the specimen for the particular planned use as determined by the filler. Refer to User-defined Table 0492 - Specimen Appropriateness for suggested entries.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.23.1",
                            Type = @"Component",
                            Position = @"SPM.23.1",
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
                            Id = @"SPM.23.2",
                            Type = @"Component",
                            Position = @"SPM.23.2",
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
                            Id = @"SPM.23.3",
                            Type = @"Component",
                            Position = @"SPM.23.3",
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
                            Id = @"SPM.23.4",
                            Type = @"Component",
                            Position = @"SPM.23.4",
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
                            Id = @"SPM.23.5",
                            Type = @"Component",
                            Position = @"SPM.23.5",
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
                            Id = @"SPM.23.6",
                            Type = @"Component",
                            Position = @"SPM.23.6",
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
                            Id = @"SPM.23.7",
                            Type = @"Component",
                            Position = @"SPM.23.7",
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
                            Id = @"SPM.23.8",
                            Type = @"Component",
                            Position = @"SPM.23.8",
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
                            Id = @"SPM.23.9",
                            Type = @"Component",
                            Position = @"SPM.23.9",
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
                            Id = @"SPM.24",
                            Type = @"Field",
                            Position = @"SPM.24",
                            Name = @"Specimen Condition",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0493",
                            TableName = @"Specimen Condition",
                            Description = @"A mode or state of being that describes the nature of the specimen. Refer to User-defined Table 0493 - Specimen Condition for suggested entries.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.24.1",
                            Type = @"Component",
                            Position = @"SPM.24.1",
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
                            Id = @"SPM.24.2",
                            Type = @"Component",
                            Position = @"SPM.24.2",
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
                            Id = @"SPM.24.3",
                            Type = @"Component",
                            Position = @"SPM.24.3",
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
                            Id = @"SPM.24.4",
                            Type = @"Component",
                            Position = @"SPM.24.4",
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
                            Id = @"SPM.24.5",
                            Type = @"Component",
                            Position = @"SPM.24.5",
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
                            Id = @"SPM.24.6",
                            Type = @"Component",
                            Position = @"SPM.24.6",
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
                            Id = @"SPM.24.7",
                            Type = @"Component",
                            Position = @"SPM.24.7",
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
                            Id = @"SPM.24.8",
                            Type = @"Component",
                            Position = @"SPM.24.8",
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
                            Id = @"SPM.24.9",
                            Type = @"Component",
                            Position = @"SPM.24.9",
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
                            Id = @"SPM.25",
                            Type = @"Field",
                            Position = @"SPM.25",
                            Name = @"Specimen Current Quantity",
                            Length = 722,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This attributes contains the amount of specimen that currently exists or is available for use in further testing.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.25.1",
                            Type = @"Component",
                            Position = @"SPM.25.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.25.2",
                            Type = @"Component",
                            Position = @"SPM.25.2",
                            Name = @"Units",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.25.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.1",
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
                            Id = @"SPM.25.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.2",
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
                            Id = @"SPM.25.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.3",
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
                            Id = @"SPM.25.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.4",
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
                            Id = @"SPM.25.2.5",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.5",
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
                            Id = @"SPM.25.2.6",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.6",
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
                            Id = @"SPM.25.2.7",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.7",
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
                            Id = @"SPM.25.2.8",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.8",
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
                            Id = @"SPM.25.2.9",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.26",
                            Type = @"Field",
                            Position = @"SPM.26",
                            Name = @"Number of Specimen Containers",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the number of containers for a given sample. For sample receipt verification purposes; may be different from the total number of samples that accompany the order.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.27",
                            Type = @"Field",
                            Position = @"SPM.27",
                            Name = @"Container Type",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The container in or on which a specimen is transported.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.27.1",
                            Type = @"Component",
                            Position = @"SPM.27.1",
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
                            Id = @"SPM.27.2",
                            Type = @"Component",
                            Position = @"SPM.27.2",
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
                            Id = @"SPM.27.3",
                            Type = @"Component",
                            Position = @"SPM.27.3",
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
                            Id = @"SPM.27.4",
                            Type = @"Component",
                            Position = @"SPM.27.4",
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
                            Id = @"SPM.27.5",
                            Type = @"Component",
                            Position = @"SPM.27.5",
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
                            Id = @"SPM.27.6",
                            Type = @"Component",
                            Position = @"SPM.27.6",
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
                            Id = @"SPM.27.7",
                            Type = @"Component",
                            Position = @"SPM.27.7",
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
                            Id = @"SPM.27.8",
                            Type = @"Component",
                            Position = @"SPM.27.8",
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
                            Id = @"SPM.27.9",
                            Type = @"Component",
                            Position = @"SPM.27.9",
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
                            Id = @"SPM.28",
                            Type = @"Field",
                            Position = @"SPM.28",
                            Name = @"Container Condition",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0544",
                            TableName = @"Container Condition",
                            Description = @"In chain of custody cases where specimens are moved from lab to lab, the status of the container that the specimen is shipped in must be recorded at each receipt. If the container is compromised in any way (seal broken, container cracked or leaking, etc) then this needs to be recorded for legal reasons.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.28.1",
                            Type = @"Component",
                            Position = @"SPM.28.1",
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
                            Id = @"SPM.28.2",
                            Type = @"Component",
                            Position = @"SPM.28.2",
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
                            Id = @"SPM.28.3",
                            Type = @"Component",
                            Position = @"SPM.28.3",
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
                            Id = @"SPM.28.4",
                            Type = @"Component",
                            Position = @"SPM.28.4",
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
                            Id = @"SPM.28.5",
                            Type = @"Component",
                            Position = @"SPM.28.5",
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
                            Id = @"SPM.28.6",
                            Type = @"Component",
                            Position = @"SPM.28.6",
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
                            Id = @"SPM.28.7",
                            Type = @"Component",
                            Position = @"SPM.28.7",
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
                            Id = @"SPM.28.8",
                            Type = @"Component",
                            Position = @"SPM.28.8",
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
                            Id = @"SPM.28.9",
                            Type = @"Component",
                            Position = @"SPM.28.9",
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
                            Id = @"SPM.29",
                            Type = @"Field",
                            Position = @"SPM.29",
                            Name = @"Specimen Child Role",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0494",
                            TableName = @"Specimen Child Role",
                            Description = @"For child specimens, this field identifies the relationship between this specimen and the parent specimen. If this field is populated, then SPM-3-Specimen Parent ID must be populated. This field differs from SPM-15-Specimen Role in that this field refers to the role of this specimen relative to a parent role rather than the role of this specimen to the ordered service.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.29.1",
                            Type = @"Component",
                            Position = @"SPM.29.1",
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
                            Id = @"SPM.29.2",
                            Type = @"Component",
                            Position = @"SPM.29.2",
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
                            Id = @"SPM.29.3",
                            Type = @"Component",
                            Position = @"SPM.29.3",
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
                            Id = @"SPM.29.4",
                            Type = @"Component",
                            Position = @"SPM.29.4",
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
                            Id = @"SPM.29.5",
                            Type = @"Component",
                            Position = @"SPM.29.5",
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
                            Id = @"SPM.29.6",
                            Type = @"Component",
                            Position = @"SPM.29.6",
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
                            Id = @"SPM.29.7",
                            Type = @"Component",
                            Position = @"SPM.29.7",
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
                            Id = @"SPM.29.8",
                            Type = @"Component",
                            Position = @"SPM.29.8",
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
                            Id = @"SPM.29.9",
                            Type = @"Component",
                            Position = @"SPM.29.9",
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
                        };
            }
        }

        public HL7V26SegmentSPM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field setIDSPM;

public HL7V26Field SetIDSPM
{
    get
    {
        if (setIDSPM != null)
        {
            return setIDSPM;
        }

        setIDSPM = new HL7V26Field
        {
            field = message[@"SPM"][1],
            Id = @"SPM.1",
            Type = @"Field",
            Position = @"SPM.1",
            Name = @"Set ID - SPM",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the sequence number. This field is used to identify SPM segment instances in message structures where the SPM segment repeats.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDSPM.field.FieldRepetitions != null && setIDSPM.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDSPM.Id));
            setIDSPM.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(setIDSPM, fieldData);
        }

        return setIDSPM;
    } 
}

internal HL7V26Field specimenID;

public HL7V26Field SpecimenID
{
    get
    {
        if (specimenID != null)
        {
            return specimenID;
        }

        specimenID = new HL7V26Field
        {
            field = message[@"SPM"][2],
            Id = @"SPM.2",
            Type = @"Field",
            Position = @"SPM.2",
            Name = @"Specimen ID",
            Length = 855,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EIP",
            DataTypeName = @"Entity Identifier Pair",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier for the specimen as referenced by the Placer application, the Filler application, or both.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenID.field.FieldRepetitions != null && specimenID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenID.Id));
            specimenID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenID, fieldData);
        }

        return specimenID;
    } 
}

internal HL7V26Field specimenParentIDs;

public HL7V26Field SpecimenParentIDs
{
    get
    {
        if (specimenParentIDs != null)
        {
            return specimenParentIDs;
        }

        specimenParentIDs = new HL7V26Field
        {
            field = message[@"SPM"][3],
            Id = @"SPM.3",
            Type = @"Field",
            Position = @"SPM.3",
            Name = @"Specimen Parent IDs",
            Length = 855,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EIP",
            DataTypeName = @"Entity Identifier Pair",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifiers for the specimen or specimens that contributed to the specimen that is described by the segment instance.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenParentIDs.field.FieldRepetitions != null && specimenParentIDs.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenParentIDs.Id));
            specimenParentIDs.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenParentIDs, fieldData);
        }

        return specimenParentIDs;
    } 
}

internal HL7V26Field specimenType;

public HL7V26Field SpecimenType
{
    get
    {
        if (specimenType != null)
        {
            return specimenType;
        }

        specimenType = new HL7V26Field
        {
            field = message[@"SPM"][4],
            Id = @"SPM.4",
            Type = @"Field",
            Position = @"SPM.4",
            Name = @"Specimen Type",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0487",
            TableName = @"Specimen Type",
            Description = @"This field describes the precise nature of the entity that will be the source material for the observation.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenType.field.FieldRepetitions != null && specimenType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenType.Id));
            specimenType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenType, fieldData);
        }

        return specimenType;
    } 
}

internal HL7V26Field specimenTypeModifier;

public HL7V26Field SpecimenTypeModifier
{
    get
    {
        if (specimenTypeModifier != null)
        {
            return specimenTypeModifier;
        }

        specimenTypeModifier = new HL7V26Field
        {
            field = message[@"SPM"][5],
            Id = @"SPM.5",
            Type = @"Field",
            Position = @"SPM.5",
            Name = @"Specimen Type Modifier",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0541",
            TableName = @"Specimen Type Modifier",
            Description = @"This field contains modifying or qualifying description(s) about the specimen type",
            Sample = @"",
        };

        // check for repetitions
        if (specimenTypeModifier.field.FieldRepetitions != null && specimenTypeModifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenTypeModifier.Id));
            specimenTypeModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenTypeModifier, fieldData);
        }

        return specimenTypeModifier;
    } 
}

internal HL7V26Field specimenAdditives;

public HL7V26Field SpecimenAdditives
{
    get
    {
        if (specimenAdditives != null)
        {
            return specimenAdditives;
        }

        specimenAdditives = new HL7V26Field
        {
            field = message[@"SPM"][6],
            Id = @"SPM.6",
            Type = @"Field",
            Position = @"SPM.6",
            Name = @"Specimen Additives",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0371",
            TableName = @"Additive/Preservative",
            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. These additives may be introduced in order to preserve, maintain or enhance the particular nature or component of the specimen. Refer to HL7 Table 0371 - Additivefor valid values. When multiple additives are introduced and valid individual additive codes exist but a valid value for the combination does not exist, repeating the field with individual values is most appropriate.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenAdditives.field.FieldRepetitions != null && specimenAdditives.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenAdditives.Id));
            specimenAdditives.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenAdditives, fieldData);
        }

        return specimenAdditives;
    } 
}

internal HL7V26Field specimenCollectionMethod;

public HL7V26Field SpecimenCollectionMethod
{
    get
    {
        if (specimenCollectionMethod != null)
        {
            return specimenCollectionMethod;
        }

        specimenCollectionMethod = new HL7V26Field
        {
            field = message[@"SPM"][7],
            Id = @"SPM.7",
            Type = @"Field",
            Position = @"SPM.7",
            Name = @"Specimen Collection Method",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0488",
            TableName = @"Specimen Collection Method",
            Description = @"Describes the procedure or process by which the specimen was collected.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCollectionMethod.field.FieldRepetitions != null && specimenCollectionMethod.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCollectionMethod.Id));
            specimenCollectionMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCollectionMethod, fieldData);
        }

        return specimenCollectionMethod;
    } 
}

internal HL7V26Field specimenSourceSite;

public HL7V26Field SpecimenSourceSite
{
    get
    {
        if (specimenSourceSite != null)
        {
            return specimenSourceSite;
        }

        specimenSourceSite = new HL7V26Field
        {
            field = message[@"SPM"][8],
            Id = @"SPM.8",
            Type = @"Field",
            Position = @"SPM.8",
            Name = @"Specimen Source Site",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"specifies the source from which the specimen was obtained. For example, in the case where a liver biopsy is obtained via a percutaneous needle, the source would be liver.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenSourceSite.field.FieldRepetitions != null && specimenSourceSite.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenSourceSite.Id));
            specimenSourceSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenSourceSite, fieldData);
        }

        return specimenSourceSite;
    } 
}

internal HL7V26Field specimenSourceSiteModifier;

public HL7V26Field SpecimenSourceSiteModifier
{
    get
    {
        if (specimenSourceSiteModifier != null)
        {
            return specimenSourceSiteModifier;
        }

        specimenSourceSiteModifier = new HL7V26Field
        {
            field = message[@"SPM"][9],
            Id = @"SPM.9",
            Type = @"Field",
            Position = @"SPM.9",
            Name = @"Specimen Source Site Modifier",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0542",
            TableName = @"Specimen Source Type Modifier",
            Description = @"This field contains modifying or qualifying description(s) about the specimen source site",
            Sample = @"",
        };

        // check for repetitions
        if (specimenSourceSiteModifier.field.FieldRepetitions != null && specimenSourceSiteModifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenSourceSiteModifier.Id));
            specimenSourceSiteModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenSourceSiteModifier, fieldData);
        }

        return specimenSourceSiteModifier;
    } 
}

internal HL7V26Field specimenCollectionSite;

public HL7V26Field SpecimenCollectionSite
{
    get
    {
        if (specimenCollectionSite != null)
        {
            return specimenCollectionSite;
        }

        specimenCollectionSite = new HL7V26Field
        {
            field = message[@"SPM"][10],
            Id = @"SPM.10",
            Type = @"Field",
            Position = @"SPM.10",
            Name = @"Specimen Collection Site",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0543",
            TableName = @"Specimen Collection Site",
            Description = @"This field differs from SPM-8-Specimen Source Site in those cases where the source site must be approached via a particular site (e.g., anatomic location). For example, in the case where a liver biopsy is obtained via a percutaneous needle, the collection site would be the point of entry of the needle. For venous blood collected from the left radial vein, the collection site could be ""antecubital fossa"".",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCollectionSite.field.FieldRepetitions != null && specimenCollectionSite.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCollectionSite.Id));
            specimenCollectionSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCollectionSite, fieldData);
        }

        return specimenCollectionSite;
    } 
}

internal HL7V26Field specimenRole;

public HL7V26Field SpecimenRole
{
    get
    {
        if (specimenRole != null)
        {
            return specimenRole;
        }

        specimenRole = new HL7V26Field
        {
            field = message[@"SPM"][11],
            Id = @"SPM.11",
            Type = @"Field",
            Position = @"SPM.11",
            Name = @"Specimen Role",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0369",
            TableName = @"Specimen Role",
            Description = @"This field indicates the role of the sample. Refer to User-defined Table 0369 – Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.

If this field is not populated, then the specimen described has no special, or specific, role other than serving as the focus of the observation.  Such specimens include patient, environmental and other specimens that are intended for analysis.

A grouped specimen consists of identical specimen types from multiple individuals that do not have individual identifiers and upon which the same services will be performed.  If the specimen role value is ""G"" then the Grouped Specimen Count (SPM-13) must be valued with the total number of specimens contained in the group.  

If the specimen role is ""L"", the repetitions of Parent Specimen ID (SPM-4) represent the individual parent specimens that contribute to the pooled specimen.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenRole.field.FieldRepetitions != null && specimenRole.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenRole.Id));
            specimenRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenRole, fieldData);
        }

        return specimenRole;
    } 
}

internal HL7V26Field specimenCollectionAmount;

public HL7V26Field SpecimenCollectionAmount
{
    get
    {
        if (specimenCollectionAmount != null)
        {
            return specimenCollectionAmount;
        }

        specimenCollectionAmount = new HL7V26Field
        {
            field = message[@"SPM"][12],
            Id = @"SPM.12",
            Type = @"Field",
            Position = @"SPM.12",
            Name = @"Specimen Collection Amount",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the volume or mass of the collected specimen. For laboratory tests, the collection volume is the volume of a specimen. Specifically, units should be expressed in the ISO Standard unit abbreviations (ISO-2955, 1977). This is a results-only field except when the placer or a party has already drawn the specimen. (See Chapter 7 for full details about units.)",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCollectionAmount.field.FieldRepetitions != null && specimenCollectionAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCollectionAmount.Id));
            specimenCollectionAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCollectionAmount, fieldData);
        }

        return specimenCollectionAmount;
    } 
}

internal HL7V26Field groupedSpecimenCount;

public HL7V26Field GroupedSpecimenCount
{
    get
    {
        if (groupedSpecimenCount != null)
        {
            return groupedSpecimenCount;
        }

        groupedSpecimenCount = new HL7V26Field
        {
            field = message[@"SPM"][13],
            Id = @"SPM.13",
            Type = @"Field",
            Position = @"SPM.13",
            Name = @"Grouped Specimen Count",
            Length = 6,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field refers to the number of individual specimens of a particular type represented by this instance of a specimen. The use of this field is restricted to specimens upon which all specimen related attributes are identical. This field would only be valued if the specimen role attribute has the value ""G"".",
            Sample = @"",
        };

        // check for repetitions
        if (groupedSpecimenCount.field.FieldRepetitions != null && groupedSpecimenCount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(groupedSpecimenCount.Id));
            groupedSpecimenCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(groupedSpecimenCount, fieldData);
        }

        return groupedSpecimenCount;
    } 
}

internal HL7V26Field specimenDescription;

public HL7V26Field SpecimenDescription
{
    get
    {
        if (specimenDescription != null)
        {
            return specimenDescription;
        }

        specimenDescription = new HL7V26Field
        {
            field = message[@"SPM"][14],
            Id = @"SPM.14",
            Type = @"Field",
            Position = @"SPM.14",
            Name = @"Specimen Description",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This is a text field that allows additional information specifically about the specimen to be sent in the message",
            Sample = @"",
        };

        // check for repetitions
        if (specimenDescription.field.FieldRepetitions != null && specimenDescription.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenDescription.Id));
            specimenDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenDescription, fieldData);
        }

        return specimenDescription;
    } 
}

internal HL7V26Field specimenHandlingCode;

public HL7V26Field SpecimenHandlingCode
{
    get
    {
        if (specimenHandlingCode != null)
        {
            return specimenHandlingCode;
        }

        specimenHandlingCode = new HL7V26Field
        {
            field = message[@"SPM"][15],
            Id = @"SPM.15",
            Type = @"Field",
            Position = @"SPM.15",
            Name = @"Specimen Handling Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0376",
            TableName = @"Special Handling Code",
            Description = @"This describes how the specimen and/or container need to be handled from the time of collection through the initiation of testing. As this field is not required, no assumptions can be made as to meaning when this field is not populated.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenHandlingCode.field.FieldRepetitions != null && specimenHandlingCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenHandlingCode.Id));
            specimenHandlingCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenHandlingCode, fieldData);
        }

        return specimenHandlingCode;
    } 
}

internal HL7V26Field specimenRiskCode;

public HL7V26Field SpecimenRiskCode
{
    get
    {
        if (specimenRiskCode != null)
        {
            return specimenRiskCode;
        }

        specimenRiskCode = new HL7V26Field
        {
            field = message[@"SPM"][16],
            Id = @"SPM.16",
            Type = @"Field",
            Position = @"SPM.16",
            Name = @"Specimen Risk Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0489",
            TableName = @"Risk Codes",
            Description = @"This field contains any known or suspected specimen hazards, e.g., exceptionally infectious agent or blood from a hepatitis patient. Either code and/or text may be absent. However, the code is always placed in the first component position and any free text in the second component. Thus, a component delimiter must precede free text without a code. Refer to User-defined Table 0489 - Risk Codes for suggested entries",
            Sample = @"",
        };

        // check for repetitions
        if (specimenRiskCode.field.FieldRepetitions != null && specimenRiskCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenRiskCode.Id));
            specimenRiskCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenRiskCode, fieldData);
        }

        return specimenRiskCode;
    } 
}

internal HL7V26Field specimenCollectionDateTime;

public HL7V26Field SpecimenCollectionDateTime
{
    get
    {
        if (specimenCollectionDateTime != null)
        {
            return specimenCollectionDateTime;
        }

        specimenCollectionDateTime = new HL7V26Field
        {
            field = message[@"SPM"][17],
            Id = @"SPM.17",
            Type = @"Field",
            Position = @"SPM.17",
            Name = @"Specimen Collection Date/Time",
            Length = 49,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/Time Range",
            TableId = null,
            TableName = null,
            Description = @"The date and time when the specimen was acquired from the source. The use of the Date Range data type allows for description of specimens collected over a period of time, for example, 24-hour urine collection. For specimens collected at a point in time, only the first component (start date/time) will be populated.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCollectionDateTime.field.FieldRepetitions != null && specimenCollectionDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCollectionDateTime.Id));
            specimenCollectionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCollectionDateTime, fieldData);
        }

        return specimenCollectionDateTime;
    } 
}

internal HL7V26Field specimenReceivedDateTime;

public HL7V26Field SpecimenReceivedDateTime
{
    get
    {
        if (specimenReceivedDateTime != null)
        {
            return specimenReceivedDateTime;
        }

        specimenReceivedDateTime = new HL7V26Field
        {
            field = message[@"SPM"][18],
            Id = @"SPM.18",
            Type = @"Field",
            Position = @"SPM.18",
            Name = @"Specimen Received Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"The specimen received date/time is the time that the specimen is received at the diagnostic service. The actual time that is recorded is based on how specimen receipt is managed and may correspond to the time the sample is logged in. This is fundamentally different from SPM-17 Specimen Collection date/time.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenReceivedDateTime.field.FieldRepetitions != null && specimenReceivedDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenReceivedDateTime.Id));
            specimenReceivedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenReceivedDateTime, fieldData);
        }

        return specimenReceivedDateTime;
    } 
}

internal HL7V26Field specimenExpirationDateTime;

public HL7V26Field SpecimenExpirationDateTime
{
    get
    {
        if (specimenExpirationDateTime != null)
        {
            return specimenExpirationDateTime;
        }

        specimenExpirationDateTime = new HL7V26Field
        {
            field = message[@"SPM"][19],
            Id = @"SPM.19",
            Type = @"Field",
            Position = @"SPM.19",
            Name = @"Specimen Expiration Date/Time",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the date and time the specimen can no longer be used for the purpose implied by the order. For example, in the Blood Banking environment the specimen can no longer be used for pre-transfusion compatibility testing. The specimen segment will include an SPM-21-Specimen Reject Reason of 'EX' indicating 'Expired' for message instances created after this date and time.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenExpirationDateTime.field.FieldRepetitions != null && specimenExpirationDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenExpirationDateTime.Id));
            specimenExpirationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenExpirationDateTime, fieldData);
        }

        return specimenExpirationDateTime;
    } 
}

internal HL7V26Field specimenAvailability;

public HL7V26Field SpecimenAvailability
{
    get
    {
        if (specimenAvailability != null)
        {
            return specimenAvailability;
        }

        specimenAvailability = new HL7V26Field
        {
            field = message[@"SPM"][20],
            Id = @"SPM.20",
            Type = @"Field",
            Position = @"SPM.20",
            Name = @"Specimen Availability",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This describes whether the specimen, as it exists, is currently available to use in an analysis. Refer to HL7 Table 0136 Yes/No Indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenAvailability.field.FieldRepetitions != null && specimenAvailability.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenAvailability.Id));
            specimenAvailability.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenAvailability, fieldData);
        }

        return specimenAvailability;
    } 
}

internal HL7V26Field specimenRejectReason;

public HL7V26Field SpecimenRejectReason
{
    get
    {
        if (specimenRejectReason != null)
        {
            return specimenRejectReason;
        }

        specimenRejectReason = new HL7V26Field
        {
            field = message[@"SPM"][21],
            Id = @"SPM.21",
            Type = @"Field",
            Position = @"SPM.21",
            Name = @"Specimen Reject Reason",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0490",
            TableName = @"Specimen Reject Reason",
            Description = @"This describes one or more reasons the specimen is rejected for the specified observation/result/analysis. Refer to HL7 Table 0490 - Specimen Reject Reason for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenRejectReason.field.FieldRepetitions != null && specimenRejectReason.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenRejectReason.Id));
            specimenRejectReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenRejectReason, fieldData);
        }

        return specimenRejectReason;
    } 
}

internal HL7V26Field specimenQuality;

public HL7V26Field SpecimenQuality
{
    get
    {
        if (specimenQuality != null)
        {
            return specimenQuality;
        }

        specimenQuality = new HL7V26Field
        {
            field = message[@"SPM"][22],
            Id = @"SPM.22",
            Type = @"Field",
            Position = @"SPM.22",
            Name = @"Specimen Quality",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0491",
            TableName = @"Specimen Quality",
            Description = @"The degree or grade of excellence of the specimen at receipt. The filler populates this attribute. Refer to User-defined Table 0491 - Specimen Quality for suggested entries.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenQuality.field.FieldRepetitions != null && specimenQuality.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenQuality.Id));
            specimenQuality.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenQuality, fieldData);
        }

        return specimenQuality;
    } 
}

internal HL7V26Field specimenAppropriateness;

public HL7V26Field SpecimenAppropriateness
{
    get
    {
        if (specimenAppropriateness != null)
        {
            return specimenAppropriateness;
        }

        specimenAppropriateness = new HL7V26Field
        {
            field = message[@"SPM"][23],
            Id = @"SPM.23",
            Type = @"Field",
            Position = @"SPM.23",
            Name = @"Specimen Appropriateness",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0492",
            TableName = @"Specimen Appropriateness",
            Description = @"The suitability of the specimen for the particular planned use as determined by the filler. Refer to User-defined Table 0492 - Specimen Appropriateness for suggested entries.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenAppropriateness.field.FieldRepetitions != null && specimenAppropriateness.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenAppropriateness.Id));
            specimenAppropriateness.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenAppropriateness, fieldData);
        }

        return specimenAppropriateness;
    } 
}

internal HL7V26Field specimenCondition;

public HL7V26Field SpecimenCondition
{
    get
    {
        if (specimenCondition != null)
        {
            return specimenCondition;
        }

        specimenCondition = new HL7V26Field
        {
            field = message[@"SPM"][24],
            Id = @"SPM.24",
            Type = @"Field",
            Position = @"SPM.24",
            Name = @"Specimen Condition",
            Length = 705,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0493",
            TableName = @"Specimen Condition",
            Description = @"A mode or state of being that describes the nature of the specimen. Refer to User-defined Table 0493 - Specimen Condition for suggested entries.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCondition.field.FieldRepetitions != null && specimenCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCondition.Id));
            specimenCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCondition, fieldData);
        }

        return specimenCondition;
    } 
}

internal HL7V26Field specimenCurrentQuantity;

public HL7V26Field SpecimenCurrentQuantity
{
    get
    {
        if (specimenCurrentQuantity != null)
        {
            return specimenCurrentQuantity;
        }

        specimenCurrentQuantity = new HL7V26Field
        {
            field = message[@"SPM"][25],
            Id = @"SPM.25",
            Type = @"Field",
            Position = @"SPM.25",
            Name = @"Specimen Current Quantity",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This attributes contains the amount of specimen that currently exists or is available for use in further testing.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenCurrentQuantity.field.FieldRepetitions != null && specimenCurrentQuantity.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenCurrentQuantity.Id));
            specimenCurrentQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenCurrentQuantity, fieldData);
        }

        return specimenCurrentQuantity;
    } 
}

internal HL7V26Field numberofSpecimenContainers;

public HL7V26Field NumberofSpecimenContainers
{
    get
    {
        if (numberofSpecimenContainers != null)
        {
            return numberofSpecimenContainers;
        }

        numberofSpecimenContainers = new HL7V26Field
        {
            field = message[@"SPM"][26],
            Id = @"SPM.26",
            Type = @"Field",
            Position = @"SPM.26",
            Name = @"Number of Specimen Containers",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the number of containers for a given sample. For sample receipt verification purposes; may be different from the total number of samples that accompany the order.",
            Sample = @"",
        };

        // check for repetitions
        if (numberofSpecimenContainers.field.FieldRepetitions != null && numberofSpecimenContainers.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberofSpecimenContainers.Id));
            numberofSpecimenContainers.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(numberofSpecimenContainers, fieldData);
        }

        return numberofSpecimenContainers;
    } 
}

internal HL7V26Field containerType;

public HL7V26Field ContainerType
{
    get
    {
        if (containerType != null)
        {
            return containerType;
        }

        containerType = new HL7V26Field
        {
            field = message[@"SPM"][27],
            Id = @"SPM.27",
            Type = @"Field",
            Position = @"SPM.27",
            Name = @"Container Type",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"The container in or on which a specimen is transported.",
            Sample = @"",
        };

        // check for repetitions
        if (containerType.field.FieldRepetitions != null && containerType.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(containerType.Id));
            containerType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(containerType, fieldData);
        }

        return containerType;
    } 
}

internal HL7V26Field containerCondition;

public HL7V26Field ContainerCondition
{
    get
    {
        if (containerCondition != null)
        {
            return containerCondition;
        }

        containerCondition = new HL7V26Field
        {
            field = message[@"SPM"][28],
            Id = @"SPM.28",
            Type = @"Field",
            Position = @"SPM.28",
            Name = @"Container Condition",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0544",
            TableName = @"Container Condition",
            Description = @"In chain of custody cases where specimens are moved from lab to lab, the status of the container that the specimen is shipped in must be recorded at each receipt. If the container is compromised in any way (seal broken, container cracked or leaking, etc) then this needs to be recorded for legal reasons.",
            Sample = @"",
        };

        // check for repetitions
        if (containerCondition.field.FieldRepetitions != null && containerCondition.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(containerCondition.Id));
            containerCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(containerCondition, fieldData);
        }

        return containerCondition;
    } 
}

internal HL7V26Field specimenChildRole;

public HL7V26Field SpecimenChildRole
{
    get
    {
        if (specimenChildRole != null)
        {
            return specimenChildRole;
        }

        specimenChildRole = new HL7V26Field
        {
            field = message[@"SPM"][29],
            Id = @"SPM.29",
            Type = @"Field",
            Position = @"SPM.29",
            Name = @"Specimen Child Role",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0494",
            TableName = @"Specimen Child Role",
            Description = @"For child specimens, this field identifies the relationship between this specimen and the parent specimen. If this field is populated, then SPM-3-Specimen Parent ID must be populated. This field differs from SPM-15-Specimen Role in that this field refers to the role of this specimen relative to a parent role rather than the role of this specimen to the ordered service.",
            Sample = @"",
        };

        // check for repetitions
        if (specimenChildRole.field.FieldRepetitions != null && specimenChildRole.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(specimenChildRole.Id));
            specimenChildRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(specimenChildRole, fieldData);
        }

        return specimenChildRole;
    } 
}
    }
}

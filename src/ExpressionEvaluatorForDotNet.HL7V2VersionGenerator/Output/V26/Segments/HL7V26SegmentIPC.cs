using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentIPC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IPC"; } }

        public string SegmentId { get { return @"IPC"; } }
        
        public string LongName { get { return @"Imaging Procedure Control Segment"; } }
        
        public string Description { get { return @"The IPC segment contains information about tasks that need to be performed in order to fulfill the request for imaging service. The information includes location, type and instance identification of equipment (acquisition modality) and stages (procedure steps)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Id = @"IPC.1",
                            Type = @"Field",
                            Position = @"IPC.1",
                            Name = @"Accession Identifier",
                            Length = 427,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"A workflow-management IDIS generated number that identifies the Filler Order for an Imaging Service (Imaging Service Request). This identifier corresponds one-to-one to the Order Filler number but is used in internal tracking of the work by the IDIS and in communication between IDIS within the department. It also has specific requirements to assure its compatibility with DICOM. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Imaging Service Request. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0008,0050) that conveys information identical to the component one of this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.1.1",
                            Type = @"Component",
                            Position = @"IPC.1.1",
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
                            Id = @"IPC.1.2",
                            Type = @"Component",
                            Position = @"IPC.1.2",
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
                            Id = @"IPC.1.3",
                            Type = @"Component",
                            Position = @"IPC.1.3",
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
                            Id = @"IPC.1.4",
                            Type = @"Component",
                            Position = @"IPC.1.4",
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
                            Id = @"IPC.2",
                            Type = @"Field",
                            Position = @"IPC.2",
                            Name = @"Requested Procedure ID",
                            Length = 22,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the identifier of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for the imaging service. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the Requested Procedure. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Requested Procedure within the scope of the order (as specified by accession number). This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0001) that conveys information identical to the component one of this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.2.1",
                            Type = @"Component",
                            Position = @"IPC.2.1",
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
                            Id = @"IPC.2.2",
                            Type = @"Component",
                            Position = @"IPC.2.2",
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
                            Id = @"IPC.2.3",
                            Type = @"Component",
                            Position = @"IPC.2.3",
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
                            Id = @"IPC.2.4",
                            Type = @"Component",
                            Position = @"IPC.2.4",
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
                            Id = @"IPC.3",
                            Type = @"Field",
                            Position = @"IPC.3",
                            Name = @"Study Instance UID",
                            Length = 70,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Globally unique identifier assigned by the workflow management IDIS to the Imaging Study under which all images and other DICOM objects produced in the course of the Requested Procedure shall be collected. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Study. A limit of sixty-four (64) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0020,000D) that conveys information identical to component one of this field. The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, ""HD - hierarchic designator""). The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Study Instance UID always identifies the actual filler of an order.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.3.1",
                            Type = @"Component",
                            Position = @"IPC.3.1",
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
                            Id = @"IPC.3.2",
                            Type = @"Component",
                            Position = @"IPC.3.2",
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
                            Id = @"IPC.3.3",
                            Type = @"Component",
                            Position = @"IPC.3.3",
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
                            Id = @"IPC.3.4",
                            Type = @"Component",
                            Position = @"IPC.3.4",
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
                            Id = @"IPC.4",
                            Type = @"Field",
                            Position = @"IPC.4",
                            Name = @"Scheduled Procedure Step ID",
                            Length = 22,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the identifier of a particular Procedure Step (sub-procedure) of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for imaging service. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Procedure Step. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Procedure Step within the scope of the Requested Procedure. This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0009) that conveys information identical to the component one of this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.4.1",
                            Type = @"Component",
                            Position = @"IPC.4.1",
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
                            Id = @"IPC.4.2",
                            Type = @"Component",
                            Position = @"IPC.4.2",
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
                            Id = @"IPC.4.3",
                            Type = @"Component",
                            Position = @"IPC.4.3",
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
                            Id = @"IPC.4.4",
                            Type = @"Component",
                            Position = @"IPC.4.4",
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
                            Id = @"IPC.5",
                            Type = @"Field",
                            Position = @"IPC.5",
                            Name = @"Modality",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The type of equipment requested to acquire data during performance of a Procedure Step. The acquired data will be used to create the images for the Imaging Study corresponding to the Requested Procedure.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.5.1",
                            Type = @"Component",
                            Position = @"IPC.5.1",
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
                            Id = @"IPC.5.2",
                            Type = @"Component",
                            Position = @"IPC.5.2",
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
                            Id = @"IPC.5.3",
                            Type = @"Component",
                            Position = @"IPC.5.3",
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
                            Id = @"IPC.5.4",
                            Type = @"Component",
                            Position = @"IPC.5.4",
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
                            Id = @"IPC.5.5",
                            Type = @"Component",
                            Position = @"IPC.5.5",
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
                            Id = @"IPC.5.6",
                            Type = @"Component",
                            Position = @"IPC.5.6",
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
                            Id = @"IPC.5.7",
                            Type = @"Component",
                            Position = @"IPC.5.7",
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
                            Id = @"IPC.5.8",
                            Type = @"Component",
                            Position = @"IPC.5.8",
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
                            Id = @"IPC.5.9",
                            Type = @"Component",
                            Position = @"IPC.5.9",
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
                            Id = @"IPC.6",
                            Type = @"Field",
                            Position = @"IPC.6",
                            Name = @"Protocol Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"One or more coded entries identifying the protocol according to which the Scheduled Procedure Step shall be performed. Protocol Code(s) may identify particular equipment settings as well as operator's manipulations.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.6.1",
                            Type = @"Component",
                            Position = @"IPC.6.1",
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
                            Id = @"IPC.6.2",
                            Type = @"Component",
                            Position = @"IPC.6.2",
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
                            Id = @"IPC.6.3",
                            Type = @"Component",
                            Position = @"IPC.6.3",
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
                            Id = @"IPC.6.4",
                            Type = @"Component",
                            Position = @"IPC.6.4",
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
                            Id = @"IPC.6.5",
                            Type = @"Component",
                            Position = @"IPC.6.5",
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
                            Id = @"IPC.6.6",
                            Type = @"Component",
                            Position = @"IPC.6.6",
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
                            Id = @"IPC.6.7",
                            Type = @"Component",
                            Position = @"IPC.6.7",
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
                            Id = @"IPC.6.8",
                            Type = @"Component",
                            Position = @"IPC.6.8",
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
                            Id = @"IPC.6.9",
                            Type = @"Component",
                            Position = @"IPC.6.9",
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
                            Id = @"IPC.7",
                            Type = @"Field",
                            Position = @"IPC.7",
                            Name = @"Scheduled Station Name",
                            Length = 22,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the instance of the modality resource being requested for the performance of a particular Scheduled Procedure Step. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the particular piece of equipment. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0010) that conveys information identical to the component one of this field.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.7.1",
                            Type = @"Component",
                            Position = @"IPC.7.1",
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
                            Id = @"IPC.7.2",
                            Type = @"Component",
                            Position = @"IPC.7.2",
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
                            Id = @"IPC.7.3",
                            Type = @"Component",
                            Position = @"IPC.7.3",
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
                            Id = @"IPC.7.4",
                            Type = @"Component",
                            Position = @"IPC.7.4",
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
                            Id = @"IPC.8",
                            Type = @"Field",
                            Position = @"IPC.8",
                            Name = @"Scheduled Procedure Step Location",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field specifies a locally defined physical location of the modality resource being requested for performance of particular Scheduled Procedure Step. Although location is usually defined geographically (such as identification of a campus, building, floor, etc.) it may be used for identification of a pool of equipment (resources) formed by any other means. Values for the field shall be drawn from a locally defined coding scheme.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IPC.8.1",
                            Type = @"Component",
                            Position = @"IPC.8.1",
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
                            Id = @"IPC.8.2",
                            Type = @"Component",
                            Position = @"IPC.8.2",
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
                            Id = @"IPC.8.3",
                            Type = @"Component",
                            Position = @"IPC.8.3",
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
                            Id = @"IPC.8.4",
                            Type = @"Component",
                            Position = @"IPC.8.4",
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
                            Id = @"IPC.8.5",
                            Type = @"Component",
                            Position = @"IPC.8.5",
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
                            Id = @"IPC.8.6",
                            Type = @"Component",
                            Position = @"IPC.8.6",
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
                            Id = @"IPC.8.7",
                            Type = @"Component",
                            Position = @"IPC.8.7",
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
                            Id = @"IPC.8.8",
                            Type = @"Component",
                            Position = @"IPC.8.8",
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
                            Id = @"IPC.8.9",
                            Type = @"Component",
                            Position = @"IPC.8.9",
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
                            Id = @"IPC.9",
                            Type = @"Field",
                            Position = @"IPC.9",
                            Name = @"Scheduled Station AE Title",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the Application Entity Title of the modality resource being requested for performance of a particular Scheduled Procedure Step. Application Entity Title is the identifier that identifies an instance of DICOM-compatible equipment for the purpose of addressing during communication. See DICOM Standard, Part 3 for further details on the DICOM Attribute (0040,0001) that conveys equivalent information. A limit of sixteen (16) characters is required to allow compatibility with DICOM.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentIPC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field accessionIdentifier;

public HL7V26Field AccessionIdentifier
{
    get
    {
        if (accessionIdentifier != null)
        {
            return accessionIdentifier;
        }

        accessionIdentifier = new HL7V26Field
        {
            field = message[@"IPC"][1],
            Id = @"IPC.1",
            Type = @"Field",
            Position = @"IPC.1",
            Name = @"Accession Identifier",
            Length = 427,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"A workflow-management IDIS generated number that identifies the Filler Order for an Imaging Service (Imaging Service Request). This identifier corresponds one-to-one to the Order Filler number but is used in internal tracking of the work by the IDIS and in communication between IDIS within the department. It also has specific requirements to assure its compatibility with DICOM. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Imaging Service Request. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0008,0050) that conveys information identical to the component one of this field.",
            Sample = @"",
        };

        // check for repetitions
        if (accessionIdentifier.field.FieldRepetitions != null && accessionIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(accessionIdentifier.Id));
            accessionIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(accessionIdentifier, fieldData);
        }

        return accessionIdentifier;
    } 
}

internal HL7V26Field requestedProcedureID;

public HL7V26Field RequestedProcedureID
{
    get
    {
        if (requestedProcedureID != null)
        {
            return requestedProcedureID;
        }

        requestedProcedureID = new HL7V26Field
        {
            field = message[@"IPC"][2],
            Id = @"IPC.2",
            Type = @"Field",
            Position = @"IPC.2",
            Name = @"Requested Procedure ID",
            Length = 22,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for the imaging service. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the Requested Procedure. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Requested Procedure within the scope of the order (as specified by accession number). This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0001) that conveys information identical to the component one of this field.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedProcedureID.field.FieldRepetitions != null && requestedProcedureID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedProcedureID.Id));
            requestedProcedureID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(requestedProcedureID, fieldData);
        }

        return requestedProcedureID;
    } 
}

internal HL7V26Field studyInstanceUID;

public HL7V26Field StudyInstanceUID
{
    get
    {
        if (studyInstanceUID != null)
        {
            return studyInstanceUID;
        }

        studyInstanceUID = new HL7V26Field
        {
            field = message[@"IPC"][3],
            Id = @"IPC.3",
            Type = @"Field",
            Position = @"IPC.3",
            Name = @"Study Instance UID",
            Length = 70,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Globally unique identifier assigned by the workflow management IDIS to the Imaging Study under which all images and other DICOM objects produced in the course of the Requested Procedure shall be collected. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Study. A limit of sixty-four (64) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0020,000D) that conveys information identical to component one of this field. The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type (see section 2.A.36, ""HD - hierarchic designator""). The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Study Instance UID always identifies the actual filler of an order.",
            Sample = @"",
        };

        // check for repetitions
        if (studyInstanceUID.field.FieldRepetitions != null && studyInstanceUID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(studyInstanceUID.Id));
            studyInstanceUID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(studyInstanceUID, fieldData);
        }

        return studyInstanceUID;
    } 
}

internal HL7V26Field scheduledProcedureStepID;

public HL7V26Field ScheduledProcedureStepID
{
    get
    {
        if (scheduledProcedureStepID != null)
        {
            return scheduledProcedureStepID;
        }

        scheduledProcedureStepID = new HL7V26Field
        {
            field = message[@"IPC"][4],
            Id = @"IPC.4",
            Type = @"Field",
            Position = @"IPC.4",
            Name = @"Scheduled Procedure Step ID",
            Length = 22,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of a particular Procedure Step (sub-procedure) of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for imaging service. It is a case of the Entity Identifier data type (section 2.A.28). Its first component is a string that identifies the Procedure Step. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Procedure Step within the scope of the Requested Procedure. This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0009) that conveys information identical to the component one of this field.",
            Sample = @"",
        };

        // check for repetitions
        if (scheduledProcedureStepID.field.FieldRepetitions != null && scheduledProcedureStepID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(scheduledProcedureStepID.Id));
            scheduledProcedureStepID.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(scheduledProcedureStepID, fieldData);
        }

        return scheduledProcedureStepID;
    } 
}

internal HL7V26Field modality;

public HL7V26Field Modality
{
    get
    {
        if (modality != null)
        {
            return modality;
        }

        modality = new HL7V26Field
        {
            field = message[@"IPC"][5],
            Id = @"IPC.5",
            Type = @"Field",
            Position = @"IPC.5",
            Name = @"Modality",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"The type of equipment requested to acquire data during performance of a Procedure Step. The acquired data will be used to create the images for the Imaging Study corresponding to the Requested Procedure.",
            Sample = @"",
        };

        // check for repetitions
        if (modality.field.FieldRepetitions != null && modality.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(modality.Id));
            modality.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(modality, fieldData);
        }

        return modality;
    } 
}

internal HL7V26Field protocolCode;

public HL7V26Field ProtocolCode
{
    get
    {
        if (protocolCode != null)
        {
            return protocolCode;
        }

        protocolCode = new HL7V26Field
        {
            field = message[@"IPC"][6],
            Id = @"IPC.6",
            Type = @"Field",
            Position = @"IPC.6",
            Name = @"Protocol Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"One or more coded entries identifying the protocol according to which the Scheduled Procedure Step shall be performed. Protocol Code(s) may identify particular equipment settings as well as operator's manipulations.",
            Sample = @"",
        };

        // check for repetitions
        if (protocolCode.field.FieldRepetitions != null && protocolCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(protocolCode.Id));
            protocolCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(protocolCode, fieldData);
        }

        return protocolCode;
    } 
}

internal HL7V26Field scheduledStationName;

public HL7V26Field ScheduledStationName
{
    get
    {
        if (scheduledStationName != null)
        {
            return scheduledStationName;
        }

        scheduledStationName = new HL7V26Field
        {
            field = message[@"IPC"][7],
            Id = @"IPC.7",
            Type = @"Field",
            Position = @"IPC.7",
            Name = @"Scheduled Station Name",
            Length = 22,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the instance of the modality resource being requested for the performance of a particular Scheduled Procedure Step. It is a case of the Entity Identifier data type (section 2.A.28). The first component of this field is a string that identifies the particular piece of equipment. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0010) that conveys information identical to the component one of this field.",
            Sample = @"",
        };

        // check for repetitions
        if (scheduledStationName.field.FieldRepetitions != null && scheduledStationName.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(scheduledStationName.Id));
            scheduledStationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(scheduledStationName, fieldData);
        }

        return scheduledStationName;
    } 
}

internal HL7V26Field scheduledProcedureStepLocation;

public HL7V26Field ScheduledProcedureStepLocation
{
    get
    {
        if (scheduledProcedureStepLocation != null)
        {
            return scheduledProcedureStepLocation;
        }

        scheduledProcedureStepLocation = new HL7V26Field
        {
            field = message[@"IPC"][8],
            Id = @"IPC.8",
            Type = @"Field",
            Position = @"IPC.8",
            Name = @"Scheduled Procedure Step Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field specifies a locally defined physical location of the modality resource being requested for performance of particular Scheduled Procedure Step. Although location is usually defined geographically (such as identification of a campus, building, floor, etc.) it may be used for identification of a pool of equipment (resources) formed by any other means. Values for the field shall be drawn from a locally defined coding scheme.",
            Sample = @"",
        };

        // check for repetitions
        if (scheduledProcedureStepLocation.field.FieldRepetitions != null && scheduledProcedureStepLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(scheduledProcedureStepLocation.Id));
            scheduledProcedureStepLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(scheduledProcedureStepLocation, fieldData);
        }

        return scheduledProcedureStepLocation;
    } 
}

internal HL7V26Field scheduledStationAETitle;

public HL7V26Field ScheduledStationAETitle
{
    get
    {
        if (scheduledStationAETitle != null)
        {
            return scheduledStationAETitle;
        }

        scheduledStationAETitle = new HL7V26Field
        {
            field = message[@"IPC"][9],
            Id = @"IPC.9",
            Type = @"Field",
            Position = @"IPC.9",
            Name = @"Scheduled Station AE Title",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Application Entity Title of the modality resource being requested for performance of a particular Scheduled Procedure Step. Application Entity Title is the identifier that identifies an instance of DICOM-compatible equipment for the purpose of addressing during communication. See DICOM Standard, Part 3 for further details on the DICOM Attribute (0040,0001) that conveys equivalent information. A limit of sixteen (16) characters is required to allow compatibility with DICOM.",
            Sample = @"",
        };

        // check for repetitions
        if (scheduledStationAETitle.field.FieldRepetitions != null && scheduledStationAETitle.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(scheduledStationAETitle.Id));
            scheduledStationAETitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(scheduledStationAETitle, fieldData);
        }

        return scheduledStationAETitle;
    } 
}
    }
}

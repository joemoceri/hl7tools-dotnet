using System.Linq;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentPDC
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PDC"; } }

        public string SegmentId { get { return @"PDC"; } }
        
        public string LongName { get { return @"Product Detail Country"; } }
        
        public string Description { get { return @""; } }
        
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
                            Id = @"PDC.1",
                            Type = @"Field",
                            Position = @"PDC.1",
                            Name = @"Manufacturer/Distributor",
                            Length = 570,
                            Usage = @"R",
                            Rpt = @"*",
                            DataType = @"XON",
                            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identity of the manufacturer/distributor.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.1",
                            Type = @"Component",
                            Position = @"PDC.1.1",
                            Name = @"Organization Name",
                            Length = 50,
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
                            Id = @"PDC.1.2",
                            Type = @"Component",
                            Position = @"PDC.1.2",
                            Name = @"Organization Name Type Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational Name Type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.3",
                            Type = @"Component",
                            Position = @"PDC.1.3",
                            Name = @"Id Number",
                            Length = 4,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component has been retained for backward compatibility only as of v 2.5. It is recommended to use component 10 Organization identifier that accommodates alphanumeric identifiers.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.4",
                            Type = @"Component",
                            Position = @"PDC.1.4",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XON.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.5",
                            Type = @"Component",
                            Position = @"PDC.1.5",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6",
                            Type = @"Component",
                            Position = @"PDC.1.6",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. Refer to User-defined Table 0363 - Assigning Authority for suggested values.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.1",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.2",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.6.3",
                            Type = @"SubComponent",
                            Position = @"PDC.1.6.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.7",
                            Type = @"Component",
                            Position = @"PDC.1.7",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8",
                            Type = @"Component",
                            Position = @"PDC.1.8",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.1",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.1",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.2",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.2",
                            Name = @"Universal Id",
                            Length = 999,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.8.3",
                            Type = @"SubComponent",
                            Position = @"PDC.1.8.3",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.9",
                            Type = @"Component",
                            Position = @"PDC.1.9",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.1.10",
                            Type = @"Component",
                            Position = @"PDC.1.10",
                            Name = @"Organization Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the sequence of characters (the code) that uniquely identifies the item being referenced by XON.1 Organization Name. This component replaces XON.3 ID Number as of v 2.5.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.2",
                            Type = @"Field",
                            Position = @"PDC.2",
                            Name = @"Country",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the country to which this product detail is relevant. ISO 3166 provides a list of country codes that may be used.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.2.1",
                            Type = @"Component",
                            Position = @"PDC.2.1",
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
                            Id = @"PDC.2.2",
                            Type = @"Component",
                            Position = @"PDC.2.2",
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
                            Id = @"PDC.2.3",
                            Type = @"Component",
                            Position = @"PDC.2.3",
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
                            Id = @"PDC.2.4",
                            Type = @"Component",
                            Position = @"PDC.2.4",
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
                            Id = @"PDC.2.5",
                            Type = @"Component",
                            Position = @"PDC.2.5",
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
                            Id = @"PDC.2.6",
                            Type = @"Component",
                            Position = @"PDC.2.6",
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
                            Id = @"PDC.2.7",
                            Type = @"Component",
                            Position = @"PDC.2.7",
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
                            Id = @"PDC.2.8",
                            Type = @"Component",
                            Position = @"PDC.2.8",
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
                            Id = @"PDC.2.9",
                            Type = @"Component",
                            Position = @"PDC.2.9",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.3",
                            Type = @"Field",
                            Position = @"PDC.3",
                            Name = @"Brand Name",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name under which the product is marketed by this manufacturer.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.4",
                            Type = @"Field",
                            Position = @"PDC.4",
                            Name = @"Device Family Name",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name used by the manufacturer to describe the family of products to which this product belongs.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.5",
                            Type = @"Field",
                            Position = @"PDC.5",
                            Name = @"Generic Name",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the name generically used to identify the product.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.5.1",
                            Type = @"Component",
                            Position = @"PDC.5.1",
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
                            Id = @"PDC.5.2",
                            Type = @"Component",
                            Position = @"PDC.5.2",
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
                            Id = @"PDC.5.3",
                            Type = @"Component",
                            Position = @"PDC.5.3",
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
                            Id = @"PDC.5.4",
                            Type = @"Component",
                            Position = @"PDC.5.4",
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
                            Id = @"PDC.5.5",
                            Type = @"Component",
                            Position = @"PDC.5.5",
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
                            Id = @"PDC.5.6",
                            Type = @"Component",
                            Position = @"PDC.5.6",
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
                            Id = @"PDC.5.7",
                            Type = @"Component",
                            Position = @"PDC.5.7",
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
                            Id = @"PDC.5.8",
                            Type = @"Component",
                            Position = @"PDC.5.8",
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
                            Id = @"PDC.5.9",
                            Type = @"Component",
                            Position = @"PDC.5.9",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.6",
                            Type = @"Field",
                            Position = @"PDC.6",
                            Name = @"Model Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the manufacturers model identifier for the product.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.7",
                            Type = @"Field",
                            Position = @"PDC.7",
                            Name = @"Catalogue Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the manufacturers catalogue identifier for the product.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.8",
                            Type = @"Field",
                            Position = @"PDC.8",
                            Name = @"Other Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains any other identifier used to for the product.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.9",
                            Type = @"Field",
                            Position = @"PDC.9",
                            Name = @"Product Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the product code from an external coding system such as that used by the CDRH at the FDA.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.9.1",
                            Type = @"Component",
                            Position = @"PDC.9.1",
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
                            Id = @"PDC.9.2",
                            Type = @"Component",
                            Position = @"PDC.9.2",
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
                            Id = @"PDC.9.3",
                            Type = @"Component",
                            Position = @"PDC.9.3",
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
                            Id = @"PDC.9.4",
                            Type = @"Component",
                            Position = @"PDC.9.4",
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
                            Id = @"PDC.9.5",
                            Type = @"Component",
                            Position = @"PDC.9.5",
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
                            Id = @"PDC.9.6",
                            Type = @"Component",
                            Position = @"PDC.9.6",
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
                            Id = @"PDC.9.7",
                            Type = @"Component",
                            Position = @"PDC.9.7",
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
                            Id = @"PDC.9.8",
                            Type = @"Component",
                            Position = @"PDC.9.8",
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
                            Id = @"PDC.9.9",
                            Type = @"Component",
                            Position = @"PDC.9.9",
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
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.10",
                            Type = @"Field",
                            Position = @"PDC.10",
                            Name = @"Marketing Basis",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0330",
                            TableName = @"Marketing basis",
                            Description = @"This field contains the basis for marketing approval. Refer to HL7 Table 0330 - Marketing basis for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.11",
                            Type = @"Field",
                            Position = @"PDC.11",
                            Name = @"Marketing Approval ID",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the designation or description of the marketing basis.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.12",
                            Type = @"Field",
                            Position = @"PDC.12",
                            Name = @"Labeled Shelf Life",
                            Length = 722,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the shelf life of the product as labeled. This will usually be in months or years. If there is no shelf life indicated in the product labeling, this field will be empty.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.12.1",
                            Type = @"Component",
                            Position = @"PDC.12.1",
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
                            Id = @"PDC.12.2",
                            Type = @"Component",
                            Position = @"PDC.12.2",
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.12.2.1",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.1",
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
                            Id = @"PDC.12.2.2",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.2",
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
                            Id = @"PDC.12.2.3",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.3",
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
                            Id = @"PDC.12.2.4",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.4",
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
                            Id = @"PDC.12.2.5",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.5",
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
                            Id = @"PDC.12.2.6",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.6",
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
                            Id = @"PDC.12.2.7",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.7",
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
                            Id = @"PDC.12.2.8",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.8",
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
                            Id = @"PDC.12.2.9",
                            Type = @"SubComponent",
                            Position = @"PDC.12.2.9",
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
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.13",
                            Type = @"Field",
                            Position = @"PDC.13",
                            Name = @"Expected Shelf Life",
                            Length = 722,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity with Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the shelf life of the product expected by the manufacturer. This will usually be in months or years.",
                            Sample = @"",
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.13.1",
                            Type = @"Component",
                            Position = @"PDC.13.1",
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
                            Id = @"PDC.13.2",
                            Type = @"Component",
                            Position = @"PDC.13.2",
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
                            FieldDatas = 
                        new HL7V2FieldData
                        {
                            Id = @"PDC.13.2.1",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.1",
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
                            Id = @"PDC.13.2.2",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.2",
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
                            Id = @"PDC.13.2.3",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.3",
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
                            Id = @"PDC.13.2.4",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.4",
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
                            Id = @"PDC.13.2.5",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.5",
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
                            Id = @"PDC.13.2.6",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.6",
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
                            Id = @"PDC.13.2.7",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.7",
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
                            Id = @"PDC.13.2.8",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.8",
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
                            Id = @"PDC.13.2.9",
                            Type = @"SubComponent",
                            Position = @"PDC.13.2.9",
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
                        },
                        
                        },
                        
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.14",
                            Type = @"Field",
                            Position = @"PDC.14",
                            Name = @"Date First Marketed",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date the product was first marketed in the country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PDC.15",
                            Type = @"Field",
                            Position = @"PDC.15",
                            Name = @"Date Last Marketed",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date the product was last marketed in the country. This field will be omitted if the product is still being marketed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V26SegmentPDC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field manufacturerDistributor;

public HL7V26Field ManufacturerDistributor
{
    get
    {
        if (manufacturerDistributor != null)
        {
            return manufacturerDistributor;
        }

        manufacturerDistributor = new HL7V26Field
        {
            field = message[@"PDC"][1],
            Id = @"PDC.1",
            Type = @"Field",
            Position = @"PDC.1",
            Name = @"Manufacturer/Distributor",
            Length = 570,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name and Identification Number for Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identity of the manufacturer/distributor.",
            Sample = @"",
        };

        

        

        

        return manufacturerDistributor;
    } 
}
internal HL7V26Field country;

public HL7V26Field Country
{
    get
    {
        if (country != null)
        {
            return country;
        }

        country = new HL7V26Field
        {
            field = message[@"PDC"][2],
            Id = @"PDC.2",
            Type = @"Field",
            Position = @"PDC.2",
            Name = @"Country",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the country to which this product detail is relevant. ISO 3166 provides a list of country codes that may be used.",
            Sample = @"",
        };

        

        

        

        return country;
    } 
}
internal HL7V26Field brandName;

public HL7V26Field BrandName
{
    get
    {
        if (brandName != null)
        {
            return brandName;
        }

        brandName = new HL7V26Field
        {
            field = message[@"PDC"][3],
            Id = @"PDC.3",
            Type = @"Field",
            Position = @"PDC.3",
            Name = @"Brand Name",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name under which the product is marketed by this manufacturer.",
            Sample = @"",
        };

        

        

        

        return brandName;
    } 
}
internal HL7V26Field deviceFamilyName;

public HL7V26Field DeviceFamilyName
{
    get
    {
        if (deviceFamilyName != null)
        {
            return deviceFamilyName;
        }

        deviceFamilyName = new HL7V26Field
        {
            field = message[@"PDC"][4],
            Id = @"PDC.4",
            Type = @"Field",
            Position = @"PDC.4",
            Name = @"Device Family Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name used by the manufacturer to describe the family of products to which this product belongs.",
            Sample = @"",
        };

        

        

        

        return deviceFamilyName;
    } 
}
internal HL7V26Field genericName;

public HL7V26Field GenericName
{
    get
    {
        if (genericName != null)
        {
            return genericName;
        }

        genericName = new HL7V26Field
        {
            field = message[@"PDC"][5],
            Id = @"PDC.5",
            Type = @"Field",
            Position = @"PDC.5",
            Name = @"Generic Name",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name generically used to identify the product.",
            Sample = @"",
        };

        

        

        

        return genericName;
    } 
}
internal HL7V26Field modelIdentifier;

public HL7V26Field ModelIdentifier
{
    get
    {
        if (modelIdentifier != null)
        {
            return modelIdentifier;
        }

        modelIdentifier = new HL7V26Field
        {
            field = message[@"PDC"][6],
            Id = @"PDC.6",
            Type = @"Field",
            Position = @"PDC.6",
            Name = @"Model Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturers model identifier for the product.",
            Sample = @"",
        };

        

        

        

        return modelIdentifier;
    } 
}
internal HL7V26Field catalogueIdentifier;

public HL7V26Field CatalogueIdentifier
{
    get
    {
        if (catalogueIdentifier != null)
        {
            return catalogueIdentifier;
        }

        catalogueIdentifier = new HL7V26Field
        {
            field = message[@"PDC"][7],
            Id = @"PDC.7",
            Type = @"Field",
            Position = @"PDC.7",
            Name = @"Catalogue Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the manufacturers catalogue identifier for the product.",
            Sample = @"",
        };

        

        

        

        return catalogueIdentifier;
    } 
}
internal HL7V26Field otherIdentifier;

public HL7V26Field OtherIdentifier
{
    get
    {
        if (otherIdentifier != null)
        {
            return otherIdentifier;
        }

        otherIdentifier = new HL7V26Field
        {
            field = message[@"PDC"][8],
            Id = @"PDC.8",
            Type = @"Field",
            Position = @"PDC.8",
            Name = @"Other Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains any other identifier used to for the product.",
            Sample = @"",
        };

        

        

        

        return otherIdentifier;
    } 
}
internal HL7V26Field productCode;

public HL7V26Field ProductCode
{
    get
    {
        if (productCode != null)
        {
            return productCode;
        }

        productCode = new HL7V26Field
        {
            field = message[@"PDC"][9],
            Id = @"PDC.9",
            Type = @"Field",
            Position = @"PDC.9",
            Name = @"Product Code",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains the product code from an external coding system such as that used by the CDRH at the FDA.",
            Sample = @"",
        };

        

        

        

        return productCode;
    } 
}
internal HL7V26Field marketingBasis;

public HL7V26Field MarketingBasis
{
    get
    {
        if (marketingBasis != null)
        {
            return marketingBasis;
        }

        marketingBasis = new HL7V26Field
        {
            field = message[@"PDC"][10],
            Id = @"PDC.10",
            Type = @"Field",
            Position = @"PDC.10",
            Name = @"Marketing Basis",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0330",
            TableName = @"Marketing basis",
            Description = @"This field contains the basis for marketing approval. Refer to HL7 Table 0330 - Marketing basis for valid values.",
            Sample = @"",
        };

        

        

        

        return marketingBasis;
    } 
}
internal HL7V26Field marketingApprovalID;

public HL7V26Field MarketingApprovalID
{
    get
    {
        if (marketingApprovalID != null)
        {
            return marketingApprovalID;
        }

        marketingApprovalID = new HL7V26Field
        {
            field = message[@"PDC"][11],
            Id = @"PDC.11",
            Type = @"Field",
            Position = @"PDC.11",
            Name = @"Marketing Approval ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the designation or description of the marketing basis.",
            Sample = @"",
        };

        

        

        

        return marketingApprovalID;
    } 
}
internal HL7V26Field labeledShelfLife;

public HL7V26Field LabeledShelfLife
{
    get
    {
        if (labeledShelfLife != null)
        {
            return labeledShelfLife;
        }

        labeledShelfLife = new HL7V26Field
        {
            field = message[@"PDC"][12],
            Id = @"PDC.12",
            Type = @"Field",
            Position = @"PDC.12",
            Name = @"Labeled Shelf Life",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the shelf life of the product as labeled. This will usually be in months or years. If there is no shelf life indicated in the product labeling, this field will be empty.",
            Sample = @"",
        };

        

        

        

        return labeledShelfLife;
    } 
}
internal HL7V26Field expectedShelfLife;

public HL7V26Field ExpectedShelfLife
{
    get
    {
        if (expectedShelfLife != null)
        {
            return expectedShelfLife;
        }

        expectedShelfLife = new HL7V26Field
        {
            field = message[@"PDC"][13],
            Id = @"PDC.13",
            Type = @"Field",
            Position = @"PDC.13",
            Name = @"Expected Shelf Life",
            Length = 722,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the shelf life of the product expected by the manufacturer. This will usually be in months or years.",
            Sample = @"",
        };

        

        

        

        return expectedShelfLife;
    } 
}
internal HL7V26Field dateFirstMarketed;

public HL7V26Field DateFirstMarketed
{
    get
    {
        if (dateFirstMarketed != null)
        {
            return dateFirstMarketed;
        }

        dateFirstMarketed = new HL7V26Field
        {
            field = message[@"PDC"][14],
            Id = @"PDC.14",
            Type = @"Field",
            Position = @"PDC.14",
            Name = @"Date First Marketed",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the product was first marketed in the country.",
            Sample = @"",
        };

        

        

        

        return dateFirstMarketed;
    } 
}
internal HL7V26Field dateLastMarketed;

public HL7V26Field DateLastMarketed
{
    get
    {
        if (dateLastMarketed != null)
        {
            return dateLastMarketed;
        }

        dateLastMarketed = new HL7V26Field
        {
            field = message[@"PDC"][15],
            Id = @"PDC.15",
            Type = @"Field",
            Position = @"PDC.15",
            Name = @"Date Last Marketed",
            Length = 24,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the product was last marketed in the country. This field will be omitted if the product is still being marketed.",
            Sample = @"",
        };

        

        

        

        return dateLastMarketed;
    } 
}

    }
}

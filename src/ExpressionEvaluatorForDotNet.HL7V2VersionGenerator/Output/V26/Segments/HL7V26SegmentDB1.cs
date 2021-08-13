using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentDB1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DB1"; } }

        public string SegmentId { get { return @"DB1"; } }
        
        public string LongName { get { return @"Disability"; } }
        
        public string Description { get { return @"The disability segment contains information related to the disability of a person. This segment was created instead of adding disability attributes to each segment that contains a person (to which disability may apply). This is an optional segment that can be used to send disability information about a person already defined by the Patient Administration Chapter. The disabled person code and identifier allow for the association of the disability information to the person."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V26SegmentDB1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _setIDDB1;

public HL7V26Field SetIDDB1
{
    get
    {
        if (_setIDDB1 != null)
        {
            return _setIDDB1;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.1",
            Type = @"Field",
            Position = @"DB1.1",
            Name = @"Set ID - DB1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDDB1 = new HL7V26Field
        {
            field = message[@"DB1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDDB1.field.FieldRepetitions != null && _setIDDB1.field.FieldRepetitions.Count > 0)
        {
            _setIDDB1.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_setIDDB1, fieldData);
        }

        return _setIDDB1;
    } 
}

internal HL7V26Field _disabledPersonCode;

public HL7V26Field DisabledPersonCode
{
    get
    {
        if (_disabledPersonCode != null)
        {
            return _disabledPersonCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.2",
            Type = @"Field",
            Position = @"DB1.2",
            Name = @"Disabled Person Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0334",
            TableName = @"Disabled Person Code",
            Description = @"The value of this field indicates to which person the disability information relates in the message. For example, if the value is PT, the disability information relates to the patient. Refer to User-defined Table 0334 - Disabled Person Code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _disabledPersonCode = new HL7V26Field
        {
            field = message[@"DB1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledPersonCode.field.FieldRepetitions != null && _disabledPersonCode.field.FieldRepetitions.Count > 0)
        {
            _disabledPersonCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabledPersonCode, fieldData);
        }

        return _disabledPersonCode;
    } 
}

internal HL7V26Field _disabledPersonIdentifier;

public HL7V26Field DisabledPersonIdentifier
{
    get
    {
        if (_disabledPersonIdentifier != null)
        {
            return _disabledPersonIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.3",
            Type = @"Field",
            Position = @"DB1.3",
            Name = @"Disabled Person Identifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID with Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This is the identifier (or identifiers) for the person whose disability information is sent on the segment. The assigning authority and identifier type code are strongly recommended for all CX data types.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DB1.3.1",
                            Type = @"Component",
                            Position = @"DB1.3.1",
                            Name = @"Id Number",
                            Length = 15,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value of the identifier itself.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.2",
                            Type = @"Component",
                            Position = @"DB1.3.2",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A digit, or digits, exclusive of the identifier in CX.1, usually calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.3",
                            Type = @"Component",
                            Position = @"DB1.3.3",
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
                            Id = @"DB1.3.4",
                            Type = @"Component",
                            Position = @"DB1.3.4",
                            Name = @"Assigning Authority",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. . Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.4.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.1",
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
                            Id = @"DB1.3.4.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.2",
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
                            Id = @"DB1.3.4.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.4.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.5",
                            Type = @"Component",
                            Position = @"DB1.3.5",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.6",
                            Type = @"Component",
                            Position = @"DB1.3.6",
                            Name = @"Assigning Facility",
                            Length = 227,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.1",
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
                            Id = @"DB1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.2",
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
                            Id = @"DB1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.6.3",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.7",
                            Type = @"Component",
                            Position = @"DB1.3.7",
                            Name = @"Effective Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the identifier is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.8",
                            Type = @"Component",
                            Position = @"DB1.3.8",
                            Name = @"Expiration Date",
                            Length = 8,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the identifier is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DB1.3.9",
                            Type = @"Component",
                            Position = @"DB1.3.9",
                            Name = @"Assigning Jurisdiction",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.9.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.1",
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
                            Id = @"DB1.3.9.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.2",
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
                            Id = @"DB1.3.9.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.3",
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
                            Id = @"DB1.3.9.4",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.4",
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
                            Id = @"DB1.3.9.5",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.5",
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
                            Id = @"DB1.3.9.6",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.6",
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
                            Id = @"DB1.3.9.7",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.7",
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
                            Id = @"DB1.3.9.8",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.8",
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
                            Id = @"DB1.3.9.9",
                            Type = @"SubComponent",
                            Position = @"DB1.3.9.9",
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
                            Id = @"DB1.3.10",
                            Type = @"Component",
                            Position = @"DB1.3.10",
                            Name = @"Assigning Agency Or Department",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in component 1.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"DB1.3.10.1",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.1",
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
                            Id = @"DB1.3.10.2",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.2",
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
                            Id = @"DB1.3.10.3",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.3",
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
                            Id = @"DB1.3.10.4",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.4",
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
                            Id = @"DB1.3.10.5",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.5",
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
                            Id = @"DB1.3.10.6",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.6",
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
                            Id = @"DB1.3.10.7",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.7",
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
                            Id = @"DB1.3.10.8",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.8",
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
                            Id = @"DB1.3.10.9",
                            Type = @"SubComponent",
                            Position = @"DB1.3.10.9",
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
                        }
        }

        _disabledPersonIdentifier = new HL7V26Field
        {
            field = message[@"DB1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledPersonIdentifier.field.FieldRepetitions != null && _disabledPersonIdentifier.field.FieldRepetitions.Count > 0)
        {
            _disabledPersonIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabledPersonIdentifier, fieldData);
        }

        return _disabledPersonIdentifier;
    } 
}

internal HL7V26Field _disabledIndicator;

public HL7V26Field DisabledIndicator
{
    get
    {
        if (_disabledIndicator != null)
        {
            return _disabledIndicator;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.4",
            Type = @"Field",
            Position = @"DB1.4",
            Name = @"Disabled Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the person's visit is a disability visit. Refer to HL7 Table 0136 - Yes/No Indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _disabledIndicator = new HL7V26Field
        {
            field = message[@"DB1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabledIndicator.field.FieldRepetitions != null && _disabledIndicator.field.FieldRepetitions.Count > 0)
        {
            _disabledIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabledIndicator, fieldData);
        }

        return _disabledIndicator;
    } 
}

internal HL7V26Field _disabilityStartDate;

public HL7V26Field DisabilityStartDate
{
    get
    {
        if (_disabilityStartDate != null)
        {
            return _disabilityStartDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.5",
            Type = @"Field",
            Position = @"DB1.5",
            Name = @"Disability Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the date the person became disabled.",
            Sample = @"",
            Fields = null
        }

        _disabilityStartDate = new HL7V26Field
        {
            field = message[@"DB1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityStartDate.field.FieldRepetitions != null && _disabilityStartDate.field.FieldRepetitions.Count > 0)
        {
            _disabilityStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabilityStartDate, fieldData);
        }

        return _disabilityStartDate;
    } 
}

internal HL7V26Field _disabilityEndDate;

public HL7V26Field DisabilityEndDate
{
    get
    {
        if (_disabilityEndDate != null)
        {
            return _disabilityEndDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.6",
            Type = @"Field",
            Position = @"DB1.6",
            Name = @"Disability End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the ending date of the person's disability.",
            Sample = @"",
            Fields = null
        }

        _disabilityEndDate = new HL7V26Field
        {
            field = message[@"DB1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityEndDate.field.FieldRepetitions != null && _disabilityEndDate.field.FieldRepetitions.Count > 0)
        {
            _disabilityEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabilityEndDate, fieldData);
        }

        return _disabilityEndDate;
    } 
}

internal HL7V26Field _disabilityReturntoWorkDate;

public HL7V26Field DisabilityReturntoWorkDate
{
    get
    {
        if (_disabilityReturntoWorkDate != null)
        {
            return _disabilityReturntoWorkDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.7",
            Type = @"Field",
            Position = @"DB1.7",
            Name = @"Disability Return to Work Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the authorized date on which the patient can return to work for a specified disability case.",
            Sample = @"",
            Fields = null
        }

        _disabilityReturntoWorkDate = new HL7V26Field
        {
            field = message[@"DB1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityReturntoWorkDate.field.FieldRepetitions != null && _disabilityReturntoWorkDate.field.FieldRepetitions.Count > 0)
        {
            _disabilityReturntoWorkDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabilityReturntoWorkDate, fieldData);
        }

        return _disabilityReturntoWorkDate;
    } 
}

internal HL7V26Field _disabilityUnabletoWorkDate;

public HL7V26Field DisabilityUnabletoWorkDate
{
    get
    {
        if (_disabilityUnabletoWorkDate != null)
        {
            return _disabilityUnabletoWorkDate;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DB1.8",
            Type = @"Field",
            Position = @"DB1.8",
            Name = @"Disability Unable to Work Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the first date in the date span that the patient is unable to work due to disability.",
            Sample = @"",
            Fields = null
        }

        _disabilityUnabletoWorkDate = new HL7V26Field
        {
            field = message[@"DB1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_disabilityUnabletoWorkDate.field.FieldRepetitions != null && _disabilityUnabletoWorkDate.field.FieldRepetitions.Count > 0)
        {
            _disabilityUnabletoWorkDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_disabilityUnabletoWorkDate, fieldData);
        }

        return _disabilityUnabletoWorkDate;
    } 
}
    }
}

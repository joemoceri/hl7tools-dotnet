using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor segment"; } }
        
        public string Description { get { return @"The GT1 segment contains guarantor (e.g., the person or the organization with financial responsibility for payment of a patient account) data for patient and insurance billing applications."; } }
        
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

        public HL7V231SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDGT1;

public HL7V231Field SetIDGT1
{
    get
    {
        if (_setIDGT1 != null)
        {
            return _setIDGT1;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set ID - GT1",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"GT1-1-set ID-contains a number that identifies this transaction. For the first occurrence of the segment the sequence shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDGT1 = new HL7V231Field
        {
            field = message[@"GT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDGT1.field.FieldRepetitions != null && _setIDGT1.field.FieldRepetitions.Count > 0)
        {
            _setIDGT1.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDGT1, fieldData);
        }

        return _setIDGT1;
    } 
}

internal HL7V231Field _guarantorNumber;

public HL7V231Field GuarantorNumber
{
    get
    {
        if (_guarantorNumber != null)
        {
            return _guarantorNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.2",
            Type = @"Field",
            Position = @"GT1.2",
            Name = @"Guarantor Number",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the primary identifier, or other identifiers, assigned to the guarantor. The assigning authority and identifier type code are strongly recommended for all CX data types.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.2.1",
                            Type = @"Component",
                            Position = @"GT1.2.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that a ST data type is allowed instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.2",
                            Type = @"Component",
                            Position = @"GT1.2.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.3",
                            Type = @"Component",
                            Position = @"GT1.2.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit). Refer to HL7 table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.4",
                            Type = @"Component",
                            Position = @"GT1.2.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.2.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.5",
                            Type = @"Component",
                            Position = @"GT1.2.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.6",
                            Type = @"Component",
                            Position = @"GT1.2.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents: <namespace ID (IS)> & < universal ID (ST)> & <universal ID type (ID)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.2.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.2.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _guarantorNumber = new HL7V231Field
        {
            field = message[@"GT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorNumber.field.FieldRepetitions != null && _guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorNumber, fieldData);
        }

        return _guarantorNumber;
    } 
}

internal HL7V231Field _guarantorName;

public HL7V231Field GuarantorName
{
    get
    {
        if (_guarantorName != null)
        {
            return _guarantorName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.3",
            Type = @"Field",
            Position = @"GT1.3",
            Name = @"Guarantor Name",
            Length = 48,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor. Multiple names for the same guarantor may be sent in this field. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.3.1",
                            Type = @"Component",
                            Position = @"GT1.3.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.3.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.3.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.3.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.2",
                            Type = @"Component",
                            Position = @"GT1.3.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.3",
                            Type = @"Component",
                            Position = @"GT1.3.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.3.4",
                            Type = @"Component",
                            Position = @"GT1.3.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.5",
                            Type = @"Component",
                            Position = @"GT1.3.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.6",
                            Type = @"Component",
                            Position = @"GT1.3.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.7",
                            Type = @"Component",
                            Position = @"GT1.3.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.3.8",
                            Type = @"Component",
                            Position = @"GT1.3.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorName = new HL7V231Field
        {
            field = message[@"GT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorName.field.FieldRepetitions != null && _guarantorName.field.FieldRepetitions.Count > 0)
        {
            _guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorName, fieldData);
        }

        return _guarantorName;
    } 
}

internal HL7V231Field _guarantorSpouseName;

public HL7V231Field GuarantorSpouseName
{
    get
    {
        if (_guarantorSpouseName != null)
        {
            return _guarantorSpouseName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.4",
            Type = @"Field",
            Position = @"GT1.4",
            Name = @"Guarantor Spouse Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor's spouse. Multiple names for the same guarantor spouse may be sent in this field. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.4.1",
                            Type = @"Component",
                            Position = @"GT1.4.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.4.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.4.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.4.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.2",
                            Type = @"Component",
                            Position = @"GT1.4.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.3",
                            Type = @"Component",
                            Position = @"GT1.4.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.4.4",
                            Type = @"Component",
                            Position = @"GT1.4.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.5",
                            Type = @"Component",
                            Position = @"GT1.4.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.6",
                            Type = @"Component",
                            Position = @"GT1.4.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.7",
                            Type = @"Component",
                            Position = @"GT1.4.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.4.8",
                            Type = @"Component",
                            Position = @"GT1.4.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorSpouseName = new HL7V231Field
        {
            field = message[@"GT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSpouseName.field.FieldRepetitions != null && _guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            _guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorSpouseName, fieldData);
        }

        return _guarantorSpouseName;
    } 
}

internal HL7V231Field _guarantorAddress;

public HL7V231Field GuarantorAddress
{
    get
    {
        if (_guarantorAddress != null)
        {
            return _guarantorAddress;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.5",
            Type = @"Field",
            Position = @"GT1.5",
            Name = @"Guarantor Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's address. Multiple addresses for the same person may be sent in this field. The mailing address is assumed to be in the first repetition. When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.5.1",
                            Type = @"Component",
                            Position = @"GT1.5.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.2",
                            Type = @"Component",
                            Position = @"GT1.5.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.3",
                            Type = @"Component",
                            Position = @"GT1.5.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.4",
                            Type = @"Component",
                            Position = @"GT1.5.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.5",
                            Type = @"Component",
                            Position = @"GT1.5.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.6",
                            Type = @"Component",
                            Position = @"GT1.5.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.7",
                            Type = @"Component",
                            Position = @"GT1.5.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.8",
                            Type = @"Component",
                            Position = @"GT1.5.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.9",
                            Type = @"Component",
                            Position = @"GT1.5.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.10",
                            Type = @"Component",
                            Position = @"GT1.5.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.11",
                            Type = @"Component",
                            Position = @"GT1.5.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorAddress = new HL7V231Field
        {
            field = message[@"GT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorAddress.field.FieldRepetitions != null && _guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorAddress, fieldData);
        }

        return _guarantorAddress;
    } 
}

internal HL7V231Field _guarantorPhNumHome;

public HL7V231Field GuarantorPhNumHome
{
    get
    {
        if (_guarantorPhNumHome != null)
        {
            return _guarantorPhNumHome;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Ph Num-Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's home phone number. All personal phone numbers for the guarantor may be sent in this field. The primary telephone number is assumed to be in the first repetition. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.6.1",
                            Type = @"Component",
                            Position = @"GT1.6.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.2",
                            Type = @"Component",
                            Position = @"GT1.6.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.3",
                            Type = @"Component",
                            Position = @"GT1.6.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.4",
                            Type = @"Component",
                            Position = @"GT1.6.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.6.5",
                            Type = @"Component",
                            Position = @"GT1.6.5",
                            Name = @"Country Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.6",
                            Type = @"Component",
                            Position = @"GT1.6.6",
                            Name = @"Area/City Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.7",
                            Type = @"Component",
                            Position = @"GT1.6.7",
                            Name = @"Phone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.8",
                            Type = @"Component",
                            Position = @"GT1.6.8",
                            Name = @"Extension",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.9",
                            Type = @"Component",
                            Position = @"GT1.6.9",
                            Name = @"Any Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorPhNumHome = new HL7V231Field
        {
            field = message[@"GT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumHome.field.FieldRepetitions != null && _guarantorPhNumHome.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorPhNumHome, fieldData);
        }

        return _guarantorPhNumHome;
    } 
}

internal HL7V231Field _guarantorPhNumBusiness;

public HL7V231Field GuarantorPhNumBusiness
{
    get
    {
        if (_guarantorPhNumBusiness != null)
        {
            return _guarantorPhNumBusiness;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.7",
            Type = @"Field",
            Position = @"GT1.7",
            Name = @"Guarantor Ph Num-Business",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's business phone number. All business phone numbers for the guarantor may be sent in this field. The primary telephone number is assumed to be in the first repetition. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.7.1",
                            Type = @"Component",
                            Position = @"GT1.7.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.2",
                            Type = @"Component",
                            Position = @"GT1.7.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.3",
                            Type = @"Component",
                            Position = @"GT1.7.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.4",
                            Type = @"Component",
                            Position = @"GT1.7.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.7.5",
                            Type = @"Component",
                            Position = @"GT1.7.5",
                            Name = @"Country Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.6",
                            Type = @"Component",
                            Position = @"GT1.7.6",
                            Name = @"Area/City Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.7",
                            Type = @"Component",
                            Position = @"GT1.7.7",
                            Name = @"Phone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.8",
                            Type = @"Component",
                            Position = @"GT1.7.8",
                            Name = @"Extension",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.9",
                            Type = @"Component",
                            Position = @"GT1.7.9",
                            Name = @"Any Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorPhNumBusiness = new HL7V231Field
        {
            field = message[@"GT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumBusiness.field.FieldRepetitions != null && _guarantorPhNumBusiness.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorPhNumBusiness, fieldData);
        }

        return _guarantorPhNumBusiness;
    } 
}

internal HL7V231Field _guarantorDateTimeOfBirth;

public HL7V231Field GuarantorDateTimeOfBirth
{
    get
    {
        if (_guarantorDateTimeOfBirth != null)
        {
            return _guarantorDateTimeOfBirth;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.8",
            Type = @"Field",
            Position = @"GT1.8",
            Name = @"Guarantor Date/Time Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's date of birth.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.8.1",
                            Type = @"Component",
                            Position = @"GT1.8.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorDateTimeOfBirth = new HL7V231Field
        {
            field = message[@"GT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateTimeOfBirth.field.FieldRepetitions != null && _guarantorDateTimeOfBirth.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateTimeOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorDateTimeOfBirth, fieldData);
        }

        return _guarantorDateTimeOfBirth;
    } 
}

internal HL7V231Field _guarantorSex;

public HL7V231Field GuarantorSex
{
    get
    {
        if (_guarantorSex != null)
        {
            return _guarantorSex;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.9",
            Type = @"Field",
            Position = @"GT1.9",
            Name = @"Guarantor Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Sex",
            Description = @"This field contains the guarantor's gender. Refer to user-defined table 0001 - Sex for valid values.",
            Sample = @"",
            Fields = null
        }

        _guarantorSex = new HL7V231Field
        {
            field = message[@"GT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSex.field.FieldRepetitions != null && _guarantorSex.field.FieldRepetitions.Count > 0)
        {
            _guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorSex, fieldData);
        }

        return _guarantorSex;
    } 
}

internal HL7V231Field _guarantorType;

public HL7V231Field GuarantorType
{
    get
    {
        if (_guarantorType != null)
        {
            return _guarantorType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.10",
            Type = @"Field",
            Position = @"GT1.10",
            Name = @"Guarantor Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0068",
            TableName = @"Guarantor type",
            Description = @"This field indicates the type of guarantor, e.g., individual, institution, etc. User-defined table 0068 - Guarantor type is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
            Fields = null
        }

        _guarantorType = new HL7V231Field
        {
            field = message[@"GT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorType.field.FieldRepetitions != null && _guarantorType.field.FieldRepetitions.Count > 0)
        {
            _guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorType, fieldData);
        }

        return _guarantorType;
    } 
}

internal HL7V231Field _guarantorRelationship;

public HL7V231Field GuarantorRelationship
{
    get
    {
        if (_guarantorRelationship != null)
        {
            return _guarantorRelationship;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.11",
            Type = @"Field",
            Position = @"GT1.11",
            Name = @"Guarantor Relationship",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field indicates the relationship of the guarantor with the patient, e.g., parent, child, etc. User-defined table 0063 - Relationship is used for the user-defined table of values for this field .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.11.1",
                            Type = @"Component",
                            Position = @"GT1.11.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11.2",
                            Type = @"Component",
                            Position = @"GT1.11.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11.3",
                            Type = @"Component",
                            Position = @"GT1.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11.4",
                            Type = @"Component",
                            Position = @"GT1.11.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.11.5",
                            Type = @"Component",
                            Position = @"GT1.11.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.11.6",
                            Type = @"Component",
                            Position = @"GT1.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorRelationship = new HL7V231Field
        {
            field = message[@"GT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRelationship.field.FieldRepetitions != null && _guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            _guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorRelationship, fieldData);
        }

        return _guarantorRelationship;
    } 
}

internal HL7V231Field _guarantorSSN;

public HL7V231Field GuarantorSSN
{
    get
    {
        if (_guarantorSSN != null)
        {
            return _guarantorSSN;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.12",
            Type = @"Field",
            Position = @"GT1.12",
            Name = @"Guarantor SSN",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's social security number.",
            Sample = @"",
            Fields = null
        }

        _guarantorSSN = new HL7V231Field
        {
            field = message[@"GT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSSN.field.FieldRepetitions != null && _guarantorSSN.field.FieldRepetitions.Count > 0)
        {
            _guarantorSSN.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorSSN, fieldData);
        }

        return _guarantorSSN;
    } 
}

internal HL7V231Field _guarantorDateBegin;

public HL7V231Field GuarantorDateBegin
{
    get
    {
        if (_guarantorDateBegin != null)
        {
            return _guarantorDateBegin;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.13",
            Type = @"Field",
            Position = @"GT1.13",
            Name = @"Guarantor Date - Begin",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the guarantor becomes responsible for the patient's account.",
            Sample = @"",
            Fields = null
        }

        _guarantorDateBegin = new HL7V231Field
        {
            field = message[@"GT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateBegin.field.FieldRepetitions != null && _guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorDateBegin, fieldData);
        }

        return _guarantorDateBegin;
    } 
}

internal HL7V231Field _guarantorDateEnd;

public HL7V231Field GuarantorDateEnd
{
    get
    {
        if (_guarantorDateEnd != null)
        {
            return _guarantorDateEnd;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.14",
            Type = @"Field",
            Position = @"GT1.14",
            Name = @"Guarantor Date - End",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the guarantor stops being responsible for the patient's account.",
            Sample = @"",
            Fields = null
        }

        _guarantorDateEnd = new HL7V231Field
        {
            field = message[@"GT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateEnd.field.FieldRepetitions != null && _guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorDateEnd, fieldData);
        }

        return _guarantorDateEnd;
    } 
}

internal HL7V231Field _guarantorPriority;

public HL7V231Field GuarantorPriority
{
    get
    {
        if (_guarantorPriority != null)
        {
            return _guarantorPriority;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.15",
            Type = @"Field",
            Position = @"GT1.15",
            Name = @"Guarantor Priority",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is used to determine the order in which the guarantors are responsible for the patient's account. '1' = primary guarantor, '2' = secondary guarantor, etc.",
            Sample = @"",
            Fields = null
        }

        _guarantorPriority = new HL7V231Field
        {
            field = message[@"GT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPriority.field.FieldRepetitions != null && _guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            _guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorPriority, fieldData);
        }

        return _guarantorPriority;
    } 
}

internal HL7V231Field _guarantorEmployerName;

public HL7V231Field GuarantorEmployerName
{
    get
    {
        if (_guarantorEmployerName != null)
        {
            return _guarantorEmployerName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.16",
            Type = @"Field",
            Position = @"GT1.16",
            Name = @"Guarantor Employer Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor's employer, if the employer is a person. When the guarantor's employer is an organization, use GT1-51-guarantor employer's organization name . Multiple names for the same person may be sent in this field, not multiple employers. The legal name must be sent first in the repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.16.1",
                            Type = @"Component",
                            Position = @"GT1.16.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.16.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.16.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.16.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.2",
                            Type = @"Component",
                            Position = @"GT1.16.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.3",
                            Type = @"Component",
                            Position = @"GT1.16.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.16.4",
                            Type = @"Component",
                            Position = @"GT1.16.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.5",
                            Type = @"Component",
                            Position = @"GT1.16.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.6",
                            Type = @"Component",
                            Position = @"GT1.16.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.7",
                            Type = @"Component",
                            Position = @"GT1.16.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.16.8",
                            Type = @"Component",
                            Position = @"GT1.16.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployerName = new HL7V231Field
        {
            field = message[@"GT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerName.field.FieldRepetitions != null && _guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployerName, fieldData);
        }

        return _guarantorEmployerName;
    } 
}

internal HL7V231Field _guarantorEmployerAddress;

public HL7V231Field GuarantorEmployerAddress
{
    get
    {
        if (_guarantorEmployerAddress != null)
        {
            return _guarantorEmployerAddress;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.17",
            Type = @"Field",
            Position = @"GT1.17",
            Name = @"Guarantor Employer Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's employer's address. Multiple addresses for the same employer may be sent in this field. The mailing address must be sent first in the repetition. When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.17.1",
                            Type = @"Component",
                            Position = @"GT1.17.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.2",
                            Type = @"Component",
                            Position = @"GT1.17.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.3",
                            Type = @"Component",
                            Position = @"GT1.17.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.4",
                            Type = @"Component",
                            Position = @"GT1.17.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"State",
                            TableName = @"State",
                            Description = @"State or province should be represented by the official postal service codes for that country.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.5",
                            Type = @"Component",
                            Position = @"GT1.17.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.6",
                            Type = @"Component",
                            Position = @"GT1.17.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.7",
                            Type = @"Component",
                            Position = @"GT1.17.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.8",
                            Type = @"Component",
                            Position = @"GT1.17.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.9",
                            Type = @"Component",
                            Position = @"GT1.17.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County code",
                            Description = @"A code that represents the county in which the specified address resides. User-defined table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.10",
                            Type = @"Component",
                            Position = @"GT1.17.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides. User-defined table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.11",
                            Type = @"Component",
                            Position = @"GT1.17.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployerAddress = new HL7V231Field
        {
            field = message[@"GT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerAddress.field.FieldRepetitions != null && _guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployerAddress, fieldData);
        }

        return _guarantorEmployerAddress;
    } 
}

internal HL7V231Field _guarantorEmployerPhoneNumber;

public HL7V231Field GuarantorEmployerPhoneNumber
{
    get
    {
        if (_guarantorEmployerPhoneNumber != null)
        {
            return _guarantorEmployerPhoneNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employer Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's employer's phone number. Multiple phone numbers for the same employer may be sent in this field. The primary telephone number must be sent first in the sequence. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.18.1",
                            Type = @"Component",
                            Position = @"GT1.18.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.2",
                            Type = @"Component",
                            Position = @"GT1.18.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.3",
                            Type = @"Component",
                            Position = @"GT1.18.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.4",
                            Type = @"Component",
                            Position = @"GT1.18.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.18.5",
                            Type = @"Component",
                            Position = @"GT1.18.5",
                            Name = @"Country Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.6",
                            Type = @"Component",
                            Position = @"GT1.18.6",
                            Name = @"Area/City Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.7",
                            Type = @"Component",
                            Position = @"GT1.18.7",
                            Name = @"Phone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.8",
                            Type = @"Component",
                            Position = @"GT1.18.8",
                            Name = @"Extension",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.9",
                            Type = @"Component",
                            Position = @"GT1.18.9",
                            Name = @"Any Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployerPhoneNumber = new HL7V231Field
        {
            field = message[@"GT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerPhoneNumber.field.FieldRepetitions != null && _guarantorEmployerPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployerPhoneNumber, fieldData);
        }

        return _guarantorEmployerPhoneNumber;
    } 
}

internal HL7V231Field _guarantorEmployeeIDNumber;

public HL7V231Field GuarantorEmployeeIDNumber
{
    get
    {
        if (_guarantorEmployeeIDNumber != null)
        {
            return _guarantorEmployeeIDNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.19",
            Type = @"Field",
            Position = @"GT1.19",
            Name = @"Guarantor Employee ID Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's employee number. The assigning authority and identifier type code are strongly recommended for all CX data types.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.19.1",
                            Type = @"Component",
                            Position = @"GT1.19.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that a ST data type is allowed instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.2",
                            Type = @"Component",
                            Position = @"GT1.19.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.3",
                            Type = @"Component",
                            Position = @"GT1.19.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit). Refer to HL7 table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.4",
                            Type = @"Component",
                            Position = @"GT1.19.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.19.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.5",
                            Type = @"Component",
                            Position = @"GT1.19.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.6",
                            Type = @"Component",
                            Position = @"GT1.19.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents: <namespace ID (IS)> & < universal ID (ST)> & <universal ID type (ID)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.19.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.19.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _guarantorEmployeeIDNumber = new HL7V231Field
        {
            field = message[@"GT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployeeIDNumber.field.FieldRepetitions != null && _guarantorEmployeeIDNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployeeIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployeeIDNumber, fieldData);
        }

        return _guarantorEmployeeIDNumber;
    } 
}

internal HL7V231Field _guarantorEmploymentStatus;

public HL7V231Field GuarantorEmploymentStatus
{
    get
    {
        if (_guarantorEmploymentStatus != null)
        {
            return _guarantorEmploymentStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.20",
            Type = @"Field",
            Position = @"GT1.20",
            Name = @"Guarantor Employment Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"This field contains the code that indicates the guarantor's employment status, e.g., full time, part time, self-employed, etc. User-definedtable 0066 - Employment status",
            Sample = @"",
            Fields = null
        }

        _guarantorEmploymentStatus = new HL7V231Field
        {
            field = message[@"GT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmploymentStatus.field.FieldRepetitions != null && _guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmploymentStatus, fieldData);
        }

        return _guarantorEmploymentStatus;
    } 
}

internal HL7V231Field _guarantorOrganizationName;

public HL7V231Field GuarantorOrganizationName
{
    get
    {
        if (_guarantorOrganizationName != null)
        {
            return _guarantorOrganizationName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.21",
            Type = @"Field",
            Position = @"GT1.21",
            Name = @"Guarantor Organization Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor when the guarantor is an organization. Multiple names for the same guarantor may be sent in this field, not multiple guarantors. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.21.1",
                            Type = @"Component",
                            Position = @"GT1.21.1",
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
                            Id = @"GT1.21.2",
                            Type = @"Component",
                            Position = @"GT1.21.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to user-defined table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.3",
                            Type = @"Component",
                            Position = @"GT1.21.3",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.4",
                            Type = @"Component",
                            Position = @"GT1.21.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.5",
                            Type = @"Component",
                            Position = @"GT1.21.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.6",
                            Type = @"Component",
                            Position = @"GT1.21.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.21.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.7",
                            Type = @"Component",
                            Position = @"GT1.21.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.8",
                            Type = @"Component",
                            Position = @"GT1.21.8",
                            Name = @"Assigning Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.21.8.1",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.8.2",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.8.3",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.9",
                            Type = @"Component",
                            Position = @"GT1.21.9",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorOrganizationName = new HL7V231Field
        {
            field = message[@"GT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorOrganizationName.field.FieldRepetitions != null && _guarantorOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _guarantorOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorOrganizationName, fieldData);
        }

        return _guarantorOrganizationName;
    } 
}

internal HL7V231Field _guarantorBillingHoldFlag;

public HL7V231Field GuarantorBillingHoldFlag
{
    get
    {
        if (_guarantorBillingHoldFlag != null)
        {
            return _guarantorBillingHoldFlag;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.22",
            Type = @"Field",
            Position = @"GT1.22",
            Name = @"Guarantor Billing Hold Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values. This field indicates whether or not a system should suppress printing of the guarantor's bills.",
            Sample = @"",
            Fields = null
        }

        _guarantorBillingHoldFlag = new HL7V231Field
        {
            field = message[@"GT1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorBillingHoldFlag.field.FieldRepetitions != null && _guarantorBillingHoldFlag.field.FieldRepetitions.Count > 0)
        {
            _guarantorBillingHoldFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorBillingHoldFlag, fieldData);
        }

        return _guarantorBillingHoldFlag;
    } 
}

internal HL7V231Field _guarantorCreditRatingCode;

public HL7V231Field GuarantorCreditRatingCode
{
    get
    {
        if (_guarantorCreditRatingCode != null)
        {
            return _guarantorCreditRatingCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.23",
            Type = @"Field",
            Position = @"GT1.23",
            Name = @"Guarantor Credit Rating Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0341",
            TableName = @"Guarantor credit rating code",
            Description = @"This field contains the guarantor's credit rating. Refer to user-defined table 0341 - Guarantor credit rating code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.23.1",
                            Type = @"Component",
                            Position = @"GT1.23.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.23.2",
                            Type = @"Component",
                            Position = @"GT1.23.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.23.3",
                            Type = @"Component",
                            Position = @"GT1.23.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.23.4",
                            Type = @"Component",
                            Position = @"GT1.23.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.23.5",
                            Type = @"Component",
                            Position = @"GT1.23.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.23.6",
                            Type = @"Component",
                            Position = @"GT1.23.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorCreditRatingCode = new HL7V231Field
        {
            field = message[@"GT1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorCreditRatingCode.field.FieldRepetitions != null && _guarantorCreditRatingCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorCreditRatingCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorCreditRatingCode, fieldData);
        }

        return _guarantorCreditRatingCode;
    } 
}

internal HL7V231Field _guarantorDeathDateAndTime;

public HL7V231Field GuarantorDeathDateAndTime
{
    get
    {
        if (_guarantorDeathDateAndTime != null)
        {
            return _guarantorDeathDateAndTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.24",
            Type = @"Field",
            Position = @"GT1.24",
            Name = @"Guarantor Death Date And Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is used to indicate the date and time at which the guarantor's death occurred.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.24.1",
                            Type = @"Component",
                            Position = @"GT1.24.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorDeathDateAndTime = new HL7V231Field
        {
            field = message[@"GT1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDeathDateAndTime.field.FieldRepetitions != null && _guarantorDeathDateAndTime.field.FieldRepetitions.Count > 0)
        {
            _guarantorDeathDateAndTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorDeathDateAndTime, fieldData);
        }

        return _guarantorDeathDateAndTime;
    } 
}

internal HL7V231Field _guarantorDeathFlag;

public HL7V231Field GuarantorDeathFlag
{
    get
    {
        if (_guarantorDeathFlag != null)
        {
            return _guarantorDeathFlag;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.25",
            Type = @"Field",
            Position = @"GT1.25",
            Name = @"Guarantor Death Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not the guarantor is deceased. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _guarantorDeathFlag = new HL7V231Field
        {
            field = message[@"GT1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDeathFlag.field.FieldRepetitions != null && _guarantorDeathFlag.field.FieldRepetitions.Count > 0)
        {
            _guarantorDeathFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorDeathFlag, fieldData);
        }

        return _guarantorDeathFlag;
    } 
}

internal HL7V231Field _guarantorChargeAdjustmentCode;

public HL7V231Field GuarantorChargeAdjustmentCode
{
    get
    {
        if (_guarantorChargeAdjustmentCode != null)
        {
            return _guarantorChargeAdjustmentCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.26",
            Type = @"Field",
            Position = @"GT1.26",
            Name = @"Guarantor Charge Adjustment Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0218",
            TableName = @"Patient charge adjustment",
            Description = @"This field contains user-defined codes that indicate which adjustments should be made to this guarantor's charges. For example, when the hospital agrees to adjust this guarantor's charges to a sliding scale. User-defined table 0218 - Charge adjustment is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.26.1",
                            Type = @"Component",
                            Position = @"GT1.26.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.26.2",
                            Type = @"Component",
                            Position = @"GT1.26.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.26.3",
                            Type = @"Component",
                            Position = @"GT1.26.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.26.4",
                            Type = @"Component",
                            Position = @"GT1.26.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.26.5",
                            Type = @"Component",
                            Position = @"GT1.26.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.26.6",
                            Type = @"Component",
                            Position = @"GT1.26.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorChargeAdjustmentCode = new HL7V231Field
        {
            field = message[@"GT1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorChargeAdjustmentCode.field.FieldRepetitions != null && _guarantorChargeAdjustmentCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorChargeAdjustmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorChargeAdjustmentCode, fieldData);
        }

        return _guarantorChargeAdjustmentCode;
    } 
}

internal HL7V231Field _guarantorHouseholdAnnualIncome;

public HL7V231Field GuarantorHouseholdAnnualIncome
{
    get
    {
        if (_guarantorHouseholdAnnualIncome != null)
        {
            return _guarantorHouseholdAnnualIncome;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.27",
            Type = @"Field",
            Position = @"GT1.27",
            Name = @"Guarantor Household Annual Income",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the combined annual income of all members of the guarantor's household.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.27.1",
                            Type = @"Component",
                            Position = @"GT1.27.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents of price: <quantity> & <denomination>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.27.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.27.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.27.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. Example:",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.2",
                            Type = @"Component",
                            Position = @"GT1.27.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.3",
                            Type = @"Component",
                            Position = @"GT1.27.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.4",
                            Type = @"Component",
                            Position = @"GT1.27.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5",
                            Type = @"Component",
                            Position = @"GT1.27.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents of range units: <identifier (ID)> & <text (ST)> & <name of coding system (ST)> & <alternate identifier (ID)> & <alternate text (ST)> & <name of alternate coding system (ST)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.1",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.2",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.3",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.4",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.5",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.27.5.6",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.6",
                            Type = @"Component",
                            Position = @"GT1.27.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorHouseholdAnnualIncome = new HL7V231Field
        {
            field = message[@"GT1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHouseholdAnnualIncome.field.FieldRepetitions != null && _guarantorHouseholdAnnualIncome.field.FieldRepetitions.Count > 0)
        {
            _guarantorHouseholdAnnualIncome.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorHouseholdAnnualIncome, fieldData);
        }

        return _guarantorHouseholdAnnualIncome;
    } 
}

internal HL7V231Field _guarantorHouseholdSize;

public HL7V231Field GuarantorHouseholdSize
{
    get
    {
        if (_guarantorHouseholdSize != null)
        {
            return _guarantorHouseholdSize;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.28",
            Type = @"Field",
            Position = @"GT1.28",
            Name = @"Guarantor Household Size",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the number of people living at the guarantor's primary residence.",
            Sample = @"",
            Fields = null
        }

        _guarantorHouseholdSize = new HL7V231Field
        {
            field = message[@"GT1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHouseholdSize.field.FieldRepetitions != null && _guarantorHouseholdSize.field.FieldRepetitions.Count > 0)
        {
            _guarantorHouseholdSize.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorHouseholdSize, fieldData);
        }

        return _guarantorHouseholdSize;
    } 
}

internal HL7V231Field _guarantorEmployerIDNumber;

public HL7V231Field GuarantorEmployerIDNumber
{
    get
    {
        if (_guarantorEmployerIDNumber != null)
        {
            return _guarantorEmployerIDNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.29",
            Type = @"Field",
            Position = @"GT1.29",
            Name = @"Guarantor Employer ID Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This is a code that uniquely identifies the guarantor's employer when the employer is a person. It may be a user-defined code or a code defined by a government agency (Federal Tax ID#).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.29.1",
                            Type = @"Component",
                            Position = @"GT1.29.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that a ST data type is allowed instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.2",
                            Type = @"Component",
                            Position = @"GT1.29.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.3",
                            Type = @"Component",
                            Position = @"GT1.29.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.8.5, CK - composite ID with check digit). Refer to HL7 table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.4",
                            Type = @"Component",
                            Position = @"GT1.29.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.29.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.5",
                            Type = @"Component",
                            Position = @"GT1.29.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.6",
                            Type = @"Component",
                            Position = @"GT1.29.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"Subcomponents: <namespace ID (IS)> & < universal ID (ST)> & <universal ID type (ID)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.29.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.29.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _guarantorEmployerIDNumber = new HL7V231Field
        {
            field = message[@"GT1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerIDNumber.field.FieldRepetitions != null && _guarantorEmployerIDNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployerIDNumber, fieldData);
        }

        return _guarantorEmployerIDNumber;
    } 
}

internal HL7V231Field _guarantorMaritalStatusCode;

public HL7V231Field GuarantorMaritalStatusCode
{
    get
    {
        if (_guarantorMaritalStatusCode != null)
        {
            return _guarantorMaritalStatusCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.30",
            Type = @"Field",
            Position = @"GT1.30",
            Name = @"Guarantor Marital Status Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the marital status of the guarantor. Refer to user-defined table 0002 - Marital status for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.30.1",
                            Type = @"Component",
                            Position = @"GT1.30.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.30.2",
                            Type = @"Component",
                            Position = @"GT1.30.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.30.3",
                            Type = @"Component",
                            Position = @"GT1.30.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.30.4",
                            Type = @"Component",
                            Position = @"GT1.30.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.30.5",
                            Type = @"Component",
                            Position = @"GT1.30.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.30.6",
                            Type = @"Component",
                            Position = @"GT1.30.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorMaritalStatusCode = new HL7V231Field
        {
            field = message[@"GT1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorMaritalStatusCode.field.FieldRepetitions != null && _guarantorMaritalStatusCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorMaritalStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorMaritalStatusCode, fieldData);
        }

        return _guarantorMaritalStatusCode;
    } 
}

internal HL7V231Field _guarantorHireEffectiveDate;

public HL7V231Field GuarantorHireEffectiveDate
{
    get
    {
        if (_guarantorHireEffectiveDate != null)
        {
            return _guarantorHireEffectiveDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.31",
            Type = @"Field",
            Position = @"GT1.31",
            Name = @"Guarantor Hire Effective Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the guarantor's employment began.",
            Sample = @"",
            Fields = null
        }

        _guarantorHireEffectiveDate = new HL7V231Field
        {
            field = message[@"GT1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHireEffectiveDate.field.FieldRepetitions != null && _guarantorHireEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _guarantorHireEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorHireEffectiveDate, fieldData);
        }

        return _guarantorHireEffectiveDate;
    } 
}

internal HL7V231Field _employmentStopDate;

public HL7V231Field EmploymentStopDate
{
    get
    {
        if (_employmentStopDate != null)
        {
            return _employmentStopDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.32",
            Type = @"Field",
            Position = @"GT1.32",
            Name = @"Employment Stop Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date on which the guarantor's employment with a particular employer ended.",
            Sample = @"",
            Fields = null
        }

        _employmentStopDate = new HL7V231Field
        {
            field = message[@"GT1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentStopDate.field.FieldRepetitions != null && _employmentStopDate.field.FieldRepetitions.Count > 0)
        {
            _employmentStopDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_employmentStopDate, fieldData);
        }

        return _employmentStopDate;
    } 
}

internal HL7V231Field _livingDependency;

public HL7V231Field LivingDependency
{
    get
    {
        if (_livingDependency != null)
        {
            return _livingDependency;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.33",
            Type = @"Field",
            Position = @"GT1.33",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living dependency",
            Description = @"Identifies the specific living conditions of the guarantor. Refer to user-defined table 0223 - Living dependency for suggested values.",
            Sample = @"",
            Fields = null
        }

        _livingDependency = new HL7V231Field
        {
            field = message[@"GT1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingDependency.field.FieldRepetitions != null && _livingDependency.field.FieldRepetitions.Count > 0)
        {
            _livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_livingDependency, fieldData);
        }

        return _livingDependency;
    } 
}

internal HL7V231Field _ambulatoryStatus;

public HL7V231Field AmbulatoryStatus
{
    get
    {
        if (_ambulatoryStatus != null)
        {
            return _ambulatoryStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.34",
            Type = @"Field",
            Position = @"GT1.34",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"Identifies the transient state of mobility for the guarantor. Refer to user-defined table 0009 - Ambulatory status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatus = new HL7V231Field
        {
            field = message[@"GT1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatus.field.FieldRepetitions != null && _ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_ambulatoryStatus, fieldData);
        }

        return _ambulatoryStatus;
    } 
}

internal HL7V231Field _citizenship;

public HL7V231Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.35",
            Type = @"Field",
            Position = @"GT1.35",
            Name = @"Citizenship",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the code to identify the guarantor's citizenship. HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.35.1",
                            Type = @"Component",
                            Position = @"GT1.35.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.35.2",
                            Type = @"Component",
                            Position = @"GT1.35.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.35.3",
                            Type = @"Component",
                            Position = @"GT1.35.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.35.4",
                            Type = @"Component",
                            Position = @"GT1.35.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.35.5",
                            Type = @"Component",
                            Position = @"GT1.35.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.35.6",
                            Type = @"Component",
                            Position = @"GT1.35.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _citizenship = new HL7V231Field
        {
            field = message[@"GT1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V231Field _primaryLanguage;

public HL7V231Field PrimaryLanguage
{
    get
    {
        if (_primaryLanguage != null)
        {
            return _primaryLanguage;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.36",
            Type = @"Field",
            Position = @"GT1.36",
            Name = @"Primary Language",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary language",
            Description = @"This field identifies the guarantor's primary speaking language. HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.36.1",
                            Type = @"Component",
                            Position = @"GT1.36.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.36.2",
                            Type = @"Component",
                            Position = @"GT1.36.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.36.3",
                            Type = @"Component",
                            Position = @"GT1.36.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.36.4",
                            Type = @"Component",
                            Position = @"GT1.36.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.36.5",
                            Type = @"Component",
                            Position = @"GT1.36.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.36.6",
                            Type = @"Component",
                            Position = @"GT1.36.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryLanguage = new HL7V231Field
        {
            field = message[@"GT1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryLanguage.field.FieldRepetitions != null && _primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            _primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_primaryLanguage, fieldData);
        }

        return _primaryLanguage;
    } 
}

internal HL7V231Field _livingArrangement;

public HL7V231Field LivingArrangement
{
    get
    {
        if (_livingArrangement != null)
        {
            return _livingArrangement;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.37",
            Type = @"Field",
            Position = @"GT1.37",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living arrangement",
            Description = @"This field identifies the situation in which the person lives at his residential address. Refer to the user-defined table 0220- Living arrangement for suggested values.",
            Sample = @"",
            Fields = null
        }

        _livingArrangement = new HL7V231Field
        {
            field = message[@"GT1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingArrangement.field.FieldRepetitions != null && _livingArrangement.field.FieldRepetitions.Count > 0)
        {
            _livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_livingArrangement, fieldData);
        }

        return _livingArrangement;
    } 
}

internal HL7V231Field _publicityCode;

public HL7V231Field PublicityCode
{
    get
    {
        if (_publicityCode != null)
        {
            return _publicityCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.38",
            Type = @"Field",
            Position = @"GT1.38",
            Name = @"Publicity Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for a guarantor. User-defined table 0215 - Publicity code is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.38.1",
                            Type = @"Component",
                            Position = @"GT1.38.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.38.2",
                            Type = @"Component",
                            Position = @"GT1.38.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.38.3",
                            Type = @"Component",
                            Position = @"GT1.38.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.38.4",
                            Type = @"Component",
                            Position = @"GT1.38.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.38.5",
                            Type = @"Component",
                            Position = @"GT1.38.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.38.6",
                            Type = @"Component",
                            Position = @"GT1.38.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _publicityCode = new HL7V231Field
        {
            field = message[@"GT1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_publicityCode.field.FieldRepetitions != null && _publicityCode.field.FieldRepetitions.Count > 0)
        {
            _publicityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_publicityCode, fieldData);
        }

        return _publicityCode;
    } 
}

internal HL7V231Field _protectionIndicator;

public HL7V231Field ProtectionIndicator
{
    get
    {
        if (_protectionIndicator != null)
        {
            return _protectionIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.39",
            Type = @"Field",
            Position = @"GT1.39",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the guarantor's protection, which determines whether or not access to information about this enrollee should be restricted from users who do not have adequate authority. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _protectionIndicator = new HL7V231Field
        {
            field = message[@"GT1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_protectionIndicator.field.FieldRepetitions != null && _protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_protectionIndicator, fieldData);
        }

        return _protectionIndicator;
    } 
}

internal HL7V231Field _studentIndicator;

public HL7V231Field StudentIndicator
{
    get
    {
        if (_studentIndicator != null)
        {
            return _studentIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.40",
            Type = @"Field",
            Position = @"GT1.40",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student status",
            Description = @"This field indicates whether the guarantor is currently a student, and whether the guarantor is a full-time or part-time student. This field does not indicate the degree level (high school, college) of the student, or his/her field of study (accounting, engineering, etc.). Referto user-defined table 0231- Student status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _studentIndicator = new HL7V231Field
        {
            field = message[@"GT1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studentIndicator.field.FieldRepetitions != null && _studentIndicator.field.FieldRepetitions.Count > 0)
        {
            _studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_studentIndicator, fieldData);
        }

        return _studentIndicator;
    } 
}

internal HL7V231Field _religion;

public HL7V231Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.41",
            Type = @"Field",
            Position = @"GT1.41",
            Name = @"Religion",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field indicates the type of religion practiced by the guarantor. User-defined table 0006 - Religion is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.41.1",
                            Type = @"Component",
                            Position = @"GT1.41.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.41.2",
                            Type = @"Component",
                            Position = @"GT1.41.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.41.3",
                            Type = @"Component",
                            Position = @"GT1.41.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.41.4",
                            Type = @"Component",
                            Position = @"GT1.41.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.41.5",
                            Type = @"Component",
                            Position = @"GT1.41.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.41.6",
                            Type = @"Component",
                            Position = @"GT1.41.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _religion = new HL7V231Field
        {
            field = message[@"GT1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V231Field _mothersMaidenName;

public HL7V231Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.42",
            Type = @"Field",
            Position = @"GT1.42",
            Name = @"Mother s Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the guarantor's mother's maiden name.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.42.1",
                            Type = @"Component",
                            Position = @"GT1.42.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.42.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.42.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.42.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.2",
                            Type = @"Component",
                            Position = @"GT1.42.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.3",
                            Type = @"Component",
                            Position = @"GT1.42.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.42.4",
                            Type = @"Component",
                            Position = @"GT1.42.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.5",
                            Type = @"Component",
                            Position = @"GT1.42.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.6",
                            Type = @"Component",
                            Position = @"GT1.42.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.7",
                            Type = @"Component",
                            Position = @"GT1.42.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.42.8",
                            Type = @"Component",
                            Position = @"GT1.42.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _mothersMaidenName = new HL7V231Field
        {
            field = message[@"GT1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V231Field _nationality;

public HL7V231Field Nationality
{
    get
    {
        if (_nationality != null)
        {
            return _nationality;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.43",
            Type = @"Field",
            Position = @"GT1.43",
            Name = @"Nationality",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field contains a code that identifies the nation or national grouping to which the person belongs. This may be different from a person's citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.). HL7 recommends using ISO table 3166 as suggested values in user-defined table 0212 - Nationality.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.43.1",
                            Type = @"Component",
                            Position = @"GT1.43.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.43.2",
                            Type = @"Component",
                            Position = @"GT1.43.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.43.3",
                            Type = @"Component",
                            Position = @"GT1.43.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.43.4",
                            Type = @"Component",
                            Position = @"GT1.43.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.43.5",
                            Type = @"Component",
                            Position = @"GT1.43.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.43.6",
                            Type = @"Component",
                            Position = @"GT1.43.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nationality = new HL7V231Field
        {
            field = message[@"GT1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nationality.field.FieldRepetitions != null && _nationality.field.FieldRepetitions.Count > 0)
        {
            _nationality.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_nationality, fieldData);
        }

        return _nationality;
    } 
}

internal HL7V231Field _ethnicGroup;

public HL7V231Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.44",
            Type = @"Field",
            Position = @"GT1.44",
            Name = @"Ethnic Group",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field contains the guarantor's ethnic group. ERISA has a published list of ethnic classifications that may be used by local agreement at a site. User-defined table 0189 - Ethnic group is used as the HL7 identifier for the user-defined table of values for this field. The second triplet of the CE data type for ethnic group (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.44.1",
                            Type = @"Component",
                            Position = @"GT1.44.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.44.2",
                            Type = @"Component",
                            Position = @"GT1.44.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.44.3",
                            Type = @"Component",
                            Position = @"GT1.44.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.44.4",
                            Type = @"Component",
                            Position = @"GT1.44.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.44.5",
                            Type = @"Component",
                            Position = @"GT1.44.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.44.6",
                            Type = @"Component",
                            Position = @"GT1.44.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _ethnicGroup = new HL7V231Field
        {
            field = message[@"GT1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V231Field _contactPersonsName;

public HL7V231Field ContactPersonsName
{
    get
    {
        if (_contactPersonsName != null)
        {
            return _contactPersonsName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.45",
            Type = @"Field",
            Position = @"GT1.45",
            Name = @"Contact Person s Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the person who should be contacted regarding the guarantor bills, etc. This may be someone other than the guarantor. (Contact guarantor's wife regarding all bills - guarantor lives out of country). The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.45.1",
                            Type = @"Component",
                            Position = @"GT1.45.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.45.1.1",
                            Type = @"SubComponent",
                            Position = @"GT1.45.1.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.1.2",
                            Type = @"SubComponent",
                            Position = @"GT1.45.1.2",
                            Name = @"Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.2",
                            Type = @"Component",
                            Position = @"GT1.45.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.3",
                            Type = @"Component",
                            Position = @"GT1.45.3",
                            Name = @"Middle Initial Or Name",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.45.4",
                            Type = @"Component",
                            Position = @"GT1.45.4",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.5",
                            Type = @"Component",
                            Position = @"GT1.45.5",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.6",
                            Type = @"Component",
                            Position = @"GT1.45.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.7",
                            Type = @"Component",
                            Position = @"GT1.45.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.45.8",
                            Type = @"Component",
                            Position = @"GT1.45.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactPersonsName = new HL7V231Field
        {
            field = message[@"GT1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsName.field.FieldRepetitions != null && _contactPersonsName.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_contactPersonsName, fieldData);
        }

        return _contactPersonsName;
    } 
}

internal HL7V231Field _contactPersonsTelephoneNumber;

public HL7V231Field ContactPersonsTelephoneNumber
{
    get
    {
        if (_contactPersonsTelephoneNumber != null)
        {
            return _contactPersonsTelephoneNumber;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.46",
            Type = @"Field",
            Position = @"GT1.46",
            Name = @"Contact Person s Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the guarantor (person) to contact regarding guarantor bills, etc. Multiple phone numbers for that person may be sent in this sequence. The primary telephone number is assumed to be in the first repetition. When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. The components for this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.46.1",
                            Type = @"Component",
                            Position = @"GT1.46.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type (see Section 2.8.42, TN - telephone number), except that the length of the country access code has been increased to three.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.2",
                            Type = @"Component",
                            Position = @"GT1.46.2",
                            Name = @"Telecommunication use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunication use code",
                            Description = @"A code that represents a specific use of a telecommunicationnumber. Refer to HL7 table 0201 - Telecommunication use code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.3",
                            Type = @"Component",
                            Position = @"GT1.46.3",
                            Name = @"Telecommunication equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunication equipment type",
                            Description = @"A code that represents the type of telecommunicationequipment. Refer to HL7 table 0202 - Telecommunication equipment type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.4",
                            Type = @"Component",
                            Position = @"GT1.46.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.46.5",
                            Type = @"Component",
                            Position = @"GT1.46.5",
                            Name = @"Country Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.6",
                            Type = @"Component",
                            Position = @"GT1.46.6",
                            Name = @"Area/City Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.7",
                            Type = @"Component",
                            Position = @"GT1.46.7",
                            Name = @"Phone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.8",
                            Type = @"Component",
                            Position = @"GT1.46.8",
                            Name = @"Extension",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.9",
                            Type = @"Component",
                            Position = @"GT1.46.9",
                            Name = @"Any Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactPersonsTelephoneNumber = new HL7V231Field
        {
            field = message[@"GT1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsTelephoneNumber.field.FieldRepetitions != null && _contactPersonsTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_contactPersonsTelephoneNumber, fieldData);
        }

        return _contactPersonsTelephoneNumber;
    } 
}

internal HL7V231Field _contactReason;

public HL7V231Field ContactReason
{
    get
    {
        if (_contactReason != null)
        {
            return _contactReason;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.47",
            Type = @"Field",
            Position = @"GT1.47",
            Name = @"Contact Reason",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field contains a user-defined code that identifies the reason for contacting the guarantor, for example, to phone the guarantor if payments are late. User-defined table 0222 - Contact reason is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.47.1",
                            Type = @"Component",
                            Position = @"GT1.47.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.47.2",
                            Type = @"Component",
                            Position = @"GT1.47.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.47.3",
                            Type = @"Component",
                            Position = @"GT1.47.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.47.4",
                            Type = @"Component",
                            Position = @"GT1.47.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.47.5",
                            Type = @"Component",
                            Position = @"GT1.47.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.47.6",
                            Type = @"Component",
                            Position = @"GT1.47.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactReason = new HL7V231Field
        {
            field = message[@"GT1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactReason.field.FieldRepetitions != null && _contactReason.field.FieldRepetitions.Count > 0)
        {
            _contactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_contactReason, fieldData);
        }

        return _contactReason;
    } 
}

internal HL7V231Field _contactRelationship;

public HL7V231Field ContactRelationship
{
    get
    {
        if (_contactRelationship != null)
        {
            return _contactRelationship;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.48",
            Type = @"Field",
            Position = @"GT1.48",
            Name = @"Contact Relationship",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"Identifies the guarantor relationship to the contact person specified above. Some examples of the relationship between the guarantor and the guarantor contact person might include wife, attorney, power of attorney, self, and organization. User-defined table 0063 - Relationship is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
            Fields = null
        }

        _contactRelationship = new HL7V231Field
        {
            field = message[@"GT1"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactRelationship.field.FieldRepetitions != null && _contactRelationship.field.FieldRepetitions.Count > 0)
        {
            _contactRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_contactRelationship, fieldData);
        }

        return _contactRelationship;
    } 
}

internal HL7V231Field _jobTitle;

public HL7V231Field JobTitle
{
    get
    {
        if (_jobTitle != null)
        {
            return _jobTitle;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.49",
            Type = @"Field",
            Position = @"GT1.49",
            Name = @"Job Title",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a descriptive name of the guarantor's occupation (e.g., Sr. Systems Analyst, Sr. Accountant).",
            Sample = @"",
            Fields = null
        }

        _jobTitle = new HL7V231Field
        {
            field = message[@"GT1"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobTitle.field.FieldRepetitions != null && _jobTitle.field.FieldRepetitions.Count > 0)
        {
            _jobTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_jobTitle, fieldData);
        }

        return _jobTitle;
    } 
}

internal HL7V231Field _jobCodeClass;

public HL7V231Field JobCodeClass
{
    get
    {
        if (_jobCodeClass != null)
        {
            return _jobCodeClass;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.50",
            Type = @"Field",
            Position = @"GT1.50",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code/class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor's job code and employee classification. Refer to user-defined tables 0327 - Job code and 0328 - Employee classification for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.50.1",
                            Type = @"Component",
                            Position = @"GT1.50.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code/class",
                            Description = @"This component contains the persons job code. User-defined table 0327 - Job code is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.50.2",
                            Type = @"Component",
                            Position = @"GT1.50.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the persons employee classification. User-defined table 0328 - Employee classification is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _jobCodeClass = new HL7V231Field
        {
            field = message[@"GT1"][50],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobCodeClass.field.FieldRepetitions != null && _jobCodeClass.field.FieldRepetitions.Count > 0)
        {
            _jobCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_jobCodeClass, fieldData);
        }

        return _jobCodeClass;
    } 
}

internal HL7V231Field _guarantorEmployersOrganizationName;

public HL7V231Field GuarantorEmployersOrganizationName
{
    get
    {
        if (_guarantorEmployersOrganizationName != null)
        {
            return _guarantorEmployersOrganizationName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.51",
            Type = @"Field",
            Position = @"GT1.51",
            Name = @"Guarantor Employer s Organization Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor's employer when the guarantor's employer is an organization. When the guarantor's employer is a person, use GT1-16 guarantor employer name. Multiple names for the same guarantor may be sent in this field. The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. The components of this data type are described in Chapter 2.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.51.1",
                            Type = @"Component",
                            Position = @"GT1.51.1",
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
                            Id = @"GT1.51.2",
                            Type = @"Component",
                            Position = @"GT1.51.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to user-defined table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.3",
                            Type = @"Component",
                            Position = @"GT1.51.3",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.4",
                            Type = @"Component",
                            Position = @"GT1.51.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.5",
                            Type = @"Component",
                            Position = @"GT1.51.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme .",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.6",
                            Type = @"Component",
                            Position = @"GT1.51.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.51.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.7",
                            Type = @"Component",
                            Position = @"GT1.51.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.8",
                            Type = @"Component",
                            Position = @"GT1.51.8",
                            Name = @"Assigning Facility Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.51.8.1",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.8.2",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.8.3",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.9",
                            Type = @"Component",
                            Position = @"GT1.51.9",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployersOrganizationName = new HL7V231Field
        {
            field = message[@"GT1"][51],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployersOrganizationName.field.FieldRepetitions != null && _guarantorEmployersOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployersOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorEmployersOrganizationName, fieldData);
        }

        return _guarantorEmployersOrganizationName;
    } 
}

internal HL7V231Field _handicap;

public HL7V231Field Handicap
{
    get
    {
        if (_handicap != null)
        {
            return _handicap;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.52",
            Type = @"Field",
            Position = @"GT1.52",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0295",
            TableName = @"Handicap",
            Description = @"This field contains a code to describe the guarantor's disability. User-defined table 0295 - Handicap is used as the HL7 identifier for the user-defined table of values for this field .",
            Sample = @"",
            Fields = null
        }

        _handicap = new HL7V231Field
        {
            field = message[@"GT1"][52],
            fieldData = fieldData
        };

        // check for repetitions
        if (_handicap.field.FieldRepetitions != null && _handicap.field.FieldRepetitions.Count > 0)
        {
            _handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_handicap, fieldData);
        }

        return _handicap;
    } 
}

internal HL7V231Field _jobStatus;

public HL7V231Field JobStatus
{
    get
    {
        if (_jobStatus != null)
        {
            return _jobStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.53",
            Type = @"Field",
            Position = @"GT1.53",
            Name = @"Job Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0311",
            TableName = @"Job status",
            Description = @"This field contains a code that identifies the guarantor's current job status, for example, part- time/workers comp, full-time/leave of absence, full-time/suspended. User-defined table 0311 - Job status is used as the HL7 identifier for the user-defined tables of values for this field.",
            Sample = @"",
            Fields = null
        }

        _jobStatus = new HL7V231Field
        {
            field = message[@"GT1"][53],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobStatus.field.FieldRepetitions != null && _jobStatus.field.FieldRepetitions.Count > 0)
        {
            _jobStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_jobStatus, fieldData);
        }

        return _jobStatus;
    } 
}

internal HL7V231Field _guarantorFinancialClass;

public HL7V231Field GuarantorFinancialClass
{
    get
    {
        if (_guarantorFinancialClass != null)
        {
            return _guarantorFinancialClass;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.54",
            Type = @"Field",
            Position = @"GT1.54",
            Name = @"Guarantor Financial Class",
            Length = 50,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"FC",
            DataTypeName = @"Financial Class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the financial class (FC) assigned to the guarantor for the purpose of identifying sources of reimbursement. It can be different than that of the patient. When the FC of the guarantor is different than the FC of the patient, and the guarantor's coverage for that patient has been exhausted, the source of reimbursement falls back onto the FC of the patient. User-defined table 0064 - Financial class is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.54.1",
                            Type = @"Component",
                            Position = @"GT1.54.1",
                            Name = @"Financial Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0064",
                            TableName = @"Financial class",
                            Description = @"This component contains the financial class assigned to a person. User-defined table 0064 - Financial class is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.54.2",
                            Type = @"Component",
                            Position = @"GT1.54.2",
                            Name = @"Effective Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the effective date/time of the persons assignment to the financial class specified in the first component.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.54.2.1",
                            Type = @"SubComponent",
                            Position = @"GT1.54.2.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _guarantorFinancialClass = new HL7V231Field
        {
            field = message[@"GT1"][54],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorFinancialClass.field.FieldRepetitions != null && _guarantorFinancialClass.field.FieldRepetitions.Count > 0)
        {
            _guarantorFinancialClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorFinancialClass, fieldData);
        }

        return _guarantorFinancialClass;
    } 
}

internal HL7V231Field _guarantorRace;

public HL7V231Field GuarantorRace
{
    get
    {
        if (_guarantorRace != null)
        {
            return _guarantorRace;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"GT1.55",
            Type = @"Field",
            Position = @"GT1.55",
            Name = @"Guarantor Race",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"This field refers to the guarantor's race. User-defined table 0005 - Race is used as the HL7 identifier for the user-defined table of values for this field . The second triplet of the CE data type for race (alternate identifier, alternate text, and name of alternate coding system) is reserved for governmentally assigned codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.55.1",
                            Type = @"Component",
                            Position = @"GT1.55.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.55.2",
                            Type = @"Component",
                            Position = @"GT1.55.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.55.3",
                            Type = @"Component",
                            Position = @"GT1.55.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.55.4",
                            Type = @"Component",
                            Position = @"GT1.55.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.55.5",
                            Type = @"Component",
                            Position = @"GT1.55.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"GT1.55.6",
                            Type = @"Component",
                            Position = @"GT1.55.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorRace = new HL7V231Field
        {
            field = message[@"GT1"][55],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRace.field.FieldRepetitions != null && _guarantorRace.field.FieldRepetitions.Count > 0)
        {
            _guarantorRace.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_guarantorRace, fieldData);
        }

        return _guarantorRace;
    } 
}
    }
}

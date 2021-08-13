using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentSTF
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"STF"; } }

        public string SegmentId { get { return @"STF"; } }
        
        public string LongName { get { return @"Staff identification segment"; } }
        
        public string Description { get { return @"The STF segment can identify any personnel referenced by information systems. These can be providers, staff, system users, and referring agents. In a network environment, this segment can be used to define personnel to other applications; for example, order entry clerks, insurance verification clerks, admission clerks, as well as provider demographics. MFE-4-primary key value is used to link all the segments pertaining to the same master file entry. Therefore, in the MFE segment, MFE-4-primary key value must be filled in. Other segments may follow the STF segment to provide data for a particular type of staff member. The PRA segment (practitioner) is one such. It may optionally follow the STF segment in order to add practitioner-specific data. Other segments may be defined as needed."; } }
        
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

        public HL7V231SegmentSTF(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _primaryKeyValueSTF;

public HL7V231Field PrimaryKeyValueSTF
{
    get
    {
        if (_primaryKeyValueSTF != null)
        {
            return _primaryKeyValueSTF;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.1",
            Type = @"Field",
            Position = @"STF.1",
            Name = @"Primary Key Value - STF",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field must match MFE-4-primary key value to identify which entry is being referenced.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.1.1",
                            Type = @"Component",
                            Position = @"STF.1.1",
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
                            Id = @"STF.1.2",
                            Type = @"Component",
                            Position = @"STF.1.2",
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
                            Id = @"STF.1.3",
                            Type = @"Component",
                            Position = @"STF.1.3",
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
                            Id = @"STF.1.4",
                            Type = @"Component",
                            Position = @"STF.1.4",
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
                            Id = @"STF.1.5",
                            Type = @"Component",
                            Position = @"STF.1.5",
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
                            Id = @"STF.1.6",
                            Type = @"Component",
                            Position = @"STF.1.6",
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

        _primaryKeyValueSTF = new HL7V231Field
        {
            field = message[@"STF"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueSTF.field.FieldRepetitions != null && _primaryKeyValueSTF.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueSTF.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_primaryKeyValueSTF, fieldData);
        }

        return _primaryKeyValueSTF;
    } 
}

internal HL7V231Field _staffIDCode;

public HL7V231Field StaffIDCode
{
    get
    {
        if (_staffIDCode != null)
        {
            return _staffIDCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.2",
            Type = @"Field",
            Position = @"STF.2",
            Name = @"Staff ID Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains a personnel identification code or institution user number, used by the institution to identify this person. Repeating field allows multiple ID codes per person, with the type of ID code indicated in the third component of the coded entry data type.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.2.1",
                            Type = @"Component",
                            Position = @"STF.2.1",
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
                            Id = @"STF.2.2",
                            Type = @"Component",
                            Position = @"STF.2.2",
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
                            Id = @"STF.2.3",
                            Type = @"Component",
                            Position = @"STF.2.3",
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
                            Id = @"STF.2.4",
                            Type = @"Component",
                            Position = @"STF.2.4",
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
                            Id = @"STF.2.4.1",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.1",
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
                            Id = @"STF.2.4.2",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.2",
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
                            Id = @"STF.2.4.3",
                            Type = @"SubComponent",
                            Position = @"STF.2.4.3",
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
                            Id = @"STF.2.5",
                            Type = @"Component",
                            Position = @"STF.2.5",
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
                            Id = @"STF.2.6",
                            Type = @"Component",
                            Position = @"STF.2.6",
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
                            Id = @"STF.2.6.1",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.1",
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
                            Id = @"STF.2.6.2",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.2",
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
                            Id = @"STF.2.6.3",
                            Type = @"SubComponent",
                            Position = @"STF.2.6.3",
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

        _staffIDCode = new HL7V231Field
        {
            field = message[@"STF"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffIDCode.field.FieldRepetitions != null && _staffIDCode.field.FieldRepetitions.Count > 0)
        {
            _staffIDCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_staffIDCode, fieldData);
        }

        return _staffIDCode;
    } 
}

internal HL7V231Field _staffName;

public HL7V231Field StaffName
{
    get
    {
        if (_staffName != null)
        {
            return _staffName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.3",
            Type = @"Field",
            Position = @"STF.3",
            Name = @"Staff Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff person's name.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.3.1",
                            Type = @"Component",
                            Position = @"STF.3.1",
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
                            Id = @"STF.3.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.1",
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
                            Id = @"STF.3.1.2",
                            Type = @"SubComponent",
                            Position = @"STF.3.1.2",
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
                            Id = @"STF.3.2",
                            Type = @"Component",
                            Position = @"STF.3.2",
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
                            Id = @"STF.3.3",
                            Type = @"Component",
                            Position = @"STF.3.3",
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
                            Id = @"STF.3.4",
                            Type = @"Component",
                            Position = @"STF.3.4",
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
                            Id = @"STF.3.5",
                            Type = @"Component",
                            Position = @"STF.3.5",
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
                            Id = @"STF.3.6",
                            Type = @"Component",
                            Position = @"STF.3.6",
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
                            Id = @"STF.3.7",
                            Type = @"Component",
                            Position = @"STF.3.7",
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
                            Id = @"STF.3.8",
                            Type = @"Component",
                            Position = @"STF.3.8",
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

        _staffName = new HL7V231Field
        {
            field = message[@"STF"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffName.field.FieldRepetitions != null && _staffName.field.FieldRepetitions.Count > 0)
        {
            _staffName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_staffName, fieldData);
        }

        return _staffName;
    } 
}

internal HL7V231Field _staffType;

public HL7V231Field StaffType
{
    get
    {
        if (_staffType != null)
        {
            return _staffType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.4",
            Type = @"Field",
            Position = @"STF.4",
            Name = @"Staff Type",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0182",
            TableName = @"Staff Type",
            Description = @"This field contains a code identifying what type of staff. User-definedtable 0182 - Staff type is used as the HL7 identifier for the user-defined table of values for this field. Values may include codes for staff, practitioner (physician, nurse, therapist, etc.), referral agent or agency, etc.",
            Sample = @"",
            Fields = null
        }

        _staffType = new HL7V231Field
        {
            field = message[@"STF"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_staffType.field.FieldRepetitions != null && _staffType.field.FieldRepetitions.Count > 0)
        {
            _staffType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_staffType, fieldData);
        }

        return _staffType;
    } 
}

internal HL7V231Field _sex;

public HL7V231Field Sex
{
    get
    {
        if (_sex != null)
        {
            return _sex;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.5",
            Type = @"Field",
            Position = @"STF.5",
            Name = @"Sex",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0001",
            TableName = @"Sex",
            Description = @"This field contains the staff person's sex. Refer to user-defined table 0001 - Sex for suggested values.",
            Sample = @"",
            Fields = null
        }

        _sex = new HL7V231Field
        {
            field = message[@"STF"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sex.field.FieldRepetitions != null && _sex.field.FieldRepetitions.Count > 0)
        {
            _sex.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_sex, fieldData);
        }

        return _sex;
    } 
}

internal HL7V231Field _dateTimeOfBirth;

public HL7V231Field DateTimeOfBirth
{
    get
    {
        if (_dateTimeOfBirth != null)
        {
            return _dateTimeOfBirth;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.6",
            Type = @"Field",
            Position = @"STF.6",
            Name = @"Date/Time Of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains a staff member's date and time of birth.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.6.1",
                            Type = @"Component",
                            Position = @"STF.6.1",
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

        _dateTimeOfBirth = new HL7V231Field
        {
            field = message[@"STF"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeOfBirth.field.FieldRepetitions != null && _dateTimeOfBirth.field.FieldRepetitions.Count > 0)
        {
            _dateTimeOfBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateTimeOfBirth, fieldData);
        }

        return _dateTimeOfBirth;
    } 
}

internal HL7V231Field _activeInactiveFlag;

public HL7V231Field ActiveInactiveFlag
{
    get
    {
        if (_activeInactiveFlag != null)
        {
            return _activeInactiveFlag;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.7",
            Type = @"Field",
            Position = @"STF.7",
            Name = @"Active/Inactive Flag",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0183",
            TableName = @"Active/Inactive",
            Description = @"This field indicates whether person is currently a valid staff member. Refer to HL7 table 0183 - Active/inactive for valid values.",
            Sample = @"",
            Fields = null
        }

        _activeInactiveFlag = new HL7V231Field
        {
            field = message[@"STF"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_activeInactiveFlag.field.FieldRepetitions != null && _activeInactiveFlag.field.FieldRepetitions.Count > 0)
        {
            _activeInactiveFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_activeInactiveFlag, fieldData);
        }

        return _activeInactiveFlag;
    } 
}

internal HL7V231Field _department;

public HL7V231Field Department
{
    get
    {
        if (_department != null)
        {
            return _department;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.8",
            Type = @"Field",
            Position = @"STF.8",
            Name = @"Department",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0184",
            TableName = @"Department",
            Description = @"This field contains the institution department to which this person reports or belongs. User-defined table 0184 - Department is used as the HL7 identifier for the user-defined table of values for this field. .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.8.1",
                            Type = @"Component",
                            Position = @"STF.8.1",
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
                            Id = @"STF.8.2",
                            Type = @"Component",
                            Position = @"STF.8.2",
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
                            Id = @"STF.8.3",
                            Type = @"Component",
                            Position = @"STF.8.3",
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
                            Id = @"STF.8.4",
                            Type = @"Component",
                            Position = @"STF.8.4",
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
                            Id = @"STF.8.5",
                            Type = @"Component",
                            Position = @"STF.8.5",
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
                            Id = @"STF.8.6",
                            Type = @"Component",
                            Position = @"STF.8.6",
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

        _department = new HL7V231Field
        {
            field = message[@"STF"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_department.field.FieldRepetitions != null && _department.field.FieldRepetitions.Count > 0)
        {
            _department.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_department, fieldData);
        }

        return _department;
    } 
}

internal HL7V231Field _hospitalService;

public HL7V231Field HospitalService
{
    get
    {
        if (_hospitalService != null)
        {
            return _hospitalService;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.9",
            Type = @"Field",
            Position = @"STF.9",
            Name = @"Hospital Service",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0069",
            TableName = @"Hospital service",
            Description = @"This field contains the hospital or ancillary service with which this staff person is associated. User-defined table 0069 - Hospital service is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.9.1",
                            Type = @"Component",
                            Position = @"STF.9.1",
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
                            Id = @"STF.9.2",
                            Type = @"Component",
                            Position = @"STF.9.2",
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
                            Id = @"STF.9.3",
                            Type = @"Component",
                            Position = @"STF.9.3",
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
                            Id = @"STF.9.4",
                            Type = @"Component",
                            Position = @"STF.9.4",
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
                            Id = @"STF.9.5",
                            Type = @"Component",
                            Position = @"STF.9.5",
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
                            Id = @"STF.9.6",
                            Type = @"Component",
                            Position = @"STF.9.6",
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

        _hospitalService = new HL7V231Field
        {
            field = message[@"STF"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hospitalService.field.FieldRepetitions != null && _hospitalService.field.FieldRepetitions.Count > 0)
        {
            _hospitalService.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_hospitalService, fieldData);
        }

        return _hospitalService;
    } 
}

internal HL7V231Field _phone;

public HL7V231Field Phone
{
    get
    {
        if (_phone != null)
        {
            return _phone;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.10",
            Type = @"Field",
            Position = @"STF.10",
            Name = @"Phone",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff person's phone number. This is a repeating field with a component for indicating which phone number is which. It is recommended that the last part of the XTN, [C any text], start with a code from the table associated below with STF-16-preferred method of contact , in order to indicate the type of each phone number in this repeating field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.10.1",
                            Type = @"Component",
                            Position = @"STF.10.1",
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
                            Id = @"STF.10.2",
                            Type = @"Component",
                            Position = @"STF.10.2",
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
                            Id = @"STF.10.3",
                            Type = @"Component",
                            Position = @"STF.10.3",
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
                            Id = @"STF.10.4",
                            Type = @"Component",
                            Position = @"STF.10.4",
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
                            Id = @"STF.10.5",
                            Type = @"Component",
                            Position = @"STF.10.5",
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
                            Id = @"STF.10.6",
                            Type = @"Component",
                            Position = @"STF.10.6",
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
                            Id = @"STF.10.7",
                            Type = @"Component",
                            Position = @"STF.10.7",
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
                            Id = @"STF.10.8",
                            Type = @"Component",
                            Position = @"STF.10.8",
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
                            Id = @"STF.10.9",
                            Type = @"Component",
                            Position = @"STF.10.9",
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

        _phone = new HL7V231Field
        {
            field = message[@"STF"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_phone.field.FieldRepetitions != null && _phone.field.FieldRepetitions.Count > 0)
        {
            _phone.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_phone, fieldData);
        }

        return _phone;
    } 
}

internal HL7V231Field _officeHomeAddress;

public HL7V231Field OfficeHomeAddress
{
    get
    {
        if (_officeHomeAddress != null)
        {
            return _officeHomeAddress;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.11",
            Type = @"Field",
            Position = @"STF.11",
            Name = @"Office/Home Address",
            Length = 106,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the office address and home address of the staff person. This is a repeating field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.11.1",
                            Type = @"Component",
                            Position = @"STF.11.1",
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
                            Id = @"STF.11.2",
                            Type = @"Component",
                            Position = @"STF.11.2",
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
                            Id = @"STF.11.3",
                            Type = @"Component",
                            Position = @"STF.11.3",
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
                            Id = @"STF.11.4",
                            Type = @"Component",
                            Position = @"STF.11.4",
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
                            Id = @"STF.11.5",
                            Type = @"Component",
                            Position = @"STF.11.5",
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
                            Id = @"STF.11.6",
                            Type = @"Component",
                            Position = @"STF.11.6",
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
                            Id = @"STF.11.7",
                            Type = @"Component",
                            Position = @"STF.11.7",
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
                            Id = @"STF.11.8",
                            Type = @"Component",
                            Position = @"STF.11.8",
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
                            Id = @"STF.11.9",
                            Type = @"Component",
                            Position = @"STF.11.9",
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
                            Id = @"STF.11.10",
                            Type = @"Component",
                            Position = @"STF.11.10",
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
                            Id = @"STF.11.11",
                            Type = @"Component",
                            Position = @"STF.11.11",
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

        _officeHomeAddress = new HL7V231Field
        {
            field = message[@"STF"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_officeHomeAddress.field.FieldRepetitions != null && _officeHomeAddress.field.FieldRepetitions.Count > 0)
        {
            _officeHomeAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_officeHomeAddress, fieldData);
        }

        return _officeHomeAddress;
    } 
}

internal HL7V231Field _institutionActivationDate;

public HL7V231Field InstitutionActivationDate
{
    get
    {
        if (_institutionActivationDate != null)
        {
            return _institutionActivationDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.12",
            Type = @"Field",
            Position = @"STF.12",
            Name = @"Institution Activation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date when staff became active for an institution. Repeats.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.12.1",
                            Type = @"Component",
                            Position = @"STF.12.1",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.12.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.1.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.12.2",
                            Type = @"Component",
                            Position = @"STF.12.2",
                            Name = @"Institution Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.12.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.1",
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
                            Id = @"STF.12.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.2",
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
                            Id = @"STF.12.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.3",
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
                            Id = @"STF.12.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.4",
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
                            Id = @"STF.12.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.5",
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
                            Id = @"STF.12.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.12.2.6",
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
                        }
        }

        _institutionActivationDate = new HL7V231Field
        {
            field = message[@"STF"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_institutionActivationDate.field.FieldRepetitions != null && _institutionActivationDate.field.FieldRepetitions.Count > 0)
        {
            _institutionActivationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_institutionActivationDate, fieldData);
        }

        return _institutionActivationDate;
    } 
}

internal HL7V231Field _institutionInactivationDate;

public HL7V231Field InstitutionInactivationDate
{
    get
    {
        if (_institutionInactivationDate != null)
        {
            return _institutionInactivationDate;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.13",
            Type = @"Field",
            Position = @"STF.13",
            Name = @"Institution Inactivation Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DIN",
            DataTypeName = @"Activation Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date when staff became inactive for an institution. Repeats.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.13.1",
                            Type = @"Component",
                            Position = @"STF.13.1",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.13.1.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.1.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.13.2",
                            Type = @"Component",
                            Position = @"STF.13.2",
                            Name = @"Institution Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"STF.13.2.1",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.1",
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
                            Id = @"STF.13.2.2",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.2",
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
                            Id = @"STF.13.2.3",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.3",
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
                            Id = @"STF.13.2.4",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.4",
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
                            Id = @"STF.13.2.5",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.5",
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
                            Id = @"STF.13.2.6",
                            Type = @"SubComponent",
                            Position = @"STF.13.2.6",
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
                        }
        }

        _institutionInactivationDate = new HL7V231Field
        {
            field = message[@"STF"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_institutionInactivationDate.field.FieldRepetitions != null && _institutionInactivationDate.field.FieldRepetitions.Count > 0)
        {
            _institutionInactivationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_institutionInactivationDate, fieldData);
        }

        return _institutionInactivationDate;
    } 
}

internal HL7V231Field _backupPersonID;

public HL7V231Field BackupPersonID
{
    get
    {
        if (_backupPersonID != null)
        {
            return _backupPersonID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.14",
            Type = @"Field",
            Position = @"STF.14",
            Name = @"Backup Person ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the MFE-4-primary key value of the master file entry which corresponds to the designated backup person for this staff person.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.14.1",
                            Type = @"Component",
                            Position = @"STF.14.1",
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
                            Id = @"STF.14.2",
                            Type = @"Component",
                            Position = @"STF.14.2",
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
                            Id = @"STF.14.3",
                            Type = @"Component",
                            Position = @"STF.14.3",
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
                            Id = @"STF.14.4",
                            Type = @"Component",
                            Position = @"STF.14.4",
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
                            Id = @"STF.14.5",
                            Type = @"Component",
                            Position = @"STF.14.5",
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
                            Id = @"STF.14.6",
                            Type = @"Component",
                            Position = @"STF.14.6",
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

        _backupPersonID = new HL7V231Field
        {
            field = message[@"STF"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_backupPersonID.field.FieldRepetitions != null && _backupPersonID.field.FieldRepetitions.Count > 0)
        {
            _backupPersonID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_backupPersonID, fieldData);
        }

        return _backupPersonID;
    } 
}

internal HL7V231Field _eMailAddress;

public HL7V231Field EMailAddress
{
    get
    {
        if (_eMailAddress != null)
        {
            return _eMailAddress;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.15",
            Type = @"Field",
            Position = @"STF.15",
            Name = @"E-Mail Address",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility. (It is now present in the fourth component of STF-10-phone).",
            Sample = @"",
            Fields = null
        }

        _eMailAddress = new HL7V231Field
        {
            field = message[@"STF"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eMailAddress.field.FieldRepetitions != null && _eMailAddress.field.FieldRepetitions.Count > 0)
        {
            _eMailAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_eMailAddress, fieldData);
        }

        return _eMailAddress;
    } 
}

internal HL7V231Field _preferredMethodOfContact;

public HL7V231Field PreferredMethodOfContact
{
    get
    {
        if (_preferredMethodOfContact != null)
        {
            return _preferredMethodOfContact;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.16",
            Type = @"Field",
            Position = @"STF.16",
            Name = @"Preferred Method Of Contact",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0185",
            TableName = @"Preferred method of contact",
            Description = @"This field indicates which of a group of multiple phone numbers is the preferred method of contact for this person. Note that all values of this code refer to this segment's phone field, except for the value 'E,' which refers to the E-mail address field. If more than one phone number of the preferred type exists in STF-10-phone, this field refers to the first such instance. Refer to HL7 table 0185 - Preferred method of contact for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.16.1",
                            Type = @"Component",
                            Position = @"STF.16.1",
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
                            Id = @"STF.16.2",
                            Type = @"Component",
                            Position = @"STF.16.2",
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
                            Id = @"STF.16.3",
                            Type = @"Component",
                            Position = @"STF.16.3",
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
                            Id = @"STF.16.4",
                            Type = @"Component",
                            Position = @"STF.16.4",
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
                            Id = @"STF.16.5",
                            Type = @"Component",
                            Position = @"STF.16.5",
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
                            Id = @"STF.16.6",
                            Type = @"Component",
                            Position = @"STF.16.6",
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

        _preferredMethodOfContact = new HL7V231Field
        {
            field = message[@"STF"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preferredMethodOfContact.field.FieldRepetitions != null && _preferredMethodOfContact.field.FieldRepetitions.Count > 0)
        {
            _preferredMethodOfContact.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_preferredMethodOfContact, fieldData);
        }

        return _preferredMethodOfContact;
    } 
}

internal HL7V231Field _maritalStatus;

public HL7V231Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.17",
            Type = @"Field",
            Position = @"STF.17",
            Name = @"Marital Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the staff member's marital status. Refer to user-defined table 0002 - Marital status for suggested values. Same values as those for PID-16-marital status .",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.17.1",
                            Type = @"Component",
                            Position = @"STF.17.1",
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
                            Id = @"STF.17.2",
                            Type = @"Component",
                            Position = @"STF.17.2",
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
                            Id = @"STF.17.3",
                            Type = @"Component",
                            Position = @"STF.17.3",
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
                            Id = @"STF.17.4",
                            Type = @"Component",
                            Position = @"STF.17.4",
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
                            Id = @"STF.17.5",
                            Type = @"Component",
                            Position = @"STF.17.5",
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
                            Id = @"STF.17.6",
                            Type = @"Component",
                            Position = @"STF.17.6",
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

        _maritalStatus = new HL7V231Field
        {
            field = message[@"STF"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
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
            Id = @"STF.18",
            Type = @"Field",
            Position = @"STF.18",
            Name = @"Job Title",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a descriptive name of the staff member's occupation (e.g., Sr. Systems Analyst, Sr. Accountant).",
            Sample = @"",
            Fields = null
        }

        _jobTitle = new HL7V231Field
        {
            field = message[@"STF"][18],
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
            Id = @"STF.19",
            Type = @"Field",
            Position = @"STF.19",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code/class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the staff member's job code and employee classification. User-defined table 0327 - Job code and User-defined table0328 - Employee classification. are used as the HL7 identifiers for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.19.1",
                            Type = @"Component",
                            Position = @"STF.19.1",
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
                            Id = @"STF.19.2",
                            Type = @"Component",
                            Position = @"STF.19.2",
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
            field = message[@"STF"][19],
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

internal HL7V231Field _employmentStatus;

public HL7V231Field EmploymentStatus
{
    get
    {
        if (_employmentStatus != null)
        {
            return _employmentStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.20",
            Type = @"Field",
            Position = @"STF.20",
            Name = @"Employment Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"This field contains the code that indicates the staff member's employment status, e.g., full-time, part-time, self-employed, etc. User-defined table 0066 - Employment status for suggested values is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = null
        }

        _employmentStatus = new HL7V231Field
        {
            field = message[@"STF"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentStatus.field.FieldRepetitions != null && _employmentStatus.field.FieldRepetitions.Count > 0)
        {
            _employmentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_employmentStatus, fieldData);
        }

        return _employmentStatus;
    } 
}

internal HL7V231Field _additionalInsuredonAuto;

public HL7V231Field AdditionalInsuredonAuto
{
    get
    {
        if (_additionalInsuredonAuto != null)
        {
            return _additionalInsuredonAuto;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.21",
            Type = @"Field",
            Position = @"STF.21",
            Name = @"Additional Insured on  Auto",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether the present institution is named as an additional insured on the staff member's auto insurance, especially for use when staff is a driver for the institution. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _additionalInsuredonAuto = new HL7V231Field
        {
            field = message[@"STF"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_additionalInsuredonAuto.field.FieldRepetitions != null && _additionalInsuredonAuto.field.FieldRepetitions.Count > 0)
        {
            _additionalInsuredonAuto.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_additionalInsuredonAuto, fieldData);
        }

        return _additionalInsuredonAuto;
    } 
}

internal HL7V231Field _driversLicenseNumberStaff;

public HL7V231Field DriversLicenseNumberStaff
{
    get
    {
        if (_driversLicenseNumberStaff != null)
        {
            return _driversLicenseNumberStaff;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.22",
            Type = @"Field",
            Position = @"STF.22",
            Name = @"Driver s License Number - Staff",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DLN",
            DataTypeName = @"Driver's License Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the driver's license information of staff, especially for use when staff is a driver for the institution. For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"STF.22.1",
                            Type = @"Component",
                            Position = @"STF.22.1",
                            Name = @"Drivers License Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the drivers license number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.22.2",
                            Type = @"Component",
                            Position = @"STF.22.2",
                            Name = @"Issuing State, Province, Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Issuing authority for drivers license. For state or province refer to official postal codes for that country; for country refer to ISO 3166 for codes. (The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.) User-defined table 0333 - Drivers license issuing authority is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"STF.22.3",
                            Type = @"Component",
                            Position = @"STF.22.3",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Expiration date (DT) for drivers license.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _driversLicenseNumberStaff = new HL7V231Field
        {
            field = message[@"STF"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_driversLicenseNumberStaff.field.FieldRepetitions != null && _driversLicenseNumberStaff.field.FieldRepetitions.Count > 0)
        {
            _driversLicenseNumberStaff.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_driversLicenseNumberStaff, fieldData);
        }

        return _driversLicenseNumberStaff;
    } 
}

internal HL7V231Field _copyAutoIns;

public HL7V231Field CopyAutoIns
{
    get
    {
        if (_copyAutoIns != null)
        {
            return _copyAutoIns;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.23",
            Type = @"Field",
            Position = @"STF.23",
            Name = @"Copy  Auto Ins",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether the institution has on file a copy of the staff member's auto insurance, especially for use when staff is a driver for the institution. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _copyAutoIns = new HL7V231Field
        {
            field = message[@"STF"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_copyAutoIns.field.FieldRepetitions != null && _copyAutoIns.field.FieldRepetitions.Count > 0)
        {
            _copyAutoIns.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_copyAutoIns, fieldData);
        }

        return _copyAutoIns;
    } 
}

internal HL7V231Field _autoInsExpires;

public HL7V231Field AutoInsExpires
{
    get
    {
        if (_autoInsExpires != null)
        {
            return _autoInsExpires;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.24",
            Type = @"Field",
            Position = @"STF.24",
            Name = @"Auto Ins. Expires",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date on which the staff member's driver's license expires, especially for use when staff is a driver for the institution.",
            Sample = @"",
            Fields = null
        }

        _autoInsExpires = new HL7V231Field
        {
            field = message[@"STF"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_autoInsExpires.field.FieldRepetitions != null && _autoInsExpires.field.FieldRepetitions.Count > 0)
        {
            _autoInsExpires.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_autoInsExpires, fieldData);
        }

        return _autoInsExpires;
    } 
}

internal HL7V231Field _dateLastDMVReview;

public HL7V231Field DateLastDMVReview
{
    get
    {
        if (_dateLastDMVReview != null)
        {
            return _dateLastDMVReview;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.25",
            Type = @"Field",
            Position = @"STF.25",
            Name = @"Date Last DMV Review",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the staff member's most recent Department of Motor Vehicles review, especially for use when staff is a driver for the institution.",
            Sample = @"",
            Fields = null
        }

        _dateLastDMVReview = new HL7V231Field
        {
            field = message[@"STF"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateLastDMVReview.field.FieldRepetitions != null && _dateLastDMVReview.field.FieldRepetitions.Count > 0)
        {
            _dateLastDMVReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateLastDMVReview, fieldData);
        }

        return _dateLastDMVReview;
    } 
}

internal HL7V231Field _dateNextDMVReview;

public HL7V231Field DateNextDMVReview
{
    get
    {
        if (_dateNextDMVReview != null)
        {
            return _dateNextDMVReview;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"STF.26",
            Type = @"Field",
            Position = @"STF.26",
            Name = @"Date Next DMV Review",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date of the staff member's next Department of Motor Vehicles review, especially for use when staff is a driver for the institution.",
            Sample = @"",
            Fields = null
        }

        _dateNextDMVReview = new HL7V231Field
        {
            field = message[@"STF"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateNextDMVReview.field.FieldRepetitions != null && _dateNextDMVReview.field.FieldRepetitions.Count > 0)
        {
            _dateNextDMVReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateNextDMVReview, fieldData);
        }

        return _dateNextDMVReview;
    } 
}
    }
}

using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentEDU
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EDU"; } }

        public string SegmentId { get { return @"EDU"; } }
        
        public string LongName { get { return @"Educational Detail"; } }
        
        public string Description { get { return @"The EDU segment adds detailed educational information to the staff member identified by the STF segment.  An EDU segment may optionally follow an STF segment.  An EDU segment must always have been preceded by a corresponding STF segment"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
            }
        }

        public HL7V24SegmentEDU(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _setIDEDU;

public HL7V24Field SetIDEDU
{
    get
    {
        if (_setIDEDU != null)
        {
            return _setIDEDU;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.1",
            Type = @"Field",
            Position = @"EDU.1",
            Name = @"Set ID - EDU",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDEDU = new HL7V24Field
        {
            field = message[@"EDU"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDEDU.field.FieldRepetitions != null && _setIDEDU.field.FieldRepetitions.Count > 0)
        {
            _setIDEDU.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_setIDEDU, fieldData);
        }

        return _setIDEDU;
    } 
}

internal HL7V24Field _academicDegree;

public HL7V24Field AcademicDegree
{
    get
    {
        if (_academicDegree != null)
        {
            return _academicDegree;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.2",
            Type = @"Field",
            Position = @"EDU.2",
            Name = @"Academic Degree",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0360",
            TableName = @"Degree",
            Description = @"This field contains the standard classification awarded upon completion of a unified program of study.  HL7 suggests using values in User-defined Table 0360 - Degree.",
            Sample = @"",
            Fields = null
        }

        _academicDegree = new HL7V24Field
        {
            field = message[@"EDU"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_academicDegree.field.FieldRepetitions != null && _academicDegree.field.FieldRepetitions.Count > 0)
        {
            _academicDegree.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_academicDegree, fieldData);
        }

        return _academicDegree;
    } 
}

internal HL7V24Field _academicDegreeProgramDateRange;

public HL7V24Field AcademicDegreeProgramDateRange
{
    get
    {
        if (_academicDegreeProgramDateRange != null)
        {
            return _academicDegreeProgramDateRange;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.3",
            Type = @"Field",
            Position = @"EDU.3",
            Name = @"Academic Degree Program Date Range",
            Length = 52,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/time Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date range when the academic degree program took place",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EDU.3.1",
                            Type = @"Component",
                            Position = @"EDU.3.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.3.1.1",
                            Type = @"SubComponent",
                            Position = @"EDU.3.1.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.3.1.2",
                            Type = @"SubComponent",
                            Position = @"EDU.3.1.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.3.2",
                            Type = @"Component",
                            Position = @"EDU.3.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.3.2.1",
                            Type = @"SubComponent",
                            Position = @"EDU.3.2.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.3.2.2",
                            Type = @"SubComponent",
                            Position = @"EDU.3.2.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _academicDegreeProgramDateRange = new HL7V24Field
        {
            field = message[@"EDU"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_academicDegreeProgramDateRange.field.FieldRepetitions != null && _academicDegreeProgramDateRange.field.FieldRepetitions.Count > 0)
        {
            _academicDegreeProgramDateRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_academicDegreeProgramDateRange, fieldData);
        }

        return _academicDegreeProgramDateRange;
    } 
}

internal HL7V24Field _academicDegreeProgramParticipationDateRange;

public HL7V24Field AcademicDegreeProgramParticipationDateRange
{
    get
    {
        if (_academicDegreeProgramParticipationDateRange != null)
        {
            return _academicDegreeProgramParticipationDateRange;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.4",
            Type = @"Field",
            Position = @"EDU.4",
            Name = @"Academic Degree Program Participation Date Range",
            Length = 52,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/time Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date range during which the staff member participated in the academic degree program",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EDU.4.1",
                            Type = @"Component",
                            Position = @"EDU.4.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.4.1.1",
                            Type = @"SubComponent",
                            Position = @"EDU.4.1.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.4.1.2",
                            Type = @"SubComponent",
                            Position = @"EDU.4.1.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.4.2",
                            Type = @"Component",
                            Position = @"EDU.4.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.4.2.1",
                            Type = @"SubComponent",
                            Position = @"EDU.4.2.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.4.2.2",
                            Type = @"SubComponent",
                            Position = @"EDU.4.2.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _academicDegreeProgramParticipationDateRange = new HL7V24Field
        {
            field = message[@"EDU"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_academicDegreeProgramParticipationDateRange.field.FieldRepetitions != null && _academicDegreeProgramParticipationDateRange.field.FieldRepetitions.Count > 0)
        {
            _academicDegreeProgramParticipationDateRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_academicDegreeProgramParticipationDateRange, fieldData);
        }

        return _academicDegreeProgramParticipationDateRange;
    } 
}

internal HL7V24Field _academicDegreeGrantedDate;

public HL7V24Field AcademicDegreeGrantedDate
{
    get
    {
        if (_academicDegreeGrantedDate != null)
        {
            return _academicDegreeGrantedDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.5",
            Type = @"Field",
            Position = @"EDU.5",
            Name = @"Academic Degree Granted Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the academic degree was granted to the staff member",
            Sample = @"",
            Fields = null
        }

        _academicDegreeGrantedDate = new HL7V24Field
        {
            field = message[@"EDU"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_academicDegreeGrantedDate.field.FieldRepetitions != null && _academicDegreeGrantedDate.field.FieldRepetitions.Count > 0)
        {
            _academicDegreeGrantedDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_academicDegreeGrantedDate, fieldData);
        }

        return _academicDegreeGrantedDate;
    } 
}

internal HL7V24Field _school;

public HL7V24Field School
{
    get
    {
        if (_school != null)
        {
            return _school;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.6",
            Type = @"Field",
            Position = @"EDU.6",
            Name = @"School",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And Identification Number For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the official name of the academic institution that granted the degree to the Staff Member",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EDU.6.1",
                            Type = @"Component",
                            Position = @"EDU.6.1",
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
                            Id = @"EDU.6.2",
                            Type = @"Component",
                            Position = @"EDU.6.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name. Refer to User-defined Table 0204 - Organizational name type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.6.3",
                            Type = @"Component",
                            Position = @"EDU.6.3",
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
                            Id = @"EDU.6.4",
                            Type = @"Component",
                            Position = @"EDU.6.4",
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
                            Id = @"EDU.6.5",
                            Type = @"Component",
                            Position = @"EDU.6.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 Table 0061 - Check digit scheme.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.6.6",
                            Type = @"Component",
                            Position = @"EDU.6.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Assigning authorities are unique across a given HL7 implementation. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.6.6.1",
                            Type = @"SubComponent",
                            Position = @"EDU.6.6.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.6.6.2",
                            Type = @"SubComponent",
                            Position = @"EDU.6.6.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"EDU.6.6.3",
                            Type = @"SubComponent",
                            Position = @"EDU.6.6.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"EDU.6.7",
                            Type = @"Component",
                            Position = @"EDU.6.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer to HL7 Table 0203 - Identifier typefor suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.6.8",
                            Type = @"Component",
                            Position = @"EDU.6.8",
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
                            Id = @"EDU.6.8.1",
                            Type = @"SubComponent",
                            Position = @"EDU.6.8.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.6.8.2",
                            Type = @"SubComponent",
                            Position = @"EDU.6.8.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"EDU.6.8.3",
                            Type = @"SubComponent",
                            Position = @"EDU.6.8.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"EDU.6.9",
                            Type = @"Component",
                            Position = @"EDU.6.9",
                            Name = @"Name Representation Code",
                            Length = 0,
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
                        }
        }

        _school = new HL7V24Field
        {
            field = message[@"EDU"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_school.field.FieldRepetitions != null && _school.field.FieldRepetitions.Count > 0)
        {
            _school.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_school, fieldData);
        }

        return _school;
    } 
}

internal HL7V24Field _schoolTypeCode;

public HL7V24Field SchoolTypeCode
{
    get
    {
        if (_schoolTypeCode != null)
        {
            return _schoolTypeCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.7",
            Type = @"Field",
            Position = @"EDU.7",
            Name = @"School Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0402",
            TableName = @"School type",
            Description = @"This field contains the categorization of the academic institution that granted the degree to the Staff Member.  HL7 suggests using values in User-defined Table 0402 - School type",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EDU.7.1",
                            Type = @"Component",
                            Position = @"EDU.7.1",
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
                            Id = @"EDU.7.2",
                            Type = @"Component",
                            Position = @"EDU.7.2",
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
                            Id = @"EDU.7.3",
                            Type = @"Component",
                            Position = @"EDU.7.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.7.4",
                            Type = @"Component",
                            Position = @"EDU.7.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.7.5",
                            Type = @"Component",
                            Position = @"EDU.7.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.7.6",
                            Type = @"Component",
                            Position = @"EDU.7.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _schoolTypeCode = new HL7V24Field
        {
            field = message[@"EDU"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_schoolTypeCode.field.FieldRepetitions != null && _schoolTypeCode.field.FieldRepetitions.Count > 0)
        {
            _schoolTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_schoolTypeCode, fieldData);
        }

        return _schoolTypeCode;
    } 
}

internal HL7V24Field _schoolAddress;

public HL7V24Field SchoolAddress
{
    get
    {
        if (_schoolAddress != null)
        {
            return _schoolAddress;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"EDU.8",
            Type = @"Field",
            Position = @"EDU.8",
            Name = @"School Address",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the postal address of the academic institution that granted the degree to the Staff Member",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EDU.8.1",
                            Type = @"Component",
                            Position = @"EDU.8.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"SAD",
                            DataTypeName = @"Street Address",
                            TableId = @"Street",
                            TableName = @"Street",
                            Description = @"See section 2.9.38, SAD - street address for description of components.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.8.1.1",
                            Type = @"SubComponent",
                            Position = @"EDU.8.1.1",
                            Name = @"Street Or Mailing Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.1.2",
                            Type = @"SubComponent",
                            Position = @"EDU.8.1.2",
                            Name = @"Street Name",
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
                            Id = @"EDU.8.1.3",
                            Type = @"SubComponent",
                            Position = @"EDU.8.1.3",
                            Name = @"Dwelling Number",
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
                            Id = @"EDU.8.2",
                            Type = @"Component",
                            Position = @"EDU.8.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In US usage, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.3",
                            Type = @"Component",
                            Position = @"EDU.8.3",
                            Name = @"City",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"City",
                            TableName = @"City",
                            Description = @"This may be the name of the city, or district or place depending upon the national convention for formatting addresses for postal usage.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.4",
                            Type = @"Component",
                            Position = @"EDU.8.4",
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
                            Id = @"EDU.8.5",
                            Type = @"Component",
                            Position = @"EDU.8.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"ZipCode",
                            TableName = @"Zip Code",
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A9A9, and the Australian Postcode takes the form 9999",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.6",
                            Type = @"Component",
                            Position = @"EDU.8.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0399",
                            TableName = @"Country code",
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used. The ISO 3166 table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code . HL7 Table 0399 - Country code is defined to contain these 3-character codes.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.7",
                            Type = @"Component",
                            Position = @"EDU.8.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Address type is optional and defined by HL7 Table 0190 - Address type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.8",
                            Type = @"Component",
                            Position = @"EDU.8.8",
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
                            Id = @"EDU.8.9",
                            Type = @"Component",
                            Position = @"EDU.8.9",
                            Name = @"County/Parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides . User-defined Table 0289 - County/parish is used as the HL7 identifier for the user-defined table of values for this component. When this component is used to represent the county (or parish), component 8 <other geographic designation> should not duplicate it (i.e., the use of <other geographic designation> to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.10",
                            Type = @"Component",
                            Position = @"EDU.8.10",
                            Name = @"Census Tract",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0288",
                            TableName = @"Census tract",
                            Description = @"A code that represents the census tract in which the specified address resides . User-defined Table 0288 - Census tract is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.11",
                            Type = @"Component",
                            Position = @"EDU.8.11",
                            Name = @"Address Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same name/address should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.12",
                            Type = @"Component",
                            Position = @"EDU.8.12",
                            Name = @"Address Validity Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times which define the period in which this address was valid",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.1",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.1",
                            Name = @"Range Start Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.1",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.2",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.2",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.2",
                            Name = @"Range End Date/Time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.1",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EDU.8.12.2",
                            Type = @"SubComponent",
                            Position = @"EDU.8.12.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = null,
                            FieldDatas = null
                        },}
                        },}
                        },
                        }
        }

        _schoolAddress = new HL7V24Field
        {
            field = message[@"EDU"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_schoolAddress.field.FieldRepetitions != null && _schoolAddress.field.FieldRepetitions.Count > 0)
        {
            _schoolAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_schoolAddress, fieldData);
        }

        return _schoolAddress;
    } 
}
    }
}

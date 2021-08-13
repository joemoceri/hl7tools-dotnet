using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentIN3
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN3"; } }

        public string SegmentId { get { return @"IN3"; } }
        
        public string LongName { get { return @"Insurance additional info - certification"; } }
        
        public string Description { get { return @"The IN3 segment contains additional insurance information for certifying the need for patient care.  Fields used by this segment are defined by HCFA, or other regulatory agencies."; } }
        
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

        public HL7V23SegmentIN3(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDInsuranceCertification;

public HL7V23Field SetIDInsuranceCertification
{
    get
    {
        if (_setIDInsuranceCertification != null)
        {
            return _setIDInsuranceCertification;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.1",
            Type = @"Field",
            Position = @"IN3.1",
            Name = @"Set ID - Insurance Certification",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"IN3-1-set ID contains the number that identifies this  transaction.  For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc. ",
            Sample = @"",
            Fields = null
        }

        _setIDInsuranceCertification = new HL7V23Field
        {
            field = message[@"IN3"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDInsuranceCertification.field.FieldRepetitions != null && _setIDInsuranceCertification.field.FieldRepetitions.Count > 0)
        {
            _setIDInsuranceCertification.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDInsuranceCertification, fieldData);
        }

        return _setIDInsuranceCertification;
    } 
}

internal HL7V23Field _certificationNumber;

public HL7V23Field CertificationNumber
{
    get
    {
        if (_certificationNumber != null)
        {
            return _certificationNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.2",
            Type = @"Field",
            Position = @"IN3.2",
            Name = @"Certification Number",
            Length = 59,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number assigned by the certification agency.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.2.1",
                            Type = @"Component",
                            Position = @"IN3.2.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.2",
                            Type = @"Component",
                            Position = @"IN3.2.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.3",
                            Type = @"Component",
                            Position = @"IN3.2.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.4",
                            Type = @"Component",
                            Position = @"IN3.2.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.2.4.1",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.4.2",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.4.3",
                            Type = @"SubComponent",
                            Position = @"IN3.2.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.5",
                            Type = @"Component",
                            Position = @"IN3.2.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.6",
                            Type = @"Component",
                            Position = @"IN3.2.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.2.6.1",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.6.2",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.2.6.3",
                            Type = @"SubComponent",
                            Position = @"IN3.2.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _certificationNumber = new HL7V23Field
        {
            field = message[@"IN3"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationNumber.field.FieldRepetitions != null && _certificationNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationNumber, fieldData);
        }

        return _certificationNumber;
    } 
}

internal HL7V23Field _certifiedBy;

public HL7V23Field CertifiedBy
{
    get
    {
        if (_certifiedBy != null)
        {
            return _certifiedBy;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.3",
            Type = @"Field",
            Position = @"IN3.3",
            Name = @"Certified By",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the party that approved the certification.  Multiple names and identifiers for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.3.1",
                            Type = @"Component",
                            Position = @"IN3.3.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.2",
                            Type = @"Component",
                            Position = @"IN3.3.2",
                            Name = @"Family Name",
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
                            Id = @"IN3.3.3",
                            Type = @"Component",
                            Position = @"IN3.3.3",
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
                            Id = @"IN3.3.4",
                            Type = @"Component",
                            Position = @"IN3.3.4",
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
                            Id = @"IN3.3.5",
                            Type = @"Component",
                            Position = @"IN3.3.5",
                            Name = @"Suffix",
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
                            Id = @"IN3.3.6",
                            Type = @"Component",
                            Position = @"IN3.3.6",
                            Name = @"Prefix",
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
                            Id = @"IN3.3.7",
                            Type = @"Component",
                            Position = @"IN3.3.7",
                            Name = @"Degree",
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
                            Id = @"IN3.3.8",
                            Type = @"Component",
                            Position = @"IN3.3.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.9",
                            Type = @"Component",
                            Position = @"IN3.3.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.3.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.3.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.10",
                            Type = @"Component",
                            Position = @"IN3.3.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.11",
                            Type = @"Component",
                            Position = @"IN3.3.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.12",
                            Type = @"Component",
                            Position = @"IN3.3.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.13",
                            Type = @"Component",
                            Position = @"IN3.3.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.14",
                            Type = @"Component",
                            Position = @"IN3.3.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.3.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.3.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.3.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _certifiedBy = new HL7V23Field
        {
            field = message[@"IN3"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certifiedBy.field.FieldRepetitions != null && _certifiedBy.field.FieldRepetitions.Count > 0)
        {
            _certifiedBy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certifiedBy, fieldData);
        }

        return _certifiedBy;
    } 
}

internal HL7V23Field _certificationRequired;

public HL7V23Field CertificationRequired
{
    get
    {
        if (_certificationRequired != null)
        {
            return _certificationRequired;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.4",
            Type = @"Field",
            Position = @"IN3.4",
            Name = @"Certification Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether certification is required.  Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _certificationRequired = new HL7V23Field
        {
            field = message[@"IN3"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationRequired.field.FieldRepetitions != null && _certificationRequired.field.FieldRepetitions.Count > 0)
        {
            _certificationRequired.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationRequired, fieldData);
        }

        return _certificationRequired;
    } 
}

internal HL7V23Field _penalty;

public HL7V23Field Penalty
{
    get
    {
        if (_penalty != null)
        {
            return _penalty;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.5",
            Type = @"Field",
            Position = @"IN3.5",
            Name = @"Penalty",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PEN",
            DataTypeName = @"Penalty",
            TableId = null,
            TableName = null,
            Description = @"This field contains the penalty, in dollars or a percentage, that will be assessed if the precertification is not performed.  Refer to user-defined table 0148 - Penalty type for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.5.1",
                            Type = @"Component",
                            Position = @"IN3.5.1",
                            Name = @"Penalty Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0148",
                            TableName = @"Penalty type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.5.2",
                            Type = @"Component",
                            Position = @"IN3.5.2",
                            Name = @"Penalty Amount",
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
                        }
        }

        _penalty = new HL7V23Field
        {
            field = message[@"IN3"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_penalty.field.FieldRepetitions != null && _penalty.field.FieldRepetitions.Count > 0)
        {
            _penalty.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_penalty, fieldData);
        }

        return _penalty;
    } 
}

internal HL7V23Field _certificationDateTime;

public HL7V23Field CertificationDateTime
{
    get
    {
        if (_certificationDateTime != null)
        {
            return _certificationDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.6",
            Type = @"Field",
            Position = @"IN3.6",
            Name = @"Certification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time stamp that indicates when insurance was certified to exist for the patient. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.6.1",
                            Type = @"Component",
                            Position = @"IN3.6.1",
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

        _certificationDateTime = new HL7V23Field
        {
            field = message[@"IN3"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationDateTime.field.FieldRepetitions != null && _certificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _certificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationDateTime, fieldData);
        }

        return _certificationDateTime;
    } 
}

internal HL7V23Field _certificationModifyDateTime;

public HL7V23Field CertificationModifyDateTime
{
    get
    {
        if (_certificationModifyDateTime != null)
        {
            return _certificationModifyDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.7",
            Type = @"Field",
            Position = @"IN3.7",
            Name = @"Certification Modify Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the certification was modified",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.7.1",
                            Type = @"Component",
                            Position = @"IN3.7.1",
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

        _certificationModifyDateTime = new HL7V23Field
        {
            field = message[@"IN3"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationModifyDateTime.field.FieldRepetitions != null && _certificationModifyDateTime.field.FieldRepetitions.Count > 0)
        {
            _certificationModifyDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationModifyDateTime, fieldData);
        }

        return _certificationModifyDateTime;
    } 
}

internal HL7V23Field _operator;

public HL7V23Field Operator
{
    get
    {
        if (_operator != null)
        {
            return _operator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.8",
            Type = @"Field",
            Position = @"IN3.8",
            Name = @"Operator",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name party who is responsible for sending this certification information. Multiple names for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.8.1",
                            Type = @"Component",
                            Position = @"IN3.8.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.2",
                            Type = @"Component",
                            Position = @"IN3.8.2",
                            Name = @"Family Name",
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
                            Id = @"IN3.8.3",
                            Type = @"Component",
                            Position = @"IN3.8.3",
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
                            Id = @"IN3.8.4",
                            Type = @"Component",
                            Position = @"IN3.8.4",
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
                            Id = @"IN3.8.5",
                            Type = @"Component",
                            Position = @"IN3.8.5",
                            Name = @"Suffix",
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
                            Id = @"IN3.8.6",
                            Type = @"Component",
                            Position = @"IN3.8.6",
                            Name = @"Prefix",
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
                            Id = @"IN3.8.7",
                            Type = @"Component",
                            Position = @"IN3.8.7",
                            Name = @"Degree",
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
                            Id = @"IN3.8.8",
                            Type = @"Component",
                            Position = @"IN3.8.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.9",
                            Type = @"Component",
                            Position = @"IN3.8.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.8.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.8.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.10",
                            Type = @"Component",
                            Position = @"IN3.8.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.11",
                            Type = @"Component",
                            Position = @"IN3.8.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.12",
                            Type = @"Component",
                            Position = @"IN3.8.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.13",
                            Type = @"Component",
                            Position = @"IN3.8.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.14",
                            Type = @"Component",
                            Position = @"IN3.8.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.8.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.8.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.8.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _operator = new HL7V23Field
        {
            field = message[@"IN3"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_operator.field.FieldRepetitions != null && _operator.field.FieldRepetitions.Count > 0)
        {
            _operator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_operator, fieldData);
        }

        return _operator;
    } 
}

internal HL7V23Field _certificationBeginDate;

public HL7V23Field CertificationBeginDate
{
    get
    {
        if (_certificationBeginDate != null)
        {
            return _certificationBeginDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.9",
            Type = @"Field",
            Position = @"IN3.9",
            Name = @"Certification Begin Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that this certification begins",
            Sample = @"",
            Fields = null
        }

        _certificationBeginDate = new HL7V23Field
        {
            field = message[@"IN3"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationBeginDate.field.FieldRepetitions != null && _certificationBeginDate.field.FieldRepetitions.Count > 0)
        {
            _certificationBeginDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationBeginDate, fieldData);
        }

        return _certificationBeginDate;
    } 
}

internal HL7V23Field _certificationEndDate;

public HL7V23Field CertificationEndDate
{
    get
    {
        if (_certificationEndDate != null)
        {
            return _certificationEndDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.10",
            Type = @"Field",
            Position = @"IN3.10",
            Name = @"Certification End Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains date that this certification ends.",
            Sample = @"",
            Fields = null
        }

        _certificationEndDate = new HL7V23Field
        {
            field = message[@"IN3"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationEndDate.field.FieldRepetitions != null && _certificationEndDate.field.FieldRepetitions.Count > 0)
        {
            _certificationEndDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationEndDate, fieldData);
        }

        return _certificationEndDate;
    } 
}

internal HL7V23Field _days;

public HL7V23Field Days
{
    get
    {
        if (_days != null)
        {
            return _days;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.11",
            Type = @"Field",
            Position = @"IN3.11",
            Name = @"Days",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DTN",
            DataTypeName = @"Day Type And Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days for which this certification is valid.  This field applies to denied, pending, or approved days.  Refer to user-defined table 0149 - Day type for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.11.1",
                            Type = @"Component",
                            Position = @"IN3.11.1",
                            Name = @"Day Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0149",
                            TableName = @"Day type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.11.2",
                            Type = @"Component",
                            Position = @"IN3.11.2",
                            Name = @"Number Of Days",
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
                        }
        }

        _days = new HL7V23Field
        {
            field = message[@"IN3"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_days.field.FieldRepetitions != null && _days.field.FieldRepetitions.Count > 0)
        {
            _days.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_days, fieldData);
        }

        return _days;
    } 
}

internal HL7V23Field _nonConcurCodeDescription;

public HL7V23Field NonConcurCodeDescription
{
    get
    {
        if (_nonConcurCodeDescription != null)
        {
            return _nonConcurCodeDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.12",
            Type = @"Field",
            Position = @"IN3.12",
            Name = @"Non-Concur Code/Description",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0233",
            TableName = @"Non-concur code/description",
            Description = @"This field contains the non-concur code and description for a denied request.   Refer to userdefined table 0233 - Non-concur code/description for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.12.1",
                            Type = @"Component",
                            Position = @"IN3.12.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.2",
                            Type = @"Component",
                            Position = @"IN3.12.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.3",
                            Type = @"Component",
                            Position = @"IN3.12.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.4",
                            Type = @"Component",
                            Position = @"IN3.12.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.5",
                            Type = @"Component",
                            Position = @"IN3.12.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.12.6",
                            Type = @"Component",
                            Position = @"IN3.12.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nonConcurCodeDescription = new HL7V23Field
        {
            field = message[@"IN3"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonConcurCodeDescription.field.FieldRepetitions != null && _nonConcurCodeDescription.field.FieldRepetitions.Count > 0)
        {
            _nonConcurCodeDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nonConcurCodeDescription, fieldData);
        }

        return _nonConcurCodeDescription;
    } 
}

internal HL7V23Field _nonConcurEffectiveDateTime;

public HL7V23Field NonConcurEffectiveDateTime
{
    get
    {
        if (_nonConcurEffectiveDateTime != null)
        {
            return _nonConcurEffectiveDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.13",
            Type = @"Field",
            Position = @"IN3.13",
            Name = @"Non-Concur Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date of the non-concurrence classification",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.13.1",
                            Type = @"Component",
                            Position = @"IN3.13.1",
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

        _nonConcurEffectiveDateTime = new HL7V23Field
        {
            field = message[@"IN3"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonConcurEffectiveDateTime.field.FieldRepetitions != null && _nonConcurEffectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            _nonConcurEffectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nonConcurEffectiveDateTime, fieldData);
        }

        return _nonConcurEffectiveDateTime;
    } 
}

internal HL7V23Field _physicianReviewer;

public HL7V23Field PhysicianReviewer
{
    get
    {
        if (_physicianReviewer != null)
        {
            return _physicianReviewer;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.14",
            Type = @"Field",
            Position = @"IN3.14",
            Name = @"Physician Reviewer",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the physician who works with and reviews cases that are pending physician review for the certification agency.  Multiple names for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.14.1",
                            Type = @"Component",
                            Position = @"IN3.14.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.2",
                            Type = @"Component",
                            Position = @"IN3.14.2",
                            Name = @"Family Name",
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
                            Id = @"IN3.14.3",
                            Type = @"Component",
                            Position = @"IN3.14.3",
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
                            Id = @"IN3.14.4",
                            Type = @"Component",
                            Position = @"IN3.14.4",
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
                            Id = @"IN3.14.5",
                            Type = @"Component",
                            Position = @"IN3.14.5",
                            Name = @"Suffix",
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
                            Id = @"IN3.14.6",
                            Type = @"Component",
                            Position = @"IN3.14.6",
                            Name = @"Prefix",
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
                            Id = @"IN3.14.7",
                            Type = @"Component",
                            Position = @"IN3.14.7",
                            Name = @"Degree",
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
                            Id = @"IN3.14.8",
                            Type = @"Component",
                            Position = @"IN3.14.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.9",
                            Type = @"Component",
                            Position = @"IN3.14.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.14.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.14.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.10",
                            Type = @"Component",
                            Position = @"IN3.14.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.11",
                            Type = @"Component",
                            Position = @"IN3.14.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.12",
                            Type = @"Component",
                            Position = @"IN3.14.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.13",
                            Type = @"Component",
                            Position = @"IN3.14.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.14",
                            Type = @"Component",
                            Position = @"IN3.14.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.14.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.14.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.14.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _physicianReviewer = new HL7V23Field
        {
            field = message[@"IN3"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_physicianReviewer.field.FieldRepetitions != null && _physicianReviewer.field.FieldRepetitions.Count > 0)
        {
            _physicianReviewer.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_physicianReviewer, fieldData);
        }

        return _physicianReviewer;
    } 
}

internal HL7V23Field _certificationContact;

public HL7V23Field CertificationContact
{
    get
    {
        if (_certificationContact != null)
        {
            return _certificationContact;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.15",
            Type = @"Field",
            Position = @"IN3.15",
            Name = @"Certification Contact",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the party contacted at the certification agency who granted the certification and communicated the certification number",
            Sample = @"",
            Fields = null
        }

        _certificationContact = new HL7V23Field
        {
            field = message[@"IN3"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationContact.field.FieldRepetitions != null && _certificationContact.field.FieldRepetitions.Count > 0)
        {
            _certificationContact.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationContact, fieldData);
        }

        return _certificationContact;
    } 
}

internal HL7V23Field _certificationContactPhoneNumber;

public HL7V23Field CertificationContactPhoneNumber
{
    get
    {
        if (_certificationContactPhoneNumber != null)
        {
            return _certificationContactPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.16",
            Type = @"Field",
            Position = @"IN3.16",
            Name = @"Certification Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the certification contact. Multiple phone numbers for the same certification contact may be sent in this sequence.  The primary phone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.16.1",
                            Type = @"Component",
                            Position = @"IN3.16.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16.2",
                            Type = @"Component",
                            Position = @"IN3.16.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16.3",
                            Type = @"Component",
                            Position = @"IN3.16.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16.4",
                            Type = @"Component",
                            Position = @"IN3.16.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.16.5",
                            Type = @"Component",
                            Position = @"IN3.16.5",
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
                            Id = @"IN3.16.6",
                            Type = @"Component",
                            Position = @"IN3.16.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN3.16.7",
                            Type = @"Component",
                            Position = @"IN3.16.7",
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
                            Id = @"IN3.16.8",
                            Type = @"Component",
                            Position = @"IN3.16.8",
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
                            Id = @"IN3.16.9",
                            Type = @"Component",
                            Position = @"IN3.16.9",
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

        _certificationContactPhoneNumber = new HL7V23Field
        {
            field = message[@"IN3"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationContactPhoneNumber.field.FieldRepetitions != null && _certificationContactPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationContactPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationContactPhoneNumber, fieldData);
        }

        return _certificationContactPhoneNumber;
    } 
}

internal HL7V23Field _appealReason;

public HL7V23Field AppealReason
{
    get
    {
        if (_appealReason != null)
        {
            return _appealReason;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.17",
            Type = @"Field",
            Position = @"IN3.17",
            Name = @"Appeal Reason",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reason that an appeal was made on a non-concur for certification",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.17.1",
                            Type = @"Component",
                            Position = @"IN3.17.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.2",
                            Type = @"Component",
                            Position = @"IN3.17.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.3",
                            Type = @"Component",
                            Position = @"IN3.17.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.4",
                            Type = @"Component",
                            Position = @"IN3.17.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.5",
                            Type = @"Component",
                            Position = @"IN3.17.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.17.6",
                            Type = @"Component",
                            Position = @"IN3.17.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _appealReason = new HL7V23Field
        {
            field = message[@"IN3"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_appealReason.field.FieldRepetitions != null && _appealReason.field.FieldRepetitions.Count > 0)
        {
            _appealReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_appealReason, fieldData);
        }

        return _appealReason;
    } 
}

internal HL7V23Field _certificationAgency;

public HL7V23Field CertificationAgency
{
    get
    {
        if (_certificationAgency != null)
        {
            return _certificationAgency;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.18",
            Type = @"Field",
            Position = @"IN3.18",
            Name = @"Certification Agency",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the certification agency",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.18.1",
                            Type = @"Component",
                            Position = @"IN3.18.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.2",
                            Type = @"Component",
                            Position = @"IN3.18.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.3",
                            Type = @"Component",
                            Position = @"IN3.18.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.4",
                            Type = @"Component",
                            Position = @"IN3.18.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.5",
                            Type = @"Component",
                            Position = @"IN3.18.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.18.6",
                            Type = @"Component",
                            Position = @"IN3.18.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _certificationAgency = new HL7V23Field
        {
            field = message[@"IN3"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationAgency.field.FieldRepetitions != null && _certificationAgency.field.FieldRepetitions.Count > 0)
        {
            _certificationAgency.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationAgency, fieldData);
        }

        return _certificationAgency;
    } 
}

internal HL7V23Field _certificationAgencyPhoneNumber;

public HL7V23Field CertificationAgencyPhoneNumber
{
    get
    {
        if (_certificationAgencyPhoneNumber != null)
        {
            return _certificationAgencyPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.19",
            Type = @"Field",
            Position = @"IN3.19",
            Name = @"Certification Agency Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the phone number of the certification agency.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.19.1",
                            Type = @"Component",
                            Position = @"IN3.19.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19.2",
                            Type = @"Component",
                            Position = @"IN3.19.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19.3",
                            Type = @"Component",
                            Position = @"IN3.19.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19.4",
                            Type = @"Component",
                            Position = @"IN3.19.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.19.5",
                            Type = @"Component",
                            Position = @"IN3.19.5",
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
                            Id = @"IN3.19.6",
                            Type = @"Component",
                            Position = @"IN3.19.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN3.19.7",
                            Type = @"Component",
                            Position = @"IN3.19.7",
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
                            Id = @"IN3.19.8",
                            Type = @"Component",
                            Position = @"IN3.19.8",
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
                            Id = @"IN3.19.9",
                            Type = @"Component",
                            Position = @"IN3.19.9",
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

        _certificationAgencyPhoneNumber = new HL7V23Field
        {
            field = message[@"IN3"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certificationAgencyPhoneNumber.field.FieldRepetitions != null && _certificationAgencyPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _certificationAgencyPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_certificationAgencyPhoneNumber, fieldData);
        }

        return _certificationAgencyPhoneNumber;
    } 
}

internal HL7V23Field _preCertificationrequiredWindow;

public HL7V23Field PreCertificationrequiredWindow
{
    get
    {
        if (_preCertificationrequiredWindow != null)
        {
            return _preCertificationrequiredWindow;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.20",
            Type = @"Field",
            Position = @"IN3.20",
            Name = @"Pre-Certification required/Window",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PCF",
            DataTypeName = @"Pre-certification Required",
            TableId = null,
            TableName = null,
            Description = @"This field indicates whether pre-certification is required for particular patient types, and the time window for obtaining the certification.  The following components of this field are defined as follows:

- pre-certification patient type refers to user-defined table 0150 - Pre-certification patient type for suggested values
- pre-certification required refers to HL7 table 0136 - Yes/no indicator for valid values
- pre-certification window is the amount of time required to attain certification from arrival at the institution. Its format follows the time stamp (TS) data type rules",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.20.1",
                            Type = @"Component",
                            Position = @"IN3.20.1",
                            Name = @"Pre-certification Patient Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0150",
                            TableName = @"Pre-certification patient type",
                            Description = @"pre-certification patient type refers to user-defined table 0150 - Pre-certification patient type for suggested values ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.2",
                            Type = @"Component",
                            Position = @"IN3.20.2",
                            Name = @"Pre-certification Required",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"pre-certification required refers to HL7 table 0136 - Yes/no indicator for valid values ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.20.3",
                            Type = @"Component",
                            Position = @"IN3.20.3",
                            Name = @"Pre-certification Windwow",
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
                            Id = @"IN3.20.3.1",
                            Type = @"SubComponent",
                            Position = @"IN3.20.3.1",
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

        _preCertificationrequiredWindow = new HL7V23Field
        {
            field = message[@"IN3"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preCertificationrequiredWindow.field.FieldRepetitions != null && _preCertificationrequiredWindow.field.FieldRepetitions.Count > 0)
        {
            _preCertificationrequiredWindow.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_preCertificationrequiredWindow, fieldData);
        }

        return _preCertificationrequiredWindow;
    } 
}

internal HL7V23Field _caseManager;

public HL7V23Field CaseManager
{
    get
    {
        if (_caseManager != null)
        {
            return _caseManager;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.21",
            Type = @"Field",
            Position = @"IN3.21",
            Name = @"Case Manager",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the entity who/which is handling this particular patient’s case (e.g., UR nurse, or a specific facility location).",
            Sample = @"",
            Fields = null
        }

        _caseManager = new HL7V23Field
        {
            field = message[@"IN3"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_caseManager.field.FieldRepetitions != null && _caseManager.field.FieldRepetitions.Count > 0)
        {
            _caseManager.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_caseManager, fieldData);
        }

        return _caseManager;
    } 
}

internal HL7V23Field _secondOpinionDate;

public HL7V23Field SecondOpinionDate
{
    get
    {
        if (_secondOpinionDate != null)
        {
            return _secondOpinionDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.22",
            Type = @"Field",
            Position = @"IN3.22",
            Name = @"Second Opinion Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the second opinion was obtained.",
            Sample = @"",
            Fields = null
        }

        _secondOpinionDate = new HL7V23Field
        {
            field = message[@"IN3"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionDate.field.FieldRepetitions != null && _secondOpinionDate.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_secondOpinionDate, fieldData);
        }

        return _secondOpinionDate;
    } 
}

internal HL7V23Field _secondOpinionStatus;

public HL7V23Field SecondOpinionStatus
{
    get
    {
        if (_secondOpinionStatus != null)
        {
            return _secondOpinionStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.23",
            Type = @"Field",
            Position = @"IN3.23",
            Name = @"Second Opinion Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0151",
            TableName = @"Second opinion status",
            Description = @"This field contains the code that represents the status of the second opinion.  Refer to userdefined table 0151 - Second opinion status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _secondOpinionStatus = new HL7V23Field
        {
            field = message[@"IN3"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionStatus.field.FieldRepetitions != null && _secondOpinionStatus.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_secondOpinionStatus, fieldData);
        }

        return _secondOpinionStatus;
    } 
}

internal HL7V23Field _secondOpinionDocumentationReceived;

public HL7V23Field SecondOpinionDocumentationReceived
{
    get
    {
        if (_secondOpinionDocumentationReceived != null)
        {
            return _secondOpinionDocumentationReceived;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.24",
            Type = @"Field",
            Position = @"IN3.24",
            Name = @"Second Opinion Documentation Received",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0152",
            TableName = @"Second opinion documentation received",
            Description = @"Use this field if accompanying documentation has been received by the provider.  Refer to userdefined table 0152 - Second opinion documentation received for suggested values.",
            Sample = @"",
            Fields = null
        }

        _secondOpinionDocumentationReceived = new HL7V23Field
        {
            field = message[@"IN3"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionDocumentationReceived.field.FieldRepetitions != null && _secondOpinionDocumentationReceived.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionDocumentationReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_secondOpinionDocumentationReceived, fieldData);
        }

        return _secondOpinionDocumentationReceived;
    } 
}

internal HL7V23Field _secondOpinionPhysician;

public HL7V23Field SecondOpinionPhysician
{
    get
    {
        if (_secondOpinionPhysician != null)
        {
            return _secondOpinionPhysician;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN3.25",
            Type = @"Field",
            Position = @"IN3.25",
            Name = @"Second Opinion Physician",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = @"0010",
            TableName = @"Physician ID",
            Description = @"This field contains an identifier and name of the physician who provided the second opinion. Multiple names and identifiers for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN3.25.1",
                            Type = @"Component",
                            Position = @"IN3.25.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.2",
                            Type = @"Component",
                            Position = @"IN3.25.2",
                            Name = @"Family Name",
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
                            Id = @"IN3.25.3",
                            Type = @"Component",
                            Position = @"IN3.25.3",
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
                            Id = @"IN3.25.4",
                            Type = @"Component",
                            Position = @"IN3.25.4",
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
                            Id = @"IN3.25.5",
                            Type = @"Component",
                            Position = @"IN3.25.5",
                            Name = @"Suffix",
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
                            Id = @"IN3.25.6",
                            Type = @"Component",
                            Position = @"IN3.25.6",
                            Name = @"Prefix",
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
                            Id = @"IN3.25.7",
                            Type = @"Component",
                            Position = @"IN3.25.7",
                            Name = @"Degree",
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
                            Id = @"IN3.25.8",
                            Type = @"Component",
                            Position = @"IN3.25.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.9",
                            Type = @"Component",
                            Position = @"IN3.25.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.25.9.1",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.9.2",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.9.3",
                            Type = @"SubComponent",
                            Position = @"IN3.25.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.10",
                            Type = @"Component",
                            Position = @"IN3.25.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.11",
                            Type = @"Component",
                            Position = @"IN3.25.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.12",
                            Type = @"Component",
                            Position = @"IN3.25.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.13",
                            Type = @"Component",
                            Position = @"IN3.25.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.14",
                            Type = @"Component",
                            Position = @"IN3.25.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN3.25.14.1",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.14.2",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN3.25.14.3",
                            Type = @"SubComponent",
                            Position = @"IN3.25.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _secondOpinionPhysician = new HL7V23Field
        {
            field = message[@"IN3"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_secondOpinionPhysician.field.FieldRepetitions != null && _secondOpinionPhysician.field.FieldRepetitions.Count > 0)
        {
            _secondOpinionPhysician.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_secondOpinionPhysician, fieldData);
        }

        return _secondOpinionPhysician;
    } 
}
    }
}

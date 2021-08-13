using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentGT1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"GT1"; } }

        public string SegmentId { get { return @"GT1"; } }
        
        public string LongName { get { return @"Guarantor"; } }
        
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

        public HL7V23SegmentGT1(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDGuarantor;

public HL7V23Field SetIDGuarantor
{
    get
    {
        if (_setIDGuarantor != null)
        {
            return _setIDGuarantor;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.1",
            Type = @"Field",
            Position = @"GT1.1",
            Name = @"Set ID - Guarantor",
            Length = 4,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"Set ID-GT1 contains a number that identifies this transaction.  For the first occurrence of the segment the sequence shall be 1, for the second occurrence it shall be 2, etc",
            Sample = @"",
            Fields = null
        }

        _setIDGuarantor = new HL7V23Field
        {
            field = message[@"GT1"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDGuarantor.field.FieldRepetitions != null && _setIDGuarantor.field.FieldRepetitions.Count > 0)
        {
            _setIDGuarantor.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDGuarantor, fieldData);
        }

        return _setIDGuarantor;
    } 
}

internal HL7V23Field _guarantorNumber;

public HL7V23Field GuarantorNumber
{
    get
    {
        if (_guarantorNumber != null)
        {
            return _guarantorNumber;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the primary identifier, or other identifiers,  assigned to the guarantor",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.2.1",
                            Type = @"Component",
                            Position = @"GT1.2.1",
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
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
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
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
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
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.2.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.1",
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
                            Id = @"GT1.2.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.2",
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
                            Id = @"GT1.2.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.2.4.3",
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
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
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
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.2.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.1",
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
                            Id = @"GT1.2.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.2",
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
                            Id = @"GT1.2.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.2.6.3",
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

        _guarantorNumber = new HL7V23Field
        {
            field = message[@"GT1"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorNumber.field.FieldRepetitions != null && _guarantorNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorNumber, fieldData);
        }

        return _guarantorNumber;
    } 
}

internal HL7V23Field _guarantorName;

public HL7V23Field GuarantorName
{
    get
    {
        if (_guarantorName != null)
        {
            return _guarantorName;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the name of the guarantor.  Multiple names for the same guarantor may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.  The components for this data type are described in Chapter 2. 

Beginning with Version 2.3, if the guarantor is an organization, send a null value ("" "") in GT1-3-guarantor  person name and put the organization name in GT1-21-guarantor organization name.  Either guarantor person name or guarantor organization name is required",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.3.1",
                            Type = @"Component",
                            Position = @"GT1.3.1",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
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
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorName = new HL7V23Field
        {
            field = message[@"GT1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorName.field.FieldRepetitions != null && _guarantorName.field.FieldRepetitions.Count > 0)
        {
            _guarantorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorName, fieldData);
        }

        return _guarantorName;
    } 
}

internal HL7V23Field _guarantorSpouseName;

public HL7V23Field GuarantorSpouseName
{
    get
    {
        if (_guarantorSpouseName != null)
        {
            return _guarantorSpouseName;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the name of the guarantor’s spouse.  Multiple names for the same guarantor spouse may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.4.1",
                            Type = @"Component",
                            Position = @"GT1.4.1",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
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
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorSpouseName = new HL7V23Field
        {
            field = message[@"GT1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSpouseName.field.FieldRepetitions != null && _guarantorSpouseName.field.FieldRepetitions.Count > 0)
        {
            _guarantorSpouseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorSpouseName, fieldData);
        }

        return _guarantorSpouseName;
    } 
}

internal HL7V23Field _guarantorAddress;

public HL7V23Field GuarantorAddress
{
    get
    {
        if (_guarantorAddress != null)
        {
            return _guarantorAddress;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s address.  Multiple addresses for the same person may be sent in this field.  The mailing address is assumed to be in the first repetition.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"The street or mailing address of a person or institution",
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
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
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
                            Description = @"tate or province should be represented by the official postal service codes for that country",
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
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
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
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
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
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
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
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.5.9",
                            Type = @"Component",
                            Position = @"GT1.5.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
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
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorAddress = new HL7V23Field
        {
            field = message[@"GT1"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorAddress.field.FieldRepetitions != null && _guarantorAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorAddress, fieldData);
        }

        return _guarantorAddress;
    } 
}

internal HL7V23Field _guarantorPhNumHome;

public HL7V23Field GuarantorPhNumHome
{
    get
    {
        if (_guarantorPhNumHome != null)
        {
            return _guarantorPhNumHome;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.6",
            Type = @"Field",
            Position = @"GT1.6",
            Name = @"Guarantor Ph Num- Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor’s home phone number.  All personal phone numbers for the guarantor may be sent in this field.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.6.2",
                            Type = @"Component",
                            Position = @"GT1.6.2",
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
                            Id = @"GT1.6.3",
                            Type = @"Component",
                            Position = @"GT1.6.3",
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
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
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

        _guarantorPhNumHome = new HL7V23Field
        {
            field = message[@"GT1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumHome.field.FieldRepetitions != null && _guarantorPhNumHome.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorPhNumHome, fieldData);
        }

        return _guarantorPhNumHome;
    } 
}

internal HL7V23Field _guarantorPhNumBusiness;

public HL7V23Field GuarantorPhNumBusiness
{
    get
    {
        if (_guarantorPhNumBusiness != null)
        {
            return _guarantorPhNumBusiness;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s business phone number.  All business phone numbers for the guarantor may be sent in this field.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.7.2",
                            Type = @"Component",
                            Position = @"GT1.7.2",
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
                            Id = @"GT1.7.3",
                            Type = @"Component",
                            Position = @"GT1.7.3",
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
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
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

        _guarantorPhNumBusiness = new HL7V23Field
        {
            field = message[@"GT1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPhNumBusiness.field.FieldRepetitions != null && _guarantorPhNumBusiness.field.FieldRepetitions.Count > 0)
        {
            _guarantorPhNumBusiness.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorPhNumBusiness, fieldData);
        }

        return _guarantorPhNumBusiness;
    } 
}

internal HL7V23Field _guarantorDateTimeofBirth;

public HL7V23Field GuarantorDateTimeofBirth
{
    get
    {
        if (_guarantorDateTimeofBirth != null)
        {
            return _guarantorDateTimeofBirth;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.8",
            Type = @"Field",
            Position = @"GT1.8",
            Name = @"Guarantor Date/Time of Birth",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor’s date of birth.",
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

        _guarantorDateTimeofBirth = new HL7V23Field
        {
            field = message[@"GT1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateTimeofBirth.field.FieldRepetitions != null && _guarantorDateTimeofBirth.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateTimeofBirth.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorDateTimeofBirth, fieldData);
        }

        return _guarantorDateTimeofBirth;
    } 
}

internal HL7V23Field _guarantorSex;

public HL7V23Field GuarantorSex
{
    get
    {
        if (_guarantorSex != null)
        {
            return _guarantorSex;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s gender.  Refer to user-defined table 0001 - Sex for valid values.",
            Sample = @"",
            Fields = null
        }

        _guarantorSex = new HL7V23Field
        {
            field = message[@"GT1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSex.field.FieldRepetitions != null && _guarantorSex.field.FieldRepetitions.Count > 0)
        {
            _guarantorSex.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorSex, fieldData);
        }

        return _guarantorSex;
    } 
}

internal HL7V23Field _guarantorType;

public HL7V23Field GuarantorType
{
    get
    {
        if (_guarantorType != null)
        {
            return _guarantorType;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field indicates the type of guarantor, e.g., individual, institution, etc.  Refer to user-defined table 0068 - Guarantor type for suggested values.",
            Sample = @"",
            Fields = null
        }

        _guarantorType = new HL7V23Field
        {
            field = message[@"GT1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorType.field.FieldRepetitions != null && _guarantorType.field.FieldRepetitions.Count > 0)
        {
            _guarantorType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorType, fieldData);
        }

        return _guarantorType;
    } 
}

internal HL7V23Field _guarantorRelationship;

public HL7V23Field GuarantorRelationship
{
    get
    {
        if (_guarantorRelationship != null)
        {
            return _guarantorRelationship;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.11",
            Type = @"Field",
            Position = @"GT1.11",
            Name = @"Guarantor Relationship",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field indicates the relationship of the guarantor with the patient, e.g., parent, child, etc.  Refer to user-defined table 0063 - Relationship for suggested values.",
            Sample = @"",
            Fields = null
        }

        _guarantorRelationship = new HL7V23Field
        {
            field = message[@"GT1"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRelationship.field.FieldRepetitions != null && _guarantorRelationship.field.FieldRepetitions.Count > 0)
        {
            _guarantorRelationship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorRelationship, fieldData);
        }

        return _guarantorRelationship;
    } 
}

internal HL7V23Field _guarantorSSN;

public HL7V23Field GuarantorSSN
{
    get
    {
        if (_guarantorSSN != null)
        {
            return _guarantorSSN;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s social security number.",
            Sample = @"",
            Fields = null
        }

        _guarantorSSN = new HL7V23Field
        {
            field = message[@"GT1"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorSSN.field.FieldRepetitions != null && _guarantorSSN.field.FieldRepetitions.Count > 0)
        {
            _guarantorSSN.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorSSN, fieldData);
        }

        return _guarantorSSN;
    } 
}

internal HL7V23Field _guarantorDateBegin;

public HL7V23Field GuarantorDateBegin
{
    get
    {
        if (_guarantorDateBegin != null)
        {
            return _guarantorDateBegin;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the date that the guarantor becomes responsible for the patient’s account.",
            Sample = @"",
            Fields = null
        }

        _guarantorDateBegin = new HL7V23Field
        {
            field = message[@"GT1"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateBegin.field.FieldRepetitions != null && _guarantorDateBegin.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateBegin.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorDateBegin, fieldData);
        }

        return _guarantorDateBegin;
    } 
}

internal HL7V23Field _guarantorDateEnd;

public HL7V23Field GuarantorDateEnd
{
    get
    {
        if (_guarantorDateEnd != null)
        {
            return _guarantorDateEnd;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the date that the guarantor stops being responsible for the patient’s account.",
            Sample = @"",
            Fields = null
        }

        _guarantorDateEnd = new HL7V23Field
        {
            field = message[@"GT1"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDateEnd.field.FieldRepetitions != null && _guarantorDateEnd.field.FieldRepetitions.Count > 0)
        {
            _guarantorDateEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorDateEnd, fieldData);
        }

        return _guarantorDateEnd;
    } 
}

internal HL7V23Field _guarantorPriority;

public HL7V23Field GuarantorPriority
{
    get
    {
        if (_guarantorPriority != null)
        {
            return _guarantorPriority;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field is used to determine the order in which the guarantors are responsible for the patient’s account.  

“1” = primary guarantor
“2” = secondary guarantor, etc",
            Sample = @"",
            Fields = null
        }

        _guarantorPriority = new HL7V23Field
        {
            field = message[@"GT1"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorPriority.field.FieldRepetitions != null && _guarantorPriority.field.FieldRepetitions.Count > 0)
        {
            _guarantorPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorPriority, fieldData);
        }

        return _guarantorPriority;
    } 
}

internal HL7V23Field _guarantorEmployerName;

public HL7V23Field GuarantorEmployerName
{
    get
    {
        if (_guarantorEmployerName != null)
        {
            return _guarantorEmployerName;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the name of the guarantor’s employer, if the employer is a person.  When the guarantor’s employer is an organization, use GT1-51-guarantor employer’s organization name  Multiple names for the same person may be sent in this field, not multiple employers.  The legal name must be sent first in the repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.16.1",
                            Type = @"Component",
                            Position = @"GT1.16.1",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
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
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployerName = new HL7V23Field
        {
            field = message[@"GT1"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerName.field.FieldRepetitions != null && _guarantorEmployerName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployerName, fieldData);
        }

        return _guarantorEmployerName;
    } 
}

internal HL7V23Field _guarantorEmployerAddress;

public HL7V23Field GuarantorEmployerAddress
{
    get
    {
        if (_guarantorEmployerAddress != null)
        {
            return _guarantorEmployerAddress;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s employer’s address.  Multiple addresses for the same employer may be sent in this field.  The mailing address must be sent first in the repetition.  When the mailing address is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"The street or mailing address of a person or institution",
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
                            Description = @"Second line of address.  In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
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
                            Description = @"tate or province should be represented by the official postal service codes for that country",
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
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
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
                            Description = @"Defines the country of the address.  ISO 3166 provides a list of country codes that may be used",
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
                            Description = @"Address type is optional and defined by HL7 table 0190 - Address type",
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
                            Description = @"Other geographic designation includes country, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.17.9",
                            Type = @"Component",
                            Position = @"GT1.17.9",
                            Name = @"County/parish Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0289",
                            TableName = @"County/parish",
                            Description = @"A code that represents the county in which the specified address resides. Refer to user-defined table 0289 - County/parish.  When this component is used to represent the county (or parish), component 8 “other geographic designation” should not duplicate it (i.e., the use of “other geographic designation” to represent the county is allowed only for the purpose of backward compatibility, and should be discouraged in this and future versions of HL7).

Allowable values:  codes defined by government",
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
                            Description = @"A code that represents the census track in which the specified address resides. Refer to user-defined table 0288 - Census tract. 
Allowable Values:  codes defined by government",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorEmployerAddress = new HL7V23Field
        {
            field = message[@"GT1"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerAddress.field.FieldRepetitions != null && _guarantorEmployerAddress.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployerAddress, fieldData);
        }

        return _guarantorEmployerAddress;
    } 
}

internal HL7V23Field _guarantorEmployPhoneNumber;

public HL7V23Field GuarantorEmployPhoneNumber
{
    get
    {
        if (_guarantorEmployPhoneNumber != null)
        {
            return _guarantorEmployPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.18",
            Type = @"Field",
            Position = @"GT1.18",
            Name = @"Guarantor Employ Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor’s employer’s phone number.  Multiple phone numbers for the same employer.  The primary telephone number must be sent first in the sequence.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.18.2",
                            Type = @"Component",
                            Position = @"GT1.18.2",
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
                            Id = @"GT1.18.3",
                            Type = @"Component",
                            Position = @"GT1.18.3",
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
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
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

        _guarantorEmployPhoneNumber = new HL7V23Field
        {
            field = message[@"GT1"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployPhoneNumber.field.FieldRepetitions != null && _guarantorEmployPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployPhoneNumber, fieldData);
        }

        return _guarantorEmployPhoneNumber;
    } 
}

internal HL7V23Field _guarantorEmployeeIDNumber;

public HL7V23Field GuarantorEmployeeIDNumber
{
    get
    {
        if (_guarantorEmployeeIDNumber != null)
        {
            return _guarantorEmployeeIDNumber;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the guarantor’s employee number.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.19.1",
                            Type = @"Component",
                            Position = @"GT1.19.1",
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
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
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
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
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
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.19.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.1",
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
                            Id = @"GT1.19.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.2",
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
                            Id = @"GT1.19.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.19.4.3",
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
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
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
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.19.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.1",
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
                            Id = @"GT1.19.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.2",
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
                            Id = @"GT1.19.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.19.6.3",
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

        _guarantorEmployeeIDNumber = new HL7V23Field
        {
            field = message[@"GT1"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployeeIDNumber.field.FieldRepetitions != null && _guarantorEmployeeIDNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployeeIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployeeIDNumber, fieldData);
        }

        return _guarantorEmployeeIDNumber;
    } 
}

internal HL7V23Field _guarantorEmploymentStatus;

public HL7V23Field GuarantorEmploymentStatus
{
    get
    {
        if (_guarantorEmploymentStatus != null)
        {
            return _guarantorEmploymentStatus;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the code that indicates the guarantor’s employment status, e.g., full time, part time, self-employed, etc.  Refer to user-defined table 0066 - Employment status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _guarantorEmploymentStatus = new HL7V23Field
        {
            field = message[@"GT1"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmploymentStatus.field.FieldRepetitions != null && _guarantorEmploymentStatus.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmploymentStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmploymentStatus, fieldData);
        }

        return _guarantorEmploymentStatus;
    } 
}

internal HL7V23Field _guarantorOrganization;

public HL7V23Field GuarantorOrganization
{
    get
    {
        if (_guarantorOrganization != null)
        {
            return _guarantorOrganization;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.21",
            Type = @"Field",
            Position = @"GT1.21",
            Name = @"Guarantor Organization",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor when the guarantor is an organization.  Multiple names for the same guarantor may be sent in this field, not multiple guarantors.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.  The components for this data type are described in Chapter 2. 

Beginning with Version 2.3, if the guarantor is a person, send a null value ("""") in GT1-21-guarantor organization name and put the person name in GT1-3-guarantor person name.  Either guarantor person name or guarantor organization name is required.",
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
                            Description = @"The name of the specified organization",
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
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.3",
                            Type = @"Component",
                            Position = @"GT1.21.3",
                            Name = @"ID Number",
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
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
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
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
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
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.21.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.1",
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
                            Id = @"GT1.21.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.2",
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
                            Id = @"GT1.21.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.21.6.3",
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
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.21.8",
                            Type = @"Component",
                            Position = @"GT1.21.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.21.8.1",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.1",
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
                            Id = @"GT1.21.8.2",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.2",
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
                            Id = @"GT1.21.8.3",
                            Type = @"SubComponent",
                            Position = @"GT1.21.8.3",
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

        _guarantorOrganization = new HL7V23Field
        {
            field = message[@"GT1"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorOrganization.field.FieldRepetitions != null && _guarantorOrganization.field.FieldRepetitions.Count > 0)
        {
            _guarantorOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorOrganization, fieldData);
        }

        return _guarantorOrganization;
    } 
}

internal HL7V23Field _guarantorBillingHoldFlag;

public HL7V23Field GuarantorBillingHoldFlag
{
    get
    {
        if (_guarantorBillingHoldFlag != null)
        {
            return _guarantorBillingHoldFlag;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field indicates whether or not a system should suppress printing of the guarantor’s bills.   

Y a system should suppress printing of guarantor’s bills
N a system should not suppress printing of guarantor’s bills",
            Sample = @"",
            Fields = null
        }

        _guarantorBillingHoldFlag = new HL7V23Field
        {
            field = message[@"GT1"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorBillingHoldFlag.field.FieldRepetitions != null && _guarantorBillingHoldFlag.field.FieldRepetitions.Count > 0)
        {
            _guarantorBillingHoldFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorBillingHoldFlag, fieldData);
        }

        return _guarantorBillingHoldFlag;
    } 
}

internal HL7V23Field _guarantorCreditRatingCode;

public HL7V23Field GuarantorCreditRatingCode
{
    get
    {
        if (_guarantorCreditRatingCode != null)
        {
            return _guarantorCreditRatingCode;
        }

        var fieldData = new HL7V23FieldData
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
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor’s credit rating.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.23.4",
                            Type = @"Component",
                            Position = @"GT1.23.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorCreditRatingCode = new HL7V23Field
        {
            field = message[@"GT1"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorCreditRatingCode.field.FieldRepetitions != null && _guarantorCreditRatingCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorCreditRatingCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorCreditRatingCode, fieldData);
        }

        return _guarantorCreditRatingCode;
    } 
}

internal HL7V23Field _guarantorDeathDateAndTime;

public HL7V23Field GuarantorDeathDateAndTime
{
    get
    {
        if (_guarantorDeathDateAndTime != null)
        {
            return _guarantorDeathDateAndTime;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field is used to indicate the date and time at which the guarantor’s death occurred.",
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

        _guarantorDeathDateAndTime = new HL7V23Field
        {
            field = message[@"GT1"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDeathDateAndTime.field.FieldRepetitions != null && _guarantorDeathDateAndTime.field.FieldRepetitions.Count > 0)
        {
            _guarantorDeathDateAndTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorDeathDateAndTime, fieldData);
        }

        return _guarantorDeathDateAndTime;
    } 
}

internal HL7V23Field _guarantorDeathFlag;

public HL7V23Field GuarantorDeathFlag
{
    get
    {
        if (_guarantorDeathFlag != null)
        {
            return _guarantorDeathFlag;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field indicates whether or not the guarantor is deceased. Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the guarantor is deceased 
N the guarantor is living ",
            Sample = @"",
            Fields = null
        }

        _guarantorDeathFlag = new HL7V23Field
        {
            field = message[@"GT1"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorDeathFlag.field.FieldRepetitions != null && _guarantorDeathFlag.field.FieldRepetitions.Count > 0)
        {
            _guarantorDeathFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorDeathFlag, fieldData);
        }

        return _guarantorDeathFlag;
    } 
}

internal HL7V23Field _guarantorChargeAdjustmentCode;

public HL7V23Field GuarantorChargeAdjustmentCode
{
    get
    {
        if (_guarantorChargeAdjustmentCode != null)
        {
            return _guarantorChargeAdjustmentCode;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains user-defined codes that indicate which adjustments should be made to this guarantor’s charges.  For example, when the hospital agrees to adjust this guarantor’s charges to a sliding scale.  Refer to user-defined table 0218 - Charge adjustment for suggested values. 

Example:  This field would contain the value used for sliding-fee scale processingé",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.26.4",
                            Type = @"Component",
                            Position = @"GT1.26.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorChargeAdjustmentCode = new HL7V23Field
        {
            field = message[@"GT1"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorChargeAdjustmentCode.field.FieldRepetitions != null && _guarantorChargeAdjustmentCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorChargeAdjustmentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorChargeAdjustmentCode, fieldData);
        }

        return _guarantorChargeAdjustmentCode;
    } 
}

internal HL7V23Field _guarantorHouseholdAnnualIncome;

public HL7V23Field GuarantorHouseholdAnnualIncome
{
    get
    {
        if (_guarantorHouseholdAnnualIncome != null)
        {
            return _guarantorHouseholdAnnualIncome;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the combined annual income of all members of the guarantor’s household.",
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
                            Description = @"The only required component; usually containing a decimal point. ",
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
                            Description = @"The first component is a quantity",
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
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
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
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
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
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
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
                            Description = @"See From value",
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
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.27.5.4",
                            Type = @"SubComponent",
                            Position = @"GT1.27.5.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _guarantorHouseholdAnnualIncome = new HL7V23Field
        {
            field = message[@"GT1"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHouseholdAnnualIncome.field.FieldRepetitions != null && _guarantorHouseholdAnnualIncome.field.FieldRepetitions.Count > 0)
        {
            _guarantorHouseholdAnnualIncome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorHouseholdAnnualIncome, fieldData);
        }

        return _guarantorHouseholdAnnualIncome;
    } 
}

internal HL7V23Field _guarantorHouseholdSize;

public HL7V23Field GuarantorHouseholdSize
{
    get
    {
        if (_guarantorHouseholdSize != null)
        {
            return _guarantorHouseholdSize;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field specifies the number of people living at the guarantor’s primary residence.",
            Sample = @"",
            Fields = null
        }

        _guarantorHouseholdSize = new HL7V23Field
        {
            field = message[@"GT1"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHouseholdSize.field.FieldRepetitions != null && _guarantorHouseholdSize.field.FieldRepetitions.Count > 0)
        {
            _guarantorHouseholdSize.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorHouseholdSize, fieldData);
        }

        return _guarantorHouseholdSize;
    } 
}

internal HL7V23Field _guarantorEmployerIDNumber;

public HL7V23Field GuarantorEmployerIDNumber
{
    get
    {
        if (_guarantorEmployerIDNumber != null)
        {
            return _guarantorEmployerIDNumber;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This is a code that uniquely identifies the guarantor’s employer when the employer is a person.  It may be a user-defined code or a code defined by a government agency (Federal Tax ID#).   

When further breakdowns of employer information are needed, such as a division or plant, it is recommended that the coding scheme incorporate the relationships (e.g., define separate codes for each division).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.29.1",
                            Type = @"Component",
                            Position = @"GT1.29.1",
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
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
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
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
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
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.29.4.1",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.1",
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
                            Id = @"GT1.29.4.2",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.2",
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
                            Id = @"GT1.29.4.3",
                            Type = @"SubComponent",
                            Position = @"GT1.29.4.3",
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
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
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
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.29.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.1",
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
                            Id = @"GT1.29.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.2",
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
                            Id = @"GT1.29.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.29.6.3",
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

        _guarantorEmployerIDNumber = new HL7V23Field
        {
            field = message[@"GT1"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployerIDNumber.field.FieldRepetitions != null && _guarantorEmployerIDNumber.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployerIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployerIDNumber, fieldData);
        }

        return _guarantorEmployerIDNumber;
    } 
}

internal HL7V23Field _guarantorMaritalStatusCode;

public HL7V23Field GuarantorMaritalStatusCode
{
    get
    {
        if (_guarantorMaritalStatusCode != null)
        {
            return _guarantorMaritalStatusCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.30",
            Type = @"Field",
            Position = @"GT1.30",
            Name = @"Guarantor Marital Status Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the marital status of the guarantor.  Refer to user-defined table 0002 - Marital status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _guarantorMaritalStatusCode = new HL7V23Field
        {
            field = message[@"GT1"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorMaritalStatusCode.field.FieldRepetitions != null && _guarantorMaritalStatusCode.field.FieldRepetitions.Count > 0)
        {
            _guarantorMaritalStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorMaritalStatusCode, fieldData);
        }

        return _guarantorMaritalStatusCode;
    } 
}

internal HL7V23Field _guarantorHireEffectiveDate;

public HL7V23Field GuarantorHireEffectiveDate
{
    get
    {
        if (_guarantorHireEffectiveDate != null)
        {
            return _guarantorHireEffectiveDate;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the date that the guarantor’s employment began.",
            Sample = @"",
            Fields = null
        }

        _guarantorHireEffectiveDate = new HL7V23Field
        {
            field = message[@"GT1"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorHireEffectiveDate.field.FieldRepetitions != null && _guarantorHireEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _guarantorHireEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorHireEffectiveDate, fieldData);
        }

        return _guarantorHireEffectiveDate;
    } 
}

internal HL7V23Field _employmentStopDate;

public HL7V23Field EmploymentStopDate
{
    get
    {
        if (_employmentStopDate != null)
        {
            return _employmentStopDate;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"his field indicates the date on which the guarantor’s employment with a particular employer ended.",
            Sample = @"",
            Fields = null
        }

        _employmentStopDate = new HL7V23Field
        {
            field = message[@"GT1"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentStopDate.field.FieldRepetitions != null && _employmentStopDate.field.FieldRepetitions.Count > 0)
        {
            _employmentStopDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employmentStopDate, fieldData);
        }

        return _employmentStopDate;
    } 
}

internal HL7V23Field _livingDependency;

public HL7V23Field LivingDependency
{
    get
    {
        if (_livingDependency != null)
        {
            return _livingDependency;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"Identifies the specific living conditions of the guarantor.  Refer to user-defined table 0223 - Living dependency for suggested values.",
            Sample = @"",
            Fields = null
        }

        _livingDependency = new HL7V23Field
        {
            field = message[@"GT1"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingDependency.field.FieldRepetitions != null && _livingDependency.field.FieldRepetitions.Count > 0)
        {
            _livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingDependency, fieldData);
        }

        return _livingDependency;
    } 
}

internal HL7V23Field _ambulatoryStatusCode;

public HL7V23Field AmbulatoryStatusCode
{
    get
    {
        if (_ambulatoryStatusCode != null)
        {
            return _ambulatoryStatusCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.34",
            Type = @"Field",
            Position = @"GT1.34",
            Name = @"Ambulatory Status Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"Identifies the transient state of mobility for the guarantor.  Refer to user-defined table 0009 - Ambulatory status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatusCode = new HL7V23Field
        {
            field = message[@"GT1"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatusCode.field.FieldRepetitions != null && _ambulatoryStatusCode.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ambulatoryStatusCode, fieldData);
        }

        return _ambulatoryStatusCode;
    } 
}

internal HL7V23Field _citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.35",
            Type = @"Field",
            Position = @"GT1.35",
            Name = @"Citizenship",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the code to identify the guarantor’s citizenship.  HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship.",
            Sample = @"",
            Fields = null
        }

        _citizenship = new HL7V23Field
        {
            field = message[@"GT1"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V23Field _primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (_primaryLanguage != null)
        {
            return _primaryLanguage;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field identifies the guarantor’s primary speaking language.  HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.36.4",
                            Type = @"Component",
                            Position = @"GT1.36.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryLanguage = new HL7V23Field
        {
            field = message[@"GT1"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryLanguage.field.FieldRepetitions != null && _primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            _primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryLanguage, fieldData);
        }

        return _primaryLanguage;
    } 
}

internal HL7V23Field _livingArrangement;

public HL7V23Field LivingArrangement
{
    get
    {
        if (_livingArrangement != null)
        {
            return _livingArrangement;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field identifies the situation in which the person lives at his residential address.  Refer to the user-defined table 0220- Living arrangement for suggested values.",
            Sample = @"",
            Fields = null
        }

        _livingArrangement = new HL7V23Field
        {
            field = message[@"GT1"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingArrangement.field.FieldRepetitions != null && _livingArrangement.field.FieldRepetitions.Count > 0)
        {
            _livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingArrangement, fieldData);
        }

        return _livingArrangement;
    } 
}

internal HL7V23Field _publicityIndicator;

public HL7V23Field PublicityIndicator
{
    get
    {
        if (_publicityIndicator != null)
        {
            return _publicityIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.38",
            Type = @"Field",
            Position = @"GT1.38",
            Name = @"Publicity Indicator",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for a guarantor.  Refer to user-defined table 0215 - Publicity indicator for suggested values.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.38.4",
                            Type = @"Component",
                            Position = @"GT1.38.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _publicityIndicator = new HL7V23Field
        {
            field = message[@"GT1"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_publicityIndicator.field.FieldRepetitions != null && _publicityIndicator.field.FieldRepetitions.Count > 0)
        {
            _publicityIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_publicityIndicator, fieldData);
        }

        return _publicityIndicator;
    } 
}

internal HL7V23Field _protectionIndicator;

public HL7V23Field ProtectionIndicator
{
    get
    {
        if (_protectionIndicator != null)
        {
            return _protectionIndicator;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field identifies the guarantor’s protection, which determines whether or not access to information about this enrollee should be restricted from users who do not have adequate authority.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y restrict access
N do not restrict access",
            Sample = @"",
            Fields = null
        }

        _protectionIndicator = new HL7V23Field
        {
            field = message[@"GT1"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_protectionIndicator.field.FieldRepetitions != null && _protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_protectionIndicator, fieldData);
        }

        return _protectionIndicator;
    } 
}

internal HL7V23Field _studentIndicator;

public HL7V23Field StudentIndicator
{
    get
    {
        if (_studentIndicator != null)
        {
            return _studentIndicator;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field indicates whether the guarantor is currently a student, and whether the patient is a full-time or part-time student.  This field does not indicate the degree level (high school, college) of the student, or his/her field of study (accounting, engineering, etc.).  Refer to user-defined table 0231- Student status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _studentIndicator = new HL7V23Field
        {
            field = message[@"GT1"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studentIndicator.field.FieldRepetitions != null && _studentIndicator.field.FieldRepetitions.Count > 0)
        {
            _studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studentIndicator, fieldData);
        }

        return _studentIndicator;
    } 
}

internal HL7V23Field _religion;

public HL7V23Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.41",
            Type = @"Field",
            Position = @"GT1.41",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field indicates the type of religion practiced by the guarantor.  Refer to user-defined table 0006 - Religion for suggested values.",
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V23Field
        {
            field = message[@"GT1"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V23Field _mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.42",
            Type = @"Field",
            Position = @"GT1.42",
            Name = @"Mother s Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the guarantor’s mother’s maiden name.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.42.1",
                            Type = @"Component",
                            Position = @"GT1.42.1",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
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
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _mothersMaidenName = new HL7V23Field
        {
            field = message[@"GT1"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V23Field _nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (_nationalityCode != null)
        {
            return _nationalityCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.43",
            Type = @"Field",
            Position = @"GT1.43",
            Name = @"Nationality Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field contains a code that identifies the nation or national grouping to which the person belongs.  This may be different from a person’s citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.).  HL7 recommends using ISO table 3166 as suggested values in user-defined table 0212 - Nationality.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.43.4",
                            Type = @"Component",
                            Position = @"GT1.43.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nationalityCode = new HL7V23Field
        {
            field = message[@"GT1"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nationalityCode.field.FieldRepetitions != null && _nationalityCode.field.FieldRepetitions.Count > 0)
        {
            _nationalityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nationalityCode, fieldData);
        }

        return _nationalityCode;
    } 
}

internal HL7V23Field _ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.44",
            Type = @"Field",
            Position = @"GT1.44",
            Name = @"Ethnic Group",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field contains the guarantor’s ethnic or race group.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0189 - Ethnic group for suggested values.",
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V23Field
        {
            field = message[@"GT1"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V23Field _contactPersonsName;

public HL7V23Field ContactPersonsName
{
    get
    {
        if (_contactPersonsName != null)
        {
            return _contactPersonsName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.45",
            Type = @"Field",
            Position = @"GT1.45",
            Name = @"Contact Person's Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the person who should be contacted regarding the guarantor bills, etc.  This may be someone other than the guarantor.  (Contact guarantor’s wife regarding all bills - guarantor lives out of country).  The components for this data type are described in Chapter 2. 

This is a repeating field that allows for multiple names for the same person.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetitioné",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"GT1.45.1",
                            Type = @"Component",
                            Position = @"GT1.45.1",
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
                            Description = null,
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
                            Description = null,
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
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
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
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactPersonsName = new HL7V23Field
        {
            field = message[@"GT1"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsName.field.FieldRepetitions != null && _contactPersonsName.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonsName, fieldData);
        }

        return _contactPersonsName;
    } 
}

internal HL7V23Field _contactPersonsTelephoneNumber;

public HL7V23Field ContactPersonsTelephoneNumber
{
    get
    {
        if (_contactPersonsTelephoneNumber != null)
        {
            return _contactPersonsTelephoneNumber;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the telephone number of the guarantor (person) to contact regarding guarantor bills, etc.  Multiple phone numbers for that person may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.",
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
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.46.2",
                            Type = @"Component",
                            Position = @"GT1.46.2",
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
                            Id = @"GT1.46.3",
                            Type = @"Component",
                            Position = @"GT1.46.3",
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
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
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

        _contactPersonsTelephoneNumber = new HL7V23Field
        {
            field = message[@"GT1"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactPersonsTelephoneNumber.field.FieldRepetitions != null && _contactPersonsTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            _contactPersonsTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactPersonsTelephoneNumber, fieldData);
        }

        return _contactPersonsTelephoneNumber;
    } 
}

internal HL7V23Field _contactReason;

public HL7V23Field ContactReason
{
    get
    {
        if (_contactReason != null)
        {
            return _contactReason;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains a user-defined code that identifies the reason for contacting the guarantor, for example, to phone the guarantor if payments are late.  Refer to user-defined table 0222 - Contact reason for suggested values.",
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
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
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
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
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.47.4",
                            Type = @"Component",
                            Position = @"GT1.47.4",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
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
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _contactReason = new HL7V23Field
        {
            field = message[@"GT1"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactReason.field.FieldRepetitions != null && _contactReason.field.FieldRepetitions.Count > 0)
        {
            _contactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactReason, fieldData);
        }

        return _contactReason;
    } 
}

internal HL7V23Field _contactRelationshipCode;

public HL7V23Field ContactRelationshipCode
{
    get
    {
        if (_contactRelationshipCode != null)
        {
            return _contactRelationshipCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.48",
            Type = @"Field",
            Position = @"GT1.48",
            Name = @"Contact Relationship Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"Identifies the guarantor relationship to the contact person specified above.   Some examples of the relationship between the guarantor and the guarantor contact person might include wife, attorney, power of attorney, self, and organization.  Refer to user-defined table 0063 - Relationship for suggested values.",
            Sample = @"",
            Fields = null
        }

        _contactRelationshipCode = new HL7V23Field
        {
            field = message[@"GT1"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_contactRelationshipCode.field.FieldRepetitions != null && _contactRelationshipCode.field.FieldRepetitions.Count > 0)
        {
            _contactRelationshipCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_contactRelationshipCode, fieldData);
        }

        return _contactRelationshipCode;
    } 
}

internal HL7V23Field _jobTitle;

public HL7V23Field JobTitle
{
    get
    {
        if (_jobTitle != null)
        {
            return _jobTitle;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains a descriptive name of the guarantor’s occupation (e.g., Sr. Systems Analyst, Sr. Accountant).",
            Sample = @"",
            Fields = null
        }

        _jobTitle = new HL7V23Field
        {
            field = message[@"GT1"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobTitle.field.FieldRepetitions != null && _jobTitle.field.FieldRepetitions.Count > 0)
        {
            _jobTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobTitle, fieldData);
        }

        return _jobTitle;
    } 
}

internal HL7V23Field _jobCodeClass;

public HL7V23Field JobCodeClass
{
    get
    {
        if (_jobCodeClass != null)
        {
            return _jobCodeClass;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.50",
            Type = @"Field",
            Position = @"GT1.50",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code Class",
            TableId = null,
            TableName = null,
            Description = @"This field contains the guarantor’s job code and employee classification.  Refer to user-defined tables 0327 - Job code and 0328 - Job class for suggested values",
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
                            TableName = @"Job code",
                            Description = @"This component contains the person’s  job code.  Refer to user-defined table 0327 - job code",
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
                            Description = @"This component contains the person’s employee classification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _jobCodeClass = new HL7V23Field
        {
            field = message[@"GT1"][50],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobCodeClass.field.FieldRepetitions != null && _jobCodeClass.field.FieldRepetitions.Count > 0)
        {
            _jobCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobCodeClass, fieldData);
        }

        return _jobCodeClass;
    } 
}

internal HL7V23Field _guarantorEmployersOrganizationName;

public HL7V23Field GuarantorEmployersOrganizationName
{
    get
    {
        if (_guarantorEmployersOrganizationName != null)
        {
            return _guarantorEmployersOrganizationName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.51",
            Type = @"Field",
            Position = @"GT1.51",
            Name = @"Guarantor Employer's Organization Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the guarantor’s employer when the guarantor’s employer is an organization.  When the guarantor’s employer is a person, use GT1-16 guarantor employer name.  Multiple names for the same guarantor may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition. ",
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
                            Description = @"The name of the specified organization",
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
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.3",
                            Type = @"Component",
                            Position = @"GT1.51.3",
                            Name = @"ID Number",
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
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
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
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
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
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.51.6.1",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.1",
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
                            Id = @"GT1.51.6.2",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.2",
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
                            Id = @"GT1.51.6.3",
                            Type = @"SubComponent",
                            Position = @"GT1.51.6.3",
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
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"GT1.51.8",
                            Type = @"Component",
                            Position = @"GT1.51.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"GT1.51.8.1",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.1",
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
                            Id = @"GT1.51.8.2",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.2",
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
                            Id = @"GT1.51.8.3",
                            Type = @"SubComponent",
                            Position = @"GT1.51.8.3",
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

        _guarantorEmployersOrganizationName = new HL7V23Field
        {
            field = message[@"GT1"][51],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorEmployersOrganizationName.field.FieldRepetitions != null && _guarantorEmployersOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _guarantorEmployersOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorEmployersOrganizationName, fieldData);
        }

        return _guarantorEmployersOrganizationName;
    } 
}

internal HL7V23Field _handicap;

public HL7V23Field Handicap
{
    get
    {
        if (_handicap != null)
        {
            return _handicap;
        }

        var fieldData = new HL7V23FieldData
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
            TableId = @"0310",
            TableName = @"Handicap",
            Description = @"This field contains a code to describe the guarantor’s disability.  Refer to user-defined table 0310 - Handicap for suggested values.",
            Sample = @"",
            Fields = null
        }

        _handicap = new HL7V23Field
        {
            field = message[@"GT1"][52],
            fieldData = fieldData
        };

        // check for repetitions
        if (_handicap.field.FieldRepetitions != null && _handicap.field.FieldRepetitions.Count > 0)
        {
            _handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_handicap, fieldData);
        }

        return _handicap;
    } 
}

internal HL7V23Field _jobStatus;

public HL7V23Field JobStatus
{
    get
    {
        if (_jobStatus != null)
        {
            return _jobStatus;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains a code that identifies the guarantor’s current job status, for example, part- time/workers comp, full-time/leave of absence, full-time/suspended.  Refer to user-defined table 0311 - Job status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _jobStatus = new HL7V23Field
        {
            field = message[@"GT1"][53],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobStatus.field.FieldRepetitions != null && _jobStatus.field.FieldRepetitions.Count > 0)
        {
            _jobStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobStatus, fieldData);
        }

        return _jobStatus;
    } 
}

internal HL7V23Field _guarantorFinancialClass;

public HL7V23Field GuarantorFinancialClass
{
    get
    {
        if (_guarantorFinancialClass != null)
        {
            return _guarantorFinancialClass;
        }

        var fieldData = new HL7V23FieldData
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
            Description = @"This field contains the financial class (FC) assigned to the guarantor for the purpose of identifying sources of reimbursement.  It can be different than that of the patient.  When the FC of the guarantor is different than the FC of the patient, and the guarantor’s coverage for that patient has been exhausted, the source of reimbursement falls back onto the FC of the patient.  Refer to user-defined table 0064 - Financial class for suggested values.",
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
                            Description = @"This component contains the financial class assigned to a person. Refer to user-defined table 0064 - Financial class for suggested values",
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
                            Description = @"This component contains the effective date/time of the person’s assignment to the financial class specified in the first component",
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

        _guarantorFinancialClass = new HL7V23Field
        {
            field = message[@"GT1"][54],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorFinancialClass.field.FieldRepetitions != null && _guarantorFinancialClass.field.FieldRepetitions.Count > 0)
        {
            _guarantorFinancialClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorFinancialClass, fieldData);
        }

        return _guarantorFinancialClass;
    } 
}

internal HL7V23Field _guarantorRace;

public HL7V23Field GuarantorRace
{
    get
    {
        if (_guarantorRace != null)
        {
            return _guarantorRace;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"GT1.55",
            Type = @"Field",
            Position = @"GT1.55",
            Name = @"Guarantor Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"This field refers to the guarantor’s race.  Refer to user-defined table 0005 - Race for suggested values.",
            Sample = @"",
            Fields = null
        }

        _guarantorRace = new HL7V23Field
        {
            field = message[@"GT1"][55],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorRace.field.FieldRepetitions != null && _guarantorRace.field.FieldRepetitions.Count > 0)
        {
            _guarantorRace.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorRace, fieldData);
        }

        return _guarantorRace;
    } 
}
    }
}

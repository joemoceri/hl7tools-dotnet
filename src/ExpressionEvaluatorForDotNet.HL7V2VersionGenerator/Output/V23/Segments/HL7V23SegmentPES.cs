using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPES
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PES"; } }

        public string SegmentId { get { return @"PES"; } }
        
        public string LongName { get { return @"Product Experience Sender"; } }
        
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

        public HL7V23SegmentPES(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _senderOrganizationName;

public HL7V23Field SenderOrganizationName
{
    get
    {
        if (_senderOrganizationName != null)
        {
            return _senderOrganizationName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.1",
            Type = @"Field",
            Position = @"PES.1",
            Name = @"Sender Organization Name",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the organization sending the message.  Coded lists of manufacturers such as that from the World Health Organization database might be used in the component of the coded name to identify the source code type.  If sent from an individual, this field may not be sent",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.1.1",
                            Type = @"Component",
                            Position = @"PES.1.1",
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
                            Id = @"PES.1.2",
                            Type = @"Component",
                            Position = @"PES.1.2",
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
                            Id = @"PES.1.3",
                            Type = @"Component",
                            Position = @"PES.1.3",
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
                            Id = @"PES.1.4",
                            Type = @"Component",
                            Position = @"PES.1.4",
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
                            Id = @"PES.1.5",
                            Type = @"Component",
                            Position = @"PES.1.5",
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
                            Id = @"PES.1.6",
                            Type = @"Component",
                            Position = @"PES.1.6",
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
                            Id = @"PES.1.6.1",
                            Type = @"SubComponent",
                            Position = @"PES.1.6.1",
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
                            Id = @"PES.1.6.2",
                            Type = @"SubComponent",
                            Position = @"PES.1.6.2",
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
                            Id = @"PES.1.6.3",
                            Type = @"SubComponent",
                            Position = @"PES.1.6.3",
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
                            Id = @"PES.1.7",
                            Type = @"Component",
                            Position = @"PES.1.7",
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
                            Id = @"PES.1.8",
                            Type = @"Component",
                            Position = @"PES.1.8",
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
                            Id = @"PES.1.8.1",
                            Type = @"SubComponent",
                            Position = @"PES.1.8.1",
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
                            Id = @"PES.1.8.2",
                            Type = @"SubComponent",
                            Position = @"PES.1.8.2",
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
                            Id = @"PES.1.8.3",
                            Type = @"SubComponent",
                            Position = @"PES.1.8.3",
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

        _senderOrganizationName = new HL7V23Field
        {
            field = message[@"PES"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderOrganizationName.field.FieldRepetitions != null && _senderOrganizationName.field.FieldRepetitions.Count > 0)
        {
            _senderOrganizationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderOrganizationName, fieldData);
        }

        return _senderOrganizationName;
    } 
}

internal HL7V23Field _senderIndividualName;

public HL7V23Field SenderIndividualName
{
    get
    {
        if (_senderIndividualName != null)
        {
            return _senderIndividualName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.2",
            Type = @"Field",
            Position = @"PES.2",
            Name = @"Sender Individual Name",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the contact individual.  If sent by an organization, the individuals in the organization who serve as primary contact points correspondence regarding this event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.2.1",
                            Type = @"Component",
                            Position = @"PES.2.1",
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
                            Id = @"PES.2.2",
                            Type = @"Component",
                            Position = @"PES.2.2",
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
                            Id = @"PES.2.3",
                            Type = @"Component",
                            Position = @"PES.2.3",
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
                            Id = @"PES.2.4",
                            Type = @"Component",
                            Position = @"PES.2.4",
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
                            Id = @"PES.2.5",
                            Type = @"Component",
                            Position = @"PES.2.5",
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
                            Id = @"PES.2.6",
                            Type = @"Component",
                            Position = @"PES.2.6",
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
                            Id = @"PES.2.7",
                            Type = @"Component",
                            Position = @"PES.2.7",
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
                            Id = @"PES.2.8",
                            Type = @"Component",
                            Position = @"PES.2.8",
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
                            Id = @"PES.2.9",
                            Type = @"Component",
                            Position = @"PES.2.9",
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
                            Id = @"PES.2.9.1",
                            Type = @"SubComponent",
                            Position = @"PES.2.9.1",
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
                            Id = @"PES.2.9.2",
                            Type = @"SubComponent",
                            Position = @"PES.2.9.2",
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
                            Id = @"PES.2.9.3",
                            Type = @"SubComponent",
                            Position = @"PES.2.9.3",
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
                            Id = @"PES.2.10",
                            Type = @"Component",
                            Position = @"PES.2.10",
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
                            Id = @"PES.2.11",
                            Type = @"Component",
                            Position = @"PES.2.11",
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
                            Id = @"PES.2.12",
                            Type = @"Component",
                            Position = @"PES.2.12",
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
                            Id = @"PES.2.13",
                            Type = @"Component",
                            Position = @"PES.2.13",
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
                            Id = @"PES.2.14",
                            Type = @"Component",
                            Position = @"PES.2.14",
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
                            Id = @"PES.2.14.1",
                            Type = @"SubComponent",
                            Position = @"PES.2.14.1",
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
                            Id = @"PES.2.14.2",
                            Type = @"SubComponent",
                            Position = @"PES.2.14.2",
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
                            Id = @"PES.2.14.3",
                            Type = @"SubComponent",
                            Position = @"PES.2.14.3",
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

        _senderIndividualName = new HL7V23Field
        {
            field = message[@"PES"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderIndividualName.field.FieldRepetitions != null && _senderIndividualName.field.FieldRepetitions.Count > 0)
        {
            _senderIndividualName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderIndividualName, fieldData);
        }

        return _senderIndividualName;
    } 
}

internal HL7V23Field _senderAddress;

public HL7V23Field SenderAddress
{
    get
    {
        if (_senderAddress != null)
        {
            return _senderAddress;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.3",
            Type = @"Field",
            Position = @"PES.3",
            Name = @"Sender Address",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XAD",
            DataTypeName = @"Extended Address",
            TableId = null,
            TableName = null,
            Description = @"This field contains the postal address of the message sender to which correspondence regarding the experience being reported should be directed",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.3.1",
                            Type = @"Component",
                            Position = @"PES.3.1",
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
                            Id = @"PES.3.2",
                            Type = @"Component",
                            Position = @"PES.3.2",
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
                            Id = @"PES.3.3",
                            Type = @"Component",
                            Position = @"PES.3.3",
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
                            Id = @"PES.3.4",
                            Type = @"Component",
                            Position = @"PES.3.4",
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
                            Id = @"PES.3.5",
                            Type = @"Component",
                            Position = @"PES.3.5",
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
                            Id = @"PES.3.6",
                            Type = @"Component",
                            Position = @"PES.3.6",
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
                            Id = @"PES.3.7",
                            Type = @"Component",
                            Position = @"PES.3.7",
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
                            Id = @"PES.3.8",
                            Type = @"Component",
                            Position = @"PES.3.8",
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
                            Id = @"PES.3.9",
                            Type = @"Component",
                            Position = @"PES.3.9",
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
                            Id = @"PES.3.10",
                            Type = @"Component",
                            Position = @"PES.3.10",
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

        _senderAddress = new HL7V23Field
        {
            field = message[@"PES"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderAddress.field.FieldRepetitions != null && _senderAddress.field.FieldRepetitions.Count > 0)
        {
            _senderAddress.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderAddress, fieldData);
        }

        return _senderAddress;
    } 
}

internal HL7V23Field _senderTelephone;

public HL7V23Field SenderTelephone
{
    get
    {
        if (_senderTelephone != null)
        {
            return _senderTelephone;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.4",
            Type = @"Field",
            Position = @"PES.4",
            Name = @"Sender Telephone",
            Length = 44,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the message sender to which telephone communications regarding the experience being reported should be directed.  An electronic mail address can be specified in this field",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.4.1",
                            Type = @"Component",
                            Position = @"PES.4.1",
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
                            Id = @"PES.4.2",
                            Type = @"Component",
                            Position = @"PES.4.2",
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
                            Id = @"PES.4.3",
                            Type = @"Component",
                            Position = @"PES.4.3",
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
                            Id = @"PES.4.4",
                            Type = @"Component",
                            Position = @"PES.4.4",
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
                            Id = @"PES.4.5",
                            Type = @"Component",
                            Position = @"PES.4.5",
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
                            Id = @"PES.4.6",
                            Type = @"Component",
                            Position = @"PES.4.6",
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
                            Id = @"PES.4.7",
                            Type = @"Component",
                            Position = @"PES.4.7",
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
                            Id = @"PES.4.8",
                            Type = @"Component",
                            Position = @"PES.4.8",
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
                            Id = @"PES.4.9",
                            Type = @"Component",
                            Position = @"PES.4.9",
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

        _senderTelephone = new HL7V23Field
        {
            field = message[@"PES"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderTelephone.field.FieldRepetitions != null && _senderTelephone.field.FieldRepetitions.Count > 0)
        {
            _senderTelephone.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderTelephone, fieldData);
        }

        return _senderTelephone;
    } 
}

internal HL7V23Field _senderEventIdentifier;

public HL7V23Field SenderEventIdentifier
{
    get
    {
        if (_senderEventIdentifier != null)
        {
            return _senderEventIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.5",
            Type = @"Field",
            Position = @"PES.5",
            Name = @"Sender Event Identifier",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"The first component of this field contains the product manufacturer’s unique alphanumeric identifier for this specific event.  This identifier will be used on all subsequent communications regarding this event.  For events reported to the FDA, the identifier is: the FDA assigned manufacturer or distributor number; a hyphen; the 4-digit year; a hyphen; and a consecutive 5-digit sequence number for each report filled by the sender that year.  For example, the event identifier for the third event reported in 1996 by a manufacturer whose FDA-assigned registration number is 1234567 would be 1234567-1993-3.  Organizations without an FDA-assigned registration number should use 0000000 until assigned a number.  Reports from other facilities should use the 10-digit HCFA number left padded with zeros in place of the FDA-assigned registration number.  The second through fourth components are defined in exactly the same way as the three components of the hierarchic designator (HD) data type (Section 2.8.18, “HD - hierarchic designator”). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.5.1",
                            Type = @"Component",
                            Position = @"PES.5.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PES.5.2",
                            Type = @"Component",
                            Position = @"PES.5.2",
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
                            Id = @"PES.5.3",
                            Type = @"Component",
                            Position = @"PES.5.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PES.5.4",
                            Type = @"Component",
                            Position = @"PES.5.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _senderEventIdentifier = new HL7V23Field
        {
            field = message[@"PES"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderEventIdentifier.field.FieldRepetitions != null && _senderEventIdentifier.field.FieldRepetitions.Count > 0)
        {
            _senderEventIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderEventIdentifier, fieldData);
        }

        return _senderEventIdentifier;
    } 
}

internal HL7V23Field _senderSequenceNumber;

public HL7V23Field SenderSequenceNumber
{
    get
    {
        if (_senderSequenceNumber != null)
        {
            return _senderSequenceNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.6",
            Type = @"Field",
            Position = @"PES.6",
            Name = @"Sender Sequence Number",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains sequentially assigned integer values which distinguish messages which share the same sender event identification element.  0 for initial report, 1 for second, and so on",
            Sample = @"",
            Fields = null
        }

        _senderSequenceNumber = new HL7V23Field
        {
            field = message[@"PES"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderSequenceNumber.field.FieldRepetitions != null && _senderSequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _senderSequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderSequenceNumber, fieldData);
        }

        return _senderSequenceNumber;
    } 
}

internal HL7V23Field _senderEventDescription;

public HL7V23Field SenderEventDescription
{
    get
    {
        if (_senderEventDescription != null)
        {
            return _senderEventDescription;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.7",
            Type = @"Field",
            Position = @"PES.7",
            Name = @"Sender Event Description",
            Length = 600,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the summary narrative text description of the event that occurred written by the sender, which may include a description of the nature of the event, how the product was involved, any environmental conditions that may have influenced the event, and patient follow-up or required treatment.  Note that laboratory results can be encoded as OBX segments rather then including them in the narrative.  By representing clinical information in OBX segments rather than in the narrative, these data become much more useful and flexible",
            Sample = @"",
            Fields = null
        }

        _senderEventDescription = new HL7V23Field
        {
            field = message[@"PES"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderEventDescription.field.FieldRepetitions != null && _senderEventDescription.field.FieldRepetitions.Count > 0)
        {
            _senderEventDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderEventDescription, fieldData);
        }

        return _senderEventDescription;
    } 
}

internal HL7V23Field _senderComment;

public HL7V23Field SenderComment
{
    get
    {
        if (_senderComment != null)
        {
            return _senderComment;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.8",
            Type = @"Field",
            Position = @"PES.8",
            Name = @"Sender Comment",
            Length = 600,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"FT",
            DataTypeName = @"Formatted Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the text commentary regarding the report being made, such as disclaimers, which is not necessarily part of the report",
            Sample = @"",
            Fields = null
        }

        _senderComment = new HL7V23Field
        {
            field = message[@"PES"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderComment.field.FieldRepetitions != null && _senderComment.field.FieldRepetitions.Count > 0)
        {
            _senderComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderComment, fieldData);
        }

        return _senderComment;
    } 
}

internal HL7V23Field _senderAwareDateTime;

public HL7V23Field SenderAwareDateTime
{
    get
    {
        if (_senderAwareDateTime != null)
        {
            return _senderAwareDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.9",
            Type = @"Field",
            Position = @"PES.9",
            Name = @"Sender Aware Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the date the sender became aware of the event",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.9.1",
                            Type = @"Component",
                            Position = @"PES.9.1",
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

        _senderAwareDateTime = new HL7V23Field
        {
            field = message[@"PES"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_senderAwareDateTime.field.FieldRepetitions != null && _senderAwareDateTime.field.FieldRepetitions.Count > 0)
        {
            _senderAwareDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_senderAwareDateTime, fieldData);
        }

        return _senderAwareDateTime;
    } 
}

internal HL7V23Field _eventReportDate;

public HL7V23Field EventReportDate
{
    get
    {
        if (_eventReportDate != null)
        {
            return _eventReportDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.10",
            Type = @"Field",
            Position = @"PES.10",
            Name = @"Event Report Date",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date the message was originally sent to the regulatory agency",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PES.10.1",
                            Type = @"Component",
                            Position = @"PES.10.1",
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

        _eventReportDate = new HL7V23Field
        {
            field = message[@"PES"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReportDate.field.FieldRepetitions != null && _eventReportDate.field.FieldRepetitions.Count > 0)
        {
            _eventReportDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventReportDate, fieldData);
        }

        return _eventReportDate;
    } 
}

internal HL7V23Field _eventReportTimingType;

public HL7V23Field EventReportTimingType
{
    get
    {
        if (_eventReportTimingType != null)
        {
            return _eventReportTimingType;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.11",
            Type = @"Field",
            Position = @"PES.11",
            Name = @"Event Report Timing/Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0234",
            TableName = @"Report timing",
            Description = @"This field contains the timing type of report as required by regulatory agency.  Refer to HL7 table 0234 - Report timing for valid values",
            Sample = @"",
            Fields = null
        }

        _eventReportTimingType = new HL7V23Field
        {
            field = message[@"PES"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReportTimingType.field.FieldRepetitions != null && _eventReportTimingType.field.FieldRepetitions.Count > 0)
        {
            _eventReportTimingType.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventReportTimingType, fieldData);
        }

        return _eventReportTimingType;
    } 
}

internal HL7V23Field _eventReportSource;

public HL7V23Field EventReportSource
{
    get
    {
        if (_eventReportSource != null)
        {
            return _eventReportSource;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.12",
            Type = @"Field",
            Position = @"PES.12",
            Name = @"Event Report Source",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0235",
            TableName = @"Report source",
            Description = @"This field identifies the source from which the sender learned about the event.  Multiple sources may be reported by repeating the element. 
If the source of the report is a clinical trial, the CSR and CSP segments can be included to define the study.  Refer to HL7 table 0235 - Report source for valid values",
            Sample = @"",
            Fields = null
        }

        _eventReportSource = new HL7V23Field
        {
            field = message[@"PES"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReportSource.field.FieldRepetitions != null && _eventReportSource.field.FieldRepetitions.Count > 0)
        {
            _eventReportSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventReportSource, fieldData);
        }

        return _eventReportSource;
    } 
}

internal HL7V23Field _eventReportedTo;

public HL7V23Field EventReportedTo
{
    get
    {
        if (_eventReportedTo != null)
        {
            return _eventReportedTo;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PES.13",
            Type = @"Field",
            Position = @"PES.13",
            Name = @"Event Reported To",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0236",
            TableName = @"Event reported to",
            Description = @"This field indicates all the entities to whom the entity submitting the report has reported the event.  Repeat the element if the report was submitted to more than one entity.  Refer to HL7 table 0236 - Event reported to for valid values.",
            Sample = @"",
            Fields = null
        }

        _eventReportedTo = new HL7V23Field
        {
            field = message[@"PES"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventReportedTo.field.FieldRepetitions != null && _eventReportedTo.field.FieldRepetitions.Count > 0)
        {
            _eventReportedTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eventReportedTo, fieldData);
        }

        return _eventReportedTo;
    } 
}
    }
}

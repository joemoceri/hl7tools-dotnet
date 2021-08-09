using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentORG
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ORG"; } }

        public string SegmentId { get { return @"ORG"; } }
        
        public string LongName { get { return @"Practitioner Organization Unit"; } }
        
        public string Description { get { return @"The ORG segment relates a practitioner to an organization unit and adds detailed information regarding the practitioner's practicing specialty in that organization unit. An ORG segment may optionally follow an STF segment. An ORG segment must always have been preceded by a corresponding STF segment. If no organization unit is specified, this segment is used to relate practitioners with their practicing specialties, including effective and end dates. When it is not necessary to record organization unit or dates associated with the practicing specialty, this data is recorded in PRA-3-Practitioner Category."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ORG.1",
                            Type = @"Field",
                            Position = @"ORG.1",
                            Name = @"Set ID - ORG",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"SI",
                            DataTypeName = @"Sequence ID",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.2",
                            Type = @"Field",
                            Position = @"ORG.2",
                            Name = @"Organization Unit Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0405",
                            TableName = @"Organization unit",
                            Description = @"This field contains the hierarchical components of the organization unit, as defined by the institution.  Refer to User-defined Table 0405 - Organization unit for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.2.1",
                            Type = @"Component",
                            Position = @"ORG.2.1",
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
                            Id = @"ORG.2.2",
                            Type = @"Component",
                            Position = @"ORG.2.2",
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
                            Id = @"ORG.2.3",
                            Type = @"Component",
                            Position = @"ORG.2.3",
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
                            Id = @"ORG.2.4",
                            Type = @"Component",
                            Position = @"ORG.2.4",
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
                            Id = @"ORG.2.5",
                            Type = @"Component",
                            Position = @"ORG.2.5",
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
                            Id = @"ORG.2.6",
                            Type = @"Component",
                            Position = @"ORG.2.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.3",
                            Type = @"Field",
                            Position = @"ORG.3",
                            Name = @"Organization Unit Type Code - ORG",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0474",
                            TableName = @"Organization unit type",
                            Description = @"This field contains a code indicating the classification of the organization unit.  HL7 suggests using values in User-defined Table 0474 - Organization unit type.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.3.1",
                            Type = @"Component",
                            Position = @"ORG.3.1",
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
                            Id = @"ORG.3.2",
                            Type = @"Component",
                            Position = @"ORG.3.2",
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
                            Id = @"ORG.3.3",
                            Type = @"Component",
                            Position = @"ORG.3.3",
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
                            Id = @"ORG.3.4",
                            Type = @"Component",
                            Position = @"ORG.3.4",
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
                            Id = @"ORG.3.5",
                            Type = @"Component",
                            Position = @"ORG.3.5",
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
                            Id = @"ORG.3.6",
                            Type = @"Component",
                            Position = @"ORG.3.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.4",
                            Type = @"Field",
                            Position = @"ORG.4",
                            Name = @"Primary Org Unit Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether this organization unit is the primary organization unit for this practitioner.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.5",
                            Type = @"Field",
                            Position = @"ORG.5",
                            Name = @"Practitioner Org Unit Identifier",
                            Length = 60,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CX",
                            DataTypeName = @"Extended Composite ID With Check Digit",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an identification code used by the institution to identify this person at this specific organization unit.  If the person is identified with the same code at all organization units, then this data should be coded in STF-2-staff ID codes",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.5.1",
                            Type = @"Component",
                            Position = @"ORG.5.1",
                            Name = @"Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Definition: The value of the identifier itself. It is similar to the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that a ST data type is used instead of a NM data type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.5.2",
                            Type = @"Component",
                            Position = @"ORG.5.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit) except that an ST data type is allowed instead of an NM data type. The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.5.3",
                            Type = @"Component",
                            Position = @"ORG.5.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Defined as in the CK data type (see Section 2.9.5, CK - composite ID with check digit). Refer to HL7 Table 0061- Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.5.4",
                            Type = @"Component",
                            Position = @"ORG.5.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. It is a HD data type . User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.5.4.1",
                            Type = @"SubComponent",
                            Position = @"ORG.5.4.1",
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
                            Id = @"ORG.5.4.2",
                            Type = @"SubComponent",
                            Position = @"ORG.5.4.2",
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
                            Id = @"ORG.5.4.3",
                            Type = @"SubComponent",
                            Position = @"ORG.5.4.3",
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
                            Id = @"ORG.5.5",
                            Type = @"Component",
                            Position = @"ORG.5.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the Assigning authority component. Refer toHL7 Table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.5.6",
                            Type = @"Component",
                            Position = @"ORG.5.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.5.6.1",
                            Type = @"SubComponent",
                            Position = @"ORG.5.6.1",
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
                            Id = @"ORG.5.6.2",
                            Type = @"SubComponent",
                            Position = @"ORG.5.6.2",
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
                            Id = @"ORG.5.6.3",
                            Type = @"SubComponent",
                            Position = @"ORG.5.6.3",
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
                            Id = @"ORG.5.7",
                            Type = @"Component",
                            Position = @"ORG.5.7",
                            Name = @"Effective Date",
                            Length = 0,
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
                            Id = @"ORG.5.8",
                            Type = @"Component",
                            Position = @"ORG.5.8",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the identifier is valid and active.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.6",
                            Type = @"Field",
                            Position = @"ORG.6",
                            Name = @"Health Care Provider Type Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0452",
                            TableName = @"Health care provider type code",
                            Description = @"This field contains the major grouping of the service or occupation of the practitioner at a specific organization unit. For example, Behavioral Health & Social Service.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 1 - Type",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.6.1",
                            Type = @"Component",
                            Position = @"ORG.6.1",
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
                            Id = @"ORG.6.2",
                            Type = @"Component",
                            Position = @"ORG.6.2",
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
                            Id = @"ORG.6.3",
                            Type = @"Component",
                            Position = @"ORG.6.3",
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
                            Id = @"ORG.6.4",
                            Type = @"Component",
                            Position = @"ORG.6.4",
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
                            Id = @"ORG.6.5",
                            Type = @"Component",
                            Position = @"ORG.6.5",
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
                            Id = @"ORG.6.6",
                            Type = @"Component",
                            Position = @"ORG.6.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.7",
                            Type = @"Field",
                            Position = @"ORG.7",
                            Name = @"Health Care Provider Classification Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0453",
                            TableName = @"Health care provider classification",
                            Description = @"This field contains the more specific service or occupation within the health care provider type of the practitioner at a specific organization unit.  For example, Counselor.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 2 – Classification",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.7.1",
                            Type = @"Component",
                            Position = @"ORG.7.1",
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
                            Id = @"ORG.7.2",
                            Type = @"Component",
                            Position = @"ORG.7.2",
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
                            Id = @"ORG.7.3",
                            Type = @"Component",
                            Position = @"ORG.7.3",
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
                            Id = @"ORG.7.4",
                            Type = @"Component",
                            Position = @"ORG.7.4",
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
                            Id = @"ORG.7.5",
                            Type = @"Component",
                            Position = @"ORG.7.5",
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
                            Id = @"ORG.7.6",
                            Type = @"Component",
                            Position = @"ORG.7.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.8",
                            Type = @"Field",
                            Position = @"ORG.8",
                            Name = @"Health Care Provider Area of Specialization Code",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0454",
                            TableName = @"Health care provider area of specialization",
                            Description = @"This field contains the segment of the population that a health care provider chooses to service, a specific medical service, a specialization in treating a specific disease, or any other descriptive characteristic about the provider’s practice relating to the services rendered of the practitioner at a specific organization unit.  For example, Mental Health.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 3 - specialization.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.8.1",
                            Type = @"Component",
                            Position = @"ORG.8.1",
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
                            Id = @"ORG.8.2",
                            Type = @"Component",
                            Position = @"ORG.8.2",
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
                            Id = @"ORG.8.3",
                            Type = @"Component",
                            Position = @"ORG.8.3",
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
                            Id = @"ORG.8.4",
                            Type = @"Component",
                            Position = @"ORG.8.4",
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
                            Id = @"ORG.8.5",
                            Type = @"Component",
                            Position = @"ORG.8.5",
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
                            Id = @"ORG.8.6",
                            Type = @"Component",
                            Position = @"ORG.8.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.9",
                            Type = @"Field",
                            Position = @"ORG.9",
                            Name = @"Effective Date Range",
                            Length = 52,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date range in which the practitioner started and ended working at the specific organization unit in the specific practicing specialty category",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.9.1",
                            Type = @"Component",
                            Position = @"ORG.9.1",
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
                            Id = @"ORG.9.1.1",
                            Type = @"SubComponent",
                            Position = @"ORG.9.1.1",
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
                            Id = @"ORG.9.1.2",
                            Type = @"SubComponent",
                            Position = @"ORG.9.1.2",
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
                            Id = @"ORG.9.2",
                            Type = @"Component",
                            Position = @"ORG.9.2",
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
                            Id = @"ORG.9.2.1",
                            Type = @"SubComponent",
                            Position = @"ORG.9.2.1",
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
                            Id = @"ORG.9.2.2",
                            Type = @"SubComponent",
                            Position = @"ORG.9.2.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.10",
                            Type = @"Field",
                            Position = @"ORG.10",
                            Name = @"Employment Status Code",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0066",
                            TableName = @"Employment status",
                            Description = @"This field contains a code indicating the working relationship of the practitioner at this organization unit.  It may be different than the work status specified in STF-20.  Refer to User-defined Table 0066 - Employment status for suggested values",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"ORG.10.1",
                            Type = @"Component",
                            Position = @"ORG.10.1",
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
                            Id = @"ORG.10.2",
                            Type = @"Component",
                            Position = @"ORG.10.2",
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
                            Id = @"ORG.10.3",
                            Type = @"Component",
                            Position = @"ORG.10.3",
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
                            Id = @"ORG.10.4",
                            Type = @"Component",
                            Position = @"ORG.10.4",
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
                            Id = @"ORG.10.5",
                            Type = @"Component",
                            Position = @"ORG.10.5",
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
                            Id = @"ORG.10.6",
                            Type = @"Component",
                            Position = @"ORG.10.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.11",
                            Type = @"Field",
                            Position = @"ORG.11",
                            Name = @"Board Approval Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether this practice specialty requires board approval. Refer to HL7 Table 0136 - Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ORG.12",
                            Type = @"Field",
                            Position = @"ORG.12",
                            Name = @"Primary Care Physician Indicator",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0136",
                            TableName = @"Yes/no indicator",
                            Description = @"This field contains an indicator for whether this practice specialty may act as a primary care physician (PCP).  Refer to HL7 Table 0136 - Yes/no indicator for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        };
            }
        }

        public HL7V24SegmentORG(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field setIDORG;

public HL7V24Field SetIDORG
{
    get
    {
        if (setIDORG != null)
        {
            return setIDORG;
        }

        setIDORG = new HL7V24Field
        {
            field = message[@"ORG"][1],
            Id = @"ORG.1",
            Type = @"Field",
            Position = @"ORG.1",
            Name = @"Set ID - ORG",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction.  For the first occurrence of the segment, the sequence number shall be one, for the second occurrence, the sequence number shall be two, etc.",
            Sample = @"",
        };

        // check for repetitions
        if (setIDORG.field.FieldRepetitions != null && setIDORG.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(setIDORG.Id));
            setIDORG.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(setIDORG, fieldData);
        }

        return setIDORG;
    } 
}

internal HL7V24Field organizationUnitCode;

public HL7V24Field OrganizationUnitCode
{
    get
    {
        if (organizationUnitCode != null)
        {
            return organizationUnitCode;
        }

        organizationUnitCode = new HL7V24Field
        {
            field = message[@"ORG"][2],
            Id = @"ORG.2",
            Type = @"Field",
            Position = @"ORG.2",
            Name = @"Organization Unit Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0405",
            TableName = @"Organization unit",
            Description = @"This field contains the hierarchical components of the organization unit, as defined by the institution.  Refer to User-defined Table 0405 - Organization unit for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (organizationUnitCode.field.FieldRepetitions != null && organizationUnitCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organizationUnitCode.Id));
            organizationUnitCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(organizationUnitCode, fieldData);
        }

        return organizationUnitCode;
    } 
}

internal HL7V24Field organizationUnitTypeCodeORG;

public HL7V24Field OrganizationUnitTypeCodeORG
{
    get
    {
        if (organizationUnitTypeCodeORG != null)
        {
            return organizationUnitTypeCodeORG;
        }

        organizationUnitTypeCodeORG = new HL7V24Field
        {
            field = message[@"ORG"][3],
            Id = @"ORG.3",
            Type = @"Field",
            Position = @"ORG.3",
            Name = @"Organization Unit Type Code - ORG",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0474",
            TableName = @"Organization unit type",
            Description = @"This field contains a code indicating the classification of the organization unit.  HL7 suggests using values in User-defined Table 0474 - Organization unit type.",
            Sample = @"",
        };

        // check for repetitions
        if (organizationUnitTypeCodeORG.field.FieldRepetitions != null && organizationUnitTypeCodeORG.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(organizationUnitTypeCodeORG.Id));
            organizationUnitTypeCodeORG.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(organizationUnitTypeCodeORG, fieldData);
        }

        return organizationUnitTypeCodeORG;
    } 
}

internal HL7V24Field primaryOrgUnitIndicator;

public HL7V24Field PrimaryOrgUnitIndicator
{
    get
    {
        if (primaryOrgUnitIndicator != null)
        {
            return primaryOrgUnitIndicator;
        }

        primaryOrgUnitIndicator = new HL7V24Field
        {
            field = message[@"ORG"][4],
            Id = @"ORG.4",
            Type = @"Field",
            Position = @"ORG.4",
            Name = @"Primary Org Unit Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether this organization unit is the primary organization unit for this practitioner.  Refer to HL7 Table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (primaryOrgUnitIndicator.field.FieldRepetitions != null && primaryOrgUnitIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryOrgUnitIndicator.Id));
            primaryOrgUnitIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(primaryOrgUnitIndicator, fieldData);
        }

        return primaryOrgUnitIndicator;
    } 
}

internal HL7V24Field practitionerOrgUnitIdentifier;

public HL7V24Field PractitionerOrgUnitIdentifier
{
    get
    {
        if (practitionerOrgUnitIdentifier != null)
        {
            return practitionerOrgUnitIdentifier;
        }

        practitionerOrgUnitIdentifier = new HL7V24Field
        {
            field = message[@"ORG"][5],
            Id = @"ORG.5",
            Type = @"Field",
            Position = @"ORG.5",
            Name = @"Practitioner Org Unit Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identification code used by the institution to identify this person at this specific organization unit.  If the person is identified with the same code at all organization units, then this data should be coded in STF-2-staff ID codes",
            Sample = @"",
        };

        // check for repetitions
        if (practitionerOrgUnitIdentifier.field.FieldRepetitions != null && practitionerOrgUnitIdentifier.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(practitionerOrgUnitIdentifier.Id));
            practitionerOrgUnitIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(practitionerOrgUnitIdentifier, fieldData);
        }

        return practitionerOrgUnitIdentifier;
    } 
}

internal HL7V24Field healthCareProviderTypeCode;

public HL7V24Field HealthCareProviderTypeCode
{
    get
    {
        if (healthCareProviderTypeCode != null)
        {
            return healthCareProviderTypeCode;
        }

        healthCareProviderTypeCode = new HL7V24Field
        {
            field = message[@"ORG"][6],
            Id = @"ORG.6",
            Type = @"Field",
            Position = @"ORG.6",
            Name = @"Health Care Provider Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0452",
            TableName = @"Health care provider type code",
            Description = @"This field contains the major grouping of the service or occupation of the practitioner at a specific organization unit. For example, Behavioral Health & Social Service.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 1 - Type",
            Sample = @"",
        };

        // check for repetitions
        if (healthCareProviderTypeCode.field.FieldRepetitions != null && healthCareProviderTypeCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(healthCareProviderTypeCode.Id));
            healthCareProviderTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(healthCareProviderTypeCode, fieldData);
        }

        return healthCareProviderTypeCode;
    } 
}

internal HL7V24Field healthCareProviderClassificationCode;

public HL7V24Field HealthCareProviderClassificationCode
{
    get
    {
        if (healthCareProviderClassificationCode != null)
        {
            return healthCareProviderClassificationCode;
        }

        healthCareProviderClassificationCode = new HL7V24Field
        {
            field = message[@"ORG"][7],
            Id = @"ORG.7",
            Type = @"Field",
            Position = @"ORG.7",
            Name = @"Health Care Provider Classification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0453",
            TableName = @"Health care provider classification",
            Description = @"This field contains the more specific service or occupation within the health care provider type of the practitioner at a specific organization unit.  For example, Counselor.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 2 – Classification",
            Sample = @"",
        };

        // check for repetitions
        if (healthCareProviderClassificationCode.field.FieldRepetitions != null && healthCareProviderClassificationCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(healthCareProviderClassificationCode.Id));
            healthCareProviderClassificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(healthCareProviderClassificationCode, fieldData);
        }

        return healthCareProviderClassificationCode;
    } 
}

internal HL7V24Field healthCareProviderAreaofSpecializationCode;

public HL7V24Field HealthCareProviderAreaofSpecializationCode
{
    get
    {
        if (healthCareProviderAreaofSpecializationCode != null)
        {
            return healthCareProviderAreaofSpecializationCode;
        }

        healthCareProviderAreaofSpecializationCode = new HL7V24Field
        {
            field = message[@"ORG"][8],
            Id = @"ORG.8",
            Type = @"Field",
            Position = @"ORG.8",
            Name = @"Health Care Provider Area of Specialization Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0454",
            TableName = @"Health care provider area of specialization",
            Description = @"This field contains the segment of the population that a health care provider chooses to service, a specific medical service, a specialization in treating a specific disease, or any other descriptive characteristic about the provider’s practice relating to the services rendered of the practitioner at a specific organization unit.  For example, Mental Health.  HL7 suggests using values derived from the ANSI ASC X12 Health Care Provider Taxonomy, Level 3 - specialization.",
            Sample = @"",
        };

        // check for repetitions
        if (healthCareProviderAreaofSpecializationCode.field.FieldRepetitions != null && healthCareProviderAreaofSpecializationCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(healthCareProviderAreaofSpecializationCode.Id));
            healthCareProviderAreaofSpecializationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(healthCareProviderAreaofSpecializationCode, fieldData);
        }

        return healthCareProviderAreaofSpecializationCode;
    } 
}

internal HL7V24Field effectiveDateRange;

public HL7V24Field EffectiveDateRange
{
    get
    {
        if (effectiveDateRange != null)
        {
            return effectiveDateRange;
        }

        effectiveDateRange = new HL7V24Field
        {
            field = message[@"ORG"][9],
            Id = @"ORG.9",
            Type = @"Field",
            Position = @"ORG.9",
            Name = @"Effective Date Range",
            Length = 52,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/time Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date range in which the practitioner started and ended working at the specific organization unit in the specific practicing specialty category",
            Sample = @"",
        };

        // check for repetitions
        if (effectiveDateRange.field.FieldRepetitions != null && effectiveDateRange.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(effectiveDateRange.Id));
            effectiveDateRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(effectiveDateRange, fieldData);
        }

        return effectiveDateRange;
    } 
}

internal HL7V24Field employmentStatusCode;

public HL7V24Field EmploymentStatusCode
{
    get
    {
        if (employmentStatusCode != null)
        {
            return employmentStatusCode;
        }

        employmentStatusCode = new HL7V24Field
        {
            field = message[@"ORG"][10],
            Id = @"ORG.10",
            Type = @"Field",
            Position = @"ORG.10",
            Name = @"Employment Status Code",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0066",
            TableName = @"Employment status",
            Description = @"This field contains a code indicating the working relationship of the practitioner at this organization unit.  It may be different than the work status specified in STF-20.  Refer to User-defined Table 0066 - Employment status for suggested values",
            Sample = @"",
        };

        // check for repetitions
        if (employmentStatusCode.field.FieldRepetitions != null && employmentStatusCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(employmentStatusCode.Id));
            employmentStatusCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(employmentStatusCode, fieldData);
        }

        return employmentStatusCode;
    } 
}

internal HL7V24Field boardApprovalIndicator;

public HL7V24Field BoardApprovalIndicator
{
    get
    {
        if (boardApprovalIndicator != null)
        {
            return boardApprovalIndicator;
        }

        boardApprovalIndicator = new HL7V24Field
        {
            field = message[@"ORG"][11],
            Id = @"ORG.11",
            Type = @"Field",
            Position = @"ORG.11",
            Name = @"Board Approval Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether this practice specialty requires board approval. Refer to HL7 Table 0136 - Yes/no indicator for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (boardApprovalIndicator.field.FieldRepetitions != null && boardApprovalIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(boardApprovalIndicator.Id));
            boardApprovalIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(boardApprovalIndicator, fieldData);
        }

        return boardApprovalIndicator;
    } 
}

internal HL7V24Field primaryCarePhysicianIndicator;

public HL7V24Field PrimaryCarePhysicianIndicator
{
    get
    {
        if (primaryCarePhysicianIndicator != null)
        {
            return primaryCarePhysicianIndicator;
        }

        primaryCarePhysicianIndicator = new HL7V24Field
        {
            field = message[@"ORG"][12],
            Id = @"ORG.12",
            Type = @"Field",
            Position = @"ORG.12",
            Name = @"Primary Care Physician Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field contains an indicator for whether this practice specialty may act as a primary care physician (PCP).  Refer to HL7 Table 0136 - Yes/no indicator for valid values",
            Sample = @"",
        };

        // check for repetitions
        if (primaryCarePhysicianIndicator.field.FieldRepetitions != null && primaryCarePhysicianIndicator.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(primaryCarePhysicianIndicator.Id));
            primaryCarePhysicianIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(primaryCarePhysicianIndicator, fieldData);
        }

        return primaryCarePhysicianIndicator;
    } 
}
    }
}

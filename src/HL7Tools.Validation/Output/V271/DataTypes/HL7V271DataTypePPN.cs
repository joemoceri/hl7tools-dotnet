using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypePPN
    {
        public string Id { get { return @"PPN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Performing Person Time Stamp"; } }

        public string Description { get { return @"This data type is the equivalent of an XCN data type joined with a DTM data type. However, the XCN data type has been flattened to allow legal expression of its embedded complex data types HD, CWE and CWE."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 0; } }

        public string Usage { get { return null; } }

        public string Rpt { get { return null; } }

        public string TableId { get { return null; } }

        public string TableName { get { return null; } }

        public string Sample { get { return @""; } }

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PPN.1",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.1",
                            Name = @"Person Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the Person Identifier itself. PPN.1, in conjunction with PPN.9, uniquely identifies the entity/person.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.2",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.2",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN – Family Name"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.3",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"First name.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.4",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Multiple middle names may be included by separating them with spaces.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.5",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.5",
                            Name = @"Suffix (e.g., Jr Or Iii)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.6",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.6",
                            Name = @"Prefix (e.g., Dr)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.7",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.7",
                            Name = @"Degree (e.g., Md)",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The PPN.7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7 See PPN.22 - Professional Suffix.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.8",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0297",
                            TableName = @"CN ID Source",
                            Description = @"Attention: Retained for backwards compatibility only as of v2.7. The reader is referred to PPN.9 instead.

User-defined Table 0297 - CN ID Source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.9",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. It is a HD data type. User-defined Table 0363 – Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.

Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.

By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first sub-component.

Attention: As of v2.7, the Assigning Authority is conditional. It is required if PPN.1 is populated and neither PPN.23 nor PPN.24 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.

The reader is referred to the PPN.23 and the PPN.24 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued. If, in so doing, it is discovered that the values in PPN.23 and/or PPN.24 conflict with PPN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.10",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.10",
                            Name = @"Name Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0200",
                            TableName = @"Name Type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values (see Section 2.A.89, “XPN - extended person name”).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.11",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A digit, or digits, exclusive of the identifier in CX.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.12",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.12",
                            Name = @"Check Digit Scheme",
                            Length = 3,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0061",
                            TableName = @"Check Digit Scheme",
                            Description = @"Contains the code identifying the check digit scheme employed.
Refer to HL7 Table 0061 - Check Digit Scheme for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.13",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.13",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0203",
                            TableName = @"Identifier Type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the ""Assigning authority"" component. Refer to HL7 Table 0203 - Identifier Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.14",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.

Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.15",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.15",
                            Name = @"Date/Time Action Performed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes when the activity was performed.
Note:If this field is not null, both the performing person and the time stamp must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.16",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.16",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0465",
                            TableName = @"Name/Address Representation",
                            Description = @"Different name/address types and representations of the same name/address should be described by repeating of this field, with different values of the Name/Address Type and/or Name/Address Representation component.

Note:This new component remains in “alphabetic” representation with each repetition of the field using these data types. That is, even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.

In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.17",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.17",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0448",
                            TableName = @"Name Context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare: indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to chapter 3, section 3.4.2.6 for more detailed information on how to use this table. Refer to User-defined Table 0448 – Name Context for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.18",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.18",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The PPN.18 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to PPN.20 Effective Date and PPN.21 Expiration Date.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.19",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.19",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0444",
                            TableName = @"Name Assembly Order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 – Name Assembly Order for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.20",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.20",
                            Name = @"Effective Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The first date, if known, on which the person name is valid and active.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.21",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.21",
                            Name = @"Expiration Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"The last date, if known, on which the person name is valid and active.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.22",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.22",
                            Name = @"Professional Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations, denoting qualifications that support the person’s profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, ""Personnel Management"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.23",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.23",
                            Name = @"Assigning Jurisdiction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in component 1. 

See section 2.A.14.9, ""Assigning Jurisdiction (CWE)"" for further detail.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.24",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.24",
                            Name = @"Assigning Agency Or Department",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in component 1.

See section 2.A.14.10, ""Assigning Agency or Department (CWE)"" for further details.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.25",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.25",
                            Name = @"Security Check",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is used to communicate a version code that may be assigned to the value given in PPN.1 - Person Identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PPN.26",
                            Type = @"DataTypeComponent",
                            Position = @"PPN.26",
                            Name = @"Security Check Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0904",
                            TableName = @"Security Check Scheme",
                            Description = @"This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.

Refer to HL7 Table 0904 - Security Check Scheme for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

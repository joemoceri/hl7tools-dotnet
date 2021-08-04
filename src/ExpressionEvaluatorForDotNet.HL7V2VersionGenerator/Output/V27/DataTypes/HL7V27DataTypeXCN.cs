using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"XCN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Composite Id Number And Name For Persons"; } }

        public string Description { get { return @"Note: Replaces CN data type as of v 2.3.

This data type is used extensively appearing in the PV1, ORC, RXO, RXE, OBR and SCH segments, as well as others, where there is a need to specify the ID number and name of a person.

Example without assigning authority and assigning facility:
|1234567^Everyman^Adam^A^III^DR^PHD^ADT01^^L^4^M11^MR|

Examples with assigning authority and assigning facility:

Dr. Harold Hippocrates’ provider ID was assigned by the Provider Master and was first issued at Good Health Hospital within the Community Health and Hospitals System. Since IS table values (first component of the HD) were not used for assigning authority and assigning facility, components 2 and 3 of the HD data type are populated and demoted to sub-components as follows:
12188^Hippocrates^Harold^H^IV^Dr^MD^^&Provider Master.Community Health and Hospitals&L^L^9^M10^DN^&Good Health Hospital.Community Health and Hospitals&L^A

Ludwig van Beethoven's medical record number was assigned by the Master Patient Index and was first issued at Fairview Hospital within the University Hospitals System.
10535^van Beethoven&van^Ludwig^A^III^Dr^PHD^^&MPI.Community Health and Hospitals&L^L^3^M10^MR^& Good Health Hospital.Community Health and Hospitals&L^A"; } }

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
                            Id = @"XCN.1",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.1",
                            Name = @"Person Identifier",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the Person Identifier itself. XCN.1, in conjunction with XCN.9 uniquely identifies the entity/person. 
XCN.1 is required if XCN.2 is not populated. Both may be populated. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.2",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.2",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.A.30, ""FN - family name"".
XCN.2 is required if XCN.1 is not populated. Both may be populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.3",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.3",
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
                            Id = @"XCN.4",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.4",
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
                            Id = @"XCN.5",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.5",
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
                            Id = @"XCN.6",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.6",
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
                            Id = @"XCN.7",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.7",
                            Name = @"Degree (e.g., Md)",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The XCN-7 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v27.. Refer to XCN.21 Professional Suffix.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.8",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0297",
                            TableName = @"CN ID Source",
                            Description = @"Attention: Retained for backwards compatibility only as of v2.7. The reader is referred to XCN.9 instead.

User-defined Table 0297 – CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.9",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 – Assigning Authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.

As of v2.7, the Assigning Authority is conditional. It is required if XCN.1 is populated and neither XCN.22 nor XCN.23 are populated. All 3 components may be populated. No assumptions can be safely made based on position or sequence. Best practice is to send an OID in this component when populated.

The reader is referred to XCN.22 and XCN.23 if there is a need to transmit values with semantic meaning for an assigning jurisdiction or assigning department or agency in addition to, or instead of, an assigning authority. However, all 3 components may be valued.  If, in so doing, it is discovered that the values in XCN.22 and/or XCN.23 conflict with XCN.9, the user would look to the Message Profile or other implementation agreement for a statement as to which takes precedence.
Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.

By site agreement, implementors may continue to use User-defined Table 0300 – Namespace ID for the first sub-component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.10",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.10",
                            Name = @"Name Type Code",
                            Length = 5,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0200",
                            TableName = @"Name Type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name Type for valid values. See Section 2.A.89.7, ""Name Type Code (ID)"".

As of v2.7, XCN.10 is conditional. It is required if XCN.2 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.11",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.11",
                            Name = @"Identifier Check Digit",
                            Length = 4,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the digit, or digits, exclusive of the identifier in XCN.1, calculated by applying an algorithm to all or some of the digits in the number, which may be used to test validity of the non-check-digit identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.12",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.12",
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
                            Id = @"XCN.13",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.13",
                            Name = @"Identifier Type Code",
                            Length = 5,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0203",
                            TableName = @"Identifier Type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier Type for suggested values.

As of v2.7, XCN.13 is conditional. It is required if XCN.1 is populated.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.14",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.

Note: When the HD data type is used in a given segment as a component of a field of another data type, User-defined Table 0300 - Namespace ID (referenced by the first sub-component of the HD component) may be re-defined (given a different user-defined table number and name) by the technical committee responsible for that segment.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.15",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.15",
                            Name = @"Name Representation Code",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0465",
                            TableName = @"Name/Address Representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.

Note: This new component remains in “alphabetic” representation with each repetition of the field using these data types. I.e., even though the name may be represented in an ideographic character set, this component will remain represented in an alphabetic character set.
Refer to HL7 Table 0465 – Name/address Representation for valid values.

In general this component provides an indication of the representation provided by the data item. It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired. This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.16",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.16",
                            Name = @"Name Context",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0448",
                            TableName = @"Name Context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 – Name Context for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.17",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.17",
                            Name = @"Name Validity Range",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The XCN.17 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v 2.7. Refer to XCN.19 Effective Date and XCN.20 Expiration Date instead.

This component contains the start and end date/times that define the period during which this name was valid.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.18",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.18",
                            Name = @"Name Assembly Order",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0444",
                            TableName = @"Name Assembly Order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name Assembly Order for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.19",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.19",
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
                            Id = @"XCN.20",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.20",
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
                            Id = @"XCN.21",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.21",
                            Name = @"Professional Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an abbreviation, or a string of abbreviations denoting qualifications that support the person’s profession, (e.g., licenses, certificates, degrees, affiliations with professional societies, etc.). The Professional Suffix normally follows the Family Name when the Person Name is used for display purposes. Please note that this component is an unformatted string and is used for display purposes only. Detailed information regarding the contents of Professional Suffix is obtained using appropriate segments in Chapter 15, ""Personnel Management"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.22",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.22",
                            Name = @"Assigning Jurisdiction",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The geo-political body that assigned the identifier in XCN.1. 

See section, 2.A.14.9, ""Assigning Jurisdiction (CWE)"" for further detail.

As of v2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.23 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.23",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.23",
                            Name = @"Assigning Agency Or Department",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The agency or department that assigned the identifier in XCN.1.

See section 2.A.14.10, ""Assigning Agency or Department (CWE)"" for further details.

As of v2.7, the Assigning Jurisdiction is conditional. It is required if XCN.1 is populated and neither XCN.9 nor XCN.22 are populated. All 3 components may be populated. The reader is referred to XCN.9 if there is a need to transmit this information as an OID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.24",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.24",
                            Name = @"Security Check",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component is used to communicate a version code that may be assigned to the value given in XCN.1 Person Identifier.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.25",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.25",
                            Name = @"Security Check Scheme",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0904",
                            TableName = @"Security Check Scheme",
                            Description = @"This component is used to transmit information intended to validate the veracity of the supplied identifier or the presenter of the identifier. For example, this component may be used to ensure that the presenter of a credit card is an authorized user of that card.

Refer to HL7 Table 0904 - Security Check Scheme for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

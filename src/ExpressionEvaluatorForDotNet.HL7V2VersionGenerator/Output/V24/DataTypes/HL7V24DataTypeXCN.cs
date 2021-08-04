using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"XCN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Composite ID Number And Name For Persons"; } }

        public string Description { get { return @"This data type is used extensively appearing in the PV1, ORC, RXO, RXE, OBR and SCH segments , as well as others, where there is a need to specify the ID number and name of a person.

Note: Replaces CN data type as of v 2.3."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 250; } }

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
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19,  FN - family name.",
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
                            TableId = @"FirstName",
                            TableName = @"First Name",
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
                            Name = @"Suffix",
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
                            Name = @"Prefix",
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
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree for suggested values.",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined Table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency of department) that creates the data. User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.10",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 Table 0200 - Name type for valid values (see Section 2.9.54.7, Name type code (ID)).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.11",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.12",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 Table 0061 - Check digit scheme for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.13",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to HL7 Table 0203 - Identifier type for suggested values.",
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
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.15",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0465",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
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
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0448",
                            TableName = @"Name context",
                            Description = @"This component is used to designate the context in which a name is used. The main use case is in Australian healthcare for indigenous patients who prefer to use different names when attending different healthcare institutions. Another use case occurs in the US where health practitioners can be licensed under slightly different names and the reporting of the correct name is vital for administrative purposes. Refer to User-defined Table 0448 - Name context for suggested values.",
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
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DR",
                            DataTypeName = @"Date/time Range",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the start and end date/times that define the period during which this name was valid. See section 2.9.14, DR - date/time range for description of subcomponents.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XCN.18",
                            Type = @"DataTypeComponent",
                            Position = @"XCN.18",
                            Name = @"Name Assembly Order",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0444",
                            TableName = @"Name assembly order",
                            Description = @"A code that represents the preferred display order of the components of this person name. Refer to HL7 Table 0444 - Name assembly orde r for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

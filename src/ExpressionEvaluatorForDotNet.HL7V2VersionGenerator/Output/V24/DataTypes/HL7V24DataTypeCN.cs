using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypeCN
    {
        public string Id { get { return @"CN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite ID Number And Name"; } }

        public string Description { get { return @"Note:  Replaced by XCN data type as of v. 2.3.

This data type is used when identifying a person both as a coded value and with a text name.  For specific fields, individual sites may elect to omit the ID or the name.

Example:
|12372^RIGGINS^JOHN^""""^""""^""""^MD^ADT1|"; } }

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
                            Id = @"CN.1",
                            Type = @"DataTypeComponent",
                            Position = @"CN.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CN.2",
                            Type = @"DataTypeComponent",
                            Position = @"CN.2",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family Name",
                            TableId = null,
                            TableName = null,
                            Description = @"This component allows full specification of the surname of a person. Where appropriate, it differentiates the person's own surname from that of the person's partner or spouse, in cases where the person's name may contain elements from either name. It also permits messages to distinguish the surname prefix (such as ""van"" or ""de"") from the surname root. See section 2.9.19, FN - family name.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CN.3",
                            Type = @"DataTypeComponent",
                            Position = @"CN.3",
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
                            Id = @"CN.4",
                            Type = @"DataTypeComponent",
                            Position = @"CN.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
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
                            Id = @"CN.5",
                            Type = @"DataTypeComponent",
                            Position = @"CN.5",
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
                            Id = @"CN.6",
                            Type = @"DataTypeComponent",
                            Position = @"CN.6",
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
                            Id = @"CN.7",
                            Type = @"DataTypeComponent",
                            Position = @"CN.7",
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
                            Id = @"CN.8",
                            Type = @"DataTypeComponent",
                            Position = @"CN.8",
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
                            Id = @"CN.9",
                            Type = @"DataTypeComponent",
                            Position = @"CN.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (organization or agency or department) that creates the data. It is a HD data type . User-defined Table 0363 - Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD data type, namespace ID.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

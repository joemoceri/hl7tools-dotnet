using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"CNN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite ID Number and Name Simplified"; } }

        public string Description { get { return @"Specifies a person using both an identifier and the persons name. Retained for backward compatibility only as of v2.6."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 406; } }

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
                            Id = @"CNN.1",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.1",
                            Name = @"Id Number",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table. If the first component is present, either component 8 or 9, or both 10 and 11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.2",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.2",
                            Name = @"Family Name",
                            Length = 50,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the person's family name in a string format.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.3",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.3",
                            Name = @"Given Name",
                            Length = 30,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a first name.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.4",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.4",
                            Name = @"Second And Further Given Names Or Initials Thereof",
                            Length = 30,
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
                            Id = @"CNN.5",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.5",
                            Name = @"Suffix",
                            Length = 20,
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
                            Id = @"CNN.6",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.6",
                            Name = @"Prefix",
                            Length = 20,
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
                            Id = @"CNN.7",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.7",
                            Name = @"Degree",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree/license/certificate",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 - Degree/license/certificate for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.8",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.8",
                            Name = @"Source Table",
                            Length = 4,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to User-defined Table 0297 - CN ID source for suggested values. Used to delineate the first component. If component 1 is valued, either component 8, or 9, or both 10 and 11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.9",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.9",
                            Name = @"Assigning Authority - Namespace Id",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data.  Refer to User-defined Table 0363 – Assigning authority for suggested values. Assigning Authority is normally expressed as an HD data type, but has been flattened to 3 components here (CNN.9, CNN.10 and CNN.11) in this data type so that it may be fully expressed. Also note that if additional components are added to the HD data type in the future, adjustment will need to be made accordingly to this data type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.10",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.10",
                            Name = @"Assigning Authority - Universal Id",
                            Length = 199,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. 

If CNN.11 is valued, this component must be valued. If component 1 is valued, either component 8, or 9, or both 10 and 11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.11",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.11",
                            Name = @"Assigning Authority- Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The assigning authority is a unique name of the system (or organization or agency or department) that creates the data. If this component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values.

If CNN.10 is valued, this component must be valued. If component 1 is valued, either component 8, or 9, or both 10 and 11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

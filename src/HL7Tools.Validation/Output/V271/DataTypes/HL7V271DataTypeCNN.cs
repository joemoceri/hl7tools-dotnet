using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeCNN
    {
        public string Id { get { return @"CNN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Id Number And Name Simplified"; } }

        public string Description { get { return @"Specifies a person using both an identifier and the person’s name. Retained for backward compatibility only as of v2.6.

Note: Restores the original data type CN as was initially implementable in the CM used in sections 4.5.3.32 and 7.4.1.32 - (OBR-32), 4.5.3.33 and 7.4.1.33 - ( OBR-33), 4.5.3.34 and 7.4.1.34 - ( OBR-34), 4.5.3.35 and 7.4.1.35 - (OBR-35). Components 7 and 8, however, have been promoted to data type IS to be consistent with current practice without violating backward compatibility.

Attention: Retained for backward compatibility only in version 2.6. Fields associated with this data type have been replaced by the ROL segment."; } }

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
                            Id = @"CNN.1",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table. If the first component is present, either CNN.8 or CNN.9, or both CNN.10 and CNN.11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.2",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.2",
                            Name = @"Family Name",
                            Length = 0,
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
                            Length = 0,
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
                            Id = @"CNN.5",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.5",
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
                            Id = @"CNN.6",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.6",
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
                            Id = @"CNN.7",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.7",
                            Name = @"Degree (e.g., Md)",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0360",
                            TableName = @"Degree/License/Certificate",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to User-defined Table 0360 – Degree/license/certificate for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.8",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0297",
                            TableName = @"CN ID Source",
                            Description = @"Refer to User-defined Table 0297 - CN ID source for suggested values. Used to delineate the first component. If component 1 is valued, either CNN.8 or CNN.9, or both CNN.10 and CNN.11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.9",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.9",
                            Name = @"Assigning Authority   - Namespace Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded Value For User-defined Tables",
                            TableId = @"0363",
                            TableName = @"Assigning Authority",
                            Description = @"See section, 2.A.14.4, ""Assigning Authority (HD)"" for definition. Refer to User-defined Table 0363 – Assigning Authority for suggested values. Assigning Authority is normally expressed as an HD data type, but has been flattened to 3 components here (CNN.9, CNN.10 and CNN.11) in this data type so that it may be fully expressed. Also note that if additional components are added to the HD data type in the future, adjustment will need to be made accordingly to this data type.

If component 1 is valued, either CNN.8 or CNN.9, or both CNN.10 and CNN.11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.10",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.10",
                            Name = @"Assigning Authority  - Universal Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"If CNN.11 is valued, this component must be valued. If component 1 is valued, either CNN.8 or CNN.9, or both CNN.10 and CNN.11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNN.11",
                            Type = @"DataTypeComponent",
                            Position = @"CNN.11",
                            Name = @"Assigning Authority  - Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0301",
                            TableName = @"Universal ID Type",
                            Description = @"If this component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values.

If CNN.10 is valued, this component must be valued. If component 1 is valued, either CNN.8 or CNN.9, or both CNN.10 and CNN.11, must be valued.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

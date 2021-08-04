using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"CN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite ID Number And Name"; } }

        public string Description { get { return @"A field identifying a person both as a coded value and with a text name.  For specific fields, individual sites may elect to omit the ID or the name

Example:
|12372^RIGGINS^JOHN^""""^""""^""""^MD^ADT1| 
|12372^^^^^^^ADT1| 
|^RIGGINS^JOHN^""""^""""^""""^MD| "; } }

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
                            Id = @"CN.1",
                            Type = @"DataTypeComponent",
                            Position = @"CN.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
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
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CN.4",
                            Type = @"DataTypeComponent",
                            Position = @"CN.4",
                            Name = @"Middle Initial Or Name",
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
                            Description = @"Used to specify a name suffix (e.g., Jr. or III). ",
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
                            Description = @"Used to specify a name prefix (e.g., Dr.). ",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an educational degree (e.g., MD). ",
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
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0297 - CN ID source  for suggested values.  Used to delineate the first component",
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
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

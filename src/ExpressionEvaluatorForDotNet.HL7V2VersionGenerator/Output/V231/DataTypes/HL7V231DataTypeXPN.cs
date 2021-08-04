using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"XPN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Extended Person Name"; } }

        public string Description { get { return @"Example:
|Smith^John^J^III^DR^PHD^L|"; } }

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
                            Id = @"XPN.1",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.1",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XPN.2",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XPN.3",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.3",
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
                            Id = @"XPN.4",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.4",
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
                            Id = @"XPN.5",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.5",
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
                            Id = @"XPN.6",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.6",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XPN.7",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"XPN.8",
                            Type = @"DataTypeComponent",
                            Position = @"XPN.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"EI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Entity Identifier"; } }

        public string Description { get { return @"The entity identifier defines a given entity within a specified series of identifiers."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 427; } }

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
                            Id = @"EI.1",
                            Type = @"DataTypeComponent",
                            Position = @"EI.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.2",
                            Type = @"DataTypeComponent",
                            Position = @"EI.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.3",
                            Type = @"DataTypeComponent",
                            Position = @"EI.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"EI.4",
                            Type = @"DataTypeComponent",
                            Position = @"EI.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

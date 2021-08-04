using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"EI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Entity Identifier"; } }

        public string Description { get { return @"The entity identifier defines a given entity within a specified series of identifiers."; } }

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
                            Id = @"EI.1",
                            Type = @"DataTypeComponent",
                            Position = @"EI.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.2",
                            Type = @"DataTypeComponent",
                            Position = @"EI.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.3",
                            Type = @"DataTypeComponent",
                            Position = @"EI.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EI.4",
                            Type = @"DataTypeComponent",
                            Position = @"EI.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

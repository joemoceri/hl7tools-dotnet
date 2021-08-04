using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"CWE"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded With Exceptions"; } }

        public string Description { get { return null; } }

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
                            Id = @"CWE.1",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.2",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.3",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique name (coding system identifier). This component will serve to identify the coding scheme being used in the identifier component. The combination of the <identifier>, <name of coding system>, and <coding system versionID> components will be a unique code for a data item. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the <name of coding system> component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.4",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"For explanation, see text after 2.8.11.6",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.5",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"For explanation, see text after 2.8.11.6",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.6",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Alternate components (4, 5, 6) (for components 1, 2, 3)",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.7",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.8",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (see note 2.8.11.6) and appears here only for reasons of backward compatibility.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CWE.9",
                            Type = @"DataTypeComponent",
                            Position = @"CWE.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

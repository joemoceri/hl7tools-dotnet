using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"EIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Entity Identifier Pair"; } }

        public string Description { get { return @"Specifies an identifier assigned to an entity by either the placer or the filler system. If both components are populated the identifiers must refer to the same entity.

Note: Replaces the CM data type used in sections 4.5.1.8 - ORC-8, 4.5.3.29 – OBR-29, 7.3.1.29 – OBR-29, as of v 2.5."; } }

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
                            Id = @"EIP.1",
                            Type = @"DataTypeComponent",
                            Position = @"EIP.1",
                            Name = @"Placer Assigned Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the placer system. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"EIP.2",
                            Name = @"Filler Assigned Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the filler system. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

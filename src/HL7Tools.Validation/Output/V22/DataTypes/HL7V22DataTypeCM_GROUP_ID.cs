using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_GROUP_ID
    {
        public string Id { get { return @"CM_GROUP_ID"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Order Group Number"; } }

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
                            Id = @"CM_GROUP_ID.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_GROUP_ID.1",
                            Name = @"Unique Group Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a string of up to 15 characters that uniquely identifies all order groups from the given placer application.  It is assigned by the placer application and may come from the same series as the placer order number of the ORC, but this is not required. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_GROUP_ID.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_GROUP_ID.2",
                            Name = @"Placer Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is a placer application ID identical to the second component of ORC-2-placer order number.  Order groups and how to use them are described in detail at the end of the ORC section under ""Use Notes"" and in the Examples.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

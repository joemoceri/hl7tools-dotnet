using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"JCC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Job Code Class"; } }

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
                            Id = @"JCC.1",
                            Type = @"DataTypeComponent",
                            Position = @"JCC.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the person’s  job code.  Refer to user-defined table 0327 - job code",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"JCC.2",
                            Type = @"DataTypeComponent",
                            Position = @"JCC.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the person’s employee classification.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

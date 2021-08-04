using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CM_PRACTITIONER"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Action Carried Out By"; } }

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
                            Id = @"CM_PRACTITIONER.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PRACTITIONER.1",
                            Name = @"Procedure Practitioner  Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN_PERSON",
                            DataTypeName = @"Cn For Person",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_PRACTITIONER.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PRACTITIONER.2",
                            Name = @"Procedure Practitioner Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
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

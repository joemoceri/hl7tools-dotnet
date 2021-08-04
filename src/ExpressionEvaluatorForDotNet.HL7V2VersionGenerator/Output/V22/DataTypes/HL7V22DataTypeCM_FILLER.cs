using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CM_FILLER"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Number Of Processing Power Point"; } }

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
                            Id = @"CM_FILLER.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_FILLER.1",
                            Name = @"Unique Filler Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Its first component is a string of up to 15 characters that identifies an order detail segment (e.g., OBR). It is assigned by the order filler (receiving) application. This string must uniquely identify the order (as specified in the order detail segment) from other orders in a particular filling application (e.g., clinical laboratory).  This uniqueness must persist over time. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_FILLER.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_FILLER.2",
                            Name = @"Filler Application Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the filler application ID.  The filler application ID is a string of up to six characters that uniquely defines the application from other applications on the network.  The second component of the filler order number always identifies the actual filler of an order. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

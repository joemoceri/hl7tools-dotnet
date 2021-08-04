using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"AUI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Authorization Information"; } }

        public string Description { get { return @"This data type specifies the identifier or code for an insurance authorization instance and its associated detail.

Note: Replaces the CM data type used in sections 6.5.6.14 IN1-14, as of v2.5."; } }

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
                            Id = @"AUI.1",
                            Type = @"DataTypeComponent",
                            Position = @"AUI.1",
                            Name = @"Authorization Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifier assigned to the authorization.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUI.2",
                            Type = @"DataTypeComponent",
                            Position = @"AUI.2",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Date of authorization.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUI.3",
                            Type = @"DataTypeComponent",
                            Position = @"AUI.3",
                            Name = @"Source",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Source of authorization.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

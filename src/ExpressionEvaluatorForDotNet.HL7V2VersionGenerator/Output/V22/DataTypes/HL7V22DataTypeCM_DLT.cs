using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CM_DLT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Delta Check"; } }

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
                            Id = @"CM_DLT.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_DLT.1",
                            Name = @"Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The range to which the following applies: <low & high>",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_DLT.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_DLT.2",
                            Name = @"Numeric Threshold",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected, e.g., 10 ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_DLT.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_DLT.3",
                            Name = @"Change",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Whether the change is computed as a percent change or an absolute change.  This component can have two possible values: 
 
- % Indicates a percent change
- a Absolute change ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_DLT.4",
                            Type = @"DataTypeComponent",
                            Position = @"CM_DLT.4",
                            Name = @"Length Of Time-days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The length of time that the service retains a value for computing delta checks.  This is recorded in number of days.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

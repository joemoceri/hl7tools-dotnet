using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"ELD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Error"; } }

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
                            Id = @"ELD.1",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.1",
                            Name = @"Segment ID",
                            Length = 0,
                            Usage = @"O",
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
                            Id = @"ELD.2",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.2",
                            Name = @"Sequence",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ELD.3",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.3",
                            Name = @"Field Position",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ELD.4",
                            Type = @"DataTypeComponent",
                            Position = @"ELD.4",
                            Name = @"Code Identifying Error",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0357",
                            TableName = @"Message error condition codes",
                            Description = @"The fourth component (which references HL7 Table 0357 - Message error condition codes,  (as a CE data type)) is restricted from having any subcomponents as the subcomponent separator is now the CE’s component separator",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

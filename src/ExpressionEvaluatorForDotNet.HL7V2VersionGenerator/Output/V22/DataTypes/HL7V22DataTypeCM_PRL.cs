using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_PRL
    {
        public string Id { get { return @"CM_PRL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Parent Result Link"; } }

        public string Description { get { return @"The third component may be used to record the name of the microorganism identified by the parent result directly.  The organism in this case should be identified exactly as it is in the parent culture"; } }

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
                            Id = @"CM_PRL.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PRL.1",
                            Name = @"OBX-3-observation identifier of parent result",
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
                            Id = @"CM_PRL.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PRL.2",
                            Name = @"OBX-4-sub-ID of parent result",
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
                            Id = @"CM_PRL.3",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PRL.3",
                            Name = @"OBX-5-observation results from parent",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
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

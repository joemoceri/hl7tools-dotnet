using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeCM_PLACER
    {
        public string Id { get { return @"CM_PLACER"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Order Number Of The Client / The Contracting Authority"; } }

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
                            Id = @"CM_PLACER.1",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PLACER.1",
                            Name = @"Unique Placer Id",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a string of up to 15 characters that identifies an individual order (e.g., OBR).  It is assigned by the placer (ordering application).  It identifies an order uniquely among all orders from a particular ordering application.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CM_PLACER.2",
                            Type = @"DataTypeComponent",
                            Position = @"CM_PLACER.2",
                            Name = @"Placer Application",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the application ID of the placing application.  The application ID is a string of up to six (6) characters that will be uniquely associated with an application.  A given institution or group of intercommunicating institutions should establish a unique list of applications that may be potential placers and fillers and assign unique application ID's.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

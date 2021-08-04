using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"PRL"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Parent Result Link"; } }

        public string Description { get { return @"Uniquely identifies the parent results OBX segment related to the current order, together with the information in OBR-29-parent."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 755; } }

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
                            Id = @"PRL.1",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.1",
                            Name = @"Parent Observation Identifier",
                            Length = 483,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the unique identifier of the parent observation as defined in the OBX-3 of the parent result. The value is the same as the OBX-3 of the parent.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRL.2",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.2",
                            Name = @"Parent Observation Sub-identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the sub-ID of the parent result as defined in the OBX-4 of the parent result. The value is the same as the OBX-4 of the parent.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRL.3",
                            Type = @"DataTypeComponent",
                            Position = @"PRL.3",
                            Name = @"Parent Observation Value Descriptor",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains a descriptor of the parent observation value as specified in the OBX-5 of the parent result.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

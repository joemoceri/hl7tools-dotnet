using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"OSP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Occurrence Span Code and Date"; } }

        public string Description { get { return @"A code and the related dates that identify an event that relates to the payment of the claim. For example, Prior Stay Dates which is the from/through dates given by the patient of any hospital stay that ended within 60 days of this hospital or SNF admission.

 Example: |71&Prior Stay Date&NUBC^20030106^20030107| "; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 723; } }

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
                            Id = @"OSP.1",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.1",
                            Name = @"Occurrence Span Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = @"The date an event started that relates to the payment of a claim.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OSP.2",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.2",
                            Name = @"Occurrence Span Start Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event ended that relates to the payment of a claim.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OSP.3",
                            Type = @"DataTypeComponent",
                            Position = @"OSP.3",
                            Name = @"Occurrence Span Stop Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
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

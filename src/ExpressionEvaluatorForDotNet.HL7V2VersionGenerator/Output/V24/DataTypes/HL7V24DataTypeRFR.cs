using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypeRFR
    {
        public string Id { get { return @"RFR"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Reference Range"; } }

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
                            Id = @"RFR.1",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.1",
                            Name = @"Numeric Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.2",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.2",
                            Name = @"Administrative Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0007",
                            TableName = @"Admission type",
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.3",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.4",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.4",
                            Name = @"Gestational Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.5",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RFR.6",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.6",
                            Name = @"Race/subspecies",
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
                            Id = @"RFR.7",
                            Type = @"DataTypeComponent",
                            Position = @"RFR.7",
                            Name = @"Conditions",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
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

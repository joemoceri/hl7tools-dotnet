using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeVH
    {
        public string Id { get { return @"VH"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Visiting Hours"; } }

        public string Description { get { return @"This data type contains the hours when a patient location is open for visiting.  Refer to HL7 table 0267 - Days of the week for valid values for the first two components"; } }

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
                            Id = @"VH.1",
                            Type = @"DataTypeComponent",
                            Position = @"VH.1",
                            Name = @"Start Day Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0267",
                            TableName = @"Days of the week",
                            Description = @"Starting day of visiting hours range.  See HL7 table 0267 - Days of the week for values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VH.2",
                            Type = @"DataTypeComponent",
                            Position = @"VH.2",
                            Name = @"End Day Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0267",
                            TableName = @"Days of the week",
                            Description = @"Ending day of visiting hours range.  Starting day of visiting hours range.  See HL7 table 0267 - Days of the week for values ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VH.3",
                            Type = @"DataTypeComponent",
                            Position = @"VH.3",
                            Name = @"Start Hour Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TM",
                            DataTypeName = @"Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Starting hour on starting day of visiting hours range (see first component, 2.8.44.1, “Start day range”). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"VH.4",
                            Type = @"DataTypeComponent",
                            Position = @"VH.4",
                            Name = @"End Hour Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TM",
                            DataTypeName = @"Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Ending hour on ending day of visiting hours range (see second component, 2.8.44.2, “End day range”). ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeOCD
    {
        public string Id { get { return @"OCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Occurrence Code and Date"; } }

        public string Description { get { return @"The code and associated date defining a significant event relating to a bill that may affect payer processing."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 714; } }

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
                            Id = @"OCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"OCD.1",
                            Name = @"Occurrence Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
                            Description = @"The NUBC code for the event or occurrence relating to a bill that may affect payer processing.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OCD.2",
                            Type = @"DataTypeComponent",
                            Position = @"OCD.2",
                            Name = @"Occurrence Date",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date the event, relating to a bill that may affect payer processing, occurred.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

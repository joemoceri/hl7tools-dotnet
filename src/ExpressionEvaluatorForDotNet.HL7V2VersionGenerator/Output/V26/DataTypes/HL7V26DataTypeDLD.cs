using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"DLD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Discharge Location and Date"; } }

        public string Description { get { return @"Specifies the healthcare facility to which the patient was discharged and the date."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 730; } }

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
                            Id = @"DLD.1",
                            Type = @"DataTypeComponent",
                            Position = @"DLD.1",
                            Name = @"Discharge To Location",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0113",
                            TableName = @"Discharged to location",
                            Description = @"This component specifies the healthcare facility to which the patient was discharged. Refer to User-defined Table 0113 - Discharged to location for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DLD.2",
                            Type = @"DataTypeComponent",
                            Position = @"DLD.2",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date on which the patient was discharged to a healthcare facility.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

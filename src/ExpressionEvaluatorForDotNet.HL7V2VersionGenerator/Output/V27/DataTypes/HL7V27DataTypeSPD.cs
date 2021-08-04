using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"SPD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Specialty Description"; } }

        public string Description { get { return @"This data type specifies the practitioner’s specialty and related information.

Note: Replaces the CM data type used in 15.4.5.5 PRA-5 as of v 2.5."; } }

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
                            Id = @"SPD.1",
                            Type = @"DataTypeComponent",
                            Position = @"SPD.1",
                            Name = @"Specialty Name",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the provider’s specialty.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPD.2",
                            Type = @"DataTypeComponent",
                            Position = @"SPD.2",
                            Name = @"Governing Board",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Identifies the governing body providing for the specialty.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPD.3",
                            Type = @"DataTypeComponent",
                            Position = @"SPD.3",
                            Name = @"Eligible Or Certified",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0337",
                            TableName = @"Certification Status",
                            Description = @"Specifies the certification status. Refer to HL7 Table 0337 – Certification Status for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPD.4",
                            Type = @"DataTypeComponent",
                            Position = @"SPD.4",
                            Name = @"Date Of Certification",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies when certification occurred.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

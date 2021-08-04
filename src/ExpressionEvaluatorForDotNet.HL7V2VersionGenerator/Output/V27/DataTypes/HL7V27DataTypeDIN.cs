using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeDIN
    {
        public string Id { get { return @"DIN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date And Institution Name"; } }

        public string Description { get { return @"Specifies the date and institution information where a staff member became active or inactive.

Note: Replaces the CM data type used in sections 15.4.6.12 STF-12 and 15.4.6.14 STF-13, as of v 2.5."; } }

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
                            Id = @"DIN.1",
                            Type = @"DataTypeComponent",
                            Position = @"DIN.1",
                            Name = @"Date",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the date when a staff member became active or inactive.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DIN.2",
                            Type = @"DataTypeComponent",
                            Position = @"DIN.2",
                            Name = @"Institution Name",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0531",
                            TableName = @"Institution",
                            Description = @"Specifies the institution where a staff member is or was active. Refer to User-Defined Table 0531 - Institution for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeRMC
    {
        public string Id { get { return @"RMC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Room Coverage"; } }

        public string Description { get { return @"This data type specifies insurance coverage detail for a room.

Note: Replaces the CM data type used in section 6.5.7.28 IN2-28, as of v 2.5."; } }

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
                            Id = @"RMC.1",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.1",
                            Name = @"Room Type",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0145",
                            TableName = @"Room Type",
                            Description = @"Specifies the room type.

Refer to User-defined Table 0145 - Room Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.2",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.2",
                            Name = @"Amount Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0146",
                            TableName = @"Amount Type",
                            Description = @"Specifies amount quantity type.

Refer to User-defined Table 0146 – Amount Type for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.3",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.3",
                            Name = @"Coverage Amount",
                            Length = 0,
                            Usage = @"W",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Attention: The PTA.3 component was deprecated as of v2.5 and the detail was withdrawn and removed from the standard as of v2.7.  Refer to 2.A.64.4, ""Money or Percentage"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.4",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.4",
                            Name = @"Money Or Percentage",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MOP",
                            DataTypeName = @"Money Or Percentage",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an amount that may be either currency or a percentage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

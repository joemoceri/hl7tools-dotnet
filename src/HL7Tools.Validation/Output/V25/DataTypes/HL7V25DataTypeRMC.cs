using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataTypeRMC
    {
        public string Id { get { return @"RMC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Room Coverage"; } }

        public string Description { get { return @"This data type specifies insurance coverage detail for a room."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 82; } }

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
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0145",
                            TableName = @"Room type",
                            Description = @"Specifies the room type.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.2",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.2",
                            Name = @"Amount Type",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0146",
                            TableName = @"Amount type",
                            Description = @"Specifies amount quantity type",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.3",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.3",
                            Name = @"Coverage Amount",
                            Length = 16,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies amount covered by the insurance as a currency or percentage quantity.

Retained for backward compatibility only as of v 2.5. Refer to Money or Percentage. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMC.4",
                            Type = @"DataTypeComponent",
                            Position = @"RMC.4",
                            Name = @"Money Or Percentage",
                            Length = 23,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MOP",
                            DataTypeName = @"Money or Percentage",
                            TableId = null,
                            TableName = null,
                            Description = @"specifies an amount that may be either currency or a percentage.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

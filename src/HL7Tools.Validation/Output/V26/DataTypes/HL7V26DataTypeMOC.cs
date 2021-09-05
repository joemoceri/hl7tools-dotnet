using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeMOC
    {
        public string Id { get { return @"MOC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Money and Code"; } }

        public string Description { get { return @"Transmits monetary information and the associated charge code for services performed."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 726; } }

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
                            Id = @"MOC.1",
                            Type = @"DataTypeComponent",
                            Position = @"MOC.1",
                            Name = @"Monetary Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The amount and denomination of money associated with the charge code.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"MOC.2",
                            Type = @"DataTypeComponent",
                            Position = @"MOC.2",
                            Name = @"Charge Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"The code identifying the charge to the ordering entity for the services performed.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

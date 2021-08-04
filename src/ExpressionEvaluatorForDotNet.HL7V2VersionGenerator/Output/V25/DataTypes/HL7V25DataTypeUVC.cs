using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"UVC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"UB Value Code and Amount"; } }

        public string Description { get { return @"A code structure to relate amounts or values to identified data elements necessary to process this claim as qualified by the payer organization."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 41; } }

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
                            Id = @"UVC.1",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.1",
                            Name = @"Value Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0153",
                            TableName = @"Value code",
                            Description = @"Specifies the National Uniform Billing Committee (NUBC) code itself.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UVC.2",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.2",
                            Name = @"Value Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

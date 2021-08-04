using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"OCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Occurrence Code And Date"; } }

        public string Description { get { return @"The code and associated date defining a significant event relating to a bill that may affect payer processing.

Note: Replaces the CM data type used in sections 6.5.10.10 UB1-16 and 6.5.11.7 UB2-7, as of v 2.5.

This data type carries data defined by CMS or other regulatory agencies. It corresponds to UB82 Fields 28 32 and UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. Refer to a UB specification for additional information.

Use Case: A Medicare beneficiary was confined in hospital from January 1, 1992 to January 10, 1992, however, his Medicare Part A benefits were exhausted as of January 8, 1992, and he was not entitled to Part B benefits. Therefore, Form Locator 32 should contain code 23 and the date 010892.

Example:
|23&Benefits Exhausted&NUBC^19920108|"; } }

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
                            Id = @"OCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"OCD.1",
                            Name = @"Occurrence Code",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded With No Exceptions",
                            TableId = @"0350",
                            TableName = @"Occurrence Code",
                            Description = @"The NUBC code for the event or occurrence relating to a bill that may affect payer processing.

Refer to HL7-defined Table 0350 – Occurrence Code for valid values.

Values for this component need to come from National Uniform Billing Committee (NUBC). No extensions are allowed.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OCD.2",
                            Type = @"DataTypeComponent",
                            Position = @"OCD.2",
                            Name = @"Occurrence Date",
                            Length = 0,
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

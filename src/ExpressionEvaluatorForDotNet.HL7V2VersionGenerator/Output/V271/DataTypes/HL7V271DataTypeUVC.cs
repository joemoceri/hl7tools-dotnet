using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"UVC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Ub Value Code And Amount"; } }

        public string Description { get { return @"A code structure to relate amounts or values to identified data elements necessary to process this claim as qualified by the payer organization.

This data type is used to convey information defined by CMS or other regulatory agencies. It corresponds to UB fields 46A, 47A, 48A, 49A, 46B, 47B, 48B, and 49B and UB92 fields 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. 

Note: Replaces the CM data type used in sections 6.5.10.10 UB1-10 and 6.5.11.6 UB2-6, as of v 2.5.

The most common semi-private room rate is used in instances where the patient is placed in a private room at their request but their insurance only covers a semi-private room rate, which can be calculated using the 01-most common semi-private room rate.

Example:
|01&most common semi private rate&NUBC^750&USD|"; } }

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
                            Id = @"UVC.1",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.1",
                            Name = @"Value Code",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0153",
                            TableName = @"Value Code",
                            Description = @"Specifies the National Uniform Billing Committee (NUBC) code itself.

Refer to External Table 0153 – Value Code for valid values. In the United States, values for this component need to come from National Uniform Billing Committee (NUBC); no extensions are allowed.  

Other realms should determine the precise set appropriate for their realm.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UVC.2",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.2",
                            Name = @"Value Amount",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value when it is monetary.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UVC.3",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.3",
                            Name = @"Non-monetary Value Amount / Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value when it is non-monetary. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UVC.4",
                            Type = @"DataTypeComponent",
                            Position = @"UVC.4",
                            Name = @"Non-monetary Value Amount / Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the  non-monetary quantity is expressed. Refer to the Unified Code for Units of Measure (UCUM) for valid values [http://aurora.rg.iupui.edu/UCUM].",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

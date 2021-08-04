using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"CP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Price"; } }

        public string Description { get { return @"Note: This data type is often used to define a repeating field within a given segment.

Example:
|100.00&USD^UP^0^9^min^P~50.00&USD^UP^10^59^min^P~10.00&USD^UP^60^999^P~50.00&USD^AP~200.00&USD^PF~80.00&USD^DC|"; } }

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
                            Id = @"CP.1",
                            Type = @"DataTypeComponent",
                            Position = @"CP.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.A.41, ""MO - money"") is a subcomponent here.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.2",
                            Type = @"DataTypeComponent",
                            Position = @"CP.2",
                            Name = @"Price Type",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0205",
                            TableName = @"Price Type",
                            Description = @"A coded value, data type ID.  Refer to HL7 Table 0205 – Price Type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.3",
                            Type = @"DataTypeComponent",
                            Position = @"CP.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range. This component, together with the CP.4 component, specifies the ""price range"". The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.

Note that, if the CP.2 Price Type component is TP, both CP.3 and CP.4 may be null.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.4",
                            Type = @"DataTypeComponent",
                            Position = @"CP.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.5",
                            Type = @"DataTypeComponent",
                            Position = @"CP.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count).  As of v2.7 the Externally-defined Unified Code for Units of Measure (UCUM) case sensitive code is the required code for units of measure.  Refer to the externally-defined table ""Unified Code for Units of Measure"" (UCUM) [http://aurora.rg.iupui.edu/UCUM] for valid values. Local codes may be transmitted in addition to UCUM codes. 

This component is required if CP.3 From Value and/or CP.4 To Value are present.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.6",
                            Type = @"DataTypeComponent",
                            Position = @"CP.6",
                            Name = @"Range Type",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0298",
                            TableName = @"CP Range Type",
                            Description = @"Refer to HL7 Table 0298 - CP Range Type for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

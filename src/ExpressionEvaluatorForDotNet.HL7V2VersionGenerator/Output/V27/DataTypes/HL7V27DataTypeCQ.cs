using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"CQ"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Quantity With Units"; } }

        public string Description { get { return @"Note: CQ cannot be legally expressed when embedded within another data type. Its use is constrained to a segment field.

Examples:
kilograms is an ISO unit
|123.7^kg|

weight in pounds is a customary US unit defined within ANSI+.	
|150^lb&&ANSI+|"; } }

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
                            Id = @"CQ.1",
                            Type = @"DataTypeComponent",
                            Position = @"CQ.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CQ.2",
                            Type = @"DataTypeComponent",
                            Position = @"CQ.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed.  As of v2.7 the externally-defined Unified Code for Units of Measure (UCUM) case sensitive code is the required code for units of measure. Refer to the external table ""Unified Code for Units of Measure"" (UCUM) [http://aurora.rg.iupui.edu/UCUM] for valid values. Local codes may be transmitted in addition to UCUM codes.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

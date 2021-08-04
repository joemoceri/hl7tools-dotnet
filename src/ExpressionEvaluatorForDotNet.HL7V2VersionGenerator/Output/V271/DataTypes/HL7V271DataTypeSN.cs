using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeSN
    {
        public string Id { get { return @"SN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Structured Numeric"; } }

        public string Description { get { return @"The structured numeric data type is used to unambiguously express numeric clinical results along with qualifications. This enables receiving systems to store the components separately, and facilitates the use of numeric database queries. The corresponding sets of values indicated with the <comparator> and <separator/suffix> components are intended to be the authoritative and complete set of values. If additional values are needed for the <comparator> and <separator/suffix> components, they should be submitted to HL7 for inclusion in the Standard.

If <num1> and <num2> are both non-null, then the separator/suffix must be non-null. If the separator is ""-"", the data range is inclusive; e.g., <num1> - <num2> defines a range of numbers x, such that: <num1> <=x<= <num2>."; } }

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
                            Id = @"SN.1",
                            Type = @"DataTypeComponent",
                            Position = @"SN.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (=  "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SN.2",
                            Type = @"DataTypeComponent",
                            Position = @"SN.2",
                            Name = @"Num1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SN.3",
                            Type = @"DataTypeComponent",
                            Position = @"SN.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""
Examples:
Greater than 100
|>^100|

Equal to range of 100 through 200
|^100^-^200|

Ratio of 1 to 128, e.g., the results of a serological test
|^1^:^228|

Categorical response, e.g., occult blood positivity
|^2^+|",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SN.4",
                            Type = @"DataTypeComponent",
                            Position = @"SN.4",
                            Name = @"Num2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

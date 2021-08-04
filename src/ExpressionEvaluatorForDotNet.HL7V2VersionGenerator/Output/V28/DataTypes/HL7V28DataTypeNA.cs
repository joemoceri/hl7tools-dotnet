using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"NA"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Numeric Array"; } }

        public string Description { get { return @"This data type is used to represent a series (array) of numeric values. A field of this type may contain a one-dimensional array (vector or row) of numbers. Also, by allowing the field to repeat, a two-dimensional array (table) of numbers may be transmitted using this format, with each row of the table represented as one repetition of the field. Arrays that have one or more values not present may be transmitted using this data type. ""Not present"" values are represented as two adjacent component delimiters. If the absent values occur at the end of a row, the trailing component delimiters may be omitted. If an entire row of a table has no values, no component delimiters are necessary (in this case, there will be two adjacent repetition delimiters).

Example 1: vector of 8 numbers
|125^34^-22^-234^569^442^-212^6|

Example 2: 3 x 3 array of numbers
|1.2^-3.5^5.2~2.0^3.1^-6.2~3.5^7.8^-1.3|

Example 3: 5 x 4 array of numbers with the values in positions (1,1), (2,2), (2,3), (3,3), (3,4), (4,1), (4,2), (4,3), and (4,4) not present
|^2^3^4~5^^^8~9^10~~17^18^19^20|"; } }

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
                            Id = @"NA.1",
                            Type = @"DataTypeComponent",
                            Position = @"NA.1",
                            Name = @"Value1",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NA.2",
                            Type = @"DataTypeComponent",
                            Position = @"NA.2",
                            Name = @"Value2",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NA.3",
                            Type = @"DataTypeComponent",
                            Position = @"NA.3",
                            Name = @"Value3",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"NA.4",
                            Type = @"DataTypeComponent",
                            Position = @"NA.4",
                            Name = @"Value4",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

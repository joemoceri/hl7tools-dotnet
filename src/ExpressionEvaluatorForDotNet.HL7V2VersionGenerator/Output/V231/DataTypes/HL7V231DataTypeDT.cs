using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"DT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date"; } }

        public string Description { get { return @"In prior versions of HL7, this data type was always specified to be in the format YYYYMMDD. In the current and future versions, the precision of a date may be expressed by limiting the number of digits used with the format specification YYYY[MM[DD]]. Thus, YYYY is used to specify a precision of year, YYYYMM specifies a precision of month, and YYYYMMDD specifies a precision of day.

By site-specific agreement, YYYYMMDD may be used where backward compatibility must be maintained.

Examples:
|19880704|
|199503|"; } }

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
                return null;
            }
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeDT
    {
        public string Id { get { return @"DT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date"; } }

        public string Description { get { return @"Specifies the century and year with optional precision to month and day

The number of digits populated specifies the precision using the format specification YYYY[MM[DD]]

Examples:
|19880704|
|199503|

The DT data type does not follow the normal truncation pattern, and the truncation character is never valid in the DT data type. Instead, the truncation behavior is based on the semantics of dates. 

Unless specified in the context where the DT type  is used, the DT type may not be truncated. When a DT is truncated, the truncated form SHALL still be a valid DT type. Systems should always be able to persist full dates. Refer to Chapter 2, section 2.5.5.2 ""Truncation Pattern"" for further information. 

Note: Prior to v2.3, this data type was specified in the format YYYYMMDD. As of v2.3, month and days are no longer required. By site-specific agreement, YYYYMMDD may be used where backward compatibility must be maintained."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 8; } }

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

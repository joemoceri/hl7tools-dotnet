using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"DT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date"; } }

        public string Description { get { return @"Specifies the century and year with optional precision to month and day.

Prior to v 2.3, this data type was specified in the format YYYYMMDD. As of v 2.3 month and days are no longer required. By site-specific agreement, YYYYMMDD may be used where backward compatibility must be maintained. "; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeFT
    {
        public string Id { get { return @"FT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Formatted Text Data"; } }

        public string Description { get { return @"For additional examples of formatting commands see Section 2.9, Use of escape sequences in text fields ."; } }

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

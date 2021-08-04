using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"ST"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"String Data"; } }

        public string Description { get { return @"To include any HL7 delimiter character (except the segment terminator) within a string data field, use the appropriate HL7 escape sequence (see Section 2.9.1, Formatting codes)."; } }

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

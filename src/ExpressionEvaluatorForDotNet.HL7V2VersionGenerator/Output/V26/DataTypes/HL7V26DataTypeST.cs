using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeST
    {
        public string Id { get { return @"ST"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"String Data"; } }

        public string Description { get { return @"The String data type is used for text data when the appearance of text does not bear meaning. This is true for formalized text, symbols and formal expressions, and all kinds of names intended for machine processing (e.g., sorting, querying, indexing, etc.)"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 999; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataTypeFT
    {
        public string Id { get { return @"FT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Formatted Text Data"; } }

        public string Description { get { return @"This data type is derived from the TX data type by allowing the addition of embedded formatting instructions. These instructions are limited to those that are intrinsic and independent of the circumstances under which the field is being used. The actual instructions and their representation are described in section 2.7.6, Usage and Examples of Formatted Text. The FT field is of arbitrary length (up to 64k) and may contain formatting commands enclosed in escape characters."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 65536; } }

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

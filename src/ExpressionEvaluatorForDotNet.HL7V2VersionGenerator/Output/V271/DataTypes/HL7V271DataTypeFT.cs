using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeFT
    {
        public string Id { get { return @"FT"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Formatted Text Data"; } }

        public string Description { get { return @"This data type is derived from the TX data type by allowing the addition of embedded formatting instructions. These instructions are limited to those that are intrinsic and independent of the circumstances under which the field is being used. The actual instructions and their representation are described in section 2.7.6, “Usage and Examples of Formatted Text”. The FT field is of arbitrary length (up to 64k) and may contain formatting commands enclosed in escape characters.

Example:
|\.sp\(skip one vertical line)|

For additional examples of formatting commands see Section 2.7, ""Use of Escape Sequences in Text Fields"".

To include alternative character sets, use the appropriate escape sequence. See Chapter 2, ""Control"", section 2.15.9.18, ""Character set"" and section 2.14.9.20, ""Alternate character set handling scheme"".

This specification applies no limit to the length of the FT data type, either here where the data type is defined, or elsewhere where the data type is used. While there is no intrinsic reason to limit the length of this data type for semantic or syntactical reasons, it is expected that some sort of limitation will be imposed for technical reasons in implementations. HL7 recommends that implementation length limits are published in implementation profiles. The contents of an FT field may be truncated, but the truncation pattern does not apply."; } }

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

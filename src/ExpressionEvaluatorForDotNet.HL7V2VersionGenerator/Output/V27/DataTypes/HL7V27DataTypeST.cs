using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"ST"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"String Data"; } }

        public string Description { get { return @"The String data type is used for text data when the appearance of text does not bear meaning. This is true for formalized text, symbols and formal expressions, and all kinds of names intended for machine processing (e.g., sorting, querying, indexing, etc.).

String data is left justified (i.e., no leading blank space) with trailing blanks optional. Any displayable (printable) ACSII characters (hexadecimal values between 20 and 7E, inclusive, or ASCII decimal values between 32 and 126), except the defined escape characters and defined delimiter characters.

Example 1: A textual ST field:
|almost any data at all|

To include any HL7 delimiter character (except the segment terminator) within a string data field, use the appropriate HL7 escape sequence (see Section 2.7.1, ""Formatting Codes”).

ST has no inbuilt semantics – these are assigned where the ST is used. In each case where ST is used, minimum, maximum, and conformance lengths may be specified.  Unless specified in the context of use, values of type ST may not be truncated.

Usage note: The ST data type is intended for short strings (e.g., less than 1000 characters). For longer strings the TX or FT data types should be used (see Sections 2.A.79, “TX - text data” or 2.A.31, “FT - formatted text data”).

Alternate character set note: ST - string data may also be used to express other character sets. See Section 2.15.9.18, ""Character set,"" and Section 2.15.9.20, ""Alternate character set handling"" for details."; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataType
    {
        public string Id { get { return @"ST"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"String Data"; } }

        public string Description { get { return @"String data is left justified with trailing blanks optional.  Any displayable (printable) ACSII characters (hexadecimal values between 20 and 7E, inclusive, or ASCII decimal values between 32 and 126), except the defined escape characters and defined delimiter characters.  

Example:
|almost any data at all|

Usage note: The ST data type is intended for short strings (e.g., less than 200 characters).  For longer strings the TX or FT data types should be used (see Sections 2.9.48, “TX - text data” or 2.9.20, “FT - formatted text data”)."; } }

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

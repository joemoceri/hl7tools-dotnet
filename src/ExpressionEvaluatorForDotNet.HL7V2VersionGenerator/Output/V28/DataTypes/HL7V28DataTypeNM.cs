using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"NM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Numeric"; } }

        public string Description { get { return @"A number represented as a series of ASCII numeric characters consisting of an optional leading sign (+ or -), the digits and an optional decimal point. In the absence of a sign, the number is assumed to be positive. If there is no decimal point the number is assumed to be an integer. 

Values of this data type shall contain at least one digit to the left of the decimal point. This means that 0.1 is a valid representation, while .1 is not. Leading zeros, or trailing zeros after a decimal point, are not significant. For example, the following two values with different representations, ""01.20"" and ""1.2,"" are identical. Except for the optional leading sign (+ or -) and the optional decimal point (.), no non-numeric ASCII characters are allowed. Thus, the value <12 should be encoded as a structured numeric (SN) (preferred) or as a string (ST) (allowed, but not preferred) data type.

The NM data type does not follow the normal truncation pattern, and the truncation character is never valid in the NM data type. Instead, the truncation behavior is based on the semantics of numbers. 

Values of type NM may always have leading zeros truncated. Note that HL7 recommends that leading zeros not be used. Unless NM is used to represent a monetary amount, implementations may truncate trailing zeros after the decimal point up to the first non-zero digit or the decimal point, which ever comes first. Any digits to the left of the decimal point may never be truncated (other than leading zeros).

Example: 1.0200 may be truncated to 1.02, but not to 1.0."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 16; } }

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

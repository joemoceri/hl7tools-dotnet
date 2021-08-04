using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataTypeDTM
    {
        public string Id { get { return @"DTM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date/time"; } }

        public string Description { get { return @"Specifies a point in time using a 24-hour clock notation. 

The number of characters populated (excluding the time zone specification) specifies the precision. 

Format: YYYY[MM[DD[HH[MM[SS[.S[S[S[S]]]]]]]]][+/-ZZZZ]. 

The time zone (+/-ZZZZ) is represented as +/-HHMM offset from Coordinated Universal Time (UTC) (formerly Greenwich Mean Time (GMT)), where +0000 or -0000 both represent UTC (without offset). The specific data representations used in the HL7 encoding rules are compatible with ISO 8824-1987(E).

Note: The time zone [+/-ZZZZ], when used, is restricted to legally-defined time zones and is represented in HHMM format."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 24; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeTM
    {
        public string Id { get { return @"TM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time"; } }

        public string Description { get { return @"In prior versions of HL7, this data type was always specified to be in the format HHMM[SS[.SSSS]][+/-ZZZZ] using a 24 hour clock notation. In the current and future versions, the precision of a time may be expressed by limiting the number of digits used with the format specification as shown above. By site-specific agreement, HHMM[SS[.SSSS]][+/-ZZZZ] may be used where backward compatibility must be maintained.

Format: HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]"; } }

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

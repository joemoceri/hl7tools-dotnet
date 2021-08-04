using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"TM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time"; } }

        public string Description { get { return @"Specifies the hour of the day with optional minutes, seconds, fraction of second using a 24-hour clock notation and time zone.

As of v 2.3, the number of characters populated (excluding the time zone specification) specifies the precision. 

Format: HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ]

Example: |0630| specifies 6: 30 AM.

The fractional seconds could be sent by a transmitter who requires greater precision than whole seconds. Fractional representations of minutes, hours or other higher-order units of time are not permitted.

Note: The time zone [+/-ZZZZ], when used, is restricted to legally-defined time zones and is represented in HHMM format.

Prior to v 2.3, this data type was specified in the format HHMM[SS[.SSSS]][+/-ZZZZ]. As of v 2.3 minutes are no longer required. By site-specific agreement, HHMM[SS[.SSSS]][+/-ZZZZ] may be used where backward compatibility must be maintained.This corresponds a minimum length of 4.

The TM data type does not follow the normal truncation pattern, and the truncation character is never valid in the TM data type. Instead, the truncation behavior is based on the semantics of times. 

Unless otherwise specified in the context where the DTM type is used, the DTM type may be truncated to a particular minute. When a TM is truncated, the truncated form SHALL still be a valid TM type. Refer to Chapter 2, section 2.5.5.2, ""Truncation Pattern"", for further information."; } }

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

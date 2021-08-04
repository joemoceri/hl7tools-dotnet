using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeTM
    {
        public string Id { get { return @"TM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time"; } }

        public string Description { get { return @"Format: HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ] 

In prior versions of HL7, this data type was always specified to be in the format HHMM[SS[.SSSS]][+/ZZZZ] using a 24 hour clock notation.  In the current and future versions, the precision of a time may be expressed by limiting the number of digits used with the format specification as shown above.  By sitespecific agreement, HHMM[SS[.SSSS]][+/-ZZZZ] may be used where backward compatibility must be maintained.

Thus, HH is used to specify a precision of “hour,” HHMM is used to specify a precision of “minute,” HHMMSS is used to specify a precision of seconds, and HHMMSS.SSSS is used to specify a precision of  ten-thousandths of a second.

In each of these cases, the time zone is an optional component. The fractional seconds could be sent by a transmitter who requires greater precision than whole seconds.  Fractional representations of minutes, hours or other higher orders units of time are not permitted.   
The time zone of the sender may be sent optionally as an offset from the coordinated universal time (previously known as Greenwich Mean Time).  Where the time zone is not present in a particular TM field but is included as part of the date/time field in the MSH segment, the MSH value will be used as the default time zone.  Otherwise, the time is understood to refer to the local time of the sender.  Midnight is represented as 0000.

Examples:

1 second before midnight in a time zone eleven hours ahead of Universal Coordinated Time (i.e., east of Greenwich). 
|235959+1100|  

Eight AM, local time of the sender.
|0800|

44.2312 seconds after Nine thirty-five AM, local time of sender.  
|093544.2312|

1pm (with a precision of hours), local time of sender.
|13|"; } }

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

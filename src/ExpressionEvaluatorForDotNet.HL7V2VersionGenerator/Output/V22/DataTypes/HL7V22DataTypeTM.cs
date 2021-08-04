using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeTM
    {
        public string Id { get { return @"TM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time"; } }

        public string Description { get { return @"Always in the format HHMM[SS[.SSSS]][+/-ZZZZ] using a 24 hour clock notation.  The seconds designation (SS) is optional.  If not present it will be interpreted as 00.  The fractional seconds designation is likewise optional.  If not present it will be interpreted as .0000.  The fractional seconds could be sent by a transmitter who requires greater precision than whole seconds.  Fractional representations of minutes, hours or other higher orders units of time are not permitted.  The time zone of the sender may be sent optionally as an offset from the coordinated universal time (previously known as Greenwich Mean Time.)   Where the time zone is not present in a particular TM field but is included as part of the date/time field in the MSH segment, the MSH value will be used as the default time zone.  Otherwise, the time is understood to refer to the local time of the sender.  Midnight is represented as 0000.

Examples: 

|235959+1130| 1 second before midnight in a time zone eleven and half hours ahead of Universal Coordinated Time (i.e., east of Greenwich). 

|0800| Eight AM, local time of the sender. 

|093544.2312| 44.2312 seconds after Nine thirty-five AM, local time of sender. "; } }

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

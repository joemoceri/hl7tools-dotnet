using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataTypeTS
    {
        public string Id { get { return @"TS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time Stamp"; } }

        public string Description { get { return @"Contains the exact time of an event, including the date and time.  Time stamp fields are always in the format: 
 
 YYYYMMDD[HHMM[SS[.SSSS]]][+/-ZZZZ]^<degree of precision>   
 
The date portion of a time stamp follows the rules of a date field and the time portion follows the rules of a time field.  When used as a birthdate, the HHMM portion is optional.  If not present the HHMM portion will default to 0000, i.e., midnight of the day just beginning.  The specific data representations used in the HL7 encoding rules are compatible with ISO 8824-1987(E).  An optional second component indicates the degree of precision of the date (Y = year, L = month, D = day, H = hour, M = minute, S = second). (Maximum length of field is 26). 

Examples: 
 
|17760704010159-0600|1:01:59 on July 4, 1776 in the Eastern Standard Time zone. 
 
|17760704010159-0500|1:01:59 on July 4, 1776 in the Eastern Daylight Saving Time zone. 
 
|198807050000|  Midnight of the night extending from July 4 to July 5, 1988 in the local time zone of the sender.  
 
|198807050000^D| Same as prior example, but precision extends only to the day.  Could be used for a birthdate. "; } }

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
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TS.1",
                            Type = @"DataTypeComponent",
                            Position = @"TS.1",
                            Name = @"Time Of An Event",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TS.2",
                            Type = @"DataTypeComponent",
                            Position = @"TS.2",
                            Name = @"Degree Of Precision",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

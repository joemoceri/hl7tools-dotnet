using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataType
    {
        public string Id { get { return @"TM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Time"; } }

        public string Description { get { return @"Specifies the hour of the day with optional minutes, seconds, fraction of second using a 24-hour clock notation and time zone.

Format: HH[MM[SS[.S[S[S[S]]]]]][+/-ZZZZ] "; } }

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

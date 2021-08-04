using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeGTS
    {
        public string Id { get { return @"GTS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"General Timing Specification"; } }

        public string Description { get { return @"The General Timing Specification data type is used to communicate complex inter-related information Timing information. The value of such a field follows the formatting rules for a ST field. The string data will be structured according to the rules set forth in the ""Version 3 Data Types Part II Unabridged Specification"" for the General Timing Specification (GTS) data type.

There is no technical limit to the length of a GTS expression – the expression may be as long as logically required. The conformance length of 199 caters for all the common expressions. GTS expressions are not to be truncated."; } }

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

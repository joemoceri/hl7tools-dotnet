using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeSNM
    {
        public string Id { get { return @"SNM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"String Of Telephone Number Digits"; } }

        public string Description { get { return @"A string whose characters are limited to ""+"" and/or the decimal digits 0  through 9.  As a string, leading zeros are always considered significant. 

Used only in the XTN data type as of v2.7. 

Minimum Length: 1
Maximum Length: Not specified for the type. May be specified in the context of use

SNM is used for telephone numbers, so it is never appropriate to truncate values of type SNM. "; } }

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

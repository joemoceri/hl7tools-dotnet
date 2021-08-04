using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"TN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Telephone Number"; } }

        public string Description { get { return @"For use in the United States and conforming countries, the telephone number is always in the form: 

Format:  [NN] [(999)]999-9999[X99999][B99999][C any text]

The optional first two digits are the country code.  The optional X portion gives an extension.  The optional B portion gives a beeper code.  The optional C portion may be used for comments like, After 6:00.  While no explicit limit is placed on the text field, receiving systems may be expected to truncate values that are more than 10 characters long.  To accommodate the variability of institutional phone systems, the length of the extension and beeper numbers may be extended by local agreement.

Examples:  
|(415)925-0121X305| 
|234-4532CWEEKENDS|"; } }

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

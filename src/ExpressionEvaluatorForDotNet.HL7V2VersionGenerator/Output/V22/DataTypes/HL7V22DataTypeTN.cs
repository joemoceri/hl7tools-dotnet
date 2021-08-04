using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"TN"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Telephone Number"; } }

        public string Description { get { return @"For use in the United States and conforming countries, the telephone number is always in the form: [NN] [(999)]999-9999[X99999][B99999][C any text] 

Examples:  
|(415)925-0121X305| |234-4532CWEEKENDS|"; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypeDTM
    {
        public string Id { get { return @"DTM"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Date/Time"; } }

        public string Description { get { return @"Specifies a point in time using a 24-hour clock notation."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 24; } }

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

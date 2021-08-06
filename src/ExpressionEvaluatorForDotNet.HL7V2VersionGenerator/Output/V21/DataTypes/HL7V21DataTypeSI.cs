using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21DataTypeSI
    {
        public string Id { get { return @"SI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Set Id"; } }

        public string Description { get { return null; } }

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
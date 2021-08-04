using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataType
    {
        public string Id { get { return @"TX"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Text Data"; } }

        public string Description { get { return @"Since TX data is intended for display purposes, the repeat delimiter, when used with a TX data field, implies a series of repeating lines to be displayed on a printer or terminal. Therefore, the repeat delimiters are regarded as paragraph terminators or hard carriage returns (e.g., they would display as though a CR/LF were inserted in the text (DOS type system) or as though a LF were inserted into the text (UNIX style system))."; } }

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

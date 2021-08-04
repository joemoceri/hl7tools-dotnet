using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24DataTypeTX
    {
        public string Id { get { return @"TX"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Text Data"; } }

        public string Description { get { return @"String data meant for user display (on a terminal or printer).  Such data would not necessarily be left justified since leading spaces may contribute greatly to the clarity of the presentation to the user.  Because this type of data is intended for display, it may contain certain escape character sequences designed to control the display.  Escape sequence formatting is defined later in this chapter in Section 2.10 “Use of escape sequences in text fields.”  Leading spaces should be included.  Trailing spaces should be removed.  

Since TX data is intended for display purposes, the repeat delimiter, when used with a TX data field, implies a series of repeating lines to be displayed on a printer or terminal.  Therefore, the repeat delimiters are regarded as paragraph terminators or hard carriage returns (e.g., they would display as though a CR/LF were inserted in the text (DOS type system) or as though a LF were inserted into the text (UNIX style system)).

Example:
|  leading spaces are allowed.|"; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 65536; } }

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

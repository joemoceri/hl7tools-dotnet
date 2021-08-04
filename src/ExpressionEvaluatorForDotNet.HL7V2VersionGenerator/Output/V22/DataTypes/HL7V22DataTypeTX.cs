using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"TX"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Text Data"; } }

        public string Description { get { return @"String data meant for user display (on a terminal or printer).  Such data would not necessarily be left justified since leading spaces may contribute greatly to the clarity of the presentation to the user.  Because this type of data is intended for display, it may contain certain escape character sequences designed to control the display.  Escape sequence formatting is defined later in this chapter in Section 2.4.6.  Leading spaces should be included.  Trailing spaces should be removed. 

Example:
|  leading spaces are allowed.|"; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"TX"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Text Data"; } }

        public string Description { get { return @"String data meant for user display (on a terminal or printer). Such data would not necessarily be left justified since leading spaces may contribute greatly to the clarity of the presentation to the user. Because this type of data is intended for display, it may contain certain escape character sequences designed to control the display. Escape sequence formatting is defined in Section 2.7, ""Use of escape sequences in text fields"". Leading spaces should be included. Trailing spaces should be removed.

Example:
|  leading spaces are allowed.|

Since TX data is intended for display purposes, the repeat delimiter, when used with a TX data field, implies a series of repeating lines to be displayed on a printer or terminal. Therefore, the repeat delimiters are regarded as paragraph terminators or hard carriage returns (e.g., they would display as though a CR/LF were inserted in the text (DOS type system) or as though a LF were inserted into the text (UNIX style system)).

A receiving system would word wrap the text between repeat delimiters in order to fit it into an arbitrarily sized display window but start any line beginning with a repeat delimiter on a new line.

To include alternative character sets, use the appropriate escape sequence. See Chapter 2, section 2.14.9.18, ""MSH-18 - Character Set"" and section 2.14.9.20, ""MSH-20 - Alternate Character Set Handling Scheme"".

This specification applies no limit to the length of the TX data type, either here where the data type is defined, or elsewhere where the data type is used. While there is no intrinsic reason to limit the length of this data type for semantic or syntactical reasons, it is expected that some sort of limitation will be imposed for technical reasons in implementations. HL7 recommends that implementation length limits be published in implementation profiles."; } }

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

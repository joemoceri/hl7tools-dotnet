using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataTypeIS
    {
        public string Id { get { return @"IS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded Value For User-defined Tables"; } }

        public string Description { get { return @"As of v2.7, the only approved use of the IS data type is in the HD.1, EI.2 and PL.6 plus a limited number of fields where a determination could not readily be made as to whether the item is an identifier or an actual coded item. Additionally, in accordance with chapter 2 rules, any field or data type component marked as ""Retained for backward compatibility"" will retain any IS data type.

The value of such a field follows the formatting rules for a ST field except that it is drawn from a site-defined (or user-defined) table of legal values. There shall be an HL7 table number associated with IS data types. An example of an IS field is the Event reason code defined in Chapter 3, ""Patient Administration"", section 3.4.1.4, ""Event reason code"". This data type should be used only for user-defined tables (see Chapter 2C, ""Code Tables"", section 2.C.1.1, ""User-defined Tables""). The reverse is not true, since in some circumstances, it is more appropriate to use the CWE data type for user-defined tables.

It is never acceptable to truncate an IS value."; } }

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

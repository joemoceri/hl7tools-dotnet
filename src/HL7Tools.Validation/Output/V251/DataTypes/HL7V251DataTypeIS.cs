using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeIS
    {
        public string Id { get { return @"IS"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded value for user-defined tables"; } }

        public string Description { get { return @"The value of such a field follows the formatting rules for a ST field except that it is drawn from a site-defined (or user-defined) table of legal values. There shall be an HL7 table number associated with IS data types. An example of an IS field is the Event reason code defined in Section 3.3.1.4, ""Event reason code"". This data type should be used only for user-defined tables (see Section 2.5.3.6 - Table). The reverse is not true, since in some circumstances, it is more appropriate to use the CWE data type for user-defined tables."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 20; } }

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

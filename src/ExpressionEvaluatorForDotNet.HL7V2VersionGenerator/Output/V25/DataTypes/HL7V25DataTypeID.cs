using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25DataType
    {
        public string Id { get { return @"ID"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded values for HL7 tables"; } }

        public string Description { get { return @"The value of such a field follows the formatting rules for an ST field except that it is drawn from a table of legal values. There shall be an HL7 table number associated with ID data types. An example of an ID field is OBR-25-result status. This data type should be used only for HL7 tables (see Section 2.5.3.6 -Table). The reverse is not true, since in some circumstances it is more appropriate to use the CNE or CWE data type for HL7 tables."; } }

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

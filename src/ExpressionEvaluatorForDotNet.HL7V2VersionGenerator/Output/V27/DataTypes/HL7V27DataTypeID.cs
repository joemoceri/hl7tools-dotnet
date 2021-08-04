using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"ID"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Coded Value For Hl7 Defined Tables"; } }

        public string Description { get { return @"The value of such a field follows the formatting rules for an ST field except that it is drawn from a table of legal values. There shall be an HL7 table number associated with ID data types. An example of an ID field is OBR-25 Result Status. This data type should be used only for HL7 tables (see Chapter 2C, section 2.C.1.2, ""HL7 Tables""). The reverse is not true, since in some circumstances it is more appropriate to use the CNE or CWE data type for HL7 tables.

The minimum and maximum lengths are specified in the context in which the ID data type is used. The longest HL7 defined legal value is 15 characters, but there are a few circumstances where the legal values are taken from code systems defined by other bodies (such as IANA mime types). In these cases, a different conformance length may be specified where the ID data type is used. It is never acceptable to truncate an ID value."; } }

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

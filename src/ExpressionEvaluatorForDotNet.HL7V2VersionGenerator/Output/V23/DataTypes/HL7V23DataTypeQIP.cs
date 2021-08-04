using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"QIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Input Parameter List"; } }

        public string Description { get { return @"Definition:  This field contains the list of parameter names and values to be passed to the stored procedure"; } }

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
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QIP.1",
                            Type = @"DataTypeComponent",
                            Position = @"QIP.1",
                            Name = @"Field Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field name.

Field naming conventions:
Fields are designated by the “@” symbol concatenated with the HL7 item number for the field.  If the field is divided into components, the designation may be suffixed with “.nn,” to identify a particular component (a suffix of “.3” indicates the third component of the field); otherwise, the whole field is assumed.  If the field is further divided into subcomponents, the designation is suffixed with “.nn.mm,” which identifies the component and subcomponent requested by relative position.

Site-specific fields may be used, provided that they begin with the letter “Z.” In this case, site-specific item numbers must be defined that do not conflict with existing HL7 item numbers.

Values for this field are defined in the function-specific chapters of this specification. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"QIP.2",
                            Name = @"Value1&value2&value3",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form “value1& value2 & value3 …”

A single valued parameter contains only a single subcomponent in the second component:  thus no subcomponent delimiters are needed (e.g., <field name> ^ <value>).  A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: ,”<field name> ^ <value1 & value2 &…>” ",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

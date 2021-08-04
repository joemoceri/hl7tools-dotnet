using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataType
    {
        public string Id { get { return @"QIP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Input Parameter List"; } }

        public string Description { get { return @"This data type contains a segment field name and the list of values to be passed to the query processor. 

Example:
|@PID.5.1^EVANS|"; } }

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
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the segment field name.

Naming conventions:
Segment field names are designated by the “@” symbol concatenated with the HL7 segment ID followed by the sequence number for the field separated by a period. See sections 2.5.2, ""Segments and segment groups"" and 2.5.3.1, ""Position (sequence within the segment)"" for a definition of segment ID and sequence number. If the field is divided into components, the designation may be suffixed with "".nn"", to identify a particular component (a suffix of “.3” indicates the third component of the field); otherwise, the whole field is assumed. If the field is further divided into subcomponents, the designation is suffixed with “.nn.mm"", which identifies the component and subcomponent requested by relative position.

Site-specific segment field names may be used. In this case, the site-specific segment ID (if the field is not being added to an existing HL7 segment) and the sequence number must be defined so that they do not conflict with existing HL7 segment IDs and field sequence numbers.
Values for this field are defined in the function-specific chapters of this specification.

Note: If the “@” is being used as one of the delimiter characters defined in MSH-2-encoding characters, it must be “escaped.”  See Section 2.7.1, ""Formatting Codes"".",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QIP.2",
                            Type = @"DataTypeComponent",
                            Position = @"QIP.2",
                            Name = @"Values",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form ""value1& value2 & value3...""

A single-valued parameter contains only a single subcomponent in the second component, thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>). A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter (e.g., <segment field name> ^ <value1 & value2 &...>).",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

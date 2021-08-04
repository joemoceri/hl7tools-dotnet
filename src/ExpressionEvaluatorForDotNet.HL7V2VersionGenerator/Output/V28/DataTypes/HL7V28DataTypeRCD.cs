using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28DataType
    {
        public string Id { get { return @"RCD"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Row Column Definition"; } }

        public string Description { get { return @"This specifies the format of a column in terms of a segment field name, a data type, and a maximum length.

Example: This defines a column containing the value of the ""last name"" component of PID-5, expressed as a ST data type with a maximum width of 20.
|@PID.5.1^ST^20|"; } }

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
                            Id = @"RCD.1",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HL7 segment field name, which identifies the field occupying the column

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
                            Id = @"RCD.2",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.2",
                            Name = @"Hl7 Data Type",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0440",
                            TableName = @"Data Types",
                            Description = @"The two or three character HL7 data type. Refer to HL7 Table 0440 – Data Types for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RCD.3",
                            Type = @"DataTypeComponent",
                            Position = @"RCD.3",
                            Name = @"Maximum Column Width",
                            Length = 5,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum width of the column, as dictated by the responding system. This may vary from the HL7-defined maximum field length.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

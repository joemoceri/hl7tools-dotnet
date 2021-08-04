using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27DataType
    {
        public string Id { get { return @"QSC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Selection Criteria"; } }

        public string Description { get { return @"This field indicates the conditions that qualify the rows to be returned in the query response. Note that this field conveys the same information as the ""WHERE"" clause in the corresponding SQL expression of the query, but is formatted differently.

Example:
|@PID.5.1^EQ^EVANS|"; } }

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
                            Id = @"QSC.1",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.1",
                            Name = @"Segment Field Name",
                            Length = 0,
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
                            Id = @"QSC.2",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.2",
                            Name = @"Relational Operator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0209",
                            TableName = @"Relational Operator",
                            Description = @"Refer to HL7 Table 0209 - Relational Operator for valid values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.3",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.3",
                            Name = @"Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The value to which the field will be compared.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.4",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.4",
                            Name = @"Relational Conjunction",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0210",
                            TableName = @"Relational Conjunction",
                            Description = @"Refer to HL7 Table 0210 - Relational Conjunction for valid values. The relational conjunction is defined as follows: If more than one comparison is to be made to select qualifying rows, a conjunction relates this repetition of the field to the next.
 - When applied to strings, the relational operators LT, GT, LE, and GE imply an alphabetic comparison.
 - A ""generic"" comparison selects a record for inclusion in the response when the beginning of the designated field matches the select string.
 - Where a repeating field is specified as an operand, a match on any instance of that field qualifies the row for inclusion in the response message. - AND takes precedence over OR. More sophisticated precedence rules require that the query be expressed as an embedded query language message or a stored procedure query message (see Chapter 5, ""Query"").",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

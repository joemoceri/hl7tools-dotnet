using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataType
    {
        public string Id { get { return @"QSC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Query Selection Criteria"; } }

        public string Description { get { return @"This field indicates the conditions that qualify the rows to be returned in the query response.  (This field conveys the same information as the “WHERE” clause in the corresponding SQL expression of the query, but is formatted differently.) "; } }

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
                            Name = @"Name Of Field",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the field that is participating as a qualifier (usually the “key”).  Refer to Section 2.8.30, “QIP - query input parameter list,” for field naming conventions",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.2",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.2",
                            Name = @"Relational Operator",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0209",
                            TableName = @"Relational operator",
                            Description = null,
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
                            Description = @"The value to which the field will be compared",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QSC.4",
                            Type = @"DataTypeComponent",
                            Position = @"QSC.4",
                            Name = @"Relational Conjunction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0210",
                            TableName = @"Relational conjunction",
                            Description = @"Refer to HL7 table 0102 - Relation conjunction for valid values.  The relational conjunction, defined as follows: If more than one comparison is to be made to select qualifying rows, a conjunction relates this repetition of the field to the next.

- When applied to strings, the relational operators LT, GT, LE, and GE imply an alphabetic comparison.

- A “generic” comparison selects a record for inclusion in the response when the beginning of the designated field matches the select string. 

- Where a repeating field is specified as an operand, a match on any instance of that field qualifies the row for inclusion in the response message.

- AND takes precedence over OR.  More sophisticated precedence rules require that the query be expressed as an embedded query language message or a stored procedure query message (see Section 2.19, “ENHANCED MODE QUERY MESSAGES,” and also Sections 2.24.16, “EQL - embedded query language segment,” and 2.24.20, “SPR - stored procedure request definition segment.”",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

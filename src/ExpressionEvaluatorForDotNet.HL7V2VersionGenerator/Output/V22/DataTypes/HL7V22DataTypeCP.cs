using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22DataType
    {
        public string Id { get { return @"CP"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Composite Price"; } }

        public string Description { get { return @"Example:
|100.00&USD^UP^0^9^min^P~50.00&USD^UP^10^59^min^P~10.00&USD^UP^60^999^P ~50.00&USD^AP~200.00&USD^PF~80.00&USD^DC|"; } }

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
                            Id = @"CP.1",
                            Type = @"DataTypeComponent",
                            Position = @"CP.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. ",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.2",
                            Type = @"DataTypeComponent",
                            Position = @"CP.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type ID.  Refer to HL7 table 0205 - Price type for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.3",
                            Type = @"DataTypeComponent",
                            Position = @"CP.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is an NM data type; together they specify the “range.”  The range can be defined as either time or quantity.  For example, the range can indicate that the first 10 minutes of the procedure has one price.  Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.4",
                            Type = @"DataTypeComponent",
                            Position = @"CP.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See From value",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.5",
                            Type = @"DataTypeComponent",
                            Position = @"CP.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (e.g., count); it is required if <from value> and  <to value> are present",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CP.6",
                            Type = @"DataTypeComponent",
                            Position = @"CP.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Refers to HL7 table 0298 - CP range type for valid values",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

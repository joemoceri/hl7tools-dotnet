using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"FC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Financial Class"; } }

        public string Description { get { return null; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 45; } }

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
                            Id = @"FC.1",
                            Type = @"DataTypeComponent",
                            Position = @"FC.1",
                            Name = @"Financial Class Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0064",
                            TableName = @"Financial class",
                            Description = @"This component contains the financial class assigned to a person. User-defined Table 0064 - Financial class is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"FC.2",
                            Type = @"DataTypeComponent",
                            Position = @"FC.2",
                            Name = @"Effective Date",
                            Length = 24,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the effective date/time of the persons assignment to the financial class specified in the first component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

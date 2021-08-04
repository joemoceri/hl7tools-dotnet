using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23DataTypeRI
    {
        public string Id { get { return @"RI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Repeat Interval"; } }

        public string Description { get { return @"This field contains the interval between repeating appointments.  The default setting indicates that the appointment should occur once, when the component is not valued.  The definition of this field is equivalent to the definition of the Interval component of the Quantity/Timing field given in Chapter 4, Section 4.4.2 “Interval component (CM).” "; } }

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
                            Id = @"RI.1",
                            Type = @"DataTypeComponent",
                            Position = @"RI.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The first component is defined by user-defined table 0335 - Repeat pattern. See Section  4.4.2.1 “Repeat pattern,”  for further details",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RI.2",
                            Type = @"DataTypeComponent",
                            Position = @"RI.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution. See Section 4.4.2.2, “Explicit time interval subcomponent,” for further details.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

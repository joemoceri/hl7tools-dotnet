using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26DataType
    {
        public string Id { get { return @"RI"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Repeat Interval"; } }

        public string Description { get { return @"contains the interval between repeated services."; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 206; } }

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
                            Length = 6,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The repeating frequency with which the treatment is to be administered. It is similar to the frequency and SIG code tables used in order entry systems.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RI.2",
                            Type = @"DataTypeComponent",
                            Position = @"RI.2",
                            Name = @"Explicit Time Interval",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component explicitly lists the actual times referenced by the code in the first component, in the following format: HHMM,HHMM,HHMM,.... This second component will be used to clarify the first component in cases where the actual times vary within an institution. If the time of the order spans more than a single day, this new component is only practical if the same times of administration occur for each day of the order. If the actual start time of the order (as given by the fourth component of the quantity/timing field) is after the first explicit time, the first administration is taken to be the first explicit time after the start time. In the case where the patient moves to a location having a different set of explicit times, the existing order may be updated with a new quantity/timing field showing the changed explicit times.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

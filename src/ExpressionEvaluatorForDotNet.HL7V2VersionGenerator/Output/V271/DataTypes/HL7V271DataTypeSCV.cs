using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271DataTypeSCV
    {
        public string Id { get { return @"SCV"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Scheduling Class Value Pair"; } }

        public string Description { get { return @"This data type is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot, resource, location, or filler override criterion for an appointment.

For use only with the scheduling chapter. "; } }

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
                            Id = @"SCV.1",
                            Type = @"DataTypeComponent",
                            Position = @"SCV.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded With Exceptions",
                            TableId = @"0294",
                            TableName = @"Time Selection Criteria Parameter Class Codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application. Refer to User-defined Table 0294 - Time Selection Criteria Parameter Class Codes for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SCV.2",
                            Type = @"DataTypeComponent",
                            Position = @"SCV.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter. 

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

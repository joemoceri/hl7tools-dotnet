using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231DataTypeSCV
    {
        public string Id { get { return @"SCV"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Scheduling Class Value Pair"; } }

        public string Description { get { return @"For use only with the scheduling chapter."; } }

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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0294",
                            TableName = @"Time selection criteria parameter class codes",
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application.",
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
                            Description = @"The second component is the actual data value for that parameter.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

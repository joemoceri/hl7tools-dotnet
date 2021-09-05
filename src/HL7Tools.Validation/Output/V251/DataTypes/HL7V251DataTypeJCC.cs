using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251DataTypeJCC
    {
        public string Id { get { return @"JCC"; } }

        public string Type { get { return @"DataType"; } }

        public string Name { get { return @"Job Code/Class"; } }

        public string Description { get { return @"Example 1: Codified job (where 1 represents the code for Administrator and F represents full time) |1^F^Administrator| 
Example 2: Uncodified job (where job codes are not codified and PT represents part time) |^PT^Analyst|. "; } }

        public string DataType { get { return null; } }

        public string DataTypeName { get { return null; } }

        public int Length { get { return 292; } }

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
                            Id = @"JCC.1",
                            Type = @"DataTypeComponent",
                            Position = @"JCC.1",
                            Name = @"Job Code",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code",
                            Description = @"This component contains the persons job code. User-defined Table 0327 - Job code is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"JCC.2",
                            Type = @"DataTypeComponent",
                            Position = @"JCC.2",
                            Name = @"Job Class",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the persons employee classification. Refer to User-defined Table 0328 - Employee classification for suggested values.",
                            Sample = null,
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"JCC.3",
                            Type = @"DataTypeComponent",
                            Position = @"JCC.3",
                            Name = @"Job Description Text",
                            Length = 250,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the text of the job description. This will accommodate systems where job descriptions are not codified.",
                            Sample = null,
                            FieldDatas = null
                        },
                        };
            }
        }
    }
}

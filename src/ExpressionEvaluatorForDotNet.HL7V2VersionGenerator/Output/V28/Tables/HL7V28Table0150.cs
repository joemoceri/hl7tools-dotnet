using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0150
    {
        public string Id { get { return @"0150"; } }

        public string TableId { get { return @"0150"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Certification Patient Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"ER",
                            Description = @"Emergency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IPE",
                            Description = @"Inpatient elective",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OPE",
                            Description = @"Outpatient elective",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Urgent",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

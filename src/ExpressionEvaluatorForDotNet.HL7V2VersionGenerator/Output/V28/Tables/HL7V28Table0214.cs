using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0214
    {
        public string Id { get { return @"0214"; } }

        public string TableId { get { return @"0214"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Special Program Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"CH",
                            Description = @"Child Health Assistance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ES",
                            Description = @"Elective Surgery Program",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FP",
                            Description = @"Family Planning",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

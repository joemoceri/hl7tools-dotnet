using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0424
    {
        public string Id { get { return @"0424"; } }

        public string TableId { get { return @"0424"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Gestation Category Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"1",
                            Description = @"Premature / Pre-term",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Full Term",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Overdue / Post-term",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

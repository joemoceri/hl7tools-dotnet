using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0422
    {
        public string Id { get { return @"0422"; } }

        public string TableId { get { return @"0422"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Triage Code"; } }

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
                            Description = @"Non-acute",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Acute",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Urgent",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Severe",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"Dead on Arrival (DOA)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"99",
                            Description = @"Other",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

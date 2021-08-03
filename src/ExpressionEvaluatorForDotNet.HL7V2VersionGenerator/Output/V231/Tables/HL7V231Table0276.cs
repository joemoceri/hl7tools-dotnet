using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0276
    {
        public string Id { get { return @"0276"; } }

        public string TableId { get { return @"0276"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Appointment reason codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",
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
                            Value = @"Checkup",
                            Description = @"A routine check-up, such as an annual physical",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Emergency",
                            Description = @"Emergency appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Followup",
                            Description = @"A follow up visit from a previous appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Routine",
                            Description = @"Routine appointment - default if not valued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Walkin",
                            Description = @"A previously unscheduled walk-in visit",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

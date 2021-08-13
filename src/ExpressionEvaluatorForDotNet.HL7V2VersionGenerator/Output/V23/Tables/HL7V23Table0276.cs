using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0276
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
                            Value = @"CHECKUP",
                            Description = @"A routine check-up such as an annual physical.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EMERGENCY",
                            Description = @"Emergency appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FOLLOWUP",
                            Description = @"A follow up visit from a previous appointment.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ROUTINE",
                            Description = @"Routine appointment - default if not valued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WALKIN",
                            Description = @"A previously unscheduled walk-in visit",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0277
    {
        public string Id { get { return @"0277"; } }

        public string TableId { get { return @"0277"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Appointment type codes"; } }

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
                            Value = @"COMPLETE",
                            Description = @"A request to add a completed appointment, used to maintain records of completed appointments that did not appear in the schedule (e.g., STAT, w alk-in, etc.)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NORMAL",
                            Description = @"Routine schedule request type - default if not valued",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TENTATIVE",
                            Description = @"A request for a tentative (e.g., “penciled in”) appointment",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

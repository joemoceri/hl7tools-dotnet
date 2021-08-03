using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0472
    {
        public string Id { get { return @"0472"; } }

        public string TableId { get { return @"0472"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"TQ Conjunction ID"; } }

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
                            Value = @"A",
                            Description = @"Asynchronous",
                            Comment = @"Do the next specification in parallel with this one (unless otherwise constrained by the following fields: TQ1-7-start date/time and TQ1-8-end date/time). The conjunction of ""A"" specifies two parallel instructions, as are sometimes used in medication, e.g., prednisone given at 1 tab on Monday, Wednesday, Friday, and at 1/2 tab on Tuesday, Thursday, Saturday, Sunday."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Actuation Time",
                            Comment = @"It will be followed by a completion time for the service. This code allows one to distinguish between the time and priority at which a service should be actuated (e.g., blood should be drawn) and the time and priority at which a service should be completed (e.g., results should be reported)."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Synchronous",
                            Comment = @"Do the next specification after this one (unless otherwise constrained by the following fields: TQ1-7-start date/time and TQ1-8-end date/time). An ""S"" specification implies that the second timing sequence follows the first, e.g., when a service request is written to measure blood pressure Q15 minutes for the 1st hour, then every 2 hours for the next day."
                        },
                    };
            } 
        }
    }
}

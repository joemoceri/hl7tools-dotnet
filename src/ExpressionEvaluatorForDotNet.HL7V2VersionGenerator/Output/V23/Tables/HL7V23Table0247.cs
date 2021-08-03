using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0247
    {
        public string Id { get { return @"0247"; } }

        public string TableId { get { return @"0247"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Status of evaluation"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Description = @"Evaluation anticipated, but not yet begun",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Product received in condition which made analysis impossible",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Product discarded -- unable to follow up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Product remains implanted -- unable to follow up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"K",
                            Description = @"Problem already known, no evaluation necessary",
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
                            Value = @"P",
                            Description = @"Evaluation in progress",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q",
                            Description = @"Product under quarantine -- unable to follow up",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Product under recall/corrective action",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U",
                            Description = @"Product unavailable for follow up investigation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X",
                            Description = @"Product not made by company",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Y",
                            Description = @"Evaluation completed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

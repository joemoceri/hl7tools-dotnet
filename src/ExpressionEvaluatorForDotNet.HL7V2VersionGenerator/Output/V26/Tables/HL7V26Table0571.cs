using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0571
    {
        public string Id { get { return @"0571"; } }

        public string TableId { get { return @"0571"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Invoice Processing Results Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"ACK",
                            Description = @"Acknowledge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADJ",
                            Description = @"Adjudicated with Adjustments",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADJSUB",
                            Description = @"Adjudicated as Submitted",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ADJZER",
                            Description = @"Adjudicated to Zero",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PAID",
                            Description = @"Paid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PEND",
                            Description = @"Pending",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRED",
                            Description = @"Pre-Determination",
                            Comment = @"Indicates that the IPR has been adjudicated but will not be paid.  Equivalent to ADJUD (Adjudicate)"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REJECT",
                            Description = @"Reject",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0156
    {
        public string Id { get { return @"0156"; } }

        public string TableId { get { return @"0156"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Which date/time qualifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Value = @"ANY",
                            Description = @"Any date/time within a range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COL",
                            Description = @"Collection date/time, equivalent to film or sample collection date/time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ORD",
                            Description = @"Order date/time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RCT",
                            Description = @"Specimen receipt date/time, receipt of specimen in filling ancillary (Lab)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REP",
                            Description = @"Report date/time, report date/time at filing ancillary (i.e., Lab)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SCHED",
                            Description = @"Schedule date/time",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0906
    {
        public string Id { get { return @"0906"; } }

        public string TableId { get { return @"0906"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ActPriority"; } }

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
                            Description = @"ASAP - As soon as possible, next highest priority after stat",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CR",
                            Description = @"Callback results - filler should contact the placer as soon as results are available, even for preliminary results",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CS",
                            Description = @"Callback for scheduling - Filler should contact the placer (or target) to schedule the service.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSP",
                            Description = @"Callback placer for scheduling - filler should contact the placer to schedule the service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CSR",
                            Description = @"Contact recipient for scheduling - Filler should contact the service recipient (target) to schedule the service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EL",
                            Description = @"Elective - Beneficial to the patient but not essential for survival.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EM",
                            Description = @"Emergency - An unforeseen combination of circumstances or the resulting state that calls for immediate action",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preop - Used to indicate that a service is to be performed prior to a scheduled surgery.  When ordering a service and using the pre-op priority, a check is done to see the amount of time that must be allowed for performance of the service.  When the order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"As needed - An ""as needed"" order should be accompanied by a description of what constitutes a need.  This description is represented by an observation service predicate as a precondition.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Routine - Routine service, do at usual work hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RR",
                            Description = @"Rush reporting - A report should be prepared and sent as quickly as possible",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat - With highest priority (e.g. emergency).",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Timing critical - It is critical to come as close as possible to the requested time (e.g. for a through antimicrobial level).",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UD",
                            Description = @"Use as directed - Drug is to be used as directed by the prescriber.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UR",
                            Description = @"Urgent - Calls for prompt action",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

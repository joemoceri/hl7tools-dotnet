using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0252
    {
        public string Id { get { return @"0252"; } }

        public string TableId { get { return @"0252"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Causality Observations"; } }

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
                            Value = @"AW",
                            Description = @"Abatement of event after product withdrawn",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BE",
                            Description = @"Event recurred after product reintroduced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DR",
                            Description = @"Dose response observed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EX",
                            Description = @"Alternative explanations for the event available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Event occurred after product introduced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LI",
                            Description = @"Literature reports association of product with event",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OE",
                            Description = @"Occurrence of event was confirmed by objective evidence",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OT",
                            Description = @"Other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PL",
                            Description = @"Effect observed when patient receives placebo",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SE",
                            Description = @"Similar events in past for this patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TC",
                            Description = @"Toxic levels of product documented in blood or body fluids",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

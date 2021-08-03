using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0725
    {
        public string Id { get { return @"0725"; } }

        public string TableId { get { return @"0725"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Mood Codes"; } }

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
                            Value = @"APT",
                            Description = @"Appointment",
                            Comment = @"Planned act for specific time and place"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ARQ",
                            Description = @"Appointment Request",
                            Comment = @"Request for Booking of an Appointment"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EVN",
                            Description = @"Event",
                            Comment = @"Service actually happens or happened or is ongoing."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EVN.CRT",
                            Description = @"Event Criterion",
                            Comment = @"Criterion applying to Events for another Service to be applied."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXP",
                            Description = @"Expectation",
                            Comment = @"Expecting that something will occur independently of deliberate intent. Eg expect a patient will discard medications."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INT",
                            Description = @"Intent",
                            Comment = @"Plan to perform a service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRMS",
                            Description = @"Promise",
                            Comment = @"An intent to perform a service"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRP",
                            Description = @"Proposal",
                            Comment = @"Non-mandated intent to perform an act"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQO",
                            Description = @"Request-Order",
                            Comment = @"Request or Order for a service"
                        },
                    };
            } 
        }
    }
}

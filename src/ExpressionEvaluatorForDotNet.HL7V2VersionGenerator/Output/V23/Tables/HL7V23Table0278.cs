using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0278
    {
        public string Id { get { return @"0278"; } }

        public string TableId { get { return @"0278"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Filler status codes"; } }

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
                            Value = @"BLOCKED",
                            Description = @"The indicated time slot(s) is(are) blocked. Not used in the AIS,  AIG,  AIL,  AIP segments.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BOOKED",
                            Description = @"The indicated appointment is booked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CANCELLED",
                            Description = @"The indicated appointment was stopped from occurring (cancelled prior to starting)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"COMPLETE",
                            Description = @"The indicated appointment has completed normally (was not discontinued, canceled, or deleted)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DC",
                            Description = @"The indicated appointment was discontinued (DCed while in progress, discontinued parent appointment,  or discontinued child appointment)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DELETED",
                            Description = @"The indicated appointment was deleted from the filler application",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OVERBOOK",
                            Description = @"The appointment has been confirmed; however it is confirmed in an overbooked state",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PENDING",
                            Description = @"Appointment has not yet been confirmed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"STARTED",
                            Description = @"The indicated appointment has begun and is currently in progress",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WAITLIST",
                            Description = @"Appointment has been placed on a waiting list for a particular slot, or set of slots",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

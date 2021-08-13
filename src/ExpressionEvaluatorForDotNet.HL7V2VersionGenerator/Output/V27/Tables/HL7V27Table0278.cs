using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0278
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
                            Value = @"Blocked",
                            Description = @"The indicated time slot(s) is(are) blocked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Booked",
                            Description = @"The indicated appointment is booked",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Cancelled",
                            Description = @"The indicated appointment was stopped from occurring (canceled prior to starting)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Complete",
                            Description = @"The indicated appointment has completed normally (was not discontinued, canceled, or deleted)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Dc",
                            Description = @"The indicated appointment was discontinued (DC'ed while in progress, discontinued parent appointment, or discontinued child appointment)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Deleted",
                            Description = @"The indicated appointment was deleted from the filler application",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Noshow",
                            Description = @"The patient did not show up for the appointment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Overbook",
                            Description = @"The appointment has been confirmed; however it is confirmed in an overbooked state",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Pending",
                            Description = @"Appointment has not yet been confirmed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Started",
                            Description = @"The indicated appointment has begun and is currently in progress",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Waitlist",
                            Description = @"Appointment has been placed on a waiting list for a particular slot, or set of slots",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0294
    {
        public string Id { get { return @"0294"; } }

        public string TableId { get { return @"0294"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Time selection criteria parameter class codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
                            Value = @"FRI",
                            Description = @"An indicator that Friday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MON",
                            Description = @"An indicator that Monday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PREFEND",
                            Description = @"The preferred end time for the appointment request, service or resource. Any legal time specification in the format HHMM, using 24-hour clock notation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PREFSTART",
                            Description = @"The preferred start time for the appointment request, service or resource. Any legal time specification in the format HHMM, using 24-hour clock notation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SAT",
                            Description = @"An indicator that Saturday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUN",
                            Description = @"An indicator that Sunday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"THU",
                            Description = @"An indicator that Thursday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TUE",
                            Description = @"An indicator that Tuesday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WED",
                            Description = @"An indicator that Wednesday is or is not preferred for the day on which the appointment will occur. OK = Preferred appointment day NO = Day is not preferred",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0335
    {
        public string Id { get { return @"0335"; } }

        public string TableId { get { return @"0335"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Repeat pattern"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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
                            Description = @"Ante (before)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BID",
                            Description = @"twice a day at institution-specified times (e.g., 9AM-4PM)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"service is provided continuously between start time and stop time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Cibus Diurnus (lunch)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inter (e.g., between this meal and the next, between dinner and sleep",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Cibus Matutinus (breakfast)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Meal Related Timings",
                            Description = @"<timing>C (“cum”)<meal>",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Once",
                            Description = @"one time only.  This is also the default when this component is null.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Post (after)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRN",
                            Description = @"given as needed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRNxxx",
                            Description = @"where xxx is some frequency code (e.g., PRNQ6H); given as needed over the frequency period.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>D",
                            Description = @"every <integer> days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>H",
                            Description = @"every <integer> hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>J<day#>",
                            Description = @"repeats on a particular day of the week, from the French jour (day).  If <integer> is missing, the repeat rate is assumed to be 1.  Day numbers are counted from 1=Monday to 7=Sunday.  So Q2J2 means every second Tuesday; Q1J6 means every Saturday.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>L",
                            Description = @"every <integer> months (Lunar cycle)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>M",
                            Description = @"every <integer> minutes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>S",
                            Description = @"every <integer> seconds",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Q<integer>W",
                            Description = @"every <integer> weeks",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QAM",
                            Description = @"in the morning at institution-specified time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QHS",
                            Description = @"every day before the hour of sleep",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QID",
                            Description = @"four times a day at institution-specified times (e.g., 9AM-11AM-4PM-9PM)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QOD",
                            Description = @"every other day (same as Q2D)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QPM",
                            Description = @"in the evening at institution-specified time",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"QSHIFT",
                            Description = @"during each of three eight-hour shifts at institution-specified times",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TID",
                            Description = @"three times a day at institution-specified times (e.g., 9AM-4PM-9PM)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"U <spec>",
                            Description = @"for future use, where <spec> is an interval specification as defined by the UNIX cron specification.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Cibus Vespertinus (dinner)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"xID",
                            Description = @"“X” times per day at institution-specified times, where X is a numeral 5 or greater.  E.g., 5ID=five times per day; 8ID=8 times per day",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

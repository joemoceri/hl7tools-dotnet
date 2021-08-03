using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0458
    {
        public string Id { get { return @"0458"; } }

        public string TableId { get { return @"0458"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"OCE Edit Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"…",
                            Description = null,
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Invalid diagnosis code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Non-covered  service submitted for verification of denial (condition code 21 from header information on claim)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Non-covered service submitted for FI review (condition code 20 from header information on claim)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"Questionable covered service",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"Additional payment for service not provided by Medicare",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"Code indicates a site of service not included in OPPS",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"Service unit out of range for procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"Multiple bilateral procedures without modifier 50 (see Appendix A)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Multiple bilateral procedures with modifier 50 (see Appendix A)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"Inpatient procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"Mutually exclusive procedure that is not allowed even if appropriate modifier present",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Diagnosis and age conflict",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"Component of a comprehensive procedure that is not allowed even if appropriate modifier present",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"Medical visit on same day as a type ""T"" or ""S"" procedure without modifier 25 (see Appendix B)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"Invalid modifier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"23",
                            Description = @"Invalid date",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"Date out of OCE range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"25",
                            Description = @"Invalid age",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"Invalid sex",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"Only incidental services reported",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"Code not recognized by Medicare; alternate code for same service available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"Partial hospitalization service for non-mental health diagnosis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Diagnosis and sex conflict",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"Insufficient services on day of partial hospitalization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Partial hospitalization on same day as ECT or type ""T"" procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"Partial hospitalization claim spans 3 or less days with in-sufficient services, or ECT or significant procedure on at least one of the days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"Partial hospitalization claim spans more than 3 days with insufficient number of days having mental health services",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"Partial hospitalization claim spans more than 3 days with insufficient number of days meeting partial hospitalization criteria",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"35.",
                            Description = @"Only activity therapy and/or occupational therapy services provided",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36.",
                            Description = @"Extensive mental health services provided on day of ECT or significant procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"Terminated bilateral procedure or terminated procedure with units greater than one",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38.",
                            Description = @"Inconsistency between implanted device and implantation procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39.",
                            Description = @"Mutually exclusive procedure that would be allowed if appropriate modifier were present",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Medicare secondary payer alert",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40.",
                            Description = @"Component of a comprehensive procedure that would be allowed if appropriate modifier were present",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41.",
                            Description = @"Invalid revenue code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42.",
                            Description = @"Multiple medical visits on same day with same revenue code without condition code G0 (see Appendix B)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"E-code as reason for visit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"Invalid procedure code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"7",
                            Description = @"Procedure and age conflict",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"8",
                            Description = @"Procedure and sex conflict",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"9",
                            Description = @"Nov-covered service",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

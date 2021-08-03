using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0112
    {
        public string Id { get { return @"0112"; } }

        public string TableId { get { return @"0112"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Discharge disposition"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Value = @"01",
                            Description = @"Discharged to home or self care (routine discharge)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Discharged/transferred to another short term general hospital for inpatient care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Discharged/transferred to skilled nursing facility (SNF)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Discharged/transferred to an intermediate care facility (ICF)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Discharged/transferred to another type of institution for inpatient care or referred for outpatient services to another institution",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"Discharged/transferred to home under care of organized home health service organization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"Left against medical advice or discontinued care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Discharged/transferred to home under care of Home IV provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Admitted as an inpatient to this hospital",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"Expired",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"23",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"25",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"Still patient or expected to return for outpatient services",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"35",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39",
                            Description = @"Still patient to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"Expired at home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"Expired in a medical facility; e.g., hospital, SNF, ICF, or free standing hospice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"Expired - place unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

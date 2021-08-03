using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0112
    {
        public string Id { get { return @"0112"; } }

        public string TableId { get { return @"0112"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Discharge Disposition"; } }

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
                            Value = @"10 …19",
                            Description = @"Discharge to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"Expired (i.e. dead)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21 ... 29",
                            Description = @"Expired to be defined at state level, if necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"Still patient or expected to return for outpatient services (i.e. still a patient)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31 … 39",
                            Description = @"Still patient to be defined at state level, if necessary  (i.e. still a patient)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"Expired (i.e. died) at home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"Expired (i.e. died) in a medical facility; e.g., hospital, SNF, ICF, or free standing hospice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"Expired (i.e. died)  - place unknown",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

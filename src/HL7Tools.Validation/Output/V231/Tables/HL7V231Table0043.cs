using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0043
    {
        public string Id { get { return @"0043"; } }

        public string TableId { get { return @"0043"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Condition code"; } }

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
                            Value = @"01",
                            Description = @"Military service related",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Condition is employment related",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Patient covered by insurance not reflected here",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"HMO enrollee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Lien has been filed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"ESRD patient in first 18 months of entitlement covered by employer group health insurance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"07",
                            Description = @"Treatment of non-terminal condition for hospice patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Beneficiary would not provide information concerning other insurance coverage",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Neither patient nor spouse is employed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Patient and/or spouse is employed but no EGHP exists",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Disabled beneficiary but no LGHP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12 ... 16",
                            Description = @"Payer codes.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"Maiden name retained",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"Child retains mother's name",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"Beneficiary requested billing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"Billing for Denial Notice",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"VA eligible patient chooses to receive services in a Medicare certified facility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"Patient referred to a sole community hospital for a diagnostic laboratory test",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"Patient and/or spouse's EGHP is secondary to Medicare",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"Disabled beneficiary and/or family member's LGHP is secondary to Medicare",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Patient is student (full time-day)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"Patient is student (cooperative/work study program)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"Patient is student (full time-night)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"Patient is student (Part time)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36",
                            Description = @"General care patient in a special unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"Ward accommodation as patient request",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38",
                            Description = @"Semi-private room not available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39",
                            Description = @"Private room medically necessary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"Same day transfer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"Partial hospitalization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"46",
                            Description = @"Non-availability statement on file",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"48",
                            Description = @"Psychiatric residential treatment centers for children and adolescents",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"55",
                            Description = @"SNF bed not available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"56",
                            Description = @"Medical appropriateness",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"57",
                            Description = @"SNF readmission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"60",
                            Description = @"Day outlier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"61",
                            Description = @"Cost outlier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"62",
                            Description = @"Payer code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"66",
                            Description = @"Provider does not wish cost outlier payment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"67",
                            Description = @"Beneficiary elects not to use life time reserve (LTR) days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"68",
                            Description = @"Beneficiary elects to use life time reserve (LTR) days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"70",
                            Description = @"Self-administered EPO",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"71",
                            Description = @"Full care in unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"72",
                            Description = @"Self-care in unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"73",
                            Description = @"Self-care training",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"74",
                            Description = @"Home",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"75",
                            Description = @"Home - 100% reimbursement",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"76",
                            Description = @"Back-up in facility dialysis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"77",
                            Description = @"Provider accepts or is obligated/required due to a contractual arrangement or law to accept payment by a primary payer as payment in full",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"78",
                            Description = @"New coverage not implemented by HMO",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"79",
                            Description = @"Corf services provided off-site",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"80",
                            Description = @"Pregnant",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

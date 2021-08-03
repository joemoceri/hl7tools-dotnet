using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0153
    {
        public string Id { get { return @"0153"; } }

        public string TableId { get { return @"0153"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Value code"; } }

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
                            Value = @"01",
                            Description = @"Most common semi-private rate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"Hospital has no semi-private rooms",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Inpatient professional component charges which are combined billed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Professional component included in charges and also billed separate to carrier",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"Medicare blood deductible",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"08",
                            Description = @"Medicare life time reserve amount in the first calendar year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Medicare co-insurance amount in the first calendar year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Lifetime reserve amount in the second calendar year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Co-insurance amount in the second calendar year",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"Working aged beneficiary/spouse with employer group health plan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"13",
                            Description = @"ESRD beneficiary in a Medicare coordination period with an employer group health plan",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"14",
                            Description = @"No Fault including auto/other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"15",
                            Description = @"Worker's Compensation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"16",
                            Description = @"PHS, or other federal agency",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Payer code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"Catastrophic",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"Surplus",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"23",
                            Description = @"Recurring monthly incode",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"Medicaid rate code",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"Pre-admission testing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Patient liability amount",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"Pints of blood furnished",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"38",
                            Description = @"Blood deductible pints",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"39",
                            Description = @"Pints of blood replaced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"New coverage not implemented by HMO (for inpatient service only)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"Black lung",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"VA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"43",
                            Description = @"Disabled beneficiary under age 64 with LGHP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"44",
                            Description = @"Amount provider agreed to accept from primary payer when this amount is less than charges but higher than payment received,, then a Medicare secondary payment is due",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"45",
                            Description = @"Accident hour",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"46",
                            Description = @"Number of grace days",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"47",
                            Description = @"Any liability insurance",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"48",
                            Description = @"Hemoglobin reading",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"49",
                            Description = @"Hematocrit reading",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"50",
                            Description = @"Physical therapy visits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"51",
                            Description = @"Occupational therapy visits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"52",
                            Description = @"Speech therapy visits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"53",
                            Description = @"Cardiac rehab visits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"56",
                            Description = @"Skilled nurse - home visit hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"57",
                            Description = @"Home health aide - home visit hours",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"58",
                            Description = @"Arterial blood gas",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"59",
                            Description = @"Oxygen saturation",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"60",
                            Description = @"HHA branch MSA",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"67",
                            Description = @"Peritoneal dialysis",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"68",
                            Description = @"EPO-drug",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"70 ... 72",
                            Description = @"Payer codes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"75 ... 79",
                            Description = @"Payer codes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"80",
                            Description = @"Psychiatric visits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"81",
                            Description = @"Visits subject to co-payment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A1",
                            Description = @"Deductible payer A",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A2",
                            Description = @"Coinsurance payer A",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A3",
                            Description = @"Estimated responsibility payer A",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X0",
                            Description = @"Service excluded on primary policy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"X4",
                            Description = @"Supplemental coverage",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

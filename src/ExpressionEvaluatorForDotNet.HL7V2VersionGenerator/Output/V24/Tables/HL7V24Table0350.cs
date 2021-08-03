using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0350
    {
        public string Id { get { return @"0350"; } }

        public string TableId { get { return @"0350"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Occurrence code"; } }

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
                            Description = @"Auto accident",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"02",
                            Description = @"No fault insurance involved-including auto accident/other",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"03",
                            Description = @"Accident/tort liability",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"04",
                            Description = @"Accident/employment related",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"05",
                            Description = @"Other accident",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"06",
                            Description = @"Crime victim",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"09",
                            Description = @"Start of infertility treatment cycle",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"10",
                            Description = @"Last menstrual period",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"11",
                            Description = @"Onset of symptoms/illness",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"12",
                            Description = @"Date of onset for a chronically dependent individual",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"17",
                            Description = @"Date outpatient occupational therapy plan established or last reviewed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"18",
                            Description = @"Date of retirement patient/beneficiary",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"19",
                            Description = @"Date of retirement spouse",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"20",
                            Description = @"Guarantee of payment began",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"21",
                            Description = @"UR notice received",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"22",
                            Description = @"Date active care ended",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"24",
                            Description = @"Date insurance denied",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"25",
                            Description = @"Date benefits terminated by primary payor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"26",
                            Description = @"Date SNF bed available",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"27",
                            Description = @"Date home health plan established",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"28",
                            Description = @"Spouse’s date of birth",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"29",
                            Description = @"Date outpatient physical therapy plan established or last reviewed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"30",
                            Description = @"Date outpatient speech pathology plan established or last reviewed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Date beneficiary notified of intent to bill (accommodations)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"32",
                            Description = @"Date beneficiary notified of intent to bill (procedures or treatments)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"33",
                            Description = @"First day of the Medicare coordination period for ESRD beneficiaries covered by EGHP",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"34",
                            Description = @"Date of election of extended care facilities",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"35",
                            Description = @"Date treatment started for P.T.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"36",
                            Description = @"Date of inpatient hospital discharge for covered transplant patients",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"37",
                            Description = @"Date of inpatient hospital discharge for non-covered transplant patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"40",
                            Description = @"Scheduled date of admission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"41",
                            Description = @"Date of first test for pre-admission testing",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"42",
                            Description = @"Date of discharge",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"43",
                            Description = @"Scheduled date of canceled surgery",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"44",
                            Description = @"Date treatment started for O.T.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"45",
                            Description = @"Date treatment started for S.T.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"46",
                            Description = @"Date treatment started for cardiac rehab.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"47 ... 49",
                            Description = @"Payer codes",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"50",
                            Description = @"Date lien released",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"51",
                            Description = @"Date treatment started for psychiatric care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"70 ... 99",
                            Description = @"Occurrence span codes and dates",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A1",
                            Description = @"Birthdate - insured A",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A2",
                            Description = @"Effective date - insured A policy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A3",
                            Description = @"Benefits exhausted payer A",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

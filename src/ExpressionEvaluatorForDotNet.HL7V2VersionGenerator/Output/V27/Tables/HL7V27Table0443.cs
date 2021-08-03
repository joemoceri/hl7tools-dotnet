using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0443
    {
        public string Id { get { return @"0443"; } }

        public string TableId { get { return @"0443"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Provider Role"; } }

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
                            Value = @"AD",
                            Description = @"Admitting",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AI",
                            Description = @"Assistant/Alternate Interpreter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AP",
                            Description = @"Administering Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AT",
                            Description = @"Attending",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CLP",
                            Description = @"Collecting Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CP",
                            Description = @"Consulting Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DP",
                            Description = @"Dispensing Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EP",
                            Description = @"Entering Provider (probably not the same as transcriptionist?)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FHCP",
                            Description = @"Family Health Care Professional",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IP",
                            Description = @"Initiating Provider (as in action by)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MDIR",
                            Description = @"Medical Director",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OP",
                            Description = @"Ordering Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PH",
                            Description = @"Pharmacist   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PI",
                            Description = @"Primary Interpreter",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PP",
                            Description = @"Primary Care Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RO",
                            Description = @"Responsible Observer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Referring Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RT",
                            Description = @"Referred to Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TN",
                            Description = @"Technician",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TR",
                            Description = @"Transcriptionist",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VP",
                            Description = @"Verifying Provider",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VPS",
                            Description = @"Verifying Pharmaceutical Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"VTS",
                            Description = @"Verifying Treatment Supplier   (not sure how to dissect Pharmacist/Treatment Supplier's Verifier ID)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

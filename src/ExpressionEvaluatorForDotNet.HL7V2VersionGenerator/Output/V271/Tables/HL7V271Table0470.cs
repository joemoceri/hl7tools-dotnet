using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0470
    {
        public string Id { get { return @"0470"; } }

        public string TableId { get { return @"0470"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Reimbursement Type Code"; } }

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
                            Value = @"Crnl",
                            Description = @"Corneal Tissue APC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DME",
                            Description = @"Durable Medical Equipment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EPO",
                            Description = @"Epotein",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Lab",
                            Description = @"Clinical Laboratory APC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Mamm",
                            Description = @"Screening Mammography APC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NoPay",
                            Description = @"This APC is not paid",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"OPPS",
                            Description = @"Outpatient Prospective Payment System",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PartH",
                            Description = @"Partial Hospitalization APC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Pckg",
                            Description = @"Packaged APC",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"Thrpy",
                            Description = @"Therapy APC",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

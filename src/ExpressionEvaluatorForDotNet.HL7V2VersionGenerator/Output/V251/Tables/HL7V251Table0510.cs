using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0510
    {
        public string Id { get { return @"0510"; } }

        public string TableId { get { return @"0510"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Blood Product Dispense Status"; } }

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
                            Value = @"CR",
                            Description = @"Released into inventory for general availability",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DS",
                            Description = @"Dispensed to patient location",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PT",
                            Description = @"Presumed transfused (dispensed and not returned)",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RA",
                            Description = @"Returned unused/no longer needed",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RD",
                            Description = @"Reserved and ready to dispense",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Released (no longer allocated for the patient)",
                            Comment = @"Status determined by Placer or Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RI",
                            Description = @"Received into inventory (for specified patient)",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RL",
                            Description = @"Returned unused/keep linked to patient for possible use later",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RQ",
                            Description = @"Request to dispense blood product",
                            Comment = @"Status determined by Placer"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RS",
                            Description = @"Reserved (ordered and product allocated for the patient)",
                            Comment = @"Status determined by Filler"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WA",
                            Description = @"Wasted (product no longer viable)",
                            Comment = @"Status determined by Filler"
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0480
    {
        public string Id { get { return @"0480"; } }

        public string TableId { get { return @"0480"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Pharmacy Order Types"; } }

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
                            Value = @"M",
                            Description = @"Medication",
                            Comment = @"Default value. Includes, but is not limited to, tables, capsules, powders, puffs, and other non-injected/non-infused products."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other solution as medication orders",
                            Comment = @"Includes, but is not limited to, piggybacks and syringes"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"IV Large Volume Solutions",
                            Comment = @"Includes, but is not limited to, TPNs, admixtures, solutions and drips."
                        },
                        
                    };
            } 
        }
    }
}

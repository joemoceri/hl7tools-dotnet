using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0513
    {
        public string Id { get { return @"0513"; } }

        public string TableId { get { return @"0513"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Blood Product Transfusion/Disposition Status"; } }

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
                            Value = @"RA",
                            Description = @"Returned unused/no longer needed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RL",
                            Description = @"Returned unused/keep linked to patient for possible use later",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TR",
                            Description = @"Transfused with adverse reaction",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TX",
                            Description = @"Transfused",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"WA",
                            Description = @"Wasted (product no longer viable)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

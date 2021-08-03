using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0572
    {
        public string Id { get { return @"0572"; } }

        public string TableId { get { return @"0572"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Tax status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"RVAT",
                            Description = @"Registered in VAT register",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UVAT",
                            Description = @"Unregistered in VAT register",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0326
    {
        public string Id { get { return @"0326"; } }

        public string TableId { get { return @"0326"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Visit indicator"; } }

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
                            Value = @"A",
                            Description = @"Account level (default)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Visit level",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

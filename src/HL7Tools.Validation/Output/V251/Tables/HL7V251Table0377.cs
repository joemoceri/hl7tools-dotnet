using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0377
    {
        public string Id { get { return @"0377"; } }

        public string TableId { get { return @"0377"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Other environmental factors"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Value = @"A60",
                            Description = @"Opened container, indoor atmosphere, 60 minutes duration",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ATM",
                            Description = @"Opened container, atmosphere and duration unspecified",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

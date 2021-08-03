using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0450
    {
        public string Id { get { return @"0450"; } }

        public string TableId { get { return @"0450"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event Type"; } }

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
                            Value = @"LOG",
                            Description = @"Log Event",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SER",
                            Description = @"Service Event",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0173
    {
        public string Id { get { return @"0173"; } }

        public string TableId { get { return @"0173"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Coordination of Benefits"; } }

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
                            Value = @"CO",
                            Description = @"Coordination",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"IN",
                            Description = @"Independent",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

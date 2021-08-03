using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0107
    {
        public string Id { get { return @"0107"; } }

        public string TableId { get { return @"0107"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Deferred response type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Value = @"B",
                            Description = @"Before the Date/Time specified",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Later than the Date/Time specified",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

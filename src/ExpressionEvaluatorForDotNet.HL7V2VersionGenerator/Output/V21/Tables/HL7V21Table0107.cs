using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V221Table0107
    {
        public string Id { get { return @"0107"; } }

        public string TableId { get { return @"0107"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DEFERRED RESPONSE TYPE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"L",
                            Description = @"Later than the DATE/TIME specified",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

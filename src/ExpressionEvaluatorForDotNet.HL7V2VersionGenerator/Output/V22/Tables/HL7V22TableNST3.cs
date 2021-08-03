using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22TableNST3
    {
        public string Id { get { return @"NST3"; } }

        public string TableId { get { return @"NST3"; } }

        public string TableType { get { return @"Local"; } }

        public string Name { get { return @"Network Source Type"; } }

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
                            Value = @"A",
                            Description = @"Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Initiate",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

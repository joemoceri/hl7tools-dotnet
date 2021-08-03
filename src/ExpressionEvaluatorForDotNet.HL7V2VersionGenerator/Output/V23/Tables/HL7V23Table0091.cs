using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0091
    {
        public string Id { get { return @"0091"; } }

        public string TableId { get { return @"0091"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Query priority"; } }

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
                            Value = @"D",
                            Description = @"Deferred",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Immediate",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

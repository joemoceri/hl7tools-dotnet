using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0894
    {
        public string Id { get { return @"0894"; } }

        public string TableId { get { return @"0894"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Side of body"; } }

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
                            Value = @"L",
                            Description = @"Left",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Right",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

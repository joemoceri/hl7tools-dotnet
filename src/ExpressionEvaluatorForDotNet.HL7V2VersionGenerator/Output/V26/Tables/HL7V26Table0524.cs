using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0524
    {
        public string Id { get { return @"0524"; } }

        public string TableId { get { return @"0524"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Sequence condition"; } }

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
                            Value = @"C",
                            Description = @"Repeating cycle of orders",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Reserved for possible future use",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Sequence conditions",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

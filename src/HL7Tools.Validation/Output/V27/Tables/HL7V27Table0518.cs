using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0518
    {
        public string Id { get { return @"0518"; } }

        public string TableId { get { return @"0518"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Override Type"; } }

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
                            Value = @"EQV",
                            Description = @"Equivalence Override",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXTN",
                            Description = @"Extension Override",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INLV",
                            Description = @"Interval Override",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

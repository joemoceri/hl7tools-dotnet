using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0105
    {
        public string Id { get { return @"0105"; } }

        public string TableId { get { return @"0105"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Source of comment"; } }

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
                            Value = @"L",
                            Description = @"Ancillary (filler) department is source of comment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Other system is source of comment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Orderer (placer) is source of comment",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

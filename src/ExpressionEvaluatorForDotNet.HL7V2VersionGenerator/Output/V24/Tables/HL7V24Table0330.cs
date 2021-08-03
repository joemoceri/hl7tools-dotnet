using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0330
    {
        public string Id { get { return @"0330"; } }

        public string TableId { get { return @"0330"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Marketing basis"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
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
                            Value = @"510E",
                            Description = @"510 (K) exempt",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"510K",
                            Description = @"510 (K)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"522S",
                            Description = @"Post marketing study (522)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PMA",
                            Description = @"Premarketing authorization",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRE",
                            Description = @"Preamendment",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"TXN",
                            Description = @"Transitional",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

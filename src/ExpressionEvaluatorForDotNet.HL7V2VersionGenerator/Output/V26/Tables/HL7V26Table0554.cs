using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0554
    {
        public string Id { get { return @"0554"; } }

        public string TableId { get { return @"0554"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Invoice Reason Codes"; } }

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
                            Value = @"LATE",
                            Description = @"Late Invoice",
                            Comment = @"Over the Payer's published time limit for this invoice"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NORM",
                            Description = @"Normal submission",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SUB",
                            Description = @"Subscriber coverage problem",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

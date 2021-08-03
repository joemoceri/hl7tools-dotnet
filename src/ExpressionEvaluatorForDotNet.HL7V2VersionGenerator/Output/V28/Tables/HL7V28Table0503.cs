using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0503
    {
        public string Id { get { return @"0503"; } }

        public string TableId { get { return @"0503"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Sequence/Results Flag"; } }

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
                            Description = @"Cyclical",
                            Comment = @"Used for indicating a repeating cycle of service requests; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. ""Alternating IVs""). This value would be compatible with linking separate service requests or with having all cyclical service request components in a single service request. Likewise, the value would be compatible with either Parent-Child messages or a single service request message to communicate the service requests' sequencing"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Reserved for future use",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Sequential",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0236
    {
        public string Id { get { return @"0236"; } }

        public string TableId { get { return @"0236"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Event Reported To"; } }

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
                            Value = @"D",
                            Description = @"Distributor",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Local facility/user facility",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Manufacturer",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Regulatory agency",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

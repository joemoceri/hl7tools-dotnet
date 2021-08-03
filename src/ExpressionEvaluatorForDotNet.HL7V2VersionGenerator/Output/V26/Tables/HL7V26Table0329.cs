using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0329
    {
        public string Id { get { return @"0329"; } }

        public string TableId { get { return @"0329"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Quantity method"; } }

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
                            Value = @"A",
                            Description = @"Actual count",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"E",
                            Description = @"Estimated (see comment)",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

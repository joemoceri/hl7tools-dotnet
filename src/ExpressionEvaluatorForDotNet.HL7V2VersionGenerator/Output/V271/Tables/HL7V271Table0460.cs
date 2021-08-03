using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0460
    {
        public string Id { get { return @"0460"; } }

        public string TableId { get { return @"0460"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Denial or Rejection Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"0",
                            Description = @"Line item not denied or rejected",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Line item denied or rejected",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Line item is on a multiple-day claim. The line item is not denied or rejected, but occurs on a day that has been denied or rejected.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

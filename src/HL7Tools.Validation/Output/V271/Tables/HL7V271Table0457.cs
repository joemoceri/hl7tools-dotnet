using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0457
    {
        public string Id { get { return @"0457"; } }

        public string TableId { get { return @"0457"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Overall Claim Disposition Code"; } }

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
                            Description = @"No edits present on claim",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Only edits present are for line item denial or rejection",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Multiple-day claim with one or more days denied or rejected",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Claim denied, rejected, suspended or returned to provider with only post payment edits",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"Claim denied, rejected, suspended or returned to provider with only pre payment edits",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

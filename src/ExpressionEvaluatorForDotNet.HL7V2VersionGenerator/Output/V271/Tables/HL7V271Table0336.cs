using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0336
    {
        public string Id { get { return @"0336"; } }

        public string TableId { get { return @"0336"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Referral Reason"; } }

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
                            Value = @"O",
                            Description = @"Provider Ordered",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Patient Preference",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Second Opinion",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Work Load",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

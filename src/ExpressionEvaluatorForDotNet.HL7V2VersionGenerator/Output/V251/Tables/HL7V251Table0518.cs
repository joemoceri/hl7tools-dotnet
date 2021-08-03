using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0518
    {
        public string Id { get { return @"0518"; } }

        public string TableId { get { return @"0518"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Override type"; } }

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
                            Comment = @"Identifies an override where a service is being performed agains t an order that the system does not recognize as equivalent to the ordered service."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"EXTN",
                            Description = @"Extension Override",
                            Comment = @"Identifies an override where a service is being performed for longe r than the ordered period of time."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"INLV",
                            Description = @"Interval Override",
                            Comment = @"Identifies an override where a repetition of service is being performed sooner than the ordered frequency."
                        },
                    };
            } 
        }
    }
}

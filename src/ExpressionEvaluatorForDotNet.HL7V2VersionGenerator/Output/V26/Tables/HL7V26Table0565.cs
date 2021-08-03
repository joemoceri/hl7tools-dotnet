using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0565
    {
        public string Id { get { return @"0565"; } }

        public string TableId { get { return @"0565"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Provider Adjustment Reason Code"; } }

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
                            Value = @"DISP",
                            Description = @"Dispensing Fee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"GST",
                            Description = @"Goods and Services Tax",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"HST",
                            Description = @"Harmonized Sales Tax",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MKUP",
                            Description = @"Mark up Fee",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PST",
                            Description = @"Provincial Sales Tax",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0002
    {
        public string Id { get { return @"0002"; } }

        public string TableId { get { return @"0002"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"MARITAL STATUS"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Description = @"Separated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Divorced",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Married",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Single",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Widowed",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

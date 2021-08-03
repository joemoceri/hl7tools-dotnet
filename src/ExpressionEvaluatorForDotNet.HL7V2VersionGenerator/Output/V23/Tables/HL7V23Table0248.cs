using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0248
    {
        public string Id { get { return @"0248"; } }

        public string TableId { get { return @"0248"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Product source"; } }

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
                            Description = @"Actual product involved in incident was evaluated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"A product from the same lot as the actual product involved was evaluated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"A product from a controlled/non-related inventory was evaluated",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"A product from a reserve sample was evaluated",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

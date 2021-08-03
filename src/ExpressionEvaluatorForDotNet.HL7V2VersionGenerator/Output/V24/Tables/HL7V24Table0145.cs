using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0145
    {
        public string Id { get { return @"0145"; } }

        public string TableId { get { return @"0145"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Room type"; } }

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
                            Value = @"2ICU",
                            Description = @"Second intensive care unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2PRI",
                            Description = @"Second private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2SPR",
                            Description = @"Second semi-private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICU",
                            Description = @"Intensive care unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRI",
                            Description = @"Private room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPR",
                            Description = @"Semi-private room",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

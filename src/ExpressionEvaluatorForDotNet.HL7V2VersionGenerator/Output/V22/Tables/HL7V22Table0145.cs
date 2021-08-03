using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0145
    {
        public string Id { get { return @"0145"; } }

        public string TableId { get { return @"0145"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"ROOM TYPE"; } }

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
                            Description = @"Second Intensive Care Unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2PRI",
                            Description = @"Second Private Room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2SPR",
                            Description = @"Second Semi-private Room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ICU",
                            Description = @"Intensive Care Unit",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PRI",
                            Description = @"Private Room",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SPR",
                            Description = @"Semi-private Room",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

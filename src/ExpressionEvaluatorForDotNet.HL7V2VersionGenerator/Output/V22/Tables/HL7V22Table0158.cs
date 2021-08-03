using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0158
    {
        public string Id { get { return @"0158"; } }

        public string TableId { get { return @"0158"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"DATE/TIME SELECTION QUALIFIER"; } }

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
                            Value = @"1ST",
                            Description = @"First value within range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ALL",
                            Description = @"All values within the range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"LST",
                            Description = @"Last value within the range",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"REV",
                            Description = @"All values within the range returned in reverse chronological order",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

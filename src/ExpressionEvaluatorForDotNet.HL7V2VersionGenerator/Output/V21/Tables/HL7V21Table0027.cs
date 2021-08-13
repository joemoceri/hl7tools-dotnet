using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0027
    {
        public string Id { get { return @"0027"; } }

        public string TableId { get { return @"0027"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"PRIORITY (COMPONENT 6 QTY/TIMING[735])"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Description = @"ASAP. Fill after STAT orders.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Stat. Required immediately.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Timed collection",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

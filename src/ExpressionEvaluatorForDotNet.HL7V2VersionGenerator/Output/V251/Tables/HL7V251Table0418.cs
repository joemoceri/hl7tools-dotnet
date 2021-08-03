using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0418
    {
        public string Id { get { return @"0418"; } }

        public string TableId { get { return @"0418"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Procedure Priority"; } }

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
                            Description = @"the admitting procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"the primary procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2 …",
                            Description = @"for ranked secondary procedures",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0179
    {
        public string Id { get { return @"0179"; } }

        public string TableId { get { return @"0179"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"RESPONSE LEVEL"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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
                            Value = @"AL",
                            Description = @"Always",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"ER",
                            Description = @"Error / reject conditions only",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NE",
                            Description = @"Never - no application level response needed",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Success",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

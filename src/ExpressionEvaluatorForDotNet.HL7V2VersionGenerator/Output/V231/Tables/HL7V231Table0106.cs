using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0106
    {
        public string Id { get { return @"0106"; } }

        public string TableId { get { return @"0106"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Query/response format code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",
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
                            Value = @"D",
                            Description = @"Response is in display format",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Response is in record-oriented format",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"T",
                            Description = @"Response is in tabular format",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

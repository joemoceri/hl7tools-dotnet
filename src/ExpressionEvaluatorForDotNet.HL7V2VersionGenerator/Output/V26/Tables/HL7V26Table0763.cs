using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0763
    {
        public string Id { get { return @"0763"; } }

        public string TableId { get { return @"0763"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DRG Procedure Relevance"; } }

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
                            Description = @"Neither operation relevant nor non-operation relevant procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"1",
                            Description = @"Operation relevant procedure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Non-operation relevant procedure",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

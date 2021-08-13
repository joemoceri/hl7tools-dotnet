using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0423
    {
        public string Id { get { return @"0423"; } }

        public string TableId { get { return @"0423"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Case category code"; } }

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
                            Value = @"D",
                            Description = @"Doctor’s Office Closed",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

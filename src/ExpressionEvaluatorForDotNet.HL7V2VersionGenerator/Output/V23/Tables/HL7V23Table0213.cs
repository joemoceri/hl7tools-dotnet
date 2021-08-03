using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0213
    {
        public string Id { get { return @"0213"; } }

        public string TableId { get { return @"0213"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Purge status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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
                            Description = @"The visit is marked for deletion and the user cannot enter new data against it.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"The visit is marked inactive and the user cannot enter new data against it.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Marked for purge. User is no longer able to update the visit.",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

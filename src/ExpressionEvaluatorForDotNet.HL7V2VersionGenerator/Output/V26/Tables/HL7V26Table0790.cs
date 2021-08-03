using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0790
    {
        public string Id { get { return @"0790"; } }

        public string TableId { get { return @"0790"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Approving Regulatory Agency"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",
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
                            Value = @"AMA",
                            Description = @"American Medical Association",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"FDA",
                            Description = @"Food and Drug Administration",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

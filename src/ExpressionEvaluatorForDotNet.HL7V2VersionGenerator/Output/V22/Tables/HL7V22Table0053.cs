using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0053
    {
        public string Id { get { return @"0053"; } }

        public string TableId { get { return @"0053"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DIAGNOSIS CODING METHOD"; } }

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
                            Value = @"I9",
                            Description = @"ICD9",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0312
    {
        public string Id { get { return @"0312"; } }

        public string TableId { get { return @"0312"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Policy Scope"; } }

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
                return null;
            } 
        }
    }
}

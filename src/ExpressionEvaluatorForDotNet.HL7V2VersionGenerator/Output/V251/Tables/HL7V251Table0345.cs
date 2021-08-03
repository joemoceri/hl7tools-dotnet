using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0345
    {
        public string Id { get { return @"0345"; } }

        public string TableId { get { return @"0345"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Appeal Reason"; } }

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

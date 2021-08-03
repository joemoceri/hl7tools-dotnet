using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0063
    {
        public string Id { get { return @"0063"; } }

        public string TableId { get { return @"0063"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"RELATIONSHIP"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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

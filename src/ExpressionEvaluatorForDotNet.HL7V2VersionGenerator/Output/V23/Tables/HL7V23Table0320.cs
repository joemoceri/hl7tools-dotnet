using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0320
    {
        public string Id { get { return @"0320"; } }

        public string TableId { get { return @"0320"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Item natural account code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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

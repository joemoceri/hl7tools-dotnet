using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0313
    {
        public string Id { get { return @"0313"; } }

        public string TableId { get { return @"0313"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Policy source"; } }

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

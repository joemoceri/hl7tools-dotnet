using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0471
    {
        public string Id { get { return @"0471"; } }

        public string TableId { get { return @"0471"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Query name"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

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

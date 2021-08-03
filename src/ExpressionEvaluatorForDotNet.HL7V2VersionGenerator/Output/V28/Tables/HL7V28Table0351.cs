using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0351
    {
        public string Id { get { return @"0351"; } }

        public string TableId { get { return @"0351"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Occurrence Span"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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

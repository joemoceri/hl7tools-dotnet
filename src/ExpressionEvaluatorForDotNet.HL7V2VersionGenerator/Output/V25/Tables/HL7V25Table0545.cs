using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0545
    {
        public string Id { get { return @"0545"; } }

        public string TableId { get { return @"0545"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Language Translated To"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",
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

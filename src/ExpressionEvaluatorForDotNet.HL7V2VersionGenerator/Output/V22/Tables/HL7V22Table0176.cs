using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V222Table0176
    {
        public string Id { get { return @"0176"; } }

        public string TableId { get { return @"0176"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"MASTER FILE APPLICATION IDENTIFIER"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
"CH_08",
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

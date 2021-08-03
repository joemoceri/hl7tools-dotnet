using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0336
    {
        public string Id { get { return @"0336"; } }

        public string TableId { get { return @"0336"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Referral reason"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",
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

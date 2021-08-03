using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0342
    {
        public string Id { get { return @"0342"; } }

        public string TableId { get { return @"0342"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Dependent of military recipient"; } }

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

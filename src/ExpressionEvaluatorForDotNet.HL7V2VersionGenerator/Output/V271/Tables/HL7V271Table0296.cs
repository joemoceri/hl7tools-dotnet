using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2271Table0296
    {
        public string Id { get { return @"0296"; } }

        public string TableId { get { return @"0296"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Primary Language"; } }

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

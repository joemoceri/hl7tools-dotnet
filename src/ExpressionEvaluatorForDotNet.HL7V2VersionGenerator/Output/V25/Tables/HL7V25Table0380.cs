using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0380
    {
        public string Id { get { return @"0380"; } }

        public string TableId { get { return @"0380"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Separator type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",
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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2231Table0215
    {
        public string Id { get { return @"0215"; } }

        public string TableId { get { return @"0215"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Publicity code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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

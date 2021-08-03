using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0114
    {
        public string Id { get { return @"0114"; } }

        public string TableId { get { return @"0114"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Diet Type"; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0381
    {
        public string Id { get { return @"0381"; } }

        public string TableId { get { return @"0381"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Cap type"; } }

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

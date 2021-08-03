using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V223Table0130
    {
        public string Id { get { return @"0130"; } }

        public string TableId { get { return @"0130"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Visit user code"; } }

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

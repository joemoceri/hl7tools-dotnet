using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0063
    {
        public string Id { get { return @"0063"; } }

        public string TableId { get { return @"0063"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Relationship"; } }

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

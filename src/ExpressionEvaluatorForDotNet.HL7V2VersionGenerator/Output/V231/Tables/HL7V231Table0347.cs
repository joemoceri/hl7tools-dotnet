using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0347
    {
        public string Id { get { return @"0347"; } }

        public string TableId { get { return @"0347"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Auto accident state"; } }

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

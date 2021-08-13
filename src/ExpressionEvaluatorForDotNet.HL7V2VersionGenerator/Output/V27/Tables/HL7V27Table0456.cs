using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0456
    {
        public string Id { get { return @"0456"; } }

        public string TableId { get { return @"0456"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Revenue code"; } }

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

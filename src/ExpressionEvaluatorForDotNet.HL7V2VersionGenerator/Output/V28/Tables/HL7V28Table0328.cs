using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0328
    {
        public string Id { get { return @"0328"; } }

        public string TableId { get { return @"0328"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Employee Classification"; } }

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0414
    {
        public string Id { get { return @"0414"; } }

        public string TableId { get { return @"0414"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Units of time"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",
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

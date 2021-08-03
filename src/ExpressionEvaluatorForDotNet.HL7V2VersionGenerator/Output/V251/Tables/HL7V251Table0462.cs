using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V2251Table0462
    {
        public string Id { get { return @"0462"; } }

        public string TableId { get { return @"0462"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Location cost center"; } }

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

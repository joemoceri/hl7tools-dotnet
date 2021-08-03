using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0044
    {
        public string Id { get { return @"0044"; } }

        public string TableId { get { return @"0044"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"CONTRACT CODE"; } }

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

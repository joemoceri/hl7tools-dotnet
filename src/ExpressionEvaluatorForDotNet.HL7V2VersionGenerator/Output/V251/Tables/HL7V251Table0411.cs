using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0411
    {
        public string Id { get { return @"0411"; } }

        public string TableId { get { return @"0411"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Supplemental Service Information Values"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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

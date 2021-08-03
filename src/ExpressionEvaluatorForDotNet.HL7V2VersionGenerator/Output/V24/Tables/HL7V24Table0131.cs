using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0131
    {
        public string Id { get { return @"0131"; } }

        public string TableId { get { return @"0131"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Contact role"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
"CH_11",
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

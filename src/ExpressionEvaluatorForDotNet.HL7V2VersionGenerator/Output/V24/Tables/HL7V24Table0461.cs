using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0461
    {
        public string Id { get { return @"0461"; } }

        public string TableId { get { return @"0461"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"License number"; } }

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

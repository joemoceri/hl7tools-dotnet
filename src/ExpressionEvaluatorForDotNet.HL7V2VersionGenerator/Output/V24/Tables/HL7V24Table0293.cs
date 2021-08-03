using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V224Table0293
    {
        public string Id { get { return @"0293"; } }

        public string TableId { get { return @"0293"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Billing category"; } }

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

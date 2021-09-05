using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0171
    {
        public string Id { get { return @"0171"; } }

        public string TableId { get { return @"0171"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Citizenship"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

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

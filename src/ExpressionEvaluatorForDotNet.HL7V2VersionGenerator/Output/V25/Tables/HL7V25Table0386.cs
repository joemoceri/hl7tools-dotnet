using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0386
    {
        public string Id { get { return @"0386"; } }

        public string TableId { get { return @"0386"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Supplier identifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0385
    {
        public string Id { get { return @"0385"; } }

        public string TableId { get { return @"0385"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Manufacturer identifier"; } }

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

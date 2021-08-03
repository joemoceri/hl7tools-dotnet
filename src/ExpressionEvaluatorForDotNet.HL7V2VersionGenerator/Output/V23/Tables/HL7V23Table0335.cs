using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0335
    {
        public string Id { get { return @"0335"; } }

        public string TableId { get { return @"0335"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Repeat pattern"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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

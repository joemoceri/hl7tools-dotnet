using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0118
    {
        public string Id { get { return @"0118"; } }

        public string TableId { get { return @"0118"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Major Diagnostic Category"; } }

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

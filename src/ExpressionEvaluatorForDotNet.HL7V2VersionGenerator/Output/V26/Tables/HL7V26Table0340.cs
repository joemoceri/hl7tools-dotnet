using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0340
    {
        public string Id { get { return @"0340"; } }

        public string TableId { get { return @"0340"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Procedure Code Modifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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

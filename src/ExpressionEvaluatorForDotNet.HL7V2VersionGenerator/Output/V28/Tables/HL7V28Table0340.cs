using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0340
    {
        public string Id { get { return @"0340"; } }

        public string TableId { get { return @"0340"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Procedure Code Modifier"; } }

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

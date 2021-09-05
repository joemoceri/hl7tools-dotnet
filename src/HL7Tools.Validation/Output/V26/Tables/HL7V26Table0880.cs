using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0880
    {
        public string Id { get { return @"0880"; } }

        public string TableId { get { return @"0880"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Product/Service Code Modifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",

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

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0084
    {
        public string Id { get { return @"0084"; } }

        public string TableId { get { return @"0084"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"PERFORMED BY CODE"; } }

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

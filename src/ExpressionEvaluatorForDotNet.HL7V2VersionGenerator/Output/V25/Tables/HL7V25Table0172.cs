using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0172
    {
        public string Id { get { return @"0172"; } }

        public string TableId { get { return @"0172"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Veterans Military Status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",
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

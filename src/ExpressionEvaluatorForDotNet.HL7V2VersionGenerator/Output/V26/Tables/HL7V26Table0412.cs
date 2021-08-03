using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0412
    {
        public string Id { get { return @"0412"; } }

        public string TableId { get { return @"0412"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Category Identifier"; } }

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

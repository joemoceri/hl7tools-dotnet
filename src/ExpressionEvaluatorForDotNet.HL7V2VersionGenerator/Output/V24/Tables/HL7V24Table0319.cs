using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0319
    {
        public string Id { get { return @"0319"; } }

        public string TableId { get { return @"0319"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Department cost center"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",
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

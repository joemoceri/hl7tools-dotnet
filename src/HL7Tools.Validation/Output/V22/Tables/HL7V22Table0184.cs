using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22Table0184
    {
        public string Id { get { return @"0184"; } }

        public string TableId { get { return @"0184"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"DEPARTMENT"; } }

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

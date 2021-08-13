using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0479
    {
        public string Id { get { return @"0479"; } }

        public string TableId { get { return @"0479"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Pharmaceutical Substances"; } }

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

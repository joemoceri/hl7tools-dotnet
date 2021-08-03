using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0188
    {
        public string Id { get { return @"0188"; } }

        public string TableId { get { return @"0188"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Operator ID"; } }

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

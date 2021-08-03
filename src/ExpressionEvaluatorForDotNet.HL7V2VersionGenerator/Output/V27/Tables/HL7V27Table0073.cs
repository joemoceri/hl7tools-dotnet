using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0073
    {
        public string Id { get { return @"0073"; } }

        public string TableId { get { return @"0073"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Interest Rate Code"; } }

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

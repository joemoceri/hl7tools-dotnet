using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0043
    {
        public string Id { get { return @"0043"; } }

        public string TableId { get { return @"0043"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Condition Code"; } }

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

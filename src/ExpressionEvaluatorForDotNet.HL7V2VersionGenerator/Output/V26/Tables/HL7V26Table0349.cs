using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0349
    {
        public string Id { get { return @"0349"; } }

        public string TableId { get { return @"0349"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"PSRO/UR Approval Indicator"; } }

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

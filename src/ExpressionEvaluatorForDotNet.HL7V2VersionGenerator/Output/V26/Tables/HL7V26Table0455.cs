using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0455
    {
        public string Id { get { return @"0455"; } }

        public string TableId { get { return @"0455"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Type of Bill Code"; } }

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

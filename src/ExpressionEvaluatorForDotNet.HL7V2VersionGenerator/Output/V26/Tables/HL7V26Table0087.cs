using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0087
    {
        public string Id { get { return @"0087"; } }

        public string TableId { get { return @"0087"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Pre-Admit Test Indicator"; } }

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

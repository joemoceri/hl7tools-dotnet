using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0526
    {
        public string Id { get { return @"0526"; } }

        public string TableId { get { return @"0526"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Privilege class"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",
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
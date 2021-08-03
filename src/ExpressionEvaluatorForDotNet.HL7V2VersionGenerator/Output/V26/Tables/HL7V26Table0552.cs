using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0552
    {
        public string Id { get { return @"0552"; } }

        public string TableId { get { return @"0552"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Advanced beneficiary notice override reason"; } }

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

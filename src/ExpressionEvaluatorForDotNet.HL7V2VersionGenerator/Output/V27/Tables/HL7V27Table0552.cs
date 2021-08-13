using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0552
    {
        public string Id { get { return @"0552"; } }

        public string TableId { get { return @"0552"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Advanced Beneficiary Notice Override Reason"; } }

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

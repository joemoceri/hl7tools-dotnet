using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V28Table0917
    {
        public string Id { get { return @"0917"; } }

        public string TableId { get { return @"0917"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Bolus Type"; } }

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
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"C",
                            Description = @"Supplemental",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Loading",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

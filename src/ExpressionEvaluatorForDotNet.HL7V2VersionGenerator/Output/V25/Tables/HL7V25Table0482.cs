using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V225Table0482
    {
        public string Id { get { return @"0482"; } }

        public string TableId { get { return @"0482"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Order Type"; } }

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
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inpatient Order",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"O",
                            Description = @"Outpatient Order",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

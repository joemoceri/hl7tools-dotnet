using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0505
    {
        public string Id { get { return @"0505"; } }

        public string TableId { get { return @"0505"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Cyclic Entry/Exit Indicator"; } }

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
                            Value = @"#",
                            Description = @"The last service request in a cyclic group.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"*",
                            Description = @"The first service request in a cyclic group",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

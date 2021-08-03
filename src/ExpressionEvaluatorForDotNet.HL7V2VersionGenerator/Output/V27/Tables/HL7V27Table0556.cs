using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0556
    {
        public string Id { get { return @"0556"; } }

        public string TableId { get { return @"0556"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Benefit Group"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_16",
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
                            Value = @"AMB",
                            Description = @"AMBULATORY CARE",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DENT",
                            Description = @"DENTAL",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

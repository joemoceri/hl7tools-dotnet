using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0492
    {
        public string Id { get { return @"0492"; } }

        public string TableId { get { return @"0492"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Specimen Appropriateness"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

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
                            Value = @"??",
                            Description = @"Inappropriate due to _",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"A",
                            Description = @"Appropriate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Inappropriate",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preferred",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

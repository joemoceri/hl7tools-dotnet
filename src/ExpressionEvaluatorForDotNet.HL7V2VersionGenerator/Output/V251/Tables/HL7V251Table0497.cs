using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251Table0497
    {
        public string Id { get { return @"0497"; } }

        public string TableId { get { return @"0497"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Consent Mode"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Value = @"T",
                            Description = @"Telephone",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"V",
                            Description = @"Verbal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"W",
                            Description = @"Written",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

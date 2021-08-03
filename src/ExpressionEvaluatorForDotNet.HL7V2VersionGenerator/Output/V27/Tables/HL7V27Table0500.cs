using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0500
    {
        public string Id { get { return @"0500"; } }

        public string TableId { get { return @"0500"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Consent Disclosure Level"; } }

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
                            Value = @"F",
                            Description = @"Full Disclosure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"No Disclosure",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Partial Disclosure",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

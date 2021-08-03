using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V228Table0920
    {
        public string Id { get { return @"0920"; } }

        public string TableId { get { return @"0920"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Preferred Specimen/Attribute Status"; } }

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
                            Value = @"A",
                            Description = @"Alternate",
                            Comment = @"This is a specimen that is acceptable as a replacement for a preferred specimen.  In the following field (OM4-17), the sequence number of the preferred specimen must be messaged."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Preferred",
                            Comment = @"This specimen is Preferred for all attributes (Container and Additive) identified in the OM4 segment."
                        },
                    };
            } 
        }
    }
}

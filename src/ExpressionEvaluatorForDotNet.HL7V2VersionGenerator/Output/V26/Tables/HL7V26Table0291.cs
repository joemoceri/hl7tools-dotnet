using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V226Table0291
    {
        public string Id { get { return @"0291"; } }

        public string TableId { get { return @"0291"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Subtype of referenced data"; } }

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
                            Value = @"x-hl7-cda-level-one",
                            Description = @"HL7 Clinical Document Architecture Level One document",
                            Comment = @"Retained for backwards compatibility only as of v2.6 and CDA R 2. Preferred value is text/xml."
                        },
                    };
            } 
        }
    }
}

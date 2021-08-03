using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V227Table0291
    {
        public string Id { get { return @"0291"; } }

        public string TableId { get { return @"0291"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Subtype of Referenced Data"; } }

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
                            Comment = null
                        },
                    };
            } 
        }
    }
}

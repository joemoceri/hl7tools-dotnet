using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0547
    {
        public string Id { get { return @"0547"; } }

        public string TableId { get { return @"0547"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Jurisdictional Breadth"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",
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
                            Description = @"County/Parish",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Country",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"State/Province",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

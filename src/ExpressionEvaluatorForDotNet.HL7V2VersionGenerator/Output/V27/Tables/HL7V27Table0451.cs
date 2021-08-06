using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0451
    {
        public string Id { get { return @"0451"; } }

        public string TableId { get { return @"0451"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Substance Identifier"; } }

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
                            Value = @"ALL",
                            Description = @"Used for query of all inventory items",
                            Comment = null
                        },
                    };
            } 
        }
    }
}
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0171
    {
        public string Id { get { return @"0171"; } }

        public string TableId { get { return @"0171"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Country Code"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
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
                            Value = @"D",
                            Description = @"Germany",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

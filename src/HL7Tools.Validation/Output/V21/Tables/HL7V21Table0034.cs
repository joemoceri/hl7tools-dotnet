using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0034
    {
        public string Id { get { return @"0034"; } }

        public string TableId { get { return @"0034"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"SITE ADMINISTERED"; } }

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
                            Value = @"B",
                            Description = @"Buttock",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"L",
                            Description = @"Left arm",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

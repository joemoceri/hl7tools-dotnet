using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0061
    {
        public string Id { get { return @"0061"; } }

        public string TableId { get { return @"0061"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"CHECK DIGIT SCHEME"; } }

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
                            Value = @"M11",
                            Description = @"Mod 11 check digit scheme",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

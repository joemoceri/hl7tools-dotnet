using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0274
    {
        public string Id { get { return @"0274"; } }

        public string TableId { get { return @"0274"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Document Modification Status"; } }

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
                            Value = @"IN",
                            Description = @"Incremental",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RP",
                            Description = @"Replacement",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

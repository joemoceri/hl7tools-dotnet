using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0273
    {
        public string Id { get { return @"0273"; } }

        public string TableId { get { return @"0273"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Document availability status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_09",

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
                            Value = @"AV",
                            Description = @"Available for patient care",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"UN",
                            Description = @"Unavailable for patient care",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

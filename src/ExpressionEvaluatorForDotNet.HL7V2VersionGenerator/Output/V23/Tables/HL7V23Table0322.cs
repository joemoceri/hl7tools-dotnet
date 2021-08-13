using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0322
    {
        public string Id { get { return @"0322"; } }

        public string TableId { get { return @"0322"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Completion status"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

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
                            Value = @"CP",
                            Description = @"Complete",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"NA",
                            Description = @"Not Administered",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PA",
                            Description = @"Partially Administered",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"RE",
                            Description = @"Refused",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23Table0149
    {
        public string Id { get { return @"0149"; } }

        public string TableId { get { return @"0149"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Day type"; } }

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
                            Value = @"AP",
                            Description = @"Approved",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DE",
                            Description = @"Denied",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"PE",
                            Description = @"Pending",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

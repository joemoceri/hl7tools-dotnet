using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0466
    {
        public string Id { get { return @"0466"; } }

        public string TableId { get { return @"0466"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Ambulatory payment classification"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",
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
                            Value = @"163",
                            Description = @"Excision/biopsy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"181",
                            Description = @"Level 1 skin repair.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"31",
                            Description = @"Dental procedures",
                            Comment = null
                        },
                    };
            } 
        }
    }
}

using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0397
    {
        public string Id { get { return @"0397"; } }

        public string TableId { get { return @"0397"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Sequencing"; } }

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
                            Value = @"A",
                            Description = @"Ascending",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"AN",
                            Description = @"Ascending, case insensitive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Descending",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"DN",
                            Description = @"Descending, case insensitive",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"None",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
